<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Cambria Math", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
		Me.Label1.Location = New System.Drawing.Point(109, -20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(581, 212)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Pharmacy Managment System"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(203, 158)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(364, 34)
		Me.ProgressBar1.TabIndex = 1
		'
		'Panel1
		'
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(0, 340)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(800, 58)
		Me.Panel1.TabIndex = 3
		'
		'Timer1
		'
		'
		'Splash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.SpringGreen
		Me.ClientSize = New System.Drawing.Size(800, 398)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Splash"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Timer1 As Timer
End Class
