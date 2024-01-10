.code
    binarization PROC
    ; Funkcja binarization przyjmuje cztery argumenty:
    ; RCX - wskaŸnik do oryginalnej bitmapy
    ; RDX - wyzerowany rejestr pomocniczy
    ; R8 - wskaŸnik do wynikowej bitmapy
    ; R9 - rozmiar w bajtach


        mov r10, 0                 ; Inicjalizacja licznika sumy
        mov rsi, 0                 ; Inicjalizacja licznika iteracji
        mov rax, 0                 ; Inicjalizacja akumulatora
        mov rbx, 0                 ; Inicjalizacja rejestru pomocniczego
        mov cx, 3                  ; Ustawienie wartoœci sta³ej 3
        mov r11w, 0                ; Inicjalizacja rejestru pomocniczego
        mov rdi, 0
        mov rdi, r9                ; Przeniesienie rozmiaru do rdi
         ;mov byte ptr [r8], 0

    mainLoop:
        cmp rsi, 3                  ; Porównanie licznika iteracji z 3
        je loopEnd                   ; Skok do loopEnd, jeœli równy
        cmp r10, rdi                ; Porównanie licznika sumy z rozmiarem
        jae loopEnd                  ; Skok do loopEnd, jeœli wiêkszy lub równy
        mov bl, byte ptr [rcx + r10] ; Wczytanie bajtu z oryginalnej bitmapy do bl
        inc r10                      ; Inkrementacja licznika sumy
        add ax, bx                    ; Dodanie wartoœci bl do akumulatora
        inc rsi                       ; Inkrementacja licznika iteracji
        jmp mainLoop                  ; Skok do mainLoop

    loopEnd:
        mov rsi, 0                    ; Wyzerowanie licznika iteracji
        xor dx, dx                    ; Wyzerowanie rejestru dx
        div cx                        ; Podzielenie zawartoœci akumulatora przez cx
        mov rdx, 0                    ; Wyzerowanie rejestru dx (reszta z dzielenia)
        cmp ax, 100            ; Porównanie zawartoœci al z 128
        jg changeToWhite              ; Skok do changeToWhite, jeœli wiêksze
        mov rax, 0                     ; W przeciwnym razie, ustawienie ax na 0
        je outerState                  ; Skok do outerState, jeœli równy 0

    outerState:
        mov qword ptr [r8 + r10], rax   ; Zapisanie wartoœci al do wynikowej bitmapy
        mov dl, byte ptr [r8 + r10]
        mov rax, 0                    ; Wyzerowanie akumulatora
        dec r9d                       ; Dekrementacja rozmiaru
        jnz mainLoop                  ; Skok do mainLoop, jeœli rozmiar niezerowy
        ret                            ; Zakoñczenie funkcji

    changeToWhite:
        ;mov r11w, 0ffffh               ; Ustawienie r11w na 0xffff
        mov rax, 0ffffffffffffh                ; Ustawienie ax na 0xffff, jeœli carry flag jest ustawione
        jmp outerState                 ; Skok do outerState

   binarization endp
end