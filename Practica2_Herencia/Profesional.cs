using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2_Herencia
{
    public class Profesional
    {
        //Atributos
        private DateTime fechaEgreso;
        private long nroTituloAcademico;
        private string cedulaIdentidad;
        private string nombres;
        private string primerApellido;
        private string segundoApellido;
        private string direccion;
        private DateTime fechaNacimiento;
        private string universidad;
        private string zona;

        public DateTime FechaEgreso { get => fechaEgreso; set => fechaEgreso = value; }
        public long NroTituloAcademico { get => nroTituloAcademico; set => nroTituloAcademico = value; }
        public string CedulaIdentidad { get => cedulaIdentidad; set => cedulaIdentidad = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Universidad { get => universidad; set => universidad = value; }
        public string Zona { get => zona; set => zona = value; }

        // Constructor de la clase Profesional
        public Profesional(DateTime fechaEgreso, long nroTituloAcademico, string cedulaIdentidad, string nombres, string primerApellido, string segundoApellido, string direccion, DateTime fechaNacimiento, string universidad, string zona)
        {
            FechaEgreso = fechaEgreso;
            NroTituloAcademico = nroTituloAcademico;
            CedulaIdentidad = cedulaIdentidad;
            Nombres = nombres;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Universidad = universidad;
            Zona = zona;
        }

        // Método para calcular la edad en años
        public int CalcularEdad()
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        // Método para mostrar datos personales
        public virtual string ObtenerDatosPersonales()
        {
            return $"Nombre: {Nombres} {PrimerApellido} {SegundoApellido}\n" +
                   $"Cédula: {CedulaIdentidad}\n" +
                   $"Dirección: {Direccion}\n" +
                   $"Fecha de Nacimiento: {FechaNacimiento:dd/MM/yyyy}";
        }
        public void cumpleanios(Profesional profesional)
        {
            //Instrucciones del método cumpleanios
            Console.WriteLine($"{Nombres} {PrimerApellido} está celebrando su cumpleaños.");
        }

    }
}
