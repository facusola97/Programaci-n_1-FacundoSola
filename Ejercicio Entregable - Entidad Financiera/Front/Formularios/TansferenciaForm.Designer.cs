namespace Front.Formularios
{
    partial class TansferenciaForm
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
            label1 = new Label ();
            comboBox1 = new ComboBox ();
            button3 = new Button ();
            button2 = new Button ();
            pictureBox1 = new PictureBox ();
            pictureBox2 = new PictureBox ();
            label2 = new Label ();
            numericUpDown1 = new NumericUpDown ();
            button4 = new Button ();
            dataGridView1 = new DataGridView ();
            label3 = new Label ();
            comboBox2 = new ComboBox ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit ();
            SuspendLayout ();
            // 
            // button1
            // 
            button1.Location = new Point (2, 380);
            button1.Name = "button1";
            button1.Size = new Size (226, 27);
            button1.TabIndex = 39;
            button1.Text = "Realizar Deposito";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point (2, 86);
            label1.Name = "label1";
            label1.Size = new Size (208, 20);
            label1.TabIndex = 38;
            label1.Text = "Seleccione la Cuenta de Origen:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (2, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (226, 23);
            comboBox1.TabIndex = 37;
            // 
            // button3
            // 
            button3.Location = new Point (2, 329);
            button3.Name = "button3";
            button3.Size = new Size (226, 31);
            button3.TabIndex = 33;
            button3.Text = "Realizar Transferencia";
            button3.UseVisualStyleBackColor = true;
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
            button2.Location = new Point (-80, 0);
            button2.Name = "button2";
            button2.Size = new Size (59, 56);
            button2.TabIndex = 30;
            button2.Text = "↩";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point (2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (236, 451);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Location = new Point (107, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (792, 83);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point (2, 251);
            label2.Name = "label2";
            label2.Size = new Size (122, 20);
            label2.TabIndex = 42;
            label2.Text = "Ingresar el Monto:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point (4, 274);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size (120, 23);
            numericUpDown1.TabIndex = 43;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.RoyalBlue;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font ("Showcard Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point (2, 0);
            button4.Name = "button4";
            button4.Size = new Size (59, 56);
            button4.TabIndex = 44;
            button4.Text = "↩";
            button4.TextAlign = ContentAlignment.TopLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point (313, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (586, 264);
            dataGridView1.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point (2, 175);
            label3.Name = "label3";
            label3.Size = new Size (213, 20);
            label3.TabIndex = 41;
            label3.Text = "Seleccione la Cuenta de Destino:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point (2, 207);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size (226, 23);
            comboBox2.TabIndex = 40;
            // 
            // TansferenciaForm
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (899, 450);
            Controls.Add (dataGridView1);
            Controls.Add (button4);
            Controls.Add (numericUpDown1);
            Controls.Add (label2);
            Controls.Add (label3);
            Controls.Add (comboBox2);
            Controls.Add (button1);
            Controls.Add (label1);
            Controls.Add (comboBox1);
            Controls.Add (button3);
            Controls.Add (button2);
            Controls.Add (pictureBox1);
            Controls.Add (pictureBox2);
            Name = "TansferenciaForm";
            Text = "Transferencia Bancarias";
            Load += TansferenciaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox comboBox2;
    }
}