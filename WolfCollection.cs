using System;
using System.Collections;
using System.Collections.Generic;

namespace Zoo
{
    public class WolfCollection
    {
        private Hashtable wolfTable;
        private List<Wolf> wolfList;

        public WolfCollection()
        {
            wolfTable = new Hashtable();
            wolfList = new List<Wolf>();
        }

        public void AddWolf(string key, Wolf wolf)
        {
            if (!wolfTable.ContainsKey(key))
            {
                wolfTable.Add(key, wolf);
                wolfList.Add(wolf);
            }
        }

        public void ShowAllWolvesFromList()
        {
            Console.WriteLine("List of Wolves (List<>):");
            foreach (var wolf in wolfList)
            {
                wolf.ShowInfo();
                Console.WriteLine("-----");
            }
        }
        public void ShowAllWolvesFromHashtable()
        {
            Console.WriteLine("Wolves from Hashtable:");
            foreach (DictionaryEntry entry in wolfTable)
            {
                Console.WriteLine($"Key: {entry.Key}");
                ((Wolf)entry.Value).ShowInfo();
                Console.WriteLine("-----");
            }
        }

        public void ShowWolfByKey(string key)
        {
            if (wolfTable.ContainsKey(key))
            {
                Console.WriteLine($"Found wolf with key '{key}':");
                ((Wolf)wolfTable[key]).ShowInfo();
            }
            else
            {
                Console.WriteLine($"No wolf found with key '{key}'.");
            }
        }
        public List<Wolf> GetAllWolves()
        {
            return wolfList;
        }

        public Wolf GetWolfByKey(string key)
        {
            return wolfTable.ContainsKey(key) ? (Wolf)wolfTable[key] : null;
        }
    }
}
