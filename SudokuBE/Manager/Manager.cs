using SudokuBE.Rules;
using SudokuBE.Rules.Interface;
using SudokuCommon;
using SudokuCommon.EventArguments;
using static SudokuCommon.Handlers.FEtoBEHandlers;

namespace SudokuBE.Manager
{
    public class Manager
    {

        private RulesSet _rulesSet;
        private Board _board;

        public void Run(Board board)
        {
            Instance.SolveItEH += new SolveItEventHandler(onSolveIt);
            _board = board;
            AddRules();
            ApplyRules();
        }

        static void onSolveIt(object sender, SolveItEventArgs e)
        {
            //
        }

        private void ApplyRules()
        {
            foreach (IRule rule in _rulesSet.SetOfRules)
            {
                rule.Apply(_board);
                // check
            }
        }

        private void AddRules()
        {
            _rulesSet = new RulesSet();
            _rulesSet.AddRule(new RuleOne());
        }

    }
}
