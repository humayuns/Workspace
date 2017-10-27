# 27-10-2017

## ASP.NET get ApplicationUserManager
```csharp
var userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
```

## ASP.NET get RoleManager
```csharp
var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
```

## Smalltalk: Block and Parameter to Block
```smalltalk
work := [:x| Transcript show: x; cr.].
1 to: 10 do: [:x| work value: x.].
```
Output
```
1
2
3
4
5
6
7
8
9
10
```

## Links
* https://stackoverflow.com/questions/3874279/the-role-manager-feature-has-not-been-enabled
* https://docs.microsoft.com/en-us/aspnet/web-forms/overview/security/create-a-secure-aspnet-web-forms-app-with-user-registration-email-confirmation-and-password-reset
* https://docs.microsoft.com/en-us/aspnet/web-forms/overview/getting-started/getting-started-with-aspnet-45-web-forms/membership-and-administration



[◀ Previous (26-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/26/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (28-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/28/notebook.md)