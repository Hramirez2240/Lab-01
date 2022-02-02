using System;
using System.Collections.Generic;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int eleccion, id_persona = 0, id_animal = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("[1]. Persona");
                Console.WriteLine("[2]. Animal");
                Console.WriteLine("[3]. Salir");
                Console.Write("Seleccione una de las opciones: ");
                eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.Clear();
                        int eleccion_persona;
                        Console.WriteLine("[1]. Agregar");
                        Console.WriteLine("[2]. Editar");
                        Console.WriteLine("[3]. Eliminar");
                        Console.WriteLine("[4]. Ver");
                        Console.Write("Seleccione una de las opciones: ");
                        eleccion_persona = int.Parse(Console.ReadLine());

                        switch (eleccion_persona)
                        {
                            case 1:
                                Console.Clear();
                                string nombre, cedula, sexo, telefono, respuesta_sexo;
                                int edad;

                                id_persona++;
                                Console.Write("Digite su nombre: ");
                                nombre = Console.ReadLine();

                                Console.Write("Digite su edad: ");
                                edad = int.Parse(Console.ReadLine());

                                Console.Write("Digite su cedula: ");
                                cedula = Console.ReadLine();

                                Console.Write("Digite su telefono: ");
                                telefono = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("[1]. Masculino");
                                Console.WriteLine("[2]. Femenino");
                                Console.Write("Digita el sexo de la persona: ");
                                respuesta_sexo = Console.ReadLine();

                                if (respuesta_sexo == "1")
                                {
                                    sexo = Sexo.Masculino.ToString();
                                    Datos_Persona datos_persona = new Datos_Persona(id_persona, nombre, edad, cedula, telefono, sexo);
                                    Datos_Persona.AgregarPersona(datos_persona);
                                    Console.WriteLine();
                                    datos_persona.Correr();
                                    Console.WriteLine();
                                    datos_persona.Verificacion(edad);
                                    Console.WriteLine();
                                    /*Datos_Persona datos_persona = new Datos_Persona();
                                    datos_persona.Id = id_persona;
                                    datos_persona.Nombre = nombre;
                                    datos_persona.Cedula = cedula;
                                    datos_persona.Telefono = telefono;
                                    datos_persona.Sexo = sexo;*/
                                }
                                else if (respuesta_sexo == "2")
                                {
                                    sexo = Sexo.Femenino.ToString();
                                    Datos_Persona datos_persona = new Datos_Persona(id_persona, nombre, edad, cedula, telefono, sexo);
                                    Datos_Persona.AgregarPersona(datos_persona);
                                    Console.WriteLine();
                                    datos_persona.Correr();
                                    Console.WriteLine();
                                    datos_persona.Verificacion(edad);
                                    Console.WriteLine();
                                }

                                Console.WriteLine("Persona agregada correctamente");
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.Clear();
                                Datos_Persona.VerPersonas();
                                Console.WriteLine();
                                int editar;
                                Console.Write("Digita el id de la persona a editar: ");
                                editar = int.Parse(Console.ReadLine());

                                Console.WriteLine();

                                Console.Write("Digite su nombre: ");
                                nombre = Console.ReadLine();

                                Console.Write("Digite su edad: ");
                                edad = int.Parse(Console.ReadLine());

                                Console.Write("Digite su cedula: ");
                                cedula = Console.ReadLine();

                                Console.Write("Digite su telefono: ");
                                telefono = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("[1]. Masculino");
                                Console.WriteLine("[2]. Femenino");
                                Console.Write("Digita el sexo de la persona: ");
                                respuesta_sexo = Console.ReadLine();

                                if (respuesta_sexo == "1")
                                {
                                    sexo = Sexo.Masculino.ToString();
                                    Datos_Persona.EditarPersona(editar, nombre, edad, cedula, telefono, sexo);
                                }

                                else if (respuesta_sexo == "2")
                                {
                                    sexo = Sexo.Femenino.ToString();
                                    Datos_Persona.EditarPersona(editar, nombre, edad, cedula, telefono, sexo);
                                }

                                Console.WriteLine("Persona editada");
                                Console.ReadLine();
                                break;

                            case 3:
                                Console.Clear();
                                Datos_Persona.VerPersonas();
                                Console.WriteLine();
                                int eliminar;
                                Console.Write("Digita el id de la persona a eliminar: ");
                                eliminar = int.Parse(Console.ReadLine());

                                Datos_Persona.EliminarPersona(eliminar);
                                Console.WriteLine("Persona eliminada correctamente");
                                Console.ReadLine();
                                break;

                            case 4:
                                Console.Clear();
                                Datos_Persona.VerPersonas();
                                Console.ReadLine();
                                break;
                        }

                        break;

                    case 2:
                        Console.Clear();
                        int eleccion_animal;
                        Console.WriteLine("[1]. Agregar");
                        Console.WriteLine("[2]. Editar");
                        Console.WriteLine("[3]. Eliminar");
                        Console.WriteLine("[4]. Ver");
                        Console.Write("Seleccione una de las opciones: ");
                        eleccion_animal = int.Parse(Console.ReadLine());

                        switch (eleccion_animal)
                        {
                            case 1:
                                Console.Clear();
                                string nombre, sexo, respuesta_sexo;
                                int edad;

                                id_animal++;
                                Console.Write("Digite su nombre: ");
                                nombre = Console.ReadLine();

                                Console.Write("Digite su edad: ");
                                edad = int.Parse(Console.ReadLine());

                                Console.WriteLine();
                                Console.WriteLine("[1]. Masculino");
                                Console.WriteLine("[2]. Femenino");
                                Console.Write("Digita el sexo de la persona: ");
                                respuesta_sexo = Console.ReadLine();

                                if (respuesta_sexo == "1")
                                {
                                    sexo = Sexo.Masculino.ToString();
                                    Datos_Animal datos_animal = new Datos_Animal(id_animal, nombre, edad, sexo);
                                    Datos_Animal.AgregarAnimal(datos_animal);
                                    Console.WriteLine();
                                    datos_animal.Correr();
                                    Console.WriteLine();
                                    datos_animal.Verificacion(edad);
                                    Console.WriteLine();
                                }

                                else if (respuesta_sexo == "2")
                                {
                                    sexo = Sexo.Femenino.ToString();
                                    Datos_Animal datos_animal = new Datos_Animal(id_animal, nombre, edad, sexo);
                                    Datos_Animal.AgregarAnimal(datos_animal);
                                    Console.WriteLine();
                                    datos_animal.Correr();
                                    Console.WriteLine();
                                    datos_animal.Verificacion(edad);
                                    Console.WriteLine();
                                }

                                Console.WriteLine("Animal agregado correctamente");
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.Clear();
                                Datos_Animal.VerAnimales();
                                Console.WriteLine();
                                int editar;
                                Console.Write("Digita el id del animal a editar: ");
                                editar = int.Parse(Console.ReadLine());

                                Console.WriteLine();

                                Console.Write("Digite su nombre: ");
                                nombre = Console.ReadLine();

                                Console.Write("Digite su edad: ");
                                edad = int.Parse(Console.ReadLine());

                                Console.WriteLine();
                                Console.WriteLine("[1]. Masculino");
                                Console.WriteLine("[2]. Femenino");
                                Console.Write("Digita el sexo del animal: ");
                                respuesta_sexo = Console.ReadLine();

                                if (respuesta_sexo == "1")
                                {
                                    sexo = Sexo.Masculino.ToString();
                                    Datos_Animal.EditarAnimales(editar, nombre, edad, sexo);
                                }

                                else if (respuesta_sexo == "2")
                                {
                                    sexo = Sexo.Femenino.ToString();
                                    Datos_Animal.EditarAnimales(editar, nombre, edad, sexo);
                                }

                                Console.WriteLine("Animal editada");
                                Console.ReadLine();
                                break;

                            case 3:
                                Console.Clear();
                                Datos_Animal.VerAnimales();
                                Console.WriteLine();
                                int eliminar;
                                Console.Write("Digita el id del animal a eliminar: ");
                                eliminar = int.Parse(Console.ReadLine());

                                Datos_Animal.EliminarAnimal(eliminar);
                                Console.WriteLine("Animal eliminado correctamente");
                                Console.ReadLine();
                                break;

                            case 4:
                                Console.Clear();
                                Datos_Animal.VerAnimales();
                                Console.ReadLine();
                                break;

                            case 5:
                                Console.Clear();

                                Console.ReadLine();
                                break;
                        }

                        break;

                    case 3:
                        salir = true;
                        break;
                }
            } while (!salir);
        }
    }

    public interface ICorrer
    {
        public void Correr();

        //public void Agregar<T>(T persona);
    }

    /*public interface ICRUD<TFirst> where TFirst : Padre
    {
        TFirst Agregar(TFirst entity);
    }*/

    public enum Sexo
    {
        Masculino,
        Femenino
    }
    
}
