using System;

namespace If_Excersize_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int input1, input2;

            //recieving input
            Console.Write("Please enter a number: ");
            input1 = int.Parse(Console.ReadLine());

            //recieving second input
            Console.Write("Please enter another number: ");
            input2 = int.Parse(Console.ReadLine());

            //checking if inputs are positive
            if (input1>0 && input2>0)
            {
                Console.WriteLine($"The product of inputs is: {input1*input2}"); 
            }
        }
    }
}
