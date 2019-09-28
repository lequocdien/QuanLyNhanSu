namespace QuanLyNhanSu.DangNhap
{
    partial class ucDangNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mpnDangNhap = new MetroFramework.Controls.MetroPanel();
            this.pnlDangNhapContainer = new MetroFramework.Controls.MetroPanel();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.tmrDangNhap = new System.Windows.Forms.Timer(this.components);
            this.txtHo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.mpnDangNhap.SuspendLayout();
            this.pnlDangNhapContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.37164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.62836F));
            this.tableLayoutPanel1.Controls.Add(this.mpnDangNhap, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mpnDangNhap
            // 
            this.mpnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mpnDangNhap.Controls.Add(this.pnlDangNhapContainer);
            this.mpnDangNhap.CustomBackground = true;
            this.mpnDangNhap.HorizontalScrollbarBarColor = true;
            this.mpnDangNhap.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnDangNhap.HorizontalScrollbarSize = 12;
            this.mpnDangNhap.Location = new System.Drawing.Point(106, 58);
            this.mpnDangNhap.Margin = new System.Windows.Forms.Padding(10);
            this.mpnDangNhap.Name = "mpnDangNhap";
            this.mpnDangNhap.Size = new System.Drawing.Size(657, 348);
            this.mpnDangNhap.TabIndex = 0;
            this.mpnDangNhap.VerticalScrollbarBarColor = true;
            this.mpnDangNhap.VerticalScrollbarHighlightOnWheel = false;
            this.mpnDangNhap.VerticalScrollbarSize = 13;
            // 
            // pnlDangNhapContainer
            // 
            this.pnlDangNhapContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.pnlDangNhapContainer.Controls.Add(this.metroTextBox1);
            this.pnlDangNhapContainer.Controls.Add(this.txtHo);
            this.pnlDangNhapContainer.Controls.Add(this.metroLabel1);
            this.pnlDangNhapContainer.Controls.Add(this.metroLabel4);
            this.pnlDangNhapContainer.Controls.Add(this.btnDangNhap);
            this.pnlDangNhapContainer.CustomBackground = true;
            this.pnlDangNhapContainer.HorizontalScrollbarBarColor = true;
            this.pnlDangNhapContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDangNhapContainer.HorizontalScrollbarSize = 10;
            this.pnlDangNhapContainer.Location = new System.Drawing.Point(10, 10);
            this.pnlDangNhapContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDangNhapContainer.Name = "pnlDangNhapContainer";
            this.pnlDangNhapContainer.Size = new System.Drawing.Size(635, 318);
            this.pnlDangNhapContainer.TabIndex = 2;
            this.pnlDangNhapContainer.VerticalScrollbarBarColor = true;
            this.pnlDangNhapContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDangNhapContainer.VerticalScrollbarSize = 10;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(362, 180);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(156, 46);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // tmrDangNhap
            // 
            this.tmrDangNhap.Interval = 10;
            this.tmrDangNhap.Tick += new System.EventHandler(this.tmrDangNhap_Tick);
            // 
            // txtHo
            // 
            this.txtHo.CustomForeColor = true;
            this.txtHo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHo.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtHo.ForeColor = System.Drawing.Color.White;
            this.txtHo.Location = new System.Drawing.Point(267, 76);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHo.Multiline = true;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(251, 41);
            this.txtHo.TabIndex = 11;
            this.txtHo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(114, 76);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(144, 41);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Tài khoản";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(114, 126);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(144, 41);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Mật khẩu";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.CustomForeColor = true;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.ForeColor = System.Drawing.Color.White;
            this.metroTextBox1.Location = new System.Drawing.Point(267, 126);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(251, 41);
            this.metroTextBox1.TabIndex = 11;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSystemPasswordChar = true;
            // 
            // ucDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDangNhap";
            this.Size = new System.Drawing.Size(873, 464);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mpnDangNhap.ResumeLayout(false);
            this.pnlDangNhapContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel mpnDangNhap;
        private System.Windows.Forms.Timer tmrDangNhap;
        private MetroFramework.Controls.MetroPanel pnlDangNhapContainer;
        private MetroFramework.Controls.MetroButton btnDangNhap;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox txtHo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
