<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(301, 289)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(35, 15)
        Me.label6.TabIndex = 21
        Me.label6.Text = "Salir"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(163, 289)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(57, 15)
        Me.label5.TabIndex = 20
        Me.label5.Text = "Cancelar"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(31, 288)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(47, 15)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Buscar"
        '
        'comboBox2
        '
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New System.Drawing.Point(153, 139)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(181, 21)
        Me.comboBox2.TabIndex = 15
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(153, 91)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(181, 21)
        Me.comboBox1.TabIndex = 14
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(11, 141)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(141, 17)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Nombre de Usuario:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 91)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 17)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Nombre:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(24, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(323, 26)
        Me.label1.TabIndex = 11
        Me.label1.Text = "BUSQUEDA DE USUSARIOS"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.SystemColors.Window
        Me.button3.Image = Global.WindowsApplication1.My.Resources.Resources.cerrar_sesion
        Me.button3.Location = New System.Drawing.Point(272, 210)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(89, 76)
        Me.button3.TabIndex = 18
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.SystemColors.Window
        Me.button2.Image = Global.WindowsApplication1.My.Resources.Resources.cancelar
        Me.button2.Location = New System.Drawing.Point(144, 210)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(98, 76)
        Me.button2.TabIndex = 17
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.Window
        Me.button1.Image = Global.WindowsApplication1.My.Resources.Resources.lupa
        Me.button1.Location = New System.Drawing.Point(11, 210)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(97, 76)
        Me.button1.TabIndex = 16
        Me.button1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._167_1670183_3d_blue_wallpaper_fondo_azul_del_mar
        Me.ClientSize = New System.Drawing.Size(382, 348)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.comboBox2)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form4"
        Me.Text = "BUSQUEDA DE USUSARIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
