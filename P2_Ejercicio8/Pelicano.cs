using System;
using System.Collections.Generic;
using System.Text;

namespace P2_Ejercicio8
{
    // a) Jerarquía de clases (atributos): Pelicano (Clase Hija)

    public class Pelicano : Animal
    {
        private string? colorPico;
        private string? colorPlumas;

        public string? ColorPico { get => colorPico; set => colorPico = value; }
        public string? ColorPlumas { get => colorPlumas; set => colorPlumas = value; }

        public override void cumpleanios()
        {
            Edad++;
            Console.WriteLine($"{Nombre} el pelícano está cumpliendo años. ¡Ahora tiene {Edad} años!");
        }

        public override void alimentacion()
        {
            Console.WriteLine($"{Nombre} se alimenta cazando peces en la superficie del agua.");
        }

        public override string ObtenerHabitat()
        {
            return "Aéreo (Zonas acuáticas y playas)";
        }
    }


}
