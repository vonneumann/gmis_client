'������Ŀ��ɫ����
'�̳й���������
Public Class frmReAssignAttendee
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_staff As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents combo_role As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chbResponsible As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReAssignAttendee))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chbResponsible = New System.Windows.Forms.CheckBox()
        Me.combo_staff = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_role = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_group.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageIndex = -1
        Me.btnQuery.ImageList = Nothing
        Me.btnQuery.Location = New System.Drawing.Point(169, 456)
        Me.btnQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.ImageIndex = -1
        Me.btnEntery.ImageList = Nothing
        Me.btnEntery.Location = New System.Drawing.Point(257, 456)
        Me.btnEntery.Text = "ȷ ��(&O)"
        Me.btnEntery.Visible = True
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupQuery.Size = New System.Drawing.Size(579, 45)
        Me.GroupQuery.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(345, 456)
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
        Me.dgQueryResult.Size = New System.Drawing.Size(576, 339)
        Me.dgQueryResult.Visible = True
        '
        'project_group
        '
        Me.project_group.Size = New System.Drawing.Size(579, 349)
        Me.project_group.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.chbResponsible, Me.combo_staff, Me.Label2, Me.combo_role, Me.Label1})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 398)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 49)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'chbResponsible
        '
        Me.chbResponsible.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.chbResponsible.Location = New System.Drawing.Point(448, 19)
        Me.chbResponsible.Name = "chbResponsible"
        Me.chbResponsible.TabIndex = 4
        Me.chbResponsible.Text = "��Ŀ������"
        Me.chbResponsible.Visible = False
        '
        'combo_staff
        '
        Me.combo_staff.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.combo_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_staff.Location = New System.Drawing.Point(288, 21)
        Me.combo_staff.Name = "combo_staff"
        Me.combo_staff.Size = New System.Drawing.Size(112, 20)
        Me.combo_staff.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(240, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ա��"
        '
        'combo_role
        '
        Me.combo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_role.Location = New System.Drawing.Point(64, 21)
        Me.combo_role.Name = "combo_role"
        Me.combo_role.Size = New System.Drawing.Size(112, 20)
        Me.combo_role.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��Ŀ��ɫ"
        '
        'frmReAssignAttendee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 485)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.project_group, Me.btnExit, Me.GroupBox2})
        Me.Name = "frmReAssignAttendee"
        Me.Text = "������Ŀ��ɫ"
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_group.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private dsTempRole As DataSet
    Private dsTempStaff As DataSet
    Private tmpProjectID, tmpRoleName, tmpRoleID, tmpStaff, tmpAnotherRoleID, tmpAnotherStaff As String
    Private iIndex As Integer

    '�����load�¼�
    Private Sub frmReAssignAttendee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            MsgBox("����Ŀ�б�!", MsgBoxStyle.Information, "������Ŀ��ɫ")
            btnEntery.Enabled = False
            Exit Sub
        End If

        '��ȡ��ɫ�б�
        strSql = "%"
        dsTempRole = gWs.GetRole(strSql)
        strSql = "role_id in ('24','25','13','33','51')"
        Dim drRole() As DataRow = dsTempRole.Tables(0).Select(strSql)
        combo_role.Items.Insert(0, "--��ѡ��һ����ɫ--")

        If UserName = "��˳" Then
            strSql = "role_id in ('33')"
            drRole = dsTempRole.Tables(0).Select(strSql)
            For i = 0 To drRole.Length - 1
                combo_role.Items.Add(drRole(i).Item("role_name"))
            Next
        Else
            For i = 0 To drRole.Length - 1
                combo_role.Items.Add(drRole(i).Item("role_name"))
            Next
        End If

        combo_role.SelectedIndex = 0

        '��ȡԱ����¼��
        strSql = "%"
        dsTempStaff = gWs.GetStaff(strSql)

        'combo_role.DisplayMember = "role_name"
        'combo_role.ValueMember = "role_id"

        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)


    End Sub

    '��ɫѡ�������б�ı��¼�
    Private Sub combo_role_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_role.SelectedValueChanged

        combo_staff.Items.Clear()

        '�ж��Ƿ�Ϊ��һ��ѡ��
        If combo_role.SelectedIndex <> 0 Then
            Dim i As Integer
            Dim strSql As String

            '��ȡ��ɫ��
            tmpRoleName = Trim(combo_role.Text)

            'ͨ����ɫ����ȡ��ɫID
            strSql = "role_name=" & "'" & tmpRoleName & "'"
            Dim drRoleID() As DataRow = dsTempRole.Tables(0).Select(strSql)

            '��ȡ����Ŀ������
            tmpRoleID = drRoleID(0).Item("role_id")
            strSql = "{project_code=" & "'" & tmpProjectID & "'" & " and role_id='" & tmpRoleID & "'}"
            Dim dsTemp As DataSet = gWs.GetWfProjectTaskAttendeeInfo(strSql)
            Dim tmpRoleStaff As String = ""
            If dsTemp.Tables(0).Rows.Count <> 0 Then
                tmpRoleStaff = dsTemp.Tables(0).Rows(0).Item("attend_person")
            End If

            '���Ա���б�
            If tmpRoleName.StartsWith("������¼Ա") Or tmpRoleName.StartsWith("������") Then
                strSql = "select staff_name from staff_role where role_id='" & tmpRoleID & "'"
                Dim dsTempStaffRole As DataSet = gWs.GetCommonQueryInfo(strSql)
                For i = 0 To dsTempStaffRole.Tables(0).Rows.Count - 1
                    combo_staff.Items.Add(dsTempStaffRole.Tables(0).Rows(i).Item("staff_name"))
                Next
            Else
                For i = 0 To dsTempStaff.Tables(0).Rows.Count - 1
                    combo_staff.Items.Add(dsTempStaff.Tables(0).Rows(i).Item("staff_name"))
                Next
            End If


            If Trim(tmpRoleStaff) = "" Then
                'combo_staff.Items.Clear()
                combo_staff.SelectedIndex = -1
            Else
                combo_staff.Text = tmpRoleStaff
            End If

            'qxd add 2004-6-10 �����Ŀ������
            If tmpRoleName.StartsWith("��Ŀ����") Then
                Me.chbResponsible.Visible = True
            Else
                Me.chbResponsible.Visible = False
            End If
        End If
    End Sub

    '����ť�¼�
    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        
        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        '��Ŀ��ɫ�����ҵ�񷽷����¹������������ɫ�����ˡ�
        ChangeAttendee(tmpProjectID, tmpRoleID, Trim(combo_staff.Text))

        'qxd add 2004-6-10
        saveProjectResponsible(tmpProjectID)

    End Sub

    Private Sub dgQueryResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.DoubleClick
        combo_role.SelectedIndex = 0
        combo_staff.Text = ""
        combo_staff.Items.Clear()

    End Sub

    '������Ŀ������ChangeAttendee��ProjectID��RoleID��Employee��
    Public Function ChangeAttendee(ByVal projectID As String, ByVal roleID As String, ByVal staff As String)
        Dim strSql As String
        Dim i As Integer
        Dim response As MsgBoxResult
        response = MsgBox("�Ƿ�ȷ��Ҫ���Ľ�ɫ������!", MsgBoxStyle.YesNo, "������Ŀ��ɫ")

        If response = MsgBoxResult.Yes Then
            '    '��Ŀ����A,B�ǲ�����ͬ
            '    '    ��ȡ��һ����Ŀ�����ɫ
            '    If tmpRoleID = "24" Then
            '        tmpAnotherRoleID = "25"
            '    Else
            '        tmpAnotherRoleID = "24"
            '    End If

            '    '   ��ȡ��һ����Ŀ�����ɫ�Ĳ�����
            '    strSql = "{ProjectCode=" & "'" & tmpProjectID & "'" & "}"
            '    tmpAnotherStaff = gWs.GetProjectInfoEx(strSql).Tables(0).Rows(0).Item(tmpAnotherRoleID)

            '    If staff <> tmpAnotherStaff Then

            '��Ŀ��ɫ�����ҵ�񷽷����¹������������ɫ�����ˡ�
            '��	����Ŀ�����˱���Ŀ����ΪProjectID����ɫΪRoleID������״̬��Ϊ��F��������Ա����ΪEmployee��

            Dim strErr As String = Workflow.AssignTaskAttendee(projectID, roleID, staff)

            If strErr <> 1 Then
                MsgBox("����ʧ��:" & strErr, MsgBoxStyle.Critical, "������Ŀ��ɫ")
            Else
                MsgBox("���ĳɹ�", MsgBoxStyle.Information, "������Ŀ��ɫ")
            End If
            'Else
            '    MsgBox("��Ŀ����A,B�ǲ�����ͬ", MsgBoxStyle.Critical, "������Ŀ��ɫ")
            '    combo_staff.Text = tmpStaff
            '    Exit Function
            'End If
        End If

    End Function

    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged

        'qxd add 20034-7-23
        iIndex = dgQueryResult.CurrentRowIndex
        '��ȡ��ĿID
        If iIndex > -1 Then
            tmpProjectID = dgQueryResult.Item(iIndex, 0)
        End If

        Static lastRow As Integer = -1
        If dgQueryResult.CurrentRowIndex <> lastRow Then
            combo_role.SelectedIndex = 0
            combo_staff.Text = ""
            combo_staff.Items.Clear()

            iIndex = dgQueryResult.CurrentRowIndex
            '��ȡ��ĿID
            tmpProjectID = dgQueryResult.Item(iIndex, 0)

            'qxd add 2004-6-10 �����Ŀ������
            If Me.combo_role.Text.StartsWith("��Ŀ����") Then
                Me.chbResponsible.Visible = True
            Else
                Me.chbResponsible.Visible = False
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

    Private Sub saveProjectResponsible(ByVal ProjectCode As String)
        Try
            If Me.chbResponsible.Checked Then
                Dim ds As DataSet
                Dim dr As DataRow
                Dim count As Integer

                ds = gWs.GetProjectResponsibleInfo(ProjectCode)
                If Not ds Is Nothing Then
                    If ds.Tables("project_responsible").Rows.Count > 0 Then
                        dr = ds.Tables("project_responsible").Rows(0)
                        With dr
                            If Me.combo_role.Text.Trim = "��Ŀ����A��" Then
                                .Item("manager_A") = Me.combo_staff.Text
                            ElseIf Me.combo_role.Text.Trim = "��Ŀ����B��" Then
                                .Item("manager_B") = Me.combo_staff.Text
                            End If
                        End With
                    Else
                        dr = ds.Tables("project_responsible").NewRow
                        With dr
                            .Item("project_code") = ProjectCode
                            If Me.combo_role.Text.Trim = "��Ŀ����A��" Then
                                .Item("manager_A") = Me.combo_staff.Text
                            ElseIf Me.combo_role.Text.Trim = "��Ŀ����B��" Then
                                .Item("manager_B") = Me.combo_staff.Text
                            End If
                            .Item("create_person") = UserName
                            .Item("create_date") = gWs.GetSysTime()
                        End With
                        ds.Tables("project_responsible").Rows.Add(dr)
                    End If
                    gWs.UpdateProjectResponsible(ds)
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
End Class
