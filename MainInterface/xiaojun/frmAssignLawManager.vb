

Public Class frmAssignLawManager
    Inherits MainInterface.frmBusinessBaseWin

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmbAssignInfo As System.Windows.Forms.ComboBox
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpApplyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtApplyBranchBank As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtApplyGuaranteeTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtApplyGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtManagerB As System.Windows.Forms.TextBox
    Friend WithEvents txtManagerA As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtManagerB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtManagerA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeTerm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApplyBranchBank = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpApplyDate = New System.Windows.Forms.DateTimePicker()
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAssignInfo = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 6)
        Me.txtProjectCode.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(240, 6)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(264, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(305, 216)
        Me.btnExit.Text = "�� ��(&X)"
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtManagerB, Me.Label5, Me.txtManagerA, Me.Label4, Me.txtApplyGuaranteeTerm, Me.Label11, Me.txtApplyGuaranteeSum, Me.Label10, Me.txtApplyBranchBank, Me.Label16, Me.txtBank, Me.Label9, Me.Label13, Me.dtpApplyDate, Me.txtApplyServiceType, Me.Label8, Me.txtStatus, Me.Label7, Me.txtPhase, Me.Label6})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 152)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "��Ŀ������Ϣ"
        '
        'txtManagerB
        '
        Me.txtManagerB.Location = New System.Drawing.Point(336, 118)
        Me.txtManagerB.Name = "txtManagerB"
        Me.txtManagerB.ReadOnly = True
        Me.txtManagerB.Size = New System.Drawing.Size(144, 21)
        Me.txtManagerB.TabIndex = 48
        Me.txtManagerB.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(256, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "��Ŀ����B"
        '
        'txtManagerA
        '
        Me.txtManagerA.Location = New System.Drawing.Point(96, 118)
        Me.txtManagerA.Name = "txtManagerA"
        Me.txtManagerA.ReadOnly = True
        Me.txtManagerA.Size = New System.Drawing.Size(144, 21)
        Me.txtManagerA.TabIndex = 46
        Me.txtManagerA.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "��Ŀ����A"
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.Location = New System.Drawing.Point(336, 94)
        Me.txtApplyGuaranteeTerm.Name = "txtApplyGuaranteeTerm"
        Me.txtApplyGuaranteeTerm.ReadOnly = True
        Me.txtApplyGuaranteeTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeTerm.TabIndex = 42
        Me.txtApplyGuaranteeTerm.Text = ""
        Me.txtApplyGuaranteeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(256, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "��������(��)"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.Location = New System.Drawing.Point(96, 94)
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        Me.txtApplyGuaranteeSum.ReadOnly = True
        Me.txtApplyGuaranteeSum.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeSum.TabIndex = 40
        Me.txtApplyGuaranteeSum.Text = ""
        Me.txtApplyGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "������(��Ԫ)"
        '
        'txtApplyBranchBank
        '
        Me.txtApplyBranchBank.Location = New System.Drawing.Point(336, 70)
        Me.txtApplyBranchBank.Name = "txtApplyBranchBank"
        Me.txtApplyBranchBank.ReadOnly = True
        Me.txtApplyBranchBank.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyBranchBank.TabIndex = 38
        Me.txtApplyBranchBank.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(256, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "�������֧��"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(96, 70)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(144, 21)
        Me.txtBank.TabIndex = 36
        Me.txtBank.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "�����������"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "��������"
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.Location = New System.Drawing.Point(96, 46)
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpApplyDate.TabIndex = 33
        Me.dtpApplyDate.Value = New Date(2003, 5, 20, 0, 0, 0, 0)
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.Location = New System.Drawing.Point(336, 46)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyServiceType.TabIndex = 32
        Me.txtApplyServiceType.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(256, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "����ҵ��Ʒ��"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(336, 22)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(144, 21)
        Me.txtStatus.TabIndex = 30
        Me.txtStatus.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(256, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = " ״ ̬  "
        '
        'txtPhase
        '
        Me.txtPhase.Location = New System.Drawing.Point(96, 22)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.ReadOnly = True
        Me.txtPhase.Size = New System.Drawing.Size(144, 21)
        Me.txtPhase.TabIndex = 28
        Me.txtPhase.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = " �� ��  "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "������Ϣ "
        '
        'cmbAssignInfo
        '
        Me.cmbAssignInfo.Location = New System.Drawing.Point(104, 192)
        Me.cmbAssignInfo.Name = "cmbAssignInfo"
        Me.cmbAssignInfo.Size = New System.Drawing.Size(144, 20)
        Me.cmbAssignInfo.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSearch.Location = New System.Drawing.Point(129, 216)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 24)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "�� ѯ(&S)"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(217, 216)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(80, 24)
        Me.btnCommit.TabIndex = 10
        Me.btnCommit.Text = "�� ��(&C)"
        '
        'frmAssignLawManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 247)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.Label3, Me.cmbAssignInfo, Me.btnSearch, Me.btnCommit, Me.GroupBox1})
        Me.MinimizeBox = False
        Me.Name = "frmAssignLawManager"
        Me.Text = "���䷨����"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private bIsFormLoad As Boolean = False
    Private bIsTextChanged As Boolean = False
    Private UpdateResult As String
    Private RoleID As String = "33"
    Private ds As New DataSet()
    Private BankCode As String

    Private Sub frmAssignLawManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Me.IniComboxContral(Me.RoleID)
            Call Me.ShowIniData(Me.strProjectCode, Me.strEnterpriseName)
            Me.bIsFormLoad = True
        Catch ex As Exception
            'Michael
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub IniComboxContral(ByVal RoleID As String)
        ds = gWs.GetStaffByRoleID("{role_id='" & RoleID & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.cmbAssignInfo.Items.Add(ds.Tables(0).Rows(i).Item("staff_name"))
            Next
        End If
        ds = gWs.GetDefaultPerson(Me.getProjectCode(), "33")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.cmbAssignInfo.SelectedItem = ds.Tables(0).Rows(0).Item("Person")
        End If
    End Sub

    Private Sub ShowIniData(ByVal ProjectCode As String, ByVal EnterpriseName As String)
        ds = gWs.GetProjectInfoEx("{projectcode='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtPhase.Text = IIf(.Item("phase") Is System.DBNull.Value, "", .Item("phase"))
                Me.txtStatus.Text = IIf(.Item("status") Is System.DBNull.Value, "", .Item("status"))
                Me.dtpApplyDate.Text = IIf(.Item("applydate") Is System.DBNull.Value, "", .Item("applydate"))
                Me.txtApplyServiceType.Text = IIf(.Item("applyservicetype") Is System.DBNull.Value, "", .Item("applyservicetype"))
                Me.txtApplyBranchBank.Text = IIf(.Item("applybank") Is System.DBNull.Value, "", .Item("applybank"))
                Me.txtApplyGuaranteeSum.Text = IIf(.Item("applysum") Is System.DBNull.Value, "", .Item("applysum"))
                Me.txtApplyGuaranteeTerm.Text = IIf(.Item("applyterm") Is System.DBNull.Value, "", .Item("applyterm"))
            End With
        End If
        ds = gWs.GetProjectInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.BankCode = IIf(.Item("apply_bank") Is System.DBNull.Value, "", .Item("apply_bank"))
            End With
        End If
        ds = gWs.GetBankInfo("{bank_code='" & Me.BankCode & "'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtBank.Text = IIf(.Item("bank_name") Is System.DBNull.Value, "", .Item("bank_name"))
            End With
        End If
        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & ProjectCode & "' and role_id='24'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtManagerA.Text = IIf(.Item("attend_person") Is System.DBNull.Value, "", .Item("attend_person"))
            End With
        End If
        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & ProjectCode & "' and role_id='25'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtManagerB.Text = IIf(.Item("attend_person") Is System.DBNull.Value, "", .Item("attend_person"))
            End With
        End If
    End Sub

    Private Sub cmbAssignInfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAssignInfo.TextChanged
        If Me.bIsFormLoad = True Then Me.bIsTextChanged = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim MsgResult As MsgBoxResult
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.bIsTextChanged Then
                'Michael
                'MsgResult = MessageBox.Show("�Ƿ񱣴�����ݵ��޸ģ�", "��ʾ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
                MsgResult = SWDialogBox.MessageBox.Show("?1003")
            End If
            If MsgResult = MsgBoxResult.No Then Me.Close() : Me.bIsFormLoad = False : Me.bIsTextChanged = False
            If MsgResult = MsgBoxResult.Cancel Then Return
            If MsgResult = MsgBoxResult.Yes Then
                If Me.SaveData() = 1 Then
                    'Michael
                    'MessageBox.Show("���ݱ���ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                    Me.Close()
                End If
            End If
            Me.Close()
        Catch ex As Exception
            'Michael
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Function SaveData() As Integer
        If Me.cmbAssignInfo.Text.Trim() = "" Then
            'Michael
            'MessageBox.Show("��ѡ�������Ϣ���в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "������Ϣ")
            Me.cmbAssignInfo.Focus() : Return 0
        End If
        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.strProjectCode & "' and role_id='" & Me.RoleID & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i).Item("attend_person") = Me.cmbAssignInfo.Text
            Next
        End If
        '�����ݼ�ds�����˸��ģ��򱣴�ø��ġ�
        Me.UpdateResult = gWs.UpdateProjectTaskAttendee(ds)
        If Me.UpdateResult = "1" Then
            Me.bIsTextChanged = False : Me.bIsFormLoad = False : Return 1
        Else
            'Michael
            'MessageBox.Show("��¼����ʧ�ܣ�" + Me.UpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "��¼����ʧ�ܣ�", Me.UpdateResult, "")
            Return 0
        End If
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'Michael
            'If MessageBox.Show("�Ƿ�ȷ���ύ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            If SWDialogBox.MessageBox.Show("?1000", "�ύ") = DialogResult.Yes Then
                If Me.SaveData() = 0 Then Return
            End If
            Me.CommitWorkFlow(Me.cmbAssignInfo.Text.Trim(), Me)
        Catch ex As Exception
            'Michael
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmQueryCurrentTask(Me.RoleID)
            frm.AllowTransparency = False
            frm.ShowDialog()
        Catch ex As Exception
            'Michael
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
