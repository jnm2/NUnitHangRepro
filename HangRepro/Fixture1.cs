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
    }
}
