using SudokuCommon;
using SudokuCommon.EventArguments;
using SudokuCommon.Handlers;
using System.Windows;

namespace SudokuFE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SolveItEventArgs args = new SolveItEventArgs(new Board());
            FEtoBEHandlers.Instance.SolveIt(args);
        }
    }
}
