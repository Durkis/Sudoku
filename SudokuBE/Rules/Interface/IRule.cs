using SudokuCommon;

namespace SudokuBE.Rules.Interface
{
    public interface IRule
    {
        /// <summary>
        /// Apply rule for given board.
        /// </summary>
        void Apply(Board board);
    }
}
