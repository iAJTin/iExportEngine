@ECHO OFF
CLS

..\source\.nuget\nuget Pack iTin.Export.Core.2.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget
..\source\.nuget\nuget Pack iTin.Export.Writers.Adobe.2.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget
..\source\.nuget\nuget Pack iTin.Export.Writers.OpenXml.DocX.2.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget
..\source\.nuget\nuget Pack iTin.Export.Writers.OpenXml.Xlsx.2.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget



