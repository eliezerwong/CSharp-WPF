using System;
using System.Collections.Generic;
using System.Text;

namespace WpfClasses
{
    public class Toy
    {
        //ctrl K + D to format
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        
        private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Image = string.Empty;
            Aisle = string.Empty;

        }
        public string GetAisle()
        {
            string output = "" + Manufacturer.ToUpper()[0] + Price.ToString().Replace(".", "");
            return output;

        }

        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }

        //public Toy(string manu, string name, double price, string image)
        //{
        //    Manufacturer = manu;
        //    Name = name;
        //    Price = price;
        //    Image = image;

        //}

        //cant figure out how to do image yet
        //public Toy(string manu, string name, double price)
        //{
        //    Manufacturer = manu;
        //    Name = name;
        //    Price = price;
        //    Aisle = GetAisle();

        //}

        //public string GetAisle()
        //{
        //    string aisle = Manufacturer.Substring(0, 1).ToUpper() + Price.ToString();
        //    return aisle;

        //}


    }
}
