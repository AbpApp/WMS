. ".\common.ps1"

# Rebuild all solutions
foreach($solution in $solutions) {
    $solutionFolder = Join-Path $rootFolder $solution
    Write-Host ("rootFoldersolution: " + $solutionFolder)
    Set-Location $solutionFolder
    & dotnet restore
}

# Create all packages
foreach($project in $projects) {
    
    Write-Host ("project: " + $project)
    $projectFolder = Join-Path $rootFolder $project

    Write-Host ("projectFolder: " + $projectFolder)
    # Create nuget pack
    Set-Location $projectFolder
    if(Test-Path (Join-Path $projectFolder "bin/Release"))
    {
       Remove-Item -Recurse (Join-Path $projectFolder "bin/Release")
    }
    & dotnet msbuild /t:Publish /p:Configuration=Release /p:SourceLinkCreate=false

    if (-Not $?) {
        Write-Host ("Packaging failed for the project: " + $projectFolder)
        exit $LASTEXITCODE
    }
    
    # Copy nuget package
    Write-Host ("projectprojectName1: " + $project)
    $projectName = $project.Substring($project.LastIndexOf("/") + 1)
    Write-Host ("projectprojectName2: " + $projectName)
    $projectPackPath = Join-Path $projectFolder ("/bin/Release/" + $projectName + ".*.nupkg")
    Write-Host ("projectPackPath: " + $projectPackPath)
    Write-Host ("packFolder: " + $packFolder)
    $targetNupkg = Join-Path $packFolder ("" + $projectName + ".*.nupkg")
    Write-Host ("targetNupkg: " + $targetNupkg)
    if(Test-Path ($targetNupkg))
    {
       Remove-Item -Recurse ($targetNupkg)
    }
    Move-Item $projectPackPath $packFolder

}

# Go back to the pack folder
Set-Location $packFolder