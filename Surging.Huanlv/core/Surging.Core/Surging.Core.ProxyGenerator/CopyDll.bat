@echo off
cls
dotnet restore
dotnet build "Surging.Core.ProxyGenerator.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.ProxyGenerator.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause