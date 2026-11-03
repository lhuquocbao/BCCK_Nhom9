using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BCCK_Nhom9
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void btnThucHien_Click(object sender, EventArgs e)
		{
			int n = int.Parse(txtNhap.Text);
			string kq = "";

			for (int i = 2; i <= n; i++)
			{
				while (n % i == 0)
				{
					kq += i + "*";
					n = n / i;
				}
			}

			txtKetQua.Text = kq.TrimEnd('*');
		}

		private void txtSo_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnLamLai_Click(object sender, EventArgs e)
		{
			txtNhap.Clear();
			txtKetQua.Clear();
			txtNhap.Focus();
		}
	}
}
