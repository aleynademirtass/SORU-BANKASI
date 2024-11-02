Imports System.Data.SqlServerCe
Imports System.Linq

Public Class frmbaslik

    Dim conn As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conn)

    Private Sub frmbaslik_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim getir = From k In db.BASLIKs Order By k.ID Descending Select k
        dgvbaslik.DataSource = getir

        GridView1.OptionsView.ShowGroupPanel = False

    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick

        Dim xid As Integer = CInt(CType(GridView1.GetFocusedRowCellValue("ID").ToString(), String))
        Dim sil = From k In db.BASLIKs Where k.ID = xid Select k

        For Each ss In sil
            db.BASLIKs.DeleteOnSubmit(ss)
            db.SubmitChanges()
        Next
        Dim getir = From k In db.BASLIKs Order By k.ID Descending Select k
        dgvbaslik.DataSource = getir
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click

        Dim baslık As String = textbaslik.Text
        Dim sorusay As Integer = 0

        If baslık = "" Then
            MsgBox("BAŞLIK ALANI BOŞ BIRAKILAMAZ")
            Exit Sub
        Else
            Dim kaydet As New BASLIK With {.BASLIK1 = baslık, .SORUSAY = sorusay}
            db.BASLIKs.InsertOnSubmit(kaydet)
            db.SubmitChanges()
            MsgBox("BAŞLIK KAYDEDİLDİ!")

            textbaslik.Text = ""
            textbaslik.Focus()

            Dim getir = From k In db.BASLIKs Order By k.ID Descending Select k
            dgvbaslik.DataSource = getir
        End If
    End Sub

    Private Sub btnsoruhazirla_Click(sender As System.Object, e As System.EventArgs) Handles btncikis.Click

        Dim cikis As New frmtest
        cikis.ShowDialog()

    End Sub
End Class