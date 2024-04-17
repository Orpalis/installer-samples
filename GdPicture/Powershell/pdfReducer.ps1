
param(
    [string] $filePath
)
    
if (!$filePath -or (Test-Path $filePath) -eq $false) {
    throw "no filepath has been provided or is invalid";
}

# Since Save-Package and Install-Package is going into circular dependency (with v2 and v3 package source), we've to levarge the dotnet package resolver with a dummy project and use the compiled assembly from there

if ((Test-Path ./Assemblies) -eq $false) {
    Write-Progress -Activity "Retreive GdPicture" -Status "Create project and download NuGet package" -PercentComplete 20

    dotnet new console -o temp | Out-Null

    dotnet add ./temp/temp.csproj package GdPicture.API | Out-Null

    Write-Progress -Activity "Retreive GdPicture" -Status "Build project" -PercentComplete 80

    dotnet build ./temp/temp.csproj -c Release --ucr | Out-Null # UCR will enable to only get the runtimes for the current system where the script is running 

    Copy-Item -Recurse /Users/oli/Downloads/pdfReducer/temp/bin/Release/net8.0/* ./Assemblies/ | Out-Null


    Remove-Item -Force -Recurse temp | Out-Null

    Write-Progress -Activity "Retreive GdPicture" -Completed
}

Add-Type -Path ./Assemblies/GdPicture.NET.14.API.dll

[GdPicture14.LicenseManager]::new().RegisterKEY("INSERT LICENSE KEY HERE") | Out-Null

$reducerConfiguration = [GdPicture14.PDFReducerConfiguration]::new();

$reducerConfiguration.EnableMRC = $true;

$reducer = [GdPicture14.GdPicturePDFReducer]::new();

$reducer.PDFReducerConfiguration = $reducerConfiguration; 
$reducer.ProcessDocument($filePath, "$([System.IO.Path]::GetDirectoryName($filePath))/reduced.pdf");

