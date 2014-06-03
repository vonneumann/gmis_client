'�ֶ������壬����ɵ������ֶ�����
'�̳й���������
Public Class frmManualTask
    Inherits MainInterface.frmBaseWorkflow

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
    Friend WithEvents combo_task As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmManualTask))
        Me.combo_task = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupQuery.SuspendLayout()
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(345, 440)
        Me.btnExit.Visible = True
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.Location = New System.Drawing.Point(169, 440)
        Me.btnQuery.Visible = True
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupQuery.Size = New System.Drawing.Size(579, 45)
        Me.GroupQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.Location = New System.Drawing.Point(257, 440)
        Me.btnEntery.Text = "�� ��(&S)"
        Me.btnEntery.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'project_group
        '
        Me.project_group.Location = New System.Drawing.Point(8, 47)
        Me.project_group.Size = New System.Drawing.Size(579, 353)
        Me.project_group.Visible = True
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Size = New System.Drawing.Size(576, 344)
        Me.dgQueryResult.Visible = True
        '
        'combo_task
        '
        Me.combo_task.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.combo_task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_task.Location = New System.Drawing.Point(40, 408)
        Me.combo_task.Name = "combo_task"
        Me.combo_task.Size = New System.Drawing.Size(264, 20)
        Me.combo_task.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label1.Location = New System.Drawing.Point(8, 412)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "����"
        '
        'frmManualTask
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 469)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.combo_task, Me.Label1, Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.project_group, Me.btnExit})
        Me.Name = "frmManualTask"
        Me.Text = "�ֶ���������"
        Me.GroupQuery.ResumeLayout(False)
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject, dsTempTask, dsTempAttend As DataSet
    Private tmpProjectID, tmpTaskID, tmpTaskStatus As String
    Private iIndex As Integer
    Public Event refreshTaskCommit()

    '�����load�¼�
    Private Sub frmManualTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '��ȡ��Ŀ�б�
        Dim i As Integer
        Dim strSql As String

        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '         " FROM dbo.ViewProjectInfo" & _
        '         " WHERE (isliving = 1)"
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
                          " FROM dbo.queryProjectInfo" & _
                          " WHERE (isliving = 1)"
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("����Ŀ�б�!", MsgBoxStyle.Information, "�ֶ�����")
            btnEntery.Enabled = False
            Exit Sub
        End If

        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        '��ȡ�����б�(ֻ��Ϊ��ɵ�����)
        'strSql = " SELECT dbo.project_task_attendee.task_id, dbo.project_task.task_name" & _
        '         " FROM dbo.project_task_attendee INNER JOIN" & _
        '         " dbo.project_task ON " & _
        '         " dbo.project_task_attendee.project_code = dbo.project_task.project_code AND" & _
        '         " dbo.project_task_attendee.workflow_id = dbo.project_task.workflow_id AND" & _
        '         " dbo.project_task_attendee.task_id = dbo.project_task.task_id" & _
        '         " WHERE dbo.project_task_attendee.task_status = 'F' AND" & _
        '         " ISNULL(dbo.project_task.task_type, '') <> 'AUTO' AND" & _
        '         " dbo.project_task_attendee.task_id NOT IN ('Application') AND" & _
        '         " dbo.project_task_attendee.project_code =" & "'" & tmpProjectID & "'"

        refreshTaskList()
       
    End Sub

    '����ѡ�������б�ı��¼�
    Private Sub combo_task_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_task.SelectedValueChanged
        If combo_task.SelectedIndex <> 0 Then

            Dim i As Integer
            Dim strSql As String

            '��ȡ������
            Dim tmpTaskName As String = Trim(combo_task.Text)
            strSql = "task_name=" & "'" & tmpTaskName & "'"

            'ͨ����������ȡ����ID
            Dim dr() As DataRow = dsTempTask.Tables(0).Select(strSql)
            tmpTaskID = dr(0).Item("task_id")

            '��ȡ������Ĳ��������ݼ�
            strSql = "{project_code=" & "'" & tmpProjectID & "'" & " and task_id=" & "'" & tmpTaskID & "'" & "}"
            dsTempAttend = gWs.GetWfProjectTaskAttendeeInfo(strSql)


        End If
    End Sub

    '����ť�¼�
    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        If combo_task.SelectedIndex = 0 Then
            MsgBox("��ѡ��һ������!", MsgBoxStyle.Information, "�ֶ�����")
            Exit Sub
        End If

        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex

        '��ȡ��ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        response = MsgBox("�Ƿ�ȷ��Ҫ�ֶ���������?", MsgBoxStyle.YesNo, "�ֶ�����")

        '����StartTaskByManual����������Ŀ��ѡ�����ֶ�����
        If response = MsgBoxResult.Yes Then
            strErr = gWs.StartTaskByManual("01", tmpProjectID, tmpTaskID)
            If strErr = "1" Then
                MsgBox("�����ѱ��ֹ�����!", MsgBoxStyle.Information, "�ֶ�����")
                RaiseEvent refreshTaskCommit()
            Else
                MsgBox("�ֶ���������ʧ��:" & strErr, MsgBoxStyle.Critical, "�ֶ�����")
            End If
        End If

    End Sub


    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged
        Static lastRow As Integer = -1
        If dgQueryResult.CurrentRowIndex <> lastRow Then
            combo_task.SelectedIndex = 0

            iIndex = dgQueryResult.CurrentRowIndex
            '��ȡ��ĿID
            tmpProjectID = dgQueryResult.Item(iIndex, 0)

        End If
        lastRow = dgQueryResult.CurrentRowIndex

        refreshTaskList()

    End Sub

    'ˢ�������б�
    Private Sub refreshTaskList()
        Dim strSql As String
        Dim i As Integer
        combo_task.Items.Clear()

        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        If iIndex >= 0 Then
            tmpProjectID = dgQueryResult.Item(iIndex, 0)
        Else
            tmpProjectID = Me.txtProjectCode.Text
        End If


        '�ڲ����˱��л�ȡ����ɵ�����,�ų���¼�����������ۣ�RecordReviewConclusion����
        '���뵣��������(ApplyLetterIntent)
        'strSql = " select distinct p.task_id,t.task_name from project_task_attendee p,task_template t " & _
        '        " where p.task_id=t.task_id and p.workflow_id=t.workflow_id" & _
        '        " and p.task_id <> 'Application' and p.task_status='F'" & _
        '        " and p.project_code=" & "'" & tmpProjectID & "'" & _
        '        " and p.attend_person='" & UserName & "' and isnull(t.task_type,'')<>'AUTO' " & _
        '        " order by t.task_name"

        strSql = " select distinct p.task_id,t.task_name from project_task_attendee p,task_template t " & _
                " where p.task_id=t.task_id and p.workflow_id=t.workflow_id" & _
                " and not p.task_id in ('Application','RecordReviewConclusion','ApplyLetterIntent') and p.task_status='F'" & _
                " and p.project_code=" & "'" & tmpProjectID & "'" & _
                " and p.attend_person='" & UserName & "' and isnull(t.task_type,'')<>'AUTO' " & _
                " order by t.task_name"
        dsTempTask = gWs.GetCommonQueryInfo(strSql)
        combo_task.Items.Insert(0, "--��ѡ��һ������--")

        '�������ѡ�������б�
        For i = 0 To dsTempTask.Tables(0).Rows.Count - 1
            combo_task.Items.Add(dsTempTask.Tables(0).Rows(i).Item("task_name"))
        Next

        combo_task.SelectedIndex = 0
    End Sub

    Private Sub btnQueryProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryProject.Click
        Dim strSql As String
        Dim tmpProjectCode, tmpCorporation As String
        tmpProjectCode = Trim(txtProjectCode.Text)
        tmpCorporation = Trim(txtCorporation.Text)
        If tmpProjectCode = "" Then
            If tmpCorporation = "" Then
                strSql = ""
            End If
            strSql = "EnterpriseName like '%" & tmpCorporation & "%'"
        Else
            strSql = "ProjectCode like '%" & tmpProjectCode & "%'"
        End If
        dsTempProject.Tables(0).DefaultView.RowFilter = strSql

        Dim index As Integer
        index = Me.dgQueryResult.CurrentRowIndex()

        If index < 0 Then
            Me.btnEntery.Enabled = False
            Me.btnQuery.Enabled = False
            Exit Sub
        Else
            Me.btnEntery.Enabled = True
            Me.btnQuery.Enabled = True
        End If

        refreshTaskList()
    End Sub

End Class
