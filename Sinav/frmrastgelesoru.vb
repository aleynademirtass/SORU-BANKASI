Imports System.Data.SqlServerCe
Public Class frmrastgelesoru

    Dim conm As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conm)


    Private Sub frmrastgelesoru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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

    Private Sub cbbaslik_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbbaslik.EditValueChanged

        Dim adet As Integer = 0

        Dim Baslik As String = cbbaslik.Text

        '30.gün
        Dim say = Aggregate c In db.SORULARs Where c.BASLIK = Baslik Into Count()

        adet = say

        txtsay.Text = adet

        Dim getir = From k In db.SORULARs Where k.BASLIK = Baslik Order By k.ID Descending Select k

        dgvsorular.DataSource = getir

    End Sub

    Private Sub cbsoruadet_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbsoruadet.SelectedIndexChanged

        Dim SoruAdet As Integer = txtsay.Text
        Dim adet As Integer = cbsoruadet.Text

        If adet > SoruAdet Then
            '30.
            MsgBox("SORU ADEDİNDEN FAZLA DEĞER SEÇEMEZSİNİZ")
            cbsoruadet.SelectedIndex = 0

            Exit Sub
        End If

    End Sub

    Private Sub btnsoruhazirla_Click(sender As System.Object, e As System.EventArgs) Handles btnsoruhazirla.Click

        Dim BASLIK As String = cbbaslik.Text
        Dim SORUADET As Integer = CInt(cbsoruadet.Text)
        Dim ADET As String = txtsay.Text
        Dim Kullanim As Integer = CInt(cbkullanım.Text)

        If BASLIK = "" Then
            MsgBox("SORU BAŞLIĞI TANIMLANMAMIŞ")
            Exit Sub
        ElseIf SORUADET = 0 Then
            MsgBox("BU BAŞLIK ADI ALTINDA SORU SEÇİMİ YAPMADINIZ")
            Exit Sub
        ElseIf ADET = 0 Then
            MsgBox("SORU ADETİ TANIMLANMAMIŞ")
            Exit Sub
            '31
        Else
            Dim tumSorular = db.SORULARs.Where(Function(K) K.BASLIK = BASLIK And K.KULLANIM <= Kullanim).ToList()

            Dim rastgele = New Random()
            Dim rastgeleSorular = tumSorular.OrderBy(Function(x) rastgele.Next()).Take(SORUADET).ToList()

            dgvsorular.DataSource = rastgeleSorular

        End If
    End Sub

    Private Sub RepositoryItemButtonEdit2_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit2.ButtonClick

        My.Application.SORUID = CInt(CType(GridView1.GetFocusedRowCellValue("ID").ToString(), String))
        Dim x As New frmanasayfa
        x.ShowDialog()

    End Sub




    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click


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

        Dim dt As New DataTable()

        dt.Columns.Add("BASLIK", GetType(String))
        dt.Columns.Add("SORU", GetType(String))
        dt.Columns.Add("CVPHARFA", GetType(String))
        dt.Columns.Add("CVPHARFB", GetType(String))
        dt.Columns.Add("CVPHARFC", GetType(String))
        dt.Columns.Add("CVPHARFD", GetType(String))
        dt.Columns.Add("CVPA", GetType(String))
        dt.Columns.Add("CVPB", GetType(String))
        dt.Columns.Add("CVPC", GetType(String))
        dt.Columns.Add("CVPD", GetType(String))
        dt.Columns.Add("CVPSIK", GetType(String))
        dt.Columns.Add("ID", GetType(Integer))


        For i As Integer = 0 To GridView1.DataRowCount - 1

            Dim row As DataRow = dt.NewRow()

            row("BASLIK") = GridView1.GetRowCellValue(i, "BASLIK").ToString
            row("SORU") = GridView1.GetRowCellValue(i, "SORU").ToString
            row("CVPHARFA") = GridView1.GetRowCellValue(i, "CVPHARFA").ToString
            row("CVPHARFB") = GridView1.GetRowCellValue(i, "CVPHARFB").ToString
            row("CVPHARFC") = GridView1.GetRowCellValue(i, "CVPHARFC").ToString
            row("CVPHARFD") = GridView1.GetRowCellValue(i, "CVPHARFD").ToString
            row("CVPA") = GridView1.GetRowCellValue(i, "CVPA").ToString
            row("CVPB") = GridView1.GetRowCellValue(i, "CVPB").ToString
            row("CVPC") = GridView1.GetRowCellValue(i, "CVPC").ToString
            row("CVPD") = GridView1.GetRowCellValue(i, "CVPD").ToString
            row("CVPSIK") = GridView1.GetRowCellValue(i, "CVPSIK").ToString
            dt.Rows.Add(row)

            Dim kaydet As New RASTGELESORULAR With {.BASLIK = BASLIK, .SORU = SORU, .CEVAP_A_HARF = CVPHARFA, .CEVAP_B_HARF = CVPHARFB, _
                                                    .CEVAP_C_HARF = CVPHARFC, .CEVAP_D_HARF = CVPHARFD, _
                                                     .CEVAP_A = CVPA, .CEVAP_B = CVPB, .CEVAP_C = CVPC, _
                                                    .CEVAP_D = CVPD, .DOGRUSIK = CVPSIK, .BASLIKID = ID}

            db.RASTGELESORULARs.InsertOnSubmit(kaydet)
            db.SubmitChanges()
        Next
        Dim a As New frmrastgele()
        a.LoadData(dt)
        a.ShowDialog()
    End Sub


End Class
