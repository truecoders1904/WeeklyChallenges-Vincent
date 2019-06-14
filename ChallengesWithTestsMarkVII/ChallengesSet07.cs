using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            int result = 0;
            if (businesses != null )
            {
                for (int i = 0; i < businesses.Count; i++)
                {
                    if (businesses[i].TotalRevenue < businesses[i].TotalExpenses)
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < businesses.Count; i++)
            {
                if (businesses[i].TotalRevenue > businesses[i].TotalExpenses)
                {
                    result.Add(businesses[i].Name);
                }
            }
            var newResult = string.Join(",", result.ToArray());

            return newResult;
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            if(business.ParentCompany == null)
            {
                return business.Name;
            }
            return GetNameOfHighestParentCompany(business.ParentCompany);
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            if (finalBoard[0,0] == finalBoard[0, 1] && finalBoard[0, 1] == finalBoard[0, 2])
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[1,0] == finalBoard[1, 1] && finalBoard[1, 1] == finalBoard[1, 2])
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[2,0] == finalBoard[2, 1] && finalBoard[2, 1] == finalBoard[2, 2])
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0,0] == finalBoard[1, 0] && finalBoard[1, 0] == finalBoard[2, 0])
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0,1] == finalBoard[1, 1] && finalBoard[1, 1] == finalBoard[2, 1])
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0,2] == finalBoard[1, 2] && finalBoard[1, 2] == finalBoard[2, 2])
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[2,0] == finalBoard[1, 1] && finalBoard[1, 1] == finalBoard[0, 2])
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0,0] == finalBoard[1, 1] && finalBoard[1, 1] == finalBoard[2, 2])
            {
                return TicTacToeResult.O;
            }
            else
            {
                return TicTacToeResult.Draw;
            }
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers.Length==0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (!numbers[j].Contains(targetNumber))
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}
