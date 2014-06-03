Imports System.Globalization

Public Class frmRegisterCorporationInfo
    Inherits System.Windows.Forms.Form

    'qxd add 2003-6-23
    Private strCorporationCode As String
    Private strCorporationName As String
    Private strSerialNum As String
    Private _corporationTypeEx As String
    Private isNoCommited As Boolean
    Private strProjectCode As String
    Private frm As frmQueryCorporationInfo
    'Private isGuaranteeLetter As Boolean = False

    Private dsBank As DataSet
    Private dsRef As DataSet = Nothing

    Private bPageLoaded As Boolean = False
    Public WithEvents cbxHightec As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Public WithEvents cbxImport As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents cbxIndus As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label

    Protected int_TechTypes As Integer = 0 '��������

    Public Event evtAccept()


#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub
    '���ع��캯��
    Public Sub New(ByVal corporationCode As String, ByVal serialNum As String, ByVal frm As frmQueryCorporationInfo)
        Me.new(corporationCode, serialNum, Nothing, frm, Nothing)
    End Sub
    '���ع��캯��
    Public Sub New(ByVal corporationCode As String, ByVal serialnum As String, ByVal dsConsult As DataSet, ByVal frm As frmQueryCorporationInfo)
        Me.new(corporationCode, serialnum, dsConsult, frm, Nothing)
    End Sub
    '���ع��캯��
    Public Sub New(ByVal corporationCode As String, ByVal serialnum As String, ByVal dsConsult As DataSet, ByVal frm As frmQueryCorporationInfo, ByVal strCorpName As String)
        Me.New()
        Me.strCorporationCode = corporationCode
        Me.strSerialNum = serialnum
        Me.dsRef = dsConsult
        Me.frm = frm
        If Not strCorpName Is Nothing AndAlso Not strCorpName = "" Then
            Me.txtCorporation_name.Text = strCorpName
        End If
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ttp As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFound_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAddressDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCorporation_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLyProfit As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtCapital As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtLySales As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtAssets As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents cbxAddressRange As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents cbxProprietorShip As System.Windows.Forms.ComboBox
    Public WithEvents cbxIndustryType As System.Windows.Forms.ComboBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtJob As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents clbTechnology As System.Windows.Forms.CheckedListBox
    Friend WithEvents cbFirstLoan As System.Windows.Forms.CheckBox
    Protected WithEvents nuTerm As System.Windows.Forms.NumericUpDown
    Public WithEvents cbxBankCode As System.Windows.Forms.ComboBox
    Public WithEvents cbxServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVouchSum As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbConsultPerson As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents dtpConsultDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxRecommendItems As System.Windows.Forms.ComboBox
    Friend WithEvents txtRecommendPerson As System.Windows.Forms.TextBox
    Public WithEvents cbxRecommendType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents cmbReimburseType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGuaranteeLetterType As System.Windows.Forms.ComboBox
    Friend WithEvents txtBeneficiary As System.Windows.Forms.TextBox
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents cmbBankBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lblcorpcreditlevel As System.Windows.Forms.Label
    Friend WithEvents txtcorpcreditlevel As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtOrgOpinion As System.Windows.Forms.TextBox
    Friend WithEvents cmbOrgName As System.Windows.Forms.ComboBox
    Friend WithEvents txtProjDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Public WithEvents cmbSserviceType As System.Windows.Forms.ComboBox
    Friend WithEvents txtLoanSum As System.Windows.Forms.TextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Protected WithEvents nudLoanTerm As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCorpDesc As System.Windows.Forms.TextBox
    Friend WithEvents btnMake As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents clbCorporationTypeEx As System.Windows.Forms.CheckedListBox
    Public WithEvents cbxAddressRangeParent As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterCorporationInfo))
        Me.btnSave = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ttp = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.cbxIndus = New System.Windows.Forms.ComboBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.clbCorporationTypeEx = New System.Windows.Forms.CheckedListBox
        Me.cbxHightec = New System.Windows.Forms.ComboBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.cbxImport = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbxAddressRangeParent = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCorpDesc = New System.Windows.Forms.TextBox
        Me.txtcorpcreditlevel = New System.Windows.Forms.TextBox
        Me.lblcorpcreditlevel = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.clbTechnology = New System.Windows.Forms.CheckedListBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.txtJob = New System.Windows.Forms.TextBox
        Me.txtContactPerson = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cbxProprietorShip = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtLyProfit = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtCapital = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtLySales = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtAssets = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbxIndustryType = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbxAddressRange = New System.Windows.Forms.ComboBox
        Me.dtpFound_date = New System.Windows.Forms.DateTimePicker
        Me.txtWebSite = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAddressDetail = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCorporation_name = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.nudLoanTerm = New System.Windows.Forms.NumericUpDown
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.cbxRecommendType = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtLoanSum = New System.Windows.Forms.TextBox
        Me.txtRecommendPerson = New System.Windows.Forms.TextBox
        Me.cmbSserviceType = New System.Windows.Forms.ComboBox
        Me.cbxRecommendItems = New System.Windows.Forms.ComboBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.txtProjDesc = New System.Windows.Forms.TextBox
        Me.cmbOrgName = New System.Windows.Forms.ComboBox
        Me.txtOrgOpinion = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.cmbReimburseType = New System.Windows.Forms.ComboBox
        Me.cmbGuaranteeLetterType = New System.Windows.Forms.ComboBox
        Me.txtBeneficiary = New System.Windows.Forms.TextBox
        Me.txtPurpose = New System.Windows.Forms.TextBox
        Me.cmbBankBranch = New System.Windows.Forms.ComboBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.cmbConsultPerson = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.dtpConsultDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbFirstLoan = New System.Windows.Forms.CheckBox
        Me.nuTerm = New System.Windows.Forms.NumericUpDown
        Me.cbxBankCode = New System.Windows.Forms.ComboBox
        Me.cbxServiceType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtVouchSum = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnAccept = New System.Windows.Forms.Button
        Me.btnMake = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.nudLoanTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 2
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(321, 560)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 212
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 536)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label51)
        Me.TabPage1.Controls.Add(Me.Label50)
        Me.TabPage1.Controls.Add(Me.Label49)
        Me.TabPage1.Controls.Add(Me.cbxIndus)
        Me.TabPage1.Controls.Add(Me.Label48)
        Me.TabPage1.Controls.Add(Me.clbCorporationTypeEx)
        Me.TabPage1.Controls.Add(Me.cbxHightec)
        Me.TabPage1.Controls.Add(Me.Label47)
        Me.TabPage1.Controls.Add(Me.cbxImport)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.cbxAddressRangeParent)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtCorpDesc)
        Me.TabPage1.Controls.Add(Me.txtcorpcreditlevel)
        Me.TabPage1.Controls.Add(Me.lblcorpcreditlevel)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.clbTechnology)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txtMobile)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtFax)
        Me.TabPage1.Controls.Add(Me.txtPhoneNumber)
        Me.TabPage1.Controls.Add(Me.txtJob)
        Me.TabPage1.Controls.Add(Me.txtContactPerson)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.cbxProprietorShip)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.txtLyProfit)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.txtCapital)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.txtLySales)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.txtAssets)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.cbxIndustryType)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cbxAddressRange)
        Me.TabPage1.Controls.Add(Me.dtpFound_date)
        Me.TabPage1.Controls.Add(Me.txtWebSite)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtAddressDetail)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCorporation_name)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(752, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "��ҵ��Ϣ"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Crimson
        Me.Label51.Location = New System.Drawing.Point(503, 304)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(11, 12)
        Me.Label51.TabIndex = 60
        Me.Label51.Text = "*"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Crimson
        Me.Label50.Location = New System.Drawing.Point(112, 331)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(11, 12)
        Me.Label50.TabIndex = 59
        Me.Label50.Text = "*"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.Crimson
        Me.Label49.Location = New System.Drawing.Point(112, 304)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(11, 12)
        Me.Label49.TabIndex = 58
        Me.Label49.Text = "*"
        '
        'cbxIndus
        '
        Me.cbxIndus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIndus.ItemHeight = 12
        Me.cbxIndus.Items.AddRange(New Object() {"��һ��ҵ", "�ڶ���ҵ", "������ҵ"})
        Me.cbxIndus.Location = New System.Drawing.Point(128, 327)
        Me.cbxIndus.Name = "cbxIndus"
        Me.cbxIndus.Size = New System.Drawing.Size(208, 20)
        Me.cbxIndus.TabIndex = 57
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(16, 331)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(53, 12)
        Me.Label48.TabIndex = 56
        Me.Label48.Text = "��ҵ����"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'clbCorporationTypeEx
        '
        Me.clbCorporationTypeEx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clbCorporationTypeEx.CheckOnClick = True
        Me.clbCorporationTypeEx.Location = New System.Drawing.Point(128, 482)
        Me.clbCorporationTypeEx.MultiColumn = True
        Me.clbCorporationTypeEx.Name = "clbCorporationTypeEx"
        Me.clbCorporationTypeEx.Size = New System.Drawing.Size(616, 20)
        Me.clbCorporationTypeEx.TabIndex = 45
        Me.clbCorporationTypeEx.Visible = False
        '
        'cbxHightec
        '
        Me.cbxHightec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxHightec.AutoCompleteCustomSource.AddRange(New String() {"��", "��"})
        Me.cbxHightec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxHightec.ItemHeight = 12
        Me.cbxHightec.Items.AddRange(New Object() {"��", "��"})
        Me.cbxHightec.Location = New System.Drawing.Point(520, 301)
        Me.cbxHightec.Name = "cbxHightec"
        Me.cbxHightec.Size = New System.Drawing.Size(224, 20)
        Me.cbxHightec.TabIndex = 55
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(384, 304)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(101, 12)
        Me.Label47.TabIndex = 54
        Me.Label47.Text = "�Ƿ���¼�����ҵ"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxImport
        '
        Me.cbxImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxImport.ItemHeight = 12
        Me.cbxImport.Items.AddRange(New Object() {"��", "��"})
        Me.cbxImport.Location = New System.Drawing.Point(128, 301)
        Me.cbxImport.Name = "cbxImport"
        Me.cbxImport.Size = New System.Drawing.Size(208, 20)
        Me.cbxImport.TabIndex = 53
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 304)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 12)
        Me.Label29.TabIndex = 52
        Me.Label29.Text = "�Ƿ������"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Crimson
        Me.Label27.Location = New System.Drawing.Point(505, 76)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(11, 12)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Crimson
        Me.Label25.Location = New System.Drawing.Point(113, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 12)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "*"
        '
        'cbxAddressRangeParent
        '
        Me.cbxAddressRangeParent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxAddressRangeParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddressRangeParent.ItemHeight = 12
        Me.cbxAddressRangeParent.Location = New System.Drawing.Point(128, 72)
        Me.cbxAddressRangeParent.Name = "cbxAddressRangeParent"
        Me.cbxAddressRangeParent.Size = New System.Drawing.Size(208, 20)
        Me.cbxAddressRangeParent.TabIndex = 49
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(384, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 12)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "��ҵ������(����)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 12)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "��ҵ������(һ��)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(3, 482)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "��ҵ��������"
        Me.Label8.Visible = False
        '
        'txtCorpDesc
        '
        Me.txtCorpDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorpDesc.Location = New System.Drawing.Point(128, 356)
        Me.txtCorpDesc.MaxLength = 250
        Me.txtCorpDesc.Multiline = True
        Me.txtCorpDesc.Name = "txtCorpDesc"
        Me.txtCorpDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCorpDesc.Size = New System.Drawing.Size(616, 94)
        Me.txtCorpDesc.TabIndex = 43
        '
        'txtcorpcreditlevel
        '
        Me.txtcorpcreditlevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcorpcreditlevel.Location = New System.Drawing.Point(520, 264)
        Me.txtcorpcreditlevel.MaxLength = 5
        Me.txtcorpcreditlevel.Name = "txtcorpcreditlevel"
        Me.txtcorpcreditlevel.Size = New System.Drawing.Size(224, 21)
        Me.txtcorpcreditlevel.TabIndex = 18
        '
        'lblcorpcreditlevel
        '
        Me.lblcorpcreditlevel.Location = New System.Drawing.Point(384, 272)
        Me.lblcorpcreditlevel.Name = "lblcorpcreditlevel"
        Me.lblcorpcreditlevel.Size = New System.Drawing.Size(136, 16)
        Me.lblcorpcreditlevel.TabIndex = 42
        Me.lblcorpcreditlevel.Text = "���ŵȼ�/��ҵ����֤��"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(16, 374)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 12)
        Me.Label33.TabIndex = 41
        Me.Label33.Text = "��ҵ�ſ�"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'clbTechnology
        '
        Me.clbTechnology.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clbTechnology.CheckOnClick = True
        Me.clbTechnology.Location = New System.Drawing.Point(128, 456)
        Me.clbTechnology.MultiColumn = True
        Me.clbTechnology.Name = "clbTechnology"
        Me.clbTechnology.Size = New System.Drawing.Size(616, 20)
        Me.clbTechnology.TabIndex = 19
        Me.clbTechnology.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(16, 460)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(53, 12)
        Me.Label32.TabIndex = 39
        Me.Label32.Text = "��������"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label32.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Crimson
        Me.Label39.Location = New System.Drawing.Point(112, 216)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(11, 12)
        Me.Label39.TabIndex = 35
        Me.Label39.Text = "*"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Crimson
        Me.Label38.Location = New System.Drawing.Point(112, 192)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(11, 12)
        Me.Label38.TabIndex = 34
        Me.Label38.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Crimson
        Me.Label23.Location = New System.Drawing.Point(112, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(11, 12)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "*"
        '
        'txtMobile
        '
        Me.txtMobile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMobile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtMobile.Location = New System.Drawing.Point(520, 216)
        Me.txtMobile.MaxLength = 15
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(224, 21)
        Me.txtMobile.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "��  ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtEmail.Location = New System.Drawing.Point(128, 240)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(208, 21)
        Me.txtEmail.TabIndex = 15
        '
        'txtFax
        '
        Me.txtFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtFax.Location = New System.Drawing.Point(520, 240)
        Me.txtFax.MaxLength = 15
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(224, 21)
        Me.txtFax.TabIndex = 16
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPhoneNumber.Location = New System.Drawing.Point(128, 216)
        Me.txtPhoneNumber.MaxLength = 20
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(208, 21)
        Me.txtPhoneNumber.TabIndex = 13
        '
        'txtJob
        '
        Me.txtJob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtJob.Location = New System.Drawing.Point(520, 184)
        Me.txtJob.MaxLength = 10
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Size = New System.Drawing.Size(224, 21)
        Me.txtJob.TabIndex = 12
        '
        'txtContactPerson
        '
        Me.txtContactPerson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtContactPerson.Location = New System.Drawing.Point(128, 184)
        Me.txtContactPerson.MaxLength = 10
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(208, 21)
        Me.txtContactPerson.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 248)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 12)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Email"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(384, 248)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 12)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "��  ��"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 12)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "��ϵ�绰"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(384, 192)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 12)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "ְ  λ"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 192)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 12)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "��ϵ��"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxProprietorShip
        '
        Me.cbxProprietorShip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxProprietorShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProprietorShip.ItemHeight = 12
        Me.cbxProprietorShip.Location = New System.Drawing.Point(520, 104)
        Me.cbxProprietorShip.Name = "cbxProprietorShip"
        Me.cbxProprietorShip.Size = New System.Drawing.Size(224, 20)
        Me.cbxProprietorShip.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(384, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 12)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "����������"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLyProfit
        '
        Me.txtLyProfit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLyProfit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtLyProfit.Location = New System.Drawing.Point(520, 160)
        Me.txtLyProfit.MaxLength = 10
        Me.txtLyProfit.Name = "txtLyProfit"
        Me.txtLyProfit.Size = New System.Drawing.Size(224, 21)
        Me.txtLyProfit.TabIndex = 10
        Me.txtLyProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(384, 160)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(113, 12)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "���������ܶ�(��Ԫ)"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCapital
        '
        Me.txtCapital.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCapital.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCapital.Location = New System.Drawing.Point(520, 128)
        Me.txtCapital.MaxLength = 10
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(224, 21)
        Me.txtCapital.TabIndex = 8
        Me.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 12)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "���ʲ�(��Ԫ)"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLySales
        '
        Me.txtLySales.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtLySales.Location = New System.Drawing.Point(128, 160)
        Me.txtLySales.MaxLength = 10
        Me.txtLySales.Name = "txtLySales"
        Me.txtLySales.Size = New System.Drawing.Size(208, 21)
        Me.txtLySales.TabIndex = 9
        Me.txtLySales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(16, 160)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(113, 12)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "������������(��Ԫ)"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAssets
        '
        Me.txtAssets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAssets.Location = New System.Drawing.Point(128, 128)
        Me.txtAssets.MaxLength = 10
        Me.txtAssets.Name = "txtAssets"
        Me.txtAssets.Size = New System.Drawing.Size(208, 21)
        Me.txtAssets.TabIndex = 7
        Me.txtAssets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(384, 136)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 12)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "ע���ʱ�(��Ԫ)"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxIndustryType
        '
        Me.cbxIndustryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIndustryType.ItemHeight = 12
        Me.cbxIndustryType.Location = New System.Drawing.Point(128, 104)
        Me.cbxIndustryType.Name = "cbxIndustryType"
        Me.cbxIndustryType.Size = New System.Drawing.Size(208, 20)
        Me.cbxIndustryType.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "��ҵ����"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxAddressRange
        '
        Me.cbxAddressRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddressRange.ItemHeight = 12
        Me.cbxAddressRange.Location = New System.Drawing.Point(520, 72)
        Me.cbxAddressRange.Name = "cbxAddressRange"
        Me.cbxAddressRange.Size = New System.Drawing.Size(224, 20)
        Me.cbxAddressRange.TabIndex = 3
        '
        'dtpFound_date
        '
        Me.dtpFound_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFound_date.CustomFormat = "yyyy �� MM ��"
        Me.dtpFound_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFound_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFound_date.Location = New System.Drawing.Point(552, 15)
        Me.dtpFound_date.Name = "dtpFound_date"
        Me.dtpFound_date.Size = New System.Drawing.Size(192, 21)
        Me.dtpFound_date.TabIndex = 2
        Me.dtpFound_date.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'txtWebSite
        '
        Me.txtWebSite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtWebSite.Location = New System.Drawing.Point(128, 272)
        Me.txtWebSite.MaxLength = 50
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Size = New System.Drawing.Size(208, 21)
        Me.txtWebSite.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "��  ַ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddressDetail.Location = New System.Drawing.Point(128, 43)
        Me.txtAddressDetail.MaxLength = 30
        Me.txtAddressDetail.Name = "txtAddressDetail"
        Me.txtAddressDetail.Size = New System.Drawing.Size(616, 21)
        Me.txtAddressDetail.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ע���ַ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "��������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorporation_name
        '
        Me.txtCorporation_name.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCorporation_name.Location = New System.Drawing.Point(128, 15)
        Me.txtCorporation_name.MaxLength = 30
        Me.txtCorporation_name.Name = "txtCorporation_name"
        Me.txtCorporation_name.Size = New System.Drawing.Size(320, 21)
        Me.txtCorporation_name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��ҵ����"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.nudLoanTerm)
        Me.TabPage2.Controls.Add(Me.Splitter1)
        Me.TabPage2.Controls.Add(Me.cbxRecommendType)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtLoanSum)
        Me.TabPage2.Controls.Add(Me.txtRecommendPerson)
        Me.TabPage2.Controls.Add(Me.cmbSserviceType)
        Me.TabPage2.Controls.Add(Me.cbxRecommendItems)
        Me.TabPage2.Controls.Add(Me.Label46)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.Label44)
        Me.TabPage2.Controls.Add(Me.txtProjDesc)
        Me.TabPage2.Controls.Add(Me.cmbOrgName)
        Me.TabPage2.Controls.Add(Me.txtOrgOpinion)
        Me.TabPage2.Controls.Add(Me.Label43)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Controls.Add(Me.Label41)
        Me.TabPage2.Controls.Add(Me.cmbReimburseType)
        Me.TabPage2.Controls.Add(Me.cmbGuaranteeLetterType)
        Me.TabPage2.Controls.Add(Me.txtBeneficiary)
        Me.TabPage2.Controls.Add(Me.txtPurpose)
        Me.TabPage2.Controls.Add(Me.cmbBankBranch)
        Me.TabPage2.Controls.Add(Me.Label40)
        Me.TabPage2.Controls.Add(Me.Label37)
        Me.TabPage2.Controls.Add(Me.Label36)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.cmbConsultPerson)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.dtpConsultDate)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cbFirstLoan)
        Me.TabPage2.Controls.Add(Me.nuTerm)
        Me.TabPage2.Controls.Add(Me.cbxBankCode)
        Me.TabPage2.Controls.Add(Me.cbxServiceType)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtVouchSum)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(752, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "��Ŀ��Ϣ"
        '
        'nudLoanTerm
        '
        Me.nudLoanTerm.BackColor = System.Drawing.SystemColors.Window
        Me.nudLoanTerm.Enabled = False
        Me.nudLoanTerm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nudLoanTerm.Location = New System.Drawing.Point(544, 202)
        Me.nudLoanTerm.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.nudLoanTerm.Name = "nudLoanTerm"
        Me.nudLoanTerm.Size = New System.Drawing.Size(88, 21)
        Me.nudLoanTerm.TabIndex = 36
        Me.nudLoanTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudLoanTerm.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 510)
        Me.Splitter1.TabIndex = 65
        Me.Splitter1.TabStop = False
        '
        'cbxRecommendType
        '
        Me.cbxRecommendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRecommendType.ItemHeight = 12
        Me.cbxRecommendType.Location = New System.Drawing.Point(128, 15)
        Me.cbxRecommendType.Name = "cbxRecommendType"
        Me.cbxRecommendType.Size = New System.Drawing.Size(128, 20)
        Me.cbxRecommendType.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 12)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "�Ƽ���λ(��)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanSum
        '
        Me.txtLoanSum.Enabled = False
        Me.txtLoanSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtLoanSum.Location = New System.Drawing.Point(128, 202)
        Me.txtLoanSum.MaxLength = 10
        Me.txtLoanSum.Name = "txtLoanSum"
        Me.txtLoanSum.Size = New System.Drawing.Size(248, 21)
        Me.txtLoanSum.TabIndex = 35
        Me.txtLoanSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.Location = New System.Drawing.Point(256, 15)
        Me.txtRecommendPerson.MaxLength = 20
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        Me.txtRecommendPerson.Size = New System.Drawing.Size(120, 21)
        Me.txtRecommendPerson.TabIndex = 44
        Me.txtRecommendPerson.Visible = False
        Me.txtRecommendPerson.WordWrap = False
        '
        'cmbSserviceType
        '
        Me.cmbSserviceType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSserviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSserviceType.Enabled = False
        Me.cmbSserviceType.ItemHeight = 12
        Me.cmbSserviceType.Location = New System.Drawing.Point(544, 176)
        Me.cmbSserviceType.Name = "cmbSserviceType"
        Me.cmbSserviceType.Size = New System.Drawing.Size(200, 20)
        Me.cmbSserviceType.TabIndex = 34
        '
        'cbxRecommendItems
        '
        Me.cbxRecommendItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRecommendItems.ItemHeight = 12
        Me.cbxRecommendItems.Location = New System.Drawing.Point(256, 15)
        Me.cbxRecommendItems.Name = "cbxRecommendItems"
        Me.cbxRecommendItems.Size = New System.Drawing.Size(120, 20)
        Me.cbxRecommendItems.TabIndex = 21
        Me.cbxRecommendItems.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(440, 180)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(77, 12)
        Me.Label46.TabIndex = 62
        Me.Label46.Text = "����ҵ��Ʒ��"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(440, 207)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(77, 12)
        Me.Label45.TabIndex = 61
        Me.Label45.Text = "��������(��)"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(16, 207)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(89, 12)
        Me.Label44.TabIndex = 60
        Me.Label44.Text = "������(��Ԫ)"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjDesc
        '
        Me.txtProjDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProjDesc.Location = New System.Drawing.Point(128, 386)
        Me.txtProjDesc.MaxLength = 255
        Me.txtProjDesc.Multiline = True
        Me.txtProjDesc.Name = "txtProjDesc"
        Me.txtProjDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProjDesc.Size = New System.Drawing.Size(616, 117)
        Me.txtProjDesc.TabIndex = 39
        '
        'cmbOrgName
        '
        Me.cmbOrgName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrgName.Enabled = False
        Me.cmbOrgName.Location = New System.Drawing.Point(128, 175)
        Me.cmbOrgName.MaxLength = 10
        Me.cmbOrgName.Name = "cmbOrgName"
        Me.cmbOrgName.Size = New System.Drawing.Size(248, 20)
        Me.cmbOrgName.TabIndex = 33
        '
        'txtOrgOpinion
        '
        Me.txtOrgOpinion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOrgOpinion.Enabled = False
        Me.txtOrgOpinion.Location = New System.Drawing.Point(128, 240)
        Me.txtOrgOpinion.MaxLength = 1000
        Me.txtOrgOpinion.Multiline = True
        Me.txtOrgOpinion.Name = "txtOrgOpinion"
        Me.txtOrgOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOrgOpinion.Size = New System.Drawing.Size(616, 72)
        Me.txtOrgOpinion.TabIndex = 37
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(16, 242)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(101, 12)
        Me.Label43.TabIndex = 58
        Me.Label43.Text = "���������������"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(16, 180)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(77, 12)
        Me.Label42.TabIndex = 57
        Me.Label42.Text = "������������"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(16, 388)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(83, 12)
        Me.Label41.TabIndex = 56
        Me.Label41.Text = "��Ŀ/��Ʒ�ſ�"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbReimburseType
        '
        Me.cmbReimburseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReimburseType.Enabled = False
        Me.cmbReimburseType.Location = New System.Drawing.Point(128, 121)
        Me.cmbReimburseType.Name = "cmbReimburseType"
        Me.cmbReimburseType.Size = New System.Drawing.Size(248, 20)
        Me.cmbReimburseType.TabIndex = 29
        '
        'cmbGuaranteeLetterType
        '
        Me.cmbGuaranteeLetterType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGuaranteeLetterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGuaranteeLetterType.Enabled = False
        Me.cmbGuaranteeLetterType.Location = New System.Drawing.Point(544, 96)
        Me.cmbGuaranteeLetterType.Name = "cmbGuaranteeLetterType"
        Me.cmbGuaranteeLetterType.Size = New System.Drawing.Size(200, 20)
        Me.cmbGuaranteeLetterType.TabIndex = 28
        '
        'txtBeneficiary
        '
        Me.txtBeneficiary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBeneficiary.Enabled = False
        Me.txtBeneficiary.Location = New System.Drawing.Point(544, 122)
        Me.txtBeneficiary.MaxLength = 20
        Me.txtBeneficiary.Name = "txtBeneficiary"
        Me.txtBeneficiary.Size = New System.Drawing.Size(200, 21)
        Me.txtBeneficiary.TabIndex = 30
        '
        'txtPurpose
        '
        Me.txtPurpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPurpose.Location = New System.Drawing.Point(128, 322)
        Me.txtPurpose.MaxLength = 255
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPurpose.Size = New System.Drawing.Size(616, 56)
        Me.txtPurpose.TabIndex = 38
        '
        'cmbBankBranch
        '
        Me.cmbBankBranch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBankBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBankBranch.Location = New System.Drawing.Point(544, 70)
        Me.cmbBankBranch.Name = "cmbBankBranch"
        Me.cmbBankBranch.Size = New System.Drawing.Size(200, 20)
        Me.cmbBankBranch.TabIndex = 26
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(440, 72)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(77, 12)
        Me.Label40.TabIndex = 50
        Me.Label40.Text = "�������֧��"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(440, 126)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(41, 12)
        Me.Label37.TabIndex = 49
        Me.Label37.Text = "������"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(16, 126)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 12)
        Me.Label36.TabIndex = 48
        Me.Label36.Text = "������������"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(440, 99)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 12)
        Me.Label35.TabIndex = 47
        Me.Label35.Text = "����Ʒ��"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(16, 322)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 12)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "��  ;"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbConsultPerson
        '
        Me.cmbConsultPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConsultPerson.Location = New System.Drawing.Point(128, 148)
        Me.cmbConsultPerson.MaxLength = 10
        Me.cmbConsultPerson.Name = "cmbConsultPerson"
        Me.cmbConsultPerson.Size = New System.Drawing.Size(248, 20)
        Me.cmbConsultPerson.TabIndex = 31
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 153)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(53, 12)
        Me.Label30.TabIndex = 40
        Me.Label30.Text = "��ѯ��Ա"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpConsultDate
        '
        Me.dtpConsultDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpConsultDate.CustomFormat = ""
        Me.dtpConsultDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpConsultDate.Location = New System.Drawing.Point(544, 149)
        Me.dtpConsultDate.Name = "dtpConsultDate"
        Me.dtpConsultDate.Size = New System.Drawing.Size(200, 21)
        Me.dtpConsultDate.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(440, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "��ѯ����"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbFirstLoan
        '
        Me.cbFirstLoan.Checked = True
        Me.cbFirstLoan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFirstLoan.Location = New System.Drawing.Point(544, 10)
        Me.cbFirstLoan.Name = "cbFirstLoan"
        Me.cbFirstLoan.Size = New System.Drawing.Size(16, 24)
        Me.cbFirstLoan.TabIndex = 22
        '
        'nuTerm
        '
        Me.nuTerm.BackColor = System.Drawing.Color.White
        Me.nuTerm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nuTerm.Location = New System.Drawing.Point(128, 40)
        Me.nuTerm.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.nuTerm.Name = "nuTerm"
        Me.nuTerm.Size = New System.Drawing.Size(79, 21)
        Me.nuTerm.TabIndex = 24
        Me.nuTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nuTerm.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'cbxBankCode
        '
        Me.cbxBankCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBankCode.ItemHeight = 12
        Me.cbxBankCode.Location = New System.Drawing.Point(128, 67)
        Me.cbxBankCode.Name = "cbxBankCode"
        Me.cbxBankCode.Size = New System.Drawing.Size(248, 20)
        Me.cbxBankCode.TabIndex = 25
        '
        'cbxServiceType
        '
        Me.cbxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxServiceType.ItemHeight = 12
        Me.cbxServiceType.Location = New System.Drawing.Point(128, 94)
        Me.cbxServiceType.Name = "cbxServiceType"
        Me.cbxServiceType.Size = New System.Drawing.Size(248, 20)
        Me.cbxServiceType.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "�����������"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 12)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "����ҵ��Ʒ��"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 12)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "���뵣������(��)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVouchSum
        '
        Me.txtVouchSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtVouchSum.Location = New System.Drawing.Point(544, 40)
        Me.txtVouchSum.MaxLength = 10
        Me.txtVouchSum.Name = "txtVouchSum"
        Me.txtVouchSum.Size = New System.Drawing.Size(200, 21)
        Me.txtVouchSum.TabIndex = 23
        Me.txtVouchSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(440, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 12)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "�Ƿ��״δ���"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(440, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 12)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "������(��Ԫ)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(495, 560)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 214
        Me.btnExit.Text = "�� ��(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccept.ImageIndex = 1
        Me.btnAccept.ImageList = Me.ImageList1
        Me.btnAccept.Location = New System.Drawing.Point(408, 560)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(77, 24)
        Me.btnAccept.TabIndex = 213
        Me.btnAccept.Text = "�� ��(&A)"
        Me.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMake
        '
        Me.btnMake.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMake.ImageIndex = 3
        Me.btnMake.ImageList = Me.ImageList1
        Me.btnMake.Location = New System.Drawing.Point(207, 560)
        Me.btnMake.Name = "btnMake"
        Me.btnMake.Size = New System.Drawing.Size(104, 24)
        Me.btnMake.TabIndex = 211
        Me.btnMake.Text = "���ɲɼ���(&M)"
        Me.btnMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmRegisterCorporationInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(778, 591)
        Me.Controls.Add(Me.btnMake)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRegisterCorporationInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�Ǽ���ѯ��ҵ��Ϣ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nudLoanTerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "��ļ�������"    '
    'ϵͳ����
    '
    Private SysDate As Date = VouchService.GetSysTime()
    '
    '�����Ƿ�ı�
    '
    Private bChanged As Boolean = False
    ReadOnly Property NeedSave() As Boolean
        Get
            Return bChanged
        End Get
    End Property
    '
    '�Ƿ�������ҵ
    '
    Private bNewCorporation As Boolean = False
    Property NewCorporation() As Boolean
        Get
            Return bNewCorporation
        End Get
        Set(ByVal Value As Boolean)
            bNewCorporation = Value
        End Set
    End Property
    '
    '�Ƿ���Ҫ������¼
    Private bNewRecord As Boolean = True
    Property NeedNewRecord() As Boolean
        Get
            Return bNewRecord
        End Get
        Set(ByVal Value As Boolean)
            bNewRecord = Value
        End Set
    End Property
