Public Class FReportViewer
    Inherits System.Windows.Forms.Form

	Private _reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument

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
	Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FReportViewer))
		Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.SuspendLayout()
		'
		'rptViewer
		'
		Me.rptViewer.ActiveViewIndex = -1
		Me.rptViewer.DisplayGroupTree = False
		Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.rptViewer.Name = "rptViewer"
		Me.rptViewer.ReportSource = Nothing
		Me.rptViewer.Size = New System.Drawing.Size(592, 533)
		Me.rptViewer.TabIndex = 0
		'
		'FReportViewer
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(592, 533)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rptViewer})
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FReportViewer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Property ReportSource() As Object
		Get
			Return Me.rptViewer.ReportSource
		End Get

		Set(ByVal Value As Object)
			rptViewer.ReportSource = Value
		End Set
	End Property

	Public Overloads Sub ShowDialog(ByVal fileName As String, ByVal dataSource As Object, ByVal reportTitle As String, Optional ByRef owner As IWin32Window = Nothing)
		Try
			_reportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
			_reportDocument.Load(fileName)
			_reportDocument.SetDataSource(dataSource)
			If Not reportTitle Is Nothing Then
				_reportDocument.SummaryInfo.ReportTitle = reportTitle
			End If

			_reportDocument.ReportOptions.EnableSaveDataWithReport = False
			_reportDocument.ReportOptions.EnableUseDummyData = False

			rptViewer.ReportSource = _reportDocument

			If Me.Text = "" Then
				Me.Text = "����Ԥ��" + IIf(reportTitle Is Nothing, "", " - " + reportTitle)
			End If
		Catch ex As CrystalDecisions.CrystalReports.Engine.LoadSaveReportException
			MessageBox.Show("�������ܼ���ָ���ı���" + fileName + "������ȷ��ָ���ı����ļ��Ƿ���ڣ�Ȼ��������ִ�иò�����", "�����ӡ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End Try

		If owner Is Nothing Then
			Me.ShowDialog()
		Else
			Me.ShowDialog(owner)
		End If
	End Sub

	Private Sub FReportViewer_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
		If Not _reportDocument Is Nothing Then
			_reportDocument.Close()
			_reportDocument.Dispose()
		End If
	End Sub
End Class
