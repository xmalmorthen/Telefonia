rem set msbuildexe=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
set builddir=CELLTRACKER
mkdir .\%builddir% 
del /q /s .\%builddir%\*.*
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe /fl /flp:LogFile="..\Build\%builddir%\build-mono.log";Append;errorsonly /nologo /p:WarningLevel=0;Optimize=True;OutputPath="..\Build\%builddir%";Platform=AnyCPU;TargetFrameworkVersion=v4.5 /clp:Verbosity=m; /t:Rebuild /p:Configuration=Release ..\CellTrack\CellTrack.csproj