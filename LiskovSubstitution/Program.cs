using System;

namespace LiskovSubstitution
{
    class Program
    {
        static public int Area(Rectangle r)
        {
            return r.Width * r.Height;
        }
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");
        }
    }
}
