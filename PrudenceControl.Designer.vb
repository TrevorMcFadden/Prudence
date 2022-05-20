<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrudenceControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrudenceControl))
        Me.PrudenceToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AddButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.RemoveButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemCountLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ClearListButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeFontButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.SaveButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ListTitleLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ListTitleBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateTimeLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CalendarButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.PrudenceListBox = New System.Windows.Forms.ListBox()
        Me.AddItemBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.PrudenceFontDialog = New System.Windows.Forms.FontDialog()
        Me.PrudenceOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.PrudenceSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PrudenceNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PrudenceTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PrudenceToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrudenceToolStrip
        '
        Me.PrudenceToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PrudenceToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddButtonTS, Me.RemoveButtonTS, Me.ToolStripSeparator1, Me.ItemCountLabel, Me.ToolStripSeparator5, Me.EditButtonTS, Me.ClearListButtonTS, Me.ToolStripSeparator2, Me.ChangeFontButtonTS, Me.ToolStripSeparator3, Me.OpenButtonTS, Me.SaveButtonTS, Me.ListTitleLabel, Me.ListTitleBox, Me.ToolStripSeparator4, Me.DateTimeLabel, Me.CalendarButtonTS})
        Me.PrudenceToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.PrudenceToolStrip.Name = "PrudenceToolStrip"
        Me.PrudenceToolStrip.Size = New System.Drawing.Size(727, 25)
        Me.PrudenceToolStrip.TabIndex = 0
        Me.PrudenceToolStrip.Text = "ToolStrip1"
        '
        'AddButtonTS
        '
        Me.AddButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddButtonTS.Image = CType(resources.GetObject("AddButtonTS.Image"), System.Drawing.Image)
        Me.AddButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddButtonTS.Name = "AddButtonTS"
        Me.AddButtonTS.Size = New System.Drawing.Size(23, 22)
        Me.AddButtonTS.Text = "+"
        Me.AddButtonTS.ToolTipText = "Add an item"
        '
        'RemoveButtonTS
        '
        Me.RemoveButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RemoveButtonTS.Enabled = False
        Me.RemoveButtonTS.Image = CType(resources.GetObject("RemoveButtonTS.Image"), System.Drawing.Image)
        Me.RemoveButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveButtonTS.Name = "RemoveButtonTS"
        Me.RemoveButtonTS.Size = New System.Drawing.Size(23, 22)
        Me.RemoveButtonTS.Text = "-"
        Me.RemoveButtonTS.ToolTipText = "Remove an item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ItemCountLabel
        '
        Me.ItemCountLabel.Name = "ItemCountLabel"
        Me.ItemCountLabel.Size = New System.Drawing.Size(45, 22)
        Me.ItemCountLabel.Text = "0 items"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'EditButtonTS
        '
        Me.EditButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditButtonTS.Enabled = False
        Me.EditButtonTS.Image = CType(resources.GetObject("EditButtonTS.Image"), System.Drawing.Image)
        Me.EditButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditButtonTS.Name = "EditButtonTS"
        Me.EditButtonTS.Size = New System.Drawing.Size(23, 22)
        Me.EditButtonTS.Text = "✏️"
        Me.EditButtonTS.ToolTipText = "Edit the selected item"
        '
        'ClearListButtonTS
        '
        Me.ClearListButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearListButtonTS.Enabled = False
        Me.ClearListButtonTS.Image = CType(resources.GetObject("ClearListButtonTS.Image"), System.Drawing.Image)
        Me.ClearListButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearListButtonTS.Name = "ClearListButtonTS"
        Me.ClearListButtonTS.Size = New System.Drawing.Size(23, 22)
        Me.ClearListButtonTS.Text = "🗑️"
        Me.ClearListButtonTS.ToolTipText = "Clear the list"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ChangeFontButtonTS
        '
        Me.ChangeFontButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ChangeFontButtonTS.Enabled = False
        Me.ChangeFontButtonTS.Image = CType(resources.GetObject("ChangeFontButtonTS.Image"), System.Drawing.Image)
        Me.ChangeFontButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChangeFontButtonTS.Name = "ChangeFontButtonTS"
        Me.ChangeFontButtonTS.Size = New System.Drawing.Size(25, 22)
        Me.ChangeFontButtonTS.Text = "Aa"
        Me.ChangeFontButtonTS.ToolTipText = "Change the font of the list"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'OpenButtonTS
        '
        Me.OpenButtonTS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpenButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OpenButtonTS.Image = CType(resources.GetObject("OpenButtonTS.Image"), System.Drawing.Image)
        Me.OpenButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenButtonTS.Name = "OpenButtonTS"
        Me.OpenButtonTS.Size = New System.Drawing.Size(23, 22)
        Me.OpenButtonTS.Text = "📂"
        Me.OpenButtonTS.ToolTipText = "Open an existing list"
        '
        'SaveButtonTS
        '
        Me.SaveButtonTS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SaveButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveButtonTS.Image = CType(resources.GetObject("SaveButtonTS.Image"), System.Drawing.Image)
        Me.SaveButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButtonTS.Name = "SaveButtonTS"
        Me.SaveButtonTS.Size = New System.Drawing.Size(23, 22)
        Me.SaveButtonTS.Text = "💾"
        Me.SaveButtonTS.ToolTipText = "Save your list"
        '
        'ListTitleLabel
        '
        Me.ListTitleLabel.Name = "ListTitleLabel"
        Me.ListTitleLabel.Size = New System.Drawing.Size(28, 22)
        Me.ListTitleLabel.Text = "List:"
        '
        'ListTitleBox
        '
        Me.ListTitleBox.Name = "ListTitleBox"
        Me.ListTitleBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(171, 22)
        Me.DateTimeLabel.Text = "Saturday, 12/25/2022, 12:00 PM"
        '
        'CalendarButtonTS
        '
        Me.CalendarButtonTS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CalendarButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CalendarButtonTS.Image = CType(resources.GetObject("CalendarButtonTS.Image"), System.Drawing.Image)
        Me.CalendarButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CalendarButtonTS.Name = "CalendarButtonTS"
        Me.CalendarButtonTS.Size = New System.Drawing.Size(23, 22)
        Me.CalendarButtonTS.Text = "📅"
        Me.CalendarButtonTS.ToolTipText = "Open the calendar"
        '
        'PrudenceListBox
        '
        Me.PrudenceListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrudenceListBox.BackColor = System.Drawing.Color.White
        Me.PrudenceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PrudenceListBox.FormattingEnabled = True
        Me.PrudenceListBox.ItemHeight = 15
        Me.PrudenceListBox.Location = New System.Drawing.Point(3, 28)
        Me.PrudenceListBox.Name = "PrudenceListBox"
        Me.PrudenceListBox.Size = New System.Drawing.Size(721, 315)
        Me.PrudenceListBox.TabIndex = 1
        '
        'AddItemBox
        '
        Me.AddItemBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddItemBox.Location = New System.Drawing.Point(3, 356)
        Me.AddItemBox.Name = "AddItemBox"
        Me.AddItemBox.Size = New System.Drawing.Size(640, 23)
        Me.AddItemBox.TabIndex = 2
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Location = New System.Drawing.Point(649, 356)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'PrudenceOpenFileDialog
        '
        Me.PrudenceOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        Me.PrudenceOpenFileDialog.Title = "Prudence: Open File"
        '
        'PrudenceSaveFileDialog
        '
        Me.PrudenceSaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        Me.PrudenceSaveFileDialog.Title = "Prudence: Save File"
        '
        'PrudenceNotifyIcon
        '
        Me.PrudenceNotifyIcon.BalloonTipText = "An item was added to the list"
        Me.PrudenceNotifyIcon.BalloonTipTitle = "Item Added"
        Me.PrudenceNotifyIcon.Icon = CType(resources.GetObject("PrudenceNotifyIcon.Icon"), System.Drawing.Icon)
        Me.PrudenceNotifyIcon.Text = "Prudence Notification"
        Me.PrudenceNotifyIcon.Visible = True
        '
        'PrudenceTimer
        '
        '
        'PrudenceControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.AddItemBox)
        Me.Controls.Add(Me.PrudenceListBox)
        Me.Controls.Add(Me.PrudenceToolStrip)
        Me.Name = "PrudenceControl"
        Me.Size = New System.Drawing.Size(727, 382)
        Me.PrudenceToolStrip.ResumeLayout(False)
        Me.PrudenceToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrudenceToolStrip As ToolStrip
    Friend WithEvents AddButtonTS As ToolStripButton
    Friend WithEvents RemoveButtonTS As ToolStripButton
    Friend WithEvents EditButtonTS As ToolStripButton
    Friend WithEvents ClearListButtonTS As ToolStripButton
    Friend WithEvents ChangeFontButtonTS As ToolStripButton
    Friend WithEvents OpenButtonTS As ToolStripButton
    Friend WithEvents PrudenceListBox As ListBox
    Friend WithEvents AddItemBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents SaveButtonTS As ToolStripButton
    Friend WithEvents ListTitleLabel As ToolStripLabel
    Friend WithEvents ListTitleBox As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PrudenceFontDialog As FontDialog
    Friend WithEvents PrudenceOpenFileDialog As OpenFileDialog
    Friend WithEvents DateTimeLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ItemCountLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents PrudenceSaveFileDialog As SaveFileDialog
    Friend WithEvents PrudenceNotifyIcon As NotifyIcon
    Friend WithEvents PrudenceTimer As Timer
    Friend WithEvents CalendarButtonTS As ToolStripButton
End Class
