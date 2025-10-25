namespace MakeenAssignment.Assignment1
{
    internal class EvenNum
    {
        static void Main(string[] args)
        {
        
           Console.WriteLine("The first 10 even numbers are:");
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            //for (int i = 0; i < 20; i+=2)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
        }
    }
}
