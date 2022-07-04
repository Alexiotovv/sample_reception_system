Imports System.Data.OleDb
Public Class frmFiltroMuestraEnvio
    Dim cmdcomando As New OleDbCommand
    Private _day As String

    Private Property Day(ByVal fecha As String) As String
        Get
            Return _day
        End Get
        Set(ByVal value As String)
            _day = value
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vcod As String
        vcod = ComboBox1.Text
        If (vcod = "") Then
            MsgBox("Select option", vbCritical, "Option")
        Else
            If (vcod = "ShowAll") Then
                vcod = "%"
            End If
            'modificando formato


            Dim mes, dia, año, fecha As String
            If RadioButton1.Checked = True Then
                fecha = DTPicker1.Value.ToString
            Else
                fecha = ComboBox2.Text.ToString
            End If
            dia = DateAndTime.Day(fecha)
            mes = DateAndTime.Month(fecha)
            año = DateAndTime.Year(fecha)
            fecha = mes & "/" & dia & "/" & año

            Dim adapter As New OleDbDataAdapter("select sangre.code as Sangre,sample_reception.sample_number as Sample_Number from sangre left join sample_reception on sample_reception.code=sangre.code where sangre.code like '%" & vcod & "%' and sangre.fecha = #" & fecha & "#", bd)
            Dim adapter2 As New OleDbDataAdapter("select suero.code as Suero,sample_reception.sample_number as Sample_Number from suero left join sample_reception on sample_reception.code=suero.code where suero.code like '%" & vcod & "%' and suero.fecha = #" & fecha & "#", bd)
            Dim adapter3 As New OleDbDataAdapter("select hisopado.code as Hisopado,sample_reception.sample_number as Sample_Number from hisopado left join sample_reception on sample_reception.code=hisopado.code where hisopado.code like '%" & vcod & "%' and hisopado.fecha = #" & fecha & "#", bd)
            Dim adapter4 As New OleDbDataAdapter("select orina.code as Orina,sample_reception.sample_number as Sample_Number from orina left join sample_reception on sample_reception.code=orina.code where orina.code like '%" & vcod & "%' and orina.fecha = #" & fecha & "#", bd)
            Dim adapter5 As New OleDbDataAdapter("select lcr.code as Lcr,sample_reception.sample_number as Sample_Number from lcr left join sample_reception on sample_reception.code=lcr.code where lcr.code like '%" & vcod & "%' and lcr.fecha = #" & fecha & "#", bd)
            Dim adapter6 As New OleDbDataAdapter("select plasma.code as Plasma,sample_reception.sample_number as Sample_Number from plasma left join sample_reception on sample_reception.code=plasma.code where plasma.code like '%" & vcod & "%' and plasma.fecha = #" & fecha & "#", bd)
            Dim adapter7 As New OleDbDataAdapter("select hisopado_a.code as HisopadoCA,sample_reception.sample_number as Sample_Number from hisopado_a left join sample_reception on sample_reception.code=hisopado_a.code where hisopado_a.code like '%" & vcod & "%' and hisopado_a.fecha = #" & fecha & "#", bd)
            Dim dataSet As New DataSet
            adapter.Fill(dataSet, "sangre")
            adapter2.Fill(dataSet, "suero")
            adapter3.Fill(dataSet, "hisopado")
            adapter4.Fill(dataSet, "orina")
            adapter5.Fill(dataSet, "lcr")
            adapter6.Fill(dataSet, "plasma")
            adapter7.Fill(dataSet, "hisopado_a")
            DataGridView1.DataSource = dataSet.Tables.Item(0)
            DataGridView2.DataSource = dataSet.Tables.Item(1)
            DataGridView3.DataSource = dataSet.Tables.Item(2)
            DataGridView4.DataSource = dataSet.Tables.Item(3)
            DataGridView5.DataSource = dataSet.Tables.Item(4)
            DataGridView6.DataSource = dataSet.Tables.Item(5)
            DataGridView7.DataSource = dataSet.Tables.Item(6)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ''Creamos las variables
        'Dim exApp As New Microsoft.Office.Interop.Excel.Application
        'Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        'Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        'Try
        '    ''Añadimos el Libro al programa, y la hoja al libro
        '    exLibro = exApp.Workbooks.Add
        '    exHoja = exLibro.Worksheets.Add()
        '    '' ¿Cuantas columnas y cuantas filas?
        '    Dim NCol As Integer = DataGridView1.ColumnCount
        '    Dim NRow As Integer = DataGridView1.RowCount
        '    ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
        '    For i As Integer = 1 To NCol
        '        exHoja.Cells.Item(1, i) = DataGridView1.Columns(i - 1).Name.ToString
        '    Next
        '    For Fila As Integer = 0 To NRow - 1
        '        For Col As Integer = 0 To NCol - 1
        '            exHoja.Cells.Item(Fila + 2, Col + 1) = DataGridView1.Rows(Fila).Cells(Col).Value
        '        Next
        '    Next
        '    ''Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
        '    exHoja.Rows.Item(1).Font.Bold = 1
        '    exHoja.Rows.Item(1).HorizontalAlignment = 3
        '    exHoja.Columns.AutoFit()
        '    ''Aplicación visible
        '    exApp.Application.Visible = True
        '    exHoja = Nothing
        '    exLibro = Nothing
        '    exApp = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        'End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ProgressBar1.Visible = True
        Label11.Visible = True

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim worksheet As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            worksheet = exApp.Workbooks.Add
            exHoja = worksheet.Worksheets.Add()

            Dim num1 As Integer = DataGridView1.RowCount
            Dim num2 As Integer = DataGridView2.RowCount
            Dim num3 As Integer = DataGridView3.RowCount
            Dim num4 As Integer = DataGridView4.RowCount
            Dim num5 As Integer = DataGridView5.RowCount
            Dim num6 As Integer = DataGridView6.RowCount
            Dim num7 As Integer = DataGridView7.RowCount
            Dim nprogres As Integer = (num1 + num2 + num3 + num4 + num5 + num6 + num7)
            ProgressBar1.Maximum = nprogres
            exHoja.Cells.Item(1, 1) = "Fecha de Envio:"
            exHoja.Cells.Item(2, 1) = "Sede:"
            exHoja.Cells.Item(3, 1) = "Responsable:"
            exHoja.Cells.Item(1, 2) = Today
            exHoja.Cells.Item(2, 2) = "Iquitos-Lab. de Virologia"
            exHoja.Cells.Item(5, 1) = "Codigo de Muestra"
            exHoja.Cells.Item(5, 2) = "Tipo Paciente"
            exHoja.Cells.Item(5, 3) = "Tipo Muestra"
            exHoja.Cells.Item(5, 4) = "Numero Viales"

            Dim rowIndex As Integer = 6
            num1 = (num1 - 1)
            Dim i As Integer = 0
            Do While (i <= num1)
                exHoja.Cells.Item(rowIndex, 1) = (DataGridView1.Rows(i).Cells(0).Value)
                exHoja.Cells.Item(rowIndex, 2) = (DataGridView1.Rows(i).Cells(1).Value)
                exHoja.Cells.Item(rowIndex, 3) = "SANGRE"
                rowIndex += 1
                i += 1
                ProgressBar1.Value = rowIndex
            Loop

            rowIndex -= 1

            num2 = (num2 - 1)
            Dim j As Integer = 0
            Do While (j <= num2)
                exHoja.Cells.Item(rowIndex, 1) = (DataGridView2.Rows(j).Cells(0).Value)
                exHoja.Cells.Item(rowIndex, 2) = (DataGridView2.Rows(j).Cells(1).Value)
                exHoja.Cells.Item(rowIndex, 3) = "SUERO"
                rowIndex += 1
                j += 1
                ProgressBar1.Value = rowIndex
            Loop
            rowIndex -= 1
            num3 = (num3 - 1)
            Dim k As Integer = 0
            Do While (k <= num3)
                exHoja.Cells.Item(rowIndex, 1) = (DataGridView3.Rows(k).Cells(0).Value)
                exHoja.Cells.Item(rowIndex, 2) = (DataGridView3.Rows(k).Cells(1).Value)
                exHoja.Cells.Item(rowIndex, 3) = "HISOPADO"
                rowIndex += 1
                k += 1
                ProgressBar1.Value = rowIndex
            Loop
            rowIndex -= 1

            num7 = (num7 - 1)
            Dim m As Integer = 0
            Do While (m <= num7)
                exHoja.Cells.Item(rowIndex, 1) = (DataGridView7.Rows(m).Cells(0).Value)
                exHoja.Cells.Item(rowIndex, 2) = (DataGridView7.Rows(m).Cells(1).Value)
                exHoja.Cells.Item(rowIndex, 3) = "HISOPADO/C.ANTIBIOTICO"
                rowIndex += 1
                m += 1
                ProgressBar1.Value = rowIndex
            Loop
            rowIndex -= 1

            num4 = (num4 - 1)
            Dim n As Integer = 0
            Do While (n <= num4)
                exHoja.Cells.Item(rowIndex, 1) = (DataGridView4.Rows(n).Cells(0).Value)
                exHoja.Cells.Item(rowIndex, 2) = (DataGridView4.Rows(n).Cells(1).Value)
                exHoja.Cells.Item(rowIndex, 3) = "ORINA"
                rowIndex += 1
                n += 1
                ProgressBar1.Value = rowIndex
            Loop
            rowIndex -= 1

            num5 = (num5 - 1)
            Dim o As Integer = 0
            Do While (o <= num5)
                exHoja.Cells.Item(rowIndex, 1) = (DataGridView5.Rows(o).Cells(0).Value)
                exHoja.Cells.Item(rowIndex, 2) = (DataGridView5.Rows(o).Cells(1).Value)
                exHoja.Cells.Item(rowIndex, 3) = "LCR"
                rowIndex += 1
                o += 1
                ProgressBar1.Value = rowIndex
            Loop
            rowIndex -= 1

            num6 = (num6 - 1)
            Dim p As Integer = 0
            Do While (p <= num6)
                exHoja.Cells.Item(rowIndex, 1) = (DataGridView6.Rows(p).Cells(0).Value)
                exHoja.Cells.Item(rowIndex, 2) = (DataGridView6.Rows(p).Cells(1).Value)
                exHoja.Cells.Item(rowIndex, 3) = "PLASMA"
                rowIndex += 1
                p += 1
                ProgressBar1.Value = rowIndex
            Loop

            exHoja.Columns.AutoFit()
            exHoja.Cells.Item((rowIndex - 1), 3) = ""
            exApp.Application.Visible = True

            'Application.Application.Visible = True
            worksheet = Nothing
            exApp = Nothing
            exHoja = Nothing
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            Label11.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form6.ShowDialog()
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (Strings.Asc(e.KeyChar) = 13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Top = 0
        Left = 0
        DTPicker1.Value = Today
        DTPicker1.Focus()
        llenacombo()
        'POR EL MOMENTO SE ESTA HACIENDO SOLO DE SANGRE, PARA LUEGO HACER DE TODOS LOS CHEKKEOS
        cmdcomando = New OleDbCommand("select distinct(fecha) from sangre", bd)
        Dim reader As OleDbDataReader
        reader = cmdcomando.ExecuteReader
        Do While reader.Read
            ComboBox2.Items.Add(reader.Item(0))
        Loop
        reader.Close()
    End Sub
    Public Sub llenacombo()
        cmdcomando = New OleDbCommand("Select code from codes", bd)
        Dim reader As OleDbDataReader
        reader = cmdcomando.ExecuteReader
        Do While reader.Read
            ComboBox1.Items.Add(reader.Item(0))
        Loop
        reader.Close()
        ComboBox1.Text = "ShowAll"

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label1.Enabled = True
            DTPicker1.Enabled = True
        Else
            Label1.Enabled = False
            DTPicker1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label10.Enabled = True
            ComboBox2.Enabled = True
        Else
            Label10.Enabled = False
            ComboBox2.Enabled = False
        End If
    End Sub
End Class