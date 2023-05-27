Imports IBM.Data.DB2
Public Class FrmAnimalAdmitUpdate
    Private UpdateConn As Common.DbConnection
    Private Sub FrmAdmitUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            UpdateConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            UpdateConn.Open()

            DTGAdmit.ReadOnly = True

            DTGAdmit.ColumnCount = 4
            With DTGAdmit
                .Columns(0).Name = "Admit No"
                .Columns(1).Name = "Date Admitted"
                .Columns(2).Name = "Date Discharged"
                .Columns(3).Name = "Pet ID"
            End With

            Call RefreshGridAdmit()
            Call NoEdit()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshGridAdmit()
        Dim RdrPetshop As DB2DataReader
        Dim CmdRetPet As DB2Command
        Dim SelectStr As String
        Dim Row As String()

        SelectStr = "select * from animalsadmitted"
        CmdRetPet = New DB2Command(SelectStr, UpdateConn)
        RdrPetshop = CmdRetPet.ExecuteReader
        Me.DTGAdmit.Rows.Clear()
        While RdrPetshop.Read
            Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(2), RdrPetshop.GetString(3)}
            DTGAdmit.Rows.Add(Row)
        End While
        RdrPetshop.Close()
    End Sub

    Private Sub NoEdit()
        Me.TxtPetIdAdmit.Enabled = False
        Me.TxtPetName.Enabled = False
        Me.BtnDelete.Enabled = False
        Me.BtnUpdate.Enabled = False
    End Sub

    Private Sub Edit()
        Me.TxtPetIdAdmit.Enabled = False
        Me.TxtPetName.Enabled = False
        Me.BtnDelete.Enabled = True
        Me.BtnUpdate.Enabled = True
    End Sub

    Private Sub ClearFunction()
        Me.TxtAdmitNo.Clear()
        Me.TxtDateAdmitted.Clear()
        Me.TxtPetIdAdmit.Clear()
        Me.TxtPetName.Clear()
    End Sub

    Private Sub DTGAdmit_MouseUp(sender As Object, e As MouseEventArgs) Handles DTGAdmit.MouseUp
        Dim StrPetName As String
        Dim CmdOwner As DB2Command
        Dim RdrPetReader As DB2DataReader
        Dim PetName As String

        Me.TxtPetIdAdmit.Text = DTGAdmit.CurrentRow.Cells(3).Value

        StrPetName = "select * from pet where petid = '" & Me.TxtPetIdAdmit.Text & "'"
        CmdOwner = New DB2Command(StrPetName, UpdateConn)
        RdrPetReader = CmdOwner.ExecuteReader
        RdrPetReader.Read()
        PetName = RdrPetReader.GetString(1)
        TxtPetName.Text = PetName
        RdrPetReader.Close()

        Me.TxtAdmitNo.Enabled = False
        TxtAdmitNo.Text = DTGAdmit.CurrentRow.Cells(0).Value
        TxtDateAdmitted.Text = DTGAdmit.CurrentRow.Cells(1).Value
        Call Edit()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim AdmitNu As String
            Dim VDateAdmit As String

            Dim UpdateStr As String
            Dim CmdUpdate As DB2Command

            AdmitNu = Me.TxtAdmitNo.Text
            VDateAdmit = Me.TxtDateAdmitted.Text

            UpdateStr = "update animalsadmitted set dateadmitted = '" & VDateAdmit & "' where admitno = '" & AdmitNu & "' "
            CmdUpdate = New DB2Command(UpdateStr, UpdateConn)
            CmdUpdate.ExecuteNonQuery()

            MessageBox.Show("Admission Updated", "Update Admission")
            Call RefreshGridAdmit()
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

            Delete = MsgBox("Are you sure you want to delete this admission info?", vbQuestion + vbYesNo + vbDefaultButton2, "Delete Confirmation")
            If Delete = vbYes Then
                DeleteStr = "delete from animalsadmitted where admitno = '" & Me.TxtAdmitNo.Text & "'"
                CmdDelete = New DB2Command(DeleteStr, UpdateConn)
                CmdDelete.ExecuteNonQuery()
                MessageBox.Show("Deleted Succesfully", "Update Admission")
                Call RefreshGridAdmit()
                Call ClearFunction()
            End If
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
            SearchStr = "Select * from animalsadmitted where admitno like  '" & SearchStr2 & "'"
            CmdSearch = New DB2Command(SearchStr, UpdateConn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.DTGAdmit.Rows.Clear()
            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3)}
                Me.DTGAdmit.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EnableUpdate()
        If (Me.TxtDateAdmitted.Text <> "") Then
            Me.BtnUpdate.Enabled = True
        Else
            Me.BtnUpdate.Enabled = False
        End If
    End Sub

    Private Sub TxtDateAdmitted_TextChanged(sender As Object, e As EventArgs) Handles TxtDateAdmitted.TextChanged
        Call EnableUpdate()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs)
        FrmMenuVet.Show()
        Me.Close()
    End Sub

    Private Sub DTGAdmit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGAdmit.CellContentClick

    End Sub

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles BtnBack.Click
        FrmMenuVet.Show()
        Me.Close()
    End Sub
End Class