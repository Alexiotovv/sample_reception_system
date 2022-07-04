Imports System.Data.OleDb
Public Class frmEditarRecepcion
    Dim cmdcomando As New OleDbCommand
    'Dim code2 As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCerrar.Click
        Close()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCambios.Click
        Dim san, sue, hiso, ori, lcr, plas As String
        'cod, cod_ins, cod2, cod3, cod4, cod5, num,
        'Dim fech As Date
        Dim id As Integer
        id = Label6.Text
        'cod = txtMuestra.Text
        'cod_ins = txtCodeIns.Text
        'cod2 = txtCode2.Text
        'cod3 = txtCode3.Text
        'cod4 = txtCode4.Text
        'cod5 = txtCode5.Text
        'num = cmbNumeroMuestra.Text
        'fech = dtFechaRegistro.Value
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

        cmdcomando = New OleDbCommand("update sample_reception set code ='" & txtMuestra.Text.Trim.ToUpper & "'," & _
                    "part_code='" & txtPartCode.Text.Trim.ToUpper & "'," & _
                    "code_ins='" & txtCodeIns.Text.Trim.ToUpper & "'," & _
                    "sample_number='" & cmbNumeroMuestra.Text & "'," & _
                    "fecha='" & dtFechaRegistro.Value & "'," & _
                    "sangre='" & san & "'," & _
                    "suero='" & sue & "'," & _
                    "hisopado='" & hiso & "'," & _
                    "orina='" & ori & "'," & _
                    "lcr='" & lcr & "'," & _
                    "plasma='" & plas & "'," & _
                    "usuario='" & usu & "'," & _
                    "congelamiento='" & txtCongelamiento.Text & "' " & _
                    "where sample_reception.id = " & id & "", bd)
        cmdcomando.ExecuteNonQuery()

        'cmdcomando = New OleDbCommand("update sample_reception set  code ='" & cod & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  code_ins ='" & cod_ins & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  code2 ='" & cod2 & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  code3 ='" & cod3 & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  sample_number ='" & num & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  fecha ='" & fech & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  sangre ='" & san & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  suero ='" & sue & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  hisopado ='" & hiso & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  orina ='" & ori & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  lcr ='" & lcr & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  plasma ='" & plas & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  usuario ='" & usu & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set  part_code ='" & txtPartCode.Text.Trim.ToUpper & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()
        'cmdcomando = New OleDbCommand("update sample_reception set congelamiento='" & txtCongelamiento.Text & "' where sample_reception.id = " & id & "", bd)
        'cmdcomando.ExecuteNonQuery()

        frmRecepcionMuestra.AgregaList()
        Dim n As Integer = frmRecepcionMuestra.DataGridView1.RowCount - 2
        Dim i As Integer = 0
        Do While (i <= n)
            If (frmRecepcionMuestra.DataGridView1.Item(0, i).Value.ToString = id) Then
                frmRecepcionMuestra.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                frmRecepcionMuestra.DataGridView1.CurrentCell = frmRecepcionMuestra.DataGridView1.Item(0, i)
                Exit Do
            End If
            i += 1
        Loop
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If txtCongelamiento.Text.Trim = "" Then
            txtCongelamiento.Text = Hour(TimeOfDay) & ":" & Minute(TimeOfDay) & ":" & Second(TimeOfDay)
        ElseIf MsgBox("Ya existe una hora de congelamiento, si continúa, perdera la hora actual, Desea Continuar?", MsgBoxStyle.YesNo + vbExclamation) = MsgBoxResult.Yes Then
            txtCongelamiento.Text = Hour(TimeOfDay) & ":" & Minute(TimeOfDay) & ":" & Second(TimeOfDay)
        End If

    End Sub

    Private Sub frmEditarRecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class