
// it means i m using the testConsoleApp namespace which i have created  

namespace testConsoleApp
{


    class Program
    {

        static void Main(string[] args)
        {

            string myNum = "Enter first Number";

            Console.WriteLine(myNum);     // here myNum is a string 
                                          // by convention read line should also be string 


            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number :");


            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == 0)
            {

                Console.WriteLine("you cannt divide any number by zero ");

                int num3 = Convert.ToInt32(Console.ReadLine());

                if (num3 == 0)
                {

                    Console.WriteLine("you cannt divide any number by zero ");

                    int num4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num1 / num4);

                }
                else
                {

                    Console.WriteLine(num1 / num3);
                }



            }
            else
            {

                Console.WriteLine(num1 / num2);
            };


        }
    }
}


