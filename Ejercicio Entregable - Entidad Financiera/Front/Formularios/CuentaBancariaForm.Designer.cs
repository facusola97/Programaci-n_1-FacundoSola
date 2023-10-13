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
            button2 = new Button ();
            label4 = new Label ();
            pictureBox2 = new PictureBox ();
            label2 = new Label ();
            dataGridView1 = new DataGridView ();
            txtdni = new TextBox ();
            button3 = new Button ();
            button4 = new Button ();
            pictureBox1 = new PictureBox ();
            comboBox1 = new ComboBox ();
            label1 = new Label ();
            button1 = new Button ();
            comboBox2 = new ComboBox ();
            label3 = new Label ();
            textBox1 = new TextBox ();
            label5 = new Label ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            SuspendLayout ();
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.RoyalBlue;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font ("Showcard Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point (-3, -2);
            button2.Name = "button2";
            button2.Size = new Size (59, 56);
            button2.TabIndex = 1;
            button2.Text = "↩";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font ("Arial", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point (416, 24);
            label4.Name = "label4";
            label4.Size = new Size (494, 43);
            label4.TabIndex = 14;
            label4.Text = "Gestion de Cuenta Bancarias";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Location = new Point (184, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (792, 83);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point (157, 98);
            label2.Name = "label2";
            label2.Size = new Size (142, 20);
            label2.TabIndex = 24;
            label2.Text = "Ingrese su N° de DNI:";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point (413, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (560, 279);
            dataGridView1.TabIndex = 21;
            // 
            // txtdni
            // 
            txtdni.Location = new Point (157, 121);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size (142, 23);
            txtdni.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point (-6, 402);
            button3.Name = "button3";
            button3.Size = new Size (194, 31);
            button3.TabIndex = 17;
            button3.Text = "Realizar Transferencia";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point (205, 188);
            button4.Name = "button4";
            button4.Size = new Size (135, 43);
            button4.TabIndex = 16;
            button4.Text = "Crear Cuenta Bancaria";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point (-6, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (346, 451);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (-2, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (134, 23);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point (-3, 98);
            label1.Name = "label1";
            label1.Size = new Size (125, 20);
            label1.TabIndex = 26;
            label1.Text = "Seleccione Titular:";
            // 
            // button1
            // 
            button1.Location = new Point (-6, 357);
            button1.Name = "button1";
            button1.Size = new Size (194, 27);
            button1.TabIndex = 27;
            button1.Text = "Realizar Deposito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point (-2, 188);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size (174, 23);
            comboBox2.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point (-2, 165);
            label3.Name = "label3";
            label3.Size = new Size (190, 20);
            label3.TabIndex = 29;
            label3.Text = "Seleccione el Tipo de Cuenta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point (-2, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size (142, 23);
            textBox1.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point (-2, 280);
            label5.Name = "label5";
            label5.Size = new Size (108, 20);
            label5.TabIndex = 31;
            label5.Text = "Ingrese el saldo";
            // 
            // CuentaBancariaForm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (967, 450);
            Controls.Add (label5);
            Controls.Add (textBox1);
            Controls.Add (label3);
            Controls.Add (comboBox2);
            Controls.Add (button1);
            Controls.Add (label1);
            Controls.Add (comboBox1);
            Controls.Add (label2);
            Controls.Add (dataGridView1);
            Controls.Add (txtdni);
            Controls.Add (button3);
            Controls.Add (button4);
            Controls.Add (label4);
            Controls.Add (button2);
            Controls.Add (pictureBox1);
            Controls.Add (pictureBox2);
            Name = "CuentaBancariaForm";
            Text = "CuentaBancariaForm";
            Load += CuentaBancariaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion
        private Button button2;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtdni;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label5;
    }
}