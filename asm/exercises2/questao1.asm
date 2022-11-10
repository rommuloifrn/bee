.text
    main:

    # Reads the first number and adds in t0
    addi $v0 $0 5
    syscall
    add $t0 $0 $v0

    # Reads the second number and adds in t1
    addi $v0 $0 5
    syscall
    add $t1 $0 $v0

    # Subtracts the second number from the first one and stores on t7
    sub $t7 $t0 $t1
    # Shifts t7 31 bits to right (leaving only the signal bit)
    srl $t7 $t7 31
    # Stores AND between t7 and 1 in a0 ($4) and prints it
    andi $a0 $t7 1
    addi $v0 $0 1
    syscall

    # Finishes the program
    addi $v0 $0 10
    syscall