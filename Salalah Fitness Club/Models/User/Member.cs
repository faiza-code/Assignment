using MakeenAssignment.Salalah_Fitness_Club.Enums;
using MakeenAssignment.Salalah_Fitness_Club.Models.FitnessClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Salalah_Fitness_Club.Models.User
{
    public class Member : Person
    {
        public MemberShapType ShapType { get; set; }
        public List<Fitness> regesteredClasses { get; set; }

        public Member(int id, string name, string email, int phoneNumber, int age, Gender gender)
        : base(id, name, email, phoneNumber, age, gender)
        {
            this.ShapType = ShapType;
            regesteredClasses = new List<Fitness>();

        }

         public string RegisterToClass(Fitness fitness)
        {
            if (fitness.nunberOfNumber < fitness.members.Count())
            {
                fitness.members[fitness.members.Count() - 1] = this;
                this.regesteredClasses.Add(fitness);
                return "registered Successfully ";
            }
            else
            {
                return "already full we will put you on the waiting list ";
            }
        }


        public List<Fitness> ShowAllRegiesteredClasses()
        {
            return regesteredClasses;
        }

    }
}

