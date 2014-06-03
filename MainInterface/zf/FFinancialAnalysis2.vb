
'�������
Public Class FFinancialAnalysis
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮�������κγ�ʼ��

    End Sub

    '������д��������������б���
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
    Friend WithEvents lblPhase As System.Windows.Forms.Label
    Friend WithEvents lblProjectNo As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents cboCorporationNo As System.Windows.Forms.ComboBox
    Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lblCorporationNo As System.Windows.Forms.Label
    Friend WithEvents grdTable As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csTypeName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIndexType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csLastYear3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csLastYear2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csChangeRate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csLastYear1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboSecondMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
    Friend WithEvents cboFirstMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboThirdMonth As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FFinancialAnalysis))
        Me.lblCorporationNo = New System.Windows.Forms.Label()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.cboCorporationNo = New System.Windows.Forms.ComboBox()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        Me.cboFirstMonth = New System.Windows.Forms.ComboBox()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csTypeName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIndexType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLastYear3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLastYear2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csChangeRate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLastYear1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.cboThirdMonth = New System.Windows.Forms.ComboBox()
        Me.cboSecondMonth = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCorporationNo
        '
        Me.lblCorporationNo.AutoSize = True
        Me.lblCorporationNo.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorporationNo.Location = New System.Drawing.Point(224, 35)
        Me.lblCorporationNo.Name = "lblCorporationNo"
        Me.lblCorporationNo.Size = New System.Drawing.Size(72, 14)
        Me.lblCorporationNo.TabIndex = 23
        Me.lblCorporationNo.Text = "��ҵ����(&C)"
        '
        'lblPhase
        '
        Me.lblPhase.AutoSize = True
        Me.lblPhase.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhase.Location = New System.Drawing.Point(16, 59)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(72, 14)
        Me.lblPhase.TabIndex = 19
        Me.lblPhase.Text = "��Ŀ�׶�(&P)"
        '
        'lblProjectNo
        '
        Me.lblProjectNo.AutoSize = True
        Me.lblProjectNo.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectNo.Location = New System.Drawing.Point(16, 35)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(72, 14)
        Me.lblProjectNo.TabIndex = 16
        Me.lblProjectNo.Text = "��Ŀ���(&N)"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(224, 59)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(72, 14)
        Me.lblMonth.TabIndex = 21
        Me.lblMonth.Text = "�ƻ�����(M)"
        '
        'cboCorporationNo
        '
        Me.cboCorporationNo.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboCorporationNo.DisplayMember = "corporation_name"
        Me.cboCorporationNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCorporationNo.Location = New System.Drawing.Point(296, 32)
        Me.cboCorporationNo.Name = "cboCorporationNo"
        Me.cboCorporationNo.Size = New System.Drawing.Size(328, 20)
        Me.cboCorporationNo.TabIndex = 18
        Me.cboCorporationNo.ValueMember = "corporation_code"
        '
        'cboPhase
        '
        Me.cboPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhase.Location = New System.Drawing.Point(88, 56)
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(120, 20)
        Me.cboPhase.TabIndex = 20
        '
        'cboFirstMonth
        '
        Me.cboFirstMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFirstMonth.DropDownWidth = 72
        Me.cboFirstMonth.Location = New System.Drawing.Point(528, 56)
        Me.cboFirstMonth.MaxLength = 6
        Me.cboFirstMonth.Name = "cboFirstMonth"
        Me.cboFirstMonth.Size = New System.Drawing.Size(96, 20)
        Me.cboFirstMonth.TabIndex = 22
        '
        'grdTable
        '
        Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 80)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.ReadOnly = True
        Me.grdTable.Size = New System.Drawing.Size(616, 296)
        Me.grdTable.TabIndex = 24
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csTypeName, Me.csIndexType, Me.csLastYear3, Me.csLastYear2, Me.csChangeRate, Me.csLastYear1})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'csTypeName
        '
        Me.csTypeName.Format = ""
        Me.csTypeName.FormatInfo = Nothing
        Me.csTypeName.HeaderText = "��Ŀ����"
        Me.csTypeName.MappingName = "type_name"
        Me.csTypeName.Width = 80
        '
        'csIndexType
        '
        Me.csIndexType.Format = ""
        Me.csIndexType.FormatInfo = Nothing
        Me.csIndexType.HeaderText = "��  Ŀ"
        Me.csIndexType.MappingName = "index_name"
        Me.csIndexType.Width = 120
        '
        'csLastYear3
        '
        Me.csLastYear3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csLastYear3.Format = "N"
        Me.csLastYear3.FormatInfo = Nothing
        Me.csLastYear3.MappingName = "index_value3"
        Me.csLastYear3.Width = 90
        '
        'csLastYear2
        '
        Me.csLastYear2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csLastYear2.Format = "N"
        Me.csLastYear2.FormatInfo = Nothing
        Me.csLastYear2.MappingName = "index_value2"
        Me.csLastYear2.Width = 90
        '
        'csChangeRate
        '
        Me.csChangeRate.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csChangeRate.Format = "0.00"
        Me.csChangeRate.FormatInfo = Nothing
        Me.csChangeRate.HeaderText = "��  ��"
        Me.csChangeRate.MappingName = "ChangeRate"
        Me.csChangeRate.Width = 80
        '
        'csLastYear1
        '
        Me.csLastYear1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csLastYear1.Format = "N"
        Me.csLastYear1.FormatInfo = Nothing
        Me.csLastYear1.MappingName = "index_value1"
        Me.csLastYear1.Width = 90
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(320, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "�� ��(&X)"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCreate.Location = New System.Drawing.Point(232, 384)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(80, 24)
        Me.btnCreate.TabIndex = 26
        Me.btnCreate.Text = "�� ��(&C)"
        '
        'cboThirdMonth
        '
        Me.cboThirdMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThirdMonth.DropDownWidth = 72
        Me.cboThirdMonth.Location = New System.Drawing.Point(296, 56)
        Me.cboThirdMonth.MaxLength = 6
        Me.cboThirdMonth.Name = "cboThirdMonth"
        Me.cboThirdMonth.Size = New System.Drawing.Size(96, 20)
        Me.cboThirdMonth.TabIndex = 28
        '
        'cboSecondMonth
        '
        Me.cboSecondMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecondMonth.DropDownWidth = 72
        Me.cboSecondMonth.Location = New System.Drawing.Point(412, 56)
        Me.cboSecondMonth.MaxLength = 6
        Me.cboSecondMonth.Name = "cboSecondMonth"
        Me.cboSecondMonth.Size = New System.Drawing.Size(96, 20)
        Me.cboSecondMonth.TabIndex = 29
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(80, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(113, 15)
        Me.lblTitle.TabIndex = 30
        Me.lblTitle.Text = "���������������"
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Location = New System.Drawing.Point(88, 32)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectNo.TabIndex = 31
        Me.txtProjectNo.Text = ""
        '
        'FFinancialAnalysis
        '
        Me.AcceptButton = Me.btnCreate
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(632, 413)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtProjectNo, Me.lblTitle, Me.lblCorporationNo, Me.lblPhase, Me.lblProjectNo, Me.lblMonth, Me.cboSecondMonth, Me.cboThirdMonth, Me.btnExit, Me.btnCreate, Me.grdTable, Me.cboCorporationNo, Me.cboPhase, Me.cboFirstMonth})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FFinancialAnalysis"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�������"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const MaxProjectCodeLength As Integer = 9  '��Ŀ������󳤶�

    '���ÿؼ�״̬
    Public Sub SetEditState(ByVal Enabled As Boolean)
        txtProjectNo.Enabled = Enabled
        cboPhase.Enabled = True
    End Sub

    Public Overloads Function ShowDialog(ByVal ProjectNo As String, Optional ByVal CorporationNo As String = Nothing, Optional ByVal Phase As String = Nothing, Optional ByVal Month As String = Nothing, Optional ByVal MonthLast As String = Nothing) As DialogResult
        MyBase.Show()
        Me.txtProjectNo.Text = ProjectNo
        Me.cboCorporationNo.SelectedValue = CorporationNo
        Me.cboPhase.SelectedValue = Phase

        '2008-2-22 yjf delete ��ֹ������formLoad�¼����������°󶨽׶�������
        'Me.Hide()
        'MyBase.ShowDialog()
    End Function
    '����Graphics����ֱ��
    Private Sub FFinancialAnalysis_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim linePen As Drawing.Pen = New Drawing.Pen(Color.Gray)

        e.Graphics.DrawLine(linePen, 8, lblTitle.Top + (lblTitle.Height \ 2), Me.ClientSize.Width - 16, lblTitle.Top + (lblTitle.Height \ 2))
        linePen.Color = Color.White
        e.Graphics.DrawLine(linePen, 8, lblTitle.Top + (lblTitle.Height \ 2) + 1, Me.ClientSize.Width - 16, lblTitle.Top + (lblTitle.Height \ 2) + 1)
    End Sub

    Private Sub FProjectCredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPhase.DataSource = gWs.GetPhase("%").Tables(0)
        cboPhase.DisplayMember = "phase_name"
        cboPhase.ValueMember = "phase_name"
    End Sub

    '���㰴ť
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.grdTable.DataSource = Nothing

            If Not Me.CheckData() Then
                Return
            End If

            Me.CreateFinanceAnalyse()
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    'ֱ���˳�
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '����У��
    Private Function CheckData() As Boolean
        If txtProjectNo.Text.Trim = "" Then
            SWDialogBox.MessageBox.Show("��Ŀ��Ų���Ϊ�գ�������һ�����ڵ���Ŀ��ţ�", "ϵͳ��ʾ", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            txtProjectNo.Focus()
            txtProjectNo.SelectAll()
            Return False
        End If

        If Me.cboCorporationNo.Text = "" Or Me.cboPhase.Text = "" Then
            SWDialogBox.MessageBox.Show("��ҵ������׶β���Ϊ�գ���鿴��Ŀ��������Ƿ�����", "ϵͳ��ʾ", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            Return False
        End If

        'If (cboThirdMonth.Enabled And cboThirdMonth.Text.Trim().Length <> 6) Then
        '    SWDialogBox.MessageBox.Show("��Ч���������ݣ���ѡȡһ���Ϸ������£�YYYYMM����", "ϵͳ��ʾ", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
        '    Return False
        'End If

        Dim systemID As Integer = gWs.GetSystemID(txtProjectNo.Text.Trim(), cboCorporationNo.SelectedValue, cboPhase.Text.Trim())
        If systemID < 1 Then
            SWDialogBox.MessageBox.Show("�޷���ȡ��ǰ��������ϵ����ȷ���Ƿ�ָ���˸���Ŀ��ҵ��������ҵ��", "ϵͳ��ʾ", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            Return False
        End If

        Return True
    End Function
    '������������������ʾ
    Private Sub CreateFinanceAnalyse()
        'Dim rsResult As DataSet = gWs.FetchProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, cboThirdMonth.Text, _lastYear1)
        'If (Not rsResult Is Nothing) AndAlso rsResult.Tables(0).Rows.Count > 0 Then
        '    rsResult = gWs.FetchProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, _lastYear1, _lastYear2)
        '    If (Not rsResult Is Nothing) AndAlso rsResult.Tables(0).Rows.Count > 0 Then
        '        rsResult = gWs.FetchProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, _lastYear2, _lastYear3)
        '        If (Not rsResult Is Nothing) AndAlso rsResult.Tables(0).Rows.Count > 0 Then
        '            If MessageBox.Show("��ȷ��Ҫ���¼�����������" + Environment.NewLine + "������¼��㽫�Ḳ�ǵ���ǰ�Ĳ������ݡ�", "��ʾѯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
        '                Return True
        '            End If
        '        End If
        '    End If
        'End If
        gWs.DeleteProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text)

        Dim ar As New ArrayList()
        ar.Add(Me.cboFirstMonth.Text)
        ar.Add(Me.cboSecondMonth.Text)
        ar.Add(Me.cboThirdMonth.Text)
        ar.Sort()
        ar.Reverse()

        Dim strYear1, strYear2, strYear3, strYear4 As String '���δ���������һ�����ڶ����������������ĸ�����
        strYear1 = ar.Item(0)
        strYear2 = ar.Item(1)
        strYear3 = ar.Item(2)

        csLastYear1.HeaderText = ""
        csLastYear2.HeaderText = ""
        csLastYear3.HeaderText = ""

        Dim dsResult As DataSet
        '��������������
        If strYear1 = String.Empty Then
            Return
        ElseIf strYear2 = String.Empty Then 'ֻ��һ��
            csLastYear1.HeaderText = DateTime.ParseExact(strYear1, "yyyyMM", Nothing).ToString("yyyy��MM��")
            strYear2 = DateTime.ParseExact(strYear1, "yyyyMM", Nothing).AddYears(-1).ToString("yyyyMM")
            gWs.CreateProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, strYear1, strYear2)
            dsResult = gWs.FetchProjectFinanceAnalyseIntegration(Me.txtProjectNo.Text.Trim(), Me.cboCorporationNo.SelectedValue, Me.cboPhase.Text, _
                 strYear1, strYear2, "", "")
        ElseIf strYear3 = String.Empty Then '����
            csLastYear1.HeaderText = DateTime.ParseExact(strYear1, "yyyyMM", Nothing).ToString("yyyy��MM��")
            csLastYear2.HeaderText = DateTime.ParseExact(strYear2, "yyyyMM", Nothing).ToString("yyyy��MM��")
            strYear3 = DateTime.ParseExact(strYear2, "yyyyMM", Nothing).AddYears(-1).ToString("yyyyMM")
            gWs.CreateProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, strYear1, strYear2)
            gWs.CreateProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, strYear2, strYear3)
            dsResult = gWs.FetchProjectFinanceAnalyseIntegration(Me.txtProjectNo.Text.Trim(), Me.cboCorporationNo.SelectedValue, Me.cboPhase.Text, _
              strYear1, strYear2, strYear3, "")
        Else                                '����
            csLastYear1.HeaderText = DateTime.ParseExact(strYear1, "yyyyMM", Nothing).ToString("yyyy��MM��")
            csLastYear2.HeaderText = DateTime.ParseExact(strYear2, "yyyyMM", Nothing).ToString("yyyy��MM��")
            csLastYear3.HeaderText = DateTime.ParseExact(strYear3, "yyyyMM", Nothing).ToString("yyyy��MM��")
            strYear4 = DateTime.ParseExact(strYear3, "yyyyMM", Nothing).AddYears(-1).ToString("yyyyMM")
            Dim strYear1compare As String = DateTime.ParseExact(strYear1, "yyyyMM", Nothing).AddYears(-1).ToString("yyyyMM")
            gWs.CreateProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, strYear1, strYear1compare)
            gWs.CreateProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, strYear2, strYear3)
            gWs.CreateProjectFinanceAnalyse(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text, strYear3, strYear4)
            dsResult = gWs.FetchProjectFinanceAnalyseIntegration(Me.txtProjectNo.Text.Trim(), Me.cboCorporationNo.SelectedValue, Me.cboPhase.Text, _
              strYear1, strYear2, strYear3, strYear4)
        End If

        dsResult.Tables("Table").Columns.Add("ChangeRate", GetType(Decimal), "(index_value2-index_value3)/IIF(index_value3=0, 1, IIF(index_value3>0, index_value3, -index_value3))")
        grdTable.SetDataBinding(dsResult, "Table")
    End Sub

    '��Ŀ�����ı���ı䣬���뵱ǰ��ҵ����
    Private Sub txtProjectNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjectNo.TextChanged
        If Me.txtProjectNo.Text.Trim().Length >= Me.MaxProjectCodeLength Then
            cboCorporationNo.DataSource = gWs.FetchCorporationAccountCreditEx(txtProjectNo.Text).Tables(0)
        End If
    End Sub
    '��ǰ��ҵ����ǰ�׶α仯�����������������
    Private Sub SetMonth(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCorporationNo.SelectedIndexChanged, cboPhase.SelectedIndexChanged
        If Me.cboCorporationNo.Text = "" Or Me.cboPhase.Text = "" Then
            Return
        End If

        Dim dt As DataTable = gWs.FetchCorporationAccountMonth(txtProjectNo.Text, cboCorporationNo.SelectedValue, cboPhase.Text).Tables(0)
        dt.Rows.Add(New Object() {""})

        cboFirstMonth.DataSource = dt
        cboFirstMonth.DisplayMember = "month"
        cboFirstMonth.ValueMember = "month"

        cboSecondMonth.DataSource = dt.Copy()
        cboSecondMonth.DisplayMember = "month"
        cboSecondMonth.ValueMember = "month"

        cboThirdMonth.DataSource = dt.Copy()
        cboThirdMonth.DisplayMember = "month"
        cboThirdMonth.ValueMember = "month"

        '�����´����������ſ������ĵ��������
        Dim count As Integer = dt.Rows.Count
        If count = 2 Then
            Me.cboFirstMonth.SelectedIndex = 0
        ElseIf count = 3 Then
            Me.cboSecondMonth.SelectedIndex = 0
            Me.cboFirstMonth.SelectedIndex = 1
        ElseIf count > 3 Then
            Me.cboThirdMonth.SelectedIndex = dt.Rows.Count - 4
            Me.cboSecondMonth.SelectedIndex = dt.Rows.Count - 3
            Me.cboFirstMonth.SelectedIndex = dt.Rows.Count - 2
        End If

    End Sub


    Private Sub cboFirstMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFirstMonth.SelectedIndexChanged
        If Me.cboFirstMonth.Text = "" Then
            Return
        End If
        If Me.cboSecondMonth.Text = Me.cboFirstMonth.Text Then
            Me.cboSecondMonth.SelectedValue = ""
        End If
        If Me.cboThirdMonth.Text = Me.cboFirstMonth.Text Then
            Me.cboThirdMonth.SelectedValue = ""
        End If
    End Sub

    Private Sub cboSecondMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSecondMonth.SelectedIndexChanged
        If Me.cboSecondMonth.Text = "" Then
            Return
        End If
        If Me.cboFirstMonth.Text = Me.cboSecondMonth.Text Then
            Me.cboFirstMonth.SelectedValue = ""
        End If
        If Me.cboThirdMonth.Text = Me.cboSecondMonth.Text Then
            Me.cboThirdMonth.SelectedValue = ""
        End If
    End Sub

    Private Sub cboThirdMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboThirdMonth.SelectedIndexChanged
        If Me.cboThirdMonth.Text = "" Then
            Return
        End If
        If Me.cboFirstMonth.Text = Me.cboThirdMonth.Text Then
            Me.cboFirstMonth.SelectedValue = ""
        End If
        If Me.cboSecondMonth.Text = Me.cboThirdMonth.Text Then
            Me.cboSecondMonth.SelectedValue = ""
        End If
    End Sub

    Private Sub cbo_selectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ar As New ArrayList()
        ar.Add(Me.cboFirstMonth)
        ar.Add(Me.cboSecondMonth)
        ar.Add(Me.cboThirdMonth)


        AddHandler cboFirstMonth.SelectedIndexChanged, AddressOf cbo_selectedIndexChanged
        AddHandler cboSecondMonth.SelectedIndexChanged, AddressOf cbo_selectedIndexChanged
        AddHandler cboThirdMonth.SelectedIndexChanged, AddressOf cbo_selectedIndexChanged

    End Sub



End Class