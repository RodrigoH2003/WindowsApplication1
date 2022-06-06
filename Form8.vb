Public Class Form8
    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub CreacionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CreacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Creacion' Puede moverla o quitarla según sea necesario.
        Me.CreacionTableAdapter.CreacionF(Me.VeterinariaDataSet.Creacion)
        IdTextBox.Clear()
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            If TextBox1.Text = "" Then
                Exit Sub
            Else
                Dim buscador As String = TextBox1.Text
                CreacionBindingSource.Filter = "(ApellidoE like'" & TextBox1.Text & "')"

                If CreacionBindingSource.Count <> 0 Then
                    CreacionDataGridView.DataSource = CreacionBindingSource
                Else
                    MsgBox("El Paciente " & buscador & " no existe", vbOKOnly + vbInformation, "Error")
                    CreacionBindingSource.Filter = Nothing
                    CreacionDataGridView.ClearSelection()
                    CreacionDataGridView.DataSource = CreacionBindingSource
                End If

            End If

        Catch ex As Exception
            MsgBox("Error numero " & Err.Number & vbNewLine & " deDescripcion del error: " & Err.Description)

        End Try

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label22.Text = DateTime.Now.ToShortTimeString
        Me.Label21.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        MsgBox("Paciente Borrado", vbOKOnly + vbInformation, "Exito")
        Me.CreacionTableAdapter.borrar(IdTextBox.Text)
        Me.CreacionTableAdapter.CreacionF(Me.VeterinariaDataSet.Creacion)
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub CreacionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CreacionDataGridView.CellContentClick

    End Sub
End Class