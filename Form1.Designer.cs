namespace Kasir
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
            panel1 = new Panel();
            btnlogin = new Button();
            txtpw = new TextBox();
            label3 = new Label();
            txtusn = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(txtpw);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtusn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 386);
            panel1.TabIndex = 0;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.DodgerBlue;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(268, 267);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(163, 46);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += button1_Click;
            btnlogin.MouseEnter += btnlogin_MouseEnter;
            btnlogin.MouseLeave += btnlogin_MouseLeave;
            // 
            // txtpw
            // 
            txtpw.BackColor = Color.White;
            txtpw.Location = new Point(172, 190);
            txtpw.Name = "txtpw";
            txtpw.Size = new Size(259, 31);
            txtpw.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(38, 187);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtusn
            // 
            txtusn.BackColor = Color.White;
            txtusn.Location = new Point(172, 122);
            txtusn.Name = "txtusn";
            txtusn.Size = new Size(259, 31);
            txtusn.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(38, 121);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(268, 44);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "LOGIN FORM";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtpw;
        private Label label3;
        private TextBox txtusn;
        private Label label2;
        private Button btnlogin;
    }
}
