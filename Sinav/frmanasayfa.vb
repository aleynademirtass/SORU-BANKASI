Imports System.Data.SqlServerCe

Public Class frmanasayfa

    Dim conn As New SqlCeConnection(My.Settings.SINAVSORUConnectionString)
    Dim db As New Database1datacontext.SINAVSORU(conn)

    Private Sub frmanasayfa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim verigetir = From k In db.SORULARs Where k.ID = My.Application.SORUID Select k

        For Each aa In verigetir

            txtsoru.Text = aa.SORU
            txtcvpa.Text = aa.CVPA
            txtcvpb.Text = aa.CVPB
            txtcvpc.Text = aa.CVPC
            txtcvpd.Text = aa.CVPD
            lblbaslik.Text = aa.BASLIK


            txtcvpa.ReadOnly = True
            txtcvpb.ReadOnly = True
            txtcvpc.ReadOnly = True
            txtcvpd.ReadOnly = True
            txtsoru.ReadOnly = True

            If aa.CVPSIK = "A" Then
                txtcvpa.BackColor = Color.ForestGreen
            ElseIf aa.CVPSIK = "B" Then
                txtcvpb.BackColor = Color.ForestGreen
            ElseIf aa.CVPSIK = "C" Then
                txtcvpc.BackColor = Color.ForestGreen
            ElseIf aa.CVPSIK = "D" Then
                txtcvpd.BackColor = Color.ForestGreen
            End If
        Next
    End Sub
  
    Private Sub btnsoruhazirla_Click(sender As System.Object, e As System.EventArgs) Handles btnsoruhazirla.Click

        Dim cikis As New frmtest

        cikis.ShowDialog()
        Me.Hide()


    End Sub
End Class