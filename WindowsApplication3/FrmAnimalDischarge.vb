Imports IBM.Data.DB2
Public Class FrmAnimalDischarge
    Private PetshopConn As Common.DbConnection
    Private Sub FrmAdmit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PetshopConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            PetshopConn.Open()

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

        SelectStr = "select * from animalsadmitted where datedischarged = '' "
        CmdRetPet = New DB2Command(SelectStr, PetshopConn)
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
        Me.TxtAdmitNo.Enabled = False
        Me.TxtDateAdmitted.Enabled = False
        Me.BtnDischarge.Enabled = False
    End Sub

    Private Sub Discharge()
        Me.TxtPetIdAdmit.Enabled = False
        Me.TxtPetName.Enabled = False
        Me.BtnDischarge.Enabled = True

    End Sub


    Private Sub BackFunction()
        Me.TxtPetIdAdmit.Enabled = False
        Me.BtnDischarge.Enabled = False
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim ViewVetMenu As New FrmMenuVet

        ViewVetMenu.Show()
        Me.Close()

    End Sub

    Private Sub BtnDischarge_Click(sender As Object, e As EventArgs) Handles BtnDischarge.Click
        Try
            Dim AdmitDateDis As String
            Dim AdmitNo As String
            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            AdmitDateDis = Me.TxtDateDisCharged.Text
            AdmitNo = Me.TxtAdmitNo.Text
            InsertStr = "update animalsadmitted set datedischarged = '" & AdmitDateDis & "' where admitno = '" & AdmitNo & "'"
            CmdInsert = New DB2Command(InsertStr, PetshopConn)
            CmdInsert.ExecuteNonQuery()
            MessageBox.Show("Pet Discharged", "Discharge")
            Call RefreshGridAdmit()
            Call ClearFunction()
            Call BackFunction()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearFunction()
        Me.TxtAdmitNo.Clear()
        Me.TxtDateAdmitted.Clear()
        Me.TxtDateDisCharged.Clear()
        Me.TxtPetIdAdmit.Clear()
        Me.TxtPetName.Clear()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs)
        Call RefreshGridAdmit()
    End Sub

    Private Sub DTGAdmit_MouseUp(sender As Object, e As MouseEventArgs) Handles DTGAdmit.MouseUp
        Dim StrPetName As String
        Dim CmdOwner As DB2Command
        Dim RdrPetReader As DB2DataReader
        Dim PetName As String

        If Me.DTGAdmit.RowCount > 0 Then
            Me.TxtPetIdAdmit.Text = DTGAdmit.CurrentRow.Cells(3).Value

            StrPetName = "select * from pet where petid = '" & Me.TxtPetIdAdmit.Text & "'"
            CmdOwner = New DB2Command(StrPetName, PetshopConn)
            RdrPetReader = CmdOwner.ExecuteReader
            RdrPetReader.Read()

            PetName = RdrPetReader.GetString(1)
            TxtPetName.Text = PetName
            RdrPetReader.Close()

            Me.TxtAdmitNo.Enabled = False
            Me.TxtDateAdmitted.Enabled = False
            TxtAdmitNo.Text = DTGAdmit.CurrentRow.Cells(0).Value
            TxtDateAdmitted.Text = DTGAdmit.CurrentRow.Cells(1).Value
            Call Discharge()
        End If
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
            SearchStr = "Select * from animalsadmitted where admitno like  '" & SearchStr2 & "' and datedischarged = '' "
            CmdSearch = New DB2Command(SearchStr, PetshopConn)
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

    Private Sub EnableDischarge()
        If (Me.TxtDateDisCharged.Text <> "") Then
            Me.BtnDischarge.Enabled = True
        Else
            Me.BtnDischarge.Enabled = False
        End If
    End Sub

    Private Sub TxtDateDisCharged_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDateDisCharged.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub
End Class