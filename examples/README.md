# Common scenarios in C#

## Prerequisites
- [.NET Core 2.0](https://www.microsoft.com/net/core) or any .NET toolset supporting .NET Core 2.0 projects

## Building and running the C# solution

You can build and run the C# solution in an IDE, or using the .NET Core CLI.

### Using an IDE
1. Open [examples.sln](examples.sln) in your preferred IDE, configured to use the .NET Core Runtime.
2. Run any of the projects in the solution.

### Using the .NET Core CLI
   
```bash
dotnet restore
dotnet run
```

## Running this example in your own SpatialOS project
Building and uploading the assembly of this project is not required to use the example C# code for the scenarios shown here in your own project. However, if you wish to see this example in action for yourself, you can use the pre-built assembly included in this repository to run a deployment on your own SpatialOS project:

1. Modify the `spatialos.json` file in the `blank_project` directory to use the name of your SpatialOS project.
2. Run `spatial cloud upload blank_project` from the `blank_project` directory to upload the pre-built assembly into your project.
3. Modify the required fields in the `Program.cs` file of the example project in the solution you wish to run. These fields are specified in the comments of the file.
4. Follow the steps to run the solution using an IDE or the .NET core CLI.

## Installing C# Platform SDK

* Please see the [SpatialOS documentation](https://docs.improbable.io/reference/latest/platform-sdk/introduction)