#End Region


    Private Sub frmRegisterCorporationInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            '�����ݣ�ȡ�ø����ؼ�����Ҫ�����ݱ��󶨶�Ӧ�ֶ�
            bindingData()

            'ӳ��ؼ������õ����ݼ������г�ʼֵ�Ŀؼ���ʼ���������ʼ���ݼ����ڵ�)
            BindControls()

            '����¼���ʹ 1������пؼ����ݱ仯����ischangeΪtrue��2������ؼ���ʾ��Ǯ�йص���������ʾΪ������
            addHand()

            '��������ť�Ƿ����
            If Me.NeedNewRecord Then
                Me.btnAccept.Enabled = False
                Me.btnMake.Enabled = False
            Else
                Me.btnAccept.Enabled = True
                Me.btnMake.Enabled = True
            End If

            bPageLoaded = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '������
    Private Sub bindingData()

        '�������

        Me.cbxAddressRangeParent.DataSource = DistrictDSParent.Tables(0)
        Me.cbxAddressRangeParent.DisplayMember = "district_parent_name"
        Me.cbxAddressRangeParent.ValueMember = "district_parent_name"

        Me.cbxAddressRange.DataSource = VouchService.GetCommonQueryInfo("select * from district where district_parent_name='" & cbxAddressRangeParent.SelectedValue & "' order by district_code").Tables(0)
        Me.cbxAddressRange.DisplayMember = "district_name"
        Me.cbxAddressRange.ValueMember = "district_name"

        '�����������
        'dsBank = gWs.GetBankInfo("{bank_name like '%' order by bank_name}", "{branch_bank_name like '%' order by branch_bank_name}")
        'qxd modify 2005-10-21 ͨ���洢ʵ���˰�������������
        dsBank = gWs.GetBankInfo("%", "%")
        Me.cbxBankCode.DataSource = dsBank.Tables("bank")
        Me.cbxBankCode.DisplayMember = "bank_name"
        Me.cbxBankCode.ValueMember = "bank_code"
        Me.cmbBankBranch.DataSource = dsBank.Tables("bank_branch").DefaultView
        Me.cmbBankBranch.DisplayMember = "branch_bank_name"
        Me.cmbBankBranch.ValueMember = "branch_bank_code"
        AddHandler cbxBankCode.SelectedIndexChanged, AddressOf BankChanged
        BankChanged(Nothing, Nothing)

        '�Ƽ�����
        Me.cbxRecommendType.DataSource = RecommendTypeDS.Tables("TRecommendType")
        Me.cbxRecommendType.DisplayMember = "recommend_type"
        Me.cbxRecommendType.ValueMember = "type_code"
        Me.cbxRecommendType.SelectedValue = "01"

        'ҵ��Ʒ��
        Me.cbxServiceType.DataSource = ServiceTypeDS.Tables("TServiceType")
        Me.cbxServiceType.DisplayMember = "service_type"
        Me.cbxServiceType.ValueMember = "service_type"
        AddHandler cbxServiceType.SelectedIndexChanged, AddressOf cbxServiceType_SelectedIndexChanged

        '��ҵ����
        Me.cbxIndustryType.DataSource = IndustryTypeDS.Tables("TIndustryType")
        Me.cbxIndustryType.DisplayMember = "industry_type"
        Me.cbxIndustryType.ValueMember = "industry_type"

        '����������
        Me.cbxProprietorShip.DataSource = ProprietorShipDS.Tables("TProprietorshipType")
        Me.cbxProprietorShip.DisplayMember = "proprietorship_type"
        Me.cbxProprietorShip.ValueMember = "proprietorship_type"

        '��ѯ��Ա
        Me.cmbConsultPerson.DataSource = StaffDS.Tables("TStaff")
        Me.cmbConsultPerson.DisplayMember = "staff_name"
        Me.cmbConsultPerson.ValueMember = "staff_name"
        Me.cmbConsultPerson.SelectedValue = UserName


        '��������
        Me.clbTechnology.DataSource = TechnologyTypeDS.Tables("TTechnologyType")
        Me.clbTechnology.DisplayMember = "technology_type"
        Me.clbTechnology.ValueMember = "technology_type_code"


        '����Ʒ��
        bindingGuaranteeLetterType()

        '
        '������������
        '
        bindingReimburseType()
        '
        '������������
        Try
            Dim dsOrg As DataSet = gWs.GetTOrganizationInfo("%")
            Me.cmbOrgName.DataSource = dsOrg.Tables("Torganization")
            Me.cmbOrgName.DisplayMember = "Name"
            Me.cmbOrgName.ValueMember = "OrganNo"
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        '
        'Դ����ҵ��Ʒ��
        '
        Me.cmbSserviceType.DataSource = ServiceTypeDS().Tables("TServiceType")
        Me.cmbSserviceType.DisplayMember = "service_type"
        Me.cmbSserviceType.ValueMember = "service_type"

        '2009-09-11 yjf add
        '��ҵ������չ
        Me.SetCorporationTypeEx("")
    End Sub

    '�������б����ʼ��֧�е�ComboBox
    Protected Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.cmbBankBranch.DataBindings.Clear()
        Me.dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cbxBankCode.SelectedValue & "'"
    End Sub
    '
    '����¼�
    '
    Private Sub addHand()
        '�⼸���¼���ʹ�⼸���ı����е���ʾΪ������
        AddHandler txtAssets.Leave, New EventHandler(AddressOf ShowCurrency) '���ʲ�
        AddHandler txtCapital.Leave, New EventHandler(AddressOf ShowCurrency) 'ע���ʱ�
        AddHandler txtLySales.Leave, New EventHandler(AddressOf ShowCurrency) 'ȥ�������ܶ�
        AddHandler txtLyProfit.Leave, New EventHandler(AddressOf ShowCurrency) 'ȥ�������ܶ�
        AddHandler txtVouchSum.Leave, New EventHandler(AddressOf ShowCurrency) '�������
        AddHandler txtLoanSum.Leave, New EventHandler(AddressOf ShowCurrency)  '�ٵ���ʱԴ������

        '�������е��¼���ʹ�����һ���ؼ��е����ݳ��ָ��ģ���ischangeΪtrue����Ҫ����
        AddHandler txtCorporation_name.TextChanged, AddressOf The_TextChanged  '��ҵ����
        AddHandler dtpFound_date.TextChanged, AddressOf The_TextChanged  '��������
        AddHandler cbxAddressRangeParent.SelectedValueChanged, AddressOf cbxAddressRangeParent_TextChanged
        AddHandler cbxAddressRange.SelectedValueChanged, AddressOf The_TextChanged  'ע������
        AddHandler txtAddressDetail.TextChanged, AddressOf The_TextChanged  'ע���ַ
        AddHandler cbxIndustryType.SelectedValueChanged, AddressOf The_TextChanged  '��ҵ����
        AddHandler cbxProprietorShip.SelectedValueChanged, AddressOf The_TextChanged  '����������





        AddHandler txtWebSite.TextChanged, AddressOf The_TextChanged  '��λ��ַ
        AddHandler txtAssets.TextChanged, AddressOf The_TextChanged '���ʲ�
        AddHandler txtCapital.TextChanged, AddressOf The_TextChanged 'ע���ʱ�
        AddHandler txtLySales.TextChanged, AddressOf The_TextChanged '������������
        AddHandler txtLyProfit.TextChanged, AddressOf The_TextChanged '���������ܶ�
        AddHandler txtContactPerson.TextChanged, AddressOf The_TextChanged '��ϵ��
        AddHandler txtJob.TextChanged, AddressOf The_TextChanged '��ϵ��ְλ��Ϣ
        AddHandler txtPhoneNumber.TextChanged, AddressOf The_TextChanged '��ϵ�绰
        AddHandler txtMobile.TextChanged, AddressOf The_TextChanged '�ֻ�
        AddHandler txtEmail.TextChanged, AddressOf The_TextChanged 'email
        AddHandler txtFax.TextChanged, AddressOf The_TextChanged '����
        AddHandler txtCorpDesc.TextChanged, AddressOf The_TextChanged '��ҵ�ſ�

        AddHandler dtpConsultDate.TextChanged, AddressOf The_TextChanged2  '��ѯ���� 'qxd add 2003-6-6
        AddHandler cmbConsultPerson.SelectedValueChanged, AddressOf The_TextChanged2  '��ѯ��Ա '
        AddHandler txtProjDesc.TextChanged, AddressOf The_TextChanged2 '��Ʒ����
        AddHandler txtVouchSum.TextChanged, AddressOf The_TextChanged2 '���뵣�����
        AddHandler txtLoanSum.TextChanged, AddressOf The_TextChanged2  '�ٵ���ʱԴ������
        AddHandler nuTerm.TextChanged, AddressOf The_TextChanged2      '���뵣������
        AddHandler cbxBankCode.SelectedValueChanged, AddressOf The_TextChanged2 '�����������
        AddHandler cbxServiceType.SelectedValueChanged, AddressOf The_TextChanged2 '����ҵ��Ʒ��
        AddHandler cmbBankBranch.SelectedValueChanged, AddressOf The_TextChanged2 '�������֧��
        AddHandler cmbGuaranteeLetterType.SelectedValueChanged, AddressOf The_TextChanged2 '����Ʒ��
        AddHandler cmbReimburseType.SelectedValueChanged, AddressOf The_TextChanged2 '������������
        AddHandler txtPurpose.TextChanged, AddressOf The_TextChanged2 '��;
        AddHandler txtBeneficiary.TextChanged, AddressOf The_TextChanged2 '������

        AddHandler cbFirstLoan.CheckStateChanged, AddressOf FirstLoanStateChanged '�Ƿ��״δ���
        AddHandler txtRecommendPerson.TextChanged, AddressOf txtRecommendPerson_TextChanged '�Ƽ���λ�����
        AddHandler cbxRecommendItems.SelectedIndexChanged, AddressOf cbxRecommendItems_SelectedIndexChanged
        AddHandler cbxRecommendType.SelectedIndexChanged, AddressOf cbxRecommendType_SelectedIndexChanged
        AddHandler TabControl1.SelectedIndexChanged, AddressOf TabControl1_TabIndexChanged
        AddHandler clbTechnology.ItemCheck, AddressOf clbTechType_ItemCheck
        AddHandler clbCorporationTypeEx.ItemCheck, AddressOf clbCorporationTypeEx_ItemCheck
    End Sub

    '
    'ӳ��ؼ������õ����ݼ����󶨿ؼ����ֶ�
    '
    Private Sub BindControls()

        If dsRef Is Nothing Then Return '��ʼ��ʱΪ�������崫��
        If dsRef.Tables("consultation").Rows.Count <= 0 Then Return

        Dim dr As DataRow() = dsRef.Tables("consultation").Select("serial_num='" & Me.strSerialNum & "'")

        With dr(0)
            '��ҵ����
            If Not .Item("corporation_name") Is System.DBNull.Value Then
                Me.txtCorporation_name.Text = .Item("corporation_name")
            End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '��Ʒ����ҵ
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '��ҵ����
            If Not .Item("industry_type") Is System.DBNull.Value Then
                Me.cbxIndustryType.SelectedValue = .Item("industry_type")
            End If
            '��������
            If Not .Item("found_date") Is System.DBNull.Value Then
                Me.dtpFound_date.Value = .Item("found_date")
            End If
            '����������
            If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                Me.cbxProprietorShip.SelectedValue = .Item("proprietorship_type")
            End If
            '��ҵ�ſ�
            If Not .Item("corporation_description") Is System.DBNull.Value Then
                Me.txtCorpDesc.Text = .Item("corporation_description")
            End If
            '��Ŀ��Ʒ��Ϣ
            If Not .Item("product_description") Is System.DBNull.Value Then
                Me.txtProjDesc.Text = .Item("product_description")
            End If
            'վ��
            If Not .Item("web_site") Is System.DBNull.Value Then
                Me.txtWebSite.Text = .Item("web_site")
            End If
            '���ŵǼǻ���ҵ����֤��
            If Not .Item("credit_grade") Is System.DBNull.Value Then
                Me.txtcorpcreditlevel.Text = .Item("credit_grade")
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '��ַ��Ϣ
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '�������
            If Not .Item("district_name") Is System.DBNull.Value Then
                Me.cbxAddressRangeParent.SelectedValue = .Item("district_parent_name")
                Me.cbxAddressRange.SelectedValue = .Item("district_name")
            End If

            '��ϸ��ַ
            If Not .Item("register_address") Is System.DBNull.Value Then
                Me.txtAddressDetail.Text = .Item("register_address")
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '�Ƽ���Ϣ
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '�Ƽ�����
            If Not .Item("recommend_type") Is System.DBNull.Value Then
                str_RecommendMethod = .Item("recommend_type")
                Me.cbxRecommendType.Text = str_RecommendMethod
            End If
            '�Ƽ���
            If Not .Item("recommend_person") Is System.DBNull.Value Then
                str_RecommendType = .Item("recommend_person")
                SelectReommends(str_RecommendType)
                If Not Me.cbxRecommendItems.DataSource Is Nothing Then
                    Me.cbxRecommendItems.SelectedValue = Me.str_RecommendType
                End If
                Me.txtRecommendPerson.Text = Me.str_RecommendType
            End If

         

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '������Ϣ
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '�Ƿ��һ�δ���
            If Not .Item("is_first_loan") Is System.DBNull.Value Then
                Me.cbFirstLoan.Checked = .Item("is_first_loan")
            End If
            '�������
            If Not .Item("apply_guarantee_sum") Is System.DBNull.Value Then
                Me.txtVouchSum.Text = Numeric2Currency(.Item("apply_guarantee_sum"))
            End If
            '��������
            If Not .Item("apply_term") Is System.DBNull.Value Then
                Me.nuTerm.Text = .Item("apply_term")
            End If
            '�����������
            'Me.cbxBankCode.DataBindings.Add("SelectedValue", dsRef, "consultation.apply_bank_code")           '�Ƽ�����
            'Me.BankChanged(Nothing, Nothing) '����֧��ComboBox������
            'Me.cmbBankBranch.DataBindings.Add("SelectedValue", dsRef, "consultation.apply_branch_code")  '�Ƽ�֧��
            If Not .Item("apply_bank_code") Is System.DBNull.Value Then
                Me.cbxBankCode.SelectedValue = .Item("apply_bank_code")
                Me.BankChanged(Nothing, Nothing) '����֧��ComboBox������
            End If
            '����ҵ��Ʒ��
            If Not .Item("apply_service_type") Is System.DBNull.Value Then
                Me.cbxServiceType.SelectedValue = .Item("apply_service_type")
            End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '�ʽ���Ϣ
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'ע���ʱ�
            If Not .Item("register_capital") Is System.DBNull.Value Then
                Me.txtCapital.Text = Numeric2Currency(.Item("register_capital"))
            End If
            '���ʲ�
            If Not .Item("total_assets") Is System.DBNull.Value Then
                Me.txtAssets.Text = Numeric2Currency(.Item("total_assets"))
            End If
            'ȥ�����۶�
            If Not .Item("lastyear_sales_income") Is System.DBNull.Value Then
                Me.txtLySales.Text = Numeric2Currency(.Item("lastyear_sales_income"))
            End If
            'ȥ��������
            If Not .Item("lastyear_total_profit") Is System.DBNull.Value Then
                Me.txtLyProfit.Text = Numeric2Currency(.Item("lastyear_total_profit"))
            End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '��ϵ����Ϣ
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '��ϵ��
            If Not .Item("contact_person") Is System.DBNull.Value Then
                Me.txtContactPerson.Text = .Item("contact_person")
            End If
            'ְλ
            If Not .Item("job") Is System.DBNull.Value Then
                Me.txtJob.Text = .Item("job")
            End If
            '�绰����
            If Not .Item("phone_num") Is System.DBNull.Value Then
                Me.txtPhoneNumber.Text = .Item("phone_num")
            End If
            '�ֻ�
            If Not .Item("mobile") Is System.DBNull.Value Then
                Me.txtMobile.Text = .Item("mobile")
            End If
            '����
            If Not .Item("fax") Is System.DBNull.Value Then
                Me.txtFax.Text = .Item("fax")
            End If
            'e_mail
            If Not .Item("e_mail") Is System.DBNull.Value Then
                Me.txtEmail.Text = .Item("e_mail")
            End If
            '��ѯ����
            If Not .Item("consult_date") Is System.DBNull.Value Then
                Me.dtpConsultDate.Value = .Item("consult_date")
            End If
            '��ѯ��Ա
            If Not .Item("consult_person") Is System.DBNull.Value Then
                'Me.cmbConsultPerson.Text = .Item("consult_person")
                Me.cmbConsultPerson.SelectedValue = .Item("consult_person")
            End If
            '
            '�������͵ĳ�ʼ��
            '
            If dsRef.Tables("consultation").Rows.Count > 0 Then
                Dim strSql As String = "serial_num='" & Me.strSerialNum & "'"
                Dim drSelect As DataRow() = dsRef.Tables("consultation").Select(strSql)
                If drSelect.Length > 0 Then
                    int_TechTypes = IIf(IsDBNull(dr(0).Item("technology_type")), 0, dr(0).Item("technology_type"))
                Else
                    int_TechTypes = 0
                End If
            Else
                int_TechTypes = 0
            End If

            '2009-09-10 yjf add ��ʼ����ҵ������չ
            _corporationTypeEx = IIf(IsDBNull(.Item("corporation_type_ex")), "", .Item("corporation_type_ex"))
            SetCorporationTypeEx(_corporationTypeEx)

            '�������ͣ���ʼ����ҵ�����ʣ�����Ϊ���¿Ƽ���ҵ��
            InitTechType()

            'qxd add 2003-12-2
            '����Ʒ��
            If Not .Item("guarantee_letter_type") Is System.DBNull.Value Then
                Me.cmbGuaranteeLetterType.SelectedValue = .Item("guarantee_letter_type")
            End If
            '������������
            If Not .Item("reimburse_type") Is System.DBNull.Value Then
                Me.cmbReimburseType.SelectedValue = .Item("reimburse_type")
            End If
            '�������֧��
            If Not .Item("apply_branch_code") Is System.DBNull.Value Then
                Me.cmbBankBranch.SelectedValue = .Item("apply_branch_code")
            End If
            '������
            If Not .Item("beneficiary") Is System.DBNull.Value Then
                Me.txtBeneficiary.Text = .Item("beneficiary")
            End If
            '��; 
            If Not .Item("purpose") Is System.DBNull.Value Then
                Me.txtPurpose.Text = .Item("purpose")
            End If
            '������������
            If Not .Item("organno") Is System.DBNull.Value Then
                Me.cmbOrgName.SelectedValue = .Item("organno")
            End If
            '���������������
            If Not .Item("organization_opinion") Is System.DBNull.Value Then
                Me.txtOrgOpinion.Text = .Item("organization_opinion")
            End If
            '�ٵ���ʱ����ҵ��Ʒ��
            If Not .Item("source_service_type") Is System.DBNull.Value Then
                Me.cmbSserviceType.SelectedValue = .Item("source_service_type")
            End If
            '�ٵ���ʱ������
            If Not .Item("source_guarantee_sum") Is System.DBNull.Value Then
                Me.txtLoanSum.Text = Currency2Numeric(.Item("source_guarantee_sum"))
            End If
            '�ٵ���ʱ��������
            If Not .Item("source_guarantee_term") Is System.DBNull.Value Then
                'Me.nudLoanTerm.Text = .Item("source_guarantee_term")
            End If
        End With
    End Sub

    '
    '�������Ϣ����Ϊ�գ���Ҫ����Ϣ�����к�ɫ��ǵ�
    '
    Private Function EmptyTestSuccess() As Boolean
        '
        '��ҵ���Ʋ���Ϊ��
        '
        Me.txtCorporation_name.Text = Me.txtCorporation_name.Text.Trim()
        If Me.txtCorporation_name.Text = "" Then
            'MsgBox("��ҵ���Ʋ����ڣ�", MsgBoxStyle.Critical, "��ѯ")
            SWDialogBox.MessageBox.Show("$1001", "��ҵ����")
            Me.TabControl1.SelectedTab = Me.TabPage1
            Me.txtCorporation_name.Focus()
            Return False
        End If


        '��ϵ�˲���Ϊ��
        '
        If Me.txtContactPerson.Text = "" Then
            'MsgBox("��ϵ�˲���Ϊ�գ�", MsgBoxStyle.Critical, "��ѯ")
            SWDialogBox.MessageBox.Show("$1001", "��ϵ��")
            Me.txtContactPerson.Focus()
            Return False
        End If

        '��ϵ�绰����Ϊ��
        '
        If Me.txtPhoneNumber.Text = "" Then
            'MsgBox("��ϵ�绰����Ϊ�գ�", MsgBoxStyle.Critical, "��ѯ")
            SWDialogBox.MessageBox.Show("$1001", "��ϵ�绰")
            Me.txtPhoneNumber.Focus()
            Return False
        End If


        If Me.cbxAddressRangeParent.Text = "" Then
            SWDialogBox.MessageBox.Show("$1001", "��ҵ������(һ��)")
            Me.cbxAddressRangeParent.Focus()
            Return False
        End If

        If Me.cbxAddressRange.Text = "" Then
            SWDialogBox.MessageBox.Show("$1001", "��ҵ������(����)")
            Me.cbxAddressRange.Focus()
            Return False
        End If
        '�Ƿ�����ڲ���Ϊ��
        If Me.cbxImport.Text = "" Then
            SWDialogBox.MessageBox.Show("$1001", "�Ƿ������")
            Me.cbxImport.Focus()
            Return False
        End If

        '�Ƿ���¼�����ҵ����Ϊ��

        If Me.cbxHightec.Text = "" Then
            SWDialogBox.MessageBox.Show("$1001", "�Ƿ���¼�����ҵ")
            Me.cbxHightec.Focus()
            Return False
        End If

       
        '��ҵ����
        If Me.cbxIndus.Text = "" Then
            SWDialogBox.MessageBox.Show("$1001", "��ҵ����")
            Me.cbxIndus.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function Save() As Boolean
        Dim strReSult As String
        Dim dr As DataRow

        Try
            Me.Cursor = Cursors.WaitCursor
            If Me.NeedNewRecord Then
                dsRef = VouchService.GetcorporationInfo("null", "null")
                dr = dsRef.Tables("consultation").NewRow 'Ϊ������ҵ���ٴ�����
                setValue(dr)
                dsRef.Tables("consultation").Rows.Add(dr)
            Else
                If Not dsRef Is Nothing Then
                    ''If Not dsRef.HasChanges Then Return False
                    'If Not Me.NeedSave Then Return True
                    Dim drSelect As DataRow() = dsRef.Tables("consultation").Select("serial_num='" & Me.strSerialNum & "'")
                    If drSelect.Length > 0 Then
                        setValue(drSelect(0))
                    Else
                        MsgBox("�������ݳ��ִ��󣬲��ܱ������ݣ�")
                        Return False
                    End If
                End If
            End If

            strReSult = VouchService.UpdateCorCon(dsRef.GetChanges())

            If strReSult = "1" Then ' �������ݿ�ɹ�

                '������ѯ��Ϣ��������б�
                If NewCorporation Then
                    '������ҵʱ,�����ܴ�������ͬ����ҵ,ͬ����ҵ����ͬһ��ҵ
                    'Dim strSql As String = "select top 1 * from corporation where corporation_type='1' order by corporation_code desc"
                    Dim strSql As String = "select top 1 * from corporation where corporation_type='1' and corporation_name='" & Me.txtCorporation_name.Text & "'"
                    Dim ds As DataSet = gWs.GetCommonQueryInfo(strSql)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If Not ds.Tables(0).Rows(0).Item("corporation_name") = Me.txtCorporation_name.Text Then
                            MsgBox("��������ʱ���ֳ�ͻ,���˳��ǼǶ�������ѯ��Ϣ�޸�!", MsgBoxStyle.OkOnly)
                            Return False
                        Else
                            Me.strCorporationCode = ds.Tables(0).Rows(0).Item("corporation_code")
                            Me.strCorporationName = ds.Tables(0).Rows(0).Item("corporation_name")
                        End If
                    End If
                    frm.btnQuery_Click(Nothing, Nothing) '��ȡ���й�˾��Ŀ
                End If

                NewCorporation = False
                bChanged = False

                If Me.NeedNewRecord Then '�����������һ����¼,���ȡ������¼��Serial_Num
                    Dim strSql As String = "select top 1 * from consultation where corporation_name='" & Me.txtCorporation_name.Text.Trim & "' and corporation_code='" & Me.strCorporationCode & "' order by serial_num desc"
                    Dim ds As DataSet = gWs.GetCommonQueryInfo(strSql)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Me.strSerialNum = ds.Tables(0).Rows(0).Item("serial_num")
                    End If
                    Me.NeedNewRecord = False
                    Me.btnMake.Enabled = True
                    Me.btnAccept.Enabled = True
                End If
                dsRef = VouchService.GetcorporationInfo("null", "{corporation_name='" & Me.txtCorporation_name.Text & "' and corporation_code='" & Me.strCorporationCode & "'}")
                Return True
            Else
                SWDialogBox.MessageBox.Show("*999", "", strReSult, "")
                Return False
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.ToString, ex.Message)
            'MsgBox("�������ԭ���ǣ�" + ex.Message, MsgBoxStyle.Critical, "��ѯ")
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not EmptyTestSuccess() Then Return 'ʹ����к�ɫ�Ĳ���Ϊ��

        If Me.Save() Then
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        End If
    End Sub
