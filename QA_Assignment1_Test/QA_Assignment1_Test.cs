using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QA_Assignment1;
using System.Threading.Tasks;
using NUnit.Framework;

namespace QA_Assignment1_Test
{
    [TestFixture]
    class QA_Assignment1_Test
    {
        [Test()]
        public void GetLength_input4_expectLengthEquals4()
        {
            //Arrange
            int L = 4;
            int W = 5;
            Rectangle testRectangle = new Rectangle(L, W);

            // Act 
            int Length = testRectangle.GetLength();

            // Assert
            Assert.AreEqual(Length, L);
        }

        [TestCase]
        public void SetLength_input2_expectLengthEquals2()
        {
            //Arrange
            int L = 2;
            int W = 5;
            Rectangle testRectangle = new Rectangle(L, W);

            // Act 
            int Length = testRectangle.GetLength();

            // Assert
            Assert.AreEqual(Length, L);
        }

        [TestCase]
        public void GetWidth_input5_expectLengthEquals5()
        {
            //Arrange
            int L = 4;
            int W = 5;
            Rectangle testRectangle = new Rectangle(L, W);

            // Act
            int Width = testRectangle.GetWidth();

            // Assert
            Assert.AreEqual(Width, W);
        }

        [TestCase]
        public void SetWidth_input2_expectLengthEquals2()
        {
            //Arrange
            int L = 4;
            int W = 2;
            Rectangle testRectangle = new Rectangle(L, W);

            // Act 
            int Width = testRectangle.GetWidth();

            // Assert
            Assert.AreEqual(Width, W);
        }

        [TestCase(4,5)]
        public void GetPerimeter_input_L4_W5_expectPerimeterEquals18(int initLength, int initWidth)
        {
            //Arrange
            Rectangle r = new Rectangle(initLength, initWidth);

            //Act
            int expectedPerimeter = (initLength * 2) + (initWidth * 2);

            // Assert
            Assert.AreEqual(expectedPerimeter, r.GetPerimeter());

        }

        [TestCase(8,37)]
        public void GetPerimeterNotNull(int initLength, int initWidth)
        {
            Rectangle r = new Rectangle(initLength, initWidth);
            Assert.NotNull(r.GetPerimeter());
        }


        [TestCase(4, 5)]
        public void GetArea_input_L4_W5_expectAreaEquals20(int initLength, int initWidth)
        {
            //Arrange
            Rectangle r = new Rectangle(initLength, initWidth);

            //Act
            int expectedArea = initLength * initWidth;
            int resultArea = r.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, resultArea);

        }

        [TestCase(8, 2)]
        public void GetAreaNotNull(int initLength, int initWidth)
        {
            Rectangle r = new Rectangle(initWidth,initLength);
            Assert.NotNull(r.GetArea());
        }
        
        [TestCase(-5,1)]
        public void ConstructorWithMinusEntry(int initLength, int initWidth)
        {
            Assert.Throws(
                typeof(InvalidOperationException),
                new TestDelegate(
                    () => new Rectangle(initWidth,initLength)
                ));
        }

    }
}
