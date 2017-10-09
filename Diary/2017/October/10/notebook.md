# 10-10-2017

## Excel/VBA Get Selected Row and Column
Used to get the active row.
```vb
' Get the selected row
Dim RowNum As Integer
RowNum = Target.Row

' Get the selected column
Dim ColNum As Integer
ColNum = Target.Column
```
Reference: https://msdn.microsoft.com/en-us/vba/excel-vba/articles/range-row-property-excel