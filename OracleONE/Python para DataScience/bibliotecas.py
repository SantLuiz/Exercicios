import matplotlib.pyplot as plt
from random import choice


estudantes = ['JOÃO', 'MARIA', 'JOSÉ']
notas = [8.5, 9 , 6.5]
escolhido = choice(estudantes)
print(escolhido)

plt.bar(x = estudantes, height = notas)
plt.show()