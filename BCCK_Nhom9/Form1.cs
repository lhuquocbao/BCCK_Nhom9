
using System;
using System.Windows.Forms;

namespace BCCK_Nhom9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hiển thị giờ ngay khi mở Form
            lblDongHo.Text = "Bây giờ là: "
                + DateTime.Now.ToString("HH:mm:ss");

            // Bắt đầu đồng hồ
            tmrDongHo.Start();
        }

        // CẬP NHẬT ĐỒNG HỒ MỖI GIÂY
        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = "Bây giờ là: "
                + DateTime.Now.ToString("HH:mm:ss");
        }

        // NÚT CHỌN
        private void btnChon_Click(object sender, EventArgs e)
        {
            if (rdoCau2.Checked)
            {
                using (Form2 f = new Form2())
                {
                    f.ShowDialog(this);
                }
            }
            else if (rdoCau3.Checked)
            {
                using (Form3 f = new Form3())
                {
                    f.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn Câu 2 hoặc Câu 3!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // NÚT THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
