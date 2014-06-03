
Public Class frmConfirmChangeManager
    Inherits MainInterface.frmConfirmItem

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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbConclusion
        '
        Me.cmbConclusion.Visible = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Visible = True
        '
        'Label11
        '
        Me.Label11.Text = "ȷ�ϸ�����Ŀ�������"
        Me.Label11.Visible = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(224, 248)
        Me.Label10.Text = "������Ŀ�������"
        Me.Label10.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(177, 312)
        Me.btnSave.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Visible = True
        '
        'txtOpinion
        '
        Me.txtOpinion.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(353, 312)
        Me.btnExit.Visible = True
        '
        'frmConfirmChangeManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(490, 343)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.btnCommit, Me.btnOpenFile, Me.btnSave, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1})
        Me.Name = "frmConfirmChangeManager"
        Me.Text = "ȷ�ϸ�����Ŀ����"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmConfirmChangeManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.strItemType = "52" : Me.strItemCode = "007" '��������ȷ�ϸ�����Ŀ�������
            Call Me.GetIniData(Me.strItemType, Me.strItemCode)
            Me.bIsFormLoad = True
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Me.OpenFile("45", "005")    '����Ŀ���������
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub txtOpinion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOpinion.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChanged = True
    End Sub

    Private Sub cmbConclusion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConclusion.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChanged = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call Me.SaveData(Me.strItemType, Me.strItemCode)
    End Sub
End Class
