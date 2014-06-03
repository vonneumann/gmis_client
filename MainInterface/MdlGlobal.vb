Imports SZCGC.DocumentManager

Module MdlGlobal
    Public gWs As htfServer.Service1  'ȫ��WebService
    Public wsPermission As htfServerPermission.Permission
    Public _authentication As htfServerPermission.AuthenticationHeader

    Public strUrl As String   'WebService��url�����ַ���

    Public bSubmitPrompt As Boolean   '�ύʱ�Ƿ���ʾ

    Public strPasswd As String   '��½�û�����
    Public strServer As String   'Ӧ�÷�����
    Public iTimeOut As Int64    '���ӳ�ʱ����

    Public strPathProTreat As String = "��Ŀ���������"
    Public strPathProApprove As String = "��Ŀ������"
    Public strRootPath As String  'ϵͳ��ǰ·��

    Public WorkLog As FWorkLog
    Public QueryWorkLog As FQueryWorkLog

    '2008-08-11 yjf add ��ȡ������Կ
    Public encryptionKey As String


    '
    '�õ�webService��ʵ��
    '
    Public Function GetWebService(ByVal strUrl As String) As htfServer.Service1
        Dim ws As htfServer.Service1
        Try
            If ws Is Nothing Then
                ws = New htfServer.Service1
                ws.Url = strUrl
                If iTimeOut = 0 Then
                    ws.Timeout = -1
                Else
                    ws.Timeout = iTimeOut * 1000
                End If

            End If
            Return ws
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
    End Function


    ''�ݴ��û�

    Private user_name As String = Nothing
    Property UserName() As String
        Get
            Return user_name
        End Get

        Set(ByVal Value As String)
            user_name = Value
        End Set
    End Property

    '********************************���˵� add 2004-2-5********************************
    '���stringΪ�ĸ���󳤶�Ϊ255��string()����
    Public Function unbindStringToFour(ByVal strSource As String) As String()
        Dim strContent() As String = {" ", " ", " ", " "}
        Dim strSpace As String = "    "
        Dim len, nMod As Integer

        Try
            len = strSource.Length
            If len > 0 Then
                nMod = len \ 255 '��������һ����������ƽ��Ϊ��һ�������Ĵ���


                If nMod = 0 Then
                    strContent(0) = strSource.Substring(0, len)
                Else
                    strContent(1) = strSpace
                    strContent(2) = strSpace
                    strContent(3) = strSpace
                End If

                If nMod = 1 Then
                    strContent(0) = strSource.Substring(0, 250)
                    If len - 251 > 0 Then
                        strContent(1) = strSource.Substring(251, len - 251)
                    Else
                        strContent(1) = strSpace
                    End If
                Else
                    strContent(2) = strSpace
                    strContent(3) = strSpace
                End If
                If nMod = 2 Then
                    strContent(0) = strSource.Substring(0, 250)
                    strContent(1) = strSource.Substring(251, 250)
                    If len - 501 > 0 Then
                        strContent(2) = strSource.Substring(501, len - 501)
                    Else
                        strContent(2) = strSpace
                    End If
                Else
                    strContent(3) = strSpace
                End If
                If nMod = 3 Then
                    strContent(0) = strSource.Substring(0, 250)
                    strContent(1) = strSource.Substring(251, 250)
                    strContent(2) = strSource.Substring(501, 250)
                    If len - 751 > 0 Then
                        strContent(3) = strSource.Substring(751, len - 751)
                    Else
                        strContent(3) = strSpace
                    End If
                End If
                Return strContent
            Else
                Return strContent
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            Return strContent
        End Try

    End Function

    '2005-7-154
    '����projectcode��roleidȡ��staff_name
    Public Function GetPerson(ByVal projectcode As String, ByVal roleid As String) As DataTable
        'Dim strSQL As String = "SELECT n.staff_name FROM project " & _
        '                        "LEFT JOIN " & _
        '                        "(" & _
        '                        "SELECT staff.staff_name,staff.branch_name FROM staff " & _
        '                        "LEFT JOIN staff_role ON  staff.staff_name = staff_role.staff_name " & _
        '                        "WHERE role_id='" & roleid & "' " & _
        '                        ") AS n ON project.applicantTeam_name=n.branch_name " & _
        '                        "WHERE project_code='" & projectcode & "' AND staff_name is not null"

        '2005-8-1
        'ֻ����role id�͵�ǰ�û���ȡstaff_name
        'Dim strSQL As String = "SELECT * FROM staff " & _
        '                        "LEFT JOIN staff_role ON staff.staff_name = staff_role.staff_name " & _
        '                        "WHERE staff_role.role_id='" & roleid & "' AND " & _
        '                        "branch_name = (SELECT branch_name FROM staff WHERE staff_name = '" & UserName & "')"

        Dim strSQL As String = "SELECT * FROM staff " & _
                                "LEFT JOIN staff_role ON staff.staff_name = staff_role.staff_name " & _
                                "WHERE staff_role.role_id='" & roleid & "' "

        Return gWs.GetCommonQueryInfo(strSQL).Tables(0)
    End Function

    '==============================================
    '===add by 9sky 20050728
    '===����user��roleid��ȡ��Ա�б�
    '==============================================
    Public Function GetPersnList(ByVal staff_name As String, ByVal roleid As String) As ArrayList
        ''Dim strTeamName As String = gWs.GetCommonQueryInfo("select branch_name from staff where staff_name='" & staff_name & "'").Tables(0).Rows(0)(0)
        'Dim tbl As DataTable = gWs.GetCommonQueryInfo("select staff.staff_name,branch_name,role_id,is_assign_all from staff left join staff_role on staff.staff_name = staff_role.staff_name").Tables(0)
        'Dim strTeamName As String = tbl.Select("staff_name='" & staff_name & "'")(0)("branch_name")
        'Dim rows() As DataRow

        '''2008-5-27 yjf edit �ж�Ա���Ƿ��з���������Ŀ�����Ȩ��
        ''Dim bIsAssignAll As Boolean = IIf(IsDBNull(tbl.Select("staff_name='" & staff_name & "'")(0)("branch_name")), 0, tbl.Select("staff_name='" & staff_name & "'")(0)("branch_name"))
        ''If bIsAssignAll Then

        ''End If

        'If strTeamName = "���ı���" Then
        '    If roleid = "" Then
        '        rows = tbl.Select("branch_name='" & strTeamName & "'")
        '    Else
        '        rows = tbl.Select("role_id='" & roleid & "'")
        '    End If
        'Else

        '    If roleid = "" Then
        '        rows = tbl.Select("branch_name='" & strTeamName & "'")
        '    Else
        '        rows = tbl.Select("branch_name='" & strTeamName & "' and role_id='" & roleid & "'")
        '    End If
        '    If rows.Length < 0 Then
        '        strTeamName = gWs.GetCommonQueryInfo("Select superior_branch from branch where branch_name='" & strTeamName & "'").Tables(0).Rows(0)(0)
        '        If roleid = "" Then
        '            rows = tbl.Select("branch_name='" & strTeamName & "'")
        '        Else
        '            rows = tbl.Select("branch_name='" & strTeamName & "' and role_id='" & roleid & "'")
        '        End If
        '    End If
        'End If

        ''rows = tbl.Select("role_id='" & roleid & "'")

        'Dim row As DataRow
        'Dim arylist As ArrayList = New ArrayList

        'For Each row In rows
        '    arylist.Add(row("staff_name").ToString())
        'Next

        'Return arylist


        'Dim strTeamName As String = gWs.GetCommonQueryInfo("select branch_name from staff where staff_name='" & staff_name & "'").Tables(0).Rows(0)(0)
        Dim tbl As DataTable = gWs.GetCommonQueryInfo("select staff.staff_name,dept_name,branch_name,role_id,is_assign_all,assign_department_list from staff left join staff_role on staff.staff_name = staff_role.staff_name").Tables(0)
        Dim strTeamName As String
        If IsDBNull(tbl.Select("staff_name='" & staff_name & "'")(0)("assign_department_list")) Then
            strTeamName = SplitStringListForWhereCondition(tbl.Select("staff_name='" & staff_name & "'")(0)("dept_name"))
        Else
            strTeamName = SplitStringListForWhereCondition(IIf(IsDBNull(tbl.Select("staff_name='" & staff_name & "'")(0)("assign_department_list")), "", tbl.Select("staff_name='" & staff_name & "'")(0)("assign_department_list")))
        End If

        '2008-5-27 yjf edit �ж�Ա���Ƿ��з���������Ŀ�����Ȩ��
        Dim bIsAssignAll As Boolean = IIf(IsDBNull(tbl.Select("staff_name='" & staff_name & "'")(0)("is_assign_all")), 0, tbl.Select("staff_name='" & staff_name & "'")(0)("is_assign_all"))

        Dim rows() As DataRow

        If bIsAssignAll Then
            If roleid = "" Then
                rows = tbl.Select("dept_name in (" & strTeamName & ")")
            Else
                rows = tbl.Select("role_id='" & roleid & "'")
            End If
        Else

            If roleid = "" Then
                rows = tbl.Select("dept_name in (" & strTeamName & ")")
            Else
                rows = tbl.Select("dept_name in (" & strTeamName & ") and role_id='" & roleid & "'")
            End If
            If rows.Length = 0 Then
                strTeamName = SplitStringListForWhereCondition(gWs.GetCommonQueryInfo("Select superior_branch from branch where branch_name in (" & strTeamName & ")").Tables(0).Rows(0)(0))
                If roleid = "" Then
                    rows = tbl.Select("dept_name in (" & strTeamName & ")")
                Else
                    rows = tbl.Select("dept_name in (" & strTeamName & ") and role_id='" & roleid & "'")
                End If
            End If
        End If

        'rows = tbl.Select("role_id='" & roleid & "'")

        Dim row As DataRow
        Dim arylist As ArrayList = New ArrayList

        For Each row In rows
            arylist.Add(row("staff_name").ToString())
        Next

        Return arylist
    End Function

    '==============================================
    '===add by 9sky 20050830
    '===����project_code��task_id��ȡί���ˣ����ί����Ϊ�գ��򷵻ص�ǰ������
    '==============================================
    Public Function GetConsigner(ByVal project_code As String, ByVal task_id As String) As String
        Dim ds As DataSet

        ds = gWs.GetCommonQueryInfo("select * from project_task_attendee where project_code='" & project_code & "' and task_id='" & task_id & "'")
        If ds.Tables(0).Rows.Count = 0 Then Return Nothing
        If ds.Tables(0).Rows(0)("Consigner") Is DBNull.Value OrElse ds.Tables(0).Rows(0)("Consigner") = "" Then
            Return ds.Tables(0).Rows(0)("attend_person")
        Else
            Return ds.Tables(0).Rows(0)("Consigner")
        End If
    End Function

    Public Function SplitStringListForWhereCondition(ByVal stringList As String)
        Dim i As Integer
        Dim stringListArray As String() = stringList.Split(",")
        Dim stringListFinal As String
        For i = 0 To stringListArray.Length - 1
            If i = stringListArray.Length - 1 Then
                stringListFinal = stringListFinal + "'" + stringListArray(i) + "'"
            Else
                stringListFinal = stringListFinal + "'" + stringListArray(i) + "'" + ","
            End If
        Next
        Return stringListFinal
    End Function

    Public Sub PrintPDF(ByVal strProjectCode As String, ByVal strContractType As String, ByVal strContractCode As String, ByVal strContractName As String)
        Dim objDoc As New CCWordApp

        'ɾ��DOCUMENTĿ¼���е��ļ���
        Dim strPath As String = Application.StartupPath & "\Document\"
        delAllFiles(strPath)

        Dim strSql As String = "{project_code='" & strProjectCode & "' and contract_name='" & strContractName & "' and item_type='" & strContractType & "' and item_code='" & strContractCode & "'}"
        Dim dsProjectContractElement As DataSet = gWs.GetProjectContractElementInfo(strSql)

        strSql = "{project_code='" & strProjectCode & "' and contract_name='" & strContractName & "'}"
        Dim dsProjectContractEstate As DataSet = gWs.GetProjectContractEstateElementInfo(strSql)
        Dim dsProjectContractChattel As DataSet = gWs.GetProjectContractChattelElementInfo(strSql)
        Dim dsProjectContractCar As DataSet = gWs.GetProjectContractCarElementInfo(strSql)


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
                        Dim data As Byte() = .Item("template")
                        docType = .Item("doc_type")
                        docType = docType.Trim
                        Dim myfilestream As System.IO.FileStream
                        Dim strTemp As String
                        Dim isThread As Boolean = False

                        'strTemp = getLegalFileName(Me.txtCorporationName.Text) & Me.txtContractName.Text ' qxd add 2003-10-30
                        strTemp = strContractName ' qxd add 2003-10-30

                        strPath = Application.StartupPath & "\Document\" & strTemp
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
                        Dim strMessage As String = "��ǰ�汾��" & strContractName & "�����ļ�ģ�岻����!"
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
            GC.Collect()
        End Try




        '����Ŀ��ͬҪ���滻��ͬģ���BOOKMARK��ǣ�
        Dim objDocGernerate As New DocumentGenerator
        Try
            objDocGernerate.GenerateDocument(dsProjectContractElement, dsProjectContractEstate, dsProjectContractChattel, dsProjectContractCar, objDoc)
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

            'objDoc = Nothing

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

    End Sub

  
End Module
