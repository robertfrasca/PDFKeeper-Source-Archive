﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5466
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
Friend Class PdfProperties_Strings
	
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
				Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PdfKeeper.PdfProperties.Strings", GetType(PdfProperties_Strings).Assembly)
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
	'''  Looks up a localized string similar to Incorrect OWNER password.  If you do not know the password and have the legal right to remove the password, you can find plenty of information on the internet to assist you..
	'''</summary>
	Friend Shared ReadOnly Property BadPassword() As String
		Get
			Return ResourceManager.GetString("BadPassword", resourceCulture)
		End Get
	End Property
End Class
