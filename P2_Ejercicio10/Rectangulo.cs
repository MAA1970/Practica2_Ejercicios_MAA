using P2_Ejercicio10;
using System;
using System.Collections.Generic;
using System.Text;

namespace P2_Ejercicio10
{
   

}
public class Rectangulo : IForma
{
    double altura;
    double miBase;

    public double Altura { get => altura; set => altura = value; }
    public double MiBase { get => miBase; set => miBase = value; }

    public double area => miBase * altura;

    //Constructor con párametros de base y altura
    public Rectangulo(double altura, double mibase)
    {
        this.Altura = altura;
        this.miBase = mibase;
    }


}