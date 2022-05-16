Public Class Form2

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label8.Text = DateTime.Now.ToShortTimeString
        Me.Label9.Text = DateTime.Now.ToLongDateString
    End Sub

End Class