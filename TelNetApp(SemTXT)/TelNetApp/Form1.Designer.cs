namespace TelNetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBx1 = new TextBox();
            btnEnviar = new Button();
            buttonEnviar2 = new Button();
            txtBx2 = new TextBox();
            button2 = new Button();
            txtBx3 = new TextBox();
            button3 = new Button();
            txtBx4 = new TextBox();
            button4 = new Button();
            txtBx5 = new TextBox();
            SuspendLayout();
            // 
            // txtBx1
            // 
            txtBx1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx1.Location = new Point(12, 2);
            txtBx1.Name = "txtBx1";
            txtBx1.Size = new Size(624, 35);
            txtBx1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.AutoSize = true;
            btnEnviar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.Location = new Point(12, 43);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(624, 47);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += button1_Click;
            // 
            // buttonEnviar2
            // 
            buttonEnviar2.AutoSize = true;
            buttonEnviar2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnviar2.Location = new Point(12, 148);
            buttonEnviar2.Name = "buttonEnviar2";
            buttonEnviar2.Size = new Size(624, 50);
            buttonEnviar2.TabIndex = 3;
            buttonEnviar2.Text = "ENVIAR";
            buttonEnviar2.UseVisualStyleBackColor = true;
            buttonEnviar2.Click += buttonEnviar2_Click;
            // 
            // txtBx2
            // 
            txtBx2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx2.Location = new Point(12, 107);
            txtBx2.Name = "txtBx2";
            txtBx2.Size = new Size(624, 35);
            txtBx2.TabIndex = 2;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 254);
            button2.Name = "button2";
            button2.Size = new Size(624, 50);
            button2.TabIndex = 5;
            button2.Text = "ENVIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtBx3
            // 
            txtBx3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx3.Location = new Point(12, 213);
            txtBx3.Name = "txtBx3";
            txtBx3.Size = new Size(624, 35);
            txtBx3.TabIndex = 4;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 362);
            button3.Name = "button3";
            button3.Size = new Size(624, 50);
            button3.TabIndex = 7;
            button3.Text = "ENVIAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtBx4
            // 
            txtBx4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx4.Location = new Point(12, 321);
            txtBx4.Name = "txtBx4";
            txtBx4.Size = new Size(624, 35);
            txtBx4.TabIndex = 6;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 469);
            button4.Name = "button4";
            button4.Size = new Size(624, 50);
            button4.TabIndex = 9;
            button4.Text = "ENVIAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtBx5
            // 
            txtBx5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx5.Location = new Point(12, 428);
            txtBx5.Name = "txtBx5";
            txtBx5.Size = new Size(624, 35);
            txtBx5.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(646, 522);
            Controls.Add(button4);
            Controls.Add(txtBx5);
            Controls.Add(button3);
            Controls.Add(txtBx4);
            Controls.Add(button2);
            Controls.Add(txtBx3);
            Controls.Add(buttonEnviar2);
            Controls.Add(txtBx2);
            Controls.Add(btnEnviar);
            Controls.Add(txtBx1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelNetApp";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBx1;
        private Button btnEnviar;
        private Button buttonEnviar2;
        private TextBox txtBx2;
        private Button button2;
        private TextBox txtBx3;
        private Button button3;
        private TextBox txtBx4;
        private Button button4;
        private TextBox txtBx5;
    }
}