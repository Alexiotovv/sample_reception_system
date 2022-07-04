Imports System.Data.OleDb
Public Class frmLogiin
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adapter As New OleDbDataAdapter("select * from usuarios", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "usu")
        DataGridView1.DataSource = dataSet.Tables(0)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        graba()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Strings.Asc(e.KeyChar) = 13) Then
            TextBox2.Focus()
        End If

    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Strings.Asc(e.KeyChar) = 13) Then
            TextBox3.Focus()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub graba()
        Dim cmdcommand As OleDbCommand
        Dim i As Integer = 0
        Dim num2 As Integer
        num2 = DataGridView1.RowCount - 2
        Dim str3 As String
        Dim str2 As String
        Do While (i <= num2)
            str3 = DataGridView1.Rows.Item(i).Cells.Item(1).Value
            str2 = DataGridView1.Rows.Item(i).Cells.Item(2).Value
            Dim text As String = TextBox3.Text
            If ((str3 = TextBox1.Text) And (str2 = TextBox2.Text)) Then
                cmdcommand = New OleDbCommand("update usuarios set pas='" & text & "' where username='" & str3 & "'", bd)
                cmdcommand.ExecuteNonQuery()
                MsgBox("The password change was successful", vbInformation, Nothing)
                Exit Sub
            End If
            i += 1
        Loop
        MsgBox("User or Password incorrect", MsgBoxStyle.Critical, "User")
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            graba()
        End If
    End Sub
End Class