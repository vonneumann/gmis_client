
'��ҵ������������
Public Class frmEnterPriseIntent
    Inherits frmBusinessBaseWin

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
    Protected WithEvents TabControl1 As System.Windows.Forms.TabControl
    Protected WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtReturnType As System.Windows.Forms.TextBox
    Protected WithEvents txtVouchDeadline As System.Windows.Forms.TextBox
    Protected WithEvents cmbLoanVouchBranchBank As System.Windows.Forms.ComboBox
    Protected WithEvents Label7 As System.Windows.Forms.Label
    Protected WithEvents txtVouchAccount As System.Windows.Forms.TextBox
    Protected WithEvents Label8 As System.Windows.Forms.Label
    Protected WithEvents cmbLoanVouchBank As System.Windows.Forms.ComboBox
    Protected WithEvents Label5 As System.Windows.Forms.Label
    Protected WithEvents Label4 As System.Windows.Forms.Label
    Protected WithEvents btnDelete As System.Windows.Forms.Button
    Protected WithEvents btnEdit As System.Windows.Forms.Button
    Protected WithEvents btnAdd As System.Windows.Forms.Button
    Protected WithEvents TabPage1 As System.Windows.Forms.TabPage
    Protected WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Protected WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents dtpSignDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents Label3 As System.Windows.Forms.Label
    Protected WithEvents Label13 As System.Windows.Forms.Label
    Protected WithEvents cmbSignPerson As System.Windows.Forms.ComboBox
    Protected WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Protected WithEvents Label11 As System.Windows.Forms.Label
    Protected WithEvents Label9 As System.Windows.Forms.Label
    Protected WithEvents Label10 As System.Windows.Forms.Label
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents btnNext As System.Windows.Forms.Button
    Protected WithEvents btnPrevious As System.Windows.Forms.Button
    Protected WithEvents dgIntentLetter As System.Windows.Forms.DataGrid
    Protected WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Protected WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents DataGridTextBoxColumn71 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents DataGridTextBoxColumn72 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents cmbSignOpinion As System.Windows.Forms.ComboBox
    Protected WithEvents txtBankVouchAccount As System.Windows.Forms.TextBox
    Protected WithEvents dtpBankRelapseDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents cmbBankRelapseOpinion As System.Windows.Forms.ComboBox
    Protected WithEvents btnPrint As System.Windows.Forms.Button
    Protected WithEvents Label16 As System.Windows.Forms.Label
    Protected WithEvents txtAverageRefundSum As System.Windows.Forms.TextBox
    Protected WithEvents Label18 As System.Windows.Forms.Label
    Protected WithEvents Label20 As System.Windows.Forms.Label
    Protected WithEvents Label21 As System.Windows.Forms.Label
    Protected WithEvents cmbBankReplyRefundType As System.Windows.Forms.ComboBox
    Protected WithEvents txtBankReplyAverageSum As System.Windows.Forms.TextBox
    Protected WithEvents txtBankReplyTerms As System.Windows.Forms.TextBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEnterPriseIntent))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgIntentLetter = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn71 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn72 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbSignOpinion = New System.Windows.Forms.ComboBox()
        Me.cmbSignPerson = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpSignDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAverageRefundSum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReturnType = New System.Windows.Forms.TextBox()
        Me.txtVouchDeadline = New System.Windows.Forms.TextBox()
        Me.cmbLoanVouchBranchBank = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVouchAccount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbLoanVouchBank = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbBankReplyRefundType = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtBankReplyAverageSum = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBankReplyTerms = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBankVouchAccount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpBankRelapseDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbBankRelapseOpinion = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgIntentLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 6)
        Me.txtProjectCode.Size = New System.Drawing.Size(104, 21)
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 8)
        Me.Label2.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(264, 6)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(304, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(291, 462)
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Visible = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1})
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 424)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPrint, Me.dgIntentLetter, Me.GroupBox3, Me.GroupBox2, Me.GroupBox1, Me.btnDelete, Me.btnEdit, Me.btnAdd, Me.btnSave, Me.btnNext, Me.btnPrevious})
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(552, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "��ҵ��������"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Bitmap)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.ImageIndex = 19
        Me.btnPrint.ImageList = Me.ImageListBasic
        Me.btnPrint.Location = New System.Drawing.Point(96, 368)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(96, 23)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "�����ĵ�(&M)"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgIntentLetter
        '
        Me.dgIntentLetter.CaptionVisible = False
        Me.dgIntentLetter.DataMember = ""
        Me.dgIntentLetter.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgIntentLetter.Location = New System.Drawing.Point(8, 8)
        Me.dgIntentLetter.Name = "dgIntentLetter"
        Me.dgIntentLetter.ReadOnly = True
        Me.dgIntentLetter.Size = New System.Drawing.Size(536, 80)
        Me.dgIntentLetter.TabIndex = 32
        Me.dgIntentLetter.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgIntentLetter
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn71, Me.DataGridTextBoxColumn72, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "intent_letter"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "���"
        Me.DataGridTextBoxColumn1.MappingName = "intent_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 38
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "��Ŀ���"
        Me.DataGridTextBoxColumn2.MappingName = "project_code"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 71
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "��������"
        Me.DataGridTextBoxColumn3.MappingName = "loan_bank"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 115
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "�������"
        Me.DataGridTextBoxColumn4.MappingName = "loan_branch_bank"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 117
        '
        'DataGridTextBoxColumn71
        '
        Me.DataGridTextBoxColumn71.Format = ""
        Me.DataGridTextBoxColumn71.FormatInfo = Nothing
        Me.DataGridTextBoxColumn71.HeaderText = "ǩ����"
        Me.DataGridTextBoxColumn71.MappingName = "sign_person"
        Me.DataGridTextBoxColumn71.NullText = ""
        Me.DataGridTextBoxColumn71.Width = 75
        '
        'DataGridTextBoxColumn72
        '
        Me.DataGridTextBoxColumn72.Format = ""
        Me.DataGridTextBoxColumn72.FormatInfo = Nothing
        Me.DataGridTextBoxColumn72.HeaderText = "ǩ�����"
        Me.DataGridTextBoxColumn72.MappingName = "sign_opinion"
        Me.DataGridTextBoxColumn72.NullText = ""
        Me.DataGridTextBoxColumn72.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "���лظ�"
        Me.DataGridTextBoxColumn6.MappingName = "bank_reply"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "�ظ����(��)"
        Me.DataGridTextBoxColumn7.MappingName = "reply_sum"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 80
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbSignOpinion, Me.cmbSignPerson, Me.Label13, Me.dtpSignDate, Me.Label3})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 48)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ǩ����Ϣ"
        '
        'cmbSignOpinion
        '
        Me.cmbSignOpinion.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSignOpinion.Location = New System.Drawing.Point(368, 20)
        Me.cmbSignOpinion.Name = "cmbSignOpinion"
        Me.cmbSignOpinion.Size = New System.Drawing.Size(152, 20)
        Me.cmbSignOpinion.TabIndex = 7
        '
        'cmbSignPerson
        '
        Me.cmbSignPerson.Enabled = False
        Me.cmbSignPerson.Location = New System.Drawing.Point(368, 16)
        Me.cmbSignPerson.Name = "cmbSignPerson"
        Me.cmbSignPerson.Size = New System.Drawing.Size(120, 20)
        Me.cmbSignPerson.TabIndex = 32
        Me.cmbSignPerson.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(272, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "ǩ�����"
        '
        'dtpSignDate
        '
        Me.dtpSignDate.Location = New System.Drawing.Point(104, 20)
        Me.dtpSignDate.Name = "dtpSignDate"
        Me.dtpSignDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpSignDate.TabIndex = 6
        Me.dtpSignDate.Value = New Date(2003, 9, 22, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "ǩ������"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label16, Me.txtAverageRefundSum, Me.Label6, Me.txtReturnType, Me.txtVouchDeadline, Me.cmbLoanVouchBranchBank, Me.Label7, Me.txtVouchAccount, Me.Label8, Me.cmbLoanVouchBank, Me.Label5, Me.Label4})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 96)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "��������"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(272, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "ÿ�λ����(Ԫ)"
        '
        'txtAverageRefundSum
        '
        Me.txtAverageRefundSum.BackColor = System.Drawing.SystemColors.Window
        Me.txtAverageRefundSum.Enabled = False
        Me.txtAverageRefundSum.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtAverageRefundSum.Location = New System.Drawing.Point(368, 64)
        Me.txtAverageRefundSum.Name = "txtAverageRefundSum"
        Me.txtAverageRefundSum.ReadOnly = True
        Me.txtAverageRefundSum.Size = New System.Drawing.Size(152, 21)
        Me.txtAverageRefundSum.TabIndex = 5
        Me.txtAverageRefundSum.Text = ""
        Me.txtAverageRefundSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "���ʽ"
        '
        'txtReturnType
        '
        Me.txtReturnType.BackColor = System.Drawing.SystemColors.Window
        Me.txtReturnType.Enabled = False
        Me.txtReturnType.Location = New System.Drawing.Point(104, 64)
        Me.txtReturnType.Name = "txtReturnType"
        Me.txtReturnType.Size = New System.Drawing.Size(152, 21)
        Me.txtReturnType.TabIndex = 4
        Me.txtReturnType.Text = ""
        '
        'txtVouchDeadline
        '
        Me.txtVouchDeadline.BackColor = System.Drawing.SystemColors.Window
        Me.txtVouchDeadline.Enabled = False
        Me.txtVouchDeadline.Location = New System.Drawing.Point(104, 40)
        Me.txtVouchDeadline.Name = "txtVouchDeadline"
        Me.txtVouchDeadline.Size = New System.Drawing.Size(152, 21)
        Me.txtVouchDeadline.TabIndex = 2
        Me.txtVouchDeadline.Text = ""
        Me.txtVouchDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbLoanVouchBranchBank
        '
        Me.cmbLoanVouchBranchBank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLoanVouchBranchBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoanVouchBranchBank.Location = New System.Drawing.Point(368, 16)
        Me.cmbLoanVouchBranchBank.Name = "cmbLoanVouchBranchBank"
        Me.cmbLoanVouchBranchBank.Size = New System.Drawing.Size(152, 20)
        Me.cmbLoanVouchBranchBank.Sorted = True
        Me.cmbLoanVouchBranchBank.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(272, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "�������(��Ԫ)"
        '
        'txtVouchAccount
        '
        Me.txtVouchAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtVouchAccount.Enabled = False
        Me.txtVouchAccount.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtVouchAccount.Location = New System.Drawing.Point(368, 40)
        Me.txtVouchAccount.Name = "txtVouchAccount"
        Me.txtVouchAccount.Size = New System.Drawing.Size(152, 21)
        Me.txtVouchAccount.TabIndex = 3
        Me.txtVouchAccount.Text = ""
        Me.txtVouchAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "��������(��)"
        '
        'cmbLoanVouchBank
        '
        Me.cmbLoanVouchBank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLoanVouchBank.Location = New System.Drawing.Point(104, 16)
        Me.cmbLoanVouchBank.Name = "cmbLoanVouchBank"
        Me.cmbLoanVouchBank.Size = New System.Drawing.Size(152, 20)
        Me.cmbLoanVouchBank.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(272, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "�������֧��"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "�����������"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbBankReplyRefundType, Me.Label20, Me.txtBankReplyAverageSum, Me.Label21, Me.txtBankReplyTerms, Me.Label18, Me.Label11, Me.txtBankVouchAccount, Me.Label9, Me.dtpBankRelapseDate, Me.Label10, Me.cmbBankRelapseOpinion})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 104)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "���лظ����"
        '
        'cmbBankReplyRefundType
        '
        Me.cmbBankReplyRefundType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbBankReplyRefundType.Enabled = False
        Me.cmbBankReplyRefundType.ItemHeight = 12
        Me.cmbBankReplyRefundType.Location = New System.Drawing.Point(104, 70)
        Me.cmbBankReplyRefundType.Name = "cmbBankReplyRefundType"
        Me.cmbBankReplyRefundType.Size = New System.Drawing.Size(152, 20)
        Me.cmbBankReplyRefundType.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(272, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "ÿ�λ����(Ԫ)"
        '
        'txtBankReplyAverageSum
        '
        Me.txtBankReplyAverageSum.BackColor = System.Drawing.SystemColors.Window
        Me.txtBankReplyAverageSum.Enabled = False
        Me.txtBankReplyAverageSum.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtBankReplyAverageSum.Location = New System.Drawing.Point(368, 70)
        Me.txtBankReplyAverageSum.Name = "txtBankReplyAverageSum"
        Me.txtBankReplyAverageSum.ReadOnly = True
        Me.txtBankReplyAverageSum.Size = New System.Drawing.Size(152, 21)
        Me.txtBankReplyAverageSum.TabIndex = 13
        Me.txtBankReplyAverageSum.Text = ""
        Me.txtBankReplyAverageSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 72)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 16)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "���ʽ"
        '
        'txtBankReplyTerms
        '
        Me.txtBankReplyTerms.BackColor = System.Drawing.SystemColors.Window
        Me.txtBankReplyTerms.Enabled = False
        Me.txtBankReplyTerms.Location = New System.Drawing.Point(368, 46)
        Me.txtBankReplyTerms.Name = "txtBankReplyTerms"
        Me.txtBankReplyTerms.ReadOnly = True
        Me.txtBankReplyTerms.Size = New System.Drawing.Size(152, 21)
        Me.txtBankReplyTerms.TabIndex = 11
        Me.txtBankReplyTerms.Text = ""
        Me.txtBankReplyTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(272, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 16)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "��������(��)"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "ͬ����(��Ԫ)"
        '
        'txtBankVouchAccount
        '
        Me.txtBankVouchAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtBankVouchAccount.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtBankVouchAccount.Location = New System.Drawing.Point(104, 46)
        Me.txtBankVouchAccount.Name = "txtBankVouchAccount"
        Me.txtBankVouchAccount.Size = New System.Drawing.Size(152, 21)
        Me.txtBankVouchAccount.TabIndex = 10
        Me.txtBankVouchAccount.Text = ""
        Me.txtBankVouchAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "���лظ�����"
        '
        'dtpBankRelapseDate
        '
        Me.dtpBankRelapseDate.Location = New System.Drawing.Point(104, 22)
        Me.dtpBankRelapseDate.Name = "dtpBankRelapseDate"
        Me.dtpBankRelapseDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpBankRelapseDate.TabIndex = 8
        Me.dtpBankRelapseDate.Value = New Date(2003, 9, 22, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(272, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "���лظ����"
        '
        'cmbBankRelapseOpinion
        '
        Me.cmbBankRelapseOpinion.BackColor = System.Drawing.SystemColors.Window
        Me.cmbBankRelapseOpinion.ItemHeight = 12
        Me.cmbBankRelapseOpinion.Location = New System.Drawing.Point(368, 22)
        Me.cmbBankRelapseOpinion.Name = "cmbBankRelapseOpinion"
        Me.cmbBankRelapseOpinion.Size = New System.Drawing.Size(152, 20)
        Me.cmbBankRelapseOpinion.TabIndex = 9
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(376, 368)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "ɾ ��(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Bitmap)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.ImageIndex = 27
        Me.btnEdit.ImageList = Me.ImageListBasic
        Me.btnEdit.Location = New System.Drawing.Point(288, 368)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(77, 23)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "�� ��(&M)"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Bitmap)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageIndex = 13
        Me.btnAdd.ImageList = Me.ImageListBasic
        Me.btnAdd.Location = New System.Drawing.Point(200, 368)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "�� ��(&A)"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(461, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNext
        '
        Me.btnNext.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(64, 368)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(32, 23)
        Me.btnNext.TabIndex = 29
        Me.btnNext.Text = "��(&N) >>"
        Me.btnNext.Visible = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.Location = New System.Drawing.Point(24, 368)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(32, 23)
        Me.btnPrevious.TabIndex = 28
        Me.btnPrevious.Text = "<< ǰ��(&P)"
        Me.btnPrevious.Visible = False
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(207, 462)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 19
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmEnterPriseIntent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(578, 491)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.btnCommit, Me.TabControl1})
        Me.Name = "frmEnterPriseIntent"
        Me.Text = "��ҵ������������"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgIntentLetter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds, TempDS As DataSet
    '��¼��ǰ���ڲ���״̬��1 ��ʾ��ǰִ������������2 ��ʾ��ǰִ���޸Ĳ�����
    Protected intOperateStatus As Integer = 0
    Protected arrIntentCode As New ArrayList()
    Protected intTrialTimes, intIntentAccount As Integer
    Protected intSearchIndex As Integer = -1
    Private strConferenceTrial As String = "ͨ��"
    Private strUpdateResult As String
    Private strBankCode, strBranchBankCode As String

    Private str, TempStr As String

    Protected bIsFormLoad As Boolean = False
    Protected bIsTextChange As Boolean = False

    Private CanBeNewIntentLetter As Boolean = False

    Private Sub frmEnterPriseIntent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbLoanVouchBank.Sorted = True
        Me.cmbLoanVouchBranchBank.Sorted = True
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            AddHandler btnDelete.Click, AddressOf btnDelete_Click
            AddHandler btnEdit.Click, AddressOf btnEdit_Click
            AddHandler btnSave.Click, AddressOf btnSave_Click
            AddHandler btnCommit.Click, AddressOf btnCommit_Click
            AddHandler btnExit.Click, AddressOf btnExit_Click

            Call Me.GetIntentReturnInfo()
            Call Me.LockContral(Me.GroupBox1)
            Call Me.LockContral(Me.GroupBox3)
            Me.bIsFormLoad = True
            'Me.CanBeNewIntentLetter = Me.CanNewIntentLetter(Me.strProjectCode)
            'If Me.CanBeNewIntentLetter = False Then Me.btnAdd.Enabled = False
            'me.lockgroupbox3
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub


    'modified by hute
    '2003-9-18
    'Private Sub ShowIntentLetterCount()
    '    str = "{��ǰ�������������" + Me.intIntentAccount.ToString() + " ��}"
    '    If Not TempStr Is Nothing Then
    '        Me.TabPage1.Text = Me.TabPage1.Text.Replace(TempStr, str)
    '    Else
    '        Me.TabPage1.Text += str
    '    End If
    '    TempStr = "{��ǰ�������������" + Me.intIntentAccount.ToString() + " ��}"
    'End Sub

    'ͨ�������GroupBox��ʵ����������GroupBox�еĿؼ��Ŀ����ԣ��Դﵽ���Ӧ�Ĺ���ʹ���ԡ�
    Protected Sub LockContral(ByVal GroupBox As System.Windows.Forms.GroupBox)
        'GroupBox.Enabled = False
        If GroupBox Is Me.GroupBox2 Then
            Me.cmbLoanVouchBank.Enabled = False
            ' Me.cmbLoanVouchBank.Sorted = True
            Me.cmbLoanVouchBranchBank.Enabled = False
            'Me.cmbLoanVouchBranchBank.Sorted = True
            Me.txtVouchAccount.Enabled = False
        ElseIf GroupBox Is Me.GroupBox1 Then
            Me.dtpBankRelapseDate.Enabled = False
            Me.txtBankVouchAccount.Enabled = False
            Me.cmbBankRelapseOpinion.Enabled = False
            Me.txtBankReplyAverageSum.Enabled = False
            Me.txtBankReplyTerms.Enabled = False
            Me.cmbBankReplyRefundType.Enabled = False
        ElseIf GroupBox Is Me.GroupBox3 Then
            Me.dtpSignDate.Enabled = False
            Me.cmbSignPerson.Enabled = False
            Me.cmbSignOpinion.Enabled = False
        End If
        Me.btnAdd.Enabled = True : Me.btnEdit.Enabled = True : Me.btnDelete.Enabled = True
        Me.btnSave.Enabled = False : Me.btnPrevious.Enabled = True : Me.btnNext.Enabled = True
        Me.btnAdd.Text = "�� ��(&A)" : Me.btnEdit.Text = "�� ��(&M)"
        Me.dgIntentLetter.Enabled = True
    End Sub

    'ͨ������GroupBox��ʵ���������GroupBox���������Ŀؼ��Ŀ����ԵĲ������ԡ�
    Protected Overridable Sub FreeContral(ByVal GroupBox As System.Windows.Forms.GroupBox)
        'GroupBox.Enabled = True
        If GroupBox Is Me.GroupBox2 Then
            Me.cmbLoanVouchBank.Enabled = True : Me.cmbLoanVouchBranchBank.Enabled = True
            'Me.txtVouchAccount.Enabled = False
        ElseIf GroupBox Is Me.GroupBox1 Then
            Me.dtpBankRelapseDate.Enabled = True
            Me.txtBankVouchAccount.Enabled = True
            Me.cmbBankRelapseOpinion.Enabled = True
            Me.txtBankReplyAverageSum.Enabled = True
            Me.txtBankReplyTerms.Enabled = True
            Me.cmbBankReplyRefundType.Enabled = True
        ElseIf GroupBox Is Me.GroupBox3 Then
            Me.dtpSignDate.Enabled = True : Me.cmbSignPerson.Enabled = True
            Me.cmbSignOpinion.Enabled = True
        End If
        Me.btnDelete.Enabled = False
        Me.btnSave.Enabled = True : Me.btnPrevious.Enabled = False : Me.btnNext.Enabled = False
        If Me.intOperateStatus = 1 Then
            Me.btnAdd.Enabled = True
            Me.btnEdit.Enabled = False
            Me.btnAdd.Text = "ȡ ��(&N)"
        ElseIf Me.intOperateStatus = 2 Then
            Me.btnEdit.Enabled = True
            Me.btnAdd.Enabled = False
            Me.btnEdit.Text = "ȡ ��(&N)"
        End If
        Me.dgIntentLetter.Enabled = False
    End Sub

    'ͨ�������Ӧ����Ŀ���룬����������Ϊ��ͨ���������ݣ��������Ŀ��һЩ��ʼ�����ݣ�����ʼ����ʾ��
    Protected Sub GetIniData(ByVal ProjectCode As String, ByVal TrialOpinion As String)
        'ȡ���Ѿ�������ͨ����TrialTimes��
        ds = gWs.GetConfTrialInfo("{project_code='" & ProjectCode & "' and trial_conclusion='" & TrialOpinion & "' order by trial_times desc}", "null")
        If Not ds.Tables("conference_trial").Rows.Count = 0 Then
            With ds.Tables("conference_trial").Rows(0)
                If Not .Item("Trial_times") Is System.DBNull.Value Then
                    Me.intTrialTimes = .Item("Trial_times")
                Else
                    Me.intTrialTimes = 0
                End If
                If Not .Item("terms") Is System.DBNull.Value Then
                    Me.txtVouchDeadline.Text = .Item("terms")
                Else
                    Me.txtVouchDeadline.Text = ""
                End If
                If Not .Item("guarantee_sum") Is System.DBNull.Value Then
                    Me.txtVouchAccount.Text = .Item("guarantee_sum")
                Else
                    Me.txtVouchAccount.Text = ""
                End If
                If Not .Item("refund_type") Is System.DBNull.Value Then
                    Me.txtReturnType.Text = .Item("refund_type")
                Else
                    Me.txtReturnType.Text = ""
                End If
                Me.txtAverageRefundSum.Text = IIf(.Item("refund_sum_average") Is System.DBNull.Value, 0, .Item("refund_sum_average"))
            End With
        Else
            Me.btnPrevious.Enabled = False : Me.btnNext.Enabled = False
        End If

        '������һ���洫���ProjectCode��ȡ����TrialTimesȡ��Intent_Letter���ж�Ӧ�ļ�¼��
        Me.arrIntentCode.Clear()
        'MessageBox.Show(Me.arrIntentCode.Capacity.ToString())
        'modify by wzh ��ֹ���ڵȴ����лظ�����Ŀ�����ϻᲢѡ��ָ���Ŀ״̬�󣬵���������Ϣ��ʧ�����ܼ�¼���лظ������⡣2006-06-08
        'ds = gWs.GetIntentLetterInfo("{project_code='" & ProjectCode & "' and trial_times=" & Me.intTrialTimes & "}")
        ds = gWs.GetIntentLetterInfo("{project_code='" & ProjectCode & "' ORDER BY create_date}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            'ȡ�õ�ǰ���ϲ�ѯ������Intent_Letter��¼һ���ж��١�
            Me.intIntentAccount = ds.Tables(0).Rows.Count

            'Call Me.ShowIntentLetterCount()

            'ds.Tables(0).DefaultView.Sort = "intent_code ASC"
            'For i = 0 To ds.Tables(0).Rows.Count - 1
            '    Me.arrIntentCode.Add(Convert.ToInt16(ds.Tables(0).DefaultView.Item(i).Item("intent_code")))
            'Next
            ''MessageBox.Show(Me.arrIntentCode.Capacity.ToString())
            'If Me.arrIntentCode.Capacity > 1 Then
            '    Me.btnNext.Enabled = True : Me.btnPrevious.Enabled = False
            'Else
            '    Me.btnNext.Enabled = False : Me.btnPrevious.Enabled = False
            'End If
            'Me.intSearchIndex = 0
            Me.dgIntentLetter.DataSource = ds.Tables(0).DefaultView
            Call Me.GetDataGridBankName()
            Me.intSearchIndex = Convert.ToInt16(ds.Tables(0).DefaultView.Item(0).Item(0))
            Call Me.ShowSpecialData(Me.intSearchIndex)
        Else
            '��Ӹ���ĿĬ�ϵ�������Ϣ��
            Dim tempDS As DataSet
            tempDS = gWs.GetProjectInfo("{project_code like '" & Me.strProjectCode & "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                If Not tempDS.Tables(0).Rows(0).Item("apply_bank") Is System.DBNull.Value Then
                    Me.strBankCode = tempDS.Tables(0).Rows(0).Item("apply_bank")
                    Me.cmbLoanVouchBank.Text = Me.GetBankName(tempDS.Tables(0).Rows(0).Item("apply_bank"), Nothing)
                End If
                If Not tempDS.Tables(0).Rows(0).Item("apply_branch_bank") Is System.DBNull.Value Then
                    Me.strBranchBankCode = tempDS.Tables(0).Rows(0).Item("apply_branch_bank")
                    Me.cmbLoanVouchBranchBank.Items.Add(Me.GetBankName(tempDS.Tables(0).Rows(0).Item("apply_bank"), tempDS.Tables(0).Rows(0).Item("apply_branch_bank")))
                    Me.cmbLoanVouchBranchBank.SelectedIndex = 0
                End If
            End If
            Me.dgIntentLetter.DataSource = ds.Tables(0).DefaultView
        End If

    End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        If gWs Is Nothing Then Exit Function

        Dim TempDS As DataSet
        If BranchBankCode Is Nothing Then
            TempDS = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
            If Not TempDS.Tables(0).Rows.Count = 0 Then
                Return TempDS.Tables(0).Rows(0).Item("bank_name")
            End If
        Else
            TempDS = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
            If Not TempDS.Tables(1).Rows.Count = 0 Then
                Return TempDS.Tables(1).Rows(0).Item("branch_bank_name")
            End If
        End If
    End Function

    'ͨ�����������е�DataGrid��ʵ���е����д�����������Ӧ���������ƣ�����DataGrid����ʾ������
    Private Sub GetDataGridBankName()
        Dim BankCode, BranchBankCode As String
        Dim DsBank As DataSet

        For i = 0 To CType(Me.dgIntentLetter.DataSource, DataView).Count - 1
            If Not Me.dgIntentLetter.Item(i, 2) Is System.DBNull.Value Then
                BankCode = Me.dgIntentLetter.Item(i, 2)
                DsBank = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
                If Not DsBank.Tables(0).Rows.Count = 0 Then
                    Me.dgIntentLetter.Item(i, 2) = DsBank.Tables(0).Rows(0).Item("bank_name")
                End If
            Else
                Me.dgIntentLetter.Item(i, 2) = ""
            End If
            If Not Me.dgIntentLetter.Item(i, 3) Is System.DBNull.Value Then
                BranchBankCode = Me.dgIntentLetter.Item(i, 3)
                DsBank = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
                If Not DsBank.Tables(1).Rows.Count = 0 Then
                    Me.dgIntentLetter.Item(i, 3) = DsBank.Tables(1).Rows(0).Item("branch_bank_name")
                End If
            Else
                Me.dgIntentLetter.Item(i, 3) = ""
            End If
        Next
        Me.dgIntentLetter.CurrentRowIndex = 0
    End Sub

    'ͨ���Ϸ����·�ȷ����Ӧ��IntentCode��ʾ��Ӧ��Intent_Letter��¼��
    Protected Sub ShowSpecialData(ByVal IntentCode As Integer)
        Dim TempDs As DataSet
        Dim DsBank As DataSet
        Dim BankCode, BranchBankCode As String

        TempDs = gWs.GetIntentLetterInfo("{intent_code='" & IntentCode & "'}")
        If Not TempDs.Tables(0).Rows.Count = 0 Then
            With TempDs.Tables(0).Rows(0)
                If Not .Item("sign_date") Is System.DBNull.Value Then
                    Me.dtpSignDate.Value = .Item("sign_date")
                Else
                    Me.dtpSignDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("sign_person") Is System.DBNull.Value Then
                    Me.cmbSignPerson.Text = .Item("sign_person")
                Else
                    Me.cmbSignPerson.Text = ""
                End If
                If Not .Item("sign_opinion") Is System.DBNull.Value Then
                    Me.cmbSignOpinion.Text = .Item("sign_opinion")
                Else
                    Me.cmbSignOpinion.Text = ""
                End If
                If Not .Item("loan_bank") Is System.DBNull.Value Then
                    BankCode = .Item("loan_bank")
                    DsBank = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
                    If Not DsBank.Tables(0).Rows.Count = 0 Then
                        Me.cmbLoanVouchBank.Text = DsBank.Tables(0).Rows(0).Item("bank_name")
                    End If
                Else
                    Me.cmbLoanVouchBank.Text = ""
                End If
                If Not .Item("loan_branch_bank") Is System.DBNull.Value Then
                    BranchBankCode = .Item("loan_branch_bank")
                    DsBank = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
                    If Not DsBank.Tables(1).Rows.Count = 0 Then
                        Me.cmbLoanVouchBranchBank.Items.Clear()
                        Me.cmbLoanVouchBranchBank.Items.Add(DsBank.Tables(1).Rows(0).Item("branch_bank_name"))
                        Me.cmbLoanVouchBranchBank.SelectedIndex = 0
                    End If
                Else
                    Me.cmbLoanVouchBranchBank.Items.Clear()
                End If
                If Not .Item("reply_date") Is System.DBNull.Value Then
                    dtpBankRelapseDate.Value = .Item("reply_date")
                Else
                    dtpBankRelapseDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("bank_reply") Is System.DBNull.Value Then
                    Me.cmbBankRelapseOpinion.Text = .Item("bank_reply")
                Else
                    Me.cmbBankRelapseOpinion.Text = ""
                End If
                If Not .Item("reply_sum") Is System.DBNull.Value Then
                    Me.txtBankVouchAccount.Text = .Item("reply_sum")
                    Me.txtBankVouchAccount.Enabled = False
                Else
                    Me.txtBankVouchAccount.Text = ""
                    Me.txtBankVouchAccount.Enabled = False
                End If
                Me.txtBankReplyTerms.Text = IIf(.Item("reply_term") Is System.DBNull.Value, 0, .Item("reply_term"))
                Me.cmbBankReplyRefundType.Text = IIf(.Item("reply_refund_type") Is System.DBNull.Value, "", .Item("reply_refund_type"))
                Me.txtBankReplyAverageSum.Text = IIf(.Item("reply_refund_sum_average") Is System.DBNull.Value, 0, .Item("reply_refund_sum_average"))
            End With
        End If
    End Sub

    '��Ҫ�����ര���н������ء�
    Protected Overridable Sub GetIntentReturnInfo()
        Call Me.LockContral(Me.GroupBox2)
        Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
        'ds = gWs.GetBankInfo("%", "null")
        ' Call Me.GetBankNameList(Me.cmbLoanVouchBank, ds, "bank", "bank_name")
        'Me.cmbLoanVouchBank.DropDownStyle = ComboBoxStyle.DropDownList
        'Me.cmbLoanVouchBank.SelectedIndex = 0
    End Sub

    '�ж��Ƿ���Խ�����������������Ĳ�����
    Private Function CanNewIntentLetter(ByVal ProjectNo As String) As Boolean
        ds = gWs.GetIntentLetterInfo("{project_code='" & ProjectNo & "' order by intent_code desc}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            If ds.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function



    'ͨ����������ص�IntentCode��������ص�Intent_Letter�ļ�¼��
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call Me.GetNextClickData()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Protected Overridable Sub GetNextClickData()
        If Not Me.intSearchIndex = Me.intIntentAccount - 1 Then
            Me.intSearchIndex += 1
            Call Me.ShowSpecialData(Me.intSearchIndex)
        End If
        Call Me.BtnPreviousNextControl(Me.intSearchIndex)
    End Sub

    'ͨ����ǰ������ص�IntentCode��������ص�Intent_Letter�ļ�¼��
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call Me.GetPreviousClickData()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Protected Overridable Sub GetPreviousClickData()
        If Me.intSearchIndex > 0 Then
            Me.intSearchIndex -= 1
            Call Me.ShowSpecialData(Me.intSearchIndex)
        End If
        Call Me.BtnPreviousNextControl(Me.intSearchIndex)
    End Sub

    '�����û������Previous��Next��ť��ø�������ť��״̬��
    Private Sub BtnPreviousNextControl(ByVal Index As Integer)
        Me.btnPrevious.Enabled = True : Me.btnNext.Enabled = True
        If Index = 0 Then
            Me.btnPrevious.Enabled = False
        End If
        If Index = Me.intIntentAccount - 1 Then
            Me.btnNext.Enabled = False
        End If
    End Sub

    'ɾ��������Ҫ�������н������ء�
    Protected Overridable Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ds = gWs.GetIntentLetterInfo("{project_code='" & Me.strProjectCode & "'}")
        If ds.Tables(0).Rows.Count = 0 Then
            'MessageBox.Show("û�пɹ�ɾ������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "")
            Return
        End If
        ds = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            'If Not ds.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value Or ds.Tables(0).Rows(0).Item("bank_reply") <> "" Then
            If IIf(ds.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value, "", ds.Tables(0).Rows(0).Item("bank_reply")) <> "" Then
                'MessageBox.Show("�õ����������Ѿ��������лظ����޷�����ɾ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("$1006", "����������")
                Return
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            'If MessageBox.Show("�Ƿ�ȷ��ɾ���������������飿", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If SWDialogBox.MessageBox.Show("?1004", "����������") = DialogResult.Yes Then
                TempDS = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
                If Not TempDS.Tables(0).Rows.Count = 0 Then
                    If Not TempDS.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value Then
                        'MessageBox.Show("�������������Ѿ��������лظ����޷�����ɾ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SWDialogBox.MessageBox.Show("$1006", "��������")
                        Me.Cursor = System.Windows.Forms.Cursors.Default
                        Return
                    Else
                        TempDS.Tables(0).Rows(0).Delete()
                        Me.strUpdateResult = gWs.UpdateIntentLetter(TempDS, Nothing)
                        If Me.strUpdateResult = "1" Then
                            'SWDialogBox.MessageBox.Show("$SaveSucceed")
                        Else
                            'MessageBox.Show("���������Ѿ�ɾ��ʧ�ܣ�" + Me.strUpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            SWDialogBox.MessageBox.Show("*999", "frmEnterPriseIntent.btnDelete_Click", Me.strUpdateResult, "gWs.UpdateIntentLetter(TempDS, Nothing)")
                        End If
                        Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
                    End If
                End If
                TempDS = gWs.GetProjectFile(Me.getProjectCode, "008", "45")
                If Not TempDS.Tables("TProjectFile").Rows.Count = 0 Then
                    TempDS.Tables(0).Rows(0).Delete()
                    Me.strUpdateResult = gWs.UpdateProjectFile(TempDS)
                    If Me.strUpdateResult = "1" Then
                        'MessageBox.Show("���������Ѿ�ɾ���ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        SWDialogBox.MessageBox.Show("$SaveSucceed")
                    Else
                        SWDialogBox.MessageBox.Show("*999", "frmEnterPriseIntent.btnDelete_Click", Me.strUpdateResult, "gWs.UpdateProjectFile(TempD)")
                    End If
                End If
                If Me.CanNewIntentLetter(Me.strProjectCode) = False Then
                    Me.btnAdd.Enabled = False
                Else
                    Me.btnAdd.Enabled = True
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Me.TabPage1.Text.StartsWith("��ҵ����") Then
            If Me.intIntentAccount = 3 Then
                'MessageBox.Show("������ҵ�Ѿ������� 3 �ε����������룬�޷��ٴν��е����������롣", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("$X004")
                Return
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call Me.btnAddClickEvent()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Protected Sub btnAddClickEvent()
        ds = gWs.GetBankInfo("%", "null")
        Me.GetBankNameList(Me.cmbLoanVouchBank, ds, "bank", "bank_name")
        Me.cmbLoanVouchBank.DropDownStyle = ComboBoxStyle.DropDownList
        If Me.intOperateStatus = 0 Then
            Me.intOperateStatus = 1
            Call Me.FreeContral(Me.GroupBox2)
            Call Me.ClearContral()
        ElseIf Me.intOperateStatus = 1 Then
            Me.intOperateStatus = 0
            Call Me.LockContral(Me.GroupBox2)
            Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
        End If
    End Sub

    '�����ര����Ҫ���ش˺�����
    Private Sub ClearContral()
        Me.dtpSignDate.Value = gWs.GetSysTime()
        ds = gWs.GetIntentLetterInfo("{project_code='" & Me.strProjectCode & "' and trial_times=" & Me.intTrialTimes & "}")
        If Not ds.Tables(0).Rows.Count = 0 Then Me.cmbLoanVouchBank.Text = "" ': Me.cmbLoanVouchBranchBank.Text = ""
        Me.cmbBankRelapseOpinion.Text = "" : Me.cmbBankRelapseOpinion.Text = "" : Me.txtBankVouchAccount.Text = ""
        'Me.txtBankReplyTerms.Text = ""
        'Me.cmbBankReplyRefundType.Text = ""
        'Me.txtAverageRefundSum.Text = ""
    End Sub

    Protected Overridable Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ds = gWs.GetBankInfo("%", "null")
        Me.GetBankNameList(Me.cmbLoanVouchBank, ds, "bank", "bank_name")
        Me.cmbLoanVouchBank.DropDownStyle = ComboBoxStyle.DropDownList
        ds = gWs.GetIntentLetterInfo("{project_code='" & Me.strProjectCode & "'}")
        If ds.Tables(0).Rows.Count = 0 Then
            'MessageBox.Show("û�пɹ��޸ĵ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "")
            Return
        End If
        ds = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            'If Not ds.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value Or ds.Tables(0).Rows(0).Item("bank_reply") <> "" Then
            If IIf(ds.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value, "", ds.Tables(0).Rows(0).Item("bank_reply")) <> "" Then
                'MessageBox.Show("�õ����������Ѿ��������лظ����޷������޸Ĳ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("$X005")
                Return
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.btnEditClickEvent()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnEditClickEvent()
        'If Me.GetExistData() = "1" Then Return
        If Me.intOperateStatus = 0 Then
            Me.intOperateStatus = 2
            Call Me.FreeContral(GroupBox2)
        ElseIf Me.intOperateStatus = 2 Then
            Me.intOperateStatus = 0
            Call Me.LockContral(Me.GroupBox2)
            Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
        End If
    End Sub

    '�ж��Ƿ��пɹ��޸ĵ����ݣ���Ҫ���Ӵ������������������
    'Private Function GetExistData() As String
    '    ds = gWs.GetIntentLetterInfo("{project_code='" & Me.strProjectCode & "'}")
    '    If ds.Tables(0).Rows.Count = 0 Then
    '        'MessageBox.Show("û�пɹ��޸ĵ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        SWDialogBox.MessageBox.Show("$1007","")
    '        Return "1"
    '    End If
    'End Function

    Protected Overridable Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Me.btnSaveClickEvent()
        If Me.CanNewIntentLetter(Me.strProjectCode) = False Then Me.btnAdd.Enabled = False
    End Sub

    Private Sub btnSaveClickEvent()
        ds = gWs.GetIntentLetterInfo("{project_code='" & Me.strProjectCode & "' and trial_times=" & Me.intTrialTimes & "}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            If Me.intSearchIndex = 0 Then
                'MessageBox.Show("��ѡ����Ӧ�ĵ�����������в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("$1001", "����������")
                Me.dgIntentLetter.Focus()
                Return
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Me.SaveData() = 1 Then
                Return
            End If
            Call Me.LockContral(GroupBox2)
            Me.intOperateStatus = 0
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '������Ӧ���񱣴���Ӧ���ݣ��˺�����Ҫ���ء�
    Private Function SaveData() As Integer
        Dim TempDs As DataSet

        If Me.cmbLoanVouchBank.Text = "" Then
            'MessageBox.Show("û��ѡ�񵣱����н��в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1001", "��������")
            Me.cmbLoanVouchBank.Focus()
            Return 1
        End If
        If Me.cmbLoanVouchBranchBank.Text = "" Then
            'MessageBox.Show("û��ѡ�񵣱�����֧�н��в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1001", "��������֧��")
            Me.cmbLoanVouchBranchBank.Focus()
            Return 1
        End If
        If Me.txtVouchAccount.Text = "" Then
            'MessageBox.Show("û�е��������в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1001", "�������")
            Me.txtVouchAccount.Focus()
            Return 1
        End If

        If Me.intOperateStatus = 1 Then 'ִ������������
            ds = gWs.GetIntentLetterInfo("null")
            Dim NewRow As DataRow = ds.Tables(0).NewRow()
            With NewRow
                .Item("project_code") = Me.strProjectCode
                .Item("trial_times") = Me.intTrialTimes
                .Item("loan_bank") = Me.strBankCode
                .Item("loan_branch_bank") = Me.strBranchBankCode
                .Item("guarantee_sum") = Convert.ToDecimal(Me.txtVouchAccount.Text.Trim())
                .Item("create_person") = Me.strUserID
                .Item("create_date") = gWs.GetSysTime
                .Item("terms") = Convert.ToDecimal(Me.txtVouchDeadline.Text.Trim())
                .Item("refund_type") = Me.txtReturnType.Text.Trim()
                .Item("refund_sum_average") = Convert.ToDecimal(Me.txtAverageRefundSum.Text.Trim())
                '.Item("sign_date") = Me.dtpSignDate.Value
            End With
            ds.Tables(0).Rows.Add(NewRow)
            Me.strUpdateResult = gWs.UpdateIntentLetter(ds, Nothing)
            If Me.strUpdateResult = "1" Then
                'MessageBox.Show("���������������ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            Else
                'MessageBox.Show("��������������ʧ�ܣ�" + Me.strUpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SWDialogBox.MessageBox.Show("*999", "frmEnterPriseIntent.SaveData", Me.strUpdateResult, "gWs.UpdateIntentLetter(ds, Nothing)")
            End If
            Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
        ElseIf Me.intOperateStatus = 2 Then 'ִ���޸Ĳ�����
            '���ѡ����intent_code�����ݼ�¼�����޸Ĳ�����
            ds = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
            If Not ds.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value Then
                'MessageBox.Show("�������������Ѿ��������лظ����޷������޸Ĳ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SWDialogBox.MessageBox.Show("$1006", "��������")
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Return 1
            End If
            If Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    .Item("loan_bank") = Me.strBankCode
                    .Item("loan_branch_bank") = Me.strBranchBankCode
                    .Item("guarantee_sum") = Convert.ToDecimal(Me.txtVouchAccount.Text.Trim())
                    '.Item("sign_date") = Me.dtpSignDate.Value
                End With
                Me.strUpdateResult = gWs.UpdateIntentLetter(ds, Nothing)
                If Me.strUpdateResult = "1" Then
                    '''MessageBox.Show("�����������޸ĳɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'MessageBox.Show("�����������޸�ʧ�ܣ�" + Me.strUpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SWDialogBox.MessageBox.Show("*999", "frmEnterPriseIntent.SaveData", Me.strUpdateResult, "gWs.UpdateIntentLetter(ds, Nothing)")
                End If
                Call Me.GetIniData(Me.strProjectCode, Me.intSearchIndex)
                '��ʾ��ǰintent_codeΪ���ļ�¼��Ϣ��
                'Call Me.ShowSpecialData(Me.intSearchIndex)
            End If
        End If
        Me.bIsFormLoad = False : Me.bIsTextChange = False
        Return 2
    End Function

    Private Sub cmbLoanVouchBank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoanVouchBank.SelectedIndexChanged
        TempDS = gWs.GetBankInfo("{bank_name='" & Me.cmbLoanVouchBank.Text & "'}", "null")
        If Not TempDS.Tables(0).Rows.Count = 0 Then
            Me.strBankCode = TempDS.Tables(0).Rows(0).Item("bank_code")
        End If
        If Me.strBankCode = "00" Then     '����ѡ��Ϊȷ�������
            Me.cmbLoanVouchBranchBank.Items.Clear()
            Return
        Else
            TempDS = gWs.GetBankInfo("null", "{bank_code='" & Me.strBankCode & "'}")
            Call Me.GetBankNameList(Me.cmbLoanVouchBranchBank, TempDS, "bank_branch", "branch_bank_name")
        End If
    End Sub

    Private Sub GetBankNameList(ByVal cmb As ComboBox, ByVal x As DataSet, ByVal TableName As String, ByVal FieldName As String)
        Dim j As Integer   'ȡ��������combobox�е�index
        Dim str1, str2 As String
        j = 0
        str1 = cmb.Text
        cmb.Items.Clear()
        If x.Tables(TableName).Rows.Count = 0 Then
            Return
        End If
        x.Tables(TableName).DefaultView.Sort = FieldName
        If Not x.Tables(TableName).Rows.Count = 0 Then
            For i = 0 To x.Tables(TableName).Rows.Count - 1
                str2 = x.Tables(TableName).Rows(i).Item(FieldName)
                If str1 = str2 Then
                    j = i
                End If
                cmb.Items.Add(str2)
            Next
        End If
        cmb.SelectedIndex = j
    End Sub

    Private Sub cmbLoanVouchBranchBank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoanVouchBranchBank.SelectedIndexChanged
        TempDS = gWs.GetBankInfo("null", "{bank_code='" & Me.strBankCode & "' and branch_bank_name='" & Me.cmbLoanVouchBranchBank.Text.Trim() & "'}")
        If Not TempDS.Tables(1).Rows.Count = 0 Then
            Me.strBranchBankCode = TempDS.Tables(1).Rows(0).Item("branch_bank_code")
        End If
    End Sub

    Protected Overridable Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MsgResult As MsgBoxResult
        If Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then
            If Me.bIsTextChange Then
                'MsgResult = MessageBox.Show("�Ƿ񱣴�����ݽ��е��޸ģ�", "��ʾ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                MsgResult = SWDialogBox.MessageBox.Show("?1003")
            Else
                Me.Close()
                Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            If MsgResult = MsgBoxResult.Yes Then
                If Me.SaveData() = 1 Then
                    Return
                Else
                    'MessageBox.Show("�����������޸ĳɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                End If
                Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            If MsgResult = MsgBoxResult.No Then Me.Close()
            If MsgResult = MsgBoxResult.Cancel Then Exit Sub
        End If
        If Me.intOperateStatus = 0 Then
            Me.Close()
            Me.bIsFormLoad = False : Me.bIsTextChange = False
        End If
    End Sub

    Protected Overridable Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call Me.btnSaveClickEvent()
        Try
            If Me.intSearchIndex = -1 Then
                'MessageBox.Show("��ǰû�е������������û��ѡ�񵣱������飬�޷�����ύ������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("$X006")
                Return
            End If

            If gWs.GetProjectFileByCondition("{project_code = '" & Me.getProjectCode() & "' AND item_type='45' AND item_code='008' AND relation_num IS NOT NULL}").Tables(0).Rows.Count = 0 Then
                SWDialogBox.MessageBox.Show("$1005", "����������")
                Return
            End If
            If Me.isCommitConfirm = True Then
                'If MessageBox.Show("�Ƿ�ȷ���ύ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                If SWDialogBox.MessageBox.Show("?1000", "�ύ") = DialogResult.No Then
                    Return
                End If
            End If
            '�ύʱ�򱣴����ݡ�
            If Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then
                If Me.bIsTextChange Then
                    If Me.SaveData() = 1 Then
                        Return
                        'Else
                        'Me.bIsTextChange = False : Me.bIsFormLoad = False
                    End If
                End If
            End If
            Call Me.CommitWorkFlow("", Me)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub txtVouchAccount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVouchAccount.KeyPress
        Call Me.SendKeys(2, Me.txtVouchAccount.Text, e)
    End Sub

    Private Sub dgIntentLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgIntentLetter.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Me.dgIntentLetter.DataSource Is Nothing OrElse CType(Me.dgIntentLetter.DataSource, DataView).Count = 0 Then
                Return
            End If
            Me.intSearchIndex = Convert.ToInt16(Me.dgIntentLetter.Item(Me.dgIntentLetter.CurrentCell.RowNumber, 0))
            Call Me.ShowSpecialData(Me.intSearchIndex)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cmbBankRelapseOpinion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBankRelapseOpinion.SelectedIndexChanged
        If Me.cmbBankRelapseOpinion.Text = "ͬ��" Then
            Me.txtBankVouchAccount.Enabled = True
            Me.txtBankReplyAverageSum.Enabled = True
            Me.txtBankReplyTerms.Enabled = True
            Me.cmbBankReplyRefundType.Enabled = True
        Else
            Me.txtBankVouchAccount.Enabled = False
            Me.txtBankVouchAccount.Text = "0"
            Me.txtBankReplyAverageSum.Enabled = False
            Me.txtBankReplyTerms.Enabled = False
            Me.cmbBankReplyRefundType.Enabled = False
            Me.txtBankReplyAverageSum.Text = "0"
            Me.txtBankReplyTerms.Text = "0"
            Me.cmbBankReplyRefundType.Text = ""
        End If
    End Sub

    Private Sub cmbLoanVouchBank_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoanVouchBank.TextChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub
    'cmbSignOpinion
    Private Sub cmbLoanVouchBranchBank_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoanVouchBranchBank.TextChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub

    Private Sub txtVouchAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVouchAccount.TextChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub

    Private Sub dtpSignDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSignDate.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChange = True
    End Sub

    Private Sub cmbSignOpinion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSignOpinion.TextChanged
        '  If Me.bIsFormLoad Then Me.bIsTextChange = True
        Me.bIsTextChange = True
    End Sub

    Private Sub dtpBankRelapseDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBankRelapseDate.TextChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub

    Private Sub cmbBankRelapseOpinion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBankRelapseOpinion.TextChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub

    Private Sub txtBankVouchAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankVouchAccount.TextChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub

    Protected Overridable Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Me.PrintIntentLetter(Me.strProjectCode, Me.intSearchIndex)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '��ӡ������
    Private Sub PrintIntentLetter(ByVal ProjectCode As String, ByVal IntentCode As String)
        'Dim strReplaceFrom(6) As String
        'Dim strReplaceTo(6) As String
        Dim strReplaceFrom(7) As String
        Dim strReplaceTo(7) As String
        Dim Sum As Double
        ds = gWs.GetIntentLetterInfo("{intent_code='" & IntentCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceFrom(0) = "&#BankName"
                strReplaceTo(0) = Me.GetBankName(IIf(.Item("loan_bank") Is System.DBNull.Value, "", .Item("loan_bank")), Nothing)
                strReplaceFrom(1) = "&#BranchBankName"
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("loan_bank") Is System.DBNull.Value, "", .Item("loan_bank")), IIf(.Item("loan_branch_bank") Is System.DBNull.Value, "", .Item("loan_branch_bank")))
                strReplaceFrom(2) = "&#GuaranteeSum"
                Sum = IIf(.Item("guarantee_sum") Is System.DBNull.Value, 0, .Item("guarantee_sum"))
                strReplaceTo(2) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
            End With
        End If
        'ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        'If Not ds.Tables(0).Rows.Count = 0 Then
        '    With ds.Tables(0).Rows(0)
        '        strReplaceFrom(3) = "&#CorporationName"
        '        strReplaceTo(3) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
        '    End With
        'End If

        'qxd add 2004-8-5
        Dim strSql As String
        strSql = "select EnterpriseName,conference_date from viewProjectInfo_Review where projectCode='" & ProjectCode & "'"
        ds = gWs.GetCommonQueryInfo(strSql)
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceFrom(3) = "&#CorporationName"
                strReplaceTo(3) = IIf(.Item("EnterpriseName") Is System.DBNull.Value, "", .Item("EnterpriseName"))
                '��Ч���� = �����ͨ������ + 3����
                strReplaceFrom(4) = "&#Validity"
                strReplaceTo(4) = IIf(.Item("conference_date") Is System.DBNull.Value, "", .Item("conference_date"))
                If Not strReplaceTo(4) = "" Then
                    Dim d As DateTime = CType(strReplaceTo(4), DateTime)
                    d = d.AddMonths(3)
                    strReplaceTo(4) = d.ToLongDateString
                End If

            End With
        End If
        'qxd end 
        ds = gWs.GetConfTrialInfo("{project_code='" & ProjectCode & "' and trial_conclusion='ͨ��'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceFrom(5) = "&#AverageSum"
                Sum = IIf(.Item("refund_sum_average") Is System.DBNull.Value, 0, .Item("refund_sum_average"))
                strReplaceTo(5) = Money2String.Money2String.GetCnString(Convert.ToString(Sum))
                Dim Temp As String
                Temp = IIf(.Item("refund_type") Is System.DBNull.Value, "", .Item("refund_type"))
                Select Case Temp
                    Case "����һ�λ���"
                        strReplaceTo(5) = Temp + "��" + strReplaceTo(5)
                    Case "�ȶ�ÿ������"
                        strReplaceTo(5) = Temp + "��" + strReplaceTo(5)
                    Case "�ȶ�ÿ�»���"
                        strReplaceTo(5) = Temp + "��" + strReplaceTo(5)
                    Case "�ȶ�ÿ�ܻ���"
                        strReplaceTo(5) = Temp + "��" + strReplaceTo(5)
                    Case "�ȶ�ÿ�ջ���"
                        strReplaceTo(5) = Temp + "��" + strReplaceTo(5)
                End Select
                strReplaceFrom(6) = "&#Terms"
                strReplaceTo(6) = Convert.ToString(IIf(.Item("terms") Is System.DBNull.Value, "", .Item("terms")))
                strReplaceTo(6) = strReplaceTo(6) + "����"
            End With
        End If
        'Dim Doc As Word.ApplicationClass
        'Doc = Me.GetWordTemplate("45", "008", Me.strEnterpriseName + "����������.DOC")
        'For i = 0 To 5
        '    Me.replaceText(Doc, strReplaceFrom(i), strReplaceTo(i))
        'Next
        Dim key(6) As String
        Dim value As ArrayList = New ArrayList()

        For i = 0 To 6
            'Me.replaceText(Doc, strReplaceFrom(i), strReplaceTo(i))
            key(i) = strReplaceFrom(i)
            value.Add(strReplaceTo(i))
        Next

        Try
            Dim ofrm1 As frmDocumentManageBusiness
            ofrm1 = New frmDocumentManageBusiness(ProjectCode, strTaskID, strEnterpriseName, "45", "008", UserName, key, value)
            ofrm1.AllowTransparency = False
            ofrm1.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("��������" & vbCr & ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Function IsLastIntentLetter(ByVal IntentCode As Integer) As Boolean
        'ȡ�����뵣���������¼���ϻ�����Ĺ���  modify by wzh 2006-06-13
        'ds = gWs.GetIntentLetterInfo("{project_code like '" & Me.strProjectCode & "' and trial_times like '" & intTrialTimes & "' order by intent_code desc}")
        ds = gWs.GetIntentLetterInfo("{project_code like '" & Me.strProjectCode & "' order by intent_code desc}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            If (IntentCode = ds.Tables(0).Rows(0).Item("intent_code")) Then
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function

    Private Sub cmbBankReplyRefundType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBankReplyRefundType.TextChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub

    Private Sub txtBankReplyAverageSum_TextAlignChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankReplyAverageSum.TextAlignChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub

    Private Sub txtBankReplyTerms_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankReplyTerms.TextChanged
        If Me.bIsFormLoad And Me.intOperateStatus = 1 Or Me.intOperateStatus = 2 Then Me.bIsTextChange = True
    End Sub

    Private Sub txtBankReplyAverageSum_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankReplyAverageSum.Leave
        Me.btnEdit.Focus()
    End Sub


End Class
