using System;
using System.Collections.Generic;
namespace _003_ex.Entities
{
    class Client
    {
        public string name { get; set; }
        public string mail { get; set; }
        public DateTime birthDate { get; set; }

        public Client() { }

        public Client(string name, string mail, DateTime birthDate)
        {
            this.name = name;
            this.mail = mail;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return "Client: " + name + " (" + birthDate.ToString("dd/MM/yyyy") + ") - " + mail;
        }
    }
}
