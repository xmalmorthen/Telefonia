
rem set msbuildexe=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe

set builddir=GSM-MONOv4.5
mkdir .\%builddir% 
del /q /s .\%builddir%\*.*

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe /fl /flp:LogFile="..\Build\%builddir%\build-mono.log";Append;errorsonly /nologo /p:WarningLevel=0;Optimize=True;OutputPath="..\Build\%builddir%";Platform=AnyCPU;DefineConstants="MONO;SQLite";TargetFrameworkVersion=v4.0 /clp:Verbosity=m; /t:Rebuild /p:Configuration=Release ..\GSMApplication\GSMApplication.csproj

if "%1"=="nopause" goto end
pause
:end