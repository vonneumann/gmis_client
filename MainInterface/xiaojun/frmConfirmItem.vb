

Public Class frmConfirmItem
    Inherits MainInterface.frmBusinessBaseWin

    Protected bIsTextChanged As Boolean = False
    Protected bIsFormLoad As Boolean = False
    Protected UpdateResult As Integer
    Protected strItemType, strItemCode As String
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtManagerB As System.Windows.Forms.TextBox
    Friend WithEvents txtManagerA As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtApplySum As System.Windows.Forms.TextBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents txtOpinion As System.Windows.Forms.TextBox
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnOpenFile As System.Windows.Forms.Button
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents cmbConclusion As System.Windows.Forms.ComboBox
    Public WithEvents ds As System.Data.DataSet
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOpinion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbConclusion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtManagerB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtManagerA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApplyTerm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApplySum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.ds = New System.Data.DataSet()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 14)
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 24)
        Me.Label2.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Size = New System.Drawing.Size(280, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(448, 368)
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOpinion, Me.Label11, Me.cmbConclusion, Me.Label10, Me.txtManagerB, Me.Label8, Me.txtManagerA, Me.Label9, Me.txtApplyServiceType, Me.Label7, Me.Label5, Me.txtApplyTerm, Me.Label6, Me.Label4, Me.txtApplySum, Me.Label3})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 304)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "��Ŀ������Ϣ"
        '
        'txtOpinion
        '
        Me.txtOpinion.Location = New System.Drawing.Point(104, 120)
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(376, 136)
        Me.txtOpinion.TabIndex = 21
        Me.txtOpinion.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(24, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 32)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "****"
        '
        'cmbConclusion
        '
        Me.cmbConclusion.ItemHeight = 12
        Me.cmbConclusion.Location = New System.Drawing.Point(352, 272)
        Me.cmbConclusion.Name = "cmbConclusion"
        Me.cmbConclusion.Size = New System.Drawing.Size(128, 20)
        Me.cmbConclusion.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(248, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "*****"
        '
        'txtManagerB
        '
        Me.txtManagerB.Location = New System.Drawing.Point(352, 88)
        Me.txtManagerB.Name = "txtManagerB"
        Me.txtManagerB.ReadOnly = True
        Me.txtManagerB.Size = New System.Drawing.Size(128, 21)
        Me.txtManagerB.TabIndex = 11
        Me.txtManagerB.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(272, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "��Ŀ����B��"
        '
        'txtManagerA
        '
        Me.txtManagerA.Location = New System.Drawing.Point(104, 88)
        Me.txtManagerA.Name = "txtManagerA"
        Me.txtManagerA.ReadOnly = True
        Me.txtManagerA.Size = New System.Drawing.Size(128, 21)
        Me.txtManagerA.TabIndex = 9
        Me.txtManagerA.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "��Ŀ����A��"
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.Location = New System.Drawing.Point(104, 56)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyServiceType.TabIndex = 7
        Me.txtApplyServiceType.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "����ҵ��Ʒ��"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(488, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "��"
        '
        'txtApplyTerm
        '
        Me.txtApplyTerm.Location = New System.Drawing.Point(352, 24)
        Me.txtApplyTerm.Name = "txtApplyTerm"
        Me.txtApplyTerm.ReadOnly = True
        Me.txtApplyTerm.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyTerm.TabIndex = 4
        Me.txtApplyTerm.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(272, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "���뵣������"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(240, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "��Ԫ"
        '
        'txtApplySum
        '
        Me.txtApplySum.Location = New System.Drawing.Point(104, 24)
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.ReadOnly = True
        Me.txtApplySum.Size = New System.Drawing.Size(128, 21)
        Me.txtApplySum.TabIndex = 1
        Me.txtApplySum.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "���뵣�����"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(360, 368)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(80, 24)
        Me.btnCommit.TabIndex = 7
        Me.btnCommit.Text = "�ύ(&C)"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(272, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "����(&S)"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(152, 368)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(112, 24)
        Me.btnOpenFile.TabIndex = 9
        Me.btnOpenFile.Text = "����Ŀ�ݻ�����(&O)"
        '
        'ds
        '
        Me.ds.DataSetName = "NewDataSet"
        Me.ds.Locale = New System.Globalization.CultureInfo("zh-CN")
        '
        'frmConfirmItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 399)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnOpenFile, Me.btnSave, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.btnCommit, Me.GroupBox1})
        Me.Name = "frmConfirmItem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmConfirmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Me.GetConclusionList()
            'Call Me.GetIniData(Me.strItemType, Me.strItemCode)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub GetConclusionList()
        ds = gWs.GetTransCondition(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If Not ds.Tables(0).Rows(i).Item("transfer_condition") Is System.DBNull.Value Then
                    With Me.cmbConclusion.Items
                        .Add(ds.Tables(0).Rows(i).Item("transfer_condition"))
                    End With
                End If
            Next
        End If
    End Sub

    '���෽���е���
    Public Sub GetIniData(ByVal ItemType As String, ByVal ItemCode As String)
        ds = gWs.GetProjectInfoEx("{projectcode like '" & Me.strProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtApplyServiceType.Text = IIf(.Item("applyservicetype") Is System.DBNull.Value, "", .Item("applyservicetype"))
                Me.txtApplySum.Text = IIf(.Item("applysum") Is System.DBNull.Value, 0, .Item("applysum"))
                Me.txtApplyTerm.Text = IIf(.Item("applyterm") Is System.DBNull.Value, 0, .Item("applyterm"))
                Me.txtManagerA.Text = IIf(.Item("24") Is System.DBNull.Value, "", .Item("24"))
                Me.txtManagerB.Text = IIf(.Item("25") Is System.DBNull.Value, "", .Item("25"))
            End With
        End If
        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='" & ItemType & "' and item_code='" & ItemCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtOpinion.Text = IIf(.Item("content") Is System.DBNull.Value, "", .Item("content"))
                Me.cmbConclusion.Text = IIf(.Item("conclusion") Is System.DBNull.Value, "", .Item("conclusion"))
            End With
        End If
    End Sub

    '���෽���е���
    Public Function SaveData(ByVal ItemType As String, ByVal ItemCode As String) As Boolean
        If Me.cmbConclusion.Text.Trim() = "" Then
            MessageBox.Show("��ѡ����۽��в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbConclusion.Focus()
            Return False
        End If
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ds = gWs.GetProjectOpinionByProjectNo _
                ("{project_code='" & Me.strProjectCode & "' and item_type='" & ItemType & "' and item_code='" & ItemCode & "'}")
            If Not ds.Tables(0).Rows.Count = 0 Then '�޸�
                With ds.Tables(0).Rows(0)
                    .Item("project_code") = Me.strProjectCode
                    .Item("item_type") = ItemType
                    .Item("item_code") = ItemCode
                    .Item("conclusion") = Me.cmbConclusion.Text.Trim()
                    .Item("content") = Me.txtOpinion.Text.Trim()
                    .Item("create_person") = Me.strUserID
                    .Item("create_date") = gWs.GetSysTime()
                End With
            Else                                    '����
                ds = gWs.GetProjectOpinionByProjectNo("null")
                Dim NewRow As DataRow = ds.Tables(0).NewRow()
                With NewRow
                    .Item("project_code") = Me.strProjectCode
                    .Item("item_type") = ItemType
                    .Item("item_code") = ItemCode
                    .Item("conclusion") = Me.cmbConclusion.Text.Trim()
                    .Item("content") = Me.txtOpinion.Text.Trim()
                    .Item("create_person") = Me.strUserID
                    .Item("create_date") = gWs.GetSysTime()
                End With
                ds.Tables(0).Rows.Add(NewRow)
            End If
            Me.UpdateResult = gWs.UpdateProjectOpinion(ds)
            If Me.UpdateResult <> "1" Then
                MessageBox.Show("����ʧ�ܣ�" + Me.UpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            Else
                MessageBox.Show("����ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.bIsFormLoad = False : Me.bIsTextChanged = False
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If MessageBox.Show("�Ƿ�ȷ���ύ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.bIsTextChanged Then
                If Not Me.SaveData(Me.strItemType, Me.strItemCode) Then
                    Return
                End If
            End If
            Call Me.CommitWorkFlow(Me.cmbConclusion.Text.Trim(), Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim DlgResult As DialogResult
        If Me.bIsTextChanged Then
            DlgResult = MessageBox.Show _
                ("�Ƿ񱣴���Ѿ��޸ĵ����ݣ�", "��ʾ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If DlgResult = DialogResult.Yes Then
                If Not Me.SaveData(Me.strItemType, Me.strItemCode) Then
                    Return
                End If
            End If
            If DlgResult = DialogResult.No Then Me.Close()
            If DlgResult = DialogResult.Cancel Then Return
        End If
        Me.Close()
    End Sub

    Protected Sub OpenFile(ByVal ItemType As String, ByVal ItemCode As String)
        Dim frm As New frmDocumentManageBusiness(Me.strProjectCode, Me.strUserID, Me.strEnterpriseName, ItemType, ItemCode, Me.strUserID)
        frm.AllowTransparency = False
        frm.setButtonEnable(False)
        frm.ShowDialog()
    End Sub

End Class
