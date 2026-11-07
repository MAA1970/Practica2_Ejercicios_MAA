using System;
using System.Collections.Generic;
using System.Text;

namespace P2_Ejercicio10
{

    public class Circulo : IForma
    {
        double radio;

        public double Radio { get => radio; set => radio = value; }

        public double area => (Math.PI * (radio * radio));

        //Constructor con párametros de base y altura
        public Circulo(double radio)
        {
            this.Radio = radio;
        }

    }

}
