using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_MetodoReversePalabra
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "a";
            ReverseWords(ref texto);
            Console.WriteLine(texto);
        }
        static void ReverseWords(ref string texto)
        {
            string[] textos=texto.Split(' ');

            for(int i = 0; i < textos.Length; i++)
            {
                Reverse(ref textos[i]);  
            }

            string nuevo1 = "";
            for (int i = 0; i < textos.Length; i++)
            {
                if (i != texto.Length - 1)
                {
                    nuevo1 += textos[i] + " ";
                }
                else
                {
                    nuevo1 += textos[i];
                }
            }

            //string nuevo = string.Join(" ",textos);
            texto = nuevo1;
            
        }
        static void Reverse(ref string texto)
        {
            char[] arr = texto.ToCharArray();
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length/2; i++)
            {
                char aux = arr[i];
                //arr[i] = arr[arr.Length - i - 1];
                //arr[arr.Length - i - 1]=aux;
                arr[i] = arr[j];
                arr[j]=aux;
                j--;
            }

            texto = new string(arr);
        }
    }
}
