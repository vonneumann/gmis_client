Public Class frmFlagContentClass

    '
    'Author quexd 
    'Create date 2003-4-10
    '

    Private StrProjectCode As String
    Private StrCorporationName As String
    Private StrCorporationCode As String
    Private StrPhase As String
    Private StrSpace As String = "          " ' �����ĵ����滻û�����ݵı���

    '���캯��
    'Public Sub New()
    'End Sub
    Public Sub New(ByVal projectCode As String, ByVal corporationName As String, ByVal corporationCode As String, ByVal phase As String)
        Me.strProjectCode = projectCode
        Me.strCorporationName = corporationName
        Me.strCorporationCode = corporationCode
        Me.strPhase = phase
    End Sub
    '
    '����vbCrLf,���ԡ��س������滻֮
    '
    Public Shared Function replaceExt(ByVal strContent As String, ByVal flag As String)
        'Chr(10) �����з�
        'Chr(13) ����س���
        Try
            flag = Chr(13).ToString
            strContent = Replace(strContent, Chr(10), flag)
            If InStr(strContent, Chr(10)) <> 0 Then
                replaceExt(strContent, flag)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return strContent
    End Function
    '
    '���󱨸��滻���
    '��55�����
    '����ҵ��Ʒ�ֲ�ͬ,��ȡ��ͬ���滻���
    '����:��item_type + item_code ���
    '
    Public Function getReviewDocFlag(ByVal cmbTypeText As String)

        If cmbTypeText = "45002" Then '�����ʽ�����,������󱨸���
            Dim docFlag As String() = {"&#DateTime", "&#ADateTime", _
                    "&#ABCorporation_Name", "&#Attend_person", "&#AAttend_person1", _
                    "&#Bttend_person", "&#BAttend_person1", _
                    "&#Corporation_Name", "&#Business_Licence_Code", "&#Business_Start_Date", _
                    "&#Business_End_Date", "&#Distric_Name", "&#Register_Adress", _
                    "&#Register_Capital", "&#MoneyName", "&#Real_Capital", "&#Cash_Receive", _
                    "&#Invisible_Asset", "&#Legal_Representative", "&#Nationality", _
                    "&#ID_Card", "&#Loan_Card_ID", "&#Corp_Paper_ID", _
                    "&#Credit_Grad", "&#Evaluate_Institution", "&#Proprietorship_Type", _
                    "&#Technology_Type", "&#Employee_Amount", "&#College", _
                    "&#Bachelor", "&#Master", "&#Doctor", _
                    "&#Business_Scope", "&#Leading_Product" _
                    , _
                    "&#BfCorpName", "&#BfFoundDate", "&#BfAddress", _
                    "&BfCapital", "&#BfSalesSum", "&#BfGainSum", _
                    "&#BfProuduct", "&#BfTechnologyType", _
                    "&#BfApplySum", "&#BfApplyTerms", "&#BfApplyPurpose", _
                    "&#BfOpinionMA", "&#BfOpinionMB" _
                     , _
                    "&#Quantity_Score", "&#Quality_Score", "&#Total_Score", _
                    "&#AQuantity_Score", "&#AQuality_Score", "&#ATotal_Score" _
                     , _
                    "&#BeforeLastYear", "&#Lastyear", "&#Year", "&#Month", "&#BLSale", _
                    "&#BLProfit", "&#LSale", "&#LProfit", "&#YSale", "&#YProfit" _
                     , _
                     "&#APersonAsurer" _
                     , _
                    "&#ACorporation_Name1", "&#ABusiness_Licence_Code1", "&#ABusiness_Start_Date1", _
                    "&#ABusiness_End_Date", "&#ADistric_Name1", "&#ARegister_Adress1", _
                    "&#ARegister_Capital1", "&#AReal_Capital1", "&#ACash_Receive1", _
                    "&#AInvisible_Asset", "&#ALegal_Representative1", "&#ANationality1", _
                    "&#AID_Card1", "&#ALoan_Card_ID1", "&#ACorp_Paper_ID1", _
                    "&#ACredit_Grad1", "&#AProprietorship_Type1", "&#ATechnology_Type1", _
                    "&#ARelation" _
                    , _
                    "&#managerA_opinion", "&#managerB_opinion", "&#defectRecord" _
                     }
            Return docFlag
        End If

        If cmbTypeText = "45102" Then '����,��һ�����Ϣ��,���б����ĵ�8��������Ϣ
            Dim docFlag As String() = {"&#DateTime", "&#ADateTime", _
                                 "&#ABCorporation_Name", "&#Attend_person", "&#AAttend_person1", _
                                 "&#Bttend_person", "&#BAttend_person1", _
                                 "&#Corporation_Name", "&#Business_Licence_Code", "&#Business_Start_Date", _
                                 "&#Business_End_Date", "&#Distric_Name", "&#Register_Adress", _
                                 "&#Register_Capital", "&#MoneyName", "&#Real_Capital", "&#Cash_Receive", _
                                 "&#Invisible_Asset", "&#Legal_Representative", "&#Nationality", _
                                 "&#ID_Card", "&#Loan_Card_ID", "&#Corp_Paper_ID", _
                                 "&#Credit_Grad", "&#Evaluate_Institution", "&#Proprietorship_Type", _
                                 "&#Technology_Type", "&#Employee_Amount", "&#College", _
                                 "&#Bachelor", "&#Master", "&#Doctor", _
                                 "&#Business_Scope", "&#Leading_Product" _
                                 , _
                                 "&#BfCorpName", "&#BfFoundDate", "&#BfAddress", _
                                 "&BfCapital", "&#BfSalesSum", "&#BfGainSum", _
                                 "&#BfProuduct", "&#BfTechnologyType", _
                                 "&#BfApplySum", "&#BfApplyTerms", "&#BfApplyPurpose", _
                                 "&#BfOpinionMA", "&#BfOpinionMB" _
                                 , _
                                 "&#AQuantity_Score", "&#AQuality_Score", "&#ATotal_Score" _
                                 , _
                                 "&#BeforeLastYear", "&#Lastyear", "&#Year", "&#Month", "&#BLSale", _
                                 "&#BLProfit", "&#LSale", "&#LProfit", "&#YSale", "&#YProfit" _
                                 , _
                                 "&#bh_purpose", "&#bh_project_name", "&#bh_project_content", _
                                 "&#bh_beneficiary_introduction", "&#bh_guarantee_letter_type", "&#bh_apply_sum", _
                                 "&#bh_apply_term", "&#bh_counterclaim_condition" _
                                  , _
                                 "&#APersonAsurer" _
                                 , _
                                 "&#ACorporation_Name1", "&#ABusiness_Licence_Code1", "&#ABusiness_Start_Date1", _
                                 "&#ABusiness_End_Date", "&#ADistric_Name1", "&#ARegister_Adress1", _
                                 "&#ARegister_Capital1", "&#AReal_Capital1", "&#ACash_Receive1", _
                                 "&#AInvisible_Asset", "&#ALegal_Representative1", "&#ANationality1", _
                                 "&#AID_Card1", "&#ALoan_Card_ID1", "&#ACorp_Paper_ID1", _
                                 "&#ACredit_Grad1", "&#AProprietorship_Type1", "&#ATechnology_Type1", _
                                 "&#ARelation" _
                                 , _
                                 "&#managerA_opinion", "&#managerB_opinion" _
                                  }
            Return docFlag
        End If

        If cmbTypeText = "45202" Then 'С��ί�����󱨸�
            Dim docFlag As String() = {"&#DateTime", "&#ADateTime", _
                    "&#ABCorporation_Name", "&#Attend_person", "&#AAttend_person1", _
                    "&#Bttend_person", "&#BAttend_person1", _
                    "&#Corporation_Name", "&#Business_Licence_Code", "&#Business_Start_Date", _
                    "&#Business_End_Date", "&#Distric_Name", "&#Register_Adress", _
                    "&#Register_Capital", "&#MoneyName", "&#Real_Capital", "&#Cash_Receive", _
                    "&#Invisible_Asset", "&#Legal_Representative", "&#Nationality", _
                    "&#ID_Card", "&#Loan_Card_ID", "&#Corp_Paper_ID", _
                    "&#Credit_Grad", "&#Evaluate_Institution", "&#Proprietorship_Type", _
                    "&#Technology_Type", "&#Employee_Amount", "&#College", _
                    "&#Bachelor", "&#Master", "&#Doctor", _
                    "&#Business_Scope", "&#Leading_Product" _
                    , _
                    "&#BfCorpName", "&#BfFoundDate", "&#BfAddress", _
                    "&BfCapital", "&#BfSalesSum", "&#BfGainSum", _
                    "&#BfProuduct", "&#BfTechnologyType", _
                    "&#BfApplySum", "&#BfApplyTerms", "&#BfApplyPurpose", _
                    "&#BfOpinionMA", "&#BfOpinionMB" _
                     , _
                    "&#Quantity_Score", "&#Quality_Score", "&#Total_Score", _
                    "&#AQuantity_Score", "&#AQuality_Score", "&#ATotal_Score" _
                     , _
                    "&#BeforeLastYear", "&#Lastyear", "&#Year", "&#Month", "&#BLSale", _
                    "&#BLProfit", "&#LSale", "&#LProfit", "&#YSale", "&#YProfit" _
                     , _
                    "&#ACorporation_Name1", "&#ABusiness_Licence_Code1", "&#ABusiness_Start_Date1", _
                    "&#ABusiness_End_Date", "&#ADistric_Name1", "&#ARegister_Adress1", _
                    "&#ARegister_Capital1", "&#AReal_Capital1", "&#ACash_Receive1", _
                    "&#AInvisible_Asset", "&#ALegal_Representative1", "&#ANationality1", _
                    "&#AID_Card1", "&#ALoan_Card_ID1", "&#ACorp_Paper_ID1", _
                    "&#ACredit_Grad1", "&#AProprietorship_Type1", "&#ATechnology_Type1", _
                    "&#ARelation" _
                    , _
                    "&#managerA_opinion", "&#managerB_opinion" _
                     }
            Return docFlag
        End If
    End Function
    '
    '���󱨸��滻���
    '��51�����
    '
    Public Function getFirstInstanceDocFlag()
        Dim docFlag As String() = {"&#DateTime", "&#ReviewPerson", "&#Minister", _
                "&#ACorporation_Name", "&#Corporation_Name", "&#Found_date", _
                "&#Register_Address", "&#Business_licence_code", "#Corp_Paper_id", _
                "&#loan_paper_id", "&#loan_card_id", "&#credit_grade", _
                "&#is_first_loan", "&#technology_type", "&#legal_representative", _
                "&#nationality", "&#Aattorney", "&#attorney_nationality ", _
                "&#contact_phone", "&#Fax ", "&#proprietorship_type", _
                "&#register_capital", "&#MoneyName", "&#real_capital", "&#cash_receive", _
                "&#employee_amount", "&#college", "&#bachelor", _
                "&#master", "&#docter", "&#business_scope", _
                "&#leading_product ", "&#technology_level" _
                 , _
                "&#BeforeLastYear", "&#Lastyear", "&#Year", "&#Month", "&#BLSale", _
                "&#BLProfit", "&#LSale", "&#LProfit", "&#YSale", "&#YProfit" _
                , _
                "&#market_status", "&#apply_sum", _
                "&#apply_term", "&#apply_bank", "&#purpose", "&#conclusion", _
                "&#content", "&#FirstTrialOpinion" _
                }
        Return docFlag
    End Function
    '
    '��Ŀ��ֹ�����滻���
    '12�����
    '���˵� �޸�ʱ�䣺2003��9��27 9��30
    '
    Public Function getTerminateReportDocFlag()
        Dim docFlag As String() = { _
                    "&#CorporationName", "&#ProjectCode", "&#Opposite_guarantee", _
                    "&#GuaranteeValue", "&#GuaranteeStartDate", "&#GuaranteeEndDate", _
                    "&#RefundDate", "&#Terminate_type", "&#Terminate_date", _
                    "&#Appraisement", "&#is_continue_support", _
                    "&#is_high_risk" _
                    }
        Return docFlag
    End Function
    '
    '���������������������
    '6�����
    '
    Public Function getEvaluateReportDocFlag()
        Dim docFlag As String() = { _
                    "&#A_ApplyCompany", "&#B_ApplyCompany", "&#C_ApplyCompany", _
                    "&#A_evaluate_person", _
                    "&#B_evaluate_person", _
                    "&#C_evaluate_person" _
                    }
        Return docFlag
    End Function
    '
    '���������������������
    '
    Public Function getEvaluateReplace()
        Dim replaceList As New ArrayList()
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
        If Not gWs Is Nothing Then
            Try
                'ds = gWs.FetchProjectCorporation(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
                i = ds.Tables("TProjectCorporation").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("TProjectCorporation").Rows(0)
                    With dr
                        '��ҵ����
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                            replaceList.Add(.Item("corporation_name"))
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                strSql = "{project_code='" & StrProjectCode & "' and (guaranty_type='21' or guaranty_type='22' or guaranty_type='23')}"
                ds = gWs.GetGuarantyInfo(strSql, "null")
                i = ds.Tables("opposite_guarantee").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("opposite_guarantee").Rows(0)
                    With dr
                        '�ʲ�������
                        If Not .Item("evaluate_person") Is System.DBNull.Value Then
                            replaceList.Add(.Item("evaluate_person"))
                            replaceList.Add(.Item("evaluate_person"))
                            replaceList.Add(.Item("evaluate_person"))
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
            Catch
            Finally
            End Try
        End If
        Return replaceList
    End Function
    '
    '���󱨸�
    '
    Public Function getFirstInstanceReplace()
        Dim replaceList As New ArrayList()
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim dsCorp As DataSet
        dsCorp = gWs.GetCommonQueryInfo("Select found_date from corporation where corporation_code='" & strCorporationCode & "'")
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & StrPhase & "' }"
        If Not gWs Is Nothing Then
            Try
                'ds = gWs.FetchProjectCorporation(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, strCorporationCode, "1", StrPhase)
                i = ds.Tables("TProjectCorporation").Rows.Count
                If i = 0 Then
                    Dim j As Integer
                    For j = 0 To 51 - 1
                        replaceList.Add(StrSpace)
                    Next
                End If
                If i > 0 Then
                    dr = ds.Tables("TProjectCorporation").Rows(0)
                    '����
                    Try
                        replaceList.Add(gWs.GetSysTime().ToString("yyyy��MM��dd��"))
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    '������
                    replaceList.Add(UserName)
                    'ǩ����,12(��������)
                    replaceList.Add("")
                    'Dim dsMinister As DataSet = gWs.GetProjectInfoEx("{projectcode='" & strProjectCode & "'}")
                    'Dim strMinister As String = ""
                    'If Not dsMinister Is Nothing Then
                    '    If dsMinister.Tables(0).Rows.Count > 0 Then
                    '        strMinister = dsMinister.Tables(0).Rows(0).Item("12")
                    '        replaceList.Add(strMinister)
                    '    Else
                    '        replaceList.Add(strMinister)
                    '    End If
                    'Else
                    '    replaceList.Add(strMinister)
                    'End If
                    With dr
                        '��ҵ����
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��ҵ����(ȫ��)_A
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '����ʱ��
                        If Not dsCorp.Tables(0).Rows(0).Item("found_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(dsCorp.Tables(0).Rows(0).Item("found_date"), Date).ToString("yyyy��MM��dd��"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��ϸ��ַ
                        'qxd add 2003-11-3
                        Dim strRegister As String = ""
                        If Not .Item("district_name") Is System.DBNull.Value Then
                            strRegister = .Item("district_name")
                        End If
                        ' qxd end
                        If Not .Item("register_address") Is System.DBNull.Value Then
                            'replaceList.Add(.Item("register_address"))
                            replaceList.Add(strRegister & .Item("register_address"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        'Ӫҵִ�պ���
                        If Not .Item("business_licence_code") Is System.DBNull.Value Then
                            replaceList.Add(.Item("business_licence_code"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '���˴���֤����
                        If Not .Item("corp_paper_id") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corp_paper_id"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '����֤����
                        If Not .Item("loan_paper_id") Is System.DBNull.Value Then
                            replaceList.Add(.Item("loan_paper_id"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '�������
                        If Not .Item("loan_card_id") Is System.DBNull.Value Then
                            replaceList.Add(.Item("loan_card_id"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��ҵ���ŵȼ�
                        If Not .Item("credit_grade") Is System.DBNull.Value Then
                            replaceList.Add(.Item("credit_grade"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '**********************��ȷ��!!!************************
                        '�Ƿ��һ�δ���
                        '�ӱ�consultation��ȡ������
                        Dim dsConsultation As DataSet
                        Dim drConsultation As DataRow
                        Dim str As String
                        Dim strCorporationCode As String
                        strCorporationCode = .Item("corporation_code")
                        str = "{corporation_code='" & strCorporationCode & "' order by serial_num DESC}" '��serial_num ����
                        dsConsultation = gWs.GetcorporationInfo("null", str)
                        If dsConsultation.Tables("consultation").Rows.Count > 0 Then
                            drConsultation = dsConsultation.Tables("consultation").Rows(0)
                            If Not drConsultation.Item("is_first_loan") Is System.DBNull.Value Then
                                If drConsultation.Item("is_first_loan") = "1" Then
                                    replaceList.Add("��")
                                Else
                                    replaceList.Add("��")
                                End If
                            Else
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '�����������
                        If Not .Item("technology_type") Is System.DBNull.Value Then
                            replaceList.Add(getTechnologyType(.Item("technology_type")))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '����������
                        If Not .Item("legal_representative") Is System.DBNull.Value Then
                            replaceList.Add(.Item("legal_representative"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '����
                        If Not .Item("nationality") Is System.DBNull.Value Then
                            replaceList.Add(.Item("nationality"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��Ȩ�������ϵ��(contact_person)
                        If Not .Item("contact_person") Is System.DBNull.Value Then
                            replaceList.Add(.Item("contact_person"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '����(��Ȩ�������ϵ��)
                        If Not .Item("attorney_nationality") Is System.DBNull.Value Then
                            replaceList.Add(.Item("attorney_nationality"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��ϵ�绰
                        If Not .Item("contact_phone") Is System.DBNull.Value Then
                            replaceList.Add(.Item("contact_phone"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '����
                        If Not .Item("fax") Is System.DBNull.Value Then
                            replaceList.Add(.Item("fax"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��˾���
                        If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                            replaceList.Add(.Item("proprietorship_type"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        'ע���ʱ�
                        If Not .Item("register_capital") Is System.DBNull.Value Then
                            replaceList.Add(.Item("register_capital"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        'ע���ʱ��Ļ��ҵ�λ
                        If Not .Item("MoneyID") Is System.DBNull.Value Then
                            replaceList.Add(getMoneyName(.Item("MoneyID")))
                        Else
                            replaceList.Add("�����")
                        End If
                        'ʵ���ʱ�
                        If Not .Item("real_capital") Is System.DBNull.Value Then
                            replaceList.Add(.Item("real_capital"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '�����ֽ�λ
                        If Not .Item("cash_receive") Is System.DBNull.Value Then
                            replaceList.Add(.Item("cash_receive"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        'Ա������
                        If Not .Item("employee_amount") Is System.DBNull.Value Then
                            replaceList.Add(.Item("employee_amount"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��ר
                        If Not .Item("college") Is System.DBNull.Value Then
                            replaceList.Add(.Item("college"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '����
                        If Not .Item("bachelor") Is System.DBNull.Value Then
                            replaceList.Add(.Item("bachelor"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '˶ʿ
                        If Not .Item("master") Is System.DBNull.Value Then
                            replaceList.Add(.Item("master"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��ʿ
                        If Not .Item("docter") Is System.DBNull.Value Then
                            replaceList.Add(.Item("docter"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��Ӫ��Χ
                        If Not .Item("business_scope") Is System.DBNull.Value Then
                            replaceList.Add(replaceExt(.Item("business_scope"), ""))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��Ӫҵ��
                        If Not .Item("leading_product") Is System.DBNull.Value Then
                            replaceList.Add(replaceExt(.Item("leading_product"), ""))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '����ˮƽ
                        If Not .Item("technology_level") Is System.DBNull.Value Then
                            replaceList.Add(.Item("technology_level"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '-------------------------
                        '---------���۶�����ܶ�----------2003-12-17 add
                        Dim strApplyDate As String
                        Dim strSQLIndex, strSystemID, strSQLSystem As String
                        Dim strMonth, strYear, strLastYear, strBeforeLastYear, strBBLastYear As String
                        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double

                        strApplyDate = GetApplyDate(StrProjectCode)

                        strYear = CType(strApplyDate, Date).Year '����
                        strMonth = CType(strApplyDate, Date).Month '������·�

                        dYear = CType(strYear, Double)

                        lastYear = dYear - 1 'ȥ��
                        strLastYear = lastYear.ToString

                        beforeLastYear = dYear - 2 'ǰ��
                        strBeforeLastYear = beforeLastYear.ToString

                        replaceList.Add(strBeforeLastYear) 'ǰ��
                        replaceList.Add(strLastYear) 'ȥ��
                        replaceList.Add(strYear) '����
                        replaceList.Add(strMonth) '������·�

                        'strSql = "{project_code='" & strProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & strPhase & "' }"
                        strSql = "{project_code='" & StrProjectCode & "' and phase='" & StrPhase & "' and corporation_code='" & strCorporationCode & _
                            "' and (month like '" & strYear & "%' or month like '" & strLastYear & _
                                "%' or month like '" & strBeforeLastYear & "%' or month like '" & strBBLastYear & "%') " & _
                                " and ((item_type='02' and item_code='b01') or (item_type='02' and item_code='b14'))}"

                        ds = gWs.FetchCorporationAccount(strSql)

                        If Not ds Is Nothing Then

                            Dim strValue As String
                            Dim strSort As String = "item_code asc"
                            Dim drTemp As DataRow

                            '��ǰ��
                            strSql = "month like '" & strBeforeLastYear & "%' "
                            If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                                If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                            Else
                                replaceList.Add(StrSpace)
                                replaceList.Add(StrSpace)
                            End If
                            'ȥ��
                            strSql = "month like '" & strLastYear & "%' "
                            If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                                If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                            Else
                                replaceList.Add(StrSpace)
                                replaceList.Add(StrSpace)
                            End If
                            '����
                            strSql = "month like '" & strYear & "%' "
                            If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                                If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                                    strValue = Format(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, "#.###")
                                    replaceList.Add(strValue)
                                Else
                                    replaceList.Add(StrSpace)
                                End If
                            Else
                                replaceList.Add(StrSpace)
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                        '-----------------------------------
                        '�г����
                        If Not .Item("market_status") Is System.DBNull.Value Then
                            replaceList.Add(replaceExt(.Item("market_status"), ""))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '******************************************************
                        Dim dsProject As DataSet
                        Dim drProject As DataRow
                        strSql = "{project_code='" & StrProjectCode & "'}"
                        dsProject = gWs.GetProjectInfo(strSql)
                        If dsProject.Tables(0).Rows.Count > 0 Then
                            drProject = dsProject.Tables(0).Rows(0)
                            '�������뵣�����
                            If Not drProject.Item("apply_sum") Is System.DBNull.Value Then
                                replaceList.Add(drProject.Item("apply_sum"))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                            '����
                            If Not drProject.Item("apply_term") Is System.DBNull.Value Then
                                replaceList.Add(drProject.Item("apply_term"))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                            '���������������
                            If Not drProject.Item("apply_bank") Is System.DBNull.Value Then
                                replaceList.Add(getBankName(drProject.Item("apply_bank")))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                            '�������������;��������Դ
                            If Not drProject.Item("purpose") Is System.DBNull.Value Then
                                replaceList.Add(replaceExt(drProject.Item("purpose"), ""))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                        '**************�ӱ�:project_opinion�ж�ȡ����
                        '������Ա���
                        'ͨ��project_code ,item_type,item_code����:51,002��ʾ�������
                        Dim dsOpinion As DataSet
                        Dim drOpinion As DataRow
                        strSql = "{project_code='" & StrProjectCode & "' and item_type='51' and item_code='002'}"
                        dsOpinion = gWs.GetProjectOpinionByProjectNo(strSql)
                        If dsOpinion.Tables(0).Rows.Count > 0 Then
                            drOpinion = dsOpinion.Tables(0).Rows(0)
                            If Not drOpinion.Item("conclusion") Is System.DBNull.Value Then
                                replaceList.Add(replaceExt(drOpinion.Item("conclusion"), ""))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                            '����
                            If Not drOpinion.Item("content") Is System.DBNull.Value Then
                                replaceList.Add(replaceExt(drOpinion.Item("content"), ""))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                        '����������
                        strSql = "{project_code='" & StrProjectCode & "' and item_type='51' and item_code='003'}"
                        dsOpinion = gWs.GetProjectOpinionByProjectNo(strSql)
                        If dsOpinion.Tables(0).Rows.Count > 0 Then
                            drOpinion = dsOpinion.Tables(0).Rows(0)
                            If Not drOpinion.Item("content") Is System.DBNull.Value Then
                                replaceList.Add(replaceExt(drOpinion.Item("content"), ""))
                            Else
                                replaceList.Add(StrSpace)
                            End If
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                End If
            Catch ex As Exception
            End Try
        End If
        Return replaceList
    End Function
    '
    '���󱨸�
    '
    '�����ݿ��:projectCorporation,��ȡ����
    'corporation_type='1'��ʾ������ҵ
    '
    Public Function getReviewReplace(ByVal cmbTypeText As String)

        Dim replaceList As New ArrayList()

        If cmbTypeText = "45002" Then '�����ʽ�����
            Try
                Me.SetReviewProjectCorporation(replaceList) '33����ҵ�滻��־
                Me.SetReviewBreif(replaceList) '13�����󱨸����滻��־
                Me.SetReviewAppraise(replaceList, cmbTypeText) '6��������Ϣ�滻��־(����Ϊ3��)
                Me.SetReviewCorporationAccout(replaceList) '10�������ܶ��滻��־
                'Me.SetReviewProject(replaceList, cmbTypeText) '8�������滻��־
                Me.SetReviewAssurer(replaceList) '1�������ʲ��嵥
                Me.SetReviewProjectCorporation2(replaceList) '19��������ҵ�滻��־
                Me.SetReviewManagerOpinion(replaceList) '��Ŀ����AB�����
                Me.SetDefectRecord(replaceList) 'ʧ�ż�¼
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If

        If cmbTypeText = "45102" Then '����ҵ��Ʒ��
            Try
                Me.SetReviewProjectCorporation(replaceList) '33����ҵ�滻��־
                Me.SetReviewBreif(replaceList) '13�����󱨸����滻��־
                Me.SetReviewAppraise(replaceList, cmbTypeText) '6��������Ϣ�滻��־(����Ϊ3��)
                Me.SetReviewCorporationAccout(replaceList) '10�������ܶ��滻��־
                Me.SetReviewProject(replaceList, cmbTypeText) '8�������滻��־
                Me.SetReviewAssurer(replaceList) '1�������ʲ��嵥
                Me.SetReviewProjectCorporation2(replaceList) '19��������ҵ�滻��־
                Me.SetReviewManagerOpinion(replaceList) '��Ŀ����AB�����
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If

        If cmbTypeText = "45202" Then 'С��ί������
            Try
                Me.SetReviewProjectCorporation(replaceList) '33����ҵ�滻��־
                Me.SetReviewBreif(replaceList) '13�����󱨸����滻��־
                Me.SetReviewAppraise(replaceList, cmbTypeText) '6��������Ϣ�滻��־(����Ϊ3��)
                Me.SetReviewCorporationAccout(replaceList) '10�������ܶ��滻��־
                'Me.SetReviewProject(replaceList, cmbTypeText) '8�������滻��־
                'Me.SetReviewAssurer(replaceList) '1�������ʲ��嵥
                Me.SetReviewProjectCorporation2(replaceList) '19��������ҵ�滻��־
                Me.SetReviewManagerOpinion(replaceList) '��Ŀ����AB�����
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If


        Return replaceList
    End Function

    '
    '��Ŀ��ֹ����
    '
    Public Function getTerminateReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                'projectCorporation��
                strSql = "{project_code='" & StrProjectCode & "' and corporation_type='1' }"
                strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
                'ds = gWs.FetchProjectCorporation(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
                i = ds.Tables("TProjectCorporation").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("TProjectCorporation").Rows(0)
                    With dr
                        '��ҵ����
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '���
                        replaceList.Add(StrProjectCode)
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                'opposite_guarantee_form
                '��������ʩ
                'qxd modify 2003-11-4
                'strSql = "{project_code='" & strProjectCode & "' }"
                strSql = "{project_code='" & StrProjectCode & "' and is_used='1'}"
                'ds = gWs.GetGuarantyInfo(strSql, "null")
                ds = gWs.GetProjectGuaranteeForm(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    Dim strForm As String = String.Empty
                    Dim strDescription As String = String.Empty
                    For i = 0 To i - 1
                        dr = ds.Tables(0).Rows(i)
                        With dr
                            strDescription = IIf(.Item("description") Is System.DBNull.Value, "(��)", .Item("description") & "")
                            strForm = strForm & (i + 1) & "��" & strDescription & Chr(13).ToString
                        End With
                    Next
                    replaceList.Add(strForm)
                Else
                    replaceList.Add(StrSpace)
                End If
                'loan_notice
                strSql = "{project_code='" & StrProjectCode & "'}"
                ds = gWs.GetLoanNoticeInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '�������

                        If Not .Item("sum") Is System.DBNull.Value Then
                            Dim strSum As String = .Item("sum")
                            'qxd 2003-10-30 modify
                            'replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
                            replaceList.Add(strSum)
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��������:��ʼ
                        If Not .Item("start_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(.Item("start_date"), Date).ToString("yyyy��MM��dd��"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��������:��ֹ
                        If Not .Item("end_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(.Item("end_date"), Date).ToString("yyyy��MM��dd��"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                'refund_certificate
                strSql = "{project_code='" & StrProjectCode & "'}"
                ds = gWs.GetRefundCertificateInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '��������ҵ��������
                        If Not .Item("refund_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(.Item("refund_date"), Date).ToString("yyyy��MM��dd��"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                End If
                'project_terminate_report
                strSql = "{project_code='" & StrProjectCode & "'}"
                ds = gWs.GetTerminateReportInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '����������ֹ
                        If Not .Item("terminate_type") Is System.DBNull.Value Then
                            replaceList.Add(.Item("terminate_type"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '��ǰ��ֹ
                        If Not .Item("terminate_date") Is System.DBNull.Value Then
                            replaceList.Add(CType(.Item("terminate_date"), Date).ToString("yyyy��MM��dd��"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        ''������ֹ
                        'If Not .Item("terminate_date") Is System.DBNull.Value Then
                        '    replaceList.Add(CType(.Item("terminate_date"), Date).ToString("yyyy��MM��dd��"))
                        'Else
                        '    replaceList.Add(strSpace)
                        'End If
                        '����
                        If Not .Item("appraisement") Is System.DBNull.Value Then
                            replaceList.Add(.Item("appraisement"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '�Ƿ�ֵ�������ļ���֧��
                        If Not .Item("is_continue_support") Is System.DBNull.Value Then
                            If .Item("is_continue_support") = "1" Then
                                replaceList.Add("��")
                            Else
                                replaceList.Add("��")
                            End If
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '�Ƿ������������ĸ߷�����ҵ�������Կ�
                        If Not .Item("is_high_risk") Is System.DBNull.Value Then
                            If .Item("is_high_risk") = "1" Then
                                replaceList.Add("��")
                            Else
                                replaceList.Add("��")
                            End If
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    'replaceList.Add(strSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        Return replaceList
    End Function
    '----------------------------qxd add 2003-5-30-----------------------------
    '1.**************************
    '��ͬ����
    '���浥����Ѻ��������ͬ
    Public Function getImpawnContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#ACompany", "&#BCompany", _
                "&#Alegal_representative" _
                         }
        Return contractFlag
    End Function
    '��Ѻ��������ͬ
    Public Function getImpawnContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '���м�֧��
                replaceList.Add(getBank())
                '��ҵ����
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '����
                replaceList.Add(getFieldName("legal_representative", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '2.****************************
    '��Ѻ��������ͬ
    Public Function getPledgeContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#ACompany", "&#BCompany", _
                     "&#Alegal_representative" _
                    }
        '"&#OppGuarantee", "&#Guarantee_value" _
        Return contractFlag
    End Function
    '��Ѻ��������ͬ
    Public Function getPledgeContractReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                '���м�֧��
                replaceList.Add(getBank())
                '��ҵ����
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '����
                replaceList.Add(getFieldName("legal_representative", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '3.******************************
    '��֤��ͬ�����У�
    Public Function getAssureContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#CorporationName"}
        Return contractFlag
    End Function
    '��֤��ͬ�����У�
    Public Function getAssureContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '���м�֧��
                replaceList.Add(getBank())
                '��ҵ����
                replaceList.Add(getFieldName("corporation_name", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '4.******************************
    '��ҵ��֤��������ͬ
    Public Function getAssureOppContractFlag()
        Dim contractFlag As String() = {"&#ACompany_Opp", "&#CCompany_Opp", "&#BankName", "&#Address_Opp", "&#Alegal_representative_Opp", _
                    "&#BCompany", "&#DCompany", "&#BAddress", "&#Blegal_representative" _
                     }
        Return contractFlag
    End Function
    '��ҵ��֤��������ͬ
    Public Function getAssureOppContractReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                '-------------------- '��������ҵ��corporationType��2 -----------------
                '��ҵ����
                replaceList.Add(getFieldName("corporation_name", "2"))
                replaceList.Add(getFieldName("corporation_name", "2"))
                '���м�֧��
                replaceList.Add(getBank())
                'ע���ַ
                replaceList.Add(getFieldName("district_name", "2") & getFieldName("register_address", "2"))
                '����
                replaceList.Add(getFieldName("legal_representative", "2"))
                '-------------------- '������ҵ��corporationType��1 -------------------
                '��ҵ����
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                'ע���ַ
                replaceList.Add(getFieldName("district_name", "1") & getFieldName("register_address", "1"))
                '����
                replaceList.Add(getFieldName("legal_representative", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '5.*********************************
    '.ί�б�֤��ͬ
    Public Function getDelegateContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#ACompany", "&#BCompany", _
                        "&#AGuaranteeSum", "&#BGuaranteeSum", "&#LoanTerms", _
                        "&#AReviewFee", "&#BReviewFee", "&#AGuaranteeFee", "&#BGuaranteeFee" _
                         }
        Return contractFlag
    End Function
    '.ί�б�֤��ͬ
    Public Function getDelegateContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '���м�֧��
                replaceList.Add(getBank())
                '��ҵ����
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '���
                Dim strSum As String = getConferenceTrial("guarantee_sum")
                If strSum.Trim = "" Then
                    strSum = "0"
                End If
                strSum = (CType(strSum, Double) * 10000.0).ToString
                replaceList.Add(Money2String.Money2String.GetCnString(strSum))
                replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
                '����
                replaceList.Add(getConferenceTrial("terms"))
                '�����
                strSum = getProjectAccountDetail("31", "001")
                If strSum.Trim = "" Then
                    strSum = "0"
                End If
                replaceList.Add(Money2String.Money2String.GetCnString(strSum))
                replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
                '������
                strSum = getProjectAccountDetail("31", "002")
                If strSum.Trim = "" Then
                    strSum = "0"
                End If
                replaceList.Add(Money2String.Money2String.GetCnString(strSum))
                replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '6*******************************
    'ί�д����ͬ
    Public Function getDelegateLoanContractFlag()
        Dim contractFlag As String() = {"&#ACompany", "&#BCompany", _
                                "&#AGuaranteeSum", "&#BGuaranteeSum", "&#LoanTerms", _
                                 "&#Alegal_representative" _
                                 }
        Return contractFlag
    End Function
    'ί�д����ͬ
    Public Function getDelegateLoanContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '��ҵ����
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '���
                Dim strSum As String = getConferenceTrial("guarantee_sum")
                If strSum.Trim = "" Then
                    strSum = "0"
                End If
                strSum = (CType(strSum, Double) * 10000.0).ToString
                replaceList.Add(Money2String.Money2String.GetCnString(strSum))
                replaceList.Add(Money2String.Money2String.GetScienceString(strSum))
                '����
                replaceList.Add(getConferenceTrial("terms"))
                '����
                replaceList.Add(getFieldName("legal_representative", "1"))
            Catch ex As Exception
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End Try
        End If
        Return replaceList
    End Function
    '7 **************************
    '���˱�֤��ͬ
    Public Function getPersonalOppContractFlag()
        Dim contractFlag As String() = {"&#BankName", "&#ACompany", "&#BCompany", _
                                "&#Legal_Representative", "&#Opp_persons", "&#Opp_Address", "&#PersonalAssetList" _
                                 }
        Return contractFlag
    End Function
    '���˱�֤��ͬ
    Public Function getPersonalOppContractReplace()
        Dim replaceList As New ArrayList
        If Not gWs Is Nothing Then
            Try
                '���м�֧��
                replaceList.Add(getBank())
                '��ҵ����
                replaceList.Add(getFieldName("corporation_name", "1"))
                replaceList.Add(getFieldName("corporation_name", "1"))
                '����������
                replaceList.Add(getFieldName("legal_representative", "1") & getFieldName("legal_representative", "1"))
                '��������֤�˺͵�ַ,�����ʲ��嵥
                replaceList.Add(getOppGuaranteeAssureer("name"))
                replaceList.Add(getOppGuaranteeAssureer("address"))
                replaceList.Add(getOppGuaranteeAssureer("assets_bill"))
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        Return replaceList
    End Function
    '������м�֧������
    Private Function getBank()
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                'intent_letter
                strSql = "{project_code='" & StrProjectCode & "' order by intent_code desc}"
                ds = gWs.GetIntentLetterInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Dim strBankCode As String
                    Dim strBankName, strBranchName As String
                    With dr
                        '��������
                        If Not .Item("loan_bank") Is System.DBNull.Value Then
                            strBankCode = .Item("loan_bank")
                            strBankName = getBankName(strBankCode)
                        Else
                            strBankName = ""
                        End If
                        '֧������
                        If Not .Item("loan_branch_bank") Is System.DBNull.Value Then
                            strBranchName = getBranchBankName(strBankCode, .Item("loan_branch_bank"))
                        Else
                            strBranchName = ""
                        End If
                        Return strBankName & strBranchName
                    End With
                Else
                    Return StrSpace
                End If
            Catch
                Return StrSpace
            End Try
        End If
    End Function
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
                ds = gWs.FetchProjectCorporation(StrProjectCode, "%", corporationType, "����")
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '��ҵ����
                        If Not .Item(fieldName) Is System.DBNull.Value Then
                            Return .Item(fieldName)
                        Else
                            Return StrSpace
                        End If
                    End With
                Else
                    Return StrSpace
                End If
            Catch ex As Exception
                Return StrSpace
            End Try
        End If
    End Function
    '��ȡconference_trial���е��ֶ�ֵ
    Private Function getConferenceTrial(ByVal fieldName As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                strSql = "{project_code='" & StrProjectCode & "' order by trial_times }"
                ds = gWs.GetConfTrialInfo(strSql, "null")
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '��ҵ����
                        If Not .Item(fieldName) Is System.DBNull.Value Then
                            Return .Item(fieldName)
                        Else
                            Return StrSpace
                        End If
                    End With
                Else
                    Return StrSpace
                End If
            Catch ex As Exception
                Return StrSpace
            End Try
        End If
    End Function
    '��ȡproject_account_detail
    Private Function getProjectAccountDetail(ByVal itemType As String, ByVal itemCode As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strTemp As String
        Dim dTemp As Double
        Dim dSum As Double = 0.0
        If Not gWs Is Nothing Then
            Try
                strSql = "{project_code='" & StrProjectCode & "' and item_type='" _
                        & itemType & "' and item_code='" & itemCode & _
                        "' and income is null}"
                ds = gWs.GetProjectAccountDetailInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = ds.Tables(0).Rows(i)
                        With dr
                            If Not .Item("payout") Is System.DBNull.Value Then
                                strTemp = .Item("payout")
                            Else
                                strTemp = "0"
                            End If
                            dTemp = CType(strTemp, Double)
                            dSum = dSum + dTemp
                        End With
                    Next
                    Return dSum.ToString
                Else
                    Return StrSpace
                End If
            Catch ex As Exception
                Return StrSpace
            End Try
        End If
    End Function
    '��ȡopposite_guarantee_assurer
    Private Function getOppGuaranteeAssureer(ByVal fieldName As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strName, strField As String
        If Not gWs Is Nothing Then
            Try
                strSql = "{project_code='" & StrProjectCode & "'}"
                ds = gWs.GetOppositeGuaranteeAssurerInfo(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = ds.Tables(0).Rows(i)
                        With dr
                            If Not .Item(fieldName) Is System.DBNull.Value Then
                                strName = .Item(fieldName) & ";"
                            Else
                                strName = " "
                            End If
                            strField = strField & strName
                        End With
                    Next
                    Return strField
                Else
                    Return StrSpace
                End If
            Catch ex As Exception
                Return StrSpace
            End Try
        End If
    End Function
    '***************************������ͬ************************************qxd 2003-12-9 start
    '������ȱ���Э����
    '���
    Public Function getLetterProtocolFlag()
        Dim flag As String() = {"&#ACompany", "&#BCompany"}
        Return flag
    End Function
    '�滻����
    Public Function getLetterProtocolReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
        If Not gWs Is Nothing Then
            Try
                'ds = gWs.FetchProjectCorporation(strSql)
                ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
                i = ds.Tables("TProjectCorporation").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("TProjectCorporation").Rows(0)
                    With dr
                        '��ҵ����
                        If Not .Item("corporation_name") Is System.DBNull.Value Then
                            replaceList.Add(.Item("corporation_name"))
                            replaceList.Add(.Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
        End If
        Return replaceList
    End Function
    '��������ȷ����
    '���
    Public Function getLetterAffirmFlag()
        Dim flag As String() = {"&#Company", "&#BankAndBranch", "&#AssureSum"}
        Return flag
    End Function
    '�滻����
    Public Function getLetterAffirmReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{projectcode='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetProjectInfoEx(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '��ҵ����
                        If Not .Item("EnterpriseName") Is System.DBNull.Value Then
                            replaceList.Add(.Item("EnterpriseName"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        '���м�֧��
                        Dim strBank, strBranch As String
                        If Not .Item("BankName") Is System.DBNull.Value Then
                            If Not .Item("BranchBankName") Is System.DBNull.Value Then
                                strBranch = .Item("BranchBankName")
                            End If
                            strBank = .Item("BankName") & strBranch
                            replaceList.Add(strBank)
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                '��֤����
                Try
                    Dim dsDetail As DataSet
                    strSql = "{project_code='" & StrProjectCode & "' and phase='" & StrPhase & "' and item_type='34' and item_code='009'}"
                    dsDetail = gWs.GetProjectAccountDetailInfo(strSql)
                    If Not dsDetail Is Nothing AndAlso dsDetail.Tables(0).Rows.Count = 1 Then
                        replaceList.Add(dsDetail.Tables(0).Rows(0).Item("payout"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                    replaceList.Add(StrSpace)
                End Try
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
        End If
        Return replaceList
    End Function
    '��Ȼ�˱�֤��������ͬ
    '���
    Public Function getLetterPledgeFlag()
        'Dim flag As String() = {"&#ACompany", "&#BCompany", "&#BankAndBranch"}
        Dim flag As String() = {"&#ACompany", "&#BCompany", "&#BankAndBranch", "&#Opp_persons", "&#PersonalAssetList"}
        Return flag
    End Function
    '�滻����
    Public Function getLetterPledgeReplace()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim strCorporationName As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{projectcode='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "'}"
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetProjectInfoEx(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '��ҵ����
                        If Not .Item("EnterpriseName") Is System.DBNull.Value Then
                            replaceList.Add(.Item("EnterpriseName"))
                            replaceList.Add(.Item("EnterpriseName"))
                        Else
                            replaceList.Add(StrSpace)
                            replaceList.Add(StrSpace)
                        End If
                        '���м�֧��
                        Dim strBank, strBranch As String
                        If Not .Item("BankName") Is System.DBNull.Value Then
                            If Not .Item("BranchBankName") Is System.DBNull.Value Then
                                strBranch = .Item("BranchBankName")
                            End If
                            strBank = .Item("BankName") & strBranch
                            replaceList.Add(strBank)
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    End With
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                replaceList.Add(getOppGuaranteeAssureer("name"))
                replaceList.Add(getOppGuaranteeAssureer("assets_bill"))
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
            replaceList.Add(StrSpace)
        End If
        Return replaceList
    End Function
    '
    '***************************������ͬ************************************qxd 2003-12-9 end 
    '8*************�ٵ�����ͬ************** xie 2004-2-24 add 
    Public Function getReGuaranteeFlag()
        Dim flag As String() = {"&#ReGurantee", "&#Bank_branch", "&#Creditee", "&#Bank_branch", "&#Creditee", " &#Bank_branch", _
        "&#Creditee", "&#Bank_branch", "&#ApplySum", " &#Bank_branch", " &#Bank_branch", "&#ReGuarantee"}
        Return flag
    End Function
    Public Function getReGuaranteeReplace()

        Dim replaceList As New ArrayList
        Dim bankAndBranch As String
        Dim corpName As String
        Dim creditee As String
        Dim reGuaranteeSum As String

        Dim dr As DataRow

        '��ֵbankandbranch
        Dim dsLoanNotice As DataSet
        dsLoanNotice = gWs.GetLoanNoticeInfo("{project_code='" & Me.StrProjectCode & "'}")
        If dsLoanNotice.Tables(0).Rows.Count > 0 Then
            dr = dsLoanNotice.Tables(0).Rows(0)
            If Not dr.Item("bank") Is System.DBNull.Value Then
                Dim dsBanka As DataSet
                dsBanka = gWs.GetBankInfo("{bank_code='" & dr.Item("bank") & "'}", "{bank_code='" & dr.Item("bank") & "'}")
                Dim strBank As String = dsBanka.Tables("bank").Rows(0).Item("bank_name")
                Dim strBranch As String = dsBanka.Tables("bank_branch").Select("branch_bank_code='" & dr.Item("branch_bank") & "'")(0).Item("branch_bank_name")
                bankAndBranch = strBank & strBranch
            Else
                bankAndBranch = StrSpace
            End If
        Else
            bankAndBranch = StrSpace
        End If

        '��ֵ�ٵ�����������corpname
        Dim dsProjectOrg As DataSet
        dsProjectOrg = gWs.GetProjectOrganization("{project_code='" & Me.StrProjectCode & "'}")
        If dsProjectOrg.Tables(0).Rows.Count > 0 Then
            dr = dsProjectOrg.Tables(0).Rows(0)
            If Not dr.Item("organno") Is System.DBNull.Value Then
                Dim dsTemp As DataSet = gWs.GetTOrganizationInfo("{organno='" & dr.Item("organno") & "'}")
                corpName = dsTemp.Tables(0).Rows(0).Item("name")
            Else
                corpName = StrSpace
            End If
        Else
            corpName = StrSpace
        End If

        '��ֵ�����д�����ҵ����creditee
        creditee = Me.StrCorporationName

        '�ٵ������reguaranteesum
        Dim dsProjAccoutDetail As DataSet
        dsProjAccoutDetail = gWs.GetProjectAccountDetailInfo("{project_code='" & Me.StrProjectCode & "' and item_type='31' and item_code='002'}")
        If dsProjAccoutDetail.Tables(0).Rows.Count > 0 Then
            dr = dsProjAccoutDetail.Tables(0).Rows(0)
            If Not dr.Item("payout") Is System.DBNull.Value Then
                reGuaranteeSum = Money2String.Money2String.GetCnString(dr.Item("payout")) & "(" & Money2String.Money2String.GetScienceString(dr.Item("payout")) & ")"
            Else
                reGuaranteeSum = StrSpace
            End If
        Else
            reGuaranteeSum = StrSpace
        End If

        With replaceList
            .Add(corpName)
            .Add(bankAndBranch)
            .Add(creditee)
            .Add(bankAndBranch)
            .Add(creditee)
            .Add(bankAndBranch)
            .Add(creditee)
            .Add(bankAndBranch)
            .Add(reGuaranteeSum)
            .Add(bankAndBranch)
            .Add(bankAndBranch)
            .Add(corpName)
        End With

        Return replaceList
    End Function

    '****��ѯ��ҵ��Ϣ�ɼ��� start
    Public Function getCorpConsultInfoFlag() As String()
        Dim flag As String() = {"&#CorporationName", "&#FoundDate", "&#st", "&#ht", "&#ContactPerson1", "&#Job1", _
                        "&#ContactPerson2", "job2", "&#PhoneNUm", "&#Mobile", "&#Fax", "&#Email", "&#WebSite", _
                        "&#Sum", "&#Term", "&#CorporationDesc", "&#ProjectDesc", "&#ConsultPerson", "&#Date"}
        Return flag
    End Function
    Public Function replaceCorpConsultInfoFlag()
        Dim replaceList As New ArrayList
        Dim strSql As String
        Dim dsConsult As DataSet
        Dim dr As DataRow
        Dim i As Int16
        Try
            strSql = "select top 1 * from consultation where corporation_code='" & StrCorporationCode & "' and corporation_name='" & Me.StrCorporationName & "' order by serial_num desc"
            dsConsult = gWs.GetCommonQueryInfo(strSql)
            i = dsConsult.Tables(0).Rows.Count
            If i > 0 Then
                dr = dsConsult.Tables("consult").Rows(0)
                With replaceList
                    .Add(StrCorporationCode)
                    .Add(dr.Item("found_date"))
                    .Add(dr.Item("proprietorship_type"))
                    .Add(dr.Item("industry_type"))
                    .Add(dr.Item("contact_person"))
                    .Add(dr.Item("job"))
                    .Add("")
                    .Add("")
                    .Add(dr.Item("phone_num"))
                    .Add(dr.Item("mobile"))
                    .Add(dr.Item("fax"))
                    .Add(dr.Item("e_mail"))
                    .Add(dr.Item("web_site"))
                    .Add(dr.Item("apply_guarantee_sum"))
                    .Add(dr.Item("apply_term"))
                    .Add(dr.Item("corporation_description"))
                    .Add(dr.Item("product_description"))
                    .Add(dr.Item("consult_person"))
                    .Add(dr.Item("consult_date"))
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return replaceList
    End Function
    '**** ��ѯ��Ϣ�ɼ��� end
    '
    'ͨ��ProjectCorporation������һ�������󱨸���滻����(33����ҵ�滻��־)
    Private Sub SetReviewProjectCorporation(ByRef replaceList As ArrayList)

        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow
        Dim dsCorp As DataSet

        'strSql = "{project_code='" & strProjectCode & "' and corporation_type='1' }"
        strSql = "{project_code='" & StrProjectCode & "' and corporation_code='" & StrCorporationCode & "' and phase='" & StrPhase & "' }"

        Try
            'ds = gWs.FetchProjectCorporation(strSql)
            ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
            dsCorp = gWs.GetCommonQueryInfo("Select * from Corporation where corporation_code='" & StrCorporationCode & "'")
            i = ds.Tables("TProjectCorporation").Rows.Count
            If i = 0 Then
                Dim j As Integer
                'qxd 2003-12-17 modify
                '33 ��������ҵ�滻���+10�����۶�����ܶ�+8��������ӵı��
                For j = 0 To 34 - 1
                    replaceList.Add(StrSpace)
                Next
            End If

            If i > 0 Then
                dr = ds.Tables("TProjectCorporation").Rows(0)
                '����
                Try
                    replaceList.Add(gWs.GetSysTime().ToString("yyyy��MM��dd��"))
                    replaceList.Add(gWs.GetSysTime().ToString("yyyy��MM��dd��"))
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                With dr
                    '��ҵ����_A
                    If Not .Item("corporation_name") Is System.DBNull.Value AndAlso .Item("corporation_name") <> "" Then
                        replaceList.Add(.Item("corporation_name"))
                    Else
                        '��ֹproject_corporation����Ϣ���������corporation_name
                        If dsCorp.Tables(0).Rows.Count > 0 AndAlso Not dsCorp.Tables(0).Rows(0).Item("corporation_name") Is DBNull.Value Then
                            replaceList.Add(dsCorp.Tables(0).Rows(0).Item("corporation_name"))
                        Else
                            replaceList.Add(StrSpace)

                        End If
                    End If
                    '*****************************����project��ͼViewProjectInfo�л�ȡ**************************
                    '��Ŀ����A��
                    '��Ŀ����B��
                    '��project_task_attendee, role_id,��24����A�ǣ���25����B��
                    Dim dsProjectTaskAttendee As DataSet
                    Dim drProjectTaskAttendee As DataRow
                    Dim k, nloop As Integer
                    Dim strManager_a, strManager_b As String
                    strSql = "role_id='24' or role_id='25'"
                    'qxd modify 2003-6-10
                    Dim strABManager As String
                    strABManager = "{projectcode='" & StrProjectCode & "'}"
                    dsProjectTaskAttendee = gWs.GetProjectInfoEx(strABManager)
                    k = dsProjectTaskAttendee.Tables(0).Rows.Count
                    If k > 0 Then
                        drProjectTaskAttendee = dsProjectTaskAttendee.Tables(0).Rows(0) '.Select(strSql, "role_id ASC")
                        For nloop = 0 To 1 '��ѭ����Ϊ�������,��Ϊ��������������Ҫ��д��Ŀ����A,B��
                            With drProjectTaskAttendee
                                replaceList.Add(.Item("24"))
                                replaceList.Add(.Item("25"))
                            End With
                        Next
                    Else
                        replaceList.Add(StrSpace)
                        replaceList.Add(StrSpace)
                        replaceList.Add(StrSpace)
                        replaceList.Add(StrSpace)
                    End If
                    '*****************************

                    '��ҵ����
                    If Not .Item("corporation_name") Is System.DBNull.Value Then
                        replaceList.Add(.Item("corporation_name"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ҵ����Ӫҵִ�պ���
                    If Not .Item("business_licence_code") Is System.DBNull.Value Then
                        replaceList.Add(.Item("business_licence_code"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'Ӫҵ���޿�ʼ
                    If Not .Item("business_start_date") Is System.DBNull.Value Then
                        replaceList.Add(CType(.Item("business_start_date"), Date).ToString("yyyy��MM��dd��"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'Ӫҵ���޽���
                    If Not .Item("business_end_date") Is System.DBNull.Value Then
                        replaceList.Add(CType(.Item("business_end_date"), Date).ToString("yyyy��MM��dd��"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    If dsCorp.Tables(0).Rows.Count > 0 Then
                        'ע���ַ:����
                        If Not dsCorp.Tables(0).Rows(0)("district_name") Is System.DBNull.Value Then
                            replaceList.Add(dsCorp.Tables(0).Rows(0)("district_name"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                        'ע���ַ:��ַ
                        If Not dsCorp.Tables(0).Rows(0)("register_address") Is System.DBNull.Value Then
                            replaceList.Add(dsCorp.Tables(0).Rows(0)("register_address"))
                        Else
                            replaceList.Add(StrSpace)
                        End If
                    Else
                        replaceList.Add(StrSpace)
                        replaceList.Add(StrSpace)
                    End If
                    'ע���ʱ�
                    If Not .Item("register_capital") Is System.DBNull.Value Then
                        replaceList.Add(.Item("register_capital"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'ע���ʱ��Ļ��ҵ�λ
                    If Not .Item("MoneyID") Is System.DBNull.Value Then
                        replaceList.Add(getMoneyName(.Item("MoneyID")))
                    Else
                        replaceList.Add("�����")
                    End If
                    'ʵ���ʱ�
                    If Not .Item("real_capital") Is System.DBNull.Value Then
                        replaceList.Add(.Item("real_capital"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�����ֽ�λ
                    If Not .Item("cash_receive") Is System.DBNull.Value Then
                        replaceList.Add(.Item("cash_receive"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�����ʲ�
                    If Not .Item("invisible_assets") Is System.DBNull.Value Then
                        replaceList.Add(.Item("invisible_assets"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '����������
                    If Not .Item("legal_representative") Is System.DBNull.Value Then
                        replaceList.Add(.Item("legal_representative"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '����
                    If Not .Item("nationality") Is System.DBNull.Value Then
                        replaceList.Add(.Item("nationality"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '���֤����
                    If Not .Item("id_card") Is System.DBNull.Value Then
                        replaceList.Add(.Item("id_card"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�������
                    If Not .Item("loan_card_id") Is System.DBNull.Value Then
                        replaceList.Add(.Item("loan_card_id"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ҵ���˴���֤����
                    If Not .Item("corp_paper_id") Is System.DBNull.Value Then
                        replaceList.Add(.Item("corp_paper_id"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ҵ���ŵȼ�
                    If Not .Item("credit_grade") Is System.DBNull.Value Then
                        replaceList.Add(.Item("credit_grade"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '������λ
                    If Not .Item("evaluate_institution") Is System.DBNull.Value Then
                        replaceList.Add(.Item("evaluate_institution"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ҵ����
                    If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                        replaceList.Add(.Item("proprietorship_type"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�����������
                    If Not .Item("technology_type") Is System.DBNull.Value Then
                        replaceList.Add(getTechnologyType(.Item("technology_type")))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��Ա���ʣ�Ա������
                    If Not .Item("employee_amount") Is System.DBNull.Value Then
                        replaceList.Add(.Item("employee_amount"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ר
                    If Not .Item("college") Is System.DBNull.Value Then
                        replaceList.Add(.Item("college"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '����
                    If Not .Item("bachelor") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bachelor"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '˶ʿ
                    If Not .Item("master") Is System.DBNull.Value Then
                        replaceList.Add(.Item("master"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ʿ
                    If Not .Item("docter") Is System.DBNull.Value Then
                        replaceList.Add(.Item("docter"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��Ӫ��Χ
                    If Not .Item("business_scope") Is System.DBNull.Value Then
                        replaceList.Add(.Item("business_scope"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '������Ʒ������ҵ��
                    If Not .Item("leading_product") Is System.DBNull.Value Then
                        replaceList.Add(.Item("leading_product"))
                    Else
                        replaceList.Add(StrSpace)
                    End If

                End With
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '
    'ͨ��ProjectCorporation������һ�������󱨸���滻����(10�����ۼ������ܶ�)
    Private Sub SetReviewCorporationAccout(ByRef replaceList As ArrayList)

        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow

        '---------���۶�����ܶ�----------2003-12-17 add
        Dim strApplyDate As String
        Dim strSQLIndex, strSystemID, strSQLSystem As String
        Dim strMonth, strYear, strLastYear, strBeforeLastYear, strBBLastYear As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double

        strApplyDate = GetApplyDate(StrProjectCode)

        strYear = CType(strApplyDate, Date).Year '����
        strMonth = CType(strApplyDate, Date).Month '������·�

        dYear = CType(strYear, Double)

        lastYear = dYear - 1 'ȥ��
        strLastYear = lastYear.ToString

        beforeLastYear = dYear - 2 'ǰ��
        strBeforeLastYear = beforeLastYear.ToString

        replaceList.Add(strBeforeLastYear) 'ǰ��
        replaceList.Add(strLastYear) 'ȥ��
        replaceList.Add(strYear) '����
        replaceList.Add(strMonth) '������·�

        'strSql = "{project_code='" & strProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & strPhase & "' }"
        strSql = "{project_code='" & StrProjectCode & "' and phase='" & StrPhase & "' and corporation_code='" & StrCorporationCode & _
            "' and (month like '" & strYear & "%' or month like '" & strLastYear & _
                "%' or month like '" & strBeforeLastYear & "%' or month like '" & strBBLastYear & "%') " & _
                " and ((item_type='02' and item_code='b01') or (item_type='02' and item_code='b14'))}"
        Try

            ds = gWs.FetchCorporationAccount(strSql)

            If Not ds Is Nothing Then

                Dim strValue As String
                Dim strSort As String = "item_code asc"
                Dim drTemp As DataRow

                '��ǰ��
                strSql = "month like '" & strBeforeLastYear & "%' "
                If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                'ȥ��
                strSql = "month like '" & strLastYear & "%' "
                If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
                '����
                strSql = "month like '" & strYear & "%' "
                If ds.Tables(0).Select(strSql, strSort).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(0).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    If Not ds.Tables(0).Select(strSql)(1).Item("value") Is System.DBNull.Value Then
                        strValue = CType(ds.Tables(0).Select(strSql)(1).Item("value") / 10000, Integer)
                        replaceList.Add(strValue)
                    Else
                        replaceList.Add(StrSpace)
                    End If
                Else
                    replaceList.Add(StrSpace)
                    replaceList.Add(StrSpace)
                End If
            Else
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
                replaceList.Add(StrSpace)
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '
    'ͨ��Project������һ�������󱨸���滻����(8�������滻��־)
    Private Sub SetReviewProject(ByRef replaceList As ArrayList, ByVal cmbTypeText As String)

        '-----------------------------------
        '**********************************��project����ֱ�ӻ�ȡ��Ŀ����Ϣ************************************
        '------------------------����----------------------qxd add 2003-12-4----------------------------------
        '���ҵ��Ʒ����:����
        If cmbTypeText = "45002" Then Exit Sub

        Try

            Dim dsProject As DataSet
            Dim drProject As DataRow
            Dim projectCount As Integer
            Dim strProjectSQL As String = "{project_code='" & StrProjectCode & "'}"
            dsProject = gWs.GetProjectInfo(strProjectSQL)
            If Not dsProject Is Nothing Then
                projectCount = dsProject.Tables(0).Rows.Count
            End If
            If projectCount = 0 Then
                Dim nloop As Int16
                For nloop = 0 To 7
                    replaceList.Add(StrSpace)
                Next
            End If
            If projectCount > 0 Then
                drProject = dsProject.Tables(0).Rows(0)
                With drProject
                    '��Լ����������������������������;
                    If Not .Item("purpose") Is System.DBNull.Value Then
                        replaceList.Add(.Item("purpose"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��Ŀ����
                    If Not .Item("bh_project_name") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bh_project_name"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��Ŀ����
                    If Not .Item("bh_project_content") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bh_project_content"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�������������
                    If Not .Item("bh_beneficiary_introduction") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bh_beneficiary_introduction"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��������
                    If Not .Item("guarantee_letter_type") Is System.DBNull.Value Then

                        replaceList.Add(getGuaranteeLetterName(.Item("guarantee_letter_type")))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�������
                    If Not .Item("apply_sum") Is System.DBNull.Value Then
                        replaceList.Add(.Item("apply_sum"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��������
                    If Not .Item("apply_term") Is System.DBNull.Value Then
                        replaceList.Add(.Item("apply_term"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��������������
                    If Not .Item("bh_counterclaim_condition") Is System.DBNull.Value Then
                        replaceList.Add(.Item("bh_counterclaim_condition"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        '----------------------------------------qxd add 2003-12-4----------------------------------
    End Sub
    'ͨ��ProjectCorporation������һ�������󱨸���滻����(19��������ҵ�滻��־)
    Private Sub SetReviewProjectCorporation2(ByRef replaceList As ArrayList)

        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow

        ''''''''''''''''''''''''''''''''''''''''''''''''
        Dim count As Integer = 19  '��19����֤��ҵ����Ϣ
        strSql = "{project_code='" & StrProjectCode & "' and corporation_type='2' }"
        'strSql = "{project_code='" & StrProjectCode & "' and not corporation_code='" & StrCorporationCode & "' and phase='" & StrPhase & "' }"

        Try
            ds = gWs.FetchProjectCorporation(strSql)
            'ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "2", StrPhase)
            i = ds.Tables("TProjectCorporation").Rows.Count
            If i = 0 Then
                Dim j As Integer
                For j = 0 To count - 1
                    replaceList.Add(StrSpace)
                Next
            End If
            If i > 0 Then
                dr = ds.Tables("TProjectCorporation").Rows(0)
                With dr
                    '��ҵ����
                    If Not .Item("corporation_name") Is System.DBNull.Value Then
                        replaceList.Add(.Item("corporation_name"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ҵ����Ӫҵִ�պ���
                    If Not .Item("business_licence_code") Is System.DBNull.Value Then
                        replaceList.Add(.Item("business_licence_code"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'Ӫҵ���޿�ʼ
                    If Not .Item("business_start_date") Is System.DBNull.Value Then
                        replaceList.Add(CType(.Item("business_start_date"), Date).ToString("yyyy��MM��dd��"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'Ӫҵ���޽���
                    If Not .Item("business_end_date") Is System.DBNull.Value Then
                        replaceList.Add(CType(.Item("business_end_date"), Date).ToString("yyyy��MM��dd��"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'ע���ַ:����
                    If Not .Item("district_name") Is System.DBNull.Value Then
                        replaceList.Add(.Item("district_name"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'ע���ַ:��ַ
                    If Not .Item("register_address") Is System.DBNull.Value Then
                        replaceList.Add(.Item("register_address"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'ע���ʱ�
                    If Not .Item("register_capital") Is System.DBNull.Value Then
                        replaceList.Add(.Item("register_capital"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    'ʵ���ʱ�
                    If Not .Item("real_capital") Is System.DBNull.Value Then
                        replaceList.Add(.Item("real_capital"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�����ֽ�λ
                    If Not .Item("cash_receive") Is System.DBNull.Value Then
                        replaceList.Add(.Item("cash_receive"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�����ʲ�
                    If Not .Item("invisible_assets") Is System.DBNull.Value Then
                        replaceList.Add(.Item("invisible_assets"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '����������
                    If Not .Item("legal_representative") Is System.DBNull.Value Then
                        replaceList.Add(.Item("legal_representative"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '����
                    If Not .Item("nationality") Is System.DBNull.Value Then
                        replaceList.Add(.Item("nationality"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '���֤����
                    If Not .Item("id_card") Is System.DBNull.Value Then
                        replaceList.Add(.Item("id_card"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�������
                    If Not .Item("loan_card_id") Is System.DBNull.Value Then
                        replaceList.Add(.Item("loan_card_id"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ҵ���˴���֤����
                    If Not .Item("corp_paper_id") Is System.DBNull.Value Then
                        replaceList.Add(.Item("corp_paper_id"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ҵ���ŵȼ�
                    If Not .Item("credit_grade") Is System.DBNull.Value Then
                        replaceList.Add(.Item("credit_grade"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '��ҵ����
                    If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                        replaceList.Add(.Item("proprietorship_type"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�����������
                    If Not .Item("technology_type") Is System.DBNull.Value Then
                        replaceList.Add(getTechnologyType(.Item("technology_type")))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                    '�뵣�������˹�ϵ
                    If Not .Item("relation") Is System.DBNull.Value Then
                        replaceList.Add(.Item("relation"))
                    Else
                        replaceList.Add(StrSpace)
                    End If
                End With
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    'ͨ��project_credit_appraise������һ�������󱨸���滻����(6�����������滻��־)
    Private Sub SetReviewAppraise(ByRef replaceList As ArrayList, ByVal strTypeText As String)

        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow

        Try
            strSql = "{project_code='" & Me.StrProjectCode & "' and corporation_code='" & Me.StrCorporationCode _
                        & "' and phase='" & Me.StrPhase & "'order by month desc}"
            ds = gWs.FetchProjectCredit(strSql)
            Dim dblQuantity, dblQuality, dblTotal As Double
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                dblQuantity = IIf(dr.Item("quantity_score") Is System.DBNull.Value, 0, dr.Item("quantity_score"))
                dblQuality = IIf(dr.Item("quality_score") Is System.DBNull.Value, 0, dr.Item("quality_score"))
                dblTotal = IIf(dr.Item("total_score") Is System.DBNull.Value, 0, dr.Item("total_score"))
            End If

            If Not strTypeText = "45102" Then '�������滻��־Ϊ3��
                replaceList.Add(Format(dblQuantity, "#,###.00").ToString)
                replaceList.Add(Format(dblQuality, "#,###.00").ToString)
                replaceList.Add(Format(dblTotal, "#,###.00").ToString)
            End If

            replaceList.Add(Format(dblQuantity, "#,###.00"))
            replaceList.Add(Format(dblQuality, "#,###.00"))
            replaceList.Add(Format(dblTotal, "#,###.00"))
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '
    '�Ӽ������г�ȡһЩ��������һ�������󱨸���滻����(13�����󱨸����滻��־)
    Private Sub SetReviewBreif(ByRef replaceList As ArrayList)
        Dim strSql As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strReplace(11) As String

        For i = 0 To 10 '����ֵ
            strReplace(i) = Me.StrSpace
        Next

        Try

            '1.��projectcorporation���л�ȡ������ҵ�滻��־
            strSql = "{project_code='" & Me.StrProjectCode & "' and corporation_code='" & Me.StrCorporationCode & "'}"
            'ds = gWs.FetchProjectCorporation(strSql)
            ds = gWs.FetchProjectCorporation(StrProjectCode, StrCorporationCode, "1", StrPhase)
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                strReplace(0) = dr.Item("corporation_name").ToString
                'strReplace(1) = dr.Item("found_date").ToString'������е�����ֶζ��ǿ�
                strReplace(2) = dr.Item("register_address").ToString()
                strReplace(3) = dr.Item("register_capital").ToString()
                'strReplace(4) = dr.Item("").ToString()
                'strReplace(5) = dr.Item("").ToString()
                strReplace(6) = dr.Item("leading_product").ToString()
                If Not dr.Item("technology_type") Is System.DBNull.Value Then
                    strReplace(7) = Me.getTechName(dr.Item("technology_type"))
                End If

            End If

            '2.��corporation���ȡ����ʱ��
            Dim strCorpSql As String = "{corporation_code='" & Me.StrCorporationCode & " ' and corporation_type='1'}"
            ds = gWs.GetcorporationInfo(strCorpSql, "null")
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                If Not dr.Item("found_date") Is System.DBNull.Value Then
                    strReplace(1) = Format(dr.Item("found_date"), "yyyy-MM")
                Else
                    strReplace(1) = ""
                End If
            End If

            '3.����ѯ���л�ȡ��ҵ��������۶�������������ܶ�
            Dim strConsult As String = "{corporation_code='" & Me.StrCorporationCode & "'}"
            ds = gWs.GetcorporationInfo("", strConsult)
            i = ds.Tables(1).Rows.Count
            If i > 0 Then
                dr = ds.Tables(1).Select("", "serial_num DESC")(0)
                strReplace(4) = dr.Item("lastyear_sales_income").ToString()
                strReplace(5) = dr.Item("lastyear_total_profit").ToString()
            End If

            '4.��project���ȡ��������
            ds = gWs.GetProjectInfo(strSql)
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                strReplace(8) = dr.Item("apply_sum").ToString
                strReplace(9) = dr.Item("apply_term").ToString
                strReplace(10) = dr.Item("purpose").ToString
            End If

            For i = 0 To 10
                replaceList.Add(strReplace(i))
            Next

            '5������Ŀ�������(ͨ�����÷���)
            Me.SetReviewManagerOpinion(replaceList)

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    'ͨ��ProjectOpinion���������󱨸��滻����(2����Ŀ��������)
    Private Sub SetReviewManagerOpinion(ByRef replaceList As ArrayList)
        Try

            '*-------------qxd add 2003-12-4-------------
            '��Ŀ����A,B�����
            Dim strSql As String
            Dim dsOpinion As DataSet
            Dim drOpinion As DataRow

            '��Ŀ����A�����(52,002)
            strSql = "{project_code='" & StrProjectCode & "' and item_type='52' and item_code='002'}"
            dsOpinion = gWs.GetProjectOpinionByProjectNo(strSql)
            If dsOpinion.Tables(0).Rows.Count > 0 Then
                drOpinion = dsOpinion.Tables(0).Rows(0)
                If Not drOpinion.Item("content") Is System.DBNull.Value Then
                    replaceList.Add(replaceExt(drOpinion.Item("content"), ""))
                Else
                    replaceList.Add(StrSpace)
                End If
            Else
                replaceList.Add(StrSpace)
            End If

            '��Ŀ����B�����(52,005)
            strSql = "{project_code='" & StrProjectCode & "' and item_type='52' and item_code='005'}"
            dsOpinion = gWs.GetProjectOpinionByProjectNo(strSql)
            If dsOpinion.Tables(0).Rows.Count > 0 Then
                drOpinion = dsOpinion.Tables(0).Rows(0)
                If Not drOpinion.Item("content") Is System.DBNull.Value Then
                    replaceList.Add(replaceExt(drOpinion.Item("content"), ""))
                Else
                    replaceList.Add(StrSpace)
                End If
            Else
                replaceList.Add(StrSpace)
            End If
            '*-------------qxd end 2003-12-1-------------
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub SetDefectRecord(ByVal replacelist)
        '2007-12-24 yjf add �滻ʧ�ż�¼
        Dim dsDefectRecord As DataSet = gWs.GetCorpDefectInfo("{corporation_code='" & StrCorporationCode & "'}")
        If dsDefectRecord.Tables(0).Rows.Count <> 0 Then
            Dim strDefectRecord, strTemp, strTemp1, strTemp2, strTemp3 As String
            Dim x As Integer
            For x = 0 To dsDefectRecord.Tables(0).Rows.Count - 1
                strTemp1 = IIf(IsDBNull(dsDefectRecord.Tables(0).Rows(x).Item("DiscreditableDate")), "", dsDefectRecord.Tables(0).Rows(x).Item("DiscreditableDate"))
                strTemp2 = IIf(IsDBNull(dsDefectRecord.Tables(0).Rows(x).Item("source")), "", dsDefectRecord.Tables(0).Rows(x).Item("source"))
                strTemp3 = IIf(IsDBNull(dsDefectRecord.Tables(0).Rows(x).Item("description")), "", dsDefectRecord.Tables(0).Rows(x).Item("description"))
                strTemp = strTemp1 & "   " & strTemp2 & "   " & strTemp3
                strDefectRecord = strDefectRecord & vbCrLf & strTemp
            Next
            replacelist.Add(strDefectRecord)
        Else
            replacelist.Add(StrSpace)
        End If
    End Sub
    '
    'ͨ����opposite_guarantee_assurer���ø����ʲ��嵥
    Private Sub SetReviewAssurer(ByRef replaceList As ArrayList)

        Dim strSql As String
        Dim dsAssurer As DataSet
        Dim dr As DataRow
        Dim i As Int16
        Dim sbReplace As New System.Text.StringBuilder

        strSql = "{project_code='" & Me.StrProjectCode & "'}"
        Try
            dsAssurer = gWs.GetOppositeGuaranteeAssurerInfo(strSql)
            If Not dsAssurer Is Nothing And Not dsAssurer.Tables(0) Is Nothing AndAlso dsAssurer.Tables(0).Rows.Count > 0 Then
                i = dsAssurer.Tables(0).Rows.Count
                For i = 0 To i - 1
                    dr = dsAssurer.Tables(0).Rows(i)
                    sbReplace.Append("  ��֤��������")
                    sbReplace.Append(dr.Item("name").ToString)
                    sbReplace.Append("  ���䣺")
                    sbReplace.Append(dr.Item("age").ToString())
                    sbReplace.Append("  �Ա�")
                    sbReplace.Append(dr.Item("sex").ToString())
                    sbReplace.Append(ControlChars.Cr) ''
                    sbReplace.Append("  ���֤���룺")
                    sbReplace.Append(dr.Item("ic_code").ToString())
                    sbReplace.Append("  סַ��")
                    sbReplace.Append(dr.Item("address").ToString())
                    sbReplace.Append(ControlChars.Cr) ''
                    sbReplace.Append("  �绰���룺")
                    sbReplace.Append(dr.Item("phone").ToString())
                    sbReplace.Append("  ������")
                    sbReplace.Append(dr.Item("guarantee_sum").ToString())
                    sbReplace.Append(ControlChars.Cr) ''
                    sbReplace.Append("  �����ʲ��嵥��")
                    sbReplace.Append(crlfToCr(dr.Item("assets_bill").ToString()))
                    'sbReplace.Append(Me.replaceExt(dr.Item("assets_bill").ToString(), ""))
                    If Not i = dsAssurer.Tables(0).Rows.Count - 1 Then '�������һ��ʱ��Ҫ���ϻس���
                        sbReplace.Append(ControlChars.Cr) ''
                    End If
                Next
                replaceList.Add(sbReplace.ToString())
            Else
                replaceList.Add(StrSpace)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    Private Function getTechName(ByVal code As Int16) As String
        Dim i As Int16
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strReturn As System.String

        Try
            ds = gWs.GetTechnologyType("%")
            i = ds.Tables(0).Rows.Count
            For i = 0 To i - 1
                dr = ds.Tables(0).Rows(i)
                If (dr.Item("technology_type_code") And code) = 0 Then
                    'strreturn.Append("��"c)
                    strReturn = strReturn + "��"
                Else
                    'strreturn.Append("��"c)
                    strReturn = strReturn + "��"
                End If
                'strreturn.Append(dr.Item("technology_type").ToString)
                strReturn = strReturn + dr.Item("technology_type").ToString + "   "
            Next
            Return strReturn.Trim
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '�����ַ���,�����еĻس����з��滻�ɻس���
    Private Function crlfToCr(ByVal strReplace As String) As String
        Dim strReturn As String

        If strReplace = "" Then Return ""

        If Not strReplace.IndexOf(ControlChars.CrLf) = -1 Then
            strReturn = strReplace.Replace(ControlChars.CrLf, ControlChars.Cr)
            Return strReturn
        End If
    End Function

    'ͨ��moneyID���moneyName���ҵ�λ
    Private Function getMoneyName(ByVal moneyID As String)
        Dim strSql, strMoneyName As String
        Dim i, count As Integer
        Dim ds As DataSet
        Try
            ds = gWs.GetMoneyInfo(moneyID)
            If Not ds Is Nothing Then
                If ds.Tables(0).Rows.Count > 0 Then
                    strMoneyName = ds.Tables(0).Rows(0).Item("name")
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        Return strMoneyName
    End Function
End Class
