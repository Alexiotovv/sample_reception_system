Imports System.Data.OleDb
Public Class frmRespcrInfluenza
    Dim idsr As Integer
    Dim cmd As New OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call llenagrid()
        Call recuento()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DTPicker1.Value = Today
        cmbAssayType.Items.Add("TAQMAN")
        cmbAssayType.Items.Add("LANCIOTTI")
        cmbAssayType.Items.Add("RT-PCR")
        cmbAssayType.Items.Add("PCR")
        cmbAssayType.Items.Add("SYBR GREEN")
        cmbAssayType.Items.Add("SEQUENCING")
        cmbAssayType.Items.Add("MASS TAG")
        cmbAssayType.Items.Add("RESPIFINDER")
        cmbAssayType.Items.Add("TLDA")

        cmbSampleType.Items.Add("SERUM")
        cmbSampleType.Items.Add("SWAB/UTM")
        cmbSampleType.Items.Add("BLOOD")
        cmbSampleType.Items.Add("CSF")
        cmbSampleType.Items.Add("BRAIN")
        cmbSampleType.Items.Add("LIVER")
        cmbSampleType.Items.Add("KIDNEY")
        cmbSampleType.Items.Add("SPLEEN")
        cmbSampleType.Items.Add("VERO-1")
        cmbSampleType.Items.Add("VERO-2")
        cmbSampleType.Items.Add("VERO-3")
        cmbSampleType.Items.Add("C6/36-1")
        cmbSampleType.Items.Add("C6/36-2")
        cmbSampleType.Items.Add("C6/36-3")

        cmbPathogenSearch.Items.Add("ADENO")
        cmbPathogenSearch.Items.Add("ALLV")
        cmbPathogenSearch.Items.Add("ALPHA")
        cmbPathogenSearch.Items.Add("ARENA")
        cmbPathogenSearch.Items.Add("BUNYA")
        cmbPathogenSearch.Items.Add("Chikungunya")
        cmbPathogenSearch.Items.Add("Coxsackie A16")
        cmbPathogenSearch.Items.Add("DENV")
        cmbPathogenSearch.Items.Add("EEE")
        cmbPathogenSearch.Items.Add("EMCV")
        cmbPathogenSearch.Items.Add("Enterovirus")
        cmbPathogenSearch.Items.Add("FLAV")
        cmbPathogenSearch.Items.Add("Group C")
        cmbPathogenSearch.Items.Add("HANTA")
        cmbPathogenSearch.Items.Add("Ilheus")
        cmbPathogenSearch.Items.Add("Influenza")
        cmbPathogenSearch.Items.Add("LEP")
        cmbPathogenSearch.Items.Add("MACV/TCRV")
        cmbPathogenSearch.Items.Add("MAY")
        cmbPathogenSearch.Items.Add("ORO")
        cmbPathogenSearch.Items.Add("Rabies")
        cmbPathogenSearch.Items.Add("RICK")
        cmbPathogenSearch.Items.Add("SLEV")
        cmbPathogenSearch.Items.Add("TCRV")
        cmbPathogenSearch.Items.Add("VEE")
        cmbPathogenSearch.Items.Add("WN")
        cmbPathogenSearch.Items.Add("YFV")

        cmbAssayType.Text = "PCR"
        cmbSampleType.Text = "SERUM"
        cmbPathogenSearch.Text = "Influenza"

        'llenando combos de usuario
        cmd = New OleDbCommand("Select username from usuarios", bd)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Do While reader.Read
            cmbRnaResponsible.Items.Add(reader.Item(0))
            cmbResponsiblePCR.Items.Add(reader.Item(0))
        Loop
        reader.Close()
        cmbRnaResponsible.Text = usu
        cmbResponsiblePCR.Text = usu
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView1.RowCount > 1 Then
            'este codigo graba desde el grid hasta la tabla de resultados_pcrf
            Dim x As Integer
            For x = 0 To DataGridView1.RowCount - 2
                cmd = New OleDbCommand("insert into resultados_pcrf(id_sample_reception,performed_by) values (" & DataGridView1.Item(0, x).Value & ",'" & usu & "')", bd)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Se han grabado " & x & " muestras para procesar ", vbInformation)
            Call llenagrid()
        Else
            MsgBox("No Hay muestras de Hisopados para procesar", vbInformation)
        End If
    End Sub
    Private Sub llenagrid()
        'obteniendo id top de la tabla pcrf para cirteriarizar en la tabla sample_reception
        cmd = New OleDbCommand("select top 1 id_sample_reception from resultados_pcrf order by id_sample_reception desc", bd)
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        '''''''''''''desde aqui verifica codigo''''''''''''''''''''''
        If reader.Read Then
            idsr = reader.GetInt32(0)
            reader.Close()
        End If
        'llenando grid        
        Dim adapter As New OleDbDataAdapter("select sample_reception.id as ID,sample_reception.code as Sample_Code,sample_reception.code_ins as Reference_Code,'" & cmbSampleType.Text & "' as Sample_Type ,'" & cmbPathogenSearch.Text & "' as Pathogen_Search,'" & cmbAssayType.Text & "' as Assay,'' as Results, '' as CTValue, '" & cmbRnaResponsible.Text & "' as RNA_Responsible,'" & cmbResponsiblePCR.Text & "' as PCR_Responsible, sample_reception.fecha as Lab_Reception_Date from sample_reception where (sample_reception.sample_number='AGUDO') and (sample_reception.hisopado='si') and (sample_reception.id >" & idsr & ") order by sample_reception.code asc", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "tablita")
        DataGridView1.DataSource = dataSet.Tables(0)
        DataGridView1.Refresh()
        ''''''''''''''''''''''''''''''''''''''
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AutoResizeColumns()
    End Sub
    Private Sub Form13_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width - 20
        DataGridView1.Height = Me.Height - 125
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form14.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
            For i As Integer = 1 To NCol - 1
                exHoja.Cells.Item(1, i) = DataGridView1.Columns(i).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 1 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col) = DataGridView1.Rows(Fila).Cells(Col).Value
                Next
            Next
            ''Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            ''Aplicación visible
            exApp.Application.Visible = True
            'exApp.Quit()
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value = "no" Then
            DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value = "si"
        Else
            DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value = "no"
        End If
    End Sub
    Private Sub recuento()
        DataGridView1.Refresh()
        Label4.Text = DataGridView1.RowCount - 1
    End Sub
End Class