#Region "������Ҫ�����ж��Ƿ��������Ҫ��Ŀؼ�"
    Private Sub txtWebSite_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWebSite.Leave
        '
        '��ַ�Ļ�����ʽΪhttp://www.sina.com.cn �� http://192.168.0.60
        '
        Dim he As TextBox = CType(sender, TextBox)
        If he.Text = "" Then Return
        Dim testString As String = he.Text.ToUpper()

        If Not WebSiteValid(he.Text) Then
            'MsgBox("��λ��ַ�ĸ�ʽ����ȷ", MsgBoxStyle.OKOnly, "��ѯ")
            SWDialogBox.MessageBox.Show("$1002", "��λ��ַ")
            Me.txtWebSite.Focus()
        End If

        If testString.IndexOf("HTTP://") < 0 Then
            he.Text = "HTTP://" + he.Text
        End If
    End Sub

    Private Sub txtPhoneNumber_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
        '��ϵ�绰0755-12345678
        '
        If Not PhoneNumberValid(Me.txtPhoneNumber.Text) Then
            'MsgBox("�绰�����ʽ����ȷ��ʽ" + Chr(13) + Chr(10) + "Ӧ��������0755-12345678", MsgBoxStyle.OKOnly, "��ѯ")
            SWDialogBox.MessageBox.Show("$1002", "�绰����")
            Me.txtPhoneNumber.Focus()
        End If
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
        'Email
        '
        If Not EmailValid(Me.txtEmail.Text) Then
            'MsgBox("�Ƿ���Email��ʽ", MsgBoxStyle.OKOnly, "��ѯ")
            SWDialogBox.MessageBox.Show("$1002", "E-mail")
            Me.txtEmail.Focus()
        End If
    End Sub

    Private Sub txtMobile_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
        'Mobile
        '
        If Not MobileValid(Me.txtMobile.Text) Then
            'MsgBox("�ֻ��Ų���ȷ", MsgBoxStyle.OKOnly, "��ѯ")
            SWDialogBox.MessageBox.Show("$1003", "�ֻ�����")
            Me.txtMobile.Focus()
        End If
    End Sub

    Private Sub txtFax_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not FaxValid(Me.txtFax.Text) Then
            'MsgBox("��������ʽ����ȷ��ʽ" + Chr(13) + Chr(10) + "Ӧ��������0755-12345678", MsgBoxStyle.OKOnly, "��ѯ")
            SWDialogBox.MessageBox.Show("$1002", "�������")
            Me.txtFax.Focus()
        End If
    End Sub

    Private Sub txtcorpcreditlevel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcorpcreditlevel.Leave

    End Sub
