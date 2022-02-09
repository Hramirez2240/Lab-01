using Lab_1.Enum;
using Lab_1.Models;
using Lab_1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class MenuAnimal
    {
        public static void Menu(int animalid, AnimalService animal_service, bool exit)
        {
            do
            {
                Console.Clear();
                int eleccion_animal;
                Console.WriteLine("[1]. Agregar");
                Console.WriteLine("[2]. Editar");
                Console.WriteLine("[3]. Eliminar");
                Console.WriteLine("[4]. Ver");
                Console.WriteLine("[5]. Correr");
                Console.WriteLine("[6]. Salir");
                Console.Write("Seleccione una de las opciones: ");
                eleccion_animal = int.Parse(Console.ReadLine());

                switch (eleccion_animal)
                {
                    case 1:
                        Console.Clear();
                        string name, gender, gender_answuer;
                        int age;

                        animalid++;
                        Console.Write("Digite su nombre: ");
                        name = Console.ReadLine();

                        Console.Write("Digite su edad: ");
                        age = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("[1]. Masculino");
                        Console.WriteLine("[2]. Femenino");
                        Console.Write("Digita el sexo de la persona: ");
                        gender_answuer = Console.ReadLine();

                        gender = (gender_answuer == "1") ? Gender.Masculino.ToString() : Gender.Femenino.ToString();

                        Animal animal = new Animal()
                        {
                            Id = animalid,
                            Name = name,
                            Age = age,
                            Gender = gender,
                        };

                        animal_service.Verification(age);
                        Console.WriteLine();

                        animal_service.Add(animal);

                        Console.WriteLine();

                        Console.WriteLine("Animal agregado correctamente");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();

                        animal_service.Get();
                        Console.WriteLine();

                        int edit;
                        Console.Write("Digita el id del animal a editar: ");
                        edit = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("Digite su nombre: ");
                        name = Console.ReadLine();

                        Console.Write("Digite su edad: ");
                        age = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("[1]. Masculino");
                        Console.WriteLine("[2]. Femenino");
                        Console.Write("Digita el sexo del animal: ");
                        gender_answuer = Console.ReadLine();

                        gender = (gender_answuer == "1") ? Gender.Masculino.ToString() : Gender.Femenino.ToString();

                        animal = new Animal()
                        {
                            Id = animalid,
                            Name = name,
                            Age = age,
                            Gender = gender,
                        };

                        animal_service.Edit(animal);
                        Console.WriteLine();

                        Console.WriteLine("Animal editado");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();

                        animal_service.Get();
                        Console.WriteLine();

                        int delete;
                        Console.Write("Digita el id del animal a eliminar: ");
                        delete = int.Parse(Console.ReadLine());

                        animal_service.Delete(delete);
                        Console.WriteLine("Animal eliminado correctamente");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        animal_service.Get();
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.Clear();
                        animal_service.Run();
                        Console.ReadLine();
                        break;

                    case 6:
                        Console.Clear();
                        exit = true;
                        break;
                }
            } while (!exit);
            
        }
    }
}
