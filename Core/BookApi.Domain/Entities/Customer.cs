using BookWebApi.Domain;
using BookWebApi.Domain.Common;
using BookWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public Customer() { }
        public Customer(string name, string surname, string phone, string email)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
       
    }
}
