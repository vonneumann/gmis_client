

Public Class frmRegSigExp
    Inherits frmBasic
    Private ProjectCode As String
    Private CorporationName As String
    Private Const passText As String = "ͨ��"
    Private WorkFlowID As String
    Private TaskID As String
    Private dsBargain As DataSet
    Private bm As CurrencyManager
    Private dsSigPro As DataSet
    Private SystemDate As Date
    Private dsBank As DataSet
    Private dsConTrial As DataSet
    Private isGuaranteeLetter As Boolean = False
    ''�ٵ���
    Private isReGuarantee As Boolean = False    '�Ƿ��ٵ���
    Private dsProjectOrga As DataSet
    Private dsLoanNotice As DataSet
    Private dsServiceType As DataSet

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsSigPro Is Nothing Then
            dsSigPro.Dispose()
        End If
        If Not dsBank Is Nothing Then
            dsBank.Dispose()
        End If
        If Not dsConTrial Is Nothing Then
            dsConTrial.Dispose()
        End If
        If Not dsBargain Is Nothing Then
            dsBargain.Dispose()
        End If
        If Not dsProjectOrga Is Nothing Then
            dsProjectOrga.Dispose()
        End If
        If Not dsLoanNotice Is Nothing Then
            dsLoanNotice.Dispose()
        End If
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
    Friend WithEvents dtpSigDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents dgBargain As System.Windows.Forms.DataGrid
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSigSum As System.Windows.Forms.TextBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Friend WithEvents nbxTerms As SWSystem.Windows.Forms.NumericBox
    Friend WithEvents txtUseCondition As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtOppMeasure As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtOrgaName As SWSystem.Windows.Forms.TextBox
    Friend WithEvents nbxGuaranteeFee As SWSystem.Windows.Forms.NumericBox
    Friend WithEvents nbxReGuaranteeFee As SWSystem.Windows.Forms.NumericBox
    Friend WithEvents txtServiceType As SWSystem.Windows.Forms.TextBox
    Friend WithEvents gpxReGuarantee As System.Windows.Forms.GroupBox
    Friend WithEvents txtRefundType As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtLoanForm As SWSystem.Windows.Forms.TextBox
    Friend WithEvents lblSubBank As System.Windows.Forms.Label
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents gpxSigInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtSourceST As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtSourceGS As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtSourceTerms As SWSystem.Windows.Forms.TextBox
    Friend WithEvents gpxGrid As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents txtExpSignTerm As SWSystem.Windows.Forms.NumericBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRegSigExp))
        Me.gpxGrid = New System.Windows.Forms.GroupBox
        Me.dgBargain = New System.Windows.Forms.DataGrid
        Me.btnCommit = New System.Windows.Forms.Button
        Me.dtpSigDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.gpxSigInfo = New System.Windows.Forms.GroupBox
        Me.cboSubBank = New System.Windows.Forms.ComboBox
        Me.cboBank = New System.Windows.Forms.ComboBox
        Me.lblSubBank = New System.Windows.Forms.Label
        Me.lblBank = New System.Windows.Forms.Label
        Me.txtSigSum = New System.Windows.Forms.TextBox
        Me.lblSum = New System.Windows.Forms.Label
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.txtExpSignTerm = New SWSystem.Windows.Forms.NumericBox
        Me.txtCorName = New System.Windows.Forms.TextBox
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gpxReGuarantee = New System.Windows.Forms.GroupBox
        Me.txtEndDate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStartDate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSourceTerms = New SWSystem.Windows.Forms.TextBox
        Me.txtSourceGS = New SWSystem.Windows.Forms.TextBox
        Me.txtSourceST = New SWSystem.Windows.Forms.TextBox
        Me.txtLoanForm = New SWSystem.Windows.Forms.TextBox
        Me.txtRefundType = New SWSystem.Windows.Forms.TextBox
        Me.txtServiceType = New SWSystem.Windows.Forms.TextBox
        Me.nbxReGuaranteeFee = New SWSystem.Windows.Forms.NumericBox
        Me.nbxGuaranteeFee = New SWSystem.Windows.Forms.NumericBox
        Me.txtOrgaName = New SWSystem.Windows.Forms.TextBox
        Me.txtOppMeasure = New SWSystem.Windows.Forms.TextBox
        Me.txtUseCondition = New SWSystem.Windows.Forms.TextBox
        Me.nbxTerms = New SWSystem.Windows.Forms.NumericBox
        Me.gpxGrid.SuspendLayout()
        CType(Me.dgBargain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxSigInfo.SuspendLayout()
        Me.gpxReGuarantee.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(361, 576)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 9
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'gpxGrid
        '
        Me.gpxGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxGrid.Controls.Add(Me.dgBargain)
        Me.gpxGrid.Location = New System.Drawing.Point(8, 32)
        Me.gpxGrid.Name = "gpxGrid"
        Me.gpxGrid.Size = New System.Drawing.Size(696, 208)
        Me.gpxGrid.TabIndex = 1
        Me.gpxGrid.TabStop = False
        Me.gpxGrid.Text = "��ͬ�б�"
        '
        'dgBargain
        '
        Me.dgBargain.CaptionVisible = False
        Me.dgBargain.DataMember = ""
        Me.dgBargain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBargain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgBargain.Location = New System.Drawing.Point(3, 17)
        Me.dgBargain.Name = "dgBargain"
        Me.dgBargain.Size = New System.Drawing.Size(690, 188)
        Me.dgBargain.TabIndex = 0
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(273, 576)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpSigDate
        '
        Me.dtpSigDate.Location = New System.Drawing.Point(72, 13)
        Me.dtpSigDate.Name = "dtpSigDate"
        Me.dtpSigDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpSigDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ǩԼ����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpxSigInfo
        '
        Me.gpxSigInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxSigInfo.Controls.Add(Me.cboSubBank)
        Me.gpxSigInfo.Controls.Add(Me.cboBank)
        Me.gpxSigInfo.Controls.Add(Me.lblSubBank)
        Me.gpxSigInfo.Controls.Add(Me.lblBank)
        Me.gpxSigInfo.Controls.Add(Me.txtSigSum)
        Me.gpxSigInfo.Controls.Add(Me.lblSum)
        Me.gpxSigInfo.Controls.Add(Me.dtpSigDate)
        Me.gpxSigInfo.Controls.Add(Me.Label1)
        Me.gpxSigInfo.Controls.Add(Me.txtRemark)
        Me.gpxSigInfo.Controls.Add(Me.txtExpSignTerm)
        Me.gpxSigInfo.Location = New System.Drawing.Point(8, 432)
        Me.gpxSigInfo.Name = "gpxSigInfo"
        Me.gpxSigInfo.Size = New System.Drawing.Size(696, 136)
        Me.gpxSigInfo.TabIndex = 6
        Me.gpxSigInfo.TabStop = False
        '
        'cboSubBank
        '
        Me.cboSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubBank.Enabled = False
        Me.cboSubBank.Location = New System.Drawing.Point(352, 41)
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(160, 20)
        Me.cboSubBank.TabIndex = 4
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.Enabled = False
        Me.cboBank.Location = New System.Drawing.Point(72, 41)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(152, 20)
        Me.cboBank.TabIndex = 3
        '
        'lblSubBank
        '
        Me.lblSubBank.AutoSize = True
        Me.lblSubBank.Location = New System.Drawing.Point(256, 44)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(72, 17)
        Me.lblSubBank.TabIndex = 34
        Me.lblSubBank.Text = "֧       ��"
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Location = New System.Drawing.Point(8, 44)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(54, 17)
        Me.lblBank.TabIndex = 33
        Me.lblBank.Text = "ǩԼ����"
        '
        'txtSigSum
        '
        Me.txtSigSum.Location = New System.Drawing.Point(352, 13)
        Me.txtSigSum.Name = "txtSigSum"
        Me.txtSigSum.Size = New System.Drawing.Size(160, 21)
        Me.txtSigSum.TabIndex = 2
        Me.txtSigSum.Text = ""
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(256, 16)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(91, 17)
        Me.lblSum.TabIndex = 7
        Me.lblSum.Text = "ǩԼ���(��Ԫ)"
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(72, 72)
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(632, 56)
        Me.txtRemark.TabIndex = 7
        Me.txtRemark.Text = ""
        '
        'txtExpSignTerm
        '
        Me.txtExpSignTerm.DefaultValue = CType(resources.GetObject("txtExpSignTerm.DefaultValue"), Object)
        Me.txtExpSignTerm.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtExpSignTerm.LabelText = "չ������(��)  "
        Me.txtExpSignTerm.LabelWidth = 91
        Me.txtExpSignTerm.Location = New System.Drawing.Point(544, 16)
        Me.txtExpSignTerm.MaxLength = 3
        Me.txtExpSignTerm.Name = "txtExpSignTerm"
        Me.txtExpSignTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtExpSignTerm.TabIndex = 36
        Me.txtExpSignTerm.Value = CType(resources.GetObject("txtExpSignTerm.Value"), Object)
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(240, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 31
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 30
        Me.txtProjectCode.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(176, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "��ҵ����"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "��Ŀ����"
        '
        'gpxReGuarantee
        '
        Me.gpxReGuarantee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxReGuarantee.Controls.Add(Me.txtEndDate)
        Me.gpxReGuarantee.Controls.Add(Me.Label4)
        Me.gpxReGuarantee.Controls.Add(Me.txtStartDate)
        Me.gpxReGuarantee.Controls.Add(Me.Label3)
        Me.gpxReGuarantee.Controls.Add(Me.txtSourceTerms)
        Me.gpxReGuarantee.Controls.Add(Me.txtSourceGS)
        Me.gpxReGuarantee.Controls.Add(Me.txtSourceST)
        Me.gpxReGuarantee.Controls.Add(Me.txtLoanForm)
        Me.gpxReGuarantee.Controls.Add(Me.txtRefundType)
        Me.gpxReGuarantee.Controls.Add(Me.txtServiceType)
        Me.gpxReGuarantee.Controls.Add(Me.nbxReGuaranteeFee)
        Me.gpxReGuarantee.Controls.Add(Me.nbxGuaranteeFee)
        Me.gpxReGuarantee.Controls.Add(Me.txtOrgaName)
        Me.gpxReGuarantee.Controls.Add(Me.txtOppMeasure)
        Me.gpxReGuarantee.Controls.Add(Me.txtUseCondition)
        Me.gpxReGuarantee.Controls.Add(Me.nbxTerms)
        Me.gpxReGuarantee.Location = New System.Drawing.Point(8, 248)
        Me.gpxReGuarantee.Name = "gpxReGuarantee"
        Me.gpxReGuarantee.Size = New System.Drawing.Size(696, 184)
        Me.gpxReGuarantee.TabIndex = 32
        Me.gpxReGuarantee.TabStop = False
        Me.gpxReGuarantee.Text = "�ٵ�����Ϣ"
        Me.gpxReGuarantee.Visible = False
        '
        'txtEndDate
        '
        Me.txtEndDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEndDate.Location = New System.Drawing.Point(296, 88)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(88, 21)
        Me.txtEndDate.TabIndex = 37
        Me.txtEndDate.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "��  ֹ   �� "
        '
        'txtStartDate
        '
        Me.txtStartDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStartDate.Location = New System.Drawing.Point(88, 88)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.ReadOnly = True
        Me.txtStartDate.Size = New System.Drawing.Size(120, 21)
        Me.txtStartDate.TabIndex = 35
        Me.txtStartDate.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "�� �� ��ʼ��"
        '
        'txtSourceTerms
        '
        Me.txtSourceTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceTerms.DefaultValue = CType(resources.GetObject("txtSourceTerms.DefaultValue"), Object)
        Me.txtSourceTerms.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtSourceTerms.LabelText = "����(����)����(��)"
        Me.txtSourceTerms.LabelWidth = 116
        Me.txtSourceTerms.Location = New System.Drawing.Point(8, 40)
        Me.txtSourceTerms.MaxLength = 32767
        Me.txtSourceTerms.Name = "txtSourceTerms"
        Me.txtSourceTerms.ReadOnly = True
        Me.txtSourceTerms.Size = New System.Drawing.Size(200, 21)
        Me.txtSourceTerms.TabIndex = 33
        Me.txtSourceTerms.Value = CType(resources.GetObject("txtSourceTerms.Value"), Object)
        '
        'txtSourceGS
        '
        Me.txtSourceGS.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceGS.DefaultValue = CType(resources.GetObject("txtSourceGS.DefaultValue"), Object)
        Me.txtSourceGS.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtSourceGS.LabelText = "������(��Ԫ)"
        Me.txtSourceGS.LabelWidth = 91
        Me.txtSourceGS.Location = New System.Drawing.Point(392, 16)
        Me.txtSourceGS.MaxLength = 32767
        Me.txtSourceGS.Name = "txtSourceGS"
        Me.txtSourceGS.ReadOnly = True
        Me.txtSourceGS.Size = New System.Drawing.Size(200, 21)
        Me.txtSourceGS.TabIndex = 32
        Me.txtSourceGS.Value = CType(resources.GetObject("txtSourceGS.Value"), Object)
        '
        'txtSourceST
        '
        Me.txtSourceST.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceST.DefaultValue = CType(resources.GetObject("txtSourceST.DefaultValue"), Object)
        Me.txtSourceST.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtSourceST.LabelText = "����ҵ��Ʒ��"
        Me.txtSourceST.LabelWidth = 79
        Me.txtSourceST.Location = New System.Drawing.Point(216, 16)
        Me.txtSourceST.MaxLength = 32767
        Me.txtSourceST.Name = "txtSourceST"
        Me.txtSourceST.ReadOnly = True
        Me.txtSourceST.Size = New System.Drawing.Size(168, 21)
        Me.txtSourceST.TabIndex = 31
        Me.txtSourceST.Value = CType(resources.GetObject("txtSourceST.Value"), Object)
        '
        'txtLoanForm
        '
        Me.txtLoanForm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanForm.DefaultValue = CType(resources.GetObject("txtLoanForm.DefaultValue"), Object)
        Me.txtLoanForm.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtLoanForm.LabelText = "�� �� �� ʽ "
        Me.txtLoanForm.LabelWidth = 79
        Me.txtLoanForm.Location = New System.Drawing.Point(216, 64)
        Me.txtLoanForm.MaxLength = 32767
        Me.txtLoanForm.Name = "txtLoanForm"
        Me.txtLoanForm.ReadOnly = True
        Me.txtLoanForm.Size = New System.Drawing.Size(168, 21)
        Me.txtLoanForm.TabIndex = 23
        Me.txtLoanForm.Value = CType(resources.GetObject("txtLoanForm.Value"), Object)
        '
        'txtRefundType
        '
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.DefaultValue = CType(resources.GetObject("txtRefundType.DefaultValue"), Object)
        Me.txtRefundType.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtRefundType.LabelText = "�� �� �� ʽ "
        Me.txtRefundType.LabelWidth = 79
        Me.txtRefundType.Location = New System.Drawing.Point(8, 64)
        Me.txtRefundType.MaxLength = 32767
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(200, 21)
        Me.txtRefundType.TabIndex = 22
        Me.txtRefundType.Value = CType(resources.GetObject("txtRefundType.Value"), Object)
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.DefaultValue = CType(resources.GetObject("txtServiceType.DefaultValue"), Object)
        Me.txtServiceType.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtServiceType.LabelText = "ҵ �� Ʒ �� "
        Me.txtServiceType.LabelWidth = 79
        Me.txtServiceType.Location = New System.Drawing.Point(216, 40)
        Me.txtServiceType.MaxLength = 32767
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(168, 21)
        Me.txtServiceType.TabIndex = 20
        Me.txtServiceType.Value = CType(resources.GetObject("txtServiceType.Value"), Object)
        '
        'nbxReGuaranteeFee
        '
        Me.nbxReGuaranteeFee.BackColor = System.Drawing.Color.Gainsboro
        Me.nbxReGuaranteeFee.DefaultValue = CType(resources.GetObject("nbxReGuaranteeFee.DefaultValue"), Object)
        Me.nbxReGuaranteeFee.LabelText = "�� �� ����(Ԫ)"
        Me.nbxReGuaranteeFee.LabelWidth = 91
        Me.nbxReGuaranteeFee.Location = New System.Drawing.Point(392, 64)
        Me.nbxReGuaranteeFee.MaxLength = 32767
        Me.nbxReGuaranteeFee.Name = "nbxReGuaranteeFee"
        Me.nbxReGuaranteeFee.ReadOnly = True
        Me.nbxReGuaranteeFee.Size = New System.Drawing.Size(144, 21)
        Me.nbxReGuaranteeFee.TabIndex = 24
        Me.nbxReGuaranteeFee.Value = CType(resources.GetObject("nbxReGuaranteeFee.Value"), Object)
        '
        'nbxGuaranteeFee
        '
        Me.nbxGuaranteeFee.DefaultValue = CType(resources.GetObject("nbxGuaranteeFee.DefaultValue"), Object)
        Me.nbxGuaranteeFee.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbxGuaranteeFee.LabelText = "�������ܶ�(Ԫ)"
        Me.nbxGuaranteeFee.LabelWidth = 91
        Me.nbxGuaranteeFee.Location = New System.Drawing.Point(392, 40)
        Me.nbxGuaranteeFee.MaxLength = 10
        Me.nbxGuaranteeFee.Name = "nbxGuaranteeFee"
        Me.nbxGuaranteeFee.Size = New System.Drawing.Size(144, 21)
        Me.nbxGuaranteeFee.TabIndex = 27
        Me.nbxGuaranteeFee.Value = CType(resources.GetObject("nbxGuaranteeFee.Value"), Object)
        '
        'txtOrgaName
        '
        Me.txtOrgaName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrgaName.DefaultValue = CType(resources.GetObject("txtOrgaName.DefaultValue"), Object)
        Me.txtOrgaName.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtOrgaName.LabelText = "������������"
        Me.txtOrgaName.LabelWidth = 79
        Me.txtOrgaName.Location = New System.Drawing.Point(8, 16)
        Me.txtOrgaName.MaxLength = 32767
        Me.txtOrgaName.Name = "txtOrgaName"
        Me.txtOrgaName.ReadOnly = True
        Me.txtOrgaName.Size = New System.Drawing.Size(200, 21)
        Me.txtOrgaName.TabIndex = 21
        Me.txtOrgaName.Value = CType(resources.GetObject("txtOrgaName.Value"), Object)
        '
        'txtOppMeasure
        '
        Me.txtOppMeasure.DefaultValue = CType(resources.GetObject("txtOppMeasure.DefaultValue"), Object)
        Me.txtOppMeasure.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtOppMeasure.LabelText = "�� �� ����ʩ"
        Me.txtOppMeasure.LabelWidth = 79
        Me.txtOppMeasure.Location = New System.Drawing.Point(8, 148)
        Me.txtOppMeasure.MaxLength = 1000
        Me.txtOppMeasure.Name = "txtOppMeasure"
        Me.txtOppMeasure.Size = New System.Drawing.Size(664, 32)
        Me.txtOppMeasure.TabIndex = 30
        Me.txtOppMeasure.TextMultiline = True
        Me.txtOppMeasure.Value = CType(resources.GetObject("txtOppMeasure.Value"), Object)
        '
        'txtUseCondition
        '
        Me.txtUseCondition.DefaultValue = CType(resources.GetObject("txtUseCondition.DefaultValue"), Object)
        Me.txtUseCondition.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtUseCondition.LabelText = "����ʹ������"
        Me.txtUseCondition.LabelWidth = 79
        Me.txtUseCondition.Location = New System.Drawing.Point(8, 112)
        Me.txtUseCondition.MaxLength = 1000
        Me.txtUseCondition.Name = "txtUseCondition"
        Me.txtUseCondition.Size = New System.Drawing.Size(664, 32)
        Me.txtUseCondition.TabIndex = 29
        Me.txtUseCondition.TextMultiline = True
        Me.txtUseCondition.Value = CType(resources.GetObject("txtUseCondition.Value"), Object)
        '
        'nbxTerms
        '
        Me.nbxTerms.DefaultValue = CType(resources.GetObject("nbxTerms.DefaultValue"), Object)
        Me.nbxTerms.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.nbxTerms.LabelText = "��������(��)  "
        Me.nbxTerms.LabelWidth = 91
        Me.nbxTerms.Location = New System.Drawing.Point(392, 88)
        Me.nbxTerms.MaxLength = 3
        Me.nbxTerms.Name = "nbxTerms"
        Me.nbxTerms.Size = New System.Drawing.Size(144, 21)
        Me.nbxTerms.TabIndex = 28
        Me.nbxTerms.Value = CType(resources.GetObject("nbxTerms.Value"), Object)
        '
        'frmRegSigExp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 607)
        Me.Controls.Add(Me.txtCorName)
        Me.Controls.Add(Me.txtProjectCode)
        Me.Controls.Add(Me.gpxReGuarantee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gpxSigInfo)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.gpxGrid)
        Me.Name = "frmRegSigExp"
        Me.Text = "�Ǽ�ǩԼ"
        Me.Controls.SetChildIndex(Me.gpxGrid, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.gpxSigInfo, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.gpxReGuarantee, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.gpxGrid.ResumeLayout(False)
        CType(Me.dgBargain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxSigInfo.ResumeLayout(False)
        Me.gpxReGuarantee.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DateTimeFormat(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not IsDBNull(e.Value) Then
            e.Value = String.Format("{0:yyyy��M��d��}", e.Value)
        End If
    End Sub
    Private Sub ShowReGuaranteeProjectInfo()
        gpxReGuarantee.Visible = True
        Dim dsTemp As DataSet = gWs.GetReGuaranteeProjectInfo("{ProjectCode LIKE '" & ProjectCode & "'}")
        Dim tableName As String = dsTemp.Tables(0).TableName
        txtServiceType.DataBindings.Add("Value", dsTemp, tableName & ".ServiceType")   'ҵ��Ʒ��
        txtSourceST.DataBindings.Add("Value", dsTemp, tableName & ".SourceServiceType")   '����ҵ��Ʒ��
        txtSourceGS.DataBindings.Add("Value", dsTemp, tableName & ".SourceLoanSum")  '�ڵ��������ĵ������
        txtSourceTerms.DataBindings.Add("Value", dsTemp, tableName & ".SourceLoanTerm")  '�ڵ��������ĵ�������

        txtOrgaName.DataBindings.Add("Value", dsTemp, tableName & ".OrganizationName") '������������

        Dim StartDateBinding As Binding = New Binding("Text", dsTemp, tableName & ".StartTime")
        AddHandler StartDateBinding.Format, AddressOf DateTimeFormat
        txtStartDate.DataBindings.Add(StartDateBinding) '������ʼ��
        StartDateBinding = Nothing

        Dim EndDateBinding As Binding = New Binding("Text", dsTemp, tableName & ".EndTime")
        AddHandler EndDateBinding.Format, AddressOf DateTimeFormat
        txtEndDate.DataBindings.Add(EndDateBinding) '������ֹ��
        EndDateBinding = Nothing

        txtLoanForm.DataBindings.Add("Value", dsTemp, tableName & ".LoanType") '�ſʽ

        txtRefundType.DataBindings.Add("Value", dsTemp, tableName & ".RefundType") '���ʽ

        dsProjectOrga = gWs.GetProjectOrganization("{project_code LIKE '" & ProjectCode & "'}")
        txtUseCondition.DataBindings.Add("Value", dsProjectOrga, "TProjectOrganization.ServiceCondition") '����ʹ������
        txtOppMeasure.DataBindings.Add("Value", dsProjectOrga, "TProjectOrganization.Counterguarantee") '��������ʩ
        nbxGuaranteeFee.DataBindings.Add("Value", dsProjectOrga, "TProjectOrganization.SourceGuaranteeFee") '�������ܶ�

        '��������
        dsLoanNotice = gWs.GetLoanNoticeInfo("{project_code LIKE '" & ProjectCode & "'}")
        nbxTerms.DataBindings.Add("Value", dsLoanNotice, "loan_notice.term")
        '�ж���û�м�¼����Ĭ��ֵ����������У�֧��
        If dsLoanNotice.Tables(0).Rows.Count > 0 Then
            txtSigSum.Text = dsLoanNotice.Tables(0).Rows(0)("sum") & ""
            cboBank.SelectedValue = dsLoanNotice.Tables(0).Rows(0)("bank")
            cboSubBank.SelectedValue = dsLoanNotice.Tables(0).Rows(0)("branch_bank")
        End If
        '�ٵ����ѽ��(Ԫ)
        Dim GuaranteeSum, GuaranteeRate As Object
        GuaranteeSum = dsConTrial.Tables("conference_trial").Rows(0)("guarantee_sum")
        GuaranteeRate = dsConTrial.Tables("conference_trial").Rows(0)("guarantee_rate")
        nbxReGuaranteeFee.Value = CDbl(GuaranteeSum + "0") * 100 * CDbl(GuaranteeRate + "0") * 0.2
    End Sub

    Private Function SaveReGuaranteeProjectInfo() As Boolean
        Dim result As String
        result = gWs.UpdateProjectOrganization(dsProjectOrga.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "������Ŀ���������", result, "")
            Return False
        End If
        dsProjectOrga.AcceptChanges()
        If dsLoanNotice.Tables(0).Rows.Count > 0 Then
            dsLoanNotice.Tables(0).Rows(0)("sum") = txtSigSum.Text
            dsLoanNotice.Tables(0).Rows(0)("bank") = cboBank.SelectedValue
            dsLoanNotice.Tables(0).Rows(0)("branch_bank") = cboSubBank.SelectedValue
        End If
        If dsLoanNotice.HasChanges Then
            result = gWs.UpdateLoanNotice(dsLoanNotice.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "����LoanNotice����", result, "")
                Return False
            End If
        End If
        dsLoanNotice.AcceptChanges()
        Return True
    End Function

    Private Sub AddTableStyle()
        dgBargain.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "TProjectDocument"
        dgts.AllowSorting = False
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col1.MappingName = "doc_name"
        col1.HeaderText = "��ͬ����"
        col1.ReadOnly = True
        col1.NullText = String.Empty
        col1.Width = 400
        Dim pd As System.ComponentModel.PropertyDescriptor = bm.GetItemProperties()("is_important")
        Dim col2 As DataGridBoolColumn = New DataGridBoolColumn(pd)
        col2.MappingName = "is_important"
        col2.ReadOnly = False
        col2.HeaderText = "�Ѿ�ǩ��"
        col2.NullText = String.Empty
        col2.AllowNull = False
        col2.Width = 70
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col2, col1})
        dgBargain.TableStyles.Add(dgts)
    End Sub

    'ǩԼ��Ϣ���Ĭ�����лظ�����е���Ϣ
    Private Sub CopyValueFromIntentLetterToControl()
        Dim dsIntentLetter As DataSet = gWs.GetIntentLetterInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY intent_code DESC}")
        If dsIntentLetter.Tables(0).Rows.Count > 0 Then
            cboBank.SelectedValue = dsIntentLetter.Tables(0).Rows(0)("loan_bank")
            cboSubBank.SelectedValue = dsIntentLetter.Tables(0).Rows(0)("loan_branch_bank")
            'txtSigSum.Text = dsIntentLetter.Tables(0).Rows(0)("reply_sum") & String.Empty

            '2007-08-12 yjf edit �Ǽ�ǩԼ���Ϊ�����ͨ�������ڱ�����Ŀû�������飬����ȡ�������
            Dim dtTemp As DataTable = gWs.GetCommonQueryInfo("select GuaranteeSum from viewprojectInfo where projectcode='" & MyBase.getProjectCode & "'").Tables(0)
            If dtTemp.Rows.Count <> 0 Then
                txtSigSum.Text = dtTemp.Rows(0)("GuaranteeSum") & String.Empty
            End If
        End If
    End Sub

    Private Sub frmRegSigExp_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ProjectCode = MyBase.getProjectCode
            WorkFlowID = MyBase.getWorkFlowID
            TaskID = MyBase.getTaskID
            CorporationName = MyBase.getCorporationName
            txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode

            SystemDate = gWs.GetSysTime
            dtpSigDate.Value = SystemDate.Date
            dsSigPro = gWs.GetProjectExpandDateInfo("{project_code LIKE '" & ProjectCode & "'}")
            dsBargain = gWs.GetProjectDocumentByCondition("{project_code LIKE '" & ProjectCode & "' AND (NOT check_person is NULL) AND item_type='43'}")
            bm = BindingContext(dsBargain, "TProjectDocument")
            Dim dr As DataRow
            For Each dr In dsBargain.Tables(0).Rows
                If IsDBNull(dr("is_important")) Then
                    dr("is_important") = False
                End If
            Next
            AddTableStyle()
            dgBargain.DataMember = "TProjectDocument"
            dgBargain.DataSource = dsBargain
            Dim dv As DataView = CType(bm.List, DataView)
            dv.AllowDelete = False
            dv.AllowNew = False
            'If dsSigPro.Tables(0).Rows.Count > 0 Then  '���ؼƻ�ǩԼ����
            '    If Not IsDBNull(dsSigPro.Tables(0).Rows(0)("signature_plan_code")) Then
            '        Dim spc As Integer = CInt(dsSigPro.Tables(0).Rows(0)("signature_plan_code"))
            '        Dim ds As DataSet = gWs.GetSignaturePlanInfo("{signature_plan_code=" & spc & "}")
            '        dtpSigDate.Value = DateTime.Parse(ds.Tables(0).Rows(0)("signature_plan_date").ToString)
            '    End If
            'End If
            '���ί��
            AddHandler txtSigSum.Enter, AddressOf Money.Money_Enter
            AddHandler txtSigSum.KeyPress, AddressOf Money.Money_KeyPress

            '���д���
            'dsBank = gWs.GetBankInfo("{0=0 ORDER BY bank_name}", "%")
            'qxd modify 2005-10-21 ͨ���洢ʵ���˰�������������
            dsBank = gWs.GetBankInfo("%", "%")
            Me.cboBank.DataSource = dsBank.Tables("bank")
            Me.cboBank.DisplayMember = "bank_name"
            Me.cboBank.ValueMember = "bank_code"
            dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
            Me.cboSubBank.DataSource = dsBank.Tables("bank_branch").DefaultView
            Me.cboSubBank.DisplayMember = "branch_bank_name"
            Me.cboSubBank.ValueMember = "branch_bank_code"
            AddHandler cboBank.SelectedIndexChanged, AddressOf BankChanged
            BankChanged(Nothing, Nothing)
            dsConTrial = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' AND trial_conclusion LIKE '%" & passText & "%' ORDER BY trial_times DESC}", "null")
            Dim ctDR As DataRow
            If dsConTrial.Tables("conference_trial").Rows.Count > 0 Then
                ctDR = dsConTrial.Tables("conference_trial").Rows(0)
            End If
            If Not ctDR Is Nothing Then
                isGuaranteeLetter = GetServicetypeCode(CStr(ctDR("service_type"))) = "08" 'CStr(ctDR("service_type")).IndexOf("�����ۺ�����") >= 0
                isReGuarantee = GetServicetypeCode(CStr(ctDR("service_type"))) = "07" 'CStr(ctDR("service_type")).IndexOf("�ٵ���") >= 0
                If isReGuarantee Then
                    lblSum.Text = "������(��Ԫ)"
                    lblBank.Text = "��������"
                    lblSubBank.Text = "����֧��"
                End If
            End If
            If isReGuarantee Then '�ٵ���Ʒ��
                ShowReGuaranteeProjectInfo()
                gpxReGuarantee.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            Else    '����Ʒ��
                'ǩԼ��Ϣ���Ĭ�����лظ�����е���Ϣ
                CopyValueFromIntentLetterToControl()
                Me.Height = Me.Height - gpxReGuarantee.Height - 5
                gpxSigInfo.Left = gpxReGuarantee.Left
                gpxSigInfo.Top = gpxReGuarantee.Top - 5
            End If
            gpxGrid.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtSigSum_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtSigSum.Leave
        Try
            If txtSigSum.Text <> String.Empty Then
                Dim d As Double = CDbl(txtSigSum.Text)
            End If
        Catch
            txtSigSum.Text = String.Empty
        End Try
    End Sub

    Private Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboBank.SelectedValue & "'"
    End Sub

    Private Function IsAllConfirm() As Boolean
        Dim dr As DataRow
        For Each dr In dsBargain.Tables("TProjectDocument").Rows
            If Not CBool(dr("is_important")) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function SaveGuaranteeLetter() As Boolean
        If Not isGuaranteeLetter Then Return True '��������ۺ����ţ����ñ���
        Dim dsGuaranteeLetter As DataSet = gWs.GetGuaranteeLetter("{project_code LIKE '" & ProjectCode & "' AND flag=0}")
        If dsGuaranteeLetter.Tables(0).Rows.Count > 0 Then
            With dsGuaranteeLetter.Tables(0).Rows(0)
                '.Item("startdate") = dtpSigDate.Value.Date
                '.Item("enddate") = dtpSigDate.Value.AddMonths(CInt(dsConTrial.Tables("conference_trial").Rows(0)("terms")))
                '.Item("guarantee_line") = CDbl(txtSigSum.Text)
                '.Item("remnant_line") = CDbl(txtSigSum.Text)
                '.Item("bank") = cboBank.SelectedValue
                '.Item("bank_branch") = cboSubBank.SelectedValue
                .Item("flag") = 1
            End With
            Dim result As String = gWs.UpdateGuaranteeLetter(dsGuaranteeLetter.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "�����guarantee_letterʧ��", result, "")
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCommit.Click
        If Not IsAllConfirm() Then
            SWDialogBox.MessageBox.Show("$X049")
            Return
        End If

        If Me.cboBank.SelectedValue Is Nothing Or Me.cboSubBank.SelectedValue Is Nothing Then
            SWDialogBox.MessageBox.Show("$1001", "���л����")
            CType(IIf(Me.cboBank.SelectedValue Is Nothing, Me.cboBank, Me.cboSubBank), ComboBox).Focus()
            Return
        End If

        If txtSigSum.Text = String.Empty OrElse CDbl(txtSigSum.Text) = 0 Then
            SWDialogBox.MessageBox.Show("$1001", "ǩԼ���")
            txtSigSum.Focus()
            Return
        End If

        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "�ύ")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If

        If Not SaveGuaranteeLetter() Then Return '�������ۺ�����ʧ���򷵻�
        If isReGuarantee Then
            If Not SaveReGuaranteeProjectInfo() Then
                Return
            End If
        End If

        If dsSigPro.Tables(0).Rows.Count = 0 Then
            Dim row As DataRow = dsSigPro.Tables(0).NewRow
            row("project_code") = ProjectCode
            row("create_person") = UserName
            row("create_date") = SystemDate
            dsSigPro.Tables(0).Rows.Add(row)
        End If

        With dsSigPro.Tables(0).Rows(0)
            .Item("exp_sign_amount") = CDbl(txtSigSum.Text)
            .Item("exp_sign_term") = CInt(txtExpSignTerm.Text)
            .Item("exp_sign_date") = dtpSigDate.Value.Date
            .Item("exp_sign_bank") = Me.cboBank.SelectedValue
            .Item("exp_sign_bank_branch") = Me.cboSubBank.SelectedValue
            .Item("remark") = txtRemark.Text

            '2007-8-12 yjf add ��ӱ����ͬ�Ź���
            '.Item("loanContract_num") = IIf(txtLoanContractNumber.Text = "", DBNull.Value, txtLoanContractNumber.Text)
            '.Item("assureContract_num") = IIf(txtAssureContractNumber.Text = "", DBNull.Value, txtAssureContractNumber.Text)
        End With

        Dim strResult As String
        strResult = gWs.UpdateProjectDocument(dsBargain.GetChanges)
        strResult += gWs.UpdateProjectExpandDate(dsSigPro.GetChanges)
        If strResult <> "11" Then
            If strResult.StartsWith("1���ض��ַ��������������") Then
                SWDialogBox.MessageBox.Show("��ͬ��ų�����Ŀǰ���ݿ����趨�ĳ��ȣ�", "��ʾ", "���޸ı�project_signature��loanContract_num��assureContract_num�ֶε���󳤶ȣ�", SWDialogBox.MessageBoxButton.Detail, SWDialogBox.MessageBoxIcon.Information)
                dsSigPro.RejectChanges()
            Else
                SWDialogBox.MessageBox.Show("*999", "����ʧ��", strResult, "")
            End If
            Return
        End If

        strResult = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If strResult = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            raiseCommitSucceed()
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "�ύʧ��", strResult, "")
            Return
        End If
    End Sub

    Private Overloads Function GetServicetypeCode(ByVal service_type_name As String) As String
        If dsServiceType Is Nothing Then
            dsServiceType = gWs.GetServiceType("%")
        End If
        Dim table As DataTable = dsServiceType.Tables(0)
        Dim drs() As DataRow = table.Select("service_type='" & service_type_name & "'")
        If drs.Length > 0 Then
            Return drs(0)("service_type_code").ToString
        End If
        Return "Nothing"
    End Function

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dg_CurCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgBargain.CurrentCellChanged
        With dgBargain
            If .CurrentCell.ColumnNumber = 0 Then
                .Item(.CurrentCell) = Not CBool(.Item(.CurrentCell))
            End If
        End With
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
