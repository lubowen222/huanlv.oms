@echo off
cls
dotnet restore
dotnet build "Surging.Core.ServiceHosting.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.ServiceHosting.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause