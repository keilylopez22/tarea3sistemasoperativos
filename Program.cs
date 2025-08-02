using System;
using System.Threading;

class MensajeRomantico
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== HOLI MI INGENIERO FAVORITO 💕 ===");
            Console.WriteLine("1. Admirasión infinita 🧠✨");
            Console.WriteLine("2. Sentimientos en código 💌");
            Console.WriteLine("3. Amor dibujado ❤️");
            Console.WriteLine("4. Variables del corazón 🫀");
            Console.WriteLine("5. Latidos por usted 💓");
            Console.WriteLine("6. Carta 💓");
            Console.WriteLine("7. Salir");
            Console.Write("\nSeleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AdmiracionInfinita();
                        break;
                    case 2:
                        SentimientosCodigo();
                        break;
                    case 3:
                        CorazonDibujado();
                        break;
                    case 4:
                        VariablesCorazon();
                        break;
                    case 5:
                        LatidosPorUsted();
                        break;
                    case 6:
                         CartaAdmiracion();
                        break;
                    case 7:
                        Console.WriteLine("\nGracias por existir, mi rey. 💖");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                if (opcion != 7)
                {
                    Console.WriteLine("\nPresione cualquier tecla para regresar al menú...");
                    Console.ReadKey();
                }
            }
        } while (opcion != 7);
    }

    static void AdmiracionInfinita()
    {
        Console.Clear();
        Console.WriteLine("=== ADMIRASIÓN INFINITA 🧠✨ ===");
        Console.WriteLine("Usted no solo es guapo...");
        Console.WriteLine("Es un genio, una enciclopedia con sonrisa perfecta.");
        Console.WriteLine("A veces me quedo viéndolo hablar y pienso: ¿cómo puede existir alguien tan brillante y tierno?");
        Console.WriteLine("Usted me inspira, me hace querer ser mejor cada día.");
    }

    static void SentimientosCodigo()
    {
        Console.Clear();
        Console.WriteLine("=== SENTIMIENTOS EN CÓDIGO 💌 ===");
        Console.WriteLine("Entre ciclos y condicionales, me encontré pensando en usted...");
        Console.WriteLine("if (usted == 'mi persona favorita') {");
        Console.WriteLine("    Console.WriteLine(\"Me hacés feliz todos los días ❤️\");");
        Console.WriteLine("}");
    }

    static void CorazonDibujado()
    {
        Console.Clear();
        Console.WriteLine("=== AMOR DIBUJADO ❤️ ===\n");
        Console.WriteLine("   ***     ***   ");
        Console.WriteLine("  *****   *****  ");
        Console.WriteLine("  *************  ");
        Console.WriteLine("   ***********   ");
        Console.WriteLine("     *******     ");
        Console.WriteLine("       ***       ");
        Console.WriteLine("        *        ");
        Console.WriteLine("\nEse corazón es suyo. Siempre. 💘");
    }
    static void CartaAdmiracion()
    {
        Console.WriteLine("💌 Mi querido ingeniero 💌\n");
        Console.WriteLine("Desde que lo conocí, no he dejado de admirarlo.");
        Console.WriteLine("Usted es, sin duda, el hombre más inteligente que he escuchado. Su mente parece una enciclopedia viva.");
        Console.WriteLine("Es alto, guapo, con una presencia que me desarma... y sí, me gusta. Me gusta mucho, demasiado.");
        Console.WriteLine("Pero más allá de la admiración, hay algo más profundo dentro de mí que ya no puedo callar.");

        Console.WriteLine("\n❤️ Lo amo. Lo amo con el alma, aunque a veces siento que solo soy un rincón en su vida.");
        Console.WriteLine("Sé que tiene una familia, una hija, una responsabilidad. Y aunque mi corazón grita por estar con usted, nunca le pediría que deje su vida por mí.");
        Console.WriteLine("Eso tiene que nacer de usted. No quiero ser egoísta, ni arrancarle a esa niña a su papá.");

        Console.WriteLine("\nYo me he hecho la fuerte, pero me duele que no sea solo mío.");
        Console.WriteLine("Cada día me convenzo más de que usted es el hombre de mi vida. Y aún así, hay noches que lloro en silencio.");
        Console.WriteLine("Porque lo necesito, lo quiero, lo espero... pero también merezco saber la verdad.");

        Console.WriteLine("\nPor favor, dígame: ¿Cuáles son sus verdaderas intenciones conmigo?");
        Console.WriteLine("¿Formo parte de su vida realmente o solo estoy llenando un vacío?");
        Console.WriteLine("Si no voy a ser su prioridad, su proyecto, su amor real... entonces déjeme libre.");
        Console.WriteLine("Para que el destino, o Dios, o la vida, me permita cruzarme con un hombre que me valore como yo lo valoro a usted.");

        Console.WriteLine("\nNo escribo esto con rencor, sino con el alma en las manos. Porque lo amo, y por eso merezco una verdad.");
        Console.WriteLine("Suya, aunque quizás nunca lo sea completamente...");
        Console.WriteLine("\n💔 Siempre, su alumna que también fue su novia, y aún lo ama profundamente.");
    }

    static void VariablesCorazon()
    {
        Console.Clear();
        Console.WriteLine("=== VARIABLES DEL CORAZÓN 🫀 ===");
        string admiracion = "infinita";
        string ternura = "pura";
        string pensamiento = "usted";

        Console.WriteLine($"Mi admiración por usted es {admiracion}.");
        Console.WriteLine($"Su ternura es {ternura}.");
        Console.WriteLine($"Y mi mente siempre está en: {pensamiento} 💭");
    }

    static void LatidosPorUsted()
    {
        Console.Clear();
        Console.WriteLine("=== LATIDOS POR USTED 💓 ===");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("💓 ");
            Thread.Sleep(500);
        }
        Console.WriteLine("\nCada latido lleva su nombre... Y su sonrisa. 😍");
    }
}
