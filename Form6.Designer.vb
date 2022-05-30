<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.VeterinariaDataSet = New WindowsApplication1.VeterinariaDataSet()
        Me.MotivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotivoTableAdapter = New WindowsApplication1.VeterinariaDataSetTableAdapters.MotivoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager()
        Me.VeterinariaDataSet1 = New WindowsApplication1.VeterinariaDataSet1()
        Me.CreacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreacionTableAdapter = New WindowsApplication1.VeterinariaDataSet1TableAdapters.CreacionTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.VeterinariaDataSet1TableAdapters.TableAdapterManager()
        Me.CreacionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreacionTableAdapter1 = New WindowsApplication1.VeterinariaDataSetTableAdapters.CreacionTableAdapter()
        Me.CreacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeterinariaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreacionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(579, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(152, 26)
        Me.label1.TabIndex = 1
        Me.label1.Text = "CONSULTAS"
        '
        'VeterinariaDataSet
        '
        Me.VeterinariaDataSet.DataSetName = "VeterinariaDataSet"
        Me.VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MotivoBindingSource
        '
        Me.MotivoBindingSource.DataMember = "Motivo"
        Me.MotivoBindingSource.DataSource = Me.VeterinariaDataSet
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
        'VeterinariaDataSet1
        '
        Me.VeterinariaDataSet1.DataSetName = "VeterinariaDataSet1"
        Me.VeterinariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CreacionBindingSource
        '
        Me.CreacionBindingSource.DataMember = "Creacion"
        Me.CreacionBindingSource.DataSource = Me.VeterinariaDataSet1
        '
        'CreacionTableAdapter
        '
        Me.CreacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CreacionTableAdapter = Me.CreacionTableAdapter
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.VeterinariaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CreacionBindingSource1
        '
        Me.CreacionBindingSource1.DataMember = "Creacion"
        Me.CreacionBindingSource1.DataSource = Me.VeterinariaDataSet
        '
        'CreacionTableAdapter1
        '
        Me.CreacionTableAdapter1.ClearBeforeFill = True
        '
        'CreacionDataGridView
        '
        Me.CreacionDataGridView.AllowUserToOrderColumns = True
        Me.CreacionDataGridView.AutoGenerateColumns = False
        Me.CreacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.CreacionDataGridView.DataSource = Me.CreacionBindingSource1
        Me.CreacionDataGridView.Location = New System.Drawing.Point(12, 92)
        Me.CreacionDataGridView.Name = "CreacionDataGridView"
        Me.CreacionDataGridView.Size = New System.Drawing.Size(1243, 220)
        Me.CreacionDataGridView.TabIndex = 67
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
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TipoAnimal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TipoAnimal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
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
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Asunto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Asunto"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Receta"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Receta"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1194, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 15)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(991, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 15)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "Label22"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(947, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 15)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "HORA:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1147, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 15)
        Me.Label24.TabIndex = 92
        Me.Label24.Text = "FECHA:"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.sobresalir
        Me.Button1.Location = New System.Drawing.Point(789, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 63)
        Me.Button1.TabIndex = 96
        Me.Button1.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.button5.Image = Global.WindowsApplication1.My.Resources.Resources.cerrar_sesion
        Me.button5.Location = New System.Drawing.Point(633, 337)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(74, 74)
        Me.button5.TabIndex = 67
        Me.button5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(649, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(786, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Abrir Control "
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1370, 458)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.CreacionDataGridView)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTAS"
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeterinariaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreacionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents VeterinariaDataSet As WindowsApplication1.VeterinariaDataSet
    Friend WithEvents MotivoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MotivoTableAdapter As WindowsApplication1.VeterinariaDataSetTableAdapters.MotivoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VeterinariaDataSet1 As WindowsApplication1.VeterinariaDataSet1
    Friend WithEvents CreacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CreacionTableAdapter As WindowsApplication1.VeterinariaDataSet1TableAdapters.CreacionTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.VeterinariaDataSet1TableAdapters.TableAdapterManager
    Private WithEvents button5 As System.Windows.Forms.Button
    Friend WithEvents CreacionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CreacionTableAdapter1 As WindowsApplication1.VeterinariaDataSetTableAdapters.CreacionTableAdapter
    Friend WithEvents CreacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
