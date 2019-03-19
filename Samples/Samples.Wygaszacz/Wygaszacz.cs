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

        /// <summary>
        /// Akcja zostanie wywołana podczas załadowania okna po włączeniu programu.
        /// </summary>
        private void Wygaszacz_Load(object sender, EventArgs e)
        {
            SetMousePosition(); // ustaw aktualna pozycję kursora myszy
            LoadPicturesFromFolder(picturesFolder); // załaduj zdjęcia z folderu
            SetBackgroundImage(0); // ustawiamy pierwszy obrazek jako tło

            Cursor.Hide(); // ukryj kursor myszy
            this.WindowState = FormWindowState.Maximized; // okno na pełen ekran
            licznik.Start(); // rozpocznij pomiar czasu
        }

        /// <summary>
        /// Akcja zostanie wykonana, kiedy upłynie wyznaczony okres czasu.
        /// </summary>
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

        /// <summary>
        /// Akcja zostanie wykonana, kiedy zostanie wciśnięty dowolny przycisk klawiatury.
        /// </summary>
        private void Wygaszacz_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Akcja zostanie wykonana, kiedy zostanie wciśnięty dowolny przycisk myszy.
        /// </summary>
        private void Wygaszacz_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Akcja zostanie wykonana, kiedy pozycja myszy zmieni się.
        /// </summary>
        private void Wygaszacz_MouseMove(object sender, MouseEventArgs e)
        {
            var x = Cursor.Position.X;
            var y = Cursor.Position.Y;

            if (x != X || y != Y)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Ustaw aktualną pozycję myszki.
        /// </summary>
        private void SetMousePosition()
        {
            X = Cursor.Position.X;
            Y = Cursor.Position.Y;
        }

        /// <summary>
        /// Załaduj zdjęcia ze wskazanego folderu.
        /// </summary>
        /// <param name="folderPath">Ścieżka do folderu z którego mają zostać załadowane pliki</param>
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

        /// <summary>
        /// Ustaw zdjęcie aplikacji na wskazane w parametrze.
        /// </summary>
        /// <param name="position">Pozycja zdjęcia w tablicy zdjęć pobranych z danego folderu.</param>
        private void SetBackgroundImage(int position)
        {
            try
            {
                this.BackgroundImage = Image.FromFile(Pictures[position]);
                CurrentPicture = position;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    $"Nie udało się załadować obrazka {Pictures[position]}",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
