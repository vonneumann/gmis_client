'��ʱ�����崰��,�ṩ���û�����������ɵ�ʱ��
'�̳й��������崰��
Public Class frmTimingTaskDefine
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
    Friend WithEvents csWorkflow As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTaskID As DataGridComboBoxColumn
    Friend WithEvents csRoleID As DataGridComboBoxColumn
    Friend WithEvents csTimingLimit As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csMessageID As DataGridComboBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTimingTaskDefine))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csWorkflow = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTaskID = New MainInterface.DataGridComboBoxColumn()
        Me.csRoleID = New MainInterface.DataGridComboBoxColumn()
        Me.csTimingLimit = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csMessageID = New MainInterface.DataGridComboBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(381, 302)
        Me.btnExit.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.Location = New System.Drawing.Point(299, 302)
        Me.btnUpdate.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.Location = New System.Drawing.Point(217, 302)
        Me.btnDelete.Visible = True
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
        Me.btnRefresh.Location = New System.Drawing.Point(53, 302)
        Me.btnRefresh.Visible = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Bitmap)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageIndex = 4
        Me.btnAdd.ImageList = Me.ImageList1
        Me.btnAdd.Location = New System.Drawing.Point(135, 302)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "�� ��(&A)"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csWorkflow, Me.csTaskID, Me.csRoleID, Me.csMessageID, Me.csTimingLimit})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "timing_task_template"
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
        'csRoleID
        '
        Me.csRoleID.Format = ""
        Me.csRoleID.FormatInfo = Nothing
        Me.csRoleID.HeaderText = "��ɫ"
        Me.csRoleID.MappingName = "role_id"
        Me.csRoleID.Width = 75

        'csMessageID
        '
        Me.csMessageID.Format = ""
        Me.csMessageID.FormatInfo = Nothing
        Me.csMessageID.HeaderText = "��Ϣ"
        Me.csMessageID.MappingName = "message_id"
        Me.csMessageID.Width = 120

        '
        'csTimingLimit
        '
        Me.csTimingLimit.Format = ""
        Me.csTimingLimit.FormatInfo = Nothing
        Me.csTimingLimit.HeaderText = "��ʾʱ��(��)"
        Me.csTimingLimit.MappingName = "time_limit"
        Me.csTimingLimit.NullText = ""
        Me.csTimingLimit.Width = 80
        '
        'frmTimingTaskDefine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAdd, Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Name = "frmTimingTaskDefine"
        Me.Text = "��ʾ����"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private strWorkflowID, strTaskID As String
    Private dsResult, dsTask As DataSet

    '��д����ˢ�·���,ʵ�������ˢ�¹���
    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            '��ȡָ��������ID������ID��ʱ�޶������ݼ�
            Dim strSql As String = "{workflow_id=" & "'" & strWorkflowID & "'" & " and task_id=" & "'" & strTaskID & "'" & "}"
            dsResult = gWs.GetWfTimingTaskTemplateInfo(strSql)
            grdTable.SetDataBinding(dsResult, "timing_task_template")
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '��д����ı��淽��,ʵ������ı��淽��
    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim result As String = gWs.UpdateWfTimingTaskTemplate(dsResult.GetChanges())

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
        '��ȡ���еĽ�ɫ���ݼ�
        Dim dsRole As DataSet = gWs.GetRole("%")

        '���ý�ɫ���ݼ��󶨵���ɫѡ��������
        csRoleID.ColumnComboBox.DataSource = dsRole.Tables("TRole").DefaultView
        csRoleID.ColumnComboBox.DisplayMember = "role_name"
        csRoleID.ColumnComboBox.ValueMember = "role_id"

        ''��ȡ�����������ݼ�
        'Dim strSql As String = "select distinct task_id,task_name from task_template"
        'Dim dsTask As DataSet = gWs.GetCommonQueryInfo(strSql)

        '�����������ݼ��󶨵�����ѡ��������
        csTaskID.ColumnComboBox.DataSource = dsTask.Tables(0).DefaultView
        csTaskID.ColumnComboBox.DisplayMember = "task_name"
        csTaskID.ColumnComboBox.ValueMember = "task_id"

        Dim strSql As String
        strSql = "SELECT * FROM message_template"
        Dim dsMessage As DataSet = gWs.GetCommonQueryInfo(strSql)

        '������Ϣ���ݼ��󶨵���Ϣ������
        csMessageID.ColumnComboBox.DataSource = dsMessage.Tables(0).DefaultView
        csMessageID.ColumnComboBox.DisplayMember = "message_content"
        csMessageID.ColumnComboBox.ValueMember = "message_id"


        '����������������¼
        setDgAttribute(Me.grdTable, Me)
    End Sub

    '������ť�¼�
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '������¼
        Dim newRow As DataRow = dsResult.Tables(0).NewRow

        '������¼ʱ�Զ���乤����ID������ID�Լ���ʱ��ʾ����
        With newRow
            .Item("workflow_id") = strWorkflowID
            .Item("task_id") = strTaskID
            .Item("type") = "A"
        End With
        dsResult.Tables(0).Rows.Add(newRow)

    End Sub
End Class
