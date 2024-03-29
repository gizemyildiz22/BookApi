﻿using BookApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApi.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string Password { get; set; }
        public string CustomerDescription { get; set; }
        public bool IsActive { get; set; }=false;
        public ICollection<Order> Orders { get; set; }

    }
}
