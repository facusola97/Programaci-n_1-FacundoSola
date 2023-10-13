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
            button3 = new Button ();
            label2 = new Label ();
            label3 = new Label ();
            dataGridView1 = new DataGridView ();
            txtsaldo = new TextBox ();
            txtcredito = new TextBox ();
            button4 = new Button ();
            button5 = new Button ();
            pictureBox1 = new PictureBox ();
            label1 = new Label ();
            txtpagoSaldo = new TextBox ();
            button1 = new Button ();
            label4 = new Label ();
            pictureBox2 = new PictureBox ();
            comboBox1 = new ComboBox ();
            textBox1 = new TextBox ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.RoyalBlue;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font ("Showcard Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point (-2, -1);
            button3.Name = "button3";
            button3.Size = new Size (59, 56);
            button3.TabIndex = 2;
            button3.Text = "↩";
            button3.TextAlign = ContentAlignment.TopLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point (-2, 151);
            label2.Name = "label2";
            label2.Size = new Size (49, 20);
            label2.TabIndex = 20;
            label2.Text = "Saldo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point (143, 82);
            label3.Name = "label3";
            label3.Size = new Size (120, 20);
            label3.TabIndex = 19;
            label3.Text = "Limite de Crédito:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point (418, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (560, 342);
            dataGridView1.TabIndex = 17;
            // 
            // txtsaldo
            // 
            txtsaldo.Location = new Point (-2, 174);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size (131, 23);
            txtsaldo.TabIndex = 16;
            // 
            // txtcredito
            // 
            txtcredito.Location = new Point (135, 105);
            txtcredito.Name = "txtcredito";
            txtcredito.Size = new Size (128, 23);
            txtcredito.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point (-2, 378);
            button4.Name = "button4";
            button4.Size = new Size (174, 28);
            button4.TabIndex = 13;
            button4.Text = "Pagar Saldo";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point (136, 166);
            button5.Name = "button5";
            button5.Size = new Size (141, 36);
            button5.TabIndex = 12;
            button5.Text = "Emitir Tarjeta de Credito";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point (-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (279, 468);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point (-2, 82);
            label1.Name = "label1";
            label1.Size = new Size (131, 20);
            label1.TabIndex = 21;
            label1.Text = "Ingrese su Nombre:";
            // 
            // txtpagoSaldo
            // 
            txtpagoSaldo.Location = new Point (-2, 335);
            txtpagoSaldo.Name = "txtpagoSaldo";
            txtpagoSaldo.Size = new Size (174, 23);
            txtpagoSaldo.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point (-2, 419);
            button1.Name = "button1";
            button1.Size = new Size (174, 28);
            button1.TabIndex = 23;
            button1.Text = "Generar Resumen";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font ("Arial", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point (283, 23);
            label4.Name = "label4";
            label4.Size = new Size (547, 43);
            label4.TabIndex = 24;
            label4.Text = "Operaciones Tarjetas de Credito";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Location = new Point (170, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (791, 83);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (-2, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (131, 23);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point (-2, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size (100, 23);
            textBox1.TabIndex = 27;
            // 
            // TarjetaDeCreditoForm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (959, 466);
            Controls.Add (textBox1);
            Controls.Add (comboBox1);
            Controls.Add (label4);
            Controls.Add (button1);
            Controls.Add (txtpagoSaldo);
            Controls.Add (label1);
            Controls.Add (label2);
            Controls.Add (label3);
            Controls.Add (dataGridView1);
            Controls.Add (txtsaldo);
            Controls.Add (txtcredito);
            Controls.Add (button4);
            Controls.Add (button5);
            Controls.Add (button3);
            Controls.Add (pictureBox1);
            Controls.Add (pictureBox2);
            Name = "TarjetaDeCreditoForm";
            Text = "TarjetaDeCreditoForm";
            Load += TarjetaDeCreditoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion
        private Button button3;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox txtsaldo;
        private TextBox txtcredito;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtpagoSaldo;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}