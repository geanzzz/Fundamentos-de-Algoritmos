def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido al Curso de Fundamentos de Algoritmos de la carrera {carrera}.")

def ejer2():
    print("\"Gean\"")

def ejer3():
    x = int(input("Ingrese x: "))
    y = int(input("Ingrese y: "))

    print("\nSuma: ",(x+y))
    print("Resta: ",(x-y))
    print("Multiplicación: ",(x*y))
    print("División: ",(x/y))

    
import math
def ejer4():
    num = float(input("Ingrese un número decimal: "))

    print("raiz2: ",math.sqrt(num))
    print("redondeado: ",round(num))
    print("al cubo: "),math.pow(num,3)
    print("raiz3: "),math.pow(num,1/3)

def ejer5():
    num = input("Ingrese un número: ")

    dec=float(num)
    entero=round(num)

    print("Resto: ",entero%2)
    print("divi: ",dec/3)

ejer5()
