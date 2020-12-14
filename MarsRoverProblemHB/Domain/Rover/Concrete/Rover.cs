using MarsRoverProblemHB.Domain.Enums;
using MarsRoverProblemHB.Domain.Plateau.Abstract;
using MarsRoverProblemHB.Domain.Rover.Abstract;
using MarsRoverProblemHB.Infrastructure.Exceptions;

namespace MarsRoverProblemHB.Domain.Rover.Concrete
{
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public Position RoverPosition { get; set; }
        public Directions RoverDirection { get; set; }

        public Rover(IPlateau roverPlateau, Position roverPosition, Directions roverDirection)
        {
            RoverPlateau = roverPlateau;
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
        }

        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new MarsRoverException("Invalid value: " + command.ToString());
                }
            }
        }

        private void TurnLeft()
        {
            RoverDirection = (RoverDirection - 1) < Directions.N ? Directions.W : RoverDirection - 1;
        }

        private void TurnRight()
        {
            RoverDirection = (RoverDirection + 1) > Directions.W ? Directions.N : RoverDirection + 1;
        }

        private void Move()
        {
            if (RoverDirection == Directions.N)
            {
                RoverPosition.Y++;
            }
            else if (RoverDirection == Directions.E)
            {
                RoverPosition.X++;
            }
            else if (RoverDirection == Directions.S)
            {
                RoverPosition.Y--;
            }
            else if (RoverDirection == Directions.W)
            {
                RoverPosition.X--;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", RoverPosition.X, RoverPosition.Y, RoverDirection);
        }
    }
}