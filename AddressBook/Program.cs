using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS BOOK!");
            List<AddressDet> addresses = new List<AddressDet>();
            Dictionary<string, List<AddressDet>> dict = new Dictionary<string, List<AddressDet>>();
            AddressDet addressDet = new AddressDet();
            Console.WriteLine("ENTER THE OPTION : \n");
            switch (Console.ReadLine())
            {
                case "1": // Check if user entered 1.
                    //Console.Clear(); // Clear the console screen.
                    Console.WriteLine("Add!"); // Write you add "program" here.
                                               //UC1 - ADD CONTACTS
                    Console.WriteLine("ADDING CONTACTS TO ADDRESS BOOK");
                    Console.WriteLine("--------------------------------");
                    //UCcaseAdd uCcase1 = new UCcaseAdd();
                    //uCcase1.AddAddress();
                    AddCon();
                    Console.WriteLine("--------------------------------");
                    break; // Stop the switch loop.
             
                case "2":
                    Console.WriteLine("Edit");
                    Edit();
                    break;
                case "3":
                    Console.WriteLine("Remove");
                    Remove();
                    break;
                default: // If user didn't enter 1 or 2 his choice isn't valid. Show a message.
                    Console.WriteLine("The choice you made isn't valid, please try again.");
                    break;
            }

             void AddCon()
            {
                Console.WriteLine("ADD ADDRESS BOOK DETAILS");

                Console.WriteLine("Enter Contact No: ");
                string adbukno = Console.ReadLine();

                Console.WriteLine("Enter your Firstname");
                addressDet.Firstname = Console.ReadLine();
                //string str1 = "Firstname";
                //str1 = Console.ReadLine();
                //string valueString1 = str1;

                Console.WriteLine("Enter your Lastname");
                addressDet.Lastname = Console.ReadLine();
                //string str2 = "Lastname";
                //str2 = Console.ReadLine();
                //string valueString2 = str2;
         
                Console.WriteLine("Enter your Address");
                addressDet.Address = Console.ReadLine();
                //string str3 = "Address";
                //str3 = Console.ReadLine();
                //string valueString3 = str3;

                Console.WriteLine("Enter your Country");
                addressDet.Country = Console.ReadLine();
                //string str4 = "County";
                //str4 = Console.ReadLine();
                //string valueString4 = str4;

                Console.WriteLine("Enter your Pincode");
                addressDet.Pincode = Console.ReadLine();
                //string str5 = "Postcode";
                //str5 = Console.ReadLine();
                //string valueString5 = str5;

                addresses.Add(addressDet);
                dict.Add(adbukno,addresses);
            }

            foreach(KeyValuePair<string,List<AddressDet>> valuePair in dict)
            {
                Console.WriteLine("Address Book No: " +valuePair.Key);
                foreach (AddressDet detail in valuePair.Value)
                {
                    Console.WriteLine("FIRST NAME : " +detail.Firstname+ "\n LAST NAME : " +detail.Lastname);
                }
            }
            void Edit()
            {

            }

            void Remove()
            {

            }

        }
    }
}

