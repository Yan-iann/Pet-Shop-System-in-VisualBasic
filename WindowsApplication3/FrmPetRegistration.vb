Imports IBM.Data.DB2
Public Class FrmPetRegistration
    Private PetshopConn As Common.DbConnection
    Private Sub FrmPetRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            PetshopConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            PetshopConn.Open()

            DTGPet.ReadOnly = True
            DTGPet.ColumnCount = 4

            With DTGPet
                .Columns(0).Name = "Pet ID"
                .Columns(1).Name = "Pet Name"
                .Columns(2).Name = "Animal Type"
                .Columns(3).Name = "Owner ID"
            End With

            Call RefreshGrid()
            Call NoEntry()
            Me.TxtOwnerName.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshGrid()
        Dim RdrPetshop As DB2DataReader
        Dim CmdRetPet As DB2Command
        Dim SelectStr As String
        Dim Row As String()

        SelectStr = "select * from pet"
        CmdRetPet = New DB2Command(SelectStr, PetshopConn)
        RdrPetshop = CmdRetPet.ExecuteReader
        Me.DTGPet.Rows.Clear()
        While RdrPetshop.Read
            Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2), RdrPetshop.GetString(3)}
            DTGPet.Rows.Add(Row)
        End While
        RdrPetshop.Close()
    End Sub

    Private Sub NoEntry()
        Me.BtnRegister.Enabled = False
    End Sub

    Private Sub Entry()
        If (Me.TxtPetId.Text <> "") And (Me.TxtPetName.Text <> "") And (Me.TxtAnimalType.Text <> "") And (Me.TxtOwnerId.Text <> "") And (Me.TxtOwnerName.Text <> "No Customer Found") Then
            Me.BtnRegister.Enabled = True
        Else
            Me.BtnRegister.Enabled = False
        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        PetshopConn.Close()
        FrmMenuClerk.Show()
        Me.Close()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Try
            Dim Id As String
            Dim PetName As String
            Dim AnimalType As String
            Dim OwnerId As String
            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            Id = Me.TxtPetId.Text
            PetName = Me.TxtPetName.Text
            AnimalType = Me.TxtAnimalType.Text
            OwnerId = Me.TxtOwnerId.Text
            InsertStr = "insert into pet values('" & Id & "','" & PetName & "', '" & AnimalType & "','" & OwnerId & "')"
            CmdInsert = New DB2Command(InsertStr, PetshopConn)
            CmdInsert.ExecuteNonQuery()
            MessageBox.Show("Pet Registered", "New Pet")
            Call RefreshGrid()
            Call ClearFunction()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearFunction()
        Me.TxtPetId.Clear()
        Me.TxtPetName.Clear()
        Me.TxtAnimalType.Clear()
        Me.TxtOwnerId.Clear()
        Me.TxtPetId.Focus()
        Me.TxtOwnerName.Clear()
    End Sub

    Private Sub TxtPetId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPetId.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPetId_TextChanged(sender As Object, e As EventArgs) Handles TxtPetId.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtPetName_TextChanged(sender As Object, e As EventArgs) Handles TxtPetName.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtAnimalType_TextChanged(sender As Object, e As EventArgs) Handles TxtAnimalType.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtOwnerId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOwnerId.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtOwnerId_TextChanged(sender As Object, e As EventArgs) Handles TxtOwnerId.TextChanged
        Dim OwnerID As Integer
        Dim StrSearchOwnerID As String
        Dim CmdSearchOwnerID As DB2Command
        Dim RdrSearchOwnerID As DB2DataReader

        If Me.TxtOwnerId.Text <> "" Then
            OwnerID = Me.TxtOwnerId.Text
            StrSearchOwnerID = "select custname from customer where custid = '" & OwnerID & "' "
            CmdSearchOwnerID = New DB2Command(StrSearchOwnerID, PetshopConn)
            RdrSearchOwnerID = CmdSearchOwnerID.ExecuteReader

            RdrSearchOwnerID.Read()
            If RdrSearchOwnerID.HasRows Then
                Me.TxtOwnerName.Text = RdrSearchOwnerID.GetString(0)
            Else
                Me.TxtOwnerName.Text = "No Customer Found"
            End If

            Call Entry()
        End If
    End Sub
End Class