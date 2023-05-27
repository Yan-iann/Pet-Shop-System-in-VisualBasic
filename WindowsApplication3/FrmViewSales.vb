Imports IBM.Data.DB2

Public Class FrmDgvPurchases
    Private PurchaseConn As Common.DbConnection
    Private Sub FrmDgvPurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim RdrPurchases As DB2DataReader
            Dim CmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()

            PurchaseConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
            PurchaseConn.Open()

            SelectStr = "select * from sales"
            CmdRetrieve = New DB2Command(SelectStr, PurchaseConn)
            RdrPurchases = CmdRetrieve.ExecuteReader
            DgvPurchases.ColumnCount = 2
            With DgvPurchases
                .Columns(0).Name = "Sale No."
                .Columns(1).Name = "Total"
            End With

            While RdrPurchases.Read
                row = New String() {RdrPurchases.GetString(0), RdrPurchases.GetString(1)}
                DgvPurchases.Rows.Add(row)
            End While
            RdrPurchases.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DgvPurchases_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPurchases.CellContentClick

    End Sub
End Class