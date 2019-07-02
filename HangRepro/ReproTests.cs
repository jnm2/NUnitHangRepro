using System.Diagnostics;
using System.Threading;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Children)]
[assembly: LevelOfParallelism(6)]

namespace HangRepro
{
    public static class ReproTests
    {
        [Test]
        public static void A([Values(45, 65)] int delay)
        {
            Thread.Sleep(delay);
            new StackTrace(true);
        }

        [Test]
        public static void B([Range(1, 20)] int _)
        {
            Thread.Sleep(20);
        }
    }
}
