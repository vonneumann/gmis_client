Public Class FFirstReviewCancel
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FFirstReviewCancel))
        Me.GroupQuery.SuspendLayout()
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.Text = "�� ��(&T)"
        Me.btnEntery.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'project_group
        '
        Me.project_group.Visible = True
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Visible = True
        '
        'FFirstReviewCancel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(584, 437)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.project_group, Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.btnExit})
        Me.Name = "FFirstReviewCancel"
        Me.Text = "�����ݻ�"
        Me.GroupQuery.ResumeLayout(False)
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsTempProject As DataSet
    Private tmpProjectID As String
    Private iIndex As Integer
    Public Event refreshTaskCommit()

    Private Sub FFirstReviewCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '��ȡ��Ŀ�б�
        'Dim i As Integer
        Dim strSql As String

        '��ȡ��Ŀ�б�
        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '         " FROM dbo.ViewProjectInfo" & _
        '         " WHERE (isliving = 1) and phase='����'"     'and manager_A='" & UserName & "'"

        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
                         " FROM dbo.queryProjectInfo" & _
                         " WHERE (isliving = 1) and phase='����' " 'and (isnull(manager_A,'')='" & UserName & "'" & _
        '" or (select top 1 attend_person from project_task_attendee where project_task_attendee.project_code=queryProjectInfo.ProjectCode and role_id='24')='" & UserName & "') "

        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("����Ŀ�б�!", MsgBoxStyle.Information, "��Ŀ�ݻ�")
            btnEntery.Enabled = False
            Exit Sub
        End If


        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)
    End Sub

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex

        '��ȡ�б�ǰ�е���ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        response = MsgBox("�Ƿ�ȷ��Ҫ�ݻ���Ŀ?", MsgBoxStyle.YesNo, "��Ŀ�ݻ�")

        '����cancelProcess����ȡ����ѡ��Ŀ�Ĺ�����
        If response = MsgBoxResult.Yes Then

            strErr = firstReviewCancel(tmpProjectID) 'gWs.CreateProcess("��Ŀ����", Trim(tmpProjectID), UserName)
            If strErr = "1" Then
                MsgBox("��Ŀ�ݻ��ɹ�!", MsgBoxStyle.Information, "��Ŀ�ݻ�")
                dsTempProject.Tables(0).Rows(iIndex).Delete()
                dsTempProject.AcceptChanges()
                RaiseEvent refreshTaskCommit()
            Else
                MsgBox("��Ŀ�ݻ�ʧ��:" & strErr, MsgBoxStyle.Critical, "��Ŀ�ݻ�")
            End If
        Else
            Exit Sub
        End If

    End Sub


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
            'tmpProjectID = dgQueryResult.Item(iIndex, 0)
            If iIndex > -1 Then
                tmpProjectID = dgQueryResult.Item(iIndex, 0)
                Me.btnEntery.Enabled = True
                Me.btnQuery.Enabled = True
            Else
                Me.btnEntery.Enabled = False
                Me.btnQuery.Enabled = False
            End If
        End If
        lastRow = dgQueryResult.CurrentRowIndex
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

    '�����ݻ�
    Private Function firstReviewCancel(ByVal projectID As String)
        Dim i As Integer
        Dim flag As Boolean
        Dim strErr As String

        '������Ŀ������ʶisliving=0
        Dim strSql As String = "{project_code=" & "'" & projectID & "'" & "}"
        Dim dsTemp, dsTempProject, dsTempAttend, dsTempTrans, dsMsg, dsTempTask, dsTempTimingTask, dsProjectTrack As DataSet
        Dim tmpStatus, tmpAttend As String

        Try
            dsTempProject = gWs.GetProjectInfo(strSql)

            dsTempProject.Tables(0).Rows(0).Item("isliving") = 0
            dsTempProject.Tables(0).Rows(0).Item("status") = "��Ŀ�ݻ�"
            gWs.UpdateProject(dsTempProject)

            'ɾ������Ŀ��������Ϣ
            strSql = "{project_code=" & "'" & projectID & "'" & "}"
            dsMsg = gWs.GetWfProjectMessagesInfo(strSql)

            For i = 0 To dsMsg.Tables(0).Rows.Count - 1
                dsMsg.Tables(0).Rows(i).Delete()
            Next
            gWs.UpdateWfProjectMessages(dsMsg)



            ''�����������Ŀ��������Ա������Ŀ��������Ϣ
            'Dim workflowID, taskID As String

            'strSql = " select distinct attend_person from project_task_attendee" & _
            '         " where project_code=" & "'" & projectID & "'" & _
            '         " and attend_person<>''"
            'dsTemp = gWs.GetCommonQueryInfo(strSql)
            'For i = 0 To dsTemp.Tables(0).Rows.Count - 1
            '    tmpAttend = dsTemp.Tables(0).Rows(i).Item("attend_person")
            '    'workflowID = dsTemp.Tables(0).Rows(i).Item("workflow_id")
            '    taskID = dsTemp.Tables(0).Rows(i).Item("task_id")
            '    gWs.AddMsg("", projectID, taskID, tmpAttend, "8", "N")
            'Next


            'ɾ����������˱�����Ŀ���������
            strSql = "{project_code=" & "'" & projectID & "'" & "}"
            dsTempAttend = gWs.GetWfProjectTaskAttendeeInfo(strSql)
            For i = 0 To dsTempAttend.Tables(0).Rows.Count - 1
                dsTempAttend.Tables(0).Rows(i).Delete()
            Next
            gWs.UpdateWfProjectTaskAttendee(dsTempAttend)

            'ɾ��ת�Ʊ��е���ϸ��¼
            strSql = "{project_code=" & "'" & projectID & "'" & "}"
            dsTempTrans = gWs.GetWfProjectTaskTransferInfo(strSql)
            For i = 0 To dsTempTrans.Tables(0).Rows.Count - 1
                dsTempTrans.Tables(0).Rows(i).Delete()
            Next
            gWs.UpdateWfProjectTaskTransfer(dsTempTrans)

            'ɾ����ʱ������ָ����Ŀ����Ķ�ʱ����
            strSql = "{project_code=" & "'" & projectID & "'" & "}"
            dsTempTimingTask = gWs.GetWfProjectTimingTaskInfo(strSql)
            For i = 0 To dsTempTimingTask.Tables(0).Rows.Count - 1
                dsTempTimingTask.Tables(0).Rows(i).Delete()
            Next
            gWs.UpdateWfProjectTimingTask(dsTempTimingTask)

            'ɾ��������ٱ��еļ�¼
            strSql = "{project_code=" & "'" & projectID & "'" & "}"
            dsProjectTrack = gWs.GetWfProjectTrackInfo(strSql)
            For i = 0 To dsProjectTrack.Tables(0).Rows.Count - 1
                dsProjectTrack.Tables(0).Rows(i).Delete()
            Next
            gWs.UpdateWfProjectTrack(dsTempTimingTask)

            'ɾ��������е�����
            strSql = "{project_code=" & "'" & projectID & "'" & "}"
            dsTempTask = gWs.GetWfProjectTaskInfo(strSql)
            For i = 0 To dsTempTask.Tables(0).Rows.Count - 1

                dsTempTask.Tables(0).Rows(i).Delete()
            Next
            gWs.UpdateWfProjectTask(dsTempTask)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            strErr = ex.ToString
            flag = True
        End Try
        If flag Then
            Return strErr
        Else
            Return "1"
        End If
    End Function
End Class
