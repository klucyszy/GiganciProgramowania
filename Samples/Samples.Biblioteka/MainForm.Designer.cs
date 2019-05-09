namespace Samples.Biblioteka
{
    partial class MainForm
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
            this.gameListLabel = new System.Windows.Forms.Label();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.addGameButton = new System.Windows.Forms.Button();
            this.deleteGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameListLabel
            // 
            this.gameListLabel.Enabled = false;
            this.gameListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameListLabel.Location = new System.Drawing.Point(12, 9);
            this.gameListLabel.Name = "gameListLabel";
            this.gameListLabel.Size = new System.Drawing.Size(454, 23);
            this.gameListLabel.TabIndex = 0;
            this.gameListLabel.Text = "Biblioteka gier";
            this.gameListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(16, 35);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(450, 238);
            this.gameListBox.TabIndex = 1;
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(16, 281);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(222, 23);
            this.addGameButton.TabIndex = 2;
            this.addGameButton.Text = "Dodaj grę";
            this.addGameButton.UseVisualStyleBackColor = true;
            // 
            // deleteGameButton
            // 
            this.deleteGameButton.Location = new System.Drawing.Point(244, 281);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(222, 23);
            this.deleteGameButton.TabIndex = 3;
            this.deleteGameButton.Text = "Usuń grę";
            this.deleteGameButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 316);
            this.Controls.Add(this.deleteGameButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.gameListBox);
            this.Controls.Add(this.gameListLabel);
            this.Name = "MainForm";
            this.Text = "Biblioteka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameListLabel;
        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button deleteGameButton;
    }
}