#End Region
#Region "�������Ƿ�������븺�ŵ��ı���"
    Private Sub txtVouchSum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        MoneyKeyPress(sender, e, False)
    End Sub

    Private Sub txtAssets_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAssets.KeyPress
        MoneyKeyPress(sender, e, False)
    End Sub

    Private Sub txtCapital_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapital.KeyPress
        MoneyKeyPress(sender, e, False)
    End Sub

    Private Sub txtLySales_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLySales.KeyPress
        MoneyKeyPress(sender, e, False)
    End Sub

    Private Sub txtLyProfit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLyProfit.KeyPress
        MoneyKeyPress(sender, e, True)
    End Sub
    '����TextBox�������ּ��������
    'isInputMinus: True ,�������롰��������;False ,���������롰��������
    Private Sub MoneyKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal isInputMinus As Boolean)
        If isInputMinus Then
            If e.KeyChar = "." Or e.KeyChar = "-" Then
                If CType(sender, TextBox).Text = "" Then
                    If e.KeyChar = "-" Then
                        e.Handled = (CType(sender, TextBox).Text.IndexOf("-") = 0)
                    Else
                        e.Handled = True
                    End If
                Else
                    If e.KeyChar = "-" Then
                        If CType(sender, TextBox).Text.StartsWith("-") Then
                            e.Handled = True
                        ElseIf CType(sender, TextBox).Text.IndexOf("-") >= 0 Then
                            e.Handled = True
                        Else
                            e.Handled = False
                        End If
                    Else
                        e.Handled = (CType(sender, TextBox).Text.IndexOf(".") >= 0)
                    End If
                End If
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
            End If
        Else
            If e.KeyChar = "." Then
                If sender.GetType.IsInstanceOfType(Me.nuTerm) Then
                    e.Handled = True
                    Return
                End If
                If CType(sender, TextBox).Text = "" Then
                    e.Handled = True
                Else
                    e.Handled = (CType(sender, TextBox).Text.IndexOf(".") >= 0)
                End If
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
            End If
        End If
    End Sub
    Private Sub dtpFound_date_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFound_date.Leave
        Dim he As DateTimePicker = CType(sender, DateTimePicker)
        If he.Value.Date >= SysDate.Date Then
            'MsgBox("��ҵ�ĳ������ڲ���ȷ��" + Chr(13) + Chr(10) + "�������ڲ��ܴ��ڻ���ڵ�ǰʱ��", MsgBoxStyle.Critical, "��ѯ")
            SWDialogBox.MessageBox.Show("$1008", "��������", "��ǰʱ��")
            he.Focus()
        End If
    End Sub
#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
        'getConsultInfo(strCorporationCode)
    End Sub

    Private Sub frmRegisterCorporationInfo_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If NeedSave Then
            'Select Case MsgBox("�������޸ģ��Ƿ񱣴棿", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question, "��ѯ")
            Select Case SWDialogBox.MessageBox.Show("?1003")
                Case MsgBoxResult.Yes
                    If Not EmptyTestSuccess() Then  'ʹ����к�ɫ�Ĳ���Ϊ��
                        e.Cancel = True
                        Return
                    End If
                    Me.Save()
                    frm.queryCorporation()
                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select
        End If
        frm.dgCorpInfo_Click(Nothing, Nothing)
    End Sub

    '
    '�Ƽ�����
    '
    Private str_RecommendMethod As String = "Ա������"
    Private str_RecommendType As String = Nothing
    Private BankDT As DataTable = BankDS.Tables("bank").Copy()

    Private Sub SelectReommends(ByVal rcon As String)
        Dim rows() As DataRow = RecommendTypeDS.Tables("TRecommendType").Select("recommend_type='" + str_RecommendMethod + "'")
        Dim selActor As String = "01"
        If rows.Length > 0 Then
            selActor = rows(0).Item("type_code")
        End If
        Me.cbxRecommendType.SelectedValue = selActor
        Me.UpdateRecommends(selActor)
    End Sub

    Private Sub UpdateRecommends(ByVal rtype As String)
        Select Case rtype
            Case "01" '�Լ�
                Me.txtRecommendPerson.Visible = False
                Me.cbxRecommendItems.Visible = False

                str_RecommendType = Nothing
            Case "02" '��������
                Me.txtRecommendPerson.Visible = False
                Me.cbxRecommendItems.Visible = True

                'Me.cbxRecommendItems.DataSource = BankDT
                If dsBank Is Nothing Then
                    'dsBank = gWs.GetBankInfo("{bank_name like '%' order by bank_name}", "{branch_bank_name like '%' order by branch_bank_name}")
                    'qxd modify 2005-10-21 ͨ���洢ʵ���˰�������������
                    dsBank = gWs.GetBankInfo("%", "%")
                End If
                Dim dsBankCopy As DataSet = dsBank.Copy() 'ʹ�������Դ�������������е�����Դ�ֿ�
                Me.cbxRecommendItems.DataSource = dsBankCopy.Tables("bank")
                Me.cbxRecommendItems.DisplayMember = "bank_name"
                Me.cbxRecommendItems.ValueMember = "bank_name"

            Case "03"
                Me.txtRecommendPerson.Visible = False
                Me.cbxRecommendItems.Visible = False

            Case "04"
                Me.txtRecommendPerson.Visible = False
                Me.cbxRecommendItems.Visible = False

            Case "05"
                Me.txtRecommendPerson.Visible = False
                Me.cbxRecommendItems.Visible = False

                'Case "03" '����Ա��
                '    Me.txtRecommendPerson.Visible = False
                '    Me.cbxRecommendItems.Visible = True

                '    Me.cbxRecommendItems.DataSource = StaffDS.Tables("TStaff")
                '    Me.cbxRecommendItems.DisplayMember = "staff_name"
                '    Me.cbxRecommendItems.ValueMember = "staff_name"
                'Case "04" '��������
                '    Me.txtRecommendPerson.Visible = False
                '    Me.cbxRecommendItems.Visible = True

                '    Me.cbxRecommendItems.DataSource = CooperatorInfoDS.Tables("cooperate_organization")
                '    Me.cbxRecommendItems.DisplayMember = "cooperate_organization"
                '    Me.cbxRecommendItems.ValueMember = "cooperate_organization"
                'Case Else '������������ҵ
                '    Me.txtRecommendPerson.Visible = True
                '    Me.cbxRecommendItems.Visible = False
                '    Me.txtRecommendPerson.Text = ""
        End Select
    End Sub

    '
    '�Ƽ���λ�����
    'qxd modify 2003-12-2
#Region "���������ı��ı�ʱ��ʹischangedΪtrue"
    Private Sub txtRecommendPerson_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If int_PageIndex = 0 Then
        If int_PageIndex = 1 Then
            str_RecommendType = CType(sender, TextBox).Text
            bChanged = True
        End If
    End Sub

    Private Sub cbxRecommendItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        'If int_PageIndex = 0 Then
        If int_PageIndex = 1 Then
            Dim he As ComboBox = CType(sender, ComboBox)
            str_RecommendType = he.Text
            bChanged = True
        End If
    End Sub
    Private Sub cbxRecommendType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If int_PageIndex = 0 Then
        If int_PageIndex = 1 Then
            Dim he As ComboBox = CType(sender, ComboBox)
            UpdateRecommends(he.SelectedValue)
            bChanged = True
        End If
    End Sub

    Private Sub FirstLoanStateChanged(ByVal sender As Object, ByVal e As EventArgs)
        bChanged = True
    End Sub

    Private Sub The_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        If int_PageIndex = 0 Then bChanged = True
    End Sub

    Private Sub cbxAddressRangeParent_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.cbxAddressRange.DataSource = VouchService.GetCommonQueryInfo("select * from district where district_parent_name='" & cbxAddressRangeParent.SelectedValue & "' order by district_code").Tables(0)
        'Me.cbxAddressRange.DataSource = DistrictDS.Tables("TDistrict").Select("district_parent_name='" & cbxAddressRangeParent.SelectedValue & "'")
        Me.cbxAddressRange.DisplayMember = "district_name"
        Me.cbxAddressRange.ValueMember = "district_name"
    End Sub

    Private Sub The_TextChanged2(ByVal sender As Object, ByVal e As EventArgs)
        If int_PageIndex = 1 Then bChanged = True
    End Sub
    '�л�pageҳ
    Private int_PageIndex As Integer = 0
    Private Sub TabControl1_TabIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        int_PageIndex = CType(sender, TabControl).SelectedIndex
        If int_PageIndex = 0 Then
            Me.KeyPreview = True 'qxd add 03/7/28
            RemoveHandler clbTechnology.ItemCheck, AddressOf clbTechType_ItemCheck
            RemoveHandler clbCorporationTypeEx.ItemCheck, AddressOf clbCorporationTypeEx_ItemCheck
            'InitTechType()
            'Me.SetCorporationTypeEx(_corporationTypeEx)
            AddHandler clbTechnology.ItemCheck, AddressOf clbTechType_ItemCheck
            AddHandler clbCorporationTypeEx.ItemCheck, AddressOf clbCorporationTypeEx_ItemCheck

        Else 'qxd add 03/7/28
            Me.KeyPreview = False
        End If

        Me.TabPage1.Controls.Remove(Me.clbCorporationTypeEx)
        Me.TabPage1.Controls.Add(Me.clbCorporationTypeEx)
        Me.TabPage1.Controls.Remove(Me.clbTechnology)
        Me.TabPage1.Controls.Add(Me.clbTechnology)
    End Sub
#End Region

    '����
    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click

        If Not EmptyTestSuccess() Then Return

        If NeedSave Then
            If Not Me.Save() Then
                Exit Sub
            End If
        End If

        If dsRef Is Nothing Then
            'MsgBox("��ѯ��Ϣ�����ڣ����ȱ�����ѯ��Ϣ!", MsgBoxStyle.Critical, "��ѯ")
            SWDialogBox.MessageBox.Show("$1005", "��ѯ��Ϣ")
            Return
        End If

        Try
            Dim ccode As String
            Dim pcode As String
            Dim corpName As String = Me.txtCorporation_name.Text

            'modify by xie 2004-5-12
            '��������ҵ��ʱ��,�����ҵ�����Ѿ�����,������Ѵ��ڵ���ҵ��������һ����ѯ��Ϣ,����������һ����ҵ��Ϣ������һ����ѯ��Ϣ
            'ÿ����ҵ�������޸ĺ�,coporation���е��������������޸ĵ�����,����ѯ��������ÿ�ε���ѯ���������
            'Dim dt As DataTable = VouchService.GetcorporationInfo("null", "{corporation_name='" + corpName + "'}").Tables("consult")
            Dim dt As DataTable = VouchService.GetcorporationInfo("{corporation_name='" + corpName + "'}", "null").Tables("corporation")

            If dt.Rows.Count = 0 Then
                'MsgBox("��ҵ��Ϣ�����ڣ����ȱ�����ѯ��Ϣ!", MsgBoxStyle.Critical, "��ѯ")
                SWDialogBox.MessageBox.Show("$1005", "��ҵ��Ϣ")
                Return
            End If

            ccode = dt.Rows(0).Item("corporation_code")
            strCorporationCode = ccode

            '�����δ�ύ����Ŀ,���ȡ����Ŀ�����������;
            '�����ȡ�µ���Ŀ����
            Me.isNoCommited = isNoCommitedProject(ccode)
            If isNoCommited Then
                pcode = Me.strProjectCode
            Else
                pcode = gWs.GetProjectCode(ccode)
            End If

            Dim aq As New frmAcceptRequest(Me, strCorporationCode, strSerialNum)
            aq.setProjectCode(pcode)
            aq.setCorporationCode(ccode)
            aq.setCorporationName(corpName)
            aq.setUser(UserName)
            aq.setIsNewPorjectCode(Not isNoCommited) '�Ƿ�ʹ�õ��µ���Ŀ����

            AddHandler aq.refreshTaskCommit, AddressOf AcceptSuc

            aq.AllowTransparency = False
            aq.ShowDialog()

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub frmRegisterCorporationInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr("13") Then
            If Not Me.ActiveControl.GetType() Is GetType(System.Windows.Forms.RichTextBox) Then
                CType(sender, Form).SelectNextControl(Me.ActiveControl, True, True, True, True)
            End If
        End If
    End Sub

    '
    '����int_TechTypes��ֵ��ȷ��ѡ���ļ�������
    'ѡ������
    '

    '��ʼ���Ƽ�����
    Private Sub InitTechType()
        Me.clbTechnology.ClearSelected()
        Dim i As Integer
        Dim choose As Integer
        For i = 0 To Me.clbTechnology.Items.Count - 1
            'ѡ������
            choose = CType(CType(Me.clbTechnology.Items(i), DataRowView).Item("technology_type_code"), Integer)
            'ȷ��ѡ������
            If int_TechTypes And choose Then
                Me.clbTechnology.SetItemCheckState(i, CheckState.Checked)
            End If
        Next
    End Sub

    '2009-09-10 yjf add ��ʼ����ҵ�������� ,����corporationTypeEx��ֵȷ����ҵ��������
    Private Sub SetCorporationTypeEx(ByVal CorporationTypeEx As String)
        Me.clbCorporationTypeEx.Items.Clear()
        Dim dsCorporationTypeExSelection As DataSet = gWs.GetCommonQueryInfo("select * from TSelection where selection_id='corporation_type_ex'")
        Dim strCorporationTypeExSelection As String = dsCorporationTypeExSelection.Tables(0).Rows(0).Item("selection_value")
        Dim listCorporationTypeExSelection As New ArrayList
        listCorporationTypeExSelection.AddRange(strCorporationTypeExSelection.Split(","))
        Dim listCorporationTypeEx As New ArrayList
        listCorporationTypeEx.AddRange(CorporationTypeEx.Split(","))
        Dim i As Integer
        For i = 0 To listCorporationTypeExSelection.Count - 1
            clbCorporationTypeEx.Items.Add(listCorporationTypeExSelection.Item(i))
        Next

        For i = 0 To clbCorporationTypeEx.Items.Count - 1
            If listCorporationTypeEx.Contains(clbCorporationTypeEx.Items(i)) Then
                clbCorporationTypeEx.SetItemChecked(i, True)
            Else
                clbCorporationTypeEx.SetItemChecked(i, False)
            End If
        Next
    End Sub

    Private Function GetCorporationTypeEx() As String
        Dim strCorporationTypeEx As String
        Dim i As Integer
        For i = 0 To clbCorporationTypeEx.CheckedItems.Count - 1
            If i = clbCorporationTypeEx.CheckedItems.Count - 1 Then
                strCorporationTypeEx = strCorporationTypeEx & clbCorporationTypeEx.CheckedItems(i)
            Else
                strCorporationTypeEx = strCorporationTypeEx & clbCorporationTypeEx.CheckedItems(i) & ","
            End If

        Next
        Return strCorporationTypeEx
    End Function


    'ItemCheck
    Private Sub clbTechType_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        If int_PageIndex = 0 Then
            Dim val As Integer = CType(CType(Me.clbTechnology.Items(e.Index), DataRowView).Item("technology_type_code"), Integer)  '��ǰѡ�����ֵ
            If e.NewValue Then
                int_TechTypes = (int_TechTypes Or val)
            Else
                int_TechTypes = (int_TechTypes And Not val)
            End If
            bChanged = True
        End If
    End Sub
    '������ҵ���룬�ж��Ƿ���δ�ύ����Ŀ��Ϣ����,���������Ŀ����
    Private Function isNoCommitedProject(ByVal corporationCode As String) As Boolean
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String
        Dim i As Integer
        Try
            strSql = "{corporation_code='" & corporationCode & " '}"
            ds = gWs.GetProjectInfo(strSql)
            i = ds.Tables("project").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dr = ds.Tables("project").Rows(i)
                    With dr
                        If (.Item("phase") Is System.DBNull.Value) And (.Item("status") Is System.DBNull.Value) Then
                            Me.strProjectCode = .Item("project_code")
                            Return True
                            Exit Function
                        End If
                    End With
                Next
            End If
        Catch
        Finally
        End Try
        Return False
    End Function
    '�����ѯ��Ϣ
    Private Function getConsultInfo(ByVal corpCode As String)
        If corpCode = "" Then
            corpCode = "0"
        End If
        Dim dsConsultA As DataSet
        Dim strWhere As String = "corporation_code=" & corpCode
        Dim dsConsult As DataSet = VouchService.GetcorporationInfo("", "{" + strWhere + "}")
        dsConsultA = dsConsult.Copy()

        If dsConsultA.Tables("consultation").Rows.Count <= 0 Then Return Nothing

        If dsConsult.Tables("consultation").Rows.Count > 0 Then
            dsConsultA.Merge(BankDS.Tables("bank"))
            dsConsultA.Relations.Add("RBank", dsConsultA.Tables("bank").Columns("bank_code"), dsConsultA.Tables("consultation").Columns("apply_bank_code"))
            dsConsultA.Tables("consultation").Columns.Add("CAppyBank", GetType(String), "Parent(RBank).bank_name")
        End If
        Dim dv As New DataView(dsConsultA.Tables("consultation"))
        dv.AllowNew = False
        dv.AllowEdit = False
        frm.dgConsultationInfo.DataSource = dv

    End Function
    '�������޵����ֵ����Сֵ
    Private Sub nuTerm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strTerm As String
        Dim dTerm As Double
        strTerm = Me.nuTerm.Text
        Try
            If Not strTerm = "" Then
                If IsNumeric(strTerm) Then
                    dTerm = CType(strTerm, Double)
                    If dTerm > 36 Then
                        Me.nuTerm.Text = "36"
                    ElseIf (dTerm < 0) Then
                        Me.nuTerm.Text = "0"
                    End If
                Else
                    Me.nuTerm.Text = "12"
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub cmbConsultPerson_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            Me.clbTechnology.Focus()
        End If
    End Sub

    Private Sub nuTerm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        MoneyKeyPress(sender, e, False)
    End Sub

    '�󶨱���Ʒ��
    Private Sub bindingGuaranteeLetterType()
        Dim ds As DataSet
        Try
            Me.cmbGuaranteeLetterType.DataSource = Nothing
            ds = gWs.GetGuaranteeLetterType("%")
            Me.cmbGuaranteeLetterType.DataSource = ds.Tables(0)
            Me.cmbGuaranteeLetterType.DisplayMember = "name"
            Me.cmbGuaranteeLetterType.ValueMember = "type_code"
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�󶨳�����������
    Private Sub bindingReimburseType()
        Dim ds As DataSet
        Try
            Me.cmbReimburseType.DataSource = Nothing
            ds = gWs.GetReimburseType("%")
            Me.cmbReimburseType.DataSource = ds.Tables(0)
            Me.cmbReimburseType.DisplayMember = "name"
            Me.cmbReimburseType.ValueMember = "type_code"
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    'ѡ��ҵ��Ʒ�ֵ�ʱ���ж��Ƿ��Ǳ���,�����в�ͬ������
    Private Sub cbxServiceType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim strService As String
        strService = Me.cbxServiceType.Text
        Select Case strService
            Case "����"
                Me.txtGuaranteeLetter(True)
                Me.txtReGuarantee(False)
            Case "�ٵ���"
                Me.txtGuaranteeLetter(False)
                Me.txtReGuarantee(True)
            Case Else
                Me.txtGuaranteeLetter(False)
                Me.txtReGuarantee(False)
        End Select
    End Sub

    Private Sub AcceptSuc()
        RaiseEvent evtAccept()
        Me.Close()
    End Sub

    '������Ϣ�ɼ���
    Private Sub btnMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMake.Click
        Dim dsFileTemplate As DataSet
        Dim strSql As String
        Dim i As Int16
        strSql = "{item_type='45' and item_code ='016' and is_current_ver='1' order by version DESC}"
        Try
            dsFileTemplate = gWs.GetFileTemplateByCondition(strSql)
            i = dsFileTemplate.Tables("TFileTemplate").Rows.Count
            If i = 0 OrElse IsDBNull(dsFileTemplate.Tables("TFileTemplate").Rows(0)("template")) Then
                MessageBox.Show("�ļ�ģ�岻����,����������ҵ��Ϣ�ɼ���!", "ϵͳ��ʾ", MessageBoxButtons.OK)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim dr As DataRow = dsFileTemplate.Tables("TFileTemplate").Rows(0)
            Dim data As Byte() = dr.Item("template")
            Dim docType As String = dr.Item("doc_type").trim
            Dim myFileStream As System.IO.FileStream
            Dim strDocumentPath As String = Application.StartupPath + "\Document"
            If Not System.IO.Directory.Exists(strDocumentPath) Then
                System.IO.Directory.CreateDirectory(strDocumentPath)
            End If
            Dim strPath As String = strDocumentPath + "\" & getLegalFileName(Me.txtCorporation_name.Text.Trim) & "." & docType
            Dim isThread As Boolean = False

            '�ж��ļ��Ƿ����,���������ɾ��;���ɾ������,˵���ļ��Ѿ�����һ����ռ����.�򲻴����µ��ļ�
            If System.IO.File.Exists(strPath) Then
                Try
                    System.IO.File.Delete(strPath)
                Catch
                    isThread = True
                End Try
            End If
            If Not isThread Then
                'myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                myFileStream = New System.IO.FileStream(strPath, IO.FileMode.Create)
                myFileStream.Write(data, 0, data.Length)
                myFileStream.Close()
            End If

            Dim office As Office = New Office
            Dim dtOffice As DataTable = office.CreateOfficeTable()

            Dim keys() As String
            Dim value As New ArrayList

            office.ReplaceFlag(dtOffice, "&#CorporationName", Me.txtCorporation_name.Text)
            office.ReplaceFlag(dtOffice, "&#FoundDate", Me.dtpFound_date.Value.ToString("yyyy��MM��"))
            office.ReplaceFlag(dtOffice, "&#st", Me.cbxProprietorShip.Text)
            office.ReplaceFlag(dtOffice, "&#ht", Me.cbxIndustryType.Text)
            office.ReplaceFlag(dtOffice, "&#Address", Me.cbxAddressRange.Text & Me.txtAddressDetail.Text)
            office.ReplaceFlag(dtOffice, "&#ContactPerson1", Me.txtContactPerson.Text)
            office.ReplaceFlag(dtOffice, "&#Job1", Me.txtJob.Text)
            office.ReplaceFlag(dtOffice, "&#PhoneNUm", Me.txtPhoneNumber.Text)
            office.ReplaceFlag(dtOffice, "&#Mobile", Me.txtMobile.Text)
            office.ReplaceFlag(dtOffice, "&#Fax", Me.txtFax.Text)
            office.ReplaceFlag(dtOffice, "&#Email", Me.txtEmail.Text)
            office.ReplaceFlag(dtOffice, "&#WebSite", Me.txtWebSite.Text)
            office.ReplaceFlag(dtOffice, "&#Sum", Me.txtVouchSum.Text)
            office.ReplaceFlag(dtOffice, "&#Term", Me.nuTerm.Text)
            office.ReplaceFlag(dtOffice, "&#CorporationDesc", Me.txtCorpDesc.Text)
            office.ReplaceFlag(dtOffice, "&#ProjectDesc", Me.txtProjDesc.Text)
            office.ReplaceFlag(dtOffice, "&#ConsultPerson", Me.cmbConsultPerson.Text)
            office.ReplaceFlag(dtOffice, "&#Date", Me.dtpConsultDate.Value.ToString("yyyy-MM-dd"))

            office.GetFlagAndValueArray(dtOffice, keys, value)


            If keys Is Nothing Or value Is Nothing Or value.Count <= 0 Or Not keys.Length = value.Count Or Not docType = "doc" Then
                'MessageBox.Show("�����ĵ����ִ���,����������ҵ��Ϣ�ɼ���!", "ϵͳ��ʾ", MessageBoxButtons.OK)
                MyMsgBox("�����ĵ����ִ���,����������ҵ��Ϣ�ɼ���!")
                Exit Sub
            End If

            Dim word1 = New Word.ApplicationClass
            word1.Application.Documents.Add(strPath)

            For i = 0 To value.Count - 1
                replaceText(word1, keys(i), value(i)) '�滻������
            Next
            word1.Caption = getLegalFileName(strCorporationName) & docType
            'qxd end 
            word1.Application.Visible = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    '
    '�滻�ĵ��еĵ�ָ���ַ�
    '
    Private Sub replaceText(ByVal word1 As Word.ApplicationClass, ByVal strFlag As String, ByVal strReplace As String)
        Dim docActive As Word.DocumentClass
        Dim content As Word.Range
        Dim fd As Word.Find

        docActive = word1.ActiveDocument
        content = docActive.Content
        fd = content.Find

        fd.Format = True
        'fd.MatchCase = false '�����ִ�Сд
        fd.MatchCase = True '���ִ�Сд
        fd.ClearFormatting() '�����ʽ
        fd.MatchWholeWord = True '���������ĵ���
        fd.MatchWildcards = False '�����Ұ���ͨ���
        fd.Wrap = Word.WdFindWrap.wdFindContinue '������ĩ�󣬴�ͷ��������
        'fd.Replacement.ClearFormatting() '����滻��ĸ�ʽ
        fd.Replacement.Style = Word.WdReplace.wdReplaceAll '�滻����

        Try
            'fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strReplace)
            fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strReplace, Word.WdReplace.wdReplaceAll, Nothing, Nothing, Nothing, Nothing)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        fd = Nothing
        content = Nothing
        docActive = Nothing
    End Sub

    '****��ѯ��ҵ��Ϣ�ɼ��� start
    Private Function getCorpConsultInfoFlag() As String()
        Dim flag As String() = {"&#CorporationName", "&#FoundDate", "&#st", "&#ht", "&#ContactPerson1", "&#Job1", _
                        "&#ContactPerson2", "&#job2", "&#Address", "&#PhoneNUm", "&#Mobile", "&#Fax", "&#Email", "&#WebSite", _
                        "&#Sum", "&#Term", "&#CorporationDesc", "&#ProjectDesc", "&#ConsultPerson", "&#Date"}
        Return flag
    End Function
    Private Function replaceCorpConsultInfoFlag()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim dsConsult As DataSet
        Dim dr As DataRow
        Dim i As Int16
        Try
            strSql = "select top 1 * from consultation where corporation_code='" & strCorporationCode & "' and serial_num='" & Me.strSerialNum & "'"
            dsConsult = gWs.GetCommonQueryInfo(strSql)
            i = dsConsult.Tables(0).Rows.Count
            If i > 0 Then
                dr = dsConsult.Tables(0).Rows(0)
                With replaceList
                    .Add(dr.Item("corporation_name").ToString)
                    .Add(Format(dr.Item("found_date"), "yyyy-MM"))
                    .Add(dr.Item("proprietorship_type").ToString)
                    .Add(dr.Item("industry_type").ToString)
                    .Add(dr.Item("contact_person").ToString)
                    .Add(dr.Item("job").ToString)
                    .Add("")
                    .Add("")
                    .Add(dr.Item("district_name").ToString & dr.Item("register_address").ToString)
                    .Add(dr.Item("phone_num").ToString)
                    .Add(dr.Item("mobile").ToString)
                    .Add(dr.Item("fax").ToString)
                    .Add(dr.Item("e_mail").ToString)
                    .Add(dr.Item("web_site").ToString)
                    .Add(dr.Item("apply_guarantee_sum").ToString() & "(��Ԫ)")
                    .Add(dr.Item("apply_term").ToString() & "(��)")
                    .Add(dr.Item("corporation_description").ToString)
                    .Add(dr.Item("product_description").ToString)
                    .Add(dr.Item("consult_person").ToString)
                    .Add(Format(dr.Item("consult_date"), "yyyy-MM-dd"))
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return replaceList
    End Function
    '**** ��ѯ��Ϣ�ɼ��� end
    Private Sub setValue(ByVal dr As DataRow)
        With dr
            '��ҵ����,���˿ո��ַ�
            .Item("corporation_name") = Me.txtCorporation_name.Text.Trim()
            '
            '��Ʒ����ҵ
            '
            .Item("corporation_type") = "1"
            .Item("industry_type") = Me.cbxIndustryType.SelectedValue
            .Item("proprietorship_type") = Me.cbxProprietorShip.SelectedValue
            .Item("corporation_description") = Me.txtCorpDesc.Text
            .Item("product_description") = Me.txtProjDesc.Text
            .Item("web_site") = Me.txtWebSite.Text
            .Item("credit_grade") = Me.txtcorpcreditlevel.Text
            .Item("found_date") = Me.dtpFound_date.Value
            .Item("if_import") = Me.cbxImport.SelectedItem              'yansm add 2013/11/29
            .Item("if_technology") = Me.cbxHightec.SelectedItem         'yansm add 2013/11/29
            .Item("indus_type") = Me.cbxIndus.SelectedItem()            'yansm add 2013/11/29




            '
            '�Ƽ���Ϣ
            '
            .Item("recommend_type") = Me.cbxRecommendType.Text
            If Not str_RecommendType Is Nothing Then
                .Item("recommend_person") = str_RecommendType
            Else
                .Item("recommend_person") = ""
            End If

            '�Ƽ�����
            .Item("recommend_bank") = Me.cbxRecommendItems.Text
            '
            '������Ϣ
            '
            .Item("is_first_loan") = Me.cbFirstLoan.Checked
            .Item("apply_guarantee_sum") = Currency2Numeric(Me.txtVouchSum.Text)
            .Item("apply_term") = Me.nuTerm.Text
            .Item("apply_bank_code") = Me.cbxBankCode.SelectedValue
            .Item("apply_service_type") = Me.cbxServiceType.SelectedValue


            '�ʽ���Ϣ

            .Item("register_capital") = Currency2Numeric(Me.txtCapital.Text)
            .Item("total_assets") = Currency2Numeric(Me.txtAssets.Text)
            .Item("lastyear_sales_income") = Currency2Numeric(Me.txtLySales.Text)
            .Item("lastyear_total_profit") = Currency2Numeric(Me.txtLyProfit.Text)

            '��ַ��Ϣ
            '
            .Item("district_name") = Me.cbxAddressRange.SelectedValue
            .Item("district_parent_name") = Me.cbxAddressRangeParent.SelectedValue
            .Item("register_address") = Me.txtAddressDetail.Text

            '��ϵ����Ϣ
            '
            .Item("contact_person") = Me.txtContactPerson.Text
            .Item("job") = Me.txtJob.Text
            .Item("phone_num") = Me.txtPhoneNumber.Text
            .Item("mobile") = Me.txtMobile.Text
            .Item("fax") = Me.txtFax.Text
            .Item("e_mail") = Me.txtEmail.Text
            '
            '��������ѯ��Ϣ
            '
            If NeedNewRecord Then
                .Item("create_person") = UserName
                .Item("branch_name") = getStaffTeamName(UserName)
                .Item("create_date") = SysDate
            End If
            '.Item("consult_person") = UserName
            .Item("consult_date") = dtpConsultDate.Value
            .Item("consult_person") = Me.cmbConsultPerson.Text
            .Item("corporation_type_ex") = Me.GetCorporationTypeEx() '2009-09-10 yjf add
            .Item("technology_type") = Me.int_TechTypes
            'qxd add 2003-12-2
            .Item("apply_branch_code") = Me.cmbBankBranch.SelectedValue
            .Item("guarantee_letter_type") = Me.cmbGuaranteeLetterType.SelectedValue
            .Item("reimburse_type") = Me.cmbReimburseType.SelectedValue
            .Item("beneficiary") = Me.txtBeneficiary.Text
            .Item("purpose") = Me.txtPurpose.Text
            '�ٵ�����Ϣ
            .Item("organno") = Me.cmbOrgName.SelectedValue
            .Item("organization_opinion") = Me.txtOrgOpinion.Text
            .Item("source_service_type") = Me.cmbSserviceType.SelectedValue
            .Item("source_guarantee_sum") = Currency2Numeric(Me.txtLoanSum.Text)
            '.Item("source_guarantee_term") = Me.nudLoanTerm.Text
        End With
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    '�Ƿ�ѡ�񱣺�
    Private Sub txtGuaranteeLetter(ByVal isUse As Boolean)
        If isUse Then
            Me.cmbGuaranteeLetterType.Enabled = True
            Me.cmbReimburseType.Enabled = True
            Me.txtBeneficiary.Enabled = True
        Else
            Me.cmbGuaranteeLetterType.Enabled = False
            Me.cmbReimburseType.Enabled = False
            Me.txtBeneficiary.Enabled = False
            Me.cmbGuaranteeLetterType.SelectedIndex = -1
            Me.cmbGuaranteeLetterType.SelectedItem = Nothing
            Me.cmbReimburseType.SelectedIndex = -1
            Me.cmbReimburseType.SelectedItem = Nothing
            Me.txtBeneficiary.Text = ""
        End If
    End Sub

    '�Ƿ�ѡ���ٵ���
    Private Sub txtReGuarantee(ByVal isUse As Boolean)
        If isUse Then
            Me.cmbOrgName.Enabled = True
            Me.txtOrgOpinion.Enabled = True
            Me.cmbSserviceType.Enabled = True
            Me.txtLoanSum.Enabled = True
            Me.nudLoanTerm.Enabled = True
        Else
            Me.cmbOrgName.Enabled = False
            Me.txtOrgOpinion.Enabled = False
            Me.cmbSserviceType.Enabled = False
            Me.txtLoanSum.Enabled = False
            Me.nudLoanTerm.Enabled = False
            Me.cmbOrgName.SelectedIndex = -1
            Me.cmbOrgName.SelectedItem = Nothing
            Me.txtOrgOpinion.Text = ""
            Me.cmbSserviceType.SelectedIndex = -1
            Me.cmbSserviceType.SelectedItem = Nothing
            Me.txtLoanSum.Text = ""
            'Me.nudLoanTerm.Text = ""
        End If
    End Sub

    Private Sub clbCorporationTypeEx_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        bChanged = True
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxHightec.SelectedIndexChanged

    End Sub
End Class

