# 27-10-2017

## ASP.NET get ApplicationUserManager
```csharp
var userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
```

## ASP.NET get RoleManager
```csharp
var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
```

[◀ Previous (26-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/26/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (28-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/28/notebook.md)