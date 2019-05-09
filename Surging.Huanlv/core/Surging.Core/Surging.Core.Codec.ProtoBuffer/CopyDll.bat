@echo off
cls
dotnet restore
dotnet build "Surging.Core.Codec.ProtoBuffer.csproj"  --configuration Release 
copy  bin\Release\netcoreapp2.1\Surging.Core.Codec.ProtoBuffer.dll ..\..\..\applib\3rdlib\surging\/y
echo Ö´ÐÐÍê³É
pause