Imports IBM.Data.DB2
Public Class FrmFeePay
    Dim PetshopConn As Common.DbConnection
    Private Sub FrmFeePay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PetshopConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
        PetshopConn.Open()

        Call LoadFees()
        Me.BtnPay.Enabled = False
    End Sub

    Private Sub LoadFees()
        Try
            Dim RdrPetshop As DB2DataReader
            Dim CmdLoadFee As DB2Command
            Dim SelectStr As String
            Dim Row As String()

            SelectStr = "select * from fee where paid = 'N'"
            CmdLoadFee = New DB2Command(SelectStr, PetshopConn)
            RdrPetshop = CmdLoadFee.ExecuteReader
            Me.DgvFees.Rows.Clear()
            DgvFees.ColumnCount = 3
            With DgvFees
                .Columns(0).Name = "Fee No."
                .Columns(1).Name = "Amount Total"
                .Columns(2).Name = "Customer ID"
            End With

            While RdrPetshop.Read
                Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2)}
                DgvFees.Rows.Add(Row)
            End While
            RdrPetshop.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub DgvFees_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvFees.CellMouseUp
        Me.TxtFeeNo.Text = Me.DgvFees.CurrentRow.Cells(0).Value
        Me.TxtCustID.Text = Me.DgvFees.CurrentRow.Cells(2).Value
        Call FindCust()
        Me.TxtAmount.Text = Me.DgvFees.CurrentRow.Cells(1).Value

        Me.BtnPay.Enabled = True
    End Sub

    Private Sub FindCust()
        Try
            Dim RdrPetshop As DB2DataReader
            Dim CmdFindCust As DB2Command
            Dim FindStr As String

            FindStr = "select * from customer where custid = '" & Me.DgvFees.CurrentRow.Cells(2).Value & "'"
            CmdFindCust = New DB2Command(FindStr, PetshopConn)
            RdrPetshop = CmdFindCust.ExecuteReader
            RdrPetshop.Read()

            Me.TxtCustName.Text = RdrPetshop.GetString(1)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FrmMenuCashier.Show()
        Me.Close()
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        Dim FeeNo As Integer
        Dim StrPaid As String
        Dim CmdPaid As DB2Command


        FeeNo = Me.TxtFeeNo.Text

        StrPaid = "update fee set paid = 'Y' where feeno = '" & FeeNo & "'"
        CmdPaid = New DB2Command(StrPaid, PetshopConn)
        CmdPaid.ExecuteNonQuery()

        MessageBox.Show("Fee is now paid", "Fee Payment")

        Me.TxtAmount.Clear()
        Me.TxtCustID.Clear()
        Me.TxtCustName.Clear()
        Me.TxtFeeNo.Clear()

        Me.DgvFees.Rows.Clear()
        Call LoadFees()

        Me.BtnPay.Enabled = False
    End Sub
End Class