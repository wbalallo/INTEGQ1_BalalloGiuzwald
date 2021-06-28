using CourierManagementWALD.DL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourierManagementWALD.BL
{
    public class ManageDelivery
    {
        string optionSelected = "", parcelInfo, shipperInfo, receiverInfo, addressInfo, statusInfo, editedInfo;
        List<string> editInfo = new List<string>() { };
        int infoIndex, numInfo;

        public void ViewPendingDeliveries()
        {
            Console.WriteLine("\n\tView Pending Deliveries");
            Console.WriteLine("\t===========================\n\n");

            Console.WriteLine("\nParcel ID 0001");
            Console.WriteLine("Shipper Info: Wald Balallo");
            Console.WriteLine("Receiver Info: Juan Dela Cruz");
            Console.WriteLine("Address Info: Sta. Rosa, Laguna");
            Console.WriteLine("Status: Delivered");

            Console.WriteLine("\nParcel ID 0002");
            Console.WriteLine("Shipper Info: Hisoka Morow");
            Console.WriteLine("Receiver Info: Killua Zoldyck");
            Console.WriteLine("Address Info: Greed Island");
            Console.WriteLine("Status: Undelivered");
        }

        public void SearchParcelID()
        {
            Console.WriteLine("\n\tSearch Parcel ID");
            Console.WriteLine("\t==================\n");

            Console.WriteLine("Please Enter the Parcel ID: ");
            string parcelNumber = Console.ReadLine();

            if (parcelNumber == "0001")
            {
                Console.WriteLine("\nParcel ID 0001");
                Console.WriteLine("Shipper Info: Wald Balallo");
                Console.WriteLine("Receiver Info: Juan Dela Cruz");
                Console.WriteLine("Address Info: Sta. Rosa, Laguna");
                Console.WriteLine("Status: Delivered");
            }

            else if (parcelNumber == "0002")
            {
                Console.WriteLine("\nParcel ID 0002");
                Console.WriteLine("Shipper Info: Hisoka Morow");
                Console.WriteLine("Receiver Info: Killua Zoldyck");
                Console.WriteLine("Address Info: Greed Island");
                Console.WriteLine("Status: Undelivered");
            }

            else
            {
                Console.WriteLine("\n\tInvalid Item Number!");
                Console.WriteLine("Press any button to continue.....");
                Console.ReadKey();
            }

        }

        public void UpdateDeliveryStatus()
        {
            Console.WriteLine("\n\tUpdate Delivery Status");
            Console.WriteLine("\t========================\n\n");
            Console.Write("Enter Parcel ID: ");
            parcelInfo = Console.ReadLine();
            Console.Write("Enter Shipper Info: ");
            shipperInfo = Console.ReadLine();
            Console.Write("Enter Receiver Info: ");
            receiverInfo = Console.ReadLine();
            Console.Write("Enter Address Info: ");
            addressInfo = Console.ReadLine();
            Console.Write("Enter Status: ");
            statusInfo = Console.ReadLine();

            Console.WriteLine("\t\nSuccessfully Updated the Delivery Status!");
            Console.WriteLine("=============================================\n");

            Console.WriteLine("\nParcel ID: " + parcelInfo);
            Console.WriteLine("Shipper Information: " + shipperInfo);
            Console.WriteLine("Receiver Information: " + receiverInfo);
            Console.WriteLine("Address Information: " + addressInfo);
            Console.WriteLine("Status: " + statusInfo);



        }

    }
}
