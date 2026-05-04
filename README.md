# Builder Pattern - Springfield Citizens

Educational example of the Builder Pattern implemented in C# (.NET 10).

## Overview
Builds `SpringfieldCitizen` objects using a `Director` and `ConcreteBuilder` implementations (e.g. `HomerBuilder`, `MrBurnsBuilder`).

## Run
Requirements: .NET 10 SDK

From project folder:

dotnet build dotnet run

## Project layout
- `Director/` — `SpringfieldDirector.cs`
- `Interface/` — `ISpringfieldCitizenBuilder.cs`
- `ConcreteBuilder/` — `HomerBuilder.cs`, `MrBurnsBuilder.cs`
- `DTO/` — `SpringfieldCitizen.cs`
- `Program.cs`