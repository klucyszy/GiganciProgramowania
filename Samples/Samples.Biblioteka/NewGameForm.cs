using Samples.Biblioteka.Model;
using System;
using System.Windows.Forms;

namespace Samples.Biblioteka
{
    public partial class NewGameForm : Form
    {
        public LibraryRepository Library { get; private set; }

        public NewGameForm(LibraryRepository library)
        {
            InitializeComponent();
            Library = library;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var price = decimal.Parse(priceTextBox.Text);
                var minAge = int.Parse(minAgeTextBox.Text);
                var game = new Game(price, descTextBox.Text, minAge, titleTextBox.Text);
                Library.Add(game);

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wpisałeś błędne wartości", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            priceTextBox.Text = string.Empty;
            minAgeTextBox.Text = string.Empty;
            descTextBox.Text = string.Empty;
            titleTextBox.Text = string.Empty;
        }
    }
}
