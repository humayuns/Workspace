# 4-11-2017

## Gridview radio button JavaScript
```js
function RadioCheck(rb) {
    var gv = document.getElementById("<%=GridView1.ClientID%>");
    var rbs = gv.getElementsByTagName("input");

    var row = rb.parentNode.parentNode;
    for (var i = 0; i < rbs.length; i++) {
        if (rbs[i].type == "radio") {
            if (rbs[i].checked && rbs[i] != rb) {
                rbs[i].checked = false;
                break;
            }
        }
    }
}
```
Reference: https://www.aspsnippets.com/Articles/ASPNet-GridView-Radio-Button-Single-Selection---Select-only-one-RadioButton-from-Column.aspx

[◀ Previous (3-11-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/3/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/November)
[Next (5-11-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/5/notebook.md)