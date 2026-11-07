using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2_Herencia
{
    public class Abogado : Profesional
    {
        //Atributos
        private string? nombreJuzgado;
        private int? nroJuiciosProceso;
        private long? nroJuiciosFinalizado;

        public string? NombreJuzgado { get => nombreJuzgado; set => nombreJuzgado = value; }
        public int? NroJuiciosProceso { get => nroJuiciosProceso; set => nroJuiciosProceso = value; }
        public long? NroJuiciosFinalizado { get => nroJuiciosFinalizado; set => nroJuiciosFinalizado = value; }

        // Constructor de Abogado utilizando base(...) para inicializar los atributos heredados
        public Abogado(DateTime fechaEgreso, long nroTituloAcademico, string cedulaIdentidad, string nombres, string primerApellido, string segundoApellido, string direccion, DateTime fechaNacimiento, string universidad, string zona,
                       string nombreJuzgado, int nroJuiciosProceso, long nroJuiciosFinalizado) : base(fechaEgreso, nroTituloAcademico, cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, fechaNacimiento,universidad, zona)
        {
            NombreJuzgado = nombreJuzgado;
            NroJuiciosProceso = nroJuiciosProceso;
            NroJuiciosFinalizado = nroJuiciosFinalizado;
        }

        // Método para mostrar datos laborales
        public string ObtenerDatosLaborales()
        {
            return $"Juzgado: {NombreJuzgado}\n" +
                   $"Juicios en Proceso: {NroJuiciosProceso}\n" +
                   $"Juicios Finalizados: {NroJuiciosFinalizado}\n" +
                   $"Nro. Titulo Académico: {NroTituloAcademico}";
        }

        //public override void Cumpleanios()
        public void cumpleanios(Abogado abogado)
        {
            //Instrucciones del método cumpleanios
            Console.WriteLine($"El abogado {Nombres} {PrimerApellido} adscrito al juzgado {NombreJuzgado} está celebrando su cumpleaños.");
        }

    }
}
