@ECHO OFF
:: Make sure that the NuGet command line executable is in your PATH or edit this batch file.
NUGET pack ..\Syroot.Windows.IO.KnownFolders\Syroot.Windows.IO.KnownFolders.csproj -Prop Configuration=Release -Build