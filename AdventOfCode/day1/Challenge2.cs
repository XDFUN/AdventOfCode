namespace AdventOfCode.day1
{
    internal class Challenge2
    {
        public void Run()
        {
            var inputString = File.ReadAllText(Environment.CurrentDirectory + "/day1/input.txt");

            var elveBackpacks = inputString.Split(Environment.NewLine + Environment.NewLine);

            var elveCalories = new List<int>();

            foreach (var backpack in elveBackpacks)
            {
                int castedCalories = 0;
                var calories = backpack.Split(Environment.NewLine);

                foreach (var calory in calories)
                {
                    castedCalories += Convert.ToInt32(calory);
                }

                elveCalories.Add(castedCalories);
            }

            elveCalories.Sort();
            var topOne = elveCalories[^1];
            var topTwo = elveCalories[^2];
            var topThree = elveCalories[^3];

            var caloriesOfTheTopThree = topOne + topTwo + topThree;

            Console.WriteLine("The top three elves carry " + caloriesOfTheTopThree + " calories.");
        }
    }
}