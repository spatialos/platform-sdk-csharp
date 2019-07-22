# Common scenarios in C#

## Prerequisites
- [.NET Core 2.0](https://www.microsoft.com/net/core) or any .NET toolset supporting .NET Core 2.0 projects

## Building and running the C# solution

You can build and run the C# solution in an IDE, or using the .NET Core CLI. You will need to change the `RefreshToken` in the `Program.cs` file of the project you want to run.

### Using an IDE
1. Open [examples.sln](examples.sln) in your preferred IDE, configured to use the .NET Core Runtime.
2. Run any of the projects in the solution.

### Using the .NET Core CLI
   
```bash
dotnet restore
dotnet run
```

## Running an example in your own project
It is not required to build and upload an assembly to run the solution, as they run in the `platform_sdk_examples` project which already contains the assembly.

However, if you wish to see an example in action on your own project, you can upload and use the pre-built assembly included in this repository to run a deployment:
1. Modify the `spatialos.json` file in the `blank_project` directory to use the name of your project.
2. Run `spatial cloud upload blank_project` from the `blank_project` directory to upload the pre-built assembly into your project.
3. Modify the fields in the `Program.cs` file of the example project in the solution you wish to run. Usually only `ProjectName` and `RefreshToken` are required, but other modifiable fields are specified in the comments of the file.
4. Follow the steps to run the solution using an IDE or the .NET core CLI.

## Installing C# Platform SDK

* Please see the [SpatialOS documentation](https://docs.improbable.io/reference/latest/platform-sdk/introduction)
