using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
	public partial class calculate : Form
	{
		public calculate()
		{
			InitializeComponent();
            txtResult.Enabled = false;
		}

        private bool checkRong()
        {
            if (txtNumber1.Text == "")
            {
                txtNumber1.Focus();
                MessageBox.Show("Vui Lòng Nhập Number1", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNumber2.Text == "")
            {
                txtNumber2.Focus();
                MessageBox.Show("Vui Lòng Nhập Number2", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool checkPare()
        {
            float num1, num2;
            bool result1 = float.TryParse(txtNumber1.Text, out num1);
            if (!result1)
            {
                MessageBox.Show("Bạn đã nhập Number1 sai kiểu dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            bool result2 = float.TryParse(txtNumber2.Text, out num2);
            if (!result2)
            {
                MessageBox.Show("Bạn đã nhập Number2 sai kiểu dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void calculate_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (checkRong() && checkPare())
            {
                float num1 = float.Parse(txtNumber1.Text);
                float num2 = float.Parse(txtNumber2.Text);
                txtResult.Text = (num1 + num2).ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (checkRong() && checkPare())
            {
                float num1 = float.Parse(txtNumber1.Text);
                float num2 = float.Parse(txtNumber2.Text);
                txtResult.Text = (num1 - num2).ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (checkRong() && checkPare())
            {
                float num1 = float.Parse(txtNumber1.Text);
                float num2 = float.Parse(txtNumber2.Text);
                txtResult.Text = (num1 * num2).ToString();
            }

        }

        private void btnChia_Click(object sender, EventArgs e)
        {

        }
    }
}
