Imports IBM.Data.DB2

Public Class FrmNewPurchase
    Private ItemsListConn As Common.DbConnection

    Private Sub FrmNewPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadProductNames()
        Call LoadToBePurchasedColumns()
        Me.BtnAdd.Enabled = False
        Me.BtnSave.Enabled = False
        Me.BtnDelete.Enabled = False
        Me.TxtTotal.Text = 0
    End Sub

    Private Sub LoadProductNames()
        Try
            Dim RdrProduct As DB2DataReader
            Dim CmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()

            ItemsListConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
            ItemsListConn.Open()

            SelectStr = "select * from product"
            CmdRetrieve = New DB2Command(SelectStr, ItemsListConn)
            RdrProduct = CmdRetrieve.ExecuteReader
            DgvItemsList.ColumnCount = 3
            With DgvItemsList
                .Columns(0).Name = "Product Name"
                .Columns(1).Name = "Available Units"
                .Columns(2).Name = "Price"
            End With

            While RdrProduct.Read
                row = New String() {RdrProduct.GetString(1), RdrProduct.GetString(2), RdrProduct.GetString(3)}
                DgvItemsList.Rows.Add(row)
            End While
            RdrProduct.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtProdName_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchProd.TextChanged
        Try
            Dim StrSearch As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim StrSearch2 As String
            Dim row As String()

            StrSearch2 = "%" + Me.TxtSearchProd.Text + "%"
            StrSearch = "select * from product where prodname like '" & StrSearch2 & "'"
            CmdSearch = New DB2Command(StrSearch, ItemsListConn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.DgvItemsList.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3)}
                Me.DgvItemsList.Rows.Add(row)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim row As String()
            Dim ProdSelected As String
            Dim ProdQty As Integer
            Dim ProdSubtotal As Decimal

            Dim StrProdSearch As String
            Dim StrProdSearch2 As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim QtyCheck As Integer

            ProdSelected = Me.DgvItemsList.CurrentRow.Cells(0).Value
            ProdQty = Me.TxtQuantity.Text
            ProdSubtotal = ProdQty * Me.DgvItemsList.CurrentRow.Cells(2).Value
            ProdSubtotal = Format(ProdSubtotal, "0.00")

            StrProdSearch2 = Me.DgvItemsList.CurrentRow.Cells(0).Value()
            StrProdSearch = "select qtyinstock from product where prodname like '" & StrProdSearch2 & "' "
            CmdSearch = New DB2Command(StrProdSearch, ItemsListConn)
            RdrSearch = CmdSearch.ExecuteReader
            RdrSearch.Read()

            QtyCheck = RdrSearch.GetValue(0)

            If QtyCheck >= ProdQty Then

                row = New String() {ProdSelected, ProdQty, ProdSubtotal}
                Me.DgvToBePurchased.Rows.Add(row)
            Else
                MessageBox.Show("'" & ProdSelected & "' only has '" & QtyCheck & "' unit/s left available", "Invalid Quantity")
            End If

            Call ComputeTotal()

            Me.TxtQuantity.Clear()
            Me.TxtSearchProd.Clear()

            If (Me.DgvToBePurchased.RowCount > 0) Then
                Me.BtnSave.Enabled = True
            End If

            Me.BtnDelete.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call AddItemsBought()
        Call AddCustPurchases()
        Me.DgvItemsList.Rows.Clear()
        Call LoadProductNames()


    End Sub

    Private Sub AddItemsBought()
        Dim CellCount As Integer
        CellCount = Me.DgvToBePurchased.RowCount
        CellCount = CellCount - 1

        Dim StrProdSearch As String
        Dim StrProdSearch2 As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim FoundProdID As Integer
        Dim QtyBought As Integer
        Dim ProdSubtotal As Decimal
        Dim IndexRow As Integer
        Dim LineNo As Integer

        Dim StrSavePurchase As String
        Dim CmdSave As DB2Command

        Try
            For index As Integer = 1 To CellCount

                IndexRow = index - 1

                StrProdSearch2 = Me.DgvToBePurchased.Rows(IndexRow).Cells(0).Value
                StrProdSearch = "select prodid from product where prodname like '" & StrProdSearch2 & "' "
                CmdSearch = New DB2Command(StrProdSearch, ItemsListConn)
                RdrSearch = CmdSearch.ExecuteReader

                RdrSearch.Read()

                FoundProdID = RdrSearch.GetValue(0)                                    'LINE ITEM - PROD ID
                QtyBought = Me.DgvToBePurchased.Rows(IndexRow).Cells(1).Value          'LINE ITEM - QTYBOUGHT
                ProdSubtotal = Me.DgvToBePurchased.Rows(IndexRow).Cells(2).Value       'LINE ITEM - SUBTOTAL
                LineNo = GenerateLineNo()


                StrSavePurchase = "insert into lineitem values('" & LineNo & "', '" & FoundProdID & "', '" & QtyBought & " ', '" & ProdSubtotal & "')"
                CmdSave = New DB2Command(StrSavePurchase, ItemsListConn)
                CmdSave.ExecuteNonQuery()

                StrSavePurchase = "update product set qtyinstock = qtyinstock - '" & QtyBought & "' where prodid = '" & FoundProdID & "' "
                CmdSave = New DB2Command(StrSavePurchase, ItemsListConn)
                CmdSave.ExecuteNonQuery()

            Next

            MessageBox.Show("Purchases have been saved", "New Purchase")
            Call ComputeTotal()
            Me.BtnSave.Enabled = False
            Me.BtnDelete.Enabled = False
            Me.DgvToBePurchased.Rows.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AddCustPurchases()
        Dim PurchaseTotal As Decimal
        Dim PurchaseNo As Integer
        Dim StrAddPurchase As String
        Dim CmdAddPurchase As DB2Command

        PurchaseTotal = Me.TxtTotal.Text

        Try
            PurchaseNo = GeneratePurchaseNo()
            StrAddPurchase = "insert into sales values('" & PurchaseNo & "', '" & PurchaseTotal & "')"
            CmdAddPurchase = New DB2Command(StrAddPurchase, ItemsListConn)
            CmdAddPurchase.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged
        Call EnableAdd()
    End Sub

    Private Sub EnableAdd()
        If (Me.TxtQuantity.Text <> "") And (Me.DgvToBePurchased.RowCount > 0) Then
            Me.BtnAdd.Enabled = True
        Else
            Me.BtnAdd.Enabled = False
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        If Me.DgvToBePurchased.SelectedRows.Count > 0 Then

            Me.DgvToBePurchased.Rows.Remove(Me.DgvToBePurchased.SelectedRows(0))
            Call ComputeTotal()

        End If

        If Me.DgvToBePurchased.Rows(0).Cells(0).Value <> "" Then
            Me.BtnDelete.Enabled = True
            Me.BtnSave.Enabled = True
        Else
            Me.BtnDelete.Enabled = False
            Me.BtnSave.Enabled = False
        End If

    End Sub

    Private Sub ComputeTotal()
        Dim Total As Decimal = 0
        Dim RowCount As Integer

        RowCount = Me.DgvToBePurchased.RowCount
        RowCount = RowCount - 1

        For index As Integer = 1 To RowCount
            Total = Total + Me.DgvToBePurchased.Rows(index - 1).Cells(2).Value
        Next
        Total = Format(Total, "0.00")
        Me.TxtTotal.Text = Total
    End Sub

    Private Sub TxtCustID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub LoadToBePurchasedColumns()
        Me.DgvToBePurchased.ColumnCount = 3
        With DgvToBePurchased
            .Columns(0).Name = "Product Name"
            .Columns(1).Name = "Quantity"
            .Columns(2).Name = "Subtotal"
        End With
    End Sub

    Function GenerateLineNo()
        Dim StrNewLineNo As String
        Dim CmdNewLineNo As DB2Command
        Dim RdrNewLineNo As DB2DataReader
        Dim NewLineNo As Integer

        Try
            StrNewLineNo = "select * from lineitem order by lineno desc fetch first row only"
            CmdNewLineNo = New DB2Command(StrNewLineNo, ItemsListConn)
            RdrNewLineNo = CmdNewLineNo.ExecuteReader
            RdrNewLineNo.Read()

            If RdrNewLineNo.HasRows Then
                NewLineNo = RdrNewLineNo.GetValue(0) + 1
            Else
                NewLineNo = 1
            End If

            Return NewLineNo
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Function

    Function GeneratePurchaseNo()
        Dim StrNewPurchaseNo As String
        Dim CmdNewPurchaseNo As DB2Command
        Dim RdrNewPurchaseNo As DB2DataReader
        Dim NewPurchaseNo As Integer

        Try
            StrNewPurchaseNo = "select * from sales order by saleno desc fetch first row only"
            CmdNewPurchaseNo = New DB2Command(StrNewPurchaseNo, ItemsListConn)
            RdrNewPurchaseNo = CmdNewPurchaseNo.ExecuteReader
            RdrNewPurchaseNo.Read()

            If RdrNewPurchaseNo.HasRows Then
                NewPurchaseNo = RdrNewPurchaseNo.GetValue(0) + 1
            Else
                NewPurchaseNo = 1
            End If

            Return NewPurchaseNo
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMenuCashier.Show()
        Me.Close()
    End Sub
End Class