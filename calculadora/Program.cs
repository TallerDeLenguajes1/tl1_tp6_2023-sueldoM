// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool realizarCalculo = true;

        while (realizarCalculo)
        {
            Console.WriteLine("---- CALCULADORA ----");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1: // Sumar
                    resultado = num1 + num2;
                    break;
                case 2: // Restar
                    resultado = num1 - num2;
                    break;
                case 3: // Multiplicar
                    resultado = num1 * num2;
                    break;
                case 4: // Dividir
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Error: No se puede dividir entre 0.");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (opcion >= 1 && opcion <= 4)
                Console.WriteLine("Resultado: " + resultado);

            Console.Write("¿Desea realizar otro cálculo? (S/N): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToUpper() != "S")
                realizarCalculo = false;

            Console.WriteLine();
        }