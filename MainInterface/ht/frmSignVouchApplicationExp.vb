Public Class frmSignVouchApplicationExp
    Inherits MainInterface.frmVouchApplicationExp

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д dispose ����������б�
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

    'ע��: ���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Public WithEvents cmbSignVouchOpinion As System.Windows.Forms.ComboBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSignVouchApplicationExp))
        Me.cmbSignVouchOpinion = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnViewAffirmContent
        '
        Me.btnViewAffirmContent.Location = New System.Drawing.Point(32, 448)
        Me.btnViewAffirmContent.Name = "btnViewAffirmContent"
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(128, 448)
        Me.btnQuery.Name = "btnQuery"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 352)
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(376, 449)
        Me.btnCommit.Name = "btnCommit"
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Location = New System.Drawing.Point(256, 449)
        Me.btnUploadReport.Name = "btnUploadReport"
        Me.btnUploadReport.Text = "�鿴չ��������"
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Location = New System.Drawing.Point(136, 449)
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        '
        'dgDatum
        '
        Me.dgDatum.Name = "dgDatum"
        Me.dgDatum.Size = New System.Drawing.Size(530, 332)
        '
        'Label1
        '
        Me.Label1.Name = "Label1"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Name = "txtEnterpriseName"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(464, 449)
        Me.btnExit.Name = "btnExit"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'cmbSignVouchOpinion
        '
        Me.cmbSignVouchOpinion.Location = New System.Drawing.Point(104, 24)
        Me.cmbSignVouchOpinion.Name = "cmbSignVouchOpinion"
        Me.cmbSignVouchOpinion.Size = New System.Drawing.Size(408, 20)
        Me.cmbSignVouchOpinion.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(24, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "ǩ�����"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbSignVouchOpinion)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 384)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 56)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'frmSignVouchApplicationExp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(554, 480)
        Me.Controls.Add(Me.GroupBox2)
        Me.MinimizeBox = False
        Me.Name = "frmSignVouchApplicationExp"
        Me.Text = "ǩ��չ��֪ͨ��(չ��)"
        Me.Controls.SetChildIndex(Me.btnViewAffirmContent, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnUploadReport, 0)
        Me.Controls.SetChildIndex(Me.btnConferenceTrial, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtEnterpriseName, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.btnQuery, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSignVouchApplicationExp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsConclusion As DataSet
        dsConclusion = gWs.GetTransCondition(MyBase.getWorkFlowID, MyBase.getProjectCode, MyBase.getTaskID)
        cmbSignVouchOpinion.DataSource = dsConclusion.Tables(0) '.Tables("project_task_transfer") �������޸�
        cmbSignVouchOpinion.DisplayMember = "transfer_condition"
        cmbSignVouchOpinion.ValueMember = "transfer_condition"
    End Sub

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        If SWDialogBox.MessageBox.Show("?1000", "�ύ") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim strResult As String = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), Trim(cmbSignVouchOpinion.SelectedValue), UserName)
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
End Class
