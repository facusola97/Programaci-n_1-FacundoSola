﻿namespace Front.Formularios
{
    partial class TarjetaDeCredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (TarjetaDeCredito));
            pictureBox1 = new PictureBox ();
            button1 = new Button ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            SuspendLayout ();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (797, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point (117, 234);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // TarjetaDeCredito
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (button1);
            Controls.Add (pictureBox1);
            Name = "TarjetaDeCredito";
            Text = "TarjetaDeCredito";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ResumeLayout (false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
    }
}