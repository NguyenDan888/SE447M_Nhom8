﻿
namespace WinFormsApp_Coffee
{
    partial class frmQuanlykhuyenmai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateNgaykt = new System.Windows.Forms.DateTimePicker();
            this.dateNgaybd = new System.Windows.Forms.DateTimePicker();
            this.txtMadot = new System.Windows.Forms.TextBox();
            this.txtTendot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvQuanlykhuyenmai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemdotkm = new System.Windows.Forms.Button();
            this.btnXoadotkhuyenmai = new System.Windows.Forms.Button();
            this.btnSuathongtin = new System.Windows.Forms.Button();
            this.btnThemdotkhuyenmai = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlykhuyenmai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Chưa áp dụng",
            "Đang diễn ra"});
            this.cbbTrangThai.Location = new System.Drawing.Point(115, 220);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(200, 28);
            this.cbbTrangThai.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đợt:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateNgaykt);
            this.panel3.Controls.Add(this.dateNgaybd);
            this.panel3.Controls.Add(this.cbbTrangThai);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMadot);
            this.panel3.Controls.Add(this.txtTendot);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(554, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 292);
            this.panel3.TabIndex = 10;
            // 
            // dateNgaykt
            // 
            this.dateNgaykt.CustomFormat = "dd/MM/yyyy";
            this.dateNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaykt.Location = new System.Drawing.Point(114, 171);
            this.dateNgaykt.Name = "dateNgaykt";
            this.dateNgaykt.Size = new System.Drawing.Size(202, 27);
            this.dateNgaykt.TabIndex = 16;
            // 
            // dateNgaybd
            // 
            this.dateNgaybd.CustomFormat = "dd/MM/yyyy";
            this.dateNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaybd.Location = new System.Drawing.Point(115, 116);
            this.dateNgaybd.Name = "dateNgaybd";
            this.dateNgaybd.Size = new System.Drawing.Size(202, 27);
            this.dateNgaybd.TabIndex = 15;
            // 
            // txtMadot
            // 
            this.txtMadot.Location = new System.Drawing.Point(115, 12);
            this.txtMadot.Name = "txtMadot";
            this.txtMadot.Size = new System.Drawing.Size(200, 27);
            this.txtMadot.TabIndex = 4;
            this.txtMadot.Text = "ss";
            // 
            // txtTendot
            // 
            this.txtTendot.Location = new System.Drawing.Point(115, 62);
            this.txtTendot.Name = "txtTendot";
            this.txtTendot.Size = new System.Drawing.Size(200, 27);
            this.txtTendot.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlykhuyenmai);
            this.panel2.Location = new System.Drawing.Point(7, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 292);
            this.panel2.TabIndex = 9;
            // 
            // dgvQuanlykhuyenmai
            // 
            this.dgvQuanlykhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlykhuyenmai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvQuanlykhuyenmai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanlykhuyenmai.Location = new System.Drawing.Point(0, 0);
            this.dgvQuanlykhuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanlykhuyenmai.Name = "dgvQuanlykhuyenmai";
            this.dgvQuanlykhuyenmai.RowHeadersWidth = 62;
            this.dgvQuanlykhuyenmai.RowTemplate.Height = 33;
            this.dgvQuanlykhuyenmai.Size = new System.Drawing.Size(541, 292);
            this.dgvQuanlykhuyenmai.TabIndex = 0;
            this.dgvQuanlykhuyenmai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlykhuyenmai_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDot";
            this.Column1.HeaderText = "Mã đợt km";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDot";
            this.Column2.HeaderText = "Tên đợt km";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayBatDau";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Ngày bắt đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Ngày kết thúc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TrangThai";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemdotkm);
            this.panel1.Controls.Add(this.btnXoadotkhuyenmai);
            this.panel1.Controls.Add(this.btnSuathongtin);
            this.panel1.Controls.Add(this.btnThemdotkhuyenmai);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 70);
            this.panel1.TabIndex = 8;
            // 
            // btnXemdotkm
            // 
            this.btnXemdotkm.Location = new System.Drawing.Point(4, 3);
            this.btnXemdotkm.Name = "btnXemdotkm";
            this.btnXemdotkm.Size = new System.Drawing.Size(125, 63);
            this.btnXemdotkm.TabIndex = 3;
            this.btnXemdotkm.Text = "Xem đợt khuyến mãi";
            this.btnXemdotkm.UseVisualStyleBackColor = true;
            this.btnXemdotkm.Click += new System.EventHandler(this.btnXemdotkm_Click);
            // 
            // btnXoadotkhuyenmai
            // 
            this.btnXoadotkhuyenmai.Location = new System.Drawing.Point(397, 3);
            this.btnXoadotkhuyenmai.Name = "btnXoadotkhuyenmai";
            this.btnXoadotkhuyenmai.Size = new System.Drawing.Size(125, 63);
            this.btnXoadotkhuyenmai.TabIndex = 2;
            this.btnXoadotkhuyenmai.Text = "Xóa đợt khuyến mãi";
            this.btnXoadotkhuyenmai.UseVisualStyleBackColor = true;
            this.btnXoadotkhuyenmai.Click += new System.EventHandler(this.btnXoadotkhuyenmai_Click);
            // 
            // btnSuathongtin
            // 
            this.btnSuathongtin.Location = new System.Drawing.Point(266, 4);
            this.btnSuathongtin.Name = "btnSuathongtin";
            this.btnSuathongtin.Size = new System.Drawing.Size(125, 63);
            this.btnSuathongtin.TabIndex = 1;
            this.btnSuathongtin.Text = "Sửa đợt khuyến mãi";
            this.btnSuathongtin.UseVisualStyleBackColor = true;
            this.btnSuathongtin.Click += new System.EventHandler(this.btnSuathongtin_Click);
            // 
            // btnThemdotkhuyenmai
            // 
            this.btnThemdotkhuyenmai.Location = new System.Drawing.Point(135, 3);
            this.btnThemdotkhuyenmai.Name = "btnThemdotkhuyenmai";
            this.btnThemdotkhuyenmai.Size = new System.Drawing.Size(125, 63);
            this.btnThemdotkhuyenmai.TabIndex = 0;
            this.btnThemdotkhuyenmai.Text = "Thêm đợt khuyến mãi";
            this.btnThemdotkhuyenmai.UseVisualStyleBackColor = true;
            this.btnThemdotkhuyenmai.Click += new System.EventHandler(this.btnThemdotkhuyenmai_Click);
            // 
            // frmQuanlykhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 389);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuanlykhuyenmai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khuyến mãi";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlykhuyenmai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMadot;
        private System.Windows.Forms.TextBox txtTendot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQuanlykhuyenmai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoadotkhuyenmai;
        private System.Windows.Forms.Button btnSuathongtin;
        private System.Windows.Forms.Button btnThemdotkhuyenmai;
        private System.Windows.Forms.Button btnXemdotkm;
        private System.Windows.Forms.DateTimePicker dateNgaykt;
        private System.Windows.Forms.DateTimePicker dateNgaybd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}