Imports CrystalDecisions
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class ReportObject
	Public Enum ExportOptions
		NoFormat
		CrystalReport
		RichText
		WordForWindows
		Excel
		PortableDocFormat
		HTML32
		HTML40
	End Enum

	Private _dataSource As Object
	Private _reportFile As String
	Private _reportTitle As String

	Public Property DataSource() As Object
		Get
			Return _dataSource
		End Get
		Set(ByVal Value As Object)
			_dataSource = Value
		End Set
	End Property

	Public Property ReportFile() As String
		Get
			Return _reportFile
		End Get
		Set(ByVal Value As String)
			_reportFile = Value
		End Set
	End Property

	Public Property ReportTitle() As String
		Get
			Return _reportTitle
		End Get
		Set(ByVal Value As String)
			_reportTitle = Value
		End Set
	End Property

	Public Sub Export()
		Dim dlgExport As SaveFileDialog = New SaveFileDialog()

		Dim exportFormat As ReportObject.ExportOptions

		dlgExport.Filter = "ˮ�������ļ�|*.rpt|RichText �ļ�|*.rtf|Word �ļ�|*.doc|Excel �ļ�|*.xls|PDF �ļ�|*.pdf|HTML32 �ļ�|*.htm,*.html|HTML40 �ļ�|*.htm,*.html"
		dlgExport.Title = "�����ļ�"
		dlgExport.FilterIndex = 4

		If dlgExport.ShowDialog() = DialogResult.OK And dlgExport.FileName.Trim() <> "" Then
			exportFormat = CType(dlgExport.FilterIndex, ReportObject.ExportOptions)

			Export(dlgExport.FileName, exportFormat)
		End If
	End Sub

	Public Sub Export(ByVal exportFile As String, ByVal exportFormat As ExportOptions)
		Try
			Dim reportDocument As CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
			Dim exportOptions As CrystalDecisions.Shared.ExportOptions = New CrystalDecisions.Shared.ExportOptions()

			reportDocument.Load(_reportFile)
			reportDocument.SetDataSource(_dataSource)
			If Not ReportTitle Is Nothing Then
				reportDocument.SummaryInfo.ReportTitle = _reportTitle
			End If

			exportOptions = reportDocument.ExportOptions
			exportOptions.ExportFormatType = exportFormat
			exportOptions.ExportDestinationType = ExportDestinationType.DiskFile
			exportOptions.DestinationOptions = New DiskFileDestinationOptions()
			CType(exportOptions.DestinationOptions, DiskFileDestinationOptions).DiskFileName = exportFile

			reportDocument.Export()
			reportDocument.Close()
			reportDocument.Dispose()
		Catch ex As CrystalDecisions.CrystalReports.Engine.LoadSaveReportException
			MessageBox.Show("�������ܼ���ָ���ı���" + _reportFile + "������ȷ��ָ���ı����ļ��Ƿ���ڣ�Ȼ��������ִ�иò�����", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		Catch ex As CrystalDecisions.CrystalReports.Engine.FormattingException
			MessageBox.Show("�������ܵ�����ָ���ĸ�ʽ��������ָ��һ��ϵͳ֧�ֵĵ�����ʽ��", "������")
			Return
		End Try
	End Sub
End Class
