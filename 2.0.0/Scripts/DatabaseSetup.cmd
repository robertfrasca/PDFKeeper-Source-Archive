@echo off

rem **********************************************************************
rem *
rem * PDFKeeper -- PDF Document Storage for Small or Home Office
rem * Copyright (C) 2009-2010 Robert F. Frasca
rem *
rem * This program is free software: you can redistribute it and/or
rem * modify it under the terms of the GNU General Public License as
rem * published by the Free Software Foundation, either version 3 of the
rem * License, or (at your option) any later version.
rem *
rem * This program is distributed in the hope that it will be useful, but
rem * WITHOUT ANY WARRANTY; without even the implied warranty of
rem * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
rem * GNU General Public License for more details.
rem *
rem * You should have received a copy of the GNU General Public License
rem * along with this program.  If not, see
rem * <http://www.gnu.org/licenses/>.
rem *
rem **********************************************************************

title PDFKeeper Database Setup
setlocal enabledelayedexpansion

rem Detect if Oracle XE Server or Client is installed.
set regKeyS="HKEY_LOCAL_MACHINE\SOFTWARE\ORACLE\KEY_XE"
set regKeyC="HKEY_LOCAL_MACHINE\SOFTWARE\ORACLE\KEY_XEClient"
set installType=Nothing
reg query %regKeyS% /v "ORACLE_HOME_NAME" 1>nul 2>nul
if !ERRORLEVEL!==0 (
	set installType=Server
) else (
	reg query %regKeyC% /v "ORACLE_HOME_NAME" 1>nul 2>nul
	if !ERRORLEVEL!==0 (
		set installType=Client
	)
)
if "!installType!"=="Nothing" (
	echo.
	echo Error:
	echo Unable to detect an Oracle XE Server or Client installation.
	echo.
	goto End
)

rem Execute the database setup SQL script.
if "!installType!"=="Server" (
	sqlplus / as sysdba @DatabaseSetup.sql
)
if "!installType!"=="Client" (
	echo.
	echo Enter the database connect string in the format
	echo username@host:port
	echo.
	echo - The username must be a member of SYSDBA.
	echo - If no port number is specified, the default of 1521
	echo   is used.
	echo.
	set /p connectString=Enter connect string: 
	if "!connectString!"=="" (
		echo.
		echo Error:
		echo Database connect string not specified.
		echo.
		goto End
	)
	sqlplus !connectString! @DatabaseSetup.sql
)	

:End
set regKeyS=
set regKeyC=
set installType=
set connectString=
del sqlnet.log 2>nul
endlocal
pause
