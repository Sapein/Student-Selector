<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMode = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuModeTextFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuModeDirectInput = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRandom = New System.Windows.Forms.Button
        Me.btnSelectFile = New System.Windows.Forms.Button
        Me.btnInputNames = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.lblOutput = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMode, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(103, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuMode
        '
        Me.mnuMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModeTextFile, Me.ToolStripMenuItem1, Me.mnuModeDirectInput})
        Me.mnuMode.Name = "mnuMode"
        Me.mnuMode.Size = New System.Drawing.Size(45, 20)
        Me.mnuMode.Text = "&Mode"
        '
        'mnuModeTextFile
        '
        Me.mnuModeTextFile.Checked = True
        Me.mnuModeTextFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuModeTextFile.Name = "mnuModeTextFile"
        Me.mnuModeTextFile.Size = New System.Drawing.Size(142, 22)
        Me.mnuModeTextFile.Text = "&Text Mode"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(139, 6)
        '
        'mnuModeDirectInput
        '
        Me.mnuModeDirectInput.Name = "mnuModeDirectInput"
        Me.mnuModeDirectInput.Size = New System.Drawing.Size(142, 22)
        Me.mnuModeDirectInput.Text = "&Direct Input"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(12, 31)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(75, 23)
        Me.btnRandom.TabIndex = 1
        Me.btnRandom.Text = "Randomize!"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(205, 31)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectFile.TabIndex = 2
        Me.btnSelectFile.Text = "Select File"
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'btnInputNames
        '
        Me.btnInputNames.Location = New System.Drawing.Point(205, 78)
        Me.btnInputNames.Name = "btnInputNames"
        Me.btnInputNames.Size = New System.Drawing.Size(75, 23)
        Me.btnInputNames.TabIndex = 3
        Me.btnInputNames.Text = "Input Names"
        Me.btnInputNames.UseVisualStyleBackColor = True
        Me.btnInputNames.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Apps (*.txt)|*.txt|All files (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Select File"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblOutput.Location = New System.Drawing.Point(118, 58)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(292, 78)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnInputNames)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Student Selector"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModeDirectInput As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModeTextFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents btnSelectFile As System.Windows.Forms.Button
    Friend WithEvents btnInputNames As System.Windows.Forms.Button
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator

End Class
