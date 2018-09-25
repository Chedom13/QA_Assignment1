using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment1
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.Length = 1;
            this.Width = 1;
        }

        public Rectangle (int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public int Length { get => length; set {
                if (value >= 0) length = value;
                else throw new InvalidOperationException();
            }
        }

        public int Width
        {
            get => width; set
            {
                if (value >= 0) width = value;
                else throw new InvalidOperationException();
            }
        }

        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            return (width*2) + (length*2);
        }

        public int GetArea()
        {
            return length*width;
        }

        
    }
}
