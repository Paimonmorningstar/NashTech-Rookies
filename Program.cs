using System;
using System.Collections.Generic;
 
namespace day_1
{
    class Program
    {
    static void Main(string[] args)
        {

            ManageMember.ListMember();

            while(true)
            {
                Console.WriteLine("**");
                Console.WriteLine("MENU");
                Console.WriteLine("1.Show all member is male");
                Console.WriteLine("2.Member oldest");
                Console.WriteLine("3.Show Full Name");
                Console.WriteLine("4.Return Birth Place");
                Console.WriteLine("5.The first person born in Ha Noi");
                Console.WriteLine("6.Exit");
                Console.WriteLine("**");

                Console.WriteLine("Select function : ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch(key)
                {
                    case 1:
                        ManageMember.FindMale();
                        break;
                    
                    case 2:
                        ManageMember.FindOldest();
                        break;

                    case 3:
                        ManageMember.FullName();
                        break;

                    case 4:
                        ManageMember.FindYear();
                        break;
                    
                    case 5:
                        ManageMember.FindFirstPersonWasBornHaNoi();
                        break;
                    
                    case 6: 
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("This funtion is not available!");
                        break;
                }
            }
        }
    }
}

