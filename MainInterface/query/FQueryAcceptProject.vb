

Public Class FQueryAcceptProject
    Inherits FQueryBase

    Private dtStaff As DataTable

    Protected Overloads Sub GetCondition(ByRef ProjectCode As String, ByRef CorName As String, _
                ByRef ServiceType As String, ByRef BankName As String, ByRef Area As String, ByRef strAcceptBranch As String, ByRef strPMA As String)
        ProjectCode = txtProjectCode.Text.Trim
        CorName = txtCorpName.Text.Trim
        ServiceType = cboServiceType.Text.Trim
        BankName = cboBank.Text.Trim
        Area = cboArea.Text.Trim

        If cboAcceptBranch.Visible = True Then
            strAcceptBranch = Trim(cboAcceptBranch.Text)
        Else
            strAcceptBranch = ""
        End If

        strPMA = cboPMA.Text.Trim

    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim StartDate, EndDate As Object
        Dim i As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable

        StartDate = IIf(chkDate.Checked, dtpStartDate.Value.Date, Nothing)
        EndDate = IIf(chkDate.Checked, dtpEndDate.Value.Date, Nothing)
        If chkDate.Checked AndAlso DateTime.Parse(StartDate).Date > DateTime.Parse(EndDate).Date Then
            SWDialogBox.MessageBox.Show("$1008", "��ʼ����", "��ֹ����")
            'MessageBox.Show("��ֹ����Ӧ������ʼ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndDate.Value = dtpStartDate.Value.Date
            Return
        End If
        Dim ProjectCode, CorName, ServiceType, BankName, Area, strAcceptBranch, strPMA As String
        GetCondition(ProjectCode, CorName, ServiceType, BankName, Area, strAcceptBranch, strPMA)
        dtResult = gWs.FQueryAcceptProject(ProjectCode, CorName, ServiceType, StartDate, EndDate, BankName, Area, strAcceptBranch, strPMA, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            'iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("apply_sum"))
            If Not dtResult.Rows(i).Item("apply_sum") Is System.DBNull.Value Then
                iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("apply_sum"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "�ϼƣ�"
            .Item("apply_sum") = iTotalSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "������" & i
        End With
        dtResult.Rows.Add(drRow)

        'dtResult.TableName = "TQueryAcceptProject"
        'grdTable.DataMember = "TQueryAcceptProject"
        MyBase.DataSource = dtResult
        Me.grdTable.DataSource = dtResult
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpStartDate.Enabled = chkDate.Checked
        dtpEndDate.Enabled = chkDate.Checked
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'ReportFile = Application.StartupPath & "\Reports\QueryAcceptProject.rpt"
        'ReportTitle = "��ʽ������Ŀһ����"

        '''''''''''''''''��ҵ����'''''''''''''''''''''''''
        'Dim ds As DataSet = gWs.GetcorporationInfo("%", "null")
        'cboCorName.DataSource = ds.Tables("corporation")
        'cboCorName.DisplayMember = "corporation_name"
        'cboCorName.ValueMember = "corporation_name"
        ''''''''''''''''ҵ��Ʒ��''''''''''''''''
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        'cboServiceType.SelectedIndex = -1
        'cboServiceType.SelectedItem = Nothing
        '''''''''''''''��������''''''''''''''''''
        Dim dsArea As DataSet = gWs.GetDistrict("%")
        cboArea.DataSource = dsArea.Tables(0)
        cboArea.DisplayMember = "district_name"
        cboArea.ValueMember = "district_name"
        'cboArea.SelectedIndex = -1
        '''''''''''''��������'''''''''''''''
        Dim dsBank As DataSet ' = gWs.GetBankInfo("{0=0 order by bank_name}", "null")
        'qxd modify 2005-10-21 ͨ���洢ʵ���˰�������������
        dsBank = gWs.GetBankInfo("%", "%")

        cboBank.DataSource = dsBank.Tables("bank")
        cboBank.DisplayMember = "bank_name"
        cboBank.ValueMember = "bank_name"
        'cboBank.SelectedIndex = -1
        'cboBank.SelectedItem = Nothing

        cboPMA.DataSource = gWs.GetStaff("{not team_name is null}").Tables(0)

        ' Added by Andy on 12/2/2003,to list the accepted part
        Dim dtAcceptBranch As DataTable = gWs.GetBranch("{is_island=1}").Tables(0)
        If dtAcceptBranch.Rows.Count > 1 Then
            lblAcceptBranch.Visible = True
            cboAcceptBranch.Visible = True
            cboAcceptBranch.DataSource = dtAcceptBranch
        Else
            lblAcceptBranch.Visible = False
            cboAcceptBranch.Visible = False
        End If
        ' Ended by Andy

        AddTableStyle()

        Dim SystemDate As Date = gWs.GetSysTime
        dtpStartDate.Value = SystemDate.Date : dtpEndDate.Value = SystemDate.Date

        AddHandler cboPMA.SelectedValueChanged, AddressOf cmbStaffSelectedValueChanged
    End Sub

    Private Sub cmbStaffSelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If dtStaff Is Nothing Then
            Try
                dtStaff = gWs.GetStaff("%").Tables(0)
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If

        Try
            Dim strFilter As String = "staff_name='" & Me.cboPMA.Text.Trim & "'"
            Dim dr() As DataRow = dtStaff.Select(strFilter)
            If dr.Length > 0 Then
                Me.cboAcceptBranch.Text = dr(0).Item("branch_name")
            Else
                Me.cboAcceptBranch.Text = ""
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "project_code"
        col1.HeaderText = "��Ŀ���"
        col1.Width = 65
        col1.NullText = ""
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "enterprise_name"
        col2.HeaderText = "��ҵ����"
        col2.Width = 140
        col2.NullText = ""
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "district_name"
        col3.HeaderText = "��������"
        col3.NullText = ""
        col3.Width = 85
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "accept_time"
        col4.HeaderText = "��ʽ��������"
        col4.Width = 100
        col4.Format = "yyyy-MM-dd"
        col4.NullText = ""
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "apply_service_type"
        col5.HeaderText = "����ҵ��Ʒ��"
        col5.NullText = ""
        col5.Width = 110
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "apply_sum"
        col6.HeaderText = "���뵣�����(��Ԫ)"
        col6.Width = 120
        'col6.Format = "n" ': col6.FormatInfo = CGFormatInfo
        col6.NullText = ""
        col6.Alignment = HorizontalAlignment.Right
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "apply_term"
        col7.HeaderText = "���뵣������(��)"
        col7.Width = 100
        col7.NullText = ""
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "apply_bank"
        col8.HeaderText = "�����������"
        col8.NullText = ""
        col8.Width = 130
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "ApplyDate"
        col12.HeaderText = "��������"
        col12.Width = 80
        col12.Format = "yyyy-MM-dd"
        col12.NullText = ""
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "recommend_person"
        col9.HeaderText = "�Ƽ���"
        col9.Width = 85
        col9.NullText = ""
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col10.MappingName = "accept_person"
        col10.HeaderText = "����������Ա"
        col10.Width = 70
        col10.NullText = ""
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col11.MappingName = "review_person"
        col11.HeaderText = "������Ա"
        col11.Width = 70
        col11.NullText = ""
        Dim col13 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col13.MappingName = "branch_name"
        col13.HeaderText = "���β���"
        If cboAcceptBranch.Visible = True Then
            col13.Width = 70
        Else
            col13.Width = 0
        End If
        col13.NullText = ""
        Dim col14 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col14.MappingName = "manager_A"
        col14.HeaderText = "��Ŀ����A��"
        col14.Width = 80
        col14.NullText = ""
        Dim col15 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col15.MappingName = "manager_B"
        col15.HeaderText = "��Ŀ����B��"
        col15.Width = 80
        col15.NullText = ""

        Dim col16 As DataGridBoolColumn = New DataGridBoolColumn
        col16.MappingName = "is_first_loan"
        col16.FalseValue = False
        col16.HeaderText = "�״δ���"
        col16.Width = 60
        col16.NullText = ""
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col5, col6, col7, col4, col8, col9, col10, col11, col12, col13, col14, col15, col16})
        grdTable.TableStyles.Add(dgts)
    End Sub

    'Protected Overrides Sub Clear()

    '    If Not Me.IsHandleCreated Then
    '        Return
    '    End If

    '    Dim control As Control

    '    For Each control In grpCondition.Controls
    '        If control.GetType() Is GetType(TextBox) Then
    '            control.Text = ""
    '        End If
    '        If control.GetType() Is GetType(ComboBox) Then
    '            CType(control, ComboBox).SelectedIndex = -1
    '            CType(control, ComboBox).SelectedItem = Nothing
    '        End If
    '        If control.GetType() Is GetType(CheckBox) Then
    '            CType(control, CheckBox).Checked = False
    '        End If
    '    Next
    'End Sub

    Protected Overrides Sub Export()
        ReportToExcel.ToExcel(Me.grdTable, "��ʽ������Ŀһ����", "��ʽ������Ŀһ����")
    End Sub

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents cboAcceptBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lblAcceptBranch As System.Windows.Forms.Label
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.lblAcceptBranch = New System.Windows.Forms.Label()
        Me.cboAcceptBranch = New System.Windows.Forms.ComboBox()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 128)
        Me.btnClear.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(656, 128)
        Me.btnExit.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(552, 112)
        Me.btnPrint.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 128)
        Me.chkVisible.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboAcceptBranch, Me.lblAcceptBranch, Me.txtCorpName, Me.Label4, Me.dtpEndDate, Me.chkDate, Me.cboBank, Me.cboArea, Me.cboServiceType, Me.dtpStartDate, Me.txtProjectCode, Me.Label7, Me.Label5, Me.Label3, Me.Label2, Me.Label1, Me.cboPMA, Me.Label8})
        Me.grpCondition.Size = New System.Drawing.Size(736, 104)
        Me.grpCondition.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 168)
        Me.grdTable.Size = New System.Drawing.Size(736, 320)
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(464, 128)
        Me.btnRefresh.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(560, 128)
        Me.btnExport.Visible = True
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(8, 67)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(104, 20)
        Me.chkDate.TabIndex = 28
        Me.chkDate.Text = "��ʽ��������"
        '
        'cboBank
        '
        Me.cboBank.Location = New System.Drawing.Point(328, 40)
        Me.cboBank.MaxLength = 20
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(112, 20)
        Me.cboBank.TabIndex = 27
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(112, 40)
        Me.cboArea.MaxLength = 20
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(136, 20)
        Me.cboArea.TabIndex = 25
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(520, 16)
        Me.cboServiceType.MaxLength = 20
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(140, 20)
        Me.cboServiceType.TabIndex = 24
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(112, 67)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpStartDate.TabIndex = 23
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(112, 16)
        Me.txtProjectCode.MaxLength = 11
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(136, 21)
        Me.txtProjectCode.TabIndex = 21
        Me.txtProjectCode.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(56, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "��������"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(272, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "��������"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(464, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ҵ��Ʒ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(272, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "��ҵ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "��Ŀ���" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(328, 67)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(304, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(328, 16)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(112, 21)
        Me.txtCorpName.TabIndex = 33
        Me.txtCorpName.Text = ""
        '
        'lblAcceptBranch
        '
        Me.lblAcceptBranch.Location = New System.Drawing.Point(464, 42)
        Me.lblAcceptBranch.Name = "lblAcceptBranch"
        Me.lblAcceptBranch.Size = New System.Drawing.Size(64, 16)
        Me.lblAcceptBranch.TabIndex = 34
        Me.lblAcceptBranch.Text = "����ֲ�"
        '
        'cboAcceptBranch
        '
        Me.cboAcceptBranch.DisplayMember = "branch_name"
        Me.cboAcceptBranch.Location = New System.Drawing.Point(520, 40)
        Me.cboAcceptBranch.MaxLength = 20
        Me.cboAcceptBranch.Name = "cboAcceptBranch"
        Me.cboAcceptBranch.Size = New System.Drawing.Size(140, 20)
        Me.cboAcceptBranch.TabIndex = 35
        Me.cboAcceptBranch.ValueMember = "branch_name"
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Location = New System.Drawing.Point(520, 67)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(142, 20)
        Me.cboPMA.TabIndex = 109
        Me.cboPMA.ValueMember = "staff_name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(456, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "��Ŀ����A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FQueryAcceptProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(752, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryAcceptProject"
        Me.Text = "��ʽ������Ŀһ����"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


End Class
