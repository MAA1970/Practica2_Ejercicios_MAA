using System;
using System.Collections.Generic;
using System.Text;

namespace P2_Ejercicio8
{
    // a) Jerarquía de clases (atributos): Perro (Clase Hija)
    public class Perro : Animal
    {
        private int cantidadPatas;
        private string? colorPelaje;

        public int CantidadPatas { get => cantidadPatas; set => cantidadPatas = value; }
        public string? ColorPelaje { get => colorPelaje; set => colorPelaje = value; }

        //public string? habitat;  // Es habitat un atributo, más que un método


        public override void cumpleanios()
        {
            Edad++;
            Console.WriteLine($"{Nombre} el perro está cumpliendo años. ¡Ahora tiene {Edad} años!");
        }

        public override void alimentacion()
        {
            Console.WriteLine($"{Nombre} se alimenta con croquetas y alimento seco.");
        }

        public override string ObtenerHabitat()
        {
            return "Terrestre (Doméstico/Callejero)";
        }
    }

}
