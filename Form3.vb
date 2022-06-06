Public Class Form3

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        button5.Enabled = True
        CheckBox1.Enabled = True
        button1.Enabled = False
        button3.Enabled = False
        button4.Enabled = False
        button2.Enabled = False
        button6.Enabled = True
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        UsuarioTextBox.Text = ""
        PasswordTextBox.Text = ""
        NivelComboBox.Text = ""
        textBox4.Text = ""
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        UsuarioTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        NivelComboBox.Enabled = True
        textBox4.Enabled = True
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        MsgBox("Accion Cancelada", vbOKOnly + vbInformation, "OJO")
        NombreTextBox.Clear()
        ApellidoTextBox.Clear()
        PasswordTextBox.Clear()
        UsuarioTextBox.Clear()
        NivelComboBox.ResetText()
        textBox4.Clear()
        button1.Enabled = True
        button2.Enabled = True
        button3.Enabled = True
        button4.Enabled = True
        button5.Enabled = False
        button6.Enabled = False
        NombreTextBox.Enabled = False
        ApellidoTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        UsuarioTextBox.Enabled = False
        NivelComboBox.Enabled = False
        textBox4.Enabled = False
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

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)

        Me.UsuariosBindingSource.AddNew()
        Me.Timer1.Enabled = True
    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        If NombreTextBox.Text = "" Or ApellidoTextBox.Text = "" Or UsuarioTextBox.Text = "" Or PasswordTextBox.Text = "" Or textBox4.Text = "" Or NivelComboBox.Text = "" Then
            MsgBox("Hay Campos Vacíos", vbOKOnly + vbInformation, "ADVERTENCIA")
        ElseIf PasswordTextBox.Text <> textBox4.Text Then
            MsgBox("Las contraseñas no coinciden, vuela a introducirlas por favor", vbOKOnly + vbInformation, "ADVERTENCIA")
        Else
            MsgBox("Datos Guardados", vbOKOnly + vbInformation, "Exito")
            Me.UsuariosTableAdapter.ingresar(NombreTextBox.Text, ApellidoTextBox.Text, UsuarioTextBox.Text, PasswordTextBox.Text, NivelComboBox.Text)
            Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)
            Me.UsuariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)
            button6.Enabled = False
            button5.Enabled = False
            button1.Enabled = True
            button2.Enabled = True
            button3.Enabled = True
            button4.Enabled = True
            NombreTextBox.Enabled = False
            ApellidoTextBox.Enabled = False
            PasswordTextBox.Enabled = False
            UsuarioTextBox.Enabled = False
            textBox4.Enabled = False
            NivelComboBox.Enabled = False
            CheckBox1.Enabled = False
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label22.Text = DateTime.Now.ToShortTimeString
        Me.Label21.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub NombreTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ApellidoTextBox.Focus()
        End If
    End Sub

    Private Sub NombreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreTextBox.TextChanged

    End Sub

    Private Sub ApellidoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            UsuarioTextBox.Focus()
        End If
    End Sub

    Private Sub ApellidoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApellidoTextBox.TextChanged

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
            textBox4.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub textBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox4.KeyPress
        If Asc(e.KeyChar) = 13 Then
            NivelComboBox.Focus()
        End If
    End Sub

    Private Sub textBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox4.TextChanged

    End Sub

    Private Sub NivelComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NivelComboBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            button6.Focus()
        End If
    End Sub

    Private Sub NivelComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NivelComboBox.SelectedIndexChanged

    End Sub
End Class