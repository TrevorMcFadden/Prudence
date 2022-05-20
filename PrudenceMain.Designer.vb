<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrudenceMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrudenceMain))
        Me.PrudenceTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PrudenceControl1 = New Prudence.PrudenceControl()
        Me.PrudenceToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AddTabButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.RemoveTabButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabCountLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PrintButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewWindowButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrudenceTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PrudenceToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrudenceTabControl
        '
        Me.PrudenceTabControl.Controls.Add(Me.TabPage1)
        Me.PrudenceTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrudenceTabControl.Location = New System.Drawing.Point(0, 25)
        Me.PrudenceTabControl.Name = "PrudenceTabControl"
        Me.PrudenceTabControl.SelectedIndex = 0
        Me.PrudenceTabControl.Size = New System.Drawing.Size(800, 425)
        Me.PrudenceTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PrudenceControl1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(792, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PrudenceControl1
        '
        Me.PrudenceControl1.BackColor = System.Drawing.Color.White
        Me.PrudenceControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrudenceControl1.Location = New System.Drawing.Point(0, 0)
        Me.PrudenceControl1.Name = "PrudenceControl1"
        Me.PrudenceControl1.Size = New System.Drawing.Size(792, 397)
        Me.PrudenceControl1.TabIndex = 0
        '
        'PrudenceToolStrip
        '
        Me.PrudenceToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PrudenceToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTabButtonTS, Me.RemoveTabButtonTS, Me.ToolStripSeparator1, Me.TabCountLabel, Me.PrintButtonTS, Me.ToolStripSeparator2, Me.NewWindowButtonTS})
        Me.PrudenceToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.PrudenceToolStrip.Name = "PrudenceToolStrip"
        Me.PrudenceToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.PrudenceToolStrip.TabIndex = 1
        Me.PrudenceToolStrip.Text = "PrudenceToolStrip"
        '
        'AddTabButtonTS
        '
        Me.AddTabButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddTabButtonTS.Image = CType(resources.GetObject("AddTabButtonTS.Image"), System.Drawing.Image)
        Me.AddTabButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddTabButtonTS.Name = "AddTabButtonTS"
        Me.AddTabButtonTS.Size = New System.Drawing.Size(33, 22)
        Me.AddTabButtonTS.Text = "Add"
        Me.AddTabButtonTS.ToolTipText = "Add a tab"
        '
        'RemoveTabButtonTS
        '
        Me.RemoveTabButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RemoveTabButtonTS.Enabled = False
        Me.RemoveTabButtonTS.Image = CType(resources.GetObject("RemoveTabButtonTS.Image"), System.Drawing.Image)
        Me.RemoveTabButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveTabButtonTS.Name = "RemoveTabButtonTS"
        Me.RemoveTabButtonTS.Size = New System.Drawing.Size(54, 22)
        Me.RemoveTabButtonTS.Text = "Remove"
        Me.RemoveTabButtonTS.ToolTipText = "Remove a tab"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TabCountLabel
        '
        Me.TabCountLabel.Name = "TabCountLabel"
        Me.TabCountLabel.Size = New System.Drawing.Size(42, 22)
        Me.TabCountLabel.Text = "Tabs: 1"
        '
        'PrintButtonTS
        '
        Me.PrintButtonTS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PrintButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintButtonTS.Image = CType(resources.GetObject("PrintButtonTS.Image"), System.Drawing.Image)
        Me.PrintButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintButtonTS.Name = "PrintButtonTS"
        Me.PrintButtonTS.Size = New System.Drawing.Size(36, 22)
        Me.PrintButtonTS.Text = "Print"
        Me.PrintButtonTS.ToolTipText = "Print the form"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NewWindowButtonTS
        '
        Me.NewWindowButtonTS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.NewWindowButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewWindowButtonTS.Image = CType(resources.GetObject("NewWindowButtonTS.Image"), System.Drawing.Image)
        Me.NewWindowButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewWindowButtonTS.Name = "NewWindowButtonTS"
        Me.NewWindowButtonTS.Size = New System.Drawing.Size(44, 22)
        Me.NewWindowButtonTS.Text = "New..."
        Me.NewWindowButtonTS.ToolTipText = "Launch a new window"
        '
        'PrintDocument1
        '
        '
        'PrudenceMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PrudenceTabControl)
        Me.Controls.Add(Me.PrudenceToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrudenceMain"
        Me.Text = "Prudence (1 Tab)"
        Me.PrudenceTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PrudenceToolStrip.ResumeLayout(False)
        Me.PrudenceToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrudenceTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PrudenceToolStrip As ToolStrip
    Friend WithEvents AddTabButtonTS As ToolStripButton
    Friend WithEvents RemoveTabButtonTS As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TabCountLabel As ToolStripLabel
    Friend WithEvents NewWindowButtonTS As ToolStripButton
    Friend WithEvents PrintButtonTS As ToolStripButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PrudenceControl1 As PrudenceControl
End Class
