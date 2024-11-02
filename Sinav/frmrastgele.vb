Imports System.Data.SqlServerCe

Public Class frmrastgele

    Dim conn As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conn)

    Public Sub LoadData(ByVal data As DataTable)
        ' DataGridView'e gelen verileri yükle
        dgvsorular2.DataSource = data
    End Sub

    Private Sub frmrastgele_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        GridView1.OptionsView.ShowGroupPanel = False

    End Sub

   
End Class