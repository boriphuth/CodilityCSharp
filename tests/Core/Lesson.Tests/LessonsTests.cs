using Lesson1.Iterations;
using TestsCore;
using Xunit;
using Xunit.Abstractions;

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
    }
}
