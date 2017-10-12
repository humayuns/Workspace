# 13-10-2017

## VB FV function
Returns a Double specifying the future value of an annuity based on periodic, fixed payments and a fixed interest rate.
```vb
Function FV( _
   ByVal Rate As Double, _
   ByVal NPer As Double, _
   ByVal Pmt As Double, _
   Optional ByVal PV As Double = 0, _
   Optional ByVal Due As DueDate = DueDate.EndOfPeriod _
) As Double
```

### Example
```vb
Sub TestFV()
    Dim TotPmts As Integer 
    Dim Payment, APR, PVal, Fval As Double 
    Dim PayType As DueDate
    Dim Response As MsgBoxResult

    ' Define money format. 
    Dim Fmt As String = "###,###,##0.00"
    Payment = CDbl(InputBox("How much do you plan to save each month?"))
    APR = CDbl(InputBox("Enter the expected interest annual percentage rate."))
    ' Ensure proper form. 
    If APR > 1 Then APR = APR / 100
    TotPmts = CInt(InputBox("For how many months do you expect to save?"))
    Response = MsgBox("Do you make payments at the end of month?", MsgBoxStyle.YesNo)
    If Response = MsgBoxResult.No Then
        PayType = DueDate.BegOfPeriod
    Else
        PayType = DueDate.EndOfPeriod
    End If
    PVal = CDbl(InputBox("How much is in this savings account now?"))
    Fval = FV(APR / 12, TotPmts, -Payment, -PVal, PayType)
    MsgBox("Your savings will be worth " & Format(Fval, Fmt) & ".")
End Sub
```
Reference: https://msdn.microsoft.com/en-us/library/ae5xky1f%28v=vs.90%29.aspx?f=255&MSPPError=-2147217396

[◀ Previous (12-10-2017)](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/12/notebook.md) [▲](https://github.com/humayuns/Workspace/tree/master/Diary/2017/October)
[Next (14-10-2017) ▶](https://github.com/humayuns/Workspace/blob/master/Diary/2017/October/14/notebook.md)