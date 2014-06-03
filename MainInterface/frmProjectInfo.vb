

Public Class frmProjectInfo
    Inherits MainInterface.frmBasicproject

    Private ws As htfServer.Service1 = gWs
    Private strUser As String = UserName
    Friend strTaskID As String   '����ID
    Friend arrTask As ArrayList

    Private strProjectCode As String
    Private index() As Integer   'added by hute 03-10-08 ���Լ�¼ÿ�еķ��յȼ�

    Public Event TaskCommit()

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

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
    Friend WithEvents btnEntery As System.Windows.Forms.Button
    Friend WithEvents btnRollBack As System.Windows.Forms.Button
    Public WithEvents btnQuery As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProjectInfo))
        Me.btnEntery = New System.Windows.Forms.Button()
        Me.btnRollBack = New System.Windows.Forms.Button()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Visible = True
        '
        'project_group
        '
        Me.project_group.Visible = True
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnEntery.Location = New System.Drawing.Point(352, 392)
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Size = New System.Drawing.Size(72, 24)
        Me.btnEntery.TabIndex = 2
        Me.btnEntery.Text = "����(&T)"
        '
        'btnRollBack
        '
        Me.btnRollBack.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.btnRollBack.Location = New System.Drawing.Point(56, 392)
        Me.btnRollBack.Name = "btnRollBack"
        Me.btnRollBack.Size = New System.Drawing.Size(72, 24)
        Me.btnRollBack.TabIndex = 3
        Me.btnRollBack.Text = "����(&R)"
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQuery.Location = New System.Drawing.Point(240, 392)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(72, 24)
        Me.btnQuery.TabIndex = 6
        Me.btnQuery.Text = "�鿴(&L)"
        '
        'frmProjectInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 435)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.project_group, Me.btnExit, Me.btnQuery, Me.btnRollBack, Me.btnEntery})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectInfo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    '
    '˫��DataGrid
    '
    Private Sub dgQueryResult_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgQueryResult.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Dim index As Integer
        Dim strCorpName As String
        Dim strWorkFlow As String
        Dim strApplyTool As String
        Dim i As Int16
        Try
            index = Me.dgQueryResult.CurrentRowIndex()
            If index < 0 Then
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If
            strProjectCode = Me.dgQueryResult.Item(index, 0)
            strCorpName = Me.dgQueryResult.Item(index, 1)

            If strProjectCode = "" Then
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            For i = 0 To Me.arrTask.Count / 3 - 1
                If arrTask(3 * i).toupper = strProjectCode.ToUpper Then
                    strWorkFlow = arrTask(3 * i + 1)
                    strApplyTool = arrTask(3 * i + 2)
                    'MsgBox(arrApplyTool(2 * i + 1))
                    Exit For
                End If
            Next

            If strTaskID = "ReviewMeetingPlan" Or strTaskID = "PlanSignature" Then
                strProjectCode = ""
                For i = 0 To Me.arrTask.Count / 3 - 1
                    strProjectCode = strProjectCode & arrTask(3 * i) & ","
                Next
                strProjectCode = strProjectCode.Substring(0, strProjectCode.Length - 1)
            End If

            strApplyTool = "MainInterface." & strApplyTool
            Dim t As System.Type = System.Type.GetType(strApplyTool)
            Dim frmApply As IApplyTool = Activator.CreateInstance(t)
            AddHandler frmApply.CommitSucceed, AddressOf project_refresh
            frmApply.OpenApplyTool(strProjectCode, strCorpName, strWorkFlow, strTaskID, Me, strUser)
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("����������ʱ����!(" & ex.Message & ")", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub frmProjectInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FilldtGrid()
            If (strTaskID.ToUpper = "ReviewAssign".ToUpper Or strTaskID.ToUpper = "RecordReviewConclusion".ToUpper Or _
             strTaskID.ToUpper = "RefundRecord".ToUpper Or strTaskID.ToUpper = "RecordProjectProcess".ToUpper Or _
             strTaskID.ToUpper = "RecordProjecTraceInfo".ToUpper Or strTaskID.ToUpper = "RecordRefundCertificate".ToUpper Or _
             strTaskID.ToUpper = "AppraiseProjectProcess".ToUpper) _
            Then
                Me.btnRollBack.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("�г���Ŀʱ������" & ex.Message & "��", "��ʾ", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    '
    '���ݾ����Task,�õ���ص���Ŀ��Ϣ;
    '
    '
    Private Function getProject(ByVal arrTaskLst As ArrayList) As DataSet
        Dim dataSetProject As DataSet
        Dim arrProject As New ArrayList()
        Dim strSql As String
        Dim i As Integer

        If arrTaskLst.Count = 0 Then
            Return Nothing
        End If

        '��ȡ��Ŀ�б�
        For i = 0 To arrTaskLst.Count / 3 - 1
            If arrTaskLst(3 * i) <> "" Then
                arrProject.Add(arrTaskLst(3 * i))
            End If
        Next

        If arrProject.Count = 0 Then
            Return Nothing
        End If

        Try
            strSql = "{projectcode in ("
            For i = 0 To arrProject.Count - 1
                If i = 0 Then
                    strSql = strSql & "'" & arrProject(i) & "'"
                Else
                    strSql = strSql & ",'" & arrProject(i) & "'"
                End If
            Next
            strSql = strSql & ") order by projectcode}"
            If ws Is Nothing Then
                ws = GetWebService(strUrl)
            End If
            'dataSetProject = ws.GetProjectInfo(strSql)
            dataSetProject = ws.GetProjectInfoEx(strSql)
            Return dataSetProject
        Catch ex As Exception
            MessageBox.Show("���ݿ����!(" & ex.Message & ")", "��ʾ", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
        End Try
    End Function

    Private Function getCorpInfo() As DataSet
        Try
            Dim dsCorp As DataSet

            If ws Is Nothing Then
                ws = GetWebService(strUrl)
            End If

            dsCorp = ws.GetcorporationInfo("%", "null")
            Return dsCorp
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub FilldtGrid()
        Try
            Dim strPhase As String

            Dim dsTmp As DataSet
            dsTmp = gWs.GetTaskProjectList(strTaskID, UserName)
            If dsTmp Is Nothing Then
                dgQueryResult.DataSource = Nothing
                dgQueryResult.DataMember = ""
                Exit Sub
            End If

            'MyBase.CreateDtGrig(dsTmp.Tables(0).TableName)
            'If dsTmp.Tables("viewproject").Rows(0).Item("phase") Is DBNull.Value Then
            '    strPhase = "����"
            'Else
            '    strPhase = dsTmp.Tables("viewproject").Rows(0).Item("phase")
            'End If

            dgQueryResult.DataSource = dsTmp
            dgQueryResult.DataMember = dsTmp.Tables(0).TableName
            '��Ŀ����ʱ����datagrid������ɫ
            If strTaskID = "AppraiseProjectProcess" Then
                GetRowColor(dsTmp)
                SetDataGridStyle(index, dgQueryResult)
            Else
                SetDataGridStyle(dgQueryResult)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    '------------------------------------------------------------------------------------
    'added by hute 03-10-08
    '����dataset�е�risk_grade�õ�ÿһ����Ҫ��ɫ���������index()
    Private Sub GetRowColor(ByVal ds As DataSet)
        Dim i As Integer

        Dim dr As DataRow
        i = 0
        ReDim index(ds.Tables(0).Rows.Count - 1)
        For Each dr In ds.Tables(0).Rows
            If dr("risk_grade") Is DBNull.Value Then
                index(i) = 0
            Else
                index(i) = Convert.ToInt16(dr("risk_grade"))
            End If
            i = i + 1
        Next
    End Sub

    '�����趨datagrid���е���ʽ
    Private Sub SetDataGridStyle(ByVal dg As DataGrid)
        Dim aColumnTextColumn As DataGridColoredTextBoxColumn '�����Զ������
        Dim ts As New DataGridTableStyle()

        Dim i As Integer
        i = 0

        ' ts.AllowSorting = False                 '���ò�������
        ts.MappingName = CType(dg.DataSource, DataSet).Tables(0).TableName

        Do While (i < 8) '�ػ����е���
            aColumnTextColumn = New DataGridColoredTextBoxColumn()
            Select Case i
                Case 0
                    aColumnTextColumn.MappingName = "ProjectCode"
                    aColumnTextColumn.HeaderText = "��Ŀ����"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 70
                    aColumnTextColumn.NullText = String.Empty
                Case 1
                    aColumnTextColumn.MappingName = "EnterpriseName"
                    aColumnTextColumn.HeaderText = "��ҵ����"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 150
                    aColumnTextColumn.NullText = String.Empty
                Case 2
                    aColumnTextColumn.MappingName = "phase"
                    aColumnTextColumn.HeaderText = "�׶�"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 40
                    aColumnTextColumn.NullText = String.Empty
                Case 3
                    aColumnTextColumn.MappingName = "Status"
                    aColumnTextColumn.HeaderText = "״̬"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 60
                    aColumnTextColumn.NullText = String.Empty
                Case 4
                    aColumnTextColumn.MappingName = "previous_task_name"
                    aColumnTextColumn.HeaderText = "ǰ������"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
                Case 5
                    aColumnTextColumn.MappingName = "previous_task_attendee"
                    aColumnTextColumn.HeaderText = "ǰ�����������"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 95
                    aColumnTextColumn.NullText = String.Empty
                Case 6
                    aColumnTextColumn.MappingName = "start_time"
                    aColumnTextColumn.HeaderText = "����ʼʱ��"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
                    aColumnTextColumn.Format = "yyyy-MM-dd HH:mm"
                Case 7
                    aColumnTextColumn.MappingName = "time_limit"
                    aColumnTextColumn.HeaderText = "��������ʱ��(�죩"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Right
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
            End Select

            ts.GridColumnStyles.Add(aColumnTextColumn)
            i = (i + 1)
        Loop

        dg.TableStyles.Clear()
        dg.TableStyles.Add(ts)
    End Sub

    '��Ϊÿ�ж���Ҫ��ʾ�����Դ��������Ϊÿһ�ж�Ӧ��ɫ�����
    Private Sub SetDataGridStyle(ByVal index() As Integer, ByVal dg As DataGrid)
        'Dim dt As DataTable
        Dim ts As New DataGridTableStyle()

        Dim aColumnTextColumn As DataGridColoredTextBoxColumn '�����Զ������
        Dim numCols As Integer
        Dim numindex() As Integer

        ts.AllowSorting = False                 '���ò�������
        'dt = CType(dg.DataSource, DataSet).Tables(0)

        ts.MappingName = CType(dg.DataSource, DataSet).Tables(0).TableName
        'numCols = dt.Columns.Count   'ͳ������

        Dim i, j As Integer
        i = 0
        j = 0

        Do While (i < 8) '�ػ����е���
            aColumnTextColumn = New DataGridColoredTextBoxColumn()
            ReDim aColumnTextColumn.ForeColor(index.Length)
            ReDim aColumnTextColumn.BackColor(index.Length)
            For j = 0 To index.Length - 1
                aColumnTextColumn.rowcollection.Add(j) 'ָ������ 
                Select Case index(j)
                    Case 0
                        aColumnTextColumn.ForeColor(j) = Color.Black
                        aColumnTextColumn.BackColor(j) = Color.Green
                    Case 1
                        aColumnTextColumn.ForeColor(j) = Color.Black
                        aColumnTextColumn.BackColor(j) = Color.Yellow
                    Case 2
                        aColumnTextColumn.ForeColor(j) = Color.Black
                        aColumnTextColumn.BackColor(j) = Color.Orange
                    Case 3
                        aColumnTextColumn.ForeColor(j) = Color.Black
                        aColumnTextColumn.BackColor(j) = Color.Red
                End Select
            Next

            'aColumnTextColumn.MappingName = dt.Table.Columns(i).ColumnName
            Select Case i
                Case 0
                    aColumnTextColumn.MappingName = "ProjectCode"
                    aColumnTextColumn.HeaderText = "��Ŀ����"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 70
                    aColumnTextColumn.NullText = String.Empty
                Case 1
                    aColumnTextColumn.MappingName = "EnterpriseName"
                    aColumnTextColumn.HeaderText = "��ҵ����"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 150
                    aColumnTextColumn.NullText = String.Empty
                Case 2
                    aColumnTextColumn.MappingName = "phase"
                    aColumnTextColumn.HeaderText = "�׶�"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 40
                    aColumnTextColumn.NullText = String.Empty
                Case 3
                    aColumnTextColumn.MappingName = "Status"
                    aColumnTextColumn.HeaderText = "״̬"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 60
                    aColumnTextColumn.NullText = String.Empty
                Case 4
                    aColumnTextColumn.MappingName = "previous_task_name"
                    aColumnTextColumn.HeaderText = "ǰ������"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
                Case 5
                    aColumnTextColumn.MappingName = "previous_task_attendee"
                    aColumnTextColumn.HeaderText = "ǰ�����������"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 95
                    aColumnTextColumn.NullText = String.Empty
                Case 6
                    aColumnTextColumn.MappingName = "start_time"
                    aColumnTextColumn.HeaderText = "����ʼʱ��"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
                    aColumnTextColumn.Format = "yyyy-MM-dd HH:mm"
                Case 7
                    aColumnTextColumn.MappingName = "time_limit"
                    aColumnTextColumn.HeaderText = "��������ʱ��(�죩"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Right
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
            End Select

            ts.GridColumnStyles.Add(aColumnTextColumn)
            i = (i + 1)
        Loop

        dg.TableStyles.Clear()
        dg.TableStyles.Add(ts)
    End Sub

    'DataGridTextBoxColumn�ļ̳��࣬����paint���ػ�DataGrid
    Public Class DataGridColoredTextBoxColumn
        Inherits DataGridTextBoxColumn  '�̳нӿ�

        Public rowcollection As New Collection() '���ڴ���кŵļ���
        Public BackColor() As Color '���ڴ�ű���ɫ�ļ��ϣ��������кż���һ��(��������������
        Public ForeColor() As Color '���ڴ��ǰ��ɫ�ļ��ϣ��������кż���һ��

        Private Function GetText(ByVal Value As Object) As String
            'Ϊ�����ػ����textbox�е����ݣ���������������ݴ������ģ���ʵ�ֻ����޹�
            If TypeOf (Value) Is System.DBNull Then
                Return NullText
            ElseIf Value Is Nothing Then
                Return ""
            Else
                Return Value.ToString
            End If
        End Function

        Protected Overloads Overrides Sub Paint(ByVal g As System.Drawing.Graphics, _
            ByVal bounds As System.Drawing.Rectangle, _
            ByVal source As System.Windows.Forms.CurrencyManager, _
            ByVal rowNum As Integer, _
            ByVal backBrush As System.Drawing.Brush, _
            ByVal foreBrush As System.Drawing.Brush, _
            ByVal alignToRight As Boolean)

            Dim text As String              '��Ĭ��ģʽ�ػ�
            text = GetText(GetColumnValueAtRow(source, rowNum)) '�����������ἰ��ȡ����
            backBrush = New SolidBrush(TextBox.BackColor) '����ɫ
            foreBrush = New SolidBrush(TextBox.ForeColor)  'ǰ��ɫ

            '��ֹ�û�û�ж��弯�ϴ�С
            ReDim Preserve BackColor(rowcollection.Count)
            ReDim Preserve ForeColor(rowcollection.Count)

            Dim i As Integer = 1 '���������ӣ���ʼ
            Do While (i <= rowcollection.Count)
                If rowNum = Val(rowcollection.Item(i)) Then  '�ж�Ҫ�����е�������
                    If Not BackColor(i - 1).IsEmpty Then 'û�ж���ľͰ�Ĭ��ɫ����
                        backBrush = New SolidBrush(BackColor(i - 1))
                    End If
                    If Not ForeColor(i - 1).IsEmpty Then 'û�ж���ľͰ�Ĭ��ɫ����
                        foreBrush = New SolidBrush(ForeColor(i - 1))
                    End If
                End If
                i += 1
            Loop

            MyBase.PaintText(g, bounds, text, backBrush, foreBrush, alignToRight)
        End Sub
    End Class

    '------------------------------------------------------------------------------------

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        dgQueryResult_DoubleClick(sender, e)
    End Sub

    Private Sub btnRollBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollBack.Click
        Dim index As Integer
        Dim strProjectCode As String
        Dim strWorkFlow, strRtn As String
        Dim i As Int16
        Try
            index = Me.dgQueryResult.CurrentRowIndex()
            If index < 0 Then
                Exit Sub
            End If
            strProjectCode = Me.dgQueryResult.Item(index, 0)

            If MsgBox("ȷ�ϻ�����Ŀ��" & strProjectCode & "����", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not strProjectCode = "" Then
                For i = 0 To Me.arrTask.Count / 3 - 1
                    If arrTask(3 * i).toupper = strProjectCode.ToUpper Then
                        strWorkFlow = arrTask(3 * i + 1)
                        Exit For
                    End If
                Next
            Else
                MsgBox("��ѡ����Ŀ,����֤��Ŀ���벻Ϊ��!", MsgBoxStyle.Exclamation, "����")
                Exit Sub
            End If
            strRtn = gWs.rollbackTask(strWorkFlow, strProjectCode, strTaskID, UserName)
            If strRtn = "1" Then
                RaiseEvent TaskCommit()
                For i = Me.arrTask.Count / 3 - 1 To 0 Step -1
                    If arrTask(3 * i).toupper = strProjectCode.ToUpper Then
                        arrTask.RemoveAt(3 * i + 2)
                        arrTask.RemoveAt(3 * i + 1)
                        arrTask.RemoveAt(3 * i)
                    End If
                Next
                FilldtGrid()  'ˢ����Ŀ�б�
                MsgBox("���˳ɹ�!", MsgBoxStyle.Information, "��ʾ")
                If Me.dgQueryResult.DataSource Is Nothing Then
                    Me.Close()
                End If
            Else
                MsgBox("����ʧ��! (" & strRtn & ")", MsgBoxStyle.Exclamation, "��ʾ")
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub


    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim index As Integer
            Dim strProjectCode, strCorpName As String
            index = Me.dgQueryResult.CurrentRowIndex()
            If index < 0 Then
                Exit Sub
            End If
            strProjectCode = Me.dgQueryResult.Item(index, 0)
            strCorpName = Me.dgQueryResult.Item(index, 1)

            Dim frmQueryProjectInfo As New frmShowProjectInfo(strProjectCode, strCorpName)
            frmQueryProjectInfo.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("�鿴��Ŀ��Ϣʱ����(" & ex.Message & ")", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub project_refresh()
        Try
            RaiseEvent TaskCommit()
            Dim i As Integer
            If strTaskID = "ReviewMeetingPlan" Or strTaskID = "PlanSignature" Then
                '��ѯ������
                Dim dsTmp As New DataSet()
                'Dim drtmp As DataRow
                '            Dim strSql As String

                dsTmp = ws.LookUpWorking(UserName)
                If dsTmp Is Nothing Then
                    Me.Close()
                    Exit Sub
                End If
                For i = Me.arrTask.Count / 3 - 1 To 0 Step -1
                    If dsTmp.Tables(0).Select("task_id='" & strTaskID & "' and project_code='" & arrTask(3 * i) & "'").Length = 0 Then
                        arrTask.RemoveAt(3 * i + 2)
                        arrTask.RemoveAt(3 * i + 1)
                        arrTask.RemoveAt(3 * i)
                    End If
                Next
            Else
                For i = Me.arrTask.Count / 3 - 1 To 0 Step -1
                    If strProjectCode = arrTask(3 * i) Then
                        arrTask.RemoveAt(3 * i + 2)
                        arrTask.RemoveAt(3 * i + 1)
                        arrTask.RemoveAt(3 * i)
                    End If
                Next
            End If
            If arrTask.Count = 0 Then
                Me.Close()
            Else
                Me.FilldtGrid()
            End If
        Catch ex As Exception
            MessageBox.Show("ˢ����Ŀʱ������" & ex.Message & "��", "��ʾ", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
        End Try
    End Sub


End Class
