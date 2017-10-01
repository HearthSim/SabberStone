@echo on
set PROJECTDIR=%cd%
echo "%PROJECTDIR%"\Data\CardDefs.xml 

if not exist "%PROJECTDIR%"\Data\CardDefs.xml (
	if not exist "%PROJECTDIR%"\Data (
		mkdir "%PROJECTDIR%"\Data
	)
	git clone https://github.com/HearthSim/hs-data
	copy /y hs-data\CardDefs.xml "%PROJECTDIR%"\Data\CardDefs.xml
	copy /y hs-data\PlayErrors.xml "%PROJECTDIR%"\Data\PlayErrors.xml
	for /d %%p in ("hs-data") do rmdir "%%p" /s /q
)
pause