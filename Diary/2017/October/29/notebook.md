# 29-10-2017

## WinForms: Screencapture
```
var img = new Bitmap(640, 480);
var g = Graphics.FromImage(img);

g.CopyFromScreen(0, 0, 0, 0,
    new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height),
    CopyPixelOperation.SourceCopy);

pictureBox1.Image = img;```

[◀ Previous (28-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/28/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (30-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/30/notebook.md)