Imports IBM.Data.DB2
Public Class FrmFees
    Private PetShopConn As DB2Connection
    Private Sub FrmFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PetShopConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            PetShopConn.Open()

            DgvCustomers.ColumnCount = 2
            With DgvCustomers
                .Columns(0).Name = "Customer ID"
                .Columns(1).Name = "Name"
            End With

            DgvFees.ColumnCount = 3
            With DgvFees
                .Columns(0).Name = "Fee No."
                .Columns(1).Name = "Amount"
                .Columns(2).Name = "Customer ID"
            End With

            Call LoadCustomers()
            Call LoadFees()
            Call BtnEnabled()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LoadCustomers()
        Try
            Dim RdrPetshop As DB2DataReader
            Dim CmdLoadCust As DB2Command
            Dim SelectStr As String
            Dim Row As String()

            SelectStr = "select * from customer"
            CmdLoadCust = New DB2Command(SelectStr, PetShopConn)
            RdrPetshop = CmdLoadCust.ExecuteReader
            Me.DgvCustomers.Rows.Clear()
            While RdrPetshop.Read
                Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1)}
                DgvCustomers.Rows.Add(Row)
            End While
            RdrPetshop.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LoadFees()
        Try
            Dim RdrPetshop As DB2DataReader
            Dim CmdLoadFee As DB2Command
            Dim SelectStr As String
            Dim Row As String()

            SelectStr = "select * from fee"
            CmdLoadFee = New DB2Command(SelectStr, PetShopConn)
            RdrPetshop = CmdLoadFee.ExecuteReader
            Me.DgvFees.Rows.Clear()
            While RdrPetshop.Read
                Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2)}
                DgvFees.Rows.Add(Row)
            End While
            RdrPetshop.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim FeeNo As Integer
        Dim TotalAmount As Decimal
        Dim CustID As Integer
        Dim InsertStr As String
        Dim CmdInsert As DB2Command

        Try

            FeeNo = GenerateFeeNo()
            TotalAmount = Me.TxtTotal.Text
            CustID = Me.TxtCustID.Text

            InsertStr = "insert into fee values('" & FeeNo & "', '" & TotalAmount & "', '" & CustID & "','N')"
            CmdInsert = New DB2Command(InsertStr, PetShopConn)
            CmdInsert.ExecuteNonQuery()
            MessageBox.Show("Submitted Successfully", "New Fee")
            Call ClearField()
            Call BtnEnabled()
            Call LoadFees()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function GenerateFeeNo()
        Dim StrNewFeeNo As String
        Dim CmdFeeNo As DB2Command
        Dim RdrFeeNo As DB2DataReader
        Dim NewFeeNo As Integer

        Try
            StrNewFeeNo = "select * from fee order by feeno desc fetch first row only"
            CmdFeeNo = New DB2Command(StrNewFeeNo, PetShopConn)
            RdrFeeNo = CmdFeeNo.ExecuteReader
            RdrFeeNo.Read()

            If RdrFeeNo.HasRows Then
                NewFeeNo = RdrFeeNo.GetValue(0) + 1
            Else
                NewFeeNo = 1
            End If

            Return NewFeeNo
        Catch ex As Exception

        End Try
    End Function

    Private Sub ClearField()
        Me.TxtCustID.Clear()
        Me.TxtCustName.Clear()
        Me.TxtTotal.Clear()
    End Sub

    Private Sub BtnEnabled()
        If (Me.TxtCustID.Text <> "") And (Me.TxtCustName.Text <> "") And (Me.TxtTotal.Text <> "") Then
            Me.BtnSave.Enabled = True
        Else
            Me.BtnSave.Enabled = False
        End If
    End Sub

    Private Sub TxtCustID_TextChanged(sender As Object, e As EventArgs) Handles TxtCustID.TextChanged
        Call BtnEnabled()
    End Sub

    Private Sub TxtCustName_TextChanged(sender As Object, e As EventArgs) Handles TxtCustName.TextChanged
        Call BtnEnabled()
    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged
        Call BtnEnabled()
    End Sub

    Private Sub DgvCustomers_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvCustomers.MouseUp
        Try
            If Me.DgvCustomers.CurrentRow.Cells(0).Value <> "" Then
                Me.TxtCustID.Text = Me.DgvCustomers.CurrentRow.Cells(0).Value
                Me.TxtCustName.Text = Me.DgvCustomers.CurrentRow.Cells(1).Value
            End If
            Me.TxtTotal.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FrmMenuVet.Show()
        Me.Close()
    End Sub
End Class