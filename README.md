ASP.NET Core MVC Order Processing Application
Overview
This is a simple ASP.NET Core MVC application that processes customer orders. It applies a 10% discount if the customer is 'Loyal' and the order amount is $100 or more.
Prerequisites
- .NET 6 SDK or later
- Visual Studio 2022 or later
- SQL Server (if using a database)
How to Run
1. Clone the repository:
   ```sh
   git clone https://github.com/Mohdsaif398/AssignmentSubmission.git 
2. Build the application:
   ```sh
   dotnet build
   ```
3. Run the application:
   ```sh
   dotnet run
   ```
4. Open a web browser and go to:
   ```
   https://localhost:5001/Order/Index
   ```
Testing
Run unit tests using xUnit:
   ```sh
   dotnet test
