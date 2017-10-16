# 16-10-2017

## Convert List(of object) to List(of string)
```csharp
var stringList = myList.OfType<string>();

// or
var stringList = myList.Select(i => i.ToString());
```

## C# comparing two string arrays
```csharp
bool areEqual = a.SequenceEqual(b);
```
## C++/CLI initialize new array
```cpp
array<String^>^ strarray = gcnew array<String^>(x);
```


[◀ Previous (15-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/15/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (17-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/17/notebook.md)