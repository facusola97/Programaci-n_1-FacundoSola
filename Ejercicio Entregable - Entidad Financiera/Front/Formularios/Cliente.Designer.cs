namespace Front.Formularios
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Cliente));
            pictureBox1 = new PictureBox ();
            dataGridView1 = new DataGridView ();
            IdCliente = new DataGridViewTextBoxColumn ();
            Nombre = new DataGridViewTextBoxColumn ();
            apellido = new DataGridViewTextBoxColumn ();
            dni = new DataGridViewTextBoxColumn ();
            label1 = new Label ();
            button1 = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            pictureBox2 = new PictureBox ();
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
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange (new DataGridViewColumn[] { IdCliente, Nombre, apellido, dni });
            dataGridView1.Location = new Point (354, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (445, 251);
            dataGridView1.TabIndex = 2;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "ID Cliente";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // dni
            // 
            dni.HeaderText = "N° DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font ("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point (331, 18);
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
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point (-4, 363);
            button2.Name = "button2";
            button2.Size = new Size (173, 54);
            button2.TabIndex = 9;
            button2.Text = "Elimanar Cliente";
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
            // Cliente
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (button1);
            Controls.Add (button2);
            Controls.Add (button3);
            Controls.Add (pictureBox2);
            Controls.Add (label1);
            Controls.Add (dataGridView1);
            Controls.Add (pictureBox1);
            Name = "Cliente";
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
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
    }
}