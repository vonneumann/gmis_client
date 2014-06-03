Public Class frmCheckBank
    Inherits frmBasic
    Private Const passText As String = "ͨ��"
    Private ProjectCode, TaskID, WorkFlowID As String
    Private dsAccount As DataSet
    Private bmAccount As BindingManagerBase
    Private Const MaxFee As Double = 100000000
    Private dsServiceType As DataSet
    Private dsBank As DataSet


#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAccount Is Nothing Then
            dsAccount.Dispose()
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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanForm As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEachReturnFee As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRefundType As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtStandard As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtConclusionReviewFee As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ckxPartnerAffirm As System.Windows.Forms.CheckBox
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents gpxBank As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubBank As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckBank))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.txtCorName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.gpxMeeting = New System.Windows.Forms.GroupBox
        Me.ckxPartnerAffirm = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLoanForm = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtEachReturnFee = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtRefundType = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTerm = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtStandard = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSum = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtServiceType = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtConclusion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtConclusionReviewFee = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRecord = New System.Windows.Forms.Button
        Me.gpxBank = New System.Windows.Forms.GroupBox
        Me.cboSubBank = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboBank = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gpxMeeting.SuspendLayout()
        Me.gpxBank.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(391, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 3
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(307, 248)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Text = "�ύ(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(224, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 41
        Me.txtCorName.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "��ҵ����"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "��Ŀ����"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 40
        Me.txtProjectCode.Text = ""
        '
        'gpxMeeting
        '
        Me.gpxMeeting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxMeeting.Controls.Add(Me.ckxPartnerAffirm)
        Me.gpxMeeting.Controls.Add(Me.Label9)
        Me.gpxMeeting.Controls.Add(Me.txtLoanForm)
        Me.gpxMeeting.Controls.Add(Me.Label13)
        Me.gpxMeeting.Controls.Add(Me.txtEachReturnFee)
        Me.gpxMeeting.Controls.Add(Me.Label12)
        Me.gpxMeeting.Controls.Add(Me.txtRefundType)
        Me.gpxMeeting.Controls.Add(Me.Label11)
        Me.gpxMeeting.Controls.Add(Me.txtTerm)
        Me.gpxMeeting.Controls.Add(Me.Label10)
        Me.gpxMeeting.Controls.Add(Me.txtStandard)
        Me.gpxMeeting.Controls.Add(Me.Label8)
        Me.gpxMeeting.Controls.Add(Me.txtSum)
        Me.gpxMeeting.Controls.Add(Me.Label7)
        Me.gpxMeeting.Controls.Add(Me.txtServiceType)
        Me.gpxMeeting.Controls.Add(Me.Label4)
        Me.gpxMeeting.Controls.Add(Me.txtConclusion)
        Me.gpxMeeting.Controls.Add(Me.Label3)
        Me.gpxMeeting.Controls.Add(Me.txtConclusionReviewFee)
        Me.gpxMeeting.Controls.Add(Me.Label2)
        Me.gpxMeeting.Location = New System.Drawing.Point(8, 40)
        Me.gpxMeeting.Name = "gpxMeeting"
        Me.gpxMeeting.Size = New System.Drawing.Size(464, 144)
        Me.gpxMeeting.TabIndex = 42
        Me.gpxMeeting.TabStop = False
        Me.gpxMeeting.Text = "��������"
        '
        'ckxPartnerAffirm
        '
        Me.ckxPartnerAffirm.BackColor = System.Drawing.Color.Gainsboro
        Me.ckxPartnerAffirm.Enabled = False
        Me.ckxPartnerAffirm.ForeColor = System.Drawing.Color.Gainsboro
        Me.ckxPartnerAffirm.Location = New System.Drawing.Point(296, 113)
        Me.ckxPartnerAffirm.Name = "ckxPartnerAffirm"
        Me.ckxPartnerAffirm.Size = New System.Drawing.Size(15, 18)
        Me.ckxPartnerAffirm.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(208, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "��   ��   ��"
        '
        'txtLoanForm
        '
        Me.txtLoanForm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanForm.Location = New System.Drawing.Point(296, 40)
        Me.txtLoanForm.Name = "txtLoanForm"
        Me.txtLoanForm.ReadOnly = True
        Me.txtLoanForm.Size = New System.Drawing.Size(160, 21)
        Me.txtLoanForm.TabIndex = 57
        Me.txtLoanForm.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(208, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 17)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "��  �� �� ʽ"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEachReturnFee
        '
        Me.txtEachReturnFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEachReturnFee.Location = New System.Drawing.Point(296, 88)
        Me.txtEachReturnFee.Name = "txtEachReturnFee"
        Me.txtEachReturnFee.ReadOnly = True
        Me.txtEachReturnFee.Size = New System.Drawing.Size(160, 21)
        Me.txtEachReturnFee.TabIndex = 55
        Me.txtEachReturnFee.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(208, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "ÿ�λ����(Ԫ)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRefundType
        '
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.Location = New System.Drawing.Point(104, 88)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(96, 21)
        Me.txtRefundType.TabIndex = 18
        Me.txtRefundType.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "��  �� �� ʽ"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(296, 64)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(160, 21)
        Me.txtTerm.TabIndex = 16
        Me.txtTerm.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "�������� (��)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStandard
        '
        Me.txtStandard.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStandard.Location = New System.Drawing.Point(104, 112)
        Me.txtStandard.Name = "txtStandard"
        Me.txtStandard.ReadOnly = True
        Me.txtStandard.Size = New System.Drawing.Size(96, 21)
        Me.txtStandard.TabIndex = 13
        Me.txtStandard.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "�� ȡ �� ׼(%)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSum.Location = New System.Drawing.Point(104, 40)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.txtSum.Size = New System.Drawing.Size(96, 21)
        Me.txtSum.TabIndex = 11
        Me.txtSum.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "�������(��Ԫ)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(296, 16)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(160, 21)
        Me.txtServiceType.TabIndex = 9
        Me.txtServiceType.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ҵ  �� Ʒ ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConclusion
        '
        Me.txtConclusion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusion.Location = New System.Drawing.Point(104, 16)
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ReadOnly = True
        Me.txtConclusion.Size = New System.Drawing.Size(96, 21)
        Me.txtConclusion.TabIndex = 7
        Me.txtConclusion.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "��  �� �� ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConclusionReviewFee
        '
        Me.txtConclusionReviewFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusionReviewFee.Location = New System.Drawing.Point(104, 64)
        Me.txtConclusionReviewFee.Name = "txtConclusionReviewFee"
        Me.txtConclusionReviewFee.ReadOnly = True
        Me.txtConclusionReviewFee.Size = New System.Drawing.Size(96, 21)
        Me.txtConclusionReviewFee.TabIndex = 5
        Me.txtConclusionReviewFee.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ӧ�������(Ԫ)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRecord
        '
        Me.btnRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.ImageIndex = 11
        Me.btnRecord.ImageList = Me.ImageListBasic
        Me.btnRecord.Location = New System.Drawing.Point(192, 248)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(108, 23)
        Me.btnRecord.TabIndex = 1
        Me.btnRecord.Text = "��������(&M)"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpxBank
        '
        Me.gpxBank.Controls.Add(Me.cboSubBank)
        Me.gpxBank.Controls.Add(Me.Label14)
        Me.gpxBank.Controls.Add(Me.cboBank)
        Me.gpxBank.Controls.Add(Me.Label1)
        Me.gpxBank.Location = New System.Drawing.Point(8, 192)
        Me.gpxBank.Name = "gpxBank"
        Me.gpxBank.Size = New System.Drawing.Size(464, 48)
        Me.gpxBank.TabIndex = 43
        Me.gpxBank.TabStop = False
        Me.gpxBank.Text = "����"
        '
        'cboSubBank
        '
        Me.cboSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubBank.Location = New System.Drawing.Point(304, 16)
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(152, 20)
        Me.cboSubBank.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(232, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 23)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "�ſ�֧��"
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.Location = New System.Drawing.Point(80, 16)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(144, 20)
        Me.cboBank.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "�ſ�����"
        '
        'frmCheckBank
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(482, 280)
        Me.Controls.Add(Me.gpxBank)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCorName)
        Me.Controls.Add(Me.txtProjectCode)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.gpxMeeting)
        Me.Controls.Add(Me.btnCommit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCheckBank"
        Me.Text = "ȷ������"
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.gpxMeeting, 0)
        Me.Controls.SetChildIndex(Me.btnRecord, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.gpxBank, 0)
        Me.gpxMeeting.ResumeLayout(False)
        Me.gpxBank.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    'ȷ����ȡ�����
    Private Sub frm_load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ProjectCode = MyBase.getProjectCode
            TaskID = MyBase.getTaskID
            WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = MyBase.getCorporationName

            dsAccount = gWs.GetProjectAccountDetailInfo("{project_code LIKE '" & ProjectCode & "' AND item_type='31' AND item_code='001' AND NOT payout IS NULL ORDER BY serial_num}") 'AND phase LIKE '%����%'   DESC
            bmAccount = BindingContext(dsAccount, "project_account_detail")
            'txtReviewFee.DataBindings.Add("Text", dsAccount, "project_account_detail.payout")
            'If bmAccount.Count > 0 Then
            '    bmAccount.Position = 0
            'End If

            Dim dsTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY trial_times DESC}", "null") 'AND trial_conclusion LIKE '%" & passText & "%' 
            txtConclusion.DataBindings.Add("Text", dsTrial, "conference_trial.trial_conclusion")
            txtSum.DataBindings.Add("Text", dsTrial, "conference_trial.guarantee_sum")
            txtServiceType.DataBindings.Add("Text", dsTrial, "conference_trial.service_type")
            txtStandard.DataBindings.Add("Text", dsTrial, "conference_trial.trial_rate")
            txtLoanForm.DataBindings.Add("Text", dsTrial, "conference_trial.loan_provide_form")
            txtTerm.DataBindings.Add("Text", dsTrial, "conference_trial.terms")
            txtRefundType.DataBindings.Add("Text", dsTrial, "conference_trial.refund_type")
            txtEachReturnFee.DataBindings.Add("Text", dsTrial, "conference_trial.refund_sum_average")

            Dim dsServiceType As DataSet = gWs.GetServiceType("{service_type='" & txtServiceType.Text & "'}")
            Dim lowest As Double = 0
            If dsServiceType.Tables(0).Rows.Count > 0 Then
                lowest = CDbl(dsServiceType.Tables(0).Rows(0)("lowest_review_sum") + "0") '�����ȡ�����
            End If

            Dim calculate As Double = 0 '������������������ʼ���������
            If txtSum.Text <> String.Empty AndAlso txtStandard.Text <> String.Empty Then
                Dim dr As DataRow
                For Each dr In dsAccount.Tables(0).Rows
                    calculate += CDbl(dr("payout"))
                Next
                'calculate = CDbl(txtSum.Text) * 100 * CDbl(txtStandard.Text)
            End If
            txtConclusionReviewFee.Text = Math.Max(calculate, lowest).ToString("n")
            dsServiceType.Dispose()

  

            '2009-09-07 yjf add ���С�֧�г�ʼ��
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
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboBank.SelectedValue & "'"
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


    Private Sub InsertAFeeRecord(ByVal payout As Double)
        Dim now As DateTime = gWs.GetSysTime
        Dim dr As DataRow = dsAccount.Tables(0).NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("phase") = "����"
            .Item("date") = now.Date
            .Item("item_type") = "31"
            .Item("item_code") = "001"
            .Item("payout") = payout
            .Item("create_person") = UserName
            .Item("create_date") = now
        End With
        dsAccount.Tables(0).Rows.Add(dr)
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click

        Dim result As String
        'Dim balance As Double = CDbl(txtReviewFee.Text)
        'Dim rowsCount As Int32 = dsAccount.Tables("project_account_detail").Rows.Count
        'If balance >= CDbl(txtConclusionReviewFee.Text) Then 'ȷ����ȡ����>=Ӧ�������
        'If rowsCount = 2 Then '������¼��rows��1��Ϊ�����󡱣�rows��0��Ϊ������
        '    balance -= CDbl(dsAccount.Tables(0).Rows(0)("payout")) 'ȷ�Ͻ���ȥԤ�յ�
        '    If balance <= 0 Then '��ȥ��Ϊ����ɾ���������޸�
        '        dsAccount.Tables(0).Rows(1).Delete()
        '    Else
        '        dsAccount.Tables(0).Rows(1)("payout") = balance
        '    End If
        'ElseIf rowsCount = 1 Then 'һ����¼
        '    Dim strPhase As String = dsAccount.Tables(0).Rows(0)("phase") & ""
        '    If Trim(strPhase) = "����" Then 'ֱ���޸�
        '        If balance = 0 Then '��ȷ�Ͻ��Ϊ�㣬ֱ��ɾ���������޸�
        '            dsAccount.Tables(0).Rows(0).Delete()
        '        Else
        '            dsAccount.Tables(0).Rows(0)("payout") = balance
        '        End If
        '    Else '������׶� ȷ�Ͻ���ȥԤ�յģ�����0�Ͳ���
        '        balance -= CDbl(dsAccount.Tables(0).Rows(0)("payout"))
        '        If balance > 0 Then
        '            InsertAFeeRecord(balance)
        '        End If
        '    End If
        'ElseIf rowsCount = 0 And balance > 0 Then '��δ�м�¼
        '    InsertAFeeRecord(balance)
        'End If
        'Else 'ȷ����ȡ���� < Ӧ�������
        '    If rowsCount = 2 Then
        '        dsAccount.Tables(0).Rows(1).Delete()
        '        balance -= CDbl(dsAccount.Tables(0).Rows(0)("payout")) 'ɾ��ԭ�еġ����󡱽׶ε�payout��¼
        '        If balance > 0 Then
        '            InsertAFeeRecord(balance)
        '        End If
        '    ElseIf rowsCount = 1 Then
        '        Dim strPhase As String = dsAccount.Tables(0).Rows(0)("phase") & ""
        '        If Trim(strPhase) = "����" Then
        '            If balance = 0 Then '��ȷ�Ͻ��Ϊ�㣬ֱ��ɾ���������޸�
        '                dsAccount.Tables(0).Rows(0).Delete()
        '            Else
        '                dsAccount.Tables(0).Rows(0)("payout") = balance
        '            End If
        '        Else '������׶�    ȷ�Ͻ���ȥԤ�յģ�����0�Ͳ���
        '            balance -= CDbl(dsAccount.Tables(0).Rows(0)("payout"))
        '            If balance > 0 Then
        '                InsertAFeeRecord(balance)
        '            End If
        '        End If
        '    ElseIf rowsCount = 1 And balance > 0 Then
        '        InsertAFeeRecord(balance)
        '    End If
        'End If

        'bmAccount.EndCurrentEdit()
        Dim strSql As String
        strSql = "{project_code='" & ProjectCode & "'}"
        Dim dsProject As DataSet = gWs.GetProjectInfo(strSql)
        dsProject.Tables(0).Rows(0).Item("apply_bank") = cboBank.SelectedValue
        dsProject.Tables(0).Rows(0).Item("apply_branch_bank") = cboSubBank.SelectedValue
        result = gWs.UpdateProject(dsProject.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "�������г���", result, "")
            Return
        End If

        result = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If result = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Me.Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "�ύʧ��", result, "")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        'If Not gpxBaoHan.Visible Then '�Ǳ���Ʒ��
        Dim meet As New frmMeetRecordQuery(ProjectCode, txtCorName.Text)
        meet.AllowTransparency = False
        meet.ShowDialog()
        'ElseIf gpxMeeting.Visible Then '����Ʒ���ҿ��������
        '    frmChangeGuarantyFee.OpenWord(ProjectCode, Me, txtCorName.Text.Trim & "����������", True, txtCorName.Text)
        'Else
        '    Dim apply_date As DateTime = Money.GetApplyDate(ProjectCode)
        '    Dim dsLetter As DataSet = gWs.GetGuaranteeLetter(ProjectCode.Substring(0, 5), apply_date)
        '    Dim fileProjectCode As String
        '    If dsLetter.Tables(0).Rows.Count > 0 Then
        '        fileProjectCode = dsLetter.Tables(0).Rows(0)("project_code") & String.Empty
        '        frmChangeGuarantyFee.OpenWord(fileProjectCode, Me, txtCorName.Text.Trim & "����������", False, String.Empty)
        '    End If
        'End If
    End Sub
    Friend WithEvents gpxMeeting As System.Windows.Forms.GroupBox
End Class
