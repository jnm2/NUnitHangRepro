using System.Diagnostics;
using System.Threading;
using NUnit.Framework;

namespace HangRepro
{
    public static class Fixture3
    {
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
