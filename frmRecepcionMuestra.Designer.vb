<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionMuestra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecepcionMuestra))
        Me.btnGuardarEdicion = New System.Windows.Forms.Button()
        Me.btnBorrarRegistro = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCodeShared2 = New System.Windows.Forms.TextBox()
        Me.txtCodeShared1 = New System.Windows.Forms.TextBox()
        Me.chkShared = New System.Windows.Forms.CheckBox()
        Me.txtCodeMuestra = New System.Windows.Forms.TextBox()
        Me.cmbNumeroMuestra = New System.Windows.Forms.ComboBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkPlasma = New System.Windows.Forms.CheckBox()
        Me.chkLcr = New System.Windows.Forms.CheckBox()
        Me.chkOrina = New System.Windows.Forms.CheckBox()
        Me.chkHisopado = New System.Windows.Forms.CheckBox()
        Me.chkSuero = New System.Windows.Forms.CheckBox()
        Me.chkSangre = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodeIns = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEditarFila = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodeParticipante = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFpiObi = New System.Windows.Forms.Button()
        Me.btnOtros = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.TmTime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodeCongelamiento = New System.Windows.Forms.TextBox()
        Me.btnMuestraCongelamiento = New System.Windows.Forms.Button()
        Me.txtCodeShared3 = New System.Windows.Forms.TextBox()
        Me.txtCodeShared4 = New System.Windows.Forms.TextBox()
        Me.btnCompartir = New System.Windows.Forms.Button()
        Me.btnCompMuestra = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardarEdicion
        '
        Me.btnGuardarEdicion.Enabled = False
        Me.btnGuardarEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEdicion.Location = New System.Drawing.Point(601, 313)
        Me.btnGuardarEdicion.Name = "btnGuardarEdicion"
        Me.btnGuardarEdicion.Size = New System.Drawing.Size(131, 35)
        Me.btnGuardarEdicion.TabIndex = 41
        Me.btnGuardarEdicion.TabStop = False
        Me.btnGuardarEdicion.Text = "&Guardar Edición"
        Me.btnGuardarEdicion.UseVisualStyleBackColor = True
        '
        'btnBorrarRegistro
        '
        Me.btnBorrarRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarRegistro.Location = New System.Drawing.Point(738, 272)
        Me.btnBorrarRegistro.Name = "btnBorrarRegistro"
        Me.btnBorrarRegistro.Size = New System.Drawing.Size(131, 35)
        Me.btnBorrarRegistro.TabIndex = 40
        Me.btnBorrarRegistro.TabStop = False
        Me.btnBorrarRegistro.Text = "&Borrar Fila"
        Me.btnBorrarRegistro.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(738, 313)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(131, 35)
        Me.btnCerrar.TabIndex = 39
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "&Close"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(314, 289)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 34)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.Text = "&Buscar..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Location = New System.Drawing.Point(6, 354)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Size = New System.Drawing.Size(1203, 328)
        Me.DataGridView1.TabIndex = 37
        Me.DataGridView1.TabStop = False
        '
        'txtCodeShared2
        '
        Me.txtCodeShared2.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodeShared2.Enabled = False
        Me.txtCodeShared2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeShared2.Location = New System.Drawing.Point(1110, 189)
        Me.txtCodeShared2.Name = "txtCodeShared2"
        Me.txtCodeShared2.Size = New System.Drawing.Size(99, 24)
        Me.txtCodeShared2.TabIndex = 10
        Me.txtCodeShared2.Visible = False
        '
        'txtCodeShared1
        '
        Me.txtCodeShared1.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodeShared1.Enabled = False
        Me.txtCodeShared1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeShared1.Location = New System.Drawing.Point(1013, 189)
        Me.txtCodeShared1.Name = "txtCodeShared1"
        Me.txtCodeShared1.Size = New System.Drawing.Size(90, 24)
        Me.txtCodeShared1.TabIndex = 9
        Me.txtCodeShared1.Visible = False
        '
        'chkShared
        '
        Me.chkShared.AutoSize = True
        Me.chkShared.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShared.Location = New System.Drawing.Point(910, 191)
        Me.chkShared.Name = "chkShared"
        Me.chkShared.Size = New System.Drawing.Size(105, 22)
        Me.chkShared.TabIndex = 8
        Me.chkShared.Text = "Compartido"
        Me.chkShared.UseVisualStyleBackColor = True
        Me.chkShared.Visible = False
        '
        'txtCodeMuestra
        '
        Me.txtCodeMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeMuestra.Location = New System.Drawing.Point(112, 288)
        Me.txtCodeMuestra.MaxLength = 8
        Me.txtCodeMuestra.Name = "txtCodeMuestra"
        Me.txtCodeMuestra.Size = New System.Drawing.Size(196, 35)
        Me.txtCodeMuestra.TabIndex = 13
        '
        'cmbNumeroMuestra
        '
        Me.cmbNumeroMuestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumeroMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumeroMuestra.FormattingEnabled = True
        Me.cmbNumeroMuestra.Location = New System.Drawing.Point(111, 213)
        Me.cmbNumeroMuestra.Name = "cmbNumeroMuestra"
        Me.cmbNumeroMuestra.Size = New System.Drawing.Size(197, 28)
        Me.cmbNumeroMuestra.TabIndex = 6
        '
        'dtFecha
        '
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(111, 3)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(163, 24)
        Me.dtFecha.TabIndex = 31
        '
        'chkPlasma
        '
        Me.chkPlasma.AutoSize = True
        Me.chkPlasma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlasma.Location = New System.Drawing.Point(111, 179)
        Me.chkPlasma.Name = "chkPlasma"
        Me.chkPlasma.Size = New System.Drawing.Size(77, 22)
        Me.chkPlasma.TabIndex = 5
        Me.chkPlasma.Text = "Plasma"
        Me.chkPlasma.UseVisualStyleBackColor = True
        '
        'chkLcr
        '
        Me.chkLcr.AutoSize = True
        Me.chkLcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLcr.Location = New System.Drawing.Point(111, 151)
        Me.chkLcr.Name = "chkLcr"
        Me.chkLcr.Size = New System.Drawing.Size(48, 22)
        Me.chkLcr.TabIndex = 4
        Me.chkLcr.Text = "Lcr"
        Me.chkLcr.UseVisualStyleBackColor = True
        '
        'chkOrina
        '
        Me.chkOrina.AutoSize = True
        Me.chkOrina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrina.Location = New System.Drawing.Point(111, 123)
        Me.chkOrina.Name = "chkOrina"
        Me.chkOrina.Size = New System.Drawing.Size(63, 22)
        Me.chkOrina.TabIndex = 3
        Me.chkOrina.Text = "Orina"
        Me.chkOrina.UseVisualStyleBackColor = True
        '
        'chkHisopado
        '
        Me.chkHisopado.AutoSize = True
        Me.chkHisopado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHisopado.Location = New System.Drawing.Point(111, 95)
        Me.chkHisopado.Name = "chkHisopado"
        Me.chkHisopado.Size = New System.Drawing.Size(91, 22)
        Me.chkHisopado.TabIndex = 2
        Me.chkHisopado.Text = "Hisopado"
        Me.chkHisopado.UseVisualStyleBackColor = True
        '
        'chkSuero
        '
        Me.chkSuero.AutoSize = True
        Me.chkSuero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuero.Location = New System.Drawing.Point(111, 67)
        Me.chkSuero.Name = "chkSuero"
        Me.chkSuero.Size = New System.Drawing.Size(67, 22)
        Me.chkSuero.TabIndex = 1
        Me.chkSuero.Text = "Suero"
        Me.chkSuero.UseVisualStyleBackColor = True
        '
        'chkSangre
        '
        Me.chkSangre.AutoSize = True
        Me.chkSangre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSangre.Location = New System.Drawing.Point(111, 39)
        Me.chkSangre.Name = "chkSangre"
        Me.chkSangre.Size = New System.Drawing.Size(74, 22)
        Me.chkSangre.TabIndex = 0
        Me.chkSangre.Text = "Sangre"
        Me.chkSangre.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Cod. Muestra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Num. Muestra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Date"
        '
        'txtCodeIns
        '
        Me.txtCodeIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeIns.Location = New System.Drawing.Point(111, 248)
        Me.txtCodeIns.Name = "txtCodeIns"
        Me.txtCodeIns.Size = New System.Drawing.Size(120, 24)
        Me.txtCodeIns.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Cod. INS "
        '
        'btnEditarFila
        '
        Me.btnEditarFila.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarFila.Location = New System.Drawing.Point(601, 272)
        Me.btnEditarFila.Name = "btnEditarFila"
        Me.btnEditarFila.Size = New System.Drawing.Size(131, 35)
        Me.btnEditarFila.TabIndex = 44
        Me.btnEditarFila.TabStop = False
        Me.btnEditarFila.Text = "&Editar Fila..."
        Me.btnEditarFila.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodeParticipante)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(436, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 63)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'txtCodeParticipante
        '
        Me.txtCodeParticipante.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeParticipante.Location = New System.Drawing.Point(145, 18)
        Me.txtCodeParticipante.Name = "txtCodeParticipante"
        Me.txtCodeParticipante.Size = New System.Drawing.Size(216, 35)
        Me.txtCodeParticipante.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Participant_Code"
        '
        'btnFpiObi
        '
        Me.btnFpiObi.Location = New System.Drawing.Point(463, 281)
        Me.btnFpiObi.Name = "btnFpiObi"
        Me.btnFpiObi.Size = New System.Drawing.Size(63, 61)
        Me.btnFpiObi.TabIndex = 15
        Me.btnFpiObi.Text = "FPI/OBI"
        Me.btnFpiObi.UseVisualStyleBackColor = True
        '
        'btnOtros
        '
        Me.btnOtros.Location = New System.Drawing.Point(532, 281)
        Me.btnOtros.Name = "btnOtros"
        Me.btnOtros.Size = New System.Drawing.Size(63, 61)
        Me.btnOtros.TabIndex = 16
        Me.btnOtros.Text = "OTROS"
        Me.btnOtros.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(475, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Verificación  Códigos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(319, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Time"
        '
        'txtHora
        '
        Me.txtHora.Enabled = False
        Me.txtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.Location = New System.Drawing.Point(368, 4)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(119, 26)
        Me.txtHora.TabIndex = 54
        '
        'TmTime
        '
        Me.TmTime.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCodeCongelamiento)
        Me.GroupBox2.Location = New System.Drawing.Point(559, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 62)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 20)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Sample Freeze"
        Me.Label9.Visible = False
        '
        'txtCodeCongelamiento
        '
        Me.txtCodeCongelamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeCongelamiento.Location = New System.Drawing.Point(129, 14)
        Me.txtCodeCongelamiento.Name = "txtCodeCongelamiento"
        Me.txtCodeCongelamiento.Size = New System.Drawing.Size(175, 35)
        Me.txtCodeCongelamiento.TabIndex = 58
        Me.txtCodeCongelamiento.Visible = False
        '
        'btnMuestraCongelamiento
        '
        Me.btnMuestraCongelamiento.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.icono_frío
        Me.btnMuestraCongelamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMuestraCongelamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMuestraCongelamiento.Location = New System.Drawing.Point(880, 12)
        Me.btnMuestraCongelamiento.Name = "btnMuestraCongelamiento"
        Me.btnMuestraCongelamiento.Size = New System.Drawing.Size(86, 90)
        Me.btnMuestraCongelamiento.TabIndex = 55
        Me.btnMuestraCongelamiento.TabStop = False
        Me.btnMuestraCongelamiento.Text = "Sample &Freeze"
        Me.btnMuestraCongelamiento.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMuestraCongelamiento.UseVisualStyleBackColor = True
        '
        'txtCodeShared3
        '
        Me.txtCodeShared3.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodeShared3.Enabled = False
        Me.txtCodeShared3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeShared3.Location = New System.Drawing.Point(1214, 189)
        Me.txtCodeShared3.Name = "txtCodeShared3"
        Me.txtCodeShared3.Size = New System.Drawing.Size(99, 24)
        Me.txtCodeShared3.TabIndex = 11
        Me.txtCodeShared3.Visible = False
        '
        'txtCodeShared4
        '
        Me.txtCodeShared4.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodeShared4.Enabled = False
        Me.txtCodeShared4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeShared4.Location = New System.Drawing.Point(1319, 189)
        Me.txtCodeShared4.Name = "txtCodeShared4"
        Me.txtCodeShared4.Size = New System.Drawing.Size(99, 24)
        Me.txtCodeShared4.TabIndex = 12
        Me.txtCodeShared4.Visible = False
        '
        'btnCompartir
        '
        Me.btnCompartir.BackgroundImage = CType(resources.GetObject("btnCompartir.BackgroundImage"), System.Drawing.Image)
        Me.btnCompartir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCompartir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompartir.Location = New System.Drawing.Point(323, 151)
        Me.btnCompartir.Name = "btnCompartir"
        Me.btnCompartir.Size = New System.Drawing.Size(88, 90)
        Me.btnCompartir.TabIndex = 59
        Me.btnCompartir.Tag = ""
        Me.btnCompartir.Text = "Compartir"
        Me.btnCompartir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCompartir.UseVisualStyleBackColor = True
        '
        'btnCompMuestra
        '
        Me.btnCompMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCompMuestra.Location = New System.Drawing.Point(112, 324)
        Me.btnCompMuestra.Name = "btnCompMuestra"
        Me.btnCompMuestra.Size = New System.Drawing.Size(196, 22)
        Me.btnCompMuestra.TabIndex = 60
        Me.btnCompMuestra.Text = "Compartiendo Muestra..."
        Me.btnCompMuestra.UseVisualStyleBackColor = True
        Me.btnCompMuestra.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmRecepcionMuestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 695)
        Me.Controls.Add(Me.btnCompMuestra)
        Me.Controls.Add(Me.btnCompartir)
        Me.Controls.Add(Me.txtCodeShared4)
        Me.Controls.Add(Me.txtCodeShared3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnMuestraCongelamiento)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnOtros)
        Me.Controls.Add(Me.btnFpiObi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEditarFila)
        Me.Controls.Add(Me.txtCodeIns)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardarEdicion)
        Me.Controls.Add(Me.btnBorrarRegistro)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCodeShared2)
        Me.Controls.Add(Me.txtCodeShared1)
        Me.Controls.Add(Me.chkShared)
        Me.Controls.Add(Me.txtCodeMuestra)
        Me.Controls.Add(Me.cmbNumeroMuestra)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.chkPlasma)
        Me.Controls.Add(Me.chkLcr)
        Me.Controls.Add(Me.chkOrina)
        Me.Controls.Add(Me.chkHisopado)
        Me.Controls.Add(Me.chkSuero)
        Me.Controls.Add(Me.chkSangre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRecepcionMuestra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sample Reception"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardarEdicion As System.Windows.Forms.Button
    Friend WithEvents btnBorrarRegistro As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodeShared2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeShared1 As System.Windows.Forms.TextBox
    Friend WithEvents chkShared As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodeMuestra As System.Windows.Forms.TextBox
    Friend WithEvents cmbNumeroMuestra As System.Windows.Forms.ComboBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkPlasma As System.Windows.Forms.CheckBox
    Friend WithEvents chkLcr As System.Windows.Forms.CheckBox
    Friend WithEvents chkOrina As System.Windows.Forms.CheckBox
    Friend WithEvents chkHisopado As System.Windows.Forms.CheckBox
    Friend WithEvents chkSuero As System.Windows.Forms.CheckBox
    Friend WithEvents chkSangre As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodeIns As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEditarFila As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodeParticipante As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnFpiObi As System.Windows.Forms.Button
    Friend WithEvents btnOtros As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents TmTime As System.Windows.Forms.Timer
    Friend WithEvents btnMuestraCongelamiento As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodeCongelamiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeShared3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeShared4 As System.Windows.Forms.TextBox
    Friend WithEvents btnCompartir As System.Windows.Forms.Button
    Friend WithEvents btnCompMuestra As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
