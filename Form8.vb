Public Class Form8

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim mensaje As String
        If TextBox1.Text = "" Then
            mensaje = MsgBox("Rellenar la Casilla de Busqueda", vbCritical, "OJO")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            MsgBox("Seleccionar una opcion de busqueda", vbCritical, "OJO")

        End If
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Form6.Show()
        Me.Close()
    End Sub
End Class