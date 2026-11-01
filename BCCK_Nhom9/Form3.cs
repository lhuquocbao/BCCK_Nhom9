
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BCCK_Nhom9
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();

            
            lstMonHoc.Items.Clear();
            lstDaChon.Items.Clear();

            
            lstMonHoc.Items.Add("Toán A1");
            lstMonHoc.Items.Add("Lập trình web");
            lstMonHoc.Items.Add("Vật lý đại cương");

            
            lstDaChon.Items.Add("Tin học đại cương");
            lstDaChon.Items.Add("Anh văn chuyên ngành");

            
            txtHocPhi.Text = "800000";
            txtHocPhi.ReadOnly = true;
        }

        
        private void btnTrai_Click(object sender, EventArgs e)
        {
            object? monHoc = lstDaChon.SelectedItem;

            if (monHoc == null)
            {
                MessageBox.Show("Vui lòng chọn môn học!");
                return;
            }

            lstMonHoc.Items.Add(monHoc);
            lstDaChon.Items.Remove(monHoc);
        }

       
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            foreach (object monHoc in lstMonHoc.Items)
            {
                lstDaChon.Items.Add(monHoc);
            }

            lstMonHoc.Items.Clear();
        }
        private int TinhTongHocPhi()
        {
            int tongDonVi = 0;

            foreach (object monHoc in lstDaChon.Items)
            {
                switch (monHoc.ToString())
                {
                    case "Tin học đại cương":
                        tongDonVi += 5;
                        break;

                    case "Anh văn chuyên ngành":
                        tongDonVi += 3;
                        break;

                    case "Toán A1":
                        tongDonVi += 4;
                        break;

                    case "Lập trình web":
                        tongDonVi += 6;
                        break;

                    case "Vật lý đại cương":
                        tongDonVi += 2;
                        break;
                }
            }

            return tongDonVi * 100000;
        }

      
        private void btnTinhHocPhi_Click(object sender, EventArgs e)
        {
            int tongTien = TinhTongHocPhi();

            txtHocPhi.Text = tongTien.ToString();
        }

       
        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu danh sách học phí";
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.FileName = "HocPhi.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(
                            sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("DANH SÁCH MÔN HỌC ĐÃ CHỌN");
                            sw.WriteLine("-------------------------");

                            foreach (object monHoc in lstDaChon.Items)
                            {
                                sw.WriteLine(monHoc);
                            }

                            sw.WriteLine("-------------------------");

                            sw.WriteLine("Tổng học phí: "
                                + TinhTongHocPhi() + " đồng");
                        }

                        MessageBox.Show("Ghi file thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi file: " + ex.Message);
                    }
                }
            }
        }
    }
}
