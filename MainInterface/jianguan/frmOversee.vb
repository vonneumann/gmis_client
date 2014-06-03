Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml
Public Class frmOversee
    Inherits System.Windows.Forms.Form
    'Create by Daniel on 2013-8-22
    Private SqlConn As SqlClient.SqlConnection
    Private OverseeInfoBean As DataSet = New DataSet()
    Dim StartingDate, ClosingDate As DateTime
    'Dim SqlParamList As ArrayList
    Dim OptTableName As String
    Dim InfoTableName As String = "OverseeInfoGuaranteeProject"   'GuaranteeProjects
    Dim AppService As SqlService = New SqlService()
    Dim NeedRefreshReleasePro As Boolean
    Dim NeedRefreshCompensatePro As Boolean
    Dim NeedRefreshSubrogationPro As Boolean
    Dim NeedRefreshBankCredit As Boolean
    Dim NothingToDo As Boolean
    Private Sub frmOversee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '��ܴ������
        StartingDate = CType(System.DateTime.Now, DateTime).ToShortDateString()
        ClosingDate = StartingDate
        OptTableName = "StatusDictionary"
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim strSql As String = "Select ReportStatus from OverseeInfoStatusDictionary"
        Dim SqlType As CommandType = CommandType.Text
        Me.OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, OptTableName, Nothing)

        GetHisLoanProject()
        ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetLoanProjectsFormat(OptTableName), Me.LoanProjectList)
        NeedRefreshReleasePro = True
        NeedRefreshCompensatePro = True
        NeedRefreshSubrogationPro = True
        NeedRefreshBankCredit = True
        GetOverseeInfo.Enabled = False
        SaveToXml.Enabled = False
        NothingToDo = True
    End Sub
    Private Sub StartDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartDate.LostFocus
        '�ϱ���ʼ�����¼�����
        GetOverseeInfo.Enabled = True
    End Sub
    Private Sub StartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartDate.ValueChanged
        '�ϱ���ʼ���ڱ仯�¼�����
        NeedRefreshReleasePro = True
        NeedRefreshCompensatePro = True
        NeedRefreshSubrogationPro = True
    End Sub
    Private Sub EndDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EndDate.LostFocus
        '�ϱ���ֹ�����¼�����
        GetOverseeInfo.Enabled = True
    End Sub
    Private Sub EndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndDate.ValueChanged
        '�ϱ���ֹ���ڱ仯�¼�����
        NeedRefreshReleasePro = True
        NeedRefreshCompensatePro = True
        NeedRefreshSubrogationPro = True
    End Sub
    Private Sub GetOverseeInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetOverseeInfo.Click
        '��ȡ�ϱ���Ϣ��ť�¼�
        Dim SqlParamList As ArrayList
        OverseeTab.SelectTab(0)
        StartingDate = CType(Me.StartDate.Text, DateTime).ToShortDateString()
        ClosingDate = CType(Me.EndDate.Text, DateTime).ToShortDateString()
        SqlParamList = New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        SqlParamList.Add(New SqlClient.SqlParameter("@EndDate", ClosingDate))
        Dim ReportedProjects As Integer = CheckReportPeriod(SqlParamList)

        If ReportedProjects < 1 Then
            InfoTableName = "OverseeInfoGuaranteeProject"
            GetAllGuaranteeProject(SqlParamList)
            ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetLoanProjectsFormat(OptTableName), Me.LoanProjectList)

            GetLoanClients()
            ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetLoanClientsFormat(), Me.ClientList)
            GetOverseeInfo.Enabled = False
            SaveToXml.Enabled = True
        Else
            MessageBox.Show("��ѡ�ϱ��������ϱ��������ظ��ϱ���", "������ʾ")
            GetOverseeInfo.Enabled = False
        End If
        SqlParamList = Nothing
    End Sub
    Private Sub OverseeTab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OverseeTab.SelectedIndexChanged
        '��ǩҳ�л��¼�����
        Dim CurDataGrid As DataGridView = LoanProjectList
        Dim strFilter As String
        Dim i As Integer = OverseeTab.SelectedIndex()
        OverseeTab.SelectTab(i)  'if get TabName:OverseeTab.SelectedTab.Name
        Select Case i
            Case 0
                CurDataGrid = CandidateProjectList
                InfoTableName = "OverseeInfoGuaranteeProject"
                strFilter = "ReportStatus='�ϱ�'and CtrlStatus<>'�ѱ�'" '�ظ��ϱ��Ĳ�������
                SplitOverseeInfo(CurDataGrid, SetLoanProjectsFormat(OptTableName), InfoTableName, strFilter)
                GetOverseeInfo.Enabled = False
            Case 1
                CurDataGrid = AbortProjectList
                InfoTableName = "OverseeInfoGuaranteeProject"
                strFilter = "ReportStatus='�˱�' and CtrlStatus='�ѱ�'" '�ϱ�δ�����˱���Ŀ��ζ���ϱ�����
                SplitOverseeInfo(CurDataGrid, SetLoanProjectsFormat(OptTableName), InfoTableName, strFilter)
                GetOverseeInfo.Enabled = False
            Case 2
                CurDataGrid = ClientList
                InfoTableName = "KHXX"  'LoanClients
                strFilter = "1=1"
                Dim UnReportedProjects As ArrayList = New ArrayList()
                If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
                    If OverseeInfoBean.Tables(InfoTableName).Rows.Count > 0 Then
                        InfoTableName = "OverseeInfoGuaranteeProject"
                        For Each UnReportedProject As DataRow In OverseeInfoBean.Tables(InfoTableName).Select("ReportStatus<>'�ϱ�'")
                            UnReportedProjects.Add(UnReportedProject("XMBH"))
                        Next
                        InfoTableName = "KHXX"
                        OverseeInfoBean.Tables(InfoTableName).RejectChanges()   '����ɾ�����
                        For Each GuaranteeProject As DataRow In OverseeInfoBean.Tables(InfoTableName).Rows()
                            If UnReportedProjects.Contains(GuaranteeProject("XMBH")) Then
                                GuaranteeProject.Delete()
                            End If
                        Next
                        SplitOverseeInfo(CurDataGrid, SetLoanClientsFormat(), InfoTableName, strFilter)
                    End If
                End If
                GetOverseeInfo.Enabled = False
            Case 3
                CurDataGrid = ReleaseProjectList
                InfoTableName = "ZRJC"    'ReleaseProjects
                If NeedRefreshReleasePro Then GetReleaseProjects()
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetReleaseProjectsFormat(), CurDataGrid)
            Case 4
                CurDataGrid = CompensateProjectList
                InfoTableName = "DCHK"  'CompensateProjects
                If NeedRefreshCompensatePro Then GetCompensateProjects()
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetCompensateProjectsFormat(OptTableName), CurDataGrid)
            Case 5
                CurDataGrid = SubrogationProjectList
                InfoTableName = "ZHSS"   'SubrogationProjects
                If NeedRefreshSubrogationPro Then GetSubrogationProjects()
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetSubrogationProjectsFormat(OptTableName), CurDataGrid)
            Case 6
                CurDataGrid = CreditByBank
                InfoTableName = "YHSX"    'BankCredit
                If NeedRefreshBankCredit Then GetCreditByBank()
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetCreditByBankFormat(), CurDataGrid)
        End Select
    End Sub
    Private Sub LoanProjectList_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoanProjectList.CurrentCellChanged
        '��Ŀ�ϱ�״̬�仯�¼�����
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim strFilter As String = "ReportStatus='�ϱ�'and CtrlStatus<>'�ѱ�'"
        SplitOverseeInfo(CandidateProjectList, SetLoanProjectsFormat(OptTableName), InfoTableName, strFilter)
    End Sub
    Private Sub ExitOversee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitOversee.Click
        If NothingToDo = False Then
            UpdateOverseeLoanProject()
            UpdateOverseeCreditByBank()
        End If
        Me.Close()
    End Sub

    Private Sub GetHisLoanProject()
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim strSql As String = "Select XMBH,BM,XH,JGMC,XKZBH,KHID,KHMC,KHLX,XMMC,YWLX,YWPZ,DKYTSUHY,CYYT,KSSJ,JSSJ,ZRJE,DBFJE,SXYHMC,YWPZFZ,ReportStatus,ReportStatus as CtrlStatus from OverseeInfoGuaranteeProject"
        Dim SqlType As CommandType = CommandType.Text
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
    End Sub
    Private Function CheckReportPeriod(ByVal SqlParamList As ArrayList) As Integer
        Dim ds As DataSet = New DataSet()
        InfoTableName = "ReportStatus"
        Dim strSql As String = "SELECT COUNT(*) AS ReportedProjects FROM OverseeInfoGuaranteeProject WHERE (KSSJ >=CONVERT(varchar(10) ,'" & StartingDate & "',120) ) AND (KSSJ < CONVERT(varchar(10) ,'" & ClosingDate & "',120))"
        Dim SqlType As CommandType = CommandType.Text
        ds = AppService.GetEntityBean(strSql, SqlType, ds, InfoTableName, Nothing)
        Return ds.Tables(InfoTableName).Rows(0).Item(0)
    End Function

    Private Sub GetAllGuaranteeProject(ByVal SqlParamList As ArrayList)
        Dim strSql As String = "OverseeAppendGuaranteeProject"
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        AppService.UpdateEntityBean(strSql, SqlType, SqlParamList) 'Save to DBMS
        OverseeInfoBean.Tables(InfoTableName).Clear()
        GetHisLoanProject()
    End Sub
    Private Sub GetLoanClients()
        InfoTableName = "KHXX"
        'Delete the fetched Clients
        If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
            OverseeInfoBean.Tables(InfoTableName).Clear()
        End If

        Dim strSql As String = "OverseeForClient"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
    End Sub
    Private Sub GetReleaseProjects()
        'Delete the fetched ReleaseProjects
        Dim SqlParamList As New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        SqlParamList.Add(New SqlClient.SqlParameter("@EndDate", ClosingDate))

        If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
            OverseeInfoBean.Tables(InfoTableName).Clear()
        End If

        Dim strSql As String = "OverseeForReleaseProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, SqlParamList)
        NeedRefreshReleasePro = False
    End Sub
    Private Sub GetCompensateProjects()
        'Delete the fetched CompensateProjects
        Dim SqlParamList As New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        SqlParamList.Add(New SqlClient.SqlParameter("@EndDate", ClosingDate))

        If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
            OverseeInfoBean.Tables(InfoTableName).Clear()
        End If

        Dim strSql As String = "OverseeForCompensateProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, SqlParamList)
        NeedRefreshCompensatePro = False
    End Sub
    Private Sub GetCreditByBank()
        Dim strSql As String = "OverseeForBankCredit"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
        NeedRefreshBankCredit = False
    End Sub
    Private Sub GetSubrogationProjects()
        Dim SqlParamList As New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        SqlParamList.Add(New SqlClient.SqlParameter("@EndDate", ClosingDate))

        If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
            OverseeInfoBean.Tables(InfoTableName).Clear()
        End If

        Dim strSql As String = "OverseeForSubrogationProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, SqlParamList)
        NeedRefreshSubrogationPro = False
    End Sub
    Private Function SetTextColumnFormat(ByVal DPN As String, ByVal HeadTxt As String, ByVal ColName As String, ByVal RW As Boolean) As DataGridViewTextBoxColumn
        Dim ColumnFormat As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        With ColumnFormat
            .DataPropertyName = DPN
            .HeaderText = HeadTxt
            .Name = ColName
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .ReadOnly = RW
        End With
        Return ColumnFormat
    End Function
    Private Function SetComBoxColumnFormat(ByVal OptTableName As String, ByVal DPN As String, ByVal HeadTxt As String, ByVal ColName As String, ByVal RW As Boolean) As DataGridViewComboBoxColumn
        Dim ColumnFormat As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
        With ColumnFormat
            .DataPropertyName = DPN
            .DataSource = OverseeInfoBean.Tables(OptTableName)
            .HeaderText = HeadTxt
            .DisplayMember = ColName
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .ReadOnly = RW
        End With
        Return ColumnFormat
    End Function
    Private Sub ViewOverseeInfo(ByVal EntityBean As DataSet, ByVal TableName As String, ByVal ViewerFormat As ArrayList, ByVal InfoViewer As DataGridView)
        'Display information of table in EntityBean on InfoViewer according to ViewerFormat
        InfoViewer.AutoGenerateColumns = False
        InfoViewer.DataSource = EntityBean
        InfoViewer.Columns.Clear()
        For Each ColumnDispFormat As DataGridViewColumn In ViewerFormat
            InfoViewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {ColumnDispFormat})
        Next
        InfoViewer.DataMember = TableName
    End Sub
    Private Sub SplitOverseeInfo(ByVal opDataGrid As DataGridView, ByVal GridFormat As ArrayList, ByVal infoTableName As String, ByVal strFilter As String)
        OverseeInfoBean.Tables(infoTableName).DefaultView.RowFilter = strFilter
        With opDataGrid
            .AutoGenerateColumns = False
            .DataSource = OverseeInfoBean.Tables(infoTableName).DefaultView
            If OverseeInfoBean.Tables(infoTableName).Rows.Count() > 0 Then
                .Columns.Clear()
                For Each ColumnDispFormat As DataGridViewColumn In GridFormat
                    .Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {ColumnDispFormat})
                Next
            End If
            '.DataMember = TableName
        End With
    End Sub
    Private Sub GetOverseeInfoPackets()
        Dim strSql As String = "Select XMBH,BM,XH,JGMC,XKZBH,KHID,KHMC,KHLX,XMMC,YWLX,YWPZ,DKYTSUHY,CYYT,KSSJ,JSSJ,ZRJE,DBFJE,SXYHMC,YWPZFZ,ReportStatus from OverseeInfoGuaranteeProject"
        InfoTableName = "OverseeInfoGuaranteeProject"
        AppService.SaveEntityBean(strSql, OverseeInfoBean, InfoTableName)

        strSql = "Select XMBH,BM,XH,JGMC,XKZBH,KHID,KHMC,KHLX,XMMC,YWLX,YWPZ,DKYTSUHY,CYYT,Convert(varchar(10) , KSSJ, 120 ) As KSSJ,Convert(varchar(10) , JSSJ, 120 ) As JSSJ ,ZRJE,DBFJE,SXYHMC,YWPZFZ from OverseeInfoGuaranteeProject where ReportStatus='�ϱ�'"
        InfoTableName = "XMXX"
        Dim SqlType As CommandType = CommandType.Text
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
        SetXH(OverseeInfoBean, InfoTableName)

        strSql = "Select XMBH,BM,'VO' As VO,JGMC,XKZBH from OverseeInfoGuaranteeProject where ReportStatus='�˱�'"
        InfoTableName = "XMXXVO"
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
        'SetXH(OverseeInfoBean, InfoTableName)

        InfoTableName = "KHXX"
        OverseeInfoBean.Tables(InfoTableName).AcceptChanges()
        SetXH(OverseeInfoBean, InfoTableName)
    End Sub
    Private Sub SetXH(ByVal EntityBean As DataSet, ByVal TableName As String)
        Dim i As Integer = 0
        For Each dr As DataRow In EntityBean.Tables(TableName).Rows()
            i = i + 1
            If i <= 9 Then
                dr.Item("XH") = "0" + i.ToString
            Else
                dr.Item("XH") = i.ToString
            End If
        Next
    End Sub
    Private Sub LoanProjectsBeingAsReleaseProjects()
        Dim i, j, xh As Integer
        Dim dr As DataRow
        j = OverseeInfoBean.Tables("ZRJC").Rows.Count
        For i = 0 To OverseeInfoBean.Tables("XMXX").Rows.Count - 1
            dr = OverseeInfoBean.Tables("ZRJC").NewRow()
            dr.Item("XMBH") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("XMBH")
            dr.Item("BM") = "zerenjiechu"
            xh = j + i + 1
            If xh <= 9 Then
                dr.Item("XH") = "0" + xh.ToString
            Else
                dr.Item("XH") = xh.ToString
            End If
            dr.Item("JGMC") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("JGMC")
            dr.Item("XKZBH") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("XKZBH")
            dr.Item("JCRQ") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("JSSJ")
            dr.Item("JCJE") = 0
            dr.Item("FKJE") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("ZRJE")
            dr.Item("FKRQ") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("KSSJ")
            OverseeInfoBean.Tables("ZRJC").Rows.Add(dr)
        Next
    End Sub
    Private Sub UpdateOverseeLoanProject()
        Dim strSql As String = "OverSeeUpdateLoanProjectInfo"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        AppService.UpdateEntityBean(strSql, SqlType, Nothing)
    End Sub
    Private Sub UpdateOverseeCreditByBank()
        '������������Э��
        Dim i As Integer
        Dim SqlParamValueList As ArrayList = New ArrayList()
        Dim SqlCmd As SqlCommand = SetParamsFormatOfUpdateBank()

        For i = 0 To OverseeInfoBean.Tables("YHSX").Rows.Count() - 1
            SqlParamValueList.Clear()
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(0))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(2))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(3))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(4))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(5))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(6))
            AppService.UpdateRecordsBySP(SqlCmd, SqlParamValueList)
        Next
        AppService.CloseDBConnect()
        'OverseeInfoBean.AcceptChanges()
    End Sub
    Private Function SetParamsFormatOfUpdateBank() As SqlCommand
        '���ø�����������Э��SQL���Ĳ���
        Dim strSql As String = "UpdateCreditByBank"
        Dim strSqlType As CommandType = CommandType.StoredProcedure
        Dim SqlParameterList As ArrayList = New ArrayList()
        SqlParameterList.Add(New SqlParameter("@sBankName", SqlDbType.NVarChar, 50, "Bank_Name"))
        SqlParameterList.Add(New SqlParameter("@sCreditLine", SqlDbType.Int, 4, "CreditLine"))
        SqlParameterList.Add(New SqlParameter("@sCreditStartDate", SqlDbType.DateTime, 8, "CreditStartDate"))
        SqlParameterList.Add(New SqlParameter("@sCreditEndDate", SqlDbType.DateTime, 8, "CreditEndDate"))
        SqlParameterList.Add(New SqlParameter("@sBail", SqlDbType.Decimal, 9, "Bail"))
        SqlParameterList.Add(New SqlParameter("@sPoolingOfRisks", SqlDbType.Float, 8, "PoolingOfRisks"))
        Return AppService.BuildSqlCommentParam(strSql, strSqlType, SqlParameterList)
    End Function

    Private Function SetLoanProjectsFormat(ByVal OptTableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "��Ŀ����", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("KHMC", "��ҵ����", "KHMC", True))
        GridFormat.Add(SetTextColumnFormat("YWPZFZ", "ҵ��Ʒ��", "YWPZFZ", True))
        GridFormat.Add(SetTextColumnFormat("KSSJ", "�ſ�����", "KSSJ", False))
        GridFormat.Add(SetTextColumnFormat("JSSJ", "��������", "JSSJ", True))
        GridFormat.Add(SetTextColumnFormat("ZRJE", "�������", "ZRJE", True))
        GridFormat.Add(SetTextColumnFormat("DBFJE", "�����ѽ��", "DBFJE", True))
        GridFormat.Add(SetTextColumnFormat("SXYHMC", "�ſ�����", "SXYHMC", True))
        GridFormat.Add(SetComBoxColumnFormat(OptTableName, "ReportStatus", "�ϱ�״̬", "ReportStatus", False))
        Return GridFormat
    End Function
    Private Function SetLoanClientsFormat() As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "��Ŀ����", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("KHLX", "�ͻ�����", "KHLX", True))
        GridFormat.Add(SetTextColumnFormat("KHID", "�ͻ�����", "KHID", True))
        GridFormat.Add(SetTextColumnFormat("KHMC", "��ҵ����", "KHMC", True))
        GridFormat.Add(SetTextColumnFormat("ZZJGDM", "��֯��������", "ZZJGDM", True))
        GridFormat.Add(SetTextColumnFormat("HYLX", "��ҵ����", "HYLX", True))
        GridFormat.Add(SetTextColumnFormat("DKKH", "�����", "DKKH", True))
        GridFormat.Add(SetTextColumnFormat("ZYYW", "��Ӫҵ��", "ZYYW", True))
        GridFormat.Add(SetTextColumnFormat("CYRS", "��ҵ����", "CYRS", True))
        GridFormat.Add(SetTextColumnFormat("ZCZE", "�ʲ��ܶ�", "ZCZE", True))
        GridFormat.Add(SetTextColumnFormat("FZZE", "��ծ�ܶ�", "FZZE", True))
        GridFormat.Add(SetTextColumnFormat("JLR", "������", "JLR", True))
        GridFormat.Add(SetTextColumnFormat("YHJKZE", "���н���ܶ�", "YHJKZE", True))
        GridFormat.Add(SetTextColumnFormat("XM", "����", "XM", True))
        GridFormat.Add(SetTextColumnFormat("SFZH", "���֤��", "SFZH", False))
        Return GridFormat
    End Function
    Private Function SetReleaseProjectsFormat() As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "��Ŀ����", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("JGMC", "��������", "JGMC", True))
        GridFormat.Add(SetTextColumnFormat("XKZBH", "�������֤���", "XKZBH", False))
        GridFormat.Add(SetTextColumnFormat("JCRQ", "�������", "JCRQ", False))
        GridFormat.Add(SetTextColumnFormat("JCJE", "������", "JCJE", False))
        GridFormat.Add(SetTextColumnFormat("FKJE", "�ſ���", "FKJE", False))
        GridFormat.Add(SetTextColumnFormat("FKRQ", "�ſ�����", "FKRQ", False))
        Return GridFormat
    End Function
    Private Function SetCompensateProjectsFormat(ByVal OptTableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "��Ŀ����", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("JGMC", "��������", "JGMC", True))
        GridFormat.Add(SetTextColumnFormat("XKZBH", "�������֤���", "XKZBH", False))
        GridFormat.Add(SetTextColumnFormat("DCJE", "�������", "DCJE", False))
        GridFormat.Add(SetTextColumnFormat("YZHDCJE", "��׷�ش������", "YZHDCJE", False))
        GridFormat.Add(SetTextColumnFormat("WZHDCJE", "δ׷�ش������", "WZHDCJE", False))
        GridFormat.Add(SetTextColumnFormat("HKDZRQ", "���������", "HKDZRQ", False))
        GridFormat.Add(SetTextColumnFormat("HKJE", "������", "HKJE", False))
        GridFormat.Add(SetTextColumnFormat("HKFS", "���ʽ", "HKFS", False))
        GridFormat.Add(SetTextColumnFormat("HXRQ", "��������", "HXRQ", False))
        GridFormat.Add(SetComBoxColumnFormat(OptTableName, "ReportStatus", "�ϱ�״̬", "ReportStatus", False))
        Return GridFormat
    End Function
    Private Function SetSubrogationProjectsFormat(ByVal OptTableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "��Ŀ����", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("JGMC", "��������", "JGMC", True))
        GridFormat.Add(SetTextColumnFormat("XKZBH", "�������֤���", "XKZBH", False))
        GridFormat.Add(SetTextColumnFormat("DZRQ", "��������", "DZRQ", False))
        GridFormat.Add(SetTextColumnFormat("WHSSJE", "�����ʧ���", "WHSSJE", False))
        GridFormat.Add(SetTextColumnFormat("WHSSFS", "�����ʧ��ʽ", "WHSSFS", False))
        GridFormat.Add(SetComBoxColumnFormat(OptTableName, "ReportStatus", "�ϱ�״̬", "ReportStatus", False))
        Return GridFormat
    End Function
    Private Function SetCreditByBankFormat() As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("JRJGMC", "���ڻ�������", "JRJGMC", True))
        GridFormat.Add(SetTextColumnFormat("SXED", "���Ŷ��", "SXED", False))
        GridFormat.Add(SetTextColumnFormat("SXKSRQ", "���ſ�ʼ����", "SXKSRQ", False))
        GridFormat.Add(SetTextColumnFormat("SXJSRQ", "���Ž�������", "SXJSRQ", False))
        GridFormat.Add(SetTextColumnFormat("BZJ", "��֤��", "BZJ", False))
        GridFormat.Add(SetTextColumnFormat("FXFD", "���շֵ�", "FXFD", False))
        GridFormat.Add(SetTextColumnFormat("JGMC", "��������", "JGMC", False))
        GridFormat.Add(SetTextColumnFormat("JGXKZBH", "�������֤���", "JGXKZBH", False))
        Return GridFormat
    End Function
    Private Sub SaveToXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToXml.Click
        Dim FileDate As DateTime = System.DateTime.Now.Date
        Dim strPathName As String = "d:\lhcis\datacenter\data\" & FileDate.Year.ToString & FileDate.Month.ToString & FileDate.Day.ToString
        Dim strFileName As String = strPathName & "\8800256_buttJoint.xml"
        Dim OverseeFilePath As Directory
        If Not OverseeFilePath.Exists(strPathName) Then
            OverseeFilePath.CreateDirectory(strPathName)
        End If
        Dim XmlDoc As XmlTextWriter = New XmlTextWriter(strFileName, System.Text.Encoding.UTF8)
        XmlDoc.Formatting = Formatting.Indented
        XmlDoc.WriteStartDocument()

        XmlDoc.WriteStartElement("YWSJ")
        XmlDoc.WriteAttributeString("xsi:noNamespaceSchemaLocation", "yewu_date.xsd")
        XmlDoc.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
        Try
            GetOverseeInfoPackets()
            LoanProjectsBeingAsReleaseProjects()

            OverseeInfoBean.DataSetName = "XMXX_INFO"
            OverseeInfoBean.Tables("XMXX").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "XMXXVO_INFO"
            OverseeInfoBean.Tables("XMXXVO").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "KHXX_INFO"
            OverseeInfoBean.Tables("KHXX").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "ZRJC_INFO"
            OverseeInfoBean.Tables("ZRJC").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "DCHK_INFO"
            OverseeInfoBean.Tables("DCHK").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "ZHSS_INFO"
            OverseeInfoBean.Tables("ZHSS").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "YHSX_INFO"
            OverseeInfoBean.Tables("YHSX").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            XmlDoc.WriteEndElement() 'End Root Element YWSJ
            XmlDoc.Close()
            SaveToXml.Enabled = False
            NothingToDo = False
        Catch ex As Exception
            MessageBox.Show("�����������δѡȫ���޷������ϱ����ݰ���Ӧ����ֹ��", "������ʾ")
            Me.Close()
        End Try
    End Sub
End Class