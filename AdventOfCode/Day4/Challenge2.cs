namespace AdventOfCode.Day4
{
    internal class Challenge2
    {
        public void Run()
        {
            var inputString = File.ReadAllText(Environment.CurrentDirectory + "/Day4/input.txt");

            var pairs = inputString.Split(Environment.NewLine);

            var overlapCount = 0;

            foreach (var pair in pairs)
            {
                var ranges = pair.Split(",");

                var castedRange1 = ranges[0].Split("-").Select(x => Convert.ToInt32(x)).ToArray();
                var castedRange2 = ranges[1].Split("-").Select(x => Convert.ToInt32(x)).ToArray();

                if (!(castedRange1[1] < castedRange2[0] || castedRange2[1] < castedRange1[0]))
                {
                    overlapCount++;
                }
            }

            Console.WriteLine(overlapCount);
        }
    }
}