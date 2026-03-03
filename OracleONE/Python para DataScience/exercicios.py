lista = [16, 14, 63, 65, 17, 99, 70, 11, 20, 48, 79, 32, 17, 89, 12, 25, 66]

print(f"A lista possui {len(lista)} números em que o maior número é {max(lista)} e o menor número é {min(lista)}. A soma dos valores presentes nela é igual a {sum(lista)}")

numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

novaLista = list(map(lambda x : x**2, numeros ))

print(novaLista)

nomes = ["joão", "MaRia", "JOSÉ"]
sobrenomes = ["SILVA", "souza", "Tavares"]

print(f"Nomes Completo:{list(map(lambda n_s: n_s[0].capitalize() +" "+n_s[1].capitalize(), zip(nomes,sobrenomes)))}")


gols_marcados = [2, 1, 3, 1, 0]
gols_sofridos = [1, 2, 2, 1, 3]

def calcula_pontos(marcados, sofridos):
    pontuação = sum(3 if m > s else 1 if m == s else 0 for m,s in zip(marcados,sofridos))
    aproveitamento = (pontuação/(len(marcados)*3)) * 100
    return f"A pontuação do time foi de {pontuação} e seu aproveitamento foi de {aproveitamento:.2f}%"    

print(calcula_pontos(gols_marcados, gols_sofridos)) 

frase = "Aprender Python aqui na Alura é muito bom"
maior5 = list(filter(lambda x: len(x)>=5,frase.split()))
print(maior5)

notas = []
for i in range(1,5):
    x = int(input(f"Insira a {i}ª nota: "))
    notas.append(x)

media = sum(notas)/len(notas)

print(f"O(a) estudante obteve uma média de {media}, com a sua maior nota de {max(notas)} pontos e a menor nota de {min(notas)} pontos e foi {'Aprovado' if media >= 5 else 'Reprovado'}")
