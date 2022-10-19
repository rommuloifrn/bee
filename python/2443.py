a,b,c,d = list(map(int,input().split(" ")))

def irreduty(x,y):
    for i in range(2,max(x,y)):
        while x%i == 0 and y%i == 0:
            x = x//i
            y = y//i
    return print(x,y)
    
def mmc(x,y):
    major = max([x,y])
    divisores = []
    for i in range(2,major+1):
        while True:
            if x%i == 0 and y%i == 0:
                x = x//i
                y = y//i
                divisores.append(i)
            elif x%i == 0:
                x = x//i
                divisores.append(i)
            elif y%i == 0:
                y = y//i
                divisores.append(i)
            else: break
    result = 1
    for i in range(len(divisores)):
        result = result*divisores[i]
    return result


if b != d:
    while True:
        if b != mmc(b,d):
            a = a * ( mmc(b,d)//b)
            b = b * ( mmc(b,d)//b)
            #nesses dois casos o denominador precisa ser declarado depois pois o valor dele é alterado, prejudicando o cálculo do numerador.
        elif d != mmc(b,d):
            c = c * ( mmc(b,d)//d)
            d = d * ( mmc(b,d)//d)
        else: break

e = int(a+c)
f = mmc(b,d)

irreduty(e,f)