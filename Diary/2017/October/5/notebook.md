# 5-10-2017

## VBA/Excel Detect change in a given cell

```vb
Private Sub Worksheet_Change(ByVal Target As Range)
    Dim KeyCells As Range

    ' The variable KeyCells contains the cells that will
    ' cause an alert when they are changed.
    Set KeyCells = Range("A1")
    
    If Not Application.Intersect(KeyCells, Range(Target.Address)) _
           Is Nothing Then

        ' Display a message when one of the designated cells has been
        ' changed.
        ' Place your code here.
        MsgBox "Cell " & Target.Address & " has changed."
       
    End If
End Sub
```

## VBA code doesn't run when cell is changed by a formula
Use the Calculate event of the worksheet.
```vb
Private Sub Worksheet_Calculate()
    ' read the updates
End SUb
```

## C# / VB App.Config change value
Save value to app.config
```csharp
Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
configuration.AppSettings.Settings["key"].Value = "value";
configuration.Save();

ConfigurationManager.RefreshSection("appSettings");
```
Read value from app.config
```csharp
var value = ConfigurationManager.AppSettings["key"];
```
Code in app.config
```xml
  <appSettings>
    <add key="key" value="value"/>
  </appSettings>
```