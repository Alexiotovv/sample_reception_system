<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMagicList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbSampleCode = New System.Windows.Forms.RadioButton()
        Me.rbPartCode = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(744, 469)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(602, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Export to excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(89, 26)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(181, 20)
        Me.txtCode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "--"
        '
        'rbSampleCode
        '
        Me.rbSampleCode.AutoSize = True
        Me.rbSampleCode.Location = New System.Drawing.Point(89, 52)
        Me.rbSampleCode.Name = "rbSampleCode"
        Me.rbSampleCode.Size = New System.Drawing.Size(88, 17)
        Me.rbSampleCode.TabIndex = 4
        Me.rbSampleCode.TabStop = True
        Me.rbSampleCode.Text = "Sample Code"
        Me.rbSampleCode.UseVisualStyleBackColor = True
        '
        'rbPartCode
        '
        Me.rbPartCode.AutoSize = True
        Me.rbPartCode.Location = New System.Drawing.Point(185, 52)
        Me.rbPartCode.Name = "rbPartCode"
        Me.rbPartCode.Size = New System.Drawing.Size(72, 17)
        Me.rbPartCode.TabIndex = 5
        Me.rbPartCode.TabStop = True
        Me.rbPartCode.Text = "Part Code"
        Me.rbPartCode.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Find"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 553)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbPartCode)
        Me.Controls.Add(Me.rbSampleCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form12"
        Me.Text = "Magic List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbSampleCode As System.Windows.Forms.RadioButton
    Friend WithEvents rbPartCode As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
