Imports System.Data.OleDb
Public Class frmRecepcionMuestra
    Dim cmdcomando As New OleDbCommand
    Dim cod, cod_ins, cod2, cod3, cod4, cod5, san, sue, hiso, ori, lcr, plas, num, part_code As String
    Dim cod_correcto As Integer
    Dim cod_ingresado As Integer
    Dim fech As Date
    Dim app As String = (Application.StartupPath & "\imagenes\")
    Dim llave, llave2, compar As Boolean
    Dim comp As String
    Dim idCompartido As Integer = 0
    Dim coloraviso As String

    Private Sub Graba_recepcion()
        'Comprueba las opciones para que no se registren vacias
        If ((cmbNumeroMuestra.Text.Trim = "BARRIDO") And (txtCodeMuestra.Text.Trim = "" And txtCodeParticipante.Text.Trim = "")) Then
            MsgBox("Debe completar datos para la muestra de Barrido")
            Exit Sub
        End If
        If (txtCodeMuestra.Text.Trim = "") Or (chkSangre.Checked = False And chkSuero.Checked = False And chkHisopado.Checked = False And chkOrina.Checked = False And chkLcr.Checked = False And chkPlasma.Checked = False) Then
            MsgBox("Debe completar datos para poder Grabar un registro", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'If (ComboBox1.Text = "BARRIDO") Then
        'busca el codigo si se ha ingresado en el campo part_code''''''''''''''''''''''
        'cmdcomando = New OleDbCommand("select part_code from sample_reception where part_code='" & TextBox5.Text.Trim.ToUpper & "'", bd)
        'Dim read As OleDbDataReader = cmdcomando.ExecuteReader
        'If read.Read Then
        '    MsgBox("El código de participante ya esta registrado", MsgBoxStyle.Critical, "StafVir")
        '    read.Close()
        '    Exit Sub
        'End If
        'read.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'End If
        'primero busca si el codigo ha sido ingresado del campo code
        cmdcomando = New OleDbCommand("select code from sample_reception where code='" & txtCodeMuestra.Text.Trim.ToUpper & "'", bd)
        Dim reader As OleDbDataReader = cmdcomando.ExecuteReader
        If reader.Read Then
            MsgBox("This code is in the database", MsgBoxStyle.Critical, "StafVir")
        Else
            reader.Close()
            cod = txtCodeMuestra.Text
            cod_ins = txtCodeIns.Text
            cod2 = txtCodeShared1.Text
            cod3 = txtCodeShared2.Text
            cod4 = txtCodeShared3.Text
            cod5 = txtCodeShared4.Text

            num = cmbNumeroMuestra.Text
            fech = dtFecha.Value
            part_code = txtCodeParticipante.Text.Trim
            Dim code_lab As String = Mid(cod, 1, 3)
            Dim cmdcomando2 = New OleDbCommand("select top 1 code from sample_reception where code like'" & code_lab & "%'" & "order by code desc", bd)
            Dim reader2 As OleDbDataReader = cmdcomando2.ExecuteReader
            '''''''''''''desde aqui verifica codigo''''''''''''''''''''''
            If code_lab = "FPI" Or code_lab = "OBI" Then
                If llave = False Then
                    If reader2.Read Then
                        cod_correcto = Mid(reader2.GetString(0), 4, 5) + 1
                        cod_ingresado = Mid(cod, 4, 5)

                        If cod_ingresado <> cod_correcto Then
                            reader2.Close()
                            MsgBox("El codigo que acaba de ingresar no es el correlativo", vbExclamation, "Codigo")
                            Exit Sub
                        End If
                        reader2.Close()
                    End If
                End If
                'ElseIf code_lab = "OBI" Then
                '    If llave = False Then
                '        If reader2.Read Then
                '            cod_correcto = Mid(reader2.GetString(0), 4, 5) + 1
                '            cod_ingresado = Mid(cod, 4, 5)
                '            If cod_ingresado <> cod_correcto Then
                '                reader2.Close()
                '                MsgBox("El codigo que acaba de ingresar no es el correlativo", vbExclamation, "Codigo")
                '                Exit Sub
                '            End If
                '            reader2.Close()
                '        End If
                '    End If
            Else
                If llave2 = False Then
                    If reader2.Read Then
                        cod_correcto = Mid(reader2.GetString(0), 4, 4) + 1
                        cod_ingresado = Mid(cod, 4, 4)
                        If cod_ingresado <> cod_correcto Then
                            reader2.Close()
                            MsgBox("El codigo que acaba de ingresar no es el correlativo", vbExclamation, "Codigo")
                            Exit Sub
                        End If
                        reader2.Close()
                    End If
                End If
            End If
            ''''''''''''''hasta aqui verifica codigo'''''''''''''''''''''''''''
            If chkSangre.Checked Then
                san = "si"
            Else
                san = ""
            End If
            If chkSuero.Checked Then
                sue = "si"
            Else
                sue = ""
            End If
            If chkHisopado.Checked Then
                hiso = "si"
            Else
                hiso = ""
            End If
            If chkOrina.Checked Then
                ori = "si"
            Else
                ori = ""
            End If
            If chkLcr.Checked Then
                lcr = "si"
            Else
                lcr = ""
            End If
            If chkPlasma.Checked Then
                plas = "si"
            Else
                plas = ""
            End If

            ''''COMPARTIDO
            If btnCompartir.BackColor = Color.LightGreen Then
                cmdcomando = New OleDbCommand("insert into sample_reception (code,idCompartido,part_code,code_ins,sample_number,fecha,sangre,suero,hisopado,orina,lcr," & _
                                                        "plasma,usuario,hora) values ('" & cod.Trim.ToUpper & "','" & _
                                                        idCompartido & "','" & _
                                                        part_code.ToUpper & "','" & cod_ins.Trim.ToUpper & "','" & _
                                                        num.Trim.ToUpper & "','" & fech & "','" & san & "','" & _
                                                        sue & "','" & hiso & "','" & ori & "','" & lcr & "','" & _
                                                        plas & "','" & usu & "','" & txtHora.Text & "')", bd)
                cmdcomando.ExecuteNonQuery()
            ElseIf btnCompartir.BackColor = Me.BackColor Then
                cmdcomando = New OleDbCommand("insert into sample_reception (code,part_code,code_ins,sample_number,fecha,sangre,suero,hisopado,orina,lcr," & _
                                        "plasma,usuario,hora) values ('" & cod.Trim.ToUpper & "','" & _
                                        part_code.ToUpper & "','" & cod_ins.Trim.ToUpper & "','" & _
                                        num.Trim.ToUpper & "','" & fech & "','" & san & "','" & _
                                        sue & "','" & hiso & "','" & ori & "','" & lcr & "','" & _
                                        plas & "','" & usu & "','" & txtHora.Text & "')", bd)
                cmdcomando.ExecuteNonQuery()
            End If



            AgregaList()
            txtCodeParticipante.Text = ""
            limpia()
            DataGridView1.Refresh()
            reader.Close()
            txtCodeMuestra.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarEdicion.Click
        'Dim num As Integer
        'Dim valor As String
        'num = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value
        'If IsDBNull(DataGridView1.Item(DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentRow.Index).Value) Then
        '    valor = ""
        'Else
        '    valor = DataGridView1.Item(DataGridView1.CurrentCell.ColumnIndex, DataGridView1.CurrentRow.Index).Value
        'End If
        'Select Case DataGridView1.CurrentCell.ColumnIndex
        '    Case 0
        '        MsgBox("No se puede editar este campo", vbCritical, Nothing)
        '        Exit Sub
        '    Case 1
        '        cmdcomando = New OleDbCommand("update sample_reception set  code ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '    Case 2
        '        cmdcomando = New OleDbCommand("update sample_reception set  code_ins ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '    Case 3
        '        cmdcomando = New OleDbCommand("update sample_reception set  code2 ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '    Case 4
        '        cmdcomando = New OleDbCommand("update sample_reception set  code3 ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '    Case 5
        '        cmdcomando = New OleDbCommand("update sample_reception set  sample_number ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '    Case 6
        '        cmdcomando = New OleDbCommand("update sample_reception set  fecha ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '    Case 7
        '        If valor = "si" Or valor = "" Then
        '            cmdcomando = New OleDbCommand("update sample_reception set  sangre ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '        Else
        '            MsgBox("No se admite este valor", vbCritical, "Valor Rechazado")
        '            Exit Sub
        '        End If
        '    Case 8
        '        If valor = "si" Or valor = "" Then
        '            cmdcomando = New OleDbCommand("update sample_reception set  suero ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '        Else
        '            MsgBox("No se admite este valor", vbCritical, "Valor Rechazado")
        '            Exit Sub
        '        End If
        '    Case 9
        '        If valor = "si" Or valor = "" Then
        '            cmdcomando = New OleDbCommand("update sample_reception set  hisopado ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '        Else
        '            MsgBox("No se admite este valor", vbCritical, "Valor Rechazado")
        '            Exit Sub
        '        End If
        '    Case 10
        '        If valor = "si" Or valor = "" Then
        '            cmdcomando = New OleDbCommand("update sample_reception set  orina ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '        Else
        '            MsgBox("No se admite este valor", vbCritical, "Valor Rechazado")
        '            Exit Sub
        '        End If
        '    Case 11
        '        If valor = "si" Or valor = "" Then
        '            cmdcomando = New OleDbCommand("update sample_reception set  lcr ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '        Else
        '            MsgBox("No se admite este valor", vbCritical, "Valor Rechazado")
        '            Exit Sub
        '        End If
        '    Case 12
        '        If valor = "si" Or valor = "" Then
        '            cmdcomando = New OleDbCommand("update sample_reception set  plasma ='" & valor & "' where sample_reception.id = " & num & "", bd)
        '        Else
        '            MsgBox("No se admite este valor", vbCritical, "Valor Rechazado")
        '            Exit Sub
        '        End If
        '    Case 13
        '        MsgBox("Is not available", vbCritical, "No available")
        '        Exit Sub
        'End Select
        'cmdcomando.ExecuteNonQuery()
        'AgregaList()
    End Sub
    Public Sub AgregaList()
        Dim adapter As New OleDbDataAdapter("select id,code,idCompartido,part_code,code_ins,sample_number,fecha,sangre,suero,hisopado,orina,lcr,plasma,usuario,congelamiento as Freeze,hora from sample_reception order by sample_reception.id desc", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "tablita")
        DataGridView1.DataSource = dataSet.Tables(0)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarRegistro.Click
        If MsgBox(usu + "!, estas a punto de eliminar un registro!, estas segura de hacer esta operacion!", vbExclamation + vbYesNo, "Delete") = vbYes Then
            Dim num As Integer
            num = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value
            cmdcomando = New OleDbCommand("delete from sample_reception where id=" & num & "", bd)
            cmdcomando.ExecuteNonQuery()
            AgregaList()
            MsgBox("The row was deleted successfully", vbInformation, "Eliminado")
        End If
    End Sub

    Private Sub CheckBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (Strings.Asc(e.KeyChar) = 13) Then
            chkSuero.Focus()
        End If
    End Sub

    Private Sub CheckBox7_Click(ByVal sender As Object, ByVal e As EventArgs)
        If chkShared.Checked Then
            txtCodeShared1.Enabled = True
            txtCodeShared2.Enabled = True
        ElseIf Not Me.chkShared.Checked Then
            txtCodeShared1.Clear()
            txtCodeShared2.Clear()
            txtCodeShared1.Enabled = False
            txtCodeShared2.Enabled = False
        End If
    End Sub
    Private Sub CheckBox7_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
        Me.chkShared.BackColor = Color.Yellow
    End Sub
    Private Sub CheckBox7_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

    End Sub
    Private Sub CheckBox7_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
        Me.chkShared.BackColor = Me.BackColor
    End Sub
    Private Sub ComboBox1_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
        cmbNumeroMuestra.BackColor = Color.Yellow
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If cmbNumeroMuestra.Text = "" Then
                MsgBox("Please Select a option", MsgBoxStyle.Critical, Nothing)
            Else
                chkShared.Focus()
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idCompartido = 0
        comp = 1
        TmTime.Enabled = True
        AgregaList()
        'Dim adapter As New OleDbDataAdapter("select top 9000 id,code,code2,code3,sample_number,fecha,sangre,suero,hisopado,orina,lcr,plasma,usuario from sample_reception order by sample_reception.id desc", bd)
        'Dim dataSet As New DataSet
        'adapter.Fill(dataSet, "tablita")
        'DataGridView1.DataSource = dataSet.Tables(0)
        dtFecha.Value = Today
        chkSangre.Focus()
        chkSangre.BackColor = Color.Yellow
        Top = 0
        Left = 0
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AutoResizeColumns()
        cmbNumeroMuestra.Items.Add("AGUDO")
        cmbNumeroMuestra.Items.Add("CONVALECIENTE")
        cmbNumeroMuestra.Items.Add("VIGILANCIA")
        cmbNumeroMuestra.Items.Add("BARRIDO")
        cmbNumeroMuestra.Items.Add("BROTE")
        cmbNumeroMuestra.Items.Add("MUESTRA2")
        cmbNumeroMuestra.Items.Add("3M")
        cmbNumeroMuestra.Items.Add("6M")
        cmbNumeroMuestra.Items.Add("12M")
        cmbNumeroMuestra.Items.Add("24M")
        cmbNumeroMuestra.Items.Add("36M")
        cmbNumeroMuestra.Items.Add("42M")
        cmbNumeroMuestra.Items.Add("OTRO")

        'DataGridView1.Columns.Item(0).Width = 50 'íd
        'DataGridView1.Columns.Item(1).Width = 70 'muestraa
        'DataGridView1.Columns.Item(2).Width = 70 'part_code
        'DataGridView1.Columns.Item(3).Width = 90 'code ins
        'DataGridView1.Columns.Item(4).Width = 70 'code2
        'DataGridView1.Columns.Item(5).Width = 70 'code3
        'DataGridView1.Columns.Item(6).Width = 70 'code4
        'DataGridView1.Columns.Item(7).Width = 70 'code5

        'DataGridView1.Columns.Item(8).Width = 100
        'DataGridView1.Columns.Item(9).Width = 110
        'DataGridView1.Columns.Item(10).Width = 80
        'DataGridView1.Columns.Item(11).Width = 40
        'DataGridView1.Columns.Item(12).Width = 60
        'DataGridView1.Columns.Item(13).Width = 50
        'DataGridView1.Columns.Item(14).Width = 40
        'DataGridView1.Columns.Item(15).Width = 50
        'DataGridView1.Columns.Item(16).Width = 50
        'DataGridView1.Columns.Item(17).Width = 50
        'DataGridView1.Columns.Item(18).Width = 80
        btnFpiObi.Image = Image.FromFile(app & "sun.png")
        btnOtros.Image = Image.FromFile(app & "sun.png")
    End Sub
    Public Sub limpia()
        If cmbNumeroMuestra.Text = "BARRIDO" Then
            chkSuero.Checked = True
            txtCodeMuestra.Clear()
            txtCodeShared1.Clear()
            txtCodeShared2.Clear()
            txtCodeIns.Clear()
            txtCodeParticipante.Clear()
            txtCodeParticipante.Focus()
        Else
            chkSangre.Checked = False
            chkSuero.Checked = False
            chkHisopado.Checked = False
            chkOrina.Checked = False
            chkLcr.Checked = False
            chkPlasma.Checked = False
            chkShared.Checked = False
            txtCodeMuestra.Clear()
            txtCodeShared1.Clear()
            txtCodeShared2.Clear()
            txtCodeIns.Clear()
            txtCodeParticipante.Clear()
            txtCodeShared1.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeMuestra.GotFocus
        txtCodeMuestra.BackColor = Color.Yellow
    End Sub
    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodeMuestra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Graba_recepcion()
        End If
    End Sub
    Private Sub CheckBox1_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSangre.GotFocus
        chkSangre.BackColor = Color.Yellow
    End Sub
    Private Sub CheckBox2_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSuero.GotFocus
        chkSuero.BackColor = Color.Yellow
    End Sub
    Private Sub CheckBox3_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkHisopado.GotFocus
        chkHisopado.BackColor = color.Yellow
    End Sub
    Private Sub CheckBox4_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOrina.GotFocus
        chkOrina.BackColor = Color.Yellow
    End Sub
    Private Sub CheckBox5_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLcr.GotFocus
        chkLcr.BackColor = Color.Yellow
    End Sub
    Private Sub CheckBox6_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPlasma.GotFocus
        chkPlasma.BackColor = Color.Yellow
    End Sub
    Private Sub CheckBox7_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShared.Click
        If chkShared.Checked Then
            txtCodeShared1.Enabled = True
            txtCodeShared2.Enabled = True
            txtCodeShared3.Enabled = True
            txtCodeShared4.Enabled = True

            txtCodeShared1.BackColor = Color.White
            txtCodeShared2.BackColor = Color.White
            txtCodeShared3.BackColor = Color.White
            txtCodeShared4.BackColor = Color.White
            txtCodeShared1.Focus()
        Else
            txtCodeShared1.Enabled = False
            txtCodeShared2.Enabled = False
            txtCodeShared3.Enabled = False
            txtCodeShared4.Enabled = False

            txtCodeShared1.BackColor = Me.BackColor
            txtCodeShared2.BackColor = Me.BackColor
            txtCodeShared3.BackColor = Me.BackColor
            txtCodeShared4.BackColor = Me.BackColor
        End If
    End Sub
    Private Sub CheckBox7_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShared.GotFocus
        chkShared.BackColor = Color.Yellow
    End Sub

    Private Sub CheckBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkSangre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chkSuero.Focus()
        End If
    End Sub
    Private Sub CheckBox1_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSangre.LostFocus
        chkSangre.BackColor = Me.BackColor
    End Sub

    Private Sub CheckBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkSuero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chkHisopado.Focus()
        End If
    End Sub
    Private Sub CheckBox2_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSuero.LostFocus
        chkSuero.BackColor = Me.BackColor
    End Sub

    Private Sub CheckBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkHisopado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chkOrina.Focus()
        End If
    End Sub
    Private Sub CheckBox3_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkHisopado.LostFocus
        chkHisopado.BackColor = Me.BackColor
    End Sub

    Private Sub CheckBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkOrina.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chkLcr.Focus()
        End If
    End Sub
    Private Sub CheckBox4_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOrina.LostFocus
        chkOrina.BackColor = Me.BackColor
    End Sub

    Private Sub CheckBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkLcr.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chkPlasma.Focus()
        End If
    End Sub
    Private Sub CheckBox5_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLcr.LostFocus
        chkLcr.BackColor = Me.BackColor
    End Sub

    Private Sub CheckBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkPlasma.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbNumeroMuestra.Focus()
        End If
    End Sub
    Private Sub CheckBox6_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPlasma.LostFocus
        chkPlasma.BackColor = Me.BackColor
    End Sub
    Private Sub CheckBox7_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShared.LostFocus
        chkShared.BackColor = Me.BackColor
    End Sub

    Private Sub ComboBox1_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNumeroMuestra.GotFocus
        cmbNumeroMuestra.BackColor = Color.Yellow
    End Sub

    Private Sub ComboBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNumeroMuestra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCodeIns.Focus()
        End If
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNumeroMuestra.LostFocus
        cmbNumeroMuestra.BackColor = BackColor
    End Sub
    Private Sub CheckBox7_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkShared.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If chkShared.Checked Then
                txtCodeMuestra.Focus()
            Else
                txtCodeIns.Focus()
            End If
        End If
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeMuestra.LostFocus
        txtCodeMuestra.BackColor = Color.White
    End Sub
    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeShared1.GotFocus
        txtCodeShared1.BackColor = Color.Yellow
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodeShared1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCodeShared2.Focus()
        End If
    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeShared1.LostFocus
        txtCodeShared1.BackColor = Color.White
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeShared2.GotFocus
        txtCodeShared2.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodeShared2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCodeShared3.Focus()
            txtCodeShared1.BackColor = Color.White
        End If
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeShared2.LostFocus
        txtCodeShared2.BackColor = Color.White
    End Sub

    Private Sub TextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeIns.GotFocus
        txtCodeIns.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodeIns.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chkShared.Focus()
        End If
    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeIns.LostFocus
        txtCodeIns.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        fmrBusquedaCodigo.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarFila.Click
        llenandoform8()
        frmEditarRecepcion.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        llenandoform8()
        frmEditarRecepcion.ShowDialog()
    End Sub
    Public Sub llenandoform8()
        '''''''''''''''''''''''''''''''
        Dim num As Integer = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value 'atrapa el id para hacer el update
        'LLENANDO EL COMBO DE FORM8''''''''''''''''''''''''''''''
        frmEditarRecepcion.Label6.Text = num ' asigna el Id en el label de l form8 para poder hacer la actualizacion
        frmEditarRecepcion.cmbNumeroMuestra.Items.Clear()
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("AGUDO")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("CONVALECIENTE")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("VIGILANCIA")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("BARRIDO")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("BROTE")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("MUESTRA2")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("3M")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("6M")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("12M")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("24M")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("36M")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("42M")
        frmEditarRecepcion.cmbNumeroMuestra.Items.Add("OTRO")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        frmEditarRecepcion.txtMuestra.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value.ToString
        frmEditarRecepcion.txtIdCompartido.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value.ToString
        frmEditarRecepcion.txtPartCode.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value.ToString
        frmEditarRecepcion.txtCodeIns.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value.ToString
        'frmEditarRecepcion.txtCode2.Text = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value.ToString
        'frmEditarRecepcion.txtCode3.Text = DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value.ToString
        'frmEditarRecepcion.txtCode4.Text = DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value.ToString
        'frmEditarRecepcion.txtCode5.Text = DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value.ToString
        frmEditarRecepcion.cmbNumeroMuestra.Text = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value
        frmEditarRecepcion.dtFechaRegistro.Value = DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value

        If DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value.ToString = "si" Then
            frmEditarRecepcion.chkSangre.Checked = True
        Else
            frmEditarRecepcion.chkSangre.Checked = False
        End If
        If DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value.ToString = "si" Then
            frmEditarRecepcion.chkSuero.Checked = True
        Else
            frmEditarRecepcion.chkSuero.Checked = False
        End If
        If DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value.ToString = "si" Then
            frmEditarRecepcion.chkHisopado.Checked = True
        Else
            frmEditarRecepcion.chkHisopado.Checked = False
        End If
        If DataGridView1.Item(10, DataGridView1.CurrentCell.RowIndex).Value.ToString = "si" Then
            frmEditarRecepcion.chkOrina.Checked = True
        Else
            frmEditarRecepcion.chkOrina.Checked = False
        End If
        If DataGridView1.Item(11, DataGridView1.CurrentCell.RowIndex).Value.ToString = "si" Then
            frmEditarRecepcion.chkLcr.Checked = True
        Else
            frmEditarRecepcion.chkLcr.Checked = False
        End If
        If DataGridView1.Item(12, DataGridView1.CurrentCell.RowIndex).Value.ToString = "si" Then
            frmEditarRecepcion.chkPlasma.Checked = True
        Else
            frmEditarRecepcion.chkPlasma.Checked = False
        End If
        frmEditarRecepcion.txtCongelamiento.Text = DataGridView1.Item(14, DataGridView1.CurrentCell.RowIndex).Value.ToString

    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeParticipante.LostFocus
        txtCodeParticipante.BackColor = Color.White
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodeParticipante.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCodeMuestra.Focus()
        End If
    End Sub
    Private Sub TextBox5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodeParticipante.GotFocus
        txtCodeParticipante.BackColor = Color.Yellow
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNumeroMuestra.SelectedIndexChanged
        If cmbNumeroMuestra.Text = "BARRIDO" Then
            GroupBox1.Visible = True
            chkSangre.Checked = False
            chkSuero.Checked = True
            chkHisopado.Checked = False
            chkOrina.Checked = False
            chkLcr.Checked = False
            chkPlasma.Checked = False
            txtCodeMuestra.Focus()
        Else
            txtCodeParticipante.Text = ""
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 35
        DataGridView1.Height = Me.Height - 410
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFpiObi.Click
        If llave = True Then
            llave = False
            btnFpiObi.Image = Image.FromFile(app & "sun.png")
        Else
            llave = True
            btnFpiObi.Image = Image.FromFile(app & "snow.png")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtros.Click
        If llave2 = True Then
            llave2 = False
            btnOtros.Image = Image.FromFile(app & "sun.png")
        Else
            llave2 = True
            btnOtros.Image = Image.FromFile(app & "snow.png")
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSangre.CheckedChanged
        'SANGRE
        If chkSangre.Checked = True Then
            cmbNumeroMuestra.Text = "AGUDO"
        ElseIf (chkHisopado.Checked = False And chkOrina.Checked = False And chkLcr.Checked = False And chkPlasma.Checked = False) Then
            cmbNumeroMuestra.Text = "CONVALECIENTE"
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSuero.CheckedChanged
        'SUERO
        If (chkSuero.Checked = True And chkSangre.Checked = False And chkHisopado.Checked = False And chkOrina.Checked = False And chkLcr.Checked = False And chkPlasma.Checked = False) Then
            cmbNumeroMuestra.Text = "CONVALECIENTE"
        End If

    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHisopado.CheckedChanged
        'HISOPADO
        If chkHisopado.Checked = True Then
            cmbNumeroMuestra.Text = "AGUDO"
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlasma.CheckedChanged
        'PLASMA
        If chkPlasma.Checked = True Then
            cmbNumeroMuestra.Text = "CONVALECIENTE"
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtCodeParticipante.TextChanged

    End Sub

    Private Sub TmTime_Tick(sender As Object, e As EventArgs) Handles TmTime.Tick
        txtHora.Text = Hour(TimeOfDay) & ":" & Minute(TimeOfDay) & ":" & Second(TimeOfDay)
    End Sub

    Private Sub txtSampleFreeze_GotFocus(sender As Object, e As EventArgs) Handles txtCodeCongelamiento.GotFocus
        txtCodeCongelamiento.BackColor = Color.LightBlue
    End Sub

    Private Sub txtSampleFreeze_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodeCongelamiento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'Comprobando Muestra
            cmdcomando = New OleDbCommand("select code from sample_reception where code='" & txtCodeCongelamiento.Text.Trim.ToUpper & "'", bd)
            Dim reader As OleDbDataReader = cmdcomando.ExecuteReader
            If reader.Read Then
                'Registrando Hora de Congelamiento
                cmdcomando = New OleDbCommand("update sample_reception set congelamiento='" & txtHora.Text.Trim.ToUpper & "' where code='" & txtCodeCongelamiento.Text & "'", bd)
                cmdcomando.ExecuteNonQuery()

                If (MsgBox("Registro de Congelamiento Exitoso, desea registrar otra muestra CONGELADA?", vbInformation + vbOKCancel, "Congelamiento")) = MsgBoxResult.Ok Then
                    AgregaList()
                    txtCodeCongelamiento.Clear()
                    txtCodeCongelamiento.Focus()
                Else
                    GroupBox2.Visible = False
                    txtCodeCongelamiento.Visible = False
                    Label9.Visible = False
                    txtCodeMuestra.Focus()
                End If
            Else
                MsgBox("La muestra aun no ha sido registrada", MsgBoxStyle.Critical, "StafVir")
            End If
        End If
    End Sub

    Private Sub txtSampleFreeze_LostFocus(sender As Object, e As EventArgs) Handles txtCodeCongelamiento.LostFocus
        txtCodeCongelamiento.BackColor = Color.White
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnMuestraCongelamiento.Click
        If GroupBox2.Visible = False Then
            GroupBox2.Visible = True
            txtCodeCongelamiento.Visible = True
            Label9.Visible = True
            txtCodeCongelamiento.Clear()
            txtCodeCongelamiento.Focus()
        Else
            GroupBox2.Visible = False
            txtCodeCongelamiento.Visible = False
            Label9.Visible = False
        End If
    End Sub
    Private Sub txtCodeShared3_GotFocus(sender As Object, e As EventArgs) Handles txtCodeShared3.GotFocus
        txtCodeShared3.BackColor = Color.Yellow
    End Sub

    Private Sub txtCodeShared4_GotFocus(sender As Object, e As EventArgs) Handles txtCodeShared4.GotFocus
        txtCodeShared4.BackColor = Color.Yellow
    End Sub

    Private Sub txtCodeShared3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodeShared3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCodeShared4.Focus()
            txtCodeShared3.BackColor = Color.White
        End If
    End Sub

    Private Sub txtCodeShared3_LostFocus(sender As Object, e As EventArgs) Handles txtCodeShared3.LostFocus
        txtCodeShared3.BackColor = Color.White
    End Sub

    Private Sub txtCodeShared4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodeShared4.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCodeMuestra.Focus()
            txtCodeShared4.BackColor = Color.White
        End If
    End Sub

    Private Sub txtCodeShared4_LostFocus(sender As Object, e As EventArgs) Handles txtCodeShared4.LostFocus
        txtCodeShared4.BackColor = Color.White
    End Sub

    Private Sub txtCodeCongelamiento_TextChanged(sender As Object, e As EventArgs) Handles txtCodeCongelamiento.TextChanged

    End Sub

    Private Sub txtCodeMuestra_TextChanged(sender As Object, e As EventArgs) Handles txtCodeMuestra.TextChanged

    End Sub

    Private Sub btnCompartir_Click(sender As Object, e As EventArgs) Handles btnCompartir.Click
        If comp = "0" Then
            Timer1.Enabled = False
            btnCompMuestra.Visible = False
            btnCompartir.BackColor = Me.BackColor
            btnCompartir.BackgroundImage = Image.FromFile(app & "unlock.ico")
            comp = "1"
        ElseIf comp = "1" Then
            Timer1.Enabled = True
            btnCompMuestra.Visible = True
            btnCompartir.BackColor = Color.LightGreen
            btnCompartir.BackgroundImage = Image.FromFile(app & "lock.ico")
            comp = "0"
            ''encontrando Id de Tabla compartido
            cmdcomando = New OleDbCommand("select top 1 idCompartido from Sample_reception order by IdCompartido desc", bd)
            Dim reader3 As OleDbDataReader = cmdcomando.ExecuteReader
            If reader3.Read Then
                idCompartido = reader3.Item(0)
                idCompartido = idCompartido + 1
            End If
            reader3.Close()
            ''''''''''''''''''''''''''''''''''''''''''''
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case coloraviso
            Case ""
                btnCompMuestra.ForeColor = Color.Red
                coloraviso = "1"
            Case "1"
                btnCompMuestra.ForeColor = Color.Orange
                coloraviso = "2"
            Case "2"
                btnCompMuestra.ForeColor = Color.Green
                coloraviso = "3"
            Case "3"
                btnCompMuestra.ForeColor = Color.LightBlue
                coloraviso = "4"
            Case "4"
                btnCompMuestra.ForeColor = Color.Black
                coloraviso = "5"
            Case "5"
                btnCompMuestra.ForeColor = Color.LightPink
                coloraviso = ""
        End Select
    End Sub
End Class
