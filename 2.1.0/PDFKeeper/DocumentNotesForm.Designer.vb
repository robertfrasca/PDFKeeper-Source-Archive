﻿'*************************************************************************
'*
'* PDFKeeper -- PDF Document Storage for Small or Home Office
'* Copyright (C) 2009-2011 Robert F. Frasca
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

Partial Class DocumentNotesForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentNotesForm))
		Me.textBoxNotes = New System.Windows.Forms.TextBox
		Me.buttonUpdate = New System.Windows.Forms.Button
		Me.buttonCancel = New System.Windows.Forms.Button
		Me.buttonDateTime = New System.Windows.Forms.Button
		Me.buttonPrint = New System.Windows.Forms.Button
		Me.printDocumentNotes = New System.Drawing.Printing.PrintDocument
		Me.printDialog = New System.Windows.Forms.PrintDialog
		Me.SuspendLayout
		'
		'textBoxNotes
		'
		Me.textBoxNotes.Location = New System.Drawing.Point(12, 12)
		Me.textBoxNotes.MaxLength = 4000
		Me.textBoxNotes.Multiline = true
		Me.textBoxNotes.Name = "textBoxNotes"
		Me.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.textBoxNotes.Size = New System.Drawing.Size(620, 350)
		Me.textBoxNotes.TabIndex = 0
		AddHandler Me.textBoxNotes.TextChanged, AddressOf Me.TextBoxNotesTextChanged
		'
		'buttonUpdate
		'
		Me.buttonUpdate.Location = New System.Drawing.Point(476, 383)
		Me.buttonUpdate.Name = "buttonUpdate"
		Me.buttonUpdate.Size = New System.Drawing.Size(75, 23)
		Me.buttonUpdate.TabIndex = 3
		Me.buttonUpdate.Text = "&Update"
		Me.buttonUpdate.UseVisualStyleBackColor = true
		AddHandler Me.buttonUpdate.Click, AddressOf Me.ButtonUpdateClick
		'
		'buttonCancel
		'
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(557, 383)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancel.TabIndex = 4
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = true
		'
		'buttonDateTime
		'
		Me.buttonDateTime.Image = CType(resources.GetObject("buttonDateTime.Image"),System.Drawing.Image)
		Me.buttonDateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.buttonDateTime.Location = New System.Drawing.Point(12, 383)
		Me.buttonDateTime.Name = "buttonDateTime"
		Me.buttonDateTime.Size = New System.Drawing.Size(85, 23)
		Me.buttonDateTime.TabIndex = 1
		Me.buttonDateTime.Text = "&Date/Time"
		Me.buttonDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.buttonDateTime.UseVisualStyleBackColor = true
		AddHandler Me.buttonDateTime.Click, AddressOf Me.ButtonDateTimeClick
		'
		'buttonPrint
		'
		Me.buttonPrint.Enabled = false
		Me.buttonPrint.Image = CType(resources.GetObject("buttonPrint.Image"),System.Drawing.Image)
		Me.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.buttonPrint.Location = New System.Drawing.Point(103, 383)
		Me.buttonPrint.Name = "buttonPrint"
		Me.buttonPrint.Size = New System.Drawing.Size(85, 23)
		Me.buttonPrint.TabIndex = 2
		Me.buttonPrint.Text = "&Print"
		Me.buttonPrint.UseVisualStyleBackColor = true
		AddHandler Me.buttonPrint.Click, AddressOf Me.ButtonPrintClick
		'
		'printDocumentNotes
		'
		AddHandler Me.printDocumentNotes.PrintPage, AddressOf Me.PrintDocumentNotesPrintPage
		'
		'printDialog
		'
		Me.printDialog.Document = Me.printDocumentNotes
		Me.printDialog.UseEXDialog = true
		'
		'DocumentNotesForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonCancel
		Me.ClientSize = New System.Drawing.Size(644, 418)
		Me.Controls.Add(Me.buttonPrint)
		Me.Controls.Add(Me.buttonDateTime)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonUpdate)
		Me.Controls.Add(Me.textBoxNotes)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "DocumentNotesForm"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Document Notes"
		AddHandler Load, AddressOf Me.DocumentNotesFormLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private printDialog As System.Windows.Forms.PrintDialog
	Private printDocumentNotes As System.Drawing.Printing.PrintDocument
	Private buttonPrint As System.Windows.Forms.Button
	Private buttonDateTime As System.Windows.Forms.Button
	Private buttonUpdate As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
	Private textBoxNotes As System.Windows.Forms.TextBox
End Class
