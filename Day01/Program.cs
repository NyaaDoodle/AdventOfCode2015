namespace Day01
{
    internal class Program
    {
        private const int startingFloor = 0;

        private static void Main()
        {
            string input = SharedUtilities.InputFileMethods.ReadInputFile();
            int buildingFloor = calculateBuildingFloor(input);
            Console.WriteLine(buildingFloor);
            int basementDirectionPosition = getPositionWhenGoingToBasement(input);
            Console.WriteLine(basementDirectionPosition);
        }

        private static int calculateBuildingFloor(string floorDirections)
        {
            int currentFloor = startingFloor;

            foreach (char directionCharacter in floorDirections)
            {
                currentFloor = getNextFloorNumber(directionCharacter, currentFloor);
            }

            return currentFloor;
        }

        private static int getPositionWhenGoingToBasement(string floorDirections)
        {
            const int basementFloor = -1;
            int currentFloor = startingFloor;
            int currentDirectionPosition = 0;
            int atBasementDirectionPosition = -1;

            foreach (char directionCharacter in floorDirections)
            {
                currentFloor = getNextFloorNumber(directionCharacter, currentFloor);
                currentDirectionPosition++;
                if (currentFloor <= basementFloor)
                {
                    atBasementDirectionPosition = currentDirectionPosition;
                    break;
                }
            }

            return atBasementDirectionPosition;
        }

        private static int getNextFloorNumber(char directionCharacter, int currentFloor)
        {
            const char goFloorUpCharacter = '(';
            const char goFloorDownCharacter = ')';
            int nextFloor = currentFloor;

            switch (directionCharacter)
            {
                case goFloorUpCharacter:
                    nextFloor++;
                    break;
                case goFloorDownCharacter:
                    nextFloor--;
                    break;
            }

            return nextFloor;
        }
    }
}
