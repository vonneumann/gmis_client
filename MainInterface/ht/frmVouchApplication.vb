
'����ſ�
Public Class frmVouchApplication
    Inherits MainInterface.frmRequestVouchApplication

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
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents dtpVouchDate As System.Windows.Forms.DateTimePicker
    Public WithEvents cmbVouchBank As System.Windows.Forms.ComboBox
    Public WithEvents cmbVouchBranchBank As System.Windows.Forms.ComboBox
    Public WithEvents cmbRefundType As System.Windows.Forms.ComboBox
    Public WithEvents cmbVouchAccount As System.Windows.Forms.TextBox
    Public WithEvents cmbVouchTerms As System.Windows.Forms.TextBox
    Public WithEvents dgLoanNotice As System.Windows.Forms.DataGrid
    Public WithEvents grpLoanNotice As System.Windows.Forms.GroupBox
    Public WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents btnViewAffirmContent As System.Windows.Forms.Button
    Protected WithEvents btnAdd As System.Windows.Forms.Button
    Protected WithEvents txtLoanContract_num As System.Windows.Forms.TextBox
    Protected WithEvents lblLoanContract_num As System.Windows.Forms.Label
    Protected WithEvents txtAssureContract_num As System.Windows.Forms.TextBox
    Protected WithEvents lblAssureContract_num As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVouchApplication))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAssureContract_num = New System.Windows.Forms.TextBox()
        Me.txtLoanContract_num = New System.Windows.Forms.TextBox()
        Me.lblAssureContract_num = New System.Windows.Forms.Label()
        Me.lblLoanContract_num = New System.Windows.Forms.Label()
        Me.cmbVouchTerms = New System.Windows.Forms.TextBox()
        Me.cmbVouchAccount = New System.Windows.Forms.TextBox()
        Me.cmbRefundType = New System.Windows.Forms.ComboBox()
        Me.cmbVouchBranchBank = New System.Windows.Forms.ComboBox()
        Me.cmbVouchBank = New System.Windows.Forms.ComboBox()
        Me.dtpVouchDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgLoanNotice = New System.Windows.Forms.DataGrid()
        Me.grpLoanNotice = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnViewAffirmContent = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLoanNotice.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Size = New System.Drawing.Size(648, 176)
        Me.GroupBox1.Visible = True
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Bitmap)
        Me.btnConferenceTrial.ImageIndex = -1
        Me.btnConferenceTrial.ImageList = Nothing
        Me.btnConferenceTrial.Location = New System.Drawing.Point(304, 464)
        Me.btnConferenceTrial.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(497, 464)
        Me.btnCommit.Visible = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Width = 520
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.Width = 82
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Width = 65
        '
        'dgDatum
        '
        Me.dgDatum.AccessibleName = "DataGrid"
        Me.dgDatum.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgDatum.Size = New System.Drawing.Size(642, 156)
        Me.dgDatum.Visible = True
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUploadReport.Enabled = True
        Me.btnUploadReport.Image = CType(resources.GetObject("btnUploadReport.Image"), System.Drawing.Bitmap)
        Me.btnUploadReport.ImageIndex = -1
        Me.btnUploadReport.ImageList = Nothing
        Me.btnUploadReport.Location = New System.Drawing.Point(182, 464)
        Me.btnUploadReport.Size = New System.Drawing.Size(120, 23)
        Me.btnUploadReport.Text = "�����ſ�����(&M)"
        Me.btnUploadReport.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 6)
        Me.txtProjectCode.Size = New System.Drawing.Size(112, 21)
        Me.txtProjectCode.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(264, 6)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(392, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(208, 8)
        Me.Label2.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(576, 464)
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAssureContract_num, Me.txtLoanContract_num, Me.lblAssureContract_num, Me.lblLoanContract_num, Me.cmbVouchTerms, Me.cmbVouchAccount, Me.cmbRefundType, Me.cmbVouchBranchBank, Me.cmbVouchBank, Me.dtpVouchDate, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 104)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "���еķſ���Ϣ"
        '
        'txtAssureContract_num
        '
        Me.txtAssureContract_num.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAssureContract_num.Location = New System.Drawing.Point(536, 71)
        Me.txtAssureContract_num.Name = "txtAssureContract_num"
        Me.txtAssureContract_num.ReadOnly = True
        Me.txtAssureContract_num.TabIndex = 24
        Me.txtAssureContract_num.Text = ""
        '
        'txtLoanContract_num
        '
        Me.txtLoanContract_num.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanContract_num.Location = New System.Drawing.Point(368, 71)
        Me.txtLoanContract_num.Name = "txtLoanContract_num"
        Me.txtLoanContract_num.ReadOnly = True
        Me.txtLoanContract_num.TabIndex = 23
        Me.txtLoanContract_num.Text = ""
        '
        'lblAssureContract_num
        '
        Me.lblAssureContract_num.Location = New System.Drawing.Point(472, 72)
        Me.lblAssureContract_num.Name = "lblAssureContract_num"
        Me.lblAssureContract_num.Size = New System.Drawing.Size(100, 16)
        Me.lblAssureContract_num.TabIndex = 26
        Me.lblAssureContract_num.Text = "��֤��ͬ��"
        '
        'lblLoanContract_num
        '
        Me.lblLoanContract_num.Location = New System.Drawing.Point(296, 72)
        Me.lblLoanContract_num.Name = "lblLoanContract_num"
        Me.lblLoanContract_num.Size = New System.Drawing.Size(100, 16)
        Me.lblLoanContract_num.TabIndex = 25
        Me.lblLoanContract_num.Text = "����ͬ��"
        '
        'cmbVouchTerms
        '
        Me.cmbVouchTerms.Location = New System.Drawing.Point(112, 46)
        Me.cmbVouchTerms.Name = "cmbVouchTerms"
        Me.cmbVouchTerms.Size = New System.Drawing.Size(176, 21)
        Me.cmbVouchTerms.TabIndex = 22
        Me.cmbVouchTerms.Text = "0"
        Me.cmbVouchTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbVouchAccount
        '
        Me.cmbVouchAccount.Location = New System.Drawing.Point(424, 46)
        Me.cmbVouchAccount.MaxLength = 15
        Me.cmbVouchAccount.Name = "cmbVouchAccount"
        Me.cmbVouchAccount.Size = New System.Drawing.Size(176, 21)
        Me.cmbVouchAccount.TabIndex = 21
        Me.cmbVouchAccount.Text = ""
        Me.cmbVouchAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbRefundType
        '
        Me.cmbRefundType.Enabled = False
        Me.cmbRefundType.Location = New System.Drawing.Point(112, 72)
        Me.cmbRefundType.Name = "cmbRefundType"
        Me.cmbRefundType.Size = New System.Drawing.Size(176, 20)
        Me.cmbRefundType.TabIndex = 19
        '
        'cmbVouchBranchBank
        '
        Me.cmbVouchBranchBank.Location = New System.Drawing.Point(424, 22)
        Me.cmbVouchBranchBank.Name = "cmbVouchBranchBank"
        Me.cmbVouchBranchBank.Size = New System.Drawing.Size(176, 20)
        Me.cmbVouchBranchBank.TabIndex = 16
        '
        'cmbVouchBank
        '
        Me.cmbVouchBank.Location = New System.Drawing.Point(112, 22)
        Me.cmbVouchBank.Name = "cmbVouchBank"
        Me.cmbVouchBank.Size = New System.Drawing.Size(176, 20)
        Me.cmbVouchBank.TabIndex = 15
        '
        'dtpVouchDate
        '
        Me.dtpVouchDate.Location = New System.Drawing.Point(520, 72)
        Me.dtpVouchDate.Name = "dtpVouchDate"
        Me.dtpVouchDate.Size = New System.Drawing.Size(8, 21)
        Me.dtpVouchDate.TabIndex = 14
        Me.dtpVouchDate.Value = New Date(2003, 7, 26, 0, 0, 0, 0)
        Me.dtpVouchDate.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(24, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "���ʽ"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(320, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "�ſ���(��Ԫ)"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "��������(��)"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(320, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "����֧��"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "��������"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(480, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "����"
        Me.Label3.Visible = False
        '
        'dgLoanNotice
        '
        Me.dgLoanNotice.AllowSorting = False
        Me.dgLoanNotice.CaptionVisible = False
        Me.dgLoanNotice.DataMember = ""
        Me.dgLoanNotice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLoanNotice.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgLoanNotice.Location = New System.Drawing.Point(3, 17)
        Me.dgLoanNotice.Name = "dgLoanNotice"
        Me.dgLoanNotice.ReadOnly = True
        Me.dgLoanNotice.Size = New System.Drawing.Size(642, 124)
        Me.dgLoanNotice.TabIndex = 9
        '
        'grpLoanNotice
        '
        Me.grpLoanNotice.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgLoanNotice})
        Me.grpLoanNotice.Location = New System.Drawing.Point(8, 208)
        Me.grpLoanNotice.Name = "grpLoanNotice"
        Me.grpLoanNotice.Size = New System.Drawing.Size(648, 144)
        Me.grpLoanNotice.TabIndex = 10
        Me.grpLoanNotice.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(418, 464)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnViewAffirmContent
        '
        Me.btnViewAffirmContent.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnViewAffirmContent.Image = CType(resources.GetObject("btnViewAffirmContent.Image"), System.Drawing.Bitmap)
        Me.btnViewAffirmContent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewAffirmContent.ImageIndex = 28
        Me.btnViewAffirmContent.ImageList = Me.ImageListBasic
        Me.btnViewAffirmContent.Location = New System.Drawing.Point(92, 464)
        Me.btnViewAffirmContent.Name = "btnViewAffirmContent"
        Me.btnViewAffirmContent.Size = New System.Drawing.Size(88, 23)
        Me.btnViewAffirmContent.TabIndex = 14
        Me.btnViewAffirmContent.Text = "�鿴����(&V)"
        Me.btnViewAffirmContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Bitmap)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageIndex = 27
        Me.btnAdd.ImageList = Me.ImageListBasic
        Me.btnAdd.Location = New System.Drawing.Point(13, 464)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "�� ��(&A)"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmVouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(666, 495)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnConferenceTrial, Me.btnUploadReport, Me.btnCommit, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1, Me.btnAdd, Me.btnViewAffirmContent, Me.btnSave, Me.grpLoanNotice, Me.GroupBox2})
        Me.MinimizeBox = False
        Me.Name = "frmVouchApplication"
        Me.Text = "����ſ�"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLoanNotice.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private intTrialTimes As Integer
    Private ds As DataSet
    Private dsBank As DataSet
    Protected dsLoanNotice As DataSet
    Private dsLoanNoticeCopy As DataSet
    Private BankCode, BranchBankCode As String
    Private bLoanAdded As Boolean = False
    Protected bOperate As Boolean = False   '�������һ����¼
    Protected bTextChanged As Boolean = False   '�ı��Ƿ�ı�
    Private intLoanCount As Integer = 0
    Private _updateType As UpdateType
    Private _bIsModified As Boolean = False

    Enum UpdateType
        Added
        Modified
    End Enum

    WriteOnly Property ControlEnabled() As Boolean
        Set(ByVal Value As Boolean)
            Me.cmbVouchBank.Enabled = Value
            Me.cmbVouchBranchBank.Enabled = Value
            Me.cmbVouchTerms.Enabled = Value
            Me.cmbVouchAccount.Enabled = Value
        End Set
    End Property

    Private Sub frmVouchApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            Call Me.InitCombo()
            Call Me.GetLoanNotice()
            Call Me.GetDataGridBankName()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub InitCombo()
        ds = gWs.GetBankInfo("%", "null")
        Call Me.GetBankNameList(Me.cmbVouchBank, ds, "bank", "bank_name")

        AddHandler cmbVouchAccount.KeyPress, AddressOf Money.Money_KeyPress
        AddHandler cmbVouchAccount.Leave, AddressOf Money.Money_Leave
        Me.ControlEnabled = False
    End Sub

    '�����ݿ���ȡ�ſ�������Ϣ���������δǩ���ľ�����һ��
    Private Sub GetLoanNotice()
        Dim i As Integer
        Dim dr As DataRow
        Dim drs() As DataRow
        Dim bIsSign As Boolean = True
        Dim intTrialTimes, intTerms As Integer
        '���TrialTimes��
        ds = gWs.GetConfTrialInfo("{project_code='" & Me.strProjectCode & "' and trial_conclusion='ͨ��' ORDER BY trial_times DESC}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                intTrialTimes = IIf(IsDBNull(.Item("trial_times")), 0, .Item("trial_times")) '�������
                intTerms = IIf(IsDBNull(.Item("terms")), 0, .Item("terms"))                  '��������
                Me.cmbRefundType.Text = IIf(IsDBNull(.Item("refund_type")), "", .Item("refund_type")) '�ſʽ
            End With
        End If

        'Dim strSignBankCode, strSignBankBranchCode As String
        'Dim dSignSum As Double

        'ds = gWs.GetProjectInfoEx("{ProjectCode='" & Me.strProjectCode & "'}")
        'If Not ds.Tables(0).Rows.Count = 0 Then
        '    With ds.Tables(0).Rows(0)
        '        strSignBankCode = IIf(IsDBNull(.Item("sign_bank")), "", .Item("sign_bank"))  'ǩԼ����
        '        strSignBankBranchCode = IIf(IsDBNull(.Item("sign_bank_branch")), "", .Item("sign_bank_branch")) 'ǩԼ֧��
        '        dSignSum = IIf(IsDBNull(.Item("sign_sum")), 0D, .Item("sign_sum"))
        '    End With
        'End If
        Me.dsLoanNotice = gWs.GetLoanNoticeInfo("{project_code = '" & Me.strProjectCode & "' order by create_date}")
        Me.intLoanCount = Me.dsLoanNotice.Tables(0).Rows.Count
        If Me.intLoanCount = 0 Then
            bIsSign = False   '���ݿ��в����ڷſ�����
        End If
        Dim dsTemp As DataSet = gWs.GetProjectOpinionByProjectNo("{project_code=" & Me.strProjectCode & " AND item_type='54' AND item_code='001'}")

        Me.dsLoanNotice.Tables(0).Columns.Add(New DataColumn("conclusion", GetType(String)))

        Me._updateType = UpdateType.Added
        For Each dr In Me.dsLoanNotice.Tables(0).Rows
            drs = dsTemp.Tables(0).Select("file_relation_num=" & dr("notice_code"))
            If Not drs.Length = 0 Then
                dr("conclusion") = drs(0)("conclusion")
            Else
                bIsSign = False  '����δǩ���ķſ�����
                Me._bIsModified = True
                Me._updateType = UpdateType.Modified
                Me.btnAdd.Enabled = False
                Me.GroupBox2.Text = "��ǰ�ķſ���Ϣ"
            End If
        Next

        Me.dgLoanNotice.DataSource = dsLoanNotice.Tables("loan_notice")

        AddTableStyle()

        '����ͬ�ţ��ͱ�֤��ͬ��������һ������������ȷ��
        dsTemp = gWs.GetProjectSignatureInfo("{project_code LIKE '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtLoanContract_num.Text = IIf(IsDBNull(.Item("loanContract_num")), "", .Item("loanContract_num"))    '����ͬ�š�
                Me.txtAssureContract_num.Text = IIf(IsDBNull(.Item("assureContract_num")), "", .Item("assureContract_num")) '��֤��ͬ��
            End With
        End If
    End Sub
    '�Ƿ��Ѵ��ڿ��Բ����ļ�¼
    Private Function HasRecord() As Boolean
        Dim i As Integer
        Dim dr As DataRow
        Dim drs() As DataRow
        Dim bIsSign As Boolean = True



        '   Me.dsLoanNotice = gWs.GetLoanNoticeInfo("{project_code = '" & Me.strProjectCode & "' ORDER BY create_date}")
        'Me.intLoanCount = Me.dsLoanNotice.Tables(0).Rows.Count  '�ſ��¼����
        If Me.dsLoanNotice Is Nothing Then
            Return False
        End If

        Dim dsTemp As DataSet = gWs.GetProjectOpinionByProjectNo("{project_code=" & Me.strProjectCode & " AND item_type='54' AND item_code='001'}")

        'Me.dsLoanNotice.Tables(0).Columns.Add(New DataColumn("conclusion", GetType(String)))

        For Each dr In Me.dsLoanNotice.Tables(0).Rows
            If IsDBNull(dr("notice_code")) Then
                Return True
            End If
            drs = dsTemp.Tables(0).Select("file_relation_num=" & dr("notice_code"))
            If Not drs.Length = 0 Then
                dr("conclusion") = drs(0)("conclusion")
            Else
                bIsSign = False  '����δǩ���ķſ�����
                Return True '�пɲ����ļ�¼
            End If
        Next
        If CType(Me.dgLoanNotice.DataSource, DataTable).Rows.Count = Me.intLoanCount + 1 Then '�Ѵ���������¼��
            Return True
        End If

        Return False
    End Function

    'ͨ�����������е�DataGrid��ʵ���е����д�����������Ӧ���������ƣ�����DataGrid����ʾ������
    Private Sub GetDataGridBankName()
        If Me.dsLoanNotice Is Nothing Then
            Return
        End If

        Dim BankCode, BranchBankCode As String
        Dim DsBank As DataSet
        Dim dr() As DataRow
        DsBank = gWs.GetBankInfo("%", "%")

        For i = 0 To Me.dsLoanNotice.Tables(0).Rows.Count - 1
            If Not Me.dgLoanNotice.Item(i, 1) Is System.DBNull.Value Then
                BankCode = Me.dgLoanNotice.Item(i, 1)
                dr = DsBank.Tables(0).Select("bank_code = '" & BankCode & "'")
                If Not dr.Length = 0 Then
                    Me.dgLoanNotice.Item(i, 1) = dr(0).Item("bank_name")
                End If
                System.Array.Clear(dr, 0, dr.Length)
            Else
                Me.dgLoanNotice.Item(i, 1) = ""
            End If
            If Not Me.dgLoanNotice.Item(i, 2) Is System.DBNull.Value Then
                BranchBankCode = Me.dgLoanNotice.Item(i, 2)
                dr = DsBank.Tables(1).Select("bank_code = '" & BankCode & "' and branch_bank_code = '" & BranchBankCode & "'")
                If Not dr.Length = 0 Then
                    Me.dgLoanNotice.Item(i, 2) = dr(0).Item("branch_bank_name")
                End If
                System.Array.Clear(dr, 0, dr.Length)
            Else
                Me.dgLoanNotice.Item(i, 2) = ""
            End If
        Next
        If Not Me.intLoanCount = 0 Then
            Me.dgLoanNotice.Select(Me.intLoanCount - 1)
            Me.cmbVouchBank.Text = Me.dgLoanNotice.Item(Me.intLoanCount - 1, 1)
            Me.cmbVouchBranchBank.Text = Me.dgLoanNotice.Item(Me.intLoanCount - 1, 2)
            Me.cmbVouchAccount.Text = Me.dgLoanNotice.Item(Me.intLoanCount - 1, 3)
            Me.cmbVouchTerms.Text = Me.dgLoanNotice.Item(Me.intLoanCount - 1, 4)
            If Me._updateType = UpdateType.Modified Then
                Me.bOperate = True
                Me.ControlEnabled = True
            End If
        End If

    End Sub
    'ΪdgLoanNotice���tableStyle
    Private Sub AddTableStyle()
        Me.dgLoanNotice.TableStyles.Clear()
        Dim ts As DataGridTableStyle = New DataGridTableStyle()
        ts.MappingName = "loan_notice"
        ts.AllowSorting = False

        Dim col0 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col0.HeaderText = "���"
        col0.MappingName = "notice_code"
        col0.NullText = ""
        col0.Width = 0

        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.HeaderText = "��������"
        col1.MappingName = "bank"
        col1.Width = 120

        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.HeaderText = "����֧��"
        col2.MappingName = "branch_bank"
        col2.Width = 140

        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.HeaderText = "���(��)"
        col3.MappingName = "sum"
        col3.FormatInfo = CGFormatInfo
        col3.Alignment = HorizontalAlignment.Center
        col3.Width = 55

        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.HeaderText = "����(��)"
        col4.MappingName = "term"
        col4.Alignment = HorizontalAlignment.Center
        col4.Width = 55

        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.HeaderText = "����ſ���"
        col5.MappingName = "create_person"
        col5.NullText = ""
        col5.Alignment = HorizontalAlignment.Center
        col5.Width = 72

        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.HeaderText = "����ʱ��"
        col6.MappingName = "create_date"
        col6.NullText = ""
        col6.Format = "yyyy-MM-dd"
        col6.Width = 73

        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.HeaderText = "ǩ����"
        col7.MappingName = "affirm_person"
        col7.NullText = ""
        col7.Alignment = HorizontalAlignment.Center
        col7.Width = 72

        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.HeaderText = "ǩ��ʱ��"
        col8.MappingName = "affirm_date"
        col8.NullText = ""
        col8.Format = "yyyy-MM-dd"
        col8.Width = 73

        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.HeaderText = "ǩ�����"
        col9.MappingName = "conclusion"
        col9.NullText = ""

        ts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col0, col1, col2, col3, col4, col5, col6, col7, col8, col9})
        Me.dgLoanNotice.TableStyles.Add(ts)
    End Sub

    Private Sub GetBankNameList(ByVal cmb As ComboBox, ByVal x As DataSet, ByVal TableName As String, ByVal FieldName As String)
        cmb.Items.Clear()
        x.Tables(TableName).DefaultView.Sort = FieldName
        If Not x.Tables(TableName).Rows.Count = 0 Then
            For i = 0 To x.Tables(TableName).Rows.Count - 1
                cmb.Items.Add(x.Tables(TableName).Rows(i).Item(FieldName))
            Next
        End If
    End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim TempDS As DataSet
        If BranchBankCode = Nothing Then    'ȡ���������ơ�
            TempDS = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
            If Not TempDS.Tables(0).Rows(0).Item("bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(0).Rows(0).Item("bank_name")
            End If
        Else    'ȡ������֧������
            TempDS = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
            If Not TempDS.Tables(1).Rows(0).Item("branch_bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(1).Rows(0).Item("branch_bank_name")
            End If
        End If
    End Function

    Private Function SaveDataToLoanNotice() As Boolean

        If Not Me.HasRecord() Then
            '�����ڿ��Ա���ķſ�����
            Return False
        End If

        Me.dgLoanNotice.Select(Me.dsLoanNotice.Tables(0).Rows.Count - 1)
        If Me.cmbVouchBank.Text.Trim() = "" Then
            'MessageBox.Show("�������벻��Ϊ�գ���ȷ�ϡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "����")
            Me.cmbVouchBank.Focus()
            Return False
        End If
        If Me.cmbVouchBranchBank.Text.Trim() = "" Then
            SWDialogBox.MessageBox.Show("$1001", "����֧��")
            Me.cmbVouchBranchBank.Focus()
            Return False
        End If
        If Me.cmbVouchAccount.Text.Trim() = "" Then
            SWDialogBox.MessageBox.Show("$1001", "������")
            Me.cmbVouchAccount.Focus()
            Return False
        End If

        Dim dr As DataRow
        Dim drs() As DataRow
        Dim nowDate As Date = gWs.GetSysTime()
        Try
            Me.Cursor = Cursors.WaitCursor
            ds = gWs.GetLoanNoticeInfo("{project_code = '" & Me.strProjectCode & "' ORDER BY create_date}")

            Dim bRowFinded As Boolean = False

            If Me._bIsModified = True Then
                Dim dsTemp As DataSet = gWs.GetProjectOpinionByProjectNo("{project_code=" & Me.strProjectCode & " AND item_type='54' AND item_code='001'}")
                For Each dr In Me.ds.Tables(0).Rows
                    drs = dsTemp.Tables(0).Select("file_relation_num=" & dr("notice_code"))
                    If drs.Length = 0 Then
                        With dr
                            .Item("bank") = Me.BankCode
                            .Item("branch_bank") = Me.BranchBankCode
                            .Item("sum") = Currency2Double(Me.cmbVouchAccount.Text.Trim())
                            .Item("term") = Currency2Double(Me.cmbVouchTerms.Text.Trim())
                            .Item("create_date") = nowDate
                            .Item("create_person") = UserName
                        End With
                        bRowFinded = True
                    End If
                Next
                If Not bRowFinded Then
                    MessageBox.Show("δ�ҵ���֮��Ӧ�ļ�¼")
                    Return False
                End If
            Else
                If Not ds.Tables(0).Rows.Count = 0 AndAlso IsDBNull(ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("affirm_person")) Then
                    '�������һ��ǩ����Ϊ�յļ�¼���޸�������¼
                    With ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)
                        .Item("bank") = Me.BankCode
                        .Item("branch_bank") = Me.BranchBankCode
                        .Item("sum") = Currency2Double(Me.cmbVouchAccount.Text.Trim())
                        .Item("term") = Currency2Double(Me.cmbVouchTerms.Text.Trim())
                    End With
                Else
                    With Me.ds.Tables(0)
                        dr = .NewRow()
                        With dr
                            .Item("project_code") = Me.strProjectCode
                            .Item("bank") = Me.BankCode
                            .Item("branch_bank") = Me.BranchBankCode
                            .Item("sum") = Currency2Double(Me.cmbVouchAccount.Text.Trim())
                            .Item("term") = Currency2Double(Me.cmbVouchTerms.Text.Trim())
                            .Item("create_date") = nowDate
                            .Item("create_person") = UserName
                        End With
                        .Rows.Add(dr)
                    End With
                End If
            End If

            Dim strResult As String = gWs.UpdateLoanNotice(ds)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "����ʧ��", strResult, "")
                Return False
            Else
                Me.bTextChanged = False
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    '���ѡ��datagrid�е����������Ŀؼ�
    Protected Overridable Sub dgLoanNotice_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgLoanNotice.MouseUp
        If Me.dsLoanNotice Is Nothing OrElse Me.dsLoanNotice.Tables(0).Rows.Count = 0 Then
            Return
        End If
        Dim index As Integer = Me.dgLoanNotice.CurrentRowIndex
        Me.dgLoanNotice.Select(index)

        Me.bOperate = False  '����bTextChanged�ĸı�
        Me.cmbVouchBank.Text = Me.dgLoanNotice.Item(index, 1)
        Me.cmbVouchBranchBank.Text = Me.dgLoanNotice.Item(index, 2)
        Me.cmbVouchAccount.Text = Me.dgLoanNotice.Item(index, 3)
        Me.cmbVouchTerms.Text = Me.dgLoanNotice.Item(index, 4)

        If index = Me.dsLoanNotice.Tables(0).Rows.Count - 1 AndAlso Me.HasRecord() Then
            Me.bOperate = True
            Me.GroupBox2.Text = "��ǰ�ķſ���Ϣ"
            Me.ControlEnabled = True
        Else
            Me.GroupBox2.Text = "���еķſ���Ϣ"
            Me.ControlEnabled = False
        End If

    End Sub

