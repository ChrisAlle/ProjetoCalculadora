Program Teste;
Var X : byte;
Begin
  ReadLn(X);
  Case X Of
  1 : Begin
        Repeat
          Read(X);
          Write(X);
        Until X = 9;
        CASE A OF
         ‘X’ : X := X-1;
        END;
      End;
  2 : WriteLn('Erro');
  End;
  X:= X + 1;
End.