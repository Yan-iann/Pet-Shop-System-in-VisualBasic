Imports IBM.Data.DB2
Public Class FrmMenuVet
    Private PetshopConn As Common.DbConnection

    Private Sub BtnPetAdmit_Click(sender As Object, e As EventArgs) Handles BtnPetDiagnose.Click
        Dim ViewPetAdmit As New FrmAnimalDiagnose
        ViewPetAdmit.Show()
        Me.Close()
    End Sub

    Private Sub FrmMenuVet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PetshopConn = New DB2Connection("server=localhost;database=PETSHOP;" + "uid=db2admin;password=db2admin;")
            PetshopConn.Open()

            DgvPetInShop.ReadOnly = True

            DgvPetInShop.ColumnCount = 3
            With DgvPetInShop
                .Columns(0).Name = "Admit No"
                .Columns(1).Name = "Date Admitted"
                .Columns(2).Name = "Pet ID"
            End With

            Call RefreshGridAdmit()

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
        Me.DgvPetInShop.Rows.Clear()
        While RdrPetshop.Read
            Row = New String() {RdrPetshop.GetString(0), RdrPetshop.GetString(1), RdrPetshop.GetString(3)}
            DgvPetInShop.Rows.Add(Row)
        End While
        RdrPetshop.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ViewPetDischarge As New FrmAnimalDischarge
        ViewPetDischarge.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginInfo.Show()
        Me.Close()
    End Sub

    Private Sub BtnAdmitUpdate_Click(sender As Object, e As EventArgs) Handles BtnAdmitUpdate.Click
        Dim ViewFrmAdmitUpdate As New FrmAnimalAdmitUpdate
        ViewFrmAdmitUpdate.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmFees.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmFeeUpdate.Show()
        Me.Close()
    End Sub
End Class