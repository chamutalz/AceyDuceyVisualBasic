Module Module1
    'Acey Ducey (101 Basic Computer Games) translated to Visual Basic
    'chamutalz January 2019
    Dim A As Integer
    Dim B As Integer
    Dim M As Integer
    Dim Q As Integer = 100
    Dim drawAgain As Boolean = False
    Dim playAgain As Boolean = False

    Sub Main()
        AceyDucey()
        If (playAgain) Then
            AceyDucey()
        End If
    End Sub

    Sub AceyDucey()
        Console.WriteLine("ACEY DUCEY CARD GAME")
        Console.WriteLine("CREATIVE COMPUTING MORRISTOWN, NEW JERSEY")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("ACEY DUCEY IS PLAYED IN THE FOLLOWING MANNER")
        Console.WriteLine("THE DEALER (COMPUTER) DEALS TWO CARDS FACE UP")
        Console.WriteLine("YOU HAVE AN OPTION TO BET OR NOT BET DEPENDING")
        Console.WriteLine("ON WHETHER OR NOT YOU FEEL THE CARD WILL HAVE")
        Console.WriteLine("A VALUE BETWEEN THE FIRST TWO.")
        Console.WriteLine("IF YOU DO NOT WANT TO BET INPUT A 0")
        Dim N As Integer = 100
        While (Q > 0)
            Dim s1 = $"YOU NOW HAVE {Q} DOLLARS"
            Console.WriteLine(s1)
            Console.WriteLine()
            Draw()
            Bet()
            Play()
            If (drawAgain = False) Then
                Compare()
            End If
            drawAgain = False
        End While

        If (Q < 0) Or (Q = 0) Then
            Console.WriteLine("SORRY, FRIEND BUT YOU BLEW YOUR WAD")
            Console.WriteLine("TRY AGAIN (YES OR NO)")
            Dim answer = Console.ReadLine().ToLower
            If (answer = "no") Then
                playAgain = False
                Console.WriteLine("OK HOPE YOU HAD FUN")
            ElseIf (answer = "yes") Then
                Q = 100
                playAgain = True
            End If
        End If

    End Sub

    Sub Bet()
        Console.WriteLine("WHAT IS YOUR BET?")
        M = Console.ReadLine()
    End Sub

    Sub Draw()
        Console.WriteLine("HERE ARE YOUR NEXT TWO CARDS")
        A = Math.Ceiling(Rnd() * 14) + 2
        While (A < 2)
            A = Math.Ceiling(Rnd() * 14) + 2
        End While
        If (A < 11) Then
            Console.WriteLine(A)
        ElseIf (A = 11) Then
            Console.WriteLine("JACK")
        ElseIf (A = 12) Then
            Console.WriteLine("QUEEN")
        ElseIf (A = 13) Then
            Console.WriteLine("KING")
        ElseIf (A = 14) Then
            Console.WriteLine("ACE")
        End If

        B = Math.Ceiling(Rnd() * 14) + 2
        While (B < 2)
            B = Math.Ceiling(Rnd() * 14) + 2
        End While
        If (B = A) Then
            B = Math.Ceiling(Rnd() * 14) + 2
        End If
        If (B < 11) Then
            Console.WriteLine(B)
        ElseIf (B = 11) Then
            Console.WriteLine("JACK")
        ElseIf (B = 12) Then
            Console.WriteLine("QUEEN")
        ElseIf (B = 13) Then
            Console.WriteLine("KING")
        ElseIf (B = 14) Then
            Console.WriteLine("ACE")
        End If
    End Sub

    Sub Play()
        If (M = 0) Then
            Console.WriteLine("CHICKEN!")
            drawAgain = True
        End If
        If (M > Q) Then
            Console.WriteLine("SORRY, MY FRIEND BUT YOU BET TOO MUCH")
            Dim s2 = $"YOU HAVE ONLY {Q} DOLLARS TO BET"
            Console.WriteLine(s2)
            drawAgain = True
        End If
    End Sub

    Sub Compare()
        If (M <= Q) Then
            Dim C As Integer
            C = Math.Ceiling(Rnd() * 14) + 2
            While (C < 2)
                C = Math.Ceiling(Rnd() * 14) + 2
            End While
            If (C < 11) Then
                Console.WriteLine(C)
            ElseIf (C = 11) Then
                Console.WriteLine("JACK")
            ElseIf (C = 12) Then
                Console.WriteLine("QUEEN")
            ElseIf (C = 13) Then
                Console.WriteLine("KING")
            ElseIf (C = 14) Then
                Console.WriteLine("ACE")
            End If

            If (A < B) Then
                If (C > A) And (C < B) Then
                    Console.WriteLine("YOU WIN!")
                    Q = Q + M
                Else
                    Console.WriteLine("SORRY, YOU LOSE")
                    Q = Q - M
                End If
            End If
            If (A > B) Then
                If (C > B) And (C < A) Then
                    Console.WriteLine("YOU WIN!")
                    Q = Q + M
                Else
                    Console.WriteLine("SORRY, YOU LOSE")
                    Q = Q - M
                End If
            End If
        End If
    End Sub
End Module
