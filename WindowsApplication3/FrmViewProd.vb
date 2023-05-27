Imports IBM.Data.DB2
Public Class FrmViewProd
    Dim ItemsListConn As Common.DbConnection
    Private Sub FrmViewProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemsListConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
        ItemsListConn.Open()
        Call LoadProductNames()
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

    Private Sub DgvItemsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItemsList.CellContentClick

    End Sub
End Class