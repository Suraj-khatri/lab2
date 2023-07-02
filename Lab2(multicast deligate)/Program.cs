using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_multicast_deligate_
{
    public delegate void RectDelegate(double width,double height);
    internal class Rectangle
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine($"area is={width*height}");
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine($"Perimeter is={2*(width+height)}");
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectDelegate rectDelegate = rect.GetArea;
            rectDelegate += rect.GetPerimeter;
            rectDelegate(5, 10);
            rectDelegate(10, 20);
            Console.ReadKey();
        }
    }
}
