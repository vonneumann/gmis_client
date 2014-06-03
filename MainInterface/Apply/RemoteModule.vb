Module RemoteModule

    '*******************************
    'ע��:�������е��ж���䱻������,ԭ����:���ڵ������Ϊȫ�ֵ�����
    '���ı���Щ���Ե�ֵ(���ݿ��е�ֵ,ͨ��ϵͳ���øı��)ʱ,ȫ�ֱ�����
    '����,�ʲ������»�ȡ���µ�ֵ,���Ǵ����.
    '�޸���:quexd 2003-8-6 17:50
    'ȷ����:yanxuekui(��Ŀ����)
    '*******************************

    '
    'ת������
    '
    'Private trans_Condition As DataSet
    'Public ReadOnly Property TransDS() As DataSet
    '    Get
    '        If trans_Condition Is Nothing Then
    '            trans_Condition = 
    '        End If
    '    End Get
    'End Property
    '
    '����
    '
    'Private mod_WebService As htfServer1.Service1 = Nothing
    Public ReadOnly Property VouchService() As htfServer.Service1
        Get
            Return gWs
        End Get
    End Property

    '
    '״̬��Ϣ
    '
    Private ds_State As DataSet = Nothing
    Public ReadOnly Property StateDS()
        Get
            If ds_State Is Nothing Then
                ds_State = Nothing 'VouchService.GetState("%")
            End If
            Return ds_State
        End Get
    End Property

    '
    '�׶���Ϣ
    '
    Private ds_Phase As DataSet = Nothing
    Public ReadOnly Property PhaseDS() As DataSet
        Get
            'If (ds_Phase Is Nothing) Then
            ds_Phase = VouchService.GetPhase("%")
            'End If
            Return ds_Phase
        End Get
    End Property

    '
    '����--�����Ӧ���ݼ�
    '
    Private ds_Bank As DataSet = Nothing
    Public ReadOnly Property BankDS() As DataSet
        Get
            'If ds_Bank Is Nothing Then
            ds_Bank = VouchService.GetBankInfo("%", "%")
            'End If
            Return ds_Bank.Copy()
        End Get
    End Property

    'Private ds_Branch As DataSet = Nothing
    'Public ReadOnly Property BranchDS() As DataSet
    '    Get
    '        If ds_Branch Is Nothing Then
    '            ds_Branch = VouchService.GetBranch
    '        End If
    '    End Get
    'End Property
    '
    '���ݴ������е����������´���֧�е���Ϣ
    '
    Public Function GetBranchs(ByVal bank As String) As DataRow()
        Return BankDS.Tables("bank_branch").Select("bank_code='" + bank + "'")
    End Function

    Public Function GetBranchDT(ByVal bank As String) As DataTable
        Dim dt As DataTable = BankDS.Tables("bank_branch").Clone()
        Dim rs() As DataRow = GetBranchs(bank)
        Dim i As Integer
        For i = 0 To rs.Length - 1
            dt.ImportRow(rs(i))
        Next
        Return dt
    End Function

    Public Function GetBranchDT2(ByVal bank As String) As DataTable
        Return VouchService.GetBankInfo("", "{bank_code='" + bank + "'}").Tables("bank_branch")
    End Function
    '
    'ҵ��Ʒ��
    '
    Private ds_ServiceType As DataSet = Nothing
    Public ReadOnly Property ServiceTypeDS() As DataSet
        Get
            'If ds_ServiceType Is Nothing Then
            ds_ServiceType = VouchService.GetServiceType("%")
            'End If
            Return ds_ServiceType.Copy()
        End Get
    End Property

    '
    '�Ƽ��ˣ���λ������
    '
    Private ds_RecommendType As DataSet = Nothing
    Public ReadOnly Property RecommendTypeDS() As DataSet
        Get
            'If ds_RecommendType Is Nothing Then
            ds_RecommendType = New DataSet()
            ds_RecommendType.Merge(VouchService.GetRecommendType("%").Tables("TRecommendType").Select("", "type_code"))
            'End If
            Return ds_RecommendType.Copy()
        End Get
    End Property

    Public Function GetRecommendCode(ByVal ty As String) As String
        Dim dr() As DataRow = RecommendTypeDS.Tables("TRecommendType").Select("recommend_type='" + ty + "'")
        If dr.Length > 0 Then
            Return dr(0).Item("type_code")
        Else
            Return "01"
        End If
    End Function

    Public Function GetRecommendType(ByVal code As String) As String
        Dim dr() As DataRow = RecommendTypeDS.Tables("TRecommendType").Select("type_code='" + code + "'")
        If dr.Length > 0 Then
            Return dr(0).Item("recommend_type")
        Else
            Return ""
        End If
    End Function
    '
    '������Ϣ
    '
    Private ds_CooperatorInfo As DataSet = Nothing
    Public ReadOnly Property CooperatorInfoDS() As DataSet
        Get
            'If ds_CooperatorInfo Is Nothing Then
            ds_CooperatorInfo = VouchService.GetCooperateOpinionInfo("%", "%")
            'End If
            Return ds_CooperatorInfo.Copy()
        End Get
    End Property
    '
    '�������
    '
    Private ds_District As DataSet = Nothing
    Public ReadOnly Property DistrictDS() As DataSet
        Get
            'If ds_District Is Nothing Then
            ds_District = VouchService.GetDistrict("%")
            'End If
            Return ds_District.Copy()
        End Get
    End Property

    Private ds_District_Parent As DataSet = Nothing
    Public ReadOnly Property DistrictDSParent() As DataSet
        Get
            ds_District_Parent = VouchService.GetCommonQueryInfo("select * from district_parent order by district_parent_code")
            Return ds_District_Parent.Copy()
        End Get
    End Property

    '
    '��ҵ����
    '
    Private ds_CorpType As DataSet = Nothing
    Public ReadOnly Property CorpTypeDS() As DataSet
        Get
            'If ds_CorpType Is Nothing Then
            ds_CorpType = VouchService.GetCorporationType("%")
            'End If
            Return ds_CorpType.Copy()
        End Get
    End Property
    '
    '��ҵ����
    '
    Private ds_IndustryType As DataSet = Nothing
    Public ReadOnly Property IndustryTypeDS() As DataSet
        Get
            'If ds_IndustryType Is Nothing Then
            ds_IndustryType = VouchService.GetIndustryType("%")
            'End If
            Return ds_IndustryType.Copy()
        End Get
    End Property


    '
    '����������
    '
    Private ds_ProprietorShip As DataSet = Nothing
    Public ReadOnly Property ProprietorShipDS() As DataSet
        Get
            'If ds_ProprietorShip Is Nothing Then
            ds_ProprietorShip = VouchService.GetProprietorshipType("%")
            'End If
            Return ds_ProprietorShip.Copy()
        End Get
    End Property
    '
    '�Ƽ�����
    '
    Private ds_TechnologyType As DataSet = Nothing
    Public ReadOnly Property TechnologyTypeDS() As DataSet
        Get
            'If ds_TechnologyType Is Nothing Then
            ds_TechnologyType = VouchService.GetTechnologyType("%")
            'End If
            Return ds_TechnologyType.Copy()
        End Get
    End Property

    '
    '������Ϣ
    '
    Private ds_CurrencyType As DataSet = Nothing
    Public ReadOnly Property CurrencyDS() As DataSet
        Get
            'If ds_CurrencyType Is Nothing Then
            ds_CurrencyType = New DataSet("CurrencyDST")
            ds_CurrencyType.Merge(VouchService.GetCurrency("%").Tables("TCurrency").Select("", "currency_code"))
            'End If
            Return ds_CurrencyType.Copy()
        End Get
    End Property

    '
    '���ʽ
    '
    Private ds_LoanType As DataSet = Nothing
    Public ReadOnly Property LoanTypeDS() As DataSet
        Get
            'If ds_LoanType Is Nothing Then
            ds_LoanType = VouchService.GetLoanType("%")
            'End If
            Return ds_LoanType.Copy()
        End Get
    End Property
    '
    '��������
    '
    '
    Private ds_LoanForm As DataSet = Nothing
    Public ReadOnly Property LoanFormDS() As DataSet
        Get
            'If ds_LoanForm Is Nothing Then
            ds_LoanForm = VouchService.GetLoanForm("%")
            'End If
            Return ds_LoanForm.Copy()
        End Get
    End Property

    '
    '���ʷ�ʽ
    '
    Private ds_InvestForm As DataSet = Nothing
    Public ReadOnly Property InvestFormDS() As DataSet
        Get
            'If ds_InvestForm Is Nothing Then
            ds_InvestForm = VouchService.GetInvestForm("%")
            'End If
            Return ds_InvestForm.Copy()
        End Get
    End Property

    '
    '����Ա��
    '
    Private ds_Staff As DataSet = Nothing
    Public ReadOnly Property StaffDS() As DataSet
        Get
            'If ds_Staff Is Nothing Then
            ds_Staff = VouchService.GetStaff("%")
            'End If
            Return ds_Staff.Copy()
        End Get
    End Property

    '
    'ͨ����Ŀ(itemtype)���ƻ�ȡ��Ŀ����
    '
    Public Function GetItemTypeByName(ByVal name As String) As String
        Return VouchService.GetItemType("{type_name='" + name + "'}").Tables("TItemType").Rows(0).Item("item_type")
    End Function
    '
    'ͨ����Ŀ(item)�����ȡ��Ŀ����
    '
    Public Function GetItemTypeByCode(ByVal code As String) As String
        Dim rc As DataRowCollection = VouchService.GetItemEx("{item_code='" + code + "'}").Tables("TItem").Rows
        If rc.Count > 0 Then
            Return rc(0).Item("item_type")
        Else
            Return String.Empty
        End If
    End Function
    '
    'ͨ����Ŀ(item)���ƻ�ȡ������Ŀ��Ϣ
    '
    'Public Function GetItemInfoByName(ByVal name As String) As DataRow
    '    Dim rc As DataRowCollection = VouchService.GetItemEx("{item_name='" + name + "'}").Tables("TItem").Rows
    '    If rc.Count > 0 Then
    '        Return rc(0)
    '    Else
    '        Return Nothing
    '    End If
    'End Function
    '
    '������������ʲ���ծ��������ֽ�������
    '
    Private ds_Finances As DataSet = Nothing
    Public Function MakeFinanceTable(ByVal tname As String) As DataTable

        Dim it() As String = {"item_code", "item_name", "value"}
        Dim tp() As String = {"System.String", "System.String", "System.Decimal"}

        Dim ret As New DataTable(tname)
        Dim i As Integer

        For i = 0 To it.Length - 1
            ret.Columns.Add(New DataColumn(it(i), System.Type.GetType(tp(i))))
        Next

        Dim s As String = GetItemTypeByName(tname)
        Dim ds As DataSet = VouchService.GetItem("%", s)
        Dim dr As DataRow

        For i = 0 To ds.Tables("TItem").Rows.Count - 1
            dr = ret.NewRow
            With dr
                .Item(0) = ds.Tables("TItem").Rows(i).Item("item_code")
                .Item(1) = ds.Tables("TItem").Rows(i).Item("item_name")
                .Item(2) = 0.0
            End With
            ret.Rows.Add(dr)
        Next
        Return ret

    End Function

    Public ReadOnly Property FinancesDS() As DataSet
        Get
            If (ds_Finances Is Nothing) Then
                ds_Finances = New DataSet("���񱨱�")
                ds_Finances.Tables.Add(MakeFinanceTable("�ʲ���ծ��"))
                ds_Finances.Tables.Add(MakeFinanceTable("�����"))
                ds_Finances.Tables.Add(MakeFinanceTable("�ֽ�������"))
            End If
            Return ds_Finances
        End Get
    End Property

    '
    'ͨ����ҵ����(code)��WebService������ҵ����
    '
    Public Function GetCorporationNameByCode(ByVal code As Integer) As String
        Dim dt As DataTable = VouchService.GetcorporationInfo(code, "").Tables("corporation")
        If dt.Rows.Count = 0 Then GetCorporationNameByCode = String.Empty
        GetCorporationNameByCode = dt.Rows(0).Item("corporation_name")
    End Function
    ''
    ''ͨ����ҵ����������Ŀ����
    ''
    'Public Function GetProjCodeByCorpCode(ByVal code As String) As String
    '    Dim dt As DataTable = VouchService.GetProjectInfo("{corporation_code='" + code.ToString + "'}").Tables("project")
    '    If dt.Rows.Count = 0 Then GetProjCodeByCorpCode = String.Empty
    '    GetProjCodeByCorpCode = dt.Rows(0).Item("project_code")
    'End Function
    '
    'ͨ����Ŀ�����ȡ��ҵ����
    '
    Public Function GetCorpCodeByProjCode(ByVal code As String) As String
        Dim dt As DataTable = VouchService.GetProjectInfo("{project_code='" + code + "'}").Tables("project")
        If dt.Rows.Count = 0 Then GetCorpCodeByProjCode = String.Empty
        GetCorpCodeByProjCode = dt.Rows(0).Item("corporation_code")
    End Function
    '
    '��ȡ��Ŀ���벻Ϊcode����Ŀ��,Ŀ����Ϊ���ҵ���ǰ��Ŀ��ҵ��ȥ�ĵ�����Ϣ
    '
    Public Function GetProjRejectCode(ByVal ccode As String, ByVal pcode As String) As DataTable
        Dim dt As New DataTable("rproject")
        Dim drs(), dr As DataRow
        Dim i, j As Integer

        Dim ds As DataSet = VouchService.GetProjectInfo("{corporation_code='" + ccode + "'}")
        For i = 0 To ds.Tables("project").Columns.Count - 1
            dt.Columns.Add(ds.Tables("project").Columns(i).ColumnName, ds.Tables("project").Columns(i).DataType)
        Next

        drs = ds.Tables("project").Select("project_code <> '" + pcode + "'")
        For i = 0 To drs.Length - 1
            dr = dt.NewRow
            For j = 0 To dt.Columns.Count - 1
                dr.Item(j) = drs(i).Item(j)
            Next
            dt.Rows.Add(dr)
        Next
        If i <> 0 Then dt.AcceptChanges()

        Return dt

    End Function

End Module
