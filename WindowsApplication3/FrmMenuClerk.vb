Public Class FrmMenuClerk

    Private Sub BtnCustNew_Click(sender As Object, e As EventArgs) Handles BtnCustNew.Click
        Dim ViewCustNew As New FrmCustomer
        ViewCustNew.Show()
        Me.Close()
    End Sub

    Private Sub BtnCustEdit_Click(sender As Object, e As EventArgs) Handles BtnCustEdit.Click
        Dim ViewCustEdit As New FrmCustomerEdit
        ViewCustEdit.Show()
        Me.Close()
    End Sub

    Private Sub BtnCustDelete_Click(sender As Object, e As EventArgs) Handles BtnCustDelete.Click
        Dim ViewCustDelete As New FrmCustomerDelete
        ViewCustDelete.Show()
        Me.Close()
    End Sub

    Private Sub BtnPetNew_Click(sender As Object, e As EventArgs) Handles BtnPetNew.Click
        Dim ViewPetNew As New FrmPetRegistration
        ViewPetNew.Show()
        Me.Close()
    End Sub

    Private Sub BtnPetEdit_Click(sender As Object, e As EventArgs) Handles BtnPetEdit.Click
        Dim ViewPetEdit As New FrmPetEdit
        ViewPetEdit.Show()
        Me.Close()
    End Sub

    Private Sub BtnPetDelete_Click(sender As Object, e As EventArgs) Handles BtnPetDelete.Click
        Dim ViewPetDelete As New FrmPetDelete
        ViewPetDelete.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginInfo.Show()
        Me.Close()
    End Sub

    Private Sub FrmMenuClerk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class