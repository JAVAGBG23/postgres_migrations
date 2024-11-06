# OBS! Endast en guide kansk inte funkar rakt av, jag  har tagit hjälp av ChatGpt pro...
Ändra inte [Column(TypeName = "jsonb")] på User roles då jag tror att det ska lösa att man slipper ändra så mycket i koden. Rollerna ska nog då funka som det gjord emed MongoDB.

## 1. Choose a Cloud PostgreSQL Provider
## 2. Set Up a Cloud-Based PostgreSQL Instance
## 3. Update appsettings.json with the Cloud PostgreSQL Connection String
Replace your existing local PostgreSQL connection string with the one provided by your cloud provider.
## 4. Update Program.cs for PostgreSQL Configuration
See program.cs
## 6. Handle Database Migrations
Ensure that your cloud PostgreSQL database is in sync with your application's data models.
Run: **dotnet ef migrations add InitialCreate** **kod dotnet ef database update**
## 7. Create Data folder and ApplicationDbContext.cs (see code)
## 8. Update Models and UserService
