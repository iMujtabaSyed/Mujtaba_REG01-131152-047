namespace VPSemProject
{
    partial class Decrypt
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
            this.Decryptedmessage = new System.Windows.Forms.Label();
            this.DecryptText = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.saveFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(167, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 196);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image";
            // 
            // Decryptedmessage
            // 
            this.Decryptedmessage.AutoSize = true;
            this.Decryptedmessage.Location = new System.Drawing.Point(59, 239);
            this.Decryptedmessage.Name = "Decryptedmessage";
            this.Decryptedmessage.Size = new System.Drawing.Size(102, 13);
            this.Decryptedmessage.TabIndex = 3;
            this.Decryptedmessage.Text = "Decrypted Message";
            // 
            // DecryptText
            // 
            this.DecryptText.Location = new System.Drawing.Point(306, 296);
            this.DecryptText.Name = "DecryptText";
            this.DecryptText.Size = new System.Drawing.Size(98, 23);
            this.DecryptText.TabIndex = 4;
            this.DecryptText.Text = "Decrypt";
            this.DecryptText.UseVisualStyleBackColor = true;
            this.DecryptText.Click += new System.EventHandler(this.DecryptText_Click);
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(62, 185);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(75, 23);
            this.AddImage.TabIndex = 5;
            this.AddImage.Text = "Add Image";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(163, 214);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(306, 76);
            this.output.TabIndex = 6;
            this.output.Text = "";
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(201, 296);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(99, 23);
            this.saveFile.TabIndex = 7;
            this.saveFile.Text = "Save to TextFile";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 331);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.output);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.DecryptText);
            this.Controls.Add(this.Decryptedmessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Decryptedmessage;
        private System.Windows.Forms.Button DecryptText;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button saveFile;
    }
}