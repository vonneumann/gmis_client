

Public Class frmValidateTrackPlan  'ȷ�ϱ�����ټƻ�
    Inherits MainInterface.frmBasic
    Private ProjectCode As String
    Private CorporationName As String
    Private TaskID As String
    Private WorkFlowID As String
    Private dsTrackPlan As DataSet
    Private SystemDate As Date
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
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnNotAgree As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAgree As System.Windows.Forms.RadioButton
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents dgPlan As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgPlan = New System.Windows.Forms.DataGrid()
        Me.rbtnNotAgree = New System.Windows.Forms.RadioButton()
        Me.rbtnAgree = New System.Windows.Forms.RadioButton()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(408, 304)
        Me.btnExit.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.Enabled = False
        Me.txtCorName.Location = New System.Drawing.Point(248, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 44
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 43
        Me.txtProjectCode.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(184, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "��ҵ����"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "��Ŀ����"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgPlan})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 264)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'dgPlan
        '
        Me.dgPlan.CaptionVisible = False
        Me.dgPlan.DataMember = ""
        Me.dgPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPlan.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgPlan.Location = New System.Drawing.Point(3, 17)
        Me.dgPlan.Name = "dgPlan"
        Me.dgPlan.ReadOnly = True
        Me.dgPlan.Size = New System.Drawing.Size(490, 244)
        Me.dgPlan.TabIndex = 0
        '
        'rbtnNotAgree
        '
        Me.rbtnNotAgree.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.rbtnNotAgree.Location = New System.Drawing.Point(248, 304)
        Me.rbtnNotAgree.Name = "rbtnNotAgree"
        Me.rbtnNotAgree.Size = New System.Drawing.Size(64, 24)
        Me.rbtnNotAgree.TabIndex = 47
        Me.rbtnNotAgree.Text = "��ͬ��"
        '
        'rbtnAgree
        '
        Me.rbtnAgree.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.rbtnAgree.Checked = True
        Me.rbtnAgree.Location = New System.Drawing.Point(192, 304)
        Me.rbtnAgree.Name = "rbtnAgree"
        Me.rbtnAgree.Size = New System.Drawing.Size(48, 24)
        Me.rbtnAgree.TabIndex = 46
        Me.rbtnAgree.TabStop = True
        Me.rbtnAgree.Text = "ͬ��"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(328, 304)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 45
        Me.btnCommit.Text = "�ύ(&C)"
        '
        'frmValidateTrackPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 335)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbtnNotAgree, Me.rbtnAgree, Me.btnCommit, Me.txtCorName, Me.txtProjectCode, Me.Label8, Me.Label9, Me.GroupBox1, Me.btnExit})
        Me.Name = "frmValidateTrackPlan"
        Me.Text = "ȷ�ϱ�����ټƻ�"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ProjectCode = MyBase.getProjectCode
            CorporationName = MyBase.getCorporationName
            TaskID = MyBase.getTaskID
            WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName

            SystemDate = gWs.GetSysTime
            dsTrackPlan = New DataSet()
            dsTrackPlan = gWs.GetTracePlanInfo("{project_code LIKE '" & ProjectCode & "'}")
            dgPlan.DataMember = "trace_plan"
            dgPlan.DataSource = dsTrackPlan
            AddTableStyle()
            If dsTrackPlan.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("û�б�����ټƻ����޷�ȷ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rbtnAgree.Enabled = False : rbtnNotAgree.Enabled = False : btnCommit.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("��������" & vbCr & ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AddTableStyle()
        dgPlan.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.AllowSorting = False
        dgts.MappingName = "trace_plan"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col1.MappingName = "trace_date"
        col1.HeaderText = "�����������"
        col1.Width = 100
        col1.NullText = String.Empty
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "remark"
        col3.HeaderText = " ��ע"
        col3.Width = 400
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        dgPlan.TableStyles.Add(dgts)
    End Sub
    Private Function Affirm() As Boolean
        Dim dsOpinion As DataSet = gWs.GetProjectOpinionByProjectNo("null")
        Dim dr As DataRow = dsOpinion.Tables(0).NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("item_type") = "53"
            .Item("item_code") = "004"
            .Item("conclusion") = IIf(rbtnAgree.Checked, "ͬ��", "��ͬ��")
            .Item("create_date") = SystemDate.Date
            .Item("create_person") = UserName
        End With
        dsOpinion.Tables(0).Rows.Add(dr)
        Return (gWs.UpdateProjectOpinion(dsOpinion.GetChanges) = "1")
    End Function
    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = MessageBox.Show("ȷ���ύ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = DialogResult.No Then
                Return
            End If
        End If
        If Not Affirm() Then
            MessageBox.Show("����������������ύ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim strSuccess As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, IIf(rbtnAgree.Checked, "ͬ��", "��ͬ��"), UserName)
        If strSuccess = "1" Then
            raiseCommitSucceed()
            Close()
        Else
            MessageBox.Show("�ύʧ��" & vbCr & strSuccess, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
