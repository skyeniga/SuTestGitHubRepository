@ECHO OFF
setlocal ENABLEDELAYEDEXPANSION

SET AppVersion=2.0.0.0
SET ApplicationName=DLAP Application Import v!AppVersion!
SET ResourceSpec=!ApplicationName!.ResourceSpec.xml
SET Package=!ApplicationName!.msi
SET Destination=!ApplicationName!.xml
SET WebDirectorySource=http://localhost:80/DCMS2/DLAP
SET ComponentFileDir="C:\W\oda-lv-branch\dcms2-integ-dev-2.0\Loss Verification\Loss Verification Components\bin\Debug"
SET ComponentFileName="Loss Verification Components"
SET ComponentFile="!ComponentFileDir:"=!\!ComponentFileName:"=!.dll"
SET CONTINUE=True

ECHO ############################# Start !ApplicationName! Script %0 #################################
if "!WebDirectorySource!" NEQ "" (
	ECHO ---------------- Re-importing the Web Service in the !ApplicationName! --------------
	btstask AddResource    -ApplicationName:"!ApplicationName!" /Type:System.BizTalk:WebDirectory /Overwrite /Source:"!WebDirectorySource!"
	IF ERRORLEVEL 1 (
		CALL :OUTPUTERR The !ApplicationName! BTSTask -ApplicationName:"!ApplicationName!" /Type:System.BizTalk:WebDirectory /Overwrite /Source:"!WebDirectorySource!" step failed.
		SET CONTINUE=False
	)
	ECHO ----------- Completed Re-importing the Web Service in the !ApplicationName! ---------
)

if "!ComponentFile!" NEQ "" (
	ECHO -------- Importing the Loss Verification Components into !ApplicationName! -------
	BTSTask AddResource -Source:"%componentFile:"=%" -ApplicationName:"!ApplicationName!" -Overwrite -Type:System.BizTalk:Assembly -Op:GacOnAdd,GacOnInstall,GacOnImport
	IF ERRORLEVEL 1 (
		CALL :OUTPUTERR The !ApplicationName! BTSTask AddResource -Source:"%componentFile:"=%" -ApplicationName:"!ApplicationName!" -Overwrite -Type:System.BizTalk:Assembly -Op:GacOnAdd,GacOnInstall,GacOnImport step failed.
		SET CONTINUE=False
	)

	ECHO --- Completed Importing the Loss Verification Components into !ApplicationName! --
)

if exist "!ResourceSpec!" del "!ResourceSpec!"

if "!CONTINUE!" EQU "True" (
	ECHO ------------------ Generating the list of !ApplicationName! resources to export -----------------
    btstask ListApp        -ApplicationName:"!ApplicationName!" -ResourceSpec:"!ResourceSpec!"
	IF ERRORLEVEL 1 (
		CALL :OUTPUTERR The !ApplicationName! BTSTask ListApp -ApplicationName:"!ApplicationName!" -ResourceSpec:"!ResourceSpec!" step failed.
		SET CONTINUE=False
	)
	ECHO ------------- Completed generating the list of !ApplicationName! resources to export ------------
)

if NOT exist "!ResourceSpec!" if "!CONTINUE!" EQU "True" (
	CALL :OUTPUTERR The !ApplicationName! "!ResourceSpec!" file that should have been created during this script is missing.
	SET CONTINUE=False
)

if "!CONTINUE!" EQU "True" (
	if exist "!ResourceSpec!.bak" del "!ResourceSpec!.bak"
	ECHO ------------- Updating the Resource List to exclude !ApplicationName! bindings files ------------
	for /f "delims=" %%f in ('type "!ResourceSpec!" ^|findstr /v /c:"System.BizTalk:BizTalkBinding" /c:"xml version="') do @echo %%f >> "!ResourceSpec!.bak"
	ECHO -------- Completed updating the Resource List to exclude !ApplicationName! bindings files -------
)

if NOT exist "!ResourceSpec!.bak" if "!CONTINUE!" EQU "True" (
	CALL :OUTPUTERR The !ApplicationName! "!ResourceSpec!.bak" file that should have been generated during an earlier part of this script doesn't exist.
	SET CONTINUE=False
)

if "!CONTINUE!" EQU "True" (
	if exist "!ResourceSpec!" del "!ResourceSpec!"
	ren "!ResourceSpec!.bak" "!ResourceSpec!"
	if exist "!Package!" del "!Package!"

	ECHO ------------------------ Generating the !ApplicationName! MSI -----------------------
	btstask ExportApp      -ApplicationName="!ApplicationName!" -Package:"!Package!" -ResourceSpec:"!ResourceSpec!"
	IF ERRORLEVEL 1 (
		CALL :OUTPUTERR The !ApplicationName! BTSTask ExportApp      -ApplicationName="!ApplicationName!" -Package:"!Package!" -ResourceSpec:"!ResourceSpec!" step failed.
		SET CONTINUE=False
	)
	ECHO ------------------- Completed generating the !ApplicationName! MSI ------------------
)

if NOT exist "!Package!" if "!CONTINUE!" EQU "True" (
	CALL :OUTPUTERR The !ApplicationName! "!Package!" file that should have been created during this script is missing.
	SET CONTINUE=False
)

if "!CONTINUE!" EQU "True" (
	if exist "!Destination!" del "!Destination!"
	ECHO -------------------- Generating the !ApplicationName! Binding XML -------------------
	btstask ExportBindings -ApplicationName:"!ApplicationName!" -Destination:"!Destination!"
	IF ERRORLEVEL 1 (
		CALL :OUTPUTERR The !ApplicationName! BTSTask ExportBindings -ApplicationName:"!ApplicationName!" -Destination:"!Destination!" step failed.
		SET CONTINUE=False
	)
	ECHO --------------- Completed generating the !ApplicationName! Binding XML --------------
)

if NOT exist "!Destination!" if "!CONTINUE!" EQU "True" (
	CALL :OUTPUTERR The !ApplicationName! Binding file "!Destination!" was not created during this script.
	SET CONTINUE=False
)

ECHO ########################### Completed !ApplicationName! Script %0 ###############################

GOTO :EOF

:OUTPUTERR
	ECHO ***** ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR *******
	ECHO ***** ERROR ERROR ERROR ERROR !ApplicationName! ERROR ERROR ERROR ERROR ERROR *******
	ECHO.
	ECHO %*
	ECHO Please check the output above for errors.
	ECHO.
	ECHO ***** ERROR ERROR ERROR ERROR !ApplicationName! ERROR ERROR ERROR ERROR ERROR *******
	ECHO ***** ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR *******
GOTO :EOF
