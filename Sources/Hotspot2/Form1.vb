Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("netsh wlan Set hostednetwork mode=allow", 0)
        Shell("netsh wlan set hostednetwork ssid=" + TextBox1.Text, 0)
        Shell("netsh wlan set hostednetwork key=" + TextBox2.Text, 0)
        Shell("netsh wlan start hostednetwork", 0)
        MsgBox("Done! Now go and Share your Internet.")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://skyleet.net/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hotspot GUI by SKY"
        TextBox1.Text = "SKYN3T"
        TextBox2.Text = "12345678"
        Me.BackColor = ColorTranslator.FromHtml("#697a84")
        Me.Icon = My.Resources._1441727650_rss_01
    End Sub
End Class
