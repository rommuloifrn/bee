# uma hailstone sequence (ou sequência granizo) é uma conjectura
# que faz um número aumentar e depois diminuir até um.
while True:
    n = int(input())

    if n == 0:
        break

    m = []
    higher = 0

    while True:

        if n%2 == 0:
            n = n//2
        else:
            n = n*3 + 1

        m.append(n)
        if n == 1 : break

    for i in range(len(m)):
        if m[i] > higher:
            higher = m[i]

    print(higher)