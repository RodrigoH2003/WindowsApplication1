
Imports System.Data.OleDb
Public Class Form5

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub combotipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combotipo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ColorTextBox.Focus()
        End If
    End Sub

    Private Sub combotipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combotipo.SelectedIndexChanged
        comboraza.Items.Clear()
        Dim tipo As String
        tipo = combotipo.SelectedItem
        If tipo = "Gato" Then
            comboraza.Items.Add("Abisinio")
            comboraza.Items.Add("American Shorthair")
            comboraza.Items.Add("American Wirehair")
            comboraza.Items.Add("Angora turco")
            comboraza.Items.Add("Azul ruso")
            comboraza.Items.Add("Balinés")
            comboraza.Items.Add("Bengala")
            comboraza.Items.Add("Birmano")
            comboraza.Items.Add("Bobtail Americano")
            comboraza.Items.Add("Bobtail japonés")
            comboraza.Items.Add("Bombay")
            comboraza.Items.Add("Bosque de Noruega")
            comboraza.Items.Add("British Longhair")
            comboraza.Items.Add("British Shorthair")
            comboraza.Items.Add("Burmilla")
            comboraza.Items.Add("California Spangled")
            comboraza.Items.Add("Californian Rex")
            comboraza.Items.Add("Cartujo")
            comboraza.Items.Add("Ceilán")
            comboraza.Items.Add("Chausie")
            comboraza.Items.Add("Cornish Rex")
            comboraza.Items.Add("Curl americano")
            comboraza.Items.Add("Cymric")
            comboraza.Items.Add("Devon Rex")
            comboraza.Items.Add("Don Sphynx")
            comboraza.Items.Add("Exótico")
            comboraza.Items.Add("Gato común")
            comboraza.Items.Add("Gato común europeo")
            comboraza.Items.Add("Gato esfinge")
            comboraza.Items.Add("Gato Siberiano")
            comboraza.Items.Add("Gato Van turco")
            comboraza.Items.Add("German Rex")
            comboraza.Items.Add("Habana Brown")
            comboraza.Items.Add("Highland Fold y Highland Straight")
            comboraza.Items.Add("Himalayo")
            comboraza.Items.Add("Javanés")
            comboraza.Items.Add("Khao Manee")
            comboraza.Items.Add("Korat")
            comboraza.Items.Add("LaPerm")
            comboraza.Items.Add("Maine Coon")
            comboraza.Items.Add("Manx")
            comboraza.Items.Add("Mau egipcio")
            comboraza.Items.Add("Munchkin")
            comboraza.Items.Add("Nebelung")
            comboraza.Items.Add("Ocicat")
            comboraza.Items.Add("Oriental")
            comboraza.Items.Add("Persa")
            comboraza.Items.Add("Persa Chinchilla")
            comboraza.Items.Add("Peterbald")
            comboraza.Items.Add("Pixie Bob")
            comboraza.Items.Add("Ragamuffin")
            comboraza.Items.Add("Ragdoll")
            comboraza.Items.Add("Safari")
            comboraza.Items.Add("Sagrado de Birmania")
            comboraza.Items.Add("Savannah")
            comboraza.Items.Add("Scottish Fold")
            comboraza.Items.Add("Siamés")
            comboraza.Items.Add("Siamés thai")
            comboraza.Items.Add("Singapura")
            comboraza.Items.Add("Snowshoe")
            comboraza.Items.Add("Somalí")
            comboraza.Items.Add("Tiffany")
            comboraza.Items.Add("Tonkinés")
            comboraza.Items.Add("Toyger")
            comboraza.Items.Add("York Chocolate")

        ElseIf tipo = "Perro" Then
            comboraza.Items.Add("Akita")
            comboraza.Items.Add("Alaskan Husky")
            comboraza.Items.Add("American Foxhound")
            comboraza.Items.Add("American pit bull terrier")
            comboraza.Items.Add("American staffordshire terrier")
            comboraza.Items.Add("Beagle")
            comboraza.Items.Add("Bóxer")
            comboraza.Items.Add("Bulldog francés")
            comboraza.Items.Add("Bulldog inglés")
            comboraza.Items.Add("Bulldog americano")
            comboraza.Items.Add("Cane Corso")
            comboraza.Items.Add("Caniche o poodle")
            comboraza.Items.Add("Caniche Toy")
            comboraza.Items.Add("Corgi")
            comboraza.Items.Add("Chihuahua")
            comboraza.Items.Add("Chow Chow")
            comboraza.Items.Add("Cocker Spaniel Americano")
            comboraza.Items.Add("Cocker Spaniel Inglés")
            comboraza.Items.Add("Dálmata")
            comboraza.Items.Add("Dobermann")
            comboraza.Items.Add("Dogo Argentino")
            comboraza.Items.Add("Dogo de Burdeos")
            comboraza.Items.Add("Dogo del Tibet")
            comboraza.Items.Add("Fila Brasileiro")
            comboraza.Items.Add("Galgo Español")
            comboraza.Items.Add("Galgo húngaro")
            comboraza.Items.Add("Galgo Italiano")
            comboraza.Items.Add("Galgo Polaco")
            comboraza.Items.Add("Golden retriever")
            comboraza.Items.Add("Gran Danés")
            comboraza.Items.Add("Gran Perro Japonés")
            comboraza.Items.Add("Husky siberiano")
            comboraza.Items.Add("Labrador Retriever")
            comboraza.Items.Add("Manchester terrier")
            comboraza.Items.Add("Mastín Español")
            comboraza.Items.Add("Mastín Napolitano")
            comboraza.Items.Add("Ovejero alemán")
            comboraza.Items.Add("Rottweiler")
            comboraza.Items.Add("Sabueso de Hamilton")
            comboraza.Items.Add("Sabueso de Hannover")
            comboraza.Items.Add("Sabueso de Hygen")
            comboraza.Items.Add("Sabueso de Istria")
            comboraza.Items.Add("Sabueso de Posavaz")
            comboraza.Items.Add("Sabueso de Schiller")
            comboraza.Items.Add("Sabueso de Smaland")
            comboraza.Items.Add("Sabueso de Transilvania")
            comboraza.Items.Add("Sabueso del Tirol")
            comboraza.Items.Add("Sabueso Español")
            comboraza.Items.Add("San Bernardo")
            comboraza.Items.Add("salchicha")
            comboraza.Items.Add("sin raza")
            comboraza.Items.Add("Pastor australiano")
            comboraza.Items.Add("Pastor Ovejero")
            comboraza.Items.Add("Pastor Alemán")
            comboraza.Items.Add("Pastor Belga")
            comboraza.Items.Add("Pointer")
            comboraza.Items.Add("Viejo Pastor Inglés")
            comboraza.Items.Add("Weimaraner")
            comboraza.Items.Add("Yorkshire terrier")
        ElseIf tipo = "Conejo" Then
            comboraza.Items.Add("American")
            comboraza.Items.Add("American chinchilla")
            comboraza.Items.Add("American sable")
            comboraza.Items.Add("Amfuzzylop small")
            comboraza.Items.Add("Belgian hare")
            comboraza.Items.Add("Beveren")
            comboraza.Items.Add("Britannian petite")
            comboraza.Items.Add("Californian small")
            comboraza.Items.Add("Champagne dargent")
            comboraza.Items.Add("Checkered giant")
            comboraza.Items.Add("Cinnamon")
            comboraza.Items.Add("Creme dargent")
            comboraza.Items.Add("Dutch small")
            comboraza.Items.Add("Dwarfhotot")
            comboraza.Items.Add("English angora")
            comboraza.Items.Add("Englishspot")
            comboraza.Items.Add("Englop small")
            comboraza.Items.Add("Flemish giant")
            comboraza.Items.Add("Florida white")
            comboraza.Items.Add("Francés angora")
            comboraza.Items.Add("Francés lop small")
            comboraza.Items.Add("Gigante angora")
            comboraza.Items.Add("Gigante chinchilla")
            comboraza.Items.Add("Harlequin small")
            comboraza.Items.Add("Havana")
            comboraza.Items.Add("Himalaya")
            comboraza.Items.Add("Hollandlop small")
            comboraza.Items.Add("Hotot")
            comboraza.Items.Add("Jersey wooly")
            comboraza.Items.Add("Lilac")
            comboraza.Items.Add("Minilop small")
            comboraza.Items.Add("Minirex")
            comboraza.Items.Add("Netherland dwarf")
            comboraza.Items.Add("Newzeland small")
            comboraza.Items.Add("Palomino")
            comboraza.Items.Add("Polish small")
            comboraza.Items.Add("Rex")
            comboraza.Items.Add("Rhynelander")
            comboraza.Items.Add("Saint angora")
            comboraza.Items.Add("Satin")
            comboraza.Items.Add("Silver")
            comboraza.Items.Add("Silver fox")
            comboraza.Items.Add("Silver marten")
            comboraza.Items.Add("Standard chinchilla")
            comboraza.Items.Add("Tan")

        ElseIf tipo = "Tortuga" Then
            comboraza.Items.Add("mediterránea")
            comboraza.Items.Add("Laúd")
            comboraza.Items.Add("rusa")
            comboraza.Items.Add("orejas amarillas")
            comboraza.Items.Add("mapa del norte")
            comboraza.Items.Add("Cumberland")
            comboraza.Items.Add("caimán")
            comboraza.Items.Add("serpentina")
            comboraza.Items.Add("caparazón blando")
            comboraza.Items.Add("Cantor")
            comboraza.Items.Add("carey")
            comboraza.Items.Add("Verde")
            comboraza.Items.Add("estrellada")
            comboraza.Items.Add("boba")
            comboraza.Items.Add("Sulcata")
            comboraza.Items.Add("morrocoy")
            comboraza.Items.Add("mordedora")
            comboraza.Items.Add("Lora")
            comboraza.Items.Add("blanca")
            comboraza.Items.Add("bulbo")
            comboraza.Items.Add("golfina")
            comboraza.Items.Add("Plana")
            comboraza.Items.Add("moteada")
            comboraza.Items.Add("Podocnemis lewyana")
            comboraza.Items.Add("Charapa ")
            comboraza.Items.Add("Terecay ")
            comboraza.Items.Add("Carranchina ")
            comboraza.Items.Add("Inguensa")
            comboraza.Items.Add("Hicotea")
            comboraza.Items.Add("Cabeza de trozo")
            comboraza.Items.Add("Chipiro ")
            comboraza.Items.Add("Swanka")
            comboraza.Items.Add("Desconocida")

        ElseIf tipo = "Rata o Raton" Then
            comboraza.Items.Add("ciervo")
            comboraza.Items.Add("común")
            comboraza.Items.Add("Noruega")
            comboraza.Items.Add("de los tejados")
            comboraza.Items.Add("Gris")
            comboraza.Items.Add("Doméstico")
            comboraza.Items.Add("Manx")
            comboraza.Items.Add("calva ")
            comboraza.Items.Add("Dumbo")
            comboraza.Items.Add("Rex")
            comboraza.Items.Add("satinada ")
            comboraza.Items.Add("enana")
            comboraza.Items.Add("angora")
            comboraza.Items.Add("patchwork ")
            comboraza.Items.Add("Topaz")
            comboraza.Items.Add("Lilac Agouti")
            comboraza.Items.Add("Cinnamon Pearl")
            comboraza.Items.Add("Silver Fawn")
            comboraza.Items.Add("Powder Blue")
            comboraza.Items.Add("Ojos Rojos")
            comboraza.Items.Add("Desconocida")

        ElseIf tipo = "Caballo" Then
            comboraza.Items.Add("andaluz")
            comboraza.Items.Add("árabe")
            comboraza.Items.Add("frisón")
            comboraza.Items.Add("percherones")
            comboraza.Items.Add("pinto")
            comboraza.Items.Add("pura sangre inglés")
            comboraza.Items.Add("Mustang")
            comboraza.Items.Add("Cuarto de Milla ")
            comboraza.Items.Add("Appaloosa")
            comboraza.Items.Add("Shire")
            comboraza.Items.Add("Bretón ")
            comboraza.Items.Add("Lusitano")
            comboraza.Items.Add("Silla Francés")
            comboraza.Items.Add("Westfaliano ")
            comboraza.Items.Add("Holsteiner")
            comboraza.Items.Add("Hannoveriano")
            comboraza.Items.Add("Tinker")
            comboraza.Items.Add("Gipsy")
            comboraza.Items.Add("Peruano de paso")
            comboraza.Items.Add("Criollo colombiano")
            comboraza.Items.Add("Pura Raza Español")
            comboraza.Items.Add("Desconocida")

        ElseIf tipo = "Gallina" Then
            comboraza.Items.Add("Padua")
            comboraza.Items.Add("cuello desnudo")
            comboraza.Items.Add("Sedosa del Japón")
            comboraza.Items.Add("Sebright")
            comboraza.Items.Add("Leghorn")
            comboraza.Items.Add("Bresse gala")
            comboraza.Items.Add("Faverolles")
            comboraza.Items.Add("Borbonesa")
            comboraza.Items.Add("Alsaciana")
            comboraza.Items.Add("Wyandotte")
            comboraza.Items.Add("Sussex")
            comboraza.Items.Add("Rhode Island")
            comboraza.Items.Add("Marans")
            comboraza.Items.Add("Negra de Berry ")
            comboraza.Items.Add("New hampshire")
            comboraza.Items.Add("Plymouth")
            comboraza.Items.Add("Brahma enana")
            comboraza.Items.Add("ISA Brown")
            comboraza.Items.Add("Isbar")
            comboraza.Items.Add("Huevo de pascua")
            comboraza.Items.Add("Pava aliblanca")
            comboraza.Items.Add("Reina de canela")
            comboraza.Items.Add("Cherry Egger")
            comboraza.Items.Add("Golden Comet")
            comboraza.Items.Add("Guinea")
            comboraza.Items.Add("Pyncheon")
            comboraza.Items.Add("Dong Tao")
            comboraza.Items.Add("Scots gris")
            comboraza.Items.Add("Pava aliblanca")
            comboraza.Items.Add("Desconocida")

        ElseIf tipo = "Gallo" Then
            comboraza.Items.Add("Americano")
            comboraza.Items.Add("Claret ")
            comboraza.Items.Add("Hatch")
            comboraza.Items.Add("Round Head")
            comboraza.Items.Add("Redquills")
            comboraza.Items.Add("Red Horse")
            comboraza.Items.Add("Quilled")
            comboraza.Items.Add("Sweater")
            comboraza.Items.Add("Kelso")
            comboraza.Items.Add("Radio")
            comboraza.Items.Add("Whitehackle ")
            comboraza.Items.Add("Brownred")
            comboraza.Items.Add("Chino")
            comboraza.Items.Add("Sementales")
            comboraza.Items.Add("Criollos")
            comboraza.Items.Add("Patas Azules")
            comboraza.Items.Add("Colorados Finos")
            comboraza.Items.Add("Andaluza Azul")
            comboraza.Items.Add("Menorca")
            comboraza.Items.Add("Pita Pinta Austriana")
            comboraza.Items.Add("Andaluza Azul")
            comboraza.Items.Add("Orpington")
            comboraza.Items.Add("Houdan")
            comboraza.Items.Add("Desconocida")
        End If
    End Sub

    Private Sub CreacionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CreacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RecetaTextBox.Text = ""
        AsuntoTextBox.Text = ""
        TotalTextBox.Text = ""
        FechaDateTimePicker.Refresh()
        NombreEncargadoTextBox.Text = ""
        ApellidoETextBox.Text = ""
        NombreMascotaTextBox.Text = ""
        ApellidoMTextBox.Text = ""
        ColorTextBox.Text = ""
        comboBox3.Text = ""
        comboraza.Text = ""
        combotipo.Text = ""
        Telefono1TextBox.Text = ""
        Telefono2TextBox.Text = ""
        FechaNacimientoTextBox.Text = ""
        TextBox1.Text = ""
        Me.Timer1.Enabled = True
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Creacion' Puede moverla o quitarla según sea necesario.
        Me.CreacionTableAdapter.CreacionF(Me.VeterinariaDataSet.Creacion)
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        If NombreEncargadoTextBox.Text = "" Or ApellidoETextBox.Text = "" Or NombreMascotaTextBox.Text = "" Or ApellidoMTextBox.Text = "" Or ColorTextBox.Text = "" Or FechaNacimientoTextBox.Text = "" Or Telefono1TextBox.Text = "" Or Telefono2TextBox.Text = "" Or comboBox3.Text = "" Or comboraza.Text = "" Or combotipo.Text = "" Then
            MsgBox("Hay Campos Vacíos", vbOKOnly + vbInformation, "ADVERTENCIA")

        Else
            MsgBox("Datos Guardados", vbOKOnly + vbInformation, "Exito")
            Me.CreacionTableAdapter.Insertar(NombreEncargadoTextBox.Text, ApellidoETextBox.Text, NombreMascotaTextBox.Text, ApellidoMTextBox.Text, combotipo.Text, ColorTextBox.Text, comboraza.Text, comboBox3.Text, Telefono1TextBox.Text, Telefono2TextBox.Text, FechaNacimientoTextBox.Text, AsuntoTextBox.Text, RecetaTextBox.Text, FechaDateTimePicker.Text, TotalTextBox.Text)
            Me.CreacionTableAdapter.CreacionF(Me.VeterinariaDataSet.Creacion)
            NombreEncargadoTextBox.Clear()
            ApellidoETextBox.Clear()
            NombreMascotaTextBox.Clear()
            ApellidoMTextBox.Clear()
            ColorTextBox.Clear()
            FechaNacimientoTextBox.Clear()
            Telefono1TextBox.Clear()
            Telefono2TextBox.Clear()
            comboBox3.ResetText()
            comboraza.ResetText()
            combotipo.ResetText()
            button4.Enabled = False
            button6.Enabled = False
            button1.Enabled = True
            button2.Enabled = True
            button3.Enabled = True
            button7.Enabled = True
            button5.Enabled = True
            NombreEncargadoTextBox.Enabled = False
            ApellidoETextBox.Enabled = False
            NombreMascotaTextBox.Enabled = False
            ApellidoMTextBox.Enabled = False
            ColorTextBox.Enabled = False
            comboBox3.Enabled = False
            comboraza.Enabled = False
            combotipo.Enabled = False
            Telefono1TextBox.Enabled = False
            Telefono2TextBox.Enabled = False
            FechaNacimientoTextBox.Enabled = False
            TextBox1.Enabled = False
            AsuntoTextBox.Clear()
            RecetaTextBox.Clear()
            FechaDateTimePicker.ResetText()
            TotalTextBox.Clear()
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        NombreEncargadoTextBox.Clear()
        ApellidoETextBox.Clear()
        AsuntoTextBox.Clear()
        RecetaTextBox.Clear()
        FechaDateTimePicker.ResetText()
        TotalTextBox.Clear()
        NombreMascotaTextBox.Clear()
        ApellidoMTextBox.Clear()
        ColorTextBox.Clear()
        FechaNacimientoTextBox.Clear()
        Telefono1TextBox.Clear()
        Telefono2TextBox.Clear()
        comboBox3.ResetText()
        comboraza.ResetText()
        combotipo.ResetText()
        RecetaTextBox.Enabled = True
        AsuntoTextBox.Enabled = True
        FechaDateTimePicker.Enabled = True
        TotalTextBox.Enabled = True
        button4.Enabled = True
        NombreEncargadoTextBox.Enabled = True
        ApellidoETextBox.Enabled = True
        NombreMascotaTextBox.Enabled = True
        ApellidoMTextBox.Enabled = True
        ColorTextBox.Enabled = True
        comboBox3.Enabled = True
        comboraza.Enabled = True
        combotipo.Enabled = True
        Telefono1TextBox.Enabled = True
        Telefono2TextBox.Enabled = True
        FechaNacimientoTextBox.Enabled = True
        TextBox1.Enabled = True
        button6.Enabled = True
        button1.Enabled = False
        button2.Enabled = False
        button3.Enabled = False
        button7.Enabled = False
        button5.Enabled = False
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        NombreEncargadoTextBox.Enabled = True
        ApellidoETextBox.Enabled = True
        NombreMascotaTextBox.Enabled = True
        ApellidoMTextBox.Enabled = True
        ColorTextBox.Enabled = True
        comboBox3.Enabled = True
        comboraza.Enabled = True
        combotipo.Enabled = True
        Telefono1TextBox.Enabled = True
        Telefono2TextBox.Enabled = True
        FechaNacimientoTextBox.Enabled = True
        TextBox1.Enabled = True
        button4.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label22.Text = DateTime.Now.ToShortTimeString
        Me.Label21.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        MsgBox("Accion Cancelada", vbOKOnly + vbInformation, "OJO")
        NombreEncargadoTextBox.Clear()
        ApellidoETextBox.Clear()
        NombreMascotaTextBox.Clear()
        ApellidoMTextBox.Clear()
        ColorTextBox.Clear()
        FechaNacimientoTextBox.Clear()
        Telefono1TextBox.Clear()
        Telefono2TextBox.Clear()
        comboBox3.ResetText()
        comboraza.ResetText()
        combotipo.ResetText()
        AsuntoTextBox.Clear()
        RecetaTextBox.Clear()
        FechaDateTimePicker.ResetText()
        TotalTextBox.Clear()
        AsuntoTextBox.Enabled = False
        RecetaTextBox.Enabled = False
        FechaDateTimePicker.Enabled = False
        TotalTextBox.Enabled = False
        button4.Enabled = False
        button1.Enabled = True
        button2.Enabled = True
        button3.Enabled = True
        button5.Enabled = True
        button7.Enabled = True
        button6.Enabled = False
        NombreEncargadoTextBox.Enabled = False
        ApellidoETextBox.Enabled = False
        NombreMascotaTextBox.Enabled = False
        ApellidoMTextBox.Enabled = False
        ColorTextBox.Enabled = False
        FechaNacimientoTextBox.Enabled = False
        Telefono1TextBox.Enabled = False
        Telefono2TextBox.Enabled = False
        TextBox1.Enabled = False
        comboBox3.Enabled = False
        comboraza.Enabled = False
        combotipo.Enabled = False

    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        MsgBox("Paciente Borrado", vbOKOnly + vbInformation, "Exito")
        Me.CreacionTableAdapter.borrar(IdTextBox.Text)
        Me.CreacionTableAdapter.CreacionF(Me.VeterinariaDataSet.Creacion)
    End Sub

    Private Sub LolToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CreacionTableAdapter1.lol(Me.VeterinariaDataSet1.Creacion)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub NombreEncargadoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreEncargadoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ApellidoETextBox.Focus()
        End If
    End Sub


  
    Private Sub NombreEncargadoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreEncargadoTextBox.TextChanged

    End Sub

    Private Sub ApellidoETextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoETextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            NombreMascotaTextBox.Focus()
        End If
    End Sub

    Private Sub ApellidoETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApellidoETextBox.TextChanged

    End Sub

    Private Sub NombreMascotaTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreMascotaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ApellidoMTextBox.Focus()
        End If
    End Sub

    Private Sub NombreMascotaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreMascotaTextBox.TextChanged

    End Sub

    Private Sub ApellidoMTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoMTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            combotipo.Focus()
        End If
    End Sub

    Private Sub ApellidoMTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApellidoMTextBox.TextChanged

    End Sub

    Private Sub ColorTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ColorTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            comboraza.Focus()
        End If
    End Sub

    Private Sub ColorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorTextBox.TextChanged

    End Sub

    Private Sub comboraza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboraza.KeyPress
        If Asc(e.KeyChar) = 13 Then
            FechaNacimientoTextBox.Focus()
        End If
    End Sub

    Private Sub comboraza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboraza.SelectedIndexChanged

    End Sub

    Private Sub FechaNacimientoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FechaNacimientoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            comboBox3.Focus()
        End If
    End Sub

    Private Sub FechaNacimientoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaNacimientoTextBox.TextChanged

    End Sub

    Private Sub comboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Telefono1TextBox.Focus()
        End If
    End Sub

    Private Sub comboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox3.SelectedIndexChanged

    End Sub

    Private Sub Telefono1TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Telefono1TextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Telefono2TextBox.Focus()
        End If
    End Sub

    Private Sub Telefono1TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Telefono1TextBox.TextChanged

    End Sub

    Private Sub Telefono2TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Telefono2TextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            AsuntoTextBox.Focus()
        End If
    End Sub

    Private Sub Telefono2TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Telefono2TextBox.TextChanged

    End Sub

    Private Sub AsuntoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AsuntoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            RecetaTextBox.Focus()
        End If
    End Sub

    Private Sub AsuntoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsuntoTextBox.TextChanged

    End Sub

    Private Sub RecetaTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RecetaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            FechaDateTimePicker.Focus()
        End If
    End Sub

    Private Sub RecetaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecetaTextBox.TextChanged

    End Sub

    Private Sub FechaDateTimePicker_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FechaDateTimePicker.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TotalTextBox.Focus()
        End If
    End Sub

    Private Sub FechaDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaDateTimePicker.ValueChanged

    End Sub

    Private Sub TotalTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TotalTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            button4.Focus()
        End If
    End Sub

    Private Sub TotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalTextBox.TextChanged

    End Sub
End Class