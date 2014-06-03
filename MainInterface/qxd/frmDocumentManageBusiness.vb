
Public Class frmDocumentManageBusiness
    Inherits MainInterface.frmDocumentManage

    '
    '�ĵ�����
    '
    'quexd 2003-4
    '

    Private strProjectCode As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strCorporationName As String
    Private strPerson As String
    Private strItemType As String
    Private strItemCode As String
    Private strProItemCode As String
    Private strProTitle As String

    Private dsFiles As DataSet
    Private strFileName As String
    Private strDir As String = "\Document\" '�����ĵ���Ŀ¼
    Private count As Integer = 0 '�ж�ѡ��Combox�Ĵ���
    Private isNewBtnClick As Boolean = False '�Ƿ�����"����"��ť

    Private bmDocument As BindingManagerBase '����� Windows �����ϰ󶨵���ͬ����Դ�����ݰ󶨿ؼ�����ͬ��
    Private isButtonEnable As Boolean = False '������Ŀ��ֹ��������ʾʱ�û�һЩ��ť
    Private isCmbTypeEnable As Boolean = False '����cmbType��Enabled����
    Private strSpace As String = "          " ' �����ĵ����滻û�����ݵı���
    Private currentIndex As Integer = 0 '��ǰѡ���е�λ��
    Private strPhase As String '��Ŀ�׶�
    Private strCorporationCode As String '��ҵ����
    '�����������������棬�������
    Private key As String() '���滻���
    Private value As New ArrayList() '�滻����
    Private isMakeDocButten As Boolean 'True�����ı䰴ťbtnMakeDoc������
    Private relationNumSucceed As String = Nothing '���سɹ�ʱ,����relationNum,���򷵻�nothing 

    Private isUpload As Boolean  '�Ƿ��������

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub
    '���ع��캯��
    Public Sub New(ByVal projectCode As String, ByVal taskID As String, ByVal corporationName As String, ByVal itemType As String, ByVal itemCode As String, ByVal user As String)
        Me.New()
        Me.strProjectCode = projectCode
        Me.strTaskID = taskID
        Me.strCorporationName = corporationName
        Me.strItemType = itemType
        Me.strItemCode = itemCode
        Me.strPerson = user
        Me.isCmbTypeEnable = True
    End Sub
    '���ع��캯��
    Public Sub New(ByVal projectCode As String, ByVal taskID As String, ByVal corporationName As String, _
        ByVal itemType As String, ByVal itemCode As String, ByVal user As String, ByVal key As String(), ByVal value As ArrayList)
        Me.New()
        Me.strProjectCode = projectCode
        Me.strTaskID = taskID
        Me.strCorporationName = corporationName
        Me.strItemType = itemType
        Me.strItemCode = itemCode
        Me.strPerson = user
        Me.key = key
        Me.value = value
        Me.isCmbTypeEnable = True
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
    Friend WithEvents uploadFileDialog As System.Windows.Forms.OpenFileDialog
    Public WithEvents btnOpen As System.Windows.Forms.Button
    Public WithEvents btnUpload As System.Windows.Forms.Button
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnMakeDoc As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocumentManageBusiness))
        Me.btnOpen = New System.Windows.Forms.Button
        Me.btnUpload = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.uploadFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.btnMakeDoc = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(504, 44)
        Me.txtAuthor.MaxLength = 10
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(184, 21)
        Me.txtAuthor.TabIndex = 4
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(504, 16)
        Me.txtVersion.MaxLength = 10
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(184, 21)
        Me.txtVersion.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, -40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 40)
        '
        'dateCreate
        '
        Me.dateCreate.Location = New System.Drawing.Point(80, -32)
        Me.dateCreate.Name = "dateCreate"
        Me.dateCreate.Size = New System.Drawing.Size(152, 21)
        Me.dateCreate.Value = New Date(2003, 3, 24, 21, 30, 44, 296)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 136)
        Me.GroupBox3.Controls.SetChildIndex(Me.Button1, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label3, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label4, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label5, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label6, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label7, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.txtTitle, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.txtAuthor, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.dateCreate, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.cmbType, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label8, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.txtVersion, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.txtRemark, 0)
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(8, 44)
        Me.Label6.Name = "Label6"
        '
        'txtRemark
        '
        Me.txtRemark.MaxLength = 100
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(648, 56)
        Me.txtRemark.TabIndex = 5
        '
        'txtCode
        '
        Me.txtCode.Name = "txtCode"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(456, 43)
        Me.Label4.Name = "Label4"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridBoolColumn1})
        Me.DataGridTableStyle1.MappingName = "TProjectFile"
        Me.DataGridTableStyle1.RowHeadersVisible = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Width = 300
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Width = 50
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Width = 90
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'dgFiles
        '
        Me.dgFiles.AccessibleName = "DataGrid"
        Me.dgFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgFiles.Name = "dgFiles"
        Me.dgFiles.Size = New System.Drawing.Size(690, 260)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Name = "Label3"
        '
        'cmbType
        '
        Me.cmbType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbType.DropDownWidth = 144
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Location = New System.Drawing.Point(40, 44)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(336, 20)
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(456, 15)
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 69)
        Me.Label7.Name = "Label7"
        '
        'txtName
        '
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(376, 21)
        '
        'GroupBox2
        '
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 280)
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(40, 16)
        Me.txtTitle.MaxLength = 50
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(336, 21)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(624, 472)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 13
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.ImageIndex = 18
        Me.btnOpen.ImageList = Me.ImageListBasic
        Me.btnOpen.Location = New System.Drawing.Point(114, 472)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(77, 24)
        Me.btnOpen.TabIndex = 7
        Me.btnOpen.Text = "�� ��(&O)"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.ImageIndex = 25
        Me.btnUpload.ImageList = Me.ImageListBasic
        Me.btnUpload.Location = New System.Drawing.Point(199, 472)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(77, 24)
        Me.btnUpload.TabIndex = 8
        Me.btnUpload.Text = "�� ��(&U)"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(284, 472)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 24)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "�� ��(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(539, 472)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMakeDoc
        '
        Me.btnMakeDoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMakeDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMakeDoc.ImageIndex = 19
        Me.btnMakeDoc.ImageList = Me.ImageListBasic
        Me.btnMakeDoc.Location = New System.Drawing.Point(11, 472)
        Me.btnMakeDoc.Name = "btnMakeDoc"
        Me.btnMakeDoc.Size = New System.Drawing.Size(95, 24)
        Me.btnMakeDoc.TabIndex = 6
        Me.btnMakeDoc.Text = "�����ĵ�(&A)"
        Me.btnMakeDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(369, 472)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "ɾ ��(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(454, 472)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 24)
        Me.btnModify.TabIndex = 11
        Me.btnModify.Text = "�� ��(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "���ļ�"
        Me.DataGridBoolColumn1.MappingName = "is_file"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 75
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'frmDocumentManageBusiness
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 503)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnMakeDoc)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmDocumentManageBusiness"
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnUpload, 0)
        Me.Controls.SetChildIndex(Me.btnOpen, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnMakeDoc, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtCode, 0)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    '���ð�ť�Ƿ����,true:����EnabledΪFalse;
    '
    Public Sub setIsButtonEnable(ByVal isButton As Boolean)
        Me.isButtonEnable = isButton
    End Sub
    '
    '���������ĵ���ť�Ƿ����,True,����;False,������
    '
    Public Sub setMakeDocEnable(ByVal isEnabled As Boolean)
        Me.btnMakeDoc.Enabled = isEnabled
        isMakeDocButten = True
    End Sub
    '
    '���سɹ�ʱ,����relationNum,���򷵻�nothing 
    '
    Public Function getUploadSucceed()
        Return relationNumSucceed
    End Function
    '
    '����TaskID�ж�ItemType���ĵ����ͬ��,������Form�ı���
    '
    Private Function setItemType(ByVal strTaskID As String)
        'If strTaskID = "DraftOutContract" Then
        If strTaskID.StartsWith("Draft") Then '"DraftOutContract"(������ͬ)����DraftLetterOfGuarantee"������������
            Me.Text = "��ͬ����"
            Return "43" '��ͬ
        Else
            'task_id �ֱ�Ϊ��Review�����ɳ��󱨸棩 ProjectAppraiseReport���������󱨸棩
            'ProjectFinishedReport��������Ŀ��ֹ���棩
            Me.Text = "�ĵ�����"
            Return "45" '�ĵ�
        End If
    End Function
    '
    'Load()
    '
    Private Sub frmDocumentManageBusiness_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            If gWs Is Nothing Then
                Exit Sub
            End If
            Try
                Me.dateCreate.Value = gWs.GetSysTime()
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            '��������,���ò�ͬ�������б�
            If strItemType = "45" Then '�ĵ�����
                Me.strItemType = setItemType(strTaskID)
                getFilesType(strItemType, strItemCode)
                Me.cmbType.Enabled = False
            ElseIf strItemType = "00" Then   '�ĵ�����
                Me.strItemType = "43"
                getFilesType("43")
            Else '��ͬ����
                Me.strProjectCode = Me.getProjectCode()
                Me.strCorporationName = Me.getCorporationName()
                Me.strWorkFlowID = Me.getWorkFlowID()
                Me.strTaskID = Me.getTaskID()
                Me.strPerson = Me.getUser()
                Me.strItemType = setItemType(strTaskID)
                getFilesType(strItemType)
            End If

            Me.txtCode.Text = strProjectCode
            Me.txtName.Text = strCorporationName
            Me.txtAuthor.Text = strPerson
            Me.txtTitle.Text = strCorporationName & Me.cmbType.Text
            strPhase = getPhase(strProjectCode)
            strCorporationCode = getCorporationCode(strProjectCode)

            '��TableStyle������ĵ�����һ��
            addFileTypeName()
            '����TextBox��Enabled����
            setTextBox(False)
            '��ȡ����ʾ�ĵ���Ϣ
            dsFiles = getFilesContent()
            If Not dsFiles Is System.DBNull.Value Then
                dgFiles.DataSource = dsFiles.Tables("TProjectFile")
                Try
                    Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                Me.dsFiles.AcceptChanges()
            End If

            If isButtonEnable Then
                setButtonEnable(False)
            Else
                '����ѡ��ļ�¼�Ƿ��������ļ�,����"��"��ť��Enabled
                setButton()
            End If
            '���ݲ�ͬ����,���ñ���
            If Me.isCmbTypeEnable Then
                If isButtonEnable Then
                    Me.Text = "�鿴" & Me.cmbType.Text
                Else
                    Me.Text = "����" & Me.cmbType.Text
                End If
            End If
            dgFiles_CurrentCellChanged(sender, e)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '
    '��TableStyles�����һ��ʾ��:type_name
    '
    Private Sub addFileTypeName()
        Dim fileType As New DataGridTextBoxColumn()
        fileType.MappingName = "type_name"
        fileType.NullText = ""
        fileType.HeaderText = "����"
        fileType.Width = 120
        dgFiles.TableStyles(0).GridColumnStyles.Add(fileType)
    End Sub
    '
    '���Item���DataSet
    '
    Private Function getItemDataSet(ByVal strItemType As String) As DataSet
        Dim ds As DataSet
        Try
            ds = gWs.GetItem("{item_type='" & strItemType & "'}", Nothing)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return ds
    End Function
    '
    '�����ݿ��а�Project_code��ȡ�ĵ�����Ϣ,�������⡢���ߡ����ڵ�
    '
    Private Function getFilesContent() As DataSet
        Dim ds As DataSet
        Dim dsItem As DataSet  '���Item�����������
        Dim i As Integer
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetProjectFileByCondition("{project_code='" & strProjectCode & "' and item_type='" & strItemType & "'}")
                dsItem = getItemDataSet(strItemType)
                ds.Tables("TProjectFile").Columns.Add("type_name", GetType(String))
                ds.Tables("TProjectFile").Columns.Add("is_file", GetType(Boolean))
                Dim j As Integer
                j = ds.Tables("TProjectFile").Rows.Count
                For j = 0 To j - 1
                    Dim str_item_code, str_item_type As String

                    If Not ds.Tables("TProjectFile").Rows(j).Item("item_code") Is System.DBNull.Value Then
                        str_item_code = ds.Tables("TProjectFile").Rows(j).Item("item_code")
                    Else
                        Exit For
                    End If

                    If Not str_item_type = ds.Tables("TProjectFile").Rows(j).Item("item_type") Is System.DBNull.Value Then
                        str_item_type = ds.Tables("TProjectFile").Rows(j).Item("item_type")
                    Else
                        Exit For
                    End If

                    If Not dsItem.Tables("TItem").Select("item_code='" & str_item_code & "' and item_type='" & str_item_type & "'")(0).Item("item_name") Is System.DBNull.Value Then
                        ds.Tables("TProjectFile").Rows(j).Item("type_name") = dsItem.Tables("TItem").Select("item_code='" & str_item_code & "' and item_type='" & str_item_type & "'")(0).Item("item_name")
                    Else
                        ds.Tables("TProjectFile").Rows(j).Item("type_name") = "δ֪���ļ�����"
                    End If

                    '�ж��Ƿ����ļ�
                    If Not ds.Tables("TProjectFile").Rows(j).Item("relation_num") Is System.DBNull.Value Then
                        ds.Tables("TProjectFile").Rows(j).Item("is_file") = True
                    Else
                        ds.Tables("TProjectFile").Rows(j).Item("is_file") = False
                    End If
                Next
            Catch ex As Exception
                'MsgBox("��ȡ�ĵ����ͳ���!" & ex.Message, MsgBoxStyle.Critical, "��ʾ")
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        Return ds
    End Function
    '
    '�����ļ��б��е�һ����¼
    '
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If Not dsFiles Is System.DBNull.Value Then
            If btnNew.Text = "�� ��(&N)" Then
                setTextBox(True)
                Me.txtTitle.Focus()
                delBinding()
                addBinding()
                addDocumentRecord()
                isNewBtnClick = True
                btnNew.Text = "ȡ ��(&C)"
                Me.dgFiles.Enabled = False
                Me.btnDelete.Enabled = False
                Me.btnModify.Enabled = False
                Me.btnUpload.Enabled = False
                Me.btnOpen.Enabled = False
                If Not isMakeDocButten Then
                    Me.btnMakeDoc.Enabled = False
                End If
            ElseIf btnNew.Text = "ȡ ��(&C)" Then

                Dim index As Integer = dsFiles.Tables("TProjectFile").Rows.Count - 1
                If index >= 0 Then
                    Dim strMaterialName As String
                    strMaterialName = dsFiles.Tables("TProjectFile").Rows(index).Item("title")
                    btnNew.Text = "�� ��(&N)"
                    Me.dgFiles.Enabled = True
                    Me.btnDelete.Enabled = True
                    Me.btnModify.Enabled = True
                    Me.btnUpload.Enabled = True
                    Me.btnOpen.Enabled = True
                    If Not isMakeDocButten Then
                        Me.btnMakeDoc.Enabled = True
                    End If
                    setTextBox(False)
                    delBinding()
                    isNewBtnClick = False

                    Me.dsFiles.RejectChanges()
                    Me.dgFiles.DataSource = Me.dsFiles.Tables("TProjectFile")
                    Try
                        Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
                setButton()
            End If
        End If
    End Sub
    '
    '��Ӱ�
    '
    Private Sub addBinding()
        Me.txtTitle.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "title")
        Me.txtAuthor.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "author")
        Me.txtVersion.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "version")
        Me.dateCreate.DataBindings.Add("Value", Me.dsFiles.Tables("TProjectFile"), "date")
        Me.txtRemark.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "remark")
        Me.cmbType.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "type_name")
    End Sub
    '
    'ɾ����
    '
    Private Sub delBinding()
        Me.txtTitle.DataBindings.Clear()
        Me.txtAuthor.DataBindings.Clear()
        Me.txtVersion.DataBindings.Clear()
        Me.dateCreate.DataBindings.Clear()
        Me.txtRemark.DataBindings.Clear()
        Me.cmbType.DataBindings.Clear()
    End Sub
    '
    '��project_file��������һ����¼
    'ͬʱ��project_document����Ҳ���һ����¼
    '
    Private Sub addDocumentRecord()
        Me.txtTitle.Text = strCorporationName & Me.cmbType.Text
        Me.txtAuthor.Text = strPerson
        Me.txtVersion.Text = "1.0"
        Me.txtRemark.Text = ""
        Dim dr As DataRow
        Dim itemCode As String
        Try
            Me.dateCreate.Value = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not Me.txtTitle.Text = "" Then
            itemCode = getItemCode(Me.cmbType.Text)
            If itemCode = "" Or itemCode Is Nothing Then
                MsgBox("������¼����!", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "������ʾ")
                Exit Sub
            End If
            dr = dsFiles.Tables("TProjectFile").NewRow

            With dr
                .Item("project_code") = strProjectCode
                .Item("item_type") = strItemType
                .Item("item_code") = itemCode
                .Item("title") = Me.txtTitle.Text
                .Item("author") = Me.txtAuthor.Text
                Try
                    .Item("date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                .Item("version") = Me.txtVersion.Text
                .Item("remark") = Me.txtRemark.Text
                .Item("type_name") = Me.cmbType.Text
                .Item("create_person") = strPerson
                Try
                    .Item("create_date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End With
            dsFiles.Tables("TProjectFile").Rows.Add(dr)

            If Not dsFiles Is System.DBNull.Value Then
                Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                Me.dgFiles.CurrentRowIndex = Me.bmDocument.Count - 1
            End If
        Else
            'MsgBox("��������������!", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$1001", "����")
            Me.txtTitle.Focus()
        End If
    End Sub
    '�ļ����͵�ѡ��
    Private Sub cmbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedValueChanged
        If Not count = 0 And isNewBtnClick Then
            Me.txtTitle.Text = Me.strCorporationName & Me.cmbType.Text
            strProTitle = Me.txtTitle.Text
            Dim dr As DataRow
            Dim i As Integer
            If Not dsFiles Is Nothing Then
                i = dsFiles.Tables("TProjectFile").Rows.Count
                If i > 0 Then
                    dr = dsFiles.Tables("TProjectFile").Rows(i - 1)
                    With dr
                        .Item("type_name") = Me.cmbType.Text
                        .Item("item_type") = strItemType
                        strProItemCode = getItemCode(Me.cmbType.Text)
                        .Item("item_code") = strProItemCode
                        .Item("title") = strCorporationName & Me.cmbType.Text
                    End With
                End If
            End If
        End If
        count = count + 1
    End Sub
    '
    '�򿪵�ǰѡ�еļ�¼���ļ�
    '
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click

        Dim index As Integer
        Dim strRelationNum As String
        Dim strSerialNum As String
        index = dgFiles.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If

        '2008-3-5 YJF ADD �ж��Ƿ�Ϊϵͳ������PDF��ͬ,�������ʹ��PDF��������
        If Not dsFiles.Tables(0).Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
            Dim strContractName As String = dsFiles.Tables(0).Rows(index).Item("title")
            strItemType = dsFiles.Tables(0).Rows(index).Item("item_type")
            strItemCode = dsFiles.Tables(0).Rows(index).Item("item_code")

            Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
            Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
            If strPDFRemark = "PDF" Then
                PrintPDF(Me.getProjectCode, strItemType, strItemCode, strContractName)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        strFileName = dsFiles.Tables(0).Rows(index).Item("title")
        If Not dsFiles.Tables(0).Rows(index).Item("relation_num") Is System.DBNull.Value Then
            strRelationNum = dsFiles.Tables(0).Rows(index).Item("relation_num")
            strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
        Else
            'MsgBox("�ü�¼δ�����ļ�����!���ܴ��ļ�.", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$X019")
            Exit Sub
        End If
        If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
        Else
            delAllFiles(Application.StartupPath & strDir)
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim docClass As New frmDocumentClass(strCorporationName)
            docClass.openFileBySerial(strSerialNum, strDir)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '
    '��ѡ�м�¼����ĳ���ļ����浽���ݿ�
    '��project_files���serial_num���ٴ�project_document���file_relation_num
    'ע��file_relation_num������ʱ�ʹ�relation_num����,������project_document��
    '
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Me.Cursor = Cursors.WaitCursor
        Dim index As Integer
        Dim strSerialNum As String
        Dim strRelationNum As String = System.DBNull.Value.ToString
        index = dgFiles.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        If Not dsFiles.Tables(0).Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
            strItemType = dsFiles.Tables(0).Rows(index).Item("item_type")
            strItemCode = dsFiles.Tables(0).Rows(index).Item("item_code")

            '2008-3-5 YJF ADD �ж��Ƿ�Ϊϵͳ������PDF��ͬ,���������ʾ���ú�ͬ��ϵͳ����,�������ء�
            Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
            Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
            If strPDFRemark = "PDF" Then
                MsgBox("�ú�ͬ��ϵͳ����,��������", MsgBoxStyle.Information, "��ͬ����")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim ds As DataSet
            Dim i As Integer
            Dim strSql As String
            strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
            Try
                ds = gWs.GetProjectDocumentByCondition(strSql)
                i = ds.Tables("TProjectDocument").Rows.Count
                If i = 1 Then
                    strRelationNum = ds.Tables("TProjectDocument").Rows(0).Item("file_relation_num")
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            'MsgBox("�ü�¼δ����!���������ļ�.", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$X020")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim docClass As New frmDocumentClass(strCorporationName)
        Dim strResult As String
        'If Me.cmbType.Text.StartsWith("�������¼��") Then
        If strItemType = "45" And strItemCode = "003" Then
            strResult = docClass.uploadDocumentForCheckRecord(strSerialNum, strRelationNum, True, False)
        Else
            strResult = docClass.uploadDocument(strSerialNum, strRelationNum, True, True)
        End If
        If strResult = "1" Then
            relationNumSucceed = strSerialNum
            dsFiles = getFilesContent()
            Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
            Me.dsFiles.AcceptChanges()
            setButton()
        End If
        Me.Cursor = Cursors.Default
    End Sub
    '
    '���ļ��б��������ļ�¼���浽���ݿ���
    '
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnNew.Text = "�� ��(&N)"
        btnModify.Text = "�� ��(&M)"
        Me.dgFiles.Enabled = True
        Me.btnNew.Enabled = True
        Me.btnModify.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnUpload.Enabled = True
        Me.btnOpen.Enabled = True
        If Not isCmbTypeEnable Then
            Me.cmbType.Enabled = True
        End If
        If Not isMakeDocButten Then
            Me.btnMakeDoc.Enabled = True
        End If
        setTextBox(False)
        'qxd add 2003-9-25
        Try
            If Me.bmDocument.Count > 0 Then
                Me.dgFiles.CurrentRowIndex = Me.bmDocument.Count - 1
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        'qxd end 
        delBinding()
        'isNewBtnClick = False
        Dim strResult As String
        Try
            '��project_document����Ӽ�¼
            addDocument()
            strResult = gWs.UpdateProjectFile(dsFiles.GetChanges())
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        '2008-6-20 yjf add ����ǰ��Ҫ���Ķ���
        BeforeSave()

        If "1" = strResult Then
            'MsgBox("����ɹ�!", MsgBoxStyle.Information, "��ʾ")
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            dsFiles.Clear()
            dsFiles = getFilesContent()
            If Not dsFiles Is System.DBNull.Value Then
                Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
                Me.dsFiles.AcceptChanges()
                Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                Me.dgFiles.CurrentRowIndex = currentIndex 'qxd modify 2003-5-22
                If isNewBtnClick Then
                    Me.dgFiles.CurrentRowIndex = Me.bmDocument.Count - 1
                End If
            End If
        Else
            'MsgBox("����ʧ��!" & strResult, MsgBoxStyle.Critical, "��ʾ")
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
        End If
        isNewBtnClick = False
        setButton()
    End Sub

    '2008-6-20 yjf add ����ǰ��Ҫ���Ķ���
    Protected Overridable Function BeforeSave()

    End Function
    '
    '��project_document������Ӽ�¼
    '
    Private Sub addDocument()
        '��project_document������Ӽ�¼
        'If strProItemCode = "" Then
        strProItemCode = getItemCode(Me.cmbType.Text)
        'End If
        If strProTitle = "" Then
            strProTitle = Me.strCorporationName & Me.cmbType.Text
        End If
        Dim itemCode As String = strProItemCode
        Dim ds As DataSet
        Dim drTemp As DataRow
        Dim i As Integer
        Dim strSql As String
        strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & itemCode & "'}"
        Try
            ds = gWs.GetProjectDocumentByCondition(strSql)
            i = ds.Tables("TProjectDocument").Rows.Count
            If i = 0 Then
                drTemp = ds.Tables("TProjectDocument").NewRow
                With drTemp
                    .Item("project_code") = strProjectCode
                    .Item("phase") = getPhase(strProjectCode)
                    .Item("item_type") = strItemType
                    .Item("item_code") = itemCode
                    .Item("doc_name") = strProTitle
                    .Item("file_relation_num") = Me.getRelationNumber()
                    ' 2003-6-4 add by qxd
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    ' add end 
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                ds.Tables("TProjectDocument").Rows.Add(drTemp)
                gWs.UpdateProjectDocument(ds.GetChanges())
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�����ĵ�
    Public Sub btnMakeDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeDoc.Click
        Dim isOpenExcel As Boolean = False '�Ƿ��Excel
        Dim docType As String '�ļ�����
        Dim ds As DataSet
        Dim i As Integer
        Dim strItemType As String
        Dim strItemCode As String
        Dim strFileType As String
        'qxd add 2003-10-30
        Dim strTemp As String

        strFileType = Me.cmbType.Text
        If strFileType = "" Then
            'MsgBox("��ѡ���ĵ�����!", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$1005", "�ĵ�����")
            Me.cmbType.Focus()
            Exit Sub
        End If
        If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
        End If
        strItemType = getItemType(strFileType)
        strItemCode = getItemCode(strFileType)
        If Not gWs Is Nothing Then
            Dim word1 As Word.ApplicationClass
            Dim excel1 As Excel.ApplicationClass
            Try
                ds = gWs.GetFileTemplateByCondition("{item_type='" & strItemType & "' and item_code ='" & strItemCode & "' and is_current_ver='1' order by version DESC}")
                i = ds.Tables("TFileTemplate").Rows.Count
                If i > 0 Then
                    With ds.Tables("TFileTemplate").Rows(0)
                        If Not .Item("template") Is System.DBNull.Value Then
                            Me.Cursor = Cursors.WaitCursor
                            Dim data As Byte() = .Item("template")
                            docType = .Item("doc_type")
                            docType = docType.Trim
                            Dim myfilestream As System.IO.FileStream
                            Dim strPath As String
                            Dim isThread As Boolean = False

                            strTemp = getLegalFileName(strCorporationName) & strFileType ' qxd add 2003-10-30
                            strPath = Application.StartupPath & strDir & strTemp
                            If docType.Trim = "doc" Then
                                strPath = strPath & ".doc"
                            Else
                                strPath = strPath & ".xls"
                            End If
                            '�ж��ļ��Ƿ����,���������ɾ��;���ɾ������,˵���ļ��Ѿ�����һ����ռ����.�򲻴����µ��ļ�
                            If System.IO.File.Exists(strPath) Then
                                Try
                                    System.IO.File.Delete(strPath)
                                Catch
                                    isThread = True
                                End Try
                            End If
                            If Not isThread Then
                                'myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                                myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create)
                                myfilestream.Write(data, 0, data.Length)
                                myfilestream.Close()
                            End If

                            Dim j As Integer
                            Dim ar As String() '�ַ�����
                            Dim replace As ArrayList '��̬����
                            '�ĵ��滻��Ǻ��滻����
                            Dim flagContent As frmFlagContentClass
                            flagContent = New frmFlagContentClass(strProjectCode, strCorporationName, strCorporationCode, strPhase)
                            '�ж����ĸ��ĵ�,��ͬ�ĵ��в�ͬ�ı��
                            Dim cmbTypeText As String
                            cmbTypeText = getSelectCase(Me.cmbType.Text)
                            Select Case cmbTypeText
                                Case "45002" '"���󱨸�(�����ʽ�����)"
                                    isOpenExcel = True
                                    ar = flagContent.getReviewDocFlag(cmbTypeText) '�õ�ģ���ĵ���������
                                    replace = flagContent.getReviewReplace(cmbTypeText) '�õ����ݿ�Ķ�Ӧ�����ǵ�����
                                Case "45102" '"���󱨸�(����)"
                                    isOpenExcel = True
                                    ar = flagContent.getReviewDocFlag(cmbTypeText) '�õ�ģ���ĵ���������
                                    replace = flagContent.getReviewReplace(cmbTypeText) '�õ����ݿ�Ķ�Ӧ�����ǵ�����
                                Case "45202"
                                    isOpenExcel = True
                                    ar = flagContent.getReviewDocFlag(cmbTypeText) '�õ�ģ���ĵ���������
                                    replace = flagContent.getReviewReplace(cmbTypeText) '�õ����ݿ�Ķ�Ӧ�����ǵ�����
                                Case "45001" '"���󱨸�"
                                    isOpenExcel = True
                                    ar = flagContent.getFirstInstanceDocFlag()
                                    replace = flagContent.getFirstInstanceReplace()
                                Case "45004" '"��Ŀ��ֹ����"
                                    ar = flagContent.getTerminateReportDocFlag()
                                    replace = flagContent.getTerminateReplace()
                                Case "45007" '"�������۱���"
                                    ar = flagContent.getEvaluateReportDocFlag()
                                    replace = flagContent.getEvaluateReplace()
                                    '���뷴�������¼��Excel��
                                    'qxd modify 2003-11-4
                                    If Not newEvaluateExcel() Then
                                        Exit Sub
                                    End If
                                Case "43005" '"��Ѻ��������ͬ"
                                    ar = flagContent.getImpawnContractFlag()
                                    replace = flagContent.getImpawnContractReplace()
                                Case "43004" '"��Ѻ��������ͬ"
                                    ar = flagContent.getPledgeContractFlag()
                                    replace = flagContent.getPledgeContractReplace()
                                Case "43003" '"��֤��ͬ"
                                    ar = flagContent.getAssureContractFlag()
                                    replace = flagContent.getAssureContractReplace()
                                Case "43006" '"��ҵ��֤��������ͬ"
                                    ar = flagContent.getAssureOppContractFlag()
                                    replace = flagContent.getAssureOppContractReplace()
                                Case "43001" '"ί�б�֤��ͬ"
                                    ar = flagContent.getDelegateContractFlag()
                                    replace = flagContent.getDelegateContractReplace()
                                Case "43002" '"ί�д����ͬ"
                                    ar = flagContent.getDelegateLoanContractFlag()
                                    replace = flagContent.getDelegateLoanContractReplace()
                                Case "43007" '"���˱�֤��ͬ"
                                    ar = flagContent.getPersonalOppContractFlag()
                                    replace = flagContent.getPersonalOppContractReplace()
                                Case "43201" '������ȱ���Э����
                                    ar = flagContent.getLetterProtocolFlag()
                                    replace = flagContent.getLetterProtocolReplace()
                                Case "43108" '��������ȷ����
                                    ar = flagContent.getLetterAffirmFlag()
                                    replace = flagContent.getLetterAffirmReplace()
                                Case "43107" '���˱�֤��ͬ(����)
                                    ar = flagContent.getLetterPledgeFlag()
                                    replace = flagContent.getLetterPledgeReplace()
                                Case "43203" '�ٵ�����ͬ
                                    ar = flagContent.getReGuaranteeFlag()
                                    replace = flagContent.getReGuaranteeReplace()
                                Case Else
                                    '  �����ĵ��滻
                                    ' "��Ŀ���������"
                                    ' "��Ŀ������"
                                    ' "��������֪ͨ��"
                                    ' "ί�зſ�֪ͨ��"
                                    ' "�����ſ�֪ͨ��"
                                    ar = key
                                    replace = value
                            End Select

                            If Not replace Is Nothing Then
                                Dim replaceCount, arLength As Integer
                                replaceCount = replace.Count
                                If Not ar Is Nothing Then
                                    arLength = ar.Length
                                Else
                                    Me.Cursor = Cursors.Default
                                    Exit Sub
                                End If
                                If replaceCount > 0 And (replaceCount = arLength) Then
                                    '��Word�ĵ�
                                    If docType.Trim = "doc" Then
                                        word1 = New Word.ApplicationClass
                                        word1.Application.Documents.Add(strPath)
                                        'word1.Application.Documents.Open(strPath)
                                        For j = 0 To arLength - 1
                                            replaceText(word1, ar(j), replace(j)) '�滻������
                                        Next
                                        '��ʾ�ĵ�
                                        'qxd modify 2003-10-30
                                        'word1.ActiveDocument.SaveAs(strPath)
                                        'word1.Caption = strTemp
                                        'qxd end 
                                        word1.Application.Visible = True
                                    Else
                                        excel1 = New Excel.ApplicationClass
                                        excel1.Application.Workbooks.Add(strPath)

                                        Dim rang As Excel.Range
                                        rang = excel1.ActiveWorkbook.Sheets(1).Cells

                                        For j = 0 To arLength - 1
                                            ReplaceExcelSign(rang, ar(j), replace(j))  '�滻������
                                        Next

                                        importSpecialData(rang, strProjectCode)
                                        excel1.Application.Visible = True
                                    End If
                                Else
                                    isOpenExcel = False
                                    'MsgBox("��ȡ��Ŀ��ҵ��Ϣ����!" & Chr(13) & "�޷�������" & strCorporationName + strFileType & "��.", MsgBoxStyle.Exclamation, "��ʾ")
                                    '''MsgBox("����Ŀ���ڣ�""" & strPhase & """ �׶�,û����Ӧ����Ŀ��ҵ��Ϣ!" & Chr(13) & "�޷�������" & strCorporationName + strFileType & "��.", MsgBoxStyle.Exclamation, "��ʾ")
                                    SWDialogBox.MessageBox.Show("$X015", strCorporationName + strFileType)
                                End If
                            Else
                                'MsgBox("����������" & strCorporationName + strFileType & "��!", MsgBoxStyle.Exclamation, "��ʾ")
                                SWDialogBox.MessageBox.Show("$X017", strCorporationName + strFileType)
                            End If

                            Me.Cursor = Cursors.Default
                        Else
                            'MsgBox("��" & strFileType & "����ģ���ļ�������!", MsgBoxStyle.Exclamation, "��ʾ")
                            SWDialogBox.MessageBox.Show("$2002", strFileType)
                        End If
                    End With
                Else
                    'MsgBox("��ǰ�汾��" & strFileType & "����ģ���ļ�������!", MsgBoxStyle.Exclamation, "��ʾ")
                    'SWDialogBox.MessageBox.Show("$2002", strFileType)
                    Dim strMessage As String = "��ǰ�汾��" & strFileType & "�����ļ�ģ�岻����!"
                    SWDialogBox.MessageBox.Show(strMessage, "ϵͳ��ʾ", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                '�رմ򿪵��ļ�
                If Not word1 Is Nothing Then
                    word1.Application.Documents.Close()
                    '�˳�Word,�Ҳ���ʾ�Ƿ񱣴�
                    CType(word1.Application, Word.ApplicationClass).Quit(Word.WdSaveOptions.wdDoNotSaveChanges)
                End If
                If Not excel1 Is Nothing Then
                    excel1.Application.Workbooks.Close()
                    '�˳�Excel,�Ҳ���ʾ�Ƿ񱣴�
                    CType(excel1.Application, Excel.ApplicationClass).Quit()
                End If
                'MsgBox("�ļ��Ѿ��򿪻��ļ�����!", MsgBoxStyle.Exclamation, "��ʾ")
                ExceptionHandler.ShowMessageBox(ex)
                Exit Sub
            Finally
                Me.Cursor = Cursors.Default
                word1 = Nothing
                excel1 = Nothing
                GC.Collect()
            End Try
        End If
        ' ֻ���ĵ�ʱ������Ҫ����Excel����ͬ����ʱ����Ҫ���룻����isOpenExcel�жϡ�qxd add 2003-5-10
        Try
            If Not Me.Name = "frmDocumentManageBusiness" Then
                Exit Sub
            End If
            If Not isOpenExcel Then
                Exit Sub
            End If
            Dim import As New frmImportDataToExcel(strProjectCode, strCorporationName)
            Dim strPhase As String
            Dim strExcelFile As String
            strExcelFile = Me.cmbType.Text
            If strExcelFile = "" Then
                strExcelFile = "�ĵ�"
            End If
            strPhase = Me.getPhase(strProjectCode)
            Dim strOppCorporationCode As String
            strOppCorporationCode = getFieldName("corporation_code", "2")
            import.importExcel(strProjectCode, strExcelFile, strPhase, "���б�", strOppCorporationCode)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            GC.Collect()
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    '�������۱���
    '���뷴�������¼��Excel��
    Private Function newEvaluateExcel()
        '���뷴�������¼��Excel��
        Dim evaExcel As New Excel.ApplicationClass
        Dim workBook As Excel.WorkbookClass
        Dim workSheet As Excel.Worksheet
        Dim rang As Excel.Range
        Dim strExcelFile As String

        'qxd modify 2003-11-4
        'strExcelFile = Application.StartupPath & "\�������۱���.xls"
        strExcelFile = Application.StartupPath & strDir & "�������۱���.xls"


        Try
            If System.IO.File.Exists(strExcelFile) Then
                System.IO.File.Delete(strExcelFile)
            End If
            'evaExcel.Application.Workbooks.Add(strExcelFile)
            evaExcel.Application.Workbooks.Add()
            evaExcel.Application.Workbooks(1).SaveAs(strExcelFile)
            workBook = evaExcel.ActiveWorkbook
            workSheet = workBook.Sheets(1)
            rang = workSheet.Cells

            workSheet.Select()
            Dim import As New frmImportDataToExcel(strProjectCode, strCorporationName)
            Dim strPhase As String
            strPhase = Me.getPhase(strProjectCode)
            import.importOppGuarantee(rang, strPhase)
            rang.Columns.AutoFit()
            evaExcel.Application.Visible = True
            Return True
        Catch ex As Exception
            'MsgBox("��ȷ����Ŀ¼" & Application.StartupPath & "�£������ļ��� ���������۱���.xls��.", MsgBoxStyle.Exclamation, "��ʾ")
            'SWDialogBox.MessageBox.Show("$2002", "�������۱���.xls")
            If Not evaExcel Is Nothing Then
                evaExcel.Application.Workbooks.Close()
                CType(evaExcel.Application, Excel.ApplicationClass).Quit()
                evaExcel = Nothing
            End If
            ExceptionHandler.ShowMessageBox(ex)
            Return False
        End Try
    End Function
    '
    '�滻�ĵ��еĵ�ָ���ַ�
    '
    Private Sub replaceText(ByVal word1 As Word.ApplicationClass, ByVal strFlag As String, ByVal strReplace As String)
        Dim docActive As Word.DocumentClass
        Dim content As Word.Range
        Dim fd As Word.Find

        docActive = word1.ActiveDocument
        content = docActive.Content
        fd = content.Find

        fd.Format = True
        'fd.MatchCase = false '�����ִ�Сд
        fd.MatchCase = True '���ִ�Сд
        fd.ClearFormatting() '�����ʽ
        fd.MatchWholeWord = True '���������ĵ���
        fd.MatchWildcards = False '�����Ұ���ͨ���
        fd.Wrap = Word.WdFindWrap.wdFindContinue '������ĩ�󣬴�ͷ��������
        'fd.Replacement.ClearFormatting() '����滻��ĸ�ʽ
        fd.Replacement.Style = Word.WdReplace.wdReplaceAll '�滻����

        Try
            If Not strReplace Is Nothing AndAlso strReplace.Length > 255 Then
                Dim strTemp As String
                Dim i As Int16
                For i = 0 To (strReplace.Length \ 230 + 1) - 2 '���һ���滻�ں������
                    strTemp = strReplace.Substring(230 * i, 230) + strFlag
                    fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strTemp, Word.WdReplace.wdReplaceAll, Nothing, Nothing, Nothing, Nothing)
                Next
                strTemp = strReplace.Substring(i * 230)
                strReplace = strTemp
            End If
            'fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strReplace)
            fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strReplace, Word.WdReplace.wdReplaceAll, Nothing, Nothing, Nothing, Nothing)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        fd = Nothing
        content = Nothing
        docActive = Nothing
    End Sub
    '
    '�滻Excel�ĵ��ı��
    '
    Private Sub ReplaceExcelSign(ByVal rang As Excel.Range, ByVal strFlag As String, ByVal strReplace As String)

        rang.Replace(strFlag, strReplace, Excel.XlLookAt.xlWhole, Excel.XlSearchOrder.xlByRows, True)
    End Sub
    '����textbox��enable����
    Private Sub setTextBox(ByVal isEnabled As Boolean)
        Me.txtTitle.Enabled = isEnabled
        Me.txtAuthor.Enabled = isEnabled
        Me.dateCreate.Enabled = isEnabled
        Me.cmbType.Enabled = isEnabled
        Me.txtVersion.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
    End Sub
    '�˳�
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '�˳�����
    Private Function frmExit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '����dataSet�ж��Ƿ��޸���
        Dim changedCount As Integer = 0
        If Not Me.dsFiles Is Nothing Then
            Try
                changedCount = Me.dsFiles.GetChanges.Tables(0).Rows.Count
            Catch
            End Try
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
    'KeyPress�¼�
    Private Sub frmDocumentManageBusiness_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing�¼�
    Private Sub frmDocumentManageBusiness_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '����Button��Enable����
    Public Sub setButtonEnable(ByVal isEnable As Boolean)
        Me.btnNew.Enabled = isEnable
        Me.btnUpload.Enabled = isEnable
        Me.btnSave.Enabled = isEnable
        Me.btnMakeDoc.Enabled = isEnable
        Me.btnDelete.Enabled = isEnable
        Me.btnModify.Enabled = isEnable
        Me.btnOpen.Enabled = isEnable
    End Sub
    'ɾ��
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not Me.dsFiles Is Nothing Then
            'If MsgBoxResult.OK = MsgBox("ȷ��ɾ��ѡ�еļ�¼��?", MsgBoxStyle.Question + MsgBoxStyle.OKCancel, "��ʾ") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "ѡ�е�") Then
                Dim i As Integer
                i = Me.dgFiles.CurrentRowIndex
                If i >= 0 Then
                    Dim projectCode, itemType, itemCode, relationNum As String
                    With Me.dsFiles.Tables("TProjectFile").Rows(i)
                        projectCode = .Item("project_code")
                        itemType = .Item("item_type")
                        itemCode = .Item("item_code")
                        If Not .Item("relation_num") Is System.DBNull.Value Then
                            relationNum = .Item("relation_num")
                        Else
                            relationNum = System.DBNull.Value.ToString
                        End If
                        .Delete()
                    End With
                    'ͬʱɾ��project_document�еļ�¼
                    Dim nDelCount As Integer
                    Dim strSql As String
                    strSql = "project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'"
                    nDelCount = Me.dsFiles.Tables("TProjectFile").Select(strSql).Length()
                    If nDelCount = 0 Then '��ʾ��һ����¼
                        delectDocument(projectCode, itemType, itemCode)

                        '2008-2-20 yjf add ����ĵ�����Ϊ��ͬ��ͬʱɾ����ͬҪ�ؼ�¼
                        delectElement(projectCode, itemType, itemCode)
                    End If


                    Try
                        gWs.UpdateProjectFile(Me.dsFiles.GetChanges())
                    Catch
                    End Try

                    dsFiles = getFilesContent()
                    If Not dsFiles Is System.DBNull.Value Then
                        dgFiles.DataSource = dsFiles.Tables("TProjectFile")
                        Me.dsFiles.AcceptChanges()
                    End If
                    Try
                        Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
            End If
            setButton()
        End If
    End Sub
    '
    'ͬʱɾ��project_document�еļ�¼
    '
    Private Function delectDocument(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String)
        Dim dsDocument As DataSet
        Dim strSql As String
        Dim i As Integer
        Try
            If gWs Is Nothing Then
                Exit Function
            End If
            strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}"
            dsDocument = gWs.GetProjectDocumentByCondition(strSql)
            i = dsDocument.Tables("TProjectDocument").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dsDocument.Tables("TProjectDocument").Rows(i).Delete()
                Next
                gWs.UpdateProjectDocument(dsDocument)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    'ͬʱɾ��project_contract_element�еļ�¼
    '
    Private Function delectElement(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String)
        Dim dsElement As DataSet
        Dim strSql As String
        Dim i As Integer
        Try
            If gWs Is Nothing Then
                Exit Function
            End If
            strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}"
            dsElement = gWs.GetProjectContractElementInfo(strSql)
            i = dsElement.Tables(0).Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dsElement.Tables(0).Rows(i).Delete()
                Next
                gWs.UpdateProjectContractElement(dsElement)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '����datagrid�����¼�
    Private Sub setTextContent()
        currentIndex = Me.dgFiles.CurrentCell.RowNumber
        Static lastRow As Integer = -1
        Me.dgFiles.Select(Me.dgFiles.CurrentCell.RowNumber)

        If Me.dgFiles.CurrentRowIndex <> lastRow Then
            Dim index As Integer = dgFiles.CurrentRowIndex()
            If index >= 0 Then
                Dim strMaterialName As String
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("title") Is System.DBNull.Value Then
                    strMaterialName = dsFiles.Tables("TProjectFile").Rows(index).Item("title")
                    Me.txtTitle.Text = strMaterialName
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("author") Is System.DBNull.Value Then
                    Me.txtAuthor.Text = dsFiles.Tables("TProjectFile").Rows(index).Item("author")
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("date") Is System.DBNull.Value Then
                    Me.dateCreate.Value = dsFiles.Tables("TProjectFile").Rows(index).Item("date")
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("item_code") Is System.DBNull.Value Then
                    Me.cmbType.Text = getItemName(strItemType, dsFiles.Tables("TProjectFile").Rows(index).Item("item_code"))
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("remark") Is System.DBNull.Value Then
                    Me.txtRemark.Text = dsFiles.Tables("TProjectFile").Rows(index).Item("remark")
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("version") Is System.DBNull.Value Then
                    Me.txtVersion.Text = dsFiles.Tables("TProjectFile").Rows(index).Item("version")
                End If
            End If
        End If
        setButton()
        lastRow = Me.dgFiles.CurrentRowIndex
    End Sub
    '�б��е���갴���¼�
    'Private Sub dgFiles_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgFiles.MouseUp
    '    If Me.dsFiles.Tables("TProjectFile").Rows.Count > 0 Then
    '        Me.dgFiles.Select(Me.dgFiles.CurrentCell.RowNumber)
    '        setTextContent()
    '    End If
    'End Sub
    Private Sub dgFiles_CurrentCellChanged(ByVal send As Object, ByVal e As System.EventArgs) Handles dgFiles.CurrentCellChanged
        If Me.dsFiles.Tables("TProjectFile").Rows.Count > 0 Then
            Me.dgFiles.Select(Me.dgFiles.CurrentCell.RowNumber)
            setTextContent()
        End If
    End Sub

    '
    '�����Ƿ����ļ�,ȷ��"��","����","ɾ��"��ť������
    '
    Protected Sub setButton()
        Dim dt As DataTable
        Try
            dt = CType(Me.dgFiles.DataSource, DataTable)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    If Not isButtonEnable Then
                        'Me.btnUpload.Enabled = True
                        Me.btnDelete.Enabled = True
                    End If
                    If dt.Rows(Me.dgFiles.CurrentRowIndex).Item("relation_num") Is System.DBNull.Value Then
                        Me.btnOpen.Enabled = False
                        isUpload = True
                        'Me.btnUpload.Enabled = True
                    Else
                        Me.btnOpen.Enabled = True
                        'Me.btnUpload.Enabled = False
                        isUpload = False
                    End If
                Else
                    Me.btnUpload.Enabled = False
                    Me.btnDelete.Enabled = False
                    Me.btnOpen.Enabled = False
                    Me.btnModify.Enabled = False
                End If
            Else
                Me.btnUpload.Enabled = False
                Me.btnDelete.Enabled = False
                Me.btnOpen.Enabled = False
                Me.btnModify.Enabled = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        setIsOperate(isUpload)
    End Sub
    '
    '��������,�����Ƿ���Խ���:ɾ��,�޸�,���ز���.
    '
    Private Sub setIsOperate(ByVal isUpload As Boolean)
        'ȥ�������ж�   by 9sky 20050705
        'If Not Me.cmbType.Enabled Then
        Dim dt As DataTable
        Try
            dt = CType(Me.dgFiles.DataSource, DataTable)
            If dt.Rows.Count > 0 Then
                If dt.Rows(Me.dgFiles.CurrentRowIndex).Item("type_name") = Me.cmbType.Text Then
                    If Not isButtonEnable Then
                        Me.btnDelete.Enabled = True
                        Me.btnModify.Enabled = True
                        'if������͵��ж�---------------------------------------qxd 
                        'ȥ�������ж�   by 9sky 20050701
                        'If Me.cmbType.Text.StartsWith("���󱨸�") Or Me.cmbType.Text.StartsWith("���󱨸�") Then
                        If isUpload Then
                            Me.btnUpload.Enabled = True
                            Me.btnDelete.Enabled = True
                        Else
                            Me.btnUpload.Enabled = False
                            Me.btnDelete.Enabled = False
                        End If
                        'Else
                        '    Me.btnUpload.Enabled = True
                        '    Me.btnDelete.Enabled = True
                        'End If
                    End If
                Else
                    Me.btnDelete.Enabled = False
                    Me.btnModify.Enabled = False
                    Me.btnUpload.Enabled = False
                    Me.cmbType.Enabled = False
                End If
            Else
                Me.btnDelete.Enabled = False
                Me.btnModify.Enabled = False
                Me.btnUpload.Enabled = False
                Me.cmbType.Enabled = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        'End If
    End Sub
    '�޸�
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If Not Me.dsFiles Is Nothing Then
            If btnModify.Text = "�� ��(&M)" Then
                Me.btnDelete.Enabled = False
                Me.btnNew.Enabled = False
                Me.btnOpen.Enabled = False
                Me.btnUpload.Enabled = False
                If Not isMakeDocButten Then
                    Me.btnMakeDoc.Enabled = False
                End If
                Me.cmbType.Enabled = False
                Me.dgFiles.Enabled = False
                currentIndex = Me.dgFiles.CurrentRowIndex
                'qxd add 2003-5-14
                Me.dgFiles.Select(currentIndex)
                setTextBox(True)
                Me.cmbType.Focus()
                delBinding()
                addBinding()
                btnModify.Text = "ȡ ��(&C)"
            ElseIf btnModify.Text = "ȡ ��(&C)" Then
                Me.btnDelete.Enabled = True
                Me.btnNew.Enabled = True
                Me.btnOpen.Enabled = True
                Me.btnUpload.Enabled = True
                If Not isMakeDocButten Then
                    Me.btnMakeDoc.Enabled = True
                End If
                If Not isCmbTypeEnable Then
                    Me.cmbType.Enabled = True
                End If
                Me.dgFiles.Enabled = True
                setTextBox(False)
                btnModify.Text = "�� ��(&M)"
                Me.dsFiles.RejectChanges()
                Me.dgFiles.Refresh() 'qxd add 2003-6-7
                delBinding()
                setButton()
            End If
        End If
    End Sub
    '���project_corporation�е��ֶ�ֵ
    Private Function getFieldName(ByVal fieldName As String, ByVal corporationType As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                'strSql = "{project_code='" & strProjectCode & "' and phase='����' and corporation_type='1'}"
                'ds = gWs.FetchProjectCorporationEx(strSql)
                'ds = gWs.FetchProjectCorporation(strProjectCode, "%", corporationType, "����")
                ds = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '��ҵ����
                        If Not .Item(fieldName) Is System.DBNull.Value Then
                            Return .Item(fieldName)
                        Else
                            Return ""
                        End If
                    End With
                Else
                    Return ""
                End If
            Catch ex As Exception
                Return ""
            End Try
        End If
    End Function
    'ͨ���ĵ����ͻ�ȡSelectCase���ж��������ж�����Ϊ��item_type & item_code
    Private Function getSelectCase(ByVal strFileType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Dim strSelectCase As String

        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetItem("{item_name='" & strFileType & "'}", Nothing)
                i = ds.Tables("TItem").Rows.Count
                If i > 0 Then
                    With ds.Tables("TItem").Rows(0)
                        strSelectCase = .Item("item_type")
                        strSelectCase = strSelectCase.Trim & .Item("item_code")
                    End With
                    Return strSelectCase.Trim
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function

    '�������¼��
    Private Sub importSpecialData(ByVal rang As Excel.Range, ByVal projectCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FQueryCreditProject(projectCode.Substring(0, 5), "", "", "2099-1-1", "", "", "", UserName)
            If Not ds Is Nothing Then
                Dim d1, d2 As Double
                d1 = 0 : d2 = 0
                For Each dr In ds.Tables(0).Rows
                    d1 += CDbl(IIf(IsDBNull(dr("guarantee_sum")), 0, dr("guarantee_sum")))
                    d2 += CDbl(IIf(IsDBNull(dr("surplus_total")), 0, dr("surplus_total")))
                Next
                '���ӺϼƼ�¼
                dr = ds.Tables(0).NewRow
                dr("service_type") = "�ϼ�"
                dr("guarantee_sum") = d1
                dr("surplus_total") = d2
                ds.Tables(0).Rows.Add(dr)

                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    rang.Item(34 + i, 2) = dr("service_type") & String.Empty
                    rang.Item(34 + i, 3) = dr("guarantee_sum") & String.Empty
                    rang.Item(34 + i, 4) = dr("terms") & String.Empty
                    rang.Item(34 + i, 5) = dr("end_date") & String.Empty
                    rang.Item(34 + i, 6) = dr("surplus_total") & String.Empty
                    rang.Item(34 + i, 7) = dr("bank") & String.Empty
                    rang.Item(34 + i, 8) = dr("branch_bank") & String.Empty
                    rang.Item(34 + i, 9) = String.Empty
                Next
                ds.Dispose()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim index As Integer
        Dim strSerialNum As String
        Dim strRelationNum As String = System.DBNull.Value.ToString
        index = dgFiles.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        If Not dsFiles.Tables(0).Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
            strItemType = dsFiles.Tables(0).Rows(index).Item("item_type")
            strItemCode = dsFiles.Tables(0).Rows(index).Item("item_code")

            '2008-3-5 YJF ADD �ж��Ƿ�Ϊϵͳ������PDF��ͬ,���������ʾ���ú�ͬ��ϵͳ����,�������ء�
            Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
            Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
            If strPDFRemark = "PDF" Then
                MsgBox("�ú�ͬ��ϵͳ����,��������", MsgBoxStyle.Information, "��ͬ����")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim ds As DataSet
            Dim i As Integer
            Dim strSql As String
            strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
            Try
                ds = gWs.GetProjectDocumentByCondition(strSql)
                i = ds.Tables("TProjectDocument").Rows.Count
                If i = 1 Then
                    strRelationNum = ds.Tables("TProjectDocument").Rows(0).Item("file_relation_num")
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            'MsgBox("�ü�¼δ����!���������ļ�.", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$X020")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim docClass As New frmDocumentClass(strCorporationName)
        Dim strResult As String
        'If Me.cmbType.Text.StartsWith("�������¼��") Then
        If strItemType = "45" And strItemCode = "003" Then
            strResult = docClass.uploadDocumentForCheckRecord(strSerialNum, strRelationNum, True, False)
        Else
            strResult = docClass.uploadDocument(strSerialNum, strRelationNum, True, True)
        End If
        If strResult = "1" Then
            relationNumSucceed = strSerialNum
            dsFiles = getFilesContent()
            Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
            Me.dsFiles.AcceptChanges()
            setButton()
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class
