Public Class FSendMessage
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub
    '��Ŀ����,��������,ָʾʱ��,��Ϣ����,��ע��,����ָʾ
    Public Sub New(ByVal pcode As String, ByVal task_name As String, ByVal attend_person As String, ByVal workContent As String)
        Me.new(pcode, task_name, attend_person)
        Me.txtIndication.Text = workContent
    End Sub

    '���ع��캯��������Ŀ���룬�������ƣ���Ϣ������������
    Public Sub New(ByVal project_code As String, ByVal task_name As String, ByVal attend_person As String)
        Me.New()
        Me.project_code = project_code
        Me.task_name = task_name
        Me.attend_person = attend_person
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
    Friend WithEvents lblSysTime As System.Windows.Forms.Label
    Friend WithEvents txtSysTime As System.Windows.Forms.TextBox
    Friend WithEvents txtAttendPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtTaskName As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents lblTaskName As System.Windows.Forms.Label
    Friend WithEvents lblProjectCode As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents btnSendMessage As System.Windows.Forms.Button
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblAttendPerson As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblIndication As System.Windows.Forms.Label
    Friend WithEvents txtIndication As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FSendMessage))
        Me.lblAttendPerson = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblSysTime = New System.Windows.Forms.Label()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtSysTime = New System.Windows.Forms.TextBox()
        Me.txtAttendPerson = New System.Windows.Forms.TextBox()
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblIndication = New System.Windows.Forms.Label()
        Me.txtIndication = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAttendPerson
        '
        Me.lblAttendPerson.AccessibleDescription = "lblAttendPerson"
        Me.lblAttendPerson.Location = New System.Drawing.Point(8, 64)
        Me.lblAttendPerson.Name = "lblAttendPerson"
        Me.lblAttendPerson.Size = New System.Drawing.Size(64, 16)
        Me.lblAttendPerson.TabIndex = 24
        Me.lblAttendPerson.Text = "��Ϣ������"
        '
        'lblUserName
        '
        Me.lblUserName.Location = New System.Drawing.Point(224, 64)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(56, 16)
        Me.lblUserName.TabIndex = 23
        Me.lblUserName.Text = "��ע��"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysTime
        '
        Me.lblSysTime.Location = New System.Drawing.Point(224, 40)
        Me.lblSysTime.Name = "lblSysTime"
        Me.lblSysTime.Size = New System.Drawing.Size(56, 16)
        Me.lblSysTime.TabIndex = 22
        Me.lblSysTime.Text = "ָʾʱ��"
        '
        'btnSendMessage
        '
        Me.btnSendMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSendMessage.Image = CType(resources.GetObject("btnSendMessage.Image"), System.Drawing.Bitmap)
        Me.btnSendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSendMessage.Location = New System.Drawing.Point(137, 264)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(77, 23)
        Me.btnSendMessage.TabIndex = 21
        Me.btnSendMessage.Text = "�� ��(&S)"
        Me.btnSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtUserName.Location = New System.Drawing.Point(288, 62)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(120, 21)
        Me.txtUserName.TabIndex = 19
        Me.txtUserName.Text = ""
        '
        'txtSysTime
        '
        Me.txtSysTime.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSysTime.Location = New System.Drawing.Point(288, 40)
        Me.txtSysTime.Name = "txtSysTime"
        Me.txtSysTime.ReadOnly = True
        Me.txtSysTime.Size = New System.Drawing.Size(120, 21)
        Me.txtSysTime.TabIndex = 18
        Me.txtSysTime.Text = ""
        '
        'txtAttendPerson
        '
        Me.txtAttendPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAttendPerson.Location = New System.Drawing.Point(72, 62)
        Me.txtAttendPerson.Name = "txtAttendPerson"
        Me.txtAttendPerson.ReadOnly = True
        Me.txtAttendPerson.Size = New System.Drawing.Size(136, 21)
        Me.txtAttendPerson.TabIndex = 17
        Me.txtAttendPerson.Text = ""
        '
        'txtTaskName
        '
        Me.txtTaskName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTaskName.Location = New System.Drawing.Point(72, 38)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.ReadOnly = True
        Me.txtTaskName.Size = New System.Drawing.Size(136, 21)
        Me.txtTaskName.TabIndex = 16
        Me.txtTaskName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 14)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(136, 21)
        Me.txtProjectCode.TabIndex = 15
        Me.txtProjectCode.Text = ""
        '
        'lblTaskName
        '
        Me.lblTaskName.Location = New System.Drawing.Point(8, 40)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(56, 16)
        Me.lblTaskName.TabIndex = 14
        Me.lblTaskName.Text = "��������"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(8, 16)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCode.TabIndex = 13
        Me.lblProjectCode.Text = "��Ŀ����"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Bitmap)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(225, 264)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 23)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "ȡ ��(&C)"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblIndication, Me.txtIndication, Me.lblSysTime, Me.txtTaskName, Me.lblTaskName, Me.lblAttendPerson, Me.txtSysTime, Me.txtUserName, Me.lblUserName, Me.txtProjectCode, Me.txtAttendPerson, Me.lblProjectCode})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 256)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'lblIndication
        '
        Me.lblIndication.Location = New System.Drawing.Point(8, 96)
        Me.lblIndication.Name = "lblIndication"
        Me.lblIndication.Size = New System.Drawing.Size(56, 16)
        Me.lblIndication.TabIndex = 27
        Me.lblIndication.Text = "����ָʾ"
        '
        'txtIndication
        '
        Me.txtIndication.Location = New System.Drawing.Point(72, 88)
        Me.txtIndication.Multiline = True
        Me.txtIndication.Name = "txtIndication"
        Me.txtIndication.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIndication.Size = New System.Drawing.Size(336, 160)
        Me.txtIndication.TabIndex = 26
        Me.txtIndication.Text = ""
        '
        'FSendMessage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(442, 295)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.btnCancel, Me.btnSendMessage})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FSendMessage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "������Ϣ"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '���Ա�����Ŀ���룬�������ƣ���Ϣ��������
    Private project_code, task_name, attend_person As String
    Private now_time As DateTime

    Private Sub FSendMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProjectCode.Text = project_code
        Me.txtTaskName.Text = task_name
        Me.txtAttendPerson.Text = attend_person
        Me.txtUserName.Text = UserName
        now_time = gWs.GetSysTime()
        Me.txtSysTime.Text = now_time.ToString("MM-dd hh:mm")
    End Sub

    '�жϹ���ָʾ���Ƿ�Ϊ�մ������ǵĻ���������Ϣ
    Private Sub btnSendMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMessage.Click
        If Me.txtIndication.Text.Trim() = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", "����ָʾ")
            Me.txtIndication.Focus()
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dsmessage As DataSet
            dsmessage = gWs.LookUpMessage("")
            Dim dr As DataRow = dsmessage.Tables(0).NewRow
            dr("project_code") = project_code
            dr("message_content") = Me.txtIndication.Text
            dr("responser") = UserName
            dr("accepter") = attend_person
            dr("send_time") = now_time
            dr("is_affirmed") = "N"
            dsmessage.Tables(0).Rows.Add(dr)
            Dim result As String = gWs.UpdateMessage(dsmessage.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "������Ϣʧ��", result, "")
            Else
                SWDialogBox.MessageBox.Show("$OperateSucceed")
                Me.Close()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
