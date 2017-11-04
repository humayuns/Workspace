# 5-11-2017

## Unity3D: Debug.Log
```cs
using UnityEngine;
using System.Collections;

public class MyGameClass : MonoBehaviour
{
    void MyGameMethod()
    {
        // Message with a link to an object.
        Debug.Log("Hello", gameObject);

        // Message using rich text.
        Debug.Log("<color=red>Fatal error:</color> AssetBundle not found");
    }
}
```
Reference: https://docs.unity3d.com/ScriptReference/Debug.Log.html


[◀ Previous (4-11-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/4/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/November)
[Next (6-11-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/6/notebook.md)