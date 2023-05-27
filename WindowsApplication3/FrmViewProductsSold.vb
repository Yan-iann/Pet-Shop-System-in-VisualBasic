Imports IBM.Data.DB2
Public Class FrmViewProductsSold
    Private ItemsBoughtConn As Common.DbConnection
    Private Sub FrmItemsBought_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim RdrItemsBought As DB2DataReader
            Dim CmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()

            ItemsBoughtConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
            ItemsBoughtConn.Open()

            SelectStr = "select * from lineitem"
            CmdRetrieve = New DB2Command(SelectStr, ItemsBoughtConn)
            RdrItemsBought = CmdRetrieve.ExecuteReader
            DgvItemsBought.ColumnCount = 4
            With DgvItemsBought
                .Columns(0).Name = "Line No."
                .Columns(1).Name = "Product ID"
                .Columns(2).Name = "Quantity Bought"
                .Columns(3).Name = "Subtotal"
            End With

            While RdrItemsBought.Read
                row = New String() {RdrItemsBought.GetString(0), RdrItemsBought.GetString(1), RdrItemsBought.GetString(2), RdrItemsBought.GetString(3)}
                DgvItemsBought.Rows.Add(row)
            End While
            RdrItemsBought.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DgvItemsBought_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItemsBought.CellContentClick

    End Sub
End Class