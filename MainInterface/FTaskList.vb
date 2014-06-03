Public Class FTaskList
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
	Friend WithEvents tvwTask As System.Windows.Forms.TreeView
	Private WithEvents imlTask As System.Windows.Forms.ImageList
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.tvwTask = New System.Windows.Forms.TreeView()
		Me.imlTask = New System.Windows.Forms.ImageList(Me.components)
		Me.SuspendLayout()
		'
		'tvwTask
		'
		Me.tvwTask.BackColor = System.Drawing.SystemColors.Window
		Me.tvwTask.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tvwTask.ImageIndex = -1
		Me.tvwTask.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tvwTask.Name = "tvwTask"
		Me.tvwTask.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�����б�")})
		Me.tvwTask.SelectedImageIndex = -1
		Me.tvwTask.ShowRootLines = False
		Me.tvwTask.Size = New System.Drawing.Size(232, 256)
		Me.tvwTask.TabIndex = 0
		'
		'imlTask
		'
		Me.imlTask.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.imlTask.ImageSize = New System.Drawing.Size(16, 16)
		Me.imlTask.TransparentColor = System.Drawing.Color.Transparent
		'
		'FTaskList
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(232, 256)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tvwTask})
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Name = "FTaskList"
		Me.ShowInTaskbar = False
		Me.Text = "�����б�"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private _taskList As New ArrayList()

	Public Sub Clear()
		tvwTask.Nodes(0).Nodes.Clear()
	End Sub

	'
	'���ݵ�¼�û�ID����̬����Tree�Ľڵ�
	'
	Friend Overloads Sub Refresh(ByVal userID As String)
		If userID = "" Then
			Exit Sub
		End If

		Dim ds As DataSet
		Dim dr As DataRow
		Dim i, iCounter, taskCount As Integer
		Dim strTaskName, strTaskID As String
		Dim strProjectCode, strWorkFlow, strApplyTool As String

		Dim iIndx As Integer = 0

		Dim dvTmp As DataView

		_taskList.Clear()
		'����WebService�ķ���,���ĳ���û��Ĺ��������б�
		Try
			If gWs Is Nothing Then
				gWs = GetWebService(strUrl)
			End If
			ds = gWs.LookUpWorking(userID)
			dvTmp = ds.Tables(0).DefaultView
			dvTmp.Sort = "task_id ASC"

			iCounter = ds.Tables(0).Rows.Count

			For i = 0 To iCounter - 1
				dr = ds.Tables(0).Rows(i)
				With dr

					'If Not .Item("task_name") Is System.DBNull.Value Then
					strProjectCode = .Item("project_code")
					strWorkFlow = .Item("workflow_id")
					strTaskID = .Item("task_id")
					strTaskName = .Item("task_name")
					If Not .Item("Apply_tool") Is System.DBNull.Value Then
						strApplyTool = .Item("Apply_Tool")
					Else
						strApplyTool = ""
					End If

					If i = 0 Then
						tvwTask.Nodes(0).Nodes.Add(strTaskID)
						tvwTask.Nodes(0).Nodes(i).Text = strTaskName
						'iIndx += 1
						taskCount = 1
					Else
						If ds.Tables(0).Rows(i - 1).Item("task_id") <> strTaskID Then
							tvwTask.Nodes(0).Nodes(tvwTask.Nodes(0).Nodes.Count - 1).Text = tvwTask.Nodes(0).Nodes(tvwTask.Nodes(0).Nodes.Count - 1).Text + "(" + taskCount.ToString() + ")"
							tvwTask.Nodes(0).Nodes.Add(strTaskID)
							iIndx += 1
							tvwTask.Nodes(0).Nodes(iIndx).Text = strTaskName
							taskCount = 1
						Else
							taskCount += 1
						End If
					End If
					'arrayTaskID.Add(strTaskID)
					'arrayTask.Clear()
					_taskList.Add(strProjectCode)
					_taskList.Add(strWorkFlow)
					_taskList.Add(strTaskID)
					_taskList.Add(strApplyTool)
					_taskList.Add(iIndx)
					'_taskList.Add(arrayTask)
					'End If
				End With
			Next

			If tvwTask.Nodes(0).Nodes.Count > 0 Then
				tvwTask.Nodes(0).Nodes(tvwTask.Nodes(0).Nodes.Count - 1).Text = tvwTask.Nodes(0).Nodes(tvwTask.Nodes(0).Nodes.Count - 1).Text + "(" + taskCount.ToString() + ")"
				tvwTask.Nodes(0).Expand()
			End If
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

	Private Sub tvwTask_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvwTask.DoubleClick
		Dim strTaskID As String
		Dim arrTasktmp As New ArrayList()

		Dim i As Integer
		Try
			If Me.tvwTask.SelectedNode.Parent Is Nothing Then
				Exit Sub
			End If

			If _taskList.Count = 0 Then
				Exit Sub
			End If

			For i = 0 To _taskList.Count / 5 - 1
				If Me.tvwTask.SelectedNode.Index = _taskList(5 * i + 4) Then
					strTaskID = _taskList(5 * i + 2)

					'���������Ŀ�����Ӧ�ó�������
					arrTasktmp.Add(_taskList(5 * i))					'��Ŀ����
					arrTasktmp.Add(_taskList(5 * i + 1))					  '������ID
					arrTasktmp.Add(_taskList(5 * i + 3))					  'Ӧ�ó���
				End If
			Next

			'''''�������������Ŀ�б�
			For i = 0 To Me.Owner.MdiChildren.Length - 1
				If Me.Owner.MdiChildren(i).GetType Is GetType(MainInterface.frmProjectInfo) Then
					Me.Owner.MdiChildren(i).Close()
				End If
			Next
			Dim projectInfo As frmProjectInfo = New frmProjectInfo()
			AddHandler projectInfo.TaskCommit, AddressOf getTasklistAndMsg			'�����ڹر�ʱ��ˢ���������Ϣ
			projectInfo.MdiParent = Me.Owner
			projectInfo.Text = Me.tvwTask.SelectedNode.Text
			projectInfo.arrTask = arrTasktmp
			projectInfo.strTaskID = strTaskID
			projectInfo.Show()
		Catch
            MessageBox.Show("����Ŀ�б�ʱ������" & Err.Description & "��", "", MessageBoxButtons.OK)
		End Try
	End Sub

	Private Sub getTasklistAndMsg()
		Try
			'��ȡ�����б�
			tvwTask.Nodes(0).Nodes.Clear()
			Me.Refresh(UserName)
			'չ�������б��������нڵ�
			Me.tvwTask.ExpandAll()

			'��ȡ��Ϣ�б�
			'FillLstBxMsg()
		Catch ex As Exception
			'Me.StatusBarPanel2.Text = "��ȡ�û�Ϊ��" & UserName & " �������б�ʱ����(" & ex.Message & ")"
			MsgBox("��ȡ�û�Ϊ" & UserName & " ���������Ϣ�б�ʱ����(" & ex.Message & ")", MsgBoxStyle.Critical, "����")
		End Try
	End Sub
End Class
