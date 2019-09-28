namespace QuanLyNhanSu
{
    partial class frmMain
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
            this.mpnContainer = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mpnContainer
            // 
            this.mpnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnContainer.HorizontalScrollbarBarColor = true;
            this.mpnContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnContainer.HorizontalScrollbarSize = 10;
            this.mpnContainer.Location = new System.Drawing.Point(20, 60);
            this.mpnContainer.Name = "mpnContainer";
            this.mpnContainer.Size = new System.Drawing.Size(1100, 560);
            this.mpnContainer.TabIndex = 0;
            this.mpnContainer.VerticalScrollbarBarColor = true;
            this.mpnContainer.VerticalScrollbarHighlightOnWheel = false;
            this.mpnContainer.VerticalScrollbarSize = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 640);
            this.Controls.Add(this.mpnContainer);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "Quản lý nhân sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroPanel mpnContainer;
    }
}

