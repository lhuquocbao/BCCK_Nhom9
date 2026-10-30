namespace BCCK_Nhom9
{
    partial class Form4
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
            lstMonHoc = new ListBox();
            lstDaChon = new ListBox();
            btnTrai = new Button();
            btnTatCa = new Button();
            btnTinhHocPhi = new Button();
            btnGhiFile = new Button();
            txtHocPhi = new TextBox();
            lblTieuDe = new Label();
            lblCuoiTrang = new Label();
            SuspendLayout();
            // 
            // lstMonHoc
            // 
            lstMonHoc.FormattingEnabled = true;
            lstMonHoc.Location = new Point(0, 90);
            lstMonHoc.Name = "lstMonHoc";
            lstMonHoc.Size = new Size(276, 274);
            lstMonHoc.TabIndex = 0;
            lstMonHoc.SelectedIndexChanged += lstMonHoc_SelectedIndexChanged;
            // 
            // lstDaChon
            // 
            lstDaChon.FormattingEnabled = true;
            lstDaChon.Location = new Point(460, 90);
            lstDaChon.Name = "lstDaChon";
            lstDaChon.Size = new Size(276, 274);
            lstDaChon.TabIndex = 1;
            // 
            // btnTrai
            // 
            btnTrai.Location = new Point(300, 182);
            btnTrai.Name = "btnTrai";
            btnTrai.Size = new Size(131, 40);
            btnTrai.TabIndex = 2;
            btnTrai.Text = "<";
            btnTrai.UseVisualStyleBackColor = true;
            btnTrai.Click += btnTrai_Click;
            // 
            // btnTatCa
            // 
            btnTatCa.Location = new Point(300, 280);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(131, 40);
            btnTatCa.TabIndex = 3;
            btnTatCa.Text = ">>";
            btnTatCa.UseVisualStyleBackColor = true;
            btnTatCa.Click += btnTatCa_Click;
            // 
            // btnTinhHocPhi
            // 
            btnTinhHocPhi.Location = new Point(59, 465);
            btnTinhHocPhi.Name = "btnTinhHocPhi";
            btnTinhHocPhi.Size = new Size(131, 40);
            btnTinhHocPhi.TabIndex = 4;
            btnTinhHocPhi.Text = "TinhHocPhi";
            btnTinhHocPhi.UseVisualStyleBackColor = true;
            btnTinhHocPhi.Click += btnTinhHocPhi_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Location = new Point(536, 470);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(131, 40);
            btnGhiFile.TabIndex = 5;
            btnGhiFile.Text = "Ghi File";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // txtHocPhi
            // 
            txtHocPhi.Location = new Point(234, 470);
            txtHocPhi.Name = "txtHocPhi";
            txtHocPhi.Size = new Size(274, 35);
            txtHocPhi.TabIndex = 6;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(278, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(200, 30);
            lblTieuDe.TabIndex = 7;
            lblTieuDe.Text = "TINH TIEN HOC PHI";
            lblTieuDe.Click += label1_Click;
            // 
            // lblCuoiTrang
            // 
            lblCuoiTrang.AutoSize = true;
            lblCuoiTrang.Location = new Point(293, 578);
            lblCuoiTrang.Name = "lblCuoiTrang";
            lblCuoiTrang.Size = new Size(138, 30);
            lblCuoiTrang.TabIndex = 8;
            lblCuoiTrang.Text = "Bai Tap Cau 3";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(738, 639);
            Controls.Add(lblCuoiTrang);
            Controls.Add(lblTieuDe);
            Controls.Add(txtHocPhi);
            Controls.Add(btnGhiFile);
            Controls.Add(btnTinhHocPhi);
            Controls.Add(btnTatCa);
            Controls.Add(btnTrai);
            Controls.Add(lstDaChon);
            Controls.Add(lstMonHoc);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cau3_2";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMonHoc;
        private ListBox lstDaChon;
        private Button btnTrai;
        private Button btnTatCa;
        private Button btnTinhHocPhi;
        private Button btnGhiFile;
        private TextBox txtHocPhi;
        private Label lblTieuDe;
        private Label lblCuoiTrang;
    }
}