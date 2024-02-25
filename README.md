# Authorization Login and Register System using Entity Framework Identity

## Overview

This project provides a comprehensive example of setting up an Authorization Login and Register System using Entity Framework Identity from .NET8. The system includes user roles, customizable user properties, and follows an N-tier architecture for scalability and maintainability.

* Version of the packages are 8.0.2 (last stable versions of the time I created this project)

## Getting Started

### Database Connection

1. Open the `appsettings.json` file.
2. Add the following connection string format under `"ConnectionStrings"`:

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\Local; Database=YourDatabaseName; Trusted_Connection=True;TrustServerCertificate=True"
    }
    ```

    Replace `YourDatabaseName` with your desired database name.

### Defining User Roles

In the `UserRoles` class, you can define roles for users. They will be automatically added in the database. Modify the roles array to fit your application because in `Program.cs` I have added this code that automatically checks if a role exists and if not it will create it.

```csharp
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { UserRoles.Admin, UserRoles.DeliveryEmployee, UserRoles.User };
    
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
            await roleManager.CreateAsync(new IdentityRole(role));
    }
}
```

### Customizing User Properties

The `AppUser` class inherits from IdentityUser and serves as the user model. You can add custom properties:

```csharp
 public class AppUser:IdentityUser
 {
     [StringLength(100)]
     [MaxLength(100)]
     [Required]
     public string? Name { get; set; }
 }
```

### N-Tier Architecture
This project follows an N-tier architecture for enhanced modularity and maintainability.

### Creating the Database
To create the database:

1. Open Package Manager Console in Visual Studio.

2. Set the default project to IdentityExample.DataAccess.

3. Run:

```bash
add-migration <any_name_you_want>
update-database
```

# Examples

You have pretty much any example you need for a basic authorization system added in the `AccountController`, and some Register and Login Views that will help you better understand how everything works.

# Conclusion

Congratulations! You have successfully configured an Authorization Login and Register System using Entity Framework Identity. If you encounter any issues or have questions, refer to the GitHub repository for support or message me on my personal email or any another social media account specified.