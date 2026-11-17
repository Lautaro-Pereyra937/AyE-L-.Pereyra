# 1- Imaginá que querés contar del 1 al 100, pero sólo mostrar los múltiplos de 3.
def Multiplos3():
    for i in range(3, 101, 3):
        print(i)

# 2- Pedí una edad y mostrale a la persona si es menor de edad, mayor o si tiene justo 18.
def MayorMenor():
    edad = int(input("Ingrese su edad: "))

    if edad > 18:
        print("Mayor")
    elif edad < 18:
        print("Menor")
    else:
        print("Usted tiene justo 18")


# 3- Pedile al usuario una palabra y mostrá cuántas letras tiene.
def CantLetras():
    palabra = input("Ingrese una palabra: ")
    print(f"La palabra tiene {len(palabra)} letras")


# 4- Pensá en una contraseña secreta. Hacé que el usuario tenga que adivinarla en 5 intentos.
def ContraseñaSecret():
    secreta = "ratas"
    intentos = 0

    while intentos < 5:
        ingreso = input(f"Intento {intentos + 1}/5 - Adivina la contraseña :v: ")
        intentos += 1

        if ingreso == secreta:
            print("¡Adivinó!")
            return;

    print("Ute no adivino e mu godito")


# 5- Pedile al usuario que ingrese 10 números, y mostrá cuál fue el más alto.
def DiezNumeros():
    print("Ingrese 10 números")

    maximo = 0

    for i in range(2, 11):
        num = float(input(f"Ingrese el número {i}: "))
        if num > maximo:
            maximo = num

    print(f"El número más alto es {maximo}")


# 6- Pedile su nombre, y saludalo usando mayúsculas para las primeras letras.
def Saludo():
    nombre = input("Ingrese su nombre: ")
    print(f"Hola {nombre.title()}")


# 7- Tabla del 7 del 1 al 10, y cuenta regresiva desde 10 hasta 1 terminando con "oa".
def tablaSiete():
    print("Tabla del 7")
    for i in range(1, 11):
        print(f"{i} = {7 * i}")

    for i in range(10, 0, -1):
        print(i)
    print("oa")


# 8- Preguntale al usuario un número. Si es par, mostrale “par”; si no, “impar”.
def ParOImpar():
    numero = int(input("Ingrese un número: "))

    if numero % 2 == 0:
        print("par")
    else:
        print("impar")


# 9- Hacé que el usuario ingrese una frase. Mostrale la cantidad de vocales que tiene.
def CantVocales():
    frase = input("Ingrese una frase: ").lower()
    cant = 0
    vocales = ["a", "e", "i", "o", "u"]

    for letra in frase:
        if letra in vocales:
            cant += 1

    print(f"Cantidad de vocales: {cant}")


# 10- Pedile al usuario que ingrese un número y mostrá su tabla de multiplicar del 1 al 12.
def TablaMultiplicar():
    numero = int(input("Ingrese un número: "))

    for i in range(1, 13):
        print(f"{i} = {numero * i}")


# 11- Armá un contador que pida números de a uno, hasta que supere un total acumulado de 100.
def ContadorCien():
    cont = 0

    while cont <= 100:
        num = int(input("Ingrese un número: "))
        cont += num
        print(f"Contador actual: {cont}")

    print("Ute supero el limite")


# 12- Escribí un programa que pida una palabra y muestre cada letra en una línea distinta.
def ForPalabra():
    palabra = input("Ingrese una palabra: ")

    for letra in palabra:
        print(letra)

# 13- Pedí una edad y mostrá si puede votar, manejar, ambas cosas, o ninguna.
def VotarManejar():
    edad = int(input("Ingrese su edad: "))

    if edad >= 18:
        print("Puede votar y manejar")
    elif edad >= 16 and edad < 18:
        print("Puede votar pero no manejar")
    else:
        print("No puede votar ni manejar")


# 14- Mostrá los números del 50 al 0 de forma descendente, de cinco en cinco.
def Descenso():
    for i in range(50, -1, -5):
        print(i)


# 15- Contraseña dos veces. Si coinciden, "Acceso permitido", si no, que repita el intento.
def ContraseñaCorrecta():
    intentos = 5

    while intentos > 0:
        contraUno = input("Ingrese una contraseña: ")
        contraDos = input("Ingrese la misma contraseña: ")

        if contraUno == contraDos:
            print("Acceso permitido")
            return
        else:
            intentos -= 1
            print(f"No e la mima. Tenes {intentos} intentos.")

    print("Se acabaron los intentos.")


# 16- Pida nombres uno por uno, y termine cuando el nombre tenga más de 10 caracteres.
def LimiteNombres():
    termina = False

    while not termina:
        print("Ingrese nombres hasta que supere el límite de 10 letras :o")
        nombre = input("Ingrese un nombre: ")

        if len(nombre) > 10:
            print("El nombre e mu larguito ;v")
            termina = True


# 17- Escriba una oración. Mostrale cuántas letras "a" tiene.
def Oracion():
    oracion = input("Ingrese una oración: ").lower()
    CantidadDeA = 0

    for letra in oracion:
        if letra == "a":
            CantidadDeA += 1

    print(f"Tiene {CantidadDeA} letras A :p")

terminacion = False

while terminacion == False:
    eleccion = int(input("Ingrese un número (del 1 al 17, o 18 para terminar) para ejecutar una función: "))
    if eleccion == 1:
        Multiplos3()
    elif eleccion == 2:
        MayorMenor()
    elif eleccion == 3:
        CantLetras()
    elif eleccion == 4:
        ContraseñaSecret()
    elif eleccion == 5:
        DiezNumeros()
    elif eleccion == 6:
        Saludo()
    elif eleccion == 7:
        tablaSiete()
    elif eleccion == 8:
        ParOImpar()
    elif eleccion == 9:
        CantVocales()
    elif eleccion == 10:
        TablaMultiplicar()
    elif eleccion == 11:
        ContadorCien()
    elif eleccion == 12:
        ForPalabra()
    elif eleccion == 13:
        VotarManejar()
    elif eleccion == 14:
        Descenso()
    elif eleccion == 15:
        ContraseñaCorrecta()
    elif eleccion == 16:
        LimiteNombres()
    elif eleccion == 17:
        Oracion()
    elif eleccion == 18:
        print("Terminamo")
        terminacion = True
    else:
        print("Ingrese un num del 1 al 18 noma.")
