using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiC_Namespace.reversiC.src
{
    internal class Board
    {
        int[,] boardArray;
        public Board(int boardWidth, int boardHeight) {
            this.boardArray = new int[boardHeight, boardWidth];
        }

        static public string getGrootsteZwimpie ()
        {
            string result = "dexter is grootste zwimpie";


            return result;

        }

        public void getNumbers ()
        {
            for (int i = 0; i < this.boardArray.GetLength(0); i++)
            {
                for (int j = 0; j < this.boardArray.GetLength(1); j++)
                {
                    int s = this.boardArray[i, j];

                    Debug.WriteLine(s);
                }
            }
        }
    }
}
