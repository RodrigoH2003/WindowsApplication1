Public Class Form6

    Private Sub MotivoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MotivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Creacion' Puede moverla o quitarla según sea necesario.
        Me.CreacionTableAdapter1.CreacionF(Me.VeterinariaDataSet.Creacion)
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet1.Creacion' Puede moverla o quitarla según sea necesario.
        Me.CreacionTableAdapter.Fill(Me.VeterinariaDataSet1.Creacion)
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Motivo' Puede moverla o quitarla según sea necesario.
        Me.MotivoTableAdapter.Mot(Me.VeterinariaDataSet.Motivo)
        Me.Timer1.Enabled = True
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label22.Text = DateTime.Now.ToShortTimeString
        Me.Label21.Text = DateTime.Now.ToLongDateString
    End Sub
End Class