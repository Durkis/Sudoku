using SudokuCommon.EventArguments;

namespace SudokuCommon.Handlers
{
    public class FEtoBEHandlers
    {
        private static FEtoBEHandlers _instance = null;
        private static readonly object padlock = new object();

        private FEtoBEHandlers()
        {
        }

        public static FEtoBEHandlers Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new FEtoBEHandlers();
                    }
                    return _instance;
                }
            }
        }

        public void SolveIt(SolveItEventArgs e)
        {
            OnSolveIt(e);
        }

        protected virtual void OnSolveIt(SolveItEventArgs e)
        {
            var ehSolveIt = SolveItEH;
            if (ehSolveIt != null)
            {
                ehSolveIt(this, e);
            }
        }

        public event SolveItEventHandler SolveItEH;
        public delegate void SolveItEventHandler(object sender, SolveItEventArgs e);
    }    
}
