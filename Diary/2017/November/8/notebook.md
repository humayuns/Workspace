# 8-11-2017

## C# Transparent TextBox
```cs
public class TransparentLabel : RichTextBox
{
    public TransparentLabel()
    {
        this.SetStyle(ControlStyles.Opaque, true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
        this.TextChanged += TransparentLabel_TextChanged;
        this.VScroll += TransparentLabel_TextChanged;
        this.HScroll += TransparentLabel_TextChanged;
    }

    void TransparentLabel_TextChanged(object sender, System.EventArgs e)
    {
        this.ForceRefresh();
    }
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams parms = base.CreateParams;
            parms.ExStyle |= 0x20;  // Turn on WS_EX_TRANSPARENT
            return parms;
        }
    }
    public void ForceRefresh()
    {
        this.UpdateStyles();
    }
}
```

## Links
* https://www.codeproject.com/Articles/819294/WPF-MVVM-step-by-step-Basics-to-Advance-Level

[◀ Previous (7-11-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/7/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/November)
[Next (9-11-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/November/9/notebook.md)