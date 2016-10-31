@ECHO OFF
CLS

..\source\.nuget\nuget Pack iTin.Export.Core.1.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget
..\source\.nuget\nuget Pack iTin.Export.Writers.Adobe.1.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget
..\source\.nuget\nuget Pack iTin.Export.Writers.OpenXml.DocX.1.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget
..\source\.nuget\nuget Pack iTin.Export.Writers.OpenXml.Xlsx.1.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget



