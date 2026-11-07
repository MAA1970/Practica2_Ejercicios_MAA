using System;
using System.Collections.Generic;
using System.Text;

namespace P2_Ejercicio1_4_5
{
    public class Cadena
    {
        public string inviertePalabras(string laFrase)
        {
            string palabra, fraseInvertida;
            int lontd, posicionFinal;
            char ESPACIO = ' ';
            char letra;

            laFrase = laFrase.Trim();
            lontd = laFrase.Length - 1;
            posicionFinal = 0;
            fraseInvertida = "";

            while (lontd >= 0)
            {

                letra = laFrase[lontd];

                if (letra == ESPACIO)
                {

                    palabra = laFrase.Substring(lontd + 1, posicionFinal);
                    fraseInvertida = fraseInvertida + palabra + " ";
                    palabra = "";
                    posicionFinal = 0;
                }

                else
                {
                    posicionFinal = posicionFinal + 1;
                }

                lontd--;

            }

            if (posicionFinal > 0)
            {
                // Integra la última palabra
                palabra = laFrase.Substring(lontd + 1, posicionFinal);
                fraseInvertida = fraseInvertida + palabra;
            }

            fraseInvertida = fraseInvertida.Trim();

            return fraseInvertida;
        }

        // EJERCICIO 4 (Procediminto que generará las llamadas a las hojas)
        public void armaArbol(int niveles)
        {
            const string ESPACIO = " ";
            const string HOJA = "*";
            const string TRONCO = "|";
            string cadenaBlancos;
            string cadenaHojas;

            int e = niveles - 1;
            int j = 1;
            int nTroncoEspacio = 0;
            int nTroncoHoja = 0;
            // Ciclo que genera y muestra hojas..
            for (int i = 0; i < niveles; i++)
            {
                cadenaBlancos = "";
                cadenaHojas = "";

                if (e > 0)
                { cadenaBlancos = juntaCadenas(ESPACIO, e); }
                cadenaHojas = juntaCadenas(HOJA, j);
                Console.WriteLine(cadenaBlancos + cadenaHojas);

                //If que toma la referencia para el tronco
                if (i == 1)
                {
                    nTroncoEspacio = e;
                    nTroncoHoja = j;
                }

                e--;
                j = j + 2;

            }
            cadenaBlancos = String.Empty;
            cadenaHojas = String.Empty;

            cadenaBlancos = juntaCadenas(ESPACIO, nTroncoEspacio);
            cadenaHojas = juntaCadenas(TRONCO, nTroncoHoja);

            // Ciclo que genera y muestra tronco..
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(cadenaBlancos + cadenaHojas);
            }

        }

        public static string juntaCadenas(string michar, int largo)
        {
            int i;
            string miCadena = "";
            for (i = 0; i < largo; i++)
            {
                miCadena = miCadena + michar;
            }
            return miCadena;
        }

        // <<< METODOS DEL EJERCICIO 4

        // METODOS DEL EJERCICIO 5 (Verifica Palíndromo)

        public string cadenaPalindromo(string frasePal)
        {
            string fraseIni, fraseFin, fraseRetorno;

            frasePal = frasePal.Trim();
            fraseIni = compactaCadena(frasePal, true);
            fraseFin = compactaCadena(frasePal, false);
            if (fraseIni == fraseFin)
                fraseRetorno = "Es palíndromo";
            else
                fraseRetorno = "NO es palíndromo";

            return fraseRetorno;
        }

        public static string compactaCadena(string sCadena, bool izqDer)
        {
            int lonPal, pos;
            int contador = 0;
            string armaCadena;
            char letra;
            char ESPACIO = ' ';

            lonPal = sCadena.Length - 1;
            armaCadena = string.Empty;

            if (izqDer == true)
                pos = 0;
            else
                pos = lonPal;


            while (contador <= lonPal)
            {
                letra = sCadena[pos];
                if (letra != ESPACIO)
                {
                    armaCadena = armaCadena + letra;
                }
                if (izqDer == true)
                    pos++;
                else
                    pos--;
                contador++;
            }
            armaCadena = armaCadena.ToLower();
            return armaCadena;

            // <<< METODOS DEL EJERCICIO 5



        }
    }
}

