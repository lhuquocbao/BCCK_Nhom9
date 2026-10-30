    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
using System.IO;
namespace BCCK_Nhom9
    {
    public partial class Form4 : Form
    {

        private int LaySoDonVi(string tenMon)
        {
            switch (tenMon)
            {
                case "Tin học đại cương":
                    return 5;

                case "Anh văn chuyên ngành":
                    return 3;

                case "Toán A1":
                    return 4;

                case "Lập trình web":
                    return 6;

                case "Vật lý đại cương":
                    return 2;

                default:
                    return 0;
            }
        }

        public Form4()
        {
            InitializeComponent();




            // Danh sách môn học bên trái
            lstMonHoc.Items.Add("Toán A1");
            lstMonHoc.Items.Add("Lập trình web");
            lstMonHoc.Items.Add("Vật lý đại cương");

            // Danh sách môn học bên phải
            lstDaChon.Items.Add("Tin học đại cương");
            lstDaChon.Items.Add("Anh văn chuyên ngành");

            // Hiển thị học phí ban đầu
            txtHocPhi.Text = "800000";
            txtHocPhi.ReadOnly = true;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn môn học chưa
            if (lstDaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học cần chuyển!");
                return;
            }

            // Lấy môn học đang được chọn
            string monHoc = lstDaChon.SelectedItem.ToString();

            // Thêm môn học sang bên trái
            lstMonHoc.Items.Add(monHoc);

            // Xóa môn học khỏi bên phải
            lstDaChon.Items.Remove(monHoc);
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            // Duyệt tất cả môn học bên trái
            foreach (string monHoc in lstMonHoc.Items)
            {
                // Thêm vào danh sách bên phải
                lstDaChon.Items.Add(monHoc);
            }

            // Xóa toàn bộ danh sách bên trái
            lstMonHoc.Items.Clear();
        }


        private int TinhTongHocPhi()
        {
            int tongDonVi = 0;

            foreach (string monHoc in lstDaChon.Items)
            {
                tongDonVi += LaySoDonVi(monHoc);
            }

            return tongDonVi * 100000;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            if (lstDaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học cần chuyển!");
                return;
            }

            object monHoc = lstDaChon.SelectedItem;

            lstMonHoc.Items.Add(monHoc);

            lstDaChon.Items.Remove(monHoc);
        }

        private void btnTinhHocPhi_Click(object sender, EventArgs e)
        {
            int tongTien = TinhTongHocPhi();

            txtHocPhi.Text = tongTien.ToString();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại lưu file
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu danh sách học phí";
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.FileName = "HocPhi.txt";

                // Kiểm tra người dùng có nhấn Save không
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Mở file để ghi dữ liệu
                        using (StreamWriter sw = new StreamWriter(
                            sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("DANH SÁCH MÔN HỌC ĐÃ CHỌN");
                            sw.WriteLine("-------------------------");

                            // Ghi từng môn học bên phải
                            foreach (string monHoc in lstDaChon.Items)
                            {
                                sw.WriteLine(monHoc);
                            }

                            sw.WriteLine("-------------------------");

                            // Ghi tổng học phí
                            int tongTien = TinhTongHocPhi();

                            sw.WriteLine("Tổng học phí: "
                                + tongTien + " đồng");
                        }

                        MessageBox.Show(
                            "Ghi file thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Lỗi ghi file: " + ex.Message);
                    }
                }
            }
        }
    }
}
