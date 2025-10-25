using MakeenAssignment.Salalah_Fitness_Club.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Salalah_Fitness_Club.Models.FitnessClass
{
    public class Fitness
    {
        public string ClassName { get; set; }

        public string Schedule { get; set; }
        public Trainers trainers { get; set; } //instance
        public Member[] members { get; set; } //List <number> //array of class member

        public int nunberOfNumber { get; set; }

        public Fitness(string className, string schedule, Trainers trainers, Member[] members)
        {
            ClassName = className;
            Schedule = schedule;
            this.trainers = trainers;
            members = new Member[nunberOfNumber];
        }

        

        public string AddMember(Member member)
        {
            if (this.nunberOfNumber < members.Count())
            {
                members[members.Count() - 1] = member;
                return "Added Suuccesfully";

            }
            return "the Class is full sorry ";
        }
        public string DisplayClassInfo()
        {
            string result = $"Welcome to {this.ClassName} Class " +
                $"\n the Class will be At {this.Schedule} " +
                $"\n with trainer : {this.trainers.Name} ";
            return result;
        }











    }
}
