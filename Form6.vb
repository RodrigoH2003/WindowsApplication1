Public Class Form6

    Private Sub MotivoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MotivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet1.Creacion' Puede moverla o quitarla según sea necesario.
        Me.CreacionTableAdapter.Fill(Me.VeterinariaDataSet1.Creacion)
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Motivo' Puede moverla o quitarla según sea necesario.
        Me.MotivoTableAdapter.Mot(Me.VeterinariaDataSet.Motivo)

    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class