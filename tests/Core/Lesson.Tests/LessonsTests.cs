using Xunit;
using Xunit.Abstractions;
using TestsCore;
using Lesson1;

namespace Lessons.Tests
{
    public class LessonTests : BaseTest
    {
        public LessonTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void BinaryGapTest()
        {
            Run(BinaryGap.Main);
        }

        [Fact]
        public void T3Test()
        {
            Run(T3.Main);
        }

        [Fact]
        public void T4Test()
        {
            Run(T4.Main);
        }

        [Fact]
        public void T5Test()
        {
            Run(T5.Main);
        }
    }
}
