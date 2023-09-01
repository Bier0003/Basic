using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace BasicTests
{
    public class Basictests
    {
        [Fact]
        public void AddAndMuliplyShouldReturnCorrectInteger()
        {
            // arrange
            int a = 2;
            int b = 3;
            int c = 4;
            int expected = 20;

            // act
            int actual = Basic.Program.AddAndMultiply(a, b, c);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}