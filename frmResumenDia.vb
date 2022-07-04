Imports System.Data.OleDb


Public Class frmResumenDia
    Dim nombrecompletofile As String=""
    Private Sub frmResumenDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpFecha.Value = Today
        MostrarResumen()
    End Sub
    Private Sub MostrarResumen()
        Dim sqlquery As String
        Dim fecha1, fecha2 As Date
        fecha1 = Today.AddDays(-3)
        fecha2 = Today.AddDays(-1)
        sqlquery = "select code as CODIGO,code_ins as CODIGO_INS,code2,code3,sample_number as NUMERO_DE_MUESTRA,fecha as FECHA,sangre as SANGRE,suero as SUERO,hisopado as HISOPADO,orina as ORINA,lcr as LCR,plasma as PLASMA,usuario as USUARIO from sample_reception where fecha  #" & fecha1 & "# and #" & fecha2 & "#"
        Dim adapter As New OleDbDataAdapter(sqlquery, bd)
        Dim ds As New DataSet
        adapter.Fill(ds, "Filtro")
        DgvResumen.DataSource = ds.Tables(0)
        DgvResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvResumen.AutoResizeColumns()
    End Sub

    Private Sub DtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles DtpFecha.ValueChanged
        MostrarResumen()
    End Sub

    Private Sub frmResumenDia_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DgvResumen.Width = Me.Width - 35
        DgvResumen.Height = Me.Height - 100
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            ''Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add
            ''¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DgvResumen.ColumnCount
            Dim NRow As Integer = DgvResumen.RowCount
            ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DgvResumen.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DgvResumen.Rows(Fila).Cells(Col).Value
                Next
            Next
            ''Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            ''Aplicación visible
            'exApp.Application.Visible = True
            Dim fecha As String = DateAndTime.Year(DtpFecha.Value) & "-" & DateAndTime.Month(DtpFecha.Value) & "-" & DateAndTime.Day(DtpFecha.Value) & "-" & DateAndTime.Hour(Now) & "." & DateAndTime.Minute(Now)
            nombrecompletofile = "C:\Temp\ResumenDiaHoy" & fecha & ".xlsx"
            exApp.Application.ActiveWorkbook.SaveAs(nombrecompletofile)
            exApp.Quit()
            exLibro = Nothing
            exHoja = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''HASTA AQUI GENERA Y GUARDA EL ARCHIVO DE EXCEL SIN ABRIRLO AHORA VIENE EL CORREO
        EnvioCorreo()
    End Sub
    
    Private Sub EnvioCorreo()
        'Creamos un Objeto que hará referencia a nuestra aplicación Outlook
        Dim m_OutLook As Outlook.Application
        Try
            'Creamos un Objeto tipo Mail
            Dim objMail As Outlook.MailItem
            'Inicializamos nuestra apliación OutLook
            m_OutLook = New Outlook.Application
            'Creamos una instancia de un objeto tipo MailItem
            objMail = m_OutLook.CreateItem(Outlook.OlItemType.olMailItem)
            'Asignamos las propiedades a nuestra Instancial del objeto
            'MailItem
            objMail.To = "Carolina.Guevara@med.navy.mil.com"
            objMail.Subject = "ReportedelDia"
            objMail.Body = "Hola Carolina te envio el reporte del Dia segun acordado. - Luis Acuña (https://takumiproject.wordpress.com)"
            Dim Rta = MsgBox("¿Realmente desea enviar el Mail?", MsgBoxStyle.YesNo)

            'Si queremos enviar un archivo adjunto usamos este codigo…
            Dim sSource As String = nombrecompletofile
            Dim sDisplayName As String = "ReportedelDia"
            Dim sBodyLen As String = objMail.Body.Length
            Dim oAttachs As Outlook.Attachments = objMail.Attachments
            Dim oAttach As Outlook.Attachment
            oAttach = oAttachs.Add(sSource, , sBodyLen + 1, sDisplayName)

            If Rta = 6 Then
                'Enviamos nuestro Mail y listo!
                objMail.Send()
                'Desplegamos un mensaje indicando que todo fue exitoso
                MessageBox.Show("Envío exitoso.", "Enviar Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf Rta = 7 Then
                MessageBox.Show("Envío cancelado", "Enviar Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            'Si se produce algun Error
            MessageBox.Show("Error al enviar mail")
        Finally
            m_OutLook = Nothing ' Destruimos el objeto (recoger la basura…)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarResumen()
    End Sub
End Class