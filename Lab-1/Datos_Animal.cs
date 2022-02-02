using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class Datos_Animal : Padre, ICorrer
    {
        public static List<Datos_Animal> Animal = new List<Datos_Animal>();

        public Datos_Animal(int id, string nombre, int edad, string sexo)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }

        public static Datos_Animal GetId(int id)
        {
            foreach (Datos_Animal animal in Animal)
            {
                if (animal.Id.Equals(id))
                {
                    return animal;
                }
            }

            return null;
        }

        public static void AgregarAnimal(Datos_Animal animal)
        {
            Animal.Add(animal);
        }

        public static bool EliminarAnimal(int id)
        {
            Datos_Animal animal_eliminar = Datos_Animal.GetId(id);
            if (animal_eliminar != null)
            {
                Animal.Remove(animal_eliminar);
                return true;
            }

            return false;
        }

        public static bool EditarAnimales(int id, string nombre, int edad, string sexo)
        {
            foreach (Datos_Animal animal_editar in Animal)
            {
                if (animal_editar.Id.Equals(id))
                {
                    animal_editar.Nombre = nombre;
                    animal_editar.Edad = edad;
                    animal_editar.Sexo = sexo;
                    return true;
                }
            }

            return false;
        }

        public static void VerAnimales()
        {
            Console.WriteLine("----------Total de animales----------");
            foreach (Datos_Animal animal in Animal)
            {
                Console.WriteLine(animal.Id);
                Console.WriteLine(animal.Nombre);
                Console.WriteLine(animal.Edad);
                Console.WriteLine(animal.Sexo);
                Console.WriteLine();
            }
        }

        public void Correr()
        {
            Console.WriteLine("Animal corriendo...");
        }

        public override void Verificacion(int edad)
        {
            if(edad >= 12)
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
