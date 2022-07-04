<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarRecepcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarRecepcion))
        Me.txtCodeIns = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMuestra = New System.Windows.Forms.TextBox()
        Me.cmbNumeroMuestra = New System.Windows.Forms.ComboBox()
        Me.dtFechaRegistro = New System.Windows.Forms.DateTimePicker()
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
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.txtCerrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPartCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCongelamiento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtIdCompartido = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCode2 = New System.Windows.Forms.TextBox()
        Me.txtCode3 = New System.Windows.Forms.TextBox()
        Me.txtCode4 = New System.Windows.Forms.TextBox()
        Me.txtCode5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCodeIns
        '
        Me.txtCodeIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeIns.Location = New System.Drawing.Point(374, 56)
        Me.txtCodeIns.Name = "txtCodeIns"
        Me.txtCodeIns.Size = New System.Drawing.Size(120, 29)
        Me.txtCodeIns.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Code INS"
        '
        'txtMuestra
        '
        Me.txtMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMuestra.Location = New System.Drawing.Point(374, 122)
        Me.txtMuestra.MaxLength = 8
        Me.txtMuestra.Name = "txtMuestra"
        Me.txtMuestra.Size = New System.Drawing.Size(196, 29)
        Me.txtMuestra.TabIndex = 55
        '
        'cmbNumeroMuestra
        '
        Me.cmbNumeroMuestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumeroMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumeroMuestra.FormattingEnabled = True
        Me.cmbNumeroMuestra.Location = New System.Drawing.Point(84, 211)
        Me.cmbNumeroMuestra.Name = "cmbNumeroMuestra"
        Me.cmbNumeroMuestra.Size = New System.Drawing.Size(166, 28)
        Me.cmbNumeroMuestra.TabIndex = 50
        '
        'dtFechaRegistro
        '
        Me.dtFechaRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaRegistro.Location = New System.Drawing.Point(84, 8)
        Me.dtFechaRegistro.Name = "dtFechaRegistro"
        Me.dtFechaRegistro.Size = New System.Drawing.Size(163, 24)
        Me.dtFechaRegistro.TabIndex = 60
        '
        'chkPlasma
        '
        Me.chkPlasma.AutoSize = True
        Me.chkPlasma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlasma.Location = New System.Drawing.Point(84, 174)
        Me.chkPlasma.Name = "chkPlasma"
        Me.chkPlasma.Size = New System.Drawing.Size(77, 22)
        Me.chkPlasma.TabIndex = 49
        Me.chkPlasma.Text = "Plasma"
        Me.chkPlasma.UseVisualStyleBackColor = True
        '
        'chkLcr
        '
        Me.chkLcr.AutoSize = True
        Me.chkLcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLcr.Location = New System.Drawing.Point(84, 147)
        Me.chkLcr.Name = "chkLcr"
        Me.chkLcr.Size = New System.Drawing.Size(48, 22)
        Me.chkLcr.TabIndex = 48
        Me.chkLcr.Text = "Lcr"
        Me.chkLcr.UseVisualStyleBackColor = True
        '
        'chkOrina
        '
        Me.chkOrina.AutoSize = True
        Me.chkOrina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrina.Location = New System.Drawing.Point(84, 119)
        Me.chkOrina.Name = "chkOrina"
        Me.chkOrina.Size = New System.Drawing.Size(63, 22)
        Me.chkOrina.TabIndex = 47
        Me.chkOrina.Text = "Orina"
        Me.chkOrina.UseVisualStyleBackColor = True
        '
        'chkHisopado
        '
        Me.chkHisopado.AutoSize = True
        Me.chkHisopado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHisopado.Location = New System.Drawing.Point(84, 91)
        Me.chkHisopado.Name = "chkHisopado"
        Me.chkHisopado.Size = New System.Drawing.Size(91, 22)
        Me.chkHisopado.TabIndex = 46
        Me.chkHisopado.Text = "Hisopado"
        Me.chkHisopado.UseVisualStyleBackColor = True
        '
        'chkSuero
        '
        Me.chkSuero.AutoSize = True
        Me.chkSuero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuero.Location = New System.Drawing.Point(84, 65)
        Me.chkSuero.Name = "chkSuero"
        Me.chkSuero.Size = New System.Drawing.Size(67, 22)
        Me.chkSuero.TabIndex = 45
        Me.chkSuero.Text = "Suero"
        Me.chkSuero.UseVisualStyleBackColor = True
        '
        'chkSangre
        '
        Me.chkSangre.AutoSize = True
        Me.chkSangre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSangre.Location = New System.Drawing.Point(84, 41)
        Me.chkSangre.Name = "chkSangre"
        Me.chkSangre.Size = New System.Drawing.Size(74, 22)
        Me.chkSangre.TabIndex = 44
        Me.chkSangre.Text = "Sangre"
        Me.chkSangre.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Sample Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Date"
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCambios.Location = New System.Drawing.Point(280, 197)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(137, 42)
        Me.btnGuardarCambios.TabIndex = 62
        Me.btnGuardarCambios.TabStop = False
        Me.btnGuardarCambios.Text = "&Guardar Cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = True
        '
        'txtCerrar
        '
        Me.txtCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCerrar.Location = New System.Drawing.Point(433, 197)
        Me.txtCerrar.Name = "txtCerrar"
        Me.txtCerrar.Size = New System.Drawing.Size(137, 42)
        Me.txtCerrar.TabIndex = 63
        Me.txtCerrar.TabStop = False
        Me.txtCerrar.Text = "&Close"
        Me.txtCerrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Id"
        '
        'txtPartCode
        '
        Me.txtPartCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartCode.Location = New System.Drawing.Point(374, 89)
        Me.txtPartCode.MaxLength = 40
        Me.txtPartCode.Name = "txtPartCode"
        Me.txtPartCode.Size = New System.Drawing.Size(196, 29)
        Me.txtPartCode.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(274, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Part code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(274, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Freeze"
        '
        'txtCongelamiento
        '
        Me.txtCongelamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCongelamiento.Location = New System.Drawing.Point(374, 157)
        Me.txtCongelamiento.MaxLength = 8
        Me.txtCongelamiento.Name = "txtCongelamiento"
        Me.txtCongelamiento.Size = New System.Drawing.Size(165, 29)
        Me.txtCongelamiento.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(139, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Codigo 4"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(236, 341)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Codigo 5"
        Me.Label13.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(542, 159)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(30, 29)
        Me.btnRefresh.TabIndex = 76
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtIdCompartido
        '
        Me.txtIdCompartido.Location = New System.Drawing.Point(374, 14)
        Me.txtIdCompartido.Name = "txtIdCompartido"
        Me.txtIdCompartido.Size = New System.Drawing.Size(111, 20)
        Me.txtIdCompartido.TabIndex = 77
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(267, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 18)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Id Compartido"
        '
        'txtCode2
        '
        Me.txtCode2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode2.Location = New System.Drawing.Point(120, 256)
        Me.txtCode2.Name = "txtCode2"
        Me.txtCode2.Size = New System.Drawing.Size(90, 26)
        Me.txtCode2.TabIndex = 52
        Me.txtCode2.Visible = False
        '
        'txtCode3
        '
        Me.txtCode3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCode3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode3.Location = New System.Drawing.Point(216, 256)
        Me.txtCode3.Name = "txtCode3"
        Me.txtCode3.Size = New System.Drawing.Size(99, 26)
        Me.txtCode3.TabIndex = 53
        Me.txtCode3.Visible = False
        '
        'txtCode4
        '
        Me.txtCode4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCode4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode4.Location = New System.Drawing.Point(120, 311)
        Me.txtCode4.Name = "txtCode4"
        Me.txtCode4.Size = New System.Drawing.Size(90, 26)
        Me.txtCode4.TabIndex = 69
        Me.txtCode4.Visible = False
        '
        'txtCode5
        '
        Me.txtCode5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCode5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode5.Location = New System.Drawing.Point(218, 312)
        Me.txtCode5.Name = "txtCode5"
        Me.txtCode5.Size = New System.Drawing.Size(97, 26)
        Me.txtCode5.TabIndex = 70
        Me.txtCode5.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 18)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Compartidos"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Codigo 2"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(236, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Codigo 3"
        Me.Label11.Visible = False
        '
        'frmEditarRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 277)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtIdCompartido)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCode5)
        Me.Controls.Add(Me.txtCode4)
        Me.Controls.Add(Me.txtCongelamiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPartCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCerrar)
        Me.Controls.Add(Me.btnGuardarCambios)
        Me.Controls.Add(Me.txtCodeIns)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCode3)
        Me.Controls.Add(Me.txtCode2)
        Me.Controls.Add(Me.txtMuestra)
        Me.Controls.Add(Me.cmbNumeroMuestra)
        Me.Controls.Add(Me.dtFechaRegistro)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditarRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodeIns As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMuestra As System.Windows.Forms.TextBox
    Friend WithEvents cmbNumeroMuestra As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaRegistro As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents btnGuardarCambios As System.Windows.Forms.Button
    Friend WithEvents txtCerrar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPartCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCongelamiento As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtIdCompartido As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCode2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCode3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCode4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCode5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
