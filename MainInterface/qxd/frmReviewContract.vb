

Public Class frmReviewContract
    Inherits MainInterface.frmMaterial

    Private strProjectCode As String
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String
    Private strDir As String = "Document\Contract"

    Private strAffirmType As String = "53"
    Private strAffirmCode As String = "002"
    Private strItemType As String = "53" 'ǩԼ�׶����
    Private strItemCode As String = "002" '��ͬ������

    Private dsMaterial As DataSet
    Private strFinishedFlag As String = ""
    Private isCommit As Boolean = False '�Ƿ����ύ������ǣ����ڱ���ɹ�ʱ������ʾ�ɹ���Ϣ
    Private isLoad As Boolean = False '���˳�ʱ�ж�,�Ƿ��Ǹ�load,û���κ�������ť����

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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtOpinion As System.Windows.Forms.RichTextBox
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents btnConclusion As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReviewContract))
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbConclusion = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtOpinion = New System.Windows.Forms.RichTextBox()
        Me.btnConclusion = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaterial
        '
        Me.txtMaterial.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtMaterial.Location = New System.Drawing.Point(64, 17)
        Me.txtMaterial.MaxLength = 100
        Me.txtMaterial.Size = New System.Drawing.Size(288, 21)
        Me.txtMaterial.TabIndex = 0
        Me.txtMaterial.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOpinion, Me.Label14, Me.cmbConclusion, Me.Label13})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox3.Size = New System.Drawing.Size(608, 144)
        Me.GroupBox3.Visible = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Size = New System.Drawing.Size(602, 216)
        Me.Panel1.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Size = New System.Drawing.Size(608, 240)
        Me.GroupBox2.Visible = True
        '
        'Label5
        '
        Me.Label5.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label5.Visible = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(232, -72)
        Me.Label7.Size = New System.Drawing.Size(56, 37)
        Me.Label7.Visible = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(280, -32)
        Me.Label4.Size = New System.Drawing.Size(64, 32)
        Me.Label4.Visible = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(232, -48)
        Me.Label9.Size = New System.Drawing.Size(32, 37)
        Me.Label9.Visible = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, -32)
        Me.Label3.Size = New System.Drawing.Size(40, 32)
        Me.Label3.Visible = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(416, -72)
        Me.Label8.Size = New System.Drawing.Size(56, 37)
        Me.Label8.Visible = True
        '
        'dgMaterial
        '
        Me.dgMaterial.AccessibleName = "DataGrid"
        Me.dgMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMaterial.Size = New System.Drawing.Size(602, 216)
        Me.dgMaterial.TabIndex = 2
        Me.dgMaterial.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgMaterial.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(216, -48)
        Me.Label6.Size = New System.Drawing.Size(56, 49)
        Me.Label6.Visible = True
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(80, 160)
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Size = New System.Drawing.Size(504, 24)
        Me.txtRemark.TabIndex = 2
        Me.txtRemark.Visible = True
        '
        'dateCheck
        '
        Me.dateCheck.Location = New System.Drawing.Point(464, -40)
        Me.dateCheck.Value = New Date(2003, 4, 11, 11, 6, 47, 125)
        Me.dateCheck.Visible = True
        '
        'txtName
        '
        Me.txtName.Size = New System.Drawing.Size(224, 21)
        Me.txtName.Visible = True
        '
        'cmbType
        '
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Location = New System.Drawing.Point(88, -32)
        Me.cmbType.TabIndex = 0
        Me.cmbType.Text = "��ͬ�б�"
        Me.cmbType.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'chbFile
        '
        Me.chbFile.Location = New System.Drawing.Point(488, -72)
        Me.chbFile.Size = New System.Drawing.Size(24, 38)
        Me.chbFile.Visible = True
        '
        'txtCode
        '
        Me.txtCode.Visible = True
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(288, -40)
        Me.txtPerson.Visible = True
        '
        'cmbContent
        '
        Me.cmbContent.DropDownWidth = 192
        Me.cmbContent.ItemHeight = 12
        Me.cmbContent.Location = New System.Drawing.Point(368, -32)
        Me.cmbContent.Size = New System.Drawing.Size(192, 20)
        Me.cmbContent.TabIndex = 1
        Me.cmbContent.Visible = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 160)
        Me.Label11.Visible = True
        '
        'chbCheck
        '
        Me.chbCheck.Location = New System.Drawing.Point(288, -72)
        Me.chbCheck.Size = New System.Drawing.Size(24, 38)
        Me.chbCheck.Visible = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(416, -48)
        Me.Label10.Size = New System.Drawing.Size(40, 37)
        Me.Label10.Visible = True
        '
        'chbImportant
        '
        Me.chbImportant.Location = New System.Drawing.Point(288, -48)
        Me.chbImportant.Size = New System.Drawing.Size(24, 49)
        Me.chbImportant.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(462, 440)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.dgMaterial
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridBoolColumn1, Me.DataGridBoolColumn2, Me.DataGridBoolColumn3, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectDocument"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "��������"
        Me.DataGridTextBoxColumn1.MappingName = "doc_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 200
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "ȷ��"
        Me.DataGridBoolColumn1.MappingName = "is_check"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 0
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "���"
        Me.DataGridBoolColumn2.MappingName = "is_affirm"
        Me.DataGridBoolColumn2.NullText = ""
        Me.DataGridBoolColumn2.NullValue = CType(resources.GetObject("DataGridBoolColumn2.NullValue"), System.DBNull)
        Me.DataGridBoolColumn2.TrueValue = True
        Me.DataGridBoolColumn2.Width = 75
        '
        'DataGridBoolColumn3
        '
        Me.DataGridBoolColumn3.AllowNull = False
        Me.DataGridBoolColumn3.FalseValue = False
        Me.DataGridBoolColumn3.HeaderText = "���ĵ�"
        Me.DataGridBoolColumn3.MappingName = "is_file"
        Me.DataGridBoolColumn3.NullText = ""
        Me.DataGridBoolColumn3.NullValue = CType(resources.GetObject("DataGridBoolColumn3.NullValue"), System.DBNull)
        Me.DataGridBoolColumn3.ReadOnly = True
        Me.DataGridBoolColumn3.TrueValue = True
        Me.DataGridBoolColumn3.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "��ע"
        Me.DataGridTextBoxColumn2.MappingName = "remark"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "ȷ����"
        Me.DataGridTextBoxColumn3.MappingName = "check_person"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 50
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "����"
        Me.DataGridTextBoxColumn4.MappingName = "check_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(379, 440)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 5
        Me.btnCommit.Text = "�� ��(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Bitmap)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(197, 440)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = "�鿴��ͬ(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label13.Location = New System.Drawing.Point(448, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 23)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "��˽���"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbConclusion
        '
        Me.cmbConclusion.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmbConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConclusion.Location = New System.Drawing.Point(504, 17)
        Me.cmbConclusion.Name = "cmbConclusion"
        Me.cmbConclusion.Size = New System.Drawing.Size(96, 20)
        Me.cmbConclusion.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 23)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "������"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(296, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOpinion
        '
        Me.txtOpinion.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtOpinion.Location = New System.Drawing.Point(65, 48)
        Me.txtOpinion.MaxLength = 250
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(535, 88)
        Me.txtOpinion.TabIndex = 3
        Me.txtOpinion.Text = ""
        '
        'btnConclusion
        '
        Me.btnConclusion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConclusion.Image = CType(resources.GetObject("btnConclusion.Image"), System.Drawing.Bitmap)
        Me.btnConclusion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConclusion.ImageIndex = 25
        Me.btnConclusion.ImageList = Me.ImageListBasic
        Me.btnConclusion.Location = New System.Drawing.Point(87, 440)
        Me.btnConclusion.Name = "btnConclusion"
        Me.btnConclusion.Size = New System.Drawing.Size(104, 24)
        Me.btnConclusion.TabIndex = 7
        Me.btnConclusion.Text = "��������(&R)"
        Me.btnConclusion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmReviewContract
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(626, 471)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.txtName, Me.Label1, Me.txtCode, Me.btnExit, Me.GroupBox3, Me.GroupBox2, Me.btnConclusion, Me.btnSave, Me.btnView, Me.btnCommit})
        Me.Name = "frmReviewContract"
        Me.Text = "��ͬ���"
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load()
    Private Sub frmReviewContract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoad = True
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser()
        Me.strPhase = getPhase(strProjectCode)
        Me.txtCode.Text = strProjectCode
        Me.txtName.Text = strCorporationName
        setTextBox(False)
        Me.Label4.Visible = False
        Me.cmbContent.Visible = False
        Me.Label6.Visible = False
        Me.chbImportant.Visible = False
        addCmbConclusion()
        Me.dsMaterial = setDgDataSource(strProjectCode, False)
        If Not Me.dsMaterial Is Nothing Then
            addStyle(Me.dsMaterial)
            'Me.dsMaterial.AcceptChanges() '2003-7-14 closed ��Ϊ�ڱ���ʱ����˴�û�б��棬�����ˡ�����Դ������һ�û����á�����
        End If
        'setButton()
        getOpinion()
    End Sub
    '���dataGrid��style
    Private Sub addStyle(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TProjectDocument"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TProjectDocument").Columns.Count
        Dim aColumnTextColumn As DataGridColoredBoolColumn
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)
        Dim i As Integer

        Dim column_1 As New DataGridTextBoxColumn()
        column_1.Width = 200
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "��������"
        column_1.MappingName = "doc_name"
        tableStyle.GridColumnStyles.Add(column_1)

        aColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        aColumnTextColumn.HeaderText = "���"
        aColumnTextColumn.AllowNull = False
        aColumnTextColumn.MappingName = "is_affirm"
        tableStyle.GridColumnStyles.Add(aColumnTextColumn)

        Dim column_2 As New DataGridBoolColumn()
        column_2.AllowNull = False
        column_2.ReadOnly = True
        column_2.HeaderText = "���ĵ�"
        column_2.MappingName = "is_file"
        tableStyle.GridColumnStyles.Add(column_2)

        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.Width = 0
        column_3.NullText = ""
        column_3.HeaderText = "˵��"
        column_3.MappingName = "remark"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = ""
        column_4.HeaderText = "ȷ����"
        column_4.MappingName = "check_person"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = ""
        column_5.HeaderText = "����"
        column_5.MappingName = "check_date"
        tableStyle.GridColumnStyles.Add(column_5)

        Me.dgMaterial.TableStyles.Clear()
        Me.dgMaterial.TableStyles.Add(tableStyle)
    End Sub
    '
    '������˽��۵�Item 
    '
    Private Sub addCmbConclusion()
        Dim i As Integer
        Dim arList As New ArrayList()
        arList = GetFinishedFlag(strProjectCode, strWorkFlowID, strTaskID)
        If Not arList Is Nothing Then
            i = arList.Count
            If i > 0 Then
                For i = 0 To i - 1
                    Me.cmbConclusion.Items.Add(arList(i))
                Next
                Try
                    Me.cmbConclusion.SelectedIndex = 1
                Catch
                End Try
            End If
        End If
    End Sub
    '��ø���Ŀ�ĺ�ͬ������
    Private Sub getOpinion()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strSql As String
        Try
            strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
            ds = gWs.GetProjectOpinionByProjectNo(strSql)
            i = ds.Tables("TProjectOpinion").Rows.Count
            If i > 0 Then
                dr = ds.Tables("TProjectOpinion").Rows(0)
                With dr
                    If Not .Item("content") Is System.DBNull.Value Then
                        Me.txtOpinion.Text = .Item("content")
                    End If
                End With
            End If
        Catch
        Finally
        End Try
    End Sub
    '
    '�ύ
    '
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        isCommit = True
        If isCommitConfirm Then
            'If MsgBoxResult.Yes = MsgBox("�Ƿ�ȷ���ύ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "��ʾ") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1000", "�ύ") Then
                commit(sender, e)
            End If
        Else
            commit(sender, e)
        End If
    End Sub
    '�ύ����
    Private Sub commit(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not Me.cmbConclusion.Text.Trim.StartsWith("��") Then
            If isAccreditCommit() Then
                'MsgBox("��δ��˵ĺ�ͬ,�����ύ!", MsgBoxStyle.Exclamation, "��ʾ")
                SWDialogBox.MessageBox.Show("$1004", "δ��˵ĺ�ͬ")
                Exit Sub
            End If
        End If

        Dim changedCount As Integer = 0
        If Not Me.dsMaterial Is Nothing Then
            Try
                changedCount = Me.dsMaterial.GetChanges.Tables(0).Rows.Count
            Catch
            End Try
        End If
        If changedCount > 0 Then
            Call btnSave_Click(sender, e)
        End If
        Dim strCommit As String
        If Me.cmbConclusion.Text = "" Then
            'MsgBox("��˽��۲���Ϊ��!", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$1001", "��˽���")
            Me.cmbConclusion.Focus()
            isCommit = False
            Exit Sub
        Else
            strFinishedFlag = Me.cmbConclusion.Text
        End If
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, strFinishedFlag, strPerson)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If "1" = strCommit Then
            'MsgBox("�ύ�ɹ�!", MsgBoxStyle.Information, "��ʾ")
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            raiseCommitSucceed()
            Me.Close()
        Else
            'MsgBox("�ύʧ��!" & strCommit, MsgBoxStyle.Critical, "��ʾ")
            SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
            isCommit = False
        End If

    End Sub
    '
    '�����ͬ��˵�Affirm_person,Affirm_date
    '
    Private Function saveContractAffirm(ByVal gWs As htfServer.Service1)
        If Not Me.dsMaterial Is Nothing Then
            Dim i As Integer
            Dim dr As DataRow
            Dim strResult As String
            i = dsMaterial.Tables("TProjectDocument").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dr = dsMaterial.Tables("TProjectDocument").Rows(i)
                    With dr
                        If Not .Item("is_affirm") Is System.DBNull.Value Then
                            If .Item("is_affirm") = True Then
                                .Item("affirm_person") = strPerson
                                Try
                                    .Item("affirm_date") = gWs.GetSysTime()
                                Catch ex As Exception
                                    ExceptionHandler.ShowMessageBox(ex)
                                End Try
                            Else
                                .Item("affirm_person") = System.DBNull.Value
                                .Item("affirm_date") = System.DBNull.Value
                            End If
                        Else
                            .Item("affirm_person") = System.DBNull.Value
                            .Item("affirm_date") = System.DBNull.Value
                        End If
                    End With
                Next
                strResult = gWs.UpdateProjectDocument(dsMaterial)
            End If
            If strResult = "1" Then
                Me.dsMaterial = setDgDataSource(strProjectCode, False)
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function
    '
    '�鿴��ͬ
    '
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Cursor = Cursors.WaitCursor
        Dim docClass As New frmDocumentClass(strCorporationName)
        docClass.setIsDocument(True)
        docClass.openFileList(strProjectCode, "43", "%", strDir) '43��ʾ��ͬ
        Me.Cursor = Cursors.Default
    End Sub
    '�˳�
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '�˳�����
    Private Function frmExit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '����dataSet�ж��Ƿ��޸���
        Dim changedCount As Integer = 0
        If Not Me.dsMaterial Is Nothing Then
            Try
                changedCount = Me.dsMaterial.GetChanges.Tables(0).Rows.Count
            Catch
            End Try
        End If
        If isLoad Then
            Me.Close()
            Exit Function
        End If
        If changedCount > 0 Then
            Dim strMesg As Integer
            'strMesg = MsgBox("�������޸ģ��Ƿ񱣴棿", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "��ʾ")
            strMesg = SWDialogBox.MessageBox.Show("?1003")
            If 6 = strMesg Then
                Call btnSave_Click(sender, e)
                Me.Close()
            ElseIf strMesg = 7 Then
                Me.Close()
            Else
                Return True
            End If
        Else
            Me.Close()
        End If
    End Function
    '����
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strSql As String
        Try
            saveContractAffirm(gWs)
            strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
            ds = gWs.GetProjectOpinionByProjectNo(strSql)
            i = ds.Tables("TProjectOpinion").Rows.Count
            If i = 0 Then
                dr = ds.Tables("TProjectOpinion").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("item_type") = strItemType
                    .Item("item_code") = strItemCode
                    .Item("content") = Me.txtOpinion.Text
                    .Item("conclusion") = Me.cmbConclusion.Text
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                ds.Tables("TProjectOpinion").Rows.Add(dr)
            Else
                dr = ds.Tables("TProjectOpinion").Rows(0)
                With dr
                    .Item("content") = Me.txtOpinion.Text
                    .Item("conclusion") = Me.cmbConclusion.Text
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
            End If
            Dim strResult As String
            strResult = gWs.UpdateProjectOpinion(ds)
            If strResult = "1" Then
                saveAffirm()
                If Not isCommit Then
                    'MsgBox("����ɹ�!", MsgBoxStyle.Information, "��ʾ")
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                End If
                Me.dsMaterial = setDgDataSource(strProjectCode, False)
                Me.dsMaterial.AcceptChanges()
            Else
                'MsgBox("����ʧ��!" & strResult, MsgBoxStyle.Information, "��ʾ")
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            End If
        Catch ex As Exception
        End Try
    End Sub
    '
    '�������,������affirm_person,affirm_date
    '
    Private Function saveAffirm()
        If gWs Is Nothing Then
            Exit Function
        End If
        Try
            If Not Me.dsMaterial Is Nothing Then
                If Me.dsMaterial.GetChanges() Is Nothing Then
                    Exit Function
                End If
                If Me.dsMaterial.GetChanges().Tables(0).Rows.Count > 0 Then
                    Dim i As Integer
                    Dim dr As DataRow
                    i = Me.dsMaterial.Tables(0).Rows.Count
                    If i > 0 Then
                        For i = 0 To i - 1
                            dr = Me.dsMaterial.Tables(0).Rows(i)
                            With dr
                                If Not .Item("is_affirm") Is System.DBNull.Value Then
                                    If .Item("is_affirm") Then
                                        .Item("affirm_person") = strPerson
                                        Try
                                            .Item("affirm_date") = gWs.GetSysTime()
                                        Catch ex As Exception
                                            ExceptionHandler.ShowMessageBox(ex)
                                        End Try
                                    Else
                                        .Item("affirm_person") = System.DBNull.Value
                                        .Item("affirm_date") = System.DBNull.Value
                                    End If
                                Else
                                    .Item("affirm_person") = System.DBNull.Value
                                    .Item("affirm_date") = System.DBNull.Value
                                End If
                            End With
                        Next
                        Dim strResult As String
                        strResult = gWs.UpdateProjectDocument(Me.dsMaterial)
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    'KeyPress()
    Private Sub frmReviewContract_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing()
    Private Sub frmReviewContract_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '���datagrid������text
    Private Sub setTextContent()
        Static lastRow As Integer = -1
        Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
        If Me.dgMaterial.CurrentRowIndex <> lastRow Then
            Try
                If Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_affirm") Is System.DBNull.Value Then
                    If Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_affirm") Then
                        isLoad = False
                    End If
                End If
            Catch
            Finally
                Dim index As Integer
                Try
                    'setButton()
                    index = Me.dgMaterial.CurrentRowIndex
                    Me.setMaterialInfo(dsMaterial, index)
                Catch ex As Exception
                End Try
            End Try
        End If
        lastRow = Me.dgMaterial.CurrentRowIndex
    End Sub
    '�б�����갴���¼�
    Private Sub dgMaterial_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgMaterial.MouseUp
        If Me.dsMaterial Is Nothing Then
            Exit Sub
        End If
        If Me.dsMaterial.Tables("TProjectDocument").Rows.Count > 0 Then
            Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
            '����datagrid�е�checkboxʱ�ı�checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgMaterial.CurrentCell.RowNumber
            colNum = Me.dgMaterial.CurrentCell.ColumnNumber
            If colNum = 1 Then
                isLoad = False
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgMaterial.Item(rowNum, colNum) = Not Me.dgMaterial.Item(rowNum, colNum)
            End If
            setTextContent()
        End If
    End Sub
    '
    '�����Ƿ����ļ�,ȷ��"�鿴��ͬ"��ť��Enabled����
    '
    Private Sub setButton()
        Dim dt As DataTable
        If Me.dsMaterial Is Nothing Then
            Me.btnView.Enabled = False
            Exit Sub
        End If
        Try
            dt = CType(Me.dgMaterial.DataSource, DataTable)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    If dt.Rows(Me.dgMaterial.CurrentRowIndex).Item("is_file") Is System.DBNull.Value Then
                        Me.btnView.Enabled = False
                    Else
                        If dt.Rows(Me.dgMaterial.CurrentRowIndex).Item("is_file") Then
                            Me.btnView.Enabled = True
                        Else
                            Me.btnView.Enabled = False
                        End If
                    End If
                Else
                    Me.btnView.Enabled = False
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '�жϻ�����������Ƿ���ȷ�����
    '�����һ��û��ȷ�����,�򷵻�true
    '
    Private Function isAccreditCommit()
        If Not Me.dsMaterial Is Nothing Then
            Dim i As Integer
            Dim dr As DataRow
            Dim isNotChecked As Boolean = False
            Try
                i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
                        With dr
                            If Not .Item("is_affirm") Then
                                isNotChecked = True
                            End If
                        End With
                    Next
                End If
            Catch
            End Try
            Return isNotChecked
        End If
    End Function
    '��������
    Private Sub btnConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConclusion.Click
        'edit by 9sky 20050705  �Ա���ҵ��Ʒ�������⴦��
        '************************ԭ���Ĵ���*******************************************
        'If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count <= 0 Then
        '    '��ʾ����Ч��û�пɹ����������ݡ���Ϣ��
        '    SWDialogBox.MessageBox.Show("$1005", " �������� ")
        '    Return
        'End If

        'Dim meet As New frmMeetRecordQuery(strProjectCode, strCorporationName)
        'meet.ShowDialog()
        '***********************************************************************************


        If gWs.GetCommonQueryInfo("select apply_service_type from project where project_code='" & Me.getProjectCode & "'").Tables(0).Rows(0)(0) <> "����" Then
            If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count <= 0 Then
                '    '��ʾ����Ч��û�пɹ����������ݡ���Ϣ��
                SWDialogBox.MessageBox.Show("$1005", " �������� ")
                Return
            End If

            Dim meet As New frmMeetRecordQuery(strProjectCode, strCorporationName)
            meet.ShowDialog()
        Else

            If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count > 0 Then
                frmChangeGuarantyFee.OpenWord(Me.getProjectCode(), Me, Me.getCorporationName() & "����������", True, Me.getCorporationName)
            Else
                Dim ProjectCode As String = MyBase.getProjectCode
                Dim apply_date As DateTime = Money.GetApplyDate(ProjectCode)
                Dim dsLetter As DataSet = gWs.GetGuaranteeLetter(ProjectCode.Substring(0, 5), apply_date)
                Dim fileProjectCode As String
                If dsLetter.Tables(0).Rows.Count > 0 Then
                    fileProjectCode = dsLetter.Tables(0).Rows(0)("project_code") & String.Empty
                    frmChangeGuarantyFee.OpenWord(fileProjectCode, Me, Me.getCorporationName() & "����������", False, String.Empty)
                End If
            End If
        End If
    End Sub
End Class
