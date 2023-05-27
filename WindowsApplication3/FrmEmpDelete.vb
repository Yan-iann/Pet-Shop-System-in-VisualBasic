Imports IBM.Data.DB2
Public Class FrmEmpDelete
    Private PetshopConn As Common.DbConnection

    Private Sub FrmEmpDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.BtnDelete.Enabled = False
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

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim DeleteStr As String
            Dim CmdDelete As DB2Command
            Dim Delete As Integer

            Delete = MsgBox("Are you sure you want to delete the employee info of '" & Me.DTGEmp.CurrentRow.Cells(1).Value & "' ?", vbQuestion + vbYesNo + vbDefaultButton2, "Delete Confirmation")
            If Delete = vbYes Then
                DeleteStr = "delete from employee where empid = '" & Me.TxtEmpID.Text & "'"
                CmdDelete = New DB2Command(DeleteStr, PetshopConn)
                CmdDelete.ExecuteNonQuery()
                MessageBox.Show("Employee Info Deleted", "Delete Employee Info")
                Me.TxtEmpID.Enabled = True
                Call RefreshGrid()
                Call ClearFunction()
                Call NoEntry()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DTGEmp_MouseUp(sender As Object, e As MouseEventArgs) Handles DTGEmp.MouseUp
        Me.TxtEmpId.Text = Me.DTGEmp.CurrentRow.Cells(0).Value
        Me.TxtLName.Text = Me.DTGEmp.CurrentRow.Cells(1).Value
        Me.TxtFName.Text = Me.DTGEmp.CurrentRow.Cells(2).Value
        Me.TxtPosition.Text = Me.DTGEmp.CurrentRow.Cells(3).Value
        Me.TxtPhone.Text = Me.DTGEmp.CurrentRow.Cells(4).Value
        Me.TxtEmpAdd.Text = Me.DTGEmp.CurrentRow.Cells(5).Value

        Me.BtnDelete.Enabled = True

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

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmMenuManagement.Show()
        Me.Close()
    End Sub
End Class