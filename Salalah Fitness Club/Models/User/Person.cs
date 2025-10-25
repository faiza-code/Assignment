using MakeenAssignment.Salalah_Fitness_Club.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Salalah_Fitness_Club.Models.User

{
    public abstract class Person
    {
        public  Person(int id, string name, string email, int phoneNumber, int age, Gender gender)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            this.age = age;
            this.gender = gender;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public int age { get; set; }

        public  Gender gender { get; set; }


        public virtual  string DisplayInfo()
        {
            return $"Name is{this.Name}\n "+
                   $"Email is{this.Email}\n " +
                   $"PhoneNumber is{this.PhoneNumber}\n " ;
        }











    }
}
