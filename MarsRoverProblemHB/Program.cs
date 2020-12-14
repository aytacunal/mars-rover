using MarsRoverProblemHB.Domain.Enums;
using MarsRoverProblemHB.Domain.Plateau.Concrete;
using MarsRoverProblemHB.Domain.Rover;
using MarsRoverProblemHB.Domain.Rover.Concrete;
using MarsRoverProblemHB.Infrastructure.Exceptions;
using System;

namespace MarsRoverProblemHB
{
    static class Program
    {
        static void Main()
        {
            Console.Write("Please enter the X and Y for Plateau coordinates in the specified format (X,Y):");
            string plateauCoordinates = Console.ReadLine();
            var dividedCoordinates = plateauCoordinates.Split(",");
            if (dividedCoordinates.Length > 3)
            {
                throw new MarsRoverException("Invalid coordinates" + dividedCoordinates);
            }
            var plateaux = Convert.ToInt32(dividedCoordinates[0]);
            var plateauy = Convert.ToInt32(dividedCoordinates[1]);
            Plateau plateau = new Plateau(new Position(plateaux, plateauy));

            Console.Write("Please enter the X and Y for Plateau position and choose Directions(N,E,S,W) in the specified format (X,Y,D):");
            string roverInput = Console.ReadLine();
            var roverCoordinates = roverInput.Split(",");
            if (roverCoordinates.Length > 4)
            {
                throw new MarsRoverException("Invalid coordinates" + roverCoordinates);
            }
            var roverx = Convert.ToInt32(roverCoordinates[0]);
            var rovery = Convert.ToInt32(roverCoordinates[1]);
            var roverDirection = (Directions)Enum.Parse(typeof(Directions), roverCoordinates[2].ToUpper());

            var rover = new Rover(plateau, new Position(roverx, rovery), roverDirection);

            Console.Write("Please enter process commands:");
            string commands = Console.ReadLine();
            rover.Process(commands.ToUpper());

            Console.WriteLine(rover.ToString());

            Console.ReadLine();

        }
    }
}