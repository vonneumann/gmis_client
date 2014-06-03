'Imports Excel.WorkbookClass
'Imports Excel.ApplicationClass


Public Class frmImportDataToExcel
    Inherits MainInterface.frmBasic

    Private strProjectCode As String
    Private strCorporationName As String
    Private strCorporationCode As String
    Private strItemType As String = "45" '��ʾ�ĵ�����
    Private strPerson As String
    Private strDir As String = "\Document\Excel\"
    Private strPhase As String

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub
    'new()
    'by quexd 2003-4-28
    Public Sub New(ByVal projectCode As String, ByVal corporationName As String)
        Me.New()
        Me.strProjectCode = projectCode
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
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents cmbTable As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmImportDataToExcel))
        Me.btnImport = New System.Windows.Forms.Button()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.btnExit.Location = New System.Drawing.Point(267, 128)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Visible = True
        '
        'btnImport
        '
        Me.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Bitmap)
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.ImageIndex = 16
        Me.btnImport.ImageList = Me.ImageListBasic
        Me.btnImport.Location = New System.Drawing.Point(171, 128)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(77, 24)
        Me.btnImport.TabIndex = 1
        Me.btnImport.Text = "�� ��(&I)"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTable
        '
        Me.cmbTable.Items.AddRange(New Object() {"���б�", "��Ȩ�ṹ", "��Ӫ���", "�����м���Ҫ���������", "�����¼", "���ⵣ����¼", "���ϼ�¼", "��˰��¼", "�жһ�Ʊ", "��������", "�������", "�ֽ���������", "�ʲ���ծ��", "�����", "�ֽ�����", "�ֽ�������"})
        Me.cmbTable.Location = New System.Drawing.Point(280, 40)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(224, 20)
        Me.cmbTable.TabIndex = 15
        Me.cmbTable.Text = "���б�"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(208, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "�����ɵı�"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbType
        '
        Me.cmbType.Location = New System.Drawing.Point(64, 40)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 20)
        Me.cmbType.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "��    ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(280, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(224, 21)
        Me.txtName.TabIndex = 11
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(208, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "��ҵ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(120, 21)
        Me.txtCode.TabIndex = 9
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "��Ŀ����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmImportDataToExcel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 159)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbTable, Me.Label4, Me.cmbType, Me.Label3, Me.txtName, Me.Label2, Me.txtCode, Me.Label1, Me.btnExit, Me.btnImport})
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportDataToExcel"
        Me.Text = "�����ݿ⵼�����ݵ�Excel"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmImportDataToExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName
        Me.txtCode_Leave(sender, e)
        getPhaseType()
        'getFilesType(strItemType)
    End Sub
    '��ý׶�����
    Private Sub getPhaseType()
        If Not gWs Is Nothing Then
            Me.cmbType.DataSource = gWs.GetPhase("%").Tables(0)
            Me.cmbTable.ValueMember = "phase_name"
            Me.cmbType.DisplayMember = "phase_name"
        End If
    End Sub
    '
    '�õ��ļ����ͣ�ͨ��Itemtype
    '
    Private Sub getFilesType(ByVal strItemType As String)
        Dim ds As DataSet
        Dim i As Integer
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetItem("{item_type='" & strItemType & "'}", Nothing)
                i = ds.Tables("TItem").Rows.Count
                cmbType.Items.Clear()
                If i > 0 Then
                    For i = 0 To i - 1
                        With ds.Tables("TItem").Rows(i)
                            cmbType.Items.Add(.Item("item_name"))
                        End With
                    Next
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            Try
                cmbType.SelectedIndex = 0
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '�˳�
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '����
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        strProjectCode = Me.txtCode.Text
        Dim strFileName As String
        Dim table As String
        strFileName = Me.txtName.Text & "��" & Me.txtCode.Text & "��" & Me.cmbTable.Text
        strPhase = Me.cmbType.Text
        table = Me.cmbTable.Text
        importExcel(strProjectCode, getLegalFileName(strFileName), strPhase, table, "")
    End Sub
    '
    '�������ݵ�Excel
    '
    Public Sub importExcel(ByVal projectCode As String, ByVal strFileName As String, ByVal phase As String, ByVal table As String, ByVal strOppCorporatinCode As String)
        If Not gWs Is Nothing Then
            Dim ds As DataSet
            Dim i As Integer
            strProjectCode = projectCode
            strPhase = phase
            Dim itemType, itemCode As String '�ĵ��еı�����ݵ�����
            itemType = "47"
            itemCode = "001"
            If strFileName = "" Then
                'MsgBox("��ѡ�д������ĵ�!", MsgBoxStyle.Exclamation, "��ʾ")
                SWDialogBox.MessageBox.Show("$1001", "�ĵ�����")
                Me.cmbTable.Focus()
                Exit Sub
            End If

            If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
            Else
                delAllFiles(Application.StartupPath & strDir)
            End If
            Dim excel1 As Excel.ApplicationClass
            Try
                ds = gWs.GetFileTemplateByCondition("{item_type='" & itemType & "' and item_code ='" & itemCode & "' and is_current_ver='1'}")
                i = ds.Tables("TFileTemplate").Rows.Count
                If i > 0 Then
                    With ds.Tables("TFileTemplate").Rows(0)
                        If Not .Item("template") Is System.DBNull.Value Then
                            Me.Cursor = Cursors.WaitCursor
                            Dim data As Byte() = .Item("template")
                            Dim myfilestream As System.IO.FileStream
                            myfilestream = New System.IO.FileStream(Application.StartupPath & strDir & strFileName & ".xls", IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                            myfilestream.Write(data, 0, data.Length)
                            myfilestream.Close()
                            '��Excel�ĵ�
                            excel1 = New Excel.ApplicationClass()
                            'excel1.Application.Workbooks.Open(Application.StartupPath & strDir & strFileName & ".xls")
                            excel1.Application.Workbooks.Add(Application.StartupPath & strDir & strFileName & ".xls")
                            importTable(excel1, projectCode, table, strOppCorporatinCode)
                            excel1.Application.Visible = True
                            Me.Cursor = Cursors.Default
                        Else
                            'MsgBox("��" & strFileName & "����Excelģ���ļ�������!", MsgBoxStyle.Exclamation, "��ʾ")
                            SWDialogBox.MessageBox.Show("$2002", strFileName)
                        End If
                    End With
                Else
                    'MsgBox("��" & strFileName & "����Excelģ���ļ�������!", MsgBoxStyle.Exclamation, "��ʾ")
                    SWDialogBox.MessageBox.Show("$2002", strFileName)
                End If
            Catch ex As Exception
                '�رմ򿪵��ļ�
                If Not excel1 Is Nothing Then
                    excel1.Application.Workbooks.Close()
                    '�˳�Excel,�Ҳ���ʾ�Ƿ񱣴�
                    CType(excel1.Application, Excel.ApplicationClass).Quit()
                End If
                Me.Cursor = Cursors.Default
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                excel1 = Nothing
                GC.Collect()
            End Try
        End If
    End Sub
    '
    '���ĳ�����range
    '
    Private Function getRange(ByVal workBook As Excel.WorkbookClass, ByVal table As String)
        Dim workSheet As Excel.Worksheet
        Dim rang As Excel.Range
        Dim j As Integer
        For j = 1 To workBook.Worksheets.Count
            workSheet = workBook.Worksheets(j)
            If workSheet.Name.Trim() = table Then
                rang = workSheet.Cells()
                workSheet.Select()
                Return rang
            End If
        Next
    End Function
    '
    '��������
    '
    Private Sub importTable(ByVal excel1 As Excel.ApplicationClass, ByVal projectCode As String, ByVal table As String, ByVal strCorporationCode As String)
        Dim workBook As Excel.WorkbookClass
        Dim workSheet As Excel.Worksheet
        Dim sheet As Excel.Sheets
        Dim rang As Excel.Range

        '���б�
        '��Ȩ�ṹ
        '��Ӫ���
        '�����м���Ҫ���������
        '�����¼
        '���ⵣ����¼
        '���ϼ�¼
        '��˰��¼
        '�жһ�Ʊ
        '��������    qxd 2003-5-7 add       
        '�������
        '�ֽ���������
        '�ʲ���ծ��
        '�����
        '�ֽ�����
        '�ֽ�������
        Try
            workBook = excel1.ActiveWorkbook
            Select Case table
                Case "��Ȩ�ṹ"
                    rang = getRange(workBook, table)
                    importCorporation_stock_structure(rang, strPhase)
                Case "��Ӫ���"
                    rang = getRange(workBook, table)
                    importCorporation_business(rang, strPhase)
                Case "�����м���Ҫ���������"
                    rang = getRange(workBook, table)
                    importCorporation_bank_saving(rang, strPhase)
                Case "�����¼"
                    rang = getRange(workBook, table)
                    importCorporation_loan(rang, strPhase)
                Case "���ⵣ����¼"
                    rang = getRange(workBook, table)
                    importCorporation_external_guarantee(rang, strPhase)
                Case "���ϼ�¼"
                    rang = getRange(workBook, table)
                    importCorporation_lawsuit_record(rang, strPhase)
                Case "��˰��¼"
                    rang = getRange(workBook, table)
                    importCorporation_ratepaying_record(rang, strPhase)
                Case "�жһ�Ʊ"
                    rang = getRange(workBook, table)
                    importCorporation_postal_order(rang, strPhase)
                Case "��������" 'qxd 2003-5-7 add 
                    rang = getRange(workBook, table)
                    importOppGuarantee(rang, strPhase)
                Case "�������"
                    rang = getRange(workBook, table)
                    importFinanceAnalyse(rang, strPhase, strCorporationCode)
                Case "�ֽ���������"
                    rang = getRange(workBook, table)
                    importCashAnalyse(rang, strPhase, strCorporationCode)
                Case "�ʲ���ծ��"
                    rang = getRange(workBook, table)
                    importBalanceSheet(rang, strPhase, strCorporationCode)
                Case "�����"
                    rang = getRange(workBook, table)
                    importIncomeStatement(rang, strPhase, strCorporationCode)
                Case "�ֽ�����"
                    rang = getRange(workBook, table)
                    importCashFlow(rang, strPhase)
                Case "�ֽ�������"
                    rang = getRange(workBook, table)
                    importCashFlowTable(rang, strPhase)
                Case "���б�"

                    '����ж����֤��ҵ�����,�ȸı�ģ��
                    Dim dsOpp As DataSet
                    Dim strSql As String
                    Dim strCorpCode
                    Dim i As Int16
                    dsOpp = gWs.FetchProjectCorporation(strProjectCode, "%", "2", "����")
                    i = dsOpp.Tables(0).Rows.Count
                    If i > 1 Then
                        '����
                        strCorpCode = dsOpp.Tables(0).Rows(0).Item("corporation_code").ToString()
                        workBook.Sheets(workBook.Sheets.Count - 2).name = "��֤��ҵ�������(" & strCorpCode & ")"
                        workBook.Sheets(workBook.Sheets.Count - 1).name = "��֤��ҵ�ʲ���ծ��(" & strCorpCode & ")"
                        workBook.Sheets(workBook.Sheets.Count - 0).name = "��֤��ҵ�����(" & strCorpCode & ")"
                        For i = 1 To i - 1 '���Ӻ����
                            strCorpCode = dsOpp.Tables(0).Rows(i).Item("corporation_code").ToString()
                            workBook.Sheets(workBook.Sheets.Count - 2).Copy(After:=workBook.Sheets(workBook.Sheets.Count))
                            workBook.Sheets(workBook.Sheets.Count).name = "��֤��ҵ�������(" & strCorpCode & ")"
                            workBook.Sheets(workBook.Sheets.Count - 2).Copy(After:=workBook.Sheets(workBook.Sheets.Count))
                            workBook.Sheets(workBook.Sheets.Count).name = "��֤��ҵ�ʲ���ծ��(" & strCorpCode & ")"
                            workBook.Sheets(workBook.Sheets.Count - 2).Copy(After:=workBook.Sheets(workBook.Sheets.Count))
                            workBook.Sheets(workBook.Sheets.Count).name = "��֤��ҵ�����(" & strCorpCode & ")"
                        Next
                    End If

                    rang = getRange(workBook, "��������")
                    importOppGuarantee(rang, strPhase)

                    rang = getRange(workBook, "������������")
                    importBaseBalanceSheet(rang, strPhase, strProjectCode.Substring(0, 5))
                    rang = getRange(workBook, "�������")
                    importFinanceAnalyse(rang, strPhase, strProjectCode.Substring(0, 5))
                    'rang = getRange(workBook, "�ֽ���������")
                    'importCashAnalyse(rang, strPhase, strProjectCode.Substring(0, 5))
                    rang = getRange(workBook, "�ʲ���ծ��")
                    'importBalanceSheet(rang, strPhase, strCorporationCode)
                    importBalanceSheet(rang, strPhase, strProjectCode.Substring(0, 5))
                    rang = getRange(workBook, "�����")
                    'importIncomeStatement(rang, strPhase, strCorporationCode)
                    importIncomeStatement(rang, strPhase, strProjectCode.Substring(0, 5))
                    rang = getRange(workBook, "�ֽ�����")
                    importCashFlow(rang, strPhase)
                    'rang = getRange(workBook, "�ֽ�������")
                    'importCashFlowTable(rang, strPhase)

                    '��֤��ҵ�������
                    i = dsOpp.Tables(0).Rows.Count
                    If i = 1 Then
                        strCorpCode = dsOpp.Tables(0).Rows(0).Item("corporation_code").ToString()
                        importFinanceAnalyse(getRange(workBook, "��֤��ҵ�������"), strPhase, strCorpCode)
                        importBalanceSheet(getRange(workBook, "��֤��ҵ�ʲ���ծ��"), strPhase, strCorpCode)
                        importIncomeStatement(getRange(workBook, "��֤��ҵ�����"), strPhase, strCorpCode)
                    ElseIf i > 1 Then
                        '����ж����֤��ҵ�����,��ʱ�����ӵĵ�����ҵ��ֵ
                        For i = 0 To i - 1
                            strCorpCode = dsOpp.Tables(0).Rows(i).Item("corporation_code").ToString()
                            importFinanceAnalyse(getRange(workBook, "��֤��ҵ�������(" & strCorpCode & ")"), strPhase, strCorpCode)
                            importBalanceSheet(getRange(workBook, "��֤��ҵ�ʲ���ծ��(" & strCorpCode & ")"), strPhase, strCorpCode)
                            importIncomeStatement(getRange(workBook, "��֤��ҵ�����(" & strCorpCode & ")"), strPhase, strCorpCode)
                        Next
                    End If

                    rang = getRange(workBook, "��������")
                    importCreditScoreSheet(rang, strPhase, strProjectCode.Substring(0, 5))

            End Select
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '��Ȩ�ṹ,1
    Private Sub importCorporation_stock_structure(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationStockStructure(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("stockholder_name")
                        rang.Item(4 + i, 2) = .Item("invest_form")
                        rang.Item(4 + i, 3) = .Item("invest_sum")
                        If Not .Item("proportion") Is System.DBNull.Value Then
                            Dim dProportion As Double
                            dProportion = CType(.Item("proportion"), Double) / 100.0
                            rang.Item(4 + i, 4) = dProportion
                        End If
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '��Ӫ���,2
    Private Sub importCorporation_business(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationBusiness(strProjectCode, "%", phase, "%")
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        Dim strMonth As String
                        If Not .Item("month") Is System.DBNull.Value Then
                            strMonth = .Item("month")
                            If strMonth.Length > 3 Then
                                rang.Item(4 + i, 1) = strMonth.Substring(0, 4) & "��1��"
                                rang.Item(4 + i, 2) = strMonth.Substring(0, 4) & "��" & strMonth.Substring(4, strMonth.Length - 4) & "��"
                            End If
                        End If
                        rang.Item(4 + i, 3) = .Item("sales_income_plan")
                        rang.Item(4 + i, 4) = .Item("profit_plan")
                        rang.Item(4 + i, 5) = .Item("sales_income")
                        rang.Item(4 + i, 6) = .Item("profit")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�����м���Ҫ���������,3
    Private Sub importCorporation_bank_saving(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationBankSaving(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("bank")
                        rang.Item(4 + i, 2) = .Item("accout")
                        rang.Item(4 + i, 3) = .Item("average_balance")
                        rang.Item(4 + i, 4) = .Item("bank_appraisement")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�����¼,4
    Private Sub importCorporation_loan(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Dim loanSum As Double = 0.0
        Try
            ds = gWs.FetchCorporationLoan(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("loan_bank")
                        rang.Item(4 + i, 2) = .Item("currency")
                        rang.Item(4 + i, 3) = .Item("loan_sum")
                        If Not .Item("loan_sum") Is System.DBNull.Value Then
                            loanSum = loanSum + CType(.Item("loan_sum"), Double)
                        End If
                        rang.Item(4 + i, 4) = .Item("loan_type")
                        rang.Item(4 + i, 5) = .Item("loan_form")
                        rang.Item(4 + i, 6) = .Item("guaranty")
                        rang.Item(4 + i, 7) = .Item("term")
                        If Not .Item("loan_end_date") Is System.DBNull.Value Then
                            rang.Item(4 + i, 8) = CType(.Item("loan_end_date"), Date).ToString("yyyy��MM��dd��")
                        End If
                        If Not .Item("refund_date") Is System.DBNull.Value Then
                            rang.Item(4 + i, 9) = CType(.Item("refund_date"), Date).ToString("yyyy��MM��dd��")
                        End If
                    End With
                Next
                rang.Item(4 + count + 1, 1) = "�ϼ�"
                rang.Item(4 + count + 1, 3) = loanSum.ToString
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '���ⵣ����¼,5
    Private Sub importCorporation_external_guarantee(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationExternalGuarantee(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("warrantee")
                        rang.Item(4 + i, 2) = .Item("loan_bank")
                        rang.Item(4 + i, 3) = .Item("currency")
                        rang.Item(4 + i, 4) = .Item("loan_sum")
                        If Not .Item("end_date") Is System.DBNull.Value Then
                            rang.Item(4 + i, 5) = CType(.Item("end_date"), Date).ToString("yyyy��MM��dd��")
                        End If
                        rang.Item(4 + i, 6) = .Item("remark")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '���ϼ�¼,6
    Private Sub importCorporation_lawsuit_record(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationLawsuitRecord(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("accuser")
                        rang.Item(4 + i, 2) = .Item("respondent")
                        rang.Item(4 + i, 3) = .Item("sum")
                        rang.Item(4 + i, 4) = .Item("reason")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '��˰��¼,7
    Private Sub importCorporation_ratepaying_record(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationRatepayingRecord(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        Dim strMonth As String
                        If Not .Item("month") Is System.DBNull.Value Then
                            strMonth = .Item("month")
                            If strMonth.Length > 3 Then
                                rang.Item(4 + i, 1) = strMonth.Substring(0, 4) & "��" & strMonth.Substring(4, strMonth.Length - 4) & "��"
                            End If
                        End If
                        rang.Item(4 + i, 2) = .Item("sum")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�жһ�Ʊ,8
    Private Sub importCorporation_postal_order(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Dim maxSum As Double = 0.0
        Dim sum As Double = 0.0
        Try
            ds = gWs.FetchCorporationPostalOrder(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("bank")
                        rang.Item(4 + i, 2) = .Item("max_sum")
                        If Not .Item("max_sum") Is System.DBNull.Value Then
                            maxSum = maxSum + CType(.Item("max_sum"), Double)
                        End If
                        rang.Item(4 + i, 3) = .Item("sum")
                        If Not .Item("sum") Is System.DBNull.Value Then
                            sum = sum + CType(.Item("sum"), Double)
                        End If
                        rang.Item(4 + i, 4) = .Item("guaranty")
                    End With
                Next
                rang.Item(4 + count + 1, 1) = "�ϼ�"
                rang.Item(4 + count + 1, 2) = maxSum
                rang.Item(4 + count + 1, 3) = sum
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '��������
    Private Sub importCreditScoreSheet(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorpCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear, strLastYearSameTerm As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        Dim strItem As String() = {"���ʲ�", "���ʲ�", _
                                   "���۶�", "�����ܶ�" _
                                  }
        Dim strItemType As String() = {"01", "01", "02", "02"}
        'qxd modify 2003-11-3  �������󱨸�ʱ���ɵı��У����վ����д���:���վ��Ӫҵ������(b12)-Ӫҵ��֧��(b13)
        'Dim strItemCode As String() = {"b01", "sum1(b02+b03)", "sum2(b06+b07+b08)", "sum3(b11-b12)", "b10", "b15", "b18"}
        Dim strItemCode As String() = {"a34", "sum1(a65-a29)", "b01", "b14"}
        Try
            'qxd modify 2004-12-6
            '''''Dim strApplyDate As String
            '''''strApplyDate = getApplyDate(strProjectCode)
            '''''strMonth = CType(strApplyDate, Date).Year '����
            '''''dYear = CType(strMonth, Double)
            '''''lastYear = dYear - 1 'ȥ��
            '''''strLastYear = lastYear.ToString
            '''''beforeLastYear = dYear - 2 'ǰ��
            '''''strBeforeLastYear = beforeLastYear.ToString
            '''''bbLastYear = dYear - 3 '��ǰ��
            '''''strBBLastYear = bbLastYear.ToString
            ''''''strCorporationCode = strProjectCode.Substring(0, 5)

            '���²��������Ǵӱ�project_finance_analyse��ȡ��,������������������ͬ���µ�����,
            '�������°����µ��Ⱥ��Ϊ����,ȥ��,ǰ��

            strSql = "select * from project_credit_appraise where project_code='" & strProjectCode & "' and corporation_code='" & strCorpCode & "' and phase='" & phase & "' and substring([month],5,2)='12' and substring([month_last],5,2)='12' and substring([month_last],1,4)=substring([month],1,4)-1 order by month"
            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count <= 0 Then
                Exit Sub
            Else

                'strLastYear = Year(gWs.GetSysTime) - 1 & "12"

                'If strLastYear <> strMonth Then
                'MyMsgBox("û��" & strLastYear.Substring(0, 4) & "���������������!", "��������һ��" & strLastYear & "�����������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!")
                'Exit Sub
                'End If
                Dim i As Integer

                For i = 0 To dt.Rows.Count - 1

                    Try
                        strMonth = dt.Rows(i).Item("month")

                        'edit by 9sky 20050705   �޸Ĵ���˳��

                        rang.Item(3 + i, 1) = strMonth.Substring(0, 4) & "��"

                        rang.Item(3 + i, 2) = dt.Rows(i).Item("quantity_score")
                        rang.Item(3 + i, 3) = dt.Rows(i).Item("quality_score")
                        rang.Item(3 + i, 4) = dt.Rows(i).Item("total_score")


                        'If dt.Rows.Count >= 2 Then
                        '    strMonth = dt.Rows(1).Item("month")
                        '    strBeforeLastYear = Year(gWs.GetSysTime) - 2 & "12"
                        '    'If strBeforeLastYear <> strMonth Then
                        '    '    MyMsgBox("û��" & strBeforeLastYear.Substring(0, 4) & "���������������!", "��������һ��" & strBeforeLastYear & "�����������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!")
                        '    '    Exit Sub
                        '    'End If

                        '    rang.Item(3, 1) = strMonth.Substring(0, 4) & "��"

                        '    rang.Item(3, 2) = dt.Rows(1).Item("quantity_score")
                        '    rang.Item(3, 3) = dt.Rows(1).Item("quality_score")
                        '    rang.Item(3, 4) = dt.Rows(1).Item("total_score")

                        'End If

                    Catch
                    End Try
                Next
            End If


        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '������������
    Private Sub importBaseBalanceSheet(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorpCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear, strLastYearSameTerm As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        Dim strItem As String() = {"���ʲ�", "���ʲ�", _
                                   "���۶�", "�����ܶ�" _
                                  }
        Dim strItemType As String() = {"01", "01", "02", "02"}
        'qxd modify 2003-11-3  �������󱨸�ʱ���ɵı��У����վ����д���:���վ��Ӫҵ������(b12)-Ӫҵ��֧��(b13)
        'Dim strItemCode As String() = {"b01", "sum1(b02+b03)", "sum2(b06+b07+b08)", "sum3(b11-b12)", "b10", "b15", "b18"}
        Dim strItemCode As String() = {"a34", "sum1(a34-a57-a32)", "b01", "b14"}
        Try
            'qxd modify 2004-12-6
            '''''Dim strApplyDate As String
            '''''strApplyDate = getApplyDate(strProjectCode)
            '''''strMonth = CType(strApplyDate, Date).Year '����
            '''''dYear = CType(strMonth, Double)
            '''''lastYear = dYear - 1 'ȥ��
            '''''strLastYear = lastYear.ToString
            '''''beforeLastYear = dYear - 2 'ǰ��
            '''''strBeforeLastYear = beforeLastYear.ToString
            '''''bbLastYear = dYear - 3 '��ǰ��
            '''''strBBLastYear = bbLastYear.ToString
            ''''''strCorporationCode = strProjectCode.Substring(0, 5)

            '���²��������Ǵӱ�project_finance_analyse��ȡ��,������������������ͬ���µ�����,
            '�������°����µ��Ⱥ��Ϊ����,ȥ��,ǰ��

            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorpCode & "' and phase='" & phase & "' order by month desc"
            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count > 3 Then
                MyMsgBox("����������ݶ���������ͬ������,ϵͳ�޷�����!", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!")
                'SWDialogBox.MessageBox.Show("����������ݶ���������ͬ������,ϵͳ�޷�����!", "������ʾ", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                Try
                    'edit by 9sky 20050705   �޸Ĵ���˳��
                    strLastYear = (strMonth.Substring(0, 4) - 1).ToString & "12"
                    rang.Item(2, 3) = strLastYear.Substring(0, 4) & "��"

                    strBeforeLastYear = (strMonth.Substring(0, 4) - 2).ToString & "12"
                    rang.Item(2, 2) = strBeforeLastYear.Substring(0, 4) & "��"

                    rang.Item(2, 4) = strMonth.Substring(0, 4) & "��" & strMonth.Substring(4, 2) & "��"

                    strLastYearSameTerm = (strMonth.Substring(0, 4) - 1).ToString & strMonth.Substring(4, 2)
                    rang.Item(2, 5) = strLastYearSameTerm.Substring(0, 4) & "��ͬ��"

                Catch
                End Try
            End If

            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorpCode & _
                     "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                     "%' or month like '" & strBeforeLastYear & "%' or month like '" & strLastYearSameTerm & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '3
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                'rang.Item(2, 1) = Me.strCorporationName
                'rang.Item(5, 2) = strBeforeLastYear.Substring(0, 4) & "��"
                'rang.Item(5, 3) = strLastYear.Substring(0, 4) & "��"

                'edit by 9sky 20050705 �����ж�
                'ǰ��
                If Not strBeforeLastYear Is Nothing Then setBaseBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j, strBeforeLastYear, 2)
                'ȥ��
                If Not strLastYear Is Nothing Then setBaseBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j, strLastYear, 3)
                '����
                If Not strMonth Is Nothing Then setBaseBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j, strMonth, 4)
                'ȥ��ͬ��
                If Not strLastYearSameTerm Is Nothing Then setBaseBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j, strLastYearSameTerm, 5)


                'For j = 0 To j - 1
                '    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strMonth & "%' "
                '    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                '        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("month") Is System.DBNull.Value Then
                '            Dim mon As String
                '            Dim len As Integer
                '            mon = ds.Tables(0).Select(strSql, "month desc")(0).Item("month")
                '            'len = strMonth.Length
                '            'mon = mon.Substring(len, mon.Length - len)
                '            rang.Item(5, 4) = mon.Substring(0, 4) & "��" & mon.Substring(4, 2) & "��"
                '            Exit For
                '        End If
                '    End If
                'Next
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '���û�����������
    Private Sub setBaseBalanceSheetRangByYear(ByVal strItemCode As String(), ByVal strItemType As String(), _
        ByVal ds As DataSet, ByVal rang As Excel.Range, ByVal j As Integer, ByVal strBeforeLastYear As String, _
        ByVal colExcel As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        For j = 0 To j - 1
            If strItemCode(j).StartsWith("sum1") Then
                strSql = "item_type='" & strItemType(j) & "' and item_code='a34' and month like '" & strBeforeLastYear & "%'"
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    strValue = getItemValue(strItemType, "a34", strBeforeLastYear, ds, j) - getItemValue(strItemType, "a57", strBeforeLastYear, ds, j) - getItemValue(strItemType, "a32", strBeforeLastYear, ds, j)
                Else
                    strValue = ""
                End If

                If strValue = "" Then
                    rang.Item(3 + j, colExcel) = strValue
                Else
                    rang.Item(3 + j, colExcel) = changedStringToTenThousand(strValue)
                End If

            Else
                strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%'"
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                        strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                    Else
                        strValue = "0"
                    End If
                Else
                    strValue = ""
                End If

                If strValue = "" Then
                    rang.Item(3 + j, colExcel) = strValue
                Else
                    rang.Item(3 + j, colExcel) = changedStringToTenThousand(strValue)
                End If

            End If
            'qxd modify 2003-11-3
            'rang.Item(6 + j, colExcel) = strValue
        Next
    End Sub

    '�������,9
    Private Sub importFinanceAnalyse(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorporationCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear As String '����,ȥ��,ǰ��
        'Dim dYear, lastYear, beforeLastYear As Double
        Dim strItem As String() = {"���ʲ�", "Ӫ���ʽ�", "���ʲ�", "�ʲ���ծ�� ", _
                                    "�������� ", "�ٶ����� ", "�����ʲ�������", "���ֱ���", _
                                    "���и�ծ����", "����ڳ�����", "��Ӫҵ����", "����������", _
                                    "Ӧ���ʿ���ת��", "�����ת��", "���ʲ��ر���", "��Ϣ���ϱ���", _
                                    "���ʲ�������", "��������������", "����������", "����������" _
                                    }
        Dim strIndexType As String() = {"11", "11", "11", "11", "11", "11", "11", "11", "11", "11", _
                                        "12", "12", "12", "12", "12", "12", _
                                        "13", "13", "13", "13"}
        Dim strIndexID As String() = {"001", "002", "003", "004", "005", "006", "007", "008", "009", "010", _
                                        "001", "002", "003", "004", "005", "006", _
                                        "001", "002", "003", "004"}
        Try
            Dim strSQLIndex, strSQLSystem As String
            Dim strLastestMonth, strSqlMonth As String

            '���²��������Ǵӱ�project_finance_analyse��ȡ��,������������������ͬ���µ�����,
            '�������°����µ��Ⱥ��Ϊ����,ȥ��,ǰ��

            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & strPhase & "' order by month desc"

            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count > 3 Then
                MyMsgBox("����������ݶ���������ͬ������,ϵͳ�޷�����!", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!")
                'SWDialogBox.MessageBox.Show("����������ݶ���������ͬ������,ϵͳ�޷�����!", "������ʾ", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                rang.Item(3, 7) = strMonth.Substring(0, 4)
                Try
                    strLastYear = (strMonth.Substring(0, 4) - 1).ToString & "12"
                    strBeforeLastYear = (strMonth.Substring(0, 4) - 2).ToString & "12"
                    rang.Item(2, 4) = strBeforeLastYear.Substring(0, 4) & "��"
                    rang.Item(2, 5) = strLastYear.Substring(0, 4) & "��"
                    rang.Item(2, 7) = strMonth.Substring(0, 4) & "��" & strMonth.Substring(4, 2) & "��"
                Catch
                End Try
            End If


            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code ='" & strCorporationCode & "'}"

            ds = gWs.FetchProjectFinanceAnalyse(strSql)

            '��ȡ�������� end

            Dim dsIndex As DataSet

            '��excel�Ķ�Ӧλ�ø�ֵ start
            dsIndex = gWs.FetchCreditQuantityIndex("{System_id='1'}")
            If ds Is Nothing Then Exit Sub
            Dim strValue As String
            Dim drTemp As DataRow
            'rang.Item(3, 4) = strBeforeLastYear.Substring(0, 4)
            'rang.Item(3, 5) = strLastYear.Substring(0, 4)
            'rang.Item(3, 7) = strMonth.Substring(0, 4)

            'ǰ��
            j = strItem.Length
            For j = 0 To j - 1
                strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strBeforeLastYear & "' "
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                        'strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                        strValue = changedStringToTenThousand(ds.Tables(0).Select(strSql)(0).Item("index_value"))
                        strSQLIndex = " index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "'"
                        If Not dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") Is System.DBNull.Value Then
                            If dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "%" Then
                                strValue = (CType(ds.Tables(0).Select(strSql)(0).Item("index_value"), Double) / 100.0).ToString
                            ElseIf dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "ԭֵ" Then
                                strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            End If
                        End If
                    Else
                        strValue = "/"
                    End If
                    rang.Item(3 + j, 4) = strValue
                End If
            Next
            'ȥ��
            j = strItem.Length
            For j = 0 To j - 1
                strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strLastYear & "' "
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                        'strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                        strValue = changedStringToTenThousand(ds.Tables(0).Select(strSql)(0).Item("index_value"))
                        strSQLIndex = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "'"
                        If Not dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") Is System.DBNull.Value Then
                            If dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "%" Then
                                strValue = (CType(ds.Tables(0).Select(strSql)(0).Item("index_value"), Double) / 100.0).ToString
                            ElseIf dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "ԭֵ" Then
                                strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            End If
                        End If
                    Else
                        strValue = "/"
                    End If
                    rang.Item(3 + j, 5) = strValue
                End If
            Next
            '����
            j = strItem.Length
            If Not strMonth = "" Then '��������Ϊ��
                For j = 0 To j - 1
                    strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strMonth & "%' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                            'strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            strValue = changedStringToTenThousand(ds.Tables(0).Select(strSql)(0).Item("index_value"))
                            strSQLIndex = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "'"
                            If Not dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") Is System.DBNull.Value Then
                                If dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "%" Then
                                    strValue = (CType(ds.Tables(0).Select(strSql)(0).Item("index_value"), Double) / 100.0).ToString
                                ElseIf dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "ԭֵ" Then
                                    strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                                End If
                            End If
                        Else
                            strValue = "/"
                        End If
                        rang.Item(3 + j, 7) = strValue
                    End If
                Next
            End If
            '��excel��Ӧλ�ø�ֵ end


        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�ֽ���������,10
    Private Sub importCashAnalyse(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorporationCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear As String
        Dim dYear, lastYear, beforeLastYear As Double
        Dim strItem As String() = {"��Ӫ�������ֽ�������/������ծ", "��Ӫ�������ֽ�������/��ծ�ܶ�", _
                                    "��Ӫ�������ֽ�������/��Ӫҵ������", "��Ӫ�������ֽ���������/������ծ", _
                                    "��Ӫ�������ֽ���������/��ծ�ܶ�", "��Ӫ�������ֽ���������/��Ӫҵ������" _
                                    }
        Dim strIndexType As String() = {"14", "14", "14", "14", "14", "14"}
        Dim strIndexID As String() = {"001", "002", "003", "004", "005", "006"}
        Try
            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & strPhase & "' order by month desc"

            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)
            If dt.Rows.Count > 3 Then
                MyMsgBox("����������ݶ���������ͬ������,ϵͳ�޷�����!", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!")
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                Try
                    strLastYear = dt.Rows(1).Item("month")
                    rang.Item(2, 4) = strLastYear.Substring(0, 4) & "��"
                    strBeforeLastYear = dt.Rows(2).Item("month")
                    rang.Item(2, 3) = strBeforeLastYear.Substring(0, 4) & "��"

                Catch
                End Try
            End If

            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & _
                     "' and (month like '" & strMonth & "' or month like '" & strLastYear & "' or month like '" & strBeforeLastYear & "') }"

            ds = gWs.FetchProjectFinanceAnalyse(strSql)
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                'rang.Item(3, 3) = strBeforeLastYear.Substring(0, 4) & "��"
                'rang.Item(3, 4) = strLastYear.Substring(0, 4) & "��"
                'rang.Item(3, 7) = strMonth & "��1��"
                'ǰ��
                For j = 0 To j - 1
                    strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strBeforeLastYear & "' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            rang.Item(3 + j, 3) = strValue
                        End If
                    End If
                Next
                'ȥ��
                For j = 0 To j - 1
                    strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strLastYear & "' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            rang.Item(3 + j, 4) = strValue
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '�ϼ�����Ľ��
    Private Function sumItem(ByVal strItemType As String, ByVal strItemCode As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet) As Double

        If strItemCode Is Nothing Or strItemType Is Nothing Then
            Return 0
        End If
        Dim strICode As String() = strItemCode.Split("+"c)
        Dim i As Int16 = strICode.Length
        Dim dSum As Double
        If i > 0 Then
            For i = 0 To i - 1
                dSum += getItemCodeValue(strItemType, strICode(i), strBeforeLastYear, ds)
            Next
        End If
        Return dSum

    End Function

    Private Function getItemCodeValue(ByVal strItemType As String, ByVal strItemCode As String, ByVal strYear As String, ByVal ds As DataSet) As Double
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        Try
            strSql = "item_type='" & strItemType & "' and item_code='" & strItemCode & "' and month like '" & strYear & "%' "
            If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                    strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                    dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
                End If
            End If
        Catch
        End Try
        Return dValue_1
    End Function
    '�ʲ���ծ��,11
    Private Sub importBalanceSheet(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorpCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear, strLastYearSameTerm As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        'Dim strItem As String() = {"�����ʽ�", "Ӧ��", "���У�Ӧ���˿�", _
        '                            "���", "��̯", "����Ͷ��", _
        '                            "�̶��ʲ�", "���ʲ�", "����Ͷ��", _
        '                            "�����ʲ��������ʲ�", "���", "Ӧ��", _
        '                            "���У�Ӧ���˿�", "Ӧ��˰��", "ʵ���ʱ�", _
        '                            "�ʱ�����", "��������", "��ծ��Ȩ��", _
        '                             "Ԥ���ʿ�", "Ԥ���ʿ�" _
        '                            }

        'Dim strItem As String() = {"�����ʽ�", "����Ͷ��", "Ӧ���ʿ�", _
        '                           "Ԥ���ʿ�", "����Ӧ��", "���", _
        '                           "��̯", "����Ͷ��", "�̶��ʲ�", _
        '                           "�����ʲ��������ʲ�", "���ʲ�", "���", _
        '                           "Ӧ���ʿ�", "Ԥ���ʿ�", "Ӧ��˰��", _
        '                           "����Ӧ��", "", "ʵ���ʱ�", _
        '                            "�ʱ�����", "��������", "", _
        '                            "��ծ��Ȩ��" _
        '                           }
        Dim strItem As String() = {"�����ʽ�", "����Ͷ��", "Ӧ��Ʊ��", _
                                    "Ӧ���ʿ�", _
                                    "Ԥ���ʿ�", "����Ӧ��", "���", _
                                    "��̯", "����Ͷ��", "�̶��ʲ�", _
                                    "�����ʲ��������ʲ�", "���ʲ�", "���", _
                                    "Ӧ��Ʊ��", _
                                    "Ӧ���ʿ�", "Ԥ���ʿ�", "Ӧ��˰��", _
                                    "����Ӧ��", "", "ʵ���ʱ�", _
                                    "�ʱ�����", "��������", "", _
                                    "��ծ��Ȩ��" _
                                           }

        'Dim strItemCode As String() = {"a01", "sum(a03+a04+a05+a07+a09+a12+a13)", "a06", _
        '                                "a10", "sum(a11+a30)", "a17", _
        '                                "a28", "a34", "a02", _
        '                                "sum(a29+a31)", "sum(a35+a50)", "sum(a36+a39+a40+a41+a43+a44+a46+a47+a48+a51+a52+a53+a54+a56+a45)", _
        '                                "a06", "a42", "a58", _
        '                                "a59", "sum(a60+a62)", "a66", _
        '                                "a08", "a38" _
        '                                }
        'Dim strItemCode As String() = {"a01", "a02", "a06", _
        '                                "a08", "sum(a03+a04+a05+a07+a09+a12+a13)", "a10", _
        '                                "sum(a11+a30)", "a17", "a28", _
        '                                "sum(a29+a31)", "a34", "sum(a35+a50)", _
        '                                "a37", "a38", "a42", _
        '                                "sum(a36+a39+a40+a41+a43+a44+a46+a47+a48+a51+a52+a53+a54+a56+a45)", "", "a58", _
        '                                "a59", "sum(a60+a62)", "", _
        '                                "a66" _
        '                                }
        Dim strItemCode As String() = {"a01", "a02", "a03", _
                                        "a06", _
                                        "a08", "sum(a04+a05+a07+a09+a12+a13)", "a10", _
                                        "sum(a11+a30)", "a17", "a28", _
                                        "sum(a29+a31)", "a34", "sum(a35+a50)", _
                                        "a36", _
                                        "a37", "a38", "a42", _
                                        "sum(a39+a40+a41+a43+a44+a46+a47+a48+a51+a52+a53+a54+a56+a45)", "", "a58", _
                                        "a59", "sum(a60+a62)", "", _
                                        "a66" _
                                        }

        Dim strItemType As String() = {"01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01" _
                                        }

        Try
            'qxd modify 2004-12-6
            ''''Dim strApplyDate As String
            ''''strApplyDate = getApplyDate(strProjectCode)
            ''''strMonth = CType(strApplyDate, Date).Year '����(������)
            ''''dYear = CType(strMonth, Double)
            ''''lastYear = dYear - 1 'ȥ��
            ''''strLastYear = lastYear.ToString
            ''''beforeLastYear = dYear - 2 'ǰ��
            ''''strBeforeLastYear = beforeLastYear.ToString

            '���²��������Ǵӱ�project_finance_analyse��ȡ��,������������������ͬ���µ�����,
            '�������°����µ��Ⱥ��Ϊ����,ȥ��,ǰ��

            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorpCode & "' and phase='" & phase & "' order by month desc"
            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count > 3 Then
                MyMsgBox("����������ݶ���������ͬ������,ϵͳ�޷�����!", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!")
                'SWDialogBox.MessageBox.Show("����������ݶ���������ͬ������,ϵͳ�޷�����!", "������ʾ", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                Try
                    'edity by 9sky 20050705 �޸��˴���˳��
                    'strLastYear = dt.Rows(1).Item("month")
                    strLastYear = (strMonth.Substring(0, 4) - 1).ToString & "12"
                    strLastYearSameTerm = (strMonth.Substring(0, 4) - 1).ToString & strMonth.Substring(4, 2)
                    rang.Item(4, 3) = strLastYear.Substring(0, 4) & "��ĩ"
                    rang.Item(4, 8) = strLastYear.Substring(0, 4) & "��ĩ"
                    rang.Item(4, 5) = strLastYearSameTerm.Substring(0, 4) & "��ͬ��"
                    rang.Item(4, 10) = strLastYearSameTerm.Substring(0, 4) & "��ͬ��"
                    'strBeforeLastYear = dt.Rows(2).Item("month")
                    strBeforeLastYear = (strMonth.Substring(0, 4) - 2).ToString & "12"
                    rang.Item(4, 2) = strBeforeLastYear.Substring(0, 4) & "��ĩ"
                    rang.Item(4, 7) = strBeforeLastYear.Substring(0, 4) & "��ĩ"
                    rang.Item(4, 4) = strMonth.Substring(0, 4) & "��" & strMonth.Substring(4, 2) & "��"
                    rang.Item(4, 9) = strMonth.Substring(0, 4) & "��" & strMonth.Substring(4, 2) & "��"
                Catch
                End Try
            End If


            'strCorporationCode = strProjectCode.Substring(0, 5)
            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorpCode & _
                     "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                     "%' or month like '" & strBeforeLastYear & "%' or month like '" & strLastYearSameTerm & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '���е��⼸���������'4
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow


                '����һЩ������Ϣ
                'rang.Item(2, 1) = Me.strCorporationName
                'rang.Item(5, 2) = strBeforeLastYear.Substring(0, 4) & "��ĩ"
                'rang.Item(5, 3) = strLastYear.Substring(0, 4) & "��ĩ"
                'rang.Item(5, 6) = strBeforeLastYear.Substring(0, 4) & "��ĩ"
                'rang.Item(5, 7) = strLastYear.Substring(0, 4) & "��ĩ"
                'edit by 9sky 20050705 �������ж�����
                'ǰ��(��벿��)
                If Not strBeforeLastYear Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strBeforeLastYear, 2) '���ֱַ�Ϊ������������
                'ȥ��(��벿��)
                If Not strLastYear Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strLastYear, 3)
                '����(��벿��
                If Not strMonth Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strMonth, 4)
                'ȥ��ͬ��(��벿��)
                If Not strLastYearSameTerm Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strLastYearSameTerm, 5)
                'ǰ��(�Ұ벿��)
                If Not strBeforeLastYear Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j - 12, strBeforeLastYear, 7, False)
                'ȥ��(�Ұ벿��)
                If Not strLastYear Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j - 12, strLastYear, 8, False)
                '����(�Ұ벿��)
                If Not strMonth Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j - 12, strMonth, 9, False)
                'ȥ��ͬ��(�Ұ벿��)
                If Not strLastYearSameTerm Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strLastYearSameTerm, 10, False)

                'For j = 0 To j - 1
                '    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strMonth & "%' "
                '    If ds.Tables(0).Select(strSql).Length > 0 Then
                '        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("month") Is System.DBNull.Value Then
                '            Dim mon As String
                '            Dim len As Integer
                '            mon = ds.Tables(0).Select(strSql, "month desc")(0).Item("month")
                '            'len = strMonth.Length
                '            'mon = mon.Substring(len, mon.Length - len)
                '            'rang.Item(5, 4) = strMonth & "��" & mon & "��ĩ"
                '            'rang.Item(5, 8) = strMonth & "��" & mon & "��ĩ"
                '            rang.Item(4, 5) = mon.Substring(0, 4) & "��" & mon.Substring(4, 2) & "��"
                '            rang.Item(4, 10) = mon.Substring(0, 4) & "��" & mon.Substring(4, 2) & "��"
                '            Exit For
                '        End If
                '    End If
                'Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '�����ʲ���ծ��
    Private Sub setBalanceSheetRangByYear(ByVal strItemCode As String(), ByVal strItemType As String(), _
        ByVal ds As DataSet, ByVal rang As Excel.Range, ByVal j As Integer, ByVal strBeforeLastYear As String, _
        ByVal colExcel As Integer, Optional ByVal isLeft As Boolean = True)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        Dim dValueTemp(9) As Double
        Dim iStart As Int16
        Dim iEnd As Int16
        Dim rownum As Int16

        If isLeft = False Then
            iStart = j
            iEnd = j + j
        Else
            iStart = 0
            iEnd = j
        End If

        strSql = "month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then

            For j = iStart To iEnd - 1

                If strItemCode(j).StartsWith("sum") Then
                    Dim dSum As Double
                    dSum = Me.sumItem(strItemType(j), strItemCode(j).Substring(4, strItemCode(j).Length - 5), strBeforeLastYear, ds)
                    strValue = dSum.ToString()
                Else
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%' "
                    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                        Else
                            strValue = "0"
                        End If
                    Else
                        strValue = ""
                    End If
                End If
                'qxd modify 2003-11-3
                'rang.Item(6 + j, colExcel) = strValue

                If isLeft = False Then
                    rownum = j - iStart
                Else
                    rownum = j
                End If

                If strValue = "" Then
                    rang.Item(5 + rownum, colExcel) = strValue
                Else
                    rang.Item(5 + rownum, colExcel) = changedStringToTenThousand(strValue)
                End If

            Next
        Else
            For j = iStart To iEnd - 1

                If isLeft = False Then
                    rownum = j - iStart
                Else
                    rownum = j
                End If
                rang.Item(5 + rownum, colExcel) = ""
            Next

        End If
    End Sub
    '���
    Private Function getSumValue(ByVal strItemType As String(), ByVal itemCode_A As String, ByVal itemCode_B As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet, ByVal j As Integer, ByVal isAdd As Boolean)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_A & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
            End If
        Else
            Return ""
        End If
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_B & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_2 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_2 = IIf(strValue_2 = "", 0, CType(strValue_2, Double))
            End If
        Else
            Return ""
        End If
        If isAdd Then
            dValue = dValue_1 + dValue_2
        Else
            dValue = dValue_1 - dValue_2
        End If
        strValue = dValue.ToString
        Return strValue
    End Function
    '���ÿ���ֵ
    Private Function getItemValue(ByVal strItemType As String(), ByVal itemCode_A As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet, ByVal j As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        Try
            strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_A & "' and month like '" & strBeforeLastYear & "%' "
            If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                    strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                    dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
                End If
            End If
        Catch
        End Try
        Return dValue_1
    End Function
    '�����,12
    Private Sub importIncomeStatement(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorpCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear, strLastYearSameTerm As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        Dim strItem As String() = {"����", "�ɱ�˰��", _
                                     "�ڼ����", "����ҵ������", _
                                     "���վ���", "Ͷ������", _
                                     "����˰", "������", _
                                     "ë����", "������" _
                                    }
        Dim strItemType As String() = {"02", "02", "02", "02", "02", "02", "02", "02", "02", "02"}
        'qxd modify 2003-11-3  �������󱨸�ʱ���ɵı��У����վ����д���:���վ��Ӫҵ������(b12)-Ӫҵ��֧��(b13)
        'Dim strItemCode As String() = {"b01", "sum1(b02+b03)", "sum2(b06+b07+b08)", "sum3(b11-b12)", "b10", "b15", "b18"}
        Dim strItemCode As String() = {"b01", "sum1(b02+b03)", "sum2(b06+b07+b08)", "b05", "sum3(b12-b13)", "b10", "b15", "b18", "div1(b04/b01)", "div2(b18/b01)"}
        Try
            'qxd modify 2004-12-6
            '''''Dim strApplyDate As String
            '''''strApplyDate = getApplyDate(strProjectCode)
            '''''strMonth = CType(strApplyDate, Date).Year '����
            '''''dYear = CType(strMonth, Double)
            '''''lastYear = dYear - 1 'ȥ��
            '''''strLastYear = lastYear.ToString
            '''''beforeLastYear = dYear - 2 'ǰ��
            '''''strBeforeLastYear = beforeLastYear.ToString
            '''''bbLastYear = dYear - 3 '��ǰ��
            '''''strBBLastYear = bbLastYear.ToString
            ''''''strCorporationCode = strProjectCode.Substring(0, 5)

            '���²��������Ǵӱ�project_finance_analyse��ȡ��,������������������ͬ���µ�����,
            '�������°����µ��Ⱥ��Ϊ����,ȥ��,ǰ��

            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorpCode & "' and phase='" & phase & "' order by month desc"
            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count > 3 Then
                MyMsgBox("����������ݶ���������ͬ������,ϵͳ�޷�����!", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!")
                'SWDialogBox.MessageBox.Show("����������ݶ���������ͬ������,ϵͳ�޷�����!", "������ʾ", "��������һ�β������,������ǳ��ִ���,����ϵͳ����Ա��ϵ!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                Try
                    'edit by 9sky 20050705   �޸Ĵ���˳��
                    strLastYear = (strMonth.Substring(0, 4) - 1).ToString & "12"
                    rang.Item(4, 3) = strLastYear.Substring(0, 4) & "��"

                    strBeforeLastYear = (strMonth.Substring(0, 4) - 2).ToString & "12"
                    rang.Item(4, 2) = strBeforeLastYear.Substring(0, 4) & "��"

                    rang.Item(4, 4) = strMonth.Substring(0, 4) & "��" & strMonth.Substring(4, 2) & "��"

                    strLastYearSameTerm = (strMonth.Substring(0, 4) - 1).ToString & strMonth.Substring(4, 2)
                    rang.Item(4, 5) = strLastYearSameTerm.Substring(0, 4) & "��ͬ��"

                Catch
                End Try
            End If

            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorpCode & _
                     "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                     "%' or month like '" & strBeforeLastYear & "%' or month like '" & strLastYearSameTerm & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '3
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                'rang.Item(2, 1) = Me.strCorporationName
                'rang.Item(5, 2) = strBeforeLastYear.Substring(0, 4) & "��"
                'rang.Item(5, 3) = strLastYear.Substring(0, 4) & "��"

                'edit by 9sky 20050705 �����ж�
                'ǰ��
                If Not strBeforeLastYear Is Nothing Then setIncomeStatementRangByYear(strItemCode, strItemType, ds, rang, j, strBeforeLastYear, 2)
                'ȥ��
                If Not strLastYear Is Nothing Then setIncomeStatementRangByYear(strItemCode, strItemType, ds, rang, j, strLastYear, 3)
                '����
                If Not strMonth Is Nothing Then setIncomeStatementRangByYear(strItemCode, strItemType, ds, rang, j, strMonth, 4)
                'ȥ��ͬ��
                If Not strLastYearSameTerm Is Nothing Then setIncomeStatementRangByYear(strItemCode, strItemType, ds, rang, j, strLastYearSameTerm, 5)


                'For j = 0 To j - 1
                '    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strMonth & "%' "
                '    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                '        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("month") Is System.DBNull.Value Then
                '            Dim mon As String
                '            Dim len As Integer
                '            mon = ds.Tables(0).Select(strSql, "month desc")(0).Item("month")
                '            'len = strMonth.Length
                '            'mon = mon.Substring(len, mon.Length - len)
                '            rang.Item(5, 4) = mon.Substring(0, 4) & "��" & mon.Substring(4, 2) & "��"
                '            Exit For
                '        End If
                '    End If
                'Next
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '���������
    Private Sub setIncomeStatementRangByYear(ByVal strItemCode As String(), ByVal strItemType As String(), _
        ByVal ds As DataSet, ByVal rang As Excel.Range, ByVal j As Integer, ByVal strBeforeLastYear As String, _
        ByVal colExcel As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        For j = 0 To j - 1
            If strItemCode(j).StartsWith("sum1") Then
                strValue = getSumValue(strItemType, "b02", "b03", strBeforeLastYear, ds, j, True)
                If strValue = "" Then
                    rang.Item(5 + j, colExcel) = strValue
                Else
                    rang.Item(5 + j, colExcel) = changedStringToTenThousand(strValue)
                End If
            ElseIf strItemCode(j).StartsWith("sum2") Then
                strValue = getSumValueEx(strItemType, "b06", "b07", "b08", strBeforeLastYear, ds, j)
                If strValue = "" Then
                    rang.Item(5 + j, colExcel) = strValue
                Else
                    rang.Item(5 + j, colExcel) = changedStringToTenThousand(strValue)
                End If
            ElseIf strItemCode(j).StartsWith("sum3") Then
                'qxd modify 2003-11-3
                'strValue = getSumValue(strItemType, "b11", "b12", strBeforeLastYear, ds, j, False)
                strValue = getSumValue(strItemType, "b12", "b13", strBeforeLastYear, ds, j, False)
                If strValue = "" Then
                    rang.Item(5 + j, colExcel) = strValue
                Else
                    rang.Item(5 + j, colExcel) = changedStringToTenThousand(strValue)
                End If
            ElseIf strItemCode(j).StartsWith("div1") Then
                strValue = getDivValue(strItemType, "b04", "b01", strBeforeLastYear, ds, j)
                rang.Item(5 + j, colExcel) = strValue
            ElseIf strItemCode(j).StartsWith("div2") Then
                strValue = getDivValue(strItemType, "b18", "b01", strBeforeLastYear, ds, j)
                rang.Item(5 + j, colExcel) = strValue
            Else
                strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%'"
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                        strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                    Else
                        strValue = "0"
                    End If
                Else
                    strValue = ""
                End If

                If strValue = "" Then
                    rang.Item(5 + j, colExcel) = strValue
                Else
                    rang.Item(5 + j, colExcel) = changedStringToTenThousand(strValue)
                End If
            End If
            'qxd modify 2003-11-3
            'rang.Item(6 + j, colExcel) = strValue
        Next
    End Sub
    '�����
    Private Function getDivValue(ByVal strItemType As String(), ByVal itemCode_A As String, ByVal itemCode_B As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet, ByVal j As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_A & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
            End If
        Else
            Return ""
        End If
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_B & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_2 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_2 = IIf(strValue_2 = "", 0, CType(strValue_2, Double))
            End If
        Else
            Return ""
        End If
        dValue = dValue_1 / dValue_2
        If dValue_2 = 0 Then
            strValue = ""
        Else
            strValue = Math.Round(dValue, 2) * 100 & "%"
        End If

        Return strValue
    End Function
    '���
    Private Function getSumValueEx(ByVal strItemType As String(), ByVal itemCode_A As String, ByVal itemCode_B As String, ByVal itemCode_C As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet, ByVal j As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2, strValue_3 As String
        Dim dValue_1, dValue_2, dValue_3, dValue As Double
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_A & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
            End If
        Else
            Return ""
        End If
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_B & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_2 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_2 = IIf(strValue_2 = "", 0, CType(strValue_2, Double))
            End If
        Else
            Return ""
        End If
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_C & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_3 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_3 = IIf(strValue_3 = "", 0, CType(strValue_3, Double))
            End If
        Else
            Return ""
        End If
        dValue = dValue_1 + dValue_2 + dValue_3
        strValue = dValue.ToString
        Return strValue
    End Function
    '�ֽ�����,13
    Private Sub importCashFlow(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear As String
        Dim dYear, lastYear, beforeLastYear As Double
        Dim strItem As String() = {"��Ӫ��������ֽ�����������", "��Ӫ��������ֽ�����������", _
                                    "��Ӫ��������ֽ���������", "Ͷ�ʻ�������ֽ�����������", _
                                    "Ͷ�ʻ�������ֽ�����������", "Ͷ�ʻ�������ֽ���������", _
                                    "���ʻ�������ֽ�����������", "���ʻ�������ֽ�����������", _
                                    "���ʻ�������ֽ���������" _
                                    }
        Dim strItemType As String() = {"03", "03", "03", "03", "03", "03", "03", "03", "03"}
        Dim strItemCode As String() = {"c04", "c09", _
                                        "c10", "c15", _
                                        "c19", "c20", _
                                        "c25", "c32", _
                                        "c33" _
                                        }
        Try
            Dim strApplyDate As String
            strApplyDate = GetApplyDate(strProjectCode)
            strMonth = CType(strApplyDate, Date).Year '����
            dYear = CType(strMonth, Double)
            lastYear = dYear - 1 'ȥ��
            strLastYear = lastYear.ToString
            beforeLastYear = dYear - 2 'ǰ��
            strBeforeLastYear = beforeLastYear.ToString
            strCorporationCode = strProjectCode.Substring(0, 5)
            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorporationCode & _
                                "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                                "%' or month like '" & strBeforeLastYear & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '2ʹ���������
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                rang.Item(3, 2) = strBeforeLastYear & "��"
                rang.Item(3, 5) = strLastYear & "��"
                'rang.Item(5, 6) = strMonth & "��1��"
                'ǰ��
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            If j < 3 Then
                                'qxd modify 2003-11-3
                                'rang.Item(5, 2 + j) = strValue
                                rang.Item(5, 2 + j) = changedStringToTenThousand(strValue)
                            ElseIf j < 6 Then
                                'qxd modify 2003-11-3
                                'rang.Item(6, 2 + j - 3) = strValue
                                rang.Item(6, 2 + j - 3) = changedStringToTenThousand(strValue)
                            ElseIf j < 9 Then
                                'qxd modify 2003-11-3
                                'rang.Item(7, 2 + j - 6) = strValue
                                rang.Item(7, 2 + j - 6) = changedStringToTenThousand(strValue)
                            End If
                        End If
                    End If
                Next
                'ȥ��
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strLastYear & "%' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            If j < 3 Then
                                'qxd modify 2003-11-3
                                'rang.Item(5, 5 + j) = strValue
                                rang.Item(5, 5 + j) = changedStringToTenThousand(strValue)
                            ElseIf j < 6 Then
                                'qxd modify 2003-11-3
                                'rang.Item(6, 5 + j - 3) = strValue
                                rang.Item(6, 5 + j - 3) = changedStringToTenThousand(strValue)
                            ElseIf j < 9 Then
                                'qxd modify 2003-11-3
                                'rang.Item(7, 5 + j - 6) = strValue
                                rang.Item(7, 5 + j - 6) = changedStringToTenThousand(strValue)
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    '�ֽ�������,14
    Private Sub importCashFlowTable(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        Dim strItem As String() = {"��Ӫ��������ֽ�������", " ��Ӫ��������ֽ���������"}
        Dim strItemType As String() = {"03", "03"}
        Dim strItemCode As String() = {"c01", "c10"}
        Try
            Dim strApplyDate As String
            strApplyDate = GetApplyDate(strProjectCode)
            strMonth = CType(strApplyDate, Date).Year '����
            dYear = CType(strMonth, Double)
            lastYear = dYear - 1 'ȥ��
            strLastYear = lastYear.ToString
            beforeLastYear = dYear - 2 'ǰ��
            strBeforeLastYear = beforeLastYear.ToString
            bbLastYear = dYear - 3 '��ǰ��
            strBBLastYear = bbLastYear.ToString
            strCorporationCode = strProjectCode.Substring(0, 5)
            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorporationCode & _
                     "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                     "%' or month like '" & strBeforeLastYear & "%' or month like '" & strBBLastYear & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '1
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                'rang.Item(2, 1) = Me.strCorporationName
                'rang.Item(2, 3) = CType(strApplyDate, Date).ToString("yyyy��MM��dd��")
                rang.Item(5, 3) = strBBLastYear & "��"
                rang.Item(5, 4) = strBeforeLastYear & "��"
                rang.Item(5, 5) = strLastYear & "��"
                'rang.Item(5, 6) = strMonth & "��1��"
                '��ǰ��
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBBLastYear & "%' "
                    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            'qxd modify 2003-11-3
                            'rang.Item(6 + j, 3) = strValue
                            rang.Item(6 + j, 3) = changedStringToTenThousand(strValue)
                        End If
                    End If
                Next
                'ǰ��
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%' "
                    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            'qxd modify 2003-11-3
                            'rang.Item(6 + j, 4) = strValue
                            rang.Item(6 + j, 4) = changedStringToTenThousand(strValue)
                        End If
                    End If
                Next
                'ȥ��
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strLastYear & "%' "
                    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            'qxd modify 2003-11-3
                            'rang.Item(6 + j, 5) = strValue
                            rang.Item(6 + j, 5) = changedStringToTenThousand(strValue)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '��������
    '
    Public Sub importOppGuarantee(ByVal rang As Excel.Range, ByVal phase As String)
        ''''''''''''''''''''''''''''''���ز�,����,�����豸,��Ʊ,��Ȩ,�浥  
        Dim strOppName As String() = {"���ز�", "����", "�����豸", "��Ʊ", "��Ȩ", "�浥", "����"}
        Dim strOppType As String() = {"21", "22", "23", "24", "25", "26", "2M"}
        Dim dsOpp, dsDetail As DataSet
        Dim drOpp, drDetail As DataRow
        Dim strSql As String
        Dim i, len As Integer
        Dim strSerial, strItemType, strOriginal, strEvaluate, strGuarantee As ArrayList
        Dim flag As New ArrayList
        strSerial = New ArrayList
        strItemType = New ArrayList
        strOriginal = New ArrayList
        strEvaluate = New ArrayList
        strGuarantee = New ArrayList
        If gWs Is Nothing Then
            Exit Sub
        End If
        Try
            strSql = "{project_code='" & strProjectCode & "' order by guaranty_type }"
            dsOpp = gWs.GetGuarantyInfo(strSql, "null")
            i = dsOpp.Tables("opposite_guarantee").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    drOpp = dsOpp.Tables("opposite_guarantee").Rows(i)
                    With drOpp
                        If Not .Item("serial_num") Is System.DBNull.Value Then
                            strSerial.Add(.Item("serial_num"))
                            flag.Add("false")
                            If Not .Item("guaranty_type") Is System.DBNull.Value Then
                                strItemType.Add(.Item("guaranty_type"))
                            Else
                                strItemType.Add("")
                            End If
                            If Not .Item("original_value") Is System.DBNull.Value Then
                                strOriginal.Add(.Item("original_value"))
                            Else
                                strOriginal.Add("0.0")
                            End If
                            If Not .Item("evaluate_value") Is System.DBNull.Value Then
                                strEvaluate.Add(.Item("evaluate_value"))
                            Else
                                strEvaluate.Add("0.0")
                            End If
                            If Not .Item("guarantee_value") Is System.DBNull.Value Then
                                strGuarantee.Add(.Item("guarantee_value"))
                            Else
                                strGuarantee.Add("0.0")
                            End If
                        End If
                    End With
                Next

                rang.Range(rang.Cells(2, 1), rang.Cells(2, 13)).Merge()

                len = strSerial.Count
                If len > 0 Then
                    Dim count As Integer = 0
                    Dim maxLen_21, maxLen_22, maxLen_23, maxLen_24, maxLen_25, maxLen_26, maxLen_2m As Integer
                    Dim dOriginal_21, dEvaluate_21, dGuarantee_21 As Double
                    Dim dOriginal_22, dEvaluate_22, dGuarantee_22 As Double
                    Dim dOriginal_23, dEvaluate_23, dGuarantee_23 As Double
                    Dim dOriginal_24, dEvaluate_24, dGuarantee_24 As Double
                    Dim dOriginal_25, dEvaluate_25, dGuarantee_25 As Double
                    Dim dOriginal_26, dEvaluate_26, dGuarantee_26 As Double
                    Dim dOriginal_2m, dEvaluate_2m, dGuarantee_2m As Double
                    Dim b_21, b_22, b_23, b_24, b_25, b_26, b_2m As Boolean
                    Dim count_21, count_22, count_23, count_24, count_25, count_26, count_2m As Integer
                    Dim a, b, c, d, e, f, g As Integer
                    For len = 0 To len - 1
                        Select Case strItemType(len)
                            Case "21"
                                If b_21 Then
                                    flag(len) = "true"
                                    If count_21 = 1 Then
                                        count_21 = count_21 + 2
                                    Else
                                        count_21 = count_21 + 1
                                    End If
                                    a = count_21 + 3
                                Else
                                    count_21 = count_21 + 1
                                    a = count_21 + 4
                                End If
                                rang.Item(3, 1) = "���ز�"
                                maxLen_21 = setOpp(rang, count_21 + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_21 = strOriginal(len) + dOriginal_21
                                dEvaluate_21 = strEvaluate(len) + dEvaluate_21
                                dGuarantee_21 = strGuarantee(len) + dGuarantee_21
                                b_21 = True
                            Case "22"
                                If a = 0 Then
                                    a = 3
                                End If
                                If b_22 Then
                                    flag(len) = "true"
                                    If count_22 = 1 Then
                                        count_22 = count_22 + 2
                                    Else
                                        count_22 = count_22 + 1
                                    End If
                                    b = count_22 + a + 3
                                Else
                                    count_22 = count_22 + 1
                                    b = count_22 + a + 4
                                End If
                                rang.Item(a + 3, 1) = "����"
                                maxLen_22 = setOpp(rang, count_22 + a + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_22 = Double.Parse(strOriginal(len)) + dOriginal_22
                                dEvaluate_22 = Double.Parse(strEvaluate(len)) + dEvaluate_22
                                dGuarantee_22 = Double.Parse(strGuarantee(len)) + dGuarantee_22
                                b_22 = True
                            Case "23"
                                If b = 0 Then
                                    b = a
                                End If
                                If b_23 Then
                                    flag(len) = "true"
                                    If count_23 = 1 Then
                                        count_23 = count_23 + 2
                                    Else
                                        count_23 = count_23 + 1
                                    End If
                                    c = count_23 + b + 3
                                Else
                                    count_23 = count_23 + 1
                                    c = count_23 + b + 4
                                End If
                                rang.Item(b + 3, 1) = "�����豸"
                                maxLen_23 = setOpp(rang, count_23 + b + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_23 = CType(strOriginal(len), Double) + dOriginal_23
                                dEvaluate_23 = CType(strEvaluate(len), Double) + dEvaluate_23
                                dGuarantee_23 = CType(strGuarantee(len), Double) + dGuarantee_23
                                b_23 = True
                            Case "24"
                                If c = 0 Then
                                    If b = 0 Then
                                        c = a
                                    Else
                                        c = b
                                    End If
                                End If
                                If b_24 Then
                                    flag(len) = "true"
                                    If count_24 = 1 Then
                                        count_24 = count_24 + 2
                                    Else
                                        count_24 = count_24 + 1
                                    End If
                                    d = count_24 + c + 3
                                Else
                                    count_24 = count_24 + 1
                                    d = count_24 + c + 4
                                End If
                                rang.Item(c + 3, 1) = "��Ʊ"
                                maxLen_24 = setOpp(rang, count_24 + c + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_24 = Double.Parse(strOriginal(len)) + dOriginal_24
                                dEvaluate_24 = Double.Parse(strEvaluate(len)) + dEvaluate_24
                                dGuarantee_24 = Double.Parse(strGuarantee(len)) + dGuarantee_24
                                b_24 = True
                            Case "25"
                                If d = 0 Then
                                    If c = 0 Then
                                        If b = 0 Then
                                            d = a
                                        Else
                                            d = b
                                        End If
                                    Else
                                        d = c
                                    End If
                                End If
                                If b_25 Then
                                    flag(len) = "true"
                                    If count_25 = 1 Then
                                        count_25 = count_25 + 2
                                    Else
                                        count_25 = count_25 + 1
                                    End If
                                    e = count_25 + d + 3
                                Else
                                    count_25 = count_25 + 1
                                    e = count_25 + d + 4
                                End If
                                rang.Item(d + 3, 1) = "��Ȩ"
                                maxLen_25 = setOpp(rang, count_25 + d + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_25 = CType(strOriginal(len), Double) + dOriginal_25
                                dEvaluate_25 = CType(strEvaluate(len), Double) + dEvaluate_25
                                dGuarantee_25 = CType(strGuarantee(len), Double) + dGuarantee_25
                                b_25 = True
                            Case "26"
                                If e = 0 Then
                                    If d = 0 Then
                                        If c = 0 Then
                                            If b = 0 Then
                                                e = a
                                            Else
                                                e = b
                                            End If
                                        Else
                                            e = c
                                        End If
                                    Else 'qxd add 2003-11-4
                                        e = d
                                    End If
                                End If
                                If b_26 Then
                                    flag(len) = "true"
                                    If count_26 = 1 Then
                                        count_26 = count_26 + 2
                                    Else
                                        count_26 = count_26 + 1
                                    End If
                                    f = count_26 + e + 3
                                Else
                                    count_26 = count_26 + 1
                                    f = count_26 + e + 4
                                End If
                                rang.Item(e + 3, 1) = "�浥"
                                maxLen_26 = setOpp(rang, count_26 + e + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_26 = CType(strOriginal(len), Double) + dOriginal_26
                                dEvaluate_26 = CType(strEvaluate(len), Double) + dEvaluate_26
                                dGuarantee_26 = CType(strGuarantee(len), Double) + dGuarantee_26
                                b_26 = True
                            Case "2M"
                                If f = 0 Then
                                    If e = 0 Then
                                        If d = 0 Then
                                            If c = 0 Then
                                                If b = 0 Then
                                                    f = a
                                                Else
                                                    f = b
                                                End If
                                            Else
                                                f = c
                                            End If
                                        Else 'qxd add 2003-11-4
                                            f = d
                                        End If
                                    Else
                                        f = e
                                    End If
                                End If
                                If b_2m Then
                                    flag(len) = "true"
                                    If count_2m = 1 Then
                                        count_2m = count_2m + 2
                                    Else
                                        count_2m = count_2m + 1
                                    End If
                                    g = count_2m + f + 3
                                Else
                                    count_2m = count_2m + 1
                                    g = count_2m + f + 4
                                End If
                                rang.Item(f + 3, 1) = "����"
                                maxLen_2m = setOpp(rang, count_2m + f + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_2m = strOriginal(len) + dOriginal_2m
                                dEvaluate_2m = strEvaluate(len) + dEvaluate_2m
                                dGuarantee_2m = strGuarantee(len) + dGuarantee_2m
                                b_2m = True
                        End Select
                    Next
                    If b_21 Then
                        setOppTotal(rang, a + 1, maxLen_21, dOriginal_21, dEvaluate_21, dGuarantee_21)
                    End If
                    If b_22 Then
                        setOppTotal(rang, b + 1, maxLen_22, dOriginal_22, dEvaluate_22, dGuarantee_22)
                    End If
                    If b_23 Then
                        setOppTotal(rang, c + 1, maxLen_23, dOriginal_23, dEvaluate_23, dGuarantee_23)
                    End If
                    If b_24 Then
                        setOppTotal(rang, d + 1, maxLen_24, dOriginal_24, dEvaluate_24, dGuarantee_24)
                    End If
                    If b_25 Then
                        setOppTotal(rang, e + 1, maxLen_25, dOriginal_25, dEvaluate_25, dGuarantee_25)
                    End If
                    If b_26 Then
                        setOppTotal(rang, f + 1, maxLen_26, dOriginal_26, dEvaluate_26, dGuarantee_26)
                    End If
                    If b_2m Then
                        setOppTotal(rang, g + 1, maxLen_2m, dOriginal_2m, dEvaluate_2m, dGuarantee_2m)
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '����ԭֵ������ֵ��������
    Private Function setOpp(ByVal rang As Excel.Range, ByVal count As Integer, ByVal strSerial As String, _
                ByVal strItemType As String, ByVal strOriginal As String, ByVal strEvaluate As String, _
                ByVal strGuarantee As String, ByVal flag As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim maxLen As Integer
        ds = New frmOppGuarantee().getOppGuaranteeDetail(strProjectCode, strSerial, strItemType)
        j = ds.Tables("opposite_guarantee_detail").Rows.Count
        maxLen = j

        If flag = "false" Then
            rang.Range(rang.Item(count - 1, 1), rang.Item(count - 1, maxLen + 3)).Merge()
            Dim rg As Excel.Range = rang.Range(rang.Item(count, 1), rang.Item(count, maxLen + 3))
            rg.Interior.ColorIndex = 34 '��ɫ
            rg.Font.ColorIndex = 32 'ǳ����ɫ
            rg.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            rang.Item(count, maxLen + 1) = "ԭֵ"
            rang.Item(count, maxLen + 2) = "������ֵ"

            rang.Item(count, maxLen + 3) = "������"

            For j = 0 To j - 1

                dr = ds.Tables("opposite_guarantee_detail").Rows(j)
                Dim itemName As String = dr.Item("item_name").ToString()
                Dim itemValue As String = dr.Item("item_value").ToString()
                rang.Item(count, j + 1) = itemName

                'Try
                '    If InStr(itemName, "(%)", CompareMethod.Text) > 0 Then
                '        rang.Item(count + 1, j + 1).NumberFormat = "0.00%"
                '        rang.Item(count + 1, j + 1) = CType(itemValue, Double)
                '    ElseIf InStr(itemName, "��)", CompareMethod.Text) > 0 Then
                '        rang.Item(count + 1, j + 1).NumberFormat = "#,##0.00"
                '        rang.Item(count + 1, j + 1) = itemValue
                '    ElseIf InStr(itemName, "(YYYY/MM/DD)", CompareMethod.Text) > 0 Then
                '        Dim strYear As String = Year(itemValue)
                '        Dim strMonth As String = Month(itemValue)
                '        rang.Item(count + 1, j + 1) = strYear + strMonth
                '    Else
                '        rang.Item(count + 1, j + 1) = itemValue
                '    End If
                'Catch
                '    rang.Item(count + 1, j + 1) = itemValue
                'End Try
                rang.Item(count + 1, j + 1) = itemvalue
            Next

            rang.Item(count + 1, maxLen + 1).NumberFormat = "#,##0.00"
            rang.Item(count + 1, maxLen + 2).NumberFormat = "#,##0.00"
            rang.Item(count + 1, maxLen + 3).NumberFormat = "#,##0.00"
            rang.Item(count + 1, maxLen + 1) = strOriginal
            rang.Item(count + 1, maxLen + 2) = strEvaluate
            rang.Item(count + 1, maxLen + 3) = strGuarantee
        Else
            For j = 0 To j - 1

                dr = ds.Tables("opposite_guarantee_detail").Rows(j)

                Dim itemName As String = dr.Item("item_name").ToString()
                Dim itemValue As String = dr.Item("item_value").ToString()
                'Try
                '    If InStr(itemName, "(%)", CompareMethod.Text) > 0 Then
                '        rang.Item(count, j + 1).NumberFormat = "0.00%"
                '        rang.Item(count, j + 1) = CType(itemValue, Double)
                '    ElseIf InStr(itemName, "��)", CompareMethod.Text) > 0 Then
                '        rang.Item(count, j + 1).NumberFormat = "#,##0.00"
                '        rang.Item(count, j + 1) = itemValue
                '    ElseIf InStr(itemName, "(YYYY/MM/DD)", CompareMethod.Text) > 0 Then
                '        Dim strYear As String = Year(itemValue)
                '        Dim strMonth As String = Month(itemValue)
                '        rang.Item(count, j + 1) = strYear + strMonth
                '    Else
                '        rang.Item(count, j + 1) = itemValue
                '    End If
                'Catch
                '    rang.Item(count, j + 1) = itemValue
                'End Try
                rang.Item(count, j + 1) = itemvalue

            Next

            rang.Item(count, maxLen + 1).NumberFormat = "#,##0.00"
            rang.Item(count, maxLen + 2).NumberFormat = "#,##0.00"
            rang.Item(count, maxLen + 3).NumberFormat = "#,##0.00"
            rang.Item(count, maxLen + 1) = strOriginal
            rang.Item(count, maxLen + 2) = strEvaluate
            rang.Item(count, maxLen + 3) = strGuarantee
        End If

        Return maxLen
    End Function
    '
    '���������м���ϼ�ֵ
    '
    Private Sub setOppTotal(ByVal rang As Excel.Range, ByVal count As Integer, ByVal maxLen As Integer, _
            ByVal dOriginal As Double, ByVal dEvaluate As Double, ByVal dGuarantee As Double)
        rang.Item(count, 1) = "�ϼ�"
        rang.Item(count, maxLen + 1).NumberFormat = "#,##0.00"
        rang.Item(count, maxLen + 2).NumberFormat = "#,##0.00"
        rang.Item(count, maxLen + 3).NumberFormat = "#,##0.00"
        rang.Item(count, maxLen + 1) = dOriginal
        rang.Item(count, maxLen + 2) = dEvaluate
        rang.Item(count, maxLen + 3) = dGuarantee
    End Sub
    '
    '������Ŀ���벢�뿪�����ʱ��������ҵ����
    '
    Private Sub txtCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strCode As String
        strCode = Me.txtCode.Text.Trim()
        If Not gWs Is Nothing Then
            If strCode.Length = 9 Then
                Dim dsProject As DataSet
                Dim dsCorporation As DataSet
                Dim drProject As DataRow
                Dim drCorporation As DataRow
                Dim strSql As String
                Dim strCorpCode, strCorpName As String
                Dim i As Integer
                strSql = "{project_code='" & strCode & "'}"
                dsProject = gWs.GetProjectInfo(strSql)
                i = dsProject.Tables("project").Rows.Count
                If i > 0 Then
                    Me.btnImport.Enabled = True
                    drProject = dsProject.Tables("project").Rows(0)
                    With drProject
                        If Not .Item("corporation_code") Is System.DBNull.Value Then
                            strCorpCode = .Item("corporation_code")
                            strSql = "{corporation_code='" & strCorpCode & "'}"
                            dsCorporation = gWs.GetcorporationInfo(strSql, "null")
                            i = dsCorporation.Tables("corporation").Rows.Count
                            If i > 0 Then
                                drCorporation = dsCorporation.Tables("corporation").Rows(0)
                                If Not drCorporation.Item("corporation_name") Is System.DBNull.Value Then
                                    strCorpName = drCorporation.Item("corporation_name")
                                    Me.txtName.Text = strCorpName
                                Else
                                    Me.txtName.Text = ""
                                End If
                            End If
                        End If
                    End With
                Else
                    Me.btnImport.Enabled = False
                    Me.txtName.Text = ""
                End If
            Else
                Me.btnImport.Enabled = False
                Me.txtName.Text = ""
            End If
        End If
    End Sub
    'KeyPress�¼�
    Private Sub frmImportDataToExcel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub

    'qxd add 2003-11-3
    'ת��string��ֵΪ1/10000��stringֵ
    '����ֵ���ͣ�string
    Private Function changedStringToTenThousand(ByVal strValue As String)
        Try
            If strValue Is Nothing Then
                Return "0.00"
            Else
                Dim d As Double
                Dim str As String

                If IsNumeric(strValue) Then
                    d = CType(strValue, Double) / 10000.0
                    d = Math.Round(d, 0)
                    str = d.ToString
                    Return str
                Else
                    Return strValue
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

    End Sub
End Class
