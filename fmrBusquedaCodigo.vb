Imports System.Data.OleDb
Public Class fmrBusquedaCodigo
    Dim cmdcomando As New OleDbCommand
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim num As Integer = frmRecepcionMuestra.DataGridView1.RowCount - 2
            Dim i As Integer = 0
            Do While (i <= num)
                If (frmRecepcionMuestra.DataGridView1.Item(1, i).Value.ToString = TextBox1.Text.Trim.ToUpper) Then
                    frmRecepcionMuestra.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    frmRecepcionMuestra.DataGridView1.CurrentCell = frmRecepcionMuestra.DataGridView1.Item(1, i)
                    Exit Sub
                End If
                i += 1
            Loop
            MsgBox("El codigo aun no esta registrado", vbInformation, "Registro")
            TextBox1.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class