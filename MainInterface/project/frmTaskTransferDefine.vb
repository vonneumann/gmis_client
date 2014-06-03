'������ת���崰��,���û�����������ת���״̬�ı�
'�̳������崰��
Public Class frmTaskTransferDefine
    Inherits MainInterface.frmBaseWfDefine

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    Public Sub New(ByVal workflowID As String, ByVal taskID As String, ByVal taskData As DataSet)
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        strWorkflowID = workflowID
        strTaskID = taskID
        dsTask = taskData

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
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csTaskID As DataGridComboBoxColumn
    Friend WithEvents csTaskStatus As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csWorkflow As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csNextTask As DataGridComboBoxColumn
    Friend WithEvents csTransCondition As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIsItem As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTaskTransferDefine))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csWorkflow = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTaskID = New MainInterface.DataGridComboBoxColumn()
        Me.csNextTask = New MainInterface.DataGridComboBoxColumn()
        Me.csTransCondition = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTaskStatus = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIsItem = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(40, 302)
        Me.btnRefresh.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.Location = New System.Drawing.Point(216, 302)
        Me.btnDelete.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(392, 302)
        Me.btnExit.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.Location = New System.Drawing.Point(304, 302)
        Me.btnUpdate.Visible = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Bitmap)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageIndex = 4
        Me.btnAdd.ImageList = Me.ImageList1
        Me.btnAdd.Location = New System.Drawing.Point(128, 302)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "�� ��(&A)"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csWorkflow, Me.csTaskID, Me.csNextTask, Me.csTransCondition, Me.csTaskStatus, Me.csIsItem})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "task_transfer_template"
        '
        'csWorkflow
        '
        Me.csWorkflow.Format = ""
        Me.csWorkflow.FormatInfo = Nothing
        Me.csWorkflow.HeaderText = "ģ��ID"
        Me.csWorkflow.MappingName = "workflow_id"
        Me.csWorkflow.ReadOnly = True
        Me.csWorkflow.Width = 75
        '
        'csTaskID
        '
        Me.csTaskID.Format = ""
        Me.csTaskID.FormatInfo = Nothing
        Me.csTaskID.HeaderText = "����ID"
        Me.csTaskID.MappingName = "task_id"
        Me.csTaskID.ReadOnly = True
        Me.csTaskID.Width = 150
        '
        'csNextTask
        '
        Me.csNextTask.Format = ""
        Me.csNextTask.FormatInfo = Nothing
        Me.csNextTask.HeaderText = "��ת����ID"
        Me.csNextTask.MappingName = "next_task"
        Me.csNextTask.ReadOnly = True
        Me.csNextTask.Width = 150
        '
        'csTransCondition
        '
        Me.csTransCondition.Format = ""
        Me.csTransCondition.FormatInfo = Nothing
        Me.csTransCondition.HeaderText = "����"
        Me.csTransCondition.MappingName = "transfer_condition"
        Me.csTransCondition.Width = 75
        '
        'csTaskStatus
        '
        Me.csTaskStatus.Format = ""
        Me.csTaskStatus.FormatInfo = Nothing
        Me.csTaskStatus.HeaderText = "����״̬"
        Me.csTaskStatus.MappingName = "status"
        Me.csTaskStatus.NullText = ""
        Me.csTaskStatus.Width = 75
        '
        'csIsItem
        '
        Me.csIsItem.Format = ""
        Me.csIsItem.FormatInfo = Nothing
        Me.csIsItem.HeaderText = "����"
        Me.csIsItem.MappingName = "isItem"
        Me.csIsItem.Width = 75
        '
        'frmTaskTransferDefine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable, Me.btnAdd})
        Me.Name = "frmTaskTransferDefine"
        Me.Text = "������ת����"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private strWorkflowID, strTaskID As String
    Private dsResult, dsTask As DataSet

    '��д�����ˢ�·���,ʵ�������ˢ�¹���
    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            '��ȡָ��������ID������ID������ת�����ݼ�
            Dim strSql As String = "{workflow_id=" & "'" & strWorkflowID & "'" & " and task_id=" & "'" & strTaskID & "'" & "}"
            dsResult = gWs.GetWfTaskTransferTemplateInfo(strSql)
            grdTable.SetDataBinding(dsResult, "task_transfer_template")
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '��д����ı��淽��,ʵ������ı��湦��
    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim result As String = gWs.UpdateWfTaskTransferTemplate(dsResult.GetChanges())

            If result = "1" Then
                '�������и���
                dsResult.AcceptChanges()

                Return True
            Else
                MessageBox.Show("ϵͳ������Ϣ��" + result, "��������", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return False
    End Function

    '�����load�¼�
    Private Sub frmTaskRoleDefine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''��ȡ���е��������ݼ�
        'Dim strSql As String = "select distinct task_id,task_name from task_template"
        'Dim dsTask As DataSet = gWs.GetCommonQueryInfo(strSql)

        '�������ݼ��󶨵�����ѡ��������
        csTaskID.ColumnComboBox.DataSource = dsTask.Tables(0).DefaultView
        csTaskID.ColumnComboBox.DisplayMember = "task_name"
        csTaskID.ColumnComboBox.ValueMember = "task_id"

        '�������ݼ��󶨵�ת������ѡ��������
        csNextTask.ColumnComboBox.DataSource = dsTask.Tables(0).DefaultView
        csNextTask.ColumnComboBox.DisplayMember = "task_name"
        csNextTask.ColumnComboBox.ValueMember = "task_id"

        '����������������¼
        setDgAttribute(Me.grdTable, Me)
    End Sub

    '������ť�¼�
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '������¼
        Dim newRow As DataRow = dsResult.Tables(0).NewRow

        '������¼ʱ�Զ���乤����ID������ID
        With newRow
            .Item("workflow_id") = strWorkflowID
            .Item("task_id") = strTaskID
        End With
        dsResult.Tables(0).Rows.Add(newRow)

    End Sub
End Class
