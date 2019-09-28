using BUL;
using DTO;
using EF;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TOOLS;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhanSu.NhanVien
{
    public partial class ucNhapXuatNV : UserControl
    {
        List<NhanVienDTO> lstNhanVienImport;

        public ucNhapXuatNV()
        {
            InitializeComponent();
        }

        private void metroTabControlNhapXuat_Click(object sender, EventArgs e)
        {
            if (metroTabControlNhapXuat.SelectedTab == metroTabControlNhapXuat.TabPages["metroTabPageXuat"])
            {
                dgvNhapXuatNhanVien.DataSource = ucHoSoNhanVien.GetListNhanVien();
                CustomDataGridView();
            }
            else if (metroTabControlNhapXuat.SelectedTab == metroTabControlNhapXuat.TabPages["metroTabPageNhap"])
            {
                dgvNhapXuatNhanVien.DataSource = null;
            }
        }

        private void BtnNhap_ChonFile_Click(object sender, EventArgs e)
        {
            lstNhanVienImport = new List<NhanVienDTO>();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files|*xlsx;*xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                metroLabelNhap_Path.Text = open.FileName.ToString();

                ////Cách 1: Sử dụng thư viện có sẵn tren Github
                //FileStream fs = new FileStream(txtPathNhap.Text, FileMode.Open);
                //using (var reader = ExcelReaderFactory.CreateReader(fs))
                //{
                //    dgvNhapXuatNhanVien.DataSource = reader.AsDataSet().Tables["NhanVien"];
                //    //CustomDataGridView();
                //}

                //Cách 2: Sử dụng thư viện của Microsoft Microsoft.Office.Interop.Excel
                //Mở úng dụng Excel
                Excel.Application excelApp = new Excel.Application();
                //Mở file Excel
                Excel.Workbook wb = excelApp.Workbooks.Open(metroLabelNhap_Path.Text);
                try
                {
                    ////Cho phép ứng dụng hiển thị
                    //excelApp.Visible = true;
                    //Mở sheet
                    Excel._Worksheet workSheet = wb.Sheets["DSNhanVien"];
                    Excel.Range range = workSheet.UsedRange;
                    int soDong = range.Rows.Count;
                    NhanVienDTO nv;
                    for (int i = 2; i <= soDong; i++)
                    {
                        nv = new NhanVienDTO();
                        nv.HoLot = Convert.ToString(workSheet.Cells[i, 1].Value);
                        nv.Ten = Convert.ToString(range.Cells[i, 2].Value);
                        nv.CMND = Convert.ToString(range.Cells[i, 3].Value);
                        //nv.GioiTinh = Convert.ToBoolean(range.Cells[i, 4].Value);
                        if(Convert.ToString(workSheet.Cells[i, 4].Value) == "Nam")
                        {
                            nv.GioiTinh = true;
                        }
                        else
                        {
                            nv.GioiTinh = false;
                        }
                        nv.NgaySinh = Convert.ToDateTime(range.Cells[i, 5].Value);
                        nv.DiaChi = Convert.ToString(range.Cells[i, 6].Value);
                        nv.DienThoai = Convert.ToString(range.Cells[i, 7].Value);
                        nv.MaBP = 5;
                        nv.MaChucVu = 5;
                        lstNhanVienImport.Add(nv);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.ToString());
                }
                finally
                {
                    wb.Close();
                    excelApp.Quit();
                    dgvNhapXuatNhanVien.DataSource = lstNhanVienImport;
                    CustomDataGridView();
                    Process[] excelProcesses = Process.GetProcessesByName("excel");
                    Console.WriteLine("excelProcesses" + excelProcesses.Length);
                    foreach (var p in excelProcesses)
                    {
                        p.Kill();
                    }
                }

                btnNhap_LuuNhanVien.Enabled = true;
            }
            else
            {
                metroLabelNhap_Path.Text = "Đường dẫn không hợp lệ!";
            }
        }
      
        private void BtnNhap_ChonViTriLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                metroLabelXuat_Path.Text = saveDialog.FileName;
                btnXuat_XuatDSNV.Enabled = true;
            }
        }

        private void btnNhap_LuuNhanVien_Click(object sender, EventArgs e)
        {
            if(NhanVienBUL.Them(lstNhanVienImport) == true)
            {
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnXuat_XuatDSNV_Click(object sender, EventArgs e)
        {
            //Mở app Excel
            Excel.Application excelApp = new Excel.Application();
            //Tạo một Workbook
            Excel._Workbook wb = excelApp.Workbooks.Add();
            try
            {
                List<NhanVienDTO> lst = ucHoSoNhanVien.GetListNhanVien();
                if (lst.Count > 0)
                {
                    //excelApp.Visible = true;
                    //Tạo 1 trang Worksheet
                    Excel._Worksheet workSheet = wb.ActiveSheet;
                    //Đặt tên cho Worksheet
                    workSheet.Name = "DSNhanVien";
                    //Gộp 9 cột 
                    workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[1, 9]].Merge();
                    workSheet.Cells[1, 1] = "Danh sách nhân viên";
                    //Căn giữa cho cells[1,1]
                    workSheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    //Chỉnh Font size cho cells[1,1]
                    workSheet.Cells[1, 1].Font.Size = 20;

                    int row = 2;
                    workSheet.Cells[row, 1] = "Họ";
                    workSheet.Cells[row, 2] = "Tên";
                    workSheet.Cells[row, 3] = "CMND";
                    workSheet.Cells[row, 4] = "Giới tính";
                    workSheet.Cells[row, 5] = "Ngày sinh";
                    workSheet.Cells[row, 6] = "Địa chỉ";
                    workSheet.Cells[row, 7] = "Điện thoại";
                    workSheet.Cells[row, 8] = "Bộ phận";
                    workSheet.Cells[row, 9] = "Chức vụ";
                    //Chỉnh font size cho header
                    workSheet.Range[workSheet.Cells[row, 1], workSheet.Cells[row, 9]].Font.Size = 12;
                    foreach (var item in lst)
                    {
                        row++;
                        workSheet.Cells[row, 1] = item.HoLot;
                        workSheet.Cells[row, 2] = item.Ten;
                        workSheet.Cells[row, 3] = item.CMND;
                        workSheet.Cells[row, 4] = item.GioiTinh;
                        workSheet.Cells[row, 5] = item.NgaySinh;
                        workSheet.Cells[row, 6] = item.DiaChi;
                        workSheet.Cells[row, 7] = item.DienThoai;
                        workSheet.Cells[row, 8] = item.TenBP;
                        workSheet.Cells[row, 9] = item.TenChucVu;
                    }
                    workSheet.Columns[1].AutoFit();
                    workSheet.Columns[2].AutoFit();
                    workSheet.Columns[3].AutoFit();
                    workSheet.Columns[4].AutoFit();
                    workSheet.Columns[5].AutoFit();
                    workSheet.Columns[6].AutoFit();
                    workSheet.Columns[7].AutoFit();
                    workSheet.Columns[8].AutoFit();
                    workSheet.Columns[9].AutoFit();

                    //Save file vào 
                    wb.SaveAs(metroLabelXuat_Path.Text);
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có gì đâu mà xuất hả 3 <3!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                wb.Close();
                excelApp.Quit();
                Process[] excelProcesses = Process.GetProcessesByName("excel");
                foreach (var p in excelProcesses)
                {
                    p.Kill();
                }
            }
        }

        private void CustomDataGridView()
        {
            dgvNhapXuatNhanVien.Columns["HoLot"].HeaderText = "Họ";
            dgvNhapXuatNhanVien.Columns["Ten"].HeaderText = "Tên";
            dgvNhapXuatNhanVien.Columns["CMND"].HeaderText = "CMND";
            dgvNhapXuatNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhapXuatNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNhapXuatNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNhapXuatNhanVien.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvNhapXuatNhanVien.Columns["TenBP"].HeaderText = "Bộ phận";
            dgvNhapXuatNhanVien.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dgvNhapXuatNhanVien.Columns["DaThoiViec"].Visible = false;
            dgvNhapXuatNhanVien.Columns["MaNV"].Visible = false;
            dgvNhapXuatNhanVien.Columns["HinhAnh"].Visible = false;
            dgvNhapXuatNhanVien.Columns["MaBP"].Visible = false;
            dgvNhapXuatNhanVien.Columns["MaChucVu"].Visible = false;
        }

        
    }
}
