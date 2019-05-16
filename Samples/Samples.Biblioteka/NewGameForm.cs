using Samples.Biblioteka.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.Biblioteka
{
    public partial class NewGameForm : Form
    {
        public Library Library { get; private set; }
        public NewGameForm(Library library)
        {
            InitializeComponent();
            Library = library;
        }
    }
}
