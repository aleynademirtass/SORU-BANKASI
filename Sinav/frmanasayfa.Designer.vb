<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmanasayfa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmanasayfa))
        Me.lblbaslik = New System.Windows.Forms.Label()
        Me.txtsoru = New DevExpress.XtraEditors.MemoEdit()
        Me.txtcvpa = New System.Windows.Forms.TextBox()
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblsoru = New System.Windows.Forms.Label()
        Me.btnsoruhazirla = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SORU = New DevExpress.XtraEditors.GroupControl()
        Me.txtcvpd = New System.Windows.Forms.TextBox()
        Me.txtcvpc = New System.Windows.Forms.TextBox()
        Me.txtcvpb = New System.Windows.Forms.TextBox()
        Me.lbld = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.lblb = New System.Windows.Forms.Label()
        CType(Me.txtsoru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SORU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SORU.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblbaslik
        '
        Me.lblbaslik.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblbaslik.AutoSize = True
        Me.lblbaslik.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblbaslik.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblbaslik.Location = New System.Drawing.Point(37, 56)
        Me.lblbaslik.Name = "lblbaslik"
        Me.lblbaslik.Size = New System.Drawing.Size(101, 29)
        Me.lblbaslik.TabIndex = 3
        Me.lblbaslik.Text = "BAŞLIK"
        '
        'txtsoru
        '
        Me.txtsoru.Location = New System.Drawing.Point(94, 71)
        Me.txtsoru.Name = "txtsoru"
        Me.txtsoru.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtsoru.Properties.Appearance.Options.UseFont = True
        Me.txtsoru.Size = New System.Drawing.Size(451, 73)
        Me.txtsoru.TabIndex = 36
        '
        'txtcvpa
        '
        Me.txtcvpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtcvpa.Location = New System.Drawing.Point(127, 170)
        Me.txtcvpa.Name = "txtcvpa"
        Me.txtcvpa.Size = New System.Drawing.Size(418, 28)
        Me.txtcvpa.TabIndex = 28
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbla.Location = New System.Drawing.Point(91, 178)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(30, 17)
        Me.lbla.TabIndex = 24
        Me.lbla.Text = "A-)"
        '
        'lblsoru
        '
        Me.lblsoru.AutoSize = True
        Me.lblsoru.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblsoru.Location = New System.Drawing.Point(39, 95)
        Me.lblsoru.Name = "lblsoru"
        Me.lblsoru.Size = New System.Drawing.Size(57, 17)
        Me.lblsoru.TabIndex = 23
        Me.lblsoru.Text = "SORU :"
        '
        'btnsoruhazirla
        '
        Me.btnsoruhazirla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsoruhazirla.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsoruhazirla.Appearance.Options.UseFont = True
        Me.btnsoruhazirla.Image = CType(resources.GetObject("btnsoruhazirla.Image"), System.Drawing.Image)
        Me.btnsoruhazirla.Location = New System.Drawing.Point(563, 419)
        Me.btnsoruhazirla.Name = "btnsoruhazirla"
        Me.btnsoruhazirla.Size = New System.Drawing.Size(122, 42)
        Me.btnsoruhazirla.TabIndex = 12
        Me.btnsoruhazirla.Text = "ÇIKIŞ"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.lblbaslik)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(711, 103)
        Me.GroupControl1.TabIndex = 11
        Me.GroupControl1.Text = "BAŞLIK"
        '
        'SORU
        '
        Me.SORU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SORU.CaptionImage = CType(resources.GetObject("SORU.CaptionImage"), System.Drawing.Image)
        Me.SORU.Controls.Add(Me.txtcvpd)
        Me.SORU.Controls.Add(Me.txtcvpc)
        Me.SORU.Controls.Add(Me.txtcvpb)
        Me.SORU.Controls.Add(Me.lbld)
        Me.SORU.Controls.Add(Me.lblc)
        Me.SORU.Controls.Add(Me.lblb)
        Me.SORU.Controls.Add(Me.txtsoru)
        Me.SORU.Controls.Add(Me.lblsoru)
        Me.SORU.Controls.Add(Me.lbla)
        Me.SORU.Controls.Add(Me.txtcvpa)
        Me.SORU.Controls.Add(Me.btnsoruhazirla)
        Me.SORU.Location = New System.Drawing.Point(6, 120)
        Me.SORU.Name = "SORU"
        Me.SORU.Size = New System.Drawing.Size(711, 488)
        Me.SORU.TabIndex = 12
        Me.SORU.Text = "SORU"
        '
        'txtcvpd
        '
        Me.txtcvpd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtcvpd.Location = New System.Drawing.Point(127, 303)
        Me.txtcvpd.Name = "txtcvpd"
        Me.txtcvpd.Size = New System.Drawing.Size(418, 28)
        Me.txtcvpd.TabIndex = 42
        '
        'txtcvpc
        '
        Me.txtcvpc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtcvpc.Location = New System.Drawing.Point(127, 258)
        Me.txtcvpc.Name = "txtcvpc"
        Me.txtcvpc.Size = New System.Drawing.Size(418, 28)
        Me.txtcvpc.TabIndex = 41
        '
        'txtcvpb
        '
        Me.txtcvpb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtcvpb.Location = New System.Drawing.Point(127, 216)
        Me.txtcvpb.Name = "txtcvpb"
        Me.txtcvpb.Size = New System.Drawing.Size(418, 28)
        Me.txtcvpb.TabIndex = 40
        '
        'lbld
        '
        Me.lbld.AutoSize = True
        Me.lbld.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbld.Location = New System.Drawing.Point(91, 311)
        Me.lbld.Name = "lbld"
        Me.lbld.Size = New System.Drawing.Size(30, 17)
        Me.lbld.TabIndex = 39
        Me.lbld.Text = "D-)"
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblc.Location = New System.Drawing.Point(91, 266)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(30, 17)
        Me.lblc.TabIndex = 38
        Me.lblc.Text = "C-)"
        '
        'lblb
        '
        Me.lblb.AutoSize = True
        Me.lblb.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblb.Location = New System.Drawing.Point(91, 224)
        Me.lblb.Name = "lblb"
        Me.lblb.Size = New System.Drawing.Size(30, 17)
        Me.lblb.TabIndex = 37
        Me.lblb.Text = "B-)"
        '
        'frmanasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 620)
        Me.Controls.Add(Me.SORU)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.Name = "frmanasayfa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmanasayfa"
        CType(Me.txtsoru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.SORU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SORU.ResumeLayout(False)
        Me.SORU.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblbaslik As System.Windows.Forms.Label
    Friend WithEvents btnsoruhazirla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtsoru As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtcvpa As System.Windows.Forms.TextBox
    Friend WithEvents lbla As System.Windows.Forms.Label
    Friend WithEvents lblsoru As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SORU As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtcvpd As System.Windows.Forms.TextBox
    Friend WithEvents txtcvpc As System.Windows.Forms.TextBox
    Friend WithEvents txtcvpb As System.Windows.Forms.TextBox
    Friend WithEvents lbld As System.Windows.Forms.Label
    Friend WithEvents lblc As System.Windows.Forms.Label
    Friend WithEvents lblb As System.Windows.Forms.Label
End Class
