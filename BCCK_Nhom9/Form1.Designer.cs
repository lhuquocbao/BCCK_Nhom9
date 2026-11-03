
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BCCK_Nhom9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTieuDe = new Label();
            lblDongHo = new Label();

            grpSinhVien = new GroupBox();
            lblMssv = new Label();
            lblHoTen = new Label();
            lblLop = new Label();
            lblSoMay = new Label();
            lblMaDe = new Label();

            grpChucNang = new GroupBox();
            rdoCau2 = new RadioButton();
            rdoCau3 = new RadioButton();
            btnChon = new Button();
            btnThoat = new Button();

            lblChanTrang = new Label();
            tmrDongHo = new System.Windows.Forms.Timer(components);

            grpSinhVien.SuspendLayout();
            grpChucNang.SuspendLayout();
            SuspendLayout();

            // =========================
            // TIÊU ĐỀ
            // =========================
            lblTieuDe.AutoSize = false;
            lblTieuDe.BackColor = Color.FromArgb(155, 177, 204);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Font = new Font(
                "Courier New", 18F, FontStyle.Bold);
            lblTieuDe.Location = new Point(24, 16);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(944, 90);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text =
                "TRƯỜNG ĐẠI HỌC LẠC HỒNG\r\n" +
                "KHOA CÔNG NGHỆ THÔNG TIN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.BorderStyle = BorderStyle.FixedSingle;

            // =========================
            // ĐỒNG HỒ
            // =========================
            lblDongHo.AutoSize = false;
            lblDongHo.BackColor = Color.Plum;
            lblDongHo.ForeColor = Color.Black;
            lblDongHo.Font = new Font(
                "Courier New", 14F, FontStyle.Bold);
            lblDongHo.Location = new Point(24, 110);
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Size = new Size(944, 40);
            lblDongHo.TabIndex = 1;
            lblDongHo.Text = "Bây giờ là: 00:00:00";
            lblDongHo.TextAlign = ContentAlignment.MiddleCenter;

            // =========================
            // GROUPBOX THÔNG TIN SINH VIÊN
            // =========================
            grpSinhVien.BackColor = Color.LightYellow;
            grpSinhVien.Font = new Font(
                "Courier New", 12F, FontStyle.Bold);
            grpSinhVien.Location = new Point(24, 160);
            grpSinhVien.Name = "grpSinhVien";
            grpSinhVien.Size = new Size(578, 275);
            grpSinhVien.TabIndex = 2;
            grpSinhVien.TabStop = false;
            grpSinhVien.Text = "Thông tin sinh viên";

            // MSSV
            lblMssv.AutoSize = true;
            lblMssv.Location = new Point(25, 42);
            lblMssv.Name = "lblMssv";
            lblMssv.Text = "MSSV: 12400000";

            // Họ và tên
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(25, 85);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ và tên: Huynh Tien Dat";

            // Lớp
            lblLop.AutoSize = true;
            lblLop.Location = new Point(25, 128);
            lblLop.Name = "lblLop";
            lblLop.Text = "Lớp: 24CT112";

            // Số máy
            lblSoMay.AutoSize = true;
            lblSoMay.Location = new Point(25, 171);
            lblSoMay.Name = "lblSoMay";
            lblSoMay.Text = "Số máy: 01";

            // Mã đề
            lblMaDe.AutoSize = true;
            lblMaDe.Location = new Point(25, 214);
            lblMaDe.Name = "lblMaDe";
            lblMaDe.Text = "Mã đề: 1-4";

            grpSinhVien.Controls.Add(lblMssv);
            grpSinhVien.Controls.Add(lblHoTen);
            grpSinhVien.Controls.Add(lblLop);
            grpSinhVien.Controls.Add(lblSoMay);
            grpSinhVien.Controls.Add(lblMaDe);

            // =========================
            // GROUPBOX CHỨC NĂNG
            // =========================
            grpChucNang.BackColor = Color.LightYellow;
            grpChucNang.Font = new Font(
                "Courier New", 12F, FontStyle.Bold);
            grpChucNang.Location = new Point(608, 160);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(360, 275);
            grpChucNang.TabIndex = 3;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng chương trình";

            // RADIO CÂU 2
            rdoCau2.AutoSize = true;
            rdoCau2.Location = new Point(28, 70);
            rdoCau2.Name = "rdoCau2";
            rdoCau2.TabIndex = 0;
            rdoCau2.Text = "Câu 2:";
            rdoCau2.UseVisualStyleBackColor = true;

            // RADIO CÂU 3
            rdoCau3.AutoSize = true;
            rdoCau3.Location = new Point(28, 135);
            rdoCau3.Name = "rdoCau3";
            rdoCau3.TabIndex = 1;
            rdoCau3.Text = "Câu 3:";
            rdoCau3.UseVisualStyleBackColor = true;

            // NÚT CHỌN
            btnChon.Location = new Point(205, 65);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(125, 40);
            btnChon.TabIndex = 2;
            btnChon.Text = "Chọn";
            btnChon.ForeColor = Color.Red;
            btnChon.Font = new Font(
                "Courier New", 11F, FontStyle.Bold);
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;

            // NÚT THOÁT
            btnThoat.Location = new Point(205, 130);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 40);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.ForeColor = Color.Red;
            btnThoat.Font = new Font(
                "Courier New", 11F, FontStyle.Bold);
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;

            grpChucNang.Controls.Add(rdoCau2);
            grpChucNang.Controls.Add(rdoCau3);
            grpChucNang.Controls.Add(btnChon);
            grpChucNang.Controls.Add(btnThoat);

            // =========================
            // CHÂN TRANG
            // =========================
            lblChanTrang.AutoSize = false;
            lblChanTrang.BackColor = Color.Plum;
            lblChanTrang.Font = new Font(
                "Courier New", 12F, FontStyle.Bold);
            lblChanTrang.Location = new Point(24, 445);
            lblChanTrang.Name = "lblChanTrang";
            lblChanTrang.Size = new Size(944, 42);
            lblChanTrang.TabIndex = 4;
            lblChanTrang.Text =
                "Đề thi Lập trình giao tiếp với C# " +
                "năm học 20.. - 20..";
            lblChanTrang.TextAlign =
                ContentAlignment.MiddleCenter;

            // =========================
            // TIMER ĐỒNG HỒ
            // =========================
            tmrDongHo.Interval = 1000;
            tmrDongHo.Tick += tmrDongHo_Tick;

            // =========================
            // FORM1
            // =========================
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1003, 509);

            Controls.Add(lblTieuDe);
            Controls.Add(lblDongHo);
            Controls.Add(grpSinhVien);
            Controls.Add(grpChucNang);
            Controls.Add(lblChanTrang);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            Name = "Form1";
            Text = "Bài thi câu 1";

            grpSinhVien.ResumeLayout(false);
            grpSinhVien.PerformLayout();
            grpChucNang.ResumeLayout(false);
            grpChucNang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // KHAI BÁO CÁC ĐIỀU KHIỂN
        private Label lblTieuDe;
        private Label lblDongHo;

        private GroupBox grpSinhVien;
        private Label lblMssv;
        private Label lblHoTen;
        private Label lblLop;
        private Label lblSoMay;
        private Label lblMaDe;

        private GroupBox grpChucNang;
        private RadioButton rdoCau2;
        private RadioButton rdoCau3;
        private Button btnChon;
        private Button btnThoat;

        private Label lblChanTrang;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}
