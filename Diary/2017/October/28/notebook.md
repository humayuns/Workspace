# 28-10-2017

## [DispatcherFrame Class](https://msdn.microsoft.com/en-us/library/system.windows.threading.dispatcherframe.aspx?f=255&MSPPError=-2147217396)
```csharp
[SecurityPermissionAttribute(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
public void DoEvents()
{
    DispatcherFrame frame = new DispatcherFrame();
    Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background,
        new DispatcherOperationCallback(ExitFrame), frame);
    Dispatcher.PushFrame(frame);
}

public object ExitFrame(object f)
{
    ((DispatcherFrame)f).Continue = false;

    return null;
}
```

[◀ Previous (27-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/27/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (29-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/29/notebook.md)