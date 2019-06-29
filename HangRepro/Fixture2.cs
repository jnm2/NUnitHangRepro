using System.Threading;
using NUnit.Framework;

namespace HangRepro
{
    public class Fixture2
    {
        [Test]
        public void Tests_3_to_14([Range(1, 12)] int x)
        {
            Thread.Sleep(20);
        }

        [Test]
        public void Tests_15_to_26([Range(1, 12)] int x)
        {
        }
    }
}
