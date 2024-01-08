.code
binarization PROC
;rcx to maciez mno¿ników
;rdx to macierz pikseli
;r8 to macierz wynikowa
mov rax, 0
	tabele_loop:
		movupd xmm0, [rdx+rax*8]
		movupd xmm1, [rcx+rax*8]
		mulpd xmm0, xmm1
		movupd [r8+rax*8], xmm0
		inc rax
		cmp rax, 3
		je done
		jmp tabele_loop
	done:
		ret

binarization ENDP
end