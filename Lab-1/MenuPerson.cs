using Lab_1.Enum;
using Lab_1.Models;
using Lab_1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class MenuPerson
    {
        public static void Menu(int personid, PersonService person_service, bool exit)
        {
            do
            {
                Console.Clear();
                int person_election;
                Console.WriteLine("[1]. Agregar");
                Console.WriteLine("[2]. Editar");
                Console.WriteLine("[3]. Eliminar");
                Console.WriteLine("[4]. Ver");
                Console.WriteLine("[5]. Correr");
                Console.WriteLine("[6]. Salir");
                Console.Write("Seleccione una de las opciones: ");
                person_election = int.Parse(Console.ReadLine());

                switch (person_election)
                {
                    case 1:
                        Console.Clear();
                        string name, identification, gender, telephone, gender_answer;
                        int age;

                        personid++;
                        Console.Write("Digite su nombre: ");
                        name = Console.ReadLine();

                        Console.Write("Digite su edad: ");
                        age = int.Parse(Console.ReadLine());

                        Console.Write("Digite su cedula: ");
                        identification = Console.ReadLine();

                        Console.Write("Digite su telefono: ");
                        telephone = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("[1]. Masculino");
                        Console.WriteLine("[2]. Femenino");
                        Console.Write("Digita el sexo de la persona: ");
                        gender_answer = Console.ReadLine();

                        gender = (gender_answer == "1") ? Gender.Masculino.ToString() : Gender.Femenino.ToString();

                        Person person = new Person()
                        {
                            Id = personid,
                            Name = name,
                            Age = age,
                            Dni = identification,
                            Telephone = telephone,
                            Gender = gender,
                        };

                        person_service.Verification(age);

                        Console.WriteLine();
                        person_service.Add(person);

                        Console.WriteLine();

                        Console.WriteLine("Persona agregada correctamente");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();

                        person_service.Get();
                        Console.WriteLine();

                        int edit;
                        Console.Write("Digita el id de la persona a editar: ");
                        edit = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("Digite su nombre: ");
                        name = Console.ReadLine();

                        Console.Write("Digite su edad: ");
                        age = int.Parse(Console.ReadLine());

                        Console.Write("Digite su cedula: ");
                        identification = Console.ReadLine();

                        Console.Write("Digite su telefono: ");
                        telephone = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("[1]. Masculino");
                        Console.WriteLine("[2]. Femenino");
                        Console.Write("Digita el sexo de la persona: ");
                        gender_answer = Console.ReadLine();

                        gender = (gender_answer == "1") ? Gender.Masculino.ToString() : Gender.Femenino.ToString();
                        person = new Person()
                        {
                            Id = edit,
                            Name = name,
                            Age = age,
                            Dni = identification,
                            Telephone = telephone,
                            Gender = gender,
                        };

                        person_service.Edit(person);

                        Console.WriteLine("Persona editada");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        person_service.Get();
                        Console.WriteLine();

                        int delete;
                        Console.Write("Digita el id de la persona a eliminar: ");
                        delete = int.Parse(Console.ReadLine());

                        person_service.Delete(delete);
                        Console.WriteLine("Persona eliminada correctamente");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        person_service.Get();
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.Clear();
                        person_service.Run();
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
