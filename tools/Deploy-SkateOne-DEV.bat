@echo off

SET MSBUILD_PATH=C:\Program Files (x86)\MSBuild\14.0\Bin
SET WORKSPACE_PATH=%~1

IF [%1] == [] SET WORKSPACE_PATH=C:\Projects\SkateOne

"%MSBUILD_PATH%\MSBuild.exe" "%WORKSPACE_PATH%\src\SkateOne.Web\SkateOne.Web.csproj" /p:Configuration=Debug /p:DeployOnBuild=true /p:VisualStudioVersion=12.0 /p:PublishProfile="%WORKSPACE_PATH%\src\SkateOne.Web\Properties\PublishProfiles\SkateOne-DEV.pubxml"