# NOT ORIGINAL!

## this tutorial is from Jeremy Buisson [Link](https://itnext.io/net-core-is-sexy-real-world-part-1-command-line-application-953f48394c83)

## instructions used in this tutorial:
1.  `dotnet new console -o Curator`
1.  `dotnet add package McMaster.Extensions.CommandLineUtils
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design`
1. `dotnet ef migrations add InitialCreate
dotnet ef database update`
2. `dotnet run add medium.com/@jbuisson
dotnet run add blog.cleancoder.com
dotnet run list
dotnet run remove 1
dotnet run list`
3. `cd src/Curator.Data/Curator.Data.EntityFramework
dotnet new classlib -o Curator.Data.EntityFramework.Memory
cd Curator.Data.EntityFramework.Memory
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add reference ../Curator.Data.EntityFramework/Curator.Data.EntityFramework.Context/`
4. `cd tests
dotnet new xunit -o Curator.Console.Tests`
2. `dotnet add reference ../../src/Curator.Console
dotnet add reference ..\..\src\Curator.Data\Curator.Data.EntityFramework\Curator.Data.EntityFramework.Memory\Curator.Data.EntityFramework.Memory.csproj`
3. `dotnet publish src/Curator.Console -c Release — self-contained true -r [YOUR_RUNTIME_IDENTIFIER] -o [INSTALLATION_PATH]`

## Commands I used:
1. `dotnet publish -r win-x64 --self-contained true`
