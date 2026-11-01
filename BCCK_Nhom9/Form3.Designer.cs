namespace BCCK_Nhom9
{
    partial class Form3
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
            btnTrai = new Button();
            btnTatCa = new Button();
            btnTinhHocPhi = new Button();
            btnGhiFile = new Button();
            label1 = new Label();
            lstMonHoc = new ListBox();
            lstDaChon = new ListBox();
            txtHocPhi = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnTrai
            // 
            btnTrai.Location = new Point(322, 213);
            btnTrai.Name = "btnTrai";
            btnTrai.Size = new Size(131, 40);
            btnTrai.TabIndex = 0;
            btnTrai.Text = "<";
            btnTrai.UseVisualStyleBackColor = true;
            btnTrai.Click += btnTrai_Click;
            // 
            // btnTatCa
            // 
            btnTatCa.Location = new Point(322, 323);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(131, 40);
            btnTatCa.TabIndex = 1;
            btnTatCa.Text = ">>";
            btnTatCa.UseVisualStyleBackColor = true;
            btnTatCa.Click += btnTatCa_Click;
            // 
            // btnTinhHocPhi
            // 
            btnTinhHocPhi.Location = new Point(68, 524);
            btnTinhHocPhi.Name = "btnTinhHocPhi";
            btnTinhHocPhi.Size = new Size(131, 40);
            btnTinhHocPhi.TabIndex = 2;
            btnTinhHocPhi.Text = "Tinh hoc phi";
            btnTinhHocPhi.UseVisualStyleBackColor = true;
            btnTinhHocPhi.Click += btnTinhHocPhi_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Location = new Point(503, 524);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(131, 40);
            btnGhiFile.TabIndex = 3;
            btnGhiFile.Text = "Ghi File";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(747, 103);
            label1.TabIndex = 4;
            label1.Text = "Tinh Tong Hoc Phi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstMonHoc
            // 
            lstMonHoc.FormattingEnabled = true;
            lstMonHoc.Location = new Point(0, 125);
            lstMonHoc.Name = "lstMonHoc";
            lstMonHoc.Size = new Size(225, 334);
            lstMonHoc.TabIndex = 5;
            // 
            // lstDaChon
            // 
            lstDaChon.FormattingEnabled = true;
            lstDaChon.Location = new Point(522, 125);
            lstDaChon.Name = "lstDaChon";
            lstDaChon.Size = new Size(225, 334);
            lstDaChon.TabIndex = 6;
            // 
            // txtHocPhi
            // 
            txtHocPhi.Location = new Point(266, 529);
            txtHocPhi.Name = "txtHocPhi";
            txtHocPhi.ReadOnly = true;
            txtHocPhi.Size = new Size(175, 35);
            txtHocPhi.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, 608);
            label2.Name = "label2";
            label2.Size = new Size(747, 103);
            label2.TabIndex = 8;
            label2.Text = "Bai Tap Cau 3";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 703);
            Controls.Add(label2);
            Controls.Add(txtHocPhi);
            Controls.Add(lstDaChon);
            Controls.Add(lstMonHoc);
            Controls.Add(label1);
            Controls.Add(btnGhiFile);
            Controls.Add(btnTinhHocPhi);
            Controls.Add(btnTatCa);
            Controls.Add(btnTrai);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrai;
        private Button btnTatCa;
        private Button btnTinhHocPhi;
        private Button btnGhiFile;
        private Label label1;
        private ListBox lstMonHoc;
        private ListBox lstDaChon;
        private TextBox txtHocPhi;
        private Label label2;
    }
}