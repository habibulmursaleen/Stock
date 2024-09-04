# Finance API Project

This is a simple Finance API built using .NET 8. The API interacts with a SQL Server database to manage financial data such as stock information and related comments.

## Prerequisites

Before you can run this project, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS) or Azure Data Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

## Getting Started

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/habibulmursaleen/Stock-api.git
   cd stock-api
   ```


Restore NuGet Packages:

Run the following command to restore the necessary NuGet packages:

```bash
dotnet restore
```

Set Up the Database:

Make sure your SQL Server instance is running. Update the appsettings.json file in the project to point to your SQL Server instance:

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME or <localhost>;Database=FinShark;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
}
```

Apply Migrations and Update the Database:

```bash
dotnet ef migrations add init
```

Use the following command to apply the existing migrations and update the database:

```bash
dotnet ef database update
```

Seeding the Database:

After the database has been created, you can seed it with initial data. Use the provided SQL commands to insert the data into the Stocks and Comments tables.

```sql
INSERT INTO [FinShark].[dbo].[Stocks] ([Symbol], [CompanyName], [Price], [LastDiv], [Industry], [MarketCap])
VALUES 
('AAPL', 'Apple Inc.', 174.55, 0.22, 'Technology', 2800000000000),
('MSFT', 'Microsoft Corporation', 315.75, 0.62, 'Technology', 2400000000000),
('TSLA', 'Tesla Inc.', 780.20, 0.00, 'Automotive', 900000000000),
('AMZN', 'Amazon.com Inc.', 134.45, 0.00, 'Consumer Discretionary', 1700000000000),
('GOOGL', 'Alphabet Inc.', 2745.30, 0.00, 'Technology', 1800000000000);

INSERT INTO [FinShark].[dbo].[Comments] ([Title], [Content], [CreatedOn], [StockId])
VALUES 
('Great Stock', 'Apple is performing very well this quarter!', '2024-09-01', 1),
('Strong Buy', 'Microsoft is expected to grow with its cloud services.', '2024-09-02', 2),
('Risky Investment', 'Tesla’s volatility makes it a risky investment.', '2024-09-03', 3),
('E-commerce King', 'Amazon continues to dominate the e-commerce space.', '2024-09-01', 4),
('Tech Giant', 'Alphabet is leading in the AI space.', '2024-09-02', 5);
```

Run the Application:

Start the API using the following command:

```bash
dotnet watch
```

The API should now be running and accessible at https://localhost:5254. 



Project Structure:

- Controllers: This folder contains the API controllers that handle HTTP requests.
- Models: This folder contains the entity classes representing the database tables.
- Data: This folder contains the database context class that manages the database connection.
- Migrations: This folder contains the Entity Framework migrations.

Additional Commands:

```bash
dotnet ef migrations add init
```

Add a Migration:

To add a new migration, run the following command:

```bash
dotnet ef migrations add MigrationName
```

Remove Last Migration:

To remove the last migration, use:

```bash
dotnet ef migrations remove
```

Update the Database:

Apply any pending migrations to the database with:

```bash
dotnet ef database update
```








































































