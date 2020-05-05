using Samples.Biblioteka.Model;
using System.Windows.Forms;

namespace Samples.Biblioteka
{
    public partial class MainForm : Form
    {
        private LibraryRepository _library;

        public MainForm()
        {
            InitializeComponent();

            _library = new LibraryRepository();
            gameListBox.DataSource = _library.GetItems();
        }

        private void AddGameButton_Click(object sender, System.EventArgs e)
        {
            var newGameForm = new NewGameForm(_library);
            newGameForm.ShowDialog();

            _library = newGameForm.Library;
            gameListBox.DataSource = null;
            gameListBox.DataSource = _library.GetItems();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
