import System
import System.Console


Dim x As Integer, y As Integer
        On Error GoTo ErrorHandler
        Write("Digite o valor 1: ")
        x = ReadLine()
        Write("Digite o valor 2: ")
        y = ReadLine()

        Dim c As Double 
        c = x/y
        WriteLine("O Resultado é " + c)
        Exit Sub
Errorhandler: 
        WriteLine()
        WriteLine("Dados incorretos. (A)bortar, (T)entar novamente, (I)gnorar")
        Dim r As String
        r = ReadLine()
        Select Case r
            Case "A": Exit Sub
            Case "T": Resume
            Case "I": Resum