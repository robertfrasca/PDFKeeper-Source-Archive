@echo off

rem *****************************************************************
rem *
rem * PDFKeeper -- PDF Document Storage for Small or Home Office
rem * Copyright (C) 2009-2010 Robert F. Frasca
rem *
rem * This program is free software: you can redistribute it and/or
rem * modify it under the terms of the GNU General Public License as
rem * published by the Free Software Foundation, either version 3 of
rem * the License, or (at your option) any later version.
rem *
rem * This program is distributed in the hope that it will be
rem * useful, but WITHOUT ANY WARRANTY; without even the implied
rem * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR
rem * PURPOSE.  See the GNU General Public License for more details.
rem *
rem * You should have received a copy of the GNU General Public
rem * License along with this program.  If not, see
rem * <http://www.gnu.org/licenses/>.
rem *
rem *****************************************************************

for /f "delims==" %%f in ('dir Source\*.rex /b') do (
 	rexxc Source\%%f Binaries\%%f
)
for /f "delims==" %%f in ('dir Source\*.cls /b') do (
 	rexxc Source\%%f Binaries\%%f
)

echo.
echo This script has completed.
echo.
echo Before pressing any key, review the command output on this
echo screen for errors.
echo.
pause
