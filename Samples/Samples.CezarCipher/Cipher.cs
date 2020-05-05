using System;
using System.Windows.Forms;

namespace Samples.CezarCipher
{
    public partial class Cipher : Form
    {
        private CezarCipher _cipher;

        public Cipher()
        {
            InitializeComponent();
            _cipher = new CezarCipher();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            var delay = (int)numericUpDown1.Value;

            textBox2.Text = _cipher.Basic(text, delay);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            var delay = (int)numericUpDown1.Value;

            textBox3.Text = _cipher.Extended(text, delay);
        }
    }
}
