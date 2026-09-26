# Boardgame Management API

This project is a personal ASP.NET Core API focused on board game management. I built it as a way to explore clean backend architecture, REST API design, and domain-driven development in a practical project.

The goal is to create a simple but structured system for working with board game data, collections, and future features such as metadata, ownership tracking, and gameplay-related information.

## What this project covers

- ASP.NET Core Web API setup
- layered project organization
- separation of concerns across API, domain, core, and infrastructure
- a clean foundation for future CRUD operations and business logic
- a practical example of building a backend around a hobby or domain-specific use case

## Project structure

- `Boardgame-Management.Api` - API entry point and endpoint setup
- `Boardgame-Management.Core` - application logic and orchestration
- `Boardgame-Management.Domain` - domain models and business concepts
- `Boardgame-Management.Infrastructure` - supporting services and data-related concerns

## Tech stack

- .NET 9
- ASP.NET Core

## Running locally

```bash
dotnet restore
dotnet build
dotnet run --project Boardgame-Management.Api
```

## Notes

This project is meant to demonstrate a clean API structure and a simple domain-driven approach for managing board game data and future functionality. It is a foundation project rather than a finished product, but it is structured in a way that makes it easy to grow into a more complete board game management system over time.
