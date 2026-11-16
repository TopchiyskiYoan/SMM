# SMM — Social Media for Musicians

A web-based social network for musicians and music communities.

> **Status:** early development.

## Tech Stack

- C#, ASP.NET Core Web API (.NET 10)
- Microsoft SQL Server, Entity Framework Core 10 (Code First)
- ASP.NET Core Identity

## Project Structure

```
backend/
  src/
    SMM.Api        — REST API, controllers
    SMM.Services   — business logic
    SMM.Data       — data access: DbContext, entities, migrations, seeding
  tests/           — tests
frontend/          — client application
```

## Database

Tables: `AspNetUsers` (Identity), `UserProfiles`, `Tracks`, `Posts`, `Groups`, `GroupMembers`, `Follows`, `Conversations`, `ConversationMembers`, `Messages`.

Seeded roles: `Musician`, `Producer`, `Studio`, `Administrator`.

## Getting Started

**Prerequisites:** .NET 10 SDK, SQL Server

```bash
cd backend
dotnet tool restore

# Configure the connection string (stored outside the repository)
dotnet user-secrets set "ConnectionStrings:DefaultConnection" \
  "Server=.;Database=SMM;Trusted_Connection=True;TrustServerCertificate=True" \
  --project src/SMM.Api

# Create the database
dotnet ef database update --project src/SMM.Data --startup-project src/SMM.Api

# Run the API
dotnet run --project src/SMM.Api
```
