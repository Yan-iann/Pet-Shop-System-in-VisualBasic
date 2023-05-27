Imports IBM.Data.DB2

Public Class FrmProdUpdate
    Dim ItemsListConn As Common.DbConnection
    Private Sub FrmUpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemsListConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
        ItemsListConn.Open()
        Call LoadProductNames()
        Me.TxtProdID.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnDelete.Enabled = False
    End Sub

    Private Sub LoadProductNames()
        Try
            Dim RdrProduct As DB2DataReader
            Dim CmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()

            SelectStr = "select * from product"
            CmdRetrieve = New DB2Command(SelectStr, ItemsListConn)
            RdrProduct = CmdRetrieve.ExecuteReader
            DgvItemsList.ColumnCount = 4
            With DgvItemsList
                .Columns(0).Name = "Product ID"
                .Columns(1).Name = "Product Name"
                .Columns(2).Name = "Available Units"
                .Columns(3).Name = "Price"
            End With

            While RdrProduct.Read
                row = New String() {RdrProduct.GetString(0), RdrProduct.GetString(1), RdrProduct.GetString(2), RdrProduct.GetString(3)}
                DgvItemsList.Rows.Add(row)
            End While

            RdrProduct.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DgvItemsList_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvItemsList.MouseUp

        Me.TxtProdID.Text = Me.DgvItemsList.CurrentRow.Cells(0).Value
        Me.TxtProdName.Text = Me.DgvItemsList.CurrentRow.Cells(1).Value
        Me.TxtQtyInStock.Text = Me.DgvItemsList.CurrentRow.Cells(2).Value
        Me.TxtProdPrice.Text = Me.DgvItemsList.CurrentRow.Cells(3).Value

        Me.TxtProdID.Enabled = False


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim ProdID As Integer
        Dim ProdName As String
        Dim ProdQty As Integer
        Dim ProdPrice As Decimal

        Dim StrUpdateProd As String
        Dim CmdUpdateProd As DB2Command

        Try
            ProdID = Me.TxtProdID.Text
            ProdName = Me.TxtProdName.Text
            ProdQty = Me.TxtQtyInStock.Text
            ProdPrice = Me.TxtProdPrice.Text

            StrUpdateProd = "update product set prodname = '" & ProdName & "',qtyinstock = '" & ProdQty & "',prodprice =  '" & ProdPrice & "' where prodid = '" & ProdID & "'"
            CmdUpdateProd = New DB2Command(StrUpdateProd, ItemsListConn)
            CmdUpdateProd.ExecuteNonQuery()

            MessageBox.Show("Product information is updated", "Update Product Info")

            Me.TxtProdID.Clear()
            Me.TxtProdName.Clear()
            Me.TxtQtyInStock.Clear()
            Me.TxtProdPrice.Clear()

            Me.DgvItemsList.Rows.Clear()
            Call LoadProductNames()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub EnableButton()
        If (Me.TxtProdID.Text <> "") And (Me.TxtProdName.Text <> "") And (Me.TxtQtyInStock.Text <> "") And (Me.TxtProdPrice.Text <> "") Then
            Me.BtnUpdate.Enabled = True
            Me.BtnDelete.Enabled = True
        Else
            Me.BtnUpdate.Enabled = False
            Me.BtnDelete.Enabled = False
        End If
    End Sub

    Private Sub TxtProdID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProdID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtProdID_TextChanged(sender As Object, e As EventArgs) Handles TxtProdID.TextChanged
        Call EnableButton()

    End Sub

    Private Sub TxtProdName_TextChanged(sender As Object, e As EventArgs) Handles TxtProdName.TextChanged
        Call EnableButton()
    End Sub

    Private Sub TxtProdPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProdPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtProdPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtProdPrice.TextChanged
        Call EnableButton()
    End Sub

    Private Sub TxtQtyInStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQtyInStock.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtQtyInStock_TextChanged(sender As Object, e As EventArgs) Handles TxtQtyInStock.TextChanged
        Call EnableButton()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim StrDeleteProd As String
        Dim CmdDeleteProd As DB2Command
        Dim DeleteProdID As Integer
        Dim answer As Integer

        Try

            answer = MsgBox("Are you sure you want to delete product '" & Me.DgvItemsList.CurrentRow.Cells(1).Value & "'", vbQuestion + vbYesNo + vbDefaultButton2, "Delete Confirmation")

            If answer = vbYes Then
                DeleteProdID = Me.DgvItemsList.CurrentRow.Cells(0).Value
                StrDeleteProd = "delete from product where prodid = '" & DeleteProdID & "'"
                CmdDeleteProd = New DB2Command(StrDeleteProd, ItemsListConn)

                CmdDeleteProd.ExecuteNonQuery()

                MessageBox.Show("Product is Deleted", "Delete Product Info")
                Me.DgvItemsList.Rows.Clear()
                Call LoadProductNames()

                Me.TxtProdID.Clear()
                Me.TxtProdName.Clear()
                Me.TxtQtyInStock.Clear()
                Me.TxtProdPrice.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FrmMenuCashier.Show()
        Me.Close()
    End Sub
End Class