using System;

class Program
{
    static void Main()
    {
        string name = "admin";
        string pw = "1881";

        Console.WriteLine("Please Enter Username");
        string username = Console.ReadLine();
        
        if (username !=name)
        {
            Console.WriteLine("Only admin login allowed");
        }
        else
        {
            Console.WriteLine("Hello Admin , \nPlease Password:");
            string password = Console.ReadLine();

            if (password == pw)
            {
                Console.WriteLine("Congratulations Successful Login");
            }
            else
            {
                Console.WriteLine("You entered the wrong password");
            }
        }

    }
}