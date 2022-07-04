Imports System.Data.OleDb
Public Class Form6
    Dim cmdcomando As OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        agregar_codigo()
    End Sub

    Private Sub Form6_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmFiltroMuestraEnvio.ComboBox1.Items.Clear()
        frmFiltroMuestraEnvio.llenacombo()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenagrid()
    End Sub
    Public Sub llenagrid()
        Dim adapter As New OleDbDataAdapter("select * from Codes", bd)
        Dim dataset As New DataSet
        adapter.Fill(dataset, "codes")
        DataGridView1.DataSource = dataset.Tables(0)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro de Borrar un codigo?", vbYesNo + vbExclamation, "Delete") = vbYes Then
            'presentancion
            cmdcomando = New OleDbCommand("delete from codes where code='" & DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value & "'", bd)
            cmdcomando.ExecuteNonQuery()
            MsgBox("Codigo Borrado satisfactoriamente", vbInformation)
        End If
        llenagrid()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
    Public Sub agregar_codigo()
        cmdcomando = New OleDbCommand("insert into codes(code) values('" & TextBox1.Text.Trim.ToUpper & "')", bd)
        cmdcomando.ExecuteNonQuery()
        MsgBox("El codigo se ha registrado correctamente", vbInformation, "Register")
        llenagrid()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            agregar_codigo()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class