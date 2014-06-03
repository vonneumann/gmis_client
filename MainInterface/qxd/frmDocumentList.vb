Public Class frmDocumentList
    Inherits System.Windows.Forms.Form

    Private strDir As String
    Private strCorporationName As String
    Private isCellFrist As Boolean = False '�ж��Ƿ��ǵ�һ��Cell
    Private lastRow As Integer = -1 '�ж��Ƿ���datagrid�е�ͬһ��
    Private IsHidePanel As Boolean = False '�ж��Ƿ�����Panel

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub
    Public Sub New(ByVal corporationName As String)
        Me.New()
        Me.strCorporationName = corporationName
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgFile As System.Windows.Forms.DataGrid
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ImageBox1 As SWSystem.Windows.Forms.ImageBox
    Friend WithEvents pictureView1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureView As SWSystem.Windows.Forms.ImageBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocumentList))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgFile = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pictureView = New SWSystem.Windows.Forms.ImageBox()
        Me.pictureView1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDelete, Me.btnLast, Me.btnNext, Me.btnView, Me.btnExit})
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 351)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(722, 40)
        Me.Panel3.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 3
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(232, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "ɾ ��(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnLast
        '
        Me.btnLast.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), System.Drawing.Bitmap)
        Me.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLast.ImageIndex = 1
        Me.btnLast.ImageList = Me.ImageList1
        Me.btnLast.Location = New System.Drawing.Point(608, 9)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(82, 23)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "��һ��(&L)"
        Me.btnLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNext
        '
        Me.btnNext.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Bitmap)
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.ImageIndex = 2
        Me.btnNext.ImageList = Me.ImageList1
        Me.btnNext.Location = New System.Drawing.Point(520, 9)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(82, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "��һ��(&N)"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Bitmap)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 4
        Me.btnView.ImageList = Me.ImageList1
        Me.btnView.Location = New System.Drawing.Point(320, 8)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(77, 24)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "�� ��(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(409, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "�� ��(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3})
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 351)
        Me.Panel2.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgFile})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 343)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "�ļ��б�"
        '
        'dgFile
        '
        Me.dgFile.AllowSorting = False
        Me.dgFile.CaptionVisible = False
        Me.dgFile.DataMember = ""
        Me.dgFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFile.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFile.Location = New System.Drawing.Point(3, 17)
        Me.dgFile.Name = "dgFile"
        Me.dgFile.ReadOnly = True
        Me.dgFile.Size = New System.Drawing.Size(346, 323)
        Me.dgFile.TabIndex = 0
        Me.dgFile.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.ToolTip1.SetToolTip(Me.dgFile, "˫�����ļ�")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.dgFile
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectFile"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "�ļ���"
        Me.DataGridTextBoxColumn1.MappingName = "file_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "����"
        Me.DataGridTextBoxColumn6.MappingName = "title"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 200
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "�ļ�����"
        Me.DataGridTextBoxColumn2.MappingName = "file_type"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "�汾"
        Me.DataGridTextBoxColumn3.MappingName = "version"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "��ע"
        Me.DataGridTextBoxColumn4.MappingName = "remark"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "����"
        Me.DataGridTextBoxColumn5.MappingName = "author"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(360, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(2, 351)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2})
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(362, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 351)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel4})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 343)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ͼƬ���"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.AddRange(New System.Windows.Forms.Control() {Me.pictureView})
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(338, 323)
        Me.Panel4.TabIndex = 0
        '
        'pictureView
        '
        Me.pictureView.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.pictureView.Location = New System.Drawing.Point(8, 8)
        Me.pictureView.Name = "pictureView"
        Me.pictureView.Size = New System.Drawing.Size(320, 304)
        Me.pictureView.TabIndex = 0
        Me.pictureView.Text = "ImageBox2"
        Me.pictureView.WatchBounds = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'pictureView1
        '
        Me.pictureView1.Location = New System.Drawing.Point(32, 344)
        Me.pictureView1.Name = "pictureView1"
        Me.pictureView1.Size = New System.Drawing.Size(449, 402)
        Me.pictureView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureView1.TabIndex = 0
        Me.pictureView1.TabStop = False
        '
        'frmDocumentList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(722, 391)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel1, Me.Splitter1, Me.Panel2, Me.Panel3})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocumentList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "���ļ�"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '��ʾɾ����ť(Ŀǰ�涨ֻ�е�����鿴ͼƬʱ�˰�ť����ʾ)
    Public Sub ShowDeleteButton()
        btnDelete.Visible = True
    End Sub

    '
    '�����ĵ�Ŀ¼
    '
    Public Sub setDir(ByVal dir As String)
        Me.strDir = dir
    End Sub
    '
    '����ͼƬ��ʾ��Panel
    '
    Public Sub setViewBox()
        Me.IsHidePanel = True
        setBtnEnabled(False)
        Me.Panel1.Dock = DockStyle.None
        Me.Width = Me.Width - Me.Panel1.Width
        Me.Panel1.Width = 0
        Me.WindowState = FormWindowState.Normal
        Me.MaximizeBox = False
        Me.DataGridTextBoxColumn1.Width = 0
        Me.DataGridTextBoxColumn6.Width = 200
        Me.DataGridTextBoxColumn3.Width = 75
        Me.DataGridTextBoxColumn4.Width = 120
        Me.DataGridTextBoxColumn5.Width = 75
        Me.Text = "�򿪸���Ŀ���а汾���ļ�"
    End Sub
    '��ʾͼƬ��Panel
    Private Sub setVisible()
        Me.IsHidePanel = False
        Me.Panel1.Width = 360
        Me.Width = Me.Width + Me.Panel1.Width
        Me.Panel1.Dock = Dock.Fill
        'Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
        'Me.MaximizeBox = True
        Me.Text = "���ļ�"
        Me.Refresh()
    End Sub

    Private Sub ShowContractElement()

        '��ȡ��ѡ��¼����Ŀ���롢��ͬ���͡���ͬ���롢��ͬ����
        Dim iIndex As Integer = dgFile.CurrentRowIndex
        Dim dr As DataRow = CType(dgFile.DataSource, DataTable).Rows(iIndex)
        Dim strItemType As String = dr.Item("item_type")
        Dim strItemCode As String = dr.Item("item_code")
        Dim strItemTpeItemCode As String = strItemType & strItemCode
        Dim strProjectCode As String = dr.Item("project_code")
        Dim strContractName As String = dr.Item("title")

        Dim frmApply As frmCommonContract = New frmCommonContract(Me.strCorporationName, strContractName, strItemType, strItemCode, strProjectCode)
        'frmApply.btnPrint.Visible = True
        frmApply.btnSave.Enabled = False
        frmApply.DataGridTableStyle1.ReadOnly = True
        frmApply.ShowDialog()

    End Sub


    '���ĵ���word,excel����ͼƬ
    'Open��Ĭ��Ŀ¼�����ļ�����ԭ�ļ�����ͬ��
    'Add���ļ���Ϊ"�ĵ�*(1,2����)"��Ŀ¼��ȷ��
    '
    Private Sub showDocument(ByVal fileName As String, ByVal fileType As String)
        Dim strPath As String
        If fileType.Trim() = "jpg" Or fileType.Trim() = "gif" Or fileType.Trim() = "bmp" Or fileType.Trim() = "jpeg" _
            Or fileType.Trim() = "JPG" Or fileType.Trim() = "GIF" Or fileType.Trim() = "BMP" Or fileType.Trim() = "JPEG" Then
            strPath = fileName
        Else
            strPath = Application.StartupPath & strDir & "\" & getLegalFileName(strCorporationName) & getLegalFileName(fileName)
        End If
        If fileType.Trim() = "doc" Then
            Dim word1 As Word.ApplicationClass
            Try
                word1 = New Word.ApplicationClass()
                word1.Application.Documents.Open(strPath)
                'word1.Application.Documents.Add(strPath)
                word1.Application.Visible = True
            Catch ex As Exception
                '�رմ򿪵��ļ�
                word1.Application.Documents.Close()
                '�˳�Word,�Ҳ���ʾ�Ƿ񱣴�
                CType(word1.Application, Word.ApplicationClass).Quit(Word.WdSaveOptions.wdDoNotSaveChanges)
                'MsgBox("�ļ��Ѿ��򿪻��ļ�����!", MsgBoxStyle.Exclamation, "��ʾ")
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                word1 = Nothing
                GC.Collect()
            End Try
        ElseIf fileType.Trim() = "xls" Then
            Dim excel1 As Excel.ApplicationClass
            Try
                excel1 = New Excel.ApplicationClass()
                'excel1.Application.Workbooks.Open(strPath)
                excel1.Application.Workbooks.Add(strPath)
                excel1.Application.Visible = True
            Catch ex As Exception
                '�رմ򿪵��ļ�
                excel1.Application.Workbooks.Close()
                '�˳�Excel,�Ҳ���ʾ�Ƿ񱣴�
                CType(excel1.Application, Excel.ApplicationClass).Quit()
                'MsgBox("�ļ��Ѿ��򿪻��ļ�����!", MsgBoxStyle.Exclamation, "��ʾ")
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                excel1 = Nothing
                GC.Collect()
            End Try
        ElseIf fileType.Trim() = "jpg" Or fileType.Trim() = "gif" Or fileType.Trim() = "bmp" Or fileType.Trim() = "jpeg" _
            Or fileType.Trim() = "JPG" Or fileType.Trim() = "GIF" Or fileType.Trim() = "BMP" Or fileType.Trim() = "JPEG" Then
            Try
                If Me.IsHidePanel Then
                    Me.setVisible()
                End If

                pictureView.Image = New Bitmap(strPath)
                pictureView.setPicturePath(strPath) 'qxd add 2004-8-23
                pictureView.Refresh()
            Catch ex As Exception
                pictureView.Dispose()
                'MsgBox("ͼƬ�ļ���ȡ����!", MsgBoxStyle.Critical, "��ʾ")
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                GC.Collect()
            End Try
        Else
            Try
                System.Diagnostics.Process.Start(strPath)
            Catch ex As Exception
                'MsgBox("ͼƬ�ļ���ȡ����!", MsgBoxStyle.Critical, "��ʾ")
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                GC.Collect()
            End Try
            'Else
            '    'MsgBox("�ļ�����δ֪,�޷���!", MsgBoxStyle.Critical, "��ʾ")
            '    SWDialogBox.MessageBox.Show("$2003", "")
        End If

    End Sub

    ''
    ''�ƶ����¼�
    ''
    'Private Sub dgFile_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgFile.CurrentCellChanged
    '    If Not isCellFrist Then

    '        Me.dgFile.Select(Me.dgFile.CurrentCell.RowNumber)
    '        Me.dgFile.Refresh()
    '        If Me.dgFile.CurrentRowIndex <> lastRow Then
    '            dgFileDeal()
    '        End If
    '        lastRow = Me.dgFile.CurrentRowIndex
    '        isCellFrist = True
    '    End If
    'End Sub
    '
    '����dg����¼�
    '
    Private Sub dgFileDeal()
        Me.Cursor = Cursors.WaitCursor
        Dim strFileName As String
        Dim strFileType As String
        Dim strItemType As String
        Dim strPath As String

        Try

            'strFileType = CType(Me.dgFile.DataSource, DataTable).Rows(dgFile.CurrentRowIndex).Item("file_type")
            strItemType = CType(Me.dgFile.DataSource, DataTable).Rows(dgFile.CurrentRowIndex).Item("item_type")
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        If strItemType = "43" Then

            '2008-3-5 YJF ADD �ж��Ƿ�Ϊϵͳ������PDF��ͬ,�������ʹ��PDF��������
            Dim dtFiles As DataTable = CType(Me.dgFile.DataSource, DataTable)
            If Not dtFiles.Rows(dgFile.CurrentRowIndex).Item("serial_num") Is System.DBNull.Value Then
                Dim strSerialNum As String = dtFiles.Rows(dgFile.CurrentRowIndex).Item("serial_num")
                Dim strContractName As String = dtFiles.Rows(dgFile.CurrentRowIndex).Item("title")
                Dim strProjectCode As String = dtFiles.Rows(dgFile.CurrentRowIndex).Item("project_code")
                Dim strItemCode As String = dtFiles.Rows(dgFile.CurrentRowIndex).Item("item_code")

                Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
                Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
                If strPDFRemark = "PDF" Then
                    ShowContractElement()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    If Not System.IO.Directory.Exists(Application.StartupPath & "\Document\") Then
                        System.IO.Directory.CreateDirectory(Application.StartupPath & "\Document\")
                    Else
                        delAllFiles(Application.StartupPath & "\Document\")
                    End If
                    Try
                        Me.Cursor = Cursors.WaitCursor
                        Dim docClass As New frmDocumentClass(strCorporationName)
                        docClass.openFileBySerial(strSerialNum, "\Document\")
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    Finally
                        Me.Cursor = Cursors.Default
                    End Try
                End If
            End If

        Else
            Try
                'strFileName = CType(Me.dgFile.DataSource, DataTable).Rows(dgFile.CurrentRowIndex).Item("title")
                strFileName = CType(Me.dgFile.DataSource, DataTable).Rows(dgFile.CurrentRowIndex).Item("file_name")
                strFileType = CType(Me.dgFile.DataSource, DataTable).Rows(dgFile.CurrentRowIndex).Item("file_type")
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            'qxd add start 2004-8-23'''''''''''''''''''''''''''
            If strFileType.Trim() = "jpg" Or strFileType.Trim() = "gif" Or strFileType.Trim() = "bmp" Or strFileType.Trim() = "jpeg" _
                Or strFileType.Trim() = "JPG" Or strFileType.Trim() = "GIF" Or strFileType.Trim() = "BMP" Or strFileType.Trim() = "JPEG" Then

                Dim index As Integer
                Dim strTemp, strNewFileName As String
                Dim strEnding As String
                strPath = Application.StartupPath & strDir & "\" & getLegalFileName(strCorporationName) & getLegalFileName(strFileName)

                strEnding = ".jpg1"
                index = strPath.IndexOf(".")
                strTemp = strPath.Substring(0, index)
                strNewFileName = strTemp & strEnding

                If Not System.IO.File.Exists(strNewFileName) Then
                    System.IO.File.Move(strPath, strNewFileName)
                End If
                strFileName = strNewFileName
            End If
            ''qxd add end 2004-8-23'''''''''''''''''''''''''''

            showDocument(strFileName, strFileType)

        End If

        Me.Cursor = Cursors.Default
    End Sub
    '�˳�
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        pictureView.Image = Nothing
        'qxd add 2003-5-24���˳�ʱ������pictureView
        pictureView.Dispose()
        Me.Close()
    End Sub

    '�б�����갴���¼�
    Private Sub dgFile_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgFile.MouseUp
        If CType(Me.dgFile.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgFile.Select(Me.dgFile.CurrentCell.RowNumber)
            setButton()
        End If
    End Sub
    '˫��dgDataGrid
    Private Sub dgFile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFile.DoubleClick
        setButton()
        dgFileDeal()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        setButton()
        dgFileDeal()
    End Sub

    'Private Sub frmDocumentList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    '    If Me.IsHidePanel Then
    '        e.Graphics.DrawLine(New System.Drawing.Pen(System.Drawing.Color.DimGray), New PointF(Panel1.Left, Panel1.Top), New PointF(Me.Left + Me.Width, Me.Top + Panel1.Height))
    '        e.Graphics.DrawLine(New System.Drawing.Pen(System.Drawing.Color.White), New PointF(Panel1.Left, Panel1.Top), New PointF(Me.Left + Me.Width, Me.Top + Panel1.Height))

    '    End If
    'End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim count, curIndex As Integer
        count = CType(Me.dgFile.DataSource, DataTable).Rows.Count
        curIndex = Me.dgFile.CurrentRowIndex
        If curIndex = count - 1 Then
            Me.btnNext.Enabled = False
        Else
            Me.btnNext.Enabled = True
        End If

        If curIndex < count Then
            Me.dgFile.CurrentRowIndex = curIndex + 1
        End If

        If Me.dgFile.CurrentRowIndex >= 1 Then
            Me.btnLast.Enabled = True
        Else
            Me.btnLast.Enabled = False
        End If

        If Me.dgFile.CurrentRowIndex = count - 1 Then
            Me.btnNext.Enabled = False
        End If
        dgFileDeal()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Dim count, curIndex As Integer
        count = CType(Me.dgFile.DataSource, DataTable).Rows.Count
        curIndex = Me.dgFile.CurrentRowIndex

        If curIndex >= 1 Then
            Me.btnLast.Enabled = True
        Else
            Me.btnLast.Enabled = False
        End If

        If curIndex > 0 Then
            Me.dgFile.CurrentRowIndex = curIndex - 1
        End If

        If Me.dgFile.CurrentRowIndex = count - 1 Then
            Me.btnNext.Enabled = False
        Else
            Me.btnNext.Enabled = True
        End If

        If Me.dgFile.CurrentRowIndex = 0 Then
            Me.btnLast.Enabled = False
        End If
        dgFileDeal()
    End Sub

    Private Sub setBtnEnabled(ByVal flag As Boolean)
        Me.btnNext.Visible = flag
        Me.btnLast.Visible = flag
    End Sub

    Private Sub frmDocumentList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim count, curIndex As Integer
        count = CType(Me.dgFile.DataSource, DataTable).Rows.Count
        curIndex = Me.dgFile.CurrentRowIndex
        If count <= 1 Then
            Me.btnNext.Enabled = False
        End If
        Me.btnLast.Enabled = False

        If Not Me.dgFile.DataSource Is Nothing Then
            CType(Me.dgFile.DataSource, DataTable).DataSet.AcceptChanges()
        End If
    End Sub

    Private Sub setButton()
        Dim count, curIndex As Integer
        count = CType(Me.dgFile.DataSource, DataTable).Rows.Count
        curIndex = Me.dgFile.CurrentRowIndex

        If curIndex = count - 1 Then
            Me.btnNext.Enabled = False
        Else
            Me.btnNext.Enabled = True
        End If

        If Me.dgFile.CurrentRowIndex >= 1 Then
            Me.btnLast.Enabled = True
        Else
            Me.btnLast.Enabled = False
        End If

        Me.btnDelete.Enabled = Not Me.dgFile.DataSource Is Nothing AndAlso count > 0
    End Sub

    'add by xie on 10/9/2004
    'Description:ɾ����ӦͼƬ
    '˵��:1.����dgFile������Դ�ڴ��ݽ���֮ǰ�Ѿ��޸Ĺ�,�ұ�Acceptchanges,�ʲ���ֱ��ɾ��dgFile������Դ�ٸ���
    '     2.��ȡ��ʽΪ��ȡ��Ӧ��¼��Serial_num,ֱ�Ӱ�������¼�����ݿ��л�ȡ����ɾ��,dgFile��ɾ����ֻ��һ����ʽ����
    '     3.ɾ����Ĵ���,���ڼ�¼ɾ����,��Ӧ�ı�(����opposite_guarantee,�������һ������,������Ƿ�������,�Ͳ�֪��
    '       �Ǹ���,�������޶�,ֻ�����ڲ鿴��������ͼƬ�Ǵ˰�ť�ſɼ�)�е�relation_num����ֵ,����ɾ��

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If Me.dgFile.DataSource Is Nothing Then Exit Sub
        Dim dt As DataTable = CType(Me.dgFile.DataSource, DataTable)

        If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "ѡ�е�") Then
            Dim strResult, strWhere As String
            If Me.dgFile.CurrentRowIndex > -1 Then
                Dim strSerialNum, strProjectCode, strItemType, strItemCode, strRelationNum As String
                Dim dr As DataRow = dt.Rows(Me.dgFile.CurrentRowIndex)
                strSerialNum = dr.Item("serial_num").ToString()
                strProjectCode = dr.Item("Project_code").ToString()
                strItemType = dr.Item("item_type").ToString()
                strItemCode = dr.Item("item_code").ToString()
                strRelationNum = dr.Item("relation_num").ToString()

                Dim dsProjectFile As DataSet
                dsProjectFile = gWs.GetProjectFileByCondition("{serial_num='" + strSerialNum + "'}")
                dsProjectFile.Tables(0).Rows(0).Delete()
                strResult = gWs.UpdateProjectFile(dsProjectFile)

                If strResult <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                Else
                    Me.pictureView.Image = Nothing
                    dt.Rows(Me.dgFile.CurrentRowIndex).Delete()
                    dt.DataSet.AcceptChanges()

                    'strWhere = "{project_code='" + strProjectCode + "' and relation_num='" + strRelationNum + "'}"
                    'dsProjectFile = gWs.GetProjectFileByCondition(strWhere)

                    If dt.Rows.Count = 0 Then
                        Dim dsOpp As DataSet
                        strWhere = "{project_code='" + strProjectCode + "' and file_relation_num='" + strRelationNum + "'}"
                        dsOpp = gWs.GetGuarantyInfo(strWhere, "")
                        If dsOpp.Tables(0).Rows.Count = 1 Then
                            dsOpp.Tables(0).Rows(0).Item("file_relation_num") = System.DBNull.Value
                            strResult = gWs.UpdateGuaranty(dsOpp)
                            If strResult <> "1" Then
                                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                            End If
                        End If
                    End If
                End If
                Me.setButton()
            End If
        End If
    End Sub
End Class
