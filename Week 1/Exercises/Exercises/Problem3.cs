using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            char[][] board = {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        };

            string word1 = "ABCCED";
            string word2 = "SEE";
            string word3 = "ABCB";

            Console.WriteLine(Exist(board, word1));
            Console.WriteLine(Exist(board, word2));
            Console.WriteLine(Exist(board, word3));
        }

        public static bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int cols = board[0].Length;

            bool Backtrack(int row, int col, int index)
            {
                if (index == word.Length) return true;
                if (row < 0 || row >= rows || col < 0 || col >= cols || board[row][ col] != word[index]) return false;
                char temp = board[row][ col];
                board[row][ col] = '#';
                bool result =
                    Backtrack(row + 1, col, index + 1) || // Down
                    Backtrack(row - 1, col, index + 1) || // Up
                    Backtrack(row, col + 1, index + 1) || // Right
                    Backtrack(row, col - 1, index + 1);   // Left

                board[row][ col] = temp;

                return result;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Backtrack(i, j, 0)) return true;
                }
            }

            return false;
        }
    }
}
