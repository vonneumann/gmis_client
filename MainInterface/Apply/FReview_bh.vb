
'���ʱ�������
Public Class FReview_bh
    Inherits MainInterface.FReviewBase

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
    Public WithEvents pgGuaranteeLetter As System.Windows.Forms.TabPage
    Friend WithEvents grpGuaranteeLetter As System.Windows.Forms.GroupBox
    Friend WithEvents lblBeneficiaryIntroduction As System.Windows.Forms.Label
    Friend WithEvents lblCounterclaimCondition As System.Windows.Forms.Label
    Friend WithEvents lblImplementAbility As System.Windows.Forms.Label
    Friend WithEvents lblProjectContent As System.Windows.Forms.Label
    Friend WithEvents lblProjectName As System.Windows.Forms.Label
    Friend WithEvents txtCounterclaimCondition As System.Windows.Forms.TextBox
    Friend WithEvents txtBeneficiaryIntroduction As System.Windows.Forms.TextBox
    Friend WithEvents txtImplementAbility As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectContent As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkflow As System.Windows.Forms.TextBox
    Friend WithEvents txtBeneficiary As System.Windows.Forms.TextBox
    Friend WithEvents cboGuaranteeLetterType As System.Windows.Forms.ComboBox
    Friend WithEvents cboReimburseType As System.Windows.Forms.ComboBox
    Friend WithEvents lblWorkflow As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeLetterType As System.Windows.Forms.Label
    Friend WithEvents lblReimburseType As System.Windows.Forms.Label
    Friend WithEvents lblBeneficiary As System.Windows.Forms.Label
    Friend WithEvents pgOpinion As System.Windows.Forms.TabPage
    Friend WithEvents grpOpinion As System.Windows.Forms.GroupBox
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents MenuItemAnalyze As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemGuarantee As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPersonAssure As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImportCorp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImportFinance As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FReview_bh))
        Me.pgGuaranteeLetter = New System.Windows.Forms.TabPage
        Me.grpGuaranteeLetter = New System.Windows.Forms.GroupBox
        Me.lblBeneficiaryIntroduction = New System.Windows.Forms.Label
        Me.lblCounterclaimCondition = New System.Windows.Forms.Label
        Me.lblImplementAbility = New System.Windows.Forms.Label
        Me.lblProjectContent = New System.Windows.Forms.Label
        Me.lblProjectName = New System.Windows.Forms.Label
        Me.txtCounterclaimCondition = New System.Windows.Forms.TextBox
        Me.txtBeneficiaryIntroduction = New System.Windows.Forms.TextBox
        Me.txtImplementAbility = New System.Windows.Forms.TextBox
        Me.txtProjectContent = New System.Windows.Forms.TextBox
        Me.txtProjectName = New System.Windows.Forms.TextBox
        Me.txtWorkflow = New System.Windows.Forms.TextBox
        Me.txtBeneficiary = New System.Windows.Forms.TextBox
        Me.cboGuaranteeLetterType = New System.Windows.Forms.ComboBox
        Me.cboReimburseType = New System.Windows.Forms.ComboBox
        Me.lblWorkflow = New System.Windows.Forms.Label
        Me.lblGuaranteeLetterType = New System.Windows.Forms.Label
        Me.lblReimburseType = New System.Windows.Forms.Label
        Me.lblBeneficiary = New System.Windows.Forms.Label
        Me.pgOpinion = New System.Windows.Forms.TabPage
        Me.grpOpinion = New System.Windows.Forms.GroupBox
        Me.txtOpinion = New System.Windows.Forms.TextBox
        Me.MenuItemAnalyze = New System.Windows.Forms.MenuItem
        Me.MenuItemGuarantee = New System.Windows.Forms.MenuItem
        Me.mnuPersonAssure = New System.Windows.Forms.MenuItem
        Me.mnuImportCorp = New System.Windows.Forms.MenuItem
        Me.mnuImportFinance = New System.Windows.Forms.MenuItem
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgProject.SuspendLayout()
        Me.grpProjectPassed.SuspendLayout()
        Me.grpRequest.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProjectHeader.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgGuaranteeLetter.SuspendLayout()
        Me.grpGuaranteeLetter.SuspendLayout()
        Me.pgOpinion.SuspendLayout()
        Me.grpOpinion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.Name = "lblCorpRepreCardID"
        '
        'lblCorpRealAsset
        '
        Me.lblCorpRealAsset.Name = "lblCorpRealAsset"
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.Location = New System.Drawing.Point(256, 208)
        Me.lblCorpCashArrived.Name = "lblCorpCashArrived"
        '
        'lblCorpBusinessStartDate
        '
        Me.lblCorpBusinessStartDate.Location = New System.Drawing.Point(264, 24)
        Me.lblCorpBusinessStartDate.Name = "lblCorpBusinessStartDate"
        '
        'lblCorpBusinessEndDate
        '
        Me.lblCorpBusinessEndDate.Name = "lblCorpBusinessEndDate"
        '
        'lblCorpRegisterAsset
        '
        Me.lblCorpRegisterAsset.Name = "lblCorpRegisterAsset"
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemAnalyze, Me.MenuItemGuarantee, Me.mnuPersonAssure})
        '
        'cboApplyServiceType
        '
        Me.cboApplyServiceType.DropDownWidth = 184
        Me.cboApplyServiceType.Enabled = False
        Me.cboApplyServiceType.ItemHeight = 12
        Me.cboApplyServiceType.Location = New System.Drawing.Point(88, 46)
        Me.cboApplyServiceType.Name = "cboApplyServiceType"
        Me.cboApplyServiceType.Size = New System.Drawing.Size(160, 20)
        '
        'cboApplyBranch
        '
        Me.cboApplyBranch.ItemHeight = 12
        Me.cboApplyBranch.Name = "cboApplyBranch"
        Me.cboApplyBranch.Size = New System.Drawing.Size(184, 20)
        '
        'lblCorpCreditLevel
        '
        Me.lblCorpCreditLevel.Name = "lblCorpCreditLevel"
        '
        'cboApplyBank
        '
        Me.cboApplyBank.DropDownWidth = 184
        Me.cboApplyBank.ItemHeight = 12
        Me.cboApplyBank.Name = "cboApplyBank"
        Me.cboApplyBank.Size = New System.Drawing.Size(152, 20)
        '
        'cboRecommendType
        '
        Me.cboRecommendType.Name = "cboRecommendType"
        Me.cboRecommendType.Size = New System.Drawing.Size(80, 20)
        '
        'cboMainServiceType
        '
        Me.cboMainServiceType.DropDownWidth = 128
        Me.cboMainServiceType.Location = New System.Drawing.Point(256, 231)
        Me.cboMainServiceType.Name = "cboMainServiceType"
        Me.cboMainServiceType.Size = New System.Drawing.Size(240, 21)
        '
        'cboProprietorShip
        '
        Me.cboProprietorShip.DropDownWidth = 288
        Me.cboProprietorShip.Name = "cboProprietorShip"
        Me.cboProprietorShip.Size = New System.Drawing.Size(288, 21)
        '
        'cboIndustryType
        '
        Me.cboIndustryType.DropDownWidth = 240
        Me.cboIndustryType.Name = "cboIndustryType"
        '
        'cboAddressRange
        '
        Me.cboAddressRange.DropDownWidth = 128
        Me.cboAddressRange.Name = "cboAddressRange"
        '
        'lblMainServiceType
        '
        Me.lblMainServiceType.Location = New System.Drawing.Point(192, 233)
        Me.lblMainServiceType.Name = "lblMainServiceType"
        '
        'lblContactEmail
        '
        Me.lblContactEmail.Name = "lblContactEmail"
        '
        'txtProjectPhase
        '
        Me.txtProjectPhase.Name = "txtProjectPhase"
        '
        'lblCorpRepreNation
        '
        Me.lblCorpRepreNation.Name = "lblCorpRepreNation"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Name = "txtCorporationName"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'lblRecommend
        '
        Me.lblRecommend.Name = "lblRecommend"
        '
        'lblPurpose
        '
        Me.lblPurpose.Name = "lblPurpose"
        '
        'lblLegelMobile
        '
        Me.lblLegelMobile.Name = "lblLegelMobile"
        '
        'lblLegelPhone
        '
        Me.lblLegelPhone.Name = "lblLegelPhone"
        '
        'lblContactMobile
        '
        Me.lblContactMobile.Name = "lblContactMobile"
        '
        'dgProject
        '
        Me.dgProject.AccessibleName = "DataGrid"
        Me.dgProject.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgProject.Name = "dgProject"
        Me.dgProject.Size = New System.Drawing.Size(756, 220)
        '
        'lblAttachBancholer
        '
        Me.lblAttachBancholer.Location = New System.Drawing.Point(512, 328)
        Me.lblAttachBancholer.Name = "lblAttachBancholer"
        '
        'lblAttachDoctor
        '
        Me.lblAttachDoctor.Location = New System.Drawing.Point(512, 352)
        Me.lblAttachDoctor.Name = "lblAttachDoctor"
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageIndex = -1
        Me.btnReport.ImageList = Nothing
        Me.btnReport.Location = New System.Drawing.Point(205, 512)
        Me.btnReport.Name = "btnReport"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(338, 512)
        Me.btnSave.Name = "btnSave"
        '
        'lblCorpRepreID
        '
        Me.lblCorpRepreID.Name = "lblCorpRepreID"
        Me.lblCorpRepreID.Size = New System.Drawing.Size(104, 16)
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Image)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(426, 512)
        Me.btnCommit.Name = "btnCommit"
        '
        'cboRecommendItems
        '
        Me.cboRecommendItems.ItemHeight = 12
        Me.cboRecommendItems.Name = "cboRecommendItems"
        Me.cboRecommendItems.Size = New System.Drawing.Size(104, 20)
        '
        'txtCooperateOpinion
        '
        Me.txtCooperateOpinion.Name = "txtCooperateOpinion"
        Me.txtCooperateOpinion.Size = New System.Drawing.Size(656, 56)
        '
        'mnuImportHistory
        '
        Me.mnuImportHistory.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuImportCorp, Me.mnuImportFinance})
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownWidth = 144
        Me.cboMoneyType.ItemHeight = 12
        Me.cboMoneyType.Name = "cboMoneyType"
        Me.cboMoneyType.Size = New System.Drawing.Size(144, 21)
        '
        'lblMoneyType
        '
        Me.lblMoneyType.Name = "lblMoneyType"
        '
        'pgProject
        '
        Me.pgProject.Name = "pgProject"
        Me.pgProject.Size = New System.Drawing.Size(762, 419)
        '
        'lblCorpRepre
        '
        Me.lblCorpRepre.Name = "lblCorpRepre"
        '
        'grpProjectPassed
        '
        Me.grpProjectPassed.Location = New System.Drawing.Point(0, 0)
        Me.grpProjectPassed.Name = "grpProjectPassed"
        Me.grpProjectPassed.Size = New System.Drawing.Size(762, 240)
        '
        'grpRequest
        '
        Me.grpRequest.Location = New System.Drawing.Point(0, 195)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Size = New System.Drawing.Size(762, 224)
        '
        'lblCorpInvisibleAsset
        '
        Me.lblCorpInvisibleAsset.Name = "lblCorpInvisibleAsset"
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        '
        'txtPurpose
        '
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.TabStop = True
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Value = New Date(2003, 12, 1, 15, 53, 21, 15)
        '
        'nuTerm
        '
        Me.nuTerm.Name = "nuTerm"
        '
        'txtApplySum
        '
        Me.txtApplySum.Name = "txtApplySum"
        '
        'dtpRecommend
        '
        Me.dtpRecommend.Name = "dtpRecommend"
        Me.dtpRecommend.Value = New Date(2003, 12, 1, 15, 53, 20, 953)
        '
        'txtRecommendSum
        '
        Me.txtRecommendSum.Name = "txtRecommendSum"
        '
        'pgCorpInfo
        '
        Me.pgCorpInfo.Name = "pgCorpInfo"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(352, 22)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpStartDate.Value = New Date(2003, 12, 1, 15, 53, 20, 703)
        '
        'txtColledgeNum
        '
        Me.txtColledgeNum.Name = "txtColledgeNum"
        Me.txtColledgeNum.Size = New System.Drawing.Size(144, 21)
        '
        'txtBachelorNum
        '
        Me.txtBachelorNum.Location = New System.Drawing.Point(600, 326)
        Me.txtBachelorNum.Name = "txtBachelorNum"
        Me.txtBachelorNum.Size = New System.Drawing.Size(144, 21)
        '
        'txtMasterNum
        '
        Me.txtMasterNum.Name = "txtMasterNum"
        Me.txtMasterNum.Size = New System.Drawing.Size(144, 21)
        '
        'txtDoctorNum
        '
        Me.txtDoctorNum.Location = New System.Drawing.Point(600, 350)
        Me.txtDoctorNum.Name = "txtDoctorNum"
        Me.txtDoctorNum.Size = New System.Drawing.Size(144, 21)
        '
        'txtEmployeeAmount
        '
        Me.txtEmployeeAmount.Name = "txtEmployeeAmount"
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Location = New System.Drawing.Point(9, 0)
        Me.grpProjectHeader.Name = "grpProjectHeader"
        Me.grpProjectHeader.Text = ""
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Name = "lblProjectPhase"
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Name = "lblCorporationName"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Name = "lblProjectCode"
        '
        'grpProjectBody
        '
        Me.grpProjectBody.Location = New System.Drawing.Point(9, 48)
        Me.grpProjectBody.Name = "grpProjectBody"
        Me.grpProjectBody.Size = New System.Drawing.Size(776, 464)
        '
        'lblProjectRequestDate
        '
        Me.lblProjectRequestDate.Name = "lblProjectRequestDate"
        '
        'lblProjectRequestServiceType
        '
        Me.lblProjectRequestServiceType.Name = "lblProjectRequestServiceType"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(600, 22)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpEndDate.Value = New Date(2003, 12, 1, 15, 53, 20, 718)
        '
        'lblProjectRequestBranch
        '
        Me.lblProjectRequestBranch.Name = "lblProjectRequestBranch"
        '
        'lblProjectRequestBank
        '
        Me.lblProjectRequestBank.Name = "lblProjectRequestBank"
        '
        'lblProjectRequestSum
        '
        Me.lblProjectRequestSum.Name = "lblProjectRequestSum"
        '
        'lblProjectRecommendDate
        '
        Me.lblProjectRecommendDate.Name = "lblProjectRecommendDate"
        '
        'lblProjectRecommendSum
        '
        Me.lblProjectRecommendSum.Name = "lblProjectRecommendSum"
        '
        'lblProjectCooperateOpinion
        '
        Me.lblProjectCooperateOpinion.Location = New System.Drawing.Point(8, 160)
        Me.lblProjectCooperateOpinion.Name = "lblProjectCooperateOpinion"
        '
        'lblProjectRequestTerm
        '
        Me.lblProjectRequestTerm.Name = "lblProjectRequestTerm"
        '
        'chkIsFirstLoan
        '
        Me.chkIsFirstLoan.Name = "chkIsFirstLoan"
        '
        'txtLegelMobile
        '
        Me.txtLegelMobile.Name = "txtLegelMobile"
        Me.txtLegelMobile.Size = New System.Drawing.Size(144, 21)
        '
        'txtLegelPhone
        '
        Me.txtLegelPhone.Name = "txtLegelPhone"
        '
        'txtContactEmail
        '
        Me.txtContactEmail.Name = "txtContactEmail"
        '
        'txtContactMobile
        '
        Me.txtContactMobile.Location = New System.Drawing.Point(600, 278)
        Me.txtContactMobile.Name = "txtContactMobile"
        Me.txtContactMobile.Size = New System.Drawing.Size(144, 21)
        '
        'lblCorpContactor
        '
        Me.lblCorpContactor.Name = "lblCorpContactor"
        '
        'lblAttachColledge
        '
        Me.lblAttachColledge.Name = "lblAttachColledge"
        '
        'lblAttachMaster
        '
        Me.lblAttachMaster.Name = "lblAttachMaster"
        '
        'lblAttachMember
        '
        Me.lblAttachMember.Name = "lblAttachMember"
        '
        'lblFoundDate
        '
        Me.lblFoundDate.Name = "lblFoundDate"
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.Location = New System.Drawing.Point(600, 70)
        Me.dtpFoundDate.Name = "dtpFoundDate"
        Me.dtpFoundDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpFoundDate.Value = New Date(2003, 12, 1, 15, 53, 21, 46)
        '
        'clbTechType
        '
        Me.clbTechType.Name = "clbTechType"
        '
        'lblCorpTechType
        '
        Me.lblCorpTechType.Name = "lblCorpTechType"
        '
        'lblCorpPropriateShip
        '
        Me.lblCorpPropriateShip.Name = "lblCorpPropriateShip"
        '
        'lblCorpIndustryType
        '
        Me.lblCorpIndustryType.Name = "lblCorpIndustryType"
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.Location = New System.Drawing.Point(248, 70)
        Me.txtAddressDetail.Name = "txtAddressDetail"
        Me.txtAddressDetail.Size = New System.Drawing.Size(248, 21)
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.Name = "lblCorpRegisterAddress"
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.Location = New System.Drawing.Point(600, 46)
        Me.txtLoanCardID.Name = "txtLoanCardID"
        Me.txtLoanCardID.Size = New System.Drawing.Size(144, 21)
        '
        'lblCorpContactNumber
        '
        Me.lblCorpContactNumber.Name = "lblCorpContactNumber"
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.Name = "lblCorpCardID"
        '
        'txtRepID
        '
        Me.txtRepID.Name = "txtRepID"
        '
        'lblCorpEvalInstitute
        '
        Me.lblCorpEvalInstitute.Name = "lblCorpEvalInstitute"
        '
        'txtLoanID
        '
        Me.txtLoanID.Location = New System.Drawing.Point(352, 46)
        Me.txtLoanID.Name = "txtLoanID"
        Me.txtLoanID.Size = New System.Drawing.Size(144, 21)
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.Location = New System.Drawing.Point(264, 48)
        Me.lblCorpPaperID.Name = "lblCorpPaperID"
        '
        'txtCorpID
        '
        Me.txtCorpID.Name = "txtCorpID"
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.Name = "lblCorpBusinessCode"
        '
        'txtFax
        '
        Me.txtFax.Name = "txtFax"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(144, 21)
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Name = "txtContactPerson"
        '
        'txtRepreID
        '
        Me.txtRepreID.Location = New System.Drawing.Point(600, 230)
        Me.txtRepreID.Name = "txtRepreID"
        Me.txtRepreID.Size = New System.Drawing.Size(144, 21)
        '
        'txtCashReceive
        '
        Me.txtCashReceive.Name = "txtCashReceive"
        Me.txtCashReceive.Size = New System.Drawing.Size(144, 21)
        '
        'lblContactorFax
        '
        Me.lblContactorFax.Name = "lblContactorFax"
        '
        'txtRepreNation
        '
        Me.txtRepreNation.Location = New System.Drawing.Point(600, 256)
        Me.txtRepreNation.Name = "txtRepreNation"
        Me.txtRepreNation.Size = New System.Drawing.Size(144, 21)
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.Name = "txtInvisibleAssets"
        '
        'txtRepresentative
        '
        Me.txtRepresentative.Name = "txtRepresentative"
        '
        'txtRealCapital
        '
        Me.txtRealCapital.Location = New System.Drawing.Point(600, 208)
        Me.txtRealCapital.Name = "txtRealCapital"
        Me.txtRealCapital.Size = New System.Drawing.Size(144, 21)
        '
        'txtRegCapital
        '
        Me.txtRegCapital.Name = "txtRegCapital"
        '
        'txtEvalInstitute
        '
        Me.txtEvalInstitute.Name = "txtEvalInstitute"
        '
        'txtCreditLevel
        '
        Me.txtCreditLevel.Name = "txtCreditLevel"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.Location = New System.Drawing.Point(515, 512)
        Me.btnExit.Name = "btnExit"
        '
        'pgGuaranteeLetter
        '
        Me.pgGuaranteeLetter.Controls.Add(Me.grpGuaranteeLetter)
        Me.pgGuaranteeLetter.Location = New System.Drawing.Point(4, 21)
        Me.pgGuaranteeLetter.Name = "pgGuaranteeLetter"
        Me.pgGuaranteeLetter.Size = New System.Drawing.Size(762, 375)
        Me.pgGuaranteeLetter.TabIndex = 12
        Me.pgGuaranteeLetter.Text = "������Ϣ"
        '
        'grpGuaranteeLetter
        '
        Me.grpGuaranteeLetter.Controls.Add(Me.lblBeneficiaryIntroduction)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblCounterclaimCondition)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblImplementAbility)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblProjectContent)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblProjectName)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtCounterclaimCondition)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtBeneficiaryIntroduction)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtImplementAbility)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtProjectContent)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtProjectName)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtWorkflow)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtBeneficiary)
        Me.grpGuaranteeLetter.Controls.Add(Me.cboGuaranteeLetterType)
        Me.grpGuaranteeLetter.Controls.Add(Me.cboReimburseType)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblWorkflow)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblGuaranteeLetterType)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblReimburseType)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblBeneficiary)
        Me.grpGuaranteeLetter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpGuaranteeLetter.Location = New System.Drawing.Point(0, 0)
        Me.grpGuaranteeLetter.Name = "grpGuaranteeLetter"
        Me.grpGuaranteeLetter.Size = New System.Drawing.Size(762, 375)
        Me.grpGuaranteeLetter.TabIndex = 64
        Me.grpGuaranteeLetter.TabStop = False
        '
        'lblBeneficiaryIntroduction
        '
        Me.lblBeneficiaryIntroduction.Location = New System.Drawing.Point(8, 312)
        Me.lblBeneficiaryIntroduction.Name = "lblBeneficiaryIntroduction"
        Me.lblBeneficiaryIntroduction.Size = New System.Drawing.Size(80, 16)
        Me.lblBeneficiaryIntroduction.TabIndex = 81
        Me.lblBeneficiaryIntroduction.Text = "�����˼��"
        '
        'lblCounterclaimCondition
        '
        Me.lblCounterclaimCondition.Location = New System.Drawing.Point(8, 232)
        Me.lblCounterclaimCondition.Name = "lblCounterclaimCondition"
        Me.lblCounterclaimCondition.Size = New System.Drawing.Size(56, 16)
        Me.lblCounterclaimCondition.TabIndex = 80
        Me.lblCounterclaimCondition.Text = "��������"
        '
        'lblImplementAbility
        '
        Me.lblImplementAbility.Location = New System.Drawing.Point(8, 168)
        Me.lblImplementAbility.Name = "lblImplementAbility"
        Me.lblImplementAbility.Size = New System.Drawing.Size(56, 16)
        Me.lblImplementAbility.TabIndex = 79
        Me.lblImplementAbility.Text = "��Լ����"
        '
        'lblProjectContent
        '
        Me.lblProjectContent.Location = New System.Drawing.Point(8, 104)
        Me.lblProjectContent.Name = "lblProjectContent"
        Me.lblProjectContent.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectContent.TabIndex = 78
        Me.lblProjectContent.Text = "�б�����"
        '
        'lblProjectName
        '
        Me.lblProjectName.Location = New System.Drawing.Point(8, 72)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectName.TabIndex = 77
        Me.lblProjectName.Text = "��Ŀ����"
        '
        'txtCounterclaimCondition
        '
        Me.txtCounterclaimCondition.Location = New System.Drawing.Point(88, 224)
        Me.txtCounterclaimCondition.Multiline = True
        Me.txtCounterclaimCondition.Name = "txtCounterclaimCondition"
        Me.txtCounterclaimCondition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCounterclaimCondition.Size = New System.Drawing.Size(656, 72)
        Me.txtCounterclaimCondition.TabIndex = 76
        Me.txtCounterclaimCondition.Text = ""
        '
        'txtBeneficiaryIntroduction
        '
        Me.txtBeneficiaryIntroduction.Location = New System.Drawing.Point(88, 304)
        Me.txtBeneficiaryIntroduction.Multiline = True
        Me.txtBeneficiaryIntroduction.Name = "txtBeneficiaryIntroduction"
        Me.txtBeneficiaryIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBeneficiaryIntroduction.Size = New System.Drawing.Size(656, 64)
        Me.txtBeneficiaryIntroduction.TabIndex = 75
        Me.txtBeneficiaryIntroduction.Text = ""
        '
        'txtImplementAbility
        '
        Me.txtImplementAbility.Location = New System.Drawing.Point(88, 160)
        Me.txtImplementAbility.Multiline = True
        Me.txtImplementAbility.Name = "txtImplementAbility"
        Me.txtImplementAbility.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImplementAbility.Size = New System.Drawing.Size(656, 56)
        Me.txtImplementAbility.TabIndex = 74
        Me.txtImplementAbility.Text = ""
        '
        'txtProjectContent
        '
        Me.txtProjectContent.Location = New System.Drawing.Point(88, 96)
        Me.txtProjectContent.Multiline = True
        Me.txtProjectContent.Name = "txtProjectContent"
        Me.txtProjectContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProjectContent.Size = New System.Drawing.Size(656, 56)
        Me.txtProjectContent.TabIndex = 73
        Me.txtProjectContent.Text = ""
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(88, 70)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(456, 21)
        Me.txtProjectName.TabIndex = 72
        Me.txtProjectName.Text = ""
        '
        'txtWorkflow
        '
        Me.txtWorkflow.Location = New System.Drawing.Point(88, 22)
        Me.txtWorkflow.Name = "txtWorkflow"
        Me.txtWorkflow.ReadOnly = True
        Me.txtWorkflow.Size = New System.Drawing.Size(184, 21)
        Me.txtWorkflow.TabIndex = 71
        Me.txtWorkflow.TabStop = False
        Me.txtWorkflow.Text = ""
        '
        'txtBeneficiary
        '
        Me.txtBeneficiary.Location = New System.Drawing.Point(360, 46)
        Me.txtBeneficiary.Name = "txtBeneficiary"
        Me.txtBeneficiary.Size = New System.Drawing.Size(184, 21)
        Me.txtBeneficiary.TabIndex = 70
        Me.txtBeneficiary.TabStop = False
        Me.txtBeneficiary.Text = ""
        '
        'cboGuaranteeLetterType
        '
        Me.cboGuaranteeLetterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGuaranteeLetterType.Location = New System.Drawing.Point(360, 22)
        Me.cboGuaranteeLetterType.Name = "cboGuaranteeLetterType"
        Me.cboGuaranteeLetterType.Size = New System.Drawing.Size(184, 20)
        Me.cboGuaranteeLetterType.TabIndex = 69
        Me.cboGuaranteeLetterType.TabStop = False
        '
        'cboReimburseType
        '
        Me.cboReimburseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReimburseType.Location = New System.Drawing.Point(88, 46)
        Me.cboReimburseType.Name = "cboReimburseType"
        Me.cboReimburseType.Size = New System.Drawing.Size(184, 20)
        Me.cboReimburseType.TabIndex = 68
        Me.cboReimburseType.TabStop = False
        '
        'lblWorkflow
        '
        Me.lblWorkflow.Location = New System.Drawing.Point(8, 24)
        Me.lblWorkflow.Name = "lblWorkflow"
        Me.lblWorkflow.Size = New System.Drawing.Size(56, 16)
        Me.lblWorkflow.TabIndex = 66
        Me.lblWorkflow.Text = "������ʽ"
        '
        'lblGuaranteeLetterType
        '
        Me.lblGuaranteeLetterType.Location = New System.Drawing.Point(288, 24)
        Me.lblGuaranteeLetterType.Name = "lblGuaranteeLetterType"
        Me.lblGuaranteeLetterType.Size = New System.Drawing.Size(56, 16)
        Me.lblGuaranteeLetterType.TabIndex = 64
        Me.lblGuaranteeLetterType.Text = "��������"
        '
        'lblReimburseType
        '
        Me.lblReimburseType.Location = New System.Drawing.Point(8, 48)
        Me.lblReimburseType.Name = "lblReimburseType"
        Me.lblReimburseType.Size = New System.Drawing.Size(80, 16)
        Me.lblReimburseType.TabIndex = 65
        Me.lblReimburseType.Text = "������������"
        '
        'lblBeneficiary
        '
        Me.lblBeneficiary.Location = New System.Drawing.Point(288, 48)
        Me.lblBeneficiary.Name = "lblBeneficiary"
        Me.lblBeneficiary.Size = New System.Drawing.Size(80, 16)
        Me.lblBeneficiary.TabIndex = 67
        Me.lblBeneficiary.Text = "����������"
        '
        'pgOpinion
        '
        Me.pgOpinion.Controls.Add(Me.grpOpinion)
        Me.pgOpinion.Location = New System.Drawing.Point(4, 21)
        Me.pgOpinion.Name = "pgOpinion"
        Me.pgOpinion.Size = New System.Drawing.Size(762, 375)
        Me.pgOpinion.TabIndex = 13
        Me.pgOpinion.Text = "�������"
        '
        'grpOpinion
        '
        Me.grpOpinion.Controls.Add(Me.txtOpinion)
        Me.grpOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOpinion.Location = New System.Drawing.Point(0, 0)
        Me.grpOpinion.Name = "grpOpinion"
        Me.grpOpinion.Size = New System.Drawing.Size(762, 375)
        Me.grpOpinion.TabIndex = 0
        Me.grpOpinion.TabStop = False
        Me.grpOpinion.Text = "�������"
        '
        'txtOpinion
        '
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.MaxLength = 1000
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(756, 355)
        Me.txtOpinion.TabIndex = 0
        Me.txtOpinion.TabStop = False
        Me.txtOpinion.Text = ""
        '
        'MenuItemAnalyze
        '
        Me.MenuItemAnalyze.Index = 4
        Me.MenuItemAnalyze.Text = "��������(&C)"
        '
        'MenuItemGuarantee
        '
        Me.MenuItemGuarantee.Index = 5
        Me.MenuItemGuarantee.Text = "���뱣֤��ҵ(&G)"
        '
        'mnuPersonAssure
        '
        Me.mnuPersonAssure.Index = 6
        Me.mnuPersonAssure.Text = "������˱�֤��Ϣ(&P)"
        '
        'mnuImportCorp
        '
        Me.mnuImportCorp.Index = 0
        Me.mnuImportCorp.Text = "��ҵ��Ϣ"
        '
        'mnuImportFinance
        '
        Me.mnuImportFinance.Index = 1
        Me.mnuImportFinance.Text = "��������"
        '
        'FReview_bh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 539)
        Me.MinimizeBox = False
        Me.Name = "FReview_bh"
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgProject.ResumeLayout(False)
        Me.grpProjectPassed.ResumeLayout(False)
        Me.grpRequest.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProjectHeader.ResumeLayout(False)
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgGuaranteeLetter.ResumeLayout(False)
        Me.grpGuaranteeLetter.ResumeLayout(False)
        Me.pgOpinion.ResumeLayout(False)
        Me.grpOpinion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FReview_bh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tabReview
        '
        Me.tabReview.Controls.Clear()
        Me.tabReview.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgProject, Me.pgCorpInfo, Me.pgGuaranteeLetter})

        Try
            MyBase.InitCorpCodeAndPhase()
            MyBase.InitComboBox()
            MyBase.InitDataSet()
            Me.Init()
            MyBase.GetData()
            'Me.tabReview.Tag = Me.tabReview.SelectedIndex
            'Dim i As Integer
            'For i = 0 To Me.tabReview.TabCount - 1
            '    Me.tabReview.SelectedIndex = i
            'Next
            'Me.tabReview.SelectedIndex = Me.tabReview.Tag
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Protected Overrides Sub GetProjectData()
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
        Me.chkIsFirstLoan.DataBindings.Add("Checked", ds, "project.is_first_loan")                 '�Ƿ��״δ���

        Me.txtWorkflow.DataBindings.Add("Text", ds, "project.workflow")                                    '������ʽ    
        Me.cboGuaranteeLetterType.DataBindings.Add("SelectedValue", ds, "project.guarantee_letter_type")   '��������
        Me.cboReimburseType.DataBindings.Add("SelectedValue", ds, "project.reimburse_type")                '������������
        Me.txtBeneficiary.DataBindings.Add("Text", ds, "project.beneficiary")                              '����������


        Me.txtProjectName.DataBindings.Add("Text", ds, "project.bh_project_name")                          '��Ŀ���� 
        Me.txtProjectContent.DataBindings.Add("Text", ds, "project.bh_project_content")                    '�б�����
        Me.txtImplementAbility.DataBindings.Add("Text", ds, "project.bh_implement_ability")                '��Լ����
        Me.txtCounterclaimCondition.DataBindings.Add("Text", ds, "project.bh_counterclaim_condition")      '�������� 
        Me.txtBeneficiaryIntroduction.DataBindings.Add("Text", ds, "project.bh_beneficiary_introduction")  '�����˼��

        bmProject = BindingContext(ds, "project")
        AddHandler bmProject.CurrentChanged, AddressOf BindDataChanged

    End Sub
    '��ʼ����󶨴����е�ComboBox
    Private Sub Init()
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetReimburseType("%")
            Me.cboReimburseType.DataSource = tempDS.Tables(0)
            Me.cboReimburseType.DisplayMember = "name"
            Me.cboReimburseType.ValueMember = "type_code"
            tempDS = gWs.GetGuaranteeLetterType("%")
            Me.cboGuaranteeLetterType.DataSource = tempDS.Tables(0)
            Me.cboGuaranteeLetterType.DisplayMember = "name"
            Me.cboGuaranteeLetterType.ValueMember = "type_code"
        
            tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='52' AND item_code='002'}") '��Ŀ���н���
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                Me.txtOpinion.Text = IIf(tempDS.Tables(0).Rows(0).Item("content") Is DBNull.Value, "", tempDS.Tables(0).Rows(0).Item("content"))
            End If
            AddHandler txtOpinion.TextChanged, AddressOf BindDataChanged
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '����project��
    Protected Overrides Function SaveProject() As Boolean
        Dim result As String
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables("project").Rows.Count = 0 Then
                With tempDS.Tables("project").Rows(0)
                    .Item("apply_service_type") = Me.cboApplyServiceType.SelectedValue
                    .Item("recommend_type") = Me.cboRecommendType.Text
                    .Item("recommend_person") = Me.GetRecommendPerson()
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
                    .Item("apply_date") = Me.dtpApplyDate.Value
                    .Item("is_first_loan") = Me.chkIsFirstLoan.Checked

                    .Item("guarantee_letter_type") = Me.cboGuaranteeLetterType.SelectedValue                            '��������
                    .Item("reimburse_type") = Me.cboReimburseType.SelectedValue                                         '������������
                    .Item("beneficiary") = Me.txtBeneficiary.Text                                                       '����������
                    .Item("bh_project_name") = Me.txtProjectName.Text                                                  '��Ŀ���� 
                    .Item("bh_project_content") = Me.txtProjectContent.Text                                            '�б�����     
                    .Item("bh_implement_ability") = Me.txtImplementAbility.Text                                        '��Լ����
                    .Item("bh_counterclaim_condition") = Me.txtCounterclaimCondition.Text                              '�������� 
                    .Item("bh_beneficiary_introduction") = Me.txtBeneficiaryIntroduction.Text                          '�����˼��
                    '.Item("create_person") = UserName
                    '.Item("create_date") = SysDate.Date
                End With
            End If
            Dim strResult As String = gWs.UpdateProject(tempDS)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "������Ŀ��Ϣʧ��", strResult, "")
                Return False
            End If
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '������Ŀ�����������
    Private Function SaveOpinion() As Boolean
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='52' AND item_code='002'}") '��Ŀ���н���
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("content") = Me.txtOpinion.Text
                End With
            Else
                Dim dr As DataRow = tempDS.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("content") = Me.txtOpinion.Text
                    .Item("item_type") = "52"   '��Ŀ���н���
                    .Item("item_code") = "002"
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
                tempDS.Tables(0).Rows.Add(dr)
            End If
            Dim strResult As String = gWs.UpdateProjectOpinion(tempDS)
            If strResult <> "1" Then
                ' MsgBox("��������������ʧ��", MsgBoxStyle.Exclamation, "��Ŀ����")
                SWDialogBox.MessageBox.Show("*999", "��������������ʧ��", strResult, "��Ŀ����")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Protected Overrides Function SaveData() As Boolean
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
            If Not Me.SaveOpinion() Then
                Return False
            End If
            Me.bIsChanged = False       '����ɹ�
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '��������
    Private Sub MenuItemAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAnalyze.Click
        Dim ds As New DataSet()
        ds = gWs.GetAccount("{project_code LIKE '" & Me.getProjectCode() & "' AND phase LIKE '����'}")
        If ds.Tables(0).Rows.Count = 0 Then
            SWDialogBox.MessageBox.Show("$1005", "����Ŀ�������������")  '��������Ӧ�׶εĲ�������
            Return
        End If
        Dim f As New FProjectCredit()
        f.Show()
        f.SetEditState(False)
        f.ShowDialog(Me.getProjectCode(), Me.CorpCode, "����")
    End Sub
    '���뱣֤��ҵ
    Private Sub MenuItemGuarantee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemGuarantee.Click
        Dim assure As New frmCorAssureList()
        assure.Text = "���뱣֤��ҵ"
        assure.OpenApplyTool(getProjectCode(), getCorporationName(), getWorkFlowID(), getTaskID(), Me, UserName)
    End Sub
    '������˱�֤��Ϣ
    Private Sub mnuPersonAssure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPersonAssure.Click
        Dim frm As New frmPersonAssure(Me.getProjectCode(), Me.getCorporationName())
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If Not Me.SaveData() Then
            Return
        End If
        If Not Me.hasFinanceAnalysis(Me.getProjectCode(), "����") Then
            If DialogResult.No = SWDialogBox.MessageBox.Show("?X008") Then
                Return
            End If
        End If
        Dim doc As New frmDocumentManageBusiness(getProjectCode, getTaskID, getCorporationName, "45", "102", UserName)
        doc.AllowTransparency = False
        doc.ShowDialog()
    End Sub

    '�ж��Ƿ���в������
    Protected Function hasFinanceAnalysis(ByVal ProjectCode As String, ByVal Phase As String) As Boolean
        If Not gWs.GetCommonQueryInfo("SELECT TOP 1 * FROM Project_Finance_Analyse WHERE project_code = '" & ProjectCode & "' AND phase = '" & _
                Phase & "' AND corporation_code = '" & Me.CorpCode & "'").Tables(0).Rows.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    '���ǻ���ķ���
    Protected Overrides Function LoadedReport() As Boolean
        Return MyBase.ReportExisted("45", "102")
    End Function

    Dim Project_code, Phase_Code As String '�Ӵ���frmProjectCorpInfoѡ���Ҫ�������Ŀ����ͽ׶�ֵ

    'ȡ��CheckedListBox�����ѡ��״̬
    Protected Sub clbTechType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles clbTechType.Leave
        Dim i As Integer
        For i = 0 To Me.clbTechType.Items.Count - 1
            Me.clbTechType.SetSelected(i, False)
        Next
    End Sub

    '������ҵ��Ϣ
    Private Sub mnuImportCorp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportCorp.Click
        Dim f As New frmProjectCorpInfo(Me.CorpCode)
        f.ShowDialog()
        Project_code = f.Project_code
        Phase_Code = f.Phase_Code
        If Project_code = "" Or Phase_Code = "" Or (Project_code = Me.ProCode And Phase_Code = "����") Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            If Me.ds.Tables("TProjectCorporation").Rows.Count > 0 Then
                'MsgBox("�Ƿ񸲸��Ѵ��ڵ����ݣ�", MsgBoxStyle.OKCancel Or MsgBoxStyle.Question, "��Ŀ����")
                If SWDialogBox.MessageBox.Show("!1002") <> MsgBoxResult.Yes Then
                    Return
                End If
            End If

            Dim dt As DataTable
            Dim dsTemp As DataSet
            dsTemp = gWs.FetchProjectCorporation(Me.ProCode, Me.CorpCode, "1", Me.Phase)
            dt = gWs.FetchProjectCorporation(Project_code, Me.CorpCode, "1", Phase_Code).Tables("TProjectCorporation")
            If dt.Rows.Count > 0 Then
                If dsTemp.Tables("TProjectCorporation").Rows.Count > 0 Then
                    With dsTemp.Tables("TProjectCorporation").Rows(0)
                        .ItemArray = dt.Rows(0).ItemArray
                        .Item("phase") = Me.Phase
                        .Item("project_code") = Me.ProCode
                        .Item("corporation_name") = Me.CorpName
                        .Item("create_person") = UserName
                        .Item("create_date") = SysDate
                    End With

                Else
                    Dim dr As DataRow = dsTemp.Tables("TProjectCorporation").NewRow()
                    With dr
                        .ItemArray = dt.Rows(0).ItemArray
                        .Item("phase") = Me.Phase
                        .Item("project_code") = Me.ProCode
                        .Item("corporation_name") = Me.CorpName
                        .Item("create_person") = UserName
                        .Item("create_date") = SysDate
                    End With
                    dsTemp.Tables("TProjectCorporation").Rows.Add(dr)
                End If

                Dim strResult As String = gWs.UpdateProjectCorporation(dsTemp)
                If Not strResult = "1" Then
                    SWDialogBox.MessageBox.Show("*999", "������ҵ��Ϣʧ��,ԭ���ǣ�", strResult, "��Ŀ����")
                Else
                    SWDialogBox.MessageBox.Show("$OperateSucceed")

                    With ds.Tables("TProjectCorporation").Rows(0)
                        .ItemArray = dt.Rows(0).ItemArray
                        Me.int_TechTypes = dt.Rows(0).Item("technology_type")
                    End With
                    Me.ds.AcceptChanges()

                    Me.tabReview.Visible = False
                    Me.tabReview.Tag = Me.tabReview.SelectedIndex
                    Dim i As Integer
                    For i = 0 To Me.tabReview.TabPages.Count - 1
                        Me.tabReview.SelectedIndex = i
                    Next
                    Me.tabReview.SelectedIndex = CInt(Me.tabReview.Tag)
                    Me.tabReview.Visible = True

                    Me.InitTechType()
                    Me.clbTechType_Leave(Nothing, Nothing)
                    Me.bIsChanged = False
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '�����������
    Private Sub mnuImportFinance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportFinance.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim f As New FImportFinance(Me.ProCode, "����", Me.getCorporationName())
            f.AllowTransparency = False
            f.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
