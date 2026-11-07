using System;
using System.Collections.Generic;
using System.Text;

namespace P2_Ejercicio8
{
    // a) Jerarquía de clases (atributos): Animal (Clase Padre)
    public abstract class Animal
    {
        private string? nombre;
        private string? especie;
        private string? raza;
        private int edad;
        private DateTime fechaNacimiento;
        private string? observaciones;

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Especie { get => especie; set => especie = value; }
        public string? Raza { get => raza; set => raza = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string? Observaciones { get => observaciones; set => observaciones = value; }

        //b) Metodo cumpleanios abstracto 
        public abstract void cumpleanios();

        //c) Metodo alimentacion abstracto 
        public abstract void alimentacion();

        //e) Método abstracto obtiene el hábitat
        public abstract string ObtenerHabitat();

    }




}
