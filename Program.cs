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

            } while (opcion != "6");
        }

    }
}
