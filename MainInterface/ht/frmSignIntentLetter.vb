Public Class frmSignIntentLetter
    Inherits frmEnterPriseIntent

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
    Friend WithEvents btnSearchTrial As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSignIntentLetter))
        Me.btnSearchTrial = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgIntentLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Visible = True
        '
        'Label20
        '
        Me.Label20.Visible = True
        '
        'txtReturnType
        '
        Me.txtReturnType.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Bitmap)
        Me.btnPrint.ImageIndex = -1
        Me.btnPrint.ImageList = Nothing
        Me.btnPrint.Location = New System.Drawing.Point(272, 368)
        Me.btnPrint.Text = "�鿴�ĵ�(&V)"
        Me.btnPrint.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Visible = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Bitmap)
        Me.btnEdit.ImageIndex = -1
        Me.btnEdit.ImageList = Nothing
        Me.btnEdit.Location = New System.Drawing.Point(376, 368)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Visible = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Bitmap)
        Me.btnAdd.ImageIndex = -1
        Me.btnAdd.ImageList = Nothing
        Me.btnAdd.Location = New System.Drawing.Point(176, 368)
        Me.btnAdd.Size = New System.Drawing.Size(0, 0)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.TabStop = False
        Me.btnAdd.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'Label9
        '
        Me.Label9.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'txtBankReplyTerms
        '
        Me.txtBankReplyTerms.Visible = True
        '
        'Label18
        '
        Me.Label18.Visible = True
        '
        'TabPage1
        '
        Me.TabPage1.Text = "ǩ����Ϣ"
        '
        'txtBankReplyAverageSum
        '
        Me.txtBankReplyAverageSum.Visible = True
        '
        'Label16
        '
        Me.Label16.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'TabControl1
        '
        Me.TabControl1.ItemSize = New System.Drawing.Size(72, 17)
        Me.TabControl1.Visible = True
        '
        'cmbBankReplyRefundType
        '
        Me.cmbBankReplyRefundType.Visible = True
        '
        'txtAverageRefundSum
        '
        Me.txtAverageRefundSum.Visible = True
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'cmbBankRelapseOpinion
        '
        Me.cmbBankRelapseOpinion.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Visible = True
        '
        'Label13
        '
        Me.Label13.Visible = True
        '
        'dtpBankRelapseDate
        '
        Me.dtpBankRelapseDate.Visible = True
        '
        'txtBankVouchAccount
        '
        Me.txtBankVouchAccount.Visible = True
        '
        'Label11
        '
        Me.Label11.Visible = True
        '
        'cmbSignOpinion
        '
        Me.cmbSignOpinion.ItemHeight = 12
        Me.cmbSignOpinion.TabIndex = 1
        Me.cmbSignOpinion.Visible = True
        '
        'Label10
        '
        Me.Label10.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(112, 368)
        Me.btnDelete.Size = New System.Drawing.Size(0, 0)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.TabStop = False
        Me.btnDelete.Visible = True
        '
        'Label3
        '
        Me.Label3.Visible = True
        '
        'dgIntentLetter
        '
        Me.dgIntentLetter.AccessibleName = "DataGrid"
        Me.dgIntentLetter.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgIntentLetter.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(269, 464)
        Me.btnCommit.Visible = True
        '
        'Label21
        '
        Me.Label21.Visible = True
        '
        'cmbSignPerson
        '
        Me.cmbSignPerson.ItemHeight = 12
        '
        'cmbLoanVouchBank
        '
        Me.cmbLoanVouchBank.ItemHeight = 12
        Me.cmbLoanVouchBank.Visible = True
        '
        'txtVouchAccount
        '
        Me.txtVouchAccount.Visible = True
        '
        'cmbLoanVouchBranchBank
        '
        Me.cmbLoanVouchBranchBank.ItemHeight = 12
        Me.cmbLoanVouchBranchBank.Size = New System.Drawing.Size(152, 20)
        Me.cmbLoanVouchBranchBank.Visible = True
        '
        'txtVouchDeadline
        '
        Me.txtVouchDeadline.Visible = True
        '
        'dtpSignDate
        '
        Me.dtpSignDate.TabIndex = 0
        Me.dtpSignDate.Value = New Date(2003, 4, 8, 10, 21, 43, 344)
        Me.dtpSignDate.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(357, 464)
        Me.btnExit.Visible = True
        '
        'btnSearchTrial
        '
        Me.btnSearchTrial.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSearchTrial.Image = CType(resources.GetObject("btnSearchTrial.Image"), System.Drawing.Bitmap)
        Me.btnSearchTrial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchTrial.ImageIndex = 26
        Me.btnSearchTrial.ImageList = Me.ImageListBasic
        Me.btnSearchTrial.Location = New System.Drawing.Point(120, 464)
        Me.btnSearchTrial.Name = "btnSearchTrial"
        Me.btnSearchTrial.Size = New System.Drawing.Size(136, 23)
        Me.btnSearchTrial.TabIndex = 13
        Me.btnSearchTrial.Text = "�鿴�������Ϣ(&R)"
        Me.btnSearchTrial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSignIntentLetter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(578, 495)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCommit, Me.TabControl1, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.btnSearchTrial})
        Me.MinimizeBox = False
        Me.Name = "frmSignIntentLetter"
        Me.Text = "ǩ��������"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgIntentLetter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds, TempDS As DataSet
    '��¼��ǰ���ڲ���״̬��1 ��ʾ��ǰִ������������2 ��ʾ��ǰִ���޸Ĳ�����
    'Private intOperateStatus As Integer = 0
    'Private arrIntentCode As New ArrayList()
    'Private intSearchIndex As Integer
    'Private intTrialTimes, intIntentAccount As Integer
    Private strConferenceTrial As String = "ͬ��"
    Private strUpdateResult As String
    Private strBankCode, strBranchBankCode As String

    Private Sub frmSignIntentLetter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.GetSignOpinion()
            'Me.btnAdd.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnSave.Enabled = True
            'Me.GroupBox3.Enabled = False
            Me.dtpSignDate.Enabled = True
            Me.cmbSignOpinion.Enabled = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    'Protected Overrides Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ds = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
    '    If Not ds.Tables(0).Rows.Count = 0 Then
    '        If Not ds.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value And ds.Tables(0).Rows(0).Item("bank_reply") <> "" Then
    '            'MessageBox.Show("�õ����������Ѿ��������лظ����޷�����ɾ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            SWDialogBox.MessageBox.Show("$1006", "����������")
    '            Return
    '        End If
    '    End If
    '    If Me.cmbSignPerson.Text = "" Then
    '        'MessageBox.Show("�õ���������û��ǩ��������ִ��ǩ����Ϣɾ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        SWDialogBox.MessageBox.Show("$X007")
    '        Return
    '    End If
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    Try
    '        'If MessageBox.Show("�Ƿ�ȷ��ɾ����ǩ����Ϣ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        If SWDialogBox.MessageBox.Show("?1004", "ǩ����Ϣ") = DialogResult.Yes Then
    '            TempDS = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
    '            If Not TempDS.Tables(0).Rows.Count = 0 Then
    '                With TempDS.Tables(0).Rows(0)
    '                    .Item("sign_date") = gWs.GetSysTime()
    '                    .Item("sign_person") = System.DBNull.Value
    '                    .Item("sign_opinion") = System.DBNull.Value
    '                End With
    '                Me.strUpdateResult = gWs.UpdateIntentLetter(TempDS, Nothing)
    '                If Me.strUpdateResult = "1" Then
    '                    'MessageBox.Show("ǩ����Ϣ�Ѿ�ɾ���ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    SWDialogBox.MessageBox.Show("$SaveSucceed")
    '                Else
    '                    'MessageBox.Show("ǩ����Ϣ�Ѿ�ɾ��ʧ�ܣ�" + Me.strUpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    SWDialogBox.MessageBox.Show("*999", "frmSignIntentLetter.btnDelete_Click", Me.strUpdateResult, " gWs.UpdateIntentLetter(TempDS, Nothing)")
    '                End If
    '                Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        ExceptionHandler.ShowMessageBox(ex)
    '        'SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
    '    Finally
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '    End Try
    'End Sub

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.isCommitConfirm = True Then
            'If MessageBox.Show("�Ƿ�ȷ���ύ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            If SWDialogBox.MessageBox.Show("?1000", "�ύ") = DialogResult.No Then
                Return
            End If
        End If
        If Me.cmbSignOpinion.Text = "" Then
            'MessageBox.Show("û�ж�Ӧ��ǩ�������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$X008")
            Me.cmbSignOpinion.Focus()
            Return
        End If
        Try
            'add by wwd 2006-09-05
            If Me.bIsTextChange Then
                Me._isDisplayDialog = False
                Call Me.SaveData()
                Me._isDisplayDialog = True
            End If
            Dim Opinion As String
            ds = gWs.GetIntentLetterInfo("{project_code ='" & Me.strProjectCode & "' order by intent_code desc}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0).Item("sign_opinion") Is System.DBNull.Value Then
                    Opinion = ds.Tables(0).Rows(0).Item("sign_opinion")
                Else
                    Opinion = ""
                End If
            End If
            Call Me.CommitWorkFlow(Opinion, Me)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        End Try
    End Sub

    Protected Overrides Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.dgIntentLetter.CurrentRowIndex <> CType(Me.dgIntentLetter.DataSource, DataView).Count - 1 Then
        If Not Me.IsLastIntentLetter(Me.intSearchIndex) Then
            'MessageBox.Show("��ֻ�ܶ����һ��ǩ����������޸ġ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$X009")
            Return
        End If
        Call Me.btnSaveClickEvent()
    End Sub

    Protected Overrides Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dtpSignDate.Enabled = True
        Me.cmbSignOpinion.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnEdit.Enabled = False
    End Sub

    Private Sub btnSaveClickEvent()
        If Me.intSearchIndex = 0 Then
            'MessageBox.Show("��ѡ����Ӧ�ĵ�����������в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "����������")
            Me.dgIntentLetter.Focus()
            Return
        End If
        If Not Me.IsLastIntentLetter(Me.intSearchIndex) Then
            'MessageBox.Show("��ֻ�ܶ����һ��ǩ����������޸ġ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$X009")
            Return
        End If
        If Me.cmbSignOpinion.Text = "" Then
            'MessageBox.Show("��ѡ��ǩ��������в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "ǩ�����")
            Me.cmbSignOpinion.Focus()
            Return
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.SaveData()
            Call Me.LockContral(GroupBox3)
            Me.intOperateStatus = 0
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private _isDisplayDialog As Boolean = True   '�����жϵ���SaveData�����İ�ť
    '������Ӧ���񱣴���Ӧ���ݣ��˺�����Ҫ���ء�
    Private Sub SaveData()
        Try
            '���ѡ����intent_code�����ݼ�¼�����޸Ĳ�����
            ds = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    .Item("sign_date") = Me.dtpSignDate.Value
                    .Item("sign_person") = Me.strUserID
                    .Item("sign_opinion") = Me.cmbSignOpinion.Text.Trim()
                End With
                Me.strUpdateResult = gWs.UpdateIntentLetter(ds, Nothing)
                If Me.strUpdateResult = "1" Then
                    If _isDisplayDialog Then
                        SWDialogBox.MessageBox.Show("$SaveSucceed")
                    End If
                    Me.dtpSignDate.Enabled = False
                    Me.cmbSignOpinion.Enabled = False
                    'Me.btnAdd.Enabled = False
                    Me.btnEdit.Enabled = True
                    'Me.btnSave.Enabled = True
                Else
                    'MessageBox.Show("ǩ������ʧ�ܣ�" + Me.strUpdateResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SWDialogBox.MessageBox.Show("*999", "frmSignIntentLetter.SaveData()", Me.strUpdateResult, "gWs.UpdateIntentLetter(ds, Nothing)")
                End If
                Call Me.GetIniData(Me.strProjectCode, Me.intSearchIndex)
                '��ʾ��ǰintent_codeΪ���ļ�¼��Ϣ��
                Call Me.ShowSpecialData(Me.intSearchIndex)
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Me.bIsFormLoad = False : Me.bIsTextChange = False
    End Sub

    Private Sub GetSignOpinion()
        ds = Me.GetFinishedFlag(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.cmbSignOpinion.Items.Add(ds.Tables(0).Rows(i).Item("transfer_condition"))
            Next
        End If
    End Sub

    Protected Overrides Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MsgResult As MsgBoxResult
        Try
            If Me.bIsTextChange Then
                'MsgResult = MessageBox.Show("�Ƿ񱣴�����ݽ��е��޸ģ�", "��ʾ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                MsgResult = SWDialogBox.MessageBox.Show("?1003")
            Else
                Me.Close()
                Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            If MsgResult = MsgBoxResult.Yes Then
                Call Me.SaveData()
                Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            If MsgResult = MsgBoxResult.No Then Me.Close() : Me.bIsFormLoad = False : Me.bIsTextChange = False
            If MsgResult = MsgBoxResult.Cancel Then Return
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        End Try
    End Sub

    Private Sub btnSearchTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchTrial.Click
        If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count <= 0 Then
            '��ʾ����Ч��û�пɹ����������ݡ���Ϣ��
            SWDialogBox.MessageBox.Show("$1005", " �������� ")
            Return
        End If

        Dim frm As New frmMeetRecordQuery(Me.getProjectCode(), Me.getCorporationName())
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub

    Protected Overrides Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim doc As New frmDocumentManageBusiness(strProjectCode, strTaskID, strEnterpriseName, "45", "008", UserName)
        doc.setIsButtonEnable(True)
        doc.AllowTransparency = False
        doc.ShowDialog()
        doc.Text = "�鿴����������"
    End Sub

End Class
