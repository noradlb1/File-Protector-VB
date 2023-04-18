Imports System.Text
Imports System.Threading.Tasks
Imports System.Security.Cryptography
Imports System.IO
Imports System.Threading

Namespace FIle_Encyrptor
	Friend Class Aes
		Public Shared Function Encrypt(ByVal bytesToBeEncrypted() As Byte, ByVal passwordBytes() As Byte) As Byte()
			Dim encryptedBytes() As Byte = Nothing


			Dim saltBytes() As Byte = { 46, 48, 04, 32, 41, 45, 65, 67 }

			Using ms As New MemoryStream()
				Using AES As New RijndaelManaged()
					AES.KeySize = 256
					AES.BlockSize = 128

					Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
					AES.Key = key.GetBytes(AES.KeySize \ 8)
					AES.IV = key.GetBytes(AES.BlockSize \ 8)

					AES.Mode = CipherMode.CBC

					Using cs = New CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write)
						cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length)
						cs.Close()
					End Using
					encryptedBytes = ms.ToArray()
				End Using
			End Using

			Return encryptedBytes
		End Function
		Public Shared Function Decrypt(ByVal btoDec() As Byte, ByVal pss() As Byte) As Byte()
			Dim decByes() As Byte = Nothing


			Dim saltBytes() As Byte = { 46, 48, 04, 32, 41, 45, 65, 67 }

			Using ms As New MemoryStream()
				Using AES As New RijndaelManaged()
					AES.KeySize = 256
					AES.BlockSize = 128

					Dim key = New Rfc2898DeriveBytes(pss, saltBytes, 1000)
					AES.Key = key.GetBytes(AES.KeySize \ 8)
					AES.IV = key.GetBytes(AES.BlockSize \ 8)

					AES.Mode = CipherMode.CBC

					Using csss = New CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write)
						csss.Write(btoDec, 0, btoDec.Length)
						csss.Close()
					End Using
					decByes = ms.ToArray()
				End Using
			End Using

			Return decByes
		End Function
	End Class
End Namespace
