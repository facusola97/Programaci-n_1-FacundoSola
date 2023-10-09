namespace Front.Formularios
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Inicio));
            pictureBox1 = new PictureBox ();
            button1 = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            label1 = new Label ();
            label2 = new Label ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            SuspendLayout ();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (797, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point (58, 214);
            button1.Name = "button1";
            button1.Size = new Size (179, 74);
            button1.TabIndex = 3;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point (330, 214);
            button2.Name = "button2";
            button2.Size = new Size (173, 74);
            button2.TabIndex = 4;
            button2.Text = "Cuenta Bancaria";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point (571, 214);
            button3.Name = "button3";
            button3.Size = new Size (178, 74);
            button3.TabIndex = 5;
            button3.Text = "Tarjeta De Credito";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font ("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point (174, 65);
            label1.Name = "label1";
            label1.Size = new Size (459, 44);
            label1.TabIndex = 6;
            label1.Text = "Sistema Entidad Financiera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font ("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point (96, 361);
            label2.Name = "label2";
            label2.Size = new Size (47, 17);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (label2);
            Controls.Add (label1);
            Controls.Add (button3);
            Controls.Add (button2);
            Controls.Add (button1);
            Controls.Add (pictureBox1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
    }
}