<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.AsuntoTextBox = New System.Windows.Forms.TextBox()
        Me.RecetaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.MotivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeterinariaDataSet = New WindowsApplication1.VeterinariaDataSet()
        Me.MotivoTableAdapter = New WindowsApplication1.VeterinariaDataSetTableAdapters.MotivoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager()
        CType(Me.MotivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(291, 388)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(59, 15)
        Me.label8.TabIndex = 44
        Me.label8.Text = "Regresar"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(168, 388)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 15)
        Me.label7.TabIndex = 43
        Me.label7.Text = "Cancelar"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(47, 388)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(53, 15)
        Me.label6.TabIndex = 42
        Me.label6.Text = "Guardar"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(26, 258)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(34, 15)
        Me.label5.TabIndex = 34
        Me.label5.Text = "Total"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(21, 201)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(39, 15)
        Me.label4.TabIndex = 33
        Me.label4.Text = "Fecha"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(21, 142)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 15)
        Me.label3.TabIndex = 32
        Me.label3.Text = "Receta"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(21, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 15)
        Me.label2.TabIndex = 31
        Me.label2.Text = "Motivo"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(121, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(229, 26)
        Me.label1.TabIndex = 30
        Me.label1.Text = "INGRESO MOTIVO"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.SystemColors.Window
        Me.button3.Image = Global.WindowsApplication1.My.Resources.Resources.cerrar_sesion
        Me.button3.Location = New System.Drawing.Point(277, 309)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(81, 76)
        Me.button3.TabIndex = 37
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.SystemColors.Window
        Me.button2.Image = Global.WindowsApplication1.My.Resources.Resources.cancelar
        Me.button2.Location = New System.Drawing.Point(156, 309)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(79, 76)
        Me.button2.TabIndex = 36
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.Window
        Me.button1.Image = Global.WindowsApplication1.My.Resources.Resources.guardar_el_archivo
        Me.button1.Location = New System.Drawing.Point(38, 309)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(76, 76)
        Me.button1.TabIndex = 35
        Me.button1.UseVisualStyleBackColor = False
        '
        'AsuntoTextBox
        '
        Me.AsuntoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotivoBindingSource, "Asunto", True))
        Me.AsuntoTextBox.Location = New System.Drawing.Point(111, 72)
        Me.AsuntoTextBox.Name = "AsuntoTextBox"
        Me.AsuntoTextBox.Size = New System.Drawing.Size(305, 20)
        Me.AsuntoTextBox.TabIndex = 46
        '
        'RecetaTextBox
        '
        Me.RecetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotivoBindingSource, "Receta", True))
        Me.RecetaTextBox.Location = New System.Drawing.Point(111, 140)
        Me.RecetaTextBox.Name = "RecetaTextBox"
        Me.RecetaTextBox.Size = New System.Drawing.Size(305, 20)
        Me.RecetaTextBox.TabIndex = 47
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MotivoBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(111, 196)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 48
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotivoBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(111, 258)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 49
        '
        'MotivoBindingSource
        '
        Me.MotivoBindingSource.DataMember = "Motivo"
        Me.MotivoBindingSource.DataSource = Me.VeterinariaDataSet
        '
        'VeterinariaDataSet
        '
        Me.VeterinariaDataSet.DataSetName = "VeterinariaDataSet"
        Me.VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MotivoTableAdapter
        '
        Me.MotivoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CreacionTableAdapter = Nothing
        Me.TableAdapterManager.MotivoTableAdapter = Me.MotivoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blue_pastel_gradation_blur_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(473, 448)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.RecetaTextBox)
        Me.Controls.Add(Me.AsuntoTextBox)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form7"
        Me.Text = "INGRESO MOTIVO"
        CType(Me.MotivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents VeterinariaDataSet As WindowsApplication1.VeterinariaDataSet
    Friend WithEvents MotivoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MotivoTableAdapter As WindowsApplication1.VeterinariaDataSetTableAdapters.MotivoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AsuntoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RecetaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
End Class
