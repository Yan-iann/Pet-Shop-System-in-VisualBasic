
Public Class FrmMenuCashier
    Private PurchaseConn As Common.DbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPurchases_Click(sender As Object, e As EventArgs) Handles BtnPurchases.Click

        Dim ViewPurchases As New FrmDgvPurchases
        ViewPurchases.Show()

    End Sub

    Private Sub BtnItemsBought_Click(sender As Object, e As EventArgs) Handles BtnItemsBought.Click

        Dim ViewItemsBought As New FrmViewProductsSold
        ViewItemsBought.Show()
    End Sub

    Private Sub BtnNewPurchase_Click(sender As Object, e As EventArgs) Handles BtnNewPurchase.Click

        Dim ViewNewPurchase As New FrmNewPurchase
        ViewNewPurchase.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim ViewAddProd As New FrmProdAdd
        ViewAddProd.Show()
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim ViewUpdateProd As New FrmProdUpdate
        ViewUpdateProd.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnProduct.Click
        Dim ViewProdList As New FrmViewProd
        ViewProdList.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginInfo.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmFeePay.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmViewPaidFees.Show()
    End Sub
End Class
