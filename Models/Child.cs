﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string UserId { get; set; }

        public Child()
        {
        }
    }
}
