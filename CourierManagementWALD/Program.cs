using CourierManagementWALD.BL; 
using System;


namespace CourierManagementWALD
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidation user = new UserValidation();
            String textToShow = "Courier Management System\n\n";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToShow.Length / 2)) + "}", textToShow));
            Console.WriteLine("\n1)Login");
            Console.WriteLine("\n2)Register\n");
            Console.WriteLine("Please Choose!:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else
            {

            }

        }
    }
}
