<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Cambria Math", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
		Me.Label1.Location = New System.Drawing.Point(168, -33)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(180, 212)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Login"
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.ForeColor = System.Drawing.Color.ForestGreen
		Me.TextBox1.Location = New System.Drawing.Point(83, 182)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(330, 30)
		Me.TextBox1.TabIndex = 2
		Me.TextBox1.Text = "UserName"
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.ForeColor = System.Drawing.Color.ForestGreen
		Me.TextBox2.Location = New System.Drawing.Point(83, 287)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(330, 30)
		Me.TextBox2.TabIndex = 3
		Me.TextBox2.Text = "Password"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.ForestGreen
		Me.Button1.Location = New System.Drawing.Point(83, 405)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(330, 56)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Login"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Cambria Math", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
		Me.Label2.Location = New System.Drawing.Point(202, 464)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(96, 111)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Clear"
		'
		'Login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(508, 616)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Login"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label2 As Label
End Class
