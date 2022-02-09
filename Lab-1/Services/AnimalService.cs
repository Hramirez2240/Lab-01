using Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Services
{
    public class AnimalService : BaseService<Animal>, IActionService
    {

        public void Run()
        {
            Console.WriteLine("Animal corriendo en cuatro patas...");
        }

        public void Verification(int age)
        {

            if (age >= 12)
            {
                Console.WriteLine("El animal es viejo");
            }

            else
            {
                Console.WriteLine("El animal es joven");
            }
        }
    }
}
