.data
;wektor_3 dd 3.0, 3.0, 3.0, 3.0, 3.0, 3.0, 3.0, 3.0
    wektor_3 dd 3, 3, 3, 3, 3, 3, 3, 3

.code
    binarization PROC
    ; RCX - wynikowa bitmapa
    ; RDX - tablica R
    ; R8 - tablica G
    ; R9 - tablica B
    
    mov r11, [rsp+40]   ; rozmiar
    mov r10, [rsp+48]   ; próg binaryzacji   
    mov rsi, 0          ; licznik
    mov r12, 0 

            ; wczytywanie wektora 8-el z trójkami do xmm3
       ; movupd xmm3, xmmword ptr [wektor_3]
        movups xmm3, xmmword ptr [wektor_3]
        cvtdq2ps xmm3, xmm3


                ;rozpakowanie progu binaryzacji do xmm5 i zrobienie 8-el wektora
        movd xmm5, r10
        punpckldq  xmm5, xmm5
        punpckldq  xmm5, xmm5
        

    main_loop:
        ; wczytywanie tablic 128 bitów
        movdqu xmm0, [rdx+rsi]
        movdqu xmm1, [r8+rsi]
        movdqu xmm2, [r9+rsi]

        ; dodawanie 128b rejestrow (s³ów 16bitowych)
        paddw xmm0, xmm1
        paddw xmm0, xmm2


        ; Skopiuj xmm0 i xmm3 do xmm4 i xmm5
;movaps xmm4, xmm0
;movaps xmm5, xmm3

; Rozpakuj s³owa do 32-bitowych
;punpcklwd xmm0, xmm0
;punpcklwd xmm3, xmm3

; Konwertuj do float (dziêki temu divps bêdzie dzia³aæ na 32-bitowych s³owach)
cvtdq2ps xmm0, xmm0


; Wykonaj dzielenie
divps xmm0, xmm3

; Skonwertuj z powrotem do 32-bitowych s³ów
cvtps2dq xmm0, xmm0

; Zapakuj s³owa z powrotem do xmm0
;punpcklwd xmm0, xmm0

; Wstaw xmm0 jako ni¿sze 64 bity do xmm4
;pextrw xmm4, xmm0, 0

; Wyczyszczenie górnych 64 bitów w xmm4
;pextrw xmm4, xmm4, 0

        ; Podzielenie xmm0 przez xmm3
;        divps xmm0, xmm3

        ; porówanie wartoœci xmm0 z xmm5 (progiem binaryzacji)
        cmpltps xmm5, xmm0

        ; zapisanie wyniku binaryzacji do wynikowej bitmapy
        vmovdqu8 [rcx + r12], xmm5
       add r12, 1
        vmovdqu8 [rcx + r12], xmm5
        add r12, 1
        vmovdqu8 [rcx + r12], xmm5
        add r12, 1

                movd xmm5, r10
        punpckldq  xmm5, xmm5
        punpckldq  xmm5, xmm5

        ; zwiêkszenie indeksu o 8 bajtów
        add rsi, 4

        ; sprawdzanie warunku zakoñczenia pêtli
        cmp rsi, r11
        jl main_loop

        ; zakoñczenie procedury
        ret

   binarization endp
end
