using MarsRoverProblemHB.Domain.Enums;
using MarsRoverProblemHB.Domain.Plateau.Abstract;

namespace MarsRoverProblemHB.Domain.Rover.Abstract
{
    public interface IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public Position RoverPosition { get; set; }
        public Directions RoverDirection { get; set; }
        public void Process(string commands);
        public string ToString();
    }
}
