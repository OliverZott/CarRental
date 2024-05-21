# Car Rental Solution

## Run application

### Locally

Prerequisites:

- .NET 8 SDK
- Postgresql

In IDE or in CLI:

1. Run application with IIS in Rider or VS 2022. Browser will open with https://localhost:44335/swagger/index.html
2. via CLI: `dotnet run --project .\CarRental\CarRental.API\CarRental.API.csproj`

Check:

- Swagger: http://localhost:5043/swagger/index.html
- API: http://localhost:5043/api/car

### Docker Compose

Prerequisites:

- Docker

Run in CLI:

1. Run `docker-compose up` in the root folder

## DB Migrations

````bash
Add-Migration MigrationDescription
Update Database

````

## TODOs:

- Pattern: CQRS / UoW + Repository
- DTOs
- Tests
- Logging
- Global Exception Handling Middleware