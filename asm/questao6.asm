.text
	# Solu��o: divide n por 100, imprime o resultado. Divide por 10, imprime, divide por 1, imprime. Vual�.

	# coloca o valor 100 em $t0
	addi $t0 $0 100
	# Lê inteiro
	addi $2 $0 5
	syscall
	# Divide $2 (resultado da leitura) por 100 ($t0)
	div $2 $t0
	# Coloca o resultado da divisao em $4 para em seguida imprimir
	mflo $4
	addi $2 $0 1
	syscall

	# Adiciona o valor 10 em t0
	addi $t0 $0 10
	# Move o resto da divisao passada pra t1 e divide por 10
	mfhi $t1
	div $t1 $t0
	# Move o resultado pra $4 e imprime
	mflo $4
	addi $2 $0 1
	syscall

	# Move o resto da divisao passada pra $4 e imprime
	add $4 $0 $t0
	addi $2 $0 1
	syscall
	

	# Termina o programa
	addi $2 $0 10
	syscall
	
	