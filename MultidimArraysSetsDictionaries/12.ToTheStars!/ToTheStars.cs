using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;


namespace _12.ToTheStars
{
    class StarSystem
    {
        private double x;
        private double y;
        string name;

        public double X
        {
            get { return this.x; }
        }

        public double Y
        {
            get { return this.y; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public StarSystem(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

    }

    class ToTheStars
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            List<StarSystem> starSystems = new List<StarSystem>();
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split();
                string name = inputArray[0];
                double x = double.Parse(inputArray[1]);
                double y = double.Parse(inputArray[2]);
                starSystems.Add(new StarSystem(x, y, name));
            }

            string shipCoordinates = Console.ReadLine();
            string[] shipCoordinatesArray = shipCoordinates.Split();
            double shipX = double.Parse(shipCoordinatesArray[0]);
            double shipY = double.Parse(shipCoordinatesArray[1]);
            int steps = int.Parse(Console.ReadLine());

            for (int i = 0; i <= steps; i++)
            {
                bool isInStarSystem = false;
                foreach (StarSystem starSystem in starSystems)
                {
                    if ((shipX <= starSystem.X + 1 && shipX >= starSystem.X - 1) && (shipY <= starSystem.Y + 1 && shipY >= starSystem.Y - 1))
                    {
                        isInStarSystem = true;
                        Console.WriteLine(starSystem.Name.ToLower());
                    }
                }
                if (!isInStarSystem)
                {
                    Console.WriteLine("space");
                }
                shipY++;
            }
        }
    }
}
