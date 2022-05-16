Public Class Form9

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)

    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        MsgBox("Paciente Borrado", vbOKOnly + vbInformation, "Exito")
        Me.UsuariosTableAdapter.borrar(IdTextBox.Text)
        Me.UsuariosTableAdapter.Fill(Me.VeterinariaDataSet.usuarios)
    End Sub
End Class