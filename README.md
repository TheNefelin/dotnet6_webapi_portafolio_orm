# dotnet6_webapi_portafolio_orm

### 1.- Web Api Project
* NuGet dependency 
```
Dapper
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Proxies
```

* Project dependency 
```
db_portafolio
```

### 2.- DB Library Project
* NuGet dependency 
```
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

### Some configs

* Rename appsettings.json.txt file to appsettings.json and add the connections, here some examples
```
"ConnectionStrings": {
    "RutaWebSQL": "Data Source=server_name; Initial Catalog=sql_name; User ID=user_name; Password=user_password;",
    "RutaLocalSQL1": "Data Source=server_name; Initial Catalog=sql_name; User ID=user_name; Password=user_password; MultipleActiveResultSets=True; TrustServerCertificate=True;",
    "RutaLocalSQL2": "Server=server_name; Database=sql_name; Trusted_Connection=True; MultipleActiveResultSets=True; TrustServerCertificate=True;"
  }
```

* Create Dependency injection on Program.cs file with "RutaWebSQL", "RutaLocalSQL" or "RutaLocalSQL2"
```
builder.Services.AddDbContext<PortafolioContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RutaLocalSQL"));
});
```

* Create Scope for building the DataBase Tables on Program.cs file
```
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<PortafolioContext>();
    context.Database.Migrate();
}
```

### Define as Initial Project where you have the Context

1. right click on dotnet6_webapi_portafolio_orm
2. Set as startup project
3. Select db_portafolio on Package Manager Console
4. Make sure that your Project is compilated
5. Type "Add-Migration InitDB" in the console (Package Manager Console)
6. If you follow everything, you should have a new folder call Migrations on db_portafolio

> [!NOTE]
> For display data like api, add new blank api controller and add connection for dapper, example: DataController.cs

### 3.- SQL file do the same thing and more
[SQL file repository](https://github.com/TheNefelin/SQLServer)
