

Public Class FQueryStatisticsPMService
    Inherits MainInterface.FQueryBase
    '��Ŀ����ҵ�����ͳ��
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
    Friend WithEvents cmbEndMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEndYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStartYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbManager As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents YearMonth As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StaffName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RecordCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TotalSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SigCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SigSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VouchCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VouchSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StaffType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iReviewFee As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iGuaranteeFee As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbEndMonth = New System.Windows.Forms.ComboBox()
        Me.cmbEndYear = New System.Windows.Forms.ComboBox()
        Me.cmbStartYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.YearMonth = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.StaffName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.RecordCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.TotalSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SigCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SigSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.VouchCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.VouchSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iReviewFee = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iGuaranteeFee = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.StaffType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 96)
        Me.chkVisible.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(408, 96)
        Me.btnRefresh.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbManager, Me.Label6, Me.cmbEndMonth, Me.cmbEndYear, Me.cmbStartYear, Me.Label2, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(696, 72)
        Me.grpCondition.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 136)
        Me.grdTable.Size = New System.Drawing.Size(696, 352)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 96)
        Me.btnClear.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(512, 96)
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 96)
        Me.btnExit.Visible = True
        '
        'cmbEndMonth
        '
        Me.cmbEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEndMonth.Location = New System.Drawing.Point(272, 24)
        Me.cmbEndMonth.Name = "cmbEndMonth"
        Me.cmbEndMonth.Size = New System.Drawing.Size(44, 20)
        Me.cmbEndMonth.TabIndex = 12
        '
        'cmbEndYear
        '
        Me.cmbEndYear.Location = New System.Drawing.Point(208, 24)
        Me.cmbEndYear.MaxLength = 4
        Me.cmbEndYear.Name = "cmbEndYear"
        Me.cmbEndYear.Size = New System.Drawing.Size(64, 20)
        Me.cmbEndYear.TabIndex = 11
        '
        'cmbStartYear
        '
        Me.cmbStartYear.Location = New System.Drawing.Point(80, 24)
        Me.cmbStartYear.MaxLength = 4
        Me.cmbStartYear.Name = "cmbStartYear"
        Me.cmbStartYear.Size = New System.Drawing.Size(64, 20)
        Me.cmbStartYear.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "��ֹ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "��ʼ���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(336, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "��Ŀ����"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbManager
        '
        Me.cmbManager.Location = New System.Drawing.Point(392, 24)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(121, 20)
        Me.cmbManager.TabIndex = 17
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.YearMonth, Me.StaffName, Me.ServiceType, Me.RecordCount, Me.TotalSum, Me.SigCount, Me.SigSum, Me.VouchCount, Me.VouchSum, Me.iReviewFee, Me.iGuaranteeFee, Me.StaffType})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'YearMonth
        '
        Me.YearMonth.Format = ""
        Me.YearMonth.FormatInfo = Nothing
        Me.YearMonth.HeaderText = "����"
        Me.YearMonth.MappingName = "YearMonth"
        Me.YearMonth.NullText = ""
        Me.YearMonth.Width = 75
        '
        'StaffName
        '
        Me.StaffName.Format = ""
        Me.StaffName.FormatInfo = Nothing
        Me.StaffName.HeaderText = "��Ŀ����"
        Me.StaffName.MappingName = "StaffName"
        Me.StaffName.NullText = ""
        Me.StaffName.Width = 75
        '
        'ServiceType
        '
        Me.ServiceType.Format = ""
        Me.ServiceType.FormatInfo = Nothing
        Me.ServiceType.HeaderText = "ҵ��Ʒ��"
        Me.ServiceType.MappingName = "ServiceType"
        Me.ServiceType.NullText = ""
        Me.ServiceType.Width = 170
        '
        'RecordCount
        '
        Me.RecordCount.Format = ""
        Me.RecordCount.FormatInfo = Nothing
        Me.RecordCount.HeaderText = "����"
        Me.RecordCount.MappingName = "RecordCount"
        Me.RecordCount.NullText = "0"
        Me.RecordCount.Width = 0
        '
        'TotalSum
        '
        Me.TotalSum.Format = "n"
        Me.TotalSum.FormatInfo = Nothing
        Me.TotalSum.HeaderText = " ����ͨ�����(��Ԫ)"
        Me.TotalSum.MappingName = "TotalSum"
        Me.TotalSum.NullText = "0.00"
        Me.TotalSum.Width = 0
        '
        'SigCount
        '
        Me.SigCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.SigCount.Format = ""
        Me.SigCount.FormatInfo = Nothing
        Me.SigCount.HeaderText = "ǩԼ����"
        Me.SigCount.MappingName = "SigCount"
        Me.SigCount.NullText = "0"
        Me.SigCount.Width = 80
        '
        'SigSum
        '
        Me.SigSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.SigSum.Format = "n"
        Me.SigSum.FormatInfo = Nothing
        Me.SigSum.HeaderText = "ǩԼ���(��Ԫ)"
        Me.SigSum.MappingName = "SigSum"
        Me.SigSum.NullText = "0.00"
        Me.SigSum.Width = 120
        '
        'VouchCount
        '
        Me.VouchCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.VouchCount.Format = ""
        Me.VouchCount.FormatInfo = Nothing
        Me.VouchCount.HeaderText = "�б�����"
        Me.VouchCount.MappingName = "VouchCount"
        Me.VouchCount.NullText = "0"
        Me.VouchCount.Width = 80
        '
        'VouchSum
        '
        Me.VouchSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.VouchSum.Format = "n"
        Me.VouchSum.FormatInfo = Nothing
        Me.VouchSum.HeaderText = "�б����(��Ԫ)"
        Me.VouchSum.MappingName = "VouchSum"
        Me.VouchSum.NullText = "0.00"
        Me.VouchSum.Width = 120
        '
        'iReviewFee
        '
        Me.iReviewFee.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iReviewFee.Format = "n"
        Me.iReviewFee.FormatInfo = Nothing
        Me.iReviewFee.HeaderText = "�����"
        Me.iReviewFee.MappingName = "iReviewFee"
        Me.iReviewFee.NullText = ""
        Me.iReviewFee.Width = 120
        '
        'iGuaranteeFee
        '
        Me.iGuaranteeFee.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iGuaranteeFee.Format = "n"
        Me.iGuaranteeFee.FormatInfo = Nothing
        Me.iGuaranteeFee.HeaderText = "������"
        Me.iGuaranteeFee.MappingName = "iGuaranteeFee"
        Me.iGuaranteeFee.NullText = ""
        Me.iGuaranteeFee.Width = 120
        '
        'StaffType
        '
        Me.StaffType.Format = ""
        Me.StaffType.FormatInfo = Nothing
        Me.StaffType.HeaderText = "���"
        Me.StaffType.MappingName = "StaffType"
        Me.StaffType.NullText = ""
        Me.StaffType.Width = 75
        '
        'FQueryStatisticsPMService
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryStatisticsPMService"
        Me.Text = "��Ŀ����ҵ�����ͳ�Ʊ�"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryStatisticsPMService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setYear()
        setMonth()
        setManager()
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False
        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryStatisticsPMService.rpt"
        MyBase.ReportTitle = "��Ŀ����ҵ�����ͳ�Ʊ�"
    End Sub
    '����(��ʼ,��ֹ)��ݵĳ�ʼֵ
    Private Sub setYear()
        Dim i As Integer
        For i = 1950 To 2050
            Me.cmbStartYear.Items.Add(i)
            Me.cmbEndYear.Items.Add(i)
        Next
        Me.cmbStartYear.SelectedItem = Date.Now.Year
        Me.cmbEndYear.SelectedItem = Date.Now.Year
    End Sub
    '�����·ݵĳ�ʼֵ
    Private Sub setMonth()
        Dim i As Integer
        For i = 1 To 12
            Me.cmbEndMonth.Items.Add(i)
        Next
        Me.cmbEndMonth.SelectedItem = Date.Now.Month
    End Sub
    '������Ŀ����
    Private Sub setManager()
        Dim ds As DataSet
        Dim strSql As String
        strSql = "{not team_name is null}"
        Try
            ds = gWs.GetStaff(strSql)
            If Not ds Is Nothing Then
                Me.cmbManager.DataSource = ds.Tables(0)
                Me.cmbManager.DisplayMember = "staff_name"
                Me.cmbManager.ValueMember = "staff_name"
                Me.cmbManager.SelectedValue = ""
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '��ò�ѯ����
    Private Overloads Sub GetCondition(ByRef startYear As String, ByRef endYear As String, ByRef endMonth As String, ByRef manager As String)
        startYear = Me.cmbStartYear.Text.Trim
        endYear = Me.cmbEndYear.Text.Trim
        endMonth = Me.cmbEndMonth.Text.Trim
        manager = Me.cmbManager.Text.Trim
    End Sub
    '��ѯ
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim startYear, endYear, endMonth, manager As String
        GetCondition(startYear, endYear, endMonth, manager)
        If startYear.Trim = "" Then
            'MsgBox("���ڲ���Ϊ��!", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$1001", "���")
            Me.cmbStartYear.Focus()
            Exit Sub
        End If
        If endYear.Trim = "" Then
            'MsgBox("���ڲ���Ϊ��!", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$1001", "���")
            Me.cmbEndYear.Focus()
            Exit Sub
        End If
        If determineDate(startYear, endYear) Then
            Exit Sub
        End If
        Dim dsResult As DataSet
        Dim recordCount As Integer

        dsResult = gWs.FQueryStatisticsPMService(startYear, endYear + endMonth, manager, UserName)
        If Not dsResult Is Nothing Then
            MyBase.DataSource = dsResult.Tables(0)
            Me.grdTable.DataSource = dsResult.Tables(0)
            recordCount = dsResult.Tables(0).Rows.Count
            Me.Text = "��Ŀ����ҵ�����ͳ�Ʊ�" & "(" & recordCount & ")"
        End If
    End Sub
    '����Clear()����
    Protected Overrides Sub Clear()
        Dim control As Control
        Try
            For Each control In grpCondition.Controls
                If control.GetType() Is GetType(ComboBox) Then
                    CType(control, ComboBox).SelectedItem = Date.Now.Year
                    CType(control, ComboBox).SelectedItem = Date.Now.Month
                End If
            Next
            If Not Me.cmbManager Is Nothing Then
                Me.cmbManager.SelectedIndex = -1
                Me.cmbManager.SelectedItem = Nothing
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�ж���ʼ��ݺͽ�ֹ��ݵĴ�С
    '�ж���ʼ�ͽ�ֹ����
    Private Function determineDate(ByVal dateStart As String, ByVal dateEnd As String)
        If dateStart > dateEnd Then
            'MsgBox("��ֹ��ݱ�����ڻ������ʼ���", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$1008", "��ʼ���", "��ֹ���")
            Me.cmbStartYear.Text = dateEnd
            Return True
        End If
    End Function
    'Protected Overrides Sub Export()

    '    Dim export As ReportToExcel = New ReportToExcel()
    '    Dim array As New ArrayList()
    '    Dim array2 As New ArrayList()
    '    Dim array3 As New ArrayList()
    '    Dim array4 As New ArrayList()
    '    Dim array5 As New ArrayList()

    '    array.Add("0")
    '    array.Add("�����")
    '    array.Add("����ͨ�����(��Ԫ)")
    '    array.Add("ǩԼ���(��Ԫ)")
    '    array.Add("�ڱ����(��Ԫ)")

    '    array5.Add("0")
    '    array5.Add("����")
    '    array5.Add("����ͨ�����(��Ԫ)")
    '    array5.Add("ǩԼ���(��Ԫ)")
    '    array5.Add("�ڱ����(��Ԫ)")

    '    array2.Add("2")
    '    array2.Add("����")
    '    array2.Add("����ͨ�����(��Ԫ)")
    '    array2.Add("ǩԼ���(��Ԫ)")
    '    array2.Add("�ڱ����(��Ԫ)")

    '    array3.Add("1")
    '    array3.Add("����")
    '    array3.Add("����ͨ�����(��Ԫ)")
    '    array3.Add("ǩԼ���(��Ԫ)")
    '    array3.Add("�ڱ����(��Ԫ)")

    '    array4.Add("3")
    '    array4.Add("����")
    '    array4.Add("ǩԼ���(��Ԫ)")
    '    array4.Add("�ڱ����(��Ԫ)")

    '    Dim arrayList As New ArrayList()
    '    arrayList.Add(array)
    '    arrayList.Add(array2)
    '    arrayList.Add(array3)
    '    arrayList.Add(array4)
    '    arrayList.Add(array5)


    '    export.ToExcel(grdTable, ReportTitle, ReportTitle, arrayList)
    'End Sub
End Class
