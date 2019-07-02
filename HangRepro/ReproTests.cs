using System.Diagnostics;
using System.Threading;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Children)]
[assembly: LevelOfParallelism(7)]

namespace HangRepro
{
    public static class ReproTests
    {
        [Test]
        public static void A__Timing_test_1() => Thread.Sleep(45);

        [Test]
        public static void A__Timing_test_2() => Thread.Sleep(66);

        [Test]
        public static void A__Timing_test_3() => Thread.Sleep(80);

        [Test]
        public static void A__Timing_test_4() => Thread.Sleep(75);

        [Test]
        public static void A__Timing_test_5() => Thread.Sleep(82);

        [Test]
        public static void A__Timing_test_6() => Thread.Sleep(69);

        [Test]
        public static void A__Timing_test_7() => Thread.Sleep(75);

        [Test]
        public static void B__Racing_tests([Range(1, 2)] int _)
        {
            new StackTrace(true);
        }

        [Test]
        public static void C__Ending_tests([Range(1, 20)] int _)
        {
            Thread.Sleep(10);
        }
    }
}
