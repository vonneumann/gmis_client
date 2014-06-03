Public Class FMessage
    Inherits System.Windows.Forms.Form

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
	Friend WithEvents ColNum As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColProjectCode As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColMessage As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColResponser As System.Windows.Forms.ColumnHeader
	Friend WithEvents lvwMessage As System.Windows.Forms.ListView
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvwMessage = New System.Windows.Forms.ListView
        Me.ColNum = New System.Windows.Forms.ColumnHeader
        Me.ColTime = New System.Windows.Forms.ColumnHeader
        Me.ColResponser = New System.Windows.Forms.ColumnHeader
        Me.ColProjectCode = New System.Windows.Forms.ColumnHeader
        Me.ColMessage = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'lvwMessage
        '
        Me.lvwMessage.BackColor = System.Drawing.SystemColors.Window
        Me.lvwMessage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColNum, Me.ColTime, Me.ColResponser, Me.ColProjectCode, Me.ColMessage})
        Me.lvwMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwMessage.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lvwMessage.FullRowSelect = True
        Me.lvwMessage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwMessage.Location = New System.Drawing.Point(0, 0)
        Me.lvwMessage.Name = "lvwMessage"
        Me.lvwMessage.Size = New System.Drawing.Size(648, 256)
        Me.lvwMessage.TabIndex = 22
        Me.lvwMessage.View = System.Windows.Forms.View.Details
        '
        'ColNum
        '
        Me.ColNum.Text = "���"
        Me.ColNum.Width = 0
        '
        'ColTime
        '
        Me.ColTime.Text = "����ʱ��"
        Me.ColTime.Width = 130
        '
        'ColResponser
        '
        Me.ColResponser.Text = "������"
        Me.ColResponser.Width = 130
        '
        'ColProjectCode
        '
        Me.ColProjectCode.Text = "��Ŀ����"
        Me.ColProjectCode.Width = 130
        '
        'ColMessage
        '
        Me.ColMessage.Text = "��Ϣ����"
        Me.ColMessage.Width = 250
        '
        'FMessage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(648, 256)
        Me.Controls.Add(Me.lvwMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FMessage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��Ϣ������"
        Me.ResumeLayout(False)

    End Sub

#End Region

	Public Shadows Sub Refresh()
		MyBase.Refresh()

		Try
			Dim dsTmp As Data.DataSet
			Dim iCounter, i As Integer

			Me.lvwMessage.Items.Clear()

            dsTmp = gWs.LookUpMessage("{accepter='" & UserName & "' order by send_time desc}")
			If dsTmp Is Nothing Then
				Exit Sub
			End If
			'Me.LstBxMsg.DisplayMember = "message_content"
			'Me.LstBxMsg.ValueMember = "serial_num"
			'Me.LstBxMsg.DataSource = dsTmp.Tables(0)

			'���listview�ؼ�
			Dim strTime As String

			For i = 0 To dsTmp.Tables(0).Rows.Count - 1
				Me.lvwMessage.Items.Add(dsTmp.Tables(0).Rows(i).Item("serial_num"))
                Me.lvwMessage.Items(i).SubItems.Add(String.Format("{0:F}", dsTmp.Tables(0).Rows(i).Item("send_time")))

                If dsTmp.Tables(0).Rows(i).Item("responser") Is DBNull.Value Then
                    Me.lvwMessage.Items(i).SubItems.Add("ϵͳ��Ϣ")
                Else
                    Me.lvwMessage.Items(i).SubItems.Add(dsTmp.Tables(0).Rows(i).Item("responser"))

                End If
                If dsTmp.Tables(0).Rows(i).Item("project_code") Is DBNull.Value Then
                    Me.lvwMessage.Items(i).SubItems.Add("")
                Else
                    Me.lvwMessage.Items(i).SubItems.Add(dsTmp.Tables(0).Rows(i).Item("project_code"))
                End If

                Me.lvwMessage.Items(i).SubItems.Add(dsTmp.Tables(0).Rows(i).Item("message_content"))
                If dsTmp.Tables(0).Rows(i).Item("is_affirmed") = "N" Then
                    lvwMessage.Items(i).Font = New Font(lvwMessage.Font, FontStyle.Bold)
                Else
                    lvwMessage.Items(i).Font = New Font(lvwMessage.Font, FontStyle.Regular)
                End If
            Next
		Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        End Try
	End Sub

	Private Sub lvwMessage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwMessage.Click
        'If Me.lvwMessage.Items.Count = 0 Then
        '	Exit Sub
        'End If
        'If Me.lvwMessage.FocusedItem Is Nothing Then
        '	Exit Sub
        'End If

        'Try
        '	Dim iNum As Int64
        '	Dim dsTmp As DataSet

        '	iNum = Me.lvwMessage.FocusedItem.Text

        '	dsTmp = gWs.LookUpMessage("{serial_num=" & iNum.ToString & "}")
        '	If Not dsTmp Is Nothing Then
        '		'MessageBox.Show(dsTmp.Tables(0).Rows(0).Item("message_content"), "��Ϣ����", MessageBoxButtons.OK, MessageBoxIcon.None)
        '		dsTmp.Tables(0).Rows(0).Item("is_affirmed") = "R"
        '		gWs.UpdateMessage(dsTmp)
        '	End If
        '	If lvwMessage.FocusedItem.Font.Bold Then
        '		Me.lvwMessage.FocusedItem.Font = New Font(lvwMessage.Font, FontStyle.Regular)
        '	End If
        '      Catch ex As Exception
        '          SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        '      End Try
    End Sub

    Private Sub FMessage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
    End Sub
End Class
