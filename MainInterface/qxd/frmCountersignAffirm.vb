

Public Class frmCountersignAffirm
    Inherits MainInterface.frmBasic

    Private strWorkFlowID As String
    Private strProjectCode As String
    Private strCorporationName As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String

    Private strItemType As String = "44"
    Private strItemCode As String = "005"

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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chbCountersign As System.Windows.Forms.CheckBox
    Friend WithEvents btnConclusion As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCountersignAffirm))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chbCountersign = New System.Windows.Forms.CheckBox()
        Me.btnConclusion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(262, 136)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(176, 136)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 1
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtName, Me.Label2, Me.txtCode, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(256, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(120, 21)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "��ҵ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 16)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(112, 21)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��Ŀ����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "��ǩ���"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbCountersign
        '
        Me.chbCountersign.Location = New System.Drawing.Point(112, 64)
        Me.chbCountersign.Name = "chbCountersign"
        Me.chbCountersign.Size = New System.Drawing.Size(16, 24)
        Me.chbCountersign.TabIndex = 1
        '
        'btnConclusion
        '
        Me.btnConclusion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConclusion.Image = CType(resources.GetObject("btnConclusion.Image"), System.Drawing.Bitmap)
        Me.btnConclusion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConclusion.ImageIndex = 25
        Me.btnConclusion.ImageList = Me.ImageListBasic
        Me.btnConclusion.Location = New System.Drawing.Point(63, 136)
        Me.btnConclusion.Name = "btnConclusion"
        Me.btnConclusion.Size = New System.Drawing.Size(104, 24)
        Me.btnConclusion.TabIndex = 0
        Me.btnConclusion.Text = "��������(&R)"
        Me.btnConclusion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCountersignAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(402, 167)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnConclusion, Me.chbCountersign, Me.Label3, Me.GroupBox1, Me.btnExit, Me.btnCommit})
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCountersignAffirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��ǩ���ȷ��"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmCountersignAffirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser()
        Me.strPhase = getPhase(strProjectCode)

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName
    End Sub
    '�ύ
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            'If MsgBoxResult.Yes = MsgBox("�Ƿ�ȷ���ύ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "��ʾ") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1000", "�ύ") Then
                commit()
            End If
        Else
            commit()
        End If
    End Sub
    '�ύ����
    Private Sub commit()
        'If Not isAddAffirmRecord(strProjectCode, strItemType, strItemCode) Then
        '    MsgBox("��ȷ�ϻ�ǩ�Ѿ����!", MsgBoxStyle.Exclamation, "��ʾ")
        '    Exit Sub
        'End If
        If Me.chbCountersign.Checked Then
            addAffirmRecord(strProjectCode, strItemType, strItemCode)
        End If
        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
            If "1" = strCommit Then
                'MsgBox("�ύ�ɹ�!", MsgBoxStyle.Information, "��ʾ")
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                raiseCommitSucceed()
                Me.Close()
            Else
                'MsgBox("�ύʧ��!" & strCommit, MsgBoxStyle.Critical, "��ʾ")
                SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�˳�
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '��������
    Private Sub btnConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConclusion.Click
        If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count <= 0 Then
            '��ʾ����Ч��û�пɹ����������ݡ���Ϣ��
            SWDialogBox.MessageBox.Show("$1005", " �������� ")
            Return
        End If

        Dim meet As New frmMeetRecordQuery(strProjectCode, strCorporationName)
        meet.ShowDialog()
    End Sub
    'ȷ��
    '44��005 ��ʾ��Ŀ��ǩ��ȷ��
    Private Sub chbCountersign_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbCountersign.CheckedChanged
        'addAffirmRecord(strProjectCode, strItemType, strItemCode)
    End Sub
    '
    'ȷ��ʱ,����¼�Ѿ�����,���޸�ȷ�ϼ�¼;��������һ����¼
    '�����ڱ�project_document��
    '
    Private Function addAffirmRecord(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String) As Boolean
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        Try
            ds = gWs.GetProjectDocumentByCondition("{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}")
        Catch ex As Exception
            'MsgBox("��ȡproject_documentʱ����!" & ex.Message, MsgBoxStyle.Critical, "��ʾ")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            i = ds.Tables("TProjectDocument").Rows.Count
            If i = 1 Then
                dr = ds.Tables("TProjectDocument").Rows(0)
                With dr
                    .Item("phase") = strPhase
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
            ElseIf i = 0 Then
                dr = ds.Tables("TProjectDocument").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("phase") = strPhase
                    .Item("item_type") = itemType
                    .Item("item_code") = itemCode
                    .Item("doc_name") = Me.Text
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                ds.Tables("TProjectDocument").Rows.Add(dr)
            End If
            strResult = gWs.UpdateProjectDocument(ds)
            If strResult = "1" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    '�ж��Ƿ�����project_document�����һ����¼
    Private Function isAddAffirmRecord(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        Try
            ds = gWs.GetProjectDocumentByCondition("{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}")
        Catch ex As Exception
            'MsgBox("��ȡproject_documentʱ����!" & ex.Message, MsgBoxStyle.Critical, "��ʾ")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            i = ds.Tables("TProjectDocument").Rows.Count
            If i >= 1 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

End Class
