Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlServerCe

Partial Public Class Form1

    Inherits DevExpress.XtraEditors.XtraForm

    Dim conm As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conm)

    Shared Sub New()

        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Dim kullanici As String = txtkullanici.Text
        Dim sifre As String = txtsifre.Text

        If kullanici = "" Or sifre = "" Then
            MsgBox("KULLANICI ADI YA DA ŞİFRE ALANI BOŞ BIRAKILAMAZ!")
            Exit Sub
        Else
            Dim kontrol = From k In db.LOGINs Where k.KULLANICI = kullanici Select k
            If kontrol.Count <= 0 Then
                MsgBox("KULLANICI ADI BULUNAMADI!")
                Exit Sub
            Else
                Dim xsifre As String = ""
                For Each aa In kontrol
                    xsifre = aa.SİFRE
                Next
                If sifre = xsifre Then
                    Dim anasayfa As New frmtest
                    anasayfa.Show()
                    Me.Hide()
                Else
                    MsgBox("ŞİFRE YANLIŞ")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    
End Class
