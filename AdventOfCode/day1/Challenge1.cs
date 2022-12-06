namespace AdventOfCode.day1
{
    internal class Challenge1
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

            var max = elveCalories.Max();
            var index = elveCalories.IndexOf(max);

            Console.WriteLine("Elve number " + index + " has the most callories with " + max + " calories");
        }
    }
}