using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.Przegladarka
{
    public partial class Form1 : Form
    {
        //plik konfiguracyjny
        private string _homePage = "https://google.com";

        public Uri HomePage { get; set; }

        public Form1()
        {
            InitializeComponent();

            this.HomePage = new Uri(_homePage);
            this.webBrowser1.Navigate(HomePage);
            this.AutoSize = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.webBrowser1.CanGoBack)
            {
                this.webBrowser1.GoBack();
            }            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.webBrowser1.CanGoForward)
            {
                this.webBrowser1.GoForward();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Refresh();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Stop();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (this.textBox1.Text != string.Empty)
                {
                    this.webBrowser1.Navigate(this.textBox1.Text);
                }
            }
        }
    }
}
