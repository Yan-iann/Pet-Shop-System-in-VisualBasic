Imports IBM.Data.DB2
Public Class FrmCustomer
    Private PetshopConn As Common.DbConnection
    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            Me.BtnRegister.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        PetshopConn.Close()
        FrmMenuClerk.Show()
        Me.Close()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Try
            Dim CustId As String
            Dim CustName As String
            Dim CustAdd As String
            Dim CustPhone As String
            Dim InsertCustStr As String
            Dim CmdCustInsert As DB2Command

            CustId = Me.TxtCustomerId.Text
            CustName = Me.TxtCustomerName.Text
            CustAdd = Me.TxtCustomerAdd.Text
            CustPhone = Me.TxtCustomerPhone.Text
            InsertCustStr = "insert into customer values('" & CustId & "','" & CustName & "', '" & CustAdd & "','" & CustPhone & "')"
            CmdCustInsert = New DB2Command(InsertCustStr, PetshopConn)
            CmdCustInsert.ExecuteNonQuery()
            MessageBox.Show("Customer successfully registered", "Customer Registration")
            Call RefreshDataGrid()
            Call ClearCustFunction()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearCustFunction()
        Me.TxtCustomerId.Clear()
        Me.TxtCustomerName.Clear()
        Me.TxtCustomerAdd.Clear()
        Me.TxtCustomerPhone.Clear()
        Me.Label1.Focus()
    End Sub

    Private Sub RefreshDataGrid()
        Dim RdrPetshop As DB2DataReader
        Dim CmdRetCustomer As DB2Command
        Dim SelectCustStr As String
        Dim Row As String()

        SelectCustStr = "select * from customer"
        CmdRetCustomer = New DB2Command(SelectCustStr, PetshopConn)
        RdrPetshop = CmdRetCustomer.ExecuteReader
        Me.DTGCustomer.Rows.Clear()
        While RdrPetshop.Read
            Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2), RdrPetshop.GetString(3)}
            DTGCustomer.Rows.Add(Row)
        End While
        RdrPetshop.Close()
    End Sub

    Private Sub Entry()
        If (Me.TxtCustomerId.Text <> "") And (Me.TxtCustomerName.Text <> "") And (Me.TxtCustomerAdd.Text <> "") And (Me.TxtCustomerPhone.Text <> "") Then
            Me.BtnRegister.Enabled = True
        Else
            Me.BtnRegister.Enabled = False
        End If
    End Sub

    Private Sub TxtCustomerID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCustomerId.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerId.TextChanged
        Call Entry()
    End Sub

    
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Call RefreshDataGrid()
    End Sub

    Private Sub TxtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerName.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtCustomerAdd_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerAdd.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtCustomerPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCustomerPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCustomerPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerPhone.TextChanged
        Call Entry()
    End Sub

    Private Sub DTGCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGCustomer.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class