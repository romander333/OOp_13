using System;
using System.Windows.Forms;
using Zoo;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new WolfCollection();

            var wolf1 = new Wolf(50.5, 5, 20, "Gray Wolf", "North America");
            var wolf2 = new Wolf(40.2, 3, 25, "Arctic Wolf", "Greenland");

            collection.AddWolf("gray", wolf1);
            collection.AddWolf("arctic", wolf2);

            Console.WriteLine("== List Output ==");
            collection.ShowAllWolvesFromList();

            Console.WriteLine("\n== Hashtable Output ==");
            collection.ShowAllWolvesFromHashtable();

            Console.WriteLine("\n== Search by key ==");
            collection.ShowWolfByKey("arctic");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WolfForm());
        }
    }
}

