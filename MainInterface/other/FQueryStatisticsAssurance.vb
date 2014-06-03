

Public Class FQueryStatisticsAssurance
    Inherits MainInterface.FQueryBase
    '����ҵ��ͳ��
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboYearFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonthFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonthTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearTo As System.Windows.Forms.ComboBox
    Friend WithEvents mReportStat As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents vchAccountYM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iTimes As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iCorpCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboChartStyle As System.Windows.Forms.ComboBox
    Friend WithEvents chkChart As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboYearFrom = New System.Windows.Forms.ComboBox()
        Me.cboMonthFrom = New System.Windows.Forms.ComboBox()
        Me.cboMonthTo = New System.Windows.Forms.ComboBox()
        Me.cboYearTo = New System.Windows.Forms.ComboBox()
        Me.mReportStat = New System.Windows.Forms.DataGridTableStyle()
        Me.vchAccountYM = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iTimes = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iCorpCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.chkChart = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboChartStyle = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(552, 112)
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(552, 112)
        Me.btnPrint.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(448, 112)
        Me.btnRefresh.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnClear.Location = New System.Drawing.Point(656, 112)
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 152)
        Me.grdTable.Size = New System.Drawing.Size(736, 336)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.mReportStat})
        Me.grdTable.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(656, 112)
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(16, 112)
        Me.chkVisible.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboType, Me.Label3, Me.cboMonthTo, Me.cboYearTo, Me.cboMonthFrom, Me.cboYearFrom, Me.Label2, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(432, 96)
        Me.grpCondition.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��ѡ������ͳ�����䣺"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(256, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "��"
        '
        'cboYearFrom
        '
        Me.cboYearFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearFrom.Location = New System.Drawing.Point(144, 24)
        Me.cboYearFrom.Name = "cboYearFrom"
        Me.cboYearFrom.Size = New System.Drawing.Size(64, 20)
        Me.cboYearFrom.TabIndex = 2
        '
        'cboMonthFrom
        '
        Me.cboMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthFrom.Location = New System.Drawing.Point(208, 24)
        Me.cboMonthFrom.Name = "cboMonthFrom"
        Me.cboMonthFrom.Size = New System.Drawing.Size(40, 20)
        Me.cboMonthFrom.TabIndex = 3
        '
        'cboMonthTo
        '
        Me.cboMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthTo.Location = New System.Drawing.Point(344, 24)
        Me.cboMonthTo.Name = "cboMonthTo"
        Me.cboMonthTo.Size = New System.Drawing.Size(40, 20)
        Me.cboMonthTo.TabIndex = 5
        '
        'cboYearTo
        '
        Me.cboYearTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearTo.Location = New System.Drawing.Point(280, 24)
        Me.cboYearTo.Name = "cboYearTo"
        Me.cboYearTo.Size = New System.Drawing.Size(64, 20)
        Me.cboYearTo.TabIndex = 4
        '
        'mReportStat
        '
        Me.mReportStat.DataGrid = Me.grdTable
        Me.mReportStat.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.vchAccountYM, Me.iSum, Me.iTimes, Me.iCorpCount})
        Me.mReportStat.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.mReportStat.MappingName = "Table"
        Me.mReportStat.PreferredColumnWidth = 100
        '
        'vchAccountYM
        '
        Me.vchAccountYM.Format = ""
        Me.vchAccountYM.FormatInfo = Nothing
        Me.vchAccountYM.HeaderText = "ͳ������"
        Me.vchAccountYM.MappingName = "vchAccountYM"
        Me.vchAccountYM.NullText = ""
        Me.vchAccountYM.Width = 75
        '
        'iSum
        '
        Me.iSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iSum.Format = "n"
        Me.iSum.FormatInfo = Nothing
        Me.iSum.HeaderText = "���(��Ԫ)"
        Me.iSum.MappingName = "iSum"
        Me.iSum.NullText = ""
        Me.iSum.Width = 120
        '
        'iTimes
        '
        Me.iTimes.Format = ""
        Me.iTimes.FormatInfo = Nothing
        Me.iTimes.HeaderText = "����"
        Me.iTimes.MappingName = "iTimes"
        Me.iTimes.NullText = ""
        Me.iTimes.Width = 120
        '
        'iCorpCount
        '
        Me.iCorpCount.Format = ""
        Me.iCorpCount.FormatInfo = Nothing
        Me.iCorpCount.HeaderText = "����"
        Me.iCorpCount.MappingName = "iCorpCount"
        Me.iCorpCount.NullText = ""
        Me.iCorpCount.Width = 120
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "��ѡ��һ��ͳ�����"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Items.AddRange(New Object() {"���뵣��", "��ʽ����", "ͨ������", "ǩԼ����"})
        Me.cboType.Location = New System.Drawing.Point(144, 56)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(104, 20)
        Me.cboType.TabIndex = 7
        '
        'chkChart
        '
        Me.chkChart.Checked = True
        Me.chkChart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChart.Location = New System.Drawing.Point(16, 24)
        Me.chkChart.Name = "chkChart"
        Me.chkChart.TabIndex = 8
        Me.chkChart.Text = "����ͼ��"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboChartStyle, Me.Label4, Me.chkChart})
        Me.GroupBox1.Location = New System.Drawing.Point(448, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 96)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ͼ����ʽ"
        '
        'cboChartStyle
        '
        Me.cboChartStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChartStyle.Items.AddRange(New Object() {"��״ͼ", "��ά����ͼ"})
        Me.cboChartStyle.Location = New System.Drawing.Point(144, 56)
        Me.cboChartStyle.Name = "cboChartStyle"
        Me.cboChartStyle.Size = New System.Drawing.Size(121, 20)
        Me.cboChartStyle.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "��ѡ��һ��ͼ����ʽ��"
        '
        'FQueryStatisticsAssurance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(752, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkVisible, Me.btnExport, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.grpCondition, Me.btnClear, Me.GroupBox1})
        Me.Name = "FQueryStatisticsAssurance"
        Me.Text = "����ҵ��ͳ��"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Shadows ReportTitle As String

    Private Sub FQueryStatisticsAssurance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDate(Now(), -50, 50, cboYearFrom, "Year")
        BindDate(Now(), 1, 12, cboMonthFrom, "Month")
        BindDate(Now(), -50, 50, cboYearTo, "Year")
        BindDate(Now(), 1, 12, cboMonthTo, "Month")     
        cboType.SelectedIndex = 0

        ' Added by Andy on 2/10/2004
        cboChartStyle.SelectedIndex = 0
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False
        ' Ended by Andy

        'grpCondition.Width = 408
        MyBase.ReportFile = Application.StartupPath & "\Reports\rptReportStat.rpt"
        'MyBase.ReportTitle = Trim(cboType.Text) & "ҵ��ͳ��"
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim strDateFrom, strDateTo, strType As String
        Dim i, iTotalTimes, iTotalCorpCount As Int32
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable

        Dim strYearFrom As String = Trim(cboYearFrom.Text)
        Dim strMonthFrom As String = Trim(cboMonthFrom.Text)
        If Len(strMonthFrom) = 1 Then
            strMonthFrom = "0" & strMonthFrom
        End If
        strDateFrom = strYearFrom & strMonthFrom

        Dim strYearTo As String = Trim(cboYearTo.Text)
        Dim strMonthTo As String = Trim(cboMonthTo.Text)
        If Len(strMonthTo) = 1 Then
            strMonthTo = "0" & strMonthTo
        End If
        strDateTo = strYearTo & strMonthTo

        strType = Trim(cboType.Text)

        If strDateFrom > strDateTo Then
            SWDialogBox.MessageBox.Show("$1008", "��ʼ����", "��ֹ����")
            Exit Sub
        End If

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            dtResult = gWs.GetQueryStatisticsAssuranceInfo(strDateFrom, strDateTo, strType, UserName).Tables(0)

            For i = 0 To dtResult.Rows.Count - 1
                iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("iSum"))
                iTotalTimes = iTotalTimes + CInt(dtResult.Rows(i).Item("iTimes"))
                iTotalCorpCount = iTotalCorpCount + CInt(dtResult.Rows(i).Item("iCorpCount"))
            Next
            Dim drRow As DataRow = dtResult.NewRow
            With drRow
                .Item("vchAccountYM") = "�ϼƣ�"
                .Item("iSum") = iTotalSum
                .Item("iTimes") = iTotalTimes
                .Item("iCorpCount") = iTotalCorpCount
            End With
            dtResult.Rows.Add(drRow)

            MyBase.ReportTitle = Trim(cboType.Text) & "ҵ��ͳ��"
            ReportTitle = Trim(cboType.Text) & "ҵ��ͳ��"

            If Not dtResult Is Nothing Then
                Me.grdTable.DataSource = dtResult
                MyBase.DataSource = dtResult
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Exit Sub
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Protected Overrides Sub Print()
        'Dim i As Integer
        'Dim reportViewerForm As FReportViewer = New FReportViewer()
        'Dim _dataSource As Object = grdTable.DataSource

        'Dim ReportFile As String = Application.StartupPath & "\Reports\rptReportStat.rpt"

        'Try
        '    reportViewerForm.ShowDialog(ReportFile, _dataSource, ReportTitle)
        'Finally
        '    If Not reportViewerForm Is Nothing Then
        '        reportViewerForm.Dispose()
        '    End If
        'End Try
    End Sub

    Function BindDate(ByVal CurrentDate As Date, ByVal iBegin As Integer, ByVal iEnd As Integer, ByVal ControlName As ComboBox, ByVal sType As String)
        Dim i As Integer

        Select Case sType
            Case "Month"
                For i = iBegin To iEnd
                    ControlName.Items.Add(i)
                    If i = CurrentDate.Month Then
                        ControlName.SelectedIndex = i - 1
                    End If
                Next
            Case "Year"
                Dim j As Integer = 0
                For i = iBegin To iEnd
                    ControlName.Items.Add(i + CurrentDate.Year)
                    If i + CurrentDate.Year = CurrentDate.Year Then
                        ControlName.SelectedIndex = j
                    End If
                    j += 1
                Next
        End Select
    End Function

    ' Modified by Andy on 2/10/2004
    Protected Overrides Sub Export()
        'Dim report As ReportObject = New ReportObject()

        'If _dataSource Is Nothing Then
        '	_dataSource = grdTable.DataSource
        'End If

        'report.DataSource = _dataSource
        'report.ReportFile = _reportFile
        'report.ReportTitle = _reportTitle

        'report.Export()
        'report = Nothing

        Dim strFlag As String
        Select Case Trim(cboChartStyle.Text)
            Case "��״ͼ"
                strFlag = "0"
            Case "����ͼ"
                strFlag = "1"
            Case "��ͼ"
                strFlag = "2"
            Case "��ά����ͼ"
                strFlag = "3"
            Case "��ά����ͼ"
                strFlag = "4"
            Case "��ά��ͼ"
                strFlag = "5"
            Case Else
                strFlag = "0"
        End Select

        If Me.chkChart.Checked Then
            Dim arrChart1 As New ArrayList()
            Dim arrChart2 As New ArrayList()
            'Dim arrChart3 As New ArrayList()
            Dim arrChartList As New ArrayList()

            arrChart1.Add(strFlag)
            arrChart1.Add("ͳ������")
            arrChart1.Add("���(��Ԫ)")

            arrChart2.Add(strFlag)
            arrChart2.Add("ͳ������")
            arrChart2.Add("����")

            'arrChart3.Add(strFlag)
            'arrChart3.Add("ͳ������")
            'arrChart3.Add("����")

            arrChartList.Add(arrChart1)
            arrChartList.Add(arrChart2)
            'arrChartList.Add(arrChart3)

            ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle, arrChartList)
        Else
            ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle)
        End If
    End Sub
    ' Ended by Andy

    Private Sub chkChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChart.CheckedChanged
        ' IIf(chkChart.Checked, cboChartStyle.Enabled = True, cboChartStyle.Enabled = False)
        If chkChart.Checked Then
            cboChartStyle.Enabled = True
        Else
            cboChartStyle.Enabled = False
        End If
    End Sub
End Class
