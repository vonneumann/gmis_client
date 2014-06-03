Imports SZCGC.DocumentManager

Public Class frmCommonContract
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    Private strContractType, strContractCode, strProjectCode As String

    Public Sub New(ByVal CorporationName As String, ByVal ContractName As String, ByVal ContractType As String, ByVal ContractCode As String, ByVal ProjectCode As String)
        MyBase.new()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        Me.txtCorporationName.Text = CorporationName
        Me.txtContractName.Text = Trim(ContractName)
        strContractType = ContractType
        strContractCode = ContractCode
        strProjectCode = ProjectCode
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtContractName As System.Windows.Forms.TextBox
    Friend WithEvents dgProjectContractElement As System.Windows.Forms.DataGrid
    Public WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents btnEstate As System.Windows.Forms.Button
    Public WithEvents btnChattel As System.Windows.Forms.Button
    Public WithEvents btnCar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommonContract))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtContractName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCorporationName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgProjectContractElement = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnChattel = New System.Windows.Forms.Button
        Me.btnEstate = New System.Windows.Forms.Button
        Me.btnCar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgProjectContractElement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtContractName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCorporationName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtContractName
        '
        Me.txtContractName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContractName.Enabled = False
        Me.txtContractName.Location = New System.Drawing.Point(384, 22)
        Me.txtContractName.Name = "txtContractName"
        Me.txtContractName.Size = New System.Drawing.Size(536, 21)
        Me.txtContractName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(320, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "��ͬ���ƣ�"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Enabled = False
        Me.txtCorporationName.Location = New System.Drawing.Point(80, 22)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(232, 21)
        Me.txtCorporationName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��ҵ���ƣ�"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgProjectContractElement)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(944, 480)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgProjectContractElement
        '
        Me.dgProjectContractElement.CaptionVisible = False
        Me.dgProjectContractElement.DataMember = ""
        Me.dgProjectContractElement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProjectContractElement.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProjectContractElement.Location = New System.Drawing.Point(3, 17)
        Me.dgProjectContractElement.Name = "dgProjectContractElement"
        Me.dgProjectContractElement.Size = New System.Drawing.Size(938, 460)
        Me.dgProjectContractElement.TabIndex = 0
        Me.dgProjectContractElement.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgProjectContractElement
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "project_contract_element"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Ҫ������"
        Me.DataGridTextBoxColumn1.MappingName = "element_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 230
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Ҫ��ֵ"
        Me.DataGridTextBoxColumn2.MappingName = "element_value"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 665
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
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
        Me.ImageListBasic.Images.SetKeyName(25, "")
        Me.ImageListBasic.Images.SetKeyName(26, "")
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(872, 560)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "�� ��(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(784, 560)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "�� ��(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.ImageIndex = 23
        Me.btnPrint.ImageList = Me.ImageListBasic
        Me.btnPrint.Location = New System.Drawing.Point(368, 560)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Ԥ ��(&P)"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChattel
        '
        Me.btnChattel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChattel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChattel.ImageIndex = 24
        Me.btnChattel.ImageList = Me.ImageListBasic
        Me.btnChattel.Location = New System.Drawing.Point(570, 560)
        Me.btnChattel.Name = "btnChattel"
        Me.btnChattel.Size = New System.Drawing.Size(96, 24)
        Me.btnChattel.TabIndex = 19
        Me.btnChattel.Text = "�豸�嵥(&C)"
        Me.btnChattel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEstate
        '
        Me.btnEstate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEstate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstate.ImageIndex = 24
        Me.btnEstate.ImageList = Me.ImageListBasic
        Me.btnEstate.Location = New System.Drawing.Point(677, 560)
        Me.btnEstate.Name = "btnEstate"
        Me.btnEstate.Size = New System.Drawing.Size(96, 24)
        Me.btnEstate.TabIndex = 20
        Me.btnEstate.Text = "�����嵥(&E)"
        Me.btnEstate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCar
        '
        Me.btnCar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCar.ImageIndex = 24
        Me.btnCar.ImageList = Me.ImageListBasic
        Me.btnCar.Location = New System.Drawing.Point(464, 560)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(96, 24)
        Me.btnCar.TabIndex = 21
        Me.btnCar.Text = "�����嵥(&A)"
        Me.btnCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCommonContract
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(960, 590)
        Me.Controls.Add(Me.btnCar)
        Me.Controls.Add(Me.btnEstate)
        Me.Controls.Add(Me.btnChattel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCommonContract"
        Me.Text = "��ͬҪ��"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgProjectContractElement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private strDir As String = "\Document\" '�����ĵ���Ŀ¼
    Private dsContractElementTemplate, dsProjectContractElement, dsProjectContractEstate, dsProjectContractChattel, dsProjectContractCar As DataSet
    'Private encryptionKey As String

    Private Sub frmCommonContract_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '��ȡ��Ŀ��ͬҪ��
        Dim strSql As String
        Dim strReplaceData As String
        strSql = "{project_code='" & strProjectCode & "' and contract_name='" & Trim(Me.txtContractName.Text) & "' and item_type='" & strContractType & "' and item_code='" & strContractCode & "'}"
        dsProjectContractElement = gWs.GetProjectContractElementInfo(strSql)
        If dsProjectContractElement.Tables(0).Rows.Count = 0 Then

            '��ȡ��ͬҪ��ģ��
            strSql = "select * from contract_element_template where item_type='" & strContractType & "' and item_code='" & strContractCode & "'"
            dsContractElementTemplate = gWs.GetCommonQueryInfo(strSql)

            Dim i As Integer
            Dim dr, drElement As DataRow
            For i = 0 To dsContractElementTemplate.Tables(0).Rows.Count - 1
                drElement = dsContractElementTemplate.Tables(0).Rows(i)
                dr = dsProjectContractElement.Tables(0).NewRow()
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("item_type") = strContractType
                    .Item("item_code") = strContractCode
                    .Item("contract_name") = Trim(Me.txtContractName.Text)
                    .Item("element_num") = drElement.Item("element_num")
                    .Item("element_name") = drElement.Item("element_name")

                    '2008-6-19 yjf add �滻�������ݼ�ҵ������
                    If IsDBNull(drElement.Item("element_replace_data")) = False Then
                        .Item("element_value") = Me.ReplaceData(drElement.Item("element_replace_data"))
                    Else
                        .Item("element_value") = drElement.Item("element_default_value")
                    End If

                    .Item("element_type") = drElement.Item("element_type")
                    .Item("element_from") = drElement.Item("element_from")
                    .Item("element_bookmark") = drElement.Item("element_bookmark")
                    .Item("element_relation_bookmark") = drElement.Item("element_relation_bookmark")

                End With
                dsProjectContractElement.Tables(0).Rows.Add(dr)
            Next
        End If

        '2008-6-19 yjf add �滻�������ݼ�ҵ������
        dgProjectContractElement.DataSource = dsProjectContractElement.Tables(0)
        setDgAttribute(dgProjectContractElement, Me)
        setDgDeleteAttribute(dgProjectContractElement, Me)

        '���ݺ�ͬ���������б�ť
        Dim EstateList() As String = {"403", "604"}
        Dim ChattelList() As String = {"404", "605"}
        Dim CarList() As String = {"405", "406"}

        If EstateList.IndexOf(EstateList, strContractCode) = -1 Then
            Me.btnEstate.Enabled = False
        End If

        If ChattelList.IndexOf(ChattelList, strContractCode) = -1 Then
            Me.btnChattel.Enabled = False
        End If

        If CarList.IndexOf(CarList, strContractCode) = -1 Then
            Me.btnCar.Enabled = False
        End If

        ''2008-08-11 yjf add ��ȡ������Կ
        'encryptionKey = gWs.GetCommonQueryInfo("select top 1 encryption_key from encryption_key").Tables(0).Rows(0).Item("encryption_key")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strResult As String = gWs.UpdateProjectContractElement(dsProjectContractElement)
        If (strResult = "1") Then
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            dsProjectContractElement.AcceptChanges()
        Else
            SWDialogBox.MessageBox.Show("*999", "����ʧ��", strResult, "")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Dim objDoc As New CCWordApp

        'ɾ��DOCUMENTĿ¼���е��ļ���
        Dim strPath As String = Application.StartupPath & strDir
        delAllFiles(strPath)

        Dim strSql As String = "{project_code='" & strProjectCode & "' and contract_name='" & Trim(Me.txtContractName.Text) & "'}"
        dsProjectContractEstate = gWs.GetProjectContractEstateElementInfo(strSql)
        dsProjectContractChattel = gWs.GetProjectContractChattelElementInfo(strSql)
        dsProjectContractCar = gWs.GetProjectContractCarElementInfo(strSql)


        '��ȡ��ͬģ��
        Dim ds As DataSet
        Dim docType As String
        Dim i As Integer
        Try
            ds = gWs.GetFileTemplateByCondition("{item_type='" & strContractType & "' and item_code ='" & strContractCode & "' and is_current_ver='1' order by version DESC}")
            i = ds.Tables("TFileTemplate").Rows.Count
            If i > 0 Then
                With ds.Tables("TFileTemplate").Rows(0)
                    If Not .Item("template") Is System.DBNull.Value Then
                        Me.Cursor = Cursors.WaitCursor
                        Dim data As Byte() = .Item("template")
                        docType = .Item("doc_type")
                        docType = docType.Trim
                        Dim myfilestream As System.IO.FileStream
                        Dim strTemp As String
                        Dim isThread As Boolean = False

                        'strTemp = getLegalFileName(Me.txtCorporationName.Text) & Me.txtContractName.Text ' qxd add 2003-10-30
                        strTemp = Me.txtContractName.Text ' qxd add 2003-10-30

                        strPath = Application.StartupPath & strDir & strTemp
                        If docType.Trim.ToUpper = "DOC" Then
                            strPath = strPath & ".doc"
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


                        If docType.Trim.ToUpper = "DOC" Then
                            'word1 = New Word.ApplicationClass()
                            'word1.Application.Documents.Add(strPath)
                            ''qxd modify 2003-10-30
                            ''word1.ActiveDocument.SaveAs(strPath)
                            'word1.Caption = strTemp
                            ''qxd end 
                            'word1.Application.Visible = True
                            objDoc.Open(strPath)
                        End If
                    Else

                        'MsgBox("��ǰ�汾��" & strFileType & "����ģ���ļ�������!", MsgBoxStyle.Exclamation, "��ʾ")
                        'SWDialogBox.MessageBox.Show("$2002", strFileType)
                        Dim strMessage As String = "��ǰ�汾��" & Me.txtContractName.Text & "�����ļ�ģ�岻����!"
                        SWDialogBox.MessageBox.Show(strMessage, "ϵͳ��ʾ", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                    End If
                End With
            End If
        Catch ex As Exception
            '�رմ򿪵��ļ�
            objDoc.Quit()
            'MsgBox("�ļ��Ѿ��򿪻��ļ�����!", MsgBoxStyle.Exclamation, "��ʾ")
            ExceptionHandler.ShowMessageBox(ex)
            Exit Sub
        Finally
            Me.Cursor = Cursors.Default
            GC.Collect()
        End Try




        '����Ŀ��ͬҪ���滻��ͬģ���BOOKMARK��ǣ�
        Dim objDocGernerate As New DocumentGenerator
        Try
            objDocGernerate.GenerateDocument(Me.dsProjectContractElement, dsProjectContractEstate, dsProjectContractChattel, dsProjectContractCar, objDoc)
        Catch ex As Exception
            objDoc.Quit()
            ExceptionHandler.ShowMessageBox(ex)
            Exit Sub
        End Try

        Try
            '2008-08-08 yjf add �ĵ���Ӵ��屣��
            objDoc.FormProtect(encryptionKey)

            '�������ɵĺ�ͬWORD�ĵ���
            objDoc.SaveAs(strPath)

            ''����ͬ��WORD�ĵ�ת��ΪPDF�ĵ����򿪣�
            'objDoc.SaveAsPdf(strPath)

        Catch ex As Exception
            'objDoc.Quit()
            'objDoc = Nothing
            'GC.Collect()
            'ExceptionHandler.ShowMessageBox(ex)
            MsgBox("�ú�ͬ�Ѵ�,���ȹر�", MsgBoxStyle.Information)
            Exit Sub
        Finally
            objDoc.Quit()
            objDoc = Nothing
            GC.Collect()
        End Try

        '2008-08-11 yjf add �����ɵ�WORD��ͬ
        System.Diagnostics.Process.Start(strPath)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnEstate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstate.Click
        Dim frmApply As frmEstateContract = New frmEstateContract(strProjectCode, Trim(Me.txtContractName.Text), dsProjectContractEstate)
        If Me.DataGridTableStyle1.ReadOnly Then
            frmApply.DataGridTableStyle1.ReadOnly = True
            frmApply.btnSave.Visible = False
            frmApply.btnClear.Visible = False
        Else
            frmApply.DataGridTableStyle1.ReadOnly = False
            frmApply.btnSave.Visible = True
            frmApply.btnClear.Visible = True
        End If
        frmApply.ShowDialog()
    End Sub

    Private Sub btnChattel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChattel.Click
        Dim frmApply As frmChattelContract = New frmChattelContract(strProjectCode, Trim(Me.txtContractName.Text), dsProjectContractEstate)
        If Me.DataGridTableStyle1.ReadOnly Then
            frmApply.DataGridTableStyle1.ReadOnly = True
            frmApply.btnSave.Visible = False
            frmApply.btnClear.Visible = False
        Else
            frmApply.DataGridTableStyle1.ReadOnly = False
            frmApply.btnSave.Visible = True
            frmApply.btnClear.Visible = True
        End If
        frmApply.ShowDialog()
    End Sub

    Private Sub btnCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCar.Click
        Dim frmApply As frmCarContract = New frmCarContract(strProjectCode, Trim(Me.txtContractName.Text), dsProjectContractEstate)
        If Me.DataGridTableStyle1.ReadOnly Then
            frmApply.DataGridTableStyle1.ReadOnly = True
            frmApply.btnSave.Visible = False
            frmApply.btnClear.Visible = False
        Else
            frmApply.DataGridTableStyle1.ReadOnly = False
            frmApply.btnSave.Visible = True
            frmApply.btnClear.Visible = True
        End If
        frmApply.ShowDialog()
    End Sub

    Private Function ReplaceData(ByVal ReplaceFlag As String) As String
        Select Case ReplaceFlag
            Case "corporation_name"
                Return Me.txtCorporationName.Text

        End Select
    End Function

    Private Sub dgProjectContractElement_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProjectContractElement.CurrentCellChanged
        '2008-6-19 yjf add �滻�������ݼ�ҵ������
        Dim i As Integer
        Dim dr As DataRow
        Dim strRelationBookMark As String
        For i = 0 To dsProjectContractElement.Tables(0).Rows.Count - 1
            dr = dsProjectContractElement.Tables(0).Rows(i)
            If IsDBNull(dr.Item("element_relation_bookmark")) = False Then
                strRelationBookMark = dr.Item("element_relation_bookmark")
                dr.Item("element_value") = dsProjectContractElement.Tables(0).Select("element_bookmark='" & strRelationBookMark & "'")(0).Item("element_value")
            End If
        Next
    End Sub
End Class
