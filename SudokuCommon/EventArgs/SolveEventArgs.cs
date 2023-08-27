using System;

namespace SudokuCommon.EventArguments
{
    public class SolveItEventArgs : EventArgs
    {
        public Board board { get; }

        private Board _board;

        public SolveItEventArgs(Board board)
        {
            _board = board;
        }
    }
}
