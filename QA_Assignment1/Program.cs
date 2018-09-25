using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int initLength;
            int initWidth;
            bool passed;
            do
            {
                Console.Write("Enter the length of the perimeter:");
                passed = int.TryParse(Console.ReadLine(), out initLength);
                
                Console.Write("Enter the width of the perimeter:");
                passed = int.TryParse(Console.ReadLine(), out initWidth);
            }
            while (!passed);

            Rectangle rectangle = new Rectangle (initLength , initWidth);
            int caseSwitch;
            int updateLength;
            int updateWidth;
            do
            {
                do
                {
                    Console.WriteLine("Choose from below options:");
                    Console.WriteLine("1. Get Rectangle Length");
                    Console.WriteLine("2. Change Rectangle Length");
                    Console.WriteLine("3. Get Rectangle Width");
                    Console.WriteLine("4. Change Rectangle Width");
                    Console.WriteLine("5. Get Rectangle Perimeter");
                    Console.WriteLine("6. Get Rectangle Area");
                    Console.WriteLine("7. Exit");
                    Console.Write("Enter your choice: ");
                    passed = Int32.TryParse(Console.ReadLine().ToString(), out caseSwitch);
                }
                while (!passed);
                switch (caseSwitch)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine ("The length of the perimeter is:"+ rectangle.GetLength());
                           
                        }
                        while (!passed);

                      
                        break;
                    case 2:
                        do
                        {
                            Console.Write("Enter the new length of the perimeter:  ");
                            passed = int.TryParse(Console.ReadLine(), out updateLength);
                        }
                        while (!passed);
                        rectangle.SetLength(updateLength);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("The width of the perimeter is:" + rectangle.GetWidth());

                        }
                        while (!passed);

                       
                        break;
                    case 4:
                        do
                        {
                            Console.Write("Enter the new width of the perimeter:  ");
                            passed = int.TryParse(Console.ReadLine(), out updateWidth);
                        }
                        while (!passed);
                        rectangle.SetLength(updateWidth);
                        break;
                    case 5:
                        Console.WriteLine("Rectangle Perimeter : " + rectangle.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again!");
                        break;
                }
            }
            while (caseSwitch != 7);
        }
    }
}
