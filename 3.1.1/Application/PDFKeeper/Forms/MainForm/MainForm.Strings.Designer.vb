﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class MainForm_Strings
	
	Private Shared resourceMan As Global.System.Resources.ResourceManager
	
	Private Shared resourceCulture As Global.System.Globalization.CultureInfo
	
	<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
	Friend Sub New()
		MyBase.New
	End Sub
	
	'''<summary>
	'''  Returns the cached ResourceManager instance used by this class.
	'''</summary>
	<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
	Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
		Get
			If Object.ReferenceEquals(resourceMan, Nothing) Then
				Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PdfKeeper.MainForm.Strings", GetType(MainForm_Strings).Assembly)
				resourceMan = temp
			End If
			Return resourceMan
		End Get
	End Property
	
	'''<summary>
	'''  Overrides the current thread's CurrentUICulture property for all
	'''  resource lookups using this strongly typed resource class.
	'''</summary>
	<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
	Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
		Get
			Return resourceCulture
		End Get
		Set
			resourceCulture = value
		End Set
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Temporary copy of PDF document has been saved and is ready to be uploaded..
	'''</summary>
	Friend Shared ReadOnly Property CaptureSaved() As String
		Get
			Return ResourceManager.GetString("CaptureSaved", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Saving temporary copy of PDF document....
	'''</summary>
	Friend Shared ReadOnly Property CaptureSaving() As String
		Get
			Return ResourceManager.GetString("CaptureSaving", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Uploading PDF document....
	'''</summary>
	Friend Shared ReadOnly Property CaptureUploading() As String
		Get
			Return ResourceManager.GetString("CaptureUploading", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Checking for a newer version of PDFKeeper....
	'''</summary>
	Friend Shared ReadOnly Property CheckingVersion() As String
		Get
			Return ResourceManager.GetString("CheckingVersion", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Delete all checked documents?.
	'''</summary>
	Friend Shared ReadOnly Property DeleteChecked() As String
		Get
			Return ResourceManager.GetString("DeleteChecked", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Are you sure you want to deselect this document?
	'''Any modifications will be discarded..
	'''</summary>
	Friend Shared ReadOnly Property DeselectPrompt() As String
		Get
			Return ResourceManager.GetString("DeselectPrompt", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to The Document Notes text box contains unsaved data.  Do you want to save changes?.
	'''</summary>
	Friend Shared ReadOnly Property DocumentNotesSavePrompt() As String
		Get
			Return ResourceManager.GetString("DocumentNotesSavePrompt", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to A captured PDF document is currently selected.
	'''Closing PDFKeeper will result in all modifications being discarded.
	'''Are you sure you want to close PDFKeeper?
	'''.
	'''</summary>
	Friend Shared ReadOnly Property FormClosingPromptSelected() As String
		Get
			Return ResourceManager.GetString("FormClosingPromptSelected", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Improper use of operators and/or characters. For more information, please consult &quot;How to search for documents&quot; in the Help file..
	'''</summary>
	Friend Shared ReadOnly Property ImproperUsage() As String
		Get
			Return ResourceManager.GetString("ImproperUsage", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to {0} document(s) found; {1} document(s) checked..
	'''</summary>
	Friend Shared ReadOnly Property ListViewCountChecked() As String
		Get
			Return ResourceManager.GetString("ListViewCountChecked", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to A newer version of PDFKeeper is available.
	'''</summary>
	Friend Shared ReadOnly Property NewerVersionAvailable() As String
		Get
			Return ResourceManager.GetString("NewerVersionAvailable", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to {0} has been saved..
	'''</summary>
	Friend Shared ReadOnly Property PdfSaved() As String
		Get
			Return ResourceManager.GetString("PdfSaved", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Database does not support the use of * as a wildcard character! Use % instead.  For more information, please consult &quot;How to search for documents&quot; in the Help file..
	'''</summary>
	Friend Shared ReadOnly Property SearchTextUsageError() As String
		Get
			Return ResourceManager.GetString("SearchTextUsageError", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to The selected document has been deleted from outside of PDFKeeper.
	'''All modifications will be lost..
	'''</summary>
	Friend Shared ReadOnly Property SelectedDocDeleted() As String
		Get
			Return ResourceManager.GetString("SelectedDocDeleted", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to The selected document has been renamed from outside of PDFKeeper.
	'''All modifications will be lost..
	'''</summary>
	Friend Shared ReadOnly Property SelectedDocRenamed() As String
		Get
			Return ResourceManager.GetString("SelectedDocRenamed", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Unable to read {0}.
	'''</summary>
	Friend Shared ReadOnly Property UnableRead() As String
		Get
			Return ResourceManager.GetString("UnableRead", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Unable to start Direct Upload Process due to an error while syncing folders to configuration files..
	'''</summary>
	Friend Shared ReadOnly Property UnableToStartDirectUpload() As String
		Get
			Return ResourceManager.GetString("UnableToStartDirectUpload", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Upload {0}?.
	'''</summary>
	Friend Shared ReadOnly Property UploadPrompt() As String
		Get
			Return ResourceManager.GetString("UploadPrompt", resourceCulture)
		End Get
	End Property
End Class
