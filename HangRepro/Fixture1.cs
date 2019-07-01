using System.Diagnostics;
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

        [Test]
        public static void Test_27() => Thread.Sleep(66);

        [Test]
        public static void Test_28() => Thread.Sleep(80);

        [Test]
        public static void Test_29() => Thread.Sleep(75);

        [Test]
        public static void Test_30() => Thread.Sleep(82);

        [Test]
        public static void Test_31() => Thread.Sleep(69);

        [Test]
        public static void Test_32() => Thread.Sleep(75);

        [Test]
        public static void Test_33()
        {
            new StackTrace(true);
        }

        [Test]
        public static void Test_34()
        {
            new StackTrace(true);
        }

        [Test]
        public static void Test_35()
        {
            new StackTrace(true);
        }

        [Test]
        public static void Test_36()
        {
        }

        [Test]
        public static void Test_37()
        {
            new StackTrace(true);
        }
    }
}
