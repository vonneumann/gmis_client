Public Class frmBasic
    Inherits System.Windows.Forms.Form
    Implements IApplyTool

    '
    'Author quexd
    'Date Created  2003-4-5
    'Modificate Date
    '
    Private strProjectCode As String '��Ŀ����
    Private strCorporatioName As String '��ҵ����
    Private strWorkFlowID As String '������ID 
    Private strTaskID As String '����ID
    Private strUser As String '�û���
    Private strRoleID As String '��ɫid

    Public isCommitConfirm As Boolean = True

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
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBasic))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(480, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "�� ��(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmBasic
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 435)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBasic"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "���޸ı���"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    'ʵ�ֽӿ�
    '
    Private Event CommitSucceed() Implements IApplyTool.CommitSucceed
    '�����¼�
    Public Sub raiseCommitSucceed()
        RaiseEvent CommitSucceed()
    End Sub
    Public Sub OpenApplyTool(ByVal strProjectCode As String, ByVal strCorpName As String, ByVal strWorkFlowId As String, ByVal strTaskId As String, ByVal frmOwner As Form, ByVal User As String) Implements IApplyTool.OpenApplyTool
        Try
            Me.strProjectCode = strProjectCode
            Me.strCorporatioName = strCorpName
            Me.strWorkFlowID = strWorkFlowId
            Me.strTaskID = strTaskId
            Me.strUser = User

            Me.AllowTransparency = False
            Me.Owner = frmOwner
            Me.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    Public Sub OpenApplyTool(ByVal strProjectCode As String, ByVal strCorpName As String, ByVal strWorkFlowID As String, ByVal strTaskID As String, ByVal frmOwner As Form, ByVal User As String, ByVal taskName As String, ByVal roleID As String) Implements IApplyTool.OpenApplyTool
        Try
            Me.strProjectCode = strProjectCode
            Me.strCorporatioName = strCorpName
            Me.strWorkFlowID = strWorkFlowID
            Me.strTaskID = strTaskID
            Me.strUser = User
            Me.strRoleID = roleID

            Me.AllowTransparency = False
            Me.Owner = frmOwner
            Me.StartPosition = FormStartPosition.CenterScreen 'qxd add 2004-3-8
            If Not taskName.Trim = "" Then
                Me.Text = taskName
            End If
            Me.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '�����Ŀ����project_code
    '
    Public Function getProjectCode() As String
        Return Me.strProjectCode
    End Function
    '
    '�����ҵ����
    '
    Public Function getCorporationName() As String
        Return Me.strCorporatioName
    End Function
    '
    '��ù�����ID
    '
    Public Function getWorkFlowID() As String
        Return Me.strWorkFlowID
    End Function
    '
    '�������ID
    '
    Public Function getTaskID() As String
        Return Me.strTaskID
    End Function
    '
    '����û���
    '
    Public Function getUser() As String
        Return Me.strUser
    End Function

    '����û���
    '
    Public Function getRoleID() As String
        Return Me.strRoleID
    End Function
    '
    '��ȡ��Ŀ�׶�phase
    '
    Public Function getPhase(ByVal strCode As String) As String

        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetProjectInfo("{project_code='" & strCode & "'}")
            i = ds.Tables("project").Rows.Count
            If i > 0 Then
                If Not ds.Tables("project").Rows(0).Item("phase") Is System.DBNull.Value Then
                    Return ds.Tables("project").Rows(0).Item("phase")
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            'MsgBox("��ȡ��Ŀ�׶γ���!", MsgBoxStyle.Critical, "��ʾ")
            SWDialogBox.MessageBox.Show("$Login106")
        End Try
    End Function
    '
    '���ûس����¼�ΪTAB��
    '
    Public Sub setEnterKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            CType(sender, Form).SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If
    End Sub

End Class
