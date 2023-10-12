namespace Front.Formularios
{
    partial class ClienteForm
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
            button1 = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            label1 = new Label ();
            txtnombre = new TextBox ();
            txtapellido = new TextBox ();
            txtdni = new TextBox ();
            dataGridView1 = new DataGridView ();
            pictureBox1 = new PictureBox ();
            label3 = new Label ();
            label2 = new Label ();
            label4 = new Label ();
            pictureBox2 = new PictureBox ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.RoyalBlue;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font ("Showcard Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point (0, -1);
            button1.Name = "button1";
            button1.Size = new Size (59, 56);
            button1.TabIndex = 0;
            button1.Text = "↩";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point (0, 314);
            button2.Name = "button2";
            button2.Size = new Size (174, 36);
            button2.TabIndex = 1;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point (0, 365);
            button3.Name = "button3";
            button3.Size = new Size (174, 28);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point (12, 96);
            label1.Name = "label1";
            label1.Size = new Size (135, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese su Nombre :";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point (12, 128);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size (135, 23);
            txtnombre.TabIndex = 4;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point (12, 202);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size (134, 23);
            txtapellido.TabIndex = 5;
            // 
            // txtdni
            // 
            txtdni.Location = new Point (12, 271);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size (142, 23);
            txtdni.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point (419, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (560, 279);
            dataGridView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point (0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (174, 416);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point (12, 179);
            label3.Name = "label3";
            label3.Size = new Size (134, 20);
            label3.TabIndex = 10;
            label3.Text = "Ingrese su Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point (12, 248);
            label2.Name = "label2";
            label2.Size = new Size (142, 20);
            label2.TabIndex = 11;
            label2.Text = "Ingrese su N° de DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font ("Arial", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point (431, 25);
            label4.Name = "label4";
            label4.Size = new Size (152, 43);
            label4.TabIndex = 12;
            label4.Text = "Clientes";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Location = new Point (171, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (808, 83);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size (980, 416);
            Controls.Add (label4);
            Controls.Add (label2);
            Controls.Add (label3);
            Controls.Add (dataGridView1);
            Controls.Add (txtdni);
            Controls.Add (txtapellido);
            Controls.Add (txtnombre);
            Controls.Add (label1);
            Controls.Add (button3);
            Controls.Add (button2);
            Controls.Add (button1);
            Controls.Add (pictureBox1);
            Controls.Add (pictureBox2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ClienteForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "ClienteForm";
            Load += ClienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtdni;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox2;
    }
}