#LISTA DE LISTAS
ExemploListaDeListas = [[1,2,3,4,5],['a','b','c','d','e'],[10,20,30,40,50]]

#TRANSFORMANDO UMA LISTA EM LISTAS MENORES

notas_turma = ['João', 8.0, 9.0, 10.0, 'Maria', 9.0, 7.0, 6.0, 'José', 3.4, 7.0, 7.0, 'Cláudia', 5.5, 6.6, 8.0, 'Ana', 6.0, 10.0, 9.5]

nomes=[]
notas_juntas=[]

for i in range(len(notas_turma)):
    if i%4==0:
        nomes.append(notas_turma[i])
    else:
        notas_juntas.append(notas_turma[i])



notas = []

for i in range(0,len(notas_juntas),3):
    notas.append([notas_juntas[i],notas_juntas[i+1],notas_juntas[i+2]])



#TRABALHANDO COM TUPLAS

cadastro = ("Júlia", 23, "São Paulo", "SP", "Python para DS 1")


#por também ser um iterável, podemos desempacotar os dados de uma tupla passando cada valor para uma variável
nome, idade, cidade, estado, turma = cadastro


from random import randint

def gera_codigo():
    return str(randint(0,999))

codigo_estudantes = []

for i in range(len(nomes)):
    codigo_estudantes.append((nomes[i],(nomes[i][0]+gera_codigo())))



#LIST COMPREHENSION

def media (lista : list=[0]) -> float:
    '''Função para calcular a média de notas passadas por uma lista
    
    lista : list, default [0]
        Lista com as notas para calcular a media
    return = calcula: float
        Média Calculada
    '''

    calculo = sum(lista)/len(lista)

    return calculo

médias = [round(media(nota),1) for nota in notas]



estudantes = [nome[0] for nome in codigo_estudantes ]


candidatos = list(zip(estudantes,médias))


finalistas = [i[0] for i in candidatos if i[1] >= 8.0]


situação = ['Aprovado' if i >= 6 else 'Reprovado' for i in médias]


passou = [i for i in [estudantes,notas,médias,situação]]


lista_completa = [codigo_estudantes,notas,médias,situação]


testezip = list(zip(estudantes,notas,médias,situação))

#DICT COMPREHENSION
#FORMATO PADRÃO {chave:valor for i in lista}

print(lista_completa)

colunas = ["NOTAS","MÉDIA FINAL", "SITUAÇÃO"]

cadastros = {colunas[i]:lista_completa[i+1] for i in range(len(colunas))}

cadastros["Estudante"] = [lista_completa[0][i][0] for i in range(len(lista_completa[0]))]

print(cadastros)

print("-"*20 + "EXERCICIOS" + "-"*20)

nomes_estudantes = [ "Enrico Monteiro", "Luna Pereira", "Anthony Silveira", "Letícia Fernandes", 
                    "João Vitor Nascimento", "Maysa Caldeira", "Diana Carvalho", "Mariane da Rosa",
                    "Camila Fernandes", "Levi Alves", "Nicolas da Rocha", "Amanda Novaes", 
                    "Laís Moraes", "Letícia Oliveira", "Lucca Novaes", "Lara Cunha", 
                    "Beatriz Martins", "João Vitor Azevedo", "Stephany Rosa", "Gustavo Henrique Lima" ]

medias_estudantes = [5.4, 4.1, 9.1, 5.3, 6.9, 3.1, 10.0, 5.0, 8.2, 5.5,
                    8.1, 7.4, 5.0, 3.7, 8.1, 6.2, 6.1, 5.6, 6.7, 8.2]

bolsistas = {nomes_estudantes[i]:medias_estudantes[i] for i in range(len(medias_estudantes)) if medias_estudantes[i] >= 9}

print(bolsistas)

resolução = {nome:media for nome,media in zip(nomes_estudantes,medias_estudantes) if media >=9}
print(resolução)