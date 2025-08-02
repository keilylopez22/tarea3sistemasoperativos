namespace tareaeSO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre ciclos y condicionales, me di cuenta de algo...");
            Console.WriteLine("if (usted == especial) { Console.WriteLine(\"Me gustás 🥰\"); }");
            string opcion;

            do
            {
                Console.WriteLine("\n=== HOLI===");
                Console.WriteLine("1. Versión Romántica");
                Console.WriteLine("2. Versión con Menú de Sentimientos");
                Console.WriteLine("3. Versión con Corazón ASCII");
                Console.WriteLine("4. Versión con Variables");
                Console.WriteLine("5. Versión con Latidos");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("\n❤️❤️❤️ Ing ❤️❤️❤️");
                    Console.WriteLine("Entre ciclos y condicionales, me encontré pensando en usted.");
                    Console.WriteLine("if (usted == especial) {\n\tConsole.WriteLine(\"Me gustás mucho 🥰\");\n}");
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("\n=== MENÚ DE SENTIMIENTOS ===");
                    Console.WriteLine("1. Admiración");
                    Console.WriteLine("2. Cariño");
                    Console.WriteLine("3. Me gustás 💖");
                    Console.WriteLine("4. Salir");
                    Console.Write("Elige una opción: ");
                    string subOpcion = Console.ReadLine();

                    if (subOpcion == "1" || subOpcion == "2")
                    {
                        Console.WriteLine("Profe, usted es una gran persona. ❤️");
                    }
                    else if (subOpcion == "3")
                    {
                        Console.WriteLine("Profe... Me gustás mucho 🥺💘");
                    }
                    else
                    {
                        Console.WriteLine("Hasta luego... pero sigo pensando en usted.");
                    }
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("\n  ***     ***  ");
                    Console.WriteLine(" *****   ***** ");
                    Console.WriteLine("***************");
                    Console.WriteLine(" ************* ");
                    Console.WriteLine("   *******     ");
                    Console.WriteLine("    *****      ");
                    Console.WriteLine("     ***       ");
                    Console.WriteLine("      *        ");
                    Console.WriteLine("Mi corazón en código ASCII 💗");
                    Console.WriteLine("Y aún así no cabe lo que siento por usted.");
                }
                else if (opcion == "4")
                {
                    string profe = "usted";
                    Console.WriteLine($"\nProfe {profe}, cada clase suya me gusta más.");
                    Console.WriteLine("No hay 'break' que detenga este 'switch' de sentimientos.");
                }
                else if (opcion == "5")
                {
                    Console.WriteLine("\nMi corazón late cada vez que lo veo, profe:");
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine($"💓 Latido {i}");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine("Diagnóstico: Me gustás 😳");
                }
                else if (opcion == "6")
                {
                    Console.WriteLine("Adiós profe... pero mis sentimientos persisten 💌");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

            } while (opcion != "6");
        }

    }
}
