Imports System.Data.SqlServerCe


Public Class frmsoruhazirla

    Dim conn As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conn)

    Private Sub btnsoruhazirla_Click(sender As System.Object, e As System.EventArgs) Handles btnsoruhazirla.Click
        Me.Close()
    End Sub
 
    Private Sub frmsoruhazirla_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim başlikgetir = From k In db.BASLIKs Order By k.BASLIK1 Ascending Select k

        cbbaslik.Properties.DataSource = başlikgetir
        cbbaslik.Properties.DisplayMember = "BASLIK1"
        cbbaslik.Properties.ValueMember = "ID"

        Dim col_1 As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BASLIK1", 100)
        col_1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        cbbaslik.Properties.Columns.Add(col_1)


    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click

        Dim BASLIK As String = cbbaslik.Text
        Dim SORU As String = txtsoru.Text

        Dim CVPHARFA As String = lbla.Text
        Dim CVPCOZA As Boolean = rba.Checked
        Dim CVPA As String = txtcvpa.Text
        '----------------------------------
        Dim CVPHARFB As String = lblb.Text
        Dim CVPCOZB As Boolean = rbb.Checked
        Dim CVPB As String = txtcvpb.Text
        '----------------------------------
        Dim CVPHARFC As String = lblc.Text
        Dim CVPCOZC As Boolean = rbc.Checked
        Dim CVPC As String = txtcvpc.Text

        Dim CVPHARFD As String = lbld.Text
        Dim CVPCOZD As Boolean = rbd.Checked
        Dim CVPD As String = txtcvpd.Text

        Dim CVPSIK As String = ""
        Dim AKTIF As Boolean = True

        If BASLIK = "" Then
            MsgBox("BAŞLIK BOŞ GEÇİLEMEZ")
            Exit Sub

        ElseIf SORU = "" Then
            MsgBox("SORU ALANI BOŞ GEÇİLEMEZ")
            Exit Sub

        ElseIf CVPA = "" Or CVPB = "" Or CVPC = "" Or CVPD = "" Then

            MsgBox("LÜTFEN CEVABI GİRİNİZ!")
            Exit Sub
        ElseIf CVPCOZA = False And CVPCOZB = False And CVPCOZC = False And CVPCOZD = False Then

            MsgBox("İŞARETLEME YAPMADINIZ")
            Exit Sub
        Else
            If CVPCOZA = True Then
                CVPSIK = "A"
            ElseIf CVPCOZB = True Then
                CVPSIK = "B"
            ElseIf CVPCOZC = True Then
                CVPSIK = "C"
            ElseIf CVPCOZD = True Then
                CVPSIK = "D"
            End If

            Dim kaydet As New SORULAR With {.BASLIK = BASLIK, .CVPA = CVPA, .CVPB = CVPB, .CVPC = CVPC, .CVPD = CVPD, .CVPCOZA = CVPCOZA, .CVPCOZB = CVPCOZB, _
                                           .CVPCOZC = CVPCOZC, .CVPCOZD = CVPCOZD, .CVPHARFA = CVPHARFA, .CVPHARFB = CVPHARFB, .CVPHARFC = CVPHARFC, _
                                            .CVPHARFD = CVPHARFD, .CVPSIK = CVPSIK, .AKTIF = True, .SORU = SORU}
            db.SORULARs.InsertOnSubmit(kaydet)
            db.SubmitChanges()

            Dim getir = From k In db.BASLIKs Select k
            Dim say As Integer = 0
            For Each aa In getir
                say = aa.SORUSAY
            Next

            Dim SORUSAY As Integer = 0
            SORUSAY = say + 1

            Dim kayit = (From k In db.BASLIKs Where k.BASLIK1 = BASLIK Select k).First()
            kayit.SORUSAY = SORUSAY
            db.SubmitChanges()

            cbbaslik.EditValue = Nothing
            txtsoru.Text = ""
            txtcvpa.Text = ""
            txtcvpb.Text = ""
            txtcvpc.Text = ""
            txtcvpd.Text = ""
            rba.Checked = False
            rbb.Checked = False
            rbc.Checked = False
            rbd.Checked = False
            cbbaslik.Focus()
        End If

    End Sub

End Class