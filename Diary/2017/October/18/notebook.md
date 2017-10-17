# 18-10-2017

## .NET: How do I find the PublicKeyToken for a particular dll?
Using PowerShell
```powershell
([system.reflection.assembly]::loadfile("c:\MyDLL.dll")).FullName
```



[◀ Previous (17-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/17/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (19-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/19/notebook.md)