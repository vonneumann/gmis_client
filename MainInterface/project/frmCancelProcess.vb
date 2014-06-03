'��Ŀ�ݻ�����
'�̳й���������
Public Class frmCancelProcess
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCancelProcess))
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Image)
        Me.btnQuery.ImageIndex = -1
        Me.btnQuery.ImageList = Nothing
        Me.btnQuery.Name = "btnQuery"
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupQuery.Name = "GroupQuery"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Name = "btnExit"
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Location = New System.Drawing.Point(0, 8)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.Size = New System.Drawing.Size(565, 342)
        '
        'project_group
        '
        Me.project_group.Name = "project_group"
        Me.project_group.Size = New System.Drawing.Size(567, 352)
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Image)
        Me.btnEntery.ImageIndex = -1
        Me.btnEntery.ImageList = Nothing
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Text = "�� ��(&C)"
        '
        'btnQueryProject
        '
        Me.btnQueryProject.Name = "btnQueryProject"
        '
        'txtCorporation
        '
        Me.txtCorporation.Name = "txtCorporation"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'frmCancelProcess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(584, 437)
        Me.Name = "frmCancelProcess"
        Me.Text = "��Ŀ�ݻ�"
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_group.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private tmpProjectID, serviceType As String
    Private iIndex As Integer
    Public Event refreshTaskCommit()

    Private Sub frmCancelProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '��ȡ��Ŀ�б�
        'Dim i As Integer
        Dim strSql As String

        '��ȡ��Ŀ�б�
        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '         " FROM dbo.ViewProjectInfo" & _
        '         " WHERE (isliving = 1) and manager_A='" & UserName & "'"
        'add by wwd 2006-09-05
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status " & _
                 " FROM dbo.queryProjectInfo LEFT OUTER JOIN loan_notice ON queryProjectInfo.ProjectCode = loan_notice.project_code " & _
                 "  WHERE StartTime is null and (queryProjectInfo.isliving = 1) and (queryProjectInfo.manager_A='" & UserName & "'" & _
                 " or (select top 1 attend_person from project_task_attendee where project_task_attendee.project_code=queryProjectInfo.ProjectCode and role_id='24')='" & UserName & "') "


        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '                 " FROM dbo.queryProjectInfo" & _
        '                 " WHERE (isliving = 1) and isnull(manager_A,'')='" & UserName & "'"

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
        'serviceType = dgQueryResult.Item(iIndex, 4)

    End Sub

    '����Ƿ�����ڱ�
    Private Function CancelProcessDo() As Boolean
        Dim strSql As String
        '  ��ȡ������־����Ϣ���жϸ���Ŀ�Ƿ����ǩ���ſ�֪ͨ������
        strSql = "{project_code='" & tmpProjectID & "' and task_name in('������Ŀ����ƻ�', '�Ǽǳ�����ִ') }"
        Dim dsWorklog As DataSet = gWs.GetWorkLogInfo(strSql)
        If dsWorklog.Tables(0).Rows.Count <> 0 Then
            MsgBox("����Ŀ�����ڱ��׶�,�����ݻ�!", MsgBoxStyle.Information, "��Ŀ�ݻ�")
            Return False
        End If
        Return True
    End Function
    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex
        If Not CancelProcessDo() Then
            Exit Sub
        End If
        '��ȡ�б�ǰ�е���ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        response = MsgBox("�Ƿ�ȷ��Ҫ�ݻ���Ŀ?", MsgBoxStyle.YesNo, "��Ŀ�ݻ�")

        '����cancelProcess����ȡ����ѡ��Ŀ�Ĺ�����
        If response = MsgBoxResult.Yes Then

            strErr = gWs.CreateProcess("��Ŀ����", Trim(tmpProjectID), UserName)
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
            tmpProjectID = dgQueryResult.Item(iIndex, 0)
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
End Class
