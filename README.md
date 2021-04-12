# SampleCQRS-MediatR-CleanArchitecture
This is a sample CQRS implementation with MediatR and Clean Architecture

## Architecture And Design Patterns Which Have Been Used :
* Clean architecture
* CQRS
* Unit Of Works

## Technologies and Libraries Which Have Been Used :
* Asp.net Core 5 MVC
* Entity Framework Core
* MediatR
* SQL Server for database
* Swashbuckle (For API documentation based on Swagger and OpenAPI specification)
* AutoMapper

## How to start it : 
* First of all, You have to create a database which name is **SampleCQRS**
* after being sure from creating a database, You have to run this command **dotnet ef --startup-project SampleCQRS.WebApi/SampleCQRS.WebApi.csproj migrations add InitialModel -p SampleCQRS.Persistence/SampleCQRS.Persistence.csproj** in the directory where the **SampleCQRS.sln** is located to create the initial migration.
* at last, run this command **dotnet ef --startup-project SampleCQRS.WebApi/SampleCQRS.WebApi.csproj database update** in the directory where the **SampleCQRS.sln** is located to create your tables.
* Open the project solution with visual studio and **press F5**.


