# Learn C# Project

## Summary
- //TODO

## dotnet CLI 
```sh
dotnet new sln -n Learn

dotnet new console  -n Lang
dotnet new console  -n Benchmark
dotnet new classlib -n ExampleLib

dotnet sln add Lang/Lang.csproj
dotnet sln add Benchmark/Benchmark.csproj
dotnet sln add ExampleLib/ExampleLib.csproj

dotnet add Lang/Lang.csproj reference ExampleLib/ExampleLib.csproj

dotnet build
dotnet run --project Learn/Learn.csproj
```