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
        Me.components = New System.ComponentModel.Container()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PrbProgres = New System.Windows.Forms.ProgressBar()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblDevelopper = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AccessibleName = ""
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(313, 23)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(251, 39)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "SCHOOL SYS"
        '
        'PrbProgres
        '
        Me.PrbProgres.ForeColor = System.Drawing.Color.LimeGreen
        Me.PrbProgres.Location = New System.Drawing.Point(1, 231)
        Me.PrbProgres.Name = "PrbProgres"
        Me.PrbProgres.Size = New System.Drawing.Size(853, 13)
        Me.PrbProgres.Step = 1
        Me.PrbProgres.TabIndex = 1
        '
        'LblVersion
        '
        Me.LblVersion.AccessibleName = "frmSplash"
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.Location = New System.Drawing.Point(656, 412)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(0, 29)
        Me.LblVersion.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LblDevelopper
        '
        Me.LblDevelopper.AccessibleName = "frmSplash"
        Me.LblDevelopper.AutoSize = True
        Me.LblDevelopper.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDevelopper.Location = New System.Drawing.Point(12, 412)
        Me.LblDevelopper.Name = "LblDevelopper"
        Me.LblDevelopper.Size = New System.Drawing.Size(0, 29)
        Me.LblDevelopper.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(855, 450)
        Me.Controls.Add(Me.LblDevelopper)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.PrbProgres)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents PrbProgres As ProgressBar
    Friend WithEvents LblVersion As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblDevelopper As Label
End Class
