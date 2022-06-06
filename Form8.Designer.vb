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
        Dim IdLabel As System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.CreacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeterinariaDataSet = New WindowsApplication1.VeterinariaDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
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
        IdLabel = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.CreacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CreacionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreacionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(317, 14)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 15)
        IdLabel.TabIndex = 28
        IdLabel.Text = "Id:"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.panel1.Controls.Add(Me.CreacionDataGridView)
        Me.panel1.Controls.Add(Me.GroupBox1)
        Me.panel1.Location = New System.Drawing.Point(12, 57)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(498, 449)
        Me.panel1.TabIndex = 23
        '
        'CreacionDataGridView
        '
        Me.CreacionDataGridView.AutoGenerateColumns = False
        Me.CreacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.CreacionDataGridView.DataSource = Me.CreacionBindingSource
        Me.CreacionDataGridView.Location = New System.Drawing.Point(18, 168)
        Me.CreacionDataGridView.Name = "CreacionDataGridView"
        Me.CreacionDataGridView.Size = New System.Drawing.Size(462, 246)
        Me.CreacionDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreEncargado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NombreEncargado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ApellidoE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ApellidoE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreMascota"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NombreMascota"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ApellidoM"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ApellidoM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TipoAnimal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TipoAnimal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Raza"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Raza"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Genero"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Genero"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Telefono1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Telefono1"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Telefono2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Telefono2"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Receta"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Receta"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Asunto"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Asunto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
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
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(62, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 149)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Paciente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 28
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(141, 94)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 23)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Buscar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreacionBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(344, 11)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(33, 22)
        Me.IdTextBox.TabIndex = 29
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
        Me.ClientSize = New System.Drawing.Size(822, 506)
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
        CType(Me.CreacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents VeterinariaDataSet As WindowsApplication1.VeterinariaDataSet
    Friend WithEvents CreacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CreacionTableAdapter As WindowsApplication1.VeterinariaDataSetTableAdapters.CreacionTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CreacionBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CreacionBindingSource1 As System.Windows.Forms.BindingSource
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
