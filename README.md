# SMM — Social Media for Musicians

A web-based social network for musicians and music communities.

> **Status:** early development.

## Tech Stack

- C#, ASP.NET Core Web API (.NET 10)

## Project Structure

```
backend/
  src/
    SMM.Api        — REST API, controllers
    SMM.Services   — business logic
    SMM.Data       — data access
  tests/           — tests
frontend/          — client application
```

## Getting Started

**Prerequisites:** .NET 10 SDK

```bash
cd backend
dotnet restore
dotnet run --project src/SMM.Api
```
