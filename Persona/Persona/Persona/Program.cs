using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            persona p2 = new persona();
            p2.Nombre = "Miriam";
            p2.Apellido = "Chen";
            p2.Edad = 22;

            Console.WriteLine("Se llama: "+ p2.Nombre + System.Environment.NewLine +
                "Su apellido es: " + p2.Apellido + System.Environment.NewLine +
                "Tiene: " + p2.Edad.ToString() + "años");
            Console.ReadKey();
        }

        public class persona
        {
            private string _nombre;
            private string _apellido;
            private int _edad;
          
            public string Nombre
            {
                get
                {
                    return _nombre;
                }
                set
                {
                    _nombre = value;
                }
            }
           
            public string Apellido
            {
                get
                {
                    return _apellido;
                }
                set
                {
                    _apellido = value;
                }
            }

            public int Edad
            {
                get
                {
                    return _edad;
                }
                set
                {
                    _edad = value;
                }
            }
        }
    }
}
