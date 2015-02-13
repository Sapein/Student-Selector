<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.lblProgram = New System.Windows.Forms.Label
        Me.lblTeam = New System.Windows.Forms.Label
        Me.txtLiscense = New System.Windows.Forms.TextBox
        Me.lblGithub = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.ForeColor = System.Drawing.Color.White
        Me.lblProgram.Location = New System.Drawing.Point(240, 9)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(149, 13)
        Me.lblProgram.TabIndex = 0
        Me.lblProgram.Text = "Student Selector v1.0.2 Alpha"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.ForeColor = System.Drawing.Color.White
        Me.lblTeam.Location = New System.Drawing.Point(247, 34)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(135, 13)
        Me.lblTeam.TabIndex = 1
        Me.lblTeam.Text = "Chandler Wise - Everything"
        '
        'txtLiscense
        '
        Me.txtLiscense.BackColor = System.Drawing.Color.Blue
        Me.txtLiscense.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtLiscense.ForeColor = System.Drawing.Color.White
        Me.txtLiscense.Location = New System.Drawing.Point(62, 84)
        Me.txtLiscense.Multiline = True
        Me.txtLiscense.Name = "txtLiscense"
        Me.txtLiscense.ReadOnly = True
        Me.txtLiscense.Size = New System.Drawing.Size(505, 298)
        Me.txtLiscense.TabIndex = 2
        Me.txtLiscense.Text = resources.GetString("txtLiscense.Text")
        Me.txtLiscense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.ForeColor = System.Drawing.Color.White
        Me.lblGithub.Location = New System.Drawing.Point(149, 59)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(330, 13)
        Me.lblGithub.TabIndex = 3
        Me.lblGithub.Text = "Project Now on Github: https://github.com/Sapein/Student-Selector"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(613, 394)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.txtLiscense)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.lblProgram)
        Me.Name = "About"
        Me.Text = "Student Selector - About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents lblTeam As System.Windows.Forms.Label
    Friend WithEvents txtLiscense As System.Windows.Forms.TextBox
    Friend WithEvents lblGithub As System.Windows.Forms.Label
End Class
