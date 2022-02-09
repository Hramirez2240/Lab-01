using Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Services
{
    public interface IBaseService<T> where T : BaseModel
    {
        public void Get();
        public T GetId(int id);

        public void Add(T entity);

        public bool Delete(int id);

        public bool Edit(T entity);
    }
}
