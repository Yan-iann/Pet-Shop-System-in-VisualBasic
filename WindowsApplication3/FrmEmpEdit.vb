Imports IBM.Data.DB2
Public Class FrmEmpEdit
    Private PetshopConn As Common.DbConnection
    Private Sub Edit_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PetshopConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            PetshopConn.Open()
            DTGEmp.ReadOnly = True
            DTGEmp.ColumnCount = 6
            With DTGEmp
                .Columns(0).Name = "Employee Id"
                .Columns(1).Name = "Last Name"
                .Columns(2).Name = "First Name"
                .Columns(3).Name = "Position"
                .Columns(4).Name = "Employee Phone Number"
                .Columns(5).Name = "Employee Address"
            End With
            Call RefreshGrid()
            Call NoEntry()
            Me.BtnUpdateLogin.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub NoEntry()
        Me.TxtEmpID.Enabled = False
        Me.TxtLName.Enabled = False
        Me.TxtFName.Enabled = False
        Me.TxtPhone.Enabled = False
        Me.TxtEmpAdd.Enabled = False
        Me.TxtPosition.Enabled = False
        Me.BtnUpdate.Enabled = False

    End Sub

    Private Sub Entry()
        Me.TxtEmpID.Enabled = False
        Me.TxtLName.Enabled = True
        Me.TxtFName.Enabled = True
        Me.TxtPosition.Enabled = True
        Me.TxtEmpAdd.Enabled = True
        Me.TxtPhone.Enabled = True

        Me.BtnUpdate.Enabled = True
    End Sub

    Private Sub DTGEmp_MouseUp(sender As Object, e As MouseEventArgs) Handles DTGEmp.MouseUp
        Me.TxtEmpId.Text = Me.DTGEmp.CurrentRow.Cells(0).Value
        Me.TxtLName.Text = Me.DTGEmp.CurrentRow.Cells(1).Value
        Me.TxtFName.Text = Me.DTGEmp.CurrentRow.Cells(2).Value
        Me.TxtPosition.Text = Me.DTGEmp.CurrentRow.Cells(3).Value
        Me.TxtPhone.Text = Me.DTGEmp.CurrentRow.Cells(4).Value
        Me.TxtEmpAdd.Text = Me.DTGEmp.CurrentRow.Cells(5).Value
        Call Entry()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Call EmpUpdate()
    End Sub

    Private Sub ClearFunction()
        Me.TxtEmpId.Clear()
        Me.TxtLName.Clear()
        Me.TxtFName.Clear()
        Me.TxtPosition.Clear()
        Me.TxtPhone.Clear()
        Me.TxtEmpAdd.Clear()
        Me.TxtSearch.Clear()
        Me.TxtSearch.Focus()
    End Sub

    Private Sub RefreshGrid()
        Dim RdrPetshop As DB2DataReader
        Dim CmdRetEmployee As DB2Command
        Dim SelectStr As String
        Dim Row As String()

        SelectStr = "select * from employee"
        CmdRetEmployee = New DB2Command(SelectStr, PetshopConn)
        RdrPetshop = CmdRetEmployee.ExecuteReader
        Me.DTGEmp.Rows.Clear()
        While RdrPetshop.Read
            Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2), RdrPetshop.GetString(3), RdrPetshop.GetString(4), RdrPetshop.GetString(5)}
            DTGEmp.Rows.Add(Row)
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
            SearchStr = "Select * from employee where lname like  '" & SearchStr2 & "'"
            CmdSearch = New DB2Command(SearchStr, PetshopConn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.DTGEmp.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                Me.DTGEmp.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Call RefreshGrid()
        FrmMenuManagement.Show()
        Me.Close()
    End Sub

    Private Sub EnableUpdate()
        If (Me.TxtEmpID.Text <> "") And (Me.TxtLName.Text <> "") And (Me.TxtFName.Text <> "") And (Me.TxtPosition.Text <> "") And (Me.TxtPhone.Text <> "") And (Me.TxtEmpAdd.Text <> "") Then
            Me.BtnUpdate.Enabled = True
            Me.BtnUpdateLogin.Enabled = True
        Else
            Me.BtnUpdate.Enabled = False
            Me.BtnUpdateLogin.Enabled = False
        End If
    End Sub

    Private Sub TxtLName_TextChanged(sender As Object, e As EventArgs) Handles TxtLName.TextChanged
        Call EnableUpdate()
    End Sub

    Private Sub TxtFName_TextChanged(sender As Object, e As EventArgs) Handles TxtFName.TextChanged
        Call EnableUpdate()
    End Sub

    Private Sub TxtPosition_TextChanged(sender As Object, e As EventArgs) Handles TxtPosition.TextChanged
        Call EnableUpdate()
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone.TextChanged
        Call EnableUpdate()
    End Sub

    Private Sub TxtEmpAdd_TextChanged(sender As Object, e As EventArgs) Handles TxtEmpAdd.TextChanged
        Call EnableUpdate()
    End Sub

    Private Sub EmpUpdate()
        Try
            Dim VId As String
            Dim VLName As String
            Dim VFName As String
            Dim VPos As String
            Dim VPhone As String
            Dim VAdd As String

            Dim UpdateStr As String
            Dim CmdUpdate As DB2Command

            VId = Me.TxtEmpID.Text
            VLName = Me.TxtLName.Text
            VFName = Me.TxtFName.Text
            VPos = Me.TxtPosition.Text
            VPhone = Me.TxtPhone.Text
            VAdd = Me.TxtEmpAdd.Text

            UpdateStr = "update employee set lname = '" & VLName & "', fname = '" & VFName & "',position = '" & VPos & "', empphoneno = '" & VPhone & "', empaddress = '" & VAdd & "' where empid = '" & VId & "'"
            CmdUpdate = New DB2Command(UpdateStr, PetshopConn)
            CmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Employee Info Updated", "Update Employee Info")
            FrmLoginNew.TxtEmpID.Text = VId
            Call RefreshGrid()
            Call ClearFunction()
            Call NoEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnUpdateLogin_Click(sender As Object, e As EventArgs) Handles BtnUpdateLogin.Click
        Call EmpUpdate()
        FrmLoginNew.Show()
    End Sub
End Class