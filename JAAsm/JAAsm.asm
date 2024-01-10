.code
    binarization PROC
;RCX = wskaünik do oryginalnej bitmapy
;RDX = wskaünik do wynikowej bitmapy
;r8 = tablica mnoønikÛw
;r9 = rozmiar w bajtach
;int[] mm0 = { 11, 59, 30 };

	    mov r10, rdx		                                ; index ustwiwamy na 0
        mov rsi, 0  
        mov rbp, 0                              ; licznik pikseli do 3    
        mov rax, 0 
        mov rbx, 0 
        mov cx, 3
        mov r11w, 0
        mov rdi, r9
        movq xmm0, rdx
        mov rdx, 0

    mainLoop:
            cmp rsi, 3
            je loopEnd
            cmp rbp, rdi
            jae loopEnd
            mov bl, byte ptr [rcx + rbp]
            inc rbp
            add ax, bx
            inc rsi
            jmp mainLoop

    loopEnd:
            mov rsi, 0
            ;xor dx, dx
            div cx
            cmp al, 128
            jg changeToWhite
            mov ax, 0
            je outerState

    outerState:
            mov byte ptr [r10 + rbp], al
            mov rax, 0
            dec r9d
            jnz mainLoop
            ret
        
    changeToWhite:
            mov r11w, 0ffffh
            mov ax, r11w
            jmp outerState


   binarization endp
end