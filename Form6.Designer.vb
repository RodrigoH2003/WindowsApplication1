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
        Me.button5 = New System.Windows.Forms.Button()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeterinariaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(555, 9)
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
        'button5
        '
        Me.button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.button5.Image = Global.WindowsApplication1.My.Resources.Resources.cerrar_sesion
        Me.button5.Location = New System.Drawing.Point(597, 280)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(74, 74)
        Me.button5.TabIndex = 67
        Me.button5.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 458)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form6"
        Me.Text = "CONSULTAS"
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeterinariaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
