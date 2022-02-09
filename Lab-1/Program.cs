using Lab_1.Enum;
using Lab_1.Models;
using Lab_1.Services;
using System;
using System.Collections.Generic;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            int election, id = 0;

            AnimalService animal_service = new AnimalService();
            PersonService person_service = new PersonService();

            do
            {
                Console.Clear();
                Console.WriteLine("[1]. Persona");
                Console.WriteLine("[2]. Animal");
                Console.WriteLine("[3]. Salir");
                Console.Write("Seleccione una de las opciones: ");
                election = int.Parse(Console.ReadLine());

                switch (election)
                {
                    case 1:
                        Console.Clear();
                        MenuPerson.Menu(id, person_service, Exit);
                        break;

                    case 2:
                        Console.Clear();
                        MenuAnimal.Menu(id, animal_service, Exit);
                        break;

                    case 3:
                        Exit = true;
                        break;
                }
            } while (!Exit);
        }
    }
    
}
