

Public Class FRegisterDischargeRecord
    Inherits frmWorkLog
    Private fileType As String = "43" '�����ı�
    Private fileCode As String = "301"
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
    Friend WithEvents btnDocument As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRegisterDischargeRecord))
        Me.btnDocument = New System.Windows.Forms.Button()
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCorName
        '
        Me.txtCorName.Visible = True
        '
        'Label888
        '
        Me.Label888.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(908, 716)
        '
        'Label999
        '
        Me.Label999.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'btnCancel
        '
        Me.btnCancel.Visible = True
        '
        'grdLog
        '
        Me.grdLog.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Visible = True
        '
        'btnNew
        '
        Me.btnNew.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnModify
        '
        Me.btnModify.Visible = True
        '
        'btnDocument
        '
        Me.btnDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDocument.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDocument.Image = CType(resources.GetObject("btnDocument.Image"), System.Drawing.Bitmap)
        Me.btnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocument.ImageIndex = 5
        Me.btnDocument.ImageList = Me.ImageList1
        Me.btnDocument.Location = New System.Drawing.Point(59, 543)
        Me.btnDocument.Name = "btnDocument"
        Me.btnDocument.Size = New System.Drawing.Size(96, 24)
        Me.btnDocument.TabIndex = 13
        Me.btnDocument.Text = "�����ĵ�(&T)"
        Me.btnDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRegisterDischargeRecord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(874, 575)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnCancel, Me.btnModify, Me.btnNew, Me.btnSave, Me.btnDelete, Me.Label888, Me.Label999, Me.txtCorName, Me.txtProjectCode, Me.grdLog, Me.btnCommit, Me.btnDocument})
        Me.Name = "FRegisterDischargeRecord"
        Me.Text = "�Ǽ�׷���"
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub MakeDocument(ByVal sender As Object, ByVal e As EventArgs) Handles btnDocument.Click
        Try
            Dim ofrmDocumentManageBusiness As frmDocumentManageBusiness
            ofrmDocumentManageBusiness = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, fileType, fileCode, UserName)
            ofrmDocumentManageBusiness.AllowTransparency = False
            ofrmDocumentManageBusiness.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
End Class
