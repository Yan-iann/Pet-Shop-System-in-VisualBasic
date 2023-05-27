Imports IBM.Data.DB2
Public Class FrmViewPaidFees
    Dim PetshopConn As Common.DbConnection

    Private Sub FrmViewPaidFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RdrPetshop As DB2DataReader
        Dim CmdLoadFee As DB2Command
        Dim SelectStr As String
        Dim Row As String()

        PetshopConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
        PetshopConn.Open()

        SelectStr = "select * from fee"
        CmdLoadFee = New DB2Command(SelectStr, PetshopConn)
        RdrPetshop = CmdLoadFee.ExecuteReader
        Me.DgvFees.Rows.Clear()
        DgvFees.ColumnCount = 4
        With DgvFees
            .Columns(0).Name = "Fee No."
            .Columns(1).Name = "Amount Total"
            .Columns(2).Name = "Customer ID"
            .Columns(3).Name = "Paid"
        End With

        While RdrPetshop.Read
            Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2), RdrPetshop.GetString(3)}
            DgvFees.Rows.Add(Row)
        End While
        RdrPetshop.Close()
    End Sub
End Class