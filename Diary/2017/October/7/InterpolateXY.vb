Public Function InterpolateXY(ByRef X As Range, ByRef Y As Range, ByRef XRange As Range, ByRef YRange As Range, ByRef ValueTable As Range) As Double
    Dim iCol As Long
    Dim iRow As Long
    Dim C1 As Double
    Dim C2 As Double
    Dim C3 As Double
    Dim C4 As Double
    Dim F1 As Double
    Dim F2 As Double
    Dim C5 As Double
    Dim C6 As Double
    
    'search X
    iCol = 1
    Do While X >= XRange(1, iCol).Value And (iCol < XRange.Columns.Count)
        iCol = iCol + 1
    Loop
    
    'search Y
    iRow = 1
    Do While Y >= YRange(iRow, 1).Value And (iRow < YRange.Rows.Count)
        iRow = iRow + 1
    Loop
    
    'if X or Y fall outside the table, the function result is an error value
    If (X < XRange(1, 1).Value) Or (X > XRange(1, iCol).Value) Or (Y < YRange(1, 1).Value) Or (Y > YRange(iRow, 1).Value) Then
        InterpolateXY = (1 / 0)
        Exit Function
    End If
    
    '4 data table points 'around' X and Y
    C1 = ValueTable.Cells(iRow - 1, iCol - 1).Value
    C2 = ValueTable.Cells(iRow - 1, iCol).Value
    C3 = ValueTable.Cells(iRow, iCol - 1).Value
    C4 = ValueTable.Cells(iRow, iCol).Value

    'X and Y fractions
    F1 = (X - XRange.Cells(1, iCol - 1).Value) / (XRange.Cells(1, iCol).Value - XRange.Cells(1, iCol - 1).Value)
    F2 = (Y - YRange.Cells(iRow - 1, 1).Value) / (YRange.Cells(iRow, 1).Value - YRange.Cells(iRow - 1, 1).Value)

    '2 intermediate results after interpolation on X
    C5 = C1 + F1 * (C2 - C1)
    C6 = C3 + F1 * (C4 - C3)
    
    'final result after interpolation on Y
    InterpolateXY = C5 + F2 * (C6 - C5)
    
End Function