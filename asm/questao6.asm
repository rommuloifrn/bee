.text
	main:
	# Solu��o: divide n por 100, imprime o resultado. Divide por 10, imprime, divide por 1, imprime. Vual�.
	
	# L� inteiro & copia para t0
	addi $2 $0 5
	syscall
	add $t0 $0 $2
	# Coloca zero a ser impresso
	add $4 $0 $0
	# Imprime zero
	addi $2 $0 1
	syscall
	syscall
	# Coloca inteiro em $2
	add $4 $0 $t0
	#imprime inteiro
	addi $2 $0 1
	syscall
	
	
	