Public Class frmPledgeRegistryAffirm
    Inherits MainInterface.frmWardAffirm

    Public Sub New()
        MyBase.New()
        Me.Text = "��Ѻ����ȷ��"
    End Sub

    Public Sub New(ByVal projectCode As String, ByVal isOnlyView As Boolean)
        MyBase.new(projectCode, isOnlyView)
        Me.Text = "��Ѻ����ȷ��"
    End Sub
End Class