using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment2
{
    public class SimpleQuizApp
    {
        static void Main(string[] args)
        {
            string[] questions = { " Which of the following is the correct default value of a Boolean type in C#?",
                " Which keyword is used to define a class in C#?",
                " To perform a comparison operation on strings, which of the following supported operations can be used?",
                " Which of the following statements is correct about access specifiers in C#?",
                " What does the term 'immutable' mean in terms of string objects in C#?" 
            };


         
            string[][] options = { 
                new string[] { "0", "1", "TRUE", "false " },
                new string[] { "struct", "interface", "class", "enum " },
                new string[] { "Compare()", "Equals()", "Assignment == operator" ,"All of the above"},
                new string[] { "Encapsulation is implemented by using access specifiers.", "An access specifier defines the scope and visibility of a class member.", "Both of the above", "None of the above. " },
                new string[] { "if (a = 2): Console.WriteLine(9);", "if (a == 2): Console.WriteLine(9);", "if (a == 2) { Console.WriteLine(9); }", "if (a = 2) { Console.WriteLine(9); } " }

            };


            //string [][] correctAnswers = new string[5][];
            //correctAnswers[0] = new string[] { "d) false"};
            //correctAnswers[1] = new string[] { "c) class" };
            //correctAnswers[2] = new string[] { " d) All of the above" };
            //correctAnswers[3] = new string[] { " C - Both of the above." };
            //correctAnswers[4] = new string[] { "b) We cannot modify characters contained in the string" };

            char[] correctAnswers = { 'D', 'C', 'D', 'C','A' };
            int score = 0;
            Console.WriteLine("Wellcome to the Quizz Of introduction of C#");
            Console.WriteLine("-------------------------------------------");
         

            for (int i = 0; i < questions.Length; i++)
            {
 
                Console.WriteLine($"{i + 1}. {questions[i]}");
                Console.WriteLine("---------------------");
                Console.WriteLine($"A. {options[i][0]}");
                Console.WriteLine($"B. {options[i][1]}");
                Console.WriteLine($"C. {options[i][2]}");
                Console.WriteLine($"D. {options[i][3]}");


                Console.Write("Your answer (A, B, C, D): ");
                char answer = Char.ToUpper(Console.ReadLine()[0]);

                if (answer == correctAnswers[i])
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! Correct answer is {correctAnswers[i]}.");
                }
                Console.WriteLine();

            }
            Console.WriteLine($"Your final score is: {score} out of {questions.Length}");

            if (score <=2 || score == 0) {
                Console.WriteLine("Try Again");
            }
                



        }
    }
}
