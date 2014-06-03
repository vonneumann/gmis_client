Public Class frmDocumentClass

    '
    'Author quexd 
    'Create date 2003-4-10
    '
    Private strCorporationName As String
    Private strFileName As String  '�ļ�����
    Private strFileType As String '�ļ�����
    Private isDocument As Boolean = False

    '���캯��
    Public Sub New()
    End Sub
    Public Sub New(ByVal corporationName As String)
        Me.strCorporationName = corporationName
    End Sub
    '�����ж��Ƿ�ʱDoc�ĵ�
    Public Sub setIsDocument(ByVal isDoc As Boolean)
        Me.isDocument = isDoc
    End Sub
    '
    '�����ļ�
    'projectCode  ��Ŀ����
    'relationNum �ļ���������
    'itemType 
    'itemCode
    'isSetParameter �Ƿ������������� ��true ,�򵯳�һ���öԻ���false ,ֱ�ӱ��浽project_files 
    '
    Public Function uploadDocument(ByVal projectCode As String, ByVal relationNum As String, ByVal itemType As String, ByVal itemCode As String, ByVal isSetParameter As Boolean, ByVal isWordOrPicture As Boolean, ByVal isWordOrExcel As Boolean)
        Dim data() As Byte
        data = getFileContent("", "Document", isWordOrPicture, isWordOrExcel)
        If Not data Is Nothing Then
            If isSetParameter Then
                Dim docParameter As New frmDocumentParameter()
                docParameter.setProjectCode(projectCode)
                docParameter.setRelationNum(relationNum)
                docParameter.setItemType(itemType)
                docParameter.setItemCode(itemCode)
                docParameter.setFileContent(data)
                docParameter.setFileName(strFileName)
                docParameter.setFileType(strFileType)
                docParameter.AllowTransparency = False
                docParameter.ShowDialog()
                Return docParameter.getResult()
            Else
                Dim ds As DataSet
                Dim dr As DataRow
                Dim strResult As String
                Try
                    ds = gWs.GetProjectFileByCondition("null")
                Catch
                End Try
                If Not ds Is Nothing Then
                    dr = ds.Tables("TProjectFile").NewRow
                    With dr
                        .Item("project_code") = projectCode
                        .Item("item_type") = itemType
                        .Item("item_code") = itemCode
                        .Item("relation_num") = relationNum
                        .Item("document") = data
                        .Item("file_name") = strFileName
                        .Item("file_type") = strFileType
                    End With
                    ds.Tables("TProjectFile").Rows.Add(dr)
                    strResult = gWs.UpdateProjectFile(ds.GetChanges())
                    If "1" = strResult Then
                        'MsgBox("�ļ����سɹ�!", MsgBoxStyle.Information, "�����ļ�")
                        SWDialogBox.MessageBox.Show("$UploadSucceed")
                    Else
                        'MsgBox("�ļ�����ʧ��!" & strResult, MsgBoxStyle.Critical, "�����ļ�")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                    Return strResult
                End If
            End If
        End If
    End Function
    '
    '�����ĵ�
    'serialNum ,relationNum
    '
    Public Function uploadDocument(ByVal serialNum As String, ByVal relationNum As String, ByVal isWordOrPicture As Boolean, ByVal isWordOrExcel As Boolean)
        Dim data() As Byte
        data = getFileContent("", "Document", isWordOrPicture, isWordOrExcel)
        If Not data Is Nothing Then
            Dim ds As DataSet
            Dim dr As DataRow
            Dim strResult As String
            Dim strSql As String
            Try
                strSql = "{serial_num='" & serialNum & "'}"
                ds = gWs.GetProjectFileByCondition(strSql)
            Catch
            End Try
            If Not ds Is Nothing Then
                If ds.Tables("TProjectFile").Rows.Count = 1 Then
                    dr = ds.Tables("TProjectFile").Rows(0)
                    With dr
                        If Not relationNum = "" Then
                            .Item("relation_num") = relationNum
                        End If
                        .Item("document") = data
                        .Item("file_name") = strFileName
                        .Item("file_type") = strFileType
                    End With
                    strResult = gWs.UpdateProjectFile(ds.GetChanges())
                    If "1" = strResult Then
                        'MsgBox("�ļ����سɹ�!", MsgBoxStyle.Information, "�����ļ�")
                        SWDialogBox.MessageBox.Show("$UploadSucceed")
                    Else
                        'MsgBox("�ļ�����ʧ��!" & strResult, MsgBoxStyle.Critical, "�����ļ�")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                    Return strResult
                End If
            End If
        End If
    End Function

    Public Function uploadDocumentForCheckRecord(ByVal serialNum As String, ByVal relationNum As String, ByVal isWordOrPicture As Boolean, ByVal isWordOrExcel As Boolean)
        Dim data() As Byte
        data = getFileContent("", "Document", isWordOrPicture, isWordOrExcel)
        '2008-5-28 yjf edit �ϴ��������¼��ʱ���±������¼���ĵ��������
        Dim dsCheckRecord As DataSet
        Dim i As Integer

        If Not data Is Nothing Then
            Dim ds As DataSet
            Dim dr As DataRow
            Dim strResult As String
            Dim strSql As String
            Dim strProjectCode As String
            Try
                strSql = "{serial_num='" & serialNum & "'}"
                ds = gWs.GetProjectFileByCondition(strSql)
            Catch
            End Try
            If Not ds Is Nothing Then
                If ds.Tables("TProjectFile").Rows.Count = 1 Then
                    dr = ds.Tables("TProjectFile").Rows(0)
                    With dr
                        '2008-5-28 yjf edit �ϴ��������¼��ʱ���±������¼���ĵ��������
                        strProjectCode = dr.Item("project_code")

                        If Not relationNum = "" Then
                            .Item("relation_num") = relationNum
                        End If
                        .Item("document") = data
                        .Item("file_name") = strFileName
                        .Item("file_type") = strFileType
                    End With

                    '2008-5-28 yjf edit �ϴ��������¼��ʱ���±������¼���ĵ��������
                    strSql = "{project_code='" & strProjectCode & "' and file_relation_num is null}"
                    dsCheckRecord = gWs.GetCheckRecordInfo(strSql, "")
                    For i = 0 To dsCheckRecord.Tables(0).Rows.Count - 1
                        dsCheckRecord.Tables(0).Rows(i).Item("file_relation_num") = serialNum
                    Next
                    strResult = gWs.UpdateCheckRecordAlarm(dsCheckRecord)


                    strResult = gWs.UpdateProjectFile(ds.GetChanges())
                    If "1" = strResult Then
                        'MsgBox("�ļ����سɹ�!", MsgBoxStyle.Information, "�����ļ�")
                        SWDialogBox.MessageBox.Show("$UploadSucceed")
                    Else
                        'MsgBox("�ļ�����ʧ��!" & strResult, MsgBoxStyle.Critical, "�����ļ�")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                    Return strResult
                End If
            End If
        End If
    End Function
    '
    '���ô��ļ��Ի��������,�����ش��ļ�������
    '����ֵ���ͣ�Byte()
    '
    Public Function getFileContent(ByVal strDialogTitle As String, ByVal strRelativePath As String, ByVal isWordOrPicture As Boolean, ByVal isWordOrExcel As Boolean)
        Dim uploadFilesDialog As New OpenFileDialog

        If strDialogTitle = "" Then
            uploadFilesDialog.Title = "�����ļ������ݿ�"
        Else
            uploadFilesDialog.Title = strDialogTitle
        End If
        If isWordOrPicture Then
            '"Word�ĵ�(*.doc)|*.doc|Excel�ĵ�(*.xls)|*.xls|�����ļ�(*.*)|*.*"
            If isWordOrExcel Then
                uploadFilesDialog.Filter = "Word�ĵ�(*.doc)|*.doc|PDF�ĵ�(*.pdf)|*.pdf|Excel�ĵ�(*.xls)|*.xls|TXT(*.txt)|*.txt|�����ļ�(*.*)|*.*"
            Else
                'uploadFilesDialog.Filter = "Excel�ĵ�(*.xls)|*.xls|Word�ĵ�(*.doc)|*.doc|TXT(*.txt)|*.txt|�����ļ�(*.*)|*.*"
                uploadFilesDialog.Filter = "Excel�ĵ�(*.xls)|*.xls|PDF�ĵ�(*.pdf)|*.pdf|Word�ĵ�(*.doc)|*.doc|TXT(*.txt)|*.txt|�����ļ�(*.*)|*.*"
            End If
        Else
            uploadFilesDialog.Filter = "JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|λͼBMP(*.bmp)|*.bmp|�����ļ�(*.*)|*.*"
        End If
        uploadFilesDialog.Multiselect = False '�������ѡ�ļ�
        If uploadFilesDialog.ShowDialog() = DialogResult.OK Then
            Dim strFileNameTemp, strFileNameAll As String
            strFileNameTemp = uploadFilesDialog.FileName
            strFileNameAll = strFileNameTemp.Substring(strFileNameTemp.LastIndexOf("\") + 1, strFileNameTemp.Length - strFileNameTemp.LastIndexOf("\") - 1)
            Try
                If strFileNameAll.LastIndexOf(".") > 0 Then
                    strFileName = strFileNameAll.Substring(0, strFileNameAll.LastIndexOf("."))
                    strFileType = strFileNameAll.Substring(strFileNameAll.LastIndexOf(".") + 1, strFileNameAll.Length - strFileNameAll.LastIndexOf(".") - 1)
                Else
                    strFileName = strFileNameAll
                    strFileType = "*"
                End If
            Catch
            Finally
            End Try

            Dim myfilestream As System.IO.FileStream
            Dim isReadOnly As Boolean = False

            '����ļ�����Ϊ��ReadOnly�����ȸ�Ϊ��Normal��Ȼ���ٸĻأ�ReadOnly
            If System.IO.File.GetAttributes(strFileNameTemp).ToString.ToUpper.StartsWith("ReadOnly".ToUpper) Then
                isReadOnly = True
                System.IO.File.SetAttributes(strFileNameTemp, IO.FileAttributes.Normal) '�޸��ļ�������Ϊ��Normal
            End If

            Try
                'myfilestream = New System.IO.FileStream(strFileNameAll, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                myfilestream = New System.IO.FileStream(strFileNameTemp, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
            Catch ex As Exception
                'MsgBox("�ļ�����Ϊֻ��,�޷�����!", MsgBoxStyle.Exclamation, "��ʾ")
                SWDialogBox.MessageBox.Show("$X018")
            Finally
                If isReadOnly Then
                    'System.IO.File.SetAttributes(strFileNameAll, IO.FileAttributes.ReadOnly) '�޸��ļ�������Ϊ��ReadOnly
                    System.IO.File.SetAttributes(strFileNameTemp, IO.FileAttributes.ReadOnly) '�޸��ļ�������Ϊ��ReadOnly
                End If
            End Try

            If Not (myfilestream Is Nothing) Then
                Dim data() As Byte
                ReDim data(myfilestream.Length - 1) 'ReDim�����̼��������·�����������Ĵ洢�ռ�
                myfilestream.Read(data, 0, myfilestream.Length)
                myfilestream.Close()
                Return data
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function
    '����ļ�������
    Public Function getFileType()
        Return strFileType
    End Function
    '
    '�趨���·���ĸ�ʽ:��"\"��ͷ
    '
    Public Function getRelativePath(ByVal relativePath As String) As String
        Dim len As Integer
        len = relativePath.Length
        Try
            If len > 1 Then
                If relativePath.Substring(1, 1) = ":" Then
                    Return relativePath.Substring(2, len - 3)
                ElseIf Not relativePath.Substring(0, 1) = "\" Then
                    Return "\" + relativePath
                Else
                    Return relativePath
                End If
            ElseIf len = 1 Then
                If Not relativePath.Substring(0, 1) = "\" Then
                    Return "\" + relativePath
                Else
                    Return relativePath
                End If
            Else
                Return relativePath
            End If
        Catch ex As Exception
            'MsgBox("�������·��ʱ�ַ�ת������" & ex.Message, MsgBoxStyle.Exclamation, "�����ļ�")
            'SWDialogBox.MessageBox.Show("$2002")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    'ͨ��serialNum ����ļ�������
    '
    Public Function openFileBySerial(ByVal serialNum As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        '�趨���·���ĸ�ʽ:��"\"��ͷ
        strDir = getRelativePath(relativePath)
        Try
            ds = gWs.GetProjectFileByCondition("{serial_num='" & serialNum & "'}")
        Catch ex As Exception
            'MsgBox("�ļ��Ѿ��򿪻��߻�ȡ�ļ�����ʱ����!" & ex.Message, MsgBoxStyle.Exclamation, "��ȡ�ļ�")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            '�����ݿ����ļ����ݣ����ڳ��������µ�strDirĿ¼�����ɸ��ļ�
            dsFile = getDataFromDataBase(ds, strDir)
            Dim strFileName As String
            Dim strFileType As String
            Try
                strFileName = dsFile.Tables("TProjectFile").Select("serial_num='" & serialNum & "'")(0).Item("file_name")
                strFileType = strFileName.Substring(strFileName.LastIndexOf(".") + 1, strFileName.Length - strFileName.LastIndexOf(".") - 1)
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            Me.showDocument(strCorporationName & strFileName, strFileType, strDir)
        End If
    End Function
    '
    'ͨ��relationNum ����ļ�������
    '
    Public Function openFileByRelation(ByVal relationNum As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        strDir = getRelativePath(relativePath)
        Try
            ds = gWs.GetProjectFileByCondition("{relation_num='" & relationNum & "'}")
        Catch ex As Exception
            'MsgBox("�ļ��Ѿ��򿪻��߻�ȡ�ļ�����ʱ����!" & ex.Message, MsgBoxStyle.Exclamation, "��ȡ�ļ�")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            dsFile = getDataFromDataBase(ds, strDir)
            listDocument(dsFile, strDir)
        End If
    End Function
    '
    'ͨ��fileID ����ļ�������
    '
    Public Function openFileByFileID(ByVal fileID As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        Dim arList As New ArrayList
        strDir = getRelativePath(relativePath)
        Try
            ds = gWs.GetProjectFileByCondition("{file_id='" & fileID & "'}")
        Catch ex As Exception
            'MsgBox("�ļ��Ѿ��򿪻��߻�ȡ�ļ�����ʱ����!" & ex.Message, MsgBoxStyle.Exclamation, "��ȡ�ļ�")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            dsFile = getDataFromDataBase(ds, strDir)
            listDocument(dsFile, strDir)
        End If
    End Function
    '
    'ͨ��itemType��itemCode ����ļ�������
    '
    Public Function openFileList(ByVal itemType As String, ByVal itemCode As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        Dim strSql As String
        strDir = getRelativePath(relativePath)
        strSql = "{item_type='" & itemType & "' and item_code='" & itemCode & "'}"
        Try
            ds = gWs.GetProjectFileByCondition(strSql)
        Catch ex As Exception
            'MsgBox("�ļ��Ѿ��򿪻��߻�ȡ�ļ�����ʱ����!" & ex.Message, MsgBoxStyle.Exclamation, "��ȡ�ļ�")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            dsFile = getDataFromDataBase(ds, strDir)
            listDocument(dsFile, strDir)
        End If
    End Function
    '
    'ͨ��projectCode ,itemType��itemCode ����ļ�������
    '
    Public Function openFileList(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        Dim strSql As String
        strDir = getRelativePath(relativePath)
        'qxd 2004-8-5
        If itemCode = "%" Or itemCode = "" Then
            strSql = "{project_code='" & projectCode & "' and item_type like '" & itemType & "'}"
        Else
            strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}"
        End If
        Try
            ds = gWs.GetProjectFileByCondition(strSql)
        Catch ex As Exception
            'MsgBox("�ļ��Ѿ��򿪻��߻�ȡ�ļ�����ʱ����!" & ex.Message, MsgBoxStyle.Exclamation, "��ȡ�ļ�")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            If itemType = "43" Then
                listDocument(ds, strDir)
            Else
                dsFile = getDataFromDataBase(ds, strDir)
                listDocument(dsFile, strDir)
            End If
        End If
    End Function
    '
    'ͨ��project_code ,title,version,��ȡ�ļ�����
    '
    Public Function openFileByTitleVersion(ByVal projectCode As String, ByVal title As String, ByVal version As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        Dim strSql As String
        strDir = getRelativePath(relativePath)
        strSql = "{project_code='" & projectCode & "' and title='" & title & "' and version='" & version & "'}"
        Try
            ds = gWs.GetProjectFileByCondition(strSql)
        Catch ex As Exception
            'MsgBox("�ļ��Ѿ��򿪻��߻�ȡ�ļ�����ʱ����!" & ex.Message, MsgBoxStyle.Exclamation, "��ȡ�ļ�")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            dsFile = getDataFromDataBase(ds, strDir)
            listDocument(dsFile, strDir)
        End If
    End Function
    '
    '�����ݿ����ļ����ݣ����ڳ��������µ�strDirĿ¼�����ɸ��ļ�
    '
    '
    Private Function getDataFromDataBase(ByVal ds As DataSet, ByVal strDir As String)
        Dim i As Integer
        Dim dr As DataRow
        Try
            i = ds.Tables("TProjectFile").Rows.Count
        Catch ex As Exception
            'MsgBox("�ļ��Ѿ��򿪻��߻�ȡ�ļ�����ʱ����!" & ex.Message, MsgBoxStyle.Exclamation, "��ȡ�ļ�")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
        Else
            delAllFiles(Application.StartupPath & strDir)
        End If
        If i > 0 Then
            For i = 0 To i - 1
                dr = ds.Tables("TProjectFile").Rows(i)
                With dr
                    If Not .Item("document") Is System.DBNull.Value Then
                        Dim data As Byte()
                        data = .Item("document")
                        If Not .Item("file_type") Is System.DBNull.Value Then
                            strFileType = .Item("file_type")
                        Else
                            strFileType = ""
                        End If
                        If Not .Item("file_name") Is System.DBNull.Value Then
                            strFileName = .Item("file_name")
                        Else
                            strFileName = i
                        End If
                        Try
                            .Item("file_name") = strFileName & "." & strFileType.Trim()
                            Dim strPath As String
                            Dim isThread As Boolean = False
                            Dim myfilestream As System.IO.FileStream
                            strPath = Application.StartupPath & strDir & "\" & getLegalFileName(strCorporationName) & getLegalFileName(strFileName) & "." & strFileType.Trim()
                            '�ж��ļ��Ƿ����,���������ɾ��;���ɾ������,˵���ļ��Ѿ�����һ����ռ����.�򲻴����µ��ļ�
                            If System.IO.File.Exists(strPath) Then
                                Try
                                    System.IO.File.Delete(strPath)
                                Catch
                                    isThread = True
                                End Try
                            End If
                            If Not isThread Then
                                myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite, 5)
                                myfilestream.Write(data, 0, data.Length)
                                myfilestream.Close()
                            End If
                        Catch ex As Exception
                            'MsgBox("�ļ��Ѿ��򿪻��߻�ȡ�ļ�����ʱ����!", MsgBoxStyle.Exclamation, "��ȡ�ļ�")
                            ExceptionHandler.ShowMessageBox(ex)
                        End Try
                    Else
                        ds.Tables("TProjectFile").Rows(i).Delete()
                    End If
                End With
            Next
            ds.AcceptChanges()
            Return ds
        End If
    End Function
    '
    'ʵ��frmDocumentList()
    '
    Private Sub listDocument(ByVal ds As DataSet, ByVal strDir As String)
        Dim listDoc As New frmDocumentList(strCorporationName)
        Dim i As Integer
        If Not ds Is Nothing Then
            Try
                i = ds.Tables("TProjectFile").Rows.Count
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            If i > 0 Then
                listDoc.setDir(strDir)
                listDoc.dgFile.DataSource = ds.Tables("TProjectFile")
                Try
                    If isDocument Then
                        listDoc.setViewBox()
                    End If
                    If Me.ViewGuanty Then
                        listDoc.ShowDeleteButton()
                    End If
                    listDoc.ShowDialog()
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            Else
                'MsgBox("û����ص��ļ�����!", MsgBoxStyle.Exclamation, "���ļ�")
                SWDialogBox.MessageBox.Show("$2004", "")
            End If
        Else
            'MsgBox("û����ص��ļ�����!", MsgBoxStyle.Exclamation, "���ļ�")
            SWDialogBox.MessageBox.Show("$2004", "")
        End If
    End Sub
    '��word,excel�ļ�
    Private Sub showDocument(ByVal fileName As String, ByVal fileType As String, ByVal strDir As String)
        Dim strPath As String
        Dim strTemp As String 'qxd add 2003-10-30

        strTemp = getLegalFileName(fileName)
        'qxd modify 2003-12-26
        'strPath = Application.StartupPath & strDir & "\" & strTemp
        strPath = Application.StartupPath & strDir & strTemp
        'If Not System.IO.File.Exists(strPath) Then
        '    SWDialogBox.MessageBox.Show("$2004", "")
        '    Exit Sub
        'End If
        If fileType.Trim() = "doc" Then
            Dim word1 As Word.ApplicationClass
            Try
                word1 = New Word.ApplicationClass
                ' qxd modify 2003-10-30
                'word1.Application.Documents.Open(strPath)
                word1.Application.Documents.Add(strPath)
                word1.Caption = strTemp
                'qxd end
                word1.Application.Visible = True
            Catch ex As Exception
                '�رմ򿪵��ļ�
                word1.Application.Documents.Close()
                '�˳�Word,�Ҳ���ʾ�Ƿ񱣴�
                CType(word1.Application, Word.ApplicationClass).Quit(Word.WdSaveOptions.wdDoNotSaveChanges)
                'MsgBox("�ļ��Ѿ���!", MsgBoxStyle.Exclamation, "���ļ�")
                SWDialogBox.MessageBox.Show("$2001", "")
            Finally
                word1 = Nothing
                GC.Collect()
            End Try
        ElseIf fileType.Trim() = "xls" Then
            Dim excel1 As Excel.ApplicationClass
            Try
                excel1 = New Excel.ApplicationClass
                'excel1.Application.Workbooks.Open(strPath)
                excel1.Application.Workbooks.Add(strPath)
                excel1.Application.Visible = True
            Catch ex As Exception
                '�رմ򿪵��ļ�
                excel1.Application.Workbooks.Close()
                '�˳�Excel,�Ҳ���ʾ�Ƿ񱣴�
                CType(excel1.Application, Excel.ApplicationClass).Quit()
                'MsgBox("�ļ��Ѿ���!", MsgBoxStyle.Exclamation, "���ļ�")
                SWDialogBox.MessageBox.Show("$2001", "")
            Finally
                excel1 = Nothing
                GC.Collect()
            End Try
        ElseIf fileType.Trim() = "jpg" Or fileType.Trim() = "gif" Or fileType.Trim() = "bmp" Or fileType.Trim() = "jpeg" _
        Or fileType.Trim() = "JPG" Or fileType.Trim() = "GIF" Or fileType.Trim() = "BMP" Or fileType.Trim() = "JPEG" Then
            Try
                System.Diagnostics.Process.Start(strPath)
            Catch ex As Exception
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
            '    'MsgBox("�ļ�����δ֪!", MsgBoxStyle.Critical, "����")
            '    SWDialogBox.MessageBox.Show("$2003", "")
        End If
    End Sub

    Private isViewOpp As Boolean
    Public Property ViewGuanty() As Boolean
        Get
            Return Me.isViewOpp
        End Get
        Set(ByVal Value As Boolean)
            Me.isViewOpp = Value
        End Set
    End Property

End Class
