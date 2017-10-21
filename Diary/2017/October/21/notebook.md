# 21-10-2017

## [jQuery.isNumeric()](https://api.jquery.com/jQuery.isNumeric/)
```javascript
// true (numeric)
$.isNumeric( "-10" )
$.isNumeric( "0" )
$.isNumeric( 0xFF )
$.isNumeric( "0xFF" )
$.isNumeric( "8e5" )
$.isNumeric( "3.1415" )
$.isNumeric( +10 )
$.isNumeric( 0144 )
 
// false (non-numeric)
$.isNumeric( "-0x42" )
$.isNumeric( "7.2acdgs" )
$.isNumeric( "" )
$.isNumeric( {} )
$.isNumeric( NaN )
$.isNumeric( null )
$.isNumeric( true )
$.isNumeric( Infinity )
$.isNumeric( undefined )
```

## [Client Side Validation using ASP.NET Validator Controls from Javascript](http://techbrij.com/client-side-validation-using-asp-net-validator-controls-from-javascript)
```javascript
function performCheck() {
    Page_ClientValidate("LoginUserValidationGroup");
    if (Page_IsValid) {
        alert('it is valid');
        return true;
    }
    else {
        alert('No valid');
        return false;
    }
}
```

## Links
* http://techbrij.com/client-side-validation-using-asp-net-validator-controls-from-javascript
* https://stackoverflow.com/questions/640520/how-do-i-fire-an-asp-net-custom-validator-from-javascript


[◀ Previous (20-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/20/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (22-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/22/notebook.md)