namespace P2_Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objetos de las clases hijas
            Animal perro = new Perro
            {
                Nombre = "Bubu",
                Especie = "Canino",
                Raza = "Beagle",
                Edad = 2,
                FechaNacimiento = new DateTime(2024, 4, 15),
                Observaciones = "Muy amigable y muuuuyy Chillón",
                CantidadPatas = 4,
                ColorPelaje = "Cafe/Blanco/Negro"
            };

            Animal ballena = new Ballena
            {
                Nombre = "Keiko",
                Especie = "Cetáceo",
                Raza = "Orca",
                Edad = 12,
                FechaNacimiento = new DateTime(2014, 8, 10),
                Observaciones = "Sana y activa",
                CantidadAletas = 2,
                ColorPiel = "Blanco y Negro"
            };

            Animal pelicano = new Pelicano
            {
                Nombre = "Paco",
                Especie = "Ave",
                Raza = "Pelícano Blanco Americano",
                Edad = 2, // Misma edad que el perro para probar el inciso f
                FechaNacimiento = new DateTime(2024, 6, 20),
                Observaciones = "Ala derecha tratada",
                ColorPico = "Amarillo",
                ColorPlumas = "Gris y blanco"
            };

            List<Animal> listaAnimales = new List<Animal> { perro, ballena, pelicano };

            // d) Obtener la fecha de cumpleaños y la edad de cada objeto

            Console.WriteLine("=== EJERCICIO 8: CLASES Y MIEMBROS ABSTRACTOS ===");
            Console.WriteLine("");

            Console.WriteLine("=== d) Fecha de Cumpleaños y Edad ===");
            foreach (var animal in listaAnimales)
            {
                Console.WriteLine($"- Animal: {animal.Nombre} ({animal.GetType().Name}) | Fecha de Nacimiento: {animal.FechaNacimiento.ToShortDateString()} | Edad: {animal.Edad} años");
            }

            // e) Obtener el hábitat de cada objeto
            Console.WriteLine("\n=== e) Hábitat de cada objeto ===");
            foreach (var animal in listaAnimales)
            {
                Console.WriteLine($"- {animal.Nombre} ({animal.GetType().Name}) -> Hábitat: {animal.ObtenerHabitat()}");
            }

            // f) Cuál de los objetos tiene mayor y menor edad, o si son iguales
            Console.WriteLine("\n=== f) Comparación de Edades ===");
            int maxEdad = listaAnimales.Max(a => a.Edad);
            int minEdad = listaAnimales.Min(a => a.Edad);

            if (maxEdad == minEdad)
            {
                Console.WriteLine("Todos los objetos tienen la misma edad:");
                foreach (var animal in listaAnimales)
                {
                    Console.WriteLine($"- {animal.Nombre} ({animal.GetType().Name}) con {animal.Edad} años.");
                }
            }
            else
            {
                var mayores = listaAnimales.Where(a => a.Edad == maxEdad).ToList();
                var menores = listaAnimales.Where(a => a.Edad == minEdad).ToList();

                Console.WriteLine("Objeto(s) con mayor edad:");
                foreach (var animal in mayores)
                {
                    Console.WriteLine($"- {animal.Nombre} ({animal.GetType().Name}) con {animal.Edad} años.");
                }

                Console.WriteLine("\nObjeto(s) con menor edad:");
                foreach (var animal in menores)
                {
                    Console.WriteLine($"- {animal.Nombre} ({animal.GetType().Name}) con {animal.Edad} años.");
                }
            }
            Console.ReadKey();



        }
    }
}
