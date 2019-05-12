@echo off
cls
dotnet restore
dotnet build "Surging.Core.KestrelHttpServer.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.KestrelHttpServer.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause