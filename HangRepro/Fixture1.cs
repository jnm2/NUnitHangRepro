using System.Diagnostics;
using System.Threading;
using NUnit.Framework;

namespace HangRepro
{
    public static class Fixture1
    {
        [Test]
        public static void Test_01() => Thread.Sleep(385);

        [Test]
        public static void Test_02() => Thread.Sleep(45);

        [Test]
        public static void Test_03() => Thread.Sleep(66);

        [Test]
        public static void Test_04() => Thread.Sleep(80);

        [Test]
        public static void Test_05() => Thread.Sleep(75);

        [Test]
        public static void Test_06() => Thread.Sleep(82);

        [Test]
        public static void Test_07() => Thread.Sleep(69);

        [Test]
        public static void Test_08() => Thread.Sleep(75);

        [Test]
        public static void Test_09()
        {
            new StackTrace(true);
        }

        [Test]
        public static void Test_10()
        {
            new StackTrace(true);
        }

        [Test]
        public static void Tests_at_end([Range(1, 24)] int x)
        {
            if (x > 12) Thread.Sleep(20);
        }
    }
}
