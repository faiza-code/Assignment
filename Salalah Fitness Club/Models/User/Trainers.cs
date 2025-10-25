using MakeenAssignment.Salalah_Fitness_Club.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Salalah_Fitness_Club.Models.User
{
    public class Trainers : Person
    {
        public string Specialization { get; set; }
        public decimal MyProperty1 { get; set; }

        public int MyProperty2 { get; set; }
        public Trainers(int id, string name, string email, int phoneNumber, int age, Gender gender)
        : base(id, name, email, phoneNumber, age, gender)
        {
        }







    }
}
