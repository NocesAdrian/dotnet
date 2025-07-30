## install dotnet core SDK
```bash
sudo pacman -S dotnet-sdk
```

## creates project
```bash
// creates teminal based or console based project
dotnet new console -o projectName

// creates avaloniaUI project
dotnet new avalonia.mvvm -o projectName

or (not recommended)

dotnet new avalonia.app -o projectName
```

## run project
```bash
cd projectName
dotnet run

// run project from diffirent directory
dotnet run --project /path/to/project
```

## build project to an lone executable
```bash
cd projectName
dotnet publish -c release -r linux-x64 --self-contained true /p:PublishSingleFIle=true
```
```bash
publish:
    build the project

-c release:
    build in release mode optimized no debug trash

-r linux-x64:
    runtime on x64 linux for arm use (linux-arm64)

--self-contained true:
    includes .NET runtime inside the build so your Os does not need to install .NET runtime

/p:PublishSingleFile=true:
    make the build on single executabel file

/p:PublishTrimmed=true:
    trim dll and only recommended on console project
```
