# 19-10-2017

## VBScript Get Short File/Folder Name
```vb
set fso = CreateObject("Scripting.FileSystemObject") 
 
strLongName = Wscript.Arguments(0)
strShortName = "Invalid File/Folder - (" & strLongName & ")"
Set fsoFile = Nothing
 
On Error Resume Next
 
Set fsoFile = fso.GetFile(strLongName)
 
if Err.number <> 0 then
	Set fsoFile = fso.GetFolder(strLongName)
end if
 
if fsoFile is not nothing then
	strShortName = fsoFile.ShortPath
end if
Wscript.Echo strShortName
```
Example
```
> cscript shortname.vbs "C:\Program Files\Adobe\Reader 9.0\Reader\AcroRd32.exe"
> C:\PROGRA~1\Adobe\READER~1.0\Reader\AcroRd32.exe
```

## Get the current temporary directory path in VBScript?
```vb
WScript.CreateObject("Scripting.FileSystemObject").GetSpecialFolder(2)
```

## VB CopyFile Method
```vb
FileSystemObject.CopyFile "c:\mydocuments\letters\*.doc", "c:\tempfolder\"
```



[◀ Previous (18-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/18/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (20-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/20/notebook.md)