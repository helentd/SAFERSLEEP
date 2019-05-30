Const ForReading = 1

Const ForWriting = 2

Set objFSO = CreateObject("Scripting.FileSystemObject")

Set objTextFile = objFSO.OpenTextFile("C:\Program Files\SAFERsleep\SAFERsleep OR\SAFERsleepOR.ini", ForReading)


Do Until objTextFile.AtEndOfStream

    strNextLine = objTextFile.Readline


    intLineFinder = InStr(strNextLine, "clientmodule_10.isenabled=true")

    If intLineFinder <> 0 Then

        strNextLine = "clientmodule_10.isenabled=false"

    End If

    strNewFile = strNewFile & strNextLine & vbCrLf

Loop


objTextFile.Close


Set objTextFile = objFSO.OpenTextFile("C:\Program Files\SAFERsleep\SAFERsleep OR\SAFERsleepOR.ini", ForWriting)


objTextFile.WriteLine strNewFile

objTextFile.Close