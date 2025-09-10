namespace Kasir
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtnama = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            nudjumlahmakanan = new NumericUpDown();
            label6 = new Label();
            txthargamakanan = new TextBox();
            label5 = new Label();
            txtsubtotalmakanan = new TextBox();
            label4 = new Label();
            cmbmakanan = new ComboBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            txtsubtotalminuman = new TextBox();
            label10 = new Label();
            nudjumlahminuman = new NumericUpDown();
            label9 = new Label();
            txthargaminuman = new TextBox();
            label8 = new Label();
            cmbminuman = new ComboBox();
            label7 = new Label();
            groupBox5 = new GroupBox();
            txtkembali = new TextBox();
            txtbayar = new TextBox();
            txttotal = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox6 = new GroupBox();
            btnclear = new Button();
            btnprosess = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudjumlahmakanan).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudjumlahminuman).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.DarkRed;
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 65);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 23);
            label1.Name = "label1";
            label1.Size = new Size(238, 30);
            label1.TabIndex = 0;
            label1.Text = "Form Kasir Sederhana";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtnama);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = Color.DarkBlue;
            groupBox2.Location = new Point(12, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 76);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtnama
            // 
            txtnama.Location = new Point(76, 27);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(250, 31);
            txtnama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(8, 27);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 0;
            label2.Text = "Nama";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudjumlahmakanan);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txthargamakanan);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtsubtotalmakanan);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cmbmakanan);
            groupBox3.Controls.Add(label3);
            groupBox3.ForeColor = Color.DarkGreen;
            groupBox3.Location = new Point(12, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 96);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // nudjumlahmakanan
            // 
            nudjumlahmakanan.Location = new Point(624, 20);
            nudjumlahmakanan.Name = "nudjumlahmakanan";
            nudjumlahmakanan.Size = new Size(146, 31);
            nudjumlahmakanan.TabIndex = 7;
            nudjumlahmakanan.ValueChanged += nudjumlahmakanan_ValueChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(545, 18);
            label6.Name = "label6";
            label6.Size = new Size(73, 28);
            label6.TabIndex = 6;
            label6.Text = "Jumlah";
            // 
            // txthargamakanan
            // 
            txthargamakanan.Location = new Point(373, 20);
            txthargamakanan.Name = "txthargamakanan";
            txthargamakanan.Size = new Size(152, 31);
            txthargamakanan.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(302, 19);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 4;
            label5.Text = "Harga";
            // 
            // txtsubtotalmakanan
            // 
            txtsubtotalmakanan.Location = new Point(104, 57);
            txtsubtotalmakanan.Name = "txtsubtotalmakanan";
            txtsubtotalmakanan.Size = new Size(182, 31);
            txtsubtotalmakanan.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(6, 56);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 2;
            label4.Text = "Subtotal";
            // 
            // cmbmakanan
            // 
            cmbmakanan.FormattingEnabled = true;
            cmbmakanan.Items.AddRange(new object[] { "Nasi Goreng Spesial", "Ayam Geprek", "Mie Ayam Bakso", "Sate Ayam Madura", "Burger Beef Cheese", "Pizza Mini" });
            cmbmakanan.Location = new Point(104, 18);
            cmbmakanan.Name = "cmbmakanan";
            cmbmakanan.Size = new Size(182, 33);
            cmbmakanan.TabIndex = 1;
            cmbmakanan.SelectedIndexChanged += cmbmakanan_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 0;
            label3.Text = "Makanan";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtsubtotalminuman);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(nudjumlahminuman);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txthargaminuman);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(cmbminuman);
            groupBox4.Controls.Add(label7);
            groupBox4.ForeColor = Color.DarkRed;
            groupBox4.Location = new Point(12, 258);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(776, 93);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // txtsubtotalminuman
            // 
            txtsubtotalminuman.Location = new Point(104, 56);
            txtsubtotalminuman.Name = "txtsubtotalminuman";
            txtsubtotalminuman.Size = new Size(182, 31);
            txtsubtotalminuman.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(4, 54);
            label10.Name = "label10";
            label10.Size = new Size(87, 28);
            label10.TabIndex = 13;
            label10.Text = "Subtotal";
            // 
            // nudjumlahminuman
            // 
            nudjumlahminuman.Location = new Point(624, 19);
            nudjumlahminuman.Name = "nudjumlahminuman";
            nudjumlahminuman.Size = new Size(146, 31);
            nudjumlahminuman.TabIndex = 12;
            nudjumlahminuman.ValueChanged += nudjumlahminuman_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(545, 16);
            label9.Name = "label9";
            label9.Size = new Size(73, 28);
            label9.TabIndex = 11;
            label9.Text = "Jumlah";
            // 
            // txthargaminuman
            // 
            txthargaminuman.Location = new Point(373, 18);
            txthargaminuman.Name = "txthargaminuman";
            txthargaminuman.Size = new Size(152, 31);
            txthargaminuman.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(302, 16);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 9;
            label8.Text = "Harga";
            // 
            // cmbminuman
            // 
            cmbminuman.FormattingEnabled = true;
            cmbminuman.Items.AddRange(new object[] { "Es Teh Manis", "Kopi Cappuccino", "Matcha Latte ", "Thai Tea ", "Jus Alpukat ", "Milkshake Cokelat" });
            cmbminuman.Location = new Point(104, 16);
            cmbminuman.Name = "cmbminuman";
            cmbminuman.Size = new Size(182, 33);
            cmbminuman.TabIndex = 8;
            cmbminuman.SelectedIndexChanged += cmbminuman_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(4, 16);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 1;
            label7.Text = "Minuman";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtkembali);
            groupBox5.Controls.Add(txtbayar);
            groupBox5.Controls.Add(txttotal);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.ForeColor = Color.DarkSlateGray;
            groupBox5.Location = new Point(12, 351);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(380, 112);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Enter += groupBox5_Enter;
            // 
            // txtkembali
            // 
            txtkembali.Location = new Point(104, 81);
            txtkembali.Name = "txtkembali";
            txtkembali.Size = new Size(182, 31);
            txtkembali.TabIndex = 21;
            // 
            // txtbayar
            // 
            txtbayar.Location = new Point(104, 48);
            txtbayar.Name = "txtbayar";
            txtbayar.Size = new Size(182, 31);
            txtbayar.TabIndex = 20;
            txtbayar.TextChanged += txtbayar_TextChanged;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(104, 14);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(182, 31);
            txttotal.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(5, 73);
            label13.Name = "label13";
            label13.Size = new Size(83, 28);
            label13.TabIndex = 18;
            label13.Text = "Kembali";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(5, 45);
            label12.Name = "label12";
            label12.Size = new Size(60, 28);
            label12.TabIndex = 16;
            label12.Text = "Bayar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(5, 17);
            label11.Name = "label11";
            label11.Size = new Size(54, 28);
            label11.TabIndex = 2;
            label11.Text = "Total";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnclear);
            groupBox6.Controls.Add(btnprosess);
            groupBox6.ForeColor = Color.DarkSlateGray;
            groupBox6.Location = new Point(398, 351);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(392, 112);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Tomato;
            btnclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.ForeColor = Color.White;
            btnclear.Location = new Point(219, 37);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(131, 47);
            btnclear.TabIndex = 1;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnprosess
            // 
            btnprosess.BackColor = Color.ForestGreen;
            btnprosess.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprosess.ForeColor = Color.White;
            btnprosess.Location = new Point(53, 37);
            btnprosess.Name = "btnprosess";
            btnprosess.Size = new Size(131, 47);
            btnprosess.TabIndex = 0;
            btnprosess.Text = "PROSESS";
            btnprosess.UseVisualStyleBackColor = false;
            btnprosess.Click += button1_Click;
            btnprosess.MouseEnter += btnprosess_MouseEnter;
            btnprosess.MouseLeave += btnprosess_MouseLeave;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudjumlahmakanan).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudjumlahminuman).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label1;
        private TextBox txtnama;
        private Label label2;
        private Label label3;
        private TextBox txthargamakanan;
        private Label label5;
        private TextBox txtsubtotalmakanan;
        private Label label4;
        private ComboBox cmbmakanan;
        private NumericUpDown nudjumlahmakanan;
        private Label label6;
        private TextBox txthargaminuman;
        private Label label8;
        private ComboBox cmbminuman;
        private Label label7;
        private TextBox txtsubtotalminuman;
        private Label label10;
        private NumericUpDown nudjumlahminuman;
        private Label label9;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtkembali;
        private TextBox txtbayar;
        private TextBox txttotal;
        private Button btnprosess;
        private Button btnclear;
    }
}