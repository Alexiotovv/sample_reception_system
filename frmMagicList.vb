Imports System.Data.OleDb
Public Class frmMagicList
    Dim cmdcomando As New OleDbCommand
    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbSampleCode.Checked = True
        Dim adapter As New OleDbDataAdapter("select id,code,part_code,sample_number,fecha,usuario from sample_reception where sample_number='BARRIDO' order by id desc", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "tablita")

        DataGridView1.DataSource = dataSet.Tables(0)

        DataGridView1.Columns.Item(0).Width = 50
        DataGridView1.Columns.Item(1).Width = 100
        DataGridView1.Columns.Item(2).Width = 100
        DataGridView1.Columns.Item(3).Width = 90
        DataGridView1.Columns.Item(4).Width = 70
        DataGridView1.Columns.Item(5).Width = 100

    End Sub

    Private Sub Form12_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 20
        DataGridView1.Height = Me.Height - 100
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            ''Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            '' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DataGridView1.ColumnCount
            Dim NRow As Integer = DataGridView1.RowCount
            ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DataGridView1.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DataGridView1.Rows(Fila).Cells(Col).Value
                Next
            Next
            ''Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            ''Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub

    Private Sub rbSampleCode_CheckedChanged(sender As Object, e As EventArgs) Handles rbSampleCode.CheckedChanged
        If rbSampleCode.Checked = True Then
            Label1.Text = "Sample Code"
            txtCode.Clear()
            txtCode.Focus()
        End If
    End Sub

    Private Sub rbPartCode_CheckedChanged(sender As Object, e As EventArgs) Handles rbPartCode.CheckedChanged
        If rbPartCode.Checked = True Then
            Label1.Text = "Part Code"
            txtCode.Clear()
            txtCode.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        Dim dataSet As New DataSet
        If rbSampleCode.Checked = True Then
            Dim adapter As New OleDbDataAdapter("select id,code,part_code,sample_number,fecha,usuario from sample_reception where sample_number='BARRIDO' and code like '%" & txtCode.Text.Trim.ToUpper & "%' order by id desc", bd)
            adapter.Fill(dataSet, "tablita")
        Else
            Dim adapter As New OleDbDataAdapter("select id,code,part_code,sample_number,fecha,usuario from sample_reception where sample_number='BARRIDO' and part_code like '%" & txtCode.Text.Trim.ToUpper & "%' order by id desc", bd)
            adapter.Fill(dataSet, "tablita")
        End If
        DataGridView1.DataSource = dataSet.Tables(0)
    End Sub
End Class