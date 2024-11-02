Imports System.Data.SqlServerCe

Public Class frmtest

    Dim conm As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conm)

    Private Sub btnsoruhazirla_Click(sender As System.Object, e As System.EventArgs) Handles btnsoruhazirla.Click

        Dim soruhazirla As New frmsoruhazirla
        soruhazirla.ShowDialog()
        update()

    End Sub

    Private Sub update()

        Dim conn As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
        Dim da As New SqlCeDataAdapter
        Dim ds As New DataSet
        Dim str1 As String = String.Format("SELECT * FROM SORULAR ORDER BY ID DESC")
        da.SelectCommand = New SqlCeCommand(str1, conn)
        da.Fill(ds)
        conn.Close()
        dgvsorular.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnbasliktanimla_Click(sender As System.Object, e As System.EventArgs) Handles btnbasliktanimla.Click

        Dim baslık As New frmbaslik
        baslık.ShowDialog()

        Dim GETIR = From K In db.SORULARs Order By K.ID Select K
        dgvsorular.DataSource = GETIR

    End Sub
    Private Sub frmtest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim verigetir = From k In db.SORULARs Order By k.BASLIK Ascending Select k
        dgvsorular.DataSource = verigetir

        Dim başlikgetir = From k In db.BASLIKs Order By k.BASLIK1 Ascending Select k

        cbbaslik.Properties.DataSource = başlikgetir
        cbbaslik.Properties.DisplayMember = "BASLIK1"
        cbbaslik.Properties.ValueMember = "ID"

        Dim col_1 As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BASLIK1", 100)
        col_1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        cbbaslik.Properties.Columns.Add(col_1)
    End Sub

    Private Sub cbbaslik_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbbaslik.EditValueChanged

        Dim Baslik As String = cbbaslik.Text
        Dim getir = From k In db.SORULARs Where k.BASLIK = Baslik Order By k.ID Descending Select k

        dgvsorular.DataSource = getir

    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick

        Dim xid As Integer = CInt(CType(GridView1.GetFocusedRowCellValue("ID").ToString(), String))

        Dim sil = From k In db.SORULARs Where k.ID = xid Select k

        For Each ss In sil
            db.SORULARs.DeleteOnSubmit(ss)
            db.SubmitChanges()
        Next

        Dim getir = From k In db.SORULARs Order By k.ID Descending Select k
        dgvsorular.DataSource = getir

    End Sub

    Private Sub RepositoryItemButtonEdit2_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit2.ButtonClick

        My.Application.SORUID = CInt(CType(GridView1.GetFocusedRowCellValue("ID").ToString(), String))
        Dim x As New frmanasayfa
        x.ShowDialog()

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

        Dim soruhazirla As New frmrastgelesoru
        soruhazirla.ShowDialog()

    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Dim soruhazirla As New manuelsoruhazirla
        soruhazirla.ShowDialog()
    End Sub

    
End Class