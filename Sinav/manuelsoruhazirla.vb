Imports System.Data.SqlServerCe

Public Class manuelsoruhazirla

    Dim conm As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conm)

    Private Sub manuelsoruhazirla_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        GridView1.OptionsView.ShowGroupPanel = False
        Dim verigetir = From k In db.SORULARs Order By k.BASLIK Ascending Select k

        dgvsorular.DataSource = verigetir

        Dim başlikgetir = From k In db.BASLIKs Order By k.BASLIK1 Ascending Select k

        cbbaslik.Properties.DataSource = başlikgetir
        cbbaslik.Properties.DisplayMember = "BASLIK1"
        cbbaslik.Properties.ValueMember = "ID"

        Dim col_1 As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BASLIK1", 100)
        col_1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        cbbaslik.Properties.Columns.Add(col_1)

        GridView1.OptionsView.ShowGroupPanel = False

    End Sub

    Private Sub cbbaslik_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbbaslik.EditValueChanged

        Dim Baslik As String = cbbaslik.Text
        Dim getir = From k In db.SORULARs Where k.BASLIK = Baslik Order By k.ID Descending Select k

        dgvsorular.DataSource = getir
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

        Dim manuel As New manuelsoru
        manuel.ShowDialog()

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

    Private Sub RepositoryItemButtonEdit3_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit3.ButtonClick

        Dim xid As Integer = CInt(CType(GridView1.GetFocusedRowCellValue("ID").ToString(), String))

        Dim ID As Integer = 0
        Dim BASLIKID As Integer = 0
        Dim BASLIK As String = ""
        Dim SORU As String = ""
        Dim CVPHARFA As String = ""
        Dim CVPHARFB As String = ""
        Dim CVPHARFC As String = ""
        Dim CVPHARFD As String = ""
        Dim CVPA As String = ""
        Dim CVPB As String = ""
        Dim CVPC As String = ""
        Dim CVPD As String = ""
        Dim CVPSIK As String = ""
        Dim KULLANIM As Integer = 0

        Dim GETIR = From K In db.SORULARs Where K.ID = xid Select K
        For Each AA In GETIR
            BASLIK = AA.BASLIK
            SORU = AA.SORU
            CVPHARFA = AA.CVPHARFA
            CVPHARFB = AA.CVPHARFB
            CVPHARFC = AA.CVPHARFC
            CVPHARFD = AA.CVPHARFD
            CVPA = AA.CVPA
            CVPB = AA.CVPB
            CVPC = AA.CVPC
            CVPD = AA.CVPD
            CVPSIK = AA.CVPSIK
            ID = AA.ID
            KULLANIM = AA.KULLANIM
        Next

        Dim KAYDET As New MANUELSORULAR With {.BASLIK = BASLIK, .SORU = SORU, .CEVAPAHARF = CVPHARFA, .CEVAPBHARF = CVPHARFB, .CEVAPCHARF = CVPHARFC, _
                                                .CEVAPDHARF = CVPHARFD, .CEVAPA = CVPA, .CEVAPB = CVPB, .CEVAPC = CVPC, _
                                                .CEVAPD = CVPD, .DOGRUSIK = CVPSIK, .ID = ID, .BASLIKID = BASLIKID}

        db.MANUELSORULARs.InsertOnSubmit(KAYDET)
        db.SubmitChanges()
    End Sub


    Private Sub RepositoryItemButtonEdit2_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit2.ButtonClick

        My.Application.SORUID = CInt(CType(GridView1.GetFocusedRowCellValue("ID").ToString(), String))
        Dim x As New frmanasayfa
        x.ShowDialog()

    End Sub
End Class