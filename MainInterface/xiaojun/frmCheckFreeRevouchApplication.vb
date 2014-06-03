

Public Class frmCheckFreeRevouchApplication
    Inherits MainInterface.frmFreeRevouchApplication

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
        Me.TabPage4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage4
        '
        Me.TabPage4.Text = "��˽������������"
        '
        'GroupBox8
        '
        Me.GroupBox8.Visible = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Visible = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Visible = True
        '
        'TabPage3
        '
        Me.TabPage3.Text = "���(ȷ��)��Ŀ��ֹ����"
        '
        'TabControl1
        '
        Me.TabControl1.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'frmCheckFreeRevouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(530, 471)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabControl1, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1})
        Me.Name = "frmCheckFreeRevouchApplication"
        Me.Text = "��˽������������"
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As New DataSet()

    Protected Overrides Sub IniFormType()
        Me.LockGroupBox2() : Me.LockGroupBox3()
        Me.LockGroupBox4()
        Me.LockGroupBox5() : GroupBox5.Visible = True
        Me.LockGroupBox6() : GroupBox6.Visible = True
        Me.LockGroupBox7()
        GroupBox8.Enabled = True : GroupBox8.Visible = True
        btnRefundSave.Enabled = False : btnTerminateSave.Enabled = False
        btnBuildRefundReport.Enabled = False : Me.btnCheckProjectTerminateReportSave.Enabled = False
    End Sub

    Protected Overrides Sub GetRevouchApplicationData()
        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='56' and item_code='004'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("create_date") Is System.DBNull.Value Then
                    Me.dtpFreeRevouchApplicationTime.Value = .Item("create_date")
                Else
                    Me.dtpFreeRevouchApplicationTime.Value = gWs.GetSysTime()
                End If
                If Not .Item("create_person") Is System.DBNull.Value Then
                    Me.txtFreeRevouchApplicationPerson.Text = .Item("create_person")
                Else
                    Me.txtFreeRevouchApplicationPerson.Text = ""
                End If
                If Not .Item("content") Is System.DBNull.Value Then
                    Me.txtFreeRevouchApplicationOpinion.Text = .Item("content")
                Else
                    Me.txtFreeRevouchApplicationOpinion.Text = ""
                End If
            End With
        Else
            Me.dtpFreeRevouchApplicationTime.Value = gWs.GetSysTime()
            Me.txtFreeRevouchApplicationPerson.Text = Me.strUserID
        End If

        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='56' and item_code='005'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("create_date") Is System.DBNull.Value Then
                    Me.dtpChekcRevouchApplicationTime.Value = .Item("create_date")
                Else
                    Me.dtpChekcRevouchApplicationTime.Value = gWs.GetSysTime()
                End If
                If Not .Item("create_person") Is System.DBNull.Value Then
                    Me.txtCheckRevouchApplicationPerson.Text = .Item("create_person")
                Else
                    Me.txtCheckRevouchApplicationPerson.Text = Me.strUserID
                End If
                If Not .Item("content") Is System.DBNull.Value Then
                    Me.txtCheckRevouchApplicationOpinion.Text = .Item("content")
                Else
                    Me.txtCheckRevouchApplicationOpinion.Text = ""
                End If
                If Not .Item("conclusion") Is System.DBNull.Value Then
                    Me.cmbCheckRevouchApplicationConclusion.Text = .Item("conclusion")
                Else
                    Me.cmbCheckRevouchApplicationConclusion.Text = ""
                End If
            End With
        Else
            Me.dtpChekcRevouchApplicationTime.Value = gWs.GetSysTime()
            Me.txtCheckRevouchApplicationPerson.Text = Me.strUserID
        End If
        Call Me.GetCheckRevouchApplicationOpinion()
    End Sub

    Private Sub GetCheckRevouchApplicationOpinion()
        ds = Me.GetFinishedFlag(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not ds Is Nothing Then
            If Not ds.Tables(0).Rows.Count = 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbCheckRevouchApplicationConclusion.Items.Add(ds.Tables(0).Rows(i).Item("transfer_condition"))
                Next
            End If
        End If
    End Sub

    '��Ҫ�����า�Ǹ÷�����
    Protected Overrides Function SaveFreeRevouchApplication() As String
        'If Me.cmbCheckRevouchApplicationConclusion.Text = "" Then
        '    MessageBox.Show("��ѡ����˽��۽��в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return Nothing
        'End If
        Dim ds As New DataSet()
        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='56' and item_code='005'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                .Item("project_code") = Me.strProjectCode
                .Item("item_type") = "56"
                .Item("item_code") = "005"
                .Item("content") = Me.txtCheckRevouchApplicationOpinion.Text.Trim()
                .Item("conclusion") = Me.cmbCheckRevouchApplicationConclusion.Text.Trim()
                .Item("create_date") = Me.dtpChekcRevouchApplicationTime.Value()
                .Item("create_person") = Me.strUserID
            End With
        Else
            ds = gWs.GetProjectOpinionByProjectNo("null")
            Dim NewRow As DataRow = ds.Tables(0).NewRow()
            With NewRow
                .Item("project_code") = Me.strProjectCode
                .Item("item_type") = "56"
                .Item("item_code") = "005"
                .Item("content") = Me.txtCheckRevouchApplicationOpinion.Text.Trim()
                .Item("conclusion") = Me.cmbCheckRevouchApplicationConclusion.Text.Trim()
                .Item("create_date") = Me.dtpChekcRevouchApplicationTime.Value()
                .Item("create_person") = Me.strUserID
            End With
            ds.Tables(0).Rows.Add(NewRow)
        End If
        Return gWs.UpdateProjectOpinion(ds)
    End Function

    Protected Overrides Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.isCommitConfirm = True Then
            'Modified by Micahel
            'MessageBox.Show("�Ƿ�ȷ���ύ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If SWDialogBox.MessageBox.Show("?1000", "ȷ���ύ") = DialogResult.No Then
                Return
            End If
        End If
        If Me.cmbCheckRevouchApplicationConclusion.Text = "" Then
            'Modified by Micahel
            'MessageBox.Show("��ѡ����˽��۽��в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "��˽���")
            Return
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Try
            If Me.bIsTextChange Then
                Me.strResult = Me.SaveFreeRevouchApplication()
                If Me.strResult <> "1" Then
                    'Modified by Micahel
                    ' MessageBox.Show("��˽�������������������ʧ�ܣ�" + strResult, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SWDialogBox.MessageBox.Show("*999", "��˽�������������������ʧ��", Me.strResult, "")
                    Return
                End If
                Me.bIsFormLoadFreeRevouchApplication = False : Me.bIsTextChange = False
            End If
            Call Me.CommitWorkFlow(Me.cmbCheckRevouchApplicationConclusion.Text.Trim(), Me)
        Catch ex As Exception
            'Modified by Micahel
            'MessageBox.Show(ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

End Class
