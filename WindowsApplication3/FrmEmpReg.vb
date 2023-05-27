Imports IBM.Data.DB2
Public Class FrmEmployee
    Private PetshopConn As Common.DbConnection
    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            PetshopConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            PetshopConn.Open()

            DTGEmp.ReadOnly = True
            DTGEmp.ColumnCount = 6
            With DTGEmp
                .Columns(0).Name = "Employee ID"
                .Columns(1).Name = "Last Name"
                .Columns(2).Name = "First Name"
                .Columns(3).Name = "Position"
                .Columns(4).Name = "Phone Number"
                .Columns(5).Name = "Address"
            End With
            Call RefreshGrid()
            Call NoEntry()
            Me.BtnRegLogin.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PetshopConn.Close()
        FrmMenuManagement.Show()
        Me.Close()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Call Register()
    End Sub

    Private Sub ClearFunction()
        Me.TxtEmpId.Clear()
        Me.TxtLName.Clear()
        Me.TxtFName.Clear()
        Me.TxtPosition.Clear()
        Me.TxtPhone.Clear()
        Me.TxtEmpAdd.Clear()
        Me.TxtEmpId.Focus()
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

    Private Sub NoEntry()
        Me.BtnRegister.Enabled = False
    End Sub

    Private Sub Entry()
        Me.BtnRegister.Enabled = True
    End Sub

    Private Sub TxtEmpId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmpId.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEmpId_TextChanged(sender As Object, e As EventArgs) Handles TxtEmpId.TextChanged
        Call EnableRegister()
    End Sub

    Private Sub EnableRegister()
        If (Me.TxtEmpId.Text <> "") And (Me.TxtLName.Text <> "") And (Me.TxtFName.Text <> "") And (Me.TxtPosition.Text <> "") And (Me.TxtPhone.Text <> "") And (Me.TxtEmpAdd.Text <> "") Then
            Me.BtnRegister.Enabled = True
            Me.BtnRegLogin.Enabled = True
        Else
            Me.BtnRegister.Enabled = False
            Me.BtnRegLogin.Enabled = False
        End If
    End Sub

    Private Sub TxtLName_TextChanged(sender As Object, e As EventArgs) Handles TxtLName.TextChanged
        Call EnableRegister()
    End Sub

    Private Sub TxtFName_TextChanged(sender As Object, e As EventArgs) Handles TxtFName.TextChanged
        Call EnableRegister()
    End Sub

    Private Sub TxtPosition_TextChanged(sender As Object, e As EventArgs) Handles TxtPosition.TextChanged
        Call EnableRegister()
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone.TextChanged
        Call EnableRegister()
    End Sub

    Private Sub TxtEmpAdd_TextChanged(sender As Object, e As EventArgs) Handles TxtEmpAdd.TextChanged
        Call EnableRegister()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRegLogin.Click
        Call Register()
        FrmLoginNew.Show()
    End Sub

    Private Sub Register()
        Try
            Dim Id As String
            Dim LName As String
            Dim FName As String
            Dim Pos As String
            Dim PhoneNo As String
            Dim EmpAdd As String
            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            Id = Me.TxtEmpId.Text
            LName = Me.TxtLName.Text
            FName = Me.TxtFName.Text
            Pos = Me.TxtPosition.Text
            PhoneNo = Me.TxtPhone.Text
            EmpAdd = Me.TxtEmpAdd.Text
            InsertStr = "insert into employee values('" & Id & "','" & LName & "', '" & FName & "', '" & Pos & "', '" & PhoneNo & "','" & EmpAdd & "')"
            CmdInsert = New DB2Command(InsertStr, PetshopConn)
            CmdInsert.ExecuteNonQuery()
            MessageBox.Show("Registration Successful", "New Employee")
            FrmLoginNew.TxtEmpID.Text = Id
            Call RefreshGrid()
            Call ClearFunction()
            Call NoEntry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
