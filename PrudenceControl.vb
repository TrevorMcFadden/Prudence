Imports System.IO

Public Class PrudenceControl
    'AddItemBox subroutine
    Private Sub AddItemBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AddItemBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(AddItemBox.Text) Then
                MsgBox("Write in an item before adding it to the list", vbCritical, "Empty Textbox")
            Else
                PrudenceListBox.Items.Add(AddItemBox.Text.ToString())
                AddItemBox.Focus()
                ItemCountLabel.Text = PrudenceListBox.Items.Count & " items"
                If PrudenceListBox.Items.Count = 1 Then
                    ItemCountLabel.Text = "1 item"
                End If
                PrudenceNotifyIcon.ShowBalloonTip(3000)
                PrudenceNotifyIcon.BalloonTipText = AddItemBox.Text.ToString() & " was added to the list"
                RemoveButtonTS.Enabled = True
                ClearListButtonTS.Enabled = True
                EditButtonTS.Enabled = True
                ChangeFontButtonTS.Enabled = True
            End If
        End If
    End Sub
    'PrudenceControl subroutine
    Private Sub MyBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddItemBox.Controls.Add(ActiveControl)
        PrudenceTimer.Start()
    End Sub
    'PrudenceTabControl subroutines
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click, AddButtonTS.Click
        If String.IsNullOrEmpty(AddItemBox.Text) Then
            MsgBox("Write in an item before adding it to the list", vbCritical, "Empty Textbox")
        Else
            PrudenceListBox.Items.Add(AddItemBox.Text.ToString())
            AddItemBox.Focus()
            ItemCountLabel.Text = PrudenceListBox.Items.Count & " items"
            If PrudenceListBox.Items.Count = 1 Then
                ItemCountLabel.Text = "1 item"
            End If
            PrudenceNotifyIcon.ShowBalloonTip(3000)
            PrudenceNotifyIcon.BalloonTipText = AddItemBox.Text.ToString() & " was added to the list"
            RemoveButtonTS.Enabled = True
            ClearListButtonTS.Enabled = True
            EditButtonTS.Enabled = True
            ChangeFontButtonTS.Enabled = True
        End If
    End Sub
    Private Sub RemoveButtonTS_Click(sender As Object, e As EventArgs) Handles RemoveButtonTS.Click
        Dim IFD
        IFD = PrudenceListBox.SelectedItem
        PrudenceListBox.Items.Remove(IFD)
        ItemCountLabel.Text = PrudenceListBox.Items.Count & " items"
        If PrudenceListBox.Items.Count = 1 Then
            ItemCountLabel.Text = "1 item"
        End If
        If PrudenceListBox.Items.Count = 0 Then
            RemoveButtonTS.Enabled = False
            ClearListButtonTS.Enabled = False
            EditButtonTS.Enabled = False
            ChangeFontButtonTS.Enabled = False
        End If
    End Sub
    Private Sub EditButtonTS_Click(sender As Object, e As EventArgs) Handles EditButtonTS.Click
        Dim SII As Integer = PrudenceListBox.Items.IndexOf(PrudenceListBox.SelectedItem)
        Dim ETI As String
        Dim ITM As Object = PrudenceListBox.Items.Item(SII)
        Dim INDX As Integer = PrudenceListBox.Items.IndexOf(ITM)
        ETI = InputBox("Edit the selected item to your desired item.", "Edit Item")
        PrudenceListBox.Items.Remove(PrudenceListBox.SelectedItem)
        PrudenceListBox.Items.Insert(INDX, ETI)
    End Sub
    Private Sub ClearListButtonTS_Click(sender As Object, e As EventArgs) Handles ClearListButtonTS.Click
        PrudenceListBox.Items.Clear()
        ItemCountLabel.Text = PrudenceListBox.Items.Count & " items"
        PrudenceNotifyIcon.ShowBalloonTip(3000)
        PrudenceNotifyIcon.BalloonTipText = "Your list was cleared"
        RemoveButtonTS.Enabled = False
        ClearListButtonTS.Enabled = False
        EditButtonTS.Enabled = False
        ChangeFontButtonTS.Enabled = False
    End Sub
    Private Sub ListTitleBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ListTitleBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PrudenceMain.PrudenceTabControl.SelectedTab.Text = ListTitleBox.Text.ToString()
        End If
    End Sub
    Private Sub CalendarButtonTS_Click(sender As Object, e As EventArgs) Handles CalendarButtonTS.Click
        Dim PC As New PrudenceCalendar
        PC.Show()
    End Sub
    Private Sub OpenButtonTS_Click(sender As Object, e As EventArgs) Handles OpenButtonTS.Click
        If PrudenceOpenFileDialog.ShowDialog() = DialogResult.OK Then
            Dim L = File.ReadAllLines(PrudenceOpenFileDialog.FileName)
            PrudenceListBox.Items.Clear()
            PrudenceListBox.Items.AddRange(L)
            PrudenceMain.PrudenceTabControl.SelectedTab.Text = PrudenceOpenFileDialog.FileName.ToString()
            ListTitleBox.Text = PrudenceOpenFileDialog.FileName.ToString()
            ItemCountLabel.Text = PrudenceListBox.Items.Count & " items"
            RemoveButtonTS.Enabled = True
            ClearListButtonTS.Enabled = True
            EditButtonTS.Enabled = True
            ChangeFontButtonTS.Enabled = True
            If PrudenceListBox.Items.Count = 1 Then
                ItemCountLabel.Text = "1 item"
            End If
            If PrudenceListBox.Items.Count = 0 Then
                RemoveButtonTS.Enabled = False
                ClearListButtonTS.Enabled = False
                EditButtonTS.Enabled = False
                ChangeFontButtonTS.Enabled = False
            End If
        End If
    End Sub
    Private Sub SaveButtonTS_Click(sender As Object, e As EventArgs) Handles SaveButtonTS.Click
        PrudenceSaveFileDialog.FileName = ListTitleBox.Text.ToString()
        If PrudenceSaveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim SB As New Text.StringBuilder()
            For Each o As Object In PrudenceListBox.Items
                SB.AppendLine(o)
            Next
            File.WriteAllText(PrudenceSaveFileDialog.FileName, SB.ToString())
        End If
    End Sub
    Private Sub ChangeFontButtonTS_Click(sender As Object, e As EventArgs) Handles ChangeFontButtonTS.Click
        If PrudenceFontDialog.ShowDialog() = DialogResult.OK Then
            Font = PrudenceFontDialog.Font
        End If
    End Sub
    'PrudenceTimer subroutine
    Private Sub PrudenceTimer_Tick(sender As Object, e As EventArgs) Handles PrudenceTimer.Tick
        DateTimeLabel.Text = Date.Now.ToString("dddd, M/d/yyyy, h:mm tt")
    End Sub
End Class