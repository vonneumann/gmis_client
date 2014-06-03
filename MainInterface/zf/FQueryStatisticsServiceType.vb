Public Class FQueryStatisticsServiceType
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
	Friend WithEvents lblDateFrom As System.Windows.Forms.Label
	Friend WithEvents lblDateTo As System.Windows.Forms.Label
	Friend WithEvents btnPrint As System.Windows.Forms.Button
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
	Friend WithEvents grdTable As System.Windows.Forms.DataGrid
	Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryStatisticsServiceType))
		Me.lblDateFrom = New System.Windows.Forms.Label()
		Me.lblDateTo = New System.Windows.Forms.Label()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.btnRefresh = New System.Windows.Forms.Button()
		Me.grdTable = New System.Windows.Forms.DataGrid()
		Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
		Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
		CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblDateFrom
		'
		Me.lblDateFrom.Location = New System.Drawing.Point(8, 14)
		Me.lblDateFrom.Name = "lblDateFrom"
		Me.lblDateFrom.Size = New System.Drawing.Size(72, 16)
		Me.lblDateFrom.TabIndex = 0
		Me.lblDateFrom.Text = "��ʼ����(&F)"
		'
		'lblDateTo
		'
		Me.lblDateTo.Location = New System.Drawing.Point(184, 16)
		Me.lblDateTo.Name = "lblDateTo"
		Me.lblDateTo.Size = New System.Drawing.Size(40, 16)
		Me.lblDateTo.TabIndex = 2
		Me.lblDateTo.Text = "��(&T)"
		'
		'btnPrint
		'
		Me.btnPrint.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
		Me.btnPrint.Location = New System.Drawing.Point(416, 8)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(80, 24)
		Me.btnPrint.TabIndex = 5
		Me.btnPrint.Text = "�� ӡ(&P)"
		'
		'btnRefresh
		'
		Me.btnRefresh.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
		Me.btnRefresh.Location = New System.Drawing.Point(328, 8)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(80, 24)
		Me.btnRefresh.TabIndex = 4
		Me.btnRefresh.Text = "�� ѯ(&S)"
		'
		'grdTable
		'
		Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right)
		Me.grdTable.CaptionVisible = False
		Me.grdTable.DataMember = ""
		Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.grdTable.Location = New System.Drawing.Point(8, 48)
		Me.grdTable.Name = "grdTable"
		Me.grdTable.ReadOnly = True
		Me.grdTable.Size = New System.Drawing.Size(576, 320)
		Me.grdTable.TabIndex = 7
		Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
		'
		'DataGridTableStyle1
		'
		Me.DataGridTableStyle1.DataGrid = Me.grdTable
		Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
		Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.DataGridTableStyle1.MappingName = "Table"
		Me.DataGridTableStyle1.ReadOnly = True
		'
		'DataGridTextBoxColumn1
		'
		Me.DataGridTextBoxColumn1.Format = ""
		Me.DataGridTextBoxColumn1.FormatInfo = Nothing
		Me.DataGridTextBoxColumn1.HeaderText = "ҵ��Ʒ��"
		Me.DataGridTextBoxColumn1.MappingName = "ServiceType"
		Me.DataGridTextBoxColumn1.Width = 150
		'
		'DataGridTextBoxColumn2
		'
		Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn2.Format = "c"
		Me.DataGridTextBoxColumn2.FormatInfo = Nothing
		Me.DataGridTextBoxColumn2.HeaderText = "�� ��"
		Me.DataGridTextBoxColumn2.MappingName = "ApplySum"
		Me.DataGridTextBoxColumn2.Width = 90
		'
		'DataGridTextBoxColumn3
		'
		Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn3.Format = ""
		Me.DataGridTextBoxColumn3.FormatInfo = Nothing
		Me.DataGridTextBoxColumn3.HeaderText = "�� ��"
		Me.DataGridTextBoxColumn3.MappingName = "ApplyCount"
		Me.DataGridTextBoxColumn3.Width = 60
		'
		'btnExit
		'
		Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
		Me.btnExit.Location = New System.Drawing.Point(504, 8)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(80, 24)
		Me.btnExit.TabIndex = 6
		Me.btnExit.Text = "�� ��(&X)"
		'
		'dtpDateFrom
		'
		Me.dtpDateFrom.Location = New System.Drawing.Point(80, 8)
		Me.dtpDateFrom.Name = "dtpDateFrom"
		Me.dtpDateFrom.Size = New System.Drawing.Size(96, 21)
		Me.dtpDateFrom.TabIndex = 1
		'
		'dtpDateTo
		'
		Me.dtpDateTo.Location = New System.Drawing.Point(224, 8)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(96, 21)
		Me.dtpDateTo.TabIndex = 3
		'
		'FQueryStatisticsServiceType
		'
		Me.AcceptButton = Me.btnRefresh
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(592, 373)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpDateTo, Me.dtpDateFrom, Me.btnExit, Me.grdTable, Me.btnPrint, Me.btnRefresh, Me.lblDateTo, Me.lblDateFrom})
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Name = "FQueryStatisticsServiceType"
		Me.Text = "ҵ��Ʒ��ͳ��"
		CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim reportViewerForm As FReportViewer = New FReportViewer()

		Try
			Dim dataSource As Object

			Me.Cursor = Cursors.WaitCursor

			If Not grdTable.DataSource Is Nothing Then
				dataSource = CType(grdTable.DataSource, DataSet).Tables(0)
				CType(dataSource, DataTable).TableName = "TQueryStatisticsServiceType"
				dataSource = grdTable.DataSource
			End If

			reportViewerForm.ShowDialog(Application.StartupPath + "\Reports\QueryStatisticsServiceType.rpt", dataSource, "ҵ��Ʒ��ͳ��", Me)
		Finally
			Me.Cursor = Cursors.Default

			If Not reportViewerForm Is Nothing Then
				reportViewerForm.Dispose()
			End If
		End Try
	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		Me.Refresh()
	End Sub

	Public Overloads Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim rsResult As DataSet = gWs.GetQueryStatisticsServiceTypeInfo(dtpDateFrom.Value, dtpDateTo.Value)

			grdTable.SetDataBinding(rsResult, "Table")
			Me.Text = "ҵ��Ʒ��ͳ��(" + rsResult.Tables("Table").Rows.Count.ToString + ")"
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub FQueryStatisticsServiceType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		If e.KeyCode = Keys.F5 Then
			Me.Refresh()
		End If
	End Sub
End Class
