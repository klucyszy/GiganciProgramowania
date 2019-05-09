namespace Samples.Biblioteka
{
    partial class NewGameForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.minAgeTextBox = new System.Windows.Forms.TextBox();
            this.minAgeLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(375, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tytuł";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(15, 35);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(372, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(15, 88);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(372, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(12, 62);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(375, 23);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Cena";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(15, 142);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(372, 20);
            this.descTextBox.TabIndex = 5;
            // 
            // descLabel
            // 
            this.descLabel.Location = new System.Drawing.Point(12, 116);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(375, 23);
            this.descLabel.TabIndex = 4;
            this.descLabel.Text = "Opis";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minAgeTextBox
            // 
            this.minAgeTextBox.Location = new System.Drawing.Point(15, 191);
            this.minAgeTextBox.Name = "minAgeTextBox";
            this.minAgeTextBox.Size = new System.Drawing.Size(372, 20);
            this.minAgeTextBox.TabIndex = 7;
            // 
            // minAgeLabel
            // 
            this.minAgeLabel.Location = new System.Drawing.Point(12, 165);
            this.minAgeLabel.Name = "minAgeLabel";
            this.minAgeLabel.Size = new System.Drawing.Size(375, 23);
            this.minAgeLabel.TabIndex = 6;
            this.minAgeLabel.Text = "Ograniczenie wiekowe";
            this.minAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(15, 217);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(182, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(203, 217);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 252);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.minAgeTextBox);
            this.Controls.Add(this.minAgeLabel);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "NewGameForm";
            this.Text = "Biblioteka - Dodaj Grę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox minAgeTextBox;
        private System.Windows.Forms.Label minAgeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
    }
}