namespace BCCK_Nhom9
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblTieude = new Label();
			lblNhapSo = new Label();
			txtNhap = new TextBox();
			lblKetQua = new Label();
			txtKetQua = new TextBox();
			btnLamLai = new Button();
			btnThucHien = new Button();
			lblFooter = new Label();
			SuspendLayout();
			// 
			// lblTieude
			// 
			lblTieude.AutoSize = true;
			lblTieude.BackColor = Color.Blue;
			lblTieude.Dock = DockStyle.Top;
			lblTieude.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTieude.ForeColor = SystemColors.Control;
			lblTieude.Location = new Point(0, 0);
			lblTieude.Name = "lblTieude";
			lblTieude.Size = new Size(292, 21);
			lblTieude.TabIndex = 0;
			lblTieude.Text = "PHÂN TÍCH RA THỪA SỐ NGUYÊN TỐ";
			lblTieude.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblNhapSo
			// 
			lblNhapSo.AutoSize = true;
			lblNhapSo.Location = new Point(10, 55);
			lblNhapSo.Name = "lblNhapSo";
			lblNhapSo.Size = new Size(102, 15);
			lblNhapSo.TabIndex = 1;
			lblNhapSo.Text = "Nhập Số Cần Tính";
			// 
			// txtNhap
			// 
			txtNhap.Location = new Point(129, 47);
			txtNhap.Name = "txtNhap";
			txtNhap.Size = new Size(100, 23);
			txtNhap.TabIndex = 2;
			txtNhap.TextChanged += txtSo_TextChanged;
			// 
			// lblKetQua
			// 
			lblKetQua.AutoSize = true;
			lblKetQua.Location = new Point(12, 99);
			lblKetQua.Name = "lblKetQua";
			lblKetQua.Size = new Size(47, 15);
			lblKetQua.TabIndex = 3;
			lblKetQua.Text = "Kết quả";
			// 
			// txtKetQua
			// 
			txtKetQua.Location = new Point(129, 99);
			txtKetQua.Name = "txtKetQua";
			txtKetQua.ReadOnly = true;
			txtKetQua.Size = new Size(100, 23);
			txtKetQua.TabIndex = 4;
			// 
			// btnLamLai
			// 
			btnLamLai.Location = new Point(202, 148);
			btnLamLai.Name = "btnLamLai";
			btnLamLai.Size = new Size(75, 23);
			btnLamLai.TabIndex = 5;
			btnLamLai.Text = "Làm Lại";
			btnLamLai.UseVisualStyleBackColor = true;
			btnLamLai.Click += btnLamLai_Click;
			// 
			// btnThucHien
			// 
			btnThucHien.Location = new Point(87, 148);
			btnThucHien.Name = "btnThucHien";
			btnThucHien.Size = new Size(75, 23);
			btnThucHien.TabIndex = 6;
			btnThucHien.Text = "Thực Hiện";
			btnThucHien.UseVisualStyleBackColor = true;
			btnThucHien.Click += btnThucHien_Click;
			// 
			// lblFooter
			// 
			lblFooter.AutoSize = true;
			lblFooter.BackColor = Color.Blue;
			lblFooter.Dock = DockStyle.Bottom;
			lblFooter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblFooter.ForeColor = SystemColors.ButtonHighlight;
			lblFooter.Location = new Point(0, 190);
			lblFooter.Name = "lblFooter";
			lblFooter.Size = new Size(112, 21);
			lblFooter.TabIndex = 7;
			lblFooter.Text = "Bài Tập Câu 2";
			lblFooter.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(414, 211);
			Controls.Add(lblFooter);
			Controls.Add(btnThucHien);
			Controls.Add(btnLamLai);
			Controls.Add(txtKetQua);
			Controls.Add(lblKetQua);
			Controls.Add(txtNhap);
			Controls.Add(lblNhapSo);
			Controls.Add(lblTieude);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form2";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BÀI TẬP CÂU 2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTieude;
		private Label lblNhapSo;
		private TextBox txtNhap;
		private Label lblKetQua;
		private TextBox txtKetQua;
		private Button btnLamLai;
		private Button btnThucHien;
		private Label lblFooter;
	}
}