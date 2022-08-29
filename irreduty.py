# Função que retorna o numerador e denominador de uma fração irredutível

def irreduty(x,y):

    for i in range(2,max(x,y)):
        while x%i == 0 and y%i == 0:
            x = x//i
            y = y//i
    return x,y

a,b = list(map(int,input().split()))
print(irreduty(a,b))