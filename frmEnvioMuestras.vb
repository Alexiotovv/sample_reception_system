Imports System.Data.OleDb
Public Class frmEnvioMuestras
    Dim cmdcomando As New OleDbCommand
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        DTPicker1.Value = DateAndTime.Today
        RadioButton1.Checked = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.BackgroundColor = Color.LightYellow
        DataGridView2.BackgroundColor = Color.LightYellow
        DataGridView3.BackgroundColor = Color.LightYellow
        DataGridView4.BackgroundColor = Color.LightYellow
        DataGridView5.BackgroundColor = Color.LightYellow
        DataGridView6.BackgroundColor = Color.LightYellow
        DataGridView7.BackgroundColor = Color.LightYellow
        If RadioButton1.Checked Then
            Label4.Text = "(1)HISOPADO"
            DataGridView7.Visible = False
        End If
        If Me.RadioButton2.Checked Then
            Label4.Text = "(2)HISOPADO"
            DataGridView7.Visible = True
        End If
        Dim adapter As New OleDbDataAdapter("select code,env_sangre from sample_reception where sangre='si' and env_sangre is null", bd)
        Dim adapter2 As New OleDbDataAdapter("select code,env_suero from sample_reception where suero='si' and env_suero is null", bd)
        Dim adapter3 As New OleDbDataAdapter("select code,env_hisopado from sample_reception where hisopado='si' and env_hisopado is null", bd)
        Dim adapter4 As New OleDbDataAdapter("select code,env_orina from sample_reception where orina='si' and env_orina is null", bd)
        Dim adapter5 As New OleDbDataAdapter("select code,env_lcr from sample_reception where lcr='si' and env_lcr is null", bd)
        Dim adapter6 As New OleDbDataAdapter("select code,env_plasma from sample_reception where plasma='si' and env_plasma is null", bd)
        Dim adapter7 As New OleDbDataAdapter("select code,env_hisopado_a from sample_reception where hisopado='si' and env_hisopado_a is null", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "sangre")
        adapter2.Fill(dataSet, "suero")
        adapter3.Fill(dataSet, "hisopado")
        adapter4.Fill(dataSet, "orina")
        adapter5.Fill(dataSet, "lcr")
        adapter6.Fill(dataSet, "plasma")
        adapter7.Fill(dataSet, "hisopado_a")
        DataGridView1.DataSource = dataSet.Tables.Item(0) ' SANGRE-buscar codigo en el code2,code3,code4,code5, where sangre='si' and env_sangre is null

        DataGridView2.DataSource = dataSet.Tables.Item(1) 'SUERO-
        DataGridView3.DataSource = dataSet.Tables.Item(2) 'HISOPADO
        DataGridView4.DataSource = dataSet.Tables.Item(3) 'ORINA
        DataGridView5.DataSource = dataSet.Tables.Item(4) 'LCR
        DataGridView6.DataSource = dataSet.Tables.Item(5) 'PLASMA
        DataGridView7.DataSource = dataSet.Tables.Item(6) 'HISOPADO CON ANTIBIOTICO

        If (DataGridView1.RowCount > 0) Then
            DataGridView1.Columns.Item(0).Width = 70
            DataGridView1.Columns.Item(1).Width = 40
        End If
        If (DataGridView2.RowCount > 0) Then
            DataGridView2.Columns.Item(0).Width = 70
            DataGridView2.Columns.Item(1).Width = 40
        End If
        If (DataGridView3.RowCount > 0) Then
            DataGridView3.Columns.Item(0).Width = 70
            DataGridView3.Columns.Item(1).Width = 40
        End If
        If (DataGridView4.RowCount > 0) Then
            DataGridView4.Columns.Item(0).Width = 70
            DataGridView4.Columns.Item(1).Width = 40
        End If
        If (DataGridView5.RowCount > 0) Then
            DataGridView5.Columns.Item(0).Width = 70
            DataGridView5.Columns.Item(1).Width = 40
        End If
        If (DataGridView6.RowCount > 0) Then
            DataGridView6.Columns.Item(0).Width = 70
            DataGridView6.Columns.Item(1).Width = 40
        End If
        If (DataGridView7.RowCount > 0) Then
            DataGridView7.Columns.Item(0).Width = 70
            DataGridView7.Columns.Item(1).Width = 40
        End If
    End Sub
    Private Sub TextBox1_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim num2 As Integer = DataGridView1.RowCount - 2
            Dim i As Integer = 0
            Do While (i <= num2)
                If (DataGridView1.Item(0, i).Value = TextBox1.Text) And IsDBNull(DataGridView1.Item(1, i).Value) Then
                    DataGridView1.Item(1, i).Value = "si"
                    cmdcomando = New OleDbCommand("update sample_reception set  env_sangre ='si' where code = '" & TextBox1.Text & "'", bd)
                    cmdcomando.ExecuteNonQuery()
                    cmdcomando = New OleDbCommand("insert into sangre (code,fecha) values ('" & TextBox1.Text & "','" & DTPicker1.Value & "')", bd)
                    cmdcomando.ExecuteNonQuery()
                    TextBox1.Clear()
                    TextBox1.Focus()
                    DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DataGridView1.CurrentCell = DataGridView1.Item(0, i)
                    Exit Sub
                End If
                If (DataGridView1.Item(0, i).Value = TextBox1.Text) And (DataGridView1.Item(1, i).Value.ToString = "si") Then
                    DataGridView1.CurrentCell = DataGridView1.Item(0, i)
                    MsgBox("The code is cheked", vbCritical, "Cheked")
                    Exit Sub
                End If
                i += 1
            Loop
            MsgBox("Code is not in database", vbCritical, "Cheked")
            TextBox1.Clear()
            TextBox1.Focus()
        End If

    End Sub
    Private Sub TextBox2_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim num2 As Integer = (Me.DataGridView2.RowCount - 2)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (DataGridView2.Item(0, i).Value = TextBox2.Text) And IsDBNull(DataGridView2.Item(1, i).Value) Then
                    DataGridView2.Item(1, i).Value = "si"
                    cmdcomando = New OleDbCommand("update sample_reception set  env_suero ='si' where code = '" & TextBox2.Text & "'", bd)
                    cmdcomando.ExecuteNonQuery()
                    cmdcomando = New OleDbCommand("insert into suero (code,fecha) values ('" & TextBox2.Text & "','" & DTPicker1.Value & "')", bd)
                    cmdcomando.ExecuteNonQuery()
                    TextBox2.Clear()
                    TextBox2.Focus()
                    DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DataGridView2.CurrentCell = Me.DataGridView2.Item(0, i)
                    Exit Sub
                End If
                If (DataGridView2.Item(0, i).Value = TextBox2.Text) And (DataGridView2.Item(1, i).Value.ToString = "si") Then
                    DataGridView2.CurrentCell = Me.DataGridView2.Item(0, i)
                    MsgBox("The code is cheked", vbCritical, "Cheked")
                    Return
                End If
                i += 1
            Loop
            MsgBox("Code is not in database", vbCritical, "Cheked")
            TextBox2.Clear()
            TextBox2.Focus()
        End If

    End Sub

    Private Sub TextBox3_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        TextBox3.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Strings.Asc(e.KeyChar) = 13) Then
            Dim num As Integer
            If Me.RadioButton1.Checked Then
                Dim num2 As Integer = (Me.DataGridView3.RowCount - 2)
                num = 0
                Do While (num <= num2)
                    If (DataGridView3.Item(0, num).Value = TextBox3.Text) And IsDBNull(DataGridView3.Item(1, num).Value) Then
                        DataGridView3.Item(1, num).Value = "si"
                        cmdcomando = New OleDbCommand(("update sample_reception set  env_hisopado ='si' where code = '" & Me.TextBox3.Text & "'"), bd)
                        cmdcomando.ExecuteNonQuery()
                        cmdcomando = New OleDbCommand("insert into hisopado (code,fecha) values ('" & TextBox3.Text & "','" & DTPicker1.Value & "')", bd)
                        cmdcomando.ExecuteNonQuery()
                        TextBox3.Clear()
                        TextBox3.Focus()
                        DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        DataGridView3.CurrentCell = Me.DataGridView3.Item(0, num)
                        Exit Sub
                    End If
                    If (DataGridView3.Item(0, num).Value = TextBox3.Text) And (DataGridView3.Item(1, num).Value.ToString = "si") Then
                        DataGridView3.CurrentCell = DataGridView3.Item(0, num)
                        MsgBox("The code is cheked", vbCritical, "Cheked")
                        Return
                    End If
                    num += 1
                Loop
                Interaction.MsgBox("Code is not in database", MsgBoxStyle.Critical, "Cheked")
            End If
            If RadioButton2.Checked Then
                Dim num3 As Integer = (Me.DataGridView7.RowCount - 2)
                num = 0
                Do While (num <= num3)
                    If (DataGridView7.Item(0, num).Value = TextBox3.Text) And IsDBNull(DataGridView7.Item(1, num).Value) Then
                        DataGridView7.Item(1, num).Value = "si"
                        cmdcomando = New OleDbCommand(("update sample_reception set  env_hisopado_a ='si' where code = '" & Me.TextBox3.Text & "'"), bd)
                        cmdcomando.ExecuteNonQuery()
                        cmdcomando = New OleDbCommand("insert into hisopado_a (code,fecha) values ('" & TextBox3.Text & "','" & DTPicker1.Value & "')", bd)
                        cmdcomando.ExecuteNonQuery()
                        TextBox3.Clear()
                        TextBox3.Focus()
                        DataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        DataGridView7.CurrentCell = DataGridView7.Item(0, num)
                        Exit Sub
                    End If
                    If (DataGridView7.Item(0, num).Value = TextBox3.Text) And (DataGridView7.Item(1, num).Value.ToString = "si") Then
                        DataGridView7.CurrentCell = DataGridView7.Item(0, num)
                        MsgBox("The code is cheked", vbCritical, "Cheked")
                        Exit Sub
                    End If
                    num += 1
                Loop
                MsgBox("Code is not in database", vbCritical, "Cheked")
            End If
            TextBox3.Clear()
            TextBox3.Focus()
        End If

    End Sub

    Private Sub TextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.GotFocus
        TextBox4.BackColor = Color.Yellow
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Strings.Asc(e.KeyChar) = 13) Then
            Dim num2 As Integer = (Me.DataGridView4.RowCount - 2)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (DataGridView4.Item(0, i).Value = TextBox4.Text) And IsDBNull(DataGridView4.Item(1, i).Value) Then
                    DataGridView4.Item(1, i).Value = "si"
                    cmdcomando = New OleDbCommand("update sample_reception set  env_orina ='si' where code = '" & Me.TextBox4.Text & "'", bd)
                    cmdcomando.ExecuteNonQuery()
                    cmdcomando = New OleDbCommand("insert into orina (code,fecha) values ('" & TextBox4.Text & "','" & DTPicker1.Value & "')", bd)
                    cmdcomando.ExecuteNonQuery()
                    TextBox4.Clear()
                    TextBox4.Focus()
                    DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DataGridView4.CurrentCell = Me.DataGridView4.Item(0, i)
                    Exit Sub
                End If
                If (DataGridView4.Item(0, i).Value = TextBox4.Text) And (DataGridView4.Item(1, i).Value.ToString = "si") Then
                    DataGridView4.CurrentCell = DataGridView4.Item(0, i)
                    MsgBox("The code is cheked", vbCritical, "Cheked")
                    Exit Sub
                End If
                i += 1
            Loop
            MsgBox("Code is not in database", vbCritical, "Cheked")
            TextBox4.Clear()
            TextBox4.Focus()
        End If

    End Sub
    Private Sub TextBox5_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.GotFocus
        TextBox5.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Strings.Asc(e.KeyChar) = 13) Then
            Dim num2 As Integer = (Me.DataGridView5.RowCount - 2)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (DataGridView5.Item(0, i).Value = TextBox5.Text) And IsDBNull(DataGridView5.Item(1, i).Value) Then
                    DataGridView5.Item(1, i).Value = "si"
                    cmdcomando = New OleDbCommand(("update sample_reception set  env_lcr ='si' where code = '" & TextBox5.Text & "'"), Module1.bd)
                    cmdcomando.ExecuteNonQuery()
                    cmdcomando = New OleDbCommand("insert into lcr (code,fecha) values ('" & TextBox5.Text & "','" & DTPicker1.Value & "')", bd)
                    cmdcomando.ExecuteNonQuery()
                    TextBox5.Clear()
                    TextBox5.Focus()
                    DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DataGridView5.CurrentCell = DataGridView5.Item(0, i)
                    Exit Sub
                End If
                If (DataGridView5.Item(0, i).Value = TextBox5.Text) And (DataGridView5.Item(1, i).Value.ToString = "si") Then
                    DataGridView5.CurrentCell = DataGridView5.Item(0, i)
                    MsgBox("The code is cheked", vbCritical, "Cheked")
                    Exit Sub
                End If
                i += 1
            Loop
            MsgBox("Code is not in database", vbCritical, "Cheked")
            TextBox5.Clear()
            TextBox5.Focus()
        End If

    End Sub
    Private Sub TextBox6_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.GotFocus
        TextBox6.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If (Strings.Asc(e.KeyChar) = 13) Then
            Dim num2 As Integer = (Me.DataGridView6.RowCount - 2)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (DataGridView6.Item(0, i).Value = TextBox6.Text) And IsDBNull(DataGridView6.Item(1, i).Value) Then
                    DataGridView6.Item(1, i).Value = "si"
                    cmdcomando = New OleDbCommand("update sample_reception set  env_plasma ='si' where code = '" & TextBox6.Text & "'", bd)
                    cmdcomando.ExecuteNonQuery()
                    cmdcomando = New OleDbCommand("insert into plasma (code,fecha) values ('" & TextBox6.Text & "','" & DTPicker1.Value & "')", bd)
                    cmdcomando.ExecuteNonQuery()
                    TextBox6.Clear()
                    TextBox6.Focus()
                    DataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DataGridView6.CurrentCell = DataGridView6.Item(0, i)
                    Exit Sub
                End If
                If (DataGridView6.Item(0, i).Value = TextBox6.Text) And (DataGridView6.Item(1, i).Value.ToString = "si") Then
                    DataGridView6.CurrentCell = DataGridView6.Item(0, i)
                    MsgBox("The code is cheked", vbCritical, "Cheked")
                    Exit Sub
                End If
                i += 1
            Loop
            MsgBox("Code is not in database", vbCritical, "Cheked")
            TextBox6.Clear()
            TextBox6.Focus()
        End If
    End Sub

    Private Sub RadioButton1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True Then
            DataGridView7.Visible = False
            Label4.Text = "(1)HISOPADO"
        End If
    End Sub

    Private Sub RadioButton2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True Then
            DataGridView7.Visible = True
            Label4.Text = "(2)HISOPADO"
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.BackColor = Color.White
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.BackColor = Color.White
    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus
        TextBox4.BackColor = Color.White
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        TextBox5.BackColor = Color.White
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        TextBox6.BackColor = Color.White
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class