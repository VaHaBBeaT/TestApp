using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Barcode { get; set; }

        public Product (string name, int price, string barcode)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
        }
    }
    class Book:Product
    {
        public int bookPages { get; set; }
        public int minAge { get; set; }
        public string progLang { get; set; }
        public string mainIngr { get; set; }
        public string EsotericBook
        {
            get
            {                
                string esobook = Name + "\t";
                return esobook;
            }
            

        }

        public void ProgrammingBook(int bookPages, string progLang)
        {

        }

        public void CookBook(int bookPages, string mainIngr)
        {

        }
        public Book (string name, int price, string barcode, int age, string lang, string ingr) : base(name, price, barcode)
        {
            minAge = age;
            progLang = lang;
            mainIngr = ingr;
        }
    }

    class Disc
    {
        
        public static void CD()
        {

        }

        public static void DVD()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Книги=====");

            Console.WriteLine("=====Диски=====");

            Console.ReadLine();
        }
    }
}
