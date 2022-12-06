using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.day2
{
    internal class Challenge1
    {
        public void Run()
        {
            var inputString = File.ReadAllText(Environment.CurrentDirectory + "/day2/input.txt");

            var rounds = inputString.Split(Environment.NewLine);

            var score = 0;

            foreach (var round in rounds)
            {
                var moves = round.Split(' ');

                var opponentMove = GetOpponentMove(moves[0][0]);
                var ownMove = GetOwnMove(moves[1][0]);

                var roundScore = GetRoundScore(opponentMove, ownMove);

                score += roundScore + (int)ownMove;
            }
            Console.WriteLine("According to plan, your score will be: "+score);
        }

        private RockPaperScissor GetOpponentMove(char move)
        {
            switch (move)
            {
                case 'A':
                    {
                        return RockPaperScissor.Rock;
                    }
                case 'B':
                    {
                        return RockPaperScissor.Paper;
                    }
                case 'C':
                    {
                        return RockPaperScissor.Scissor;
                    }
                default:
                    {
                        throw new Exception("Unknown move.");
                    }
            }
        }

        private RockPaperScissor GetOwnMove(char move)
        {
            switch (move)
            {
                case 'X':
                    {
                        return RockPaperScissor.Rock;
                    }
                case 'Y':
                    {
                        return RockPaperScissor.Paper;
                    }
                case 'Z':
                    {
                        return RockPaperScissor.Scissor;
                    }
                default:
                    {
                        throw new Exception("Unknown move.");
                    }
            }
        }

        private int GetRoundScore(RockPaperScissor opponent, RockPaperScissor own)
        {
            if (opponent == RockPaperScissor.Rock && own == RockPaperScissor.Paper)
            {
                return 6;
            }
            else if (opponent == RockPaperScissor.Paper && own == RockPaperScissor.Scissor)
            {
                return 6;
            }
            else if (opponent == RockPaperScissor.Scissor && own == RockPaperScissor.Rock)
            {
                return 6;
            }
            else if (opponent == own)
            {
                return 3;
            }

            return 0;
        }
    }
}