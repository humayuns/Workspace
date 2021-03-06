## How to pass query string parameter in ActionLink in MVC :white_check_mark:


4th parameter of Html.ActionLink can have any number of properties:

```c#
<%= Html.ActionLink("Check this", "Edit", "test", 
                     new { id = id, data=name }, new { style = "display:block" })%>
```                     
These properties are inserted into URL based on routing, but if the property name cannot be matched into any route it is added as URL GET parameter.

So if you have standard route {controller}/{action}/{id}, you will get the URL:

```
test/Edit/[id]?data=[name] 
```
from the above code.


## Smalltalk Hello World

```smalltalk
Transcript show:'Hello, World!'.
```

## How to run a macro when certain cells change in Excel
https://support.microsoft.com/en-in/help/213612/how-to-run-a-macro-when-certain-cells-change-in-excel

```vb
Private Sub Worksheet_Change(ByVal Target As Range)
    Dim KeyCells As Range

    ' The variable KeyCells contains the cells that will
    ' cause an alert when they are changed.
    Set KeyCells = Range("A1:C10")
    
    If Not Application.Intersect(KeyCells, Range(Target.Address)) _
           Is Nothing Then

        ' Display a message when one of the designated cells has been 
        ' changed.
        ' Place your code here.
        MsgBox "Cell " & Target.Address & " has changed."
       
    End If
End Sub
```


## Excel VBA get range of user selected range by mouse

```vb
Sub macro1()
  MsgBox Selection.Address(ReferenceStyle:=xlA1, _
                           RowAbsolute:=False, ColumnAbsolute:=False)
End Sub
```

## Font Class in C#
Defines a particular format for text, including font face, size, and style attributes. This class cannot be inherited.
```csharp
private void ComboBox1_SelectedIndexChanged(System.Object sender, 
    System.EventArgs e)
{

    // Cast the sender object back to a ComboBox.
    ComboBox ComboBox1 = (ComboBox) sender;

    // Retrieve the selected item.
    string selectedString = (string) ComboBox1.SelectedItem;

    // Convert it to lowercase.
    selectedString = selectedString.ToLower();

    // Declare the current size.
    float currentSize;

    // Switch on the selected item. 
    switch(selectedString)
    {

            // If Bigger is selected, get the current size from the 
            // Size property and increase it. Reset the font to the
            //  new size, using the current unit.
        case "bigger":
            currentSize = Label1.Font.Size;
            currentSize += 2.0F;
            Label1.Font = new Font(Label1.Font.Name, currentSize, 
                Label1.Font.Style, Label1.Font.Unit);

            // If Smaller is selected, get the current size, in points,
            // and decrease it by 1.  Reset the font with the new size
            // in points.
            break;
        case "smaller":
            currentSize = Label1.Font.SizeInPoints;
            currentSize -= 1;
            Label1.Font = new Font(Label1.Font.Name, currentSize, 
                Label1.Font.Style);
            break;
    }
}
```

## Convert JSON to object of given type in C#
https://stackoverflow.com/questions/37672423/deserialize-json-array-with-json-net-from-url
```csharp
var machine = JsonConvert.DeserializeObject<List<MachineJson>>(json);
```

## How to get a json string from url?

```csharp
var json = new WebClient().DownloadString("url");
// or
using (WebClient wc = new WebClient())
{
   var json = wc.DownloadString("url");
}
```


## C# function to create a Font.
```csharp
private static Font CreateFont(float size, FontStyle style)
{
    var fontMono = new Font(FontFamily.GenericMonospace, 10);
    var font = new Font(fontMono, style);
    return font;
}
```


## C#: Open existing file, append a single line

```csharp
File.AppendAllText(@"c:\path\file.txt", "text content" + Environment.NewLine);
```

## C#: Open existing file and read all lines

```csharp
foreach (var line in File.ReadLines("Filename"))
{
    // ...process line.
}

// read all file
var lines = File.ReadAllLines("Filename")

```