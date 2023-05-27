Imports IBM.Data.DB2
Public Class FrmPetEdit
    Private PetshopConn As Common.DbConnection
    Private Sub FrmPetEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.TxtPetId.Enabled = False

        Me.TxtPetName.Enabled = False
        Me.TxtAnimalType.Enabled = False
        Me.TxtOwnerId.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.TxtOwnerName.Enabled = False
    End Sub

    Private Sub Entry()
        Me.TxtPetId.Enabled = False

        Me.TxtPetName.Enabled = True
        Me.TxtAnimalType.Enabled = True
        Me.TxtOwnerId.Enabled = True
        Me.BtnUpdate.Enabled = True
    End Sub

    Private Sub ClearFunction()
        Me.TxtPetId.Clear()
        Me.TxtPetName.Clear()
        Me.TxtAnimalType.Clear()
        Me.TxtOwnerId.Clear()
        Me.TxtPetId.Focus()
        Me.TxtSearch.Clear()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FrmMenuClerk.Show()

        Me.Close()
    End Sub

    Private Sub DTGPet_MouseUp(sender As Object, e As MouseEventArgs) Handles DTGPet.MouseUp
        Try
            Dim StrOwner As String
            Dim CmdOwner As DB2Command
            Dim RdrOwner As DB2DataReader
            Dim Owner As String

            Me.TxtPetId.Text = Me.DTGPet.CurrentRow.Cells(0).Value
            Me.TxtPetName.Text = Me.DTGPet.CurrentRow.Cells(1).Value
            Me.TxtAnimalType.Text = Me.DTGPet.CurrentRow.Cells(2).Value
            Me.TxtOwnerId.Text = Me.DTGPet.CurrentRow.Cells(3).Value

            StrOwner = "select * from customer where custid = '" & Me.TxtOwnerId.Text & "'"
            CmdOwner = New DB2Command(StrOwner, PetshopConn)
            RdrOwner = CmdOwner.ExecuteReader
            RdrOwner.Read()
            Owner = RdrOwner.GetString(1)

            RdrOwner.Close()
            Call Entry()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim VId As String
            Dim VName As String
            Dim VAnimalType As String
            Dim VOwnerId As String

            Dim UpdateStr As String
            Dim CmdUpdate As DB2Command

            VId = Me.TxtPetId.Text
            VName = Me.TxtPetName.Text
            VAnimalType = Me.TxtAnimalType.Text
            VOwnerId = Me.TxtOwnerId.Text

            UpdateStr = "update pet set petname = '" & VName & "', animaltype = '" & VAnimalType & "', ownerid = '" & VOwnerId & "' where petid = '" & VId & "' "
            CmdUpdate = New DB2Command(UpdateStr, PetshopConn)
            CmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Pet Info Updated", "Update Pet Info")
            Call RefreshGrid()
            Call ClearFunction()
            Call NoEntry()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            Dim SearchStr As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim SearchStr2 As String
            Dim row As String()

            SearchStr2 = "%" + Me.TxtSearch.Text + "%"
            SearchStr = "Select * from pet where petname like  '" & SearchStr2 & "'"
            CmdSearch = New DB2Command(SearchStr, PetshopConn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.DTGPet.Rows.Clear()
            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3)}
                Me.DTGPet.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EnableUpdate()
        If (Me.TxtPetName.Text <> "") And (Me.TxtAnimalType.Text <> "") And (Me.TxtOwnerId.Text <> "") Then
            Me.BtnUpdate.Enabled = True
        Else
            Me.BtnUpdate.Enabled = False
        End If
    End Sub

    Private Sub TxtPetName_TextChanged(sender As Object, e As EventArgs) Handles TxtPetName.TextChanged
        Call EnableUpdate()
    End Sub

    Private Sub TxtAnimalType_TextChanged(sender As Object, e As EventArgs) Handles TxtAnimalType.TextChanged
        Call EnableUpdate()
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

            If Me.TxtOwnerName.Text <> "No Customer Found" And Me.TxtOwnerId.Text <> "" Then
                Me.BtnUpdate.Enabled = True
            Else
                Me.BtnUpdate.Enabled = False
            End If
        End If
    End Sub

    Private Sub TxtOwnerName_TextChanged(sender As Object, e As EventArgs) Handles TxtOwnerName.TextChanged

    End Sub

    Private Sub TxtPetId_TextChanged(sender As Object, e As EventArgs) Handles TxtPetId.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class