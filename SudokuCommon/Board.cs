namespace SudokuCommon
{
    public class Board
    {
        public int Size => 9;

        public BoardSquare[,] MainBoard;

        public Board()
        {
            MainBoard = new BoardSquare[Size,Size];
            for (int i = 1; i <= Size; i++)
            {
                for (int j = 1; j <= Size; j++)
                {
                    MainBoard[i-1, j-1] = new BoardSquare(Size);
                }
            }
        }

    }
}
