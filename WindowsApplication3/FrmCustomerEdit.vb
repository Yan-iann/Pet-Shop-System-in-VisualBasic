Imports IBM.Data.DB2
Public Class FrmCustomerEdit
    Private PetshopConn As Common.DbConnection
    Private Sub FrmCustomerEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PetshopConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            PetshopConn.Open()

            DTGCustomer.ReadOnly = True
            DTGCustomer.ColumnCount = 4
            With DTGCustomer
                .Columns(0).Name = "Customer ID"
                .Columns(1).Name = "Customer Name"
                .Columns(2).Name = "Customer Address"
                .Columns(3).Name = "Customer Phone No"
            End With
            Call RefreshDataGrid()
            Call NoEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub NoEntry()
        Me.TxtCustomerId.Enabled = False
        Me.TxtCustomerName.Enabled = False
        Me.TxtCustomerAdd.Enabled = False
        Me.TxtCustomerPhone.Enabled = False
        Me.BtnUpdate.Enabled = False
    End Sub

    Private Sub Entry()
        Me.TxtCustomerId.Enabled = False
        Me.TxtCustomerName.Enabled = True
        Me.TxtCustomerAdd.Enabled = True
        Me.TxtCustomerPhone.Enabled = True
        Me.BtnUpdate.Enabled = True
    End Sub

    Private Sub DTGCustomer_MouseUp(sender As Object, e As MouseEventArgs) Handles DTGCustomer.MouseUp
        Me.TxtCustomerId.Text = Me.DTGCustomer.CurrentRow.Cells(0).Value
        Me.TxtCustomerName.Text = Me.DTGCustomer.CurrentRow.Cells(1).Value
        Me.TxtCustomerAdd.Text = Me.DTGCustomer.CurrentRow.Cells(2).Value
        Me.TxtCustomerPhone.Text = Me.DTGCustomer.CurrentRow.Cells(3).Value
        Call Entry()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim VId As String
            Dim VName As String
            Dim VAdd As String
            Dim VPhone As String

            Dim UpdateStr As String
            Dim CmdUpdate As DB2Command

            VId = Me.TxtCustomerId.Text
            VName = Me.TxtCustomerName.Text
            VAdd = Me.TxtCustomerAdd.Text
            VPhone = Me.TxtCustomerPhone.Text

            UpdateStr = "update customer set custname = '" & VName & "', custaddress = '" & VAdd & "', custphoneno = '" & VPhone & "' where custid = '" & VId & "'"
            CmdUpdate = New DB2Command(UpdateStr, PetshopConn)
            CmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Customer Info Updated", "Update Customer Info")
            Call RefreshDataGrid()
            Call ClearCustFunction()
            Call NoEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearCustFunction()
        Me.TxtCustomerId.Clear()
        Me.TxtCustomerName.Clear()
        Me.TxtCustomerAdd.Clear()
        Me.TxtCustomerPhone.Clear()
        Me.TxtCustomerId.Focus()
        Me.TxtSearch.Clear()
    End Sub

    Private Sub RefreshDataGrid()
        Dim RdrPetshop As DB2DataReader
        Dim CmdRetCustomer As DB2Command
        Dim SelectCustStr As String
        Dim row As String()

        SelectCustStr = "select * from customer"
        CmdRetCustomer = New DB2Command(SelectCustStr, PetshopConn)
        RdrPetshop = CmdRetCustomer.ExecuteReader
        Me.DTGCustomer.Rows.Clear()
        While RdrPetshop.Read
            row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2), RdrPetshop.GetString(3)}
            DTGCustomer.Rows.Add(row)
        End While
        RdrPetshop.Close()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            Dim SearchStr As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim SearchStr2 As String
            Dim row As String()

            SearchStr2 = "%" + Me.TxtSearch.Text + "%"
            SearchStr = "Select * from customer where custname like  '" & SearchStr2 & "'"
            CmdSearch = New DB2Command(SearchStr, PetshopConn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.DTGCustomer.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3)}
                Me.DTGCustomer.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Call RefreshDataGrid()
        FrmMenuClerk.Show()
        Me.Close()
    End Sub

    Private Sub TextEntry()
        If (Me.TxtCustomerId.Text <> "") And (Me.TxtCustomerName.Text <> "") And (Me.TxtCustomerAdd.Text <> "") And (Me.TxtCustomerPhone.Text <> "") Then
            Me.BtnUpdate.Enabled = True
        Else
            Me.BtnUpdate.Enabled = False
        End If
    End Sub

    Private Sub TxtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerName.TextChanged
        Call TextEntry()
    End Sub

    Private Sub TxtCustomerAdd_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerAdd.TextChanged
        Call TextEntry()
    End Sub

    Private Sub TxtCustomerPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCustomerPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCustomerPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerPhone.TextChanged
        Call TextEntry()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class