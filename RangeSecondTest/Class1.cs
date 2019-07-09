using NUnit.Framework;

namespace RangeSecondTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void RangeClosed2andOpened6Contains2and4 ()
        {
            int rangeFirst = 2;
            int rangeLast = 6;
            int[] arr = { 2, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < rangeFirst || arr[i] >= rangeLast)
                {
                    Assert.Fail();
                }
            }
        }

        [Test]
        public void RangeClosed2andOpened6DoesntContainsMinus1and1and6and10()
        {
            int rangeFirst = 2;
            int rangeLast = 6;
            int[] arr = { -1, 1, 6, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (!(arr[i] < rangeFirst || arr[i] >= rangeLast))
                {
                    Assert.Fail();
                }
            }
        }

        [Test]
        public void RangeClosed2andOpened6GetsAllPoints2and3and4and5() 
        {
            int rangeFirst = 2;
            int rangeLast = 6;
            int[] arr = { 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < rangeFirst || arr[i] >= rangeLast)
                {
                    Assert.Fail();
                }
            }
        }

        [Test]
        public void RangeClosed2andOpened5DoesntContainClosed7andOpened10() 
        {
            int rangeFirst = 2;
            int rangeLast = 6;
            int rangeFirst2 = 7;
            int rangeLast2 = 10;

            if ()
            {
                Assert.Fail();
            }

        }

    }
}
