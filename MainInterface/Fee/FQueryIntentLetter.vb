Public Class FQueryIntentLetter
    Inherits FQueryBase

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
       
        If Not dgts Is Nothing Then
            dgts.Dispose()
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkSignDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpSignStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpSignEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkIssueDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpIssueStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpIssueEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPutOut As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkSignDate = New System.Windows.Forms.CheckBox()
        Me.dtpSignStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpSignEndDate = New System.Windows.Forms.DateTimePicker()
        Me.chkIssueDate = New System.Windows.Forms.CheckBox()
        Me.dtpIssueStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpIssueEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPutOut = New System.Windows.Forms.ComboBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPutOut, Me.Label3, Me.Label2, Me.Label1, Me.dtpIssueEndDate, Me.dtpIssueStartDate, Me.chkIssueDate, Me.dtpSignEndDate, Me.dtpSignStartDate, Me.chkSignDate})
        Me.grpCondition.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.CaptionVisible = True
        Me.grdTable.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Location = New System.Drawing.Point(360, 113)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 23)
        Me.btnSave.TabIndex = 108
        Me.btnSave.Text = "�� ��(&S)"
        '
        'chkSignDate
        '
        Me.chkSignDate.Location = New System.Drawing.Point(16, 16)
        Me.chkSignDate.Name = "chkSignDate"
        Me.chkSignDate.Size = New System.Drawing.Size(80, 24)
        Me.chkSignDate.TabIndex = 0
        Me.chkSignDate.Text = "ǩ������"
        '
        'dtpSignStartDate
        '
        Me.dtpSignStartDate.Enabled = False
        Me.dtpSignStartDate.Location = New System.Drawing.Point(104, 16)
        Me.dtpSignStartDate.Name = "dtpSignStartDate"
        Me.dtpSignStartDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpSignStartDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "        ��"
        '
        'dtpSignEndDate
        '
        Me.dtpSignEndDate.Enabled = False
        Me.dtpSignEndDate.Location = New System.Drawing.Point(320, 16)
        Me.dtpSignEndDate.Name = "dtpSignEndDate"
        Me.dtpSignEndDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpSignEndDate.TabIndex = 3
        '
        'chkIssueDate
        '
        Me.chkIssueDate.Location = New System.Drawing.Point(16, 56)
        Me.chkIssueDate.Name = "chkIssueDate"
        Me.chkIssueDate.Size = New System.Drawing.Size(80, 24)
        Me.chkIssueDate.TabIndex = 4
        Me.chkIssueDate.Text = "ǩ������"
        '
        'dtpIssueStartDate
        '
        Me.dtpIssueStartDate.Enabled = False
        Me.dtpIssueStartDate.Location = New System.Drawing.Point(104, 58)
        Me.dtpIssueStartDate.Name = "dtpIssueStartDate"
        Me.dtpIssueStartDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpIssueStartDate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "        ��"
        '
        'dtpIssueEndDate
        '
        Me.dtpIssueEndDate.Enabled = False
        Me.dtpIssueEndDate.Location = New System.Drawing.Point(320, 58)
        Me.dtpIssueEndDate.Name = "dtpIssueEndDate"
        Me.dtpIssueEndDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpIssueEndDate.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "�������"
        '
        'cboPutOut
        '
        Me.cboPutOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPutOut.Items.AddRange(New Object() {"<δѡ��>", "δ����", "�ѷ���"})
        Me.cboPutOut.Location = New System.Drawing.Point(552, 16)
        Me.cboPutOut.Name = "cboPutOut"
        Me.cboPutOut.Size = New System.Drawing.Size(121, 20)
        Me.cboPutOut.TabIndex = 9
        '
        'FQueryIntentLetter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition, Me.btnSave})
        Me.Name = "FQueryIntentLetter"
        Me.Text = "���������鷢��һ����"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private cmLocal As CurrencyManager
    Private dtResult As DataSet
    Private dgts As DataGridTableStyle

    Protected Overrides Sub SetLayout()
        MyBase.SetLayout()
        Dim height As Integer = IIf(chkVisible.Checked, grpCondition.Height, -grpCondition.Height)
        If Not btnSave Is Nothing Then
            btnSave.Top += height
        End If
    End Sub


    Private Sub chkSignDate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSignDate.CheckedChanged
        dtpSignEndDate.Enabled = chkSignDate.Checked
        dtpSignStartDate.Enabled = chkSignDate.Checked
    End Sub

    Private Sub chkIssueDate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkIssueDate.CheckedChanged
        dtpIssueEndDate.Enabled = chkIssueDate.Checked
        dtpIssueStartDate.Enabled = chkIssueDate.Checked
    End Sub

    Private Sub FQueryIntentLetter_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AddTableStyle()
        MyBase.Clear()
        cboPutOut.SelectedIndex = -1
    End Sub

    'Protected Overloads Sub GetCondition(ByRef strCondition As String)
    '    Dim signStartDate, signEndDate, issueStartDate, issueEndDate As String

    '    signStartDate = IIf(chkSignDate.Checked, dtpSignStartDate.Value.Date.ToString(), "1990-01-01")
    '    signEndDate = IIf(chkSignDate.Checked, dtpSignEndDate.Value.AddDays(1).Date.ToString(), "2100-01-01")

    '    issueStartDate = IIf(chkIssueDate.Checked, dtpIssueStartDate.Value.Date.ToString(), "1990-01-01")
    '    issueEndDate = IIf(chkIssueDate.Checked, dtpIssueEndDate.Value.AddDays(1).Date.ToString(), "2100-01-01")

    '    If chkSignDate.Checked Then
    '        strCondition = "sign_date>='" & signStartDate & "' AND sign_date<'" & signEndDate & "'"
    '    End If
    '    If chkIssueDate.Checked Then
    '        strCondition += IIf(strCondition = "", "", " AND ") & "issue_date>='" & issueStartDate & "' AND issue_date<'" & issueEndDate & "'"
    '    End If
    '    '�Ƿ񷢷�
    '    Dim PutOutType As String = cboPutOut.Tag & ""
    '    If PutOutType <> String.Empty Then
    '        strCondition += IIf(strCondition = "", "", " AND ") & PutOutType
    '    End If

    '    If strCondition <> "" Then
    '        strCondition = "{" & strCondition & " AND NOT sign_date IS NULL}"
    '    Else
    '        strCondition = "{NOT sign_date IS NULL}"
    '    End If
    'End Sub

    Protected Overloads Overrides Sub Refresh(ByVal strCondition As String)
        Dim signStartDate, signEndDate, issueStartDate, issueEndDate As String
        Dim i As Integer
        'Dim dtResult As DataSet


        signStartDate = IIf(chkSignDate.Checked, dtpSignStartDate.Value.Date.ToString(), "1990-01-01")
        signEndDate = IIf(chkSignDate.Checked, dtpSignEndDate.Value.AddDays(1).Date.ToString(), "2100-01-01")
        issueStartDate = IIf(chkIssueDate.Checked, dtpIssueStartDate.Value.Date.ToString(), "1990-01-01")
        issueEndDate = IIf(chkIssueDate.Checked, dtpIssueEndDate.Value.AddDays(1).Date.ToString(), "2100-01-01")
       
        '�Ƿ񷢷�
        Dim PutOutType As String = cboPutOut.SelectedIndex
       
        dtResult = gWs.PQueryIntentLetterInfo(PutOutType, signStartDate, signEndDate, issueStartDate, issueEndDate, UserName)
        Me.grdTable.DataSource = dtResult.Tables(0)
        grdTable.CaptionText = "��¼������" & dtResult.Tables(0).Rows.Count.ToString
        'ds.Tables(0).TableName = "TQueryRequiteProject"
        'grdTable.DataMember = "TQueryRequiteProject"
        grdTable.TableStyles.Clear()
        'grdTable.SetDataBinding(dtResult, "Table")
        AddTableStyle()
        'MyBase.DataSource = dtResult

        If MyBase.grdTable.ReadOnly Then
            MyBase.grdTable.ReadOnly = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If dtResult Is Nothing Then
            Return
        End If
        Dim dsChanges As DataSet = dtResult.GetChanges
        If Not dsChanges Is Nothing Then
            Dim dr As DataRow
            Dim dt As DataTable = dsChanges.Tables(0)
            For Each dr In dt.Rows
                dtResult.Tables(0).Select("intent_code=" & dr("intent_code").ToString)(0)("issue_person") = dr("issue_person")
                dtResult.Tables(0).Select("intent_code=" & dr("intent_code").ToString)(0)("issue_date") = dr("issue_date")
            Next
            Dim result As String = gWs.UpdateIntentLetter(dtResult.GetChanges, Nothing)
            If result = "1" Then
                SWDialogBox.MessageBox.Show("$SaveSucceed")
                dtResult.AcceptChanges()
                dtResult.AcceptChanges()
            Else
                SWDialogBox.MessageBox.Show("*999", "����ʧ��", result, "")
            End If
        End If
    End Sub

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        If dgts Is Nothing Then
            dgts = New DataGridTableStyle()
            dgts.MappingName = "Table"
            Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col1.MappingName = "project_code"
            col1.HeaderText = "��Ŀ���"
            col1.Width = 75
            col1.NullText = ""
            col1.ReadOnly = True
            Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col2.MappingName = "EnterpriseName"
            col2.HeaderText = "��ҵ����"
            col2.Width = 150
            col2.NullText = ""
            col2.ReadOnly = True
            Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col3.MappingName = "ServiceType"
            col3.HeaderText = "ҵ��Ʒ��"
            col3.Width = 100
            col3.NullText = ""
            col3.ReadOnly = True
            Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col4.MappingName = "manager_A"
            col4.HeaderText = "��Ŀ����A��"
            col4.Width = 75
            col4.NullText = ""
            col4.ReadOnly = True
            Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col5.MappingName = "LoanBank"
            col5.HeaderText = "��   ��"
            col5.Width = 100
            col5.NullText = ""
            col5.ReadOnly = True
            Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col8.MappingName = "LoanSubBank"
            col8.HeaderText = "֧   ��"
            col8.Width = 100
            col8.NullText = ""
            col8.ReadOnly = True
            'Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            'col6.MappingName = "manager_B"
            'col6.HeaderText = "��Ŀ����B��"
            'col6.Width = 75
            'col6.NullText = ""
            Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col7.MappingName = "guarantee_sum"
            col7.Alignment = HorizontalAlignment.Right
            col7.HeaderText = "�������(��Ԫ)"
            col7.Width = 100
            col7.NullText = ""
            col7.ReadOnly = True
            Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col9.MappingName = "sign_date"
            col9.HeaderText = "ǩ������"
            col9.Format = "yyyy-MM-dd"
            col9.Width = 75
            col9.NullText = ""
            col9.ReadOnly = True

            Dim col15 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col15.MappingName = "issue_person"
            col15.HeaderText = "ǩ����"
            col15.NullText = ""
            col15.TextBox.MaxLength = 15
            col15.Width = 75

            Dim col10 As DataGridDateTimeColumn = New DataGridDateTimeColumn(DateTimePickerFormat.Long, MyBase.grdTable)
            col10.MappingName = "issue_date"
            col10.HeaderText = "ǩ��ʱ��"
            col10.NullText = ""
            col10.Width = 100

            dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col10, col15, col3, col4, col5, col8, col7, col9})
        End If
        grdTable.TableStyles.Add(dgts)
    End Sub

    Private Sub cboPutOut_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPutOut.SelectedIndexChanged
        'If cmLocal Is Nothing Then
        '    cboPutOut.Tag = String.Empty
        '    Return
        'End If
        Select Case CType(sender, ComboBox).SelectedIndex
            Case 1 'δ����
                cboPutOut.Tag = "issue_person IS NULL AND issue_date IS NULL"
                Exit Select
            Case 2 '�ѷ���
                cboPutOut.Tag = "NOT issue_person IS NULL OR NOT issue_date IS NULL"
                Exit Select
            Case Else
                cboPutOut.Tag = String.Empty
                Exit Select
        End Select
    End Sub

End Class
