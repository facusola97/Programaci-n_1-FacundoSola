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
            label1 = new Label ();
            button1 = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            SuspendLayout ();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font ("Arial", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point (207, 22);
            label1.Name = "label1";
            label1.Size = new Size (440, 43);
            label1.TabIndex = 0;
            label1.Text = "Sistema Entidad Bancaria";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point (165, 153);
            button1.Name = "button1";
            button1.Size = new Size (163, 69);
            button1.TabIndex = 1;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point (371, 153);
            button2.Name = "button2";
            button2.Size = new Size (163, 69);
            button2.TabIndex = 3;
            button2.Text = "Cuenta Bancaria";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point (569, 153);
            button3.Name = "button3";
            button3.Size = new Size (163, 69);
            button3.TabIndex = 4;
            button3.Text = "Taarjeta de Credito";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size (822, 319);
            Controls.Add (button3);
            Controls.Add (button2);
            Controls.Add (button1);
            Controls.Add (label1);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}