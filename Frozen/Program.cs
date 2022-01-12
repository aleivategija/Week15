using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    internal class Program
    {
        class Wishlist
        {
            string name;
            string wish;
            

            public Wishlist(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }

            public string Name
            {
                get { return name; }
            }
            public string Wish
            {
                get { return wish; }
            }

        }

        static void Main(string[] args)
        {
            List<Wishlist> wishes = new List<Wishlist>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Wishlist newWish = new Wishlist(tempArray[0], tempArray[1]);
                wishes.Add(newWish);
            }

            foreach (Wishlist wishFromList in wishes)
            {
                Console.WriteLine($"{wishFromList.Name} wants {wishFromList.Wish} for Christmas.");
            }


        }


        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String form array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\kasutaja\...\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

    }
}

