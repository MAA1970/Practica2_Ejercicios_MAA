using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2_Herencia
{
    public class Medico : Profesional
    {
        //Atributos
        private string unidadTrabajo;
        private long nroConsultasMedicas;
        private long nroConsultasDomicilio;
        private long nroCirugias;

        public string UnidadTrabajo { get => unidadTrabajo; set => unidadTrabajo = value; }
        public long NroConsultasMedicas { get => nroConsultasMedicas; set => nroConsultasMedicas = value; }
        public long NroConsultasDomicilio { get => nroConsultasDomicilio; set => nroConsultasDomicilio = value; }
        public long NroCirugias { get => nroCirugias; set => nroCirugias = value; }

        // Constructor de Medico utilizando base(...) para inicializar los atributos heredados
        public Medico(DateTime fechaEgreso, long nroTituloAcademico, string cedulaIdentidad, string nombres, string primerApellido, string segundoApellido, string direccion, DateTime fechaNacimiento, string universidad, string zona,
                      string unidadTrabajo, long nroConsultasMedicas, long nroConsultasDomicilio, long nroCirugias) : base(fechaEgreso, nroTituloAcademico, cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, fechaNacimiento, universidad,zona)
        {
            UnidadTrabajo = unidadTrabajo;
            NroConsultasMedicas = nroConsultasMedicas;
            NroConsultasDomicilio = nroConsultasDomicilio;
            NroCirugias = nroCirugias;
        }

        //public override void Cumpleanios()
        public void cumpleanios(Medico medico)
        {
            //Instrucciones del método cumpleanios
            Console.WriteLine($"El médico {Nombres} {PrimerApellido} está celebrando su cumpleaños en la unidad: {UnidadTrabajo}.");
        }

    }
}
