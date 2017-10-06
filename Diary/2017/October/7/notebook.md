# 7-10-2017

## C# Change printer page size
```csharp
PrintDocument pd = new PrintDocument();
pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 840, 1000);
```