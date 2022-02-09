using Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Services
{
    public class PersonService : BaseService<Person>, IActionService
    {

        public override void Get()
        {
            Console.WriteLine("----------Listado de personas----------");
            foreach (Person person in GlobalList)
            {
                Console.WriteLine(person.Id);
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Dni);
                Console.WriteLine(person.Telephone);
                Console.WriteLine(person.Gender);
                Console.WriteLine();
            }
        }

        public override bool Edit(Person entity)
        {
            foreach (Person person in GlobalList)
            {
                if (person.Id.Equals(entity.Id))
                {
                    person.Name = entity.Name;
                    person.Age = entity.Age;
                    person.Dni = entity.Dni;
                    person.Telephone = entity.Telephone;
                    person.Gender = entity.Gender;
                    return true;
                }
            }

            return false;
        }

        public void Run()
        {
            Console.WriteLine("Persona corriendo con dos piernas...");
        }

        public void Verification(int age)
        {
            int ageToDrink = 18;

            if (age >= ageToDrink)
            {
                Console.WriteLine("La persona es mayor de edad");
            }

            else
            {
                Console.WriteLine("La persona es menor de edad");
            }
        }
    }
}
