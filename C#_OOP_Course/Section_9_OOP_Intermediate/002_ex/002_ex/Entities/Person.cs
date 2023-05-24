using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ex.Entities
{
    class Person
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; }

        public Person(string name, string mail, DateTime birthDate, string cpf)
        {
            Name = name;
            Mail = mail;
            BirthDate = birthDate;
            CPF = cpf;
        }

        public override string ToString()
        {
            return $"Name: {Name} || Mail: {Mail} || Birth Date: {BirthDate} || CPF: {CPF}";
        }
    }
}
