using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Miner
    {
        public static string[] SearchMines(string[] minesField)
        {
            int[][] directions = new int[8][] { new int[] { -1, -1}, new int[] { -1, 0}, new int[] { -1, 1}, new int[] { 0, -1}, new int[] { 0, 1}, new int[] { 1, -1}, new int[] { 1, 0}, new int[] { 1, 1} }; 
            string[] result = new string[minesField.Length];
            result[0] = "";
            int count;
            for (int col = 0; col < minesField.Length; col++)
            {
                for (int row = 0; row < minesField[col].Length; row++)
                {
                    if (minesField[col][row] == '*')
                    {
                        result[col] += "*";
                    }
                    else
                    {
                        count = 0;
                        foreach (var direction in directions)
                        {
                            if (col + direction[0] >= 0 &&
                                col + direction[0] <= minesField.Length - 1 &&
                                row + direction[1] >= 0 &&
                                row + direction[1] <= minesField[col + direction[0]].Length - 1)
                            {
                               if(minesField[col + direction[0]][row + direction[1]] == '*')
                               { 
                                    count++;
                               }
                            }
                        }
                        result[col] += count;
                    }
                }
            }
            return result;
        }
    }
}
