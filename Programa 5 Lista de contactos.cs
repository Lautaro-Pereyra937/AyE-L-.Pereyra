try
{
    void programa5()
    {
        string[] contactos = new string[100];
        string[] telefonos = new string[100];

        bool ejecutando = true;

        void agregarcontacto()
        {
            Console.WriteLine("Ingrese el numero de contacto que desea ingresar");
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.WriteLine("Ingrese el telefono");

                telefonos[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre del contacto");

                contactos[i] = Console.ReadLine();
            }
        }

        void todoscontactos()
        {
            for (int x = 0; x < contactos.Length; x++)
            {
                Console.WriteLine($"Contactos que ingreso: {telefonos[x]}-{contactos[x]}");
            }
        }

        void buscarcontacto()
        {
            Console.WriteLine("Ingrese el nombre del contacto");
            string nombre = Console.ReadLine();
            for (int i = 0; i < contactos.Length; i++)
            {
                if (contactos[i] == nombre)
                {
                    Console.WriteLine("Numero: " + telefonos[i] + " Nombre: " + nombre);
                }
            }
        }

        while (ejecutando)
        {
            Console.WriteLine("Ingrese 1 para añadir contactos nuevos, 2 para ver todos los contactos, 3 para buscar un contacto por el nombre 3 , 4 para terminar");
            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    agregarcontacto();
                    break;

                case 2:
                    todoscontactos();
                    break;

                case 3:
                    buscarcontacto();
                    break;

                case 4:
                    Console.WriteLine("Terminando...");
                    ejecutando = false;
                    break;

                default:
                    Console.WriteLine("Esa opcion no esta disponible");
                    break;
            }
        }
    }
    programa5();
}
catch(System.FormatException)
{
    Console.WriteLine("no puede ingresar eso");
}