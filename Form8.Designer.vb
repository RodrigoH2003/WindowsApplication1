<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreEncargadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMascotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoAnimalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsuntoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeterinariaDataSet = New WindowsApplication1.VeterinariaDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NombreMascotaTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoETextBox = New System.Windows.Forms.TextBox()
        Me.Telefono1TextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.CreacionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.CreacionTableAdapter = New WindowsApplication1.VeterinariaDataSetTableAdapters.CreacionTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager()
        Me.CreacionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CreacionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreacionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.panel1.Controls.Add(Me.DataGridView1)
        Me.panel1.Controls.Add(Me.GroupBox1)
        Me.panel1.Location = New System.Drawing.Point(12, 57)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(498, 388)
        Me.panel1.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreEncargadoDataGridViewTextBoxColumn, Me.ApellidoEDataGridViewTextBoxColumn, Me.NombreMascotaDataGridViewTextBoxColumn, Me.ApellidoMDataGridViewTextBoxColumn, Me.TipoAnimalDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.RazaDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn, Me.Telefono1DataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.RecetaDataGridViewTextBoxColumn, Me.AsuntoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CreacionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(469, 219)
        Me.DataGridView1.TabIndex = 3
        '
        'NombreEncargadoDataGridViewTextBoxColumn
        '
        Me.NombreEncargadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEncargado"
        Me.NombreEncargadoDataGridViewTextBoxColumn.HeaderText = "NombreEncargado"
        Me.NombreEncargadoDataGridViewTextBoxColumn.Name = "NombreEncargadoDataGridViewTextBoxColumn"
        '
        'ApellidoEDataGridViewTextBoxColumn
        '
        Me.ApellidoEDataGridViewTextBoxColumn.DataPropertyName = "ApellidoE"
        Me.ApellidoEDataGridViewTextBoxColumn.HeaderText = "ApellidoE"
        Me.ApellidoEDataGridViewTextBoxColumn.Name = "ApellidoEDataGridViewTextBoxColumn"
        '
        'NombreMascotaDataGridViewTextBoxColumn
        '
        Me.NombreMascotaDataGridViewTextBoxColumn.DataPropertyName = "NombreMascota"
        Me.NombreMascotaDataGridViewTextBoxColumn.HeaderText = "NombreMascota"
        Me.NombreMascotaDataGridViewTextBoxColumn.Name = "NombreMascotaDataGridViewTextBoxColumn"
        '
        'ApellidoMDataGridViewTextBoxColumn
        '
        Me.ApellidoMDataGridViewTextBoxColumn.DataPropertyName = "ApellidoM"
        Me.ApellidoMDataGridViewTextBoxColumn.HeaderText = "ApellidoM"
        Me.ApellidoMDataGridViewTextBoxColumn.Name = "ApellidoMDataGridViewTextBoxColumn"
        '
        'TipoAnimalDataGridViewTextBoxColumn
        '
        Me.TipoAnimalDataGridViewTextBoxColumn.DataPropertyName = "TipoAnimal"
        Me.TipoAnimalDataGridViewTextBoxColumn.HeaderText = "TipoAnimal"
        Me.TipoAnimalDataGridViewTextBoxColumn.Name = "TipoAnimalDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'RazaDataGridViewTextBoxColumn
        '
        Me.RazaDataGridViewTextBoxColumn.DataPropertyName = "Raza"
        Me.RazaDataGridViewTextBoxColumn.HeaderText = "Raza"
        Me.RazaDataGridViewTextBoxColumn.Name = "RazaDataGridViewTextBoxColumn"
        '
        'GeneroDataGridViewTextBoxColumn
        '
        Me.GeneroDataGridViewTextBoxColumn.DataPropertyName = "Genero"
        Me.GeneroDataGridViewTextBoxColumn.HeaderText = "Genero"
        Me.GeneroDataGridViewTextBoxColumn.Name = "GeneroDataGridViewTextBoxColumn"
        '
        'Telefono1DataGridViewTextBoxColumn
        '
        Me.Telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.Name = "Telefono1DataGridViewTextBoxColumn"
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'RecetaDataGridViewTextBoxColumn
        '
        Me.RecetaDataGridViewTextBoxColumn.DataPropertyName = "Receta"
        Me.RecetaDataGridViewTextBoxColumn.HeaderText = "Receta"
        Me.RecetaDataGridViewTextBoxColumn.Name = "RecetaDataGridViewTextBoxColumn"
        '
        'AsuntoDataGridViewTextBoxColumn
        '
        Me.AsuntoDataGridViewTextBoxColumn.DataPropertyName = "Asunto"
        Me.AsuntoDataGridViewTextBoxColumn.HeaderText = "Asunto"
        Me.AsuntoDataGridViewTextBoxColumn.Name = "AsuntoDataGridViewTextBoxColumn"
        '
        'CreacionBindingSource
        '
        Me.CreacionBindingSource.DataMember = "Creacion"
        Me.CreacionBindingSource.DataSource = Me.VeterinariaDataSet
        '
        'VeterinariaDataSet
        '
        Me.VeterinariaDataSet.DataSetName = "VeterinariaDataSet"
        Me.VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.NombreMascotaTextBox)
        Me.GroupBox1.Controls.Add(Me.ApellidoETextBox)
        Me.GroupBox1.Controls.Add(Me.Telefono1TextBox)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(98, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 149)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Paciente"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(140, 84)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(110, 19)
        Me.CheckBox3.TabIndex = 29
        Me.CheckBox3.Text = "Telefono Dueño"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(139, 59)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(117, 19)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.Text = "Nombre Mascota"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(140, 31)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(109, 19)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "Apellido Dueño"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NombreMascotaTextBox
        '
        Me.NombreMascotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreacionBindingSource, "NombreMascota", True))
        Me.NombreMascotaTextBox.Enabled = False
        Me.NombreMascotaTextBox.Location = New System.Drawing.Point(7, 52)
        Me.NombreMascotaTextBox.Name = "NombreMascotaTextBox"
        Me.NombreMascotaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NombreMascotaTextBox.TabIndex = 4
        '
        'ApellidoETextBox
        '
        Me.ApellidoETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreacionBindingSource, "ApellidoE", True))
        Me.ApellidoETextBox.Enabled = False
        Me.ApellidoETextBox.Location = New System.Drawing.Point(7, 21)
        Me.ApellidoETextBox.Name = "ApellidoETextBox"
        Me.ApellidoETextBox.Size = New System.Drawing.Size(100, 22)
        Me.ApellidoETextBox.TabIndex = 26
        '
        'Telefono1TextBox
        '
        Me.Telefono1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreacionBindingSource, "Telefono1", True))
        Me.Telefono1TextBox.Enabled = False
        Me.Telefono1TextBox.Location = New System.Drawing.Point(7, 81)
        Me.Telefono1TextBox.Name = "Telefono1TextBox"
        Me.Telefono1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Telefono1TextBox.TabIndex = 25
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(25, 109)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 23)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Buscar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'CreacionBindingSource2
        '
        Me.CreacionBindingSource2.DataMember = "Creacion"
        Me.CreacionBindingSource2.DataSource = Me.VeterinariaDataSet
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(633, 394)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(35, 15)
        Me.label6.TabIndex = 22
        Me.label6.Text = "Salir"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(699, 274)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(56, 15)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Consulta"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(563, 274)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 15)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Ficha"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(673, 152)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(105, 15)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Eliminar Paciente"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(535, 152)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(104, 15)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Agregar Paciente"
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.SystemColors.Window
        Me.button5.Image = Global.WindowsApplication1.My.Resources.Resources.cerrar_sesion
        Me.button5.Location = New System.Drawing.Point(605, 311)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(97, 80)
        Me.button5.TabIndex = 17
        Me.button5.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.SystemColors.Window
        Me.button4.Image = Global.WindowsApplication1.My.Resources.Resources.co
        Me.button4.Location = New System.Drawing.Point(679, 188)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(99, 83)
        Me.button4.TabIndex = 16
        Me.button4.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.SystemColors.Window
        Me.button3.Image = Global.WindowsApplication1.My.Resources.Resources.consulta
        Me.button3.Location = New System.Drawing.Point(535, 188)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(99, 83)
        Me.button3.TabIndex = 15
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.SystemColors.Window
        Me.button2.Image = Global.WindowsApplication1.My.Resources.Resources.eliminar_amigo
        Me.button2.Location = New System.Drawing.Point(679, 71)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(99, 78)
        Me.button2.TabIndex = 14
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.Window
        Me.button1.Image = Global.WindowsApplication1.My.Resources.Resources.nuevo_usuario
        Me.button1.Location = New System.Drawing.Point(535, 71)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(99, 78)
        Me.button1.TabIndex = 13
        Me.button1.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(119, 9)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(308, 26)
        Me.label1.TabIndex = 12
        Me.label1.Text = "BUSQUEDA DE PACIENTE"
        '
        'CreacionTableAdapter
        '
        Me.CreacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CreacionTableAdapter = Me.CreacionTableAdapter
        Me.TableAdapterManager.MotivoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'CreacionBindingSource1
        '
        Me.CreacionBindingSource1.DataMember = "Creacion"
        Me.CreacionBindingSource1.DataSource = Me.VeterinariaDataSet
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(633, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 15)
        Me.Label24.TabIndex = 92
        Me.Label24.Text = "FECHA:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(469, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 15)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "HORA:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(513, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 15)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "Label22"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(680, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 15)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "Label21"
        '
        'Timer1
        '
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.soft_pastel_purple_blue_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(822, 457)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSQUEDA DE PACIENTE"
        Me.panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CreacionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreacionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents VeterinariaDataSet As WindowsApplication1.VeterinariaDataSet
    Friend WithEvents CreacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CreacionTableAdapter As WindowsApplication1.VeterinariaDataSetTableAdapters.CreacionTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CreacionBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CreacionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Telefono1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreEncargadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMascotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAnimalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsuntoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoETextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreMascotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
