using MarsRoverProblemHB.Domain.Enums;
using MarsRoverProblemHB.Domain.Plateau.Concrete;
using MarsRoverProblemHB.Domain.Rover;
using MarsRoverProblemHB.Domain.Rover.Concrete;
using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace MarsRoverProblemHBUnitTest.DataShare
{
    public class FirstValidData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new Rover(new Plateau(new Position(5, 5)), new Position(1, 2), Directions.N), "LMLMLMLMM" };
        }
    }
    public class SecondValidData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new Rover(new Plateau(new Position(5, 5)), new Position(3, 3), Directions.E), "MMRMMRMRRM" };
        }
    }
    public class InvalidData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new Rover(new Plateau(new Position(5, 5)), new Position(1, 2), Directions.N), "SSSS" };
        }
    }
}