using System.Windows.Forms;

namespace Samples.Wygaszacz
{
    partial class Wygaszacz
    {
        private System.ComponentModel.IContainer components = null;
        private Timer licznik;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialize the Wygaszacz component
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.licznik = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // licznik
            // 
            this.licznik.Interval = 2000;
            this.licznik.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Wygaszacz
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wygaszacz";
            this.Text = "Wygaszacz";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Wygaszacz_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Wygaszacz_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Wygaszacz_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Wygaszacz_MouseMove);
            this.ResumeLayout(false);

        }
    }
}