n = int(input())

j = 0
fibolist = [0,0]

# Este for adiciona os algarismos em fibolist[].
for i in range(1,n):
    if fibolist[i] == 0:
        j = j+1
    else:
        j = fibolist[i]+fibolist[i-1]
    print(i)
    fibolist.append(j)

# range(len(fibolist)) vai até len(fibolist)-1. Isso bate com o índice da lista, que começa em 0 e por isso não vai até len(fibolist).

# Este for printa os algarismos.

for i in range(1,len(fibolist)):
    if i == len(fibolist):
        print(fibolist[i])
    else:
        print(fibolist[i],end=" ")