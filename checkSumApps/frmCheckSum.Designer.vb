<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckSum
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
        Me.txtBineary = New System.Windows.Forms.TextBox()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBinearResult = New System.Windows.Forms.TextBox()
        Me.panelLoading = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPersent = New System.Windows.Forms.Label()
        Me.panelLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBineary
        '
        Me.txtBineary.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBineary.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBineary.ForeColor = System.Drawing.Color.White
        Me.txtBineary.Location = New System.Drawing.Point(12, 25)
        Me.txtBineary.Multiline = True
        Me.txtBineary.Name = "txtBineary"
        Me.txtBineary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBineary.Size = New System.Drawing.Size(288, 392)
        Me.txtBineary.TabIndex = 0
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Location = New System.Drawing.Point(12, 422)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(168, 36)
        Me.cmdGenerate.TabIndex = 1
        Me.cmdGenerate.Text = "Generate Checksum"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResult.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.ForeColor = System.Drawing.Color.White
        Me.txtResult.Location = New System.Drawing.Point(310, 25)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(426, 433)
        Me.txtResult.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Masukkan Kode Binear Disini..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Log Proses..."
        '
        'txtBinearResult
        '
        Me.txtBinearResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBinearResult.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBinearResult.ForeColor = System.Drawing.Color.White
        Me.txtBinearResult.Location = New System.Drawing.Point(12, 464)
        Me.txtBinearResult.Name = "txtBinearResult"
        Me.txtBinearResult.Size = New System.Drawing.Size(708, 32)
        Me.txtBinearResult.TabIndex = 6
        Me.txtBinearResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panelLoading
        '
        Me.panelLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLoading.Controls.Add(Me.lblPersent)
        Me.panelLoading.Controls.Add(Me.Label5)
        Me.panelLoading.Controls.Add(Me.ProgressBar1)
        Me.panelLoading.Controls.Add(Me.Label4)
        Me.panelLoading.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.panelLoading.Location = New System.Drawing.Point(310, 25)
        Me.panelLoading.Name = "panelLoading"
        Me.panelLoading.Size = New System.Drawing.Size(410, 433)
        Me.panelLoading.TabIndex = 7
        Me.panelLoading.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(84, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Data sedang diproses"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(84, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mohon menunggu"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(186, 422)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(114, 36)
        Me.cmdReset.TabIndex = 8
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(60, 195)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(292, 21)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 9
        '
        'lblPersent
        '
        Me.lblPersent.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersent.ForeColor = System.Drawing.Color.White
        Me.lblPersent.Location = New System.Drawing.Point(84, 152)
        Me.lblPersent.Name = "lblPersent"
        Me.lblPersent.Size = New System.Drawing.Size(247, 40)
        Me.lblPersent.TabIndex = 10
        Me.lblPersent.Text = "Mohon menunggu"
        Me.lblPersent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCheckSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(746, 509)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.panelLoading)
        Me.Controls.Add(Me.txtBinearResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.txtBineary)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheckSum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckSum"
        Me.panelLoading.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBineary As System.Windows.Forms.TextBox
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBinearResult As System.Windows.Forms.TextBox
    Friend WithEvents panelLoading As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPersent As System.Windows.Forms.Label

End Class
