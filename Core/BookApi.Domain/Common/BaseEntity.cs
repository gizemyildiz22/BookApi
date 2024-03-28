﻿using BookWebApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWebApi.Domain.Entities.Common
{
    public class BaseEntity:IBaseEntity

    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public bool IsDeleted { get; set; } = false;

       
    }
}
