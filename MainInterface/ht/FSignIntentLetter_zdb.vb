Public Class FSignIntentLetter_zdb
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
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents cboSignOpinion As System.Windows.Forms.ComboBox
    Friend WithEvents lblSignOpinion As System.Windows.Forms.Label
    Public WithEvents dtpSignDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSignDate As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents lblCorporationName As System.Windows.Forms.Label
    Public WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents grpBaseInfo As System.Windows.Forms.GroupBox
    Protected WithEvents txtRefund_sum_average As System.Windows.Forms.TextBox
    Protected WithEvents txtLoan_provide_form As System.Windows.Forms.TextBox
    Friend WithEvents lblLoan_provide_form As System.Windows.Forms.Label
    Protected WithEvents txtRefund_Type As System.Windows.Forms.TextBox
    Protected WithEvents lblRefund_Type As System.Windows.Forms.Label
    Protected WithEvents txtServiceType As System.Windows.Forms.TextBox
    Protected WithEvents lblServiceType As System.Windows.Forms.Label
    Protected WithEvents txtOrganizationName As System.Windows.Forms.TextBox
    Protected WithEvents lblOrganizationName As System.Windows.Forms.Label
    Protected WithEvents lblTerms As System.Windows.Forms.Label
    Protected WithEvents txtTerms As System.Windows.Forms.TextBox
    Protected WithEvents lblGuarantee_sum As System.Windows.Forms.Label
    Protected WithEvents txtGuarantee_sum As System.Windows.Forms.TextBox
    Friend WithEvents lblRefund_sum_average As System.Windows.Forms.Label
    Public WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents txtSourceServiceType As System.Windows.Forms.TextBox
    Protected WithEvents lblSourceServiceType As System.Windows.Forms.Label
    Friend WithEvents btnViewDoc As System.Windows.Forms.Button
    Protected WithEvents lblSourceLoanTerm As System.Windows.Forms.Label
    Protected WithEvents txtSourceLoanTerm As System.Windows.Forms.TextBox
    Protected WithEvents lblSourceLoanSum As System.Windows.Forms.Label
    Protected WithEvents txtSourceLoanSum As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FSignIntentLetter_zdb))
        Me.btnViewDoc = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboSignOpinion = New System.Windows.Forms.ComboBox()
        Me.lblSignOpinion = New System.Windows.Forms.Label()
        Me.dtpSignDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSignDate = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox()
        Me.lblSourceLoanTerm = New System.Windows.Forms.Label()
        Me.txtSourceLoanTerm = New System.Windows.Forms.TextBox()
        Me.lblSourceLoanSum = New System.Windows.Forms.Label()
        Me.txtSourceLoanSum = New System.Windows.Forms.TextBox()
        Me.txtSourceServiceType = New System.Windows.Forms.TextBox()
        Me.lblSourceServiceType = New System.Windows.Forms.Label()
        Me.txtRefund_sum_average = New System.Windows.Forms.TextBox()
        Me.txtLoan_provide_form = New System.Windows.Forms.TextBox()
        Me.lblLoan_provide_form = New System.Windows.Forms.Label()
        Me.txtRefund_Type = New System.Windows.Forms.TextBox()
        Me.lblRefund_Type = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.txtOrganizationName = New System.Windows.Forms.TextBox()
        Me.lblOrganizationName = New System.Windows.Forms.Label()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.lblGuarantee_sum = New System.Windows.Forms.Label()
        Me.txtGuarantee_sum = New System.Windows.Forms.TextBox()
        Me.lblRefund_sum_average = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.grpBaseInfo.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(377, 256)
        Me.btnExit.Visible = True
        '
        'btnViewDoc
        '
        Me.btnViewDoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnViewDoc.Image = CType(resources.GetObject("btnViewDoc.Image"), System.Drawing.Bitmap)
        Me.btnViewDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewDoc.ImageIndex = 27
        Me.btnViewDoc.ImageList = Me.ImageListBasic
        Me.btnViewDoc.Location = New System.Drawing.Point(88, 256)
        Me.btnViewDoc.Name = "btnViewDoc"
        Me.btnViewDoc.Size = New System.Drawing.Size(192, 23)
        Me.btnViewDoc.TabIndex = 67
        Me.btnViewDoc.Text = "�鿴�ٵ��������鼰������(&V)"
        Me.btnViewDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboSignOpinion, Me.lblSignOpinion, Me.dtpSignDate, Me.lblSignDate})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(535, 56)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "����ǩ����Ϣ"
        '
        'cboSignOpinion
        '
        Me.cboSignOpinion.BackColor = System.Drawing.SystemColors.Window
        Me.cboSignOpinion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSignOpinion.Location = New System.Drawing.Point(368, 22)
        Me.cboSignOpinion.Name = "cboSignOpinion"
        Me.cboSignOpinion.Size = New System.Drawing.Size(152, 20)
        Me.cboSignOpinion.TabIndex = 7
        '
        'lblSignOpinion
        '
        Me.lblSignOpinion.Location = New System.Drawing.Point(272, 24)
        Me.lblSignOpinion.Name = "lblSignOpinion"
        Me.lblSignOpinion.Size = New System.Drawing.Size(54, 16)
        Me.lblSignOpinion.TabIndex = 31
        Me.lblSignOpinion.Text = "ǩ�����"
        '
        'dtpSignDate
        '
        Me.dtpSignDate.Location = New System.Drawing.Point(104, 22)
        Me.dtpSignDate.Name = "dtpSignDate"
        Me.dtpSignDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpSignDate.TabIndex = 6
        Me.dtpSignDate.Value = New Date(2004, 4, 10, 0, 0, 0, 0)
        '
        'lblSignDate
        '
        Me.lblSignDate.Location = New System.Drawing.Point(8, 24)
        Me.lblSignDate.Name = "lblSignDate"
        Me.lblSignDate.Size = New System.Drawing.Size(54, 16)
        Me.lblSignDate.TabIndex = 29
        Me.lblSignDate.Text = "ǩ������"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(290, 256)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 64
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(184, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationName.TabIndex = 60
        Me.lblCorporationName.Text = "��ҵ����"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectCode.TabIndex = 59
        Me.lblProjectCode.Text = "��Ŀ����"
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblSourceLoanTerm, Me.txtSourceLoanTerm, Me.lblSourceLoanSum, Me.txtSourceLoanSum, Me.txtSourceServiceType, Me.lblSourceServiceType, Me.txtRefund_sum_average, Me.txtLoan_provide_form, Me.lblLoan_provide_form, Me.txtRefund_Type, Me.lblRefund_Type, Me.txtServiceType, Me.lblServiceType, Me.txtOrganizationName, Me.lblOrganizationName, Me.lblTerms, Me.txtTerms, Me.lblGuarantee_sum, Me.txtGuarantee_sum, Me.lblRefund_sum_average})
        Me.grpBaseInfo.Location = New System.Drawing.Point(8, 34)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(536, 150)
        Me.grpBaseInfo.TabIndex = 63
        Me.grpBaseInfo.TabStop = False
        Me.grpBaseInfo.Text = "��Ŀ������Ϣ"
        '
        'lblSourceLoanTerm
        '
        Me.lblSourceLoanTerm.Location = New System.Drawing.Point(272, 120)
        Me.lblSourceLoanTerm.Name = "lblSourceLoanTerm"
        Me.lblSourceLoanTerm.Size = New System.Drawing.Size(80, 16)
        Me.lblSourceLoanTerm.TabIndex = 61
        Me.lblSourceLoanTerm.Text = "��������(��)"
        '
        'txtSourceLoanTerm
        '
        Me.txtSourceLoanTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceLoanTerm.Location = New System.Drawing.Point(368, 118)
        Me.txtSourceLoanTerm.MaxLength = 4
        Me.txtSourceLoanTerm.Name = "txtSourceLoanTerm"
        Me.txtSourceLoanTerm.ReadOnly = True
        Me.txtSourceLoanTerm.Size = New System.Drawing.Size(152, 21)
        Me.txtSourceLoanTerm.TabIndex = 62
        Me.txtSourceLoanTerm.TabStop = False
        Me.txtSourceLoanTerm.Text = ""
        Me.txtSourceLoanTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSourceLoanSum
        '
        Me.lblSourceLoanSum.Location = New System.Drawing.Point(8, 120)
        Me.lblSourceLoanSum.Name = "lblSourceLoanSum"
        Me.lblSourceLoanSum.Size = New System.Drawing.Size(96, 16)
        Me.lblSourceLoanSum.TabIndex = 58
        Me.lblSourceLoanSum.Text = "������(��Ԫ)"
        '
        'txtSourceLoanSum
        '
        Me.txtSourceLoanSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceLoanSum.Location = New System.Drawing.Point(104, 118)
        Me.txtSourceLoanSum.MaxLength = 10
        Me.txtSourceLoanSum.Name = "txtSourceLoanSum"
        Me.txtSourceLoanSum.ReadOnly = True
        Me.txtSourceLoanSum.Size = New System.Drawing.Size(152, 21)
        Me.txtSourceLoanSum.TabIndex = 59
        Me.txtSourceLoanSum.TabStop = False
        Me.txtSourceLoanSum.Text = ""
        Me.txtSourceLoanSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSourceServiceType
        '
        Me.txtSourceServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceServiceType.Location = New System.Drawing.Point(368, 94)
        Me.txtSourceServiceType.MaxLength = 20
        Me.txtSourceServiceType.Name = "txtSourceServiceType"
        Me.txtSourceServiceType.ReadOnly = True
        Me.txtSourceServiceType.Size = New System.Drawing.Size(152, 21)
        Me.txtSourceServiceType.TabIndex = 56
        Me.txtSourceServiceType.TabStop = False
        Me.txtSourceServiceType.Text = ""
        '
        'lblSourceServiceType
        '
        Me.lblSourceServiceType.Location = New System.Drawing.Point(272, 96)
        Me.lblSourceServiceType.Name = "lblSourceServiceType"
        Me.lblSourceServiceType.Size = New System.Drawing.Size(79, 16)
        Me.lblSourceServiceType.TabIndex = 57
        Me.lblSourceServiceType.Text = "����ҵ��Ʒ��"
        '
        'txtRefund_sum_average
        '
        Me.txtRefund_sum_average.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefund_sum_average.Location = New System.Drawing.Point(104, 94)
        Me.txtRefund_sum_average.MaxLength = 10
        Me.txtRefund_sum_average.Name = "txtRefund_sum_average"
        Me.txtRefund_sum_average.ReadOnly = True
        Me.txtRefund_sum_average.Size = New System.Drawing.Size(152, 21)
        Me.txtRefund_sum_average.TabIndex = 54
        Me.txtRefund_sum_average.TabStop = False
        Me.txtRefund_sum_average.Text = ""
        Me.txtRefund_sum_average.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLoan_provide_form
        '
        Me.txtLoan_provide_form.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoan_provide_form.Location = New System.Drawing.Point(104, 46)
        Me.txtLoan_provide_form.Name = "txtLoan_provide_form"
        Me.txtLoan_provide_form.ReadOnly = True
        Me.txtLoan_provide_form.Size = New System.Drawing.Size(152, 21)
        Me.txtLoan_provide_form.TabIndex = 48
        Me.txtLoan_provide_form.TabStop = False
        Me.txtLoan_provide_form.Text = ""
        '
        'lblLoan_provide_form
        '
        Me.lblLoan_provide_form.Location = New System.Drawing.Point(8, 48)
        Me.lblLoan_provide_form.Name = "lblLoan_provide_form"
        Me.lblLoan_provide_form.Size = New System.Drawing.Size(54, 16)
        Me.lblLoan_provide_form.TabIndex = 40
        Me.lblLoan_provide_form.Text = "�ſʽ"
        '
        'txtRefund_Type
        '
        Me.txtRefund_Type.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefund_Type.Location = New System.Drawing.Point(368, 46)
        Me.txtRefund_Type.Name = "txtRefund_Type"
        Me.txtRefund_Type.ReadOnly = True
        Me.txtRefund_Type.Size = New System.Drawing.Size(152, 21)
        Me.txtRefund_Type.TabIndex = 24
        Me.txtRefund_Type.TabStop = False
        Me.txtRefund_Type.Text = ""
        '
        'lblRefund_Type
        '
        Me.lblRefund_Type.Location = New System.Drawing.Point(272, 48)
        Me.lblRefund_Type.Name = "lblRefund_Type"
        Me.lblRefund_Type.Size = New System.Drawing.Size(54, 16)
        Me.lblRefund_Type.TabIndex = 23
        Me.lblRefund_Type.Text = "���ʽ"
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(368, 22)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(152, 21)
        Me.txtServiceType.TabIndex = 16
        Me.txtServiceType.TabStop = False
        Me.txtServiceType.Text = ""
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(272, 24)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(80, 16)
        Me.lblServiceType.TabIndex = 15
        Me.lblServiceType.Text = "����ҵ��Ʒ��"
        '
        'txtOrganizationName
        '
        Me.txtOrganizationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrganizationName.Location = New System.Drawing.Point(104, 22)
        Me.txtOrganizationName.Name = "txtOrganizationName"
        Me.txtOrganizationName.ReadOnly = True
        Me.txtOrganizationName.Size = New System.Drawing.Size(152, 21)
        Me.txtOrganizationName.TabIndex = 3
        Me.txtOrganizationName.TabStop = False
        Me.txtOrganizationName.Text = ""
        '
        'lblOrganizationName
        '
        Me.lblOrganizationName.Location = New System.Drawing.Point(8, 24)
        Me.lblOrganizationName.Name = "lblOrganizationName"
        Me.lblOrganizationName.Size = New System.Drawing.Size(54, 16)
        Me.lblOrganizationName.TabIndex = 2
        Me.lblOrganizationName.Text = "��������"
        '
        'lblTerms
        '
        Me.lblTerms.Location = New System.Drawing.Point(272, 72)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(96, 16)
        Me.lblTerms.TabIndex = 21
        Me.lblTerms.Text = "�ٵ�������(��)"
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerms.Location = New System.Drawing.Point(368, 70)
        Me.txtTerms.MaxLength = 4
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(152, 21)
        Me.txtTerms.TabIndex = 22
        Me.txtTerms.TabStop = False
        Me.txtTerms.Text = ""
        Me.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGuarantee_sum
        '
        Me.lblGuarantee_sum.Location = New System.Drawing.Point(8, 72)
        Me.lblGuarantee_sum.Name = "lblGuarantee_sum"
        Me.lblGuarantee_sum.Size = New System.Drawing.Size(96, 16)
        Me.lblGuarantee_sum.TabIndex = 19
        Me.lblGuarantee_sum.Text = "�������(��Ԫ)"
        '
        'txtGuarantee_sum
        '
        Me.txtGuarantee_sum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuarantee_sum.Location = New System.Drawing.Point(104, 70)
        Me.txtGuarantee_sum.MaxLength = 10
        Me.txtGuarantee_sum.Name = "txtGuarantee_sum"
        Me.txtGuarantee_sum.ReadOnly = True
        Me.txtGuarantee_sum.Size = New System.Drawing.Size(152, 21)
        Me.txtGuarantee_sum.TabIndex = 20
        Me.txtGuarantee_sum.TabStop = False
        Me.txtGuarantee_sum.Text = ""
        Me.txtGuarantee_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRefund_sum_average
        '
        Me.lblRefund_sum_average.Location = New System.Drawing.Point(8, 96)
        Me.lblRefund_sum_average.Name = "lblRefund_sum_average"
        Me.lblRefund_sum_average.Size = New System.Drawing.Size(96, 16)
        Me.lblRefund_sum_average.TabIndex = 46
        Me.lblRefund_sum_average.Text = "ÿ�λ����(Ԫ)"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(248, 5)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(296, 21)
        Me.txtCorporationName.TabIndex = 62
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 5)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 61
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'FSignIntentLetter_zdb
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(554, 287)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCorporationName, Me.lblProjectCode, Me.btnExit, Me.btnViewDoc, Me.GroupBox3, Me.btnCommit, Me.grpBaseInfo, Me.txtCorporationName, Me.txtProjectCode})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FSignIntentLetter_zdb"
        Me.Text = "ǩ���ٵ���������"
        Me.GroupBox3.ResumeLayout(False)
        Me.grpBaseInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsTemp As DataSet

    Private Sub FSignIntentLetter_zdb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.GetData()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GetData()
        dsTemp = gWs.GetTransCondition(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID())
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            Me.cboSignOpinion.DataSource = dsTemp.Tables(0).DefaultView
            Me.cboSignOpinion.DisplayMember = "transfer_condition"
            Me.cboSignOpinion.ValueMember = "transfer_condition"
            Me.cboSignOpinion.SelectedIndex = 0
        End If

        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        dsTemp = gWs.GetReGuaranteeProjectInfo("{ProjectCode = '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtOrganizationName.Text = IIf(IsDBNull(.Item("OrganizationName")), "", .Item("OrganizationName")) '�ٵ���������
                Me.txtServiceType.Text = IIf(IsDBNull(.Item("ServiceType")), "", .Item("ServiceType"))  '����ҵ��Ʒ��              
            End With
        End If
        dsTemp = gWs.GetConfTrialInfo("{project_code = '" & Me.getProjectCode() & "' ORDER BY trial_times}", "NULL")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtRefund_Type.Text = IIf(IsDBNull(.Item("refund_type")), "", .Item("refund_type"))     '��������
                Me.txtLoan_provide_form.Text = IIf(IsDBNull(.Item("loan_provide_form")), "", .Item("loan_provide_form"))  '�ſ�����    
                Me.txtRefund_sum_average.Text = IIf(IsDBNull(.Item("refund_sum_average")), "", .Item("refund_sum_average")) 'ÿ�λ���
                Me.txtGuarantee_sum.Text = IIf(IsDBNull(.Item("guarantee_sum")), "", .Item("guarantee_sum")) '�������
                Me.txtTerms.Text = IIf(IsDBNull(.Item("terms")), "", .Item("terms"))                       '��������
            End With
        End If
        dsTemp = gWs.GetProjectOrganization("{project_code = '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtSourceServiceType.Text = IIf(IsDBNull(.Item("SourceServiceType")), "", .Item("SourceServiceType"))  '����ҵ��Ʒ��
                Me.txtSourceLoanSum.Text = IIf(IsDBNull(.Item("SourceLoanSum")), "", .Item("SourceLoanSum"))    '�����
                Me.txtSourceLoanTerm.Text = IIf(IsDBNull(.Item("SourceLoanTerm")), "", .Item("SourceLoanTerm")) '��������
            End With
        End If

        '����ǩ�����
        dsTemp = gWs.GetIntentLetterInfo("{project_code = '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.dtpSignDate.Value = IIf(IsDBNull(.Item("sign_date")), gWs.GetSysTime(), .Item("sign_date"))
                If Not IsDBNull(.Item("sign_opinion")) Then
                    Me.cboSignOpinion.SelectedValue = .Item("sign_opinion")
                End If
            End With
        End If
    End Sub

    '�鿴�ٵ��������鹦��
    '�鿴���������ύ���ٵ��������鹦�ܡ�
    Private Sub btnViewDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDoc.Click
        Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "213", UserName)
        frm.AllowTransparency = False
        frm.setIsButtonEnable(True)
        frm.ShowDialog()
    End Sub

    Private Function SaveData() As Boolean
        Try
            dsTemp = gWs.GetIntentLetterInfo("{project_code = '" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    .Item("sign_date") = Me.dtpSignDate.Value
                    .Item("sign_opinion") = Me.cboSignOpinion.Text
                    .Item("sign_person") = UserName
                End With
            Else
                MessageBox.Show("IntentLetter������")
            End If
            Dim strResult As String = gWs.UpdateIntentLetter(dsTemp, Nothing)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "����IntentLetterʧ��", strResult, "����ʧ��")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If SWDialogBox.MessageBox.Show("?1000", "�ύ") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If
            Dim strResult As String = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), Me.cboSignOpinion.Text, UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "�ύʧ��", strResult, "�ǼǷſ�")
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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    
End Class
