Imports IBM.Data.DB2
Public Class FrmAnimalAdmit
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

        SelectStr = "select * from animalsadmitted"
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


    End Sub

    Private Sub Edit()
        Me.TxtPetIdAdmit.Enabled = False
        Me.TxtPetName.Enabled = False
        Me.BtnAdmit.Enabled = False

    End Sub


    Private Sub BackFunction()
        Me.TxtPetIdAdmit.Enabled = False

        Me.BtnAdmit.Enabled = False
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FrmAnimalDiagnose.Show()
        Me.Close()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnAdmit.Click
        Try
            Dim AdmitNo As String
            Dim AdmitDate As String
            Dim PetID As String
            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            AdmitNo = Me.TxtAdmitNo.Text
            AdmitDate = Me.TxtDateAdmitted.Text
            PetID = Me.TxtPetIdAdmit.Text
            InsertStr = "insert into animalsadmitted(admitno,dateadmitted,petid) values('" & AdmitNo & "','" & AdmitDate & "','" & PetID & "')"
            CmdInsert = New DB2Command(InsertStr, PetshopConn)
            CmdInsert.ExecuteNonQuery()
            MessageBox.Show("Admission Added", "Admit Pet")
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
        Me.TxtPetIdAdmit.Clear()
        Me.TxtPetName.Clear()
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EnableAdmit()
        If (Me.TxtAdmitNo.Text <> "") And (Me.TxtDateAdmitted.Text <> "") Then
            Me.BtnAdmit.Enabled = True
        Else
            Me.BtnAdmit.Enabled = False

        End If
    End Sub

    Private Sub TxtAdmitNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAdmitNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAdmitNo_TextChanged(sender As Object, e As EventArgs) Handles TxtAdmitNo.TextChanged
        Call EnableAdmit()
    End Sub

    Private Sub TxtDateAdmitted_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDateAdmitted.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDateAdmitted_TextChanged(sender As Object, e As EventArgs) Handles TxtDateAdmitted.TextChanged
        Call EnableAdmit()
    End Sub

    Private Sub TxtDateDisCharged_TextChanged(sender As Object, e As EventArgs)
        Call EnableAdmit()
    End Sub

    Private Sub DTGAdmit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGAdmit.CellContentClick

    End Sub

    Private Sub TxtPetIdAdmit_TextChanged(sender As Object, e As EventArgs) Handles TxtPetIdAdmit.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class