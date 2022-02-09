using Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseModel, new()
    {
        public static List<T> GlobalList = new List<T>();

        public virtual void Get()
        {
            Console.WriteLine("----------Listado de animales----------");
            foreach (T entity in GlobalList)
            {
                Console.WriteLine(entity.Id);
                Console.WriteLine(entity.Name);
                Console.WriteLine(entity.Age);
                Console.WriteLine(entity.Gender);
                Console.WriteLine();
            }
        }

        public T GetId(int id)
        {
            foreach (T entity in GlobalList)
            {
                if (entity.Id.Equals(id))
                {
                    return entity;
                }
            }

            return null;
        }

        public void Add(T entity)
        {
            GlobalList.Add(entity);
        }

        public bool Delete(int id)
        {
            var delete = new BaseService<T>();

            var deleted = delete.GetId(id);
            if (deleted != null)
            {
                GlobalList.Remove(deleted);
                return true;
            }

            return false;
        }

        public virtual bool Edit(T entity)
        {
            foreach (T edited in GlobalList)
            {
                if (edited.Id.Equals(entity.Id))
                {
                    edited.Name = entity.Name;
                    edited.Age = entity.Age;
                    edited.Gender = entity.Gender;
                    return true;
                }
            }

            return false;
        }
    }
}
