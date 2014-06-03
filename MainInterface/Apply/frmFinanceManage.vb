Imports System.Globalization

Public Class frmFinanceManage
    Inherits frmBasic

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tpDept As System.Windows.Forms.TabPage
    Friend WithEvents tpIOcome As System.Windows.Forms.TabPage
    Friend WithEvents tpCash As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorporation_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProjCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDebet As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgIOcome As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dgCash As System.Windows.Forms.DataGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxProjPhase As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTerm As System.Windows.Forms.ComboBox
    Friend WithEvents lblAlarm As System.Windows.Forms.Label
    Friend WithEvents ttpFinance As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFinanceManage))
        Me.btnModify = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpDept = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgDebet = New System.Windows.Forms.DataGrid()
        Me.tpIOcome = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgIOcome = New System.Windows.Forms.DataGrid()
        Me.tpCash = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgCash = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAlarm = New System.Windows.Forms.Label()
        Me.cbxTerm = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxProjPhase = New System.Windows.Forms.ComboBox()
        Me.txtProjCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorporation_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ttpFinance = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tpDept.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDebet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpIOcome.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgIOcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCash.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(432, 488)
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.Visible = True
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.Enabled = False
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 2
        Me.btnModify.ImageList = Me.ImageList1
        Me.btnModify.Location = New System.Drawing.Point(168, 488)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 0
        Me.btnModify.Text = "�� ��(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 1
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(256, 488)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "ɾ ��(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "��������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 0
        Me.btnNew.ImageList = Me.ImageList1
        Me.btnNew.Location = New System.Drawing.Point(80, 488)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 24)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "�� ��(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 3
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(344, 488)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tpDept, Me.tpIOcome, Me.tpCash})
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(3, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(570, 376)
        Me.TabControl1.TabIndex = 15
        '
        'tpDept
        '
        Me.tpDept.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3})
        Me.tpDept.Location = New System.Drawing.Point(4, 21)
        Me.tpDept.Name = "tpDept"
        Me.tpDept.Size = New System.Drawing.Size(562, 351)
        Me.tpDept.TabIndex = 0
        Me.tpDept.Text = "�ʲ���ծ��"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDebet})
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(562, 351)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'dgDebet
        '
        Me.dgDebet.AllowSorting = False
        Me.dgDebet.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.dgDebet.CaptionVisible = False
        Me.dgDebet.DataMember = ""
        Me.dgDebet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDebet.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDebet.Location = New System.Drawing.Point(3, 17)
        Me.dgDebet.Name = "dgDebet"
        Me.dgDebet.Size = New System.Drawing.Size(556, 331)
        Me.dgDebet.TabIndex = 1
        '
        'tpIOcome
        '
        Me.tpIOcome.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4})
        Me.tpIOcome.Location = New System.Drawing.Point(4, 21)
        Me.tpIOcome.Name = "tpIOcome"
        Me.tpIOcome.Size = New System.Drawing.Size(562, 351)
        Me.tpIOcome.TabIndex = 1
        Me.tpIOcome.Text = "�����"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgIOcome})
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(562, 351)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'dgIOcome
        '
        Me.dgIOcome.AllowSorting = False
        Me.dgIOcome.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.dgIOcome.CaptionVisible = False
        Me.dgIOcome.DataMember = ""
        Me.dgIOcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIOcome.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgIOcome.Location = New System.Drawing.Point(3, 17)
        Me.dgIOcome.Name = "dgIOcome"
        Me.dgIOcome.Size = New System.Drawing.Size(556, 331)
        Me.dgIOcome.TabIndex = 1
        '
        'tpCash
        '
        Me.tpCash.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox5})
        Me.tpCash.Location = New System.Drawing.Point(4, 21)
        Me.tpCash.Name = "tpCash"
        Me.tpCash.Size = New System.Drawing.Size(562, 351)
        Me.tpCash.TabIndex = 2
        Me.tpCash.Text = "�ֽ�������"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgCash})
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(562, 351)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'dgCash
        '
        Me.dgCash.AllowSorting = False
        Me.dgCash.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.dgCash.CaptionVisible = False
        Me.dgCash.DataMember = ""
        Me.dgCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCash.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCash.Location = New System.Drawing.Point(3, 17)
        Me.dgCash.Name = "dgCash"
        Me.dgCash.Size = New System.Drawing.Size(556, 331)
        Me.dgCash.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblAlarm, Me.cbxTerm, Me.TabControl1, Me.Label3})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 424)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'lblAlarm
        '
        Me.lblAlarm.Location = New System.Drawing.Point(64, 24)
        Me.lblAlarm.Name = "lblAlarm"
        Me.lblAlarm.Size = New System.Drawing.Size(56, 16)
        Me.lblAlarm.TabIndex = 17
        Me.lblAlarm.Text = "(yyyymm)"
        Me.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxTerm
        '
        Me.cbxTerm.Location = New System.Drawing.Point(136, 22)
        Me.cbxTerm.MaxLength = 6
        Me.cbxTerm.Name = "cbxTerm"
        Me.cbxTerm.Size = New System.Drawing.Size(120, 20)
        Me.cbxTerm.TabIndex = 1
        Me.ttpFinance.SetToolTip(Me.cbxTerm, "����ڼ��ʽ��yyyymm(200305)")
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.cbxProjPhase, Me.txtProjCode, Me.Label2, Me.txtCorporation_name, Me.Label1})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 48)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(440, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "��Ŀ�׶�"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxProjPhase
        '
        Me.cbxProjPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProjPhase.Location = New System.Drawing.Point(496, 22)
        Me.cbxProjPhase.Name = "cbxProjPhase"
        Me.cbxProjPhase.Size = New System.Drawing.Size(72, 20)
        Me.cbxProjPhase.TabIndex = 0
        Me.cbxProjPhase.TabStop = False
        '
        'txtProjCode
        '
        Me.txtProjCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjCode.Location = New System.Drawing.Point(64, 22)
        Me.txtProjCode.Name = "txtProjCode"
        Me.txtProjCode.ReadOnly = True
        Me.txtProjCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjCode.TabIndex = 0
        Me.txtProjCode.TabStop = False
        Me.txtProjCode.Text = ""
        Me.txtProjCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "��Ŀ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorporation_name
        '
        Me.txtCorporation_name.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporation_name.Location = New System.Drawing.Point(216, 22)
        Me.txtCorporation_name.Name = "txtCorporation_name"
        Me.txtCorporation_name.ReadOnly = True
        Me.txtCorporation_name.Size = New System.Drawing.Size(216, 21)
        Me.txtCorporation_name.TabIndex = 0
        Me.txtCorporation_name.TabStop = False
        Me.txtCorporation_name.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(152, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��ҵ����"
        '
        'frmFinanceManage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 519)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.GroupBox2, Me.GroupBox1, Me.btnSave, Me.btnNew, Me.btnDelete, Me.btnModify})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinanceManage"
        Me.Text = "�������ݹ���"
        Me.TabControl1.ResumeLayout(False)
        Me.tpDept.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgDebet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpIOcome.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgIOcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCash.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    'ϵͳ����
    Private SysDate As Date = VouchService.GetSysTime()

    '�����ĳ�ʼ�������캯��
    Private proj_Code As String ' ��Ŀ����
    Private corp_Code As String ' ��ҵ����
    Private corp_Name As String ' ��ҵ����

    Public Property ProjCode() As String
        Get
            Return proj_Code
        End Get
        Set(ByVal Value As String)
            proj_Code = Value.Trim()
        End Set
    End Property

    Public Property CorpName() As String
        Get
            Return corp_Name
        End Get
        Set(ByVal Value As String)
            corp_Name = Value
        End Set
    End Property

    Public Property CorpCode() As String
        Get
            Return corp_Code
        End Get
        Set(ByVal Value As String)
            corp_Code = Value
        End Set
    End Property

    '��Ŀ�׶�
    Private proj_Phase As String
    Property ProjPhase() As String
        Get
            Return proj_Phase
        End Get
        Set(ByVal Value As String)
            proj_Phase = Value
        End Set
    End Property

    '�Ƿ���������Ŀ�׶�
    Private phase_Enabled As Boolean
    Property PhaseEnabled() As Boolean
        Get
            Return phase_Enabled
        End Get
        Set(ByVal Value As Boolean)
            phase_Enabled = Value
        End Set
    End Property

    Private bPageLoaded As Boolean = False                  ' �����ʼ���Ƿ����    

    '¼�뱣֤��ҵ�Ĳ�������ʱ������������ҵ���룬���򽫻�ô������ҵ����
    Public Sub New(ByVal pcode As String, ByVal corp_name As String, ByVal corp_code As String, ByVal phase As String, ByVal owner As Form)
        Me.New()

        ProjCode = pcode
        CorpName = corp_name
        If corp_code = "" Then
            CorpCode = GetCorpCodeByProjCode(pcode)
        Else
            CorpCode = corp_code
        End If
        ProjPhase = phase
        Me.Owner = owner
    End Sub

    Private Sub frmFinanceManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load '
        Me.txtProjCode.Text = ProjCode
        Me.txtCorporation_name.Text = CorpName

        '�׶���Ϣ����
        Me.cbxProjPhase.DataSource = PhaseDS.Tables("TPhase")
        Me.cbxProjPhase.DisplayMember = "phase_name"
        Me.cbxProjPhase.ValueMember = "phase_name"
        Me.cbxProjPhase.SelectedValue = ProjPhase

        Me.cbxProjPhase.Enabled = PhaseEnabled

        '����ڼ�
        InitTerm()

        '��������
        InitFinance()

        'Me.dgtbcDebetA.FormatInfo = CGFormatInfo
        'Me.dgtbcDebetA.FormatInfo = CGFormatInfo
        'Me.dgtbcCashA.FormatInfo = CGFormatInfo
        'Me.dgtbcIocomeA.FormatInfo = CGFormatInfo

        bPageLoaded = True

        'AddHandler dgtbcDebetA.TextBox.KeyPress, AddressOf txt_KeyPress
    End Sub

    ' ĳһ�������ķ�װ
    Public Class FinanceTable
        Private _finance As DataTable   ' ���������ݱ�ܹ�������
        Private _name As String         ' ���������
        Private _itemType As String     ' �������Ŀ���� �硰�ʲ����ر�Ϊ��01��

        ' ��ĸ������Բ�������ʾ�ñ�������Ŀ����Ϊ_pcode,��ҵ����Ϊ_ccode,��Ŀ�׶�Ϊ_phase,��Ŀ�ڼ�Ϊ_term��name��
        Private _pcode As String
        Private _ccode As String
        Private _phase As String
        Private _term As String

        '�Ƿ��Ѿ����ػ��������
        Private _hasData As Boolean = False

        Public Sub New(ByVal name As String, ByVal pcode As String, ByVal ccode As String, ByVal dg As DataGrid)
            _name = name

            _pcode = pcode
            _ccode = ccode
            _itemType = GetItemTypeByName(_name)

            _finance = FinancesDS.Tables(_name).Copy() ' ���ƹ����ṹ������
            _finance.AcceptChanges()
            Dim dv As New DataView(_finance)
            dg.DataSource = dv ' ����_finance���ⲿ��ʾ���ݱ��(DataGrid)
            dv.AllowNew = False
            dv.AllowDelete = False

            AddHandler _finance.ColumnChanged, AddressOf Column_Changed
            AddHandler dg.CurrentCellChanged, AddressOf RowMove
        End Sub

        Public Sub New(ByVal name As String, ByVal pcode As String, ByVal ccode As String, ByVal term As String, ByVal phase As String, ByVal dg As DataGrid)
            _name = name

            _pcode = pcode
            _ccode = ccode
            _term = term
            _phase = phase

            _itemType = GetItemTypeByName(_name)

            _finance = FinancesDS.Tables(_name).Copy()
            _finance.AcceptChanges()

            Dim dv As New DataView(_finance)
            dg.DataSource = dv
            dv.AllowNew = False
            dv.AllowDelete = False

            AddHandler _finance.ColumnChanged, AddressOf Column_Changed
            AddHandler dg.CurrentCellChanged, AddressOf RowMove
        End Sub

        Private Sub RowMove(ByVal sender As Object, ByVal e As EventArgs)
            Dim he As DataGrid = CType(sender, DataGrid)
            he.Select(he.CurrentCell.RowNumber)
        End Sub

        Private Sub Column_Changed(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
            RemoveHandler _finance.ColumnChanged, AddressOf Column_Changed
            Calculate()
            AddHandler _finance.ColumnChanged, AddressOf Column_Changed
        End Sub

        '������Ŀ����
        Public Sub SetArgument(ByVal term As String, ByVal phase As String, ByVal pcode As String, ByVal ccode As String)
            _term = term
            _phase = phase
            _pcode = pcode
            _ccode = ccode

        End Sub

        '���û���ڼ�ͽ׶β���
        Public Sub SetArgument(ByVal term As String, ByVal phase As String)
            _term = term
            _phase = phase

        End Sub

        '���û���ڼ�
        Public Sub SetArgument(ByVal term As String)
            _term = term

        End Sub

        '��ȡ����ڼ�
        Public Function GetTerm() As String
            Return _term
        End Function

        '��ȡ��Ŀ�׶�
        Public Function GetPhase() As String
            Return _phase
        End Function

        '��ȡ����
        Public Function GetName() As String
            Return _name
        End Function

        '��������
        Public Sub Import(ByVal force As Boolean)
            '���forceΪ����ǿ�Ƽ������ݣ� ��������Ѿ��������ˣ��Ͳ��������������
            If force Or Not (HasChanged Or HasData) Then
                Try
                    Dim i As Integer
                    Dim dr() As DataRow
                    Dim ds As DataSet = VouchService.GetAccountEx(_pcode, _ccode, _phase, _term, "%", _itemType)


                    'If _finance.Rows.Count = ds.Tables("TCorporationAccount").Rows.Count Then
                    'For i = 0 To ds.Tables("TCorporationAccount").Rows.Count - 1
                    '    With _finance.Rows(i)
                    '        .Item("item_code") = ds.Tables("TCorporationAccount").Rows(i).Item("item_code")
                    '        .Item("value") = ds.Tables("TCorporationAccount").Rows(i).Item("value")
                    '    End With
                    'Next
                    'Else
                    For i = 0 To _finance.Rows.Count - 1
                        With _finance.Rows(i)
                            dr = ds.Tables("TCorporationAccount").Select("item_code = '" & .Item("item_code") & "'")
                            If Not dr.Length = 0 Then
                                .Item("value") = dr(0).Item("value")
                            End If
                        End With
                    Next
                    'End If

                    If i = 0 Then   'û�п��Լ��ص�����
                        Clear()     '��������Ѿ����ڵ�����
                    Else
                        _finance.AcceptChanges()
                        _hasData = True
                    End If
                Catch ex As Exception
                    Throw ex
                End Try
            End If
        End Sub

        '��ձ��еĸ�������
        Public Sub Clear()
            If HasData Or HasChanged Then
                Dim i As Integer
                For i = 0 To _finance.Rows.Count - 1
                    _finance.Rows(i).Item("value") = 0.0
                Next
                _finance.AcceptChanges()
                _hasData = False
            End If
        End Sub

        '�����ݱ��浽���ݿ���ȥ
        Public Function Save() As String
            If HasChanged Then
                Dim i As Integer
                Dim dr As DataRow
                Dim ds As DataSet = VouchService.GetAccountEx(_pcode, _ccode, _phase, _term, "%", _itemType)

                Dim DateNow As DateTime = VouchService.GetSysTime()
                If ds.Tables("TCorporationAccount").Rows.Count > 0 Then ' �޸�����

                    For i = 0 To ds.Tables("TCorporationAccount").Rows.Count - 1
                        ds.Tables("TCorporationAccount").Rows(i).Delete()
                    Next

                    For i = 0 To _finance.Rows.Count - 1                   '���������ݴ���һ��
                        dr = ds.Tables("TCorporationAccount").NewRow
                        With dr
                            .Item("project_code") = _pcode
                            .Item("corporation_code") = _ccode
                            .Item("phase") = _phase
                            .Item("month") = _term
                            .Item("item_type") = _itemType
                            .Item("item_code") = _finance.Rows(i).Item("item_code")
                            .Item("value") = _finance.Rows(i).Item("value")

                            .Item("create_person") = UserName
                            .Item("create_date") = DateNow
                        End With
                        ds.Tables("TCorporationAccount").Rows.Add(dr)
                    Next                                                   '----------------
                Else ' ��������                              
                    For i = 0 To _finance.Rows.Count - 1
                        dr = ds.Tables("TCorporationAccount").NewRow
                        With dr
                            .Item("project_code") = _pcode
                            .Item("corporation_code") = _ccode
                            .Item("phase") = _phase
                            .Item("month") = _term
                            .Item("item_type") = _itemType
                            .Item("item_code") = _finance.Rows(i).Item("item_code")
                            .Item("value") = _finance.Rows(i).Item("value")

                            .Item("create_person") = UserName
                            .Item("create_date") = DateNow
                        End With
                        ds.Tables("TCorporationAccount").Rows.Add(dr)
                    Next
                End If

                _hasData = True
                _finance.AcceptChanges()
                Return VouchService.UpdateAccount(ds.GetChanges())
            Else
                Return "0"
            End If
        End Function

        '�����ϴθı������
        Public Sub Reject()
            _finance.RejectChanges()
        End Sub

        '�����ݿ���ɾ����������
        Public Function Remove() As String
            If HasData Then
                Dim i As Integer
                Dim res As String
                Dim dr As DataRow
                Dim ds As DataSet = VouchService.GetAccountEx(_pcode, _ccode, _phase, _term, "%", _itemType)

                For Each dr In ds.Tables("TCorporationAccount").Rows
                    dr.Delete()
                Next

                res = VouchService.UpdateAccount(ds.GetChanges())
                Clear()
                Return res
            End If
        End Function

        '�Ƿ��������
        ReadOnly Property HasData() As Boolean
            Get
                Return _hasData
            End Get
        End Property

        '�����Ƿ��޸Ĺ�
        ReadOnly Property HasChanged() As Boolean
            Get
                Dim ds As DataTable = _finance.GetChanges()
                If Not ds Is Nothing Then
                    If (ds.Rows.Count > 0) Then Return True
                End If
                Return False
            End Get
        End Property

        '���Ҷ�Ӧ�����ڱ��е�����
        Public Function CodeIndex(ByVal code As String) As Integer
            Dim ret As Integer = 0
            For ret = 0 To _finance.Rows.Count - 1
                If _finance.Rows(ret).Item("item_code") = code Then
                    Exit For
                End If
            Next
            Return ret
        End Function

        '���ض�Ӧ�����������������
        Public Function CodeIndexes(ByVal codes As String()) As Integer()
            Dim rets(codes.Length - 1) As Integer
            Dim i As Integer
            For i = 0 To codes.Length - 1
                rets(i) = CodeIndex(codes(i))
            Next
            Return rets
        End Function

        '�����ʲ����ر�
        Private Sub CalDebet()
            '�����ʲ��ϼ�
            Dim arr0() As String = {"a01", "a02", "a03", "a04", "a05", "a06", "a07", "a08", "a09", "a10", "a11", "a12", "a13"}
            Sum(arr0, "a14") 'sum(a01, a13, a14)
            '����Ͷ�ʺϼ�
            Dim arr1() As String = {"a15", "a16"}
            Sum(arr1, "a17") 'sum(a15, a16, a17
            'modified by hute 2003-9-26
            '��ȨͶ�ʲ��
            Dim arr2() As String = {"a17", "a18"}
            Dim op2() As Boolean = {True, False}
            Sum(arr2, op2, "a19")
            '�̶��ʲ���ֵ
            Dim arr3() As String = {"a20", "a21"}
            Dim op3() As Boolean = {True, False} '+,-
            Sum(arr3, op3, "a22") 'a22 = a20-a21
            '�̶��ʲ�����
            Dim arr4() As String = {"a22", "a23"}
            Dim op4() As Boolean = {True, False} '+,-
            Sum(arr4, op4, "a24") 'a24 = a22-a23
            '�̶��ʲ��ϼ�
            Dim arr5() As String = {"a24", "a25", "a26", "a27"}
            Sum(arr5, "a28") 'sum(a24,a27,a28)
            '�����ʲ��������ʲ��ϼ�
            '�����ʲ��������ʲ��ϼƣ������ʲ��������ʲ������������ʲ�
            Dim arr6() As String = {"a29", "a30", "a31"}
            Sum(arr6, "a32") 'a32 = a29 + a30
            '�ʲ��ϼ�
            'a34=a14+a17+a28+a32+a33
            Dim arr7() As String = {"a14", "a17", "a28", "a32", "a33"}
            Sum(arr7, "a34")
            '������ծ�ϼ�
            Dim arr8() As String = {"a35", "a36", "a37", "a38", "a39", "a40", "a41", "a42", "a43", "a44", "a45", "a46", "a47", "a48"}
            Sum(arr8, "a49") 'sum(a35, a48, a49)
            '���ڸ�ծ�ϼ�
            Dim arr9() As String = {"a50", "a51", "a52", "a53", "a54"}
            Sum(arr9, "a55") 'sum(a50,a54, a55)
            '��ծ�ϼ�
            Dim arr10() As String = {"a49", "a55", "a56"}
            Sum(arr10, "a57") 'a57 = a49 + a55 + a56
            '������Ȩ��(��ɶ�Ȩ��)�ϼ�
            Dim arr11() As String = {"a58", "a59", "a60", "a62", "a63", "a64"}
            Sum(arr11, "a65") 'sum(a58, a64, a65)
            '��ծ��������(�ɱ�)Ȩ���ܼ�
            Dim arr12() As String = {"a57", "a65"}
            Sum(arr12, "a66") 'a66 = a57+a65

        End Sub

        '���������
        Private Sub CalIO()
            '��Ӫҵ������
            Dim arr0() As String = {"b01", "b02", "b03"}
            Dim op0() As Boolean = {True, False, False}
            Sum(arr0, op0, "b04") 'b04 = b01 - b02 - b03
            'Ӫҵ����
            Dim arr1() As String = {"b04", "b05", "b06", "b07", "b08"}
            Dim op1() As Boolean = {True, True, False, False, False}
            Sum(arr1, op1, "b09") 'b09 = b04 + b05 - b06 - b07 - b08
            '�����ܶ�
            Dim arr2() As String = {"b09", "b10", "b11", "b12", "b13"}
            Dim op2() As Boolean = {True, True, True, True, False}
            Sum(arr2, op2, "b14") 'b14 = b09 + b10 + b11 + b12 - b13
            '������
            Dim arr3() As String = {"b14", "b15", "b16", "b17"}
            Dim op3() As Boolean = {True, False, False, False}
            Sum(arr3, op3, "b18") 'b18 = b14-b15 - b16 - b17
            '�ɹ���������
            Dim arr4() As String = {"b18", "b19", "b20"}
            Sum(arr4, "b21") 'b21 = b18 + b19 + b20
            '�ɹ��ɶ����������
            Dim arr5() As String = {"b21", "b22", "b23", "b24"}
            Dim op5() As Boolean = {True, False, False, False}
            Sum(arr5, op5, "b25") 'b25 = b21 - b22 - b23 - b24
            'δ��������
            Dim arr6() As String = {"b25", "b26", "b27", "b28", "b29"}
            Dim op6() As Boolean = {True, False, False, False, False}
            Sum(arr6, op6, "b30") 'b30 = b25 - b26 - b27 - b28 - b29
        End Sub

        '�����ֽ�������
        Private Sub CalCash()
            '�ֽ�����С��
            Dim arr0() As String = {"c01", "c02", "c03"}
            Sum(arr0, "c04") 'c04=sum(c01:c03)
            '�ֽ�����С��
            Dim arr1() As String = {"c05", "c06", "c07", "c08"}
            Sum(arr1, "c09") 'c09=sum(c05:c08)
            '��Ӫ��������ֽ���������
            Dim arr2() As String = {"c04", "c09"}
            Dim op2() As Boolean = {True, False}
            Sum(arr2, op2, "c10") 'c10 = c04 - c09
            '�ֽ�����С��
            Dim arr3() As String = {"c11", "c12", "c13", "c14"}
            Sum(arr3, "c15") 'c15=sum(c11:c14)
            '�ֽ�����С��
            Dim arr4() As String = {"c16", "c17", "c18"}
            Sum(arr4, "c19") 'c19=sum(c16:c18)
            'Ͷ�ʻ�������ֽ���������
            Dim arr5() As String = {"c15", "c19"}
            Dim op5() As Boolean = {True, False}
            Sum(arr5, op5, "c20") 'c20 = c15 - c19
            '�ֽ�����С��
            Dim arr6() As String = {"c21", "c22", "c23", "c24"}
            Sum(arr6, "c25") 'c25=sum(c21:c24)
            '�ֽ�����С��
            Dim arr7() As String = {"c26", "c27", "c28", "c29", "c30", "c31"}
            Sum(arr7, "c32") 'c32=sum(c26:c31)
            '���ʻ�������ֽ���������
            Dim arr8() As String = {"c25", "c32"}
            Dim op8() As Boolean = {True, False}
            Sum(arr8, op8, "c33") 'c33 = c25 - c32
            '�ֽ��ֽ�ȼ۾����Ӷ�
            Dim arr9() As String = {"c10", "c20", "c33", "c34"}
            Sum(arr9, "c35") 'c35 = c10 + c20 + c33 + c34
            '��Ӫ��������ֽ���������
            Dim arr10() As String = {"c39", "c40", "c41", "c42", "c43", "c44", "c45", "c46", "c47", "c48", "c49", "c50", "c51", "c52", "c53", "c54", "c55"}
            Sum(arr10, "c56") 'c56=c39+sum(c40:c55)
            Dim arr11() As String = {"c57", "c58", "c59", "c60"}
            Dim op11() As Boolean = {True, False, True, False}
            Sum(arr11, op11, "c61")
        End Sub

        '�������ݵļ���
        Public Sub Calculate()
            Select Case _name
                Case "�ʲ���ծ��"
                    CalDebet()
                Case "�����"
                    CalIO()
                Case "�ֽ�������"
                    CalCash()
            End Select

        End Sub

        '���==�Ѵ�i0��i1����Ŀ��͵�ֵ����fill��Ŀ
        Public Sub Sum(ByVal i0 As Integer, ByVal i1 As Integer, ByVal fill As Integer)
            If i0 < 0 Or i1 < 0 Or i0 > i1 Or fill < 0 Then Return
            If i0 <= fill And i1 >= fill Then Return
            If i1 > _finance.Rows.Count Then Return
            If fill > _finance.Rows.Count Then Return
            Dim i As Integer
            _finance.Rows(fill).Item("value") = 0
            For i = i0 To i1
                If Not _finance.Rows(i).Item("value") Is System.DBNull.Value Then
                    _finance.Rows(fill).Item("value") += _finance.Rows(i).Item("value")
                End If
            Next
        End Sub

        '���==�Ѵ�arr(0)��arr(n)��Ŀ��͵�ֵ����fill��Ŀ
        Private Sub Sum(ByVal arr() As String, ByVal fill As String)
            Sum(CodeIndexes(arr), CodeIndex(fill))
        End Sub

        Private Sub Sum(ByVal arr() As Integer, ByVal fill As Integer)
            Dim i As Integer
            _finance.Rows(fill).Item("value") = 0
            For i = 0 To arr.Length - 1
                If Not _finance.Rows(arr(i)).Item("value") Is System.DBNull.Value Then
                    _finance.Rows(fill).Item("value") += _finance.Rows(arr(i)).Item("value")
                End If
            Next
        End Sub

        '���==�Ѵ�arr(0)��arr(n)��Ŀ��͵�ֵ����fill��Ŀ,op(i)Ϊtrue��ʾ�ӷ��������ʾ������
        Private Sub Sum(ByVal arr() As String, ByVal op() As Boolean, ByVal fill As String)
            Sum(CodeIndexes(arr), op, CodeIndex(fill))
        End Sub
        Private Sub Sum(ByVal arr() As Integer, ByVal op() As Boolean, ByVal fill As Integer)
            If arr.Length <> op.Length Then Return
            Dim i As Integer
            _finance.Rows(fill).Item("value") = 0
            For i = 0 To arr.Length - 1
                If Not _finance.Rows(arr(i)).Item("value") Is System.DBNull.Value Then
                    If op(i) Then
                        _finance.Rows(fill).Item("value") += _finance.Rows(arr(i)).Item("value")
                    Else
                        _finance.Rows(fill).Item("value") -= _finance.Rows(arr(i)).Item("value")
                    End If
                End If
            Next
        End Sub

        '��֤������Ŀ��ֵ�Ƿ����,��ֵ��֤ʧ��
        Private Function ConfirmX(ByVal s0 As String, ByVal s1 As String) As Boolean
            Return ConfirmX(CodeIndex(s0), CodeIndex(s1))
        End Function
        Private Function ConfirmX(ByVal i0 As Integer, ByVal i1 As Integer) As Boolean
            If i0 < 0 Or i1 < 0 Then Return False
            If i0 > _finance.Rows.Count Or i1 > _finance.Rows.Count Then Return False
            If _finance.Rows(i0).Item("value") Is System.DBNull.Value Or _finance.Rows(i1).Item("value") Is System.DBNull.Value Then Return False
            Return (Convert.ToInt64(_finance.Rows(i0).Item("value")) = Convert.ToInt64(_finance.Rows(i1).Item("value")))
        End Function
        ' ��֤�ʲ����ر�
        Public Function ConfirmDebet() As Boolean
            If _name = "�ʲ���ծ��" Then
                Return ConfirmX("a34", "a66")
            End If
            Return False
        End Function
    End Class

    '��ʼ��������Ϣ�����ݱ�
    Private financeTables(2) As FinanceTable
    Private Sub InitFinance()

        '������Ϣ����ṹ
        financeTables(0) = New FinanceTable("�ʲ���ծ��", ProjCode, CorpCode, Me.dgDebet)
        financeTables(1) = New FinanceTable("�����", ProjCode, CorpCode, Me.dgIOcome)
        financeTables(2) = New FinanceTable("�ֽ�������", ProjCode, CorpCode, Me.dgCash)
        SetDataGridStyle()
    End Sub

    'added by hute 2003-9-28      'DataGridTextBoxColumn�ļ̳��࣬����paint���ػ�DataGrid
    Public Class DataGridColoredTextBoxColumn
        Inherits DataGridTextBoxColumn  '�̳нӿ�

        Public rowcollection As New Collection() '���ڴ���кŵļ���
        Public BackColor() As Color '���ڴ�ű���ɫ�ļ��ϣ��������кż���һ��(��������������
        Public ForeColor() As Color '���ڴ��ǰ��ɫ�ļ��ϣ��������кż���һ��

        Private Function GetText(ByVal Value As Object) As String
            'Ϊ�����ػ����textbox�е����ݣ���������������ݴ������ģ���ʵ�ֻ����޹�
            If TypeOf (Value) Is System.DBNull Then
                Return NullText
            ElseIf Value Is Nothing Then
                Return ""
            Else
                If IsNumeric(Value.ToString) Then
                    Return Numeric2Currency(Value.ToString)  'modified by hute 2003-10-30
                Else
                    Return Value.ToString
                End If
            End If
        End Function

        Protected Overloads Overrides Sub Paint(ByVal g As System.Drawing.Graphics, _
            ByVal bounds As System.Drawing.Rectangle, _
            ByVal source As System.Windows.Forms.CurrencyManager, _
            ByVal rowNum As Integer, _
            ByVal backBrush As System.Drawing.Brush, _
            ByVal foreBrush As System.Drawing.Brush, _
            ByVal alignToRight As Boolean)

            Dim text As String              '��Ĭ��ģʽ�ػ�
            text = GetText(GetColumnValueAtRow(source, rowNum)) '�����������ἰ��ȡ����
            backBrush = New SolidBrush(TextBox.BackColor) '����ɫ
            foreBrush = New SolidBrush(TextBox.ForeColor)  'ǰ��ɫ

            '��ֹ�û�û�ж��弯�ϴ�С
            ReDim Preserve BackColor(rowcollection.Count)
            ReDim Preserve ForeColor(rowcollection.Count)

            Dim i As Integer = 1 '���������ӣ���ʼ
            Do While (i <= rowcollection.Count)
                If rowNum = Val(rowcollection.Item(i)) Then  '�ж�Ҫ�����е�������
                    If Not BackColor(i - 1).IsEmpty Then 'û�ж���ľͰ�Ĭ��ɫ����
                        backBrush = New SolidBrush(BackColor(i - 1))
                    End If
                    If Not ForeColor(i - 1).IsEmpty Then 'û�ж���ľͰ�Ĭ��ɫ����
                        foreBrush = New SolidBrush(ForeColor(i - 1))
                    End If
                End If
                i += 1
            Loop

            MyBase.PaintText(g, bounds, text, backBrush, foreBrush, alignToRight)
        End Sub
    End Class

    '����DataGrid����ʾ��ʽ(���ļ�����ɫ��ͬ)
    Private Sub SetDataGridStyle()
        Dim index1() As Integer = {13, 16, 18, 21, 23, 27, 31, 33, 48, 54, 56, 64, 65}
        SetDataGridStyle(index1, dgDebet)
        Dim index2() As Integer = {3, 8, 13, 17, 20, 24, 29}
        SetDataGridStyle(index2, dgIOcome)
        Dim index3() As Integer = {3, 8, 9, 14, 18, 19, 24, 31, 32, 34, 55, 60}
        SetDataGridStyle(index3, dgCash)
    End Sub
    '����SetDataStyle������Ҫ�޸ĵ���������ʾ�ı����ƣ��Լ�DataGrid����
    Private Sub SetDataGridStyle(ByVal index() As Integer, ByVal dg As DataGrid)
        Dim dt As DataView
        Dim ts As New DataGridTableStyle()
        Dim aColumnTextColumn As DataGridColoredTextBoxColumn '�����Զ������
        ' Dim aColumnTextColumn As DataGridTextBoxColumn
        Dim numCols As Integer
        Dim numindex() As Integer

        ts.AllowSorting = False
        dt = CType(dg.DataSource, DataView)
        ts.MappingName = dt.Table.TableName
        numCols = dt.Table.Columns.Count   'ͳ������

        Dim i, j As Integer
        i = 0
        j = 0

        Do While (i < numCols) '�ػ����е���

            'aColumnTextColumn = New DataGridTextBoxColumn()

            aColumnTextColumn = New DataGridColoredTextBoxColumn()
            ReDim aColumnTextColumn.ForeColor(index.Length)
            ReDim aColumnTextColumn.BackColor(index.Length)
            For j = 0 To index.Length - 1
                aColumnTextColumn.rowcollection.Add(index(j)) 'ָ������               
                '����ֵ����Ĭ��ɫ������Ϊ�ף�ǰ��Ϊ��
                aColumnTextColumn.ForeColor(j) = Color.Red
                aColumnTextColumn.BackColor(j) = Color.LightGray
            Next

            'aColumnTextColumn.MappingName = dt.Table.Columns(i).ColumnName

            If i = 0 Then
                aColumnTextColumn.Format = ""
                aColumnTextColumn.FormatInfo = Nothing
                aColumnTextColumn.HeaderText = "��Ŀ"
                aColumnTextColumn.MappingName = "item_name"
                aColumnTextColumn.NullText = ""
                aColumnTextColumn.ReadOnly = True
                aColumnTextColumn.Width = 380
            End If
            If i = 1 Then
                aColumnTextColumn.Format = "c"
                aColumnTextColumn.FormatInfo = CGFormatInfo
                aColumnTextColumn.HeaderText = "���(Ԫ)"
                aColumnTextColumn.MappingName = "value"
                aColumnTextColumn.NullText = ""
                aColumnTextColumn.Alignment = HorizontalAlignment.Right
                aColumnTextColumn.ReadOnly = True
                aColumnTextColumn.Width = 120
                '��������Ϊ����
                AddHandler aColumnTextColumn.TextBox.KeyPress, AddressOf txt_KeyPress
            End If
            ts.GridColumnStyles.Add(aColumnTextColumn)
            i = (i + 1)
        Loop

        dg.TableStyles.Clear()
        dg.TableStyles.Add(ts)


    End Sub

    '��ʼ������ڼ�
    Private Sub InitTerm()
        Dim TempDS As DataSet
        Dim i As Integer
        TempDS = gWs.FetchCorporationAccountMonth(Me.proj_Code, Me.corp_Code, Me.proj_Phase)
        If Not TempDS.Tables(0).Rows.Count = 0 Then
            Me.cbxTerm.Items.Clear()
            For i = 0 To TempDS.Tables(0).Rows.Count - 1
                Me.cbxTerm.Items.Add(TempDS.Tables(0).Rows(i).Item("month"))
            Next
        End If
        UpdateControls()
    End Sub

    '�����еĿɱ༭����
    Private Sub SetValueReadOnly(ByVal ro As Boolean)
        Me.dgDebet.TableStyles(0).GridColumnStyles(1).ReadOnly = ro
        Me.dgIOcome.TableStyles(0).GridColumnStyles(1).ReadOnly = ro
        Me.dgCash.TableStyles(0).GridColumnStyles(1).ReadOnly = ro
    End Sub

    '���������ֵ�ı�
    Private Sub cbxTerm_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTerm.TextChanged
        If bPageLoaded Then 'ÿһ��ѡ��ĸı䶼�������������������
            Dim i As Integer
            If Me.cbxTerm.Text.Length = 6 And Me.cbxTerm.Items.IndexOf(Me.cbxTerm.Text) >= 0 Then

                'qxd add 2004-8-2 ���⣺��ʾʱδˢ���ϴβ�ѯ�����ݣ�����Ӧ�����û������ʱ��
                For i = 0 To financeTables.Length - 1
                    financeTables(i).Clear()
                Next

                Dim pc As Cursor = Me.Cursor
                Me.Cursor = Cursors.WaitCursor
                For i = 0 To financeTables.Length - 1
                    financeTables(i).SetArgument(CType(sender, ComboBox).Text, Me.cbxProjPhase.SelectedValue)
                    financeTables(i).Import(True)
                Next
                Me.Cursor = pc

                Me.btnDelete.Enabled = True
                Me.btnModify.Enabled = True
            Else
                Me.btnDelete.Enabled = False
                Me.btnModify.Enabled = False

                For i = 0 To financeTables.Length - 1
                    financeTables(i).Clear()
                Next
            End If
        End If

    End Sub

    'У�����������Ƿ�Ϻ�Ҫ��
    Private Function IsValidTerm(ByVal term As String) As Boolean
        If term.Length <> 6 Then Return False
        Try
            Dim y As Integer = Integer.Parse(term.Substring(0, 4))
            Dim m As Integer = Integer.Parse(term.Substring(4))
            Dim te As DateTime = New DateTime(y, m, 1)
        Catch
            Return False
        End Try
        Return True
    End Function

    '�׶α仯�����»�ȡ����
    Private Sub cbxProjPhase_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProjPhase.SelectedValueChanged
        '����ڼ�
        If bPageLoaded Then
            InitTerm()
        End If
    End Sub

    '��������ֻ��Ϊ����
    Private Sub cbxTerm_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cbxTerm.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub
    '����DataGrid�е��ı�������
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Or e.KeyChar = Convert.ToChar(45)) '���벻Ϊ���֣����߲�Ϊ�˸������Ϊ����ʱ  ������¼�
        If e.KeyChar = "." AndAlso CType(sender, TextBox).Text.IndexOf(".") = -1 Then        '�״�����С����ʱ��������¼�
            e.Handled = False
        End If
    End Sub

    '����ö���������ڱ�ʾ����״̬
    Enum OperationType
        OPER_EMPTRY
        ADD_FINANCE '��Ӳ�������
        CANCEL_ADD_FINANCE 'ȡ����Ӳ�������
        MODIFY_FINANCE '�޸Ĳ�������
        CANCEL_MODIFY_FINANCE 'ȡ���޸Ĳ�������
    End Enum

    '���¿ؼ���״̬
    Private op_Type As OperationType
    Private Sub UpdateControls()
        Select Case op_Type
            Case OperationType.ADD_FINANCE '��Ӳ�������
                Me.cbxProjPhase.Enabled = False

                Me.cbxTerm.Enabled = False

                Me.btnModify.Enabled = False
                Me.btnDelete.Enabled = False
                Me.btnSave.Enabled = True

                SetValueReadOnly(False)

            Case OperationType.CANCEL_ADD_FINANCE 'ȡ����Ӳ�������
                Me.cbxTerm.Text = ""
                Me.cbxTerm.Enabled = True

                If PhaseEnabled Then
                    Me.cbxProjPhase.Enabled = True
                End If

                Me.btnSave.Enabled = False
                SetValueReadOnly(True)

                op_Type = OperationType.OPER_EMPTRY

            Case OperationType.MODIFY_FINANCE '�޸Ĳ�������
                Me.cbxProjPhase.Enabled = False

                Me.cbxTerm.Enabled = False

                Me.btnNew.Enabled = False
                Me.btnDelete.Enabled = False
                Me.btnSave.Enabled = True

                SetValueReadOnly(False)

            Case OperationType.CANCEL_MODIFY_FINANCE 'ȡ���޸Ĳ�������
                Me.cbxTerm.Text = ""
                Me.cbxTerm.Enabled = True

                If PhaseEnabled Then Me.cbxProjPhase.Enabled = True

                Me.btnNew.Enabled = True
                Me.btnDelete.Enabled = False
                Me.btnModify.Enabled = False

                Me.btnSave.Enabled = False
                SetValueReadOnly(True)

                op_Type = OperationType.OPER_EMPTRY

            Case Else

        End Select
    End Sub
    '������ť
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim he As Button = CType(sender, Button)

        If he.Text = "�� ��(&N)" Then
            If Me.cbxTerm.Text = "" Then
                'MsgBox("���������ڼ�", MsgBoxStyle.Exclamation, "�������ݹ���")
                SWDialogBox.MessageBox.Show("$1001", "����ڼ�")
                Me.cbxTerm.Focus()
                Return
            End If

            If Not IsValidTerm(Me.cbxTerm.Text) Then
                ' MsgBox("��Ч�Ļ���ڼ�", MsgBoxStyle.Exclamation, "�������ݹ���")
                SWDialogBox.MessageBox.Show("$1003", "����ڼ�")
                Me.cbxTerm.Focus()
                Return
            End If

            If Me.cbxTerm.Items.IndexOf(Me.cbxTerm.Text) >= 0 Then
                'MsgBox("����ڼ��Ѵ���", MsgBoxStyle.Exclamation, "�������ݹ���")
                SWDialogBox.MessageBox.Show("$X051")
                Me.cbxTerm.Focus()
                Return
            End If

            he.Text = "ȡ ��(&C)"
            op_Type = OperationType.ADD_FINANCE

        Else
            he.Text = "�� ��(&N)"
            op_Type = OperationType.CANCEL_ADD_FINANCE
            Dim i As Integer
            For i = 0 To financeTables.Length - 1
                financeTables(i).Clear()
            Next
        End If

        UpdateControls()
    End Sub
    '�޸İ�ť
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim he As Button = CType(sender, Button)
        If he.Text = "�� ��(&M)" Then
            Dim tterm As String = Me.cbxTerm.Text

            If Not IsValidTerm(tterm) Then
                ' MsgBox("��Ч�Ļ���ڼ�", MsgBoxStyle.Exclamation, "�������ݹ���")
                SWDialogBox.MessageBox.Show("$1001", "����ڼ�")
                Return
            End If
            If Me.cbxTerm.Items.IndexOf(tterm) < 0 Then
                ' MsgBox("����ڼ䲻����", MsgBoxStyle.Exclamation, "�������ݹ���")
                SWDialogBox.MessageBox.Show("$X052")
                Return
            End If

            he.Text = "ȡ ��(&C)"
            op_Type = OperationType.MODIFY_FINANCE
        Else
            he.Text = "�� ��(&M)"
            op_Type = OperationType.CANCEL_MODIFY_FINANCE
            Dim i As Integer
            For i = 0 To financeTables.Length - 1
                financeTables(i).Clear()
            Next
        End If
        UpdateControls()
    End Sub
    'ɾ����ť
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim tterm As String = Me.cbxTerm.Text
        If Not IsValidTerm(tterm) Then
            'MsgBox("��Ч�Ļ���ڼ�", MsgBoxStyle.Exclamation, "�������ݹ���")
            SWDialogBox.MessageBox.Show("$1001", "����ڼ�")
            Return
        End If
        If Me.cbxTerm.Items.IndexOf(tterm) < 0 Then
            ' MsgBox("����ڼ䲻����", MsgBoxStyle.Exclamation, "�������ݹ���")
            SWDialogBox.MessageBox.Show("$X052")
            Return
        End If
        'MsgBox("��ȷ��ɾ������ڼ�" + tterm + "�Ĳ����", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "�������ݹ���")
        If SWDialogBox.MessageBox.Show("?1004", "����ڼ�" + tterm + "�Ĳ����") <> MsgBoxResult.Yes Then Return

        Dim succ As Boolean = True
        Me.Cursor = Cursors.WaitCursor
        Dim i As Integer
        For i = 0 To financeTables.Length - 1
            If financeTables(i).HasData Then
                Dim res = financeTables(i).Remove()
                If res <> "1" Then
                    'MsgBox("ɾ��" + financeTables(i).GetName() + "ʧ�ܣ�ԭ���ǣ�" + res, MsgBoxStyle.Exclamation, "�������ݹ���") '*999
                    SWDialogBox.MessageBox.Show("*999", "ɾ��" + financeTables(i).GetName() + "ʧ��", res, "�������ݹ���")
                    succ = False
                End If
            End If
        Next

        'modified by hute 2004-7-26 ��Ϊ���ڶ��������Ѿ������ṩ��ѯ���ܣ�����֮ǰ��ɾ�����еĶ����������ݣ�����û�б�Ҫɾ������
        ''ɾ�����������������������е�����
        'Dim strResult As String
        'strResult = gWs.DeleteProjectCreditQuantity(ProjCode, CorpCode, financeTables(0).GetPhase(), financeTables(0).GetTerm())
        'If Not strResult = "1" Then
        '    SWDialogBox.MessageBox.Show("*999", "ɾ��projectCreditQuantity", strResult, "")
        '    Return
        'End If
        Me.Cursor = Cursors.Default

        SWDialogBox.MessageBox.Show("$OperateSucceed")

        If succ Then
            Me.cbxTerm.Items.Remove(tterm)
            Me.cbxTerm.Text = ""
            'For i = 0 To financeTables.Length - 1
            '    financeTables(i).Clear()
            'Next
        End If
    End Sub
    '���水ť
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not IsValidTerm(Me.cbxTerm.Text) Then
            'MsgBox("��Ч�Ļ���ڼ�", MsgBoxStyle.Exclamation, "�������ݹ���")
            SWDialogBox.MessageBox.Show("$1001", "����ڼ�")
            Return
        End If

        'MsgBox("(�ʲ��ϼ�)��(��ծ��������(�ɱ�)Ȩ���ܼ�)�������ȣ�" + vbCrLf + "����������", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "�������ݹ���")
        If Not financeTables(0).ConfirmDebet() Then
            If SWDialogBox.MessageBox.Show("?X006") <> MsgBoxResult.Yes Then
                Return
            End If
        End If

        Dim i As Integer
        Dim result As String
        Dim succ As Boolean = True
        Dim pc As Cursor = Me.Cursor
        Me.Cursor = Cursors.WaitCursor
        For i = 0 To financeTables.Length - 1
            If financeTables(i).HasChanged() Then
                financeTables(i).SetArgument(Me.cbxTerm.Text, Me.cbxProjPhase.SelectedValue)
                result = financeTables(i).Save()
                If result <> "1" Then
                    'MsgBox("����" + financeTables(i).GetName() + "ʧ�ܣ�ԭ���ǣ�" + result, MsgBoxStyle.Exclamation, "�������ݹ���")
                    SWDialogBox.MessageBox.Show("*999", "����" + financeTables(i).GetName() + "ʧ�ܣ�ԭ���ǣ�", result, "�������ݹ���")
                    succ = False
                End If
            End If
        Next
        Me.Cursor = pc

        If succ Then
            'MsgBox("����ɹ���", MsgBoxStyle.Information, "�������ݹ���")
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            If op_Type = OperationType.ADD_FINANCE Then
                Me.cbxTerm.Items.Add(Me.cbxTerm.Text)
                op_Type = OperationType.CANCEL_ADD_FINANCE
                Me.btnNew.Text = "�� ��(&N)"
            ElseIf op_Type = OperationType.MODIFY_FINANCE Then
                op_Type = OperationType.CANCEL_MODIFY_FINANCE
                Me.btnModify.Text = "�� ��(&M)"
            End If

            UpdateControls()
        End If
    End Sub
    '�˳���ť
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
    '������ݸı䣬�˳���ʱ������Ƿ񱣴��޸ĵ�ѡ��
    Private Sub frmFinanceManage_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim bc As Boolean = False
        Dim i As Integer

        For i = 0 To financeTables.Length - 1
            If financeTables(i).HasChanged Then
                bc = True
                Exit For
            End If
        Next

        If bc Then
            'MsgBox("���Ѿ��޸������ݣ�Ҫ������", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question, "�������ݹ���")
            Select Case SWDialogBox.MessageBox.Show("?1002")
                Case MsgBoxResult.Yes
                    btnSave_Click(sender, e)
                Case MsgBoxResult.Cancel '���ݸı䣬ѡ��ȡ����������¼�
                    e.Cancel = True
            End Select
        End If
    End Sub

End Class
