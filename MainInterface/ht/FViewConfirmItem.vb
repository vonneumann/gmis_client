
'�鿴����������
Public Class FViewConfirmItem
    Inherits Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    Public Sub New(ByVal ProjectCode As String, ByVal ItemCode As String)
        Me.New()

        _ProjectCode = ProjectCode
        _ItemCode = ItemCode
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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grdConfirmItem As System.Windows.Forms.DataGrid
    Friend WithEvents tsDoc As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col00 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col01 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col02 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col03 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents tsFee As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tsCooperateOrganization As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tsGuaranteeForm As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col30 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col31 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grdGuaranteeFormAdditional As System.Windows.Forms.DataGrid
    Friend WithEvents tsGuaranteeFormAdditional As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col40 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents col41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FViewConfirmItem))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grdConfirmItem = New System.Windows.Forms.DataGrid()
        Me.tsDoc = New System.Windows.Forms.DataGridTableStyle()
        Me.col00 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col01 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col02 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col03 = New System.Windows.Forms.DataGridBoolColumn()
        Me.tsFee = New System.Windows.Forms.DataGridTableStyle()
        Me.col10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.tsCooperateOrganization = New System.Windows.Forms.DataGridTableStyle()
        Me.col20 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col21 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col22 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col23 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col24 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col25 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.tsGuaranteeForm = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col30 = New System.Windows.Forms.DataGridBoolColumn()
        Me.col31 = New System.Windows.Forms.DataGridBoolColumn()
        Me.col32 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col33 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col34 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col35 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col36 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grdGuaranteeFormAdditional = New System.Windows.Forms.DataGrid()
        Me.tsGuaranteeFormAdditional = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col40 = New System.Windows.Forms.DataGridBoolColumn()
        Me.col41 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col42 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col43 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        CType(Me.grdConfirmItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGuaranteeFormAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(616, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "�� ��(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdConfirmItem
        '
        Me.grdConfirmItem.CaptionVisible = False
        Me.grdConfirmItem.DataMember = ""
        Me.grdConfirmItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdConfirmItem.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdConfirmItem.Location = New System.Drawing.Point(8, 8)
        Me.grdConfirmItem.Name = "grdConfirmItem"
        Me.grdConfirmItem.ReadOnly = True
        Me.grdConfirmItem.Size = New System.Drawing.Size(688, 240)
        Me.grdConfirmItem.TabIndex = 1
        Me.grdConfirmItem.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsDoc, Me.tsFee, Me.tsCooperateOrganization, Me.tsGuaranteeForm})
        '
        'tsDoc
        '
        Me.tsDoc.DataGrid = Me.grdConfirmItem
        Me.tsDoc.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col00, Me.col01, Me.col02, Me.col03})
        Me.tsDoc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsDoc.MappingName = "TProjectDocument"
        '
        'col00
        '
        Me.col00.Format = ""
        Me.col00.FormatInfo = Nothing
        Me.col00.HeaderText = "��������"
        Me.col00.MappingName = "doc_name"
        Me.col00.NullText = ""
        Me.col00.Width = 410
        '
        'col01
        '
        Me.col01.Format = ""
        Me.col01.FormatInfo = Nothing
        Me.col01.HeaderText = "������"
        Me.col01.MappingName = "check_person"
        Me.col01.NullText = ""
        Me.col01.Width = 60
        '
        'col02
        '
        Me.col02.Format = "yyyy��MM��dd��"
        Me.col02.FormatInfo = Nothing
        Me.col02.HeaderText = "��������"
        Me.col02.MappingName = "check_date"
        Me.col02.NullText = ""
        Me.col02.Width = 95
        '
        'col03
        '
        Me.col03.AllowNull = False
        Me.col03.FalseValue = False
        Me.col03.HeaderText = "�Ƿ�ؼ�"
        Me.col03.MappingName = "is_important"
        Me.col03.NullValue = False
        Me.col03.TrueValue = True
        Me.col03.Width = 60
        '
        'tsFee
        '
        Me.tsFee.DataGrid = Me.grdConfirmItem
        Me.tsFee.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col10, Me.col11, Me.col12, Me.col13, Me.col14, Me.col15, Me.col16})
        Me.tsFee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsFee.MappingName = "project_account_detail"
        '
        'col10
        '
        Me.col10.Format = ""
        Me.col10.FormatInfo = Nothing
        Me.col10.HeaderText = "��Ŀ����"
        Me.col10.MappingName = "project_code"
        Me.col10.NullText = ""
        Me.col10.Width = 68
        '
        'col11
        '
        Me.col11.Format = "yyyy��MM��dd��"
        Me.col11.FormatInfo = Nothing
        Me.col11.HeaderText = "�շ�����"
        Me.col11.MappingName = "date"
        Me.col11.NullText = ""
        Me.col11.Width = 95
        '
        'col12
        '
        Me.col12.Format = ""
        Me.col12.FormatInfo = Nothing
        Me.col12.HeaderText = "�շ���Ŀ"
        Me.col12.MappingName = "item_name"
        Me.col12.NullText = ""
        Me.col12.Width = 80
        '
        'col13
        '
        Me.col13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.col13.Format = "c"
        Me.col13.FormatInfo = CType(resources.GetObject("col13.FormatInfo"), System.Globalization.NumberFormatInfo)
        Me.col13.HeaderText = "�շѽ��(Ԫ)"
        Me.col13.MappingName = "income"
        Me.col13.NullText = ""
        Me.col13.Width = 90
        '
        'col14
        '
        Me.col14.Format = ""
        Me.col14.FormatInfo = Nothing
        Me.col14.HeaderText = "��ע"
        Me.col14.MappingName = "remark"
        Me.col14.NullText = ""
        Me.col14.Width = 250
        '
        'col15
        '
        Me.col15.Format = ""
        Me.col15.FormatInfo = Nothing
        Me.col15.HeaderText = "������"
        Me.col15.MappingName = "create_person"
        Me.col15.NullText = ""
        Me.col15.Width = 60
        '
        'col16
        '
        Me.col16.Format = "yyyy��MM��dd��"
        Me.col16.FormatInfo = Nothing
        Me.col16.HeaderText = "����ʱ��"
        Me.col16.MappingName = "create_date"
        Me.col16.NullText = ""
        Me.col16.Width = 95
        '
        'tsCooperateOrganization
        '
        Me.tsCooperateOrganization.DataGrid = Me.grdConfirmItem
        Me.tsCooperateOrganization.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col20, Me.col21, Me.col22, Me.col23, Me.col24, Me.col25})
        Me.tsCooperateOrganization.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsCooperateOrganization.MappingName = "TCooperateOrganizationOpinion"
        '
        'col20
        '
        Me.col20.Format = ""
        Me.col20.FormatInfo = Nothing
        Me.col20.HeaderText = "��������"
        Me.col20.MappingName = "cooperate_organization"
        Me.col20.NullText = ""
        Me.col20.Width = 120
        '
        'col21
        '
        Me.col21.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.col21.Format = "c"
        Me.col21.FormatInfo = CType(resources.GetObject("col21.FormatInfo"), System.Globalization.NumberFormatInfo)
        Me.col21.HeaderText = "�Ƽ����(��)"
        Me.col21.MappingName = "recommend_sum"
        Me.col21.NullText = ""
        Me.col21.Width = 90
        '
        'col22
        '
        Me.col22.Format = ""
        Me.col22.FormatInfo = Nothing
        Me.col22.HeaderText = "�Ƽ����"
        Me.col22.MappingName = "opinion"
        Me.col22.NullText = ""
        Me.col22.Width = 250
        '
        'col23
        '
        Me.col23.Format = "yyyy��MM��dd��"
        Me.col23.FormatInfo = Nothing
        Me.col23.HeaderText = "�Ƽ�����"
        Me.col23.MappingName = "recommend_date"
        Me.col23.NullText = ""
        Me.col23.Width = 95
        '
        'col24
        '
        Me.col24.Format = ""
        Me.col24.FormatInfo = Nothing
        Me.col24.HeaderText = "��¼��"
        Me.col24.MappingName = "create_person"
        Me.col24.NullText = ""
        Me.col24.Width = 60
        '
        'col25
        '
        Me.col25.Format = "yyyy��MM��dd��"
        Me.col25.FormatInfo = Nothing
        Me.col25.HeaderText = "��¼����"
        Me.col25.MappingName = "create_date"
        Me.col25.NullText = ""
        Me.col25.Width = 95
        '
        'tsGuaranteeForm
        '
        Me.tsGuaranteeForm.DataGrid = Me.grdConfirmItem
        Me.tsGuaranteeForm.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.col30, Me.col31, Me.col32, Me.col33, Me.col34, Me.col35, Me.col36})
        Me.tsGuaranteeForm.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsGuaranteeForm.MappingName = "TProjectGuaranteeForm"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "��Ŀ����"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 68
        '
        'col30
        '
        Me.col30.AllowNull = False
        Me.col30.FalseValue = False
        Me.col30.HeaderText = "�Ƿ����"
        Me.col30.MappingName = "is_used"
        Me.col30.NullValue = CType(resources.GetObject("col30.NullValue"), System.DBNull)
        Me.col30.TrueValue = True
        Me.col30.Width = 65
        '
        'col31
        '
        Me.col31.AllowNull = False
        Me.col31.FalseValue = False
        Me.col31.HeaderText = "�Ƿ���ȷ��"
        Me.col31.MappingName = "is_checked"
        Me.col31.NullValue = CType(resources.GetObject("col31.NullValue"), System.DBNull)
        Me.col31.TrueValue = True
        Me.col31.Width = 75
        '
        'col32
        '
        Me.col32.Format = ""
        Me.col32.FormatInfo = Nothing
        Me.col32.HeaderText = "��������ʽ"
        Me.col32.MappingName = "guarantee_form"
        Me.col32.ReadOnly = True
        Me.col32.Width = 90
        '
        'col33
        '
        Me.col33.Format = ""
        Me.col33.FormatInfo = Nothing
        Me.col33.HeaderText = "��������"
        Me.col33.MappingName = "guaranty_name"
        Me.col33.NullText = ""
        Me.col33.ReadOnly = True
        Me.col33.Width = 90
        '
        'col34
        '
        Me.col34.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.col34.Format = ""
        Me.col34.FormatInfo = Nothing
        Me.col34.HeaderText = "����"
        Me.col34.MappingName = "num"
        Me.col34.ReadOnly = True
        Me.col34.Width = 30
        '
        'col35
        '
        Me.col35.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.col35.Format = "n"
        Me.col35.FormatInfo = Nothing
        Me.col35.HeaderText = "�������(Ԫ) "
        Me.col35.MappingName = "guarantee_sum"
        Me.col35.NullText = ""
        Me.col35.ReadOnly = True
        Me.col35.Width = 90
        '
        'col36
        '
        Me.col36.Format = ""
        Me.col36.FormatInfo = Nothing
        Me.col36.HeaderText = "����"
        Me.col36.MappingName = "description"
        Me.col36.NullText = ""
        Me.col36.Width = 340
        '
        'grdGuaranteeFormAdditional
        '
        Me.grdGuaranteeFormAdditional.CaptionVisible = False
        Me.grdGuaranteeFormAdditional.DataMember = ""
        Me.grdGuaranteeFormAdditional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGuaranteeFormAdditional.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdGuaranteeFormAdditional.Location = New System.Drawing.Point(8, 256)
        Me.grdGuaranteeFormAdditional.Name = "grdGuaranteeFormAdditional"
        Me.grdGuaranteeFormAdditional.ReadOnly = True
        Me.grdGuaranteeFormAdditional.Size = New System.Drawing.Size(688, 0)
        Me.grdGuaranteeFormAdditional.TabIndex = 2
        Me.grdGuaranteeFormAdditional.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsGuaranteeFormAdditional})
        Me.grdGuaranteeFormAdditional.Visible = False
        '
        'tsGuaranteeFormAdditional
        '
        Me.tsGuaranteeFormAdditional.DataGrid = Me.grdGuaranteeFormAdditional
        Me.tsGuaranteeFormAdditional.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn2, Me.col40, Me.col41, Me.col42, Me.col43})
        Me.tsGuaranteeFormAdditional.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsGuaranteeFormAdditional.MappingName = "TProjectGuaranteeFormAdditional"
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "��Ŀ����"
        Me.DataGridTextBoxColumn2.MappingName = "project_code"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 68
        '
        'col40
        '
        Me.col40.AllowNull = False
        Me.col40.FalseValue = False
        Me.col40.HeaderText = "�Ƿ���ȷ��"
        Me.col40.MappingName = "is_checked"
        Me.col40.NullValue = CType(resources.GetObject("col40.NullValue"), System.DBNull)
        Me.col40.TrueValue = True
        Me.col40.Width = 75
        '
        'col41
        '
        Me.col41.Format = ""
        Me.col41.FormatInfo = Nothing
        Me.col41.HeaderText = "��������ʽ"
        Me.col41.MappingName = "guarantee_form"
        Me.col41.NullText = ""
        Me.col41.ReadOnly = True
        Me.col41.Width = 90
        '
        'col42
        '
        Me.col42.Format = ""
        Me.col42.FormatInfo = Nothing
        Me.col42.HeaderText = "��������"
        Me.col42.MappingName = "guaranty_name"
        Me.col42.NullText = ""
        Me.col42.ReadOnly = True
        Me.col42.Width = 90
        '
        'col43
        '
        Me.col43.Format = ""
        Me.col43.FormatInfo = Nothing
        Me.col43.HeaderText = "���ӷ�������ʽ"
        Me.col43.MappingName = "additional_guarantee_form"
        Me.col43.NullText = ""
        Me.col43.ReadOnly = True
        Me.col43.Width = 120
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(8, 248)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(688, 8)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        Me.Splitter1.Visible = False
        '
        'FViewConfirmItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(704, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdGuaranteeFormAdditional, Me.Splitter1, Me.grdConfirmItem, Me.btnExit})
        Me.DockPadding.Bottom = 30
        Me.DockPadding.Left = 8
        Me.DockPadding.Right = 8
        Me.DockPadding.Top = 8
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FViewConfirmItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.grdConfirmItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGuaranteeFormAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private _ProjectCode, _ItemCode As String
    Private dsTemp As DataSet

    Private Sub FViewConfirmItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.SetData()
            Me.GetData()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '����ö�ٱ�����
    Enum ItemType
        Empty
        Doc
        Fee
        CooperateOrganization '��ӦΪcooperate_organization_opinion��
        GuaranteeForm
        Fraternity
    End Enum

    Private _Type As ItemType  '�����Ƿ���ʾ�����ĵ����Ƿ��ã����Ƿ�������

    Private Sub SetData()
        Select Case _ItemCode
            Case "001"                '��Ŀ����������
                Me._Type = ItemType.Doc
                Me.col01.MappingName = "affirm_person"
                Me.col01.HeaderText = "ȷ����"
                Me.col02.MappingName = "affirm_date"
                Me.col02.HeaderText = "ȷ������"
            Case "002"                '�������ȡ
                Me._Type = ItemType.Fee
            Case "003"               '��������ȡ
                Me._Type = ItemType.Fee
            Case "004"               '��ͬ�ı�������
                Me._Type = ItemType.Doc
                Me.col03.Width = 0
            Case "005"               '��Ŀ�ѻ�ǩ���
                'Case "006"               '��Ѻ�Ǽ��Ѱ��ײ���������ı�������
                '    Me._Type = ItemType.GuaranteeForm
                'Case "007"               '��Ѻ�Ǽ��Ѱ��ײ���������ı�������
                '    Me._Type = ItemType.GuaranteeForm
            Case "008"               '��Ѻ�������ﱣ���Ѱ��ײ�ע������Ϊ��һ������(��������ȷ��)
                Me._Type = ItemType.GuaranteeForm
                Me.Text = "��������ȷ��"
            Case "009"               '�Ѱ���Ʋ�����������Ȩ����֤��(Ԥ�䵱����ȷ��)
                Me._Type = ItemType.GuaranteeForm
                Me.Text = "Ԥ�䵱����ȷ��"
            Case "010"               '�������Ƽ�����
                Me._Type = ItemType.CooperateOrganization
            Case "011"               '��������������ȷ��
                Me._Type = ItemType.Fraternity
                Me.col03.MappingName = "is_checked"
                Me.col03.HeaderText = "��ȷ��"
            Case "012"               '��֤��������
                Me._Type = ItemType.Fee
                'Case "013"               '�������ȷ��
                '    Me._Type = ItemType.GuaranteeForm
            Case "014"               '�����ı�ȷ��
                Me._Type = ItemType.GuaranteeForm
                Me.Text = "�����ı�ȷ��"
        End Select
    End Sub

    Private Sub GetData()
        Dim strSql As String = ""
        Select Case _ItemCode
            Case "001"               '��Ŀ����������
                strSql = "item_type = '41' OR item_type = '42'"
            Case "002"               '�������ȡ
                strSql = "item_type = '31' AND item_code = '001'"
            Case "003"               '��������ȡ
                strSql = "item_type = '31' AND item_code = '002'"
            Case "004"               '��ͬ�ı�������
                strSql = "item_type = '43'"
            Case "011"               '��������������ȷ��
                strSql = "item_type = '48'"
            Case "012"               '��֤����ȡȷ��
                strSql = "item_type = '34' AND item_code = '009'"
        End Select

        Dim dv As DataView
        Select Case Me._Type
            Case ItemType.Doc                   '�����嵥,���ر�ΪTProjectDocument
                Me.Text = "����"
                Me.grdConfirmItem.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
                dv = gWs.GetProjectDocumentByCondition("{item_type in ('41','42','43','48') AND check_person IS NOT NULL AND project_code = '" & _ProjectCode & "'}").Tables(0).DefaultView
                Me.grdConfirmItem.DataSource = dv
                dv.RowFilter = strSql
            Case ItemType.Fee                   '�շ��嵥,project_account_detail
                Me.Text = "�շ�"
                Me.grdConfirmItem.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
                dv = Me.GetFee().Tables(0).DefaultView
                Me.grdConfirmItem.DataSource = dv
                dv.RowFilter = strSql
            Case ItemType.CooperateOrganization '��ȡ�������Ƽ����,���ر���ΪTCooperateOrganizationOpinion
                Me.Text = "������"
                Me.grdConfirmItem.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
                dv = gWs.GetCooperateOrganizationOpinion("{project_code = '" & _ProjectCode & "'}").Tables(0).DefaultView
                Me.grdConfirmItem.DataSource = dv
                dv.RowFilter = strSql
            Case ItemType.GuaranteeForm  '   ���������嵥 
                Me.grdGuaranteeFormAdditional.Visible = True
                Me.Splitter1.Visible = True
                Me.Height += Me.Height / 2
                Me.Top = (Screen.AllScreens(0).WorkingArea.Height - Me.Height) / 2
                dsTemp = Me.GetGuaranteeForm()
                Me.grdConfirmItem.DataSource = dsTemp.Tables("TProjectGuaranteeForm")
                Me.grdGuaranteeFormAdditional.DataSource = dsTemp.Tables("TProjectGuaranteeFormAdditional")
            Case ItemType.Fraternity   '���������
                Me.Text = "����"
                Me.grdConfirmItem.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
                Me.grdConfirmItem.DataSource = Me.GetFraternity.Tables(0)
        End Select
    End Sub

    '    �շ��嵥
    Private Function GetFee() As DataSet
        dsTemp = gWs.GetProjectAccountDetailInfo("{project_code='" & _ProjectCode & "' AND income IS NOT NULL}")
        dsTemp.Merge(gWs.GetItemEx("{item_type in ('31', '34')}").Tables("TItem"))
        Dim dc0() As DataColumn = {dsTemp.Tables(0).Columns("item_type"), dsTemp.Tables(0).Columns("item_code")}
        Dim dc1() As DataColumn = {dsTemp.Tables(1).Columns("item_type"), dsTemp.Tables(1).Columns("item_code")}
        dsTemp.Relations.Add("RItem", dc1, dc0)
        dsTemp.Tables(0).Columns.Add("item_name", GetType(String), "parent(RItem).item_name")
        Return dsTemp
    End Function
    '�������������嵥
    Private Function GetGuaranteeForm() As DataSet
        dsTemp = gWs.GetProjectGuaranteeFormAdditional(Me._ProjectCode, "44", Me._ItemCode)

        Dim dtItemType As DataTable = gWs.GetItemType("%").Tables(0)
        Dim dt As DataTable
        Dim dr As DataRow
        Dim drs() As DataRow
        For Each dt In dsTemp.Tables
            dt.Columns.Add("guaranty_name", GetType(String))
            For Each dr In dt.Rows
                If Not IsDBNull(dr("guaranty")) Then
                    drs = dtItemType.Select("item_type='" & dr("guaranty") & "'")
                    If Not drs.Length = 0 Then
                        dr("guaranty_name") = drs(0)("type_name")
                    End If
                End If
                If IsDBNull(dr("is_checked")) Then
                    dr("is_checked") = False
                End If
            Next
        Next
        Return dsTemp
    End Function
    '��ȡ�����������Ϣ
    Private Function GetFraternity() As DataSet
        dsTemp = gWs.GetProjectDocumentByCondition("{project_code = '" & _ProjectCode & "' AND item_type ='48' AND check_person IS NOT NULL}")
        dsTemp.Tables(0).Columns.Add("is_checked", GetType(Boolean), "IIf(check_person is null, false, true)")
        dsTemp.Merge(gWs.GetItemEx("{item_type = '48'}").Tables("TItem"))
        Dim i As Integer
        For i = 0 To dsTemp.Tables(1).Rows.Count - 1
            With dsTemp.Tables(1).Rows(i)
                If dsTemp.Tables(0).Select("item_code = '" & .Item("item_code") & "'").Length = 0 Then
                    Dim dr As DataRow = dsTemp.Tables(0).NewRow()
                    With dr
                        .Item("doc_name") = dsTemp.Tables(1).Rows(i).Item("item_name")
                        .Item("is_checked") = False
                    End With
                    dsTemp.Tables(0).Rows.Add(dr)
                End If
            End With
        Next
        Return dsTemp
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

End Class
