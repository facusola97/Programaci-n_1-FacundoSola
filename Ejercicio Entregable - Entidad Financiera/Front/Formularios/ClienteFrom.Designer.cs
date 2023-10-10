namespace Front.Formularios
{
    partial class ClienteFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (ClienteFrom));
            pictureBox1 = new PictureBox ();
            dataGridView1 = new DataGridView ();
            label1 = new Label ();
            button1 = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            pictureBox2 = new PictureBox ();
            txt1 = new TextBox ();
            label2 = new Label ();
            txtapellido = new Label ();
            txtdni = new Label ();
            txt2 = new TextBox ();
            txt3 = new TextBox ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (797, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point (454, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (345, 293);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font ("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point (345, 9);
            label1.Name = "label1";
            label1.Size = new Size (146, 44);
            label1.TabIndex = 7;
            label1.Text = "Clientes";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.ForeColor = Color.Black;
            button1.Location = new Point (-4, 263);
            button1.Name = "button1";
            button1.Size = new Size (173, 54);
            button1.TabIndex = 8;
            button1.Text = "Agregar Nuevo Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point (-4, 363);
            button2.Name = "button2";
            button2.Size = new Size (173, 54);
            button2.TabIndex = 9;
            button2.Text = "Eliminar Cliente";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.BackgroundImage = (Image)resources.GetObject ("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderColor = Color.LightGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point (2, 0);
            button3.Name = "button3";
            button3.Size = new Size (47, 37);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Location = new Point (2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (167, 450);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // txt1
            // 
            txt1.Location = new Point (218, 211);
            txt1.Name = "txt1";
            txt1.Size = new Size (154, 23);
            txt1.TabIndex = 12;
            txt1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point (218, 187);
            label2.Name = "label2";
            label2.Size = new Size (154, 21);
            label2.TabIndex = 13;
            label2.Text = "Ingrese su Nombre:";
            // 
            // txtapellido
            // 
            txtapellido.AutoSize = true;
            txtapellido.BackColor = Color.RoyalBlue;
            txtapellido.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            txtapellido.ForeColor = SystemColors.ActiveCaptionText;
            txtapellido.Location = new Point (218, 263);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size (155, 21);
            txtapellido.TabIndex = 14;
            txtapellido.Text = "Ingrese su Apellido:";
            // 
            // txtdni
            // 
            txtdni.AutoSize = true;
            txtdni.BackColor = Color.RoyalBlue;
            txtdni.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            txtdni.ForeColor = SystemColors.ActiveCaptionText;
            txtdni.Location = new Point (211, 341);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size (162, 21);
            txtdni.TabIndex = 15;
            txtdni.Text = "Ingrese su N° de DNI";
            // 
            // txt2
            // 
            txt2.Location = new Point (219, 287);
            txt2.Name = "txt2";
            txt2.Size = new Size (154, 23);
            txt2.TabIndex = 16;
            // 
            // txt3
            // 
            txt3.Location = new Point (211, 365);
            txt3.Name = "txt3";
            txt3.Size = new Size (162, 23);
            txt3.TabIndex = 17;
            // 
            // ClienteFrom
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (txt3);
            Controls.Add (txt2);
            Controls.Add (txtdni);
            Controls.Add (txtapellido);
            Controls.Add (label2);
            Controls.Add (txt1);
            Controls.Add (button1);
            Controls.Add (button2);
            Controls.Add (button3);
            Controls.Add (pictureBox2);
            Controls.Add (label1);
            Controls.Add (dataGridView1);
            Controls.Add (pictureBox1);
            Name = "ClienteFrom";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private TextBox txt1;
        private Label label2;
        private Label txtapellido;
        private Label txtdni;
        private TextBox txt2;
        private TextBox txt3;
    }
}