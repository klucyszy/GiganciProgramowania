using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.Przegladarka
{
    public partial class DodajUlubiony : UserControl
    {
        public string Nazwa { get; set; }
        public string Url { get; set; }

        public DodajUlubiony(string urlText)
        {
            InitializeComponent();
            Url = urlTextBox.Text = urlText;
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            Url = urlTextBox.Text;
            Nazwa = nazwaTextBox.Text;

            this.Hide();
        }
    }
}
