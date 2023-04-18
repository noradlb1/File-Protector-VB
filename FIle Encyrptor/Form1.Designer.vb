Namespace FIle_Encyrptor
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.button3 = New System.Windows.Forms.Button()
			Me.label2 = New System.Windows.Forms.Label()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.button2 = New System.Windows.Forms.Button()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label14 = New System.Windows.Forms.Label()
			Me.label15 = New System.Windows.Forms.Label()
			Me.label16 = New System.Windows.Forms.Label()
			Me.label17 = New System.Windows.Forms.Label()
			Me.label18 = New System.Windows.Forms.Label()
			Me.label19 = New System.Windows.Forms.Label()
			Me.label20 = New System.Windows.Forms.Label()
			Me.button4 = New System.Windows.Forms.Button()
			Me.label21 = New System.Windows.Forms.Label()
			Me.textBox3 = New System.Windows.Forms.TextBox()
			Me.label22 = New System.Windows.Forms.Label()
			Me.button6 = New System.Windows.Forms.Button()
			Me.textBox4 = New System.Windows.Forms.TextBox()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label11)
			Me.groupBox1.Controls.Add(Me.label10)
			Me.groupBox1.Controls.Add(Me.label9)
			Me.groupBox1.Controls.Add(Me.label8)
			Me.groupBox1.Controls.Add(Me.label7)
			Me.groupBox1.Controls.Add(Me.label6)
			Me.groupBox1.Controls.Add(Me.label5)
			Me.groupBox1.Controls.Add(Me.label4)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.button3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.checkBox1)
			Me.groupBox1.Controls.Add(Me.button2)
			Me.groupBox1.Controls.Add(Me.textBox2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.button1)
			Me.groupBox1.Controls.Add(Me.textBox1)
			Me.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
			Me.groupBox1.Location = New System.Drawing.Point(12, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(363, 386)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Encrypt File"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(14, 329)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(49, 13)
			Me.label11.TabIndex = 19
			Me.label11.Text = "File Size:"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(96, 329)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(19, 13)
			Me.label10.TabIndex = 18
			Me.label10.Text = "na"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(106, 98)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(154, 13)
			Me.label9.TabIndex = 17
			Me.label9.Text = "AES only more coming soon....."
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(14, 241)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(60, 13)
			Me.label8.TabIndex = 16
			Me.label8.Text = "File Name: "
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(96, 298)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(19, 13)
			Me.label7.TabIndex = 15
			Me.label7.Text = "na"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(12, 298)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(78, 13)
			Me.label6.TabIndex = 14
			Me.label6.Text = "File Extension: "
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(96, 269)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(19, 13)
			Me.label5.TabIndex = 13
			Me.label5.Text = "na"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(14, 269)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(54, 13)
			Me.label4.TabIndex = 12
			Me.label4.Text = "File Path: "
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(96, 241)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(19, 13)
			Me.label3.TabIndex = 11
			Me.label3.Text = "na"
			' 
			' button3
			' 
			Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
			Me.button3.Location = New System.Drawing.Point(239, 357)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(118, 23)
			Me.button3.TabIndex = 10
			Me.button3.Text = "Encrypt"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(129, 139)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(78, 13)
			Me.label2.TabIndex = 9
			Me.label2.Text = "Encryption Key"
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New System.Drawing.Point(6, 363)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(125, 17)
			Me.checkBox1.TabIndex = 8
			Me.checkBox1.Text = "Generate Strong Key"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' button2
			' 
			Me.button2.Enabled = False
			Me.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
			Me.button2.Location = New System.Drawing.Point(99, 202)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(134, 23)
			Me.button2.TabIndex = 7
			Me.button2.Text = "Generate"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(59, 166)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(228, 20)
			Me.textBox2.TabIndex = 6
			Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.textBox2.TextChanged += New System.EventHandler(Me.textBox2_TextChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(129, 61)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(96, 13)
			Me.label1.TabIndex = 5
			Me.label1.Text = "Encryption Method"
			' 
			' button1
			' 
			Me.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
			Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.button1.Location = New System.Drawing.Point(282, 19)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Browse"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(6, 19)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(271, 20)
			Me.textBox1.TabIndex = 0
			' 
			' groupBox2
			' 
			Me.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.groupBox2.Controls.Add(Me.label12)
			Me.groupBox2.Controls.Add(Me.label13)
			Me.groupBox2.Controls.Add(Me.label14)
			Me.groupBox2.Controls.Add(Me.label15)
			Me.groupBox2.Controls.Add(Me.label16)
			Me.groupBox2.Controls.Add(Me.label17)
			Me.groupBox2.Controls.Add(Me.label18)
			Me.groupBox2.Controls.Add(Me.label19)
			Me.groupBox2.Controls.Add(Me.label20)
			Me.groupBox2.Controls.Add(Me.button4)
			Me.groupBox2.Controls.Add(Me.label21)
			Me.groupBox2.Controls.Add(Me.textBox3)
			Me.groupBox2.Controls.Add(Me.label22)
			Me.groupBox2.Controls.Add(Me.button6)
			Me.groupBox2.Controls.Add(Me.textBox4)
			Me.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
			Me.groupBox2.Location = New System.Drawing.Point(383, 12)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(363, 386)
			Me.groupBox2.TabIndex = 1
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Decrypt File"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(14, 329)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(49, 13)
			Me.label12.TabIndex = 19
			Me.label12.Text = "File Size:"
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Location = New System.Drawing.Point(96, 329)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(19, 13)
			Me.label13.TabIndex = 18
			Me.label13.Text = "na"
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Location = New System.Drawing.Point(107, 98)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(154, 13)
			Me.label14.TabIndex = 17
			Me.label14.Text = "AES only more coming soon....."
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.Location = New System.Drawing.Point(14, 241)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(60, 13)
			Me.label15.TabIndex = 16
			Me.label15.Text = "File Name: "
			' 
			' label16
			' 
			Me.label16.AutoSize = True
			Me.label16.Location = New System.Drawing.Point(96, 298)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(19, 13)
			Me.label16.TabIndex = 15
			Me.label16.Text = "na"
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.Location = New System.Drawing.Point(12, 298)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(78, 13)
			Me.label17.TabIndex = 14
			Me.label17.Text = "File Extension: "
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.Location = New System.Drawing.Point(96, 269)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(19, 13)
			Me.label18.TabIndex = 13
			Me.label18.Text = "na"
			' 
			' label19
			' 
			Me.label19.AutoSize = True
			Me.label19.Location = New System.Drawing.Point(14, 269)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(54, 13)
			Me.label19.TabIndex = 12
			Me.label19.Text = "File Path: "
			' 
			' label20
			' 
			Me.label20.AutoSize = True
			Me.label20.Location = New System.Drawing.Point(96, 241)
			Me.label20.Name = "label20"
			Me.label20.Size = New System.Drawing.Size(19, 13)
			Me.label20.TabIndex = 11
			Me.label20.Text = "na"
			' 
			' button4
			' 
			Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
			Me.button4.Location = New System.Drawing.Point(239, 357)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(118, 23)
			Me.button4.TabIndex = 10
			Me.button4.Text = "Decrypt"
			Me.button4.UseVisualStyleBackColor = True
'			Me.button4.Click += New System.EventHandler(Me.button4_Click)
			' 
			' label21
			' 
			Me.label21.AutoSize = True
			Me.label21.Location = New System.Drawing.Point(129, 139)
			Me.label21.Name = "label21"
			Me.label21.Size = New System.Drawing.Size(79, 13)
			Me.label21.TabIndex = 9
			Me.label21.Text = "Decryption Key"
			' 
			' textBox3
			' 
			Me.textBox3.Location = New System.Drawing.Point(58, 166)
			Me.textBox3.Name = "textBox3"
			Me.textBox3.Size = New System.Drawing.Size(228, 20)
			Me.textBox3.TabIndex = 6
			Me.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.textBox3.TextChanged += New System.EventHandler(Me.textBox3_TextChanged)
			' 
			' label22
			' 
			Me.label22.AutoSize = True
			Me.label22.Location = New System.Drawing.Point(129, 61)
			Me.label22.Name = "label22"
			Me.label22.Size = New System.Drawing.Size(97, 13)
			Me.label22.TabIndex = 5
			Me.label22.Text = "Decryption Method"
			' 
			' button6
			' 
			Me.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
			Me.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.button6.Location = New System.Drawing.Point(282, 19)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(75, 23)
			Me.button6.TabIndex = 1
			Me.button6.Text = "Browse"
			Me.button6.UseVisualStyleBackColor = True
'			Me.button6.Click += New System.EventHandler(Me.button6_Click)
			' 
			' textBox4
			' 
			Me.textBox4.Location = New System.Drawing.Point(6, 19)
			Me.textBox4.Name = "textBox4"
			Me.textBox4.Size = New System.Drawing.Size(271, 20)
			Me.textBox4.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(44)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.ClientSize = New System.Drawing.Size(756, 411)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.Text = "OTG File Protector"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents textBox2 As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents button3 As System.Windows.Forms.Button
		Private label8 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private label16 As System.Windows.Forms.Label
		Private label17 As System.Windows.Forms.Label
		Private label18 As System.Windows.Forms.Label
		Private label19 As System.Windows.Forms.Label
		Private label20 As System.Windows.Forms.Label
		Private WithEvents button4 As System.Windows.Forms.Button
		Private label21 As System.Windows.Forms.Label
		Private WithEvents textBox3 As System.Windows.Forms.TextBox
		Private label22 As System.Windows.Forms.Label
		Private WithEvents button6 As System.Windows.Forms.Button
		Private textBox4 As System.Windows.Forms.TextBox
	End Class
End Namespace

