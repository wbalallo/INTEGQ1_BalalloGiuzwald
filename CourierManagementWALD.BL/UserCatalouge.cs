
using System;

namespace CourierManagementWALD.BL
{
   public class UserCatalouge
    {
        public void Catalouge()
        { 
        ManageDelivery deliveryService = new ManageDelivery();

        START:
            string textToShow = "Courier Management System\n\n";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToShow.Length / 2)) + "}", textToShow));
            Console.WriteLine("\n1) View Pending Deliveries");
            Console.WriteLine("\n2) Search Parcel ID");
            Console.WriteLine("\n3) Update Delivery Status");
            Console.WriteLine("\n4) Exit");

            Console.WriteLine("Please Choose!:");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    deliveryService.ViewPendingDeliveries();
                    goto START;
                case 2:
                    deliveryService.SearchParcelID();
                    goto START;
                case 3:
                    deliveryService.UpdateDeliveryStatus();
                    goto START;
                
                default:
                    break;
            }

}

    }
}
