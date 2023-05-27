Imports IBM.Data.DB2
Public Class FrmAnimalDiagnose
    Private PetshopConn As Common.DbConnection
    Private Sub FrmAnimalDiagnose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            PetshopConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            PetshopConn.Open()

            DTGDiagnosisData.ReadOnly = True
            DTGPetData.ReadOnly = True

            DTGPetData.ColumnCount = 4
            With DTGPetData
                .Columns(0).Name = "Pet ID"
                .Columns(1).Name = "Pet Name"
                .Columns(2).Name = "Animal Type"
                .Columns(3).Name = "Owner ID"
            End With
            DTGDiagnosisData.ColumnCount = 4
            With DTGDiagnosisData
                .Columns(0).Name = "Examination No"
                .Columns(1).Name = "Diagnosis"
                .Columns(2).Name = "Date Examined"
                .Columns(3).Name = "Pet ID"
            End With

            Call RefreshGridDiagnosis()
            Call RefreshGridPet()
            Call NoEntryPet()
            Call NoEntryDiag()
            Me.BtnSubmit.Enabled = False
            Me.TxtPetNum.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshGridPet()
        Dim RdrPetshop As DB2DataReader
        Dim CmdRetPet As DB2Command
        Dim SelectStr As String
        Dim Row As String()

        SelectStr = "select * from pet"
        CmdRetPet = New DB2Command(SelectStr, PetshopConn)
        RdrPetshop = CmdRetPet.ExecuteReader
        Me.DTGPetData.Rows.Clear()
        While RdrPetshop.Read
            Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2), RdrPetshop.GetString(3)}
            DTGPetData.Rows.Add(Row)
        End While
        RdrPetshop.Close()
    End Sub

    Private Sub RefreshGridDiagnosis()
        Dim RdrPetshop As DB2DataReader
        Dim CmdRetDiag As DB2Command
        Dim SelectStr As String
        Dim Row As String()

        SelectStr = "select * from animalsexamined"
        CmdRetDiag = New DB2Command(SelectStr, PetshopConn)
        RdrPetshop = CmdRetDiag.ExecuteReader
        Me.DTGDiagnosisData.Rows.Clear()
        While RdrPetshop.Read
            Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2), RdrPetshop.GetString(3)}
            DTGDiagnosisData.Rows.Add(Row)
        End While
        RdrPetshop.Close()
    End Sub

    Private Sub NoEntryPet()
        Me.TxtPetId.Enabled = False
        Me.TxtSearch.Enabled = True
        Me.TxtPetOwner.Enabled = False
        Me.BtnSubmit.Enabled = False
        Me.TxtDiagNo.Enabled = False
        Me.TxtDateDiag.Enabled = False
        Me.TxtDiagnosis.Enabled = False
    End Sub

    Private Sub EntryPet()
        Me.TxtPetId.Enabled = False
        Me.TxtPetOwner.Enabled = False
        Me.TxtSearch.Enabled = True
        Me.BtnSubmit.Enabled = False
        Me.TxtDiagNo.Enabled = True
        Me.TxtDateDiag.Enabled = True
        Me.TxtDiagnosis.Enabled = True
    End Sub

    Private Sub NoEntryDiag()
        Me.TxtPetNum.Enabled = True
        Me.BtnAdmit.Enabled = False
        Me.BtnDelete.Enabled = False
        Me.BtnUpdate.Enabled = False
    End Sub

    Private Sub EntryDiag()
        Me.TxtPetNum.Enabled = True
        Me.BtnAdmit.Enabled = True
        Me.TxtDateDiag.Enabled = True
        Me.TxtDiagnosis.Enabled = True
        Me.BtnDelete.Enabled = True
        Me.BtnUpdate.Enabled = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        PetshopConn.Close()
        FrmMenuVet.Show()
        Me.Close()
    End Sub

    Private Sub DTGPetData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DTGPetData.CellMouseUp
        Try
            Dim StrOwner As String
            Dim StrOwnerId As String
            Dim CmdOwner As DB2Command
            Dim RdrOwner As DB2DataReader
            Dim Owner As String

            StrOwnerId = Me.DTGPetData.CurrentRow.Cells(3).Value

            StrOwner = "select * from customer where custid = '" & StrOwnerId & "'"
            CmdOwner = New DB2Command(StrOwner, PetshopConn)
            RdrOwner = CmdOwner.ExecuteReader
            RdrOwner.Read()
            Owner = RdrOwner.GetString(1)
            TxtPetOwner.Text = Owner
            RdrOwner.Close()

            Me.TxtPetId.Text = Me.DTGPetData.CurrentRow.Cells(0).Value
            Call EntryPet()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DTGDiagnosisData_MouseUp(sender As Object, e As MouseEventArgs) Handles DTGDiagnosisData.MouseUp
        Try
            If Me.DTGDiagnosisData.CurrentRow.Cells(0).Value <> "" Then
                Me.TxtDiagNo.Text = Me.DTGDiagnosisData.CurrentRow.Cells(0).Value
                Me.TxtDateDiag.Text = Me.DTGDiagnosisData.CurrentRow.Cells(2).Value
                Me.TxtDiagnosis.Text = Me.DTGDiagnosisData.CurrentRow.Cells(1).Value
                Me.TxtPetId.Text = Me.DTGDiagnosisData.CurrentRow.Cells(3).Value
                Call SearchOwner()
                Call NoEntryPet()
                Call EntryDiag()
            Else
                Call ClearFunction()
                Me.BtnAdmit.Enabled = False
                Me.BtnUpdate.Enabled = False
                Me.BtnDelete.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try
            Dim DiagNo As String
            Dim Diag As String
            Dim DateDiag As String
            Dim PetID As String
            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            DiagNo = Me.TxtDiagNo.Text
            Diag = Me.TxtDiagnosis.Text
            DateDiag = Me.TxtDateDiag.Text
            PetID = Me.TxtPetId.Text
            InsertStr = "insert into animalsexamined values('" & DiagNo & "','" & Diag & "', '" & DateDiag & "','" & PetID & "')"
            CmdInsert = New DB2Command(InsertStr, PetshopConn)
            CmdInsert.ExecuteNonQuery()
            MessageBox.Show("Submitted Successfully", "New Examination")
            Call RefreshGridDiagnosis()
            Call ClearFunction()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim DiagNu As String
            Dim VDiagnosis As String
            Dim VDateDiag As String

            Dim UpdateStr As String
            Dim CmdUpdate As DB2Command

            DiagNu = Me.TxtDiagNo.Text
            VDiagnosis = Me.TxtDiagnosis.Text
            VDateDiag = Me.TxtDateDiag.Text

            UpdateStr = "update animalsexamined set diagnosis = '" & VDiagnosis & "', dateexamined = '" & VDateDiag & "' where examno = '" & DiagNu & "' "
            CmdUpdate = New DB2Command(UpdateStr, PetshopConn)
            CmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully", "Update Examination")
            Call RefreshGridDiagnosis()
            Call ClearFunction()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim DeleteStr As String
            Dim CmdDelete As DB2Command
            Dim Delete As Integer

            Delete = MsgBox("Are you sure you want to delete this diagnosis info?", vbQuestion + vbYesNo + vbDefaultButton2, "Delete Confirmation")
            If Delete = vbYes Then
                DeleteStr = "delete from animalsexamined where examno = '" & Me.TxtDiagNo.Text & "'"
                CmdDelete = New DB2Command(DeleteStr, PetshopConn)
                CmdDelete.ExecuteNonQuery()
                MessageBox.Show("Deleted Succesfully", "Delete Examination")
                Call RefreshGridDiagnosis()
                Call ClearFunction()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearFunction()
        Me.TxtDiagNo.Clear()
        Me.TxtPetId.Clear()
        Me.TxtDateDiag.Clear()
        Me.TxtDiagnosis.Clear()
        Me.TxtPetOwner.Clear()
        Me.TxtPetNum.Clear()
    End Sub

    Private Sub DTGDiagnosisData_GotFocus(sender As Object, e As EventArgs) Handles DTGDiagnosisData.GotFocus
        Call ClearFunction()
        Call EntryDiag()
        Call NoEntryPet()
    End Sub

    Private Sub DTGPetData_GotFocus(sender As Object, e As EventArgs) Handles DTGPetData.GotFocus
        Call ClearFunction()
        Call NoEntryDiag()
        Call EntryPet()
    End Sub

    Private Sub BtnAdmit_Click(sender As Object, e As EventArgs) Handles BtnAdmit.Click
        FrmAnimalAdmit.TxtPetIdAdmit.Text = Me.TxtPetId.Text
        FrmAnimalAdmit.TxtPetName.Text = Me.DTGPetData.CurrentRow.Cells(1).Value
        FrmAnimalAdmit.Show()
        Me.Close()
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            Dim SearchStr As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim SearchStr2 As String
            Dim row As String()

            SearchStr2 = "%" + Me.TxtSearch.Text + "%"
            SearchStr = "Select * from pet where petid like  '" & SearchStr2 & "'"
            CmdSearch = New DB2Command(SearchStr, PetshopConn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.DTGPetData.Rows.Clear()
            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3)}
                Me.DTGPetData.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Entry()
        If (Me.TxtPetId.Text <> "") And (Me.TxtPetOwner.Text <> "") And (Me.TxtDiagNo.Text <> "") And (Me.TxtDateDiag.Text <> "") And (Me.TxtDiagnosis.Text <> "") And (Me.TxtDiagNo.Enabled = True) Then
            Me.BtnSubmit.Enabled = True
        Else
            Me.BtnSubmit.Enabled = False
        End If

        If (Me.TxtPetId.Text <> "") And (Me.TxtPetOwner.Text <> "") And (Me.TxtDiagNo.Text <> "") And (Me.TxtDateDiag.Text <> "") And (Me.TxtDiagnosis.Text <> "") And (Me.TxtDiagNo.Enabled = False) Then
            Me.BtnUpdate.Enabled = True
        Else
            Me.BtnUpdate.Enabled = False
        End If
    End Sub

    Private Sub TxtPetId_TextChanged(sender As Object, e As EventArgs) Handles TxtPetId.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtPetOwner_TextChanged(sender As Object, e As EventArgs) Handles TxtPetOwner.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtDiagNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDiagNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDiagNo_TextChanged(sender As Object, e As EventArgs) Handles TxtDiagNo.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtDateDiag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDateDiag.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDateDiag_TextChanged(sender As Object, e As EventArgs) Handles TxtDateDiag.TextChanged
        Call Entry()
    End Sub

    Private Sub TxtDiagnosis_Click(sender As Object, e As EventArgs) Handles TxtDiagnosis.Click
        Me.TxtDiagnosis.Clear()
        Me.TxtDiagnosis.Focus()
    End Sub

    Private Sub TxtDiagnosis_TextChanged(sender As Object, e As EventArgs) Handles TxtDiagnosis.TextChanged
        Call Entry()
    End Sub

    Private Sub SearchOwner()
        Try
            Dim StrOwner As String
            Dim StrOwnerId As String
            Dim CmdOwner As DB2Command
            Dim RdrOwner As DB2DataReader
            Dim Owner As String

            StrOwnerId = Me.DTGDiagnosisData.CurrentRow.Cells(3).Value

            StrOwner = "select * from pet where petid = '" & StrOwnerId & "'"
            CmdOwner = New DB2Command(StrOwner, PetshopConn)
            RdrOwner = CmdOwner.ExecuteReader
            RdrOwner.Read()

            Owner = RdrOwner.GetString(3)

            StrOwner = "select * from customer where custid = '" & Owner & "'"
            CmdOwner = New DB2Command(StrOwner, PetshopConn)
            RdrOwner = CmdOwner.ExecuteReader
            RdrOwner.Read()

            Owner = RdrOwner.GetString(1)

            Me.TxtPetOwner.Text = Owner
            RdrOwner.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtDiagnosisNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPetNum.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDiagnosisNumber_TextChanged(sender As Object, e As EventArgs) Handles TxtPetNum.TextChanged
        Try
            Dim SearchStr As String
            Dim CmdSearch As DB2Command
            Dim RdrSearch As DB2DataReader
            Dim SearchStr2 As String
            Dim row As String()

            SearchStr2 = "%" + Me.TxtPetNum.Text + "%"
            SearchStr = "Select * from animalsexamined where petid like  '" & SearchStr2 & "'"
            CmdSearch = New DB2Command(SearchStr, PetshopConn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.DTGDiagnosisData.Rows.Clear()
            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3)}
                Me.DTGDiagnosisData.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DTGPetData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGPetData.CellContentClick

    End Sub

    Private Sub DTGDiagnosisData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGDiagnosisData.CellContentClick

    End Sub
End Class