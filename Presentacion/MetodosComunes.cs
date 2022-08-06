using System;
using System.Collections.Generic;



namespace Presentacion
{
    public class MetodosComunes
    {

        public bool esNumero(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter))) 
                { 
                return false;
                }

            }
            return true;
        }


        public bool esTexto(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsLetter(caracter)))
                {
                    return false;
                }

            }
            return true;
        }



    }
}
