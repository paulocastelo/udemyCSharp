using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder clientData = new StringBuilder();
            clientData.Append("\nClient: " + Name + " (" + BirthDate + ") - " + Email);
            return clientData.ToString();
        }

    }
}
