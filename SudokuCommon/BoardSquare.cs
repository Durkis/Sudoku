using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuCommon
{
    public class BoardSquare
    {
        public int? Value;

        public List<int> Candidates;

        public BoardSquare(int size)
        {
            Value = null;
            Candidates = GetListOfCandidate(size);
        }

        private List<int> GetListOfCandidate(int size)
        {
            var returnValue = new List<int>();
            for (int i = 1; i <= size; i++ )
            {
                returnValue.Add(i);
            }
            return returnValue;
        }
    }
}
