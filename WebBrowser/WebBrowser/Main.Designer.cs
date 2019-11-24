namespace WebBrowser
{
    partial class Main
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
            this.backButton = new System.Windows.Forms.Button();
            this.goForwardButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.addToFavButton = new System.Windows.Forms.Button();
            this.favoritesComboBox = new System.Windows.Forms.ComboBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.homeButton = new System.Windows.Forms.Button();
            this.browseMemCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(38, 29);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goForwardButton
            // 
            this.goForwardButton.Location = new System.Drawing.Point(56, 12);
            this.goForwardButton.Name = "goForwardButton";
            this.goForwardButton.Size = new System.Drawing.Size(38, 29);
            this.goForwardButton.TabIndex = 1;
            this.goForwardButton.Text = ">";
            this.goForwardButton.UseVisualStyleBackColor = true;
            this.goForwardButton.Click += new System.EventHandler(this.goForwardButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(100, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(51, 29);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(157, 12);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(63, 29);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Refresh";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(965, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(51, 29);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(286, 17);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(574, 20);
            this.urlTextBox.TabIndex = 5;
            // 
            // addToFavButton
            // 
            this.addToFavButton.Location = new System.Drawing.Point(1238, 12);
            this.addToFavButton.Name = "addToFavButton";
            this.addToFavButton.Size = new System.Drawing.Size(51, 29);
            this.addToFavButton.TabIndex = 6;
            this.addToFavButton.Text = "Add";
            this.addToFavButton.UseVisualStyleBackColor = true;
            this.addToFavButton.Click += new System.EventHandler(this.addToFavButton_Click);
            // 
            // favoritesComboBox
            // 
            this.favoritesComboBox.FormattingEnabled = true;
            this.favoritesComboBox.Location = new System.Drawing.Point(1022, 16);
            this.favoritesComboBox.Name = "favoritesComboBox";
            this.favoritesComboBox.Size = new System.Drawing.Size(210, 21);
            this.favoritesComboBox.TabIndex = 7;
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(12, 47);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1277, 794);
            this.browser.TabIndex = 8;
            this.browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.browser_Navigated);
            this.browser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.browser_Navigating);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(226, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(54, 29);
            this.homeButton.TabIndex = 9;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // browseMemCheckbox
            // 
            this.browseMemCheckbox.AutoSize = true;
            this.browseMemCheckbox.Location = new System.Drawing.Point(866, 18);
            this.browseMemCheckbox.Name = "browseMemCheckbox";
            this.browseMemCheckbox.Size = new System.Drawing.Size(97, 17);
            this.browseMemCheckbox.TabIndex = 10;
            this.browseMemCheckbox.Text = "Browse memes";
            this.browseMemCheckbox.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 853);
            this.Controls.Add(this.browseMemCheckbox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.favoritesComboBox);
            this.Controls.Add(this.addToFavButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.goForwardButton);
            this.Controls.Add(this.backButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goForwardButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button addToFavButton;
        private System.Windows.Forms.ComboBox favoritesComboBox;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.CheckBox browseMemCheckbox;
    }
}