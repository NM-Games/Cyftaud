﻿namespace Cyftaud
{
    partial class Form2
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
            this.NameVersionLabel = new System.Windows.Forms.Label();
            this.ByLabel = new System.Windows.Forms.Label();
            this.NMLogo = new System.Windows.Forms.PictureBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.WebsiteButton = new System.Windows.Forms.Button();
            this.GithubButton = new System.Windows.Forms.Button();
            this.DiscordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NMLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // NameVersionLabel
            // 
            this.NameVersionLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameVersionLabel.Location = new System.Drawing.Point(12, 9);
            this.NameVersionLabel.Name = "NameVersionLabel";
            this.NameVersionLabel.Size = new System.Drawing.Size(232, 42);
            this.NameVersionLabel.TabIndex = 0;
            this.NameVersionLabel.Text = "Cyftaud ";
            this.NameVersionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ByLabel
            // 
            this.ByLabel.AutoSize = true;
            this.ByLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByLabel.Location = new System.Drawing.Point(25, 64);
            this.ByLabel.Name = "ByLabel";
            this.ByLabel.Size = new System.Drawing.Size(32, 25);
            this.ByLabel.TabIndex = 1;
            this.ByLabel.Text = "by";
            // 
            // NMLogo
            // 
            this.NMLogo.Image = global::Cyftaud.Properties.Resources.logo_wide;
            this.NMLogo.Location = new System.Drawing.Point(61, 57);
            this.NMLogo.Name = "NMLogo";
            this.NMLogo.Size = new System.Drawing.Size(166, 42);
            this.NMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NMLogo.TabIndex = 2;
            this.NMLogo.TabStop = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(12, 109);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(232, 44);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "Cyftaud is a free and open-source tool\r\nto copy (zipped) folders to USB drives!";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebsiteButton
            // 
            this.WebsiteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WebsiteButton.Location = new System.Drawing.Point(9, 160);
            this.WebsiteButton.Name = "WebsiteButton";
            this.WebsiteButton.Size = new System.Drawing.Size(75, 23);
            this.WebsiteButton.TabIndex = 4;
            this.WebsiteButton.Text = "Website";
            this.WebsiteButton.UseVisualStyleBackColor = true;
            this.WebsiteButton.Click += new System.EventHandler(this.WebsiteButton_Click);
            // 
            // GithubButton
            // 
            this.GithubButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GithubButton.Location = new System.Drawing.Point(90, 160);
            this.GithubButton.Name = "GithubButton";
            this.GithubButton.Size = new System.Drawing.Size(75, 23);
            this.GithubButton.TabIndex = 5;
            this.GithubButton.Text = "GitHub";
            this.GithubButton.UseVisualStyleBackColor = true;
            this.GithubButton.Click += new System.EventHandler(this.GithubButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DiscordButton.Location = new System.Drawing.Point(171, 160);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Size = new System.Drawing.Size(75, 23);
            this.DiscordButton.TabIndex = 6;
            this.DiscordButton.Text = "Discord";
            this.DiscordButton.UseVisualStyleBackColor = true;
            this.DiscordButton.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 194);
            this.Controls.Add(this.DiscordButton);
            this.Controls.Add(this.GithubButton);
            this.Controls.Add(this.WebsiteButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.NMLogo);
            this.Controls.Add(this.ByLabel);
            this.Controls.Add(this.NameVersionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Cyftaud.Properties.Resources.cyftaud;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "About Cyftaud";
            ((System.ComponentModel.ISupportInitialize)(this.NMLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameVersionLabel;
        private Label ByLabel;
        private PictureBox NMLogo;
        private Label InfoLabel;
        private Button WebsiteButton;
        private Button GithubButton;
        private Button DiscordButton;
    }
}