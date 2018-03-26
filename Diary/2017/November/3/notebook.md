# 3-11-2017

## Reading JSON with XMLHttpRequest
```javascript
var getJSON = function(url, callback) {

    var xhr = new XMLHttpRequest();
    xhr.open('GET', url, true);
    xhr.responseType = 'json';
    
    xhr.onload = function() {
    
        var status = xhr.status;
        
        if (status == 200) {
            callback(null, xhr.response);
        } else {
            callback(status);
        }
    };
    
    xhr.send();
};

getJSON('http://time.jsontest.com',  function(err, data) {
    
    if (err != null) {
        console.error(err);
    } else {
        
        var text = `Date: ${data.date}
Time: ${data.time}
Unix time: ${data.milliseconds_since_epoch}`
    
        console.log(text);
    }
});

```

## [AlphaBlendTextBox - A transparent/translucent textbox for .NET](https://www.codeproject.com/Articles/4390/AlphaBlendTextBox-A-transparent-translucent-textbo)
![AlphaBlendTextBox](https://www.codeproject.com/KB/edit/AlphaBlendTextBox/AlphaBlendTextBox1.gif)
```csharp
// Sample C# code
private ZBobb.AlphaBlendTextBox alphaBlendTextBox1; 
private void Form1_Load(object sender, System.EventArgs e)
{
    alphaBlendTextBox1 = new ZBobb.AlphaBlendTextBox();
    alphaBlendTextBox1.Location = new System.Drawing.Point(32, 16);
    this.alphaBlendTextBox1.Text = "Hello";
    alphaBlendTextBox1.BackAlpha = 0; // Totally transparent
    this.Controls.Add(this.alphaBlendTextBox1);
 }
```


## Links
* http://www.html5canvastutorials.com/tutorials/html5-canvas-line-color/
* https://www.codeproject.com/Articles/4390/AlphaBlendTextBox-A-transparent-translucent-textbo


[◀ Previous (1-11-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/1/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/November)
[Next (4-11-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/4/notebook.md)
