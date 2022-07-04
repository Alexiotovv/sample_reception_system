Imports System.Data.OleDb
Public Class Form14
    Dim cmd As New OleDbCommand
    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        llenacombo()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim adapter As New OleDbDataAdapter("select * from resultados_pcrf where running_date=#" & ComboBox1.Text & "#", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "tablita")
        DataGridView1.DataSource = dataSet.Tables(0)
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub llenacombo()
        cmd = New OleDbCommand("select distinct(running_date) from resultados_pcrf", bd)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Do While reader.Read
            ComboBox1.Items.Add(reader.Item(0))
        Loop
        reader.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Call editar()
    End Sub
    Private Sub editar()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call editar()
    End Sub
End Class