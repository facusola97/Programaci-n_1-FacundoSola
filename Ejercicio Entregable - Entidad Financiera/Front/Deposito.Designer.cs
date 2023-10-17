namespace Front
{
    partial class Deposito
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
            label6 = new Label ();
            dataGridView1 = new DataGridView ();
            button4 = new Button ();
            label2 = new Label ();
            button1 = new Button ();
            pictureBox2 = new PictureBox ();
            label4 = new Label ();
            txtmonto = new TextBox ();
            comboBox1 = new ComboBox ();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RoyalBlue;
            label6.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point (1, 117);
            label6.Name = "label6";
            label6.Size = new Size (284, 20);
            label6.TabIndex = 33;
            label6.Text = "Seleccione en la grilla la cuenta a depositar:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point (400, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size (573, 319);
            dataGridView1.TabIndex = 34;
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
            button4.Location = new Point (1, 0);
            button4.Name = "button4";
            button4.Size = new Size (59, 56);
            button4.TabIndex = 55;
            button4.Text = "↩";
            button4.TextAlign = ContentAlignment.TopLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font ("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point (-3, 218);
            label2.Name = "label2";
            label2.Size = new Size (196, 20);
            label2.TabIndex = 53;
            label2.Text = "Ingresar el Monto a Depositar:";
            // 
            // button1
            // 
            button1.Location = new Point (50, 335);
            button1.Name = "button1";
            button1.Size = new Size (195, 59);
            button1.TabIndex = 50;
            button1.Text = "Realizar Deposito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Location = new Point (1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (963, 83);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font ("Arial", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point (325, 24);
            label4.Name = "label4";
            label4.Size = new Size (406, 43);
            label4.TabIndex = 56;
            label4.Text = "Operación de Deposito:";
            // 
            // txtmonto
            // 
            txtmonto.Location = new Point (12, 262);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size (162, 23);
            txtmonto.TabIndex = 59;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (1, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (284, 23);
            comboBox1.TabIndex = 60;
            // 
            // Deposito
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (977, 452);
            Controls.Add (comboBox1);
            Controls.Add (txtmonto);
            Controls.Add (label4);
            Controls.Add (button4);
            Controls.Add (label2);
            Controls.Add (button1);
            Controls.Add (pictureBox2);
            Controls.Add (dataGridView1);
            Controls.Add (label6);
            Name = "Deposito";
            Text = "Deposito";
            Load += Deposito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Label label6;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox txtmonto;
        private ComboBox comboBox1;
    }
}