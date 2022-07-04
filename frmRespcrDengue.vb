Imports System.Data.OleDb
Public Class frmRespcrDengue
    Dim cmdcomando As New OleDbCommand
    Dim idsr As Integer = 0
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        llenagrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (MsgBox("Esta completamente seguro de grabar los códigos para el procesamiento, después de esta operación no podra revertir el proceso. Despues de esta operación se cargaran las muestras que ingresen desde este momento D:", vbExclamation + vbYesNoCancel, "Grabar") = vbYes) Then
            If DataGridView1.RowCount > 1 Then
                'este codigo graba desde el grid hasta la tabla de resultados_pcrf
                Dim x As Integer
                For x = 0 To DataGridView1.RowCount - 1
                    cmdcomando = New OleDbCommand("insert into resultados_pcr(id_sample_reception) values (" & DataGridView1.Item(0, x).Value & ")", bd)
                    cmdcomando.ExecuteNonQuery()
                Next
                MsgBox("Se han grabado " & x & " muestras para procesar ", vbInformation)
                Call llenagrid()
            Else
                MsgBox("No Hay muestras para procesar", vbInformation)
            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
    Private Sub llenagrid()
        'obteniendo id top de la tabla pcrdengue para criteriarizar en la tabla sample_reception
        cmdcomando = New OleDbCommand("select top 1 id_sample_reception from resultados_pcr order by id_sample_reception desc", bd)
        Dim reader As OleDbDataReader
        reader = cmdcomando.ExecuteReader
        '''''''''''''desde aqui verifica codigo''''''''''''''''''''''
        If reader.Read Then
            idsr = reader.GetInt32(0) 'obtiene el id 
            reader.Close()
        End If
        cmdcomando = New OleDbCommand("select  id,code,idCompartido from Sample_reception where (sample_number='AGUDO') and " & _
                                            "(sangre='si' or sample_reception.suero='si' or plasma='si') and " & _
                                            "(id>" & idsr & ") order by idCompartido,id asc", bd)
        reader = cmdcomando.ExecuteReader

        Dim compart As String = ""
        Dim codigo As String = ""
        Dim id As Integer = 0
        Dim num As Integer = 0
        Dim index As Integer = 0
        Dim c As Integer = 0
        'id, code,idcompartido
        Dim listaids(2, 0) As String

        While reader.Read
            listaids(0, index) = reader(0).ToString 'id
            listaids(1, index) = reader(1).ToString 'code
            listaids(2, index) = reader(2).ToString 'idcompartido
            index = index + 1
            ReDim Preserve listaids(2, index)
        End While
        reader.Close()
        'Dim cant As Integer = index
        Dim codeprin As Integer = 0
        For x = 0 To index
            If listaids(2, x) > "0" Then
                If Convert.ToString(listaids(2, x)) = Convert.ToString(listaids(2, x + 1)) Then
                    codeprin = codeprin + 1
                    compart = listaids(1, x + 1).ToString & "/" & compart
                Else
                    id = listaids(0, x - codeprin)
                    codigo = listaids(1, x - codeprin).ToString
                    cmdcomando = New OleDbCommand("insert into resultados_pcr_temp (id_sample_reception, muestra, Compartidos," & _
                                                                                          "sample_type,pathogen_search,assay,result,ctvalue,rna_responsible,pcr_responsible)values(" & _
                                                                                            id & ",'" & codigo & "','" & compart & "','" & cmbSampleType.Text & "','" & _
                                                                                            cmbPathogenSearch.Text & "','" & cmbAssayType.Text & "','','','" & _
                                                                                            cmbRnaResponsible.Text & "','" & cmbResponsiblePCR.Text & "')", bd)
                    cmdcomando.ExecuteNonQuery()
                    codeprin = 0
                    compart = ""
                End If
            ElseIf Convert.ToString(listaids(2, x)) = "0" Then
                id = listaids(0, x)
                codigo = listaids(1, x).ToString
                cmdcomando = New OleDbCommand("insert into resultados_pcr_temp (id_sample_reception, muestra, Compartidos," & _
                                                                      "sample_type,pathogen_search,assay,result,ctvalue,rna_responsible,pcr_responsible)values(" & _
                                                                        id & ",'" & codigo & "','" & compart & "','" & cmbSampleType.Text & "','" & _
                                                                        cmbPathogenSearch.Text & "','" & cmbAssayType.Text & "','','','" & _
                                                                        cmbRnaResponsible.Text & "','" & cmbResponsiblePCR.Text & "')", bd)
                cmdcomando.ExecuteNonQuery()
            End If
        Next

        'poniendo de filas a columnas

        'For index = 0 To idscompartidos.Count - 1

        '    While reader.Read
        '        'x = x + 1
        '        'If x = 1 Then
        '        '    id = reader.Item(0)
        '        '    codigo = reader.Item(1).ToString
        '        'Else
        '        '    compart = compart & "/" & reader.Item(1).ToString
        '        'End If


        '    End While
        'Next

        'llenando grid
        'Dim adapter As New OleDbDataAdapter("select sample_reception.id as ID," & _
        '                                    "sample_reception.code as Sample_Code," & _
        '                                    "sample_reception.code_ins as Reference_Code,'" & _
        '                                    cmbSampleType.Text & "' as Sample_Type ,'" & _
        '                                    cmbPathogenSearch.Text & "' as Pathogen_Search,'" & _
        '                                    cmbAssayType.Text & "' as Assay," & _
        '                                    "'' as Results, '' as CTValue, '" & cmbRnaResponsible.Text & _
        '                                    "' as RNA_Responsible,'" & cmbResponsiblePCR.Text & _
        '                                    "' as PCR_Responsible, sample_reception.fecha as Lab_Reception_Date " &
        '                                    "from sample_reception where (sample_reception.sample_number='AGUDO') and " &
        '                                    "(sample_reception.sangre='si' or sample_reception.suero='si' or " & _
        '                                    "sample_reception.plasma='si') and (sample_reception.id >" & idsr & _
        '                                    ") order by sample_reception.code asc", bd)
        'Dim dataSet As New DataSet
        'adapter.Fill(dataSet, "tablita")
        'DataGridView1.DataSource = dataSet.Tables(0)
        'DataGridView1.Refresh()

        ''''''''''''''''''''''''''''''''''''''
        'llenando grid
        Dim adapter As New OleDbDataAdapter("select * from resultados_pcr_temp ", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "tablita")
        DataGridView1.DataSource = dataSet.Tables(0)
        DataGridView1.Refresh()

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AutoResizeColumns()
        Label6.Text = DataGridView1.RowCount - 1

        cmdcomando = New OleDbCommand("delete from resultados_pcr_temp'", bd)
        cmdcomando.ExecuteNonQuery()
    End Sub
    Private Sub frmRespcrDengue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 20
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DTPicker1.Value = Today
        cmbAssayType.Items.Clear()
        cmbSampleType.Items.Clear()

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

        cmbAssayType.Text = "TAQMAN"
        cmbSampleType.Text = "SERUM"
        cmbPathogenSearch.Text = "DENV"

        'llenando combos de usuario
        cmdcomando = New OleDbCommand("Select username from usuarios", bd)
        Dim reader As OleDbDataReader
        reader = cmdcomando.ExecuteReader
        Do While reader.Read
            cmbRnaResponsible.Items.Add(reader.Item(0))
            cmbResponsiblePCR.Items.Add(reader.Item(0))
        Loop
        reader.Close()
        cmbRnaResponsible.Text = usu
        cmbResponsiblePCR.Text = usu
    End Sub
End Class