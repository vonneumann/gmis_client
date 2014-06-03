Public Class FWorkLog
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        FillTimeComboBox(cboStartTime)
        FillTimeComboBox(cboEndTime)
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStartTime As System.Windows.Forms.ComboBox
    Friend WithEvents cboJob As System.Windows.Forms.ComboBox
    Friend WithEvents cboPost As System.Windows.Forms.ComboBox
    Friend WithEvents cboTask As System.Windows.Forms.ComboBox
    Friend WithEvents cboEndTime As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents dtpWorkDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmuDelete As System.Windows.Forms.ContextMenu
    Friend WithEvents muitDeleteSingle As System.Windows.Forms.MenuItem
    Friend WithEvents muitDeleteBatch As System.Windows.Forms.MenuItem
    Protected WithEvents grdLog As System.Windows.Forms.DataGrid
    Protected WithEvents ImageList1 As System.Windows.Forms.ImageList
    Protected WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents btnDelete As System.Windows.Forms.Button
    Protected WithEvents btnNew As System.Windows.Forms.Button
    Protected WithEvents btnModify As System.Windows.Forms.Button
    Protected WithEvents btnCancel As System.Windows.Forms.Button
    Protected WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FWorkLog))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.grdLog = New System.Windows.Forms.DataGrid()
        Me.gbxContainer = New System.Windows.Forms.GroupBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpWorkDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboEndTime = New System.Windows.Forms.ComboBox()
        Me.cboStartTime = New System.Windows.Forms.ComboBox()
        Me.cboJob = New System.Windows.Forms.ComboBox()
        Me.cboPost = New System.Windows.Forms.ComboBox()
        Me.cboTask = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmuDelete = New System.Windows.Forms.ContextMenu()
        Me.muitDeleteSingle = New System.Windows.Forms.MenuItem()
        Me.muitDeleteBatch = New System.Windows.Forms.MenuItem()
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(626, 544)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "�� ��(&E)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 2
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(535, 544)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 4
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(353, 544)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "ɾ ��(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 1
        Me.btnNew.ImageList = Me.ImageList1
        Me.btnNew.Location = New System.Drawing.Point(171, 544)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "�� ��(&A)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdLog
        '
        Me.grdLog.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdLog.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grdLog.CaptionBackColor = System.Drawing.Color.PowderBlue
        Me.grdLog.CaptionForeColor = System.Drawing.SystemColors.WindowText
        Me.grdLog.DataMember = ""
        Me.grdLog.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLog.Location = New System.Drawing.Point(8, 8)
        Me.grdLog.Name = "grdLog"
        Me.grdLog.ReadOnly = True
        Me.grdLog.Size = New System.Drawing.Size(856, 304)
        Me.grdLog.TabIndex = 0
        '
        'gbxContainer
        '
        Me.gbxContainer.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gbxContainer.BackgroundImage = CType(resources.GetObject("gbxContainer.BackgroundImage"), System.Drawing.Bitmap)
        Me.gbxContainer.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpEndDate, Me.Label8, Me.dtpWorkDate, Me.Label7, Me.cboEndTime, Me.cboStartTime, Me.cboJob, Me.cboPost, Me.cboTask, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.txtContent})
        Me.gbxContainer.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.gbxContainer.Location = New System.Drawing.Point(8, 312)
        Me.gbxContainer.Name = "gbxContainer"
        Me.gbxContainer.Size = New System.Drawing.Size(856, 224)
        Me.gbxContainer.TabIndex = 46
        Me.gbxContainer.TabStop = False
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(480, 16)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Bitmap)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(424, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 14)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "��ֹ����"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpWorkDate
        '
        Me.dtpWorkDate.Location = New System.Drawing.Point(136, 16)
        Me.dtpWorkDate.Name = "dtpWorkDate"
        Me.dtpWorkDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpWorkDate.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Bitmap)
        Me.Label7.Location = New System.Drawing.Point(8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 80)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "    ��־����"
        '
        'cboEndTime
        '
        Me.cboEndTime.Location = New System.Drawing.Point(672, 16)
        Me.cboEndTime.MaxLength = 5
        Me.cboEndTime.Name = "cboEndTime"
        Me.cboEndTime.Size = New System.Drawing.Size(72, 20)
        Me.cboEndTime.TabIndex = 4
        '
        'cboStartTime
        '
        Me.cboStartTime.Location = New System.Drawing.Point(328, 16)
        Me.cboStartTime.MaxLength = 5
        Me.cboStartTime.Name = "cboStartTime"
        Me.cboStartTime.Size = New System.Drawing.Size(72, 20)
        Me.cboStartTime.TabIndex = 2
        '
        'cboJob
        '
        Me.cboJob.Location = New System.Drawing.Point(328, 45)
        Me.cboJob.MaxLength = 20
        Me.cboJob.Name = "cboJob"
        Me.cboJob.Size = New System.Drawing.Size(128, 20)
        Me.cboJob.TabIndex = 6
        '
        'cboPost
        '
        Me.cboPost.Location = New System.Drawing.Point(136, 45)
        Me.cboPost.MaxLength = 10
        Me.cboPost.Name = "cboPost"
        Me.cboPost.Size = New System.Drawing.Size(112, 20)
        Me.cboPost.TabIndex = 5
        '
        'cboTask
        '
        Me.cboTask.Location = New System.Drawing.Point(544, 45)
        Me.cboTask.MaxLength = 50
        Me.cboTask.Name = "cboTask"
        Me.cboTask.Size = New System.Drawing.Size(200, 20)
        Me.cboTask.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Bitmap)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(264, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "ְ�����"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Bitmap)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(40, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "��λ���"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Bitmap)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(480, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "�������"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Bitmap)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(616, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "����ʱ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Bitmap)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(264, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "��ʼʱ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Bitmap)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(40, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "����(��ʼ)����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContent
        '
        Me.txtContent.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtContent.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtContent.Location = New System.Drawing.Point(48, 72)
        Me.txtContent.MaxLength = 500
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContent.Size = New System.Drawing.Size(800, 144)
        Me.txtContent.TabIndex = 8
        Me.txtContent.Text = ""
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 6
        Me.btnModify.ImageList = Me.ImageList1
        Me.btnModify.Location = New System.Drawing.Point(262, 544)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 23)
        Me.btnModify.TabIndex = 10
        Me.btnModify.Text = "�� ��(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Bitmap)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 3
        Me.btnCancel.ImageList = Me.ImageList1
        Me.btnCancel.Location = New System.Drawing.Point(444, 544)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "ȡ ��(&C)"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmuDelete
        '
        Me.cmuDelete.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.muitDeleteSingle, Me.muitDeleteBatch})
        '
        'muitDeleteSingle
        '
        Me.muitDeleteSingle.Index = 0
        Me.muitDeleteSingle.Text = "��  ��"
        '
        'muitDeleteBatch
        '
        Me.muitDeleteBatch.Index = 1
        Me.muitDeleteBatch.Text = "��  ��"
        '
        'FWorkLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(872, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnModify, Me.gbxContainer, Me.btnNew, Me.btnExit, Me.btnSave, Me.btnDelete, Me.grdLog})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FWorkLog"
        Me.Text = "������־"
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsLog, dsPeriod, dsPostAndJob, dsUserPost As DataSet
    Private SystemDate As DateTime
    Private dgtsLog As DataGridTableStyle
    Private htJudgedDates As Hashtable  '�����Ѿ��ж��ǲ��Ǽ��յ�����

    Protected Overridable Function GetSqlQueryCondition() As String
        Return "{start_time >= '" & dtpWorkDate.Value.ToString("yyyy-MM-dd") & _
                "' AND start_time < '" + dtpEndDate.Value.AddDays(1).ToString("yyyy-MM-dd") & "' AND attend_person = '" & _
                 UserName.ToString() & "' AND auto = 0 ORDER BY start_time}"
    End Function

    'ˢ�±�������
    Private Sub RefreshDataGridCaptionText()
        grdLog.CaptionText = "�������ڣ�" & String.Format("{0:yyyy��M��d��}", dtpWorkDate.Value) & _
                        "  ��  " & String.Format("{0:yyyy��M��d��}", dtpEndDate.Value) & "����־��¼����" & dsLog.Tables(0).Rows.Count.ToString
    End Sub

    Private Sub RefreshWorkLog(Optional ByVal hasAddedRecord As Boolean = False)
        dsLog = gWs.GetWorkLogInfo(GetSqlQueryCondition)
        If hasAddedRecord Then '�������ļ�¼,������־��ţ�Ϊ��С��serial_num
            Dim leastSerialNum As Int64 = Convert.ToInt64(dsLog.Tables(0).Select("log_number IS NULL", "serial_num")(0)("serial_num")) 'log_number
            Dim row As DataRow
            For Each row In dsLog.Tables(0).Rows
                If IsDBNull(row("log_number")) Then
                    row("log_number") = leastSerialNum
                End If
            Next
            Dim result As String = gWs.UpdateWorkLog(dsLog.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("", "��ȡ������־ʧ��", result, "")
            End If
        End If
        dsLog.Tables("work_log").Columns.Add(New DataColumn("StartTimeNoDate", GetType(String)))
        dsLog.Tables("work_log").Columns.Add(New DataColumn("EndTimeNoDate", GetType(String)))
        Dim dr As DataRow
        For Each dr In dsLog.Tables("work_log").Rows
            If IsDBNull(dr("start_time")) Then
                dr("StartTimeNoDate") = DBNull.Value
            Else
                dr("StartTimeNoDate") = Format(dr("start_time"), "HH:mm")
            End If
            If IsDBNull(dr("finish_time")) Then
                dr("EndTimeNoDate") = DBNull.Value
            Else
                dr("EndTimeNoDate") = Format(dr("finish_time"), "HH:mm")
            End If
        Next
        If dsLog.HasChanges Then
            dsLog.AcceptChanges()
        End If
        grdLog.SetDataBinding(dsLog, "work_log")
        RefreshDataGridCaptionText()
    End Sub

    Private Sub FWorkLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            dsPeriod = gWs.GetJobPeriodInfo("%")
            dsPostAndJob = gWs.GetPostAndJobResponsibilityInfo("%", "%")
            dsUserPost = gWs.GetUserPostInfo("{staff_name='" & UserName & "'}")
            '���û�����ù���ʱ�Σ��������а�ť
            If dsPeriod.Tables(0).Rows.Count = 0 Then
                btnNew.Enabled = False
            End If
            SystemDate = gWs.GetSysTime
            dtpWorkDate.Value = SystemDate
            dtpEndDate.Value = dtpWorkDate.Value

            AddTableStyle()
            WorkDateChanged(False, Nothing)

            '��ʼ����λѡ���
            Initialize_cboPost()
            AddHandler cboJob.SelectedIndexChanged, AddressOf JobChanged
            AddHandler cboPost.SelectedIndexChanged, AddressOf PostChanged
            AddHandler dtpWorkDate.ValueChanged, AddressOf WorkDateChanged
            AddHandler dtpEndDate.ValueChanged, AddressOf EndDateChanged
            SetControlEnabled(False)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AddTableStyle()
        If dgtsLog Is Nothing Then
            dgtsLog = New DataGridTableStyle()
            dgtsLog.MappingName = "work_log"
            Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col1.MappingName = "start_time"
            col1.HeaderText = "��������"
            col1.NullText = String.Empty
            col1.Format = "yyyy��M��d��"
            col1.Width = 95
            Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col2.MappingName = "StartTimeNoDate"
            col2.Format = "HH:mm"
            col2.HeaderText = "��ʼʱ��"
            col2.Width = 55
            col2.NullText = String.Empty
            Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col3.MappingName = "EndTimeNoDate"
            col3.HeaderText = "����ʱ��"
            col3.Format = "HH:mm"
            col3.Width = 55
            col3.NullText = String.Empty
            Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col4.MappingName = "post_name"
            col4.HeaderText = "��λ���"
            col4.NullText = String.Empty
            col4.Width = 75
            Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col5.MappingName = "task_name"
            col5.HeaderText = "ְ�����"
            col5.NullText = String.Empty
            col5.Width = 85
            Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col6.MappingName = "subtask_name"
            col6.HeaderText = "�������"
            col6.Width = 120
            col6.NullText = String.Empty
            Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col7.MappingName = "description"
            col7.HeaderText = "��������"
            col7.NullText = String.Empty
            col7.Width = 1000
            Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col8.MappingName = "period"
            col8.HeaderText = "����ʱ��"
            col8.NullText = String.Empty
            col8.Width = 65
            Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col9.MappingName = "man_hour"
            col9.HeaderText = "��ʱ"
            col9.NullText = String.Empty
            col9.Width = 35
            dgtsLog.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col6, col8, col9, col7})
        End If
        grdLog.TableStyles.Clear()
        grdLog.TableStyles.Add(dgtsLog)
    End Sub


    Private Sub SetButtonEnabled(ByVal btnNewEn As Boolean, ByVal btnModifyEn As Boolean, ByVal btnDeleteEn As Boolean, _
                                        ByVal btnSaveEn As Boolean, ByVal btnCancelEn As Boolean, ByVal grdLogEn As Boolean)
        btnNew.Enabled = btnNewEn
        btnModify.Enabled = btnModifyEn
        btnDelete.Enabled = btnDeleteEn
        btnSave.Enabled = btnSaveEn
        btnCancel.Enabled = btnCancelEn
        grdLog.Enabled = grdLogEn
    End Sub

    Private Sub DatarowToControl(ByVal row As DataRow)
        If IsDBNull(row("start_time")) Then
            'dtpWorkDate.Value = SystemDate
            cboStartTime.Text = String.Empty
        Else
            'dtpWorkDate.Value = DateTime.Parse(row("start_time"))
            cboStartTime.Text = Format(DateTime.Parse(row("start_time")), "HH:mm")
        End If
        If IsDBNull(row("finish_time")) Then
            cboEndTime.Text = String.Empty
        Else
            Dim dt As DateTime = DateTime.Parse(row("finish_time"))
            cboEndTime.Text = Format(dt, "HH:mm")
        End If
        If IsDBNull(row("post_name")) Then
            cboPost.SelectedItem = Nothing
        Else
            cboPost.SelectedItem = row("post_name")
        End If
        If IsDBNull(row("task_name")) Then
            cboJob.SelectedItem = Nothing
        Else
            cboJob.SelectedItem = row("task_name")
        End If
        If IsDBNull(row("subtask_name")) Then
            cboTask.SelectedItem = Nothing
        Else
            cboTask.SelectedItem = row("subtask_name")
        End If
        If IsDBNull(row("description")) Then
            txtContent.Text = String.Empty
        Else
            txtContent.Text = row("description")
        End If
    End Sub

    Private Sub ControlToDatarow(ByVal row As DataRow)
        row("post_name") = cboPost.SelectedItem
        row("task_name") = cboJob.SelectedItem
        row("subtask_name") = cboTask.SelectedItem
        row("description") = txtContent.Text
    End Sub

    '������־�����࣬һ������ݼ٣���� �����������ϰ���

    '������־�����ڼ���ʱ��ʱ��Ϊ�����ռӰࡱ����ʱ���������ϰࡱ���㣬ͷβ����Ҫ��֣��м����ڰ��������ϰࡱ����
    '���ݼ١�������١���־ʱ����ʱ���������ϰࡱ���㣬ͷβ����Ҫ��֣��м����ڰ��������ϰࡱ����,�ڼ�����ڼ���ʱ��ʱ��Ϊ���ݼٻ���١�
    '������־������Ӱ�

    '�����ϰ����ʱ��ͷβ����Ҫ��֣��м����ڰ��������ϰࡱ����
    '�Ӱ� overtime

    Private Sub CreateRecords(ByVal start_date As Date, ByVal start_time As String, ByVal end_date As Date, ByVal end_time As String)
        Dim needSaveOvertimeRecord As Boolean = (GetJobTaskType() = 0) '�ж��Ƿ���Ҫ���㲢����Ӱ���־
        Dim saveOvertimeRecord As Boolean = False  '�����Ƿ񱣴�Ӱ���־��Ĭ��ΪFalse
        If needSaveOvertimeRecord Then
            Dim hasOvertimeLogs As Boolean
            If start_date < end_date Then '�������ڲ���ͬһ��
                hasOvertimeLogs = HasOvertimeWorkLog(start_time, "23:59") OrElse HasOvertimeWorkLog("00:00", end_time)
            Else 'ͬһ��
                hasOvertimeLogs = HasOvertimeWorkLog(start_time, end_time)
            End If
            If hasOvertimeLogs Then '�ж��Ƿ��мӰ���־
                Dim dlgResult As DialogResult = MessageBox.Show("�Ƿ����ɼӰ�ʱ����־��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                saveOvertimeRecord = (dlgResult = DialogResult.Yes)
            End If
        End If

        If start_date < end_date Then '����
            SplitRecord(start_date, start_time, "23:59", saveOvertimeRecord) '����������־
        Else 'ͬһ��
            SplitRecord(start_date, start_time, end_time, saveOvertimeRecord)
        End If

        Dim currentDate As Date = start_date.AddDays(1) '��ȥͷβ�����������������־
        While currentDate < end_date
            Dim dv As DataView = dsPeriod.Tables(0).DefaultView
            dv.Sort = "start_time"
            Dim i As Int16
            For i = 0 To dv.Count - 1
                If dv(i)("period") = "�����ϰ�" Then
                    Dim isHoliday As Boolean = SpecifiedDateIsHoliday(currentDate)
                    If needSaveOvertimeRecord Or (GetJobTaskType() = 2) Then
                        If isHoliday Then
                            InsertOneWorkLog(currentDate, dv(i)("start_time"), dv(i)("end_time"), "���ռӰ�")
                        Else
                            InsertOneWorkLog(currentDate, dv(i)("start_time"), dv(i)("end_time"), dv(i)("period"))
                        End If
                    ElseIf Not isHoliday Then
                        InsertOneWorkLog(currentDate, dv(i)("start_time"), dv(i)("end_time"), cboTask.SelectedItem.ToString) '����������Ϊ�ݼ٣����
                    End If
                End If
            Next
            currentDate = currentDate.AddDays(1)
        End While

        If start_date < end_date Then '����
            SplitRecord(end_date, "00:00", end_time, saveOvertimeRecord) '����β����־
        End If
    End Sub

    'ֻ����Ҫ����Ӱ�Ĺ�����־������Ҫ�ж���û�мӰ�ļ�¼
    Private Function HasOvertimeWorkLog(ByVal start_time As String, ByVal end_time As String) As Boolean
        Dim length As Int32 = dsPeriod.Tables(0).Select("period='�����ϰ�'").Length
        Dim dv As DataView = dsPeriod.Tables(0).DefaultView
        dv.Sort = "start_time"
        Dim startTimes(length), endTimes(length) As String
        Dim i As Int16
        For i = 0 To dv.Count - 1
            If dv(i)("period") <> "�����ϰ�" Then
                If String.Compare(start_time, dv(i)("start_time")) >= 0 AndAlso String.Compare(start_time, dv(i)("end_time")) < 0 Then
                    Return True
                End If
                If String.Compare(end_time, dv(i)("start_time")) > 0 AndAlso String.Compare(end_time, dv(i)("end_time")) <= 0 Then
                    Return True
                End If
                If String.Compare(start_time, dv(i)("start_time")) <= 0 AndAlso String.Compare(end_time, dv(i)("end_time")) >= 0 Then
                    Return True
                End If
            Else
                If i = 0 Then
                    startTimes(0) = dv(i)("start_time")
                    endTimes(0) = dv(i)("end_time")
                ElseIf String.Compare(endTimes(i - 1), dv(i)("start_time")) = 0 Then
                    startTimes(i) = startTimes(i - 1)
                    endTimes(i) = dv(i)("end_time")
                Else
                    startTimes(i) = dv(i)("start_time")
                    endTimes(i) = dv(i)("end_time")
                End If
            End If
        Next
        For i = 0 To startTimes.Length - 1
            If String.Compare(start_time, startTimes(i)) >= 0 And String.Compare(end_time, endTimes(i)) <= 0 Then
                Return False
            End If
        Next
        Return True
    End Function


    '[C#]
    'public static int Compare(
    '   string strA,
    '   string strB
    ');

    'С���� strA С�� strB�� 
    '�� strA ���� strB�� 
    '������ strA ���� strB�� 

    '�����Ŀ
    Private Sub SplitRecord(ByVal work_date As Date, ByVal start_time As String, ByVal end_time As String, Optional ByVal saveOvertimeRec As Boolean = True)
        If dsPeriod.Tables(0).Rows.Count = 0 Then
            Return
        End If

        Dim needSaveOvertimeRecord As Boolean = (GetJobTaskType() = 0) '�ж��Ƿ���Ҫ���㲢����Ӱ���־�������������ϰ࣬�ǡ��ݼ٣���٣����
        Dim period As String = Nothing '�׶�
        Dim isHolidayDate As Boolean = SpecifiedDateIsHoliday(work_date)

        If isHolidayDate Then
            If needSaveOvertimeRecord Then
                InsertOneWorkLog(work_date, start_time, end_time, "���ռӰ�")
                Return
            ElseIf GetJobTaskType() = 1 Then '��٣��ݼ� ���ñ���
                Return
            End If
        End If

        Dim dv As DataView = dsPeriod.Tables(0).DefaultView
        dv.Sort = "start_time"
        Dim i As Int16
        For i = 0 To dv.Count - 1
            If needSaveOvertimeRecord Then
                period = dv(i)("period")
            ElseIf GetJobTaskType() = 1 Then
                period = cboTask.SelectedItem.ToString
            ElseIf GetJobTaskType() = 2 Then '����
                If isHolidayDate Then
                    period = "���ռӰ�"
                Else
                    period = dv(i)("period")
                End If
            End If
            If String.Compare(start_time, dv(i)("start_time")) <= 0 Then '����Ŀ�ʼʱ��С�����ʱ�εĿ�ʼʱ��
                If String.Compare(end_time, dv(i)("start_time")) <= 0 Then '����Ľ���ʱ��С�����ʱ�εĿ�ʼʱ��
                    If saveOvertimeRec Then
                        InsertOneWorkLog(work_date, start_time, end_time) '�Ӱ࣬Ҫ�ж���ƽʱ�Ӱ໹�ǽڼ��ռӰ�
                        Exit For
                    End If
                Else '����Ľ���ʱ�����ʱ�εĽ���ʱ��
                    If String.Compare(end_time, dv(i)("end_time")) > 0 Then '����Ľ���ʱ�������ʱ�εĽ���ʱ��
                        If saveOvertimeRec Then
                            InsertOneWorkLog(work_date, start_time, dv(i)("start_time")) '�Ӱ࣬Ҫ�ж���ƽʱ�Ӱ໹�ǽڼ��ռӰ�
                        End If
                        If needSaveOvertimeRecord Then
                            If saveOvertimeRec Or period = "�����ϰ�" Then '���û�ѡ�񡰲�����Ӱ���־��ʱ���ų�����ʱ�α��ʱ��Ϊ���Ӱࡱ��ʱ���
                                InsertOneWorkLog(work_date, dv(i)("start_time"), dv(i)("end_time"), period) 'ʱ��������ڹ���ʱ�α��壬��ʱ���Ѿ�����
                            End If
                        ElseIf dv(i)("period") <> "ƽʱ�Ӱ�" Then
                            InsertOneWorkLog(work_date, dv(i)("start_time"), dv(i)("end_time"), period) 'ʱ��������ڹ���ʱ�α��壬��ʱ���Ѿ�����
                        End If
                        If i = dv.Count - 1 Then
                            If saveOvertimeRec Then
                                InsertOneWorkLog(work_date, dv(i)("end_time"), end_time) '�Ӱ࣬Ҫ�ж���ƽʱ�Ӱ໹�ǽڼ��ռӰ�
                            End If
                        Else
                            start_time = dv(i)("end_time").ToString
                        End If
                    Else '����Ľ���ʱ������ʱ�εĶ�������
                        If saveOvertimeRec Then
                            InsertOneWorkLog(work_date, start_time, dv(i)("start_time")) '�Ӱ࣬Ҫ�ж���ƽʱ�Ӱ໹�ǽڼ��ռӰ�
                        End If
                        If needSaveOvertimeRecord Then
                            If saveOvertimeRec Or period = "�����ϰ�" Then
                                InsertOneWorkLog(work_date, dv(i)("start_time"), end_time, period) 'ʱ�ζ���Ĺ���
                            End If
                        ElseIf dv(i)("period") <> "ƽʱ�Ӱ�" Then
                            InsertOneWorkLog(work_date, dv(i)("start_time"), end_time, period) 'ʱ�ζ���Ĺ���
                        End If
                        Exit For
                    End If
                End If
            Else '����Ŀ�ʼʱ�����ʱ�εĿ�ʼʱ�� 
                If String.Compare(end_time, dv(i)("end_time")) <= 0 Then '����ʱ��ȫ������ʱ������
                    If needSaveOvertimeRecord Then
                        If saveOvertimeRec Or period = "�����ϰ�" Then
                            InsertOneWorkLog(work_date, start_time, end_time, period) 'ʱ�ζ���Ĺ���
                        End If
                    ElseIf dv(i)("period") <> "ƽʱ�Ӱ�" Then
                        InsertOneWorkLog(work_date, start_time, end_time, period) 'ʱ�ζ���Ĺ���
                    End If
                    Exit For
                ElseIf String.Compare(start_time, dv(i)("end_time")) < 0 Then '��������ʱ�����䣬���뿪ʼʱ��С��ʱ�ν���ʱ��
                    If needSaveOvertimeRecord Then
                        If saveOvertimeRec Or period = "�����ϰ�" Then
                            InsertOneWorkLog(work_date, start_time, dv(i)("end_time"), period)  'ʱ�ζ���Ĺ���
                        End If
                    ElseIf dv(i)("period") <> "ƽʱ�Ӱ�" Then
                        InsertOneWorkLog(work_date, start_time, dv(i)("end_time"), period)  'ʱ�ζ���Ĺ���
                    End If
                    If i = dv.Count - 1 Then
                        If saveOvertimeRec Then
                            InsertOneWorkLog(work_date, dv(i)("end_time"), end_time) '�Ӱ࣬Ҫ�ж���ƽʱ�Ӱ໹�ǽڼ��ռӰ�
                        End If
                    Else
                        start_time = dv(i)("end_time")
                    End If
                ElseIf dv.Count - 1 = i Then '��ǰʱ�μ�¼�����һ������ʾ����Ŀ�ʼʱ�������ʱ�ζ�������Ľ���ʱ��
                    If saveOvertimeRec Then
                        InsertOneWorkLog(work_date, start_time, end_time) '�Ӱ࣬Ҫ�ж���ƽʱ�Ӱ໹�ǽڼ��ռӰ�
                    End If
                    Exit For
                End If
            End If
        Next
    End Sub

    'ָ����ĳһ���Ƿ�Ϊ����
    Private Function SpecifiedDateIsHoliday(ByVal yourDate As DateTime) As Boolean
        If htJudgedDates Is Nothing Then
            htJudgedDates = New Hashtable()
        End If
        Dim result As Boolean
        If htJudgedDates.ContainsKey(yourDate.ToString("yyyy-MM-dd")) Then
            result = CBool(htJudgedDates.Item(yourDate.ToString("yyyy-MM-dd")))
        Else
            Dim strSql As String = "{holiday>'" & yourDate.AddDays(-1).ToString("yyyy-MM-dd") & _
                                                             "' AND holiday<'" & yourDate.AddDays(1).ToString("yyyy-MM-dd") & "'}"
            Dim dsHoliday As DataSet = gWs.GetHolidayInfo(strSql)
            result = dsHoliday.Tables(0).Rows.Count > 0
            dsHoliday.Dispose()
            htJudgedDates.Add(yourDate.ToString("yyyy-MM-dd"), result)
        End If

        Return result
    End Function

    '����̳��ำֵ�����е�ĳЩ��
    Protected Overridable Sub SetColumnValueForNewDataRow(ByVal newRow As DataRow)

    End Sub

    '��Ϊ������Ϊ���жϿ�ʼʱ�䣬����ʱ���Ƿ���Ч
    Private Sub InsertOneWorkLog(ByVal work_date As Date, ByVal start_time As String, ByVal end_time As String, Optional ByVal periodName As String = "")
        If String.Compare(start_time, end_time) >= 0 Then
            Return
        End If

        Dim dtStart As DateTime = DateTime.Parse(start_time)
        Dim dtEnd As DateTime = DateTime.Parse(end_time)
        Dim mins As Int32 = (dtEnd.Hour * 60 + dtEnd.Minute) - (dtStart.Hour * 60 + dtStart.Minute)

        Dim row As DataRow = dsLog.Tables(0).NewRow
        ControlToDatarow(row)
        row("auto") = False
        row("create_date") = SystemDate
        row("attend_person") = UserName
        If periodName <> String.Empty Then
            row("period") = periodName
        Else
            row("period") = "ƽʱ�Ӱ�"
        End If
        row("man_hour") = Format(mins / 60, "0.0") '��ʱ
        row("start_time") = New DateTime(work_date.Year, work_date.Month, work_date.Day, dtStart.Hour, dtStart.Minute, 0)
        row("finish_time") = New DateTime(work_date.Year, work_date.Month, work_date.Day, dtEnd.Hour, dtEnd.Minute, 0)
        row("day_name") = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(work_date.DayOfWeek)
        SetColumnValueForNewDataRow(row)
        dsLog.Tables(0).Rows.Add(row)

        'If txtContent.Text = String.Empty Then
        '    txtContent.Text = String.Format("��ʼʱ�䣺{0} -- ����ʱ�䣺{1} -- ʱ�Σ�{2}", start_time, end_time, periodName) & System.Environment.NewLine
        'Else
        '    txtContent.Text = txtContent.Text & String.Format("��ʼʱ�䣺{0} -- ����ʱ�䣺{1} -- ʱ�Σ�{2}", start_time, end_time, periodName) & System.Environment.NewLine
        'End If

    End Sub

    Private Sub SetControlEnabled(ByVal enabled As Boolean)
        dtpWorkDate.Enabled = Not enabled
        cboStartTime.Enabled = enabled
        cboEndTime.Enabled = enabled
        cboPost.Enabled = enabled
        cboJob.Enabled = enabled
        cboTask.Enabled = enabled
        txtContent.ReadOnly = Not enabled
    End Sub

    Private Sub Initialize_cboPost()
        Dim row As DataRow
        For Each row In dsUserPost.Tables("TUserPost").Rows
            cboPost.Items.Add(row("post_name"))
        Next
    End Sub

    '�������ڸı����ʾָ�����ڵĹ�����־
    Private Sub WorkDateChanged(ByVal sender As Object, ByVal e As EventArgs)
        If dtpEndDate.Value.Date < dtpWorkDate.Value.Date Then
            dtpEndDate.Tag = "NotRefresh"
            dtpEndDate.Value = dtpWorkDate.Value
            dtpEndDate.Tag = "Refresh"
        End If

        If Not grdLog.Enabled Then
            grdLog.Enabled = True
        End If

        If sender.GetType Is GetType(DateTimePicker) Then
            RefreshWorkLog()
        Else
            RefreshWorkLog(CBool(sender))
        End If

        If grdLog.CurrentRowIndex >= 0 Then
            DatarowToControl(dsLog.Tables("work_log").Rows(grdLog.CurrentRowIndex))
            '����������������ʾ��¼ʱ���ּ�¼
            txtContent.Tag = dsLog.Tables("work_log").Rows(grdLog.CurrentRowIndex)("serial_num")
            SetButtonEnabled(True, True, True, False, False, True)
        Else
            SetButtonEnabled(True, False, False, False, False, True)
        End If
    End Sub

    Private Sub EndDateChanged(ByVal sender As Object, ByVal e As EventArgs)
        If dtpWorkDate.Enabled Then
            If dtpEndDate.Tag Is Nothing OrElse dtpEndDate.Tag = "Refresh" Then
                RefreshWorkLog()
            End If
        End If
    End Sub

    '��λ�ı��
    Private Sub PostChanged(ByVal sender As Object, ByVal e As EventArgs)
        '����չ���ְ���ѡ������
        cboJob.Items.Clear()
        If Not cboPost.SelectedItem Is Nothing Then
            Dim drs() As DataRow = dsPostAndJob.Tables("TPost").Select("post_name='" & cboPost.SelectedItem.ToString & "'")
            Dim row As DataRow
            For Each row In drs
                If cboJob.Items.IndexOf(row("post_responsibility")) < 0 Then
                    cboJob.Items.Add(row("post_responsibility"))
                End If
            Next
        End If
        cboJob.Text = String.Empty
        cboTask.Text = String.Empty
    End Sub

    '����ְ��ı��
    Private Sub JobChanged(ByVal sender As Object, ByVal e As EventArgs)
        cboTask.Items.Clear()
        If Not cboJob.SelectedItem Is Nothing Then
            Dim drs() As DataRow = dsPostAndJob.Tables("TJobResponsibility").Select("post_responsibility='" & cboJob.SelectedItem.ToString & "'")
            Dim row As DataRow
            For Each row In drs
                cboTask.Items.Add(row("post_task"))
            Next
        End If
        cboTask.Text = String.Empty
    End Sub

    '��ǰְ�����ͬ��������Ƿ��к���Ȩ
    Private Function HasLaterInputRecord() As Boolean
        If cboJob.SelectedItem Is Nothing OrElse cboTask.SelectedItem Is Nothing Then
            Return False
        End If
        Dim row As DataRow = dsPostAndJob.Tables("TJobResponsibility").Select("post_responsibility='" & _
                                    cboJob.SelectedItem.ToString & "' AND post_task='" & cboTask.SelectedItem.ToString & "'")(0)
        Return CBool(row("laterInput_privilege"))
    End Function

    '0��ʾ��ǰ���������Ҫ����Ӱ๤ʱ��1��ʾ����Ҫ����
    Private Function GetJobTaskType() As Int16
        Dim row As DataRow = dsPostAndJob.Tables("TJobResponsibility").Select("post_responsibility='" & _
                                            cboJob.SelectedItem.ToString & "' AND post_task='" & cboTask.SelectedItem.ToString & "'")(0)
        Return CInt(row("post_task_type"))
    End Function

    Private Sub grdLog_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdLog.CurrentCellChanged
        Dim row As DataRow = CType(Me.BindingContext(dsLog, "work_log").Current, DataRowView).Row
        If txtContent.Tag Is Nothing Then
            DatarowToControl(row)
        ElseIf txtContent.Tag & "" <> row("serial_num") & "" Then
            DatarowToControl(row)
        End If
        txtContent.Tag = row("serial_num")
    End Sub

#Region "ʱ�����"
    Private Sub FillTimeComboBox(ByVal cboTime As ComboBox)
        Dim i, j As Int16
        For i = 8 To 23
            j = 0
            While j < 60
                cboTime.Items.Add(Format(DateTime.Parse(i & ":" & j.ToString), "HH:mm"))
                j += 30
            End While
        Next
        For i = 0 To 7
            j = 0
            While j < 60
                cboTime.Items.Add(Format(DateTime.Parse(i & ":" & j.ToString), "HH:mm"))
                j += 30
            End While
        Next
    End Sub

    Private Sub StartTimeLeave(ByVal sender As Object, ByVal e As EventArgs) Handles cboStartTime.Leave
        Try
            Dim dt As DateTime = DateTime.Parse(cboStartTime.Text)
            If cboStartTime.SelectedIndex < 0 Then
                'cboEndTime.SelectedIndex = dt.Hour * 2 + Math.Ceiling(dt.Minute / 10)
                cboStartTime.Text = Format(dt, "HH:mm")
                'ElseIf cboStartTime.SelectedIndex < cboEndTime.Items.Count - 1 Then
                '    cboEndTime.SelectedIndex = cboStartTime.SelectedIndex + 1
                cboEndTime.Text = Format(dt.AddMinutes(30), "HH:mm")
            End If
        Catch
            cboStartTime.Text = ""
            cboEndTime.Text = ""
        End Try
    End Sub

    Private Sub EndTimeLeave(ByVal sender As Object, ByVal e As EventArgs) Handles cboEndTime.Leave
        Try
            If cboEndTime.SelectedIndex < 0 Then
                Dim dt As DateTime = DateTime.Parse(cboEndTime.Text)
                cboEndTime.Text = Format(dt, "HH:mm")
            End If
        Catch
            cboEndTime.Text = ""
        End Try
    End Sub

#End Region

    '��ť�����¼�
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim newDr As DataRow = dsLog.Tables(0).NewRow
        DatarowToControl(newDr)
        newDr.Delete()
        SetControlEnabled(True)
        SetButtonEnabled(False, False, False, True, True, False)
        If cboPost.Items.Count > 0 Then
            cboPost.SelectedIndex = 0
            If dsUserPost.Tables(0).Rows.Count > 0 Then
                If Not IsDBNull(dsUserPost.Tables(0).Rows(0)("default_responsibility")) Then
                    cboJob.SelectedItem = dsUserPost.Tables(0).Rows(0)("default_responsibility")
                    If cboJob.SelectedIndex < 0 AndAlso cboJob.Items.Count > 0 Then
                        cboJob.SelectedItem = 0
                    End If
                    If Not IsDBNull(dsUserPost.Tables(0).Rows(0)("default_task")) Then
                        cboTask.SelectedItem = dsUserPost.Tables(0).Rows(0)("default_task")
                        If cboTask.SelectedIndex < 0 AndAlso cboTask.Items.Count > 0 Then
                            cboTask.SelectedIndex = 0
                        End If
                    End If
                End If
            End If
        End If
        cboStartTime.SelectedIndex = 0
        cboEndTime.Text = Format(SystemDate, "HH:mm")
        btnSave.Tag = "NEW"
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        DatarowToControl(CType(Me.BindingContext(dsLog, "work_log").Current, DataRowView).Row)
        SetControlEnabled(True)
        SetButtonEnabled(False, False, False, True, True, False)
        btnSave.Tag = "MODIFY"
        'dtpEndDate.Value = dtpWorkDate.Value '��仰�������SetButtonEnabled(False, False, False, True, True, False)֮��
        dtpEndDate.Enabled = False
    End Sub

    '����ɾ��
    Private Sub DeleteSingRecord(ByVal sender As Object, ByVal e As EventArgs) Handles muitDeleteSingle.Click
        'If SWDialogBox.MessageBox.Show("?1004", "") = DialogResult.Yes Then
        dsLog.Tables("work_log").Rows(grdLog.CurrentRowIndex).Delete()
        Dim result As String = gWs.UpdateWorkLog(dsLog.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "ɾ��ʧ��", result, "")
        Else
            dsLog.AcceptChanges()
            SWDialogBox.MessageBox.Show("$DeleteSucceed")
        End If
        Dim hasRecord As Boolean = grdLog.CurrentRowIndex >= 0
        SetButtonEnabled(True, hasRecord, hasRecord, False, False, True)
        RefreshDataGridCaptionText()
        'End If
    End Sub

    '����ɾ��
    Private Sub DeleteBatchRecord(ByVal sender As Object, ByVal e As EventArgs) Handles muitDeleteBatch.Click
        'ȷ����ǰ���ݼ��Ѱ�����ǰ��־��ŵļ�¼��
        'If SWDialogBox.MessageBox.Show("?1005", "") = DialogResult.Yes Then
        Dim logNum As String = dsLog.Tables("work_log").Rows(grdLog.CurrentRowIndex)("log_number").ToString
        Dim dsLogTemp As DataSet = gWs.GetWorkLogInfo("{serial_num>=" & logNum & " AND log_number=" & logNum & "}")
        Dim i, count As Int32
        count = dsLogTemp.Tables(0).Rows.Count
        For i = count - 1 To 0 Step -1
            dsLogTemp.Tables(0).Rows(i).Delete()
        Next
        Dim result As String = gWs.UpdateWorkLog(dsLogTemp.GetChanges)
        dsLogTemp.Dispose()
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "ɾ��ʧ��", result, "")
        Else
            RefreshWorkLog()
            SWDialogBox.MessageBox.Show("$DeleteSucceed")
        End If
        Dim hasRecord As Boolean = grdLog.CurrentRowIndex >= 0
        SetButtonEnabled(True, hasRecord, hasRecord, False, False, True)
        RefreshDataGridCaptionText()
        'End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dlgResult As DialogResult = MessageBox.Show("�Ƿ�ɾ����������Ĺ�����־��" & System.Environment.NewLine & "��""����""ѡ����,""����""ѡ���", "ȷ����ʾ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If dlgResult = DialogResult.Yes Then
            DeleteBatchRecord(Nothing, Nothing)
        ElseIf dlgResult = DialogResult.No Then
            DeleteSingRecord(Nothing, Nothing)
        End If
        'cmuDelete.Show(btnDelete, New Point(0, btnDelete.Height)) '��ʾɾ���˵�
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If dsLog.HasChanges Then
            dsLog.RejectChanges()
        End If
        If btnSave.Tag & "" = "MODIFY" Then
            'Dim rows() As DataRow = dsLog.Tables("work_log").Select("", "start_time DESC")
            'If rows.Length > 0 Then
            '    dtpEndDate.Value = DateTime.Parse(rows(0)("start_time")).Date '�������SetButtonEnabled(True, hasRecord, hasRecord, False, False, True)֮ǰ
            'End If
            dtpEndDate.Enabled = True
        End If
        Dim hasRecord As Boolean = grdLog.CurrentRowIndex >= 0
        SetButtonEnabled(True, hasRecord, hasRecord, False, False, True)
        If hasRecord Then
            DatarowToControl(CType(Me.BindingContext(dsLog, "work_log").Current, DataRowView).Row)
        End If
        SetControlEnabled(False)
    End Sub

    Private Function IsInfoEffective() As Boolean
        If dtpWorkDate.Value.Date > SystemDate.Date Then
            SWDialogBox.MessageBox.Show("$1003", "(�������ڲ��ܴ��ڽ���)")
            dtpWorkDate.Focus()
            Return False
        End If
        If dtpWorkDate.Value.Date > dtpEndDate.Value.Date Then
            SWDialogBox.MessageBox.Show("$1008", "��ʼ����", "��ֹ����")
            dtpEndDate.Focus()
            Return False
        End If
        If cboPost.SelectedItem Is Nothing Then
            SWDialogBox.MessageBox.Show("$1001", "��λ���")
            cboPost.Focus()
            Return False
        ElseIf cboJob.SelectedItem Is Nothing Then
            SWDialogBox.MessageBox.Show("$1001", "ְ�����")
            cboJob.Focus()
            Return False
        ElseIf cboTask.SelectedItem Is Nothing Then
            SWDialogBox.MessageBox.Show("$1001", "�������")
            cboTask.Focus()
            Return False
        End If

        If cboStartTime.Text = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", "��ʼʱ��")
            cboStartTime.Focus()
            Return False
        ElseIf cboEndTime.Text = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", "����ʱ��")
            cboEndTime.Focus()
            Return False
        ElseIf dtpWorkDate.Value.Date = dtpEndDate.Value.Date AndAlso String.Compare(cboStartTime.Text, cboEndTime.Text) >= 0 Then
            SWDialogBox.MessageBox.Show("$1003", "(��ʼʱ��ӦС�ڽ���ʱ��)")
            cboEndTime.Focus()
            Return False
        End If
        '���û�к���Ȩ
        If Not HasLaterInputRecord() Then
            If CompareToFiveWorkingDays(dtpWorkDate.Value.Date, SystemDate) > 0 Then
                SWDialogBox.MessageBox.Show("$1003", "(������¼�������������ǰ�Ĺ�����־��)")
                dtpWorkDate.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    '��־��ʼ������ϵͳ���ڵ�ǰ5����������Ƚϣ�����Խ�򷵻�1�����򷵻�0
    Private Function CompareToFiveWorkingDays(ByVal startDate As DateTime, ByVal endDate As DateTime) As Int16
        Dim strSql As String = "SELECT * FROM holiday WHERE holiday<'" & endDate.AddDays(1).ToString("yyyy-MM-dd") & "'"
        Dim dsQuery As DataSet = gWs.GetCommonQueryInfo(strSql)

        Dim fiveBefore, eachDate As DateTime

        Dim i, j As Int16
        j = 1
        Dim isHoliday As Boolean = True
        While i < 5

            While isHoliday
                eachDate = endDate.AddDays(j * -1)
                isHoliday = (dsQuery.Tables(0).Select("holiday>=#" & eachDate.ToString("yyyy-MM-dd") & _
                                            "# AND holiday<#" & eachDate.AddDays(1).ToString("yyyy-MM-dd") & "#").Length > 0)
                j += 1
            End While

            fiveBefore = eachDate
            i += 1
            isHoliday = True
        End While

        dsQuery.Dispose()

        If startDate.Date < fiveBefore.Date Then
            Return 1
        End If

        Return 0
    End Function

    '���ݲ�ֺ�ļ�¼���ж�ʱ����û���ص�
    Private Function HasOverlapRecords(ByVal sourceRows() As DataRow, ByVal addedRows() As DataRow, ByVal serialNum As Int64) As Boolean
        If addedRows.Length = 0 Or sourceRows.Length = 0 Then
            Return False
        End If
        Dim dsTemp As DataSet = New DataSet()
        dsTemp.Merge(sourceRows)
        Dim row As DataRow
        For Each row In addedRows
            If dsTemp.Tables(0).Select("serial_num<>" & serialNum.ToString & " AND start_time<'" & row("start_time").ToString & "' AND finish_time>'" & row("start_time").ToString & "'").Length > 0 Then
                Return True
            End If
            If dsTemp.Tables(0).Select("serial_num<>" & serialNum.ToString & " AND start_time<'" & row("finish_time").ToString & "' AND finish_time>'" & row("finish_time").ToString & "'").Length > 0 Then
                Return True
            End If
            If dsTemp.Tables(0).Select("serial_num<>" & serialNum.ToString & " AND start_time>='" & row("start_time").ToString & "' AND finish_time<='" & row("finish_time").ToString & "'").Length > 0 Then
                Return True
            End If
            If dsTemp.Tables(0).Select("serial_num<>" & serialNum.ToString & " AND start_time<='" & row("start_time").ToString & "' AND finish_time>='" & row("finish_time").ToString & "'").Length > 0 Then
                Return True
            End If
        Next
        dsTemp.Dispose()
        Return False
    End Function

    Private Function Save(ByVal sender As Object) As Boolean
        If Not IsInfoEffective() Then
            Return False
        End If

        Dim serialNum As Int64 = -1 '�����ͨ������������ť��������¼��serialNumΪ-1
        Dim startDate, endDate As DateTime
        If btnSave.Tag & "" = "MODIFY" Then
            Dim drv As DataRowView = CType(Me.BindingContext(dsLog, "work_log").Current, DataRowView)
            serialNum = Convert.ToInt64(drv("serial_num"))
            startDate = DateTime.Parse(drv("start_time")).Date
            endDate = DateTime.Parse(drv("finish_time")).Date
        Else
            startDate = dtpWorkDate.Value.Date
            endDate = dtpEndDate.Value.Date
        End If

        Dim sourceRows() As DataRow = dsLog.Tables("work_log").Select("", "", DataViewRowState.CurrentRows) '��ǰ��¼
        CreateRecords(startDate, cboStartTime.Text, endDate, cboEndTime.Text)
        Dim addedRows() As DataRow = dsLog.Tables("work_log").Select("", "", DataViewRowState.Added) '��ֺ������ļ�¼
        If HasOverlapRecords(sourceRows, addedRows, serialNum) Then
            dsLog.RejectChanges()
            SWDialogBox.MessageBox.Show("$1003", "(ʱ������ص�)")
            Return False
        End If
        If serialNum <> -1 Then
            Dim logNum As Int64 = Convert.ToInt64(dsLog.Tables("work_log").Select("serial_num=" & serialNum.ToString)(0)("log_number"))
            dsLog.Tables("work_log").Select("serial_num=" & serialNum.ToString)(0).Delete()
            '�������޸ģ�����ǰ��¼��log_numberֵ ���� ������¼��log_number�ֶ�
            Dim row As DataRow
            For Each row In addedRows
                row("log_number") = logNum
            Next
        End If
        If Not dsLog.HasChanges Then
            Return True
        End If
        Dim hasAddedRecord As Boolean = dsLog.HasChanges(DataRowState.Added)
        Dim result As String = gWs.UpdateWorkLog(dsLog.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "����ʧ��", result, "")
            Return False
        Else
            If sender Is Nothing Then
                Return True
            End If
            SetControlEnabled(False)
            If btnSave.Tag & "" = "MODIFY" Then
                'Dim rows() As DataRow = dsLog.Tables("work_log").Select("", "start_time DESC")
                'If rows.Length > 0 Then
                '    dtpEndDate.Value = DateTime.Parse(rows(0)("start_time")).Date '�������SetButtonEnabled(True, hasRecord, hasRecord, False, False, True)֮ǰ
                'End If
                dtpEndDate.Enabled = True
            End If
            WorkDateChanged(hasAddedRecord And (serialNum = -1), Nothing) 'ֻ��ͨ������������ť��������¼�����ݣ��ֶΡ�log_number������Ҫ���¸�ֵ
            SWDialogBox.MessageBox.Show("$SaveSucceed")

            Me.grdLog.Size = New Size(Me.grdLog.Width + 5, Me.grdLog.Height + 5)
            Me.grdLog.Size = New Size(Me.grdLog.Width - 5, Me.grdLog.Height - 5)
        End If
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save(sender)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If btnSave.Enabled Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003")
            If QueryResult = DialogResult.Yes Then
                If Not Save(Nothing) Then
                    Return False
                End If
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf FWorkLog_Closing
        Close()
        Return True
    End Function

    Private Sub FWorkLog_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, Nothing)
    End Sub

End Class
