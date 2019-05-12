@echo off
cls
dotnet restore
dotnet build "Surging.Core.Protocol.Mqtt.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.Protocol.Mqtt.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause