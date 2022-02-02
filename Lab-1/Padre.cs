using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class Padre
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }

        public virtual void Verificacion(int edad)
        {
            if(edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }

            else
            {
                Console.WriteLine("Usted es menor de edad");
            }
        }
    }
}
