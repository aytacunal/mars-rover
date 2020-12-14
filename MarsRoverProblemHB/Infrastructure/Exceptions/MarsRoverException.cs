namespace MarsRoverProblemHB.Infrastructure.Exceptions
{
    public class MarsRoverException : System.Exception
    {
        public MarsRoverException() : base()
        {
        }
        public MarsRoverException(string message) : base(message)
        {
        }
    }
}