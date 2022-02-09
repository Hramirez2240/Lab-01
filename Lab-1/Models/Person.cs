using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1.Models
{
    public class Person : BaseModel
    {
        public string Dni { get; set; }
        public string? Telephone { get; set; }
    }
}
