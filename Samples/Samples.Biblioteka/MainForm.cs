using Samples.Biblioteka.Model;
using System.Windows.Forms;

namespace Samples.Biblioteka
{
    public partial class MainForm : Form
    {
        private Library _library;

        public MainForm()
        {
            InitializeComponent();

            _library = new Library();
            _library.ImportGamesFromFile();
            gameListBox.DataSource = _library.GetGames();
        }
    }
}
