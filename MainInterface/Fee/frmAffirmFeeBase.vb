

Public Class frmAffirmFeeBase
    Inherits frmBasic
    Protected ProjectCode As String
    Protected CorporationName As String
    Protected TaskID As String
    Protected WorkFlowID As String
    Protected SystemDate As Date
    Protected dsAccount As DataSet
    Protected IsGuarantyFee, IsReviewFee As Boolean
    Protected Income, Payout As Double
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
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgFee As System.Windows.Forms.DataGrid
    Friend WithEvents cbxGet As System.Windows.Forms.CheckBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents Label8 As System.Windows.Forms.Label
    Protected WithEvents lblFeeType As System.Windows.Forms.Label
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents txtIncome As System.Windows.Forms.TextBox
    Protected WithEvents txtPayout As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPayout = New System.Windows.Forms.TextBox()
        Me.lblFeeType = New System.Windows.Forms.Label()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgFee = New System.Windows.Forms.DataGrid()
        Me.cbxGet = New System.Windows.Forms.CheckBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(440, 304)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtIncome, Me.Label8, Me.txtPayout, Me.lblFeeType, Me.txtCorName, Me.txtProjectCode, Me.Label5, Me.Label6})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtIncome
        '
        Me.txtIncome.BackColor = System.Drawing.SystemColors.Window
        Me.txtIncome.Enabled = False
        Me.txtIncome.Location = New System.Drawing.Point(104, 64)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(80, 21)
        Me.txtIncome.TabIndex = 31
        Me.txtIncome.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "���������(Ԫ)"
        '
        'txtPayout
        '
        Me.txtPayout.BackColor = System.Drawing.SystemColors.Window
        Me.txtPayout.Enabled = False
        Me.txtPayout.Location = New System.Drawing.Point(104, 40)
        Me.txtPayout.Name = "txtPayout"
        Me.txtPayout.Size = New System.Drawing.Size(80, 21)
        Me.txtPayout.TabIndex = 29
        Me.txtPayout.Text = ""
        '
        'lblFeeType
        '
        Me.lblFeeType.Location = New System.Drawing.Point(8, 40)
        Me.lblFeeType.Name = "lblFeeType"
        Me.lblFeeType.Size = New System.Drawing.Size(96, 17)
        Me.lblFeeType.TabIndex = 28
        Me.lblFeeType.Text = "Ӧ�������(Ԫ)"
        Me.lblFeeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCorName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorName.Enabled = False
        Me.txtCorName.Location = New System.Drawing.Point(256, 16)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 24
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(104, 16)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 23
        Me.txtProjectCode.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "��ҵ����"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "��Ŀ����"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgFee})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 200)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'dgFee
        '
        Me.dgFee.CaptionVisible = False
        Me.dgFee.DataMember = ""
        Me.dgFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFee.Location = New System.Drawing.Point(3, 17)
        Me.dgFee.Name = "dgFee"
        Me.dgFee.ReadOnly = True
        Me.dgFee.Size = New System.Drawing.Size(514, 180)
        Me.dgFee.TabIndex = 11
        '
        'cbxGet
        '
        Me.cbxGet.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.cbxGet.Location = New System.Drawing.Point(272, 304)
        Me.cbxGet.Name = "cbxGet"
        Me.cbxGet.Size = New System.Drawing.Size(80, 20)
        Me.cbxGet.TabIndex = 0
        Me.cbxGet.Text = "��ȡ���"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(360, 304)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 1
        Me.btnCommit.Text = "�ύ(&C)"
        '
        'frmAffirmFeeBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(538, 335)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCommit, Me.cbxGet, Me.btnExit, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmAffirmFeeBase"
        Me.Text = "ȷ����ȡ����"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Protected Sub GetDataSource(ByVal ItemType As String, ByVal ItemCode As String)
        dsAccount = New DataSet()
        dsAccount = gWs.GetProjectAccountDetailInfo("{project_code LIKE '" & ProjectCode & "' AND item_type='" & ItemType & "' AND item_code='" & ItemCode & "'}")
        dgFee.DataMember = "project_account_detail"
        dgFee.DataSource = dsAccount
        AddTableStyle()
        Dim dr As DataRow
        For Each dr In dsAccount.Tables(0).Rows
            If Not IsDBNull(dr("income")) Then
                Income += CDbl(dr("income"))
            End If
            If Not IsDBNull(dr("payout")) Then
                Payout += CDbl(dr("payout"))
            End If
        Next
    End Sub

    Protected Function Affirm(ByVal ItemType As String, ByVal ItemCode As String) As Boolean
        Dim dsProDoc As DataSet = gWs.GetProjectDocumentByCondition("{project_code='" & ProjectCode & "' and  item_type='" & ItemType & "' and item_code='" & ItemCode & "'}")
        Dim i As Integer = dsProDoc.Tables(0).Rows.Count
        Dim curPhrase As String = MyBase.getPhase(ProjectCode)
        Dim dr As DataRow = dsProDoc.Tables(0).NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("phase") = curPhrase
            .Item("item_type") = ItemType
            .Item("item_code") = ItemCode
            .Item("check_person") = UserName
            .Item("check_date") = SystemDate.Date
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate.Date
            If IsGuarantyFee Then
                .Item("doc_name") = "�������վ�"
            ElseIf IsReviewFee Then
                .Item("doc_name") = IIf(i = 0, "Ԥ��������վ�", "����������վ�")
            End If
        End With
        dsProDoc.Tables(0).Rows.Add(dr)
        Return (gWs.UpdateProjectAccountDetail(dsProDoc.GetChanges) = "1")
    End Function

    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "�ύ") 'MessageBox.Show("ȷ���ύ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        If IsGuarantyFee Then
            If Not Affirm("44", "003") Then
                SWDialogBox.MessageBox.Show("*999", "ȷ����ȡ������ʧ��")
                'MessageBox.Show("ȷ����ȡ������ʧ�ܣ������ύ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        ElseIf IsReviewFee Then
            If Not Affirm("44", "002") Then
                SWDialogBox.MessageBox.Show("*999", "ȷ����ȡ�����ʧ��")
                'MessageBox.Show("ȷ����ȡ�����ʧ�ܣ������ύ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
        Dim strSuccess As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If strSuccess = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            'MessageBox.Show("�ύ�ɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MyBase.raiseCommitSucceed()
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "�ύʧ��", strSuccess)
            'MessageBox.Show("�ύʧ��" & vbCr & strSuccess, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Protected Sub AddTableStyle()
        dgFee.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "project_account_detail"
        dgts.AllowSorting = False
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "date"
        col3.HeaderText = "����"
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col6.MappingName = "payout"
        col6.HeaderText = "���ս��"
        col6.Alignment = HorizontalAlignment.Right
        col6.NullText = String.Empty
        col6.Width = 90
        col6.Format = "c"
        col6.FormatInfo = CGFormatInfo
        dgts.GridColumnStyles.Add(col6)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "income"
        col2.HeaderText = "��ȡ���"
        col2.Alignment = HorizontalAlignment.Right
        col2.NullText = String.Empty
        col2.Width = 90
        col2.Format = "c"
        col2.FormatInfo = CGFormatInfo
        dgts.GridColumnStyles.Add(col2)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = "  ժҪ"
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 360
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        dgFee.TableStyles.Add(dgts)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmAffirmFeeBase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MyBase.setEnterKeyPress(sender, e)
    End Sub
End Class
