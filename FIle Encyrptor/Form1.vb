Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Web
Imports System.IO

Namespace FIle_Encyrptor
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			If checkBox1.Checked Then
				button2.Enabled = True
			Else
				button2.Enabled = False
			End If
		End Sub

		Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox2.TextChanged

		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			textBox2.Clear()
			textBox2.Text = System.Web.Security.Membership.GeneratePassword(30, 8)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Try
				textBox1.Clear()
				Dim openFileDialog As New OpenFileDialog()
				If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Dim FilePath As String = openFileDialog.FileName
					textBox1.Text = FilePath

					Dim FileName As String = openFileDialog.SafeFileName
					Dim FileExt As String = Path.GetExtension(FilePath)
					Dim FileSize = (New FileInfo(FilePath)).Length

					label3.Text = FileName
					label5.Text = FilePath
					label7.Text = FileExt
					label10.Text = FileSize.ToString() & " Bytes"

				Else
					MessageBox.Show("File corrupted or missing!")
				End If
			Catch s As Exception
				MessageBox.Show(s.ToString())
			End Try
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			If textBox2.Text <> String.Empty Then
				Try
					Dim data() As Byte = File.ReadAllBytes(textBox1.Text)
					Dim pw() As Byte = Encoding.UTF8.GetBytes(textBox2.Text)

					If MessageBox.Show("BACKUP YOUR PASSWORD!", "READ THIS!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.OK Then
						Dim encrypted() As Byte = Aes.Encrypt(data, pw)
						File.WriteAllBytes(textBox1.Text, encrypted)
						MessageBox.Show("File Encrypted!")
					End If
				Catch s As Exception
					MessageBox.Show(s.ToString())
				End Try
			End If
		End Sub

		Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button6.Click
			Try
				textBox4.Clear()
				Dim openFileDialog As New OpenFileDialog()
				If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Dim FilePath As String = openFileDialog.FileName
					textBox4.Text = FilePath

					Dim FileName As String = openFileDialog.SafeFileName
					Dim FileExt As String = Path.GetExtension(FilePath)
					Dim FileSize = (New FileInfo(FilePath)).Length

					label20.Text = FileName
					label18.Text = FilePath
					label16.Text = FileExt
					label13.Text = FileSize.ToString() & " Bytes"

				Else
					MessageBox.Show("File corrupted or missing!")
				End If
			Catch s As Exception
				MessageBox.Show(s.ToString())
			End Try
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			If textBox3.Text <> String.Empty Then
				Try
					Dim data11() As Byte = File.ReadAllBytes(textBox4.Text)
					Dim pw11() As Byte = Encoding.UTF8.GetBytes(textBox3.Text)

					If MessageBox.Show("MAKE SURE THE PASSWORD IS CORRECT OR THE FILE WIL BE CORRUPTED!", "READ THIS!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.OK Then
						Dim Decrypted() As Byte = Aes.Decrypt(data11, pw11)
						File.WriteAllBytes(textBox4.Text, Decrypted)
						MessageBox.Show("File Decrypted!")
					End If

				Catch s As Exception
					MessageBox.Show(s.ToString())
				End Try
			End If
		End Sub

		Private Sub textBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox3.TextChanged

		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace

