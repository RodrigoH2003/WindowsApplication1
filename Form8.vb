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
        ApellidoETextBox.Clear()
        NombreMascotaTextBox.Clear()
        Telefono1TextBox.Clear()
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            If ApellidoETextBox.Text = "" Then
                Exit Sub
            Else
                Dim buscador As String = ApellidoETextBox.Text
                CreacionBindingSource.Filter = "(ApellidoE like'" & ApellidoETextBox.Text & "')"

                If CreacionBindingSource.Count <> 0 Then
                    DataGridView1.DataSource = CreacionBindingSource
                Else
                    MsgBox("El Paciente " & buscador & " no existe")
                    CreacionBindingSource.Filter = Nothing
                    DataGridView1.ClearSelection()
                    DataGridView1.DataSource = CreacionBindingSource
                End If
            End If
        Catch ex As Exception
            MsgBox("Error numero " & Err.Number & vbNewLine & "deDescripcion del error: " & Err.Description)

        End Try

        Try
            If NombreMascotaTextBox.Text = "" Then
                Exit Sub
            Else
                Dim buscador As String = NombreMascotaTextBox.Text
                CreacionBindingSource.Filter = "(NombreMascota like'" & NombreMascotaTextBox.Text & "')"

                If CreacionBindingSource.Count <> 0 Then
                    DataGridView1.DataSource = CreacionBindingSource
                Else
                    MsgBox("El Nombre de la Mascota " & buscador & " no existe")
                    CreacionBindingSource.Filter = Nothing
                    DataGridView1.ClearSelection()
                    DataGridView1.DataSource = CreacionBindingSource
                End If
            End If
        Catch ex As Exception
            MsgBox("Error numero " & Err.Number & vbNewLine & "deDescripcion del error: " & Err.Description)

        End Try

        Try
            If Telefono1TextBox.Text = "" Then
                Exit Sub
            Else
                Dim buscador As String = Telefono1TextBox.Text
                CreacionBindingSource.Filter = "(Telefono1 like'" & Telefono1TextBox.Text & "')"

                If CreacionBindingSource.Count <> 0 Then
                    DataGridView1.DataSource = CreacionBindingSource
                Else
                    MsgBox("El Numero de Telefono " & buscador & " no existe")
                    CreacionBindingSource.Filter = Nothing
                    DataGridView1.ClearSelection()
                    DataGridView1.DataSource = CreacionBindingSource
                End If
            End If
        Catch ex As Exception
            MsgBox("Error numero " & Err.Number & vbNewLine & "deDescripcion del error: " & Err.Description)

        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            NombreMascotaTextBox.Enabled = True
        Else
            NombreMascotaTextBox.Enabled = False
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            Telefono1TextBox.Enabled = True
        Else
            Telefono1TextBox.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ApellidoETextBox.Enabled = True
        Else
            ApellidoETextBox.Enabled = False
        End If
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label22.Text = DateTime.Now.ToShortTimeString
        Me.Label21.Text = DateTime.Now.ToLongDateString
    End Sub
End Class