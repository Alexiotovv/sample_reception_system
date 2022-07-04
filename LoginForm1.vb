Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Dim str As String = (Application.StartupPath & "\bdstafvir.mdb")
        bd.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & str & ";")
        bd.Open()
        llenagrid()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        entra()
    End Sub
    Public Sub entra()
      Dim str As String = ""
        Dim num2 As Integer = (DataGridView1.RowCount - 2)
        Dim i As Integer = 0
        Do While (i <= num2)
            str = DataGridView1.Rows.Item(i).Cells.Item(2).Value
            If (DataGridView1.Rows.Item(i).Cells.Item(1).Value = TextBox1.Text) And (str = TextBox2.Text) Then
                usu = DataGridView1.Rows.Item(i).Cells.Item(1).Value
                TextBox2.Text = ""
                TextBox1.Text = ""
                Me.Visible = False
                MDIParent1.Show()
                MDIParent1.StatusStrip.Items.Clear()
                MDIParent1.StatusStrip.Items.Add(("User: " & Module1.usu & " /"))
                MDIParent1.StatusStrip.Items.Add(("Date: " & DateAndTime.DateString))
                Return
            End If
            i += 1
        Loop
        MsgBox("User or Password incorrect", MsgBoxStyle.Critical, "User")
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            entra()
        End If
    End Sub
    Public Sub llenagrid()
        Dim adapter As New OleDbDataAdapter("select * from usuarios", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "usuarios")
        DataGridView1.DataSource = dataSet.Tables(0)
    End Sub
End Class
