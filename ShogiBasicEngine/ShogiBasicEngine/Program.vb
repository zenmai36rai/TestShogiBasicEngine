Imports System

Module Program
    Const ENGINE_NAME = "ShogiBasicEngine"
    Const AUTHOR_NAME = "Kyosuke Miyazawa"
    Class USI
        Const ID_NAME = 0
        Const ID_AUTHOR = 1
        Const ID_NB = 2
        Public USI()
        Public Function UsiLoop() As Integer
            Dim cmd As String = "Default"
            While (cmd <> "")
                cmd = Console.ReadLine()
                Dim cmds = Split(cmd)
                If (cmds(0).Equals("quit")) Then
                    Return 0
                ElseIf (cmds(0).Equals("usi")) Then
                    SendId(ID_NAME)
                    SendId(ID_AUTHOR)
                    SendUsiok()
                ElseIf (cmds(0).Equals("isready")) Then
                    SendReadyOk()
                ElseIf (cmds(0).Equals("usinewgame")) Then
                    Continue While
                ElseIf (cmds(0).Equals("position")) Then
                    Continue While
                ElseIf (cmds(0).Equals("go")) Then
                    SendBestmove()
                Else
                    Console.WriteLine("invalid comannd:")
                End If
            End While
            Return 0

        End Function

        Private ID = {ENGINE_NAME, AUTHOR_NAME, ""}
        Private Function SendId(ByVal id As String)
            If (id = ID_NAME) Then
                Console.WriteLine("id name " + ENGINE_NAME)
            ElseIf (id = ID_AUTHOR) Then
                Console.WriteLine("id author " + AUTHOR_NAME)
            Else
                Return 0
            End If
        End Function
        Private Function SendUsiok()
            Console.WriteLine("usiok")
            Return 0
        End Function
        Private Function SendReadyOk()
            Console.WriteLine("readyok")
            Return 0
        End Function
        Private Function SendBestmove()
            Console.WriteLine("bestmove resign")
            Return 0
        End Function
    End Class
    Sub Main(args As String())
        Dim usi As USI = New USI()
        usi.UsiLoop()
    End Sub
End Module
