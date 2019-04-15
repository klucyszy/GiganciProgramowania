namespace Samples.Przegladarka
{
    partial class Przeglądarka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wteczButton = new System.Windows.Forms.Button();
            this.przodButton = new System.Windows.Forms.Button();
            this.zatrzymajButton = new System.Windows.Forms.Button();
            this.odswiezButton = new System.Windows.Forms.Button();
            this.dodajUlubionyButton = new System.Windows.Forms.Button();
            this.idzButton = new System.Windows.Forms.Button();
            this.ulubioneComboBox = new System.Windows.Forms.ComboBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.przegladarkaWebBrowser = new System.Windows.Forms.WebBrowser();
            this.Podpis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wteczButton
            // 
            this.wteczButton.Location = new System.Drawing.Point(12, 12);
            this.wteczButton.Name = "wteczButton";
            this.wteczButton.Size = new System.Drawing.Size(23, 23);
            this.wteczButton.TabIndex = 0;
            this.wteczButton.Text = "<";
            this.wteczButton.UseVisualStyleBackColor = true;
            this.wteczButton.Click += new System.EventHandler(this.wsteczButton_Click);
            // 
            // przodButton
            // 
            this.przodButton.Location = new System.Drawing.Point(41, 12);
            this.przodButton.Name = "przodButton";
            this.przodButton.Size = new System.Drawing.Size(22, 23);
            this.przodButton.TabIndex = 1;
            this.przodButton.Text = ">";
            this.przodButton.UseVisualStyleBackColor = true;
            this.przodButton.Click += new System.EventHandler(this.przodButton_Click);
            // 
            // zatrzymajButton
            // 
            this.zatrzymajButton.Location = new System.Drawing.Point(69, 12);
            this.zatrzymajButton.Name = "zatrzymajButton";
            this.zatrzymajButton.Size = new System.Drawing.Size(64, 23);
            this.zatrzymajButton.TabIndex = 2;
            this.zatrzymajButton.Text = "Zatrzymaj";
            this.zatrzymajButton.UseVisualStyleBackColor = true;
            this.zatrzymajButton.Click += new System.EventHandler(this.zatrzymajButton_Click);
            // 
            // odswiezButton
            // 
            this.odswiezButton.Location = new System.Drawing.Point(139, 12);
            this.odswiezButton.Name = "odswiezButton";
            this.odswiezButton.Size = new System.Drawing.Size(55, 23);
            this.odswiezButton.TabIndex = 3;
            this.odswiezButton.Text = "Odswież";
            this.odswiezButton.UseVisualStyleBackColor = true;
            this.odswiezButton.Click += new System.EventHandler(this.odswiezButton_Click);
            // 
            // dodajUlubionyButton
            // 
            this.dodajUlubionyButton.Location = new System.Drawing.Point(583, 12);
            this.dodajUlubionyButton.Name = "dodajUlubionyButton";
            this.dodajUlubionyButton.Size = new System.Drawing.Size(124, 23);
            this.dodajUlubionyButton.TabIndex = 4;
            this.dodajUlubionyButton.Text = "Dodaj do ulubionych";
            this.dodajUlubionyButton.UseVisualStyleBackColor = true;
            this.dodajUlubionyButton.Click += new System.EventHandler(this.dodajUlubionyButton_Click);
            // 
            // idzButton
            // 
            this.idzButton.Location = new System.Drawing.Point(713, 12);
            this.idzButton.Name = "idzButton";
            this.idzButton.Size = new System.Drawing.Size(75, 23);
            this.idzButton.TabIndex = 5;
            this.idzButton.Text = "Idź";
            this.idzButton.UseVisualStyleBackColor = true;
            this.idzButton.Click += new System.EventHandler(this.idzButton_Click);
            // 
            // ulubioneComboBox
            // 
            this.ulubioneComboBox.FormattingEnabled = true;
            this.ulubioneComboBox.Location = new System.Drawing.Point(200, 14);
            this.ulubioneComboBox.Name = "ulubioneComboBox";
            this.ulubioneComboBox.Size = new System.Drawing.Size(377, 21);
            this.ulubioneComboBox.TabIndex = 6;
            this.ulubioneComboBox.SelectedIndexChanged += new System.EventHandler(this.ulubioneComboBox_SelectedIndexChanged);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 41);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(776, 20);
            this.urlTextBox.TabIndex = 7;
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyDown);
            // 
            // przegladarkaWebBrowser
            // 
            this.przegladarkaWebBrowser.Location = new System.Drawing.Point(12, 67);
            this.przegladarkaWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.przegladarkaWebBrowser.Name = "przegladarkaWebBrowser";
            this.przegladarkaWebBrowser.Size = new System.Drawing.Size(1054, 454);
            this.przegladarkaWebBrowser.TabIndex = 8;
            this.przegladarkaWebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.przegladarkaWebBrowser_Navigated);
            // 
            // Przeglądarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 549);
            this.Controls.Add(this.Podpis);
            this.Controls.Add(this.przegladarkaWebBrowser);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.ulubioneComboBox);
            this.Controls.Add(this.idzButton);
            this.Controls.Add(this.dodajUlubionyButton);
            this.Controls.Add(this.odswiezButton);
            this.Controls.Add(this.zatrzymajButton);
            this.Controls.Add(this.przodButton);
            this.Controls.Add(this.wteczButton);
            this.DoubleBuffered = true;
            this.Name = "Przeglądarka";
            this.Text = "Przeglądarka internetowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wteczButton;
        private System.Windows.Forms.Button przodButton;
        private System.Windows.Forms.Button zatrzymajButton;
        private System.Windows.Forms.Button odswiezButton;
        private System.Windows.Forms.Button dodajUlubionyButton;
        private System.Windows.Forms.Button idzButton;
        private System.Windows.Forms.ComboBox ulubioneComboBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.WebBrowser przegladarkaWebBrowser;
        private System.Windows.Forms.Label Podpis;
    }
}

