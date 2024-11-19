namespace LoginProgramaPrincipal
{
    partial class CLIENTE_VENDEDOR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(50, 132);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(205, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "CONSUMIDOR - CLIENTE";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(271, 19);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO AL SISTEMA DE VARIEDADES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(64, 60);
            label2.Name = "label2";
            label2.Size = new Size(169, 19);
            label2.TabIndex = 2;
            label2.Text = "\"LA BENDICION DE DIOS\"";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(50, 196);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 25);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "VENDEDOR";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(27, 281);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 4;
            button1.Text = "&INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(158, 281);
            button2.Name = "button2";
            button2.Size = new Size(108, 39);
            button2.TabIndex = 5;
            button2.Text = "&CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CLIENTE_VENDEDOR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 343);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton1);
            Name = "CLIENTE_VENDEDOR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLIENTE_VENDEDOR";
            Load += CLIENTE_VENDEDOR_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private Label label1;
        private Label label2;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
    }
}