using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day3
{
    internal class Challenge1
    {
        public void Run()
        {
            var inputString = File.ReadAllText(Environment.CurrentDirectory + "/Day3/input.txt");

            var backpacks = inputString.Split(Environment.NewLine);

            int sum = 0;

            foreach (var backpack in backpacks)
            {
                var middle = backpack.Length / 2;

                var firstHalf = backpack[0..middle];
                var secondHalf = backpack[middle..^0];

                var charInBoth = firstHalf.ToCharArray().FirstOrDefault(ch => secondHalf.Contains(ch));
                sum += GetPriority(charInBoth);
            }

            Console.WriteLine("The sum of the priorities of all items which exist in both compartments is {0}", sum);
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