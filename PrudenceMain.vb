Imports System.Drawing.Printing

Public Class PrudenceMain
    Dim MI As Bitmap
    Private Sub AddTabButtonTS_Click_1(sender As Object, e As EventArgs) Handles AddTabButtonTS.Click
        Dim NPC As New PrudenceControl With {.Dock = DockStyle.Fill, .BackColor = Color.White}
        Dim NTP As New TabPage With {.Text = "New List"}
        NTP.Controls.Add(NPC)
        PrudenceTabControl.TabPages.Add(NTP)
        PrudenceTabControl.SelectedTab = NTP
        TabCountLabel.Text = "Tabs: " & PrudenceTabControl.TabPages.Count.ToString()
        Text = "Prudence (" & PrudenceTabControl.TabPages.Count.ToString() & " Tabs)"
        RemoveTabButtonTS.Enabled = True
    End Sub
    Private Sub RemoveTabButtonTS_Click(sender As Object, e As EventArgs) Handles RemoveTabButtonTS.Click
        PrudenceTabControl.TabPages.Remove(PrudenceTabControl.SelectedTab)
        TabCountLabel.Text = "Tabs: " & PrudenceTabControl.TabPages.Count.ToString()
        Text = "Prudence (" & PrudenceTabControl.TabPages.Count.ToString() & " Tabs)"
        If PrudenceTabControl.TabPages.Count = 1 Then
            TabCountLabel.Text = "Tabs: 1"
            Text = "Prudence (1 Tab)"
            RemoveTabButtonTS.Enabled = False
        End If
    End Sub
    Private Sub NewWindowButtonTS_Click(sender As Object, e As EventArgs) Handles NewWindowButtonTS.Click
        Dim NW As New PrudenceMain
        NW.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(MI, 0, 0)
    End Sub
    Private Sub PrintButtonTS_Click(sender As Object, e As EventArgs) Handles PrintButtonTS.Click
        Dim MG As Graphics = CreateGraphics()
        Dim S As Size = Size
        MI = New Bitmap(S.Width, S.Height, MG)
        Dim MEMG As Graphics = Graphics.FromImage(MI)
        MEMG.CopyFromScreen(Location.X, Location.Y, 0, 0, S)
        PrintDocument1.Print()
    End Sub
End Class