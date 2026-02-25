def fatorial_recursivo(n):
    if n < 0:
        raise ValueError("Para números menores que 0, fatorial é indefinido")
    elif n == 0 or n == 1:
        return 1
    else:
        return n * fatorial_recursivo(n - 1)

def fatorial_n_recursivo(n):
    if n < 0:
        raise ValueError("Para números menores que 0, fatorial é indefinido")

    result = 1
    for i in range(2, n + 1):
        result *= i

    return result


print(fatorial_recursivo(5))  

print(fatorial_n_recursivo(5))  