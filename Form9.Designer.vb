<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VeterinariaDataSet = New WindowsApplication1.VeterinariaDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New WindowsApplication1.VeterinariaDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuarios Registrados"
        '
        'VeterinariaDataSet
        '
        Me.VeterinariaDataSet.DataSetName = "VeterinariaDataSet"
        Me.VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.VeterinariaDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CreacionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(12, 55)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(636, 163)
        Me.UsuariosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nivel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nivel"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(96, 297)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(55, 15)
        Me.label8.TabIndex = 47
        Me.label8.Text = "Eliminar"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(236, 298)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(40, 15)
        Me.label7.TabIndex = 46
        Me.label7.Text = "Editar"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.SystemColors.Window
        Me.button3.Image = Global.WindowsApplication1.My.Resources.Resources.eliminar_amigo
        Me.button3.Location = New System.Drawing.Point(90, 224)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(70, 73)
        Me.button3.TabIndex = 45
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.SystemColors.Window
        Me.button2.Image = Global.WindowsApplication1.My.Resources.Resources.usuario
        Me.button2.Location = New System.Drawing.Point(221, 225)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(70, 70)
        Me.button2.TabIndex = 44
        Me.button2.UseVisualStyleBackColor = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(566, 308)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(35, 15)
        Me.label6.TabIndex = 49
        Me.label6.Text = "Salir"
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.SystemColors.Window
        Me.button5.Image = Global.WindowsApplication1.My.Resources.Resources.cerrar_sesion
        Me.button5.Location = New System.Drawing.Point(538, 225)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(97, 80)
        Me.button5.TabIndex = 48
        Me.button5.UseVisualStyleBackColor = False
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(51, 21)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 49
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(76, 18)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 50
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.soft_pastel_purple_blue_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(672, 343)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VeterinariaDataSet As WindowsApplication1.VeterinariaDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As WindowsApplication1.VeterinariaDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.VeterinariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents button5 As System.Windows.Forms.Button
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
End Class
