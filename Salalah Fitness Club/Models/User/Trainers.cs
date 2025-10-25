using MakeenAssignment.Salalah_Fitness_Club.Enums;
using MakeenAssignment.Salalah_Fitness_Club.Models.FitnessClass;
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
        public decimal loggedHours { get; set; }
        public decimal ratePerHour { get; set; }
        public List<Fitness> AssignedClass { get; set; }
        public Trainers(int id, string name, string email, int phoneNumber, int age, Gender gender)
        : base(id, name, email, phoneNumber, age, gender)
        {
        }

        public string AssignToClass(Fitness fitness)
        {
            if (fitness.trainers is null)
            {
                AssignedClass.Add(fitness);
                return "Added Successfully";
            }
            else
            {
                return "the Class already has atrainer";
            }

        }

        public List<Fitness> ShowAssignedClasses()
        {
            return AssignedClass;
        }





    }
}
