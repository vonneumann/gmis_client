Public Class FQueryStatisticsTradeRegion
    Inherits MainInterface.FQueryBase    
    '����ҵ�����ͳ��
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
    Friend WithEvents cboMonthTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonthFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents mStatType As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents vchRange As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iTimes As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents vchSubRange As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iCorpCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboRange As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboChartStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkChart As System.Windows.Forms.CheckBox
    Friend WithEvents iNewCorp As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryStatisticsTradeRegion))
        Me.cboMonthTo = New System.Windows.Forms.ComboBox()
        Me.cboYearTo = New System.Windows.Forms.ComboBox()
        Me.cboMonthFrom = New System.Windows.Forms.ComboBox()
        Me.cboYearFrom = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mStatType = New System.Windows.Forms.DataGridTableStyle()
        Me.vchRange = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.vchSubRange = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iTimes = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iCorpCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iNewCorp = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cboRange = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboChartStyle = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkChart = New System.Windows.Forms.CheckBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnClear.Location = New System.Drawing.Point(192, 144)
        Me.btnClear.TabStop = False
        Me.btnClear.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboRange, Me.Label4, Me.Label3, Me.cboType})
        Me.grpCondition.Size = New System.Drawing.Size(392, 120)
        Me.grpCondition.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(512, 144)
        Me.btnExport.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 184)
        Me.grdTable.Size = New System.Drawing.Size(696, 304)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.mStatType})
        Me.grdTable.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 144)
        Me.btnExit.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(408, 144)
        Me.btnRefresh.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 144)
        Me.chkVisible.Visible = True
        '
        'cboMonthTo
        '
        Me.cboMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthTo.Location = New System.Drawing.Point(316, 32)
        Me.cboMonthTo.Name = "cboMonthTo"
        Me.cboMonthTo.Size = New System.Drawing.Size(40, 20)
        Me.cboMonthTo.TabIndex = 113
        '
        'cboYearTo
        '
        Me.cboYearTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearTo.Location = New System.Drawing.Point(252, 32)
        Me.cboYearTo.Name = "cboYearTo"
        Me.cboYearTo.Size = New System.Drawing.Size(64, 20)
        Me.cboYearTo.TabIndex = 112
        '
        'cboMonthFrom
        '
        Me.cboMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthFrom.Location = New System.Drawing.Point(180, 32)
        Me.cboMonthFrom.Name = "cboMonthFrom"
        Me.cboMonthFrom.Size = New System.Drawing.Size(40, 20)
        Me.cboMonthFrom.TabIndex = 111
        '
        'cboYearFrom
        '
        Me.cboYearFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearFrom.Location = New System.Drawing.Point(116, 32)
        Me.cboYearFrom.Name = "cboYearFrom"
        Me.cboYearFrom.Size = New System.Drawing.Size(64, 20)
        Me.cboYearFrom.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 14)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "��"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "ͳ���������䣺"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ͳ�����ݣ�"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Items.AddRange(New Object() {"��ѯ", "����", "����ͨ��", "����ͨ��", "ǩԼ", "��;", "�б�", "�ڱ�", "����", "����", "��ֹ"})
        Me.cboType.Location = New System.Drawing.Point(108, 88)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(128, 20)
        Me.cboType.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "���鷽ʽ��"
        '
        'mStatType
        '
        Me.mStatType.DataGrid = Me.grdTable
        Me.mStatType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.vchRange, Me.vchSubRange, Me.iSum, Me.iTimes, Me.iCorpCount, Me.iNewCorp})
        Me.mStatType.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.mStatType.MappingName = "Table"
        Me.mStatType.PreferredColumnWidth = 100
        '
        'vchRange
        '
        Me.vchRange.Format = ""
        Me.vchRange.FormatInfo = Nothing
        Me.vchRange.HeaderText = "�������"
        Me.vchRange.MappingName = "vchRange"
        Me.vchRange.NullText = ""
        Me.vchRange.Width = 160
        '
        'vchSubRange
        '
        Me.vchSubRange.Format = ""
        Me.vchSubRange.FormatInfo = Nothing
        Me.vchSubRange.HeaderText = "֧��"
        Me.vchSubRange.MappingName = "vchSubRange"
        Me.vchSubRange.NullText = ""
        Me.vchSubRange.Width = 120
        '
        'iSum
        '
        Me.iSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iSum.Format = ""
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
        Me.iTimes.Width = 90
        '
        'iCorpCount
        '
        Me.iCorpCount.Format = ""
        Me.iCorpCount.FormatInfo = Nothing
        Me.iCorpCount.HeaderText = "����"
        Me.iCorpCount.MappingName = "iCorpCount"
        Me.iCorpCount.NullText = ""
        Me.iCorpCount.Width = 90
        '
        'iNewCorp
        '
        Me.iNewCorp.Format = ""
        Me.iNewCorp.FormatInfo = Nothing
        Me.iNewCorp.HeaderText = "������ҵ����"
        Me.iNewCorp.MappingName = "iNewCorp"
        Me.iNewCorp.Width = 90
        '
        'cboRange
        '
        Me.cboRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRange.Items.AddRange(New Object() {"��Ŀ��", "����ֲ�", "ҵ��Ʒ��", "������", "������", "������ҵ", "�Ƽ�����", "�Ƿ��״δ���", "����", "֧��"})
        Me.cboRange.Location = New System.Drawing.Point(108, 56)
        Me.cboRange.Name = "cboRange"
        Me.cboRange.Size = New System.Drawing.Size(128, 20)
        Me.cboRange.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboChartStyle, Me.Label5, Me.chkChart})
        Me.GroupBox1.Location = New System.Drawing.Point(408, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 120)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ͼ����ʽ"
        '
        'cboChartStyle
        '
        Me.cboChartStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChartStyle.Items.AddRange(New Object() {"��ͼ", "��ά��ͼ"})
        Me.cboChartStyle.Location = New System.Drawing.Point(144, 56)
        Me.cboChartStyle.Name = "cboChartStyle"
        Me.cboChartStyle.Size = New System.Drawing.Size(121, 20)
        Me.cboChartStyle.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "��ѡ��һ��ͼ����ʽ��"
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
        'FQueryStatisticsTradeRegion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboMonthFrom, Me.cboMonthTo, Me.cboYearTo, Me.cboYearFrom, Me.Label2, Me.Label1, Me.grpCondition, Me.btnExport, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.btnClear, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FQueryStatisticsTradeRegion"
        Me.Text = "����ҵ�����ͳ��"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Shadows ReportTitle, ReportFile As String

    Private Sub FQueryStatisticsTradeRegion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BindDate(Now(), -50, 50, cboYearFrom, "Year")
        BindDate(Now(), 1, 12, cboMonthFrom, "Month")
        BindDate(Now(), -50, 50, cboYearTo, "Year")
        BindDate(Now(), 1, 12, cboMonthTo, "Month")
        ' Added by Andy on 2/11/2004
        cboChartStyle.SelectedIndex = 0
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False
        ' Ended by Andy
        cboType.SelectedIndex = 0
        cboRange.SelectedIndex = 1
        MyBase.ReportFile = Application.StartupPath & "\Reports\rptTypeStat.rpt"
        Me.RemoveClearControl() '���������ؼ��ĳ�ʼֵ
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)

        If Me.cboRange.Text = "" Or Me.cboType.Text = "" Then
            MessageBox.Show("���鷽ʽ��ͳ�����ݲ���Ϊ��!", "��ʾ")
            Exit Sub
        End If

        Dim strDateFrom, strDateTo, strRange, strType As String
        Dim i, iTotalTimes, iTotalCorpCount, iTotalNewCorp As Int32
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable

        Select Case Trim(cboType.Text)
            Case "��ѯ"
                strType = "Consult"
            Case "����"
                strType = "Apply"
            Case "����ͨ��"
                strType = "FirstReview"
            Case "����ͨ��"
                strType = "SecReview"
            Case "ǩԼ"
                strType = "Vise"
            Case "��;"
                strType = "OnRecord"
            Case "�б�"
                strType = "Loan"
            Case "�ڱ�"
                strType = "Guaranting"
            Case "����"
                strType = "Refund"
            Case "����"
                strType = "RemoveVouch"
            Case "��ֹ"
                strType = "Terminate"
        End Select

        Select Case Trim(cboRange.Text)
            Case "ҵ��Ʒ��"
                strRange = "ServiceType"
            Case "������"
                strRange = "Area"
            Case "����"
                strRange = "Bank"
            Case "֧��"
                strRange = "BranchBank"
            Case "������ҵ"
                strRange = "Industry"
            Case "������"
                strRange = "Property"
            Case "�Ƽ�����"
                strRange = "Technology"
            Case "��Ŀ��"
                strRange = "Team"
            Case "�Ƿ��״δ���"
                strRange = "is1stLoan"
            Case "����ֲ�"
                strRange = "AcceptBranch"
        End Select

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

        If strDateFrom > strDateTo Then
            SWDialogBox.MessageBox.Show("$1008", "��ʼ����", "��ֹ����")
            Exit Sub
        End If

        If Trim(cboRange.Text) = "��Ŀ��" And (Trim(cboType.Text) = "��ѯ" Or Trim(cboType.Text) = "����" Or Trim(cboType.Text) = "����ͨ��") Then
            MsgBox("����" & Trim(cboType.Text) & "ҵ����Ŀ���޷�ͳ�ƣ�������ѡ��", MsgBoxStyle.OKOnly, "����" & Trim(cboType.Text) & "ҵ��")
            Exit Sub
        End If

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'dtResult = gWs.PStatisticsByType(strDateFrom, strDateTo, strRange, strType).Tables(0)
            Dim strProcName As String = "Usp_GetSumTAB" & strType
            '�����ݿ�������Ĵ洢���̵����ƺͷ��鷽ʽ�й�
            '����,���������ͨ�����鷽ʽ��ȡ��Ӧ�Ĵ洢����
            dtResult = gWs.PStatisticsByTypeEx(strProcName, strDateFrom, strDateTo, strRange, UserName).Tables(0)
            GetTitle()
            If Trim(cboRange.Text) = "֧��" Then
                grdTable.TableStyles(0).GridColumnStyles("vchRange").HeaderText = "����"
                ReportFile = Application.StartupPath & "\Reports\rptTypeStatForBank.rpt"
                MyBase.ReportFile = Application.StartupPath & "\Reports\rptTypeStatForBank.rpt"
            Else
                grdTable.TableStyles(0).GridColumnStyles("vchRange").HeaderText = cboRange.Text
                ReportFile = Application.StartupPath & "\Reports\rptTypeStat.rpt"
                MyBase.ReportFile = Application.StartupPath & "\Reports\rptTypeStat.rpt"
            End If

            For i = 0 To dtResult.Rows.Count - 1
                If Trim(cboRange.Text) <> "�Ƽ�����" And Trim(cboRange.Text) <> "�Ƿ��״δ���" Then
                    iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("iSum"))
                    iTotalTimes = iTotalTimes + CInt(dtResult.Rows(i).Item("iTimes"))
                End If
                iTotalCorpCount = iTotalCorpCount + CInt(dtResult.Rows(i).Item("iCorpCount"))
                If Me.cboYearFrom.Enabled Then
                    iTotalNewCorp = iTotalNewCorp + CInt(dtResult.Rows(i).Item("iNewCorp"))
                End If
            Next
            Dim drRow As DataRow = dtResult.NewRow
            With drRow
                .Item("vchRange") = "�ϼƣ�"
                If Trim(cboRange.Text) <> "�Ƽ�����" And Trim(cboRange.Text) <> "�Ƿ��״δ���" Then
                    .Item("iSum") = iTotalSum
                    .Item("iTimes") = iTotalTimes
                End If
                .Item("iCorpCount") = iTotalCorpCount
                If Me.cboYearFrom.Enabled Then
                    .Item("iNewCorp") = iTotalNewCorp
                End If
            End With
            dtResult.Rows.Add(drRow)

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

    Sub GetTitle()
        Dim strYearFrom As String = Trim(cboYearFrom.Text)
        Dim strMonthFrom As String = Trim(cboMonthFrom.Text)
        If Len(strMonthFrom) = 1 Then
            strMonthFrom = "0" & strMonthFrom
        End If
        Dim strDateFrom As String = strYearFrom & strMonthFrom

        Dim strYearTo As String = Trim(cboYearTo.Text)
        Dim strMonthTo As String = Trim(cboMonthTo.Text)
        If Len(strMonthTo) = 1 Then
            strMonthTo = "0" & strMonthTo
        End If
        Dim strDateTo As String = strYearTo & strMonthTo

        ReportTitle = strDateFrom & " �� " & strDateTo & " ����" & Trim(cboType.Text) & "ҵ��" & Trim(cboRange.Text) & "ͳ��"
        MyBase.ReportTitle = strDateFrom & " �� " & strDateTo & " ����" & Trim(cboType.Text) & "ҵ��" & Trim(cboRange.Text) & "ͳ��"

    End Sub

    ' Modified by Andy on 2/11/2004
    Protected Overrides Sub Export()

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
            Dim arrChart3 As New ArrayList()
            Dim arrChartList As New ArrayList()

            arrChart1.Add(strFlag)
            arrChart1.Add(grdTable.TableStyles(0).GridColumnStyles("vchRange").HeaderText)
            arrChart1.Add("���(��Ԫ)")

            arrChart2.Add(strFlag)
            arrChart2.Add(grdTable.TableStyles(0).GridColumnStyles("vchRange").HeaderText)
            arrChart2.Add("����")

            arrChart3.Add(strFlag)
            arrChart3.Add(grdTable.TableStyles(0).GridColumnStyles("vchRange").HeaderText)
            arrChart3.Add("����")

            arrChartList.Add(arrChart1)
            arrChartList.Add(arrChart2)
            arrChartList.Add(arrChart3)

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

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If Trim(cboType.Text) = "��;" Or Trim(cboType.Text) = "�ڱ�" Then
            cboYearFrom.Enabled = False
            cboYearTo.Enabled = False
            cboMonthFrom.Enabled = False
            cboMonthTo.Enabled = False
        Else
            cboYearFrom.Enabled = True
            cboYearTo.Enabled = True
            cboMonthFrom.Enabled = True
            cboMonthTo.Enabled = True
        End If
    End Sub

End Class
