<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.chklx = New System.Windows.Forms.CheckBox()
        Me.chkbn = New System.Windows.Forms.CheckBox()
        Me.chksd = New System.Windows.Forms.CheckBox()
        Me.chkhd = New System.Windows.Forms.CheckBox()
        Me.chkhm = New System.Windows.Forms.CheckBox()
        Me.chkam = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chklx
        '
        Me.chklx.AutoSize = True
        Me.chklx.Location = New System.Drawing.Point(21, 26)
        Me.chklx.Name = "chklx"
        Me.chklx.Size = New System.Drawing.Size(103, 17)
        Me.chklx.TabIndex = 0
        Me.chklx.Text = "LaserJet X $100"
        Me.chklx.UseVisualStyleBackColor = True
        '
        'chkbn
        '
        Me.chkbn.AutoSize = True
        Me.chkbn.Location = New System.Drawing.Point(21, 60)
        Me.chkbn.Name = "chkbn"
        Me.chkbn.Size = New System.Drawing.Size(118, 17)
        Me.chkbn.TabIndex = 1
        Me.chkbn.Text = "Big Notebook $500"
        Me.chkbn.UseVisualStyleBackColor = True
        '
        'chksd
        '
        Me.chksd.AutoSize = True
        Me.chksd.Location = New System.Drawing.Point(21, 95)
        Me.chksd.Name = "chksd"
        Me.chksd.Size = New System.Drawing.Size(123, 17)
        Me.chksd.TabIndex = 2
        Me.chksd.Text = "Smart Desktop $200"
        Me.chksd.UseVisualStyleBackColor = True
        '
        'chkhd
        '
        Me.chkhd.AutoSize = True
        Me.chkhd.Location = New System.Drawing.Point(188, 26)
        Me.chkhd.Name = "chkhd"
        Me.chkhd.Size = New System.Drawing.Size(102, 17)
        Me.chkhd.TabIndex = 3
        Me.chkhd.Text = "Hd Digicam $80"
        Me.chkhd.UseVisualStyleBackColor = True
        '
        'chkhm
        '
        Me.chkhm.AutoSize = True
        Me.chkhm.Location = New System.Drawing.Point(188, 60)
        Me.chkhm.Name = "chkhm"
        Me.chkhm.Size = New System.Drawing.Size(113, 17)
        Me.chkhm.TabIndex = 4
        Me.chkhm.Text = "HiTech MP4 $300"
        Me.chkhm.UseVisualStyleBackColor = True
        '
        'chkam
        '
        Me.chkam.AutoSize = True
        Me.chkam.Location = New System.Drawing.Point(188, 95)
        Me.chkam.Name = "chkam"
        Me.chkam.Size = New System.Drawing.Size(118, 17)
        Me.chkam.TabIndex = 5
        Me.chkam.Text = "ADSL modem $150"
        Me.chkam.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total ="
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(79, 200)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(27, 13)
        Me.lbltotal.TabIndex = 7
        Me.lbltotal.Text = "total"
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(188, 158)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(124, 65)
        Me.btncalculate.TabIndex = 8
        Me.btncalculate.Text = "calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 251)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkam)
        Me.Controls.Add(Me.chkhm)
        Me.Controls.Add(Me.chkhd)
        Me.Controls.Add(Me.chksd)
        Me.Controls.Add(Me.chkbn)
        Me.Controls.Add(Me.chklx)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chklx As System.Windows.Forms.CheckBox
    Friend WithEvents chkbn As System.Windows.Forms.CheckBox
    Friend WithEvents chksd As System.Windows.Forms.CheckBox
    Friend WithEvents chkhd As System.Windows.Forms.CheckBox
    Friend WithEvents chkhm As System.Windows.Forms.CheckBox
    Friend WithEvents chkam As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents btncalculate As System.Windows.Forms.Button

End Class
