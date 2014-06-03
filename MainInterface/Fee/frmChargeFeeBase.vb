'���ߣ�����棻����2003-04-05
Public Class frmChargeFeeBase
    Inherits frmBasic

    Public MaxChargeFee As Double = 100000000
    Public WorkFlowID As String
    Public CorporationName As String
    Public ProjectCode As String
    Public TaskID As String
    Protected bmAccount As BindingManagerBase
    Protected item_type As String = String.Empty
    Protected item_code As String = String.Empty         'frmGuarantFee.vb
    Protected dsItem As DataSet
    Protected dsAccountDetail As DataSet 'DataSet for update to DataBase
    Protected strStatus As String = String.Empty
    Protected SystemDate As DateTime
    Protected IsReviewFee As Boolean = False '��ȡ�����
    Protected IsGuarantyFee As Boolean = False '��ȡ������
    Protected IsReturnFee As Boolean = False '��ȡ����

    '2013-11-30 yjf add
    Protected IsLoanInterestFee As Boolean = False '��ȡί����Ϣ

    '2013-11-30 yjf add
    Protected IsFinancingConsultingFee As Boolean = False '��ȡ���ʹ��ʷ�

    Protected IsSecurityFee As Boolean = False '��ȡ��֤��
    Protected IsReturnSecurityFee As Boolean = False '�˻���֤��
    Protected IsReturnGuaranteeFee As Boolean = False '�˻�������

    Protected IsReturnFinancingConsultingFee As Boolean = False '�˻����ʹ��ʷ�
    Protected IsReturnReviewFee As Boolean = False '�˻������
    Protected IsReturnEvaluateFee As Boolean = False '�˻�������

    '2013-12-03 yjf add
    Protected IsBankFee As Boolean = False '�Ǽ����з���

    Protected IsOverDueFee As Boolean = False '�Ǽ�������Ϣ
    Protected IsRefundDebt As Boolean = False '�ǼǴ�����Ϣ
    Protected IsRegisterDischargeInfo As Boolean = False '�Ǽ��峥��Ϣ
    Protected LessMoney As Double = 0
    Protected phase As String
