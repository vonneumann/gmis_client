Module MdlMain
    'Private moSplash As SWDialogBox.SplashBox
    Private _system As String = "v2.0.1"

    Friend Sub LoginedProcess(ByVal sender As Object, ByVal e As SWDialogBox.LoginedEventArgs)
        'If Not moSplash Is Nothing Then
        '    moSplash.Show("", "", "")
        '    'moSplash.Refresh("ϵͳ���ڵ�¼�����Ժ�...", Color.DarkBlue)
        'End If

        sender = CType(sender, SWDialogBox.LoginBox)

        If wsPermission Is Nothing Then
            wsPermission = New htfServerPermission.Permission()
        End If

        If _authentication Is Nothing Then
            _authentication = New htfServerPermission.AuthenticationHeader()
        End If

        _authentication.UserName = sender.UserName
        _authentication.Password = sender.Password
        _authentication.System = _system

        wsPermission.AuthenticationHeaderValue = _authentication


        Try
            '��ȡȨ�޿��Ƶ�Webservice
            'wsPermission.Url = "http://" & sender.Server & "/SWPermission/Permission.asmx"
            wsPermission.Url = "http://" & sender.Server & "/WebService_CGMIS/Permission.asmx"
            If sender.Timeout <> 0 Then
                wsPermission.Timeout = sender.Timeout * 1000
            End If

            '��֤�û�Ȩ��
            If wsPermission.Login(sender.UserName, sender.Password) Then
                UserName = sender.UserName
                strPasswd = sender.Password
                strServer = sender.Server
                iTimeOut = sender.Timeout

                'д����
                Try
                    SWConsole.Configuration.SetAppValue("LoginBox.UserName", sender.UserName, True)
                    SWConsole.Configuration.SetAppValue("LoginBox.Server", sender.Server, True)
                Catch
                End Try

                '��ȡҵ��Webservice����
                strUrl = "http://" & sender.Server & "/WebService_CGMIS/Service1.asmx"
                If gWs Is Nothing Then
                    gWs = New htfServer.Service1()
                End If
                gWs.Url = strUrl
                If sender.Timeout <> 0 Then
                    gWs.Timeout = sender.Timeout * 1000
                End If

                '2008-08-11 yjf add ��ȡ������Կ
                encryptionKey = gWs.GetCommonQueryInfo("select top 1 encryption_key from encryption_key").Tables(0).Rows(0).Item("encryption_key")

                e.Result = SWDialogBox.LoginResult.Success
            End If
        Catch ex As System.Web.Services.Protocols.SoapException
            e.Result = SWDialogBox.LoginResult.Unknown

            Select Case ex.Actor
                Case "InvalidAccountException"
                    MessageBox.Show("��Ч��ϵͳ�ʻ���", "ϵͳ�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.InvalidUserName
                Case "InvalidPasswordException"
                    MessageBox.Show("��Ч���û����", "ϵͳ�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.InvalidPassword
                Case "InvalidLoginException"
                    MessageBox.Show("��δ��ȷ��¼ϵͳ�����ȵ�¼��", "ϵͳ�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.Unknown
                Case "InvalidPermissionException"
                    MessageBox.Show("��Ч�Ĳ���Ȩ�ޣ�", "ϵͳ�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.InvalidPermission
                Case Else
                    MessageBox.Show("ϵͳ�쳣��" + Environment.NewLine + "�������(Web Service)����δ֪���쳣���뼴ʱ������ϵͳ����Ա��ϵ����������Ϣ��" + Environment.NewLine + Environment.NewLine + ex.Message, "��������쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Result = SWDialogBox.LoginResult.Unknown
            End Select
        Catch ex As Exception
            MsgBox("���������Ӵ���,�����µ�¼����ϵͳ����Ա��ϵ!" & "(" & ex.Message & ")", MsgBoxStyle.Critical, "����")
            e.Result = SWDialogBox.LoginResult.Unknown
        End Try
    End Sub

    Sub Main()
        Try
            Try
                strRootPath = System.IO.Directory.GetCurrentDirectory  '��ȡ��ǰĿ¼
                'moSplash = New SWDialogBox.SplashBox()

                'If System.IO.File.Exists(strRootPath & "\image\Splash.gif") Then
                '    moSplash.BackgroundImage = System.Drawing.Image.FromFile(strRootPath & "\image\Splash.gif")
                'End If
                'moSplash.Show("", "", "")
                'System.Threading.Thread.CurrentThread.Sleep(2000)
            Catch ex As System.Exception
                'MessageBox.Show(ex.Message, ex.Source)
            End Try
            Dim frmLogin As New SWDialogBox.LoginBox()
            'Dim iCounter As Int16

            'wsPermission = New htfServerPermission.Permission()
            '_authentication = New htfServerPermission.AuthenticationHeader()
            'wsPermission.AuthenticationHeaderValue = _authentication

            AddHandler frmLogin.Logined, AddressOf LoginedProcess

            Try
                '��ȡ����
                frmLogin.UserName = SWConsole.Configuration.GetAppValue("LoginBox.UserName")
                frmLogin.Server = SWConsole.Configuration.GetAppValue("LoginBox.Server")
                Try
                    frmLogin.Timeout = Int32.Parse(SWConsole.Configuration.GetAppValue("LoginBox.Timeout"))
                Catch
                End Try
            Catch
            End Try

            'moSplash.Close()

            If frmLogin.Login() Then
                '��������
                Dim frmMain As New FConsole     ' frmMainInterface()
                'Dim frmMain As New frmMainInterface     ' frmMainInterface()
                'setFormMenu(frmMain)

                'moSplash.Close()
                'moSplash.Dispose()
                'moSplash = Nothing
                Application.Run(frmMain)
            Else
                Return
            End If
        Finally
            'If Not moSplash Is Nothing Then
            '    moSplash.Dispose()
            '    moSplash = Nothing
            'End If
        End Try
    End Sub

    Friend Sub setFormMenu(ByVal frmMain As MainInterface.frmMainInterface)
        frmMain.mnuBaseGeneral.Enabled = False
        frmMain.MnItemOrganize.Enabled = False
        frmMain.MnItemCreditAppraise.Enabled = False
        frmMain.MnItemBranch.Enabled = False
        frmMain.MnItemRole.Enabled = False
        frmMain.MnItemTeam.Enabled = False
        frmMain.MnItemStaff.Enabled = False
        frmMain.MnItemStaffRole.Enabled = False
        frmMain.MnItemRight.Enabled = False
        frmMain.MnItemProPause.Enabled = False
        frmMain.MnItemProCancel.Enabled = False
        frmMain.MnItemProConsign.Enabled = False
        frmMain.MnItemProCancelCon.Enabled = False
        frmMain.MnItemProManual.Enabled = False
        frmMain.MnItemProAssign.Enabled = False
        frmMain.mnuProjectDelete.Enabled = False
        frmMain.MnItemMeetQuery.Enabled = False
        frmMain.MnItemMeetSet.Enabled = False
        frmMain.ToolBarBttnConsult.Enabled = False
        frmMain.MnItemConsult.Enabled = False
        frmMain.ToolBarBttnApply.Enabled = False
        frmMain.MnItemAccept.Enabled = False
        frmMain.mnuCreditProject.Enabled = False
        frmMain.mnuFinancialAnalysis.Enabled = False
        frmMain.mnuWorkFlowHoliday.Enabled = False
        frmMain.mnuWorkFlowTask.Enabled = False
        frmMain.mnuWorkLogEnter.Enabled = False
        frmMain.mnuWorkLogQuery.Enabled = False
        frmMain.mnuWorkLogStatistics.Enabled = False
        frmMain.MnItemDocQry.Enabled = False
        frmMain.MenuItem69.Enabled = False
        frmMain.mnuCompanyFileManage.Enabled = False
        frmMain.btnCredit.Enabled = False
        frmMain.mnuUpdateMeetRecord.Enabled = False
        frmMain.mnuChargeFee.Enabled = False
        frmMain.MnItemRemeet.Enabled = False
        frmMain.mnuItemClaim.Enabled = False
        frmMain.mnuItemUpdateGuarantee.Enabled = False
        frmMain.mnuItemEvaluate.Enabled = False
        frmMain.mnuItemFirReviewCancel.Enabled = False
        frmMain.mneItemUpdateProcess.Enabled = False


        '��ѯ
        frmMain.MenuItem19.Enabled = False   '��Ŀ��ѯ
        frmMain.MenuItem20.Enabled = False   '��ѯ��ҵ��ѯ
        'frmMain.MenuItem21.Enabled = False		 '������ҵ��ѯ
        frmMain.MenuItem28.Enabled = False   '������Ŀ��ѯ
        'frmMain.MenuItem27.Enabled = False		 '��ʽ������ҵ��ѯ
        'frmMain.MenuItem23.Enabled = False		 '�����ϻ���Ŀһ����
        frmMain.MenuItem24.Enabled = False   '������Ŀһ����
        frmMain.MenuItem67.Enabled = False   '������Ŀһ����
        frmMain.MenuItem29.Enabled = False   '�ݻ���Ŀ��ѯ
        frmMain.MenuItem13.Enabled = False   '������Ŀһ����
        'frmMain.MenuItem43.Enabled = False   '�ڱ���Ŀһ����
        frmMain.MenuItem49.Enabled = False   '��ֹ��Ŀһ����
        frmMain.MenuItem15.Enabled = False   '���������ѯ
        frmMain.MenuItem32.Enabled = False  '��Ŀ���۲�ѯ
        frmMain.mnuQueryFirstTrialProject.Enabled = False  '������Ŀһ����
        frmMain.mnuQueryAcceptProject.Enabled = False   '��ʽ������Ŀһ����
        frmMain.mnuQueryAllocateProject.Enabled = False    '��Ŀ����һ����
        frmMain.mnuQueryPresentingProject.Enabled = False    '�ύ�����������Ŀһ����
        frmMain.mnuQuerySignProject.Enabled = False    'ǩԼ��Ŀһ����
        frmMain.mnuQueryLoanProject.Enabled = False    '�ſ���Ŀһ����
        frmMain.mnuQueryCreditProject.Enabled = False    '�ڱ���Ŀһ����
        frmMain.mnuQueryRequiteProject.Enabled = False    '������Ŀһ����
        frmMain.mnuQueryRecantProject.Enabled = False    '������Ŀһ����
        frmMain.mnuQueryProcessingProject.Enabled = False    '����Ŀ�������ڽ�����Ŀһ����
        frmMain.mnuQueryRegionProject.Enabled = False    '��������Ŀ����һ����
        frmMain.mnuQueryChargeStatistics.Enabled = False    '�շ�ͳ��
        frmMain.MnItemQrySignaturePlan.Enabled = False 'ǩԼ���Ų�ѯ
        frmMain.MnItemUnSignProject.Enabled = False 'δǩԼ��Ŀ��ѯ
        frmMain.MnItemQueryGuaranteeForm.Enabled = False '��������ʩ��ѯ
        frmMain.mnuGuaranteeProject.Enabled = False '������Ŀ��ѯ
        frmMain.mnuUnDealProject.Enabled = False 'δ������Ŀ��ѯ
        frmMain.mnuAfterGuaranteeRecord.Enabled = False '������һ����
        frmMain.mnuItemProjectRequite.Enabled = False '��Ŀ���������ѯ
        frmMain.mnuItemIntentLetter.Enabled = False '���������鷢��һ����

        'ͳ��
        frmMain.MenuItem35.Enabled = False    '����ҵ��ͳ��
        'frmMain.MenuItem41.Enabled = False		  '����ҵ���������ͳ��
        'frmMain.MenuItem45.Enabled = False		  '����ҵ����ҵͳ��
        frmMain.MenuItem46.Enabled = False    '����ҵ������ͳ��
        'frmMain.MenuItem48.Enabled = False		  '����ҵ��ҵ��Ʒ��ͳ��
        frmMain.mnuQueryStatisticsMarketingA.Enabled = False    '��Ӫ���ͳ�ƣ�һ��
        frmMain.mnuQueryStatisticsMarketingB.Enabled = False    '��Ӫ���ͳ�ƣ�����
        frmMain.mnuQueryStatisticsMarketingC.Enabled = False    '��Ӫ���ͳ�ƣ�����
        frmMain.mnuQueryStatisticsCompensation.Enabled = False    '�������ͳ��
        frmMain.MnItemStatisticsFee.Enabled = False '�շ����ͳ��
        'frmMain.mnuQueryStatisticsGECraft.Enabled = False		  '������ҵ����״��ͳ��
        'frmMain.mnuQueryStatisticsGEProprietorship.Enabled = False	   '������ҵ����������ͳ��
        frmMain.MnItemStaticsFirstLoan.Enabled = False '�״δ�����ҵ���ͳ��
        frmMain.mnuQueryStatisticsRegion.Enabled = False    '���������ͳ��
        frmMain.mnuQueryStatisticsCounterguarantee.Enabled = False  '���������ͳ��
        frmMain.mnuQueryStatisticsPMService.Enabled = False    '��Ŀ����ҵ�����ͳ��
        frmMain.MnItemStatisticsRecommendproject.Enabled = False '����Ա���Ƽ���Ŀͳ��
        frmMain.muiQueryGuarantingCorporation.Enabled = False
        frmMain.muiConferenceRoom.Enabled = False
        frmMain.mnuFinancialAnalysis.Enabled = False '�������
        frmMain.muiUpdateIntentLetter.Enabled = False
        frmMain.MenuCreditManager.Enabled = False
        frmMain.MenuDefectRecord.Enabled = False
        frmMain.MenuDefectRecordEdit.Enabled = False
        frmMain.MenuDefectRecordAdd.Enabled = False
        frmMain.MenuContractManage.Enabled = False
        frmMain.MenuProjectExp.Enabled = False
        frmMain.MenuQueryProjectExpandDate.Enabled = False
        frmMain.MenuReviewGuarantee.Enabled = False
        frmMain.mnuBackFee.Enabled = False


        Dim mitem As MenuItem '������־����
        For Each mitem In frmMain.mnitemWorkLog.MenuItems
            mitem.Enabled = False
        Next

        Dim dsRights As New DataSet()
        dsRights = wsPermission.FetchPermission(UserName)
        Dim i As Integer
        For i = 0 To dsRights.Tables(0).Rows.Count - 1
            Select Case dsRights.Tables(0).Rows(i).Item("Formid")
                Case 1
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemBranch.Enabled = True
                Case 2
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemRole.Enabled = True
                Case 3
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemTeam.Enabled = True
                Case 4
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemStaff.Enabled = True
                Case 5
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemStaffRole.Enabled = True
                Case 7
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.MnItemRight.Enabled = True
                Case 8
                    frmMain.MnItemOrganize.Enabled = True
                    frmMain.mnuBaseGeneral.Enabled = True
                Case 9
                    frmMain.MnItemCreditAppraise.Enabled = True
                Case 10
                    frmMain.mnuBaseGeneral.Enabled = True
                Case 11 'ҵ������ͬ��
                    frmMain.mneItemUpdateProcess.Enabled = True

                    '����������
                Case 20
                    frmMain.MnItemProPause.Enabled = True
                Case 21
                    frmMain.MnItemProCancel.Enabled = True
                Case 22
                    frmMain.MnItemProConsign.Enabled = True
                Case 23
                    frmMain.MnItemProCancelCon.Enabled = True
                Case 24
                    frmMain.MnItemProManual.Enabled = True
                Case 25
                    frmMain.MnItemProAssign.Enabled = True
                Case 26
                    frmMain.mnuProjectDelete.Enabled = True
                Case 27
                    frmMain.mnuWorkFlowHoliday.Enabled = True
                Case 28
                    frmMain.mnuWorkFlowTask.Enabled = True
                Case 29
                    frmMain.MnItemRemeet.Enabled = True

                Case 30
                    frmMain.MnItemMeetQuery.Enabled = True
                Case 31
                    frmMain.MnItemMeetSet.Enabled = True
                Case 32
                    frmMain.MnItemQrySignaturePlan.Enabled = True
                Case 33
                    frmMain.mnuUpdateMeetRecord.Enabled = True
                Case 34
                    frmMain.mnuItemClaim.Enabled = True
                Case 35
                    frmMain.mnuItemUpdateGuarantee.Enabled = True

                Case 40
                    frmMain.ToolBarBttnConsult.Enabled = True
                    frmMain.MnItemConsult.Enabled = True
                Case 41
                    frmMain.ToolBarBttnApply.Enabled = True
                    frmMain.MnItemAccept.Enabled = True
                Case 42
                    frmMain.mnuCreditProject.Enabled = True
                    frmMain.btnCredit.Enabled = True
                Case 43
                    frmMain.mnuChargeFee.Enabled = True
                Case 44 'Ա����λ����
                    For Each mitem In frmMain.mnitemWorkLog.MenuItems
                        mitem.Enabled = True
                    Next
                Case 51
                    frmMain.mnuWorkLogEnter.Enabled = True
                Case 52
                    frmMain.mnuWorkLogQuery.Enabled = True
                Case 53
                    frmMain.mnuWorkLogStatistics.Enabled = True
                Case 61
                    frmMain.MnItemDocQry.Enabled = True
                Case 62
                    frmMain.MenuItem69.Enabled = True
                Case 63
                    frmMain.mnuCompanyFileManage.Enabled = True

                Case 71      '��Ŀ��ѯ
                    frmMain.MenuItem19.Enabled = True      '��Ŀ��ѯ
                Case 72      '���������ѯ
                    frmMain.MenuItem15.Enabled = True      '���������ѯ
                Case 80      '��ѯ��ҵ��ѯ
                    frmMain.MenuItem20.Enabled = True      '��ѯ��ҵ��ѯ
                Case 81      '������Ŀ��ѯ
                    frmMain.MenuItem28.Enabled = True      '������Ŀ��ѯ
                Case 82      '������Ŀһ����
                    frmMain.MenuItem24.Enabled = True      '������Ŀһ����
                Case 83      '������Ŀһ����
                    frmMain.MenuItem67.Enabled = True      '������Ŀһ����
                Case 84      '�ݻ���Ŀ��ѯ
                    frmMain.MenuItem29.Enabled = True      '�ݻ���Ŀ��ѯ
                Case 85      '������Ŀһ����
                    frmMain.MenuItem13.Enabled = True      '������Ŀһ����
                Case 86      '��ֹ��Ŀһ����
                    frmMain.MenuItem49.Enabled = True      '��ֹ��Ŀһ����
                Case 87      '������Ŀһ����
                    frmMain.mnuQueryFirstTrialProject.Enabled = True     '������Ŀһ����
                Case 88      '��ʽ������Ŀһ����
                    frmMain.mnuQueryAcceptProject.Enabled = True      '��ʽ������Ŀһ����
                Case 89      '��Ŀ����һ����
                    frmMain.mnuQueryAllocateProject.Enabled = True       '��Ŀ����һ����
                Case 90      '�ύ�����������Ŀһ����
                    frmMain.mnuQueryPresentingProject.Enabled = True       '�ύ�����������Ŀһ����
                Case 91      'ǩԼ��Ŀһ����
                    frmMain.mnuQuerySignProject.Enabled = True       'ǩԼ��Ŀһ����
                Case 92      '�ſ���Ŀһ����
                    frmMain.mnuQueryLoanProject.Enabled = True       '�ſ���Ŀһ����
                Case 93      '�ڱ���Ŀһ����
                    frmMain.mnuQueryCreditProject.Enabled = True       '�ڱ���Ŀһ����
                Case 94      '������Ŀһ����
                    frmMain.mnuQueryRequiteProject.Enabled = True       '������Ŀһ����
                Case 95      '������Ŀһ����
                    frmMain.mnuQueryRecantProject.Enabled = True       '������Ŀһ����
                Case 96      '����Ŀ�������ڽ�����Ŀһ����
                    frmMain.mnuQueryProcessingProject.Enabled = True       '����Ŀ�������ڽ�����Ŀһ����
                Case 97      '��������Ŀ����һ����
                    frmMain.mnuQueryRegionProject.Enabled = True       '��������Ŀ����һ����
                Case 98      '�շѲ�ѯ
                    frmMain.mnuQueryChargeStatistics.Enabled = True       '�շѲ�ѯ
                Case 99      'δǩԼ��Ŀһ����
                    frmMain.MnItemUnSignProject.Enabled = True
                Case 100      '��������ʩ��ѯ
                    frmMain.MnItemQueryGuaranteeForm.Enabled = True
                Case 101
                    frmMain.MenuItem32.Enabled = True
                Case 102        '������Ŀ��ѯ
                    frmMain.mnuGuaranteeProject.Enabled = True
                Case 103        'δ������Ŀ��ѯ
                    frmMain.mnuUnDealProject.Enabled = True
                Case 104
                    frmMain.mnuAfterGuaranteeRecord.Enabled = True
                Case 105        '��Ŀ���������ѯ
                    frmMain.mnuItemProjectRequite.Enabled = True
                Case 106        '���������鷢��һ����
                    frmMain.mnuItemIntentLetter.Enabled = True
                Case 107        '�ʲ�����һ���� 
                    frmMain.mnuItemEvaluate.Enabled = True

                Case 121      '����ҵ��ͳ��
                    frmMain.MenuItem35.Enabled = True       '����ҵ��ͳ��
                    'Case 122      '����ҵ���������ͳ��
                    '    frmMain.MenuItem41.Enabled = True       '����ҵ���������ͳ��
                    'Case 123      '����ҵ����ҵͳ��
                    '    frmMain.MenuItem45.Enabled = True       '����ҵ����ҵͳ��
                Case 124      '����ҵ�����ͳ��
                    frmMain.MenuItem46.Enabled = True       '����ҵ�����ͳ��
                    'Case 125      '����ҵ��ҵ��Ʒ��ͳ��
                    'frmMain.MenuItem48.Enabled = True       '����ҵ��ҵ��Ʒ��ͳ��
                Case 126      '��Ӫ���ͳ�ƣ�һ��
                    frmMain.mnuQueryStatisticsMarketingA.Enabled = True       '��Ӫ���ͳ�ƣ�һ��
                Case 127      '��Ӫ���ͳ�ƣ�����
                    frmMain.mnuQueryStatisticsMarketingB.Enabled = True       '��Ӫ���ͳ�ƣ�����
                Case 128      '��Ӫ���ͳ�ƣ�����
                    frmMain.mnuQueryStatisticsMarketingC.Enabled = True       '��Ӫ���ͳ�ƣ�����
                Case 129      '�������ͳ��
                    frmMain.mnuQueryStatisticsCompensation.Enabled = True       '�������ͳ��
                Case 130      '����Ա���Ƽ���Ŀͳ��
                    frmMain.MnItemStatisticsRecommendproject.Enabled = True
                Case 131      '�״δ�����ҵͳ��
                    frmMain.MnItemStaticsFirstLoan.Enabled = True
                Case 132      '���������ͳ��
                    frmMain.mnuQueryStatisticsRegion.Enabled = True       '���������ͳ��
                Case 133      '���������ͳ��
                    frmMain.mnuQueryStatisticsCounterguarantee.Enabled = True     '���������ͳ��
                Case 134      '��Ŀ����ҵ�����ͳ��
                    frmMain.mnuQueryStatisticsPMService.Enabled = True       '��Ŀ����ҵ�����ͳ��
                Case 135      '�շ����ͳ��
                    frmMain.MnItemStatisticsFee.Enabled = True       '�շ����ͳ��

                Case 140 '�����ݻ�
                    frmMain.mnuItemFirReviewCancel.Enabled = True
                Case 141
                    frmMain.muiQueryGuarantingCorporation.Enabled = True
                Case 142
                    frmMain.muiConferenceRoom.Enabled = True
                Case 143
                    frmMain.mnuFinancialAnalysis.Enabled = True
                Case 144
                    frmMain.muiUpdateIntentLetter.Enabled = True
                Case 145
                    frmMain.MenuCreditManager.Enabled = True
                Case 146
                    frmMain.MenuDefectRecord.Enabled = True
                Case 147
                    frmMain.MenuDefectRecordAdd.Enabled = True
                Case 148
                    frmMain.MenuDefectRecordEdit.Enabled = True
                Case 149
                    frmMain.MenuContractManage.Enabled = True
                Case 150
                    frmMain.MenuProjectExp.Enabled = True
                Case 151
                    frmMain.MenuQueryProjectExpandDate.Enabled = True
                Case 152
                    frmMain.MenuReviewGuarantee.Enabled = True
                Case 155
                    frmMain.mnuBackFee.Enabled = True
            End Select
        Next

        If wsPermission.IsFixed(UserName, htfServerPermission.FixedRoleEnum.Administrators, 0) Or _
           wsPermission.IsFixed(UserName, htfServerPermission.FixedRoleEnum.Security, 0) Then
            frmMain.MnItemRight.Enabled = True
        Else
            frmMain.MnItemRight.Enabled = False
        End If

        frmMain.StatusBarPanel3.Text = "����Ա��" & UserName
        frmMain.StatusBarPanel4.Text = " ���ڣ� " & gWs.GetSysTime.Date
    End Sub
End Module
