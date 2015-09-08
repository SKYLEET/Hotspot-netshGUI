Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell(My.Computer.FileSystem.GetParentPath(Environment.SystemDirectory) & "\System32\control.exe ncpa.cpl", 1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("mailto:yadavsunil4796@gmail.com")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Share"
        Me.Icon = My.Resources._1441727650_rss_01

    End Sub
End Class