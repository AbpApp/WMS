# 指定要操作的文件路径，数据库合并工程的父目录D:\wwwroot\
$currentRootDir = "D:\release\"
# 获取该目录内的所有文件夹
$migratorDirs = Get-ChildItem -Filter "*DbMigrator*" -Path $currentRootDir
# Set-Location $currentRootDir
foreach ($migratorDir in $migratorDirs) {    
    if(($migratorDir.Name).Contains("DbMigrator")){
        $currentMigratorDir = (Join-Path $currentRootDir $migratorDir)
        Write-Host ("currentMigratorDir:"+$currentMigratorDir)
        Set-Location $currentMigratorDir
    # 获取数据库合并程序exe，.DbMigrator.exe结尾的文件就是数据库合并程序
        $migratorFiles = Get-ChildItem $currentMigratorDir -recurse *.exe | %{$_.FullName}
        foreach ($migratorFile in $migratorFiles)
        {
            Write-Host ("migratorFilePaht:"+$migratorFile)
            # 执行数据库合并程序exe
            Start-Job -ScriptBlock { & $migratorFile } -Name $migratorDir            
            Set-Location $currentRootDir
        }
        if (-Not $?) {
            Write-Host ("Publish failed for the host: " + $hostPath)
            Set-Location $rootFolder
            exit $LASTEXITCODE
        }
    }
}