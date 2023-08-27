using SudokuBE.Rules.Interface;
using System.Collections.Generic;

namespace SudokuBE.Rules
{
    public class RulesSet
    {

        public List<IRule> SetOfRules { get; }

        public RulesSet()
        {
            SetOfRules = new List<IRule>();
        }

        public void AddRule(IRule rule)
        {
            SetOfRules.Add(rule);
        }

    }
}
