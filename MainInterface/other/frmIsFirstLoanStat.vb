Public Class frmIsFirstLoanStat
    Inherits System.Windows.Forms.Form
    '�״δ�����ҵ���ͳ��
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents btnToExcel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents grdTable As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents IsFirstLoan As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iCorpCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmIsFirstLoanStat))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.btnToExcel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.IsFirstLoan = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iCorpCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblToDate, Me.dtpToDate, Me.dtpFromDate, Me.chkDate})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 96)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "��ѯ����"
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(240, 32)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(17, 14)
        Me.lblToDate.TabIndex = 26
        Me.lblToDate.Text = "��"
        '
        'dtpToDate
        '
        Me.dtpToDate.Enabled = False
        Me.dtpToDate.Location = New System.Drawing.Point(264, 24)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpToDate.TabIndex = 27
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Enabled = False
        Me.dtpFromDate.Location = New System.Drawing.Point(112, 24)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpFromDate.TabIndex = 25
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(16, 24)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.TabIndex = 28
        Me.chkDate.Text = "��ѯʱ��Σ�"
        '
        'btnToExcel
        '
        Me.btnToExcel.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnToExcel.Image = CType(resources.GetObject("btnToExcel.Image"), System.Drawing.Bitmap)
        Me.btnToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToExcel.ImageIndex = 1
        Me.btnToExcel.ImageList = Me.ImageList1
        Me.btnToExcel.Location = New System.Drawing.Point(568, 128)
        Me.btnToExcel.Name = "btnToExcel"
        Me.btnToExcel.Size = New System.Drawing.Size(77, 24)
        Me.btnToExcel.TabIndex = 28
        Me.btnToExcel.Text = "�� ��(&E)"
        Me.btnToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 2
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(656, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "�� ��(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 0
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(480, 128)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 24)
        Me.btnRefresh.TabIndex = 26
        Me.btnRefresh.Text = "�� ѯ(&S)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdTable
        '
        Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 168)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.ReadOnly = True
        Me.grdTable.Size = New System.Drawing.Size(736, 320)
        Me.grdTable.TabIndex = 29
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.IsFirstLoan, Me.iCorpCount})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'IsFirstLoan
        '
        Me.IsFirstLoan.Format = ""
        Me.IsFirstLoan.FormatInfo = Nothing
        Me.IsFirstLoan.HeaderText = "ͳ�Ʒ�Χ"
        Me.IsFirstLoan.MappingName = "IsFirstLoan"
        Me.IsFirstLoan.NullText = ""
        Me.IsFirstLoan.Width = 75
        '
        'iCorpCount
        '
        Me.iCorpCount.Format = ""
        Me.iCorpCount.FormatInfo = Nothing
        Me.iCorpCount.HeaderText = "����"
        Me.iCorpCount.MappingName = "iCorpCount"
        Me.iCorpCount.NullText = ""
        Me.iCorpCount.Width = 75
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmIsFirstLoanStat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(752, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdTable, Me.btnToExcel, Me.btnExit, Me.btnRefresh, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIsFirstLoanStat"
        Me.ShowInTaskbar = False
        Me.Text = "�״δ�����ҵͳ��"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToExcel.Click

        'Dim strFlag As String

        'Select Case Trim(cboChartStyle.Text)
        '    Case "��״ͼ"
        '        strFlag = "0"
        '    Case "����ͼ"
        '        strFlag = "1"
        '    Case "��ͼ"
        '        strFlag = "2"
        '    Case "��ά����ͼ"
        '        strFlag = "3"
        '    Case "��ά����ͼ"
        '        strFlag = "4"
        '    Case "��ά��ͼ"
        '        strFlag = "5"
        '    Case Else
        '        strFlag = "0"
        'End Select

        '  If Me.chkChart.Checked Then

        'Dim arrChart1 As New ArrayList()
        'Dim arrChartList As New ArrayList()

        'arrChart1.Add(strFlag)
        'arrChart1.Add("ͳ�Ʒ�Χ")
        'arrChart1.Add("����")

        'arrChartList.Add(arrChart1)

        'ReportToExcel.ToExcel(grdTable, "�״δ�����ҵͳ��һ����", "�״δ�����ҵͳ��һ����", arrChartList)
            ' Else
            ReportToExcel.ToExcel(Me.grdTable, "�״δ�����ҵͳ��һ����", "�״δ�����ҵͳ��һ����")
            'End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Dim dtResult As DataTable

            Me.Cursor = Cursors.WaitCursor

            Dim FromDate, ToDate As DateTime
            FromDate = IIf(Me.chkDate.Checked, Me.dtpFromDate.Value, New DateTime(1900, 1, 1))
            ToDate = IIf(Me.chkDate.Checked, Me.dtpToDate.Value, New DateTime(2049, 12, 31))

            If FromDate.Date > ToDate.Date Then
                SWDialogBox.MessageBox.Show("$1008", "��ʼ����", "��ֹ����")
                Return
            End If

            dtResult = gWs.Usp_ListIsFirstLoanStat(FromDate, ToDate, UserName).Tables(0)

            grdTable.DataSource = dtResult

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        Me.dtpFromDate.Enabled = Me.chkDate.Checked
        Me.dtpToDate.Enabled = Me.chkDate.Checked
    End Sub

    Private Sub frmIsFirstLoanStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cboChartStyle.SelectedIndex = 0
    End Sub

    'Private Sub chkChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ' IIf(chkChart.Checked, cboChartStyle.Enabled = True, cboChartStyle.Enabled = False)
    '    If chkChart.Checked Then
    '        cboChartStyle.Enabled = True
    '    Else
    '        cboChartStyle.Enabled = False
    '    End If
    'End Sub

End Class
