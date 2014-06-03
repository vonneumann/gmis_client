

Public Class FConferenceRoom
    Inherits MainInterface.FBaseData

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FConferenceRoom))
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Visible = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageIndex = -1
        Me.btnUpdate.ImageList = Nothing
        Me.btnUpdate.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Visible = True
        '
        'FConferenceRoom
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Name = "FConferenceRoom"
        Me.Text = "�᳡����"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private style As DataGridTableStyle
    Private dsResult As dataset

    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            dsResult = gWs.FetchConfernceRoom("%")
            grdTable.SetDataBinding(dsResult, "TConferenceRoom")
            'AddHandler dsResult.Tables(0).ColumnChanged, AddressOf ColumnChanged
        Catch ex As System.Exception
            'ͳһ������
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ValidateData(ByVal dtResult As DataTable) As Boolean
        If dtResult.Select("conference_address IS NULL OR record_person IS NULL").Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "�ص���¼Ա")
            Return False
        End If
        Dim i, j, leng As Int16
        Dim rows() As DataRow = dtResult.Select("", "", DataViewRowState.CurrentRows)
        leng = rows.Length
        For i = 0 To leng - 1
            For j = i + 1 To leng - 1
                If rows(i)("conference_address") = rows(j)("conference_address") Then
                    SWDialogBox.MessageBox.Show("$1003", "�� ��")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)
            If Not dsCommit.HasChanges() Then
                Return False
            End If
            If Not ValidateData(dsCommit.Tables(0)) Then
                Return False
            End If

            Dim result As String = gWs.UpdateConfernceRoom(dsCommit.GetChanges())

            If result = "1" Then
                '�������и���
                dsCommit.AcceptChanges()

                Return True
            Else
                '��ʾ�������ķ��ش�����Ϣ
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
            End If
        Catch ex As System.Exception
            'ͳһ������
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return False
    End Function

    Private Sub FStaff_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsStaff As DataSet = gWs.GetStaff("%")

        Dim col_address As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        Dim col_person As DataGridComboBoxColumn = New DataGridComboBoxColumn()
        style = New DataGridTableStyle()
        style.MappingName = "TConferenceRoom"
        style.AllowSorting = False
        style.GridColumnStyles.AddRange(New DataGridColumnStyle() {col_address, col_person})

        col_address.MappingName = "conference_address"
        col_address.HeaderText = "�� ��"
        col_address.Width = 150
        col_address.TextBox.MaxLength = 50
        col_address.NullText = String.Empty

        col_person.MappingName = "record_person"
        col_person.HeaderText = "�����¼Ա"
        col_person.ColumnComboBox.DataSource = dsStaff.Tables("TStaff").DefaultView
        col_person.ColumnComboBox.DisplayMember = "staff_name"
        col_person.ColumnComboBox.ValueMember = "staff_name"
        col_person.NullText = String.Empty
        col_person.Width = 90

        grdTable.TableStyles.Add(style)
    End Sub


End Class
