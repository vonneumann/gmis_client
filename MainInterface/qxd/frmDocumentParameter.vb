Public Class frmDocumentParameter
    Inherits frmBasic

    Private strProjectCode As String
    Private strRelationNum As String
    Private strItemType As String
    Private strItemCode As String
    Private data() As Byte
    Private strFileName As String
    Private strFileType As String

    Private result As String '���ر�����

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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbChildType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFileType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFileTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocumentParameter))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbChildType = New System.Windows.Forms.ComboBox()
        Me.cmbFileType = New System.Windows.Forms.ComboBox()
        Me.txtFileTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.btnExit.Location = New System.Drawing.Point(191, 64)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(103, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbChildType
        '
        Me.cmbChildType.Location = New System.Drawing.Point(240, 40)
        Me.cmbChildType.Name = "cmbChildType"
        Me.cmbChildType.Size = New System.Drawing.Size(121, 20)
        Me.cmbChildType.TabIndex = 15
        Me.cmbChildType.Visible = False
        '
        'cmbFileType
        '
        Me.cmbFileType.Location = New System.Drawing.Point(89, 40)
        Me.cmbFileType.Name = "cmbFileType"
        Me.cmbFileType.Size = New System.Drawing.Size(121, 20)
        Me.cmbFileType.TabIndex = 14
        Me.cmbFileType.Visible = False
        '
        'txtFileTitle
        '
        Me.txtFileTitle.Location = New System.Drawing.Point(64, 16)
        Me.txtFileTitle.MaxLength = 50
        Me.txtFileTitle.Name = "txtFileTitle"
        Me.txtFileTitle.Size = New System.Drawing.Size(296, 21)
        Me.txtFileTitle.TabIndex = 17
        Me.txtFileTitle.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "�ļ�����"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDocumentParameter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(370, 95)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbChildType, Me.cmbFileType, Me.txtFileTitle, Me.Label4, Me.btnExit, Me.btnSave})
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDocumentParameter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�����ļ�"
        Me.ResumeLayout(False)

    End Sub

#End Region

    '����projectCode
    Public Sub setProjectCode(ByVal projectCode As String)
        Me.strProjectCode = projectCode
    End Sub
    '����relationNum
    Public Sub setRelationNum(ByVal relationNum As String)
        Me.strRelationNum = relationNum
    End Sub
    '����itemType
    Public Sub setItemType(ByVal itemType)
        Me.strItemType = itemType
    End Sub
    '����itemCode
    Public Sub setItemCode(ByVal itemCode)
        Me.strItemCode = itemCode
    End Sub
    '����fileType
    Public Sub setFileType(ByVal fileType As String)
        Me.strFileType = fileType
    End Sub
    '����fileName
    Public Sub setFileName(ByVal fileName)
        Me.strFileName = fileName
    End Sub
    '�����ļ�����
    Public Sub setFileContent(ByVal fileContent() As Byte)
        Me.data = fileContent
    End Sub
    Public Function getResult()
        Return Me.result
    End Function
    'Load����
    Private Sub frmDocumentParameter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getFileType()
        Me.txtFileTitle.Text = Me.strFileName
    End Sub
    '����ļ�����
    Private Sub getFileType()
        Dim ds As DataSet
        Dim i As Integer
        Dim strSql As String
        '�ĵ����ͣ�41��46��
        strSql = "{item_type='43' or item_type='44' or item_type='45' or item_type='46'}"
        ds = gWs.GetItemType(strSql)
        i = ds.Tables("TItemType").Rows.Count
        If i > 0 Then
            For i = 0 To i - 1
                With ds.Tables("TItemType").Rows(i)
                    Me.cmbFileType.Items.Add(.Item("type_name"))
                End With
            Next
            Me.cmbFileType.SelectedIndex = 0
        End If
    End Sub
    '
    '�ı��ļ�����ʱ��ͬʱ����������
    '
    Private Sub cmbFileType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFileType As String
        strFileType = Me.cmbFileType.Text
        getChildType(getItem_Type(strFileType))
    End Sub
    '
    '���������
    '
    Private Sub getChildType(ByVal itemType)
        Me.cmbChildType.Items.Clear()

        Dim ds As DataSet
        Dim i As Integer
        ds = gWs.GetItem("%", itemType)
        i = ds.Tables("TItem").Rows.Count
        If i > 0 Then
            For i = 0 To i - 1
                With ds.Tables("TItem").Rows(i)
                    Me.cmbChildType.Items.Add(.Item("item_name"))
                End With
            Next
            Me.cmbChildType.SelectedIndex = 0
        End If
    End Sub
    '
    '�ӱ�item_type��ͨ��type_name�� ���item_type
    '
    Private Function getItem_Type(ByVal strFileType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        ds = gWs.GetItemType("{type_name='" & strFileType & "'}")
        i = ds.Tables("TItemType").Rows.Count
        If i > 0 Then
            For i = 0 To i - 1
                With ds.Tables("TItemType").Rows(i)
                    Return .Item("item_type")
                End With
            Next
        End If
    End Function
    '
    '����
    '
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveFiles()
    End Sub
    '
    '�����ļ������ݿ�
    '
    Private Sub saveFiles()
        If Not data Is Nothing Then
            Dim ds As DataSet
            Dim dr As DataRow
            Dim strResult As String
            ds = gWs.GetProjectFileByCondition("null")
            dr = ds.Tables("TProjectFile").NewRow
            With dr
                .Item("project_code") = strProjectCode
                If strItemType = "" Then
                    .Item("item_type") = getItem_Type(Me.cmbFileType.Text)
                Else
                    .Item("item_type") = strItemType
                End If
                If strItemCode = "" Then
                    .Item("item_code") = getItemCode(Me.cmbChildType.Text)
                Else
                    .Item("item_code") = strItemCode
                End If
                .Item("relation_num") = strRelationNum
                .Item("document") = data
                .Item("title") = Me.txtFileTitle.Text
                'If Me.txtFileName.Text = "" Then
                '    .Item("file_name") = strFileName
                'Else
                '    .Item("file_name") = Me.txtFileName.Text
                'End If
                .Item("file_type") = strFileType
                '.Item("author") = Me.txtAuthor.Text
                '.Item("version") = Me.txtVersion.Text
                '.Item("file_id") = Me.txtFileID.Text
                '.Item("remark") = Me.txtRemark.Text
            End With
            ds.Tables("TProjectFile").Rows.Add(dr)
            strResult = gWs.UpdateProjectFile(ds.GetChanges())
            If "1" = strResult Then
                Me.Close()
                'MsgBox("�ļ����سɹ�!", MsgBoxStyle.Information, "��ʾ")
                SWDialogBox.MessageBox.Show("$UploadSucceed")
            Else
                'MsgBox("�ļ�����ʧ��!" & strResult, MsgBoxStyle.Critical, "��ʾ")
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            End If
            result = strResult
        Else
            'MsgBox("�ļ�����Ϊ��,����ʧ��!", MsgBoxStyle.Exclamation, "��ʾ")
            SWDialogBox.MessageBox.Show("$2004", "������")
        End If
    End Sub
    '���س������л�����
    Private Sub frmDocumentParameter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    '�˳�
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