#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()
        
        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAccountDetail Is Nothing Then
            dsAccountDetail.Dispose()
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
    Public WithEvents gpbxResult As System.Windows.Forms.GroupBox

    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtSummary As System.Windows.Forms.TextBox
    Public WithEvents dgMoney As System.Windows.Forms.DataGrid
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnModify As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblFeeType As System.Windows.Forms.Label
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Public WithEvents cmbxType As System.Windows.Forms.ComboBox
    Public WithEvents txtIncome As System.Windows.Forms.TextBox
    Public WithEvents gpbxDetail As System.Windows.Forms.GroupBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChargeFeeBase))
        Me.txtCorName = New System.Windows.Forms.TextBox
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gpbxResult = New System.Windows.Forms.GroupBox
        Me.dgMoney = New System.Windows.Forms.DataGrid
        Me.gpbxDetail = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIncome = New System.Windows.Forms.TextBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.cmbxType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFeeType = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSummary = New System.Windows.Forms.TextBox
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCommit = New System.Windows.Forms.Button
        Me.gpbxResult.SuspendLayout()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(504, 352)
        Me.btnExit.TabIndex = 10
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.Images.SetKeyName(0, "")
        Me.ImageListBasic.Images.SetKeyName(1, "")
        Me.ImageListBasic.Images.SetKeyName(2, "")
        Me.ImageListBasic.Images.SetKeyName(3, "")
        Me.ImageListBasic.Images.SetKeyName(4, "")
        Me.ImageListBasic.Images.SetKeyName(5, "")
        Me.ImageListBasic.Images.SetKeyName(6, "")
        Me.ImageListBasic.Images.SetKeyName(7, "")
        Me.ImageListBasic.Images.SetKeyName(8, "")
        Me.ImageListBasic.Images.SetKeyName(9, "")
        Me.ImageListBasic.Images.SetKeyName(10, "")
        Me.ImageListBasic.Images.SetKeyName(11, "")
        Me.ImageListBasic.Images.SetKeyName(12, "")
        Me.ImageListBasic.Images.SetKeyName(13, "")
        Me.ImageListBasic.Images.SetKeyName(14, "")
        Me.ImageListBasic.Images.SetKeyName(15, "")
        Me.ImageListBasic.Images.SetKeyName(16, "")
        Me.ImageListBasic.Images.SetKeyName(17, "")
        Me.ImageListBasic.Images.SetKeyName(18, "")
        Me.ImageListBasic.Images.SetKeyName(19, "")
        Me.ImageListBasic.Images.SetKeyName(20, "")
        Me.ImageListBasic.Images.SetKeyName(21, "")
        Me.ImageListBasic.Images.SetKeyName(22, "")
        Me.ImageListBasic.Images.SetKeyName(23, "")
        Me.ImageListBasic.Images.SetKeyName(24, "")
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(248, 7)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(288, 21)
        Me.txtCorName.TabIndex = 20
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 7)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "��ҵ����"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "��Ŀ����"
        '
        'gpbxResult
        '
        Me.gpbxResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbxResult.Controls.Add(Me.dgMoney)
        Me.gpbxResult.ForeColor = System.Drawing.Color.Red
        Me.gpbxResult.Location = New System.Drawing.Point(8, 32)
        Me.gpbxResult.Name = "gpbxResult"
        Me.gpbxResult.Size = New System.Drawing.Size(576, 224)
        Me.gpbxResult.TabIndex = 15
        Me.gpbxResult.TabStop = False
        '
        'dgMoney
        '
        Me.dgMoney.CaptionVisible = False
        Me.dgMoney.DataMember = ""
        Me.dgMoney.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMoney.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMoney.Location = New System.Drawing.Point(3, 17)
        Me.dgMoney.Name = "dgMoney"
        Me.dgMoney.ReadOnly = True
        Me.dgMoney.RowHeadersVisible = False
        Me.dgMoney.RowHeaderWidth = 0
        Me.dgMoney.Size = New System.Drawing.Size(570, 204)
        Me.dgMoney.TabIndex = 0
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbxDetail.Controls.Add(Me.Label1)
        Me.gpbxDetail.Controls.Add(Me.txtIncome)
        Me.gpbxDetail.Controls.Add(Me.dtpDate)
        Me.gpbxDetail.Controls.Add(Me.cmbxType)
        Me.gpbxDetail.Controls.Add(Me.Label2)
        Me.gpbxDetail.Controls.Add(Me.lblFeeType)
        Me.gpbxDetail.Controls.Add(Me.Label3)
        Me.gpbxDetail.Controls.Add(Me.txtSummary)
        Me.gpbxDetail.Location = New System.Drawing.Point(8, 256)
        Me.gpbxDetail.Name = "gpbxDetail"
        Me.gpbxDetail.Size = New System.Drawing.Size(576, 88)
        Me.gpbxDetail.TabIndex = 23
        Me.gpbxDetail.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(352, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "��ȡ���(Ԫ)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIncome
        '
        Me.txtIncome.BackColor = System.Drawing.SystemColors.Window
        Me.txtIncome.Enabled = False
        Me.txtIncome.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtIncome.Location = New System.Drawing.Point(440, 13)
        Me.txtIncome.MaxLength = 14
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(128, 21)
        Me.txtIncome.TabIndex = 3
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Location = New System.Drawing.Point(64, 13)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpDate.TabIndex = 1
        '
        'cmbxType
        '
        Me.cmbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxType.Enabled = False
        Me.cmbxType.Location = New System.Drawing.Point(240, 13)
        Me.cmbxType.Name = "cmbxType"
        Me.cmbxType.Size = New System.Drawing.Size(104, 20)
        Me.cmbxType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ժ   Ҫ"
        '
        'lblFeeType
        '
        Me.lblFeeType.Location = New System.Drawing.Point(184, 16)
        Me.lblFeeType.Name = "lblFeeType"
        Me.lblFeeType.Size = New System.Drawing.Size(56, 16)
        Me.lblFeeType.TabIndex = 2
        Me.lblFeeType.Text = "��������"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "��ȡ����"
        '
        'txtSummary
        '
        Me.txtSummary.BackColor = System.Drawing.SystemColors.Window
        Me.txtSummary.Location = New System.Drawing.Point(64, 40)
        Me.txtSummary.MaxLength = 30
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.ReadOnly = True
        Me.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSummary.Size = New System.Drawing.Size(504, 40)
        Me.txtSummary.TabIndex = 4
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(64, 352)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "�� ��(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.Enabled = False
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(152, 352)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 23)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "�� ��(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(240, 352)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "ɾ ��(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(328, 352)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(416, 352)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 9
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmChargeFeeBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 383)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gpbxDetail)
        Me.Controls.Add(Me.txtCorName)
        Me.Controls.Add(Me.txtProjectCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gpbxResult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChargeFeeBase"
        Me.Text = "��ȡ����"
        Me.Controls.SetChildIndex(Me.gpbxResult, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.Controls.SetChildIndex(Me.gpbxDetail, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.gpbxResult.ResumeLayout(False)
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxDetail.ResumeLayout(False)
        Me.gpbxDetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    '������Ŀ�׶�
    Protected Function ReturnProjectPhase() As String
        If phase Is Nothing Then
            phase = MyBase.getPhase(ProjectCode)
        End If
        Return phase
    End Function
    '��ʽ��
    Protected Overridable Function addTableStyle() As DataGridTableStyle
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "project_account_detail"
        dgts.AllowSorting = False
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col7.MappingName = "serial_num"
        col7.Width = 0
        dgts.GridColumnStyles.Add(col7)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "date"
        col3.HeaderText = "   �ɷ�����"
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "income"
        col2.HeaderText = "��ȡ���(Ԫ)"
        col2.Alignment = HorizontalAlignment.Right
        col2.NullText = ""
        col2.Width = 100
        col2.Format = "n"
        dgts.GridColumnStyles.Add(col2)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = "  ժҪ"
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 360
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col6.MappingName = "item_code"
        col6.Width = 0
        dgts.GridColumnStyles.Add(col6)
        Return dgts
    End Function

    Protected Sub GetDataSource()
        'dsItem = New DataSet()
        If item_code <> String.Empty Then
            dsAccountDetail = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' and item_type='" & item_type & "' and  item_code='" & item_code & "' ORDER BY date}")
            dsItem = gWs.GetItem(item_code, item_type)
        Else
            dsAccountDetail = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' and item_type='" & item_type & "' ORDER BY date}")
            dsItem = gWs.GetItem("%", item_type)
        End If
        btnDelete.Enabled = (dsAccountDetail.Tables("project_account_detail").Rows.Count > 0)
        btnModify.Enabled = btnDelete.Enabled
    End Sub

    Private Sub DateTimeFormatParse(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If IsDBNull(e.Value) Then
            e.Value = DateTime.Today
        End If
    End Sub

    Protected HasBinded As Boolean = False
    Protected Overridable Sub IniBindingForAccount()
        Dim dateBind As Binding = New Binding("Value", dsAccountDetail, "project_account_detail.date")
        AddHandler dateBind.Format, AddressOf DateTimeFormatParse
        AddHandler dateBind.Parse, AddressOf DateTimeFormatParse
        dtpDate.DataBindings.Add(dateBind)
        Dim moneybind As Binding = New Binding("Text", dsAccountDetail, "project_account_detail.income")
        txtIncome.DataBindings.Add(moneybind)
        AddHandler moneybind.Format, AddressOf money_format
        txtSummary.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.remark"))
        cmbxType.DataBindings.Add(New Binding("SelectedValue", dsAccountDetail, "project_account_detail.item_code"))
        HasBinded = True
    End Sub

    Protected Sub QuitBindingForAccount()
        dtpDate.DataBindings.Clear()
        txtIncome.DataBindings.Clear()
        txtSummary.DataBindings.Clear()
        cmbxType.DataBindings.Clear()
        HasBinded = False
    End Sub


    Protected Overridable Sub SetObjEnabled(ByVal IsEnabled As Boolean)
        dtpDate.Enabled = IsEnabled : cmbxType.Enabled = IsEnabled : txtIncome.Enabled = IsEnabled
        txtSummary.ReadOnly = Not IsEnabled : btnSave.Enabled = IsEnabled : dgMoney.Enabled = Not IsEnabled
    End Sub

    Protected Sub Cancel(ByVal sender As Object, ByVal e As EventArgs)
        If Not sender.GetType Is GetType(Button) Then Return

        If bmAccount.Count = 1 And CType(sender, Button) Is btnNew Then
            QuitBindingForAccount()
        End If

        'If Not (IsRefundDebt Or IsOverDueFee) Then
        If dsAccountDetail.HasChanges Then
            dsAccountDetail.RejectChanges()
        End If
        'End If

        btnDelete.Enabled = (dgMoney.CurrentRowIndex >= 0)
        btnModify.Enabled = btnDelete.Enabled
        Select Case strStatus
            Case "new" : btnNew.Text = "�� ��(&N)"
                RemoveHandler btnNew.Click, AddressOf Cancel
                AddHandler btnNew.Click, AddressOf NewEvent
            Case "modify" : btnModify.Text = "�� ��(&M)" : btnNew.Enabled = True
                RemoveHandler btnModify.Click, AddressOf Cancel
                AddHandler btnModify.Click, AddressOf ModifyEvent
            Case Else
        End Select
        SetObjEnabled(False)
        strStatus = String.Empty
        If dgMoney.VisibleRowCount < bmAccount.Count Then
            addTableStyle()
        End If
    End Sub

    Protected Function TypeDescription() As String
        Dim description As String
        If IsReviewFee Then
            description = "��ȡ�����"
        ElseIf IsGuarantyFee Then
            description = "��ȡ������"
        ElseIf IsReturnFee Then
            description = "��ȡ����"
        ElseIf IsLoanInterestFee Then  '2013-11-30 yjf add
            description = "��ȡί����Ϣ"
        ElseIf IsFinancingConsultingFee Then  '2013-11-30 yjf add
            description = "��ȡ���ʹ��ʷ�"
        ElseIf IsSecurityFee Then
            description = "��ȡ��֤��"
        ElseIf IsReturnSecurityFee Then
            description = "�˻���֤��"
        ElseIf IsOverDueFee Then
            description = "�Ǽ�������Ŀ��Ϣ"
        ElseIf IsRefundDebt Then
            description = "�ǼǴ�����Ŀ��Ϣ"
        ElseIf IsRegisterDischargeInfo Then
            description = "�Ǽ��峥��Ϣ"
        ElseIf IsReturnGuaranteeFee Then
            description = "�˻�������"
        ElseIf IsBankFee Then
            description = "�Ǽ����з���"
        ElseIf IsReturnFinancingConsultingFee Then
            description = "�����ʹ��ʷ�"
        ElseIf IsReturnReviewFee Then
            description = "�������"
        ElseIf IsReturnEvaluateFee Then
            description = "��������"
        End If
        Return description
    End Function

    Private Sub NewEvent(ByVal sender As Object, ByVal e As System.EventArgs)
        cmbxType.SelectedIndex = 0
        dtpDate.Value = SystemDate.Date
        Dim dr As DataRow = dsAccountDetail.Tables("project_account_detail").NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("date") = dtpDate.Value.Date
            .Item("phase") = ReturnProjectPhase()
            .Item("item_type") = item_type
            .Item("item_code") = cmbxType.SelectedValue
            If IsReturnSecurityFee Then '�˻���֤��
                .Item("payout") = IIf(LessMoney <> 0, LessMoney, DBNull.Value)
            ElseIf IsReturnGuaranteeFee Then
                .Item("income") = LessMoney * (-1) '�����˻������ѣ���Ĭ��Ϊ0
            ElseIf IsLoanInterestFee Then
                .Item("income") = 0 '������ȡί����Ϣ����Ĭ��Ϊ0
            Else
                .Item("income") = IIf(LessMoney <> 0, LessMoney, DBNull.Value)
            End If
            .Item("remark") = TypeDescription()
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate
        End With
        dsAccountDetail.Tables("project_account_detail").Rows.Add(dr)
        btnNew.Text = "ȡ ��(&N)"
        strStatus = "new" : btnDelete.Enabled = False : btnModify.Enabled = False
        RemoveHandler btnNew.Click, AddressOf NewEvent
        AddHandler btnNew.Click, AddressOf Cancel
        If Not HasBinded Then
            IniBindingForAccount()
        End If
        bmAccount.Position = bmAccount.Count - 1
        SetObjEnabled(True)
        'txtIncome.Text = IIf(LessMoney <> 0, LessMoney.ToString("n"), String.Empty)
        dtpDate.Focus()
    End Sub

    Private Sub ModifyEvent(ByVal sender As Object, ByVal e As System.EventArgs)
        dsAccountDetail.Tables("project_account_detail").Rows(bmAccount.Position).Item("date") = dtpDate.Value.Date
        If Not HasBinded Then
            IniBindingForAccount()
        End If
        SetObjEnabled(True)
        btnModify.Text = "ȡ ��(&M)"
        strStatus = "modify" : btnDelete.Enabled = False : btnNew.Enabled = False
        RemoveHandler btnModify.Click, AddressOf ModifyEvent
        AddHandler btnModify.Click, AddressOf Cancel
    End Sub
    Private Sub DeleteEvent(ByVal sender As Object, ByVal e As System.EventArgs)
        If SWDialogBox.MessageBox.Show("?1004", "") = DialogResult.Yes Then
            If bmAccount.Count = 1 Then
                QuitBindingForAccount()
            End If
            With dgMoney
                Dim dr As DataRow = CType(bmAccount.Current, DataRowView).Row 'dsAccountDetail.Tables("project_account_detail").Rows(bmAccount.Position)
                dr.Delete()
                If IsReturnFee Then  '����ǻ���
                    CaculateReturnFee()
                End If
                Dim strResult As String = gWs.UpdateProjectAccountDetail(dsAccountDetail.GetChanges)
                If (strResult = "1") Then
                    dsAccountDetail.AcceptChanges()
                    SWDialogBox.MessageBox.Show("$DeleteSucceed")
                Else
                    SWDialogBox.MessageBox.Show("*999", "ɾ��ʧ��", strResult, "")
                End If
            End With
            btnDelete.Enabled = (dgMoney.CurrentRowIndex >= 0)
            btnModify.Enabled = btnDelete.Enabled
            If bmAccount.Count = 0 Then
                IniBindingForAccount()
            End If
        End If
    End Sub

    Protected Overridable Sub DeleteRefresh(ByVal sender As Object, ByVal e As EventArgs)
        DeleteEvent(sender, e)
    End Sub

    Protected Overridable Function RemoveSomeRecord() As Double
        Return 0
    End Function
    '���⹤��
    Protected Overridable Sub AdditionalOperation()
        Return
    End Sub

    Protected IsWrong As Boolean = False
    Protected Sub SaveEvent(ByVal sender As Object, ByVal e As System.EventArgs)
        IsWrong = True
        If cmbxType.SelectedIndex < 0 Then
            SWDialogBox.MessageBox.Show("$1001", "ժҪ����")
            cmbxType.Focus()
            Return
        End If
        If txtIncome.Text = String.Empty Then
            SWDialogBox.MessageBox.Show("$1003", "���")
            txtIncome.Focus()
            Return
        End If
        bmAccount.Position = bmAccount.Position
        If IsReturnFee Then
            If IsDBNull(CType(bmAccount.Current, DataRowView)("type")) OrElse CType(bmAccount.Current, DataRowView)("type").ToString = String.Empty Then
                SWDialogBox.MessageBox.Show("$1001", "��  ��")
                Return
            End If
            CaculateReturnFee()
        End If
        '�̳е�������Ҫ�ڱ���ʱ�����Ĳ���
        AdditionalOperation()
        Dim strResult As String = gWs.UpdateProjectAccountDetail(dsAccountDetail.GetChanges)
        If (strResult = "1") Then
            IsWrong = False
            GetDataSource()
            QuitBindingForAccount()
            bmAccount = BindingContext(dsAccountDetail, "project_account_detail")
            RemoveSomeRecord()
            IniBindingForAccount()
            dgMoney.DataMember = "project_account_detail"
            dgMoney.DataSource = dsAccountDetail

            If sender Is Nothing Then Return
            If sender.GetType Is GetType(Button) Then
                If CType(sender, Button).Name <> "btnReport" Then
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                End If
            End If
        Else
            SWDialogBox.MessageBox.Show("*999", "����ʧ��", strResult, "")
            IsWrong = True
            Return
        End If
        bmAccount.Position = bmAccount.Position
        If txtIncome.Text.StartsWith("-") Then
            txtIncome.Text = txtIncome.Text.Remove(0, 1)
        End If
        Cancel(sender, e)
    End Sub
    'Dim hitArea As DataGrid.HitTestInfo
    Private Sub dgMoney_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgMoney.MouseUp
        With dgMoney
            If .CurrentRowIndex < 0 Then
                Return
            End If
            .Select(.CurrentRowIndex)
            If Not HasBinded Then
                IniBindingForAccount()
                If txtIncome.Text.StartsWith("-") Then
                    txtIncome.Text = txtIncome.Text.Remove(0, 1)
                End If
            End If
        End With
    End Sub

    '������������Ϊ���������ȷ����ȷ

    Private Sub txt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIncome.Enter
        Money.Money_Enter(sender, e)
    End Sub
    Private Sub txt_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIncome.KeyPress
        Money.Money_KeyPress(sender, e)
    End Sub

    Private Sub txt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIncome.Leave
        If txtIncome.Text = String.Empty Then
            txtIncome.Text = "0"
            Return
        End If
        Try
            If CDbl(txtIncome.Text) > MaxChargeFee Then
                SWDialogBox.MessageBox.Show("$X032", MaxChargeFee.ToString("n"))
                'MessageBox.Show("����ѳ���" & MaxChargeFee.ToString("c", CGFormatInfo), "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIncome.Text = String.Empty
                Return
            End If
        Catch
            CType(sender, TextBox).Text = String.Empty
        End Try
        Money.Money_Leave(sender, e)
    End Sub

    Protected Overridable Sub Affirm(ByVal ItemType As String, ByVal ItemCode As String)

    End Sub
    '�̳е����������ύǰ���Ķ���
    Protected Overridable Function OtherOperationSuccess() As Boolean
        Return True
    End Function

    Protected Overridable Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "�ύ")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        If strStatus <> String.Empty Then
            SaveEvent(Nothing, Nothing)
            If IsWrong Then Return
        End If
        If IsReturnGuaranteeFee Then
            If LessMoney < 0 Then '�˻�����>���ձ���
                SWDialogBox.MessageBox.Show("$X025")
                Return
            End If

        ElseIf LessMoney > 0 And Not IsReturnFee And Not IsLoanInterestFee Then
            'If IsReturnFee Then
            '    MessageBox.Show("����������©")
            'Else
            SWDialogBox.MessageBox.Show("$X025")
            'End If
            Return
        End If

        If Not OtherOperationSuccess() Then
            Return
        End If

        Dim strSuccess As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If strSuccess = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            'Affirm(String.Empty, String.Empty)
            If IsGuarantyFee Then
                Affirm("44", "003")
            ElseIf IsReviewFee Then
                Affirm("44", "002")
            ElseIf IsSecurityFee Then
                Affirm("44", "012")
            ElseIf IsFinancingConsultingFee Then '2013-11-30 yjf add
                Affirm("44", "015")
            End If
            MyBase.raiseCommitSucceed()
            RemoveHandler MyBase.Closing, AddressOf frmChargeFeeBase_Closing
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "�ύʧ��", strSuccess, "")
        End If
    End Sub

    Private Sub frmChargeFeeBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProjectCode = MyBase.getProjectCode
        WorkFlowID = MyBase.getWorkFlowID
        TaskID = MyBase.getTaskID
        CorporationName = MyBase.getCorporationName
        AddHandler btnDelete.Click, AddressOf DeleteRefresh
        AddHandler btnSave.Click, AddressOf SaveEvent
        AddHandler btnNew.Click, AddressOf NewEvent
        AddHandler btnModify.Click, AddressOf ModifyEvent
        AddHandler btnCommit.Click, AddressOf btnCommit_Click
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub

    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If strStatus <> "" Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003")
            If QueryResult = DialogResult.Yes Then
                SaveEvent(Nothing, Nothing)
                If IsWrong Then Return False
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmChargeFeeBase_Closing
        Close()
        Return True
    End Function

    Private Sub frmChargeFeeBase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MyBase.setEnterKeyPress(sender, e)
    End Sub

    Private Sub frmChargeFeeBase_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub

    Private Sub CaculateReturnFee()
        Dim dr As DataRow
        Dim dv As DataView = New DataView(dsAccountDetail.Tables("project_account_detail"), "", "date ASC", DataViewRowState.CurrentRows)
        If dv.Count > 0 Then
            Dim i As Int16
            Dim oDate As Date = DateTime.Parse(dv(0)("date"))
            dv(0)("total_sum") = dv(0)("income")
            For i = 1 To dv.Count - 1
                If DateTime.Parse(dv(i)("date")).Date > oDate.Date Then
                    dv(i)("total_sum") = dv(i - 1)("total_sum") + dv(i)("income") + 0
                ElseIf DateTime.Parse(dv(i)("date")).Date = oDate.Date Then
                    dv(i)("total_sum") = dv(i - 1)("total_sum") + dv(i)("income") + 0
                    'dv(i - 1)("total_sum") = dv(i)("total_sum")
                End If
                oDate = DateTime.Parse(dv(i)("date"))
            Next
        End If
    End Sub
End Class
