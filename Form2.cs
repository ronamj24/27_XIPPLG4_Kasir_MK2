using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int subtotalMakanan = string.IsNullOrEmpty(txtsubtotalmakanan.Text) ? 0 : int.Parse(txtsubtotalmakanan.Text);
            int subtotalMinuman = string.IsNullOrEmpty(txtsubtotalminuman.Text) ? 0 : int.Parse(txtsubtotalminuman.Text);
            int total = string.IsNullOrEmpty(txttotal.Text) ? 0 : int.Parse(txttotal.Text);
            int bayar = string.IsNullOrEmpty(txtbayar.Text) ? 0 : int.Parse(txtbayar.Text);
            int kembali = bayar - total;

            if (bayar < total)
            {
                MessageBox.Show("Uang tidak cukup untuk membayar total belanja!",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fmtSubtotalMakanan = subtotalMakanan.ToString("N0");
            string fmtSubtotalMinuman = subtotalMinuman.ToString("N0");
            string fmtTotal = total.ToString("N0");
            string fmtBayar = bayar.ToString("N0");
            string fmtKembali = kembali.ToString("N0");

            
            MessageBox.Show(
               "===== STRUK PEMBELIAN =====\n" +
               "Kasir     : " + txtnama.Text + "\n" +
               "Makanan   : " + cmbmakanan.Text + " x " + nudjumlahmakanan.Value + " = Rp " + fmtSubtotalMakanan + "\n" +
               "Minuman   : " + cmbminuman.Text + " x " + nudjumlahminuman.Value + " = Rp " + fmtSubtotalMinuman + "\n" +
               "---------------------------\n" +
               "TOTAL     : Rp " + fmtTotal + "\n" +
               "BAYAR     : Rp " + fmtBayar + "\n" +
               "KEMBALI   : Rp " + fmtKembali + "\n" +
               "===========================",
               "Struk Kasir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnprosess_MouseEnter(object sender, EventArgs e)
        {
            btnprosess.BackColor = System.Drawing.Color.DarkGreen;
        }

        private void btnprosess_MouseLeave(object sender, EventArgs e)
        {
            btnprosess.BackColor = System.Drawing.Color.ForestGreen;
        }
        private void btnclear_MouseEnter(object sender, EventArgs e)
        {
            btnclear.BackColor = System.Drawing.Color.IndianRed;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnclear.BackColor = System.Drawing.Color.Tomato;
        }
        private void FormKasir_Load(object sender, EventArgs e)
        {
            // Isi daftar makanan
            cmbmakanan.Items.Add("Nasi Goreng Spesial");
            cmbmakanan.Items.Add("Ayam Geprek");
            cmbmakanan.Items.Add("Mie Ayam Bakso");
            cmbmakanan.Items.Add("Sate Ayam Madura");
            cmbmakanan.Items.Add("Burger Beef Cheese");
            cmbmakanan.Items.Add("Pizza Mini");

            // Isi daftar minuman
            cmbminuman.Items.Add("Es Teh Manis");
            cmbminuman.Items.Add("Kopi Cappuccino");
            cmbminuman.Items.Add("Matcha Latte");
            cmbminuman.Items.Add("Thai Tea");
            cmbminuman.Items.Add("Jus Alpukat");
            cmbminuman.Items.Add("Milkshake Cokelat");

            cmbmakanan.SelectedIndex = 0; 
            cmbminuman.SelectedIndex = 0;
        }

        private void cmbmakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbmakanan.Text.Trim())
            {
                case "Nasi Goreng Spesial": txthargamakanan.Text = "20000"; break;
                case "Ayam Geprek": txthargamakanan.Text = "18000"; break;
                case "Mie Ayam Bakso": txthargamakanan.Text = "17000"; break;
                case "Sate Ayam Madura": txthargamakanan.Text = "25000"; break;
                case "Burger Beef Cheese": txthargamakanan.Text = "22000"; break;
                case "Pizza Mini": txthargamakanan.Text = "30000"; break;
                default: txthargamakanan.Text = "0"; break;
            }
            HitungSubtotal();

        }
        private void HitungSubtotal()
        {
            int hargaMakanan = string.IsNullOrEmpty(txthargamakanan.Text) ? 0 : int.Parse(txthargamakanan.Text);
            int hargaMinuman = string.IsNullOrEmpty(txthargaminuman.Text) ? 0 : int.Parse(txthargaminuman.Text);

            int jumlahMakanan = (int)nudjumlahmakanan.Value;
            int jumlahMinuman = (int)nudjumlahminuman.Value;

            int subtotalMakanan = hargaMakanan * jumlahMakanan;
            int subtotalMinuman = hargaMinuman * jumlahMinuman;

            txtsubtotalmakanan.Text = subtotalMakanan.ToString();
            txtsubtotalminuman.Text = subtotalMinuman.ToString();

            txttotal.Text = (subtotalMakanan + subtotalMinuman).ToString();
        }

        private void cmbminuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbminuman.Text.Trim())
            {
                case "Es Teh Manis": txthargaminuman.Text = "5000"; break;
                case "Kopi Cappuccino": txthargaminuman.Text = "15000"; break;
                case "Matcha Latte": txthargaminuman.Text = "18000"; break;
                case "Thai Tea": txthargaminuman.Text = "12000"; break;
                case "Jus Alpukat": txthargaminuman.Text = "14000"; break;
                case "Milkshake Cokelat": txthargaminuman.Text = "16000"; break;
                default: txthargaminuman.Text = "0"; break;
            }
            HitungSubtotal();
        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {
            int total = string.IsNullOrEmpty(txttotal.Text) ? 0 : int.Parse(txttotal.Text);
            int bayar = string.IsNullOrEmpty(txtbayar.Text) ? 0 : int.Parse(txtbayar.Text);

            txtkembali.Text = (bayar - total).ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnama.Clear();
            cmbmakanan.SelectedIndex = -1;
            cmbminuman.SelectedIndex = -1;
            txthargamakanan.Clear();
            txthargaminuman.Clear();
            nudjumlahmakanan.Value = 0;
            nudjumlahminuman.Value = 0;
            txtsubtotalmakanan.Clear();
            txtsubtotalminuman.Clear();
            txttotal.Clear();
            txtbayar.Clear();
            txtkembali.Clear();
        }

        private void nudjumlahmakanan_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void nudjumlahminuman_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txthargaminuman.Text) || txthargaminuman.Text == "0")
            {
                switch (cmbminuman.Text.Trim())
                {
                    case "Es Teh Manis": txthargaminuman.Text = "5000"; break;
                    case "Kopi Cappuccino": txthargaminuman.Text = "15000"; break;
                    case "Matcha Latte": txthargaminuman.Text = "18000"; break;
                    case "Thai Tea": txthargaminuman.Text = "12000"; break;
                    case "Jus Alpukat": txthargaminuman.Text = "14000"; break;
                    case "Milkshake Cokelat": txthargaminuman.Text = "16000"; break;
                    default: txthargaminuman.Text = "0"; break;
                }
            }

            HitungSubtotal();
        }

        private void nudjumlahmakanan_ValueChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txthargamakanan.Text) || txthargamakanan.Text == "0")
            {
                
                switch (cmbmakanan.Text.Trim())
                {
                    case "Nasi Goreng Spesial": txthargamakanan.Text = "20000"; break;
                    case "Ayam Geprek": txthargamakanan.Text = "18000"; break;
                    case "Mie Ayam Bakso": txthargamakanan.Text = "17000"; break;
                    case "Sate Ayam Madura": txthargamakanan.Text = "25000"; break;
                    case "Burger Beef Cheese": txthargamakanan.Text = "22000"; break;
                    case "Pizza Mini": txthargamakanan.Text = "30000"; break;
                    default: txthargamakanan.Text = "0"; break;
                }
            }

            HitungSubtotal();
        }

    }
}
