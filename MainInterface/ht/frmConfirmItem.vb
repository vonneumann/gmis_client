
Public Class frmConfirmItem
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents txtOpinion As System.Windows.Forms.TextBox
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnOpenFile As System.Windows.Forms.Button
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents cmbConclusion As System.Windows.Forms.ComboBox
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents txtManagerB As System.Windows.Forms.TextBox
    Protected WithEvents txtManagerA As System.Windows.Forms.TextBox
    Protected WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Protected WithEvents txtApplyTerm As System.Windows.Forms.TextBox
    Protected WithEvents txtApplySum As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConfirmItem))
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
        Me.txtApplyTerm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApplySum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(256, 6)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(224, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 6)
        Me.txtProjectCode.Size = New System.Drawing.Size(104, 21)
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 8)
        Me.Label2.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(177, 312)
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOpinion, Me.Label11, Me.cmbConclusion, Me.Label10, Me.txtManagerB, Me.Label8, Me.txtManagerA, Me.Label9, Me.txtApplyServiceType, Me.Label7, Me.txtApplyTerm, Me.Label6, Me.txtApplySum, Me.Label3})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 272)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "��Ŀ������Ϣ"
        '
        'txtOpinion
        '
        Me.txtOpinion.Location = New System.Drawing.Point(104, 96)
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOpinion.Size = New System.Drawing.Size(352, 136)
        Me.txtOpinion.TabIndex = 21
        Me.txtOpinion.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 32)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "****"
        '
        'cmbConclusion
        '
        Me.cmbConclusion.ItemHeight = 12
        Me.cmbConclusion.Location = New System.Drawing.Point(328, 240)
        Me.cmbConclusion.Name = "cmbConclusion"
        Me.cmbConclusion.Size = New System.Drawing.Size(128, 20)
        Me.cmbConclusion.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(224, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "*****"
        '
        'txtManagerB
        '
        Me.txtManagerB.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManagerB.Location = New System.Drawing.Point(328, 70)
        Me.txtManagerB.Name = "txtManagerB"
        Me.txtManagerB.ReadOnly = True
        Me.txtManagerB.Size = New System.Drawing.Size(128, 21)
        Me.txtManagerB.TabIndex = 11
        Me.txtManagerB.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(248, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "��Ŀ����B��"
        '
        'txtManagerA
        '
        Me.txtManagerA.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManagerA.Location = New System.Drawing.Point(104, 70)
        Me.txtManagerA.Name = "txtManagerA"
        Me.txtManagerA.ReadOnly = True
        Me.txtManagerA.Size = New System.Drawing.Size(128, 21)
        Me.txtManagerA.TabIndex = 9
        Me.txtManagerA.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "��Ŀ����A��"
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyServiceType.Location = New System.Drawing.Point(104, 46)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyServiceType.TabIndex = 7
        Me.txtApplyServiceType.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "����ҵ��Ʒ��"
        '
        'txtApplyTerm
        '
        Me.txtApplyTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyTerm.Location = New System.Drawing.Point(328, 22)
        Me.txtApplyTerm.Name = "txtApplyTerm"
        Me.txtApplyTerm.ReadOnly = True
        Me.txtApplyTerm.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyTerm.TabIndex = 4
        Me.txtApplyTerm.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(248, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "��������(��)"
        '
        'txtApplySum
        '
        Me.txtApplySum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySum.Location = New System.Drawing.Point(104, 22)
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.ReadOnly = True
        Me.txtApplySum.Size = New System.Drawing.Size(128, 21)
        Me.txtApplySum.TabIndex = 1
        Me.txtApplySum.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "������(��Ԫ)"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(265, 312)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(80, 23)
        Me.btnCommit.TabIndex = 7
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(353, 312)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOpenFile.Image = CType(resources.GetObject("btnOpenFile.Image"), System.Drawing.Bitmap)
        Me.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpenFile.ImageIndex = 18
        Me.btnOpenFile.ImageList = Me.ImageListBasic
        Me.btnOpenFile.Location = New System.Drawing.Point(24, 312)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(144, 23)
        Me.btnOpenFile.TabIndex = 9
        Me.btnOpenFile.Text = "����Ŀ�ݻ�����(&O)"
        Me.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmConfirmItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(490, 343)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.btnOpenFile, Me.btnSave, Me.btnCommit, Me.GroupBox1})
        Me.MinimizeBox = False
        Me.Name = "frmConfirmItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected ds As DataSet
    Protected bIsTextChanged As Boolean = False
    Protected bIsFormLoad As Boolean = False
    Protected UpdateResult As Integer
    Protected strItemType, strItemCode As String

    Private Sub frmConfirmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.GetConclusionList()
            'Call Me.GetIniData(Me.strItemType, Me.strItemCode)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '������ѡ������cmbConlcusioin
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

    '���෽���е��ã�ȡ�öԾ���Ŀ�����Ŀ��Ŷ�Ӧ�ĵ���Ŀdataset���������Me�еĸ�Ԫ��
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

    '���෽���е��ã�
    Public Function SaveData(ByVal ItemType As String, ByVal ItemCode As String) As Boolean
        If Me.cmbConclusion.Text.Trim() = "" Then
            'MessageBox.Show("��ѡ����۽��в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "����")
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
                'MessageBox.Show("����ʧ�ܣ�" + Me.UpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("*999", "frmConfirmItem.SaveData", Me.UpdateResult, "gWs.UpdaeProjectOpinion(ds)")
                Return False
            Else
                'MessageBox.Show("����ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            End If
            Me.bIsFormLoad = False : Me.bIsTextChanged = False
            Return True
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return False
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        'If MessageBox.Show("�Ƿ�ȷ���ύ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
        If SWDialogBox.MessageBox.Show("?1000", "") = DialogResult.No Then
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
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim DlgResult As DialogResult
        If Me.bIsTextChanged Then
            'DlgResult = MessageBox.Show("�Ƿ񱣴���Ѿ��޸ĵ����ݣ�", "��ʾ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            DlgResult = SWDialogBox.MessageBox.Show("?1003")
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
