Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        If Me.UsuariosTableAdapter.Buscardato(Me.VeterinariaDataSet.usuarios, UsuarioTextBox.Text, PasswordTextBox.Text) Then
            MsgBox("Inicio de Sesion Exitoso", vbOKOnly + vbInformation, "SuccesFull")
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Datos Erroneos!!!", vbOKOnly + vbInformation, "Error")
        End If
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)
        UsuarioTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub UsuarioTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsuarioTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub UsuarioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            button3.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged
    
    End Sub
End Class
