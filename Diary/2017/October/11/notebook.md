# 11-10-2017

## Parameterized ADO Query Using VBA
https://support.microsoft.com/en-us/help/181734/how-to-invoke-a-parameterized-ado-query-using-vba-c-java
```vb
Dim Conn1 As ADODB.Connection
Dim Cmd1 As ADODB.Command
Dim Param1 As ADODB.Parameter
Dim Rs1 As ADODB.Recordset

Dim i As Integer

' Trap any error/exception.
On Error Resume Next

' Create and Open Connection Object.
Set Conn1 = New ADODB.Connection
Conn1.ConnectionString = "DSN=Biblio;UID=admin;PWD=;"
Conn1.Open

' Create Command Object.
Set Cmd1 = New ADODB.Command
Cmd1.ActiveConnection = Conn1
Cmd1.CommandText = "SELECT * FROM Authors WHERE AU_ID < ?"

' Create Parameter Object.
Set Param1 = Cmd1.CreateParameter(, adInteger, adParamInput, 5)
Param1.Value = 5
Cmd1.Parameters.Append Param1
Set Param1 = Nothing

' Open Recordset Object.
Set Rs1 = Cmd1.Execute()
```


[<< Previous (10-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/10/notebook.md) - 
[Next (12-10-2017) >>](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/12/notebook.md)