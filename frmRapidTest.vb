Imports System.Data.OleDb
Public Class frmRapidTest
    Dim cmd As OleDbCommand
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Me.Text = "Nuevo" Then
            grabaregistro()
        Else
            actualizaregistro()
            frmListavb.llenagrid()
            Me.Close()
        End If
    End Sub
    Private Sub limpiar()
        cmbIgM.Text = ""
        txtMuestra.Text = ""
        cmbIgG.Text = ""
        cmbIgM.Text = ""
        cmbResultControl.Text = ""
        dtFecha.Value = Date.Today
        cmbResultControl.Focus()
    End Sub

    Private Sub frmRapidTest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = ""
    End Sub

    Private Sub frmRapidTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Text = "Nuevo" Then
            cmbEnsayo.Text = "NS1"
            dtFecha.Value = Date.Today
            cmbResultControl.Focus()
            limpiar()
        Else
            lbId.Text = frmListavb.dgvLista.Item(0, frmListavb.dgvLista.CurrentCell.RowIndex).Value.ToString()
            txtMuestra.Text = frmListavb.dgvLista.Item(1, frmListavb.dgvLista.CurrentCell.RowIndex).Value.ToString()
            dtFecha.Value = frmListavb.dgvLista.Item(2, frmListavb.dgvLista.CurrentCell.RowIndex).Value
            cmbEnsayo.Text = frmListavb.dgvLista.Item(3, frmListavb.dgvLista.CurrentCell.RowIndex).Value.ToString()
            cmbResultControl.Text = frmListavb.dgvLista.Item(4, frmListavb.dgvLista.CurrentCell.RowIndex).Value.ToString()
            cmbIgM.Text = frmListavb.dgvLista.Item(5, frmListavb.dgvLista.CurrentCell.RowIndex).Value.ToString()
            cmbIgG.Text = frmListavb.dgvLista.Item(6, frmListavb.dgvLista.CurrentCell.RowIndex).Value.ToString()

        End If
    End Sub

    Private Sub cmbResultControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbResultControl.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbIgG.Focus()
        End If

    End Sub
    Private Sub cmbIgG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbIgG.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbIgM.Focus()
        End If
    End Sub

    Private Sub cmbIgM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbIgM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtMuestra.Focus()
        End If
    End Sub
    Private Sub txtMuestra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMuestra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If (Me.Text = "Nuevo") Then
                grabaregistro()
            Else
                actualizaregistro()
            End If
        End If
    End Sub
    Private Sub grabaregistro()
        'comprobando codigo de resultado
        cmd = New OleDbCommand("select sample_code from Rapid_test where sample_code='" & txtMuestra.Text.Trim & "'", bdresult)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If (dr.Read) Then
            MsgBox("Ya existe un resultado para este código")
        Else
            cmd = New OleDbCommand("insert into Rapid_test (sample_code,test_date,assay,result,result_IgG,result_IgM,entered,entered_by,aviso,hora) values('" & txtMuestra.Text & "','" & dtFecha.Value & "','" & cmbEnsayo.Text & "','" & cmbResultControl.Text & "','" & cmbIgG.Text & "','" & cmbIgM.Text & "','" & DateAndTime.Now & "','" & usu & "','" & "0" & "','" & TimeOfDay & "')", bdresult)
            cmd.ExecuteNonQuery()
            limpiar()
            MsgBox("Registro Grabado")
        End If
    End Sub
    Private Sub actualizaregistro()
        'Dim fecha As Date
        'fecha = Today
        cmd = New OleDbCommand("update Rapid_test set sample_code='" & txtMuestra.Text & "',test_date='" & dtFecha.Value & "',assay='" & cmbEnsayo.Text & "',result='" & cmbResultControl.Text & "',result_IgG='" & cmbIgG.Text & "',result_IgM='" & cmbIgM.Text & "',entered='" & DateAndTime.Now & "',entered_by='" & usu & "' where Id=" & Convert.ToInt32(lbId.Text) & "", bdresult)
        cmd.ExecuteNonQuery()
        MsgBox("Registro Actualizado")

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub
End Class