Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FLoanForm
	Inherits FBaseData

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
	Friend csNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend csName As System.Windows.Forms.DataGridTextBoxColumn
	Friend tsLoanForm As System.Windows.Forms.DataGridTableStyle

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.tsLoanForm = New System.Windows.Forms.DataGridTableStyle()
		Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.SuspendLayout()
		'
		'tsLoanForm
		'
		Me.tsLoanForm.DataGrid = Me.grdTable
		Me.tsLoanForm.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName})
		Me.tsLoanForm.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsLoanForm.MappingName = "TLoanForm"
		'
		'csNo
		'
		Me.csNo.Format = ""
		Me.csNo.FormatInfo = Nothing
		Me.csNo.HeaderText = "��  ��"
		Me.csNo.MappingName = "loan_form_code"
		Me.csNo.Width = 75
		'
		'csName
		'
		Me.csName.Format = ""
		Me.csName.FormatInfo = Nothing
		Me.csName.HeaderText = "��ʽ"
		Me.csName.MappingName = "loan_form"
		Me.csName.Width = 210
		'
		'FLoanForm
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(512, 333)
		Me.Name = "FLoanForm"
		Me.Text = "��ʽ����"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetLoanForm("%")
			grdTable.SetDataBinding(dsResult, "TLoanForm")
		Catch ex As System.Exception
			'ͳһ������
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Public Overrides Function Update() As Boolean
		Try
			Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)

            If dsCommit Is Nothing OrElse (Not dsCommit.HasChanges()) Then
                Return False
            End If

            Dim result As String = gWs.UpdateLoanForm(dsCommit.GetChanges())

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

	Private Sub FLoanForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		grdTable.TableStyles.Add(Me.tsLoanForm)
	End Sub
End Class
