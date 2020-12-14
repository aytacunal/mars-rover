using MarsRoverProblemHB.Domain.Rover.Concrete;
using MarsRoverProblemHB.Infrastructure.Exceptions;
using MarsRoverProblemHBUnitTest.DataShare;
using Xunit;
using Xunit.Abstractions;

namespace MarsRoverProblemHBUnitTest
{
    public class MarsRoverTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public MarsRoverTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [FirstValidData]
        public void FirstRoverCheck(Rover rover, string commands)
        {
            rover.Process(commands);
            Assert.Equal("1 3 N", rover.ToString());
            _testOutputHelper.WriteLine("Test passed!");
        }
        [Theory]
        [SecondValidData]
        public void SecondRoverCheck(Rover rover, string commands)
        {
            rover.Process(commands);
            Assert.Equal("5 1 E", rover.ToString());
            _testOutputHelper.WriteLine("Test passed!");
        }
        [Theory]
        [InvalidData]
        public void IncorrectInput(Rover rover, string commands)
        {
            Assert.Throws<MarsRoverException>(() => rover.Process(commands));
            _testOutputHelper.WriteLine("Test passed!");
        }
    }
}
