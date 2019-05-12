@echo off
cls
dotnet restore
dotnet build "Surging.Core.Redis.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.Redis.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause