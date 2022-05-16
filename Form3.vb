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
        button7.Enabled = False
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        UsuarioTextBox.Text = ""
        PasswordTextBox.Text = ""
        NivelTextBox.Text = ""
        textBox4.Text = ""
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        UsuarioTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        NivelTextBox.Enabled = True
        textBox4.Enabled = True
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        MsgBox("Accion Cancelada", vbOKOnly + vbInformation, "OJO")
        NombreTextBox.Clear()
        ApellidoTextBox.Clear()
        PasswordTextBox.Clear()
        UsuarioTextBox.Clear()
        NivelTextBox.Clear()
        textBox4.Clear()
        button1.Enabled = True
        button2.Enabled = True
        button3.Enabled = True
        button4.Enabled = True
        button5.Enabled = False
        button6.Enabled = False
        button7.Enabled = True
        NombreTextBox.Enabled = False
        ApellidoTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        UsuarioTextBox.Enabled = False
        NivelTextBox.Enabled = False
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

    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        If NombreTextBox.Text = "" Or ApellidoTextBox.Text = "" Or UsuarioTextBox.Text = "" Or PasswordTextBox.Text = "" Or textBox4.Text = "" Or NivelTextBox.Text = "" Then
            MsgBox("Hay Campos Vacíos", vbOKOnly + vbInformation, "ADVERTENCIA")

        Else
            MsgBox("Datos Guardados", vbOKOnly + vbInformation, "Exito")
            Me.UsuariosTableAdapter.ingresar(NombreTextBox.Text, ApellidoTextBox.Text, UsuarioTextBox.Text, PasswordTextBox.Text, NivelTextBox.Text)
            Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)
            Me.UsuariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)
            button6.Enabled = False
            button5.Enabled = False
            button1.Enabled = True
            button2.Enabled = True
            button3.Enabled = True
            button4.Enabled = True
            button7.Enabled = True
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label8.Click

    End Sub

    Private Sub label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label7.Click

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        Form4.Show()
        Me.Close()
    End Sub
End Class