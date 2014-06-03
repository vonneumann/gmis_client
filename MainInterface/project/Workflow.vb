'����������������
Public Class Workflow

    '������Ŀ��ɫ��Ա
    Public Shared Function AssignTaskAttendee(ByVal ProjectCode As String, ByVal RoleID As String, ByVal AttendeePerson As String) As String

        Dim dsStaffRole, dsConsignAttendee As DataSet
        Dim strSql As String
        Dim i As Integer
        Dim Consigner As String


        '��ȡָ����ɫ��ָ����Ա��������,�ж��Ƿ����ί��
        dsStaffRole = gWs.GetStaffRole(RoleID, AttendeePerson)

        If dsStaffRole.Tables(0).Rows.Count > 0 Then
            Consigner = Trim(IIf(IsDBNull(dsStaffRole.Tables(0).Rows(0).Item("consigner")), "", dsStaffRole.Tables(0).Rows(0).Item("consigner")))
        End If


        '���������ί��,����������Ϊ������Ա,����ԭί������������˱�
        strSql = "{project_code=" & "'" & ProjectCode & "'" & " and role_id=" & "'" & RoleID & "'}"
        dsConsignAttendee = gWs.GetProjectTaskAttendeeInfo(strSql)

        If Consigner <> "" Then

            For i = 0 To dsConsignAttendee.Tables(0).Rows.Count - 1
                dsConsignAttendee.Tables(0).Rows(i).Item("attend_person") = Consigner
                dsConsignAttendee.Tables(0).Rows(i).Item("Consigner") = AttendeePerson
            Next


        Else
            '����,��ָ����Ա��Ϊ������Ա

            For i = 0 To dsConsignAttendee.Tables(0).Rows.Count - 1
                dsConsignAttendee.Tables(0).Rows(i).Item("attend_person") = AttendeePerson
            Next

        End If

        Return gWs.UpdateProjectTaskAttendee(dsConsignAttendee)

    End Function

    '��ȡʵ�ʲ�����
    Public Shared Function GetRealTaskAttendee(ByVal RoleID As String, ByVal AttendeePerson As String) As String
        Dim dsStaffRole, dsConsignAttendee As DataSet
        Dim strSql As String
        Dim i As Integer
        Dim Consigner As String


        '��ȡָ����ɫ��ָ����Ա��������,�ж��Ƿ����ί��
        dsStaffRole = gWs.GetStaffRole(RoleID, AttendeePerson)

        If dsStaffRole.Tables(0).Rows.Count > 0 Then
            Consigner = Trim(IIf(IsDBNull(dsStaffRole.Tables(0).Rows(0).Item("consigner")), "", dsStaffRole.Tables(0).Rows(0).Item("consigner")))
        End If

        '���������ί�У�����������
        If Consigner <> "" Then
            Return Consigner

            '���򷵻أ�ָ����Ա
        Else
            Return AttendeePerson
        End If
    End Function

End Class
