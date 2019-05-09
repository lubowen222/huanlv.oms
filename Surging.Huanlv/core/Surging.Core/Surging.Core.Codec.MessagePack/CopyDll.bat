@echo off
cls
dotnet restore
dotnet build "Surging.Core.Codec.MessagePack.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.Codec.MessagePack.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause