using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public class Datos_Persona : Padre, ICorrer
    {
        public string Cedula { get; set; }
        public string? Telefono { get; set; }

        public static List<Datos_Persona> Persona = new List<Datos_Persona>();

        public Datos_Persona(int id, string nombre, int edad, string cedula, string telefono, string sexo)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Cedula = cedula;
            Telefono = telefono;
            Sexo = sexo; 
        }

        public static Datos_Persona GetId(int id)
        {
            foreach (Datos_Persona persona in Persona)
            {
                if (persona.Id.Equals(id))
                {
                    return persona;
                }
            }

            return null;
        }

        public static void AgregarPersona(Datos_Persona persona)
        {
            Persona.Add(persona);
        }

        public static bool EliminarPersona(int id)
        {
            Datos_Persona persona_eliminar = Datos_Persona.GetId(id);
            if(persona_eliminar != null)
            {
                Persona.Remove(persona_eliminar);
                return true;
            }

            return false;
        }

        public static bool EditarPersona(int id, string nombre, int edad, string cedula, string telefono, string sexo)
        {
            foreach (Datos_Persona persona_editar in Persona)
            {
                if (persona_editar.Id.Equals(id))
                {
                    persona_editar.Nombre = nombre;
                    persona_editar.Edad = edad;
                    persona_editar.Cedula = cedula;
                    persona_editar.Telefono = telefono;
                    persona_editar.Sexo = sexo;
                    return true;
                }
            }

            return false;
        }

        public static void VerPersonas()
        {
            Console.WriteLine("----------Total de personas----------");
            foreach (Datos_Persona persona in Persona)
            {
                Console.WriteLine(persona.Id);
                Console.WriteLine(persona.Nombre);
                Console.WriteLine(persona.Edad);
                Console.WriteLine(persona.Telefono);
                Console.WriteLine(persona.Cedula);
                Console.WriteLine(persona.Sexo);
                Console.WriteLine();
            }
        }

        public void Correr()
        {
            Console.WriteLine("Persona corriendo...");
        }
    }
}
