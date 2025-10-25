﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public Animal( string name) {
         this.Name = name;
        }


        public abstract void MakeSound();
       
    }
}
