for /f "skip=1 tokens=3" %%s in ('query user %paul.campbell%') do (
  %windir%\System32\tscon.exe %%s /dest:console
)