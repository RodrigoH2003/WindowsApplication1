Public Class Form9

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)
        Me.Timer1.Enabled = True
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        MsgBox("Usuario Borrado", vbOKOnly + vbInformation, "Exito")
        UsuariosDataGridView.Enabled = False
        Me.UsuariosTableAdapter.borrar(IdTextBox.Text)
        Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        MsgBox("Datos Editados", vbOKOnly + vbInformation, "Exito")
        Me.UsuariosTableAdapter.ingresar(NombreTextBox.Text, ApellidoTextBox.Text, UsuarioTextBox.Text, PasswordTextBox.Text, NivelTextBox.Text)
        Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label22.Text = DateTime.Now.ToShortTimeString
        Me.Label21.Text = DateTime.Now.ToLongDateString
    End Sub

End Class