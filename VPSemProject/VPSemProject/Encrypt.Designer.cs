﻿namespace VPSemProject
{
    partial class Encrypt
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.RichTextBox();
            this.OpenTextFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 166);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(72, 182);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(75, 23);
            this.AddImage.TabIndex = 5;
            this.AddImage.Text = "Add Image";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(166, 199);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(326, 65);
            this.input.TabIndex = 6;
            this.input.Text = "";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // OpenTextFile
            // 
            this.OpenTextFile.Location = new System.Drawing.Point(175, 270);
            this.OpenTextFile.Name = "OpenTextFile";
            this.OpenTextFile.Size = new System.Drawing.Size(94, 23);
            this.OpenTextFile.TabIndex = 7;
            this.OpenTextFile.Text = "OpenTextFile";
            this.OpenTextFile.UseVisualStyleBackColor = true;
            this.OpenTextFile.Click += new System.EventHandler(this.OpenTextFile_Click);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 331);
            this.Controls.Add(this.OpenTextFile);
            this.Controls.Add(this.input);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Encrypt";
            this.Text = "Encrypt";
            this.Load += new System.EventHandler(this.Encrypt_Load);
            this.MdiChildActivate += new System.EventHandler(this.Encrypt_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Button OpenTextFile;
    }
}