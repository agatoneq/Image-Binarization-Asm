.code
    binarization PROC
    ; RCX - oryginalna bitmapa
    ; RDX - wyzerowany rejestr do dzielenia
    ; R8 - wynikowa bitmapa
    ; R9 - rozmiar w bajtach
    ; R10 - próg binaryzacji

        mov r10, rdx
        mov rdx, 0
        mov r11, 0                          ; Inicjalizacja licznika sumy
        mov rsi, 0                          ; Inicjalizacja licznika iteracji
        mov rax, 0                          ; Inicjalizacja akumulatora
        mov rbx, 0                          ; Inicjalizacja rejestru pomocniczego
        mov cx, 3                           ; Ustawienie 3
        mov rdi, 0
        mov rdi, r9                         ; Przeniesienie rozmiaru do rdi

    addValuesLoop:
        cmp rsi, 3                          
        je divideAndChangeColor                 
        cmp r11, rdi                        
        jae divideAndChangeColor            
        mov bl, byte ptr [rcx + r11]        
        inc r11                            
        add ax, bx                      
        inc rsi                        
        jmp addValuesLoop                  

    divideAndChangeColor:
        mov rsi, 0                            
        div cx                             
        mov rdx, 0                          
        cmp ax, r10w                    
        jg changeToWhite                    
        mov rax, 0                         
        je finalLoop                     

    finalLoop:
        mov qword ptr [r8 + r11], rax
        mov rax, 0                               
        dec r9d                                  
        jnz addValuesLoop                     
        ret 

    changeToWhite:                                   
        mov rax, 0ffffffffffffh                   
        jmp finalLoop                             


   binarization endp
end