#Region "�鿴����"
    '˫������DataGrid
    Private Sub dgDatum_DoubleClick(ByVal sender As System.Object, ByVal ne As System.EventArgs) Handles dgDatum.DoubleClick
        If Me.dgDatum.DataSource Is Nothing Then
            Return
        End If
        If Me.dgDatum(dgDatum.CurrentRowIndex, 4).ToString().Trim() = "" Then
            Return
        End If
        Dim bIsGuarantee As Boolean = False
        Select Case Me.dgDatum.Item(dgDatum.CurrentRowIndex, 4).ToString().Trim()
            Case "006"               '��Ѻ�Ǽ��Ѱ��ײ���������ı�������
                Dim f As New frmRegistryAffirm(Me.strProjectCode, True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "007"               '��Ѻ�Ǽ��Ѱ��ײ���������ı�������
                Dim f As New frmPledgeRegistryAffirm(Me.strProjectCode, True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "008"               '��Ѻ�������ﱣ���Ѱ��ײ�ע������Ϊ��һ������(��������ȷ��)
            Case "009"               '�Ѱ���Ʋ�����������Ȩ����֤��(Ԥ�䵱����ȷ��)
            Case "011"               '��������������ȷ��
            Case "013"               '�������ȷ��
                Dim f As New frmWardAffirm(Me.strProjectCode, True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "014"               '�����ı�ȷ��
        End Select

        If Not bIsGuarantee Then
            Dim frm As New FViewConfirmItem(Me.strProjectCode, Me.dgDatum.Item(dgDatum.CurrentRowIndex, 4).ToString().Trim())
            frm.AllowTransparency = False
            frm.ShowDialog()
        End If
    End Sub
    '�鿴����
    Private Sub btnViewAffirmContent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAffirmContent.Click
        dgDatum_DoubleClick(Nothing, Nothing)
    End Sub
#End Region

#Region "��ť"

    '������ť
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim intTrialTimes, intTerms As Integer
        '���TrialTimes��
        ds = gWs.GetConfTrialInfo("{project_code='" & Me.strProjectCode & "' and trial_conclusion='ͨ��' ORDER BY trial_times DESC}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                intTrialTimes = IIf(IsDBNull(.Item("trial_times")), 0, .Item("trial_times"))
                intTerms = IIf(IsDBNull(.Item("terms")), 0, .Item("terms"))
                Me.cmbRefundType.Text = IIf(IsDBNull(.Item("refund_type")), "", .Item("refund_type"))
            End With
        End If

        Dim strSignBankCode, strSignBankBranchCode As String
        Dim dSignSum As Double

        ds = gWs.GetProjectInfoEx("{ProjectCode='" & Me.strProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strSignBankCode = IIf(IsDBNull(.Item("sign_bank")), "", .Item("sign_bank"))
                strSignBankBranchCode = IIf(IsDBNull(.Item("sign_bank_branch")), "", .Item("sign_bank_branch"))
                dSignSum = IIf(IsDBNull(.Item("sign_sum")), 0D, .Item("sign_sum"))
            End With
        End If

        With dsLoanNotice.Tables(0)
            Dim dr As DataRow
            dr = .NewRow
            With dr
                .Item("bank") = strSignBankCode      '"δȷ��"
                .Item("branch_bank") = strSignBankBranchCode
                .Item("sum") = dSignSum
                .Item("term") = intTerms
                .Item("create_person") = UserName
            End With
            .Rows.Add(dr)
            Me.intLoanCount = Me.intLoanCount + 1
        End With
        Call Me.GetDataGridBankName()
        Me.bTextChanged = True
        Me.dgLoanNotice.Select(Me.dsLoanNotice.Tables(0).Rows.Count - 1)
        Me.bOperate = True
        Me.ControlEnabled = True
        Me.btnAdd.Enabled = False
    End Sub
    '���水ť
    Protected Overridable Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not Me.SaveDataToLoanNotice() Then
                Return
            End If
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '�˳���ť
    Protected Overrides Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.bTextChanged = False Then
            Me.Close()
            Return
        End If
        Select Case SWDialogBox.MessageBox.Show("?1003")
            Case DialogResult.Yes
                If Not Me.SaveDataToLoanNotice() Then
                    Return
                End If
                SWDialogBox.MessageBox.Show("$OperateSucceed")
            Case DialogResult.Cancel
                Return
        End Select
        Me.Close()
    End Sub
    '�ύ��ť
    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("��ȷ���ύ��", MsgBoxStyle.OKCancel Or MsgBoxStyle.Question, "��Ŀ����") 
        If SWDialogBox.MessageBox.Show("?1000", "�ύ") <> MsgBoxResult.Yes Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Try
            If Not Me.SaveDataToLoanNotice() Then
                Return
            End If

            '2007-12-14 yjf add �ſ�ǰ��Ҫ��֤�������Ƿ���ȡ���
            If Not CheckGuaranteeFeeBalance() Then
                MsgBox("����δ����", MsgBoxStyle.Information, "��ʾ")
                Return
            End If

            Dim strResult As String = gWs.finishedTask(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID, "", Me.strUserID)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "�ύʧ��", strResult, "����ſ�")
            Else
                MyBase.raiseCommitSucceed()
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                Me.Close()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function CheckGuaranteeFeeBalance() As Boolean
        Dim strSql As String = "{project_code=" & "'" & MyBase.getProjectCode & "'" & " and (item_type + item_code ='31001'" & " or item_type + item_code='31002' or item_type + item_code='34009' " & ")}"
        Dim dsTemp As DataSet = gWs.GetProjectAccountDetailInfo(strSql)
        Dim i As Integer

        Dim TrialFeePayout As Integer = 0
        Dim TotalTrialFeeIncome As Integer = 0
        '������õ������ܶ�
        For i = 0 To dsTemp.Tables(0).Rows.Count - 1
            TrialFeePayout = CInt(TrialFeePayout + IIf(IsDBNull(dsTemp.Tables(0).Rows(i).Item("payout")), 0, dsTemp.Tables(0).Rows(i).Item("payout")))
            TotalTrialFeeIncome = CInt(TotalTrialFeeIncome + IIf(IsDBNull(dsTemp.Tables(0).Rows(i).Item("income")), 0, dsTemp.Tables(0).Rows(i).Item("income")))
        Next
        If TrialFeePayout <= TotalTrialFeeIncome Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region




    Private Sub cmbVouchAccount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVouchAccount.TextChanged
        If Me.bOperate = True Then
            Me.dgLoanNotice.Item(Me.dgLoanNotice.CurrentRowIndex, 3) = Me.cmbVouchAccount.Text
            Me.bTextChanged = True
        End If
    End Sub

    Private Sub cmbVouchTerms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVouchTerms.TextChanged
        Try
            cmbVouchTerms.Text = CType(cmbVouchTerms.Text, Integer).ToString
            If Not Me.cmbVouchAccount.Text.IndexOf("-") = -1 Then
                cmbVouchTerms.Text = "0"
            End If
        Catch
            cmbVouchTerms.Text = "0"
        End Try
        If Me.bOperate = True Then
            Me.dgLoanNotice.Item(Me.dgLoanNotice.CurrentRowIndex, 4) = Me.cmbVouchTerms.Text
            Me.bTextChanged = True
        End If
    End Sub

    Private Sub cmbVouchTerms_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVouchTerms.KeyPress
        Try
            Call Me.SendKeys(1, Me.cmbVouchTerms.Text.Trim(), e)
        Catch
            Me.cmbVouchTerms.Text = "0"
        End Try

    End Sub
    '
    Private Sub cmbVouchBank_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVouchBank.SelectedIndexChanged
        Dim TempDS As DataSet
        TempDS = gWs.GetBankInfo("{bank_name='" & Me.cmbVouchBank.Text & "'}", "null")
        If Not TempDS.Tables(0).Rows.Count = 0 Then
            Me.BankCode = TempDS.Tables(0).Rows(0).Item("bank_code")
        End If
        TempDS = gWs.GetBankInfo("null", "{bank_code='" & Me.BankCode & "'}")
        Call Me.GetBankNameList(Me.cmbVouchBranchBank, TempDS, "bank_branch", "branch_bank_name")
        Me.cmbVouchBranchBank.Text = ""
        If Me.bOperate = True Then
            Me.dgLoanNotice.Item(Me.dgLoanNotice.CurrentRowIndex, 1) = Me.cmbVouchBank.Text
            Me.bTextChanged = True
        End If
    End Sub

    Private Sub cmbVouchBranchBank_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVouchBranchBank.TextChanged
        Dim TempDS As DataSet
        TempDS = gWs.GetBankInfo("null", "{bank_code='" & Me.BankCode & "' and branch_bank_name='" & Me.cmbVouchBranchBank.Text.Trim() & "'}")
        If Not TempDS.Tables(1).Rows.Count = 0 Then
            Me.BranchBankCode = TempDS.Tables(1).Rows(0).Item("branch_bank_code")
        End If
        If Me.bOperate = True Then
            Me.dgLoanNotice.Item(Me.dgLoanNotice.CurrentRowIndex, 2) = Me.cmbVouchBranchBank.Text
            Me.bTextChanged = True
        End If
    End Sub

    Private Sub btnUploadReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadReport.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ds = gWs.GetServiceType("{service_type=(SELECT TOP 1 service_type FROM conference_trial WHERE project_code LIKE '" & Me.strProjectCode & "' AND status=1 ORDER BY trial_times DESC )}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                'If ((((((((((ds.Tables(0).Rows(0).Item("service_type_code") = "01" Or ds.Tables(0).Rows(0).Item("service_type_code") = "03") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "04") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "05") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "06") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "07") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "08") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "09") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "10") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "11") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "18") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "12") Then '�����ſ�֪ͨ��
                '    Call Me.UploadDocument01(Me.strProjectCode, "45", "010")
                'ElseIf ds.Tables(0).Rows(0).Item("service_type_code") = "02" Then   'ί�зſ�֪ͨ��
                '    Call Me.UploadDocument02(Me.strProjectCode, "45", "009")
                'End If

                If ds.Tables(0).Rows(0).Item("service_type_code") = "02" Then
                    Call Me.UploadDocument02(Me.strProjectCode, "45", "009") 'ί�зſ�֪ͨ��
                Else
                    Call Me.UploadDocument01(Me.strProjectCode, "45", "010") '�����ſ�֪ͨ��
                End If
            Else
                SWDialogBox.MessageBox.Show("�Ҳ���������������ж�Ӧ��ҵ��Ʒ��!", "ϵͳ��ʾ", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '
    '��ӡService_Type_Code='01' �ſ�֪ͨ�顣�����ſ�֪ͨ�顣
    '
    Private Sub UploadDocument01(ByVal ProjectCode As String, ByVal ItemType As String, ByVal ItemCode As String)
        Dim strReplaceFrom(14) As String, strReplaceTo(14) As String
        Dim Sum As Double
        strReplaceFrom(0) = "&#CorporationName"
        strReplaceFrom(1) = "&#BankName"
        strReplaceFrom(2) = "&#BranchBankName"
        strReplaceFrom(3) = "&#RefundAverage"
        strReplaceFrom(4) = "&#GuaranteeSum"
        strReplaceFrom(5) = "&#VouchTerminate"

        strReplaceFrom(6) = "&#ACorporationName"
        strReplaceFrom(7) = "&#BCorporationName"
        strReplaceFrom(8) = "&#ABankName"
        strReplaceFrom(9) = "&#BBankName"
        strReplaceFrom(10) = "&#ABranchBankName"
        strReplaceFrom(11) = "&#BBranchBankName"
        strReplaceFrom(12) = "&#AGuaranteeSum"
        strReplaceFrom(13) = "&#AVouchTerminate"
        strReplaceFrom(14) = "&#ARefundAverage"

        'ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        ds = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(0) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
                strReplaceTo(6) = strReplaceTo(0) : strReplaceTo(7) = strReplaceTo(0)
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "' order by create_date desc}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), Nothing)
                strReplaceTo(2) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank")))
                strReplaceTo(8) = strReplaceTo(1) : strReplaceTo(9) = strReplaceTo(1)
                strReplaceTo(10) = strReplaceTo(2) : strReplaceTo(11) = strReplaceTo(2)

                If System.Text.RegularExpressions.Regex.IsMatch(Me.cmbVouchAccount.Text, "^(-?\d+)(\.\d+)$") Then
                    strReplaceTo(4) = (CDec(Me.cmbVouchAccount.Text) * 1000)
                Else
                    strReplaceTo(4) = ""
                End If
                'Sum = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                'strReplaceTo(4) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
                strReplaceTo(5) = Convert.ToString(IIf(.Item("term") Is System.DBNull.Value, 0, .Item("term"))) + "����"
                strReplaceTo(12) = strReplaceTo(4) : strReplaceTo(13) = strReplaceTo(5)
            End With
        End If
        ds = gWs.GetConfTrialInfo("{project_code='" & ProjectCode & "' and trial_conclusion='ͨ��'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Dim Temp As String
                Temp = IIf(.Item("refund_type") Is System.DBNull.Value, "", .Item("refund_type"))
                Sum = IIf(.Item("refund_sum_average") Is System.DBNull.Value, 0, .Item("refund_sum_average"))
                strReplaceTo(3) = Temp + Money2String.Money2String.GetCnString(Convert.ToString(Sum))
                strReplaceTo(14) = strReplaceTo(3)
            End With
        End If
        Dim arrReplaceTo As New ArrayList
        For i = 0 To 14
            arrReplaceTo.Add(strReplaceTo(i))
        Next
        Dim frm As New frmDocumentManageBusiness(Me.strProjectCode, Me.strTaskID, Me.strEnterpriseName, ItemType, ItemCode, Me.strUserID, strReplaceFrom, arrReplaceTo)
        frm.AllowTransparency = False
        If Not Me.strTaskID = "LoanApplication" Then
            frm.setIsButtonEnable(True)
        End If
        frm.ShowDialog()
    End Sub
    '
    '��ӡService_Type_Code='02' �ſ�֪ͨ�顣ί�зſ�֪ͨ�顣
    '
    Private Sub UploadDocument02(ByVal ProjectCode As String, ByVal ItemType As String, ByVal ItemCode As String)
        Dim strReplaceFrom(14) As String, strReplaceTo(14) As String
        Dim Sum As Double
        strReplaceFrom(0) = "&#CorporationName"
        strReplaceFrom(1) = "&#BankName"
        strReplaceFrom(2) = "&#BranchBankName"
        strReplaceFrom(3) = "&#BankCreditNo"
        strReplaceFrom(4) = "&#GuaranteeSum"
        strReplaceFrom(5) = "&#VouchTerminate"

        strReplaceFrom(6) = "&#ACorporationName"
        strReplaceFrom(7) = "&#BCorporationName"
        strReplaceFrom(8) = "&#ABankName"
        strReplaceFrom(9) = "&#BBankName"
        strReplaceFrom(10) = "&#ABranchBankName"
        strReplaceFrom(11) = "&#BBranchBankName"
        strReplaceFrom(12) = "&#AGuaranteeSum"
        strReplaceFrom(13) = "&#AVouchTerminate"

        'ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        ds = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(0) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
                strReplaceTo(6) = strReplaceTo(0)
                strReplaceTo(7) = strReplaceTo(0)
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "' order by create_date desc}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), Nothing)
                strReplaceTo(2) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank")))
                strReplaceTo(8) = strReplaceTo(1) : strReplaceTo(9) = strReplaceTo(1)
                strReplaceTo(10) = strReplaceTo(2) : strReplaceTo(11) = strReplaceTo(2)

                If System.Text.RegularExpressions.Regex.IsMatch(Me.cmbVouchAccount.Text, "^(-?\d+)(\.\d+)$") Then
                    strReplaceTo(4) = (CDec(Me.cmbVouchAccount.Text) * 1000)
                Else
                    strReplaceTo(4) = ""
                End If

                'Sum = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                'strReplaceTo(4) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
                strReplaceTo(5) = Convert.ToString(IIf(.Item("term") Is System.DBNull.Value, 0, .Item("term"))) + "����"
                strReplaceTo(12) = strReplaceTo(4)
                strReplaceTo(13) = strReplaceTo(5)
            End With
        End If
        strReplaceTo(3) = "                    "
        Dim arrReplaceTo As New ArrayList
        For i = 0 To 14
            arrReplaceTo.Add(strReplaceTo(i))
        Next
        Dim frm As New frmDocumentManageBusiness(Me.strProjectCode, Me.strTaskID, Me.strEnterpriseName, ItemType, ItemCode, Me.strUserID, strReplaceFrom, arrReplaceTo)
        frm.AllowTransparency = False
        If Not Me.strTaskID = "LoanApplication" Then
            frm.setIsButtonEnable(True)
        End If
        frm.ShowDialog()
    End Sub

End Class
