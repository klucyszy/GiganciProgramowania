using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Samples.Wygaszacz
{
    public class ScreenManager
    {
        public int X { get; private set; } // pozycja X kursora myszki
        public int Y { get; private set; } // pozycja Y kursora myszki
        public string[] Pictures { get; private set; } // wszystkie załadowane obrazki
        public int CurrentPicture { get; private set; } // numer aktualnego wygaszacza ekranu
        public string PicturesFolder { get; set; } = @"D:\Obrazy\Wygaszacz\";

        public ScreenManager(Image image, string picturesFolder)
        {
            X = Cursor.Position.X;
            Y = Cursor.Position.Y;
            CurrentPicture = 0;
            PicturesFolder = picturesFolder;
            LoadPicturesFromFolder();
        }

        public bool HasMousePositionChanged()
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            return x != X || y != Y;
        }

        public void SetCurrentMousePosition()
        {
            X = Cursor.Position.X;
            Y = Cursor.Position.Y;
        }




        public void LoadPicturesFromFolder()
        {
            try
            {
                Pictures = Directory.GetFiles(PicturesFolder);

                if (Pictures == null)
                {
                    Directory.CreateDirectory(PicturesFolder);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    $"Błąd w trakcie pobierania obrazków z folderu {PicturesFolder}.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Pictures.Length == 0)
            {
                MessageBox.Show(
                    $"Folder {PicturesFolder} jest pusty.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Image UpdateImage()
        {
            var lastPicture = Pictures.Length - 1;
            CurrentPicture += 1;

            if (CurrentPicture > lastPicture)
            {
                CurrentPicture = 0;
            }

            return Image.FromFile(Pictures[CurrentPicture]);

        }
    }
}
