namespace Practica2_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a) Jerarqupia de clases (Padre: Profesional, Hijas: Medico y Abogado

            // b) Mostrar datos dependiendo de la edad del médico y abogado

            // Instancia de un Médico
            Medico medico = new Medico(
                new DateTime(2015, 6, 15), 
                100234, 
                "12345678",
                "Juan", "González", 
                "Pérez", 
                "Av. La Patria #123",
                new DateTime(1988, 4, 10),
                "Universidad de Celaya",
                "Los Olivos", 
                "Hospital General", 
                500, 
                120, 
                45
            );

            // Instancia de un Abogado
            Abogado abogado = new Abogado(
                new DateTime(2018, 11, 20),
                200567,
                "87654321",
                "Ana",
                "Gómez",
                "Rojas",
                "Calle 5 de Mayo #456",
                new DateTime(1988, 6, 25),
                "Instituto Benavente",
                "Centro",
                "Juzgado 3ro Civil",
                15,
                80
            );

            // Llamada a la función que compara edades
            CompararEdades(medico, abogado);
            Console.ReadKey();

            // c) Instanciar objeto de cada clase hija y mostrar sus datos
            Medico medico1 = new Medico(
                   new DateTime(2018, 4, 25),
                   156491,
                   "0035588",
                   "Armando",
                   "Ontiveros",
                   "López",
                   "Av. 20 de Nov #151",
                   new DateTime(1971, 7, 10),
                   "Universidad Latina",
                   "Centro",
                   "Hospital CMQ",
                   380,
                   212,
                   54
                    );

            Abogado abogado1 = new Abogado(
                new DateTime(2018, 11, 20),
                056720,
                "0057629",
                "Maricruz",
                "Granados",
                "Herrera", 
                "Calle Benito Juárez #816",
                new DateTime(1981, 2, 17),
                "Instituto Benavente",
                "La Alameda",
                "Notaria No. 12",
                34,
                45
            );

            // Mostrar datos de ambos objetos
            Console.WriteLine("=== DATOS DEL MÉDICO ===");
            Console.WriteLine(medico.ObtenerDatosPersonales());
            Console.WriteLine($"Unidad de Trabajo: {medico.UnidadTrabajo}");
            Console.WriteLine($"Nro. Consultas Médicas: {medico.NroConsultasMedicas}");
            Console.WriteLine($"Nro. Consultas Domicilio: {medico.NroConsultasDomicilio}");
            Console.WriteLine($"Nro. Cirugías: {medico.NroCirugias}");
            Console.WriteLine($"Fecha de Egreso: {medico.FechaEgreso:dd/MM/yyyy}");
            Console.WriteLine($"Nro. Título Académico: {medico.NroTituloAcademico}");
            Console.WriteLine($"Edad: {medico.CalcularEdad()} años\n");

            Console.WriteLine("=== DATOS DEL ABOGADO ===");
            Console.WriteLine(abogado.ObtenerDatosPersonales());
            Console.WriteLine(abogado.ObtenerDatosLaborales());
            Console.WriteLine($"Fecha de Egreso: {abogado.FechaEgreso:dd/MM/yyyy}");
            Console.WriteLine($"Edad: {abogado.CalcularEdad()} años");

            // d)
            VerificarMismaUniversidad(medico, abogado);
            Console.ReadKey();

            // e)


            Console.ReadKey();

            // f)
            Console.WriteLine("=== CANTIDAD DE JUICIOS DEL ABOGADO ===");
            Console.WriteLine($"Abogado: {abogado.Nombres} {abogado.PrimerApellido}");
            Console.WriteLine($"Juicios en Proceso: {abogado.NroJuiciosProceso}");
            Console.ReadKey();

        }

        // Metodos del b)
        public static void CompararEdades(Medico doctor, Abogado abogado)
        {
            int edadDoctor = doctor.CalcularEdad();
            int edadAbogado = abogado.CalcularEdad();

            Console.WriteLine("================ RESULTADO DE LA COMPARACIÓN ================\n");

            // Si el doctor es mayor que el abogado
            if (edadDoctor > edadAbogado)
            {
                Console.WriteLine("El doctor cumple más años que el abogado.");
                Console.WriteLine($"Edad del Doctor: {edadDoctor} años");
                Console.WriteLine("\n--- DATOS PERSONALES DEL DOCTOR ---");
                Console.WriteLine(doctor.ObtenerDatosPersonales());
            }
            // Si el doctor NO es mayor (es decir, el abogado es mayor)
            else if (edadDoctor < edadAbogado)
            {
                Console.WriteLine("El doctor no es mayor que el abogado (El abogado es mayor).");
                Console.WriteLine("\n--- DATOS PERSONALES DEL ABOGADO ---");
                Console.WriteLine(abogado.ObtenerDatosPersonales());
                Console.WriteLine("\n--- DATOS LABORALES DEL ABOGADO ---");
                Console.WriteLine(abogado.ObtenerDatosLaborales());
            }
            // Si tienen la misma edad
            else
            {
                Console.WriteLine("Tienen la misma edad.");
                Console.WriteLine($"\n--- DATOS PERSONALES DEL DOCTOR (Edad: {edadDoctor} años) ---");
                Console.WriteLine(doctor.ObtenerDatosPersonales());

                Console.WriteLine($"\n--- DATOS PERSONALES DEL ABOGADO (Edad: {edadAbogado} años) ---");
                Console.WriteLine(abogado.ObtenerDatosPersonales());
            }
        }

        // Metodo del d)

        public static void VerificarMismaUniversidad(Profesional profesionista1, Profesional profesionista2)
        {
            // Compara las propiedades de la universidad
            if (profesionista1.Universidad.ToLower() == profesionista2.Universidad.ToLower())
                {
                Console.WriteLine($"Sí, ambos profesionales provienen de la misma universidad: {profesionista1.Universidad}");
            }
            else
            {
                Console.WriteLine($"No provienen de la misma universidad.");
                Console.WriteLine($"El médico estudió en: {profesionista1.Universidad}");
                Console.WriteLine($"El abogado estudió en: {profesionista2.Universidad}");
            }
        }

        // Metodo del d)

        public static void VerificarMismaZona(Profesional profesionista1, Profesional profesionista2)
        {
            // Compara las propiedades de la zona 
            if (profesionista1.Zona.ToLower() == profesionista2.Zona.ToLower())
            {
                Console.WriteLine($"Sí, ambos profesionales provienen de la misma universidad: {profesionista1.Universidad}");
            }
            else
            {
                Console.WriteLine($"No provienen de la misma universidad.");
                Console.WriteLine($"El médico estudió en: {profesionista1.Universidad}");
                Console.WriteLine($"El abogado estudió en: {profesionista2.Universidad}");
            }
        }


    }
}
