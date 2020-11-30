# LordLamington.Heartcore

A website built for Lord Lamington with [StazorPages](https://github.com/emmanueltissera/stazorpages) and [StazorPages.Heartcore](https://github.com/emmanueltissera/stazorpages.heartcore).

This website is a demo site which allows for the creation of static HTML pages using [ASP.NET Core 5.0](https://docs.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-5.0) with [Umbraco Heartcore](https://umbraco.com/products/umbraco-heartcore/).

## Prerequisites

* Visual Studio 2019 version 16.8.2 or higher 
* OR Visual Studio Code 1.51.1 or higher
* OR .NET Core CLI Host 5.0.0 or higher 
* .NET SDK 5.0.100
* Microsoft.AspNetCore.App 5.0.0 Runtime
* Microsoft.NETCore.App 5.0.0 Runtime

## Getting Started

Once you have cloned this repo, complete the following steps:

### With Visual Studio 2019

* Open the solution with `LordLamington.Heartcore.sln`.
* In Solution Explorer, right-click the solution and select `Restore NuGet Packages`.
* Run the solution using `IIS Express` 

### With Visual Studio Code

* Open the root folder with VS Code
* Press F5 to debug and run

### With .NET Core CLI

* Switch to the root of your cloned project
* Run the project using `dotnet run --project LordLamington.Heartcore.WebApp\LordLamington.Heartcore.WebApp.csproj`

## Sample Site

Once the solution is running, you can visit multiple pages from the website navigation and see corresponding static files created inside `AppData\Pages` folder on your local machine.

### Running with IIS Express

* [https://localhost:44340/](https://localhost:44340/)

### Running with Kestrel

* [https://localhost:5001/](https://localhost:5001/)


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)