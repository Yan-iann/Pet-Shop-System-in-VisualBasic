Imports IBM.Data.DB2

Public Class FrmProdAdd
    Private AddConn As Common.DbConnection

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim ProdID As Integer
            Dim ProdName As String
            Dim ProdQty As Integer
            Dim ProdPrice As Decimal

            Dim StrAdd As String
            Dim CmdAdd As DB2Command

            ProdID = Me.TxtProdID.Text
            ProdName = Me.TxtProdName.Text
            ProdQty = Me.TxtQtyInStock.Text
            ProdPrice = Me.TxtProdPrice.Text

            StrAdd = "insert into product values('" & ProdID & "', '" & ProdName & "', '" & ProdQty & "', '" & ProdPrice & "')"
            CmdAdd = New DB2Command(StrAdd, AddConn)
            CmdAdd.ExecuteNonQuery()

            MessageBox.Show("Product Added", "Add New Product")

            Me.TxtProdID.Clear()
            Me.TxtProdName.Clear()
            Me.TxtQtyInStock.Clear()
            Me.TxtProdPrice.Clear()
            Me.DgvItemsList.Rows.Clear()
            Call LoadProductNames()

            Call GenerateNewID()


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub FrmAddProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
        AddConn.Open()
        Call LoadProductNames()
        Call GenerateNewID()

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

    Private Sub EnableButton()
        If (Me.TxtProdID.Text <> "") And (Me.TxtProdName.Text <> "") And (Me.TxtQtyInStock.Text <> "") And (Me.TxtProdPrice.Text <> "") Then
            Me.BtnAdd.Enabled = True
        Else
            Me.BtnAdd.Enabled = False
        End If
    End Sub

    Private Sub GenerateNewID()
        Dim StrNewProdID As String
        Dim CmdNewProdID As DB2Command
        Dim RdrNewProdID As DB2DataReader
        Dim NewID As Integer

        Try
            StrNewProdID = "select prodid from product order by prodid desc fetch first row only"
            CmdNewProdID = New DB2Command(StrNewProdID, AddConn)
            RdrNewProdID = CmdNewProdID.ExecuteReader
            RdrNewProdID.Read()

            If RdrNewProdID.HasRows Then
                NewID = RdrNewProdID.GetValue(0) + 1
            Else
                NewID = 1
            End If

            Me.TxtProdID.Text = NewID


            Me.BtnAdd.Enabled = False
            Me.TxtProdName.Select()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub LoadProductNames()
        Try
            Dim RdrProduct As DB2DataReader
            Dim CmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()

            SelectStr = "select * from product"
            CmdRetrieve = New DB2Command(SelectStr, AddConn)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMenuCashier.Show()
        Me.Close()
    End Sub
End Class