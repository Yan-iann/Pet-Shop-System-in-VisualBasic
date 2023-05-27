Imports IBM.Data.DB2

Public Class FrmFeeUpdate
    Dim PetshopConn As Common.DbConnection
    Private Sub FrmFeeUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PetshopConn = New DB2Connection("server=localhost;database=petshop;" + "uid=db2admin;password=db2admin")
        PetshopConn.Open()


        Me.TxtAmount.Clear()
        Me.TxtCustID.Clear()
        Me.TxtCustName.Clear()
        Me.TxtFeeNo.Clear()
        Call LoadFees()
        Call EnableBtn()
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


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim FeeNo As Integer
        Dim TotalAmount As Decimal

        Dim StrFeeUpdate As String
        Dim CmdFeeUpdate As DB2Command

        Try
            FeeNo = Me.TxtFeeNo.Text
            TotalAmount = Me.TxtAmount.Text

            StrFeeUpdate = "update fee set totalamount = '" & TotalAmount & "' where feeno = '" & FeeNo & "' "
            CmdFeeUpdate = New DB2Command(StrFeeUpdate, PetshopConn)
            CmdFeeUpdate.ExecuteNonQuery()

            MessageBox.Show("Fee information is updated", "Update Fee Info")

            Me.TxtAmount.Clear()
            Me.TxtCustID.Clear()
            Me.TxtCustName.Clear()
            Me.TxtFeeNo.Clear()

            Me.DgvFees.Rows.Clear()
            Call LoadFees()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim StrDeleteFee As String
        Dim CmdDeleteFee As DB2Command
        Dim DeleteFeeNo As Integer
        Dim answer As Integer

        Try
            answer = MsgBox("Are you sure you want to delete the fee info of customer ID '" & Me.DgvFees.CurrentRow.Cells(2).Value & "'", vbQuestion + vbYesNo + vbDefaultButton2, "Delete Confirmation")

            If answer = vbYes Then
                DeleteFeeNo = Me.DgvFees.CurrentRow.Cells(0).Value
                StrDeleteFee = "delete from fee where feeno = '" & DeleteFeeNo & "'"
                CmdDeleteFee = New DB2Command(StrDeleteFee, PetshopConn)
                CmdDeleteFee.ExecuteNonQuery()

                MessageBox.Show("Fee information is deleted", "Delete Fee Info")
                Me.DgvFees.Rows.Clear()
                Call LoadFees()

                Me.TxtAmount.Clear()
                Me.TxtCustID.Clear()
                Me.TxtCustName.Clear()
                Me.TxtFeeNo.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FrmMenuVet.Show()
        Me.Close()
    End Sub

    Private Sub EnableBtn()
        If (Me.TxtAmount.Text <> "") And (Me.TxtCustID.Text <> "") And (Me.TxtCustName.Text <> "") And (Me.TxtFeeNo.Text <> "") Then
            Me.BtnUpdate.Enabled = True
            Me.BtnDelete.Enabled = True
        Else
            Me.BtnUpdate.Enabled = False
            Me.BtnDelete.Enabled = False
        End If
    End Sub

    Private Sub TxtFeeNo_TextChanged(sender As Object, e As EventArgs) Handles TxtFeeNo.TextChanged
        Call EnableBtn()
    End Sub

    Private Sub TxtCustID_TextChanged(sender As Object, e As EventArgs) Handles TxtCustID.TextChanged
        Call EnableBtn()
    End Sub

    Private Sub TxtCustName_TextChanged(sender As Object, e As EventArgs) Handles TxtCustName.TextChanged
        Call EnableBtn()
    End Sub

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.TextChanged
        Call EnableBtn()
    End Sub
End Class