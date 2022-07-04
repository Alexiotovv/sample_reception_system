Imports System.Data.OleDb
Public Class frmListavb
    Dim cmd As New OleDbCommand
    Dim valor As String
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmRapidTest.Text = "Nuevo"
        frmRapidTest.ShowDialog()
    End Sub

    Private Sub frmListavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenagrid()
    End Sub
    Public Sub llenagrid()
        If (txtMuestra.Text.Trim = "") Then
            valor = "%"
        Else
            valor = txtMuestra.Text.Trim
        End If
        Dim dp As New OleDbDataAdapter
        Dim st As New DataSet
        dp = New OleDbDataAdapter("select Id,sample_code,test_date,assay,result,result_IgM,result_IgG,entered,entered_by,hora from Rapid_test where sample_code like '%" & txtMuestra.Text.Trim & "%' order by Id desc", bdresult)
        dp.Fill(st, "0")
        dgvLista.DataSource = st.Tables(0)
        dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLista.AutoResizeColumns()
    End Sub

    Private Sub txtMuestra_TextChanged(sender As Object, e As EventArgs) Handles txtMuestra.TextChanged
        llenagrid()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        frmRapidTest.Text = "Editar"
        frmRapidTest.ShowDialog()
    End Sub
    Private Sub dgvLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellDoubleClick
        frmRapidTest.Text = "Editar"
        frmRapidTest.ShowDialog()
    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub frmListavb_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        dgvLista.Width = Me.Width - 35
        dgvLista.Height = Me.Height - 100
    End Sub
End Class