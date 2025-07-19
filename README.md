# RESTApi

Sample REST API built with ASP.NET Core targeting .NET 9.

## Building and Running

Use the .NET SDK 9.0 to build and run the project:

```
dotnet build EmployeeApi.sln
dotnet run --project src/EmployeeApi/EmployeeApi.csproj
```

The API exposes two unauthenticated GET endpoints:

- `GET /api/employees` returns all employees.
- `GET /api/employees/{id}` returns a single employee by id.
