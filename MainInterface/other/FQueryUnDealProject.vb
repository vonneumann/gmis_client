Public Class FQueryUnDealProject
    Inherits MainInterface.FQueryBase

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
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents dtUnDeal As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ProjectCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EnterPriseName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ApplyServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents consult_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ApplySum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents take_time As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_A As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_B As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.dtUnDeal = New System.Windows.Forms.DataGridTableStyle()
        Me.ProjectCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EnterPriseName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ApplyServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.consult_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ApplySum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.take_time = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_A = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_B = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 88)
        Me.btnExit.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPMA, Me.Label8, Me.cboServiceType, Me.lbl4})
        Me.grpCondition.Size = New System.Drawing.Size(696, 64)
        Me.grpCondition.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 88)
        Me.chkVisible.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 88)
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 128)
        Me.grdTable.Size = New System.Drawing.Size(696, 360)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dtUnDeal})
        Me.grdTable.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(512, 88)
        Me.btnExport.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(408, 88)
        Me.btnRefresh.Visible = True
        '
        'cboServiceType
        '
        Me.cboServiceType.DisplayMember = "service_type"
        Me.cboServiceType.Location = New System.Drawing.Point(72, 24)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(160, 20)
        Me.cboServiceType.TabIndex = 16
        Me.cboServiceType.ValueMember = "service_type"
        '
        'lbl4
        '
        Me.lbl4.Location = New System.Drawing.Point(16, 24)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(56, 23)
        Me.lbl4.TabIndex = 15
        Me.lbl4.Text = "ҵ��Ʒ��"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtUnDeal
        '
        Me.dtUnDeal.DataGrid = Me.grdTable
        Me.dtUnDeal.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ProjectCode, Me.EnterPriseName, Me.ApplyServiceType, Me.consult_date, Me.ApplySum, Me.take_time, Me.manager_A, Me.manager_B})
        Me.dtUnDeal.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtUnDeal.MappingName = "Table"
        '
        'ProjectCode
        '
        Me.ProjectCode.Format = ""
        Me.ProjectCode.FormatInfo = Nothing
        Me.ProjectCode.HeaderText = "��Ŀ����"
        Me.ProjectCode.MappingName = "ProjectCode"
        Me.ProjectCode.NullText = ""
        Me.ProjectCode.Width = 75
        '
        'EnterPriseName
        '
        Me.EnterPriseName.Format = ""
        Me.EnterPriseName.FormatInfo = Nothing
        Me.EnterPriseName.HeaderText = "��ҵ����"
        Me.EnterPriseName.MappingName = "EnterPriseName"
        Me.EnterPriseName.NullText = ""
        Me.EnterPriseName.Width = 150
        '
        'ApplyServiceType
        '
        Me.ApplyServiceType.Format = ""
        Me.ApplyServiceType.FormatInfo = Nothing
        Me.ApplyServiceType.HeaderText = "ҵ��Ʒ��"
        Me.ApplyServiceType.MappingName = "ApplyServiceType"
        Me.ApplyServiceType.NullText = ""
        Me.ApplyServiceType.Width = 120
        '
        'consult_date
        '
        Me.consult_date.Format = "D"
        Me.consult_date.FormatInfo = Nothing
        Me.consult_date.HeaderText = "��������"
        Me.consult_date.MappingName = "consult_date"
        Me.consult_date.NullText = ""
        Me.consult_date.Width = 80
        '
        'ApplySum
        '
        Me.ApplySum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ApplySum.Format = ""
        Me.ApplySum.FormatInfo = Nothing
        Me.ApplySum.HeaderText = "������"
        Me.ApplySum.MappingName = "ApplySum"
        Me.ApplySum.NullText = ""
        Me.ApplySum.Width = 75
        '
        'take_time
        '
        Me.take_time.Format = "yyyy-MM-dd"
        Me.take_time.FormatInfo = Nothing
        Me.take_time.HeaderText = "��Ŀ��������"
        Me.take_time.MappingName = "take_time"
        Me.take_time.NullText = ""
        Me.take_time.Width = 80
        '
        'manager_A
        '
        Me.manager_A.Format = ""
        Me.manager_A.FormatInfo = Nothing
        Me.manager_A.HeaderText = "��Ŀ����A��"
        Me.manager_A.MappingName = "manager_A"
        Me.manager_A.NullText = ""
        Me.manager_A.Width = 80
        '
        'manager_B
        '
        Me.manager_B.Format = ""
        Me.manager_B.FormatInfo = Nothing
        Me.manager_B.HeaderText = "��Ŀ����B��"
        Me.manager_B.MappingName = "manager_B"
        Me.manager_B.NullText = ""
        Me.manager_B.Width = 80
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Location = New System.Drawing.Point(328, 24)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(142, 20)
        Me.cboPMA.TabIndex = 113
        Me.cboPMA.ValueMember = "staff_name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(264, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "��Ŀ����A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FQueryUnDealProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryUnDealProject"
        Me.Text = "δ������Ŀһ����"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim strServiceType, strPMA As String
        Dim i As Integer
        Dim iTotalApplySum As Decimal
        Dim dtResult As DataTable

        strServiceType = cboServiceType.Text.Trim
        strPMA = cboPMA.Text.Trim

        dtResult = gWs.Usp_GetUnDealProject(strServiceType, strPMA, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not IsDBNull(dtResult.Rows(i).Item("ApplySum")) Then
                iTotalApplySum = iTotalApplySum + CDec(dtResult.Rows(i).Item("ApplySum"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("EnterpriseName") = "�ϼƣ�"
            .Item("ApplySum") = iTotalApplySum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("EnterpriseName") = "������" & i
        End With
        dtResult.Rows.Add(drRow)
        Me.grdTable.DataSource = dtResult

    End Sub

    Protected Overrides Sub Export()
        ReportToExcel.ToExcel(Me.grdTable, "δ������Ŀһ����", "δ������Ŀһ����")
    End Sub


    Private Sub FQueryUnDealProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
        cboPMA.DataSource = gWs.GetStaff("{not team_name is null}").Tables(0)
    End Sub

End Class
