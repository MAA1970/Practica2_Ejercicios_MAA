using System;
using System.Collections.Generic;
using System.Text;

namespace P2_Ejercicio8
{
    // a) Jerarquía de clases (atributos): Ballena (Clase Hija)

    public class Ballena : Animal
    {
        private int cantidadAletas;
        private string? colorPiel;

        public int CantidadAletas { get => cantidadAletas; set => cantidadAletas = value; }
        public string? ColorPiel { get => colorPiel; set => colorPiel = value; }

        //public string? habitat;  // Es habitat un atributo, más que un método

        public override void cumpleanios()
        {
            Edad++;
            Console.WriteLine($"{Nombre} la ballena está cumpliendo años. ¡Ahora tiene {Edad} años!");
        }

        public override void alimentacion()
        {
            Console.WriteLine($"{Nombre} se alimenta filtrando plancton y peces pequeños.");
        }

        public override string ObtenerHabitat()
        {
            return "Acuático (Mar abierto)";
        }
    }

}
