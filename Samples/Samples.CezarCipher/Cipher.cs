using System;
using System.Windows.Forms;

namespace Samples.CezarCipher
{
    public partial class Cipher : Form
    {
        public Cipher()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            var delay = (int)numericUpDown1.Value;

            textBox2.Text = CezarCipher.Basic(text, delay);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            var delay = (int)numericUpDown1.Value;

            textBox3.Text = CezarCipher.Extended(text, delay);
        }
    }
}
