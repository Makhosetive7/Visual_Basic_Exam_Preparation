<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Credits:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Instructor:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(167, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(380, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(167, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(380, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(167, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(380, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(167, 122)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(380, 20)
        Me.TextBox4.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(167, 185)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(380, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(596, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 129)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Populate ComboBox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Combobox:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(259, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
