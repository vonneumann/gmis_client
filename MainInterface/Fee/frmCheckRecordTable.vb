
'���ߣ������ ����޸����ڣ�2003-04-11
Public Class frmCheckRecordTable
    Inherits frmBasic

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAlarm Is Nothing Then
            dsAlarm.Dispose()
        End If
        If Not dsRecord Is Nothing Then
            dsRecord.Dispose()
        End If
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
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgRecord As System.Windows.Forms.DataGrid
    Friend WithEvents dgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents btnLookDocument As System.Windows.Forms.Button
    Protected WithEvents gpbxOpinion As System.Windows.Forms.GroupBox
    Protected WithEvents btnDetailInfo As System.Windows.Forms.Button
    Protected WithEvents txtOpinion As System.Windows.Forms.TextBox
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Protected WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckRecordTable))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgRecord = New System.Windows.Forms.DataGrid()
        Me.gpbxOpinion = New System.Windows.Forms.GroupBox()
        Me.txtOpinion = New System.Windows.Forms.TextBox()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLookDocument = New System.Windows.Forms.Button()
        Me.btnDetailInfo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgDetail = New System.Windows.Forms.DataGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxOpinion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(541, 448)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(453, 448)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 3
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgRecord})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 152)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "�������¼"
        '
        'dgRecord
        '
        Me.dgRecord.CaptionVisible = False
        Me.dgRecord.DataMember = ""
        Me.dgRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRecord.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgRecord.Location = New System.Drawing.Point(3, 17)
        Me.dgRecord.Name = "dgRecord"
        Me.dgRecord.ReadOnly = True
        Me.dgRecord.Size = New System.Drawing.Size(744, 132)
        Me.dgRecord.TabIndex = 0
        '
        'gpbxOpinion
        '
        Me.gpbxOpinion.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxOpinion.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOpinion})
        Me.gpbxOpinion.Location = New System.Drawing.Point(8, 384)
        Me.gpbxOpinion.Name = "gpbxOpinion"
        Me.gpbxOpinion.Size = New System.Drawing.Size(752, 56)
        Me.gpbxOpinion.TabIndex = 0
        Me.gpbxOpinion.TabStop = False
        Me.gpbxOpinion.Text = "������"
        '
        'txtOpinion
        '
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.MaxLength = 50
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(746, 36)
        Me.txtOpinion.TabIndex = 0
        Me.txtOpinion.Text = ""
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Enabled = False
        Me.txtCorName.Location = New System.Drawing.Point(240, 7)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.Size = New System.Drawing.Size(320, 21)
        Me.txtCorName.TabIndex = 64
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 7)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 63
        Me.txtProjectCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "��ҵ����"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "��Ŀ����"
        '
        'btnLookDocument
        '
        Me.btnLookDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLookDocument.Image = CType(resources.GetObject("btnLookDocument.Image"), System.Drawing.Bitmap)
        Me.btnLookDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLookDocument.ImageIndex = 18
        Me.btnLookDocument.ImageList = Me.ImageListBasic
        Me.btnLookDocument.Location = New System.Drawing.Point(312, 448)
        Me.btnLookDocument.Name = "btnLookDocument"
        Me.btnLookDocument.Size = New System.Drawing.Size(128, 23)
        Me.btnLookDocument.TabIndex = 2
        Me.btnLookDocument.Text = "�������¼��(&D)"
        Me.btnLookDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDetailInfo.Image = CType(resources.GetObject("btnDetailInfo.Image"), System.Drawing.Bitmap)
        Me.btnDetailInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetailInfo.ImageIndex = 3
        Me.btnDetailInfo.ImageList = Me.ImageListBasic
        Me.btnDetailInfo.Location = New System.Drawing.Point(184, 448)
        Me.btnDetailInfo.Name = "btnDetailInfo"
        Me.btnDetailInfo.Size = New System.Drawing.Size(120, 23)
        Me.btnDetailInfo.TabIndex = 1
        Me.btnDetailInfo.Text = "��Ŀ��ϸ��Ϣ(&L)"
        Me.btnDetailInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDetail})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(752, 104)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ԥ�����"
        '
        'dgDetail
        '
        Me.dgDetail.CaptionVisible = False
        Me.dgDetail.DataMember = ""
        Me.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetail.Location = New System.Drawing.Point(3, 17)
        Me.dgDetail.Name = "dgDetail"
        Me.dgDetail.ReadOnly = True
        Me.dgDetail.Size = New System.Drawing.Size(746, 84)
        Me.dgDetail.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtContent})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(752, 72)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "�����¼���˵��"
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent.Location = New System.Drawing.Point(3, 17)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ReadOnly = True
        Me.txtContent.Size = New System.Drawing.Size(746, 52)
        Me.txtContent.TabIndex = 11
        Me.txtContent.Text = ""
        '
        'frmCheckRecordTable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(770, 479)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.btnDetailInfo, Me.btnLookDocument, Me.txtCorName, Me.txtProjectCode, Me.Label2, Me.Label3, Me.gpbxOpinion, Me.GroupBox1, Me.btnExit, Me.btnCommit})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCheckRecordTable"
        Me.Text = "��˱������¼��"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxOpinion.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ProjectCode, CorporationName, WorkFlowID, TaskID As String

    Private dsRecord As DataSet
    Private bmRecord As BindingManagerBase
    Private SystemDate As Date
    Private dsAlarm As DataSet

    '��������Դ
    Private Sub GetDataSource()
        dsRecord = New DataSet()
        dsRecord = gWs.GetCheckRecordInfo("{project_code LIKE '" & ProjectCode & "'}", "{project_code LIKE '" & ProjectCode & "'}")
        bmRecord = BindingContext(dsRecord, "guarantee_check_record")
        If bmRecord.Count = 0 Then
            SWDialogBox.MessageBox.Show("$X035")
            'MessageBox.Show("����Ŀû�б����¼���޷����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim obj As Control
            For Each obj In Controls
                obj.Enabled = False
            Next
            btnExit.Enabled = True
            Return
        End If
        Dim dsLocal As DataSet = New DataSet() '�������ݼ�������Ԥ����¼��Ԥ�������ֵ�
        dsLocal.Tables.Add(dsRecord.Tables("guarantee_check_alarm").Copy)
        Dim dsAlarmName As DataSet = gWs.GetAlarmCode("%")
        dsLocal.Merge(dsAlarmName.Tables("TAlarmCode"))
        Dim parCols(1) As DataColumn
        Dim chdCols(1) As DataColumn
        parCols(0) = dsLocal.Tables("TAlarmCode").Columns("alarm_type")
        parCols(1) = dsLocal.Tables("TAlarmCode").Columns("alarm_code")
        chdCols(0) = dsLocal.Tables("guarantee_check_alarm").Columns("alarm_type")
        chdCols(1) = dsLocal.Tables("guarantee_check_alarm").Columns("alarm")
        dsLocal.Relations.Add("Alarm", parCols, chdCols)
        dsLocal.Tables("guarantee_check_alarm").Columns.Add("AlarmName", GetType(String), "Parent(Alarm).alarm_name")
        Dim dsAlarmType As DataSet = gWs.GetAlarmType("%")

        dsAlarm = New DataSet()  'Ԥ����¼�ĸ���
        dsAlarm.Tables.Add(New DataTable("Table"))
        With dsAlarm.Tables(0)
            .Columns.Add("SerialNum", GetType(Integer))
            .Columns.Add("AlarmType", GetType(String))
            .Columns.Add("AlarmTypeName", GetType(String))
            .Columns.Add("Items", GetType(String))
        End With
        Dim dr As DataRow
        Dim drs() As DataRow
        For Each dr In dsLocal.Tables("guarantee_check_alarm").Rows
            drs = dsAlarm.Tables(0).Select("SerialNum=" & dr("serial_num") & " AND AlarmType='" & dr("alarm_type") & "'")
            If drs.Length > 0 Then
                drs(0)("Items") = drs(0)("Items") & "," & dr("AlarmName")
            Else
                Dim odr As DataRow = dsAlarm.Tables(0).NewRow
                With odr
                    .Item("SerialNum") = dr("serial_num")
                    .Item("AlarmType") = dr("alarm_type")
                    .Item("AlarmTypeName") = dsAlarmType.Tables(0).Select("alarm_type='" & dr("alarm_type") & "'")(0)("alarm_type_name")
                    .Item("Items") = dr("AlarmName")
                End With
                dsAlarm.Tables(0).Rows.Add(odr)
            End If
        Next
        If dsAlarm.HasChanges Then
            dsAlarm.AcceptChanges()
        End If
        dgDetail.DataSource = dsAlarm.Tables(0).DefaultView
        AddTableStyleOfDetail()
    End Sub



    Private Sub frmCheckRecordTable_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ProjectCode = MyBase.getProjectCode
            TaskID = MyBase.getTaskID
            CorporationName = MyBase.getCorporationName
            WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName

            GetDataSource()
            If bmRecord.Count = 0 Then Return
            SystemDate = gWs.GetSysTime
            txtContent.DataBindings.Add(New Binding("Text", dsRecord, "guarantee_check_record.explanation"))
            txtOpinion.DataBindings.Add(New Binding("Text", dsRecord, "guarantee_check_record.approve_opinion"))
            dgRecord.DataMember = "guarantee_check_record"
            dgRecord.DataSource = dsRecord
            AddTableStyleOfHistory()
            bm_positionChanged(Nothing, Nothing)
            AddHandler bmRecord.PositionChanged, AddressOf bm_positionChanged
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("��������" & vbCr & ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub bm_positionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bmRecord.Count = 0 Then Return
        CType(dgDetail.DataSource, DataView).RowFilter = "SerialNum=" & CType(bmRecord.Current, DataRowView)("serial_num").ToString
    End Sub

    '��ʽ��
    Private Sub AddTableStyleOfDetail()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "AlarmTypeName"
        col1.HeaderText = "�ȼ�"
        col1.Width = 60
        col1.NullText = ""
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "Items"
        col2.HeaderText = "����"
        col2.Width = 400
        col2.NullText = ""
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2})
        dgDetail.TableStyles.Add(dgts)
    End Sub
    Private Sub AddTableStyleOfHistory()
        dgRecord.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.AllowSorting = False
        dgts.MappingName = "guarantee_check_record"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "serial_num"
        col1.HeaderText = "������"
        col1.Width = 55
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "check_date"
        col2.HeaderText = "�������"
        col2.Width = 80
        col2.Format = "yyyy-MM-dd"
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "finacial_report_month"
        col3.HeaderText = "���ݵĲ��񱨱�����"
        col3.Width = 100
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "contact_person"
        col4.HeaderText = "����������ϵ��"
        col4.NullText = ""
        col4.Width = 100
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "contact_phone"
        col5.HeaderText = "��ϵ�˵绰"
        col5.NullText = ""
        col5.Width = 100
        '���                                                                
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "approve_opinion"
        col7.HeaderText = "������"
        col7.Width = 250
        col7.NullText = String.Empty
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "approve_person"
        col8.HeaderText = "�����Ա"
        col8.Width = 80
        col8.NullText = String.Empty
        'ȷ����                                                         
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "approve_date"
        col9.HeaderText = "�������"
        col9.Width = 80
        col9.Format = "yyyy-MM-dd"
        col9.NullText = String.Empty
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col8, col9, col7})
        dgRecord.TableStyles.Add(dgts)
    End Sub

    Protected Overridable Function SaveOpinion() As Boolean
        bmRecord.Position = dgRecord.CurrentRowIndex
        If dsRecord.HasChanges Then
            CType(bmRecord.Current, DataRowView)("approve_person") = UserName
            CType(bmRecord.Current, DataRowView)("approve_date") = SystemDate.Date
            Dim strResult As String = gWs.UpdateCheckRecordAlarm(dsRecord.GetChanges)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "����������ʧ��", strResult, "")
                Return False
            End If
        End If
        Return True
    End Function

    'Submit
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "�ύ")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        If Not SaveOpinion() Then '����������ʧ�ܣ��򷵻�
            Return
        End If

        Dim strResult As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If strResult = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "�ύʧ��", strResult, "")
        End If
    End Sub

    Private Sub frmCheckRecordTable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MyBase.setEnterKeyPress(sender, e)
    End Sub

    Private Sub btnLookDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookDocument.Click
        Dim oForm As New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, "45", "003", UserName)
        oForm.setIsButtonEnable(True)
        oForm.AllowTransparency = False
        oForm.ShowDialog()
    End Sub

    'Exit
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDetailInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailInfo.Click
        Dim ofrmShowProjectInfo As frmShowProjectInfo = New frmShowProjectInfo(txtProjectCode.Text, txtCorName.Text)
        ofrmShowProjectInfo.ShowDialog()
    End Sub


End Class
