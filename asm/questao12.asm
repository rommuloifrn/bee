.text
    main:

    # Reads three integers and stores respectively in t0, t1 and t2
    addi $v0 $0 5
    syscall
    add $t0 $0 $v0

    addi $v0 $0 5
    syscall
    add $t1 $0 $v0

    addi $v0 $0 5
    syscall
    add $t2 $0 $v0

    # Shifts t0 one bit to left and adds 1 (multiplication by 3)
    sll $t7 $t0 1
    add $t0 $t0 $t7
    # Shifts t1 three bits to left and adds 1 (multiplication by 9)
    sll $t7 $t1 3
    add $t1 $t1 $t7
    # Shifts t2 four bits to left and subtracts 1 (multiplication by 15)
    sll $t7 $t2 4
    sub $t2 $t7 $t2

    # Sums the three multiplications on t7 and shifts 2 bits to left
    add $t7 $t0 $t1
    add $t7 $t7 $t2
    sll $t7 $t7 2

    # Stores 27 (sum of the three weights) on $t6
    addi $t6 $0 27

    div $t7 $t6
    mflo $t7
    srl $t7 $t7 2





    # Finishes the program
    addi $v0 $0 10
    syscall


