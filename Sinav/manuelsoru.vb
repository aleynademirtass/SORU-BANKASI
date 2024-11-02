Imports System.Data.SqlServerCe

Public Class manuelsoru

    Dim conm As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conm)

    Private Sub manuelsoru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim getir = From k In db.MANUELSORULARs Select k

        dgvsorular2.DataSource = getir.ToList()

        GridView1.OptionsView.ShowGroupPanel = False
        'gridin üzerindeki yazıyı gizleme


    End Sub
End Class