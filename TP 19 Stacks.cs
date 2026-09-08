namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> invertida = new Stack<char>();

            Console.WriteLine("Ingrese una palabra/frase");
            string palabra = Console.ReadLine();

            string nueva = "";

            foreach (char j in palabra)
            {
                invertida.Push(j);
            }

            for (int i = 0; 0 < invertida.Count; i++)
            {
                nueva += invertida.Pop();
            }
            Console.WriteLine($"Palabra invertida: {nueva}");

            Stack<string> historial = new Stack<string>();
            historial.Push("google.com");
            historial.Push("github.com");
            historial.Push("stackoverflow.com");

            Console.WriteLine("Desea volver atras??(1 si 2 salir)");
            int respuesta = 0;

            while(respuesta != 2)
            {
                Console.WriteLine($"URL actual: {historial.Peek()}");
                respuesta = Convert.ToInt32(Console.ReadLine());

                if(respuesta == 1)
                {
                    if(historial.TryPop(out string paginaAnterior))
                    {
                        Console.WriteLine($"Regresando a: {paginaAnterior}");
                    }
                    else
                    {
                        Console.WriteLine("Ya no se puede volver atras");
                    }
                }
            }
            Console.WriteLine("saliendo");

            Console.WriteLine("Ingrese un mensaje como este { [ ( a + b ) ] } (similar)");
            string Palabra = Console.ReadLine();
            Stack<string> TextoRandom = new Stack<string>();
            TextoRandom.Push(Palabra);
            bool VerificarTexto(string ejemplo)
            {
                bool parentesis = false;
                bool parentesisbien = false;
                bool corchete = false;
                bool corchetebien = false;
                bool llaves = false;
                bool llavesbien = false;
                foreach (char letra in ejemplo)
                {
                    if (letra == '(')
                    {
                        parentesis = true;
                    }
                    if (letra == ')' && parentesis == true)
                    {
                        parentesisbien = true;
                    }
                }
                foreach (char letra1 in ejemplo)
                {
                    if (letra1 == '[')
                    {
                        corchete = true;
                    }
                    if (letra1 == ']' && corchete == true)
                    {
                        corchetebien = true;
                    }
                }
                foreach (char letra2 in ejemplo)
                {
                    if (letra2 == '{')
                    {
                        llaves = true;
                    }
                    if (letra2 == '}' && llaves == true)
                    {
                        llavesbien = true;
                    }
                }
                if (llavesbien == true && corchetebien == true && parentesisbien == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine(VerificarTexto(TextoRandom.Peek()));

            AccionTexto acciones = new AccionTexto("", "");

            acciones.guardar_accion("escribir", "perritos");
            acciones.guardar_accion("leer", "gatitos");

            Console.WriteLine("Ingrese 1 para hacer Control Z ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                acciones.deshacer();
            }

            double EvaluarRPN(string expresion)
            {
                Stack<double> pila = new Stack<double>();

                string[] elementos = expresion.Split(' ');

                foreach (string elemento in elementos)
                {

                    if (double.TryParse(elemento, out double numero))
                    {
                        pila.Push(numero);
                    }

                    else if (elemento == "+" || elemento == "-" || elemento == "*" || elemento == "/")
                    {

                        double num1 = pila.Pop();

                        double num2 = pila.Pop();

                        switch (elemento)
                        {
                            case "+": pila.Push(num2 + num1); break;
                            case "-": pila.Push(num2 - num1); break;
                            case "*": pila.Push(num2 * num1); break;
                            case "/": pila.Push(num2 / num1); break;
                        }
                    }
                }
                return pila.Pop();
                Console.WriteLine(pila.Pop());
            }
            string expresion = "5 3 + 2 *";
            double resultado = EvaluarRPN(expresion);
            Console.WriteLine($"Cuenta: {expresion} resultado: {resultado}");
        }
    }
}
