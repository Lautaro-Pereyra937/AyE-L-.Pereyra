try
{
    void programa6()
    {
        string[,] matrizVisual = new string[10, 10];
        for (int fila = 0; fila < matrizVisual.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matrizVisual.GetLength(1); columna++)
            {
                matrizVisual[fila,columna] = "?" + " ";
            }
        }
         
        int[,] matriz1 = new int[10, 10];
    
        int unos = 0;
    
        int intentos = 5;
    
        bool adivinar = true;
    
        int adivinados = 0;
    
        int ultimaX = -1;
        int ultimaY = -1;
    
        Random num = new Random();
    
        while(unos < 3)
        {
            int fila = num.Next(0, 10);
            int columna = num.Next(0, 10);
    
            if(matriz1[fila, columna] == 0)
            {
                matriz1[fila, columna] = 1;
                unos++;
            }
        }
    
        for (int fila = 0; fila < matriz1.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz1.GetLength(1); columna++)
            {
                Console.Write("?" + " ");
            }
            Console.WriteLine();
        }
    
        while(adivinar == true)
        {
            Console.WriteLine("Elija la casilla en la cordenada x del 1 al 10");
            int corx = Convert.ToInt32(Console.ReadLine())-1;
    
            Console.WriteLine("Elija la casilla en la cordenada y del 1 al 10(ya ingreso la cordenada en x)");
            int cory = Convert.ToInt32(Console.ReadLine())-1;
    
            ultimaX = corx;
            ultimaY = cory;
    
            if(matriz1[corx, cory] == 1)
            {
                Console.WriteLine("Usted acerto");
                adivinados++;
    
                matrizVisual[corx, cory] = "O";
    
                 for (int fila = 0; fila < matrizVisual.GetLength(0); fila++)
                    {
                        for (int columna = 0; columna < matrizVisual.GetLength(1); columna++)
                        {
                            Console.Write(matrizVisual[fila, columna] + " ");
                        }
                        Console.WriteLine();
                    }
                
                if (adivinados == 3)
                {
                    Console.WriteLine("Usted gano el juego Acerto Todas las posiciones, la matriz usada fue: ");
    
                    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
                    {
                        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
                        {
                            Console.WriteLine(matriz1[fila, columna] + " ");
                        }
                        Console.WriteLine();
                    }
                    adivinar = false;
                    break;
                }
            }
            else
            {
                intentos--;
                Console.WriteLine($"Usted no acerto tiene {intentos} intentos");
    
                matrizVisual[corx, cory] = "X";
                
                for (int fila = 0; fila < matrizVisual.GetLength(0); fila++)
                    {
                        for (int columna = 0; columna < matrizVisual.GetLength(1); columna++)
                        {
                            Console.Write(matrizVisual[fila, columna] + " ");
                        }
                        Console.WriteLine();
                    }
                if (intentos == 0)
                {
                    Console.WriteLine("Perdio, las casillas eran: ");
    
                    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
                    {
                        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
                        {
                            Console.Write(matriz1[fila, columna] + " ");
                        }
                        Console.WriteLine();
                    }
                    adivinar = false;
                    break;
                }
            }
        }
    }
    programa6();
}
catch(System.FormatException)
{
  Console.WriteLine("No puede");
}
catch(IndexOutOfRangeException)
{
  Console.WriteLine("No puede");
}
