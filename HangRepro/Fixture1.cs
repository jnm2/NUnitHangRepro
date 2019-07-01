using System.Threading;
using NUnit.Framework;

namespace HangRepro
{
    public static class Fixture1
    {
        [Test]
        public static void Test_1()
        {
            Thread.Sleep(385);
        }

        [Test]
        public static void Test_2()
        {
            Thread.Sleep(45);
        }

        [Test]
        public static void Tests_3_to_14([Range(1, 12)] int x)
        {
            Thread.Sleep(20);
        }

        [Test]
        public static void Tests_15_to_26([Range(1, 12)] int x)
        {
        }
    }
}
