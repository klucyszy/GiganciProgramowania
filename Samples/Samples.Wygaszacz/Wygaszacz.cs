using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Samples.Wygaszacz
{
    public partial class Wygaszacz : Form
    {
        public int X { get; private set; } // pozycja X kursora myszki
        public int Y { get; private set; } // pozycja Y kursora myszki
        public string[] Pictures { get; private set; } // wszystkie załadowane obrazki
        public int CurrentPicture { get; private set; } // numer aktualnego wygaszacza ekranu

        private const string picturesFolder = @"D:\Obrazy\Wygaszacz\";

        public Wygaszacz()
        {
            InitializeComponent();
        }

        private void Wygaszacz_Load(object sender, EventArgs e)
        {
            SetMousePosition(); // ustaw aktualna pozycję kursora myszy
            LoadPicturesFromFolder(picturesFolder); // załaduj zdjęcia z folderu
            SetBackgroundImage(0); // ustawiamy pierwszy obrazek jako tło

            Cursor.Hide();
            this.WindowState = FormWindowState.Maximized;
            licznik.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            var lastPicture = Pictures.Length - 1;
            if(CurrentPicture == lastPicture)
            {
                SetBackgroundImage(0);
            }
            else
            {
                SetBackgroundImage(CurrentPicture + 1);
            }
        }

        private void Wygaszacz_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void Wygaszacz_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Wygaszacz_MouseMove(object sender, MouseEventArgs e)
        {
            var x = Cursor.Position.X;
            var y = Cursor.Position.Y;

            if (x != X || y != Y)
            {
                Application.Exit();
            }
        }

        private void SetMousePosition()
        {
            X = Cursor.Position.X;
            Y = Cursor.Position.Y;
        }

        private void LoadPicturesFromFolder(string folderPath)
        {
            try
            {
                Pictures = Directory.GetFiles(folderPath);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    $"Błąd w trakcie pobierania obrazków z folderu {picturesFolder}.", 
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(Pictures.Length == 0)
            {
                MessageBox.Show(
                    $"Folder {picturesFolder} jest pusty.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetBackgroundImage(int position)
        {            
            this.BackgroundImage = Image.FromFile(Pictures[position]);
            CurrentPicture = position;
        }
    }
}
