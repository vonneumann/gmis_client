'ȡ��ί�д���
Public Class frmCancelConsignTask
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents dgConsign As System.Windows.Forms.DataGrid
    Friend WithEvents btnEntery As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csStaffName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csRoleID As DataGridComboBoxColumn
    Friend WithEvents csConsinger As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_currentTask As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCancelConsignTask))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgConsign = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csStaffName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRoleID = New MainInterface.DataGridComboBoxColumn()
        Me.csConsinger = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnEntery = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chk_currentTask = New System.Windows.Forms.CheckBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgConsign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgConsign})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 328)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ί�й�ϵ"
        '
        'dgConsign
        '
        Me.dgConsign.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dgConsign.CaptionVisible = False
        Me.dgConsign.DataMember = ""
        Me.dgConsign.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgConsign.Location = New System.Drawing.Point(3, 16)
        Me.dgConsign.Name = "dgConsign"
        Me.dgConsign.Size = New System.Drawing.Size(402, 309)
        Me.dgConsign.TabIndex = 0
        Me.dgConsign.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgConsign
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csStaffName, Me.csRoleID, Me.csConsinger})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TStaffRole"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'csStaffName
        '
        Me.csStaffName.Format = ""
        Me.csStaffName.FormatInfo = Nothing
        Me.csStaffName.HeaderText = "ί����"
        Me.csStaffName.MappingName = "staff_name"
        Me.csStaffName.NullText = ""
        Me.csStaffName.Width = 75
        '
        'csRoleID
        '
        Me.csRoleID.Format = ""
        Me.csRoleID.FormatInfo = Nothing
        Me.csRoleID.HeaderText = "��ɫ"
        Me.csRoleID.MappingName = "role_id"
        Me.csRoleID.Width = 75
        '
        'csConsinger
        '
        Me.csConsinger.Format = ""
        Me.csConsinger.FormatInfo = Nothing
        Me.csConsinger.HeaderText = "������"
        Me.csConsinger.MappingName = "consigner"
        Me.csConsinger.NullText = ""
        Me.csConsinger.Width = 75
        '
        'btnEntery
        '
        Me.btnEntery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntery.ImageIndex = 0
        Me.btnEntery.ImageList = Me.ImageList1
        Me.btnEntery.Location = New System.Drawing.Point(128, 368)
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Size = New System.Drawing.Size(77, 23)
        Me.btnEntery.TabIndex = 1
        Me.btnEntery.Text = "ȷ ��(&O)"
        Me.btnEntery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Bitmap)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 1
        Me.btnCancel.ImageList = Me.ImageList1
        Me.btnCancel.Location = New System.Drawing.Point(216, 368)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "�� ��(&X)"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_currentTask
        '
        Me.chk_currentTask.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.chk_currentTask.Location = New System.Drawing.Point(16, 336)
        Me.chk_currentTask.Name = "chk_currentTask"
        Me.chk_currentTask.Size = New System.Drawing.Size(112, 24)
        Me.chk_currentTask.TabIndex = 3
        Me.chk_currentTask.Text = "������ǰ����"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmCancelConsignTask
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(424, 397)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chk_currentTask, Me.btnCancel, Me.btnEntery, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCancelConsignTask"
        Me.Text = "����ί��"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgConsign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsStaffRole, dsRole As DataSet
    Dim tmpStaff, tmpRoleName, tmpRoleID As String
    Dim iIndex As Integer
    Public Event refreshTaskCommit()

    Private Sub frmCancelConsignTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '��ȡ������ί�е�Ա����ɫ���ݼ�
        dsStaffRole = gWs.GetStaffByRoleID("{isnull(consigner,'')<>'' }")
        'dsStaffRole.Tables(0).DefaultView.Sort = "staff_name"

        If dsStaffRole.Tables("TStaffRole").Rows.Count <= 0 Then
            Me.btnEntery.Enabled = False
            Exit Sub
        End If

        '���б�����ʾ��Ա����ɫ���ݼ�
        dgConsign.SetDataBinding(dsStaffRole, "TStaffRole")



        '��ȡ���еĽ�ɫ���ݼ�
        dsRole = gWs.GetRole("%")

        '���ý�ɫ���ݼ��ﶨ����ɫѡ�������б�
        csRoleID.ColumnComboBox.DataSource = dsRole.Tables("TRole").DefaultView
        csRoleID.ColumnComboBox.DisplayMember = "role_name"
        csRoleID.ColumnComboBox.ValueMember = "role_id"

        '�������ݱ��������
        setDgAttribute(dgConsign, Me)
    End Sub


    Private Sub btnEntery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        iIndex = dgConsign.CurrentRowIndex

        '��ȡ������,��ɫ��
        Dim tmpSrcPerson As String = dgConsign.Item(iIndex, 0)
        tmpStaff = IIf(IsDBNull(dgConsign.Item(iIndex, 2)), "", dgConsign.Item(iIndex, 2))
        tmpRoleName = Trim(dgConsign.Item(iIndex, 1))

        '�ж��Ƿ���������(���û��,���ܳ���ί��)
        If tmpStaff = "" Then
            MsgBox("û�а���ί��,���ܳ���ί��", MsgBoxStyle.Information, "ȡ��ί��")
            Exit Sub
        End If

        '��ȡ�ý�ɫ����ID��
        Dim strSql As String = "role_name='" & tmpRoleName & "'"
        tmpRoleID = dsRole.Tables(0).Select(strSql)(0).Item("role_id")

        Dim response As MsgBoxResult
        Dim strErr As String
        response = MsgBox("�Ƿ�ȷ��Ҫ����ί��!", MsgBoxStyle.YesNo, "ȡ��ί��")

        '����CancelconsignTask����ȡ��ί��
        If response = MsgBoxResult.Yes Then
            strErr = gWs.CancelconsignTask(tmpSrcPerson, tmpStaff, tmpRoleID, chk_currentTask.Checked)
            If strErr = "1" Then
                MsgBox("����ί�гɹ�!", MsgBoxStyle.Information, "ȡ��ί��")

                '�������е��������ÿ�
                strSql = "role_id='" & tmpRoleID & "' and staff_name='" & tmpSrcPerson & "'"
                dsStaffRole.Tables(0).Select(strSql)(0).Item("consigner") = DBNull.Value
                dsStaffRole.AcceptChanges()
                RaiseEvent refreshTaskCommit()

            Else
                MsgBox("����ί��ʧ��:" & strErr, MsgBoxStyle.Critical, "ȡ��ί��")
                Exit Sub
            End If
        End If

     
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
