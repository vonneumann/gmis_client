

Public Class FQuerySignProject
    Inherits FQueryBase
    Private dsBank As DataSet

    Protected Overloads Sub GetCondition(ByRef ProjectCode As String, ByRef CorName As String, _
         ByRef CorType As String, ByRef ServiceType As String, ByRef MA As String, ByRef BankName As String, _
         ByRef SubBank As String, ByRef Area As String, ByRef IndustrT As String)
        ProjectCode = txtProjectCode.Text.Trim
        CorName = txtCorpName.Text.Trim
        CorType = cboCorType.Text.Trim
        ServiceType = cboServiceType.Text.Trim
        MA = cboMA.Text.Trim
        BankName = cboBank.Text.Trim
        SubBank = cboSubBank.Text.Trim
        Area = cboArea.Text.Trim
        IndustrT = cboIndustryType.Text.Trim
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim StartDate, EndDate As Object
        Dim i As Integer
        Dim iTotalSum, iTotalRefundAverageSum As Decimal
        Dim dtResult As DataTable

        StartDate = IIf(chkDate.Checked, dtpStartDate.Value.Date, Nothing)
        EndDate = IIf(chkDate.Checked, dtpEndDate.Value.Date, Nothing)
        If chkDate.Checked AndAlso DateTime.Parse(StartDate).Date > DateTime.Parse(EndDate).Date Then
            SWDialogBox.MessageBox.Show("$1008", "��ʼ����", "��ֹ����")
            'MessageBox.Show("��ֹ����Ӧ������ʼ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndDate.Value = dtpStartDate.Value.Date
            Return
        End If
        Dim PC, CorName, CorType, SerT, MA, BankName, SubBank, Area, IndustrT As String  'IndustrT ������ҵ��CorType ����������
        GetCondition(PC, CorName, CorType, SerT, MA, BankName, SubBank, Area, IndustrT)
        dtResult = gWs.FQuerySignProject(PC, CorName, SerT, StartDate, EndDate, Area, IndustrT, CorType, MA, BankName, SubBank, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not IsDBNull(dtResult.Rows(i).Item("guarantee_sum")) Then
                iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("guarantee_sum"))
            End If
            If Not IsDBNull(dtResult.Rows(i).Item("refund_sum_average")) Then
                iTotalRefundAverageSum = iTotalRefundAverageSum + CDec(dtResult.Rows(i).Item("refund_sum_average"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "�ϼƣ�"
            .Item("guarantee_sum") = iTotalSum
            .Item("refund_sum_average") = iTotalRefundAverageSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "������" & i
        End With
        dtResult.Rows.Add(drRow)


        'ds.Tables(0).TableName = "TQuerySignProject"
        'grdTable.DataMember = ds.Tables(0).TableName
        grdTable.DataSource = dtResult
        MyBase.DataSource = dtResult
    End Sub

    Private Sub chkStartDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpStartDate.Enabled = chkDate.Checked
        dtpEndDate.Enabled = chkDate.Checked
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportFile = Application.StartupPath & ".\Reports\QuerySignProject.rpt"
        ReportTitle = "ǩԼ��Ŀһ����"
        'ReportTable = New String() {"TQuerySignProject"}

        '''''''''''''''''��ҵ����'''''''''''''''''''''''''
        'Dim ds As DataSet = gWs.GetcorporationInfo("%", "null")
        'cboCorName.DataSource = ds.Tables("corporation")
        'cboCorName.DisplayMember = "corporation_name"
        'cboCorName.ValueMember = "corporation_name"
        '''''''ҵ��Ʒ��''''''''''''''''
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        '''''''''''''''��������''''''''''''''''''
        Dim dsArea As DataSet = gWs.GetDistrict("%")
        cboArea.DataSource = dsArea.Tables(0)
        cboArea.DisplayMember = "district_name"
        cboArea.ValueMember = "district_name"
        '''''''''''''�������� ����֧��'''''''''''''''
        'dsBank = gWs.GetBankInfo("{0=0 order by bank_name}", "%")
        'qxd modify 2005-10-21 ͨ���洢ʵ���˰�������������
        dsBank = gWs.GetBankInfo("%", "%")
        cboBank.DataSource = dsBank.Tables("bank")
        cboBank.DisplayMember = "bank_name"
        cboBank.ValueMember = "bank_code"
        cboSubBank.DataSource = dsBank.Tables("bank_branch").DefaultView
        cboSubBank.DisplayMember = "branch_bank_name"
        cboSubBank.ValueMember = "branch_bank_name"

        'Dim dsBank As DataSet = gWs.GetBankInfo("{0=0 ORDER BY bank_name}", "%")         '"bank"   "bank_branch"
        'Dim dr As DataRow
        'cmbxApplyBank.DataSource = dsBank.Tables("bank")
        'cmbxApplyBank.DisplayMember = "bank_name"
        'cmbxApplyBank.ValueMember = "bank_code"
        'AddHandler cmbxApplyBank.SelectedValueChanged, AddressOf BankChanged
        ''''''''''''''����������''''''''''''''''''
        Dim dsCorType As DataSet = gWs.GetProprietorshipType("%")
        cboCorType.DataSource = dsCorType.Tables(0)
        cboCorType.DisplayMember = "proprietorship_type"
        cboCorType.ValueMember = "proprietorship_type"
        ''''''''''''''������ҵ'''''''''''''''''''
        Dim dsIT As DataSet = gWs.GetIndustryType("%")
        cboIndustryType.DataSource = dsIT.Tables(0)
        cboIndustryType.DisplayMember = "industry_type"
        cboIndustryType.ValueMember = "industry_type"
        '''''''''''''��Ŀ����A'''''''''''
        Dim strSql As String = "{not team_name is null}"
        Dim dsMA As DataSet = gWs.GetStaff(strSql)
        cboMA.DataSource = dsMA.Tables(0)
        cboMA.DisplayMember = "staff_name"
        cboMA.ValueMember = "staff_name"
        AddTableStyle()
        Clear()
        Dim SystemDate As Date = gWs.GetSysTime
        dtpStartDate.Value = SystemDate.Date : dtpEndDate.Value = SystemDate.Date
    End Sub

    Private Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboBank.SelectedValueChanged
        If Me.cboSubBank.DataSource Is Nothing Then Return
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code LIKE '" & cboBank.SelectedValue & "'"
        dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
        'Me.cboSubBank.Text = ""
        Me.cboSubBank.SelectedIndex = -1
    End Sub

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "project_code"
        col1.HeaderText = "��Ŀ���"
        col1.Width = 75
        col1.NullText = ""
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "enterprise_name"
        col2.HeaderText = "��ҵ����"
        col2.Width = 150
        col2.NullText = ""
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "manager_a"
        col3.HeaderText = "��Ŀ����A��"
        col3.Width = 75
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "manager_b"
        col4.HeaderText = "��Ŀ����B��"
        col4.Width = 75
        col4.NullText = ""
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "service_type"
        col5.HeaderText = "ҵ��Ʒ��"
        col5.Width = 110
        col5.NullText = ""
        Dim col5_1 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col5_1.MappingName = "terms"
        col5_1.HeaderText = "����"
        col5_1.Width = 75
        col5_1.NullText = ""
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "guarantee_sum"
        col6.Alignment = HorizontalAlignment.Right
        col6.HeaderText = "ǩԼ���(��Ԫ)"
        'col6.Format = "n" : col6.FormatInfo = CGFormatInfo
        col6.NullText = String.Empty
        col6.Width = 100
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "sign_date"
        col7.HeaderText = "ǩԼ����"
        col7.Format = "yyyy-MM-dd"
        col7.NullText = ""
        col7.Width = 75
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "reply_date"
        col8.HeaderText = "����ͨ������"
        col8.Width = 75
        col8.Format = "yyyy-MM-dd"
        col8.NullText = ""
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "bank"
        col9.HeaderText = "ǩԼ����"
        col9.Width = 100
        col9.NullText = ""
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col10.MappingName = "branch_bank"
        col10.HeaderText = "ǩԼ֧��"
        col10.Width = 100
        col10.NullText = ""
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col11.MappingName = "district_name"
        col11.HeaderText = "��������"
        col11.NullText = ""
        col11.Width = 100
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "industry_type"
        col12.HeaderText = "������ҵ"
        col12.Width = 110
        col12.NullText = ""
        Dim col13 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col13.MappingName = "proprietorship_type"
        col13.HeaderText = "����������"
        col13.Width = 110
        col13.NullText = ""
        Dim col14 As DataGridBoolColumn = New DataGridBoolColumn()
        col14.MappingName = "is_first_loan"
        col14.HeaderText = "�Ƿ��״δ���"
        col14.Width = 75
        col14.NullValue = False
        Dim col15 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col15.MappingName = "recommend_person"
        col15.HeaderText = "�Ƽ���"
        col15.Width = 90
        col15.NullText = ""
        Dim col16 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col16.MappingName = "conference_date"
        col16.HeaderText = "�����ͨ��ʱ��"
        col16.Width = 120
        col16.Format = "yyyy-MM-dd"
        col16.NullText = ""
        Dim col17 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col17.MappingName = "RefundType"
        col17.HeaderText = "���ʽ"
        col17.Width = 90
        col17.NullText = ""
        Dim col18 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col18.MappingName = "cooperate_organization"
        col18.HeaderText = "�������Ƽ����"
        col18.Width = 120
        col18.NullText = ""
        Dim col19 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col19.MappingName = "recommend_sum"
        col19.HeaderText = "�������Ƽ����(��Ԫ)"
        col19.Alignment = HorizontalAlignment.Right
        col19.Width = 120
        'col19.Format = "n"
        col19.NullText = ""
        Dim col20 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col20.MappingName = "intent_date"
        col20.HeaderText = "ǩ����������������"
        col20.Width = 120
        col20.Format = "yyyy-MM-dd"
        col20.NullText = ""
        Dim col21 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col21.MappingName = "vchTechType"
        col21.HeaderText = "�Ƽ�����"
        col21.Width = 120
        col21.NullText = ""
        Dim col22 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col22.MappingName = "refund_sum_average"
        col22.HeaderText = "ÿ�λ�����"
        col22.Alignment = HorizontalAlignment.Right
        col22.Width = 120
        col22.Format = "n"
        col22.NullText = ""
        Dim col23 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col23.MappingName = "Remark"
        col23.HeaderText = "��ע"
        col23.Alignment = HorizontalAlignment.Left
        col23.Width = 100
        'col23.Format = ""
        col23.NullText = ""
        Dim col24 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col24.MappingName = "branch_name"
        col24.HeaderText = "���β���"
        col24.Alignment = HorizontalAlignment.Left
        col24.Width = 75
        col24.NullText = ""
        Dim col25 As DataGridTextBoxColumn = New DataGridTextBoxColumn() 'status             2005-1-4 by 9sky
        col25.Format = ""
        col25.FormatInfo = Nothing
        col25.HeaderText = "��Ŀ״̬"
        col25.MappingName = "status"
        col25.NullText = ""
        col25.Width = 75
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col5_1, col6, col7, col22, col23, col8, col9, col10, col11, col12, col13, col14, col15, col16, col17, col18, col19, col20, col21, col24, col25})
        grdTable.TableStyles.Add(dgts)
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboCorType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboIndustryType As System.Windows.Forms.ComboBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboMA As System.Windows.Forms.ComboBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.cboIndustryType = New System.Windows.Forms.ComboBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSubBank = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCorType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboMA = New System.Windows.Forms.ComboBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.cboMA, Me.cboArea, Me.Label9, Me.cboCorType, Me.Label8, Me.cboSubBank, Me.Label4, Me.cboBank, Me.cboIndustryType, Me.cboServiceType, Me.txtProjectCode, Me.Label7, Me.Label6, Me.Label5, Me.Label3, Me.Label2, Me.Label1, Me.dtpStartDate, Me.chkDate, Me.Label10, Me.dtpEndDate})
        Me.grpCondition.Size = New System.Drawing.Size(752, 120)
        Me.grpCondition.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 144)
        Me.chkVisible.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 144)
        Me.btnClear.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(568, 144)
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(560, 152)
        Me.btnPrint.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 184)
        Me.grdTable.Size = New System.Drawing.Size(752, 304)
        Me.grdTable.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(664, 144)
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(472, 144)
        Me.btnRefresh.Visible = True
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(8, 89)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 18)
        Me.chkDate.TabIndex = 28
        Me.chkDate.Text = "ǩԼ����"
        '
        'cboBank
        '
        Me.cboBank.Location = New System.Drawing.Point(272, 40)
        Me.cboBank.MaxLength = 20
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(168, 20)
        Me.cboBank.TabIndex = 27
        '
        'cboIndustryType
        '
        Me.cboIndustryType.Location = New System.Drawing.Point(272, 64)
        Me.cboIndustryType.MaxLength = 20
        Me.cboIndustryType.Name = "cboIndustryType"
        Me.cboIndustryType.Size = New System.Drawing.Size(168, 20)
        Me.cboIndustryType.TabIndex = 25
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(536, 16)
        Me.cboServiceType.MaxLength = 20
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(168, 20)
        Me.cboServiceType.TabIndex = 24
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(80, 88)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 23
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 16)
        Me.txtProjectCode.MaxLength = 11
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(112, 21)
        Me.txtProjectCode.TabIndex = 21
        Me.txtProjectCode.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(216, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "������ҵ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "��Ŀ����A��"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(216, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ǩԼ����"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(480, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ҵ��Ʒ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(216, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "��ҵ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "��Ŀ���" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(480, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ǩԼ֧��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSubBank
        '
        Me.cboSubBank.Location = New System.Drawing.Point(536, 40)
        Me.cboSubBank.MaxLength = 20
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(168, 20)
        Me.cboSubBank.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(472, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "����������"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCorType
        '
        Me.cboCorType.Location = New System.Drawing.Point(536, 64)
        Me.cboCorType.MaxLength = 20
        Me.cboCorType.Name = "cboCorType"
        Me.cboCorType.Size = New System.Drawing.Size(168, 20)
        Me.cboCorType.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "��������"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(80, 40)
        Me.cboArea.MaxLength = 20
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(112, 20)
        Me.cboArea.TabIndex = 34
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(272, 88)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(168, 21)
        Me.dtpEndDate.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(248, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "��"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboMA
        '
        Me.cboMA.Location = New System.Drawing.Point(80, 64)
        Me.cboMA.MaxLength = 10
        Me.cboMA.Name = "cboMA"
        Me.cboMA.Size = New System.Drawing.Size(112, 20)
        Me.cboMA.TabIndex = 37
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(272, 16)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(168, 21)
        Me.txtCorpName.TabIndex = 38
        Me.txtCorpName.Text = ""
        '
        'FQuerySignProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(768, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQuerySignProject"
        Me.Text = "ǩԼ��Ŀһ����"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


End Class
