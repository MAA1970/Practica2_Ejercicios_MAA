using P2_Ejercicio1_4_5;

namespace P2_Ejercicio1_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // <<<
            // EJERCICIO # 1
            // >>>

            Cadena cadena = new Cadena();

            string? frase, fraseFinal;
            Console.WriteLine("EJERCICIO 1 ");
            Console.WriteLine("Captura la frase (Se invertirán sus palabras): ");
            frase = Console.ReadLine();
            fraseFinal = cadena.inviertePalabras(frase);
            Console.WriteLine("La frase invetida es: {0}", fraseFinal);
            Console.WriteLine("");


            // <<<
            // EJERCICIO # 4
            // >>>
            //int columnas = Console.WindowWidth;
            int nivelHojas;
            Console.WriteLine("EJERCICIO 4 ");
            Console.WriteLine("Se generará un árbol de navidad.");
            Console.WriteLine("Cuantas niveles de hojas quieres (Mínimo 4, máximo 60): ");
            nivelHojas = Convert.ToInt32(Console.ReadLine());
            if (nivelHojas < 4)
            {
                nivelHojas = 4;
                Console.WriteLine("Se mostrarán {0} niveles (Enter)", nivelHojas);
                Console.ReadKey();

            }
            if (nivelHojas > 60)
            {
                nivelHojas = 60;
                Console.WriteLine("Se mostrarán {0} niveles (Enter)", nivelHojas);
                Console.ReadKey();

            }
            cadena.armaArbol(nivelHojas);
            Console.WriteLine("");


            // <<<
            // EJERCICIO # 5
            // >>>
            string? frasePal, resultado;

            Console.WriteLine("EJERCICIO 5: Validar palíndromo. ");
            Console.WriteLine("Captura la frase: ");
            frasePal = Console.ReadLine();
            resultado = cadena.cadenaPalindromo(frasePal);
            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }
}