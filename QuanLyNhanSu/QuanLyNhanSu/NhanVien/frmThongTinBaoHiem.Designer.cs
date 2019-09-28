namespace QuanLyNhanSu.NhanVien
{
    partial class frmThongTinBaoHiem
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.txtNoiKhamBenh = new MetroFramework.Controls.MetroTextBox();
            this.txtNoiCap = new MetroFramework.Controls.MetroTextBox();
            this.txtSoBaoHiem = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.metroPanel1.Controls.Add(this.btnXoa);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.btnSua);
            this.metroPanel1.Controls.Add(this.dtpNgayCap);
            this.metroPanel1.Controls.Add(this.dtpNgayHetHan);
            this.metroPanel1.Controls.Add(this.txtNoiKhamBenh);
            this.metroPanel1.Controls.Add(this.txtNoiCap);
            this.metroPanel1.Controls.Add(this.txtSoBaoHiem);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(767, 456);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnXoa.Location = new System.Drawing.Point(541, 358);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 46);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            // 
            // metroButton2
            // 
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.metroButton2.Location = new System.Drawing.Point(76, 358);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(129, 46);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "Thêm";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnSua
            // 
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSua.Location = new System.Drawing.Point(313, 358);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 46);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayCap.CustomFormat = "dd/mm/yyyy";
            this.dtpNgayCap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCap.Location = new System.Drawing.Point(271, 99);
            this.dtpNgayCap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(357, 42);
            this.dtpNgayCap.TabIndex = 21;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayHetHan.CustomFormat = "dd/mm/yyyy";
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(271, 281);
            this.dtpNgayHetHan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(357, 42);
            this.dtpNgayHetHan.TabIndex = 21;
            // 
            // txtNoiKhamBenh
            // 
            this.txtNoiKhamBenh.CustomForeColor = true;
            this.txtNoiKhamBenh.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNoiKhamBenh.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtNoiKhamBenh.Location = new System.Drawing.Point(271, 219);
            this.txtNoiKhamBenh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiKhamBenh.Multiline = true;
            this.txtNoiKhamBenh.Name = "txtNoiKhamBenh";
            this.txtNoiKhamBenh.Size = new System.Drawing.Size(357, 43);
            this.txtNoiKhamBenh.TabIndex = 17;
            this.txtNoiKhamBenh.Text = "metroTextBox1";
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.CustomForeColor = true;
            this.txtNoiCap.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNoiCap.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtNoiCap.Location = new System.Drawing.Point(271, 156);
            this.txtNoiCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiCap.Multiline = true;
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(357, 43);
            this.txtNoiCap.TabIndex = 18;
            this.txtNoiCap.Text = "metroTextBox1";
            // 
            // txtSoBaoHiem
            // 
            this.txtSoBaoHiem.CustomForeColor = true;
            this.txtSoBaoHiem.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSoBaoHiem.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtSoBaoHiem.Location = new System.Drawing.Point(271, 39);
            this.txtSoBaoHiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoBaoHiem.Multiline = true;
            this.txtSoBaoHiem.Name = "txtSoBaoHiem";
            this.txtSoBaoHiem.Size = new System.Drawing.Size(357, 43);
            this.txtSoBaoHiem.TabIndex = 20;
            this.txtSoBaoHiem.Text = "metroTextBox1";
            // 
            // metroLabel5
            // 
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(44, 281);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(206, 43);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Ngày hết hạn";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(44, 219);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(206, 43);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Nơi khám bệnh";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(44, 156);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(206, 43);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Nơi cấp";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(44, 99);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(206, 43);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Ngày cấp";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(44, 39);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(206, 43);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Số bảo hiểm";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmThongTinBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 536);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongTinBaoHiem";
            this.Text = "Thông tin bảo hiểm";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtNoiKhamBenh;
        private MetroFramework.Controls.MetroTextBox txtNoiCap;
        private MetroFramework.Controls.MetroTextBox txtSoBaoHiem;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}