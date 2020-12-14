using MarsRoverProblemHB.Domain.Plateau.Abstract;
using MarsRoverProblemHB.Domain.Rover;

namespace MarsRoverProblemHB.Domain.Plateau.Concrete
{
    public class Plateau : IPlateau
    {
        public Position PlateauPosition { get; set; }

        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }
}