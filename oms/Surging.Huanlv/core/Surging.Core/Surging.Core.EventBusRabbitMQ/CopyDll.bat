@echo off
cls
dotnet restore
dotnet build "Surging.Core.EventBusRabbitMQ.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.EventBusRabbitMQ.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause