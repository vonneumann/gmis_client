'ί�д���
'�̳й���������

Public Class frmConsignTask
    Inherits MainInterface.frmBaseWorkflow

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    Public Sub New(ByVal userName As String)
        tmpUserName = userName
        InitializeComponent()
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
    Friend task_name As System.Windows.Forms.DataGridTextBoxColumn

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_currentTask As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_consign As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_roleID As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_Staff As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConsignTask))
        Me.task_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chk_currentTask = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_consign = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.combo_roleID = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combo_Staff = New System.Windows.Forms.ComboBox()
        Me.GroupQuery.SuspendLayout()
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Visible = True
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.Visible = True
        '
        'GroupQuery
        '
        Me.GroupQuery.Size = New System.Drawing.Size(572, 45)
        Me.GroupQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.Text = "ȷ ��(&O)"
        Me.btnEntery.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'project_group
        '
        Me.project_group.Location = New System.Drawing.Point(8, 0)
        Me.project_group.Size = New System.Drawing.Size(576, 336)
        Me.project_group.Visible = True
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.task_name})
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Size = New System.Drawing.Size(572, 326)
        Me.dgQueryResult.Visible = True
        '
        'task_name
        '
        Me.task_name.Format = ""
        Me.task_name.FormatInfo = Nothing
        Me.task_name.HeaderText = "��������"
        Me.task_name.MappingName = "task_name"
        Me.task_name.NullText = ""
        Me.task_name.Width = 150
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.chk_currentTask, Me.GroupBox3, Me.GroupBox2, Me.GroupBox1})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 336)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(576, 60)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'chk_currentTask
        '
        Me.chk_currentTask.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.chk_currentTask.Location = New System.Drawing.Point(408, 20)
        Me.chk_currentTask.Name = "chk_currentTask"
        Me.chk_currentTask.Size = New System.Drawing.Size(128, 24)
        Me.chk_currentTask.TabIndex = 16
        Me.chk_currentTask.Text = "�Ƿ�ί�е�ǰ����"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.combo_consign})
        Me.GroupBox3.Location = New System.Drawing.Point(248, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 40)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "������"
        '
        'combo_consign
        '
        Me.combo_consign.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.combo_consign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_consign.Location = New System.Drawing.Point(16, 12)
        Me.combo_consign.Name = "combo_consign"
        Me.combo_consign.Size = New System.Drawing.Size(88, 20)
        Me.combo_consign.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.combo_roleID})
        Me.GroupBox2.Location = New System.Drawing.Point(120, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 40)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ί�н�ɫ"
        '
        'combo_roleID
        '
        Me.combo_roleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_roleID.Location = New System.Drawing.Point(16, 13)
        Me.combo_roleID.Name = "combo_roleID"
        Me.combo_roleID.Size = New System.Drawing.Size(88, 20)
        Me.combo_roleID.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.combo_Staff})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 40)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ί����"
        '
        'combo_Staff
        '
        Me.combo_Staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Staff.Location = New System.Drawing.Point(8, 13)
        Me.combo_Staff.Name = "combo_Staff"
        Me.combo_Staff.Size = New System.Drawing.Size(88, 20)
        Me.combo_Staff.TabIndex = 0
        '
        'frmConsignTask
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 435)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnQuery, Me.btnEntery, Me.project_group, Me.btnExit, Me.GroupBox4, Me.GroupQuery})
        Me.Name = "frmConsignTask"
        Me.Text = "����ί��"
        Me.GroupQuery.ResumeLayout(False)
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private tmpUserName As String
    Private strSql As String
    Private tmpRoleID As String
    Private tmpConsigner As String
    Private dsTempProject, dsTempRole As DataSet
    Private i, j As Integer
    Private dsTempStaff As DataSet
    Public Event refreshTaskCommit()

    Private Sub frmConsignTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GroupQuery.Visible = False

        '��ȡ���еĽ�ɫ��Ա�����ݼ�
        dsTempRole = gWs.GetRole("%")
        dsTempStaff = gWs.GetStaff("%")

        refreshStaffList()

    End Sub


    Private Sub combo_roleID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_roleID.SelectedValueChanged

        combo_consign.DataSource = Nothing
        combo_consign.Items.Clear()


        '��ȡ��ɫ��
        Dim tmpRoleName As String = Trim(combo_roleID.Text)

        'ͨ����ɫ����ȡ��ɫID
        strSql = "role_name=" & "'" & tmpRoleName & "'"
        Dim drRoleID() As DataRow = dsTempRole.Tables(0).Select(strSql)
        tmpRoleID = drRoleID(0).Item("role_id")

        '��Ա�����ݼ��󶨵�ί����ѡ�������б�
        If combo_consign.DataSource = Nothing Then
            combo_consign.DataSource = dsTempStaff.Tables(0)
            combo_consign.DisplayMember = "staff_name"
            combo_consign.ValueMember = "staff_name"
        End If

        'For i = 0 To dsTempStaff.Tables(0).Rows.Count - 1
        '    combo_consign.Items.Add(dsTempStaff.Tables(0).Rows(i).Item("staff_name"))
        'Next
        strSql = "{staff_name=" & "'" & tmpUserName & "'" & " and role_id=" & "'" & tmpRoleID & "'" & "}"
        Dim dsTempRoleID As DataSet = gWs.GetStaffByRoleID(strSql)
        tmpConsigner = IIf(IsDBNull(dsTempRoleID.Tables(0).Rows(0).Item("consigner")), "", dsTempRoleID.Tables(0).Rows(0).Item("consigner"))

        '�ж��Ƿ�����������
        If tmpConsigner <> "" Then
            combo_consign.SelectedValue = tmpConsigner
        Else
            combo_consign.SelectedIndex = -1
        End If

        dsTempProject.Tables(0).DefaultView.RowFilter = "role_id='" & tmpRoleID & "'"
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

    End Sub

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click

        If combo_Staff.Text = "" Then
            MsgBox("��ѡ��һ��ί����!", MsgBoxStyle.Information, "ί��")
            Exit Sub
        End If

        If combo_roleID.Text = "" Then
            MsgBox("��ѡ��һ����ɫ!", MsgBoxStyle.Information, "ί��")
            Exit Sub
        End If

        If combo_consign.Text = "" Then
            MsgBox("��ѡ��һ��������!", MsgBoxStyle.Information, "ί��")
            Exit Sub
        End If

        Dim response As MsgBoxResult
        Dim strErr As String
        response = MsgBox("�Ƿ�ȷ��Ҫί��!", MsgBoxStyle.YesNo, "ί��")

        '����consignTask����ί������
        If response = MsgBoxResult.Yes Then

            '�ж�ί�������������Ƿ�Ϊͬһ��,�����ͬ,����
            If Trim(combo_Staff.Text) = Trim(combo_consign.Text) Then
                MsgBox("ί��ʧ��,ί�����������˲���Ϊͬһ��!", MsgBoxStyle.Critical, "ί��")
                Exit Sub
            End If

            strErr = gWs.consignTask(tmpUserName, tmpRoleID, Trim(combo_consign.Text), chk_currentTask.Checked)
            If strErr = "1" Then
                MsgBox("ί�гɹ�!", MsgBoxStyle.Information, "ί��")
                RaiseEvent refreshTaskCommit()
            Else
                MsgBox("ί��ʧ��:" & strErr, MsgBoxStyle.Critical, "ί��")
            End If
        End If


        combo_consign.DataSource = Nothing
        combo_consign.Items.Clear()
        refreshProjectList()
    End Sub

    'ˢ��Ա���б�
    Private Sub refreshStaffList()

        combo_roleID.Items.Clear()

        Dim strSql As String
        Dim i As Integer
        Dim tmpStaffName As String

        '���Ա��ѡ�������б�
        For i = 0 To dsTempStaff.Tables(0).Rows.Count - 1
            tmpStaffName = dsTempStaff.Tables(0).Rows(i).Item("staff_name")
            combo_Staff.Items.Add(tmpStaffName)
        Next


    End Sub


    'ˢ����Ŀ�б�
    Private Sub refreshProjectList()

        Dim strSql As String

        '��ʾ���û����ڴ�����Ŀ�����񣬲������Ŀ�б�
        'strSql = " SELECT dbo.ViewProjectInfo.ProjectCode, dbo.ViewProjectInfo.EnterpriseName," & _
        '         " dbo.ViewProjectInfo.phase, dbo.ViewProjectInfo.Status, dbo.project_task.task_name," & _
        '         " dbo.project_task.start_time" & _
        '         " FROM dbo.project_task_attendee INNER JOIN" & _
        '         " dbo.project_task ON " & _
        '         " dbo.project_task_attendee.project_code = dbo.project_task.project_code AND" & _
        '         " dbo.project_task_attendee.workflow_id = dbo.project_task.workflow_id AND" & _
        '         " dbo.project_task_attendee.task_id = dbo.project_task.task_id INNER JOIN" & _
        '         " dbo.ViewProjectInfo ON" & _
        '         " dbo.project_task.project_code = dbo.ViewProjectInfo.ProjectCode" & _
        '         " WHERE dbo.project_task_attendee.task_status = 'P' AND" & _
        '         " dbo.project_task_attendee.attend_person =" & "'" & tmpUserName & "'"
        strSql = " SELECT v.ProjectCode, v.EnterpriseName," & _
                         " v.phase, v.Status, dbo.project_task.task_name," & _
                         " dbo.project_task.start_time,dbo.project_task_attendee.role_id" & _
                         " FROM dbo.project_task_attendee INNER JOIN" & _
                         " dbo.project_task ON " & _
                         " dbo.project_task_attendee.project_code = dbo.project_task.project_code AND" & _
                         " dbo.project_task_attendee.workflow_id = dbo.project_task.workflow_id AND" & _
                         " dbo.project_task_attendee.task_id = dbo.project_task.task_id INNER JOIN" & _
                         " dbo.queryProjectInfo v ON" & _
                         " dbo.project_task.project_code = v.ProjectCode" & _
                         " WHERE dbo.project_task_attendee.task_status = 'P' AND" & _
                         " dbo.project_task_attendee.attend_person =" & "'" & tmpUserName & "'"
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0)
        If dgQueryResult.CurrentRowIndex < 0 Then
            'Me.btnEntery.Enabled = False
            Me.btnQuery.Enabled = False
        End If
    End Sub

    Private Sub combo_Staff_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Staff.SelectedValueChanged

        combo_roleID.Items.Clear()
        combo_consign.DataSource = Nothing
        combo_consign.Items.Clear()

        Dim strSql As String
        Dim i As Integer
        tmpUserName = combo_Staff.Text
        strSql = "{staff_name=" & "'" & tmpUserName & "'" & "}"
        Dim dsTempRoleID As DataSet = gWs.GetStaffByRoleID(strSql)
        Dim tmpRoleID, tmpRoleName As String

        '��ȡԱ����ɫ���ݼ��п���ί�еĽ�ɫ��������ɫѡ�������б�
        For i = 0 To dsTempRoleID.Tables(0).Rows.Count - 1
            tmpRoleID = dsTempRoleID.Tables(0).Rows(i).Item("role_id")
            strSql = "role_id=" & "'" & tmpRoleID & "'" & " and isConsign=1"
            If dsTempRole.Tables(0).Select(strSql).Length <> 0 Then
                tmpRoleName = dsTempRole.Tables(0).Select(strSql)(0).Item("role_name")
                combo_roleID.Items.Add(tmpRoleName)
            End If
        Next

        refreshProjectList()

     

    End Sub

End Class
