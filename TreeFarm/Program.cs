using System;
using System.Collections.Generic;

namespace TreeFarm
{
    class Program
    {
        public static void Main(string[] args)
        {

            string newStuffMan = "Maple";

            Tree newTreeTesting = new Tree();
            newTreeTesting.TreeType(newStuffMan);
        }
    }

    public class Tree
    {
        public double Height { get; set; } = 0;
        public string Location { get; set; } = "";
        public string Type { get; set; } = "";

        public string Move (string newLocation)
        {
            if (newLocation != this.Location)
            {
                this.Location = newLocation;
            }

            return this.Location;
        }

        public double Grow (double growth)
        {
            if (growth > 0.0)
            {
                this.Height += growth;
            }

            return this.Height;
        }


        public string TreeType (string newType) {
            if (newType != this.Type) {
                this.Type = newType;
                Console.WriteLine($"Tree type: {this.Type}");
            }
            return this.Type;
        }  

    }
}
