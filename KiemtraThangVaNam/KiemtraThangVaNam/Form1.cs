using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemtraThangVaNam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtNam.Text, out int Nam)==false || Nam < 0)
            {
                MessageBox.Show("Nhập năm sai, mời nhập lại");
                txtNam.Clear();
                txtNam.Focus();
                return;
            }
            if (int.TryParse(txtThang.Text, out int Thang) == false || Thang < 1 || Thang >12)
            {
                MessageBox.Show("Nhập năm sai, mời nhập lại");
                txtThang.Clear();
                txtThang.Focus();
                return;
            }
            bool NamNhuan = false;
            if ((Nam % 400 == 0) || (Nam % 4 == 0 && Nam % 100 != 0))
            {
                NamNhuan = true;
            }
            int SoNgay = 0;
            switch(Thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    SoNgay=31;
                    break;
                case 2:
                    SoNgay = NamNhuan ? 29 : 28;
                    break;
                default:
                    SoNgay = 30;
                    break;
            }
            cbNamNhuan.Checked = NamNhuan;
            txtKQ.Text = $"Tháng {Thang} năm {Nam} có {SoNgay} ngày";

        }
    }
}
