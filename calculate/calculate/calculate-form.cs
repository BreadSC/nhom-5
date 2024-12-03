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

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (checkRong() && checkPare())
            {
                float num1 = float.Parse(txtNumber1.Text);
                float num2 = float.Parse(txtNumber2.Text);
                txtResult.Text = (num1 * num2).ToString();
            }

        }
    }
}
