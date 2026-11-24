import random
def adivina():
    entero = random.randint(1, 10)
    adivino = False

    while not adivino:
        ingreso = int(input("Ingrese un numero entre 1 y 10: "))

        if ingreso < entero:
            print("EL numero secreto es mayor")
        elif ingreso > entero:
            print("EL numero secreto es menor")
        else:
            print(f"Adivino el numero secreto es: {entero}")
            adivino = True


def Divisores():
    divisores = []
    numero = int(input("Ingrese un numero, veremos sus divisores: "))

    for i in range(1, numero + 1):
        if numero % i == 0:
            divisores.append(i)

    print(f"Sus divisores son: {divisores}")


def Fibonacci():
    print("Mostraremos los 20 primeros numeros de la secuencia fibonacci: ")
    a, b = 0, 1
    for i in range(20):
        print(a)
        a, b = b, a + b


def Calculadora():
    termino = False

    while not termino:
        eleccion = int(
            input("Ingrese 1 para sumar, 2 para restar, 3 para multiplicar, 4 para dividir o 5 para salir: "))

        if eleccion == 5:
            print("Chau :p")
            break

        if eleccion in (1, 2, 3, 4):
            num1 = int(input("Ingrese el primer numero: "))
            num2 = int(input("Ingrese el segundo numero: "))

            if eleccion == 1:
                print(f"La suma es: {num1 + num2}")
            elif eleccion == 2:
                print(f"La resta es: {num1 - num2}")
            elif eleccion == 3:
                print(f"La multiplicacion es: {num1 * num2}")
            elif eleccion == 4:
                if num2 == 0:
                    print("No se puede dividir por 0")
                else:
                    print(f"La division es: {num1 / num2}")
        else:
            print("Ingrese solo lo que dije antes")


def Factorial():
    numero = int(input("Ingrese el numero a factoriar: "))

    factoria = 1
    for i in range(1, numero + 1):
        factoria *= i

    print(f"Numero factorial: {factoria}")


def Turnos():
    nombre = input("Ingrese su nombre para asignarle un turno o 1 para terminar: ")
    cont = 0

    while nombre != "1":
        cont += 1
        print(f"Turno numero {cont} asignado a {nombre}")
        nombre = input("Ingrese su nombre para asignarle un turno o 1 para terminar: ")

    print(f"Total de turnos asignados: {cont}")


def pares():
    pares = []
    for i in range(1, 101):
        if i % 2 == 0:
            pares.append(i)

    print(f"Todos los numeros pares del 1 al 100: {pares}")

def ConvertirTemp():
    pasaje = True

    while pasaje:
        print("1 para pasar de C° a F°, 2 para salir")
        o = int(input())

        match o:
            case 1:
                usuario = True
                while usuario:
                    temperatura = int(input("Ingrese la temperatura (o 99999 para salir): "))

                    if temperatura == 99999:
                        usuario = False
                    else:
                        fahrenheit = (temperatura * 1.8) + 32
                        print(f"Resultado: {fahrenheit}°F")
            case 2:
                pasaje = False
                print("Saliendo")
            case _:
                print("Opcion no disponible")


def Primo():
    numero = int(input("Ingrese un numero entero: "))

    if numero < 2:
        print("El numero no es primo")
        return

    for num in range(2, numero):
        if numero % num == 0:
            print("El numero no es primo")
            return

    print("El numero SÍ es primo")


def Saludar():
    nombres = []
    print("Ingrese nombres para saludar")

    while True:
        nombre = input("Ingrese un nombre o fin para terminar: ")

        if nombre.lower() == "fin":
            for nombresito in nombres:
                print(f"Hola {nombresito} :v")
            break

        nombres.append(nombre)


def RecibirNombre():
    nombres = []

    while True:
        nombre = input("Ingrese un nombre: ")

        if nombre.lower() in [n.lower() for n in nombres]:
            print(f"¡El nombre '{nombre}' ya fue ingresado!")
            print(f"Cantidad de nombres ingresados antes del repetido: {len(nombres)}")
            break

        nombres.append(nombre)


def multiplos7():
    for i in range(100, 201):
        if i % 7 == 0 and i % 10 == 3:
            print(i)


def IngresarPrecios():
    total = 0
    cont = 0

    while True:
        precio = int(input("Ingrese el precio del producto: "))
        total += precio
        cont += 1

        if total > 1000:
            print(f"Se cargaron {cont} productos")
            break


def Formulario():
    while True:
        nombre = input("Ingrese su nombre (fin para terminar): ")
        if nombre.lower() == "fin":
            break

        while True:
            email = input("Ingrese su email: ").strip()
            if "@" in email:
                break
            print("Email inválido. Debe contener un '@'. Intentá de nuevo.")

        edad = int(input("Ingrese su edad: "))

        print(f"Su formulario es: {email}-{nombre}-{edad}")


def RecorrerNum():
    numero = input("Ingrese un número: ")

    if numero.isdigit():
        for digito in numero:
            print(digito)
    else:
        print("Error: Debe ingresar solo números enteros positivos.")


def PPT():
    rondas = 0
    puntCompu = 0
    puntHuman = 0

    while rondas < 3:
        entero = random.randint(1, 3)
        eleccion = int(input("Ingrese 1 para piedra, 2 para papel, 3 para tijera: "))

        if eleccion == entero:
            print("Empate")
        elif (eleccion == 1 and entero == 3) or (eleccion == 2 and entero == 1) or (eleccion == 3 and entero == 2):
            puntHuman += 1
            print(f"Ganaste esta ronda {puntHuman} a {puntCompu}")
        else:
            puntCompu += 1
            print(f"Perdiste esta ronda {puntHuman} a {puntCompu}")

        rondas += 1

    # Corrección: signos de comparación invertidos correctamente
    if puntCompu > puntHuman:
        print("Gano mas veces la compu")
    elif puntCompu < puntHuman:
        print("Ganaste mas veces vos")
    else:
        print("Terminaron empatados")


def mayores50():
    mayor50 = []
    for i in range(1, 11):
        entero = random.randint(1, 100)

        if entero > 50:
            mayor50.append(entero)

    print(f"Mayor a 50 salieron: {mayor50}")


def promedio():
    guardados = []
    suma = 0

    for i in range(1, 6):
        nombre = input("Ingrese su nombre: ")
        nota = int(input("Ingrese su nota: "))
        suma += nota
        guardados.append((nota, nombre))

    mejor_nota, mejor_nombre = max(guardados)

    print(f"Promedio: {suma / 5}")
    print(f"Mejor nota: {mejor_nota} Alumno: {mejor_nombre}")


def abcdario():
    abecedario = "abcdefghijklmnñopqrstuvwxyz"

    for letra in reversed(abecedario):
        print(letra)

adivina()
Divisores()
Fibonacci()
Calculadora()
Factorial()
Turnos()
pares()
ConvertirTemp()
Primo()
Saludar()
RecibirNombre()
multiplos7()
IngresarPrecios()
Formulario()
RecorrerNum()
PPT()
mayores50()
promedio()
abcdario()