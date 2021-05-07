using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                //float Toan = float.Parse(txtToan.Text);
                if (float.TryParse(txtToan.Text, out float Toan) == false || Toan<0 || Toan >10)
                {
                    MessageBox.Show("Điểm toán không hợp lệ");
                    txtToan.Clear();
                    txtToan.Focus();
                    return;
                }
                //float Ly = float.Parse(txtLy.Text
                if (float.TryParse(txtLy.Text, out float Ly) == false || Ly < 0 || Ly > 10)
                {
                    MessageBox.Show("Điểm lý không hợp lệ");
                    txtLy.Clear();
                    txtLy.Focus();
                    return;
                }
                //float Hoa = float.Parse(txtHoa.Text);
                if (float.TryParse(txtHoa.Text, out float Hoa) == false || Hoa < 0 || Hoa > 10)
                {
                    MessageBox.Show("Điểm hóa không hợp lệ");
                    txtHoa.Clear();
                    txtHoa.Focus();
                    return;
                }
                float Dtb = (Toan + Ly + Hoa) / 3;
                txtDtb.Text = Dtb.ToString();
                if(Dtb < 5)
                {
                    txtXepLoai.Text="Yếu";
                } 
                else if(Dtb<7)
                {
                    txtXepLoai.Text = "Trung bình";
                }
                else if (Dtb<8)
                {
                    txtXepLoai.Text = "Khá";
                }
                else if (Dtb<9)
                {
                    txtXepLoai.Text = "Giỏi";
                }
                else
                {
                    txtXepLoai.Text = "Xuất sắc";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Bạn nhập sai" + Ex.Message);
                txtToan.Clear();
                txtLy.Clear();
                txtHoa.Clear();
               
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
