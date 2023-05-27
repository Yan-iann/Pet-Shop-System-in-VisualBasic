Public Class FrmMenuManagement

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewEmployee As New FrmEmployee
        NewEmployee.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim EditEmployee As New FrmEmpEdit
        EditEmployee.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim DeleteEmployee As New FrmEmpDelete
        DeleteEmployee.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginInfo.Show()
        Me.Close()
    End Sub

    Private Sub FrmMenuManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class