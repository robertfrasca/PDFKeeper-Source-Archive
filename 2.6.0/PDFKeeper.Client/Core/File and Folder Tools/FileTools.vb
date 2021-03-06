﻿'*************************************************************************
'*
'* PDFKeeper -- PDF Document Storage for Small or Home Office
'* Copyright (C) 2009-2012 Robert F. Frasca
'*
'* This program is free software: you can redistribute it and/or modify
'* it under the terms of the GNU General Public License as published by
'* the Free Software Foundation, either version 3 of the License, or
'* (at your option) any later version.
'*
'* This program is distributed in the hope that it will be useful, but
'* WITHOUT ANY WARRANTY; without even the implied warranty of
'* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'* GNU General Public License for more details.
'*
'* You should have received a copy of the GNU General Public License
'* along with this program.  If not, see <http://www.gnu.org/licenses/>.
'*
'*************************************************************************

Public Class FileTools
	Dim file As String
	
	''' <summary>
	''' This subroutine is the class constructor.
	''' </summary>
	''' <param name="arg: file"></param>
	Public Sub New(ByVal arg As String)
		file = arg
	End Sub
	
	''' <summary>
	''' This function will compute the hash code of the file object and return
	''' it to the caller as a string value.
	''' </summary>
	''' <returns></returns>
	Public Function CalcHashCode As String
		Dim oHashAlgorithm As HashAlgorithm = HashAlgorithm.Create("SHA1")
		Using oFileStream As New FileStream(file, FileMode.Open, _
												  FileAccess.Read)
			Dim hash As Byte() = oHashAlgorithm.ComputeHash(oFileStream)
			Return BitConverter.ToString(hash)
		End Using
	End Function
	
	''' <summary>
	''' This subroutine will encrypt the file object if the operating system
	''' supports the Encrypting File System (EFS).
	''' </summary>
	Public Sub EncryptFile
		Try
			IO.File.Encrypt(file)
		Catch ex As IOException
		End Try
	End Sub
	
	''' <summary>
	''' This function will return True or False if the file object is in use.
	''' </summary>
	''' <returns>True or False</returns>
	Public Function IsInUse As Boolean
		Dim inUse As Boolean = False
		If IO.File.Exists(file) Then
			Try
				Using oFileStream As New FileStream(file, FileMode.Open, _
								  		 FileAccess.ReadWrite, FileShare.None)
				End Using
			Catch ex As IOException
				inUse = True
			Catch ex As UnauthorizedAccessException
				inUse = True
			End Try
		End If
		Return inUse
	End Function
	
	''' <summary>
	''' This function will delete the file object.
	''' </summary>
	''' <returns>0 = Successful, 1 = Failed</returns>
	Function Delete As Integer
		Try
			IO.File.Delete(file)
			Return 0
		Catch ex As IOException
			Dim oMessageDialog As New MessageDialog(ex.Message)
			oMessageDialog.DisplayError
			Return 1
		End Try
	End Function
End Class
