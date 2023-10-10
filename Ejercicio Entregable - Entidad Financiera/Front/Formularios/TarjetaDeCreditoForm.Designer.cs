namespace Front.Formularios
{
    partial class TarjetaDeCreditoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (TarjetaDeCreditoForm));
            button2 = new Button ();
            button3 = new Button ();
            button5 = new Button ();
            pictureBox2 = new PictureBox ();
            label1 = new Label ();
            pictureBox1 = new PictureBox ();
            dataGridView1 = new DataGridView ();
            button6 = new Button ();
            button1 = new Button ();
            button4 = new Button ();
            label2 = new Label ();
            textBox2 = new TextBox ();
            textBox3 = new TextBox ();
            textBox4 = new TextBox ();
            label4 = new Label ();
            label3 = new Label ();
            textBox1 = new TextBox ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit ();
            SuspendLayout ();
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.ForeColor = Color.Black;
            button2.Location = new Point (233, 497);
            button2.Name = "button2";
            button2.Size = new Size (173, 54);
            button2.TabIndex = 15;
            button2.Text = "Agregar Nuevo Cliente";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point (233, 597);
            button3.Name = "button3";
            button3.Size = new Size (173, 54);
            button3.TabIndex = 16;
            button3.Text = "Elimanar Cliente";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.BackgroundImage = (Image)resources.GetObject ("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderColor = Color.LightGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.InfoText;
            button5.Location = new Point (5, 0);
            button5.Name = "button5";
            button5.Size = new Size (47, 37);
            button5.TabIndex = 22;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Location = new Point (5, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (300, 551);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font ("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point (334, 18);
            label1.Name = "label1";
            label1.Size = new Size (310, 44);
            label1.TabIndex = 19;
            label1.Text = "Tarjeta de Credito";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (921, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point (387, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (539, 384);
            dataGridView1.TabIndex = 24;
            // 
            // button6
            // 
            button6.BackColor = Color.RoyalBlue;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font ("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Location = new Point (5, 288);
            button6.Name = "button6";
            button6.Size = new Size (239, 39);
            button6.TabIndex = 25;
            button6.Text = "Emitir Nueva Tarjeta";
            button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font ("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point (5, 419);
            button1.Name = "button1";
            button1.Size = new Size (239, 39);
            button1.TabIndex = 26;
            button1.Text = "Pagar Saldo";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font ("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point (5, 476);
            button4.Name = "button4";
            button4.Size = new Size (239, 36);
            button4.TabIndex = 27;
            button4.Text = "Generar Resumen:";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font ("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point (5, 60);
            label2.Margin = new Padding (3, 5, 3, 5);
            label2.Name = "label2";
            label2.Size = new Size (171, 23);
            label2.TabIndex = 28;
            label2.Text = "Nombre del Titular:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point (5, 380);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size (239, 33);
            textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            textBox3.Location = new Point (5, 166);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size (239, 33);
            textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            textBox4.Location = new Point (5, 249);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size (239, 33);
            textBox4.TabIndex = 33;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font ("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point (5, 210);
            label4.Margin = new Padding (3, 5, 3, 5);
            label4.Name = "label4";
            label4.Size = new Size (239, 31);
            label4.TabIndex = 34;
            label4.Text = "Saldo :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font ("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point (5, 127);
            label3.Margin = new Padding (3, 5, 3, 5);
            label3.Name = "label3";
            label3.Size = new Size (239, 31);
            label3.TabIndex = 35;
            label3.Text = "Limite de Credito:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point (5, 86);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size (239, 33);
            textBox1.TabIndex = 36;
            // 
            // TarjetaDeCreditoForm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (927, 545);
            Controls.Add (textBox1);
            Controls.Add (label3);
            Controls.Add (label4);
            Controls.Add (textBox4);
            Controls.Add (textBox3);
            Controls.Add (textBox2);
            Controls.Add (label2);
            Controls.Add (button4);
            Controls.Add (button1);
            Controls.Add (button6);
            Controls.Add (dataGridView1);
            Controls.Add (button5);
            Controls.Add (pictureBox2);
            Controls.Add (label1);
            Controls.Add (pictureBox1);
            Controls.Add (button2);
            Controls.Add (button3);
            Name = "TarjetaDeCreditoForm";
            Text = "TarjetaDeCredito";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Button button2;
        private Button button3;
        private Button button5;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button1;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
    }
}