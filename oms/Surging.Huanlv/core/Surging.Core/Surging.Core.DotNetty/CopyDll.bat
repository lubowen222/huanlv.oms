@echo off
cls
dotnet restore
dotnet build "Surging.Core.DotNetty.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.DotNetty.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause