
'�Ǽǻ���֤����
Public Class frmProjectTerminate
    Inherits frmBasic

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
    Protected WithEvents tab As System.Windows.Forms.TabControl
    Protected WithEvents pg1 As System.Windows.Forms.TabPage
    Protected WithEvents btnDocRefund As System.Windows.Forms.Button
    Protected WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Protected WithEvents txtSum As System.Windows.Forms.TextBox
    Protected WithEvents dtpRefundDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents cboRefundSubBank As System.Windows.Forms.ComboBox
    Protected WithEvents cboRefundBank As System.Windows.Forms.ComboBox
    Protected WithEvents Label8 As System.Windows.Forms.Label
    Protected WithEvents Label7 As System.Windows.Forms.Label
    Protected WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents Label5 As System.Windows.Forms.Label
    Protected WithEvents txtGuaranteesum As System.Windows.Forms.TextBox
    Protected WithEvents Label3 As System.Windows.Forms.Label
    Protected WithEvents cboSignBank As System.Windows.Forms.ComboBox
    Protected WithEvents cboSignSubBank As System.Windows.Forms.ComboBox
    Protected WithEvents txtTerm As System.Windows.Forms.TextBox
    Protected WithEvents Label4 As System.Windows.Forms.Label
    Protected WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents pg2 As System.Windows.Forms.TabPage
    Protected WithEvents txtAppraisement As System.Windows.Forms.TextBox
    Protected WithEvents txtDetail_reason As System.Windows.Forms.TextBox
    Protected WithEvents Label12 As System.Windows.Forms.Label
    Protected WithEvents chkIs_high_risk As System.Windows.Forms.CheckBox
    Protected WithEvents chkIs_continue_support As System.Windows.Forms.CheckBox
    Protected WithEvents Label11 As System.Windows.Forms.Label
    Protected WithEvents dtpTerminate_date As System.Windows.Forms.DateTimePicker
    Protected WithEvents Label9 As System.Windows.Forms.Label
    Protected WithEvents cboTerminate_type As System.Windows.Forms.ComboBox
    Protected WithEvents Label10 As System.Windows.Forms.Label
    Protected WithEvents btnDocTerminate As System.Windows.Forms.Button
    Protected WithEvents lblCorporationName As System.Windows.Forms.Label
    Protected WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Protected WithEvents lblLoanContract_num As System.Windows.Forms.Label
    Protected WithEvents txtLoanContract_num As System.Windows.Forms.TextBox
    Protected WithEvents txtAssureContract_num As System.Windows.Forms.TextBox
    Protected WithEvents lblAssureContract_num As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProjectTerminate))
        Me.tab = New System.Windows.Forms.TabControl()
        Me.pg1 = New System.Windows.Forms.TabPage()
        Me.btnDocRefund = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAssureContract_num = New System.Windows.Forms.TextBox()
        Me.lblAssureContract_num = New System.Windows.Forms.Label()
        Me.txtLoanContract_num = New System.Windows.Forms.TextBox()
        Me.lblLoanContract_num = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.dtpRefundDate = New System.Windows.Forms.DateTimePicker()
        Me.cboRefundSubBank = New System.Windows.Forms.ComboBox()
        Me.cboRefundBank = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGuaranteesum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSignBank = New System.Windows.Forms.ComboBox()
        Me.cboSignSubBank = New System.Windows.Forms.ComboBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pg2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAppraisement = New System.Windows.Forms.TextBox()
        Me.txtDetail_reason = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkIs_high_risk = New System.Windows.Forms.CheckBox()
        Me.chkIs_continue_support = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpTerminate_date = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboTerminate_type = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDocTerminate = New System.Windows.Forms.Button()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.tab.SuspendLayout()
        Me.pg1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pg2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(321, 424)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Visible = True
        '
        'tab
        '
        Me.tab.Controls.AddRange(New System.Windows.Forms.Control() {Me.pg1, Me.pg2})
        Me.tab.Location = New System.Drawing.Point(8, 32)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(528, 384)
        Me.tab.TabIndex = 12
        '
        'pg1
        '
        Me.pg1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDocRefund, Me.GroupBox2, Me.GroupBox1})
        Me.pg1.Location = New System.Drawing.Point(4, 21)
        Me.pg1.Name = "pg1"
        Me.pg1.Size = New System.Drawing.Size(520, 359)
        Me.pg1.TabIndex = 0
        Me.pg1.Text = "������֤��"
        '
        'btnDocRefund
        '
        Me.btnDocRefund.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDocRefund.Image = CType(resources.GetObject("btnDocRefund.Image"), System.Drawing.Bitmap)
        Me.btnDocRefund.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocRefund.ImageIndex = 25
        Me.btnDocRefund.ImageList = Me.ImageListBasic
        Me.btnDocRefund.Location = New System.Drawing.Point(368, 320)
        Me.btnDocRefund.Name = "btnDocRefund"
        Me.btnDocRefund.Size = New System.Drawing.Size(136, 23)
        Me.btnDocRefund.TabIndex = 55
        Me.btnDocRefund.Text = "���ػ���֤����(&U)"
        Me.btnDocRefund.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAssureContract_num, Me.lblAssureContract_num, Me.txtLoanContract_num, Me.lblLoanContract_num, Me.txtSum, Me.dtpRefundDate, Me.cboRefundSubBank, Me.cboRefundBank, Me.Label8, Me.Label7, Me.Label6, Me.Label5})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 104)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "��Ŀ������Ϣ"
        '
        'txtAssureContract_num
        '
        Me.txtAssureContract_num.Location = New System.Drawing.Point(344, 72)
        Me.txtAssureContract_num.Name = "txtAssureContract_num"
        Me.txtAssureContract_num.Size = New System.Drawing.Size(144, 21)
        Me.txtAssureContract_num.TabIndex = 53
        Me.txtAssureContract_num.Text = ""
        '
        'lblAssureContract_num
        '
        Me.lblAssureContract_num.Location = New System.Drawing.Point(256, 72)
        Me.lblAssureContract_num.Name = "lblAssureContract_num"
        Me.lblAssureContract_num.Size = New System.Drawing.Size(100, 16)
        Me.lblAssureContract_num.TabIndex = 52
        Me.lblAssureContract_num.Text = "��֤��ͬ��"
        '
        'txtLoanContract_num
        '
        Me.txtLoanContract_num.Location = New System.Drawing.Point(96, 72)
        Me.txtLoanContract_num.Name = "txtLoanContract_num"
        Me.txtLoanContract_num.Size = New System.Drawing.Size(144, 21)
        Me.txtLoanContract_num.TabIndex = 51
        Me.txtLoanContract_num.Text = ""
        '
        'lblLoanContract_num
        '
        Me.lblLoanContract_num.Location = New System.Drawing.Point(8, 72)
        Me.lblLoanContract_num.Name = "lblLoanContract_num"
        Me.lblLoanContract_num.Size = New System.Drawing.Size(100, 16)
        Me.lblLoanContract_num.TabIndex = 50
        Me.lblLoanContract_num.Text = "����ͬ��"
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.SystemColors.Window
        Me.txtSum.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtSum.Location = New System.Drawing.Point(344, 46)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(144, 21)
        Me.txtSum.TabIndex = 4
        Me.txtSum.Text = ""
        Me.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpRefundDate
        '
        Me.dtpRefundDate.Location = New System.Drawing.Point(96, 46)
        Me.dtpRefundDate.Name = "dtpRefundDate"
        Me.dtpRefundDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpRefundDate.TabIndex = 3
        '
        'cboRefundSubBank
        '
        Me.cboRefundSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRefundSubBank.Enabled = False
        Me.cboRefundSubBank.Location = New System.Drawing.Point(344, 22)
        Me.cboRefundSubBank.Name = "cboRefundSubBank"
        Me.cboRefundSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundSubBank.TabIndex = 2
        '
        'cboRefundBank
        '
        Me.cboRefundBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRefundBank.Enabled = False
        Me.cboRefundBank.Location = New System.Drawing.Point(96, 22)
        Me.cboRefundBank.Name = "cboRefundBank"
        Me.cboRefundBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundBank.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(256, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "�������(��Ԫ)"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "��������"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "����֧��"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "��������"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtGuaranteesum, Me.Label3, Me.cboSignBank, Me.cboSignSubBank, Me.txtTerm, Me.Label4, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 80)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "��Ŀ������Ϣ"
        '
        'txtGuaranteesum
        '
        Me.txtGuaranteesum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteesum.Location = New System.Drawing.Point(96, 22)
        Me.txtGuaranteesum.Name = "txtGuaranteesum"
        Me.txtGuaranteesum.ReadOnly = True
        Me.txtGuaranteesum.Size = New System.Drawing.Size(144, 21)
        Me.txtGuaranteesum.TabIndex = 1
        Me.txtGuaranteesum.Text = ""
        Me.txtGuaranteesum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "ǩԼ����"
        '
        'cboSignBank
        '
        Me.cboSignBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSignBank.Enabled = False
        Me.cboSignBank.Location = New System.Drawing.Point(96, 46)
        Me.cboSignBank.Name = "cboSignBank"
        Me.cboSignBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSignBank.TabIndex = 5
        '
        'cboSignSubBank
        '
        Me.cboSignSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSignSubBank.Enabled = False
        Me.cboSignSubBank.Location = New System.Drawing.Point(344, 46)
        Me.cboSignSubBank.Name = "cboSignSubBank"
        Me.cboSignSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSignSubBank.TabIndex = 6
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(344, 22)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtTerm.TabIndex = 2
        Me.txtTerm.Text = ""
        Me.txtTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(256, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "ǩԼ֧��"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(256, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "��������(��)"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "�������(��Ԫ)"
        '
        'pg2
        '
        Me.pg2.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.btnDocTerminate})
        Me.pg2.Location = New System.Drawing.Point(4, 21)
        Me.pg2.Name = "pg2"
        Me.pg2.Size = New System.Drawing.Size(520, 359)
        Me.pg2.TabIndex = 1
        Me.pg2.Text = "������Ŀ��ֹ����"
        Me.pg2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAppraisement, Me.txtDetail_reason, Me.Label12, Me.chkIs_high_risk, Me.chkIs_continue_support, Me.Label11, Me.dtpTerminate_date, Me.Label9, Me.cboTerminate_type, Me.Label10})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 304)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtAppraisement
        '
        Me.txtAppraisement.Location = New System.Drawing.Point(88, 192)
        Me.txtAppraisement.MaxLength = 250
        Me.txtAppraisement.Multiline = True
        Me.txtAppraisement.Name = "txtAppraisement"
        Me.txtAppraisement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAppraisement.Size = New System.Drawing.Size(400, 104)
        Me.txtAppraisement.TabIndex = 24
        Me.txtAppraisement.Text = ""
        '
        'txtDetail_reason
        '
        Me.txtDetail_reason.Location = New System.Drawing.Point(88, 80)
        Me.txtDetail_reason.MaxLength = 250
        Me.txtDetail_reason.Multiline = True
        Me.txtDetail_reason.Name = "txtDetail_reason"
        Me.txtDetail_reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetail_reason.Size = New System.Drawing.Size(400, 104)
        Me.txtDetail_reason.TabIndex = 23
        Me.txtDetail_reason.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "��Ŀ����"
        '
        'chkIs_high_risk
        '
        Me.chkIs_high_risk.Location = New System.Drawing.Point(88, 48)
        Me.chkIs_high_risk.Name = "chkIs_high_risk"
        Me.chkIs_high_risk.Size = New System.Drawing.Size(120, 24)
        Me.chkIs_high_risk.TabIndex = 13
        Me.chkIs_high_risk.Text = "�߷�����Ŀ"
        '
        'chkIs_continue_support
        '
        Me.chkIs_continue_support.Location = New System.Drawing.Point(248, 48)
        Me.chkIs_continue_support.Name = "chkIs_continue_support"
        Me.chkIs_continue_support.Size = New System.Drawing.Size(144, 24)
        Me.chkIs_continue_support.TabIndex = 14
        Me.chkIs_continue_support.Text = "����֧�ָ���ҵ"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "��ֹԭ��˵��"
        '
        'dtpTerminate_date
        '
        Me.dtpTerminate_date.Location = New System.Drawing.Point(88, 22)
        Me.dtpTerminate_date.Name = "dtpTerminate_date"
        Me.dtpTerminate_date.Size = New System.Drawing.Size(144, 21)
        Me.dtpTerminate_date.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "��Ŀ��ֹ����"
        '
        'cboTerminate_type
        '
        Me.cboTerminate_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTerminate_type.Location = New System.Drawing.Point(328, 22)
        Me.cboTerminate_type.Name = "cboTerminate_type"
        Me.cboTerminate_type.Size = New System.Drawing.Size(160, 20)
        Me.cboTerminate_type.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(248, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "��Ŀ��ֹ����"
        '
        'btnDocTerminate
        '
        Me.btnDocTerminate.Image = CType(resources.GetObject("btnDocTerminate.Image"), System.Drawing.Bitmap)
        Me.btnDocTerminate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocTerminate.ImageIndex = 19
        Me.btnDocTerminate.ImageList = Me.ImageListBasic
        Me.btnDocTerminate.Location = New System.Drawing.Point(360, 320)
        Me.btnDocTerminate.Name = "btnDocTerminate"
        Me.btnDocTerminate.Size = New System.Drawing.Size(144, 23)
        Me.btnDocTerminate.TabIndex = 17
        Me.btnDocTerminate.Text = "������Ŀ��ֹ����(&M)"
        Me.btnDocTerminate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(184, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(56, 16)
        Me.lblCorporationName.TabIndex = 16
        Me.lblCorporationName.Text = "��ҵ����"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCode.TabIndex = 15
        Me.lblProjectCode.Text = "��Ŀ����"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(145, 424)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(240, 6)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(296, 21)
        Me.txtCorporationName.TabIndex = 18
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 17
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(233, 424)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 14
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmProjectTerminate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 455)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCorporationName, Me.lblProjectCode, Me.btnExit, Me.tab, Me.btnSave, Me.txtCorporationName, Me.txtProjectCode, Me.btnCommit})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProjectTerminate"
        Me.Text = "�Ǽǻ���֤����"
        Me.tab.ResumeLayout(False)
        Me.pg1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.pg2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsSignBank As DataSet           'ǩԼ����
    Private dsRefundBank As DataSet         '��������
    Protected bFormLoad As Boolean = False  '�����Ƿ�load���
    Protected bIsChanged As Boolean = False '�����Ƿ�ı�
    Protected bIsReguarantee As Boolean = False  '�Ƿ����ٵ���
    Protected dsTemp As DataSet         '��ʱ����       
    Protected strResult As String       '��ʱ����

    Private Sub frmProjectTerminate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.InitComboBox()
            Me.GetData()
            Me.SetControlState()
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '��ʼ����󶨴����е�ComboBox
    Private Sub InitComboBox()
        '��Ŀ��ֹ����
        dsTemp = gWs.GetTerminateType("%")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            Me.cboTerminate_type.DataSource = dsTemp.Tables(0)
            Me.cboTerminate_type.DisplayMember = "terminate_type"
            Me.cboTerminate_type.ValueMember = "terminate_type"
            Me.cboTerminate_type.SelectedIndex = 0
        End If

        'ǩԼ����
        Me.dsSignBank = gWs.GetBankInfo("%", "%")
        If Not Me.dsSignBank.Tables("bank").Rows.Count = 0 Then
            Me.cboSignBank.DataSource = Me.dsSignBank.Tables("bank")
            Me.cboSignBank.DisplayMember = "bank_name"
            Me.cboSignBank.ValueMember = "bank_code"
            Me.cboSignBank.SelectedIndex = 0
        End If
        Me.cboSignSubBank.DataSource = Me.dsSignBank.Tables("bank_branch").DefaultView
        Me.cboSignSubBank.DisplayMember = "branch_bank_name"
        Me.cboSignSubBank.ValueMember = "branch_bank_code"
        Me.SignBankChanged(Nothing, Nothing)
        AddHandler cboSignBank.SelectedIndexChanged, AddressOf SignBankChanged

        '��������
        Me.dsRefundBank = gWs.GetBankInfo("%", "%")
        If Not Me.dsRefundBank.Tables("bank").Rows.Count = 0 Then
            Me.cboRefundBank.DataSource = Me.dsRefundBank.Tables("bank")
            Me.cboRefundBank.DisplayMember = "bank_name"
            Me.cboRefundBank.ValueMember = "bank_code"
            Me.cboRefundBank.SelectedIndex = 0
        End If
        Me.cboRefundSubBank.DataSource = Me.dsRefundBank.Tables("bank_branch").DefaultView
        Me.cboRefundSubBank.DisplayMember = "branch_bank_name"
        Me.cboRefundSubBank.ValueMember = "branch_bank_code"
        Me.RefundBankChanged(Nothing, Nothing)
        AddHandler cboRefundBank.SelectedIndexChanged, AddressOf RefundBankChanged
    End Sub
    Protected Sub GetData()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        Me.GetProjectBaseInfo()
        Me.GetProjectRefundInfo()
        Me.GetProjectTerminateInfo()
        tab_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    '��ȡ��Ŀ������Ϣ
    Private Sub GetProjectBaseInfo()
        dsTemp = gWs.GetProjectInfoEx("{projectcode='" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                If Not IsDBNull(.Item("loan_sum")) Then
                    Me.txtGuaranteesum.Text = CGModule.Numeric2Currency(.Item("loan_sum"))         '�������
                Else
                    If Not IsDBNull(.Item("sign_sum")) Then
                        Me.txtGuaranteesum.Text = CGModule.Numeric2Currency(.Item("sign_sum"))         '�������
                    End If
                End If
                If Not IsDBNull(.Item("ServiceType")) Then
                    If .Item("ServiceType") = "�ٵ���" Then                     '�ж��Ƿ�Ϊ�ٵ���
                        Me.bIsReguarantee = True
                    End If
                End If
                'If Not .Item("guaranting_sum") Is DBNull.Value Then
                '    If .Item("guaranting_sum") > 0 Then                               '����Ǽ�����©
                '        MessageBox.Show("����Ǽ�����©", "��ʾ", MessageBoxButtons.OK)
                '        Return
                '    End If
                'End If
            End With
        End If
        dsTemp = gWs.GetLoanNoticeInfo("{project_code='" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtTerm.Text = IIf(.Item("term") Is DBNull.Value, "", .Item("term")) '��������
                If Not .Item("bank") Is DBNull.Value Then
                    Me.cboSignBank.SelectedValue = .Item("bank")                       'ǩԼ����
                    Me.cboRefundBank.SelectedValue = .Item("bank")                     '��������
                End If
                If Not .Item("bank") Is DBNull.Value AndAlso Not .Item("branch_bank") Is DBNull.Value Then
                    Me.cboSignSubBank.SelectedValue = .Item("branch_bank")            'ǩԼ֧��
                    Me.cboRefundSubBank.SelectedValue = .Item("branch_bank")          '����֧��
                End If
            End With
        End If
    End Sub
    '��ȡ��Ŀ������Ϣ
    Protected Overridable Sub GetProjectRefundInfo()
        Dim dsSigPro As DataSet = gWs.GetProjectSignatureInfo("{project_code='" & Me.getProjectCode() & "'}")
        dsTemp = gWs.GetRefundCertificateInfo("{project_code='" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.dtpRefundDate.Value = IIf(.Item("refund_date") Is DBNull.Value, gWs.GetSysTime(), .Item("refund_date"))  '��������
                If Not .Item("sum") Is DBNull.Value Then
                    Me.txtSum.Text = CGModule.Numeric2Currency(.Item("sum"))         '�������
                End If
                If Not .Item("bank") Is DBNull.Value Then
                    Me.cboRefundBank.SelectedValue = .Item("bank")                   '��������      
                End If
                If Not .Item("bank") Is DBNull.Value AndAlso Not .Item("branch_bank") Is DBNull.Value Then
                    Me.cboRefundSubBank.SelectedValue = .Item("branch_bank")         '����֧��
                End If
                Me.txtLoanContract_num.Text = IIf(IsDBNull(.Item("loanContract_num")), "", .Item("loanContract_num"))   '����ͬ�š�
                Me.txtAssureContract_num.Text = IIf(IsDBNull(.Item("assureContract_num")), "", .Item("assureContract_num")) '��֤��ͬ��
            End With
        Else
            If dsSigPro.Tables(0).Rows.Count > 0 Then
                With dsSigPro.Tables(0).Rows(0)
                    Me.txtLoanContract_num.Text = IIf(IsDBNull(.Item("loanContract_num")), "", .Item("loanContract_num"))   '����ͬ�š�
                    Me.txtAssureContract_num.Text = IIf(IsDBNull(.Item("assureContract_num")), "", .Item("assureContract_num")) '��֤��ͬ��

                End With
            End If
        End If

        AddHandler dtpRefundDate.TextChanged, AddressOf DataChanged
        AddHandler txtSum.TextChanged, AddressOf DataChanged
        AddHandler txtSum.Enter, AddressOf Money.Money_Enter
        AddHandler txtSum.KeyPress, AddressOf Money.Money_KeyPress
        AddHandler txtSum.Leave, AddressOf Money.Money_Leave
        AddHandler txtLoanContract_num.TextChanged, AddressOf DataChanged
        AddHandler txtAssureContract_num.TextChanged, AddressOf DataChanged
    End Sub
    '��ȡ��Ŀ��ֹ��Ϣ
    Private Sub GetProjectTerminateInfo()
        dsTemp = gWs.GetTerminateReportInfo("{project_code='" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                If Not .Item("terminate_type") Is DBNull.Value Then
                    Me.cboTerminate_type.SelectedValue = .Item("terminate_type")
                End If
                Me.dtpTerminate_date.Value = IIf(.Item("terminate_date") Is DBNull.Value, Date.Now, .Item("terminate_date")) '��Ŀ��ֹ����
                Me.txtDetail_reason.Text = IIf(.Item("detail_reason") Is DBNull.Value, "", .Item("detail_reason")) '��ֹԭ��˵��
                Me.txtAppraisement.Text = IIf(.Item("appraisement") Is DBNull.Value, "", .Item("appraisement"))    '��Ŀ����
                If Not .Item("is_high_risk") Is System.DBNull.Value Then
                    Me.chkIs_high_risk.Checked = .Item("is_high_risk")                    '�Ƿ�߷���
                End If
                If Not .Item("is_continue_support") Is DBNull.Value Then
                    Me.chkIs_continue_support.Checked = .Item("is_continue_support")      '�Ƿ����֧�ָ���ҵ 
                End If
            End With
        End If

        AddHandler cboTerminate_type.SelectedIndexChanged, AddressOf DataChanged
        AddHandler dtpTerminate_date.TextChanged, AddressOf DataChanged
        AddHandler txtDetail_reason.TextChanged, AddressOf DataChanged
        AddHandler txtAppraisement.TextChanged, AddressOf DataChanged
        AddHandler chkIs_high_risk.CheckedChanged, AddressOf DataChanged
        AddHandler chkIs_continue_support.CheckedChanged, AddressOf DataChanged
    End Sub
    '�����Ƿ��ٵ��������ÿؼ�״̬��
    Protected Overridable Sub SetControlState()
        If Me.bIsReguarantee Then
            Me.btnDocRefund.Text = "�����ٵ�����֤������ֹ֪ͨ��(&U)"
        End If
    End Sub


    'ǩԼ���иı�
    Private Sub SignBankChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.dsSignBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code = '" & Me.cboSignBank.SelectedValue & "'"
    End Sub
    '�������иı�
    Private Sub RefundBankChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.dsRefundBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code = '" & Me.cboRefundBank.SelectedValue & "'"
    End Sub
    '���ݸı���bIsChangedΪTrue
    Protected Sub DataChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad Then
            bIsChanged = True
        End If
    End Sub

    Protected Overridable Function SaveData() As Boolean
        If Not Me.CheckData() Then
            Return False
        End If
        If Not Me.SaveProjectRefundInfo() Then
            Return False
        End If
        If Not Me.SaveProjectTerminateInfo() Then
            Return False
        End If
        Return True
    End Function
    '����У��
    Protected Function CheckData() As Boolean
        If Me.txtSum.Text = "" Then
            SWDialogBox.MessageBox.Show("$1007", "������Ϣ�г������")
            Return False
        End If
        If Currency2Numeric(Me.txtSum.Text.Trim()) > Currency2Numeric(Me.txtGuaranteesum.Text) Then
            'MessageBox.Show("������Ϣ�г������ܴ��ڴ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1008", "�������", "������")
            Return False
        End If

        Return True
        ''����ͬ�ţ��ͱ�֤��ͬ��������һ������������ȷ��
        'Dim dsTemp As DataSet = gWs.GetProjectSignatureInfo("{project_code LIKE '" & Me.getProjectCode() & "'}")
        'If Not dsTemp.Tables(0).Rows.Count = 0 Then
        '    With dsTemp.Tables(0).Rows(0)
        '        If Not IsDBNull(.Item("loanContract_num")) Then
        '            If Me.txtLoanContract_num.Text = CStr(.Item("loanContract_num")) Then '����ͬ�š�
        '                Return True
        '            End If
        '        End If
        '        If Not IsDBNull(.Item("assureContract_num")) Then
        '            If Me.txtAssureContract_num.Text = CStr(.Item("assureContract_num")) Then '��֤��ͬ��
        '                Return True
        '            End If
        '        End If
        '    End With
        '    SWDialogBox.MessageBox.Show("����ͬ�ţ��ͱ�֤��ͬ��������һ������������ȷ!", "��ʾ", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
        '    Return False
        'Else
        '    If DialogResult.Yes = SWDialogBox.MessageBox.Show("δȡ���Ǽ�ǩԼ�й���Ϣ���Ƿ������", "��ʾ", "", SWDialogBox.MessageBoxButton.YesNo, SWDialogBox.MessageBoxIcon.Question) Then
        '        Return True
        '    End If
        '    Return False
        'End If
    End Function
    '������Ŀ������Ϣ
    Protected Function SaveProjectRefundInfo() As Boolean
        Try
            dsTemp = gWs.GetRefundCertificateInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    .Item("refund_date") = Me.dtpRefundDate.Value
                    .Item("sum") = CGModule.Currency2Numeric(Me.txtSum.Text.Trim())
                    .Item("loanContract_num") = Me.txtLoanContract_num.Text.Trim() '����ͬ�š�
                    .Item("assureContract_num") = Me.txtAssureContract_num.Text.Trim() '��֤��ͬ��
                End With
            Else
                Dim dr As DataRow = dsTemp.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("bank") = Me.cboRefundBank.SelectedValue
                    .Item("branch_bank") = Me.cboRefundSubBank.SelectedValue
                    .Item("refund_date") = Me.dtpRefundDate.Value
                    .Item("sum") = CGModule.Currency2Numeric(Me.txtSum.Text.Trim())
                    .Item("loanContract_num") = Me.txtLoanContract_num.Text.Trim() '����ͬ�š�
                    .Item("assureContract_num") = Me.txtAssureContract_num.Text.Trim() '��֤��ͬ��
                End With
                dsTemp.Tables(0).Rows.Add(dr)
            End If
            strResult = gWs.UpdateRefundCertificate(dsTemp)
            If strResult <> "1" Then
                If strResult.StartsWith("���ض��ַ��������������") Then
                    SWDialogBox.MessageBox.Show("��ͬ��ų�����Ŀǰ���ݿ����趨�ĳ��ȣ�", "��ʾ", "���޸ı�refund_certificate��loanContract_num��assureContract_num�ֶε���󳤶ȣ�", SWDialogBox.MessageBoxButton.Detail, SWDialogBox.MessageBoxIcon.Information)
                    dsTemp.RejectChanges()
                Else
                    SWDialogBox.MessageBox.Show("*999", "���»���֤��������ʧ��", strResult, "")
                End If

                Return False
            End If
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '������Ŀ��ֹ��Ϣ
    Private Function SaveProjectTerminateInfo() As Boolean
        Try
            Dim strCorporation_code As String
            dsTemp = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
            With dsTemp.Tables(0)
                If Not .Rows.Count = 0 Then
                    strCorporation_code = IIf(.Rows(0).Item("corporation_code") Is DBNull.Value, "", .Rows(0).Item("corporation_code"))
                End If
            End With
            '������ҵ��
            dsTemp = gWs.GetcorporationInfo("{corporation_code='" & strCorporation_code & "'}", "null")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    .Item("is_high_risk") = Me.chkIs_high_risk.Checked
                    .Item("is_continue_support") = Me.chkIs_continue_support.Checked
                End With
            End If
            strResult = gWs.UpdateCorCon(dsTemp)
            If Not strResult = "1" Then
                'MessageBox.Show("��ҵ��Ϣ���²���ʧ�ܣ�" + Me.strUpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SWDialogBox.MessageBox.Show("*999", "��ҵ��Ϣ���²���ʧ��", strResult, "")
                Return False
            End If

            dsTemp = gWs.GetTerminateReportInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    .Item("terminate_type") = Me.cboTerminate_type.Text
                    .Item("terminate_date") = Me.dtpTerminate_date.Value
                    .Item("detail_reason") = Me.txtDetail_reason.Text
                    .Item("appraisement") = Me.txtAppraisement.Text
                    .Item("is_high_risk") = Me.chkIs_high_risk.Checked
                    .Item("is_continue_support") = Me.chkIs_continue_support.Checked
                End With
            Else
                Dim dr As DataRow = dsTemp.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("terminate_type") = Me.cboTerminate_type.Text
                    .Item("terminate_date") = Me.dtpTerminate_date.Value
                    .Item("detail_reason") = Me.txtDetail_reason.Text
                    .Item("appraisement") = Me.txtAppraisement.Text
                    .Item("is_high_risk") = Me.chkIs_high_risk.Checked
                    .Item("is_continue_support") = Me.chkIs_continue_support.Checked
                    .Item("create_date") = gWs.GetSysTime()
                    .Item("create_person") = UserName
                End With
                dsTemp.Tables(0).Rows.Add(dr)
            End If

            strResult = gWs.UpdateTerminateReport(dsTemp)
            If Not strResult = "1" Then
                ' MessageBox.Show("��Ŀ��ֹ������²���ʧ�ܣ�" + Me.strUpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error) '*999
                SWDialogBox.MessageBox.Show("*999", "��Ŀ��ֹ������²���ʧ��", strResult, "")
                Return False
            End If
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '��������֤����
    Protected Overridable Sub btnDocRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocRefund.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.bIsReguarantee Then
                Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "212", UserName)
                frm.AllowTransparency = False
                frm.Text = "�����ٵ�����֤������ֹ֪ͨ��"
                frm.setMakeDocEnable(False)
                frm.ShowDialog()
            Else
                Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "012", UserName)
                frm.AllowTransparency = False
                frm.Text = "���ػ���֤����"
                frm.setMakeDocEnable(False)
                frm.ShowDialog()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '������Ŀ��ֹ����
    Private Sub btnDocTerminate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocTerminate.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "004", UserName)
            frm.AllowTransparency = False
            If Me.getTaskID() = "RecordRefundCertificate" Then
                'frm.setMakeDocEnable(False)
            Else
                frm.setIsButtonEnable(True)
            End If
            frm.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '���水ť
    Protected Overridable Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If
            Me.bIsChanged = False
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex) 
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '�ύ��ť
    Protected Overridable Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If SWDialogBox.MessageBox.Show("?1000", "�ύ") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "�ύʧ��", strResult, "�Ǽǻ���֤����")
            Else
                MyBase.raiseCommitSucceed()
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                Close()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '�˳���ť
    Protected Overridable Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If Not Me.bIsChanged Then
            Me.Close()
            Return
        End If
        Select Case SWDialogBox.MessageBox.Show("?1003")
            Case DialogResult.Yes
                If Not Me.SaveData() Then
                    Return
                End If
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            Case DialogResult.Cancel
                Return
        End Select
        Me.Close()
    End Sub

    '����bIsChanged����TabPage�л�ʱComboBox����Ҫ�ĳ�ʼ�����ı�
    Protected Overridable Sub tab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab.SelectedIndexChanged
        If Not tab.SelectedIndex = 1 Then
            RemoveHandler cboTerminate_type.SelectedIndexChanged, AddressOf DataChanged
        Else
            AddHandler cboTerminate_type.SelectedIndexChanged, AddressOf DataChanged
        End If
    End Sub

End Class
