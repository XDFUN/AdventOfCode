using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day3
{
    internal class Challenge2
    {
        public void Run()
        {
            var inputString = File.ReadAllText(Environment.CurrentDirectory + "/Day3/input.txt");

            var backpacks = inputString.Split(Environment.NewLine);

            int sum = 0;

            for (int i = 0; i < backpacks.Length; i += 3)
            {
                var firstBackpack = backpacks[i];
                var secondBackpack = backpacks[i + 1];
                var thirdBackpack = backpacks[i + 2];

                var badge = firstBackpack.FirstOrDefault(ch => secondBackpack.Contains(ch) && thirdBackpack.Contains(ch));

                sum += GetPriority(badge);
            }

            Console.WriteLine("The sum of the priorities of all badges is {0}", sum);
        }

        private int GetPriority(char ch)
        {
            if (char.IsUpper(ch))
            {
                return ch - 38;
            }
            else if (char.IsLower(ch))
            {
                return ch - 96;
            }

            return 0;
        }

    }
}