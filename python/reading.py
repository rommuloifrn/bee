# Montador da disciplina de arquitetura de computadores
arquivo1 = open(r"/home/romrom/Desktop/bee/python/tobereaded.txt", "r")
texto = arquivo1.read()
linhas = texto.split(" ")


print(linhas[1])

arquivo1.close()