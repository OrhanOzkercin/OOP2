using System;
using System.Drawing;

namespace Oop2
{
    public abstract class Product
    {
        public String name;
        public double price;
        public int ProductID;
        public string Category;
        public string image;
        public double Sale;
        public abstract void ShowProperties();
    }
}