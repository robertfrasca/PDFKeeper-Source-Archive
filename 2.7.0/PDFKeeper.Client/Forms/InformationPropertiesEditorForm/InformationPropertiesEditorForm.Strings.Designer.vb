﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5456
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
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class InformationPropertiesEditorForm_Strings
	
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
				Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PdfKeeper.Client.InformationPropertiesEditorForm.Strings", GetType(InformationPropertiesEditorForm_Strings).Assembly)
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
	'''  Looks up a localized string similar to Do you want to continue editing PDF files?.
	'''</summary>
	Friend Shared ReadOnly Property ContinueEditing() As String
		Get
			Return ResourceManager.GetString("ContinueEditing", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Are you sure you want to delete the original file {0}?.
	'''</summary>
	Friend Shared ReadOnly Property DeleteOriginal() As String
		Get
			Return ResourceManager.GetString("DeleteOriginal", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Are you sure you want to delete the saved file {0} after being uploaded?.
	'''</summary>
	Friend Shared ReadOnly Property DeleteSaved() As String
		Get
			Return ResourceManager.GetString("DeleteSaved", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Unable to read {0}. File will be skipped..
	'''</summary>
	Friend Shared ReadOnly Property UnableRead() As String
		Get
			Return ResourceManager.GetString("UnableRead", resourceCulture)
		End Get
	End Property
End Class