; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this ClientSide.
; Do not use the same AppId value in installers for other ClientSides.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4F0E9E20-AB83-4AB1-9B05-D77BDED27ED4}
AppName=PDFKeeper
AppVerName=PDFKeeper 1.0.0
AppPublisher=Robert F. Frasca
AppPublisherURL=http://code.google.com/p/pdfkeeper/
AppSupportURL=http://code.google.com/p/pdfkeeper/issues/list
AppUpdatesURL=http://code.google.com/p/pdfkeeper/downloads/list
DefaultDirName={pf}\PDFKeeper
DefaultGroupName=PDFKeeper
LicenseFile=H:\My Documents\Development\OpenSource\PDFKeeper\COPYING.txt
OutputDir=H:\My Documents\Development\OpenSource\PDFKeeper
OutputBaseFilename=PDFKeeper-1.0.0
SetupIconFile=H:\My Documents\Development\OpenSource\PDFKeeper\Graphics\logo.ico
Compression=lzma
SolidCompression=true
MinVersion=0,5.01.2600sp1
VersionInfoVersion=1.0.0
VersionInfoDescription=PDF Document Storage for Small or Home Office
VersionInfoTextVersion=1.0.0
VersionInfoProductName=PDFKeeper
VersionInfoProductVersion=1.0.0
AlwaysRestart=false
AppCopyright=� 2009 Robert F. Frasca
AppVersion=1.0.0
AppContact=
VersionInfoCompany=Robert F. Frasca
VersionInfoCopyright=� 2009 Robert F. Frasca
AppComments=PDF Document Storage for Small or Home Office
UninstallDisplayIcon={app}\Graphics\logo.ico
ChangesAssociations=true
OnlyBelowVersion=0,5.02.3790
ChangesEnvironment=true

[Languages]
Name: english; MessagesFile: compiler:Default.isl

[Components]
Name: ClientSide; Description: Install client-side components (Search and Summary Editor); Types: custom full compact; Languages: 
Name: ServerSide; Description: Install server-side components (Database Setup and Document Loader); Types: custom full
[Icons]
Name: {group}\PDFKeeper Search; Filename: {app}\Scripts\pdfsearch.vbs; WorkingDir: {app}\Scripts; IconFilename: {app}\Graphics\logo.ico; IconIndex: 0; Comment: PDF Document Storage Search; Components: ClientSide; Languages: 
Name: {commondesktop}\PDFKeeper Search; Filename: {app}\Scripts\pdfsearch.vbs; WorkingDir: {app}\Scripts; IconFilename: {app}\Graphics\logo.ico; IconIndex: 0; Comment: PDF Document Storage Search; Components: ClientSide
Name: {group}\Database Setup; Filename: {app}\Scripts\dbsetup.cmd; WorkingDir: {app}\Scripts; Components: ServerSide
Name: {group}\Select Upload Folder; Filename: {app}\Scripts\upfolder.vbs; WorkingDir: {app}\Scripts; Components: ServerSide
Name: {group}\Documentation\User FAQ; Filename: {app}\Documents\faq.html; WorkingDir: {app}\Documents
Name: {group}\Documentation\Release Notes; Filename: {app}\Documents\release-notes.html; WorkingDir: {app}\Documents
Name: {group}\Documentation\Installation - Quick Start Guide; Filename: {app}\Documents\install.html; WorkingDir: {app}\Documents
Name: {group}\Documentation\User Guide; Filename: {app}\Documents\userguide.html; WorkingDir: {app}\Documents
[Registry]
Root: HKLM; SubKey: SOFTWARE\PDFKeeper; ValueType: string; ValueName: HomeDir; ValueData: {app}; Components: ClientSide; Flags: uninsdeletekey
Root: HKCR; SubKey: *\shell\PDFKeeper Summary Editor; ValueType: string; Components: ClientSide; Flags: uninsdeletekey
Root: HKCR; SubKey: *\shell\PDFKeeper Summary Editor\command; ValueType: string; ValueData: "wscript.exe ""{app}\Scripts\pdfsedit.vbs"" "" %1"""; Components: ClientSide; Flags: uninsdeletekey
Root: HKLM; Subkey: SYSTEM\CurrentControlSet\Control\Session Manager\Environment; ValueType: string; ValueName: PDFKEEPER_UPLOAD; Flags: uninsdeletevalue dontcreatekey; Languages: 
[Dirs]
Name: {app}\Binaries; Flags: uninsalwaysuninstall; Components: ClientSide ServerSide
Name: {app}\Graphics; Flags: uninsalwaysuninstall; Components: ClientSide ServerSide
Name: {app}\Scripts; Flags: uninsalwaysuninstall; Components: ClientSide ServerSide
Name: {app}\Documents; Flags: uninsalwaysuninstall; Components: ClientSide ServerSide
Name: {app}\Documents\css; Flags: uninsalwaysuninstall; Components: " ServerSide ClientSide"
[Files]
Source: THIRDPARTYLICENSEREADME.txt; DestDir: {app}; Components: ClientSide ServerSide
Source: COPYING.txt; DestDir: {app}; Components: ClientSide ServerSide
Source: Binaries\SumatraPDF.exe; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\about.cls; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\dblogon.cls; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\entry.cls; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\odbcsql.cls; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\pdf.cls; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\pdfinfo.exe; DestDir: {app}\Binaries; Components: ClientSide ServerSide; Languages: 
Source: Binaries\pdfsearch.cls; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\pdfsearch.rex; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\pdfsedit.cls; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\pdfsedit.rex; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\pdftk.exe; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\property.cls; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\rexxodbc.dll; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\rexxsql.dll; DestDir: {app}\Binaries; Components: ClientSide
Source: Binaries\rexxtrans.dll; DestDir: {app}\Binaries; Components: ClientSide
Source: Graphics\logo.ico; DestDir: {app}\Graphics; Components: ClientSide ServerSide; Languages: 
Source: Graphics\listicon.bmp; DestDir: {app}\Graphics; Components: ClientSide
Source: Graphics\logo.bmp; DestDir: {app}\Graphics; Components: ClientSide
Source: Scripts\upfolder.vbs; DestDir: {app}\Scripts; Components: ServerSide
Source: Scripts\dbinput.vbs; DestDir: {app}\Scripts; Components: ServerSide
Source: Scripts\dbsetup.cmd; DestDir: {app}\Scripts; Components: ServerSide
Source: Scripts\dbsetup.sql; DestDir: {app}\Scripts; Components: ServerSide
Source: Scripts\dloader.cmd; DestDir: {app}\Scripts; Components: ServerSide
Source: Scripts\pdfsearch.vbs; DestDir: {app}\Scripts; Components: ClientSide
Source: Scripts\pdfsedit.vbs; DestDir: {app}\Scripts; Components: ClientSide
Source: Scripts\sqlloader.ctl; DestDir: {app}\Scripts; Components: ServerSide
Source: Documents\userguide.html; DestDir: {app}\Documents; Components: ClientSide ServerSide
Source: Documents\faq.html; DestDir: {app}\Documents; Components: ClientSide ServerSide
Source: Documents\install.html; DestDir: {app}\Documents; Components: ClientSide ServerSide
Source: Documents\release-notes.html; DestDir: {app}\Documents; Components: ClientSide ServerSide
Source: Documents\css\readyset.css; DestDir: {app}\Documents\css; Components: ClientSide ServerSide
Source: Documents\css\inst.css; DestDir: {app}\Documents\css; Components: ClientSide ServerSide
Source: Documents\css\nav.css; DestDir: {app}\Documents\css; Components: ClientSide ServerSide
Source: Documents\css\print.css; DestDir: {app}\Documents\css; Components: ClientSide ServerSide
