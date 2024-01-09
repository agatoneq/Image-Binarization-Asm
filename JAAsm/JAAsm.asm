.code
    binarization PROC
;RCX = wskaünik do oryginalnej bitmapy
;RDX = wskaünik do wynikowej bitmapy
;r8 = tablica mnoønikÛw
;r9 = rozmiar w bajtach

	    mov r10, 0		                                ; index ustwiwamy na 0
        mov r11, 0                                      ; licznik pikseli do 3    

    mainLoop:


        mov al, byte ptr [rcx + r10]  
        mov bl, 3
        imul bl


        mov byte ptr [rdx + r10], al 
        inc r10
        dec r9d
        jnz mainLoop                            
        ret                                    

    outerState:
        mov r11, 0
        jmp mainLoop


   binarization endp
end