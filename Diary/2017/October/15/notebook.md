# 15-10-2017

## C# Bitwise operators
```csharp
var i = 10;
i = i << 1;
Console.WriteLine(i);
// output: 20
```

## C# Binary conversions
```csharp
Action <object> log = (m) => Console.WriteLine(m);

var i = 65;
log(Convert.ToString(i, 2));
Console.WriteLine(Convert.ToString(i, 2));

i = i >> 2;
log(i);
log(Convert.ToString(i, 2));
log(Convert.ToInt32(Convert.ToString(i, 2), 2).ToString());

```

[◀ Previous (14-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/14/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (16-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/16/notebook.md)