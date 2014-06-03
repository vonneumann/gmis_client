Public Class frmCoMBase
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
    Friend WithEvents dgtsProject As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgtbcProjectServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtbcProjectBank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtbcProjectBranch As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtbcProjectApplySum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtbcProjectTerm As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtbcProjectPurpose As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtbcProjectLoanSum As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents grpRequest As System.Windows.Forms.GroupBox
    Friend WithEvents dgtbcProjectCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtbcApplyDate As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents cboMoneyType As System.Windows.Forms.ComboBox
    Protected WithEvents lblMoneyType As System.Windows.Forms.Label
    Protected WithEvents pgCorpInfo As System.Windows.Forms.TabPage
    Protected WithEvents grpProjectBody As System.Windows.Forms.GroupBox
    Protected WithEvents lblCorpPropriateShip As System.Windows.Forms.Label
    Protected WithEvents tabCoMBase As System.Windows.Forms.TabControl
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents txtPhase As System.Windows.Forms.TextBox
    Protected WithEvents lblCorporationName As System.Windows.Forms.Label
    Protected WithEvents lblProjectPhase As System.Windows.Forms.Label
    Protected WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents grpProjectHeader As System.Windows.Forms.GroupBox
    Protected WithEvents lblCorpBusinessCode As System.Windows.Forms.Label
    Protected WithEvents lblCorpBusinessStartDate As System.Windows.Forms.Label
    Protected WithEvents lblCorpBusinessEndDate As System.Windows.Forms.Label
    Protected WithEvents lblCorpPaperID As System.Windows.Forms.Label
    Protected WithEvents lblCorpRegisterAddress As System.Windows.Forms.Label
    Protected WithEvents lblCorpCardID As System.Windows.Forms.Label
    Protected WithEvents lblCorpIndustryType As System.Windows.Forms.Label
    Protected WithEvents lblCorpTechType As System.Windows.Forms.Label
    Protected WithEvents lblCorpCreditLevel As System.Windows.Forms.Label
    Protected WithEvents lblCorpEvalInstitute As System.Windows.Forms.Label
    Protected WithEvents lblCorpRegisterAsset As System.Windows.Forms.Label
    Protected WithEvents lblCorpRealAsset As System.Windows.Forms.Label
    Protected WithEvents lblCorpCashArrived As System.Windows.Forms.Label
    Protected WithEvents lblCorpInvisibleAsset As System.Windows.Forms.Label
    Protected WithEvents lblCorpRepreCardID As System.Windows.Forms.Label
    Protected WithEvents lblCorpContactNumber As System.Windows.Forms.Label
    Protected WithEvents lblCorpContactor As System.Windows.Forms.Label
    Protected WithEvents lblCorpRepre As System.Windows.Forms.Label
    Protected WithEvents lblCorpRepreID As System.Windows.Forms.Label
    Protected WithEvents lblCorpRepreNation As System.Windows.Forms.Label
    Protected WithEvents txtEvalInstitute As System.Windows.Forms.TextBox
    Protected WithEvents txtCreditLevel As System.Windows.Forms.TextBox
    Protected WithEvents txtRegCapital As System.Windows.Forms.TextBox
    Protected WithEvents txtInvisibleAssets As System.Windows.Forms.TextBox
    Protected WithEvents txtRealCapital As System.Windows.Forms.TextBox
    Protected WithEvents txtRepresentative As System.Windows.Forms.TextBox
    Protected WithEvents txtRepreID As System.Windows.Forms.TextBox
    Protected WithEvents txtRepreNation As System.Windows.Forms.TextBox
    Protected WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Protected WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Protected WithEvents txtLoanCardID As System.Windows.Forms.TextBox
    Protected WithEvents txtRepID As System.Windows.Forms.TextBox
    Protected WithEvents txtLoanID As System.Windows.Forms.TextBox
    Protected WithEvents txtAddressDetail As System.Windows.Forms.TextBox
    Protected WithEvents clbTechType As System.Windows.Forms.CheckedListBox
    Protected WithEvents cboAddressRange As System.Windows.Forms.ComboBox
    Protected WithEvents cboProprietorShip As System.Windows.Forms.ComboBox
    Protected WithEvents cboIndustryType As System.Windows.Forms.ComboBox
    Protected WithEvents txtCashReceive As System.Windows.Forms.TextBox
    Protected WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtCorpID As System.Windows.Forms.TextBox
    Protected WithEvents dtpFoundDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents lblFoundDate As System.Windows.Forms.Label
    Protected WithEvents txtFax As System.Windows.Forms.TextBox
    Protected WithEvents lblContactorFax As System.Windows.Forms.Label
    Protected WithEvents txtContactEmail As System.Windows.Forms.TextBox
    Protected WithEvents txtContactMobile As System.Windows.Forms.TextBox
    Protected WithEvents Label10 As System.Windows.Forms.Label
    Protected WithEvents Label11 As System.Windows.Forms.Label
    Protected WithEvents txtLegelMobile As System.Windows.Forms.TextBox
    Protected WithEvents Label13 As System.Windows.Forms.Label
    Protected WithEvents txtLegelPhone As System.Windows.Forms.TextBox
    Protected WithEvents Label16 As System.Windows.Forms.Label
    Protected WithEvents groupbox As System.Windows.Forms.GroupBox
    Protected WithEvents chkIsFirstLoan As System.Windows.Forms.CheckBox
    Protected WithEvents dgProject As System.Windows.Forms.DataGrid
    Protected WithEvents cboRecommendItems As System.Windows.Forms.ComboBox
    Protected WithEvents grpProjectPassed As System.Windows.Forms.GroupBox
    Protected WithEvents pgProject As System.Windows.Forms.TabPage
    Protected WithEvents lblAttachMember As System.Windows.Forms.Label
    Protected WithEvents lblAttachColledge As System.Windows.Forms.Label
    Protected WithEvents lblAttachBancholer As System.Windows.Forms.Label
    Protected WithEvents lblAttachMaster As System.Windows.Forms.Label
    Protected WithEvents lblAttachDoctor As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestBank As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestSum As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestDate As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestTerm As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestBranch As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestServiceType As System.Windows.Forms.Label
    Protected WithEvents lblProjectRecommendSum As System.Windows.Forms.Label
    Protected WithEvents lblProjectRecommendDate As System.Windows.Forms.Label
    Protected WithEvents lblProjectCooperateOpinion As System.Windows.Forms.Label
    Protected WithEvents txtCooperateOpinion As System.Windows.Forms.RichTextBox
    Protected WithEvents dtpRecommend As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtRecommendSum As System.Windows.Forms.TextBox
    Protected WithEvents dtpApplyDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents nuTerm As System.Windows.Forms.NumericUpDown
    Protected WithEvents cboApplyServiceType As System.Windows.Forms.ComboBox
    Protected WithEvents cboApplyBranch As System.Windows.Forms.ComboBox
    Protected WithEvents cboApplyBank As System.Windows.Forms.ComboBox
    Protected WithEvents txtApplySum As System.Windows.Forms.TextBox
    Protected WithEvents Label7 As System.Windows.Forms.Label
    Protected WithEvents txtPurpose As System.Windows.Forms.RichTextBox
    Protected WithEvents Label14 As System.Windows.Forms.Label
    Protected WithEvents cboRecommendType As System.Windows.Forms.ComboBox
    Protected WithEvents txtRecommendPerson As System.Windows.Forms.TextBox
    Protected WithEvents txtColledgeNum As System.Windows.Forms.TextBox
    Protected WithEvents txtBachelorNum As System.Windows.Forms.TextBox
    Protected WithEvents txtMasterNum As System.Windows.Forms.TextBox
    Protected WithEvents txtDoctorNum As System.Windows.Forms.TextBox
    Protected WithEvents txtEmployeeAmount As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCoMBase))
        Me.grpProjectHeader = New System.Windows.Forms.GroupBox
        Me.txtPhase = New System.Windows.Forms.TextBox
        Me.txtCorporationName = New System.Windows.Forms.TextBox
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.lblProjectPhase = New System.Windows.Forms.Label
        Me.lblCorporationName = New System.Windows.Forms.Label
        Me.lblProjectCode = New System.Windows.Forms.Label
        Me.grpProjectBody = New System.Windows.Forms.GroupBox
        Me.tabCoMBase = New System.Windows.Forms.TabControl
        Me.pgProject = New System.Windows.Forms.TabPage
        Me.grpProjectPassed = New System.Windows.Forms.GroupBox
        Me.dgProject = New System.Windows.Forms.DataGrid
        Me.dgtsProject = New System.Windows.Forms.DataGridTableStyle
        Me.dgtbcProjectCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtbcApplyDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtbcProjectServiceType = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtbcProjectBank = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtbcProjectBranch = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtbcProjectApplySum = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtbcProjectTerm = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtbcProjectPurpose = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtbcProjectLoanSum = New System.Windows.Forms.DataGridTextBoxColumn
        Me.grpRequest = New System.Windows.Forms.GroupBox
        Me.txtRecommendPerson = New System.Windows.Forms.TextBox
        Me.cboRecommendItems = New System.Windows.Forms.ComboBox
        Me.cboRecommendType = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPurpose = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblProjectRequestDate = New System.Windows.Forms.Label
        Me.dtpApplyDate = New System.Windows.Forms.DateTimePicker
        Me.nuTerm = New System.Windows.Forms.NumericUpDown
        Me.lblProjectRequestTerm = New System.Windows.Forms.Label
        Me.cboApplyServiceType = New System.Windows.Forms.ComboBox
        Me.lblProjectRequestServiceType = New System.Windows.Forms.Label
        Me.cboApplyBranch = New System.Windows.Forms.ComboBox
        Me.cboApplyBank = New System.Windows.Forms.ComboBox
        Me.lblProjectRequestBranch = New System.Windows.Forms.Label
        Me.txtApplySum = New System.Windows.Forms.TextBox
        Me.lblProjectRequestBank = New System.Windows.Forms.Label
        Me.lblProjectRequestSum = New System.Windows.Forms.Label
        Me.txtCooperateOpinion = New System.Windows.Forms.RichTextBox
        Me.dtpRecommend = New System.Windows.Forms.DateTimePicker
        Me.lblProjectRecommendDate = New System.Windows.Forms.Label
        Me.txtRecommendSum = New System.Windows.Forms.TextBox
        Me.lblProjectRecommendSum = New System.Windows.Forms.Label
        Me.lblProjectCooperateOpinion = New System.Windows.Forms.Label
        Me.pgCorpInfo = New System.Windows.Forms.TabPage
        Me.groupbox = New System.Windows.Forms.GroupBox
        Me.cboMoneyType = New System.Windows.Forms.ComboBox
        Me.lblMoneyType = New System.Windows.Forms.Label
        Me.chkIsFirstLoan = New System.Windows.Forms.CheckBox
        Me.txtLegelMobile = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtLegelPhone = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtContactEmail = New System.Windows.Forms.TextBox
        Me.txtContactMobile = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtColledgeNum = New System.Windows.Forms.TextBox
        Me.lblAttachColledge = New System.Windows.Forms.Label
        Me.txtBachelorNum = New System.Windows.Forms.TextBox
        Me.lblAttachBancholer = New System.Windows.Forms.Label
        Me.txtMasterNum = New System.Windows.Forms.TextBox
        Me.lblAttachMaster = New System.Windows.Forms.Label
        Me.txtDoctorNum = New System.Windows.Forms.TextBox
        Me.lblAttachDoctor = New System.Windows.Forms.Label
        Me.txtEmployeeAmount = New System.Windows.Forms.TextBox
        Me.lblAttachMember = New System.Windows.Forms.Label
        Me.dtpFoundDate = New System.Windows.Forms.DateTimePicker
        Me.lblFoundDate = New System.Windows.Forms.Label
        Me.clbTechType = New System.Windows.Forms.CheckedListBox
        Me.lblCorpTechType = New System.Windows.Forms.Label
        Me.cboProprietorShip = New System.Windows.Forms.ComboBox
        Me.lblCorpPropriateShip = New System.Windows.Forms.Label
        Me.cboIndustryType = New System.Windows.Forms.ComboBox
        Me.lblCorpIndustryType = New System.Windows.Forms.Label
        Me.cboAddressRange = New System.Windows.Forms.ComboBox
        Me.txtAddressDetail = New System.Windows.Forms.TextBox
        Me.lblCorpRegisterAddress = New System.Windows.Forms.Label
        Me.txtLoanCardID = New System.Windows.Forms.TextBox
        Me.lblCorpCardID = New System.Windows.Forms.Label
        Me.txtRepID = New System.Windows.Forms.TextBox
        Me.lblCorpRepreCardID = New System.Windows.Forms.Label
        Me.txtLoanID = New System.Windows.Forms.TextBox
        Me.lblCorpPaperID = New System.Windows.Forms.Label
        Me.txtCorpID = New System.Windows.Forms.TextBox
        Me.lblCorpBusinessCode = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtContactNumber = New System.Windows.Forms.TextBox
        Me.txtContactPerson = New System.Windows.Forms.TextBox
        Me.txtRepreID = New System.Windows.Forms.TextBox
        Me.txtCashReceive = New System.Windows.Forms.TextBox
        Me.txtRepreNation = New System.Windows.Forms.TextBox
        Me.txtInvisibleAssets = New System.Windows.Forms.TextBox
        Me.txtRepresentative = New System.Windows.Forms.TextBox
        Me.txtRealCapital = New System.Windows.Forms.TextBox
        Me.txtRegCapital = New System.Windows.Forms.TextBox
        Me.txtEvalInstitute = New System.Windows.Forms.TextBox
        Me.txtCreditLevel = New System.Windows.Forms.TextBox
        Me.lblContactorFax = New System.Windows.Forms.Label
        Me.lblCorpContactNumber = New System.Windows.Forms.Label
        Me.lblCorpContactor = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblCorpInvisibleAsset = New System.Windows.Forms.Label
        Me.lblCorpRepre = New System.Windows.Forms.Label
        Me.lblCorpRepreID = New System.Windows.Forms.Label
        Me.lblCorpRepreNation = New System.Windows.Forms.Label
        Me.lblCorpCreditLevel = New System.Windows.Forms.Label
        Me.lblCorpEvalInstitute = New System.Windows.Forms.Label
        Me.lblCorpRealAsset = New System.Windows.Forms.Label
        Me.lblCorpCashArrived = New System.Windows.Forms.Label
        Me.lblCorpBusinessStartDate = New System.Windows.Forms.Label
        Me.lblCorpBusinessEndDate = New System.Windows.Forms.Label
        Me.lblCorpRegisterAsset = New System.Windows.Forms.Label
        Me.grpProjectHeader.SuspendLayout()
        Me.grpProjectBody.SuspendLayout()
        Me.tabCoMBase.SuspendLayout()
        Me.pgProject.SuspendLayout()
        Me.grpProjectPassed.SuspendLayout()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequest.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgCorpInfo.SuspendLayout()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(360, 498)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabStop = False
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProjectHeader.Controls.Add(Me.txtPhase)
        Me.grpProjectHeader.Controls.Add(Me.txtCorporationName)
        Me.grpProjectHeader.Controls.Add(Me.txtProjectCode)
        Me.grpProjectHeader.Controls.Add(Me.lblProjectPhase)
        Me.grpProjectHeader.Controls.Add(Me.lblCorporationName)
        Me.grpProjectHeader.Controls.Add(Me.lblProjectCode)
        Me.grpProjectHeader.Location = New System.Drawing.Point(8, 8)
        Me.grpProjectHeader.Name = "grpProjectHeader"
        Me.grpProjectHeader.Size = New System.Drawing.Size(768, 48)
        Me.grpProjectHeader.TabIndex = 0
        Me.grpProjectHeader.TabStop = False
        Me.grpProjectHeader.Text = "��Ŀ��Ϣ"
        '
        'txtPhase
        '
        Me.txtPhase.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtPhase.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPhase.Location = New System.Drawing.Point(672, 16)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.ReadOnly = True
        Me.txtPhase.Size = New System.Drawing.Size(72, 21)
        Me.txtPhase.TabIndex = 0
        Me.txtPhase.TabStop = False
        Me.txtPhase.Text = ""
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(216, 16)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(392, 21)
        Me.txtCorporationName.TabIndex = 0
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 16)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 0
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblProjectPhase.Location = New System.Drawing.Point(616, 16)
        Me.lblProjectPhase.Name = "lblProjectPhase"
        Me.lblProjectPhase.Size = New System.Drawing.Size(56, 23)
        Me.lblProjectPhase.TabIndex = 0
        Me.lblProjectPhase.Text = "��Ŀ�׶�"
        Me.lblProjectPhase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(160, 16)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(56, 23)
        Me.lblCorporationName.TabIndex = 0
        Me.lblCorporationName.Text = "��ҵ����"
        Me.lblCorporationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 17)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(56, 23)
        Me.lblProjectCode.TabIndex = 0
        Me.lblProjectCode.Text = "��Ŀ����"
        Me.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpProjectBody
        '
        Me.grpProjectBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProjectBody.Controls.Add(Me.tabCoMBase)
        Me.grpProjectBody.Location = New System.Drawing.Point(8, 56)
        Me.grpProjectBody.Name = "grpProjectBody"
        Me.grpProjectBody.Size = New System.Drawing.Size(768, 432)
        Me.grpProjectBody.TabIndex = 0
        Me.grpProjectBody.TabStop = False
        '
        'tabCoMBase
        '
        Me.tabCoMBase.Controls.Add(Me.pgProject)
        Me.tabCoMBase.Controls.Add(Me.pgCorpInfo)
        Me.tabCoMBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCoMBase.Location = New System.Drawing.Point(3, 17)
        Me.tabCoMBase.Name = "tabCoMBase"
        Me.tabCoMBase.SelectedIndex = 0
        Me.tabCoMBase.Size = New System.Drawing.Size(762, 412)
        Me.tabCoMBase.TabIndex = 5
        Me.tabCoMBase.TabStop = False
        '
        'pgProject
        '
        Me.pgProject.Controls.Add(Me.grpProjectPassed)
        Me.pgProject.Controls.Add(Me.grpRequest)
        Me.pgProject.Location = New System.Drawing.Point(4, 21)
        Me.pgProject.Name = "pgProject"
        Me.pgProject.Size = New System.Drawing.Size(754, 387)
        Me.pgProject.TabIndex = 11
        Me.pgProject.Text = "��Ŀ��Ϣ"
        '
        'grpProjectPassed
        '
        Me.grpProjectPassed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProjectPassed.Controls.Add(Me.dgProject)
        Me.grpProjectPassed.Location = New System.Drawing.Point(0, 8)
        Me.grpProjectPassed.Name = "grpProjectPassed"
        Me.grpProjectPassed.Size = New System.Drawing.Size(754, 120)
        Me.grpProjectPassed.TabIndex = 0
        Me.grpProjectPassed.TabStop = False
        Me.grpProjectPassed.Text = "��ʷ�����¼"
        '
        'dgProject
        '
        Me.dgProject.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgProject.CaptionVisible = False
        Me.dgProject.DataMember = ""
        Me.dgProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProject.Location = New System.Drawing.Point(3, 17)
        Me.dgProject.Name = "dgProject"
        Me.dgProject.Size = New System.Drawing.Size(748, 100)
        Me.dgProject.TabIndex = 0
        Me.dgProject.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgtsProject})
        Me.dgProject.TabStop = False
        '
        'dgtsProject
        '
        Me.dgtsProject.DataGrid = Me.dgProject
        Me.dgtsProject.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgtbcProjectCode, Me.dgtbcApplyDate, Me.dgtbcProjectServiceType, Me.dgtbcProjectBank, Me.dgtbcProjectBranch, Me.dgtbcProjectApplySum, Me.dgtbcProjectTerm, Me.dgtbcProjectPurpose, Me.dgtbcProjectLoanSum})
        Me.dgtsProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgtsProject.MappingName = "rproject"
        Me.dgtsProject.ReadOnly = True
        Me.dgtsProject.RowHeadersVisible = False
        '
        'dgtbcProjectCode
        '
        Me.dgtbcProjectCode.Format = ""
        Me.dgtbcProjectCode.FormatInfo = Nothing
        Me.dgtbcProjectCode.HeaderText = "��Ŀ����"
        Me.dgtbcProjectCode.MappingName = "project_code"
        Me.dgtbcProjectCode.NullText = ""
        Me.dgtbcProjectCode.Width = 70
        '
        'dgtbcApplyDate
        '
        Me.dgtbcApplyDate.Format = ""
        Me.dgtbcApplyDate.FormatInfo = Nothing
        Me.dgtbcApplyDate.HeaderText = "��������"
        Me.dgtbcApplyDate.MappingName = "apply_date"
        Me.dgtbcApplyDate.NullText = ""
        Me.dgtbcApplyDate.Width = 75
        '
        'dgtbcProjectServiceType
        '
        Me.dgtbcProjectServiceType.Format = ""
        Me.dgtbcProjectServiceType.FormatInfo = Nothing
        Me.dgtbcProjectServiceType.HeaderText = "����ҵ��Ʒ��"
        Me.dgtbcProjectServiceType.MappingName = "apply_service_type"
        Me.dgtbcProjectServiceType.NullText = ""
        Me.dgtbcProjectServiceType.ReadOnly = True
        Me.dgtbcProjectServiceType.Width = 120
        '
        'dgtbcProjectBank
        '
        Me.dgtbcProjectBank.Format = ""
        Me.dgtbcProjectBank.FormatInfo = Nothing
        Me.dgtbcProjectBank.HeaderText = "��������"
        Me.dgtbcProjectBank.MappingName = "CBank"
        Me.dgtbcProjectBank.NullText = ""
        Me.dgtbcProjectBank.ReadOnly = True
        Me.dgtbcProjectBank.Width = 120
        '
        'dgtbcProjectBranch
        '
        Me.dgtbcProjectBranch.Format = ""
        Me.dgtbcProjectBranch.FormatInfo = Nothing
        Me.dgtbcProjectBranch.HeaderText = "����֧��"
        Me.dgtbcProjectBranch.MappingName = "CBranch"
        Me.dgtbcProjectBranch.NullText = ""
        Me.dgtbcProjectBranch.ReadOnly = True
        Me.dgtbcProjectBranch.Width = 120
        '
        'dgtbcProjectApplySum
        '
        Me.dgtbcProjectApplySum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgtbcProjectApplySum.Format = "c"
        Me.dgtbcProjectApplySum.FormatInfo = CType(resources.GetObject("dgtbcProjectApplySum.FormatInfo"), System.IFormatProvider)
        Me.dgtbcProjectApplySum.HeaderText = "���뵣�����(��Ԫ) "
        Me.dgtbcProjectApplySum.MappingName = "apply_sum"
        Me.dgtbcProjectApplySum.NullText = ""
        Me.dgtbcProjectApplySum.ReadOnly = True
        Me.dgtbcProjectApplySum.Width = 120
        '
        'dgtbcProjectTerm
        '
        Me.dgtbcProjectTerm.Format = ""
        Me.dgtbcProjectTerm.FormatInfo = Nothing
        Me.dgtbcProjectTerm.HeaderText = "��������"
        Me.dgtbcProjectTerm.MappingName = "apply_term"
        Me.dgtbcProjectTerm.NullText = ""
        Me.dgtbcProjectTerm.ReadOnly = True
        Me.dgtbcProjectTerm.Width = 75
        '
        'dgtbcProjectPurpose
        '
        Me.dgtbcProjectPurpose.Format = ""
        Me.dgtbcProjectPurpose.FormatInfo = Nothing
        Me.dgtbcProjectPurpose.HeaderText = "��;"
        Me.dgtbcProjectPurpose.MappingName = "purpose"
        Me.dgtbcProjectPurpose.NullText = ""
        Me.dgtbcProjectPurpose.ReadOnly = True
        Me.dgtbcProjectPurpose.Width = 180
        '
        'dgtbcProjectLoanSum
        '
        Me.dgtbcProjectLoanSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgtbcProjectLoanSum.Format = "c"
        Me.dgtbcProjectLoanSum.FormatInfo = CType(resources.GetObject("dgtbcProjectLoanSum.FormatInfo"), System.IFormatProvider)
        Me.dgtbcProjectLoanSum.HeaderText = "������(��Ԫ)"
        Me.dgtbcProjectLoanSum.MappingName = "loan_sum"
        Me.dgtbcProjectLoanSum.NullText = ""
        Me.dgtbcProjectLoanSum.ReadOnly = True
        Me.dgtbcProjectLoanSum.Width = 110
        '
        'grpRequest
        '
        Me.grpRequest.Controls.Add(Me.txtRecommendPerson)
        Me.grpRequest.Controls.Add(Me.cboRecommendItems)
        Me.grpRequest.Controls.Add(Me.cboRecommendType)
        Me.grpRequest.Controls.Add(Me.Label14)
        Me.grpRequest.Controls.Add(Me.txtPurpose)
        Me.grpRequest.Controls.Add(Me.Label7)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestDate)
        Me.grpRequest.Controls.Add(Me.dtpApplyDate)
        Me.grpRequest.Controls.Add(Me.nuTerm)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestTerm)
        Me.grpRequest.Controls.Add(Me.cboApplyServiceType)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestServiceType)
        Me.grpRequest.Controls.Add(Me.cboApplyBranch)
        Me.grpRequest.Controls.Add(Me.cboApplyBank)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestBranch)
        Me.grpRequest.Controls.Add(Me.txtApplySum)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestBank)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestSum)
        Me.grpRequest.Controls.Add(Me.txtCooperateOpinion)
        Me.grpRequest.Controls.Add(Me.dtpRecommend)
        Me.grpRequest.Controls.Add(Me.lblProjectRecommendDate)
        Me.grpRequest.Controls.Add(Me.txtRecommendSum)
        Me.grpRequest.Controls.Add(Me.lblProjectRecommendSum)
        Me.grpRequest.Controls.Add(Me.lblProjectCooperateOpinion)
        Me.grpRequest.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpRequest.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grpRequest.Location = New System.Drawing.Point(0, 123)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Size = New System.Drawing.Size(754, 264)
        Me.grpRequest.TabIndex = 0
        Me.grpRequest.TabStop = False
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRecommendPerson.Location = New System.Drawing.Point(168, 134)
        Me.txtRecommendPerson.MaxLength = 20
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        Me.txtRecommendPerson.Size = New System.Drawing.Size(104, 21)
        Me.txtRecommendPerson.TabIndex = 9
        Me.txtRecommendPerson.Text = ""
        '
        'cboRecommendItems
        '
        Me.cboRecommendItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecommendItems.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboRecommendItems.Location = New System.Drawing.Point(168, 134)
        Me.cboRecommendItems.Name = "cboRecommendItems"
        Me.cboRecommendItems.Size = New System.Drawing.Size(104, 20)
        Me.cboRecommendItems.TabIndex = 10
        '
        'cboRecommendType
        '
        Me.cboRecommendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecommendType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboRecommendType.ItemHeight = 12
        Me.cboRecommendType.Location = New System.Drawing.Point(88, 134)
        Me.cboRecommendType.Name = "cboRecommendType"
        Me.cboRecommendType.Size = New System.Drawing.Size(80, 20)
        Me.cboRecommendType.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "�Ƽ���λ(��)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPurpose
        '
        Me.txtPurpose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPurpose.Location = New System.Drawing.Point(88, 72)
        Me.txtPurpose.MaxLength = 100
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtPurpose.Size = New System.Drawing.Size(656, 56)
        Me.txtPurpose.TabIndex = 6
        Me.txtPurpose.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = " �� ;"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectRequestDate
        '
        Me.lblProjectRequestDate.Location = New System.Drawing.Point(504, 24)
        Me.lblProjectRequestDate.Name = "lblProjectRequestDate"
        Me.lblProjectRequestDate.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectRequestDate.TabIndex = 0
        Me.lblProjectRequestDate.Text = "��������"
        Me.lblProjectRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpApplyDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpApplyDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpApplyDate.Location = New System.Drawing.Point(560, 22)
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Size = New System.Drawing.Size(184, 21)
        Me.dtpApplyDate.TabIndex = 2
        '
        'nuTerm
        '
        Me.nuTerm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nuTerm.Location = New System.Drawing.Point(336, 22)
        Me.nuTerm.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.nuTerm.Name = "nuTerm"
        Me.nuTerm.Size = New System.Drawing.Size(152, 21)
        Me.nuTerm.TabIndex = 1
        Me.nuTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nuTerm.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'lblProjectRequestTerm
        '
        Me.lblProjectRequestTerm.Location = New System.Drawing.Point(256, 24)
        Me.lblProjectRequestTerm.Name = "lblProjectRequestTerm"
        Me.lblProjectRequestTerm.Size = New System.Drawing.Size(80, 16)
        Me.lblProjectRequestTerm.TabIndex = 0
        Me.lblProjectRequestTerm.Text = "��������(��)"
        Me.lblProjectRequestTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboApplyServiceType
        '
        Me.cboApplyServiceType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboApplyServiceType.Location = New System.Drawing.Point(88, 46)
        Me.cboApplyServiceType.Name = "cboApplyServiceType"
        Me.cboApplyServiceType.Size = New System.Drawing.Size(160, 20)
        Me.cboApplyServiceType.TabIndex = 3
        '
        'lblProjectRequestServiceType
        '
        Me.lblProjectRequestServiceType.Location = New System.Drawing.Point(8, 48)
        Me.lblProjectRequestServiceType.Name = "lblProjectRequestServiceType"
        Me.lblProjectRequestServiceType.Size = New System.Drawing.Size(80, 16)
        Me.lblProjectRequestServiceType.TabIndex = 0
        Me.lblProjectRequestServiceType.Text = "����ҵ��Ʒ��"
        Me.lblProjectRequestServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboApplyBranch
        '
        Me.cboApplyBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApplyBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboApplyBranch.Location = New System.Drawing.Point(560, 46)
        Me.cboApplyBranch.Name = "cboApplyBranch"
        Me.cboApplyBranch.Size = New System.Drawing.Size(184, 20)
        Me.cboApplyBranch.TabIndex = 5
        '
        'cboApplyBank
        '
        Me.cboApplyBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApplyBank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboApplyBank.Location = New System.Drawing.Point(336, 46)
        Me.cboApplyBank.Name = "cboApplyBank"
        Me.cboApplyBank.Size = New System.Drawing.Size(152, 20)
        Me.cboApplyBank.TabIndex = 4
        '
        'lblProjectRequestBranch
        '
        Me.lblProjectRequestBranch.Location = New System.Drawing.Point(504, 48)
        Me.lblProjectRequestBranch.Name = "lblProjectRequestBranch"
        Me.lblProjectRequestBranch.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectRequestBranch.TabIndex = 0
        Me.lblProjectRequestBranch.Text = "����֧��"
        Me.lblProjectRequestBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApplySum
        '
        Me.txtApplySum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtApplySum.Location = New System.Drawing.Point(88, 22)
        Me.txtApplySum.MaxLength = 8
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.Size = New System.Drawing.Size(160, 21)
        Me.txtApplySum.TabIndex = 0
        Me.txtApplySum.Text = ""
        Me.txtApplySum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProjectRequestBank
        '
        Me.lblProjectRequestBank.Location = New System.Drawing.Point(256, 48)
        Me.lblProjectRequestBank.Name = "lblProjectRequestBank"
        Me.lblProjectRequestBank.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectRequestBank.TabIndex = 0
        Me.lblProjectRequestBank.Text = "��������"
        Me.lblProjectRequestBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectRequestSum
        '
        Me.lblProjectRequestSum.Location = New System.Drawing.Point(8, 24)
        Me.lblProjectRequestSum.Name = "lblProjectRequestSum"
        Me.lblProjectRequestSum.Size = New System.Drawing.Size(80, 16)
        Me.lblProjectRequestSum.TabIndex = 0
        Me.lblProjectRequestSum.Text = "������(��)"
        Me.lblProjectRequestSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCooperateOpinion
        '
        Me.txtCooperateOpinion.Enabled = False
        Me.txtCooperateOpinion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCooperateOpinion.Location = New System.Drawing.Point(88, 160)
        Me.txtCooperateOpinion.MaxLength = 250
        Me.txtCooperateOpinion.Name = "txtCooperateOpinion"
        Me.txtCooperateOpinion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtCooperateOpinion.Size = New System.Drawing.Size(656, 88)
        Me.txtCooperateOpinion.TabIndex = 10
        Me.txtCooperateOpinion.Text = ""
        '
        'dtpRecommend
        '
        Me.dtpRecommend.CustomFormat = "yyyy-MM-dd"
        Me.dtpRecommend.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpRecommend.Enabled = False
        Me.dtpRecommend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpRecommend.Location = New System.Drawing.Point(560, 134)
        Me.dtpRecommend.Name = "dtpRecommend"
        Me.dtpRecommend.Size = New System.Drawing.Size(184, 21)
        Me.dtpRecommend.TabIndex = 9
        '
        'lblProjectRecommendDate
        '
        Me.lblProjectRecommendDate.Location = New System.Drawing.Point(504, 136)
        Me.lblProjectRecommendDate.Name = "lblProjectRecommendDate"
        Me.lblProjectRecommendDate.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectRecommendDate.TabIndex = 0
        Me.lblProjectRecommendDate.Text = "�Ƽ�����"
        Me.lblProjectRecommendDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRecommendSum
        '
        Me.txtRecommendSum.Enabled = False
        Me.txtRecommendSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRecommendSum.Location = New System.Drawing.Point(368, 134)
        Me.txtRecommendSum.MaxLength = 8
        Me.txtRecommendSum.Name = "txtRecommendSum"
        Me.txtRecommendSum.Size = New System.Drawing.Size(120, 21)
        Me.txtRecommendSum.TabIndex = 8
        Me.txtRecommendSum.Text = ""
        Me.txtRecommendSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProjectRecommendSum
        '
        Me.lblProjectRecommendSum.Location = New System.Drawing.Point(288, 136)
        Me.lblProjectRecommendSum.Name = "lblProjectRecommendSum"
        Me.lblProjectRecommendSum.Size = New System.Drawing.Size(80, 16)
        Me.lblProjectRecommendSum.TabIndex = 0
        Me.lblProjectRecommendSum.Text = "�Ƽ����(��)"
        Me.lblProjectRecommendSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectCooperateOpinion
        '
        Me.lblProjectCooperateOpinion.Location = New System.Drawing.Point(8, 168)
        Me.lblProjectCooperateOpinion.Name = "lblProjectCooperateOpinion"
        Me.lblProjectCooperateOpinion.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCooperateOpinion.TabIndex = 0
        Me.lblProjectCooperateOpinion.Text = "�������"
        Me.lblProjectCooperateOpinion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pgCorpInfo
        '
        Me.pgCorpInfo.Controls.Add(Me.groupbox)
        Me.pgCorpInfo.Location = New System.Drawing.Point(4, 21)
        Me.pgCorpInfo.Name = "pgCorpInfo"
        Me.pgCorpInfo.Size = New System.Drawing.Size(754, 387)
        Me.pgCorpInfo.TabIndex = 0
        Me.pgCorpInfo.Text = "��ҵ��Ϣ"
        '
        'groupbox
        '
        Me.groupbox.Controls.Add(Me.cboMoneyType)
        Me.groupbox.Controls.Add(Me.lblMoneyType)
        Me.groupbox.Controls.Add(Me.chkIsFirstLoan)
        Me.groupbox.Controls.Add(Me.txtLegelMobile)
        Me.groupbox.Controls.Add(Me.Label13)
        Me.groupbox.Controls.Add(Me.txtLegelPhone)
        Me.groupbox.Controls.Add(Me.Label16)
        Me.groupbox.Controls.Add(Me.txtContactEmail)
        Me.groupbox.Controls.Add(Me.txtContactMobile)
        Me.groupbox.Controls.Add(Me.Label10)
        Me.groupbox.Controls.Add(Me.Label11)
        Me.groupbox.Controls.Add(Me.txtColledgeNum)
        Me.groupbox.Controls.Add(Me.lblAttachColledge)
        Me.groupbox.Controls.Add(Me.txtBachelorNum)
        Me.groupbox.Controls.Add(Me.lblAttachBancholer)
        Me.groupbox.Controls.Add(Me.txtMasterNum)
        Me.groupbox.Controls.Add(Me.lblAttachMaster)
        Me.groupbox.Controls.Add(Me.txtDoctorNum)
        Me.groupbox.Controls.Add(Me.lblAttachDoctor)
        Me.groupbox.Controls.Add(Me.txtEmployeeAmount)
        Me.groupbox.Controls.Add(Me.lblAttachMember)
        Me.groupbox.Controls.Add(Me.dtpFoundDate)
        Me.groupbox.Controls.Add(Me.lblFoundDate)
        Me.groupbox.Controls.Add(Me.clbTechType)
        Me.groupbox.Controls.Add(Me.lblCorpTechType)
        Me.groupbox.Controls.Add(Me.cboProprietorShip)
        Me.groupbox.Controls.Add(Me.lblCorpPropriateShip)
        Me.groupbox.Controls.Add(Me.cboIndustryType)
        Me.groupbox.Controls.Add(Me.lblCorpIndustryType)
        Me.groupbox.Controls.Add(Me.cboAddressRange)
        Me.groupbox.Controls.Add(Me.txtAddressDetail)
        Me.groupbox.Controls.Add(Me.lblCorpRegisterAddress)
        Me.groupbox.Controls.Add(Me.txtLoanCardID)
        Me.groupbox.Controls.Add(Me.lblCorpCardID)
        Me.groupbox.Controls.Add(Me.txtRepID)
        Me.groupbox.Controls.Add(Me.lblCorpRepreCardID)
        Me.groupbox.Controls.Add(Me.txtLoanID)
        Me.groupbox.Controls.Add(Me.lblCorpPaperID)
        Me.groupbox.Controls.Add(Me.txtCorpID)
        Me.groupbox.Controls.Add(Me.lblCorpBusinessCode)
        Me.groupbox.Controls.Add(Me.txtFax)
        Me.groupbox.Controls.Add(Me.txtContactNumber)
        Me.groupbox.Controls.Add(Me.txtContactPerson)
        Me.groupbox.Controls.Add(Me.txtRepreID)
        Me.groupbox.Controls.Add(Me.txtCashReceive)
        Me.groupbox.Controls.Add(Me.txtRepreNation)
        Me.groupbox.Controls.Add(Me.txtInvisibleAssets)
        Me.groupbox.Controls.Add(Me.txtRepresentative)
        Me.groupbox.Controls.Add(Me.txtRealCapital)
        Me.groupbox.Controls.Add(Me.txtRegCapital)
        Me.groupbox.Controls.Add(Me.txtEvalInstitute)
        Me.groupbox.Controls.Add(Me.txtCreditLevel)
        Me.groupbox.Controls.Add(Me.lblContactorFax)
        Me.groupbox.Controls.Add(Me.lblCorpContactNumber)
        Me.groupbox.Controls.Add(Me.lblCorpContactor)
        Me.groupbox.Controls.Add(Me.dtpEndDate)
        Me.groupbox.Controls.Add(Me.dtpStartDate)
        Me.groupbox.Controls.Add(Me.lblCorpInvisibleAsset)
        Me.groupbox.Controls.Add(Me.lblCorpRepre)
        Me.groupbox.Controls.Add(Me.lblCorpRepreID)
        Me.groupbox.Controls.Add(Me.lblCorpRepreNation)
        Me.groupbox.Controls.Add(Me.lblCorpCreditLevel)
        Me.groupbox.Controls.Add(Me.lblCorpEvalInstitute)
        Me.groupbox.Controls.Add(Me.lblCorpRealAsset)
        Me.groupbox.Controls.Add(Me.lblCorpCashArrived)
        Me.groupbox.Controls.Add(Me.lblCorpBusinessStartDate)
        Me.groupbox.Controls.Add(Me.lblCorpBusinessEndDate)
        Me.groupbox.Controls.Add(Me.lblCorpRegisterAsset)
        Me.groupbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupbox.Location = New System.Drawing.Point(0, 0)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(754, 387)
        Me.groupbox.TabIndex = 0
        Me.groupbox.TabStop = False
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneyType.Location = New System.Drawing.Point(352, 190)
        Me.cboMoneyType.Name = "cboMoneyType"
        Me.cboMoneyType.Size = New System.Drawing.Size(136, 20)
        Me.cboMoneyType.TabIndex = 10001
        '
        'lblMoneyType
        '
        Me.lblMoneyType.Location = New System.Drawing.Point(264, 192)
        Me.lblMoneyType.Name = "lblMoneyType"
        Me.lblMoneyType.Size = New System.Drawing.Size(100, 16)
        Me.lblMoneyType.TabIndex = 10002
        Me.lblMoneyType.Text = "��������"
        '
        'chkIsFirstLoan
        '
        Me.chkIsFirstLoan.Location = New System.Drawing.Point(16, 240)
        Me.chkIsFirstLoan.Name = "chkIsFirstLoan"
        Me.chkIsFirstLoan.Size = New System.Drawing.Size(168, 24)
        Me.chkIsFirstLoan.TabIndex = 19
        Me.chkIsFirstLoan.Text = "����ҵ�ǵ�һ�δ���"
        '
        'txtLegelMobile
        '
        Me.txtLegelMobile.BackColor = System.Drawing.SystemColors.Window
        Me.txtLegelMobile.Location = New System.Drawing.Point(352, 264)
        Me.txtLegelMobile.MaxLength = 12
        Me.txtLegelMobile.Name = "txtLegelMobile"
        Me.txtLegelMobile.Size = New System.Drawing.Size(136, 21)
        Me.txtLegelMobile.TabIndex = 24
        Me.txtLegelMobile.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(256, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 324
        Me.Label13.Text = "�����������ֻ�"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLegelPhone
        '
        Me.txtLegelPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtLegelPhone.Location = New System.Drawing.Point(96, 286)
        Me.txtLegelPhone.MaxLength = 20
        Me.txtLegelPhone.Name = "txtLegelPhone"
        Me.txtLegelPhone.Size = New System.Drawing.Size(152, 21)
        Me.txtLegelPhone.TabIndex = 23
        Me.txtLegelPhone.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 291)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 320
        Me.Label16.Text = "���������˵绰"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactEmail
        '
        Me.txtContactEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtContactEmail.Location = New System.Drawing.Point(352, 310)
        Me.txtContactEmail.MaxLength = 30
        Me.txtContactEmail.Name = "txtContactEmail"
        Me.txtContactEmail.Size = New System.Drawing.Size(392, 21)
        Me.txtContactEmail.TabIndex = 29
        Me.txtContactEmail.Text = ""
        '
        'txtContactMobile
        '
        Me.txtContactMobile.BackColor = System.Drawing.SystemColors.Window
        Me.txtContactMobile.Location = New System.Drawing.Point(96, 334)
        Me.txtContactMobile.MaxLength = 12
        Me.txtContactMobile.Name = "txtContactMobile"
        Me.txtContactMobile.Size = New System.Drawing.Size(152, 21)
        Me.txtContactMobile.TabIndex = 28
        Me.txtContactMobile.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(264, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 315
        Me.Label10.Text = "��ϵ��Email"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 316
        Me.Label11.Text = "��ϵ���ֻ�"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtColledgeNum
        '
        Me.txtColledgeNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtColledgeNum.Location = New System.Drawing.Point(352, 334)
        Me.txtColledgeNum.MaxLength = 6
        Me.txtColledgeNum.Name = "txtColledgeNum"
        Me.txtColledgeNum.Size = New System.Drawing.Size(136, 21)
        Me.txtColledgeNum.TabIndex = 31
        Me.txtColledgeNum.Text = "0"
        Me.txtColledgeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachColledge
        '
        Me.lblAttachColledge.Location = New System.Drawing.Point(264, 336)
        Me.lblAttachColledge.Name = "lblAttachColledge"
        Me.lblAttachColledge.Size = New System.Drawing.Size(72, 16)
        Me.lblAttachColledge.TabIndex = 301
        Me.lblAttachColledge.Text = "��ר������"
        Me.lblAttachColledge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBachelorNum
        '
        Me.txtBachelorNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBachelorNum.Location = New System.Drawing.Point(608, 334)
        Me.txtBachelorNum.MaxLength = 6
        Me.txtBachelorNum.Name = "txtBachelorNum"
        Me.txtBachelorNum.Size = New System.Drawing.Size(136, 21)
        Me.txtBachelorNum.TabIndex = 32
        Me.txtBachelorNum.Text = "0"
        Me.txtBachelorNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachBancholer
        '
        Me.lblAttachBancholer.Location = New System.Drawing.Point(512, 336)
        Me.lblAttachBancholer.Name = "lblAttachBancholer"
        Me.lblAttachBancholer.Size = New System.Drawing.Size(80, 16)
        Me.lblAttachBancholer.TabIndex = 303
        Me.lblAttachBancholer.Text = "����������"
        Me.lblAttachBancholer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMasterNum
        '
        Me.txtMasterNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtMasterNum.Location = New System.Drawing.Point(352, 358)
        Me.txtMasterNum.MaxLength = 6
        Me.txtMasterNum.Name = "txtMasterNum"
        Me.txtMasterNum.Size = New System.Drawing.Size(136, 21)
        Me.txtMasterNum.TabIndex = 33
        Me.txtMasterNum.Text = "0"
        Me.txtMasterNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachMaster
        '
        Me.lblAttachMaster.Location = New System.Drawing.Point(264, 360)
        Me.lblAttachMaster.Name = "lblAttachMaster"
        Me.lblAttachMaster.Size = New System.Drawing.Size(72, 16)
        Me.lblAttachMaster.TabIndex = 302
        Me.lblAttachMaster.Text = "˶ʿ������"
        Me.lblAttachMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDoctorNum
        '
        Me.txtDoctorNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDoctorNum.Location = New System.Drawing.Point(608, 358)
        Me.txtDoctorNum.MaxLength = 6
        Me.txtDoctorNum.Name = "txtDoctorNum"
        Me.txtDoctorNum.Size = New System.Drawing.Size(136, 21)
        Me.txtDoctorNum.TabIndex = 34
        Me.txtDoctorNum.Text = "0"
        Me.txtDoctorNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachDoctor
        '
        Me.lblAttachDoctor.Location = New System.Drawing.Point(512, 360)
        Me.lblAttachDoctor.Name = "lblAttachDoctor"
        Me.lblAttachDoctor.Size = New System.Drawing.Size(80, 16)
        Me.lblAttachDoctor.TabIndex = 300
        Me.lblAttachDoctor.Text = "��ʿ������"
        Me.lblAttachDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmployeeAmount
        '
        Me.txtEmployeeAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtEmployeeAmount.Location = New System.Drawing.Point(96, 358)
        Me.txtEmployeeAmount.MaxLength = 6
        Me.txtEmployeeAmount.Name = "txtEmployeeAmount"
        Me.txtEmployeeAmount.Size = New System.Drawing.Size(152, 21)
        Me.txtEmployeeAmount.TabIndex = 30
        Me.txtEmployeeAmount.Text = "0"
        Me.txtEmployeeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachMember
        '
        Me.lblAttachMember.Location = New System.Drawing.Point(8, 363)
        Me.lblAttachMember.Name = "lblAttachMember"
        Me.lblAttachMember.Size = New System.Drawing.Size(80, 16)
        Me.lblAttachMember.TabIndex = 306
        Me.lblAttachMember.Text = "Ա��������"
        Me.lblAttachMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpFoundDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFoundDate.Enabled = False
        Me.dtpFoundDate.Location = New System.Drawing.Point(608, 70)
        Me.dtpFoundDate.Name = "dtpFoundDate"
        Me.dtpFoundDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpFoundDate.TabIndex = 9
        Me.dtpFoundDate.Visible = False
        '
        'lblFoundDate
        '
        Me.lblFoundDate.Location = New System.Drawing.Point(512, 72)
        Me.lblFoundDate.Name = "lblFoundDate"
        Me.lblFoundDate.Size = New System.Drawing.Size(56, 16)
        Me.lblFoundDate.TabIndex = 0
        Me.lblFoundDate.Text = "��������"
        Me.lblFoundDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFoundDate.Visible = False
        '
        'clbTechType
        '
        Me.clbTechType.CheckOnClick = True
        Me.clbTechType.Location = New System.Drawing.Point(96, 124)
        Me.clbTechType.MultiColumn = True
        Me.clbTechType.Name = "clbTechType"
        Me.clbTechType.Size = New System.Drawing.Size(648, 36)
        Me.clbTechType.TabIndex = 12
        '
        'lblCorpTechType
        '
        Me.lblCorpTechType.Location = New System.Drawing.Point(8, 128)
        Me.lblCorpTechType.Name = "lblCorpTechType"
        Me.lblCorpTechType.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpTechType.TabIndex = 0
        Me.lblCorpTechType.Text = "��ҵ��������"
        Me.lblCorpTechType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboProprietorShip
        '
        Me.cboProprietorShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProprietorShip.ItemHeight = 12
        Me.cboProprietorShip.Location = New System.Drawing.Point(96, 96)
        Me.cboProprietorShip.Name = "cboProprietorShip"
        Me.cboProprietorShip.Size = New System.Drawing.Size(272, 20)
        Me.cboProprietorShip.TabIndex = 10
        '
        'lblCorpPropriateShip
        '
        Me.lblCorpPropriateShip.Location = New System.Drawing.Point(8, 96)
        Me.lblCorpPropriateShip.Name = "lblCorpPropriateShip"
        Me.lblCorpPropriateShip.Size = New System.Drawing.Size(88, 16)
        Me.lblCorpPropriateShip.TabIndex = 0
        Me.lblCorpPropriateShip.Text = "����������"
        Me.lblCorpPropriateShip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboIndustryType
        '
        Me.cboIndustryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIndustryType.ItemHeight = 12
        Me.cboIndustryType.Location = New System.Drawing.Point(496, 96)
        Me.cboIndustryType.Name = "cboIndustryType"
        Me.cboIndustryType.Size = New System.Drawing.Size(248, 20)
        Me.cboIndustryType.TabIndex = 11
        '
        'lblCorpIndustryType
        '
        Me.lblCorpIndustryType.Location = New System.Drawing.Point(416, 98)
        Me.lblCorpIndustryType.Name = "lblCorpIndustryType"
        Me.lblCorpIndustryType.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpIndustryType.TabIndex = 0
        Me.lblCorpIndustryType.Text = "��ҵ����"
        Me.lblCorpIndustryType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAddressRange
        '
        Me.cboAddressRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressRange.ItemHeight = 12
        Me.cboAddressRange.Location = New System.Drawing.Point(96, 70)
        Me.cboAddressRange.Name = "cboAddressRange"
        Me.cboAddressRange.Size = New System.Drawing.Size(152, 20)
        Me.cboAddressRange.TabIndex = 7
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.Location = New System.Drawing.Point(248, 70)
        Me.txtAddressDetail.MaxLength = 50
        Me.txtAddressDetail.Name = "txtAddressDetail"
        Me.txtAddressDetail.Size = New System.Drawing.Size(248, 21)
        Me.txtAddressDetail.TabIndex = 8
        Me.txtAddressDetail.Text = ""
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.Location = New System.Drawing.Point(8, 72)
        Me.lblCorpRegisterAddress.Name = "lblCorpRegisterAddress"
        Me.lblCorpRegisterAddress.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpRegisterAddress.TabIndex = 0
        Me.lblCorpRegisterAddress.Text = "ע���ַ"
        Me.lblCorpRegisterAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.Location = New System.Drawing.Point(608, 46)
        Me.txtLoanCardID.MaxLength = 18
        Me.txtLoanCardID.Name = "txtLoanCardID"
        Me.txtLoanCardID.Size = New System.Drawing.Size(136, 21)
        Me.txtLoanCardID.TabIndex = 6
        Me.txtLoanCardID.Text = ""
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.Location = New System.Drawing.Point(512, 48)
        Me.lblCorpCardID.Name = "lblCorpCardID"
        Me.lblCorpCardID.Size = New System.Drawing.Size(64, 16)
        Me.lblCorpCardID.TabIndex = 0
        Me.lblCorpCardID.Text = "�������"
        Me.lblCorpCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRepID
        '
        Me.txtRepID.Location = New System.Drawing.Point(96, 46)
        Me.txtRepID.MaxLength = 10
        Me.txtRepID.Name = "txtRepID"
        Me.txtRepID.Size = New System.Drawing.Size(152, 21)
        Me.txtRepID.TabIndex = 4
        Me.txtRepID.Text = ""
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.Location = New System.Drawing.Point(8, 48)
        Me.lblCorpRepreCardID.Name = "lblCorpRepreCardID"
        Me.lblCorpRepreCardID.Size = New System.Drawing.Size(88, 16)
        Me.lblCorpRepreCardID.TabIndex = 0
        Me.lblCorpRepreCardID.Text = "���˴���֤��"
        Me.lblCorpRepreCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanID
        '
        Me.txtLoanID.Location = New System.Drawing.Point(360, 46)
        Me.txtLoanID.MaxLength = 7
        Me.txtLoanID.Name = "txtLoanID"
        Me.txtLoanID.Size = New System.Drawing.Size(136, 21)
        Me.txtLoanID.TabIndex = 5
        Me.txtLoanID.Text = ""
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.Location = New System.Drawing.Point(264, 48)
        Me.lblCorpPaperID.Name = "lblCorpPaperID"
        Me.lblCorpPaperID.Size = New System.Drawing.Size(64, 16)
        Me.lblCorpPaperID.TabIndex = 0
        Me.lblCorpPaperID.Text = "����֤����"
        Me.lblCorpPaperID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorpID
        '
        Me.txtCorpID.Location = New System.Drawing.Point(96, 22)
        Me.txtCorpID.MaxLength = 15
        Me.txtCorpID.Name = "txtCorpID"
        Me.txtCorpID.Size = New System.Drawing.Size(152, 21)
        Me.txtCorpID.TabIndex = 1
        Me.txtCorpID.Text = "��˾��"
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.Location = New System.Drawing.Point(8, 24)
        Me.lblCorpBusinessCode.Name = "lblCorpBusinessCode"
        Me.lblCorpBusinessCode.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpBusinessCode.TabIndex = 0
        Me.lblCorpBusinessCode.Text = "Ӫҵִ�պ���"
        Me.lblCorpBusinessCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(608, 286)
        Me.txtFax.MaxLength = 10
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(136, 21)
        Me.txtFax.TabIndex = 27
        Me.txtFax.Text = ""
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(352, 286)
        Me.txtContactNumber.MaxLength = 20
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(136, 21)
        Me.txtContactNumber.TabIndex = 26
        Me.txtContactNumber.Text = ""
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(96, 310)
        Me.txtContactPerson.MaxLength = 10
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(152, 21)
        Me.txtContactPerson.TabIndex = 25
        Me.txtContactPerson.Text = ""
        '
        'txtRepreID
        '
        Me.txtRepreID.Location = New System.Drawing.Point(608, 240)
        Me.txtRepreID.MaxLength = 20
        Me.txtRepreID.Name = "txtRepreID"
        Me.txtRepreID.Size = New System.Drawing.Size(136, 21)
        Me.txtRepreID.TabIndex = 22
        Me.txtRepreID.Text = ""
        '
        'txtCashReceive
        '
        Me.txtCashReceive.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCashReceive.Location = New System.Drawing.Point(352, 216)
        Me.txtCashReceive.MaxLength = 8
        Me.txtCashReceive.Name = "txtCashReceive"
        Me.txtCashReceive.Size = New System.Drawing.Size(136, 21)
        Me.txtCashReceive.TabIndex = 17
        Me.txtCashReceive.Text = ""
        Me.txtCashReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRepreNation
        '
        Me.txtRepreNation.Location = New System.Drawing.Point(608, 264)
        Me.txtRepreNation.MaxLength = 10
        Me.txtRepreNation.Name = "txtRepreNation"
        Me.txtRepreNation.Size = New System.Drawing.Size(136, 21)
        Me.txtRepreNation.TabIndex = 21
        Me.txtRepreNation.Text = "�й�"
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtInvisibleAssets.Location = New System.Drawing.Point(96, 216)
        Me.txtInvisibleAssets.MaxLength = 8
        Me.txtInvisibleAssets.Name = "txtInvisibleAssets"
        Me.txtInvisibleAssets.Size = New System.Drawing.Size(152, 21)
        Me.txtInvisibleAssets.TabIndex = 16
        Me.txtInvisibleAssets.Text = ""
        Me.txtInvisibleAssets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRepresentative
        '
        Me.txtRepresentative.Location = New System.Drawing.Point(96, 264)
        Me.txtRepresentative.MaxLength = 10
        Me.txtRepresentative.Name = "txtRepresentative"
        Me.txtRepresentative.Size = New System.Drawing.Size(152, 21)
        Me.txtRepresentative.TabIndex = 20
        Me.txtRepresentative.Text = ""
        '
        'txtRealCapital
        '
        Me.txtRealCapital.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRealCapital.Location = New System.Drawing.Point(608, 216)
        Me.txtRealCapital.MaxLength = 8
        Me.txtRealCapital.Name = "txtRealCapital"
        Me.txtRealCapital.Size = New System.Drawing.Size(136, 21)
        Me.txtRealCapital.TabIndex = 18
        Me.txtRealCapital.Text = ""
        Me.txtRealCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegCapital
        '
        Me.txtRegCapital.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRegCapital.Location = New System.Drawing.Point(96, 190)
        Me.txtRegCapital.MaxLength = 8
        Me.txtRegCapital.Name = "txtRegCapital"
        Me.txtRegCapital.Size = New System.Drawing.Size(152, 21)
        Me.txtRegCapital.TabIndex = 15
        Me.txtRegCapital.Text = ""
        Me.txtRegCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEvalInstitute
        '
        Me.txtEvalInstitute.Location = New System.Drawing.Point(352, 166)
        Me.txtEvalInstitute.MaxLength = 20
        Me.txtEvalInstitute.Name = "txtEvalInstitute"
        Me.txtEvalInstitute.Size = New System.Drawing.Size(392, 21)
        Me.txtEvalInstitute.TabIndex = 14
        Me.txtEvalInstitute.Text = ""
        '
        'txtCreditLevel
        '
        Me.txtCreditLevel.Location = New System.Drawing.Point(96, 166)
        Me.txtCreditLevel.MaxLength = 10
        Me.txtCreditLevel.Name = "txtCreditLevel"
        Me.txtCreditLevel.Size = New System.Drawing.Size(152, 21)
        Me.txtCreditLevel.TabIndex = 13
        Me.txtCreditLevel.Text = ""
        '
        'lblContactorFax
        '
        Me.lblContactorFax.Location = New System.Drawing.Point(512, 288)
        Me.lblContactorFax.Name = "lblContactorFax"
        Me.lblContactorFax.Size = New System.Drawing.Size(88, 16)
        Me.lblContactorFax.TabIndex = 0
        Me.lblContactorFax.Text = "��ϵ�˴���"
        Me.lblContactorFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpContactNumber
        '
        Me.lblCorpContactNumber.Location = New System.Drawing.Point(264, 288)
        Me.lblCorpContactNumber.Name = "lblCorpContactNumber"
        Me.lblCorpContactNumber.Size = New System.Drawing.Size(72, 16)
        Me.lblCorpContactNumber.TabIndex = 0
        Me.lblCorpContactNumber.Text = "��ϵ�˵绰"
        Me.lblCorpContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpContactor
        '
        Me.lblCorpContactor.Location = New System.Drawing.Point(8, 315)
        Me.lblCorpContactor.Name = "lblCorpContactor"
        Me.lblCorpContactor.Size = New System.Drawing.Size(64, 16)
        Me.lblCorpContactor.TabIndex = 0
        Me.lblCorpContactor.Text = "��ϵ��"
        Me.lblCorpContactor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpEndDate.Location = New System.Drawing.Point(608, 22)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpEndDate.TabIndex = 3
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpStartDate.Location = New System.Drawing.Point(360, 22)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpStartDate.TabIndex = 2
        '
        'lblCorpInvisibleAsset
        '
        Me.lblCorpInvisibleAsset.Location = New System.Drawing.Point(8, 218)
        Me.lblCorpInvisibleAsset.Name = "lblCorpInvisibleAsset"
        Me.lblCorpInvisibleAsset.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpInvisibleAsset.TabIndex = 0
        Me.lblCorpInvisibleAsset.Text = "�����ʲ�(��)"
        Me.lblCorpInvisibleAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepre
        '
        Me.lblCorpRepre.Location = New System.Drawing.Point(8, 266)
        Me.lblCorpRepre.Name = "lblCorpRepre"
        Me.lblCorpRepre.Size = New System.Drawing.Size(72, 16)
        Me.lblCorpRepre.TabIndex = 0
        Me.lblCorpRepre.Text = "����������"
        Me.lblCorpRepre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepreID
        '
        Me.lblCorpRepreID.Location = New System.Drawing.Point(496, 242)
        Me.lblCorpRepreID.Name = "lblCorpRepreID"
        Me.lblCorpRepreID.Size = New System.Drawing.Size(104, 16)
        Me.lblCorpRepreID.TabIndex = 0
        Me.lblCorpRepreID.Text = "�������������֤"
        Me.lblCorpRepreID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepreNation
        '
        Me.lblCorpRepreNation.Location = New System.Drawing.Point(504, 264)
        Me.lblCorpRepreNation.Name = "lblCorpRepreNation"
        Me.lblCorpRepreNation.Size = New System.Drawing.Size(96, 16)
        Me.lblCorpRepreNation.TabIndex = 0
        Me.lblCorpRepreNation.Text = "���������˹���"
        Me.lblCorpRepreNation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpCreditLevel
        '
        Me.lblCorpCreditLevel.Location = New System.Drawing.Point(8, 168)
        Me.lblCorpCreditLevel.Name = "lblCorpCreditLevel"
        Me.lblCorpCreditLevel.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpCreditLevel.TabIndex = 0
        Me.lblCorpCreditLevel.Text = "���ŵȼ�"
        Me.lblCorpCreditLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpEvalInstitute
        '
        Me.lblCorpEvalInstitute.Location = New System.Drawing.Point(264, 168)
        Me.lblCorpEvalInstitute.Name = "lblCorpEvalInstitute"
        Me.lblCorpEvalInstitute.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpEvalInstitute.TabIndex = 0
        Me.lblCorpEvalInstitute.Text = "������λ"
        Me.lblCorpEvalInstitute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRealAsset
        '
        Me.lblCorpRealAsset.Location = New System.Drawing.Point(512, 218)
        Me.lblCorpRealAsset.Name = "lblCorpRealAsset"
        Me.lblCorpRealAsset.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpRealAsset.TabIndex = 0
        Me.lblCorpRealAsset.Text = "ʵ���ʱ�(��)"
        Me.lblCorpRealAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.Location = New System.Drawing.Point(254, 218)
        Me.lblCorpCashArrived.Name = "lblCorpCashArrived"
        Me.lblCorpCashArrived.Size = New System.Drawing.Size(104, 16)
        Me.lblCorpCashArrived.TabIndex = 0
        Me.lblCorpCashArrived.Text = "�����ʽ�λ(��)"
        Me.lblCorpCashArrived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpBusinessStartDate
        '
        Me.lblCorpBusinessStartDate.Location = New System.Drawing.Point(264, 24)
        Me.lblCorpBusinessStartDate.Name = "lblCorpBusinessStartDate"
        Me.lblCorpBusinessStartDate.Size = New System.Drawing.Size(88, 16)
        Me.lblCorpBusinessStartDate.TabIndex = 0
        Me.lblCorpBusinessStartDate.Text = "��Ӫ������ʼ��"
        Me.lblCorpBusinessStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpBusinessEndDate
        '
        Me.lblCorpBusinessEndDate.Location = New System.Drawing.Point(512, 24)
        Me.lblCorpBusinessEndDate.Name = "lblCorpBusinessEndDate"
        Me.lblCorpBusinessEndDate.Size = New System.Drawing.Size(88, 16)
        Me.lblCorpBusinessEndDate.TabIndex = 0
        Me.lblCorpBusinessEndDate.Text = "��Ӫ���޽�ֹ��"
        Me.lblCorpBusinessEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRegisterAsset
        '
        Me.lblCorpRegisterAsset.Location = New System.Drawing.Point(8, 192)
        Me.lblCorpRegisterAsset.Name = "lblCorpRegisterAsset"
        Me.lblCorpRegisterAsset.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpRegisterAsset.TabIndex = 0
        Me.lblCorpRegisterAsset.Text = "ע���ʱ�(��)"
        Me.lblCorpRegisterAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCoMBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(786, 528)
        Me.Controls.Add(Me.grpProjectBody)
        Me.Controls.Add(Me.grpProjectHeader)
        Me.MaximizeBox = False
        Me.Name = "frmCoMBase"
        Me.Text = "��Ŀ��ҵ��Ϣ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.grpProjectHeader, 0)
        Me.Controls.SetChildIndex(Me.grpProjectBody, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.grpProjectHeader.ResumeLayout(False)
        Me.grpProjectBody.ResumeLayout(False)
        Me.tabCoMBase.ResumeLayout(False)
        Me.pgProject.ResumeLayout(False)
        Me.grpProjectPassed.ResumeLayout(False)
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequest.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgCorpInfo.ResumeLayout(False)
        Me.groupbox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected ds As New DataSet()
    Protected dsBank As DataSet
    Protected _ProCode As String = Nothing  '��Ŀ����
    Protected _CorpCode As String           '��ҵ����
    Protected _Phase As String '��Ŀ�׶�
    Protected SysDate As Date 'ϵͳ����
    Protected bFormLoad As Boolean = False  '�����Ƿ��Ѿ�
    Protected bIsChanged As Boolean = False '�����Ƿ�ı�
    Protected dsTemp As DataSet
    Protected CorpName As String

    Private Sub frmCoMBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            If gWs Is Nothing Then
                Return
            End If
            'Me.InitCorpCodeAndPhase()
            'Me.InitComboBox()
            'Me.InitDataSet()
            'Me.GetData()
            'Me.bFormLoad = True
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#Region "��ʼ������"
    '��ʼ����ҵ������׶�
    Protected Overridable Sub InitCorpCodeAndPhase()
        Me._ProCode = Me.getProjectCode()
        Me._CorpCode = Me._ProCode.Substring(0, 5)
        Me._Phase = Me.getPhase(Me._ProCode)
        Dim dt As DataTable = gWs.GetCommonQueryInfo("select corporation_name from corporation where corporation_code='" & _CorpCode & "'").Tables(0)
        If Not dt.Rows.Count = 0 Then
            Me.CorpName = dt.Rows(0).Item("corporation_name")
        End If
    End Sub
    '��ʼ����󶨴����е�ComboBox
    Protected Sub InitComboBox()
        '�����������
        dsBank = gWs.GetBankInfo("%", "%")
        dsBank.Tables("bank").DefaultView.Sort = "bank_name"
        Me.cboApplyBank.DataSource = dsBank.Tables("bank")
        Me.cboApplyBank.DisplayMember = "bank_name"
        Me.cboApplyBank.ValueMember = "bank_code"
        Me.dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
        Me.cboApplyBranch.DataSource = dsBank.Tables("bank_branch").DefaultView
        Me.cboApplyBranch.DisplayMember = "branch_bank_name"
        Me.cboApplyBranch.ValueMember = "branch_bank_code"
        AddHandler cboApplyBank.SelectedIndexChanged, AddressOf BankChanged
        BankChanged(Nothing, Nothing)
        '����ҵ��Ʒ��'
        Me.cboApplyServiceType.DataSource = ServiceTypeDS.Tables("TServiceType")
        Me.cboApplyServiceType.DisplayMember = "service_type"
        Me.cboApplyServiceType.ValueMember = "service_type"
        '�Ƽ�����
        Me.cboRecommendType.DataSource = RecommendTypeDS.Tables("TRecommendType")
        Me.cboRecommendType.DisplayMember = "recommend_type"
        Me.cboRecommendType.ValueMember = "recommend_type"
        '����
        Me.cboAddressRange.DataSource = DistrictDS.Tables("TDistrict")
        Me.cboAddressRange.DisplayMember = "district_name"
        Me.cboAddressRange.ValueMember = "district_name"
        '��������
        Me.clbTechType.DataSource = TechnologyTypeDS.Tables("TTechnologyType")
        Me.clbTechType.DisplayMember = "technology_type"
        Me.clbTechType.ValueMember = "technology_type_code"
        '����������
        Me.cboProprietorShip.DataSource = ProprietorShipDS.Tables("TProprietorshipType")
        Me.cboProprietorShip.DisplayMember = "proprietorship_type"
        Me.cboProprietorShip.ValueMember = "proprietorship_type"
        '��ҵ����'
        Me.cboIndustryType.DataSource = IndustryTypeDS.Tables("TIndustryType")
        Me.cboIndustryType.DisplayMember = "industry_type"
        Me.cboIndustryType.ValueMember = "industry_type"
        '��������
        Me.cboMoneyType.DataSource = gWs.GetMoneyInfo("%").Tables(0)
        Me.cboMoneyType.DisplayMember = "name"
        Me.cboMoneyType.ValueMember = "money_id"
    End Sub
    '�������б����ʼ��֧�е�ComboBox
    Protected Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.cboApplyBranch.DataBindings.Clear()
        Me.dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboApplyBank.SelectedValue & "'"
        Me.dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
    End Sub
    '��ʼ��ds
    Protected Overridable Sub InitDataSet()
        '��Ŀ��Ϣ
        Me.ds.Merge(gWs.GetProjectInfo("{project_code='" + Me._ProCode + "'}").Tables("project"))
        '��ҵ��Ϣ
        Me.ds.Merge(gWs.GetcorporationInfo("{corporation_code='" + Me._CorpCode + "'}", "null"))
        '��Ŀ��ҵ��Ϣ��
        '2007-12-18 yjf edit
        'Me.ds.Merge(gWs.FetchProjectCorporation(Me._ProCode, Me._CorpCode, "1", _Phase).Tables("TProjectCorporation"))

        If _Phase = "չ��" Then
            Me.ds.Merge(gWs.FetchProjectCorporation(Me._ProCode, Me._CorpCode, "1", "����").Tables("TProjectCorporation"))
        Else
            Me.ds.Merge(gWs.FetchProjectCorporation(Me._ProCode, Me._CorpCode, "1", "").Tables("TProjectCorporation"))
        End If

        '��Ŀ��ҵ��Ϣ��������(������ѯ��Ϣ)
        If ds.Tables("TProjectCorporation").Rows.Count = 0 Then
            'Select Case Me._Phase
            '    Case "����"      '�׶�Ϊ����project_corporation���в����ڼ�¼��copy��ѯ��
            '        Me.CopyFinalConsultaion()
            '    Case "����"      '�׶�Ϊ����project_corporation���в����ڼ�¼��������ڽ׶�Ϊ�����project_corporation��¼��copy�˼�¼������copy��ѯ��
            '        Dim dtTemp As DataTable = gWs.FetchProjectCorporation(Me._ProCode, Me._CorpCode, "1", "����").Tables("TProjectCorporation")
            '        If Not dtTemp.Rows.Count = 0 Then
            '            Dim dr As DataRow = ds.Tables("TProjectCorporation").NewRow()
            '            dr.ItemArray = dtTemp.Rows(0).ItemArray
            '            With dr
            '                .Item("phase") = Me._Phase
            '                .Item("project_code") = Me._ProCode
            '                .Item("create_person") = UserName
            '                .Item("create_date") = SysDate
            '            End With
            '            ds.Tables("TProjectCorporation").Rows.Add(dr)
            '        Else
            '            Me.CopyFinalConsultaion()
            '        End If
            'End Select
            Me.CopyFinalConsultaion()

        End If
        '�����ȥ����Ŀ��Ϣ            '
        Me.ds.Merge(GetProjRejectCode(Me._CorpCode, Me._ProCode))
        Me.ds.Merge(gWs.GetBankInfo("%", "%"))
        Me.ds.Relations.Add("RBank", Me.ds.Tables("bank").Columns("bank_code"), Me.ds.Tables("rproject").Columns("apply_bank"))
        Me.ds.Tables("rproject").Columns.Add("CBank", GetType(System.String), "parent(RBank).bank_name")

        '������Ϣ
        Me.ds.Merge(gWs.GetCooperateOpinionInfo("", Me._ProCode).Tables("cooperate_organization_opinion"))
        If Me.ds.Tables("cooperate_organization_opinion").Rows.Count = 0 Then
            Dim dr As DataRow = Me.ds.Tables("cooperate_organization_opinion").NewRow()
            dr.Item("project_code") = Me._ProCode
            dr.Item("recommend_sum") = 0
            dr.Item("recommend_date") = gWs.GetSysTime()
            Me.ds.Tables("cooperate_organization_opinion").Rows.Add(dr)
        End If
    End Sub
    '��������������ѯ��Ϣ��������ҵ��Ϣ
    Private Sub CopyFinalConsultaion()
        Dim drProjectCorporation, drConsult, drCorporation As DataRow
        Try
            Dim dt As DataTable = gWs.GetcorporationInfo("null", "{corporation_code = '" & Me._CorpCode & "' ORDER BY serial_num DESC }").Tables("consultation")
            If dt.Rows.Count = 0 Then Return
            drConsult = dt.Rows(0)
            drCorporation = ds.Tables("Corporation").Rows(0)
            Dim nowTime As DateTime = gWs.GetSysTime()
            drProjectCorporation = ds.Tables("TProjectCorporation").NewRow
            With drProjectCorporation
                .Item("district_name") = drConsult.Item("district_name")                '��������
                .Item("register_address") = drConsult.Item("register_address")          'ע���ַ
                .Item("industry_type") = drConsult.Item("industry_type")                '��ҵ����
                .Item("proprietorship_type") = drConsult.Item("proprietorship_type")    '����������
                .Item("total_capital_stock") = drConsult.Item("total_assets")           '���ʲ� 
                .Item("register_capital") = drConsult.Item("register_capital")          'ע���ʱ�
                .Item("contact_person") = drConsult.Item("contact_person")              '��ϵ�� 
                .Item("contact_phone") = drConsult.Item("phone_num")                    '��ϵ�绰
                .Item("fax") = drConsult.Item("fax")                                    '���� 
                .Item("contact_mobile") = drConsult.Item("mobile")                      '��ϵ���ֻ�
                .Item("e_mail") = drConsult.Item("e_mail")                              '��ҵe_mail
                If Not drCorporation.Item("found_date") Is DBNull.Value Then
                    .Item("found_date") = drCorporation.Item("found_date")                  '��������
                Else
                    .Item("found_date") = nowTime                                           '��������
                End If
                If Not drCorporation.Item("found_date") Is DBNull.Value Then
                    .Item("business_start_date") = drCorporation.Item("found_date")                  '��Ӫ��ʼ�� 
                Else
                    .Item("business_start_date") = nowTime                                           '��Ӫ��ʼ��   �����ʧЧ
                End If

                .Item("business_end_date") = drCorporation.Item("business_end_date")       '��Ӫ��ֹ��
                .Item("technology_type") = drCorporation.Item("technology_type")            '�Ƽ�����
                .Item("business_licence_code") = drCorporation.Item("business_licence_code") '��ҵӪҵִ�մ���
                .Item("corp_paper_id") = drCorporation.Item("corp_paper_id")                 '��ҵ���˴���֤����
                .Item("loan_paper_id") = drCorporation.Item("loan_paper_id")                 '����֤����
                .Item("loan_card_id") = drCorporation.Item("loan_card_id")                   '�������
                .Item("legal_representative") = drCorporation.Item("legal_representative")   '���˴���
                .Item("legal_representative_phone") = drCorporation.Item("legal_representative_phone")   '���˵绰
                .Item("legal_representative_mobile") = drCorporation.Item("legal_representative_mobile") '�����ֻ�

            End With
            ds.Tables("TProjectCorporation").Rows.Add(drProjectCorporation)
            ds.AcceptChanges()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private bmProjectCorporation As BindingManagerBase
    Private bmProject As BindingManagerBase
    Private bmCooperate As BindingManagerBase
    Private bmCorporation As BindingManagerBase
    '����Ŀ��Ϣ��
    Protected Overridable Sub GetProjectData()
        Dim binding As Binding
        '��Ŀ��project       
        Me.cboApplyServiceType.DataBindings.Add("SelectedValue", ds, "project.apply_service_type") '����ҵ��Ʒ�� 
        Me.cboApplyBank.DataBindings.Add("SelectedValue", ds, "project.apply_bank")           '�Ƽ�����
        Me.BankChanged(Nothing, Nothing) '����֧��ComboBox������
        Me.cboApplyBranch.DataBindings.Add("SelectedValue", ds, "project.apply_branch_bank")  '�Ƽ�֧��
        binding = New Binding("Text", ds, "project.apply_sum")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtApplySum.DataBindings.Add(binding)                                                       '������
        Me.nuTerm.DataBindings.Add("Text", ds, "project.apply_term")                      '�������� 
        Me.txtPurpose.DataBindings.Add("Text", ds, "project.purpose")                     'Ŀ��
        Me.dtpApplyDate.DataBindings.Add("Text", ds, "project.apply_date")                '�������� 
        Me.cboRecommendType.DataBindings.Add("SelectedValue", ds, "project.recommend_type") '�Ƽ�������
        Select Case Me.cboRecommendType.SelectedValue.ToString()
            Case "Ա������"
                Me.txtRecommendPerson.Visible = False
                Me.cboRecommendItems.Visible = False
            Case "��������"
                Me.cboRecommendItems.DataBindings.Add("SelectedValue", ds, "project.recommend_person")     '�Ƽ���
            Case "��ͷ�ͻ�"
                Me.cboRecommendItems.DataBindings.Add("SelectedValue", ds, "project.recommend_person")     '�Ƽ���
            Case "��������"
                Me.cboRecommendItems.DataBindings.Add("SelectedValue", ds, "project.recommend_person")     '�Ƽ���
            Case Else '������������ҵ
                Me.txtRecommendPerson.DataBindings.Add("Text", ds, "project.recommend_person")     '�Ƽ���
        End Select
        Me.chkIsFirstLoan.DataBindings.Add("Checked", ds, "project.is_first_loan")     '�Ƿ��״δ���

        bmProject = BindingContext(ds, "project")
        AddHandler bmProject.CurrentChanged, AddressOf BindDataChanged

    End Sub
    '����Ŀ��ҵ��Ϣ��
    Protected Overridable Sub GetProjectCorporationData()
        Dim binding As Binding
      
        '��Ŀ��ҵ��project_corporation    
        Me.dtpStartDate.DataBindings.Add("Text", ds, "TProjectCorporation.business_start_date")  '��Ӫ��ʼ��
        Me.dtpEndDate.DataBindings.Add("Text", ds, "TProjectCorporation.business_end_date")      '��Ӫ��ֹ��
        Me.txtCreditLevel.DataBindings.Add("Text", ds, "TProjectCorporation.credit_grade")          '���ŵȼ� 
        Me.txtEvalInstitute.DataBindings.Add("Text", ds, "TProjectCorporation.evaluate_institution") '���ֵ�λ 
        Me.cboAddressRange.DataBindings.Add("SelectedValue", ds, "TProjectCorporation.district_name") '��ַ����������
        Me.txtAddressDetail.DataBindings.Add("Text", ds, "TProjectCorporation.register_address")      '��ַ��ϸ
        Me.cboIndustryType.DataBindings.Add("SelectedValue", ds, "TProjectCorporation.industry_type") '��ҵ����
        Me.cboMoneyType.DataBindings.Add("SelectedValue", ds, "TProjectCorporation.moneyID")          '��������
        If Not ds.Tables("TProjectCorporation").Rows(0).Item("technology_type") Is DBNull.Value Then
            int_TechTypes = ds.Tables("TProjectCorporation").Rows(0).Item("technology_type")              '�Ƽ�����
        Else
            int_TechTypes = 0
        End If
        Me.InitTechType()
        Me.cboProprietorShip.DataBindings.Add("SelectedValue", ds, "TProjectCorporation.proprietorship_type") '����������
        binding = New Binding("Text", ds, "TProjectCorporation.register_capital")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtRegCapital.DataBindings.Add(binding)                              'ע���ʱ�
        binding = New Binding("Text", ds, "TProjectCorporation.invisible_assets")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtInvisibleAssets.DataBindings.Add(binding)                         '�����ʲ�
        binding = New Binding("Text", ds, "TProjectCorporation.real_capital")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtRealCapital.DataBindings.Add(binding)                             'ʵ���ʱ�
        binding = New Binding("Text", ds, "TProjectCorporation.cash_receive")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtCashReceive.DataBindings.Add(binding)                             '�����ʽ�λ

        Me.txtRepresentative.DataBindings.Add("Text", ds, "TProjectCorporation.legal_representative") '����
        Me.txtRepreNation.DataBindings.Add("Text", ds, "TProjectCorporation.nationality")             '���˹���
        Me.txtRepreID.DataBindings.Add("Text", ds, "TProjectCorporation.id_card")                     '�������֤�� 
        Me.txtLegelPhone.DataBindings.Add("Text", ds, "TProjectCorporation.legal_representative_phone")  '���˵绰
        Me.txtLegelMobile.DataBindings.Add("Text", ds, "TProjectCorporation.legal_representative_mobile") '�����ֻ�
        'Me.txtAttorney.DataBindings.Add("Text", ds, "TProjectCorporation.attorney")                  '��Ȩ��
        'Me.txtAttorneyNation.DataBindings.Add("Text", ds, "TProjectCorporation.attorney_nationality")
        Me.txtEmployeeAmount.DataBindings.Add("Text", ds, "TProjectCorporation.employee_amount") 'Ա������
        Me.txtDoctorNum.DataBindings.Add("Text", ds, "TProjectCorporation.docter")            '��ʿ 
        Me.txtMasterNum.DataBindings.Add("Text", ds, "TProjectCorporation.master")            '˶ʿ 
        Me.txtBachelorNum.DataBindings.Add("Text", ds, "TProjectCorporation.bachelor")        '��ѧ
        Me.txtColledgeNum.DataBindings.Add("Text", ds, "TProjectCorporation.college")         '��ר
        Me.txtContactPerson.DataBindings.Add("Text", ds, "TProjectCorporation.contact_person") '��ϵ��
        Me.txtContactNumber.DataBindings.Add("Text", ds, "TProjectCorporation.contact_phone")  '��ϵ�绰
        Me.txtFax.DataBindings.Add("Text", ds, "TProjectCorporation.fax")                      '��ϵ�˴���
        Me.txtContactEmail.DataBindings.Add("Text", ds, "TProjectCorporation.e_mail")          '��ϵ��e-mail
        Me.txtContactMobile.DataBindings.Add("Text", ds, "TProjectCorporation.contact_mobile")

        Me.txtLoanCardID.DataBindings.Add("Text", ds, "TProjectCorporation.loan_card_id")        '����֤����
        Me.txtLoanID.DataBindings.Add("Text", ds, "TProjectCorporation.loan_paper_id")           '����֤����
        Me.txtCorpID.DataBindings.Add("Text", ds, "TProjectCorporation.business_licence_code")   'Ӫҵִ��
        Me.txtRepID.DataBindings.Add("Text", ds, "TProjectCorporation.corp_paper_id")            '���˴���֤����
        If ds.Tables("TProjectCorporation").Rows(0).Item("found_date") Is DBNull.Value Then
            ds.Tables("TProjectCorporation").Rows(0).Item("found_date") = gWs.GetSysTime()
        End If
        'Me.dtpFoundDate.DataBindings.Add("Text", ds, "TProjectCorporation.found_date")           '��������
        Me.bmProjectCorporation = BindingContext(ds, "TProjectCorporation")
        AddHandler bmProjectCorporation.CurrentChanged, AddressOf BindDataChanged
    End Sub

    Protected Sub GetData()
        SysDate = gWs.GetSysTime()

        Me.txtProjectCode.Text = Me._ProCode
        Me.txtCorporationName.Text = Me.getCorporationName()
        Me.txtPhase.Text = _Phase
        Me.dgProject.DataSource = Me.ds.Tables("rproject").DefaultView

        Me.GetProjectData()
        Me.GetProjectCorporationData()

        Dim binding As Binding
        '������Ϣ��cooperate_organization_opinion
        binding = New Binding("Text", ds, "cooperate_organization_opinion.recommend_sum")            '�Ƽ����  
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtRecommendSum.DataBindings.Add(binding)
        Me.txtCooperateOpinion.DataBindings.Add("Text", ds, "cooperate_organization_opinion.opinion")   '�������
        Me.dtpRecommend.DataBindings.Add("Text", ds, "cooperate_organization_opinion.recommend_date")  '�Ƽ�����
        bmCooperate = BindingContext(ds, "cooperate_organization_opinion")
        AddHandler bmCooperate.CurrentChanged, AddressOf BindDataChanged

        Me.tabCoMBase.SelectedTab = Me.pgCorpInfo        '������ʾ��Ϊ��ҵ
    End Sub
    '���㵽�����ַ���
    Protected Sub DecimalToCurrency(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not e.DesiredType Is GetType(String) Then
            Exit Sub
        End If
        If e.Value Is System.DBNull.Value Then
            Exit Sub
        End If
        e.Value = Numeric2Currency(e.Value)
    End Sub
    '�����ַ���������
    Protected Sub CurrencyToDecimal(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not e.DesiredType Is GetType(Decimal) Then
            Exit Sub
        End If
        e.Value = Currency2Numeric(e.Value)
    End Sub
    '���ݸı�
    Protected Sub BindDataChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad Then
            bIsChanged = True
        End If
    End Sub
#End Region

#Region "���沿��"

    Protected Overridable Function Save() As Boolean
        Try
            If Not Me.CheckData() Then
                Return False
            End If
            If Not Me.SaveProjectCorporation() Then
                Return False
            End If
            If Not Me.SaveProject() Then
                Return False
            End If
            If Not Me.SaveCorporation() Then
                Return False
            End If
            If Not Me.SaveCooperate() Then
                Return False
            End If
            Me.bIsChanged = False       '����ɹ�
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '����У�� �ɹ�������
    Protected Overridable Function CheckData() As Boolean
        '��Ա�������������ڴ�ר�������ơ�˶ʿ����ʿ֮��
        Dim reg As New System.Text.RegularExpressions.Regex("^\d+$")
        Dim EmployeeAmount, ColledgeNum, BachelorNum, Masternum, DoctorNum As Integer
        EmployeeAmount = CInt(IIf(reg.Match(Me.txtEmployeeAmount.Text).Success, reg.Match(Me.txtEmployeeAmount.Text).Value, 0))
        ColledgeNum = CInt(IIf(reg.Match(Me.txtColledgeNum.Text).Success, reg.Match(Me.txtColledgeNum.Text).Value, 0))
        BachelorNum = CInt(IIf(reg.Match(Me.txtBachelorNum.Text).Success, reg.Match(Me.txtBachelorNum.Text).Value, 0))
        Masternum = CInt(IIf(reg.Match(Me.txtMasterNum.Text).Success, reg.Match(Me.txtMasterNum.Text).Value, 0))
        DoctorNum = CInt(IIf(reg.Match(Me.txtDoctorNum.Text).Success, reg.Match(Me.txtDoctorNum.Text).Value, 0))

        If EmployeeAmount < ColledgeNum + BachelorNum + Masternum + DoctorNum Then
            'MessageBox.Show("�����Ա�����������벻��С�ڴ�ר�����ƣ�˶ʿ����ʿ������֮�͡�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1008", "Ա��������", "��ר�����ƣ�˶ʿ����ʿ������֮��")
            Me.txtEmployeeAmount.Focus()
            Return False
        End If
        If Me.cboRecommendType.SelectedValue.ToString() = "��������" And Me.cboRecommendItems.Text = "" Then
            SWDialogBox.MessageBox.Show("$1007", "��������")
            Return False
        End If
        Return True
    End Function
    '����project_corporation��
    Private Function SaveProjectCorporation() As Boolean
        dsTemp = gWs.FetchProjectCorporation(_ProCode, Me._CorpCode, "1", _Phase)
        If Not dsTemp.Tables("TProjectCorporation").Rows.Count = 0 Then
            With dsTemp.Tables("TProjectCorporation").Rows(0)
                .Item("business_start_date") = Me.dtpStartDate.Value
                .Item("business_end_date") = Me.dtpEndDate.Value
                .Item("district_name") = Me.cboAddressRange.Text
                .Item("register_address") = Me.txtAddressDetail.Text
                .Item("industry_type") = Me.cboIndustryType.Text
                .Item("moneyID") = Me.cboMoneyType.SelectedValue  '��������
                .Item("proprietorship_type") = Me.cboProprietorShip.Text
                .Item("technology_type") = Me.int_TechTypes

                .Item("loan_paper_id") = Me.txtLoanID.Text
                .Item("loan_card_id") = Me.txtLoanCardID.Text
                .Item("business_licence_code") = Me.txtCorpID.Text
                .Item("corp_paper_id") = Me.txtRepID.Text

                .Item("credit_grade") = Me.txtCreditLevel.Text
                .Item("evaluate_institution") = Me.txtEvalInstitute.Text

                .Item("register_capital") = Currency2Double(Me.txtRegCapital.Text)
                .Item("real_capital") = Currency2Double(Me.txtRealCapital.Text)
                .Item("cash_receive") = Currency2Double(Me.txtCashReceive.Text)
                .Item("invisible_assets") = Currency2Double(Me.txtInvisibleAssets.Text)

                .Item("legal_representative") = Me.txtRepresentative.Text '����
                .Item("nationality") = Me.txtRepreNation.Text '���˹���
                .Item("id_card") = Me.txtRepreID.Text '�������֤��
                .Item("legal_representative_phone") = Me.txtLegelPhone.Text '���˵绰
                .Item("legal_representative_mobile") = Me.txtLegelMobile.Text '�����ֻ�

                If Me.txtEmployeeAmount.Text <> "" Then
                    .Item("employee_amount") = Int32.Parse(Me.txtEmployeeAmount.Text)
                End If
                If Me.txtColledgeNum.Text <> "" Then
                    .Item("college") = Int32.Parse(Me.txtColledgeNum.Text)
                End If
                If Me.txtBachelorNum.Text <> "" Then
                    .Item("bachelor") = Int32.Parse(Me.txtBachelorNum.Text)
                End If
                If Me.txtMasterNum.Text <> "" Then
                    .Item("master") = Int32.Parse(Me.txtMasterNum.Text)
                End If
                If Me.txtDoctorNum.Text <> "" Then
                    .Item("docter") = Int32.Parse(Me.txtDoctorNum.Text)
                End If
                .Item("contact_person") = Me.txtContactPerson.Text '��ϵ��
                .Item("contact_phone") = Me.txtContactNumber.Text '��ϵ�绰
                .Item("fax") = Me.txtFax.Text                    '��ϵ�˴���
                .Item("e_mail") = Me.txtContactEmail.Text '��ϵ�绰
                .Item("contact_mobile") = Me.txtContactMobile.Text '��ϵ���ֻ�
                If Me.ds.Tables("TProjectCorporation").Rows.Count > 0 Then
                    .Item("found_date") = Me.ds.Tables("TProjectCorporation").Rows(0)("found_date")
                End If
                .Item("create_person") = UserName
                .Item("create_date") = SysDate
            End With
        Else
            Dim dr As DataRow = dsTemp.Tables("TProjectCorporation").NewRow()
            With dr
                .Item("project_code") = _ProCode
                .Item("corporation_code") = Me._CorpCode
                .Item("phase") = _Phase
                .Item("corporation_name") = MyBase.getCorporationName

                '.Item("relation") = Me.txtRelation.Text
                .Item("corporation_type") = "1"
                .Item("business_start_date") = Me.dtpStartDate.Value
                .Item("business_end_date") = Me.dtpEndDate.Value

                .Item("district_name") = Me.cboAddressRange.Text
                .Item("register_address") = Me.txtAddressDetail.Text
                .Item("industry_type") = Me.cboIndustryType.Text
                .Item("moneyID") = Me.cboMoneyType.SelectedValue  '��������
                .Item("proprietorship_type") = Me.cboProprietorShip.Text
                .Item("technology_type") = Me.int_TechTypes

                .Item("loan_paper_id") = Me.txtLoanID.Text
                .Item("loan_card_id") = Me.txtLoanCardID.Text
                .Item("business_licence_code") = Me.txtCorpID.Text
                .Item("corp_paper_id") = Me.txtRepID.Text

                .Item("credit_grade") = Me.txtCreditLevel.Text
                .Item("evaluate_institution") = Me.txtEvalInstitute.Text

                .Item("register_capital") = Currency2Double(Me.txtRegCapital.Text)
                .Item("real_capital") = Currency2Double(Me.txtRealCapital.Text)
                .Item("cash_receive") = Currency2Double(Me.txtCashReceive.Text)
                .Item("invisible_assets") = Currency2Double(Me.txtInvisibleAssets.Text)

                .Item("legal_representative") = Me.txtRepresentative.Text '����
                .Item("nationality") = Me.txtRepreNation.Text '���˹���
                .Item("id_card") = Me.txtRepreID.Text '�������֤��
                .Item("legal_representative_phone") = Me.txtLegelPhone.Text '���˵绰
                .Item("legal_representative_mobile") = Me.txtLegelMobile.Text '�����ֻ�

                If Me.txtEmployeeAmount.Text <> "" Then
                    .Item("employee_amount") = Int32.Parse(Me.txtEmployeeAmount.Text)
                End If
                If Me.txtColledgeNum.Text <> "" Then
                    .Item("college") = Int32.Parse(Me.txtColledgeNum.Text)
                End If
                If Me.txtBachelorNum.Text <> "" Then
                    .Item("bachelor") = Int32.Parse(Me.txtBachelorNum.Text)
                End If
                If Me.txtMasterNum.Text <> "" Then
                    .Item("master") = Int32.Parse(Me.txtMasterNum.Text)
                End If
                If Me.txtDoctorNum.Text <> "" Then
                    .Item("docter") = Int32.Parse(Me.txtDoctorNum.Text)
                End If
                .Item("contact_person") = Me.txtContactPerson.Text '��ϵ��
                .Item("contact_phone") = Me.txtContactNumber.Text '��ϵ�绰
                .Item("fax") = Me.txtFax.Text                    '��ϵ�˴���
                .Item("e_mail") = Me.txtContactEmail.Text '��ϵ�绰
                .Item("contact_mobile") = Me.txtContactMobile.Text '��ϵ���ֻ�
                If Me.ds.Tables("TProjectCorporation").Rows.Count > 0 Then
                    .Item("found_date") = Me.ds.Tables("TProjectCorporation").Rows(0)("found_date")
                End If
                .Item("create_person") = UserName
                .Item("create_date") = SysDate
            End With
            dsTemp.Tables("TProjectCorporation").Rows.Add(dr)
        End If

        Dim strResult As String = gWs.UpdateProjectCorporation(dsTemp)
        If Not strResult = "1" Then
            SWDialogBox.MessageBox.Show("*999", "������Ŀ��ҵ��Ϣʧ��", strResult, "")
            Return False
        Else
            Me.ds.Tables("TProjectCorporation").AcceptChanges()
            Return True
        End If
    End Function
    '����project��
    Private Function SaveProject() As Boolean
        dsTemp = gWs.GetProjectInfo("{project_code='" + Me._ProCode + "'}")
        If Not dsTemp.Tables("project").Rows.Count = 0 Then
            With dsTemp.Tables("project").Rows(0)
                .Item("project_code") = _ProCode
                .Item("corporation_code") = Me._CorpCode
                .Item("phase") = _Phase
                .Item("recommend_type") = Me.cboRecommendType.Text
                .Item("recommend_person") = Me.GetRecommendPerson()
                .Item("apply_service_type") = Me.cboApplyServiceType.SelectedValue
                .Item("apply_bank") = Me.cboApplyBank.SelectedValue
                If Me.cboApplyBranch.Text <> "" Then
                    .Item("apply_branch_bank") = Me.cboApplyBranch.SelectedValue
                Else
                    .Item("apply_branch_bank") = System.DBNull.Value
                End If
                Try
                    .Item("apply_sum") = Currency2Double(Me.txtApplySum.Text)
                Catch
                End Try
                .Item("purpose") = Me.txtPurpose.Text
                .Item("apply_term") = Me.nuTerm.Text
                .Item("apply_date") = Me.dtpApplyDate.Text
                .Item("is_first_loan") = Me.chkIsFirstLoan.Checked
                '.Item("create_person") = UserName
                '.Item("create_date") = SysDate.Date
            End With
        End If
        Dim strResult As String = gWs.UpdateProject(dsTemp)
        If strResult <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "������Ŀ��Ϣʧ��", strResult, "")
            Return False
        Else
            Me.ds.Tables("project").AcceptChanges()
            Return True
        End If
    End Function
    '����corporation��
    Private Function SaveCorporation() As Boolean
        dsTemp = gWs.GetcorporationInfo("{corporation_code='" + Me._CorpCode + "'}", "null")
        If Not dsTemp.Tables("corporation").Rows.Count = 0 Then
            With dsTemp.Tables("corporation").Rows(0)
                .Item("loan_paper_id") = Me.txtLoanID.Text
                .Item("loan_card_id") = Me.txtLoanCardID.Text
                .Item("business_end_date") = Me.dtpEndDate.Value                     '��Ӫ��ֹ��
                .Item("business_licence_code") = Me.txtCorpID.Text
                .Item("corp_paper_id") = Me.txtRepID.Text
                '.Item("found_date") = Me.dtpFoundDate.Value
                'Below Patch Modified By Xiaojun 2003-6-26
                '������ϵ����ϵ��ʽ�ͷ�����������ϵ��ʽ��
                .Item("contact_person") = Me.txtContactPerson.Text.Trim()
                .Item("phone_num") = Me.txtContactNumber.Text.Trim()
                .Item("mobile") = Me.txtContactMobile.Text.Trim()
                .Item("e_mail") = Me.txtContactEmail.Text.Trim()
                .Item("fax") = Me.txtFax.Text.Trim()
                .Item("legal_representative") = Me.txtRepresentative.Text.Trim()
                .Item("legal_representative_mobile") = Me.txtLegelMobile.Text.Trim()
                .Item("legal_representative_phone") = Me.txtLegelPhone.Text.Trim()

                .Item("district_name") = Me.cboAddressRange.Text
                .Item("register_address") = Me.txtAddressDetail.Text
                .Item("proprietorship_type") = Me.cboProprietorShip.Text
                .Item("industry_type") = Me.cboIndustryType.Text
                .Item("technology_type") = Me.int_TechTypes
            End With
        End If
        Dim strResult As String = gWs.UpdateCorCon(dsTemp)
        If Not strResult = "1" Then
            SWDialogBox.MessageBox.Show("*999", "��ҵ��Ϣ����ʧ��", strResult, "")
            Return False
        Else
            Return True
        End If
    End Function
    '����������cooperate_organization_opinion��
    Private Function SaveCooperate() As Boolean
        Dim strResult As String
        Try
            If Me.cboRecommendType.SelectedValue.ToString() = "��������" Then  '�Ƽ�����Ϊ������
                dsTemp = gWs.GetCooperateOpinionInfo("null", Me.getProjectCode())
                If Not dsTemp.Tables("cooperate_organization_opinion").Rows.Count = 0 Then
                    With dsTemp.Tables("cooperate_organization_opinion").Rows(0)
                        .Item("cooperate_organization") = Me.cboRecommendItems.Text
                        Try
                            .Item("recommend_sum") = Currency2Double(Me.txtRecommendSum.Text)
                        Catch
                            .Item("recommend_sum") = 0
                        End Try
                        .Item("opinion") = Me.txtCooperateOpinion.Text
                        .Item("recommend_date") = Me.dtpRecommend.Value

                        .Item("create_person") = UserName
                        .Item("create_date") = gWs.GetSysTime()
                    End With
                Else
                    Dim dr As DataRow
                    dr = dsTemp.Tables("cooperate_organization_opinion").NewRow()
                    With dr
                        .Item("project_code") = Me.getProjectCode()
                        .Item("cooperate_organization") = Me.cboRecommendItems.Text
                        Try
                            .Item("recommend_sum") = Currency2Double(Me.txtRecommendSum.Text)
                        Catch
                            .Item("recommend_sum") = 0
                        End Try
                        .Item("opinion") = Me.txtCooperateOpinion.Text
                        .Item("recommend_date") = Me.dtpRecommend.Value

                        .Item("create_person") = UserName
                        .Item("create_date") = gWs.GetSysTime()
                    End With
                    dsTemp.Tables("cooperate_organization_opinion").Rows.Add(dr)
                End If

                strResult = gWs.UpdateCooperateOpinion(dsTemp)
                If Not strResult = "1" Then
                    SWDialogBox.MessageBox.Show("*999", "����������ʧ��", strResult, "�������")
                    Return False
                Else
                    Me.ds.Tables("cooperate_organization_opinion").AcceptChanges()
                    Return True
                End If
            Else
                dsTemp = gWs.GetCooperateOpinionInfo("null", Me.getProjectCode())
                If Not dsTemp.Tables("cooperate_organization_opinion").Rows.Count = 0 Then
                    dsTemp.Tables("cooperate_organization_opinion").Rows(0).Delete()
                End If
                If dsTemp.HasChanges Then
                    strResult = gWs.UpdateCooperateOpinion(dsTemp)
                    If strResult <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "����������ʧ��", strResult, "�������")
                        Return False
                    End If
                End If
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

#End Region

#Region "�ԿƼ������Լ��������Ĵ���"

    Protected int_TechTypes As Integer = 0  '�Ƽ�����
    '��ʼ���Ƽ�����CheckedListBox
    Protected Sub InitTechType()
        Dim tempChanged As Boolean = Me.bIsChanged
        Me.clbTechType.ClearSelected()
        Dim i As Integer
        Dim choose As Integer

        For i = 0 To Me.clbTechType.Items.Count - 1
            'ѡ������
            choose = CType(CType(Me.clbTechType.Items(i), DataRowView).Item("technology_type_code"), Integer)
            'ȷ��ѡ������
            If int_TechTypes And choose Then
                Me.clbTechType.SetItemCheckState(i, CheckState.Checked)
            Else
                Me.clbTechType.SetItemCheckState(i, CheckState.Unchecked)
            End If
        Next
        Me.bIsChanged = tempChanged
    End Sub
    'ѡ��Ƽ����ͺ����ÿƼ����͵�ֵ
    Public Sub clbTechType_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbTechType.ItemCheck
        Dim val As Integer = CType(CType(Me.clbTechType.Items(e.Index), DataRowView).Item("technology_type_code"), Integer)  '��ǰѡ�����ֵ
        If e.NewValue Then
            int_TechTypes = (int_TechTypes Or val)
        Else
            int_TechTypes = (int_TechTypes And Not val)
        End If
        If Me.bFormLoad Then
            Me.bIsChanged = True
        End If
    End Sub
    'ȡ��CheckedListBox�����ѡ��״̬
    Protected Sub clbTechType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles clbTechType.Leave
        Dim i As Integer
        For i = 0 To Me.clbTechType.Items.Count - 1
            Me.clbTechType.SetSelected(i, False)
        Next
    End Sub

    Private bTabChanged As Boolean = False '����TabPage��index�仯�󣬲���Ҫ�ĳ�ʼ��
    '���ú�������ѡ����״̬
    Private Sub cboRecommendType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRecommendType.SelectedIndexChanged
        If Me.bTabChanged Then
            Me.dtpRecommend.Enabled = False
            Me.txtRecommendSum.Enabled = False
            Me.txtCooperateOpinion.Enabled = False

            Select Case Me.cboRecommendType.SelectedValue.ToString()
                Case "Ա������"
                    Me.txtRecommendPerson.Visible = False
                    Me.cboRecommendItems.Visible = False
                Case "��������"
                    Me.txtRecommendPerson.Visible = False
                    Me.cboRecommendItems.Visible = True
                    Me.cboRecommendItems.DataSource = BankDS.Tables("bank")
                    Me.cboRecommendItems.DisplayMember = "bank_name"
                    Me.cboRecommendItems.ValueMember = "bank_name"
                Case "��ͷ�ͻ�"
                    Me.txtRecommendPerson.Visible = False
                    Me.cboRecommendItems.Visible = True
                    Me.cboRecommendItems.DataSource = StaffDS.Tables("TStaff")
                    Me.cboRecommendItems.DisplayMember = "staff_name"
                    Me.cboRecommendItems.ValueMember = "staff_name"
                Case "��������"
                    Me.txtRecommendPerson.Visible = False
                    Me.cboRecommendItems.Visible = True
                    Me.cboRecommendItems.DataSource = CooperatorInfoDS.Tables("cooperate_organization")
                    Me.cboRecommendItems.DisplayMember = "cooperate_organization"
                    Me.cboRecommendItems.ValueMember = "cooperate_organization"
                    Me.dtpRecommend.Enabled = True
                    Me.txtRecommendSum.Enabled = True
                    Me.txtCooperateOpinion.Enabled = True
                Case Else '������������ҵ
                    Me.txtRecommendPerson.Visible = True
                    Me.cboRecommendItems.Visible = False
            End Select
            If Me.bFormLoad Then
                Me.bIsChanged = True
            End If
        End If
    End Sub
    '��ȡ��������(�п����������������ߺ�������)
    Protected Function GetRecommendPerson() As String
        Select Case Me.cboRecommendType.SelectedValue.ToString()
            Case "Ա������"
                Return ""
            Case "��������"
                Return Me.cboRecommendItems.Text
            Case "��ͷ�ͻ�"
                Return Me.cboRecommendItems.Text
            Case "��������"
                Return Me.cboRecommendItems.Text
            Case Else '������������ҵ
                Return Me.txtRecommendPerson.Text
        End Select
    End Function

    'tabpage�仯ʱ�����ÿƼ�����CheckListBox   
    Private Sub tabReview_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabCoMBase.SelectedIndexChanged
        If tabCoMBase.SelectedIndex = 1 Then
            RemoveHandler cboRecommendType.SelectedIndexChanged, AddressOf cboRecommendType_SelectedIndexChanged
            Me.bTabChanged = False
            Me.InitTechType()
        ElseIf tabCoMBase.SelectedIndex = 0 Then
            AddHandler cboRecommendType.SelectedIndexChanged, AddressOf cboRecommendType_SelectedIndexChanged
            Me.bTabChanged = True
        Else
            RemoveHandler cboRecommendType.SelectedIndexChanged, AddressOf cboRecommendType_SelectedIndexChanged
            Me.bTabChanged = False
        End If
    End Sub

#End Region

    Protected Overridable Function HasReport(ByVal item_code As String, ByVal item_type As String) As Boolean
        Dim dsTemp As DataSet = gWs.GetProjectFile(Me._ProCode, item_code, item_type)
        Dim i As Integer
        For i = 0 To dsTemp.Tables("TProjectFile").Rows.Count - 1
            If Not IsDBNull(dsTemp.Tables("TProjectFile").Rows(0).Item("relation_num")) Then
                Return True
            End If
        Next

        Return False
    End Function

    Protected Sub AnalisisFinance(ByVal ProjectCode As String, ByVal CorporationCode As String, ByVal Phase As String)
        Try
            '���в������֮ǰ���в��������жϣ����û�в����������ܽ��в��������
            Dim dsTemp As DataSet
            dsTemp = gWs.GetAccount("{project_code like '" & ProjectCode & "' and phase like '" & Phase & "'}")
            If dsTemp.Tables(0).Rows.Count = 0 Then
                'MessageBox.Show("�в����ڸ���Ŀ�ĳ���������ݣ��޷����в��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)'*999
                SWDialogBox.MessageBox.Show("$1007", Phase & "��������")
                Return
            End If
            Dim frm As New FFinancialAnalysis()
            frm.SetEditState(False)
            frm.ShowDialog(ProjectCode, CorporationCode, Phase)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '(((�жϸ���Ŀ��ǰһ����û�н������Ŷ������֡�))    '�ж��Ƿ���в������
    Protected Function hasFinanceAnalysis(ByVal ProjectCode As String, ByVal Phase As String) As Boolean
        If Not gWs.GetCommonQueryInfo("SELECT TOP 1 * FROM Project_Finance_Analyse WHERE project_code = '" & ProjectCode & "' AND phase = '" & _
                Phase & "' AND corporation_code = '" & Me._CorpCode & "'").Tables(0).Rows.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    '�Խ���س����Ĵ���
    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If Me.ActiveControl.GetType() Is GetType(TextBox) Then
            Dim txt As TextBox = CType(Me.ActiveControl, TextBox)
            If txt.Multiline = True Then            '�Զ���TextBox����
                Return False
            End If
        End If
        If keyData = Keys.Enter And Not Me.ActiveControl.GetType() Is GetType(Button) Then '��������search
            SendKeys.Send("{TAB}")
        End If
        MyBase.ProcessDialogKey(keyData)
        Return False
    End Function

End Class