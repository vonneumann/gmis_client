'��ͣ����������
'�̳й���������

Public Class frmSuspendProcess
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
    Friend workflow_status As System.Windows.Forms.DataGridTextBoxColumn

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents txtDelayDay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSuspendProcess))
        Me.workflow_status = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtDelayDay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupQuery.SuspendLayout()
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(345, 456)
        Me.btnExit.Visible = True
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.Location = New System.Drawing.Point(169, 456)
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
        Me.btnEntery.Location = New System.Drawing.Point(257, 456)
        Me.btnEntery.Text = "�� ��(&S)"
        Me.btnEntery.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'project_group
        '
        Me.project_group.Size = New System.Drawing.Size(579, 376)
        Me.project_group.Visible = True
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.workflow_status})
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Size = New System.Drawing.Size(577, 366)
        Me.dgQueryResult.Visible = True
        '
        'workflow_status
        '
        Me.workflow_status.Format = ""
        Me.workflow_status.FormatInfo = Nothing
        Me.workflow_status.HeaderText = "������״̬"
        Me.workflow_status.MappingName = "workflow_status"
        Me.workflow_status.NullText = ""
        Me.workflow_status.Width = 75
        '
        'txtDelayDay
        '
        Me.txtDelayDay.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.txtDelayDay.Location = New System.Drawing.Point(108, 429)
        Me.txtDelayDay.Name = "txtDelayDay"
        Me.txtDelayDay.Size = New System.Drawing.Size(24, 21)
        Me.txtDelayDay.TabIndex = 9
        Me.txtDelayDay.Text = "1"
        '
        'Label1
        '
        Me.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label1.Location = New System.Drawing.Point(12, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "��ͣʱ��(��):"
        '
        'frmSuspendProcess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 485)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.project_group, Me.btnExit, Me.Label1, Me.txtDelayDay})
        Me.Name = "frmSuspendProcess"
        Me.Text = "����ͻָ�������"
        Me.GroupQuery.ResumeLayout(False)
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private tmpProjectID As String
    Private isSuspend As Boolean
    Private iIndex As Integer
    Private drRow() As DataRow
    Private strSql As String
    Private tmpWorkflowStatus As String
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '�����load�¼�
    Private Sub frmSuspendProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '��ȡ��Ŀ�б�
        Dim i As Integer

        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status," & _
        '        " CASE (SELECT COUNT(*)" & _
        '        " FROM project_task_attendee" & _
        '        " WHERE task_status = 'W' AND " & _
        '        " ViewProjectInfo.ProjectCode = project_task_attendee.project_code)" & _
        '        " WHEN 0 THEN '����' ELSE '����' END AS workflow_status" & _
        '        " FROM dbo.ViewProjectInfo" & _
        '        " WHERE (isliving = 1)"
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status," & _
                " CASE (SELECT COUNT(*)" & _
                " FROM project_task_attendee" & _
                " WHERE task_status = 'W' AND " & _
                " queryProjectInfo.ProjectCode = project_task_attendee.project_code)" & _
                " WHEN 0 THEN '����' ELSE '����' END AS workflow_status" & _
                " FROM dbo.queryProjectInfo" & _
                " WHERE (isliving = 1)"
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("����Ŀ�б�!", MsgBoxStyle.Information, "����ͻָ�������")
            btnEntery.Enabled = False
            Exit Sub
        End If

        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        strSql = "ProjectCode=" & "'" & tmpProjectID & "'"
        drRow = dsTempProject.Tables(0).Select(strSql)

        If drRow(0).Item("workflow_status") = "����" Then
            isSuspend = True
            btnEntery.Text = "�ָ�(&R)"
        Else
            isSuspend = False
            btnEntery.Text = "����(&S)"
        End If

    End Sub

    '����ť�¼�
    Private Sub btnEntery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEntery.Click

        If Trim(txtDelayDay.Text) = "" Then
            MsgBox("��������ͣʱ��!", MsgBoxStyle.Information, "����ͻָ�������")
            Exit Sub
        End If

        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        '�жϹ�����״̬�Ƿ�Ϊ����
        If isSuspend Then
            response = MsgBox("�Ƿ�ȷ��Ҫ�ָ�������?", MsgBoxStyle.YesNo, "����ͻָ�������")
            '����ǹ��������resumeProcess�ָ�������
            If response = MsgBoxResult.Yes Then
                strErr = gWs.resumeProcess(Trim(tmpProjectID))
                If strErr = "1" Then
                    MsgBox("�������ѻָ�", MsgBoxStyle.Information, "����ͻָ�������")
                    dsTempProject.Tables(0).Rows(iIndex).Item("workflow_status") = "����"
                    btnEntery.Text = "����(&S)"
                    isSuspend = False
                Else
                    MsgBox("�ָ�������ʧ��:" & strErr, MsgBoxStyle.Critical, "����ͻָ�������")
                End If
            Else
                Exit Sub
            End If

        Else
            '���򣬵���suspendProcess��������
            response = MsgBox("�Ƿ�ȷ��Ҫ��������?", MsgBoxStyle.YesNo, "����ͻָ�������")
            If response = MsgBoxResult.Yes Then
                strErr = gWs.suspendProcess(Trim(tmpProjectID), CInt(Trim(txtDelayDay.Text)))
                If strErr = "1" Then
                    MsgBox("�������ѹ���", MsgBoxStyle.Information, "����ͻָ�������")
                    dsTempProject.Tables(0).Rows(iIndex).Item("workflow_status") = "����"
                    btnEntery.Text = "�ָ�(&R)"
                    isSuspend = True
                Else
                    MsgBox("��������ʧ��:" & strErr, MsgBoxStyle.Critical, "����ͻָ�������")
                End If

            Else
                Exit Sub
            End If
        End If

    End Sub

    '
    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged

        'qxd add 20034-7-23
        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        If iIndex > -1 Then
            tmpProjectID = dgQueryResult.Item(iIndex, 0)
        End If

        Static lastRow As Integer = -1
        If dgQueryResult.CurrentRowIndex <> lastRow Then

            iIndex = dgQueryResult.CurrentRowIndex
            '��ȡ��ĿID
            tmpProjectID = dgQueryResult.Item(iIndex, 0)

            'tmpWorkflowStatus = Trim(dsTempProject.Tables(0).Rows(iIndex).Item("workflow_status"))
            '2005-3-16 yjf �޸�DATAGRID��״̬��ʾ����
            strSql = "ProjectCode=" & "'" & tmpProjectID & "'"
            drRow = dsTempProject.Tables(0).Select(strSql)

            If drRow(0).Item("workflow_status") = "����" Then
                isSuspend = True
                btnEntery.Text = "�ָ�(&R)"
            Else
                isSuspend = False
                btnEntery.Text = "����(&S)"
            End If

        End If
        lastRow = dgQueryResult.CurrentRowIndex

    End Sub

    Private Sub txtDelayDay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDelayDay.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDelayDay_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDelayDay.Leave
        If Not (IsNumeric(txtDelayDay.Text)) Then
            txtDelayDay.Text = ""
        End If

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

        '���»�ȡ��ǰ��Ŀ���뼰�������б�
        dgQueryResult_CurrentCellChanged(sender, e)
    End Sub

End Class
