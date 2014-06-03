

Public Class FQueryStatisticsCompensation
    Inherits MainInterface.FQueryBase

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
    Friend WithEvents cboStartYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboEndYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboEndMonth As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboChartStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkChart As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStartYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboEndYear = New System.Windows.Forms.ComboBox()
        Me.cboEndMonth = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboChartStyle = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkChart = New System.Windows.Forms.CheckBox()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(408, 128)
        Me.btnRefresh.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 128)
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 168)
        Me.grdTable.Size = New System.Drawing.Size(696, 320)
        Me.grdTable.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboEndMonth, Me.cboEndYear, Me.Label2, Me.cboStartYear, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(392, 96)
        Me.grpCondition.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(512, 128)
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 64)
        Me.btnPrint.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 128)
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 128)
        Me.chkVisible.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��ʼ���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboStartYear
        '
        Me.cboStartYear.Location = New System.Drawing.Point(64, 24)
        Me.cboStartYear.MaxLength = 4
        Me.cboStartYear.Name = "cboStartYear"
        Me.cboStartYear.Size = New System.Drawing.Size(72, 20)
        Me.cboStartYear.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "��ֹ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEndYear
        '
        Me.cboEndYear.Location = New System.Drawing.Point(208, 24)
        Me.cboEndYear.MaxLength = 4
        Me.cboEndYear.Name = "cboEndYear"
        Me.cboEndYear.Size = New System.Drawing.Size(72, 20)
        Me.cboEndYear.TabIndex = 3
        '
        'cboEndMonth
        '
        Me.cboEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEndMonth.Location = New System.Drawing.Point(280, 24)
        Me.cboEndMonth.Name = "cboEndMonth"
        Me.cboEndMonth.Size = New System.Drawing.Size(48, 20)
        Me.cboEndMonth.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboChartStyle, Me.Label4, Me.chkChart})
        Me.GroupBox1.Location = New System.Drawing.Point(408, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 96)
        Me.GroupBox1.TabIndex = 109
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
        'chkChart
        '
        Me.chkChart.Checked = True
        Me.chkChart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChart.Location = New System.Drawing.Point(16, 24)
        Me.chkChart.Name = "chkChart"
        Me.chkChart.TabIndex = 8
        Me.chkChart.Text = "����ͼ��"
        '
        'FQueryStatisticsCompensation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition, Me.GroupBox1})
        Me.Name = "FQueryStatisticsCompensation"
        Me.Text = "�������ͳ�Ʊ�"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryStatisticsCompensation_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportFile = Application.StartupPath & "\Reports\QueryStatisticsCompensation.rpt"
        ReportTitle = "�������ͳ�Ʊ�"

        Dim SystemDate As Date = gWs.GetSysTime
        Dim i As Integer
        For i = 1990 To 2050
            cboStartYear.Items.Add(i)
            cboEndYear.Items.Add(i)
        Next
        For i = 1 To 12
            cboEndMonth.Items.Add(i)
        Next
        cboStartYear.Text = SystemDate.Year : cboEndYear.Text = SystemDate.Year
        cboEndMonth.Text = SystemDate.Month
        AddTableStyle()
        cboChartStyle.SelectedIndex = 0
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False

        Me.RemoveClearControl() '���������ؼ��ĳ�ʼֵ
    End Sub
    Protected Overloads Sub GetCondition(ByRef StartYear As String, ByRef EndYearMonth As String)
        StartYear = cboStartYear.Text
        EndYearMonth = cboEndYear.Text & cboEndMonth.Text
    End Sub
    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        If cboStartYear.Text.Trim = "" Then
            SWDialogBox.MessageBox.Show("$1001", "��ʼ���")
            'MessageBox.Show("��ʼ��ݲ���Ϊ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboStartYear.Focus()
            Return
        ElseIf cboEndYear.Text.Trim = "" Then
            SWDialogBox.MessageBox.Show("$1001", "��ֹ���")
            'MessageBox.Show("��ֹ��ݲ���Ϊ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboEndYear.Focus()
            Return
        Else
            Try
                If CInt(cboStartYear.Text) > CInt(cboEndYear.Text) Then
                    SWDialogBox.MessageBox.Show("$1008", "��ʼ���", "�������")
                    'MessageBox.Show("��ʼ���ӦС����ڽ�ֹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            Catch
                Return
            End Try
        End If
        Dim StartYear, EndYearMonth As String
        GetCondition(StartYear, EndYearMonth)
        Dim ds As DataSet = gWs.FQueryStatisticsCompensation(StartYear, EndYearMonth, UserName)
        ds.Tables(0).TableName = "TQueryStatisticsCompensation"
        grdTable.DataMember = ds.Tables(0).TableName
        grdTable.DataSource = ds
        MyBase.DataSource = ds
    End Sub

    ' Modified by Andy on 2/10/2004
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

        If chkChart.Checked Then
            Dim arrChart1 As New ArrayList()
            Dim arrChart2 As New ArrayList()
            Dim arrChart3 As New ArrayList()
            Dim arrChart4 As New ArrayList()
            Dim arrChartList As New ArrayList()

            arrChart1.Add(strFlag)
            arrChart1.Add("ͳ������")
            arrChart1.Add("��������")

            arrChart2.Add(strFlag)
            arrChart2.Add("ͳ������")
            arrChart2.Add("�������(Ԫ)")

            arrChart3.Add(strFlag)
            arrChart3.Add("ͳ������")
            arrChart3.Add("׷�ؽ��(Ԫ)")

            arrChart4.Add(strFlag)
            arrChart4.Add("ͳ������")
            arrChart4.Add("�������(Ԫ)")

            arrChartList.Add(arrChart1)
            arrChartList.Add(arrChart2)
            arrChartList.Add(arrChart3)
            arrChartList.Add(arrChart4)

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

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TQueryStatisticsCompensation"
        dgts.AllowSorting = False
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "YearMonth"
        col1.HeaderText = "ͳ������"
        col1.Width = 50
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "RefundCount"
        col2.HeaderText = "��������"
        col2.Width = 60
        col2.NullText = ""
        col2.Alignment = HorizontalAlignment.Center
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "RefundSum"
        col3.HeaderText = "�������(Ԫ)"
        col3.Width = 100
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "Returned"
        col4.HeaderText = "׷�ؽ��(Ԫ)"
        col4.Width = 100
        col4.NullText = ""
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "Balance"
        col5.HeaderText = "�������(Ԫ)"
        col5.Width = 100
        col5.NullText = ""
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5})
        grdTable.TableStyles.Add(dgts)
    End Sub
End Class
