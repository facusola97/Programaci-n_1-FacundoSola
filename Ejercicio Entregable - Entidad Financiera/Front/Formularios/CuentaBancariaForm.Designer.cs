namespace Front.Formularios
{
    partial class CuentaBancariaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (CuentaBancariaForm));
            button1 = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            pictureBox2 = new PictureBox ();
            label1 = new Label ();
            pictureBox1 = new PictureBox ();
            txtdni = new Label ();
            txt1 = new TextBox ();
            txtNombre = new TextBox ();
            label2 = new Label ();
            label3 = new Label ();
            txt2 = new TextBox ();
            dataGridView1 = new DataGridView ();
            button4 = new Button ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit ();
            SuspendLayout ();
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point (5, 236);
            button1.Name = "button1";
            button1.Size = new Size (173, 54);
            button1.TabIndex = 15;
            button1.Text = "Crear Cuenta Bancaria:";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font ("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point (5, 310);
            button2.Name = "button2";
            button2.Size = new Size (173, 54);
            button2.TabIndex = 16;
            button2.Text = "Realizar Transferencia";
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
            button3.Location = new Point (5, 0);
            button3.Name = "button3";
            button3.Size = new Size (47, 37);
            button3.TabIndex = 17;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Location = new Point (5, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (173, 512);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font ("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point (245, 0);
            label1.Name = "label1";
            label1.Size = new Size (493, 44);
            label1.TabIndex = 14;
            label1.Text = "Gestión de Cuentas Bancarias";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (5, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (921, 521);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtdni
            // 
            txtdni.AutoSize = true;
            txtdni.BackColor = Color.RoyalBlue;
            txtdni.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            txtdni.ForeColor = SystemColors.ActiveCaptionText;
            txtdni.Location = new Point (174, 293);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size (162, 21);
            txtdni.TabIndex = 19;
            txtdni.Text = "Ingrese su N° de DNI";
            // 
            // txt1
            // 
            txt1.Location = new Point (381, 291);
            txt1.Name = "txt1";
            txt1.Size = new Size (201, 23);
            txt1.TabIndex = 20;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point (381, 225);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size (201, 23);
            txtNombre.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point (174, 223);
            label2.Name = "label2";
            label2.Size = new Size (158, 21);
            label2.TabIndex = 22;
            label2.Text = "Ingrese su Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point (174, 358);
            label3.Name = "label3";
            label3.Size = new Size (201, 21);
            label3.TabIndex = 23;
            label3.Text = "Ingrese el Tipo de Cuenta:";
            // 
            // txt2
            // 
            txt2.Location = new Point (381, 356);
            txt2.Name = "txt2";
            txt2.Size = new Size (201, 23);
            txt2.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point (590, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (328, 289);
            dataGridView1.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font ("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point (5, 382);
            button4.Name = "button4";
            button4.Size = new Size (173, 54);
            button4.TabIndex = 26;
            button4.Text = "Realizar Deposito";
            button4.UseVisualStyleBackColor = false;
            // 
            // CuentaBancariaForm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (919, 514);
            Controls.Add (button4);
            Controls.Add (dataGridView1);
            Controls.Add (txt2);
            Controls.Add (label3);
            Controls.Add (label2);
            Controls.Add (txtNombre);
            Controls.Add (txt1);
            Controls.Add (txtdni);
            Controls.Add (button1);
            Controls.Add (button2);
            Controls.Add (button3);
            Controls.Add (pictureBox2);
            Controls.Add (label1);
            Controls.Add (pictureBox1);
            Name = "CuentaBancariaForm";
            Text = "CuentaBancaria";
            Load += CuentaBancaria_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label txtdni;
        private TextBox txt1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txt2;
        private DataGridView dataGridView1;
        private Button button4;
    }
}