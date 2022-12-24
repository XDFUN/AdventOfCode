namespace AdventOfCode.Day5
{
    internal class Challenge2
    {
        public void Run()
        {
            var inputString = File.ReadAllText(Environment.CurrentDirectory + "/Day5/input.txt");

            var pairs = inputString.Split(Environment.NewLine + Environment.NewLine);

            var stacks = GetStacks(pairs[0]);

            var moves = pairs[1].Split(Environment.NewLine);

            foreach (var move in moves)
            {
                var splittedMove = move.Split(" ");

                var i = Convert.ToInt32(splittedMove[1]);
                var sourceStack = Convert.ToInt32(splittedMove[3]) - 1;
                var targetStack = Convert.ToInt32(splittedMove[5]) - 1;

                var idk = new List<string>();
                for (; i > 0; i--)
                {
                    idk.Add(stacks[sourceStack].Pop());
                }

                idk.Reverse();

                foreach (var str in idk)
                {
                    stacks[targetStack].Push(str);
                }
            }

            var result = "";

            foreach (var stack in stacks)
            {
                result += stack.Peek();
            }

            Console.WriteLine(result);
        }

        private List<Stack<string>> GetStacks(string str)
        {
            var stacks = new List<Stack<string>>();

            var stackLayers = str.Split(Environment.NewLine);
            stackLayers = stackLayers.Reverse().ToArray();

            foreach (var layer in stackLayers)
            {
                if (stackLayers[0] == layer)
                {
                    continue;
                }

                var values = GetStackValues(layer);

                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] != " ")
                    {
                        if (stacks.Count <= i)
                        {
                            stacks.Add(new());
                        }

                        stacks[i].Push(values[i]);
                    }
                }
            }

            return stacks;
        }

        private string[] GetStackValues(string str)
        {
            var values = new List<string>();

            for (int i = 0; i < str.Length - 1;)
            {
                var value = str[++i];
                values.Add(value.ToString());

                i += 3;
            }

            return values.ToArray();
        }
    }
}