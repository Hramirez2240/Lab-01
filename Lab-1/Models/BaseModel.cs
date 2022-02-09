using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public virtual void Verification()
        {
            if (Age >= 18)
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
