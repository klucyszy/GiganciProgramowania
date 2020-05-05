using System;
using System.Windows.Forms;

namespace Samples.Wygaszacz
{
    public partial class Wygaszacz : Form
    {
        private ScreenManager screenManager;

        public Wygaszacz()
        {
            InitializeComponent();
            screenManager = new ScreenManager(BackgroundImage, @"D:\Obrazy\Wygaszacz\");
        }

        private void Wygaszacz_Load(object sender, EventArgs e)
        {
            screenManager.SetCurrentMousePosition();
            screenManager.LoadPicturesFromFolder();
            BackgroundImage = screenManager.UpdateImage();

            Cursor.Hide(); // ukryj kursor myszy
            this.WindowState = FormWindowState.Maximized; // okno na pełen ekran
            licznik.Start(); // rozpocznij pomiar czasu
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BackgroundImage = screenManager.UpdateImage();
        }

        private void Wygaszacz_KeyDown(object sender, KeyEventArgs e)
        {
            //Application.Exit();
        }

        private void Wygaszacz_MouseClick(object sender, MouseEventArgs e)
        {
            //Application.Exit();
        }

        private void Wygaszacz_MouseMove(object sender, MouseEventArgs e)
        {
            if (screenManager.HasMousePositionChanged())
            {
                //Application.Exit();
            }
        }
    }
}
