# 17-11-2017

## Excel/VBA Append Data
```vb
Sub AppendData()

    Dim wbkMaster As Workbook
    Dim shtMaster As Worksheet
    Dim rngMaster As Range
    Dim wbkData As Workbook
    Dim shtData As Worksheet
    Dim rngData As Range
    
' change path and file name to suit
    Set wbkMaster = Workbooks.Open("D:\temp\testmaster.xls")
    Set shtMaster = wbkMaster.Worksheets(1)
    
' change path and file name to suit
    Set wbkData = Workbooks.Open("D:\temp\test1.xls")
    Set shtData = wbkData.Worksheets(1)
    
' get end of master
    Set rngMaster = shtMaster.Range("A65536").End(xlUp)
' get all data cells
    Set rngData = shtData.UsedRange
' copy data across
    rngData.Copy rngMaster
    
    MsgBox "Appended " & rngData.Rows.Count & " rows of data to Master data", vbInformation
    
' simply close data
    wbkData.Close False
' save and close master
    wbkMaster.Close True

'  release objects  
    Set rngData = Nothing
    Set shtData = Nothing
    Set wbkData = Nothing
    Set rngMaster = Nothing
    Set shtMaster = Nothing
    Set wbkMaster = Nothing
End Sub
```

## Links
* https://www.ozgrid.com/forum/forum/help-forums/excel-general/17231-append-data-to-excel-file
* https://github.com/acdvorak/named-pipe-wrapper

[◀ Previous (16-11-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/16/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/November)
[Next (18-11-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/18/notebook.md)