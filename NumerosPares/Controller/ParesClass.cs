using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares.Controller
{
    internal class ParesClass
    {
        public string calcularPares(int valor)
        {
            string numeropar = "";

            if(valor % 2 == 0)
            {
                numeropar = valor + " seu Número é Par";
            }
            else
            {
                numeropar = valor + " Seu Número é impar";
            }
            return numeropar;

            
        }
    }
}
