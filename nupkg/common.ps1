# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of solutions
$solutions = (
	"modules/Hd.Container"
)

# List of projects
$projects = (
	"modules/Hd.Container/src/Hd.Container.Application",
	"modules/Hd.Container/src/Hd.Container.Application.Contracts",
	"modules/Hd.Container/src/Hd.Container.Domain",
	"modules/Hd.Container/src/Hd.Container.Domain.Shared",
	"modules/Hd.Container/src/Hd.Container.EntityFrameworkCore",
	"modules/Hd.Container/src/Hd.Container.HttpApi",
	"modules/Hd.Container/src/Hd.Container.HttpApi.Client"
)