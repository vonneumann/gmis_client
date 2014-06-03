Public Class FUpdateProcess
    Inherits frmBaseWorkflow

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
        Me.project_group.SuspendLayout()
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'project_group
        '
        Me.project_group.Visible = True
        '
        'btnQuery
        '
        Me.btnQuery.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Visible = True
        '
        'GroupQuery
        '
        Me.GroupQuery.Visible = True
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Visible = True
        '
        'FUpdateProcess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(584, 437)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.project_group, Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.btnExit})
        Me.Name = "FUpdateProcess"
        Me.Text = "ҵ�����̸���"
        Me.project_group.ResumeLayout(False)
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsTempProject As DataSet
    Private tmpProjectID As String
    Private iIndex As Integer

    Public Event refreshTaskCommit()

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim ProjectCode As String = Me.dgQueryResult.Item(dgQueryResult.CurrentRowIndex, 0)

        If SWDialogBox.MessageBox.Show("?1000", "ҵ�����̸���") = DialogResult.Yes Then
            Dim result As String = gWs.updateProcessEx(ProjectCode)
            If result = "1" Then
                SWDialogBox.MessageBox.Show("$OperateSucceed")
                RaiseEvent refreshTaskCommit()
            End If
        End If
    End Sub

    Private Sub FReMeeting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '��ȡ��Ŀ�б�
        'Dim i As Integer
        Dim strSql As String

        '��ȡ��Ŀ�б�
        '�����ϻ���Ŀ�б�ֻ��ʾ��Ŀ����A����ļ�¼���������״̬Ϊ��F������Ŀ
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
                 " FROM dbo.queryProjectInfo" & _
                 " WHERE (isliving = 1) AND manager_A='" & UserName & "'"

        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("����Ŀ�б�!", MsgBoxStyle.Information, "ҵ�����̸���")
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
