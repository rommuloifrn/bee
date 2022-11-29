print("Bem vindo ao Enem Notinha Simulator!")
while True:

    print("Quer aplicar a mesma nota em outros pesos? Digite 1")
    print("Quer aplicar outra nota nos mesmos pesos? Digite 2")
    print("Quer inserir pesos e notas? Digite 3")
    resposta = int(input())

    if resposta == 1:
        pesos = input("Digite os pesos\n")
    elif resposta == 2:
        notas = input("Digite as notas\n")
    elif resposta == 3:
        pesos = input("Digite os pesos\n")
        notas = input("Digite as notas\n")
    else:
        print("Escreve direito, chimpa.\n")

    pLing, pMat, pHum, pNat, pRed, totalpesos = map(float, pesos.split(" "))
    nLing, nHum, nNat, nMat, nRed = map(float, notas.split(" "))

    print("Sua nota com os pesos é", (nLing*pLing+nMat*pMat+nHum*pHum+nNat*pNat+nRed*pRed)/totalpesos)
    resposta = input("Deseja fazer outra operação? Sim = 1, Não = 0\n")
    if resposta == "0":
        break
