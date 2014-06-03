Public Class frmSearchTrialInfo
    Inherits frmBusinessBaseWin

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    Public Sub New(ByVal projectcode As String, ByVal enterprise As String, Optional ByVal conferenceTrial As Integer = 1)
        Me.New()
        Me.str = projectcode
        Me.strEnterprise = enterprise
        Me.ConferenceTrial = conferenceTrial
    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimaryCommitee As System.Windows.Forms.TextBox
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents txtRefundType As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanType As System.Windows.Forms.TextBox
    Friend WithEvents txtAverageRefund As System.Windows.Forms.TextBox
    Friend WithEvents chkIsFinalConclusion As System.Windows.Forms.CheckBox
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    Friend WithEvents dtpApplyTrialTime As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.chkIsFinalConclusion = New System.Windows.Forms.CheckBox()
        Me.txtAverageRefund = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRefundType = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoanType = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrimaryCommitee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConclusion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpApplyTrialTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 8)
        Me.Label2.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 6)
        Me.txtProjectCode.Size = New System.Drawing.Size(104, 21)
        Me.txtProjectCode.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(256, 6)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(248, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(424, 176)
        Me.btnExit.Text = "�� ��(&X)"
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtTerms, Me.chkIsFinalConclusion, Me.txtAverageRefund, Me.Label12, Me.txtRefundType, Me.Label9, Me.txtLoanType, Me.Label10, Me.txtPrimaryCommitee, Me.Label7, Me.txtConclusion, Me.Label8, Me.Label6, Me.txtGuaranteeSum, Me.Label5, Me.txtServiceType, Me.Label4, Me.dtpApplyTrialTime, Me.Label3})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 144)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerms.Location = New System.Drawing.Point(344, 37)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(136, 21)
        Me.txtTerms.TabIndex = 20
        Me.txtTerms.Text = ""
        Me.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkIsFinalConclusion
        '
        Me.chkIsFinalConclusion.Enabled = False
        Me.chkIsFinalConclusion.Location = New System.Drawing.Point(264, 59)
        Me.chkIsFinalConclusion.Name = "chkIsFinalConclusion"
        Me.chkIsFinalConclusion.TabIndex = 18
        Me.chkIsFinalConclusion.Text = "�����ս���"
        '
        'txtAverageRefund
        '
        Me.txtAverageRefund.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAverageRefund.Location = New System.Drawing.Point(104, 109)
        Me.txtAverageRefund.Name = "txtAverageRefund"
        Me.txtAverageRefund.ReadOnly = True
        Me.txtAverageRefund.Size = New System.Drawing.Size(136, 21)
        Me.txtAverageRefund.TabIndex = 17
        Me.txtAverageRefund.Text = ""
        Me.txtAverageRefund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 14)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "ÿ�λ����(Ԫ)"
        '
        'txtRefundType
        '
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.Location = New System.Drawing.Point(344, 85)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(136, 21)
        Me.txtRefundType.TabIndex = 15
        Me.txtRefundType.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(264, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 14)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "���ʽ"
        '
        'txtLoanType
        '
        Me.txtLoanType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanType.Location = New System.Drawing.Point(104, 85)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.ReadOnly = True
        Me.txtLoanType.Size = New System.Drawing.Size(136, 21)
        Me.txtLoanType.TabIndex = 13
        Me.txtLoanType.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 14)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "���ʽ"
        '
        'txtPrimaryCommitee
        '
        Me.txtPrimaryCommitee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPrimaryCommitee.Location = New System.Drawing.Point(344, 109)
        Me.txtPrimaryCommitee.Name = "txtPrimaryCommitee"
        Me.txtPrimaryCommitee.ReadOnly = True
        Me.txtPrimaryCommitee.Size = New System.Drawing.Size(136, 21)
        Me.txtPrimaryCommitee.TabIndex = 11
        Me.txtPrimaryCommitee.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(267, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 14)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "��  �� "
        '
        'txtConclusion
        '
        Me.txtConclusion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusion.Location = New System.Drawing.Point(104, 61)
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ReadOnly = True
        Me.txtConclusion.Size = New System.Drawing.Size(136, 21)
        Me.txtConclusion.TabIndex = 9
        Me.txtConclusion.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "�������"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(264, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "��������(��)"
        '
        'txtGuaranteeSum
        '
        Me.txtGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(104, 37)
        Me.txtGuaranteeSum.Name = "txtGuaranteeSum"
        Me.txtGuaranteeSum.ReadOnly = True
        Me.txtGuaranteeSum.Size = New System.Drawing.Size(136, 21)
        Me.txtGuaranteeSum.TabIndex = 5
        Me.txtGuaranteeSum.Text = ""
        Me.txtGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "�������(��Ԫ)"
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(344, 13)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(136, 21)
        Me.txtServiceType.TabIndex = 3
        Me.txtServiceType.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(264, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ҵ��Ʒ��"
        '
        'dtpApplyTrialTime
        '
        Me.dtpApplyTrialTime.Enabled = False
        Me.dtpApplyTrialTime.Location = New System.Drawing.Point(104, 13)
        Me.dtpApplyTrialTime.Name = "dtpApplyTrialTime"
        Me.dtpApplyTrialTime.Size = New System.Drawing.Size(136, 21)
        Me.dtpApplyTrialTime.TabIndex = 1
        Me.dtpApplyTrialTime.Value = New Date(2003, 6, 13, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "��������ʱ��"
        '
        'frmSearchTrialInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 207)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1})
        Me.MinimizeBox = False
        Me.Name = "frmSearchTrialInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "����������Ϣ"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private str As String
    Private strEnterprise As String
    Private ConferenceTrial As Integer

    Private Sub frmSearchTrialInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.GetTrialInfo(Me.str)
            Me.txtProjectCode.Text = Me.str : Me.txtEnterpriseName.Text = Me.strEnterprise
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '����������Ϣ
    Private Sub GetTrialInfo(ByVal ProjectCode As String)
        Try
            Dim tempDS As DataSet
            'modified by hute �����ϻ����������Լ��
            tempDS = gWs.GetConfTrialInfo("{project_code = '" & ProjectCode & "' AND trial_times = " & Me.ConferenceTrial.ToString() & "}", "null")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    Me.dtpApplyTrialTime.Value = IIf(.Item("apply_trial_date") Is System.DBNull.Value, gWs.GetSysTime(), .Item("apply_trial_date"))
                    Me.txtServiceType.Text = IIf(.Item("service_type") Is System.DBNull.Value, "", .Item("service_type"))
                    Me.txtGuaranteeSum.Text = IIf(.Item("guarantee_sum") Is System.DBNull.Value, "", .Item("guarantee_sum"))
                    Me.txtTerms.Text = IIf(.Item("terms") Is System.DBNull.Value, "", .Item("terms"))
                    Me.txtConclusion.Text = IIf(.Item("trial_conclusion") Is System.DBNull.Value, "", .Item("trial_conclusion"))
                    Me.chkIsFinalConclusion.Checked = IIf(.Item("is_final_conclusion") Is System.DBNull.Value, False, .Item("is_final_conclusion"))
                    Me.txtPrimaryCommitee.Text = IIf(.Item("prime_committeeman") Is System.DBNull.Value, "", .Item("prime_committeeman"))
                    Me.txtLoanType.Text = IIf(.Item("loan_provide_form") Is System.DBNull.Value, "", .Item("loan_provide_form"))
                    Me.txtRefundType.Text = IIf(.Item("refund_type") Is System.DBNull.Value, "", .Item("refund_type"))
                    Me.txtAverageRefund.Text = IIf(.Item("refund_sum_average") Is System.DBNull.Value, "", .Item("refund_sum_average"))
                    If Me.txtAverageRefund.Text <> "" Then
                        Me.txtAverageRefund.Text = Numeric2Currency(Me.txtAverageRefund.Text)
                    End If
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    
End Class
