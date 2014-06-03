

Public Class FReMeeting
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FReMeeting))
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.Visible = True
        '
        'GroupQuery
        '
        Me.GroupQuery.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Visible = True
        '
        'project_group
        '
        Me.project_group.Visible = True
        '
        'FReMeeting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 437)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.project_group, Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.btnExit})
        Me.Name = "FReMeeting"
        Me.Text = "�����ϻ�"
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_group.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private tmpProjectID As String
    Private iIndex As Integer

    Public Event refreshTaskCommit()

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim ProjectCode As String = Me.dgQueryResult.Item(dgQueryResult.CurrentRowIndex, 0)
        If SWDialogBox.MessageBox.Show("?1000", "�����ϻ�") = DialogResult.Yes Then
            Dim result As String = gWs.ReMeetingPlan(ProjectCode)
            If result = "1" Then
                SWDialogBox.MessageBox.Show("$OperateSucceed")
                RaiseEvent refreshTaskCommit()
            Else
                SWDialogBox.MessageBox.Show("*999", "�����ϻ�ʧ��", result, "")
            End If
        End If
    End Sub

    Private Sub FReMeeting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '��ȡ��Ŀ�б�
        'Dim i As Integer
        Dim strSql As String

        '��ȡ��Ŀ�б�
        '�����ϻ���Ŀ�б�ֻ��ʾ��Ŀ����A����ļ�¼���������״̬Ϊ��F������Ŀ
        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '         " FROM dbo.queryProjectInfo" & _
        '         " WHERE (isliving = 1) AND manager_A='" & UserName & "'"
        'strSql = "select ProjectCode, EnterpriseName, phase, Status from queryProjectinfo" & _
        '        " where projectcode in (" & _
        '        " select project_code from project_task_attendee " & _
        '        " where manager_A='" & UserName & "' and StartTime is null)"
        'strSql = " select ProjectCode , EnterpriseName,phase,status from viewprojectinfo " & _
        ' " where guaranteesum is not null and manager_a='" & UserName & "'" & _
        ' " and certificate_sum is null " & _
        ' " and loan_sum is null " & _
        ' " UNION " & _
        ' " select ProjectCode as project_code,EnterpriseName,phase,status from viewProjectInfo " & _
        ' " where rtrim(isnull(LoanType,''))='��ηſ�' and isnull(loan_sum,0)<isnull(GuaranteeSum,0) and isnull(manager_a,'')='" & UserName & "'" & _
        ' " and isliving<>0 "
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
               " FROM dbo.queryProjectInfo" & _
               " WHERE  (isliving = 1) and (manager_A='" & UserName & "'" & _
               " or (select top 1 attend_person from project_task_attendee where project_task_attendee.project_code=queryProjectInfo.ProjectCode and role_id='24')='" & UserName & "') "
        '" where projectcode in (" & _
        '" select project_code from project_task_attendee " & _
        '" where manager_A='" & UserName & "')"

        ''2005-03-21 yjf modify 
        ''�޸������ϻ��б��������ύ�ϻ����Ŀ�ٴ��ύ�ϻᣨ�ſ�ǰ����Ŀ����RecordReturnReceipt����״̬��ΪF����Ŀ
        'strSql = "select ProjectCode, EnterpriseName, phase, Status from queryProjectinfo" & _
        '              " where projectcode in (" & _
        '              " select project_code from project_task_attendee " & _
        '              " where task_id='RecordReturnReceipt'  and isnull(task_status,'')<>'F' ) and manager_A='" & UserName & "' and StartTime is null"
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("����Ŀ�б�!", MsgBoxStyle.Information, "�����ϻ�")
            btnEntery.Enabled = False
            Exit Sub
        End If


        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)
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
    End Sub

End Class
