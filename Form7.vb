Public Class Form7


    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        MsgBox("Accion Cancelada", vbOKOnly + vbInformation, "OJO")
        AsuntoTextBox.Clear()
        RecetaTextBox.Clear()
        FechaDateTimePicker.ResetText()
        TotalTextBox.Clear()
    End Sub

    Private Sub MotivoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MotivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Motivo' Puede moverla o quitarla según sea necesario.
        Me.MotivoTableAdapter.Mot(Me.VeterinariaDataSet.Motivo)

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.MotivoTableAdapter.Inster(AsuntoTextBox.Text, RecetaTextBox.Text, FechaDateTimePicker.Text, TotalTextBox.Text)
        Me.MotivoTableAdapter.Mot(Me.VeterinariaDataSet.Motivo)
        AsuntoTextBox.Clear()
        RecetaTextBox.Clear()
        FechaDateTimePicker.ResetText()
        TotalTextBox.Clear()
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Form5.Show()
        Me.Close()
    End Sub
End Class