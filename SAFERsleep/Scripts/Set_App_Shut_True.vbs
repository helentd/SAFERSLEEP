Const ForReading = 1

Const ForWriting = 2

Set objFSO = CreateObject("Scripting.FileSystemObject")

Set objTextFile = objFSO.OpenTextFile("C:\Program Files\SAFERsleep\SAFERsleep OR\SAFERsleepORBase.ini", ForReading)


Do Until objTextFile.AtEndOfStream

    strNextLine = objTextFile.Readline


    intLineFinder = InStr(strNextLine, "application.shutdown")

    If intLineFinder <> 0 Then

        strNextLine = "application.shutdown=true"

    End If

    strNewFile = strNewFile & strNextLine & vbCrLf

Loop


objTextFile.Close


Set objTextFile = objFSO.OpenTextFile("C:\Program Files\SAFERsleep\SAFERsleep OR\SAFERsleepORBase.ini", ForWriting)


objTextFile.WriteLine strNewFile

objTextFile.Close