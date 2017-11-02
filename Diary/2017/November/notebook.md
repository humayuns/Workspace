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

## Links
* http://www.html5canvastutorials.com/tutorials/html5-canvas-line-color/


[◀ Previous (1-11-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/1/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/November)
[Next (3-11-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/3/notebook.md)