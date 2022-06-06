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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SAVE As New SaveFileDialog
        Dim ruta As String
        Dim xlapp As Object = CreateObject("Excel.Application")
        Dim pth As String = ""

        Dim xlwb As Object = xlapp.Workbooks.add
        Dim xlws As Object = xlwb.worksheets(1)
        Try

            For c As Integer = 0 To CreacionDataGridView.ColumnCount - 1
                xlws.cells(1, c + 1).value = CreacionDataGridView.Columns(c).HeaderText
            Next

            For r As Integer = 0 To CreacionDataGridView.RowCount - 1
                For c As Integer = 0 To CreacionDataGridView.Columns.Count - 1
                    xlws.cells(r + 2, c + 1).value = Convert.ToString(CreacionDataGridView.Item(c, r).Value)
                Next
            Next

            Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog
            SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog1.Filter = "Archivo Excel| *.xlsx"
            SaveFileDialog1.FilterIndex = 2
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                ruta = SaveFileDialog1.FileName
                xlwb.saveas(ruta)
                xlws = Nothing
                xlwb = Nothing
                xlapp.quit()
                MsgBox("Exportado Correctamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class