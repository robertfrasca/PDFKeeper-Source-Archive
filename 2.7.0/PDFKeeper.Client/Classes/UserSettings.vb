﻿'******************************************************************************
'*
'* PDFKeeper -- PDF Document Storage for Small or Home Office
'* Copyright (C) 2009-2012 Robert F. Frasca
'*
'* This program is free software: you can redistribute it and/or modify it
'* under the terms of the GNU General Public License as published by the Free
'* Software Foundation, either version 3 of the License, or (at your option)
'* any later version.
'*
'* This program is distributed in the hope that it will be useful, but WITHOUT
'* ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
'* FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for
'* more details.
'*
'* You should have received a copy of the GNU General Public License along
'* with this program.  If not, see <http://www.gnu.org/licenses/>.
'*
'******************************************************************************

Public Class UserSettings
	Dim xmlFile As String = RootDataDir & "\UserSettings.xml"
	Shared m_OpenFileLastFolder As String
	Shared m_SaveFileLastFolder As String
	Shared m_LastUserName As String
	Shared m_LastDataSource As String
	Shared m_FormPositionTop As String
	Shared m_FormPositionLeft As String
	Shared m_FormPositionHeight As String
	Shared m_FormPositionWidth As String
	Shared m_FormPositionWindowState As String
	Shared m_UpdateCheck As String
	Shared m_InfoPropEditWatcherEnabled As String
	Shared m_InfoPropEditWatcherFolder As String
	Shared m_UploadWatcherEnabled As String
	Shared m_UploadWatcherFolder As String
	Shared m_AfterSavingOpenPdfChecked As String
	Shared m_AfterSavingUploadPdfChecked As String
	Shared m_AfterSavingDeletePdfChecked As String
	Shared m_AfterSavingUploadingDeletePdfChecked As String
	Shared m_TitlePreFill As String
	Shared m_AuthorPreFill As String
	Shared m_SubjectPreFill As String
	Shared m_KeywordsPreFill As String
	Shared m_UseExistingTitleChecked As String
	Shared m_UseExistingAuthorChecked As String
	Shared m_UseExistingSubjectChecked As String
	Shared m_UseExistingKeywordsChecked As String
	Shared m_AfterUploadingDeletePdfChecked As String
						
	#Region "Properties"
	
	Shared Property OpenFileLastFolder() As String
		Get
			If m_OpenFileLastFolder = Nothing Then
				m_OpenFileLastFolder = _
						 My.Computer.FileSystem.SpecialDirectories.MyDocuments
			End If
			Return m_OpenFileLastFolder
		End Get
		Set(ByVal Value As String)
			m_OpenFileLastFolder = Value
		End Set
	End Property
	
	Shared Property SaveFileLastFolder() As String
		Get
			If m_SaveFileLastFolder = Nothing Then
				m_SaveFileLastFolder = _
						 My.Computer.FileSystem.SpecialDirectories.MyDocuments
			End If
			Return m_SaveFileLastFolder
		End Get
		Set(ByVal Value As String)
			m_SaveFileLastFolder = Value
		End Set
	End Property
	
	Shared Property LastUserName() As String
		Get
			return m_LastUserName
		End Get
		Set(ByVal Value As String)
			m_LastUserName = Value
		End Set
	End Property
	
	Shared Property LastDataSource() As String
		Get
			Return m_LastDataSource
		End Get
		Set(ByVal Value As String)
			m_LastDataSource = Value
		End Set
	End Property

	Shared Property FormPositionTop() As String
		Get
			If m_FormPositionTop = Nothing Then
				m_FormPositionTop = 10
			End If
			Return m_FormPositionTop
		End Get
		Set(ByVal Value As String)
			m_FormPositionTop = Value
		End Set
	End Property
	
	Shared Property FormPositionLeft() As String
		Get
			If m_FormPositionLeft = Nothing Then
				m_FormPositionLeft = 25
			End If
			Return m_FormPositionLeft
		End Get
		Set(ByVal Value As String)
			m_FormPositionLeft = Value
		End Set
	End Property
	
	Shared Property FormPositionHeight() As String
		Get
			If m_FormPositionHeight = Nothing Then
				m_FormPositionHeight = 710
			End If
			Return m_FormPositionHeight
		End Get
		Set(ByVal Value As String)
			m_FormPositionHeight = Value
		End Set
	End Property
	
	Shared Property FormPositionWidth() As String
		Get
			If m_FormPositionWidth = Nothing Then
				m_FormPositionWidth = 750
			End If
			Return m_FormPositionWidth
		End Get
		Set(ByVal Value As String)
			m_FormPositionWidth = Value
		End Set
	End Property
	
	Shared Property FormPositionWindowState() As String
		Get
			If m_FormPositionWindowState = Nothing Then
				m_FormPositionWindowState = 0
			End If
			Return m_FormPositionWindowState
		End Get
		Set(ByVal Value As String)
			m_FormPositionWindowState = Value
		End Set
	End Property
	
	Shared Property UpdateCheck() As String
		Get
			If m_UpdateCheck = Nothing Then
				m_UpdateCheck = 1
			End If
			Return m_UpdateCheck
		End Get
		Set(ByVal Value As String)
			m_UpdateCheck = Value
		End Set
	End Property
		
	Shared Property InfoPropEditWatcherEnabled() As String
		Get
			If m_InfoPropEditWatcherEnabled = Nothing Then
				m_InfoPropEditWatcherEnabled = 0
			End If
			Return m_InfoPropEditWatcherEnabled
		End Get
		Set(ByVal Value As String)
			m_InfoPropEditWatcherEnabled = Value
		End Set
	End Property
	
	Shared Property InfoPropEditWatcherFolder() As String
		Get
			Return m_InfoPropEditWatcherFolder
		End Get
		Set(ByVal Value As String)
			m_InfoPropEditWatcherFolder = Value
		End Set
	End Property
	
	Shared Property UploadWatcherEnabled() As String
		Get
			If m_UploadWatcherEnabled = Nothing Then
				m_UploadWatcherEnabled = 0
			End If
			Return m_UploadWatcherEnabled
		End Get
		Set(ByVal Value As String)
			m_UploadWatcherEnabled = Value
		End Set
	End Property
	
	Shared Property UploadWatcherFolder() As String
		Get
			Return m_UploadWatcherFolder
		End Get
		Set(ByVal Value As String)
			m_UploadWatcherFolder = Value
		End Set
	End Property
	
	Shared Property AfterSavingOpenPdfChecked() As String
		Get
			If m_AfterSavingOpenPdfChecked = Nothing Then
				m_AfterSavingOpenPdfChecked = 0
			End If
			Return m_AfterSavingOpenPdfChecked
		End Get
		Set(ByVal Value As String)
			m_AfterSavingOpenPdfChecked = Value
		End Set
	End Property
	
	Shared Property AfterSavingUploadPdfChecked() As String
		Get
			If m_AfterSavingUploadPdfChecked = Nothing Then
				m_AfterSavingUploadPdfChecked = 0
			End If
			Return m_AfterSavingUploadPdfChecked
		End Get
		Set(ByVal Value As String)
			m_AfterSavingUploadPdfChecked = Value
		End Set
	End Property
	
	Shared Property AfterSavingDeletePdfChecked() As String
		Get
			If m_AfterSavingDeletePdfChecked = Nothing Then
				m_AfterSavingDeletePdfChecked = 0
			End If
			Return m_AfterSavingDeletePdfChecked
		End Get
		Set(ByVal Value As String)
			m_AfterSavingDeletePdfChecked = Value
		End Set
	End Property
	
	Shared Property AfterSavingUploadingDeletePdfChecked() As String
		Get
			If m_AfterSavingUploadingDeletePdfChecked = Nothing Then
				m_AfterSavingUploadingDeletePdfChecked = 0
			End If
			Return m_AfterSavingUploadingDeletePdfChecked
		End Get
		Set(ByVal Value As String)
			m_AfterSavingUploadingDeletePdfChecked = Value
		End Set
	End Property
		
	Shared Property TitlePreFill() As String
		Get
			Return m_TitlePreFill
		End Get
		Set(ByVal Value As String)
			m_TitlePreFill = Value
		End Set
	End Property
	
	Shared Property AuthorPreFill() As String
		Get
			Return m_AuthorPreFill
		End Get
		Set(ByVal Value As String)
			m_AuthorPreFill = Value
		End Set
	End Property
	
	Shared Property SubjectPreFill() As String
		Get
			Return m_SubjectPreFill
		End Get
		Set(ByVal Value As String)
			m_SubjectPreFill = Value
		End Set
	End Property
		
	Shared Property KeywordsPreFill() As String
		Get
			If m_KeywordsPreFill = Nothing Then
				m_KeywordsPreFill = ""
			End If
			Return m_KeywordsPreFill
		End Get
		Set(ByVal Value As String)
			m_KeywordsPreFill = Value
		End Set
	End Property
	
	Shared Property UseExistingTitleChecked() As String
		Get
			If m_UseExistingTitleChecked = Nothing Then
				m_UseExistingTitleChecked = 0
			End If
			Return m_UseExistingTitleChecked
		End Get
		Set(ByVal Value As String)
			m_UseExistingTitleChecked = Value
		End Set
	End Property
	
	Shared Property UseExistingAuthorChecked() As String
		Get
			If m_UseExistingAuthorChecked = Nothing Then
				m_UseExistingAuthorChecked = 0
			End If
			Return m_UseExistingAuthorChecked
		End Get
		Set(ByVal Value As String)
			m_UseExistingAuthorChecked = Value
		End Set
	End Property
	
	Shared Property UseExistingSubjectChecked() As String
		Get
			If m_UseExistingSubjectChecked = Nothing Then
				m_UseExistingSubjectChecked = 0
			End If
			Return m_UseExistingSubjectChecked
		End Get
		Set(ByVal Value As String)
			m_UseExistingSubjectChecked = Value
		End Set
	End Property
	
	Shared Property UseExistingKeywordsChecked() As String
		Get
			If m_UseExistingKeywordsChecked = Nothing Then
				m_UseExistingKeywordsChecked = 0
			End If
			Return m_UseExistingKeywordsChecked
		End Get
		Set(ByVal Value As String)
			m_UseExistingKeywordsChecked = Value
		End Set
	End Property
	
	Shared Property AfterUploadingDeletePdfChecked() As String
		Get
			If m_AfterUploadingDeletePdfChecked = Nothing Then
				m_AfterUploadingDeletePdfChecked = 0
			End If
			Return m_AfterUploadingDeletePdfChecked
		End Get
		Set(ByVal Value As String)
			m_AfterUploadingDeletePdfChecked = Value
		End Set
	End Property

	#End Region
	
	#Region "Functions and Subroutines"

	''' <summary>
	''' This function will read application user settings from UserSettings.XML
	''' into class properties.  It will get called when the application is
	''' started.
	''' </summary>
	''' <returns>0 = Success, 1 = Failed</returns>
	Public Function Read() As Byte
			
		' If a PDFKeeper 1.0.0 or 1.1.0 properties file exists, then import and
		' delete the file.
		Dim legacyProperties As String = Path.Combine(AppDataDir, "pdfkeeper.properties")
		If IO.File.Exists(legacyProperties) Then
			Try
				Using oFileStream As New FileStream(legacyProperties, _
									 	 FileMode.Open)
					Using oStreamReader As New StreamReader(oFileStream, _
															Encoding.ASCII)
				
						' First line is LastDataSource.
						Dim lastDataSource As String
						lastDataSource = oStreamReader.ReadLine
						m_LastDataSource = lastDataSource.Substring(15)
				
						' Second line is LastUsername.
						Dim lastUserName As String
						lastUserName = oStreamReader.ReadLine
						m_LastUserName = lastUserName.Substring(13)
					End Using
					oFileStream.Close
				End Using
				IO.File.Delete(legacyProperties)
			Catch ex As IOException
				Dim oMessageDialog As New MessageDialog(ex.Message)
				oMessageDialog.DisplayError
				Return 1
			End Try
		End If
				
		' If a PDFKeeper 2.0.0 through 2.4.0 registry key exists, then import
		' and delete the key.
		Dim appRoot As String = "HKEY_CURRENT_USER\Software\" & _
								 Application.ProductName
		Dim regKey As Microsoft.Win32.RegistryKey = _
			  		  Microsoft.Win32.Registry.CurrentUser.OpenSubKey( _
			  		 "Software\" & Application.ProductName, True)
		If Not regKey Is Nothing Then
			Try
				m_LastUserName = Registry.GetValue(appRoot, "LastUserName", _
											   	   Nothing)
				m_LastDataSource = Registry.GetValue(appRoot, _
													"LastDataSource", _
												 	 Nothing)
				m_FormPositionTop = Registry.GetValue(appRoot, _
													 "FormPositionTop", _
												  	  Nothing)
				m_FormPositionLeft = Registry.GetValue(appRoot, _
													  "FormPositionLeft", _
													   Nothing)
				m_FormPositionHeight = Registry.GetValue(appRoot, _
														"FormPositionHeight", _
														 Nothing)
				m_FormPositionWidth = Registry.GetValue(appRoot, _
													   "FormPositionWidth", _
														Nothing)
				m_FormPositionWindowState = Registry.GetValue(appRoot, _
												"FormPositionWindowState", _
												 Nothing)
				m_UpdateCheck = Registry.GetValue(appRoot, "UpdateCheck", _
												  Nothing)
				registry.CurrentUser.DeleteSubKey("Software\" & _
												   Application.ProductName)
			Catch ex as IOException
				Dim oMessageDialog As New MessageDialog(ex.Message)
				oMessageDialog.DisplayError
				Return 1
			End Try
		End If
				
		If IO.File.Exists(xmlFile) Then
			Try
				Dim xmlConfig As New XmlConfigSource(xmlFile)
				m_LastUserName = xmlConfig.Configs("DatabaseConnectionForm") _
									  	  	.Get("LastUserName")
				m_LastDataSource = xmlConfig.Configs("DatabaseConnectionForm") _
									  		.Get("LastDataSource")
				m_FormPositionTop = xmlConfig.Configs("MainForm") _
									  		.Get("FormPositionTop")
				m_FormPositionLeft = xmlConfig.Configs("MainForm") _
									  		.Get("FormPositionLeft")
				m_FormPositionHeight = xmlConfig.Configs("MainForm") _
									  		.Get("FormPositionHeight")
				m_FormPositionWidth = xmlConfig.Configs("MainForm") _
									  		.Get("FormPositionWidth")
				m_FormPositionWindowState = xmlConfig.Configs("MainForm") _
									  		.Get("FormPositionWindowState")
				m_UpdateCheck = xmlConfig.Configs("MainForm") _
											.Get("UpdateCheck")
				m_InfoPropEditWatcherEnabled = xmlConfig.Configs("MainForm") _
											.Get("InfoPropEditWatcherEnabled")
				m_InfoPropEditWatcherFolder = xmlConfig.Configs("MainForm") _
											.Get("InfoPropEditWatcherFolder")
				m_UploadWatcherEnabled = xmlConfig.Configs("MainForm") _
											.Get("UploadWatcherEnabled")
				m_UploadWatcherFolder = xmlConfig.Configs("MainForm") _
											.Get("UploadWatcherFolder")
				m_AfterSavingOpenPdfChecked = xmlConfig.Configs( _
										"InformationPropertiesEditorForm") _
											.Get("AfterSavingOpenPdfChecked")
				m_AfterSavingUploadPdfChecked = xmlConfig.Configs( _
										"InformationPropertiesEditorForm") _
											.Get("AfterSavingUploadPdfChecked")
				m_AfterSavingDeletePdfChecked = xmlConfig.Configs( _
										"InformationPropertiesEditorForm") _
											.Get("AfterSavingDeletePdfChecked")
				m_AfterSavingUploadingDeletePdfChecked = xmlConfig.Configs( _
										"InformationPropertiesEditorForm") _
								   .Get("AfterSavingUploadingDeletePdfChecked")
				m_OpenFileLastFolder = xmlConfig.Configs("CommonDialogs") _
								   .Get("OpenFileLastFolder")
				m_SaveFileLastFolder = xmlConfig.Configs("CommonDialogs") _
								   .Get("SaveFileLastFolder")
				m_TitlePreFill = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
								   .Get("TitlePreFill")
				m_AuthorPreFill = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
							   	   .Get("AuthorPreFill")
				m_SubjectPreFill = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
							   	   .Get("SubjectPreFill")
				m_KeywordsPreFill = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
							   	   .Get("KeywordsPreFill")
				m_UseExistingTitleChecked = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
							   	   .Get("UseExistingTitleChecked")
				m_UseExistingAuthorChecked = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
							   	   .Get("UseExistingAuthorChecked")
				m_UseExistingSubjectChecked = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
							   	   .Get("UseExistingSubjectChecked")
				m_UseExistingKeywordsChecked = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
							  	   .Get("UseExistingKeywordsChecked")
				m_AfterUploadingDeletePdfChecked = xmlConfig.Configs( _
									"UploadFolderWatcherConfigurationForm") _
							   	   .Get("AfterUploadingDeletePdfChecked")
			Catch ex As System.NullReferenceException
			Catch ex As UnauthorizedAccessException
				Dim oMessageDialog As New MessageDialog(ex.Message)
				oMessageDialog.DisplayError
				Return 1
			Catch ex As IOException
				Dim oMessageDialog As New MessageDialog(ex.Message)
				oMessageDialog.DisplayError
				Return 1
			End Try
		End If
		Return 0
	End Function

	''' <summary>
	''' This subroutine will write the class properties to UserSettings.XML.
	''' It will get called when the application is closing.
	''' </summary>
	Public Sub Write
		Try
			Dim xmlConfig As New XmlConfigSource
			xmlConfig.AddConfig("DatabaseConnectionForm")
			xmlConfig.Configs("DatabaseConnectionForm").Set("LastUserName", _
														     m_LastUserName)
			xmlConfig.Configs("DatabaseConnectionForm").Set("LastDataSource", _
														 	 m_LastDataSource)
			xmlConfig.AddConfig("MainForm")
			xmlConfig.Configs("MainForm").Set("FormPositionTop", _
											   m_FormPositionTop)
			xmlConfig.Configs("MainForm").Set("FormPositionLeft", _
											   m_FormPositionLeft)
			xmlConfig.Configs("MainForm").Set("FormPositionHeight", _
											   m_FormPositionHeight)
			xmlConfig.Configs("MainForm").Set("FormPositionWidth", _
											   m_FormPositionWidth)
			xmlConfig.Configs("MainForm").Set("FormPositionWindowState", _
											   m_FormPositionWindowState)
			xmlConfig.Configs("MainForm").Set("UpdateCheck", m_UpdateCheck)
			xmlConfig.Configs("MainForm").Set("InfoPropEditWatcherEnabled", _
											   m_InfoPropEditWatcherEnabled)
			If Not m_InfoPropEditWatcherFolder = Nothing Then
				xmlConfig.Configs("MainForm").Set("InfoPropEditWatcherFolder", _
												   m_InfoPropEditWatcherFolder)
			End If
			xmlConfig.Configs("MainForm").Set("UploadWatcherEnabled", _
											   m_UploadWatcherEnabled)
			If Not m_UploadWatcherFolder = Nothing Then
				xmlConfig.Configs("MainForm").Set("UploadWatcherFolder", _
												   m_UploadWatcherFolder)
			End If
			xmlConfig.AddConfig("InformationPropertiesEditorForm")
			If m_AfterSavingOpenPdfChecked = Nothing Then
				m_AfterSavingOpenPdfChecked = 0
			End If
			xmlConfig.Configs("InformationPropertiesEditorForm").Set( _
							  "AfterSavingOpenPdfChecked", _
							   m_AfterSavingOpenPdfChecked)
			If m_AfterSavingUploadPdfChecked = Nothing Then
				m_AfterSavingUploadPdfChecked = 0
			End If
			xmlConfig.Configs("InformationPropertiesEditorForm").Set( _
							  "AfterSavingUploadPdfChecked", _
							   m_AfterSavingUploadPdfChecked)
			If m_AfterSavingDeletePdfChecked = Nothing Then
				m_AfterSavingDeletePdfChecked = 0
			End If
			xmlConfig.Configs("InformationPropertiesEditorForm").Set( _
							  "AfterSavingDeletePdfChecked", _
							   m_AfterSavingDeletePdfChecked)
			If m_AfterSavingUploadingDeletePdfChecked = Nothing Then
				m_AfterSavingUploadingDeletePdfChecked = 0
			End If
			xmlConfig.Configs("InformationPropertiesEditorForm").Set( _
							  "AfterSavingUploadingDeletePdfChecked", _
							   m_AfterSavingUploadingDeletePdfChecked)
			xmlConfig.AddConfig("CommonDialogs")
			If Not m_OpenFileLastFolder = Nothing Then
				xmlConfig.Configs("CommonDialogs").Set("OpenFileLastFolder", _
														m_OpenFileLastFolder)				
			End If
			If Not m_SaveFileLastFolder = Nothing Then
				xmlConfig.Configs("CommonDialogs").Set("SaveFileLastFolder", _
														m_SaveFileLastFolder)
			End If
			xmlConfig.AddConfig("UploadFolderWatcherConfigurationForm")
			If Not m_TitlePreFill = Nothing Then
				xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  	  "TitlePreFill", m_TitlePreFill)
			End If
			If Not m_AuthorPreFill = Nothing Then
				xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  	  "AuthorPreFill", m_AuthorPreFill)
			End If
			If Not m_SubjectPreFill = Nothing Then
				xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  	  "SubjectPreFill", m_SubjectPreFill)
			End If
			If Not m_KeywordsPreFill = Nothing Then
				xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  	  "KeywordsPreFill", m_KeywordsPreFill)
			End If
			If m_UseExistingTitleChecked = Nothing Then
				m_UseExistingTitleChecked = 0
			End If
			xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  "UseExistingTitleChecked", _
							   m_UseExistingTitleChecked)
			If m_UseExistingAuthorChecked = Nothing Then
				m_UseExistingAuthorChecked = 0
			End If
			xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  "UseExistingAuthorChecked", _
							   m_UseExistingAuthorChecked)
			If m_UseExistingSubjectChecked = Nothing Then
				m_UseExistingSubjectChecked = 0
			End If
			xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  "UseExistingSubjectChecked", _
							   m_UseExistingSubjectChecked)
			If m_UseExistingKeywordsChecked = Nothing Then
				m_UseExistingKeywordsChecked = 0
			End If
			xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  "UseExistingKeywordsChecked", _
							   m_UseExistingKeywordsChecked)
			If m_AfterUploadingDeletePdfChecked = Nothing Then
				m_AfterUploadingDeletePdfChecked = 0
			End If
			xmlConfig.Configs("UploadFolderWatcherConfigurationForm").Set( _
							  "AfterUploadingDeletePdfChecked", _
							   m_AfterUploadingDeletePdfChecked)
			xmlConfig.Save(xmlFile)
		Catch ex As UnauthorizedAccessException
			Dim oMessageDialog As New MessageDialog(ex.Message)
			oMessageDialog.DisplayError
		Catch ex As IOException
			Dim oMessageDialog As New MessageDialog(ex.Message)
			oMessageDialog.DisplayError
		End Try
	End Sub
	
	#End Region
End Class
