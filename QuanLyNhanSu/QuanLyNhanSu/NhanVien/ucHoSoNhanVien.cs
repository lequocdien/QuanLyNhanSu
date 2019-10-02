using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUL;
using TOOLS;
using DTO;
using EF;
using System.Linq;

namespace QuanLyNhanSu.NhanVien
{
    public partial class ucHoSoNhanVien : UserControl
    {
        static List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();
        List<TRINHDO> lstTrinhDo = new List<TRINHDO>();
        List<BOPHAN> lstBoPhan = new List<BOPHAN>();
        List<CHUCVU> lstChucVu = new List<CHUCVU>();
        List<BAOHIEM> lstBaoHiem;
        AutoCompleteStringCollection asc = new AutoCompleteStringCollection();

        public static List<NhanVienDTO> GetListNhanVien()
        {
            return lstNhanVien;
        }

        public ucHoSoNhanVien()
        {
            InitializeComponent();
        }

        private void ucHoSoNhanVien_Load(object sender, EventArgs e)
        {
            //Load nhân viên
            lstNhanVien = NhanVienBUL.LoadNhanVien();
            if(lstNhanVien == null)
            {
                MessageBox.Show("Không kết nối được cơ sở dữ liệu!");
            }
            //dgvNhanVien.DataSource = lstNhanVien;
            //CustomDataGridViewNhanVien();
            lstNhanVien = lstNhanVien.OrderBy(i => i.Ten).ToList();
            LoadNhanVien(1);
            //Load bộ phận
            lstBoPhan = BoPhanBUL.LoadBoPhan();
            cbxBoPhan.DataSource = lstBoPhan;
            cbxBoPhan.DisplayMember = "TenBP";
            cbxBoPhan.ValueMember = "MaBP";
            //Load chức vụ
            lstChucVu = ChucVuBUL.LoadChucVu();
            cbxChucVu.DataSource = lstChucVu;
            cbxChucVu.DisplayMember = "TenChucVu";
            cbxChucVu.ValueMember = "MaChucVu";
            //Load trình độ
            lstTrinhDo = TrinhDoBUL.LoadTrinhDo();
            cbxTrinhDo.DataSource = lstTrinhDo;
            cbxTrinhDo.DisplayMember = "TenTrinhDo";
            cbxTrinhDo.ValueMember = "MaTrinhDo";
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                //Load Sơ yếu lý lịch
                DataGridViewRow dgvRow = dgvNhanVien.SelectedRows[0];
                lblMaNV.Text = dgvRow.Cells["MaNV"].Value.ToString();
                txtHo.Text = dgvRow.Cells["HoLot"].Value.ToString();
                txtTen.Text = dgvRow.Cells["Ten"].Value.ToString();
                txtCMND.Text = dgvRow.Cells["CMND"].Value.ToString();
                if (Convert.ToBoolean(dgvRow.Cells["GioiTinh"].Value) == true)
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                dtpNgaySinh.Value = Convert.ToDateTime(dgvRow.Cells["NgaySinh"].Value);
                txtDienThoai.Text = dgvRow.Cells["DienThoai"].Value.ToString();
                picHinhAnhNV.Image = MyConvert.BinaryToImage((byte[])dgvRow.Cells["HinhAnh"].Value);
                txtDiaChi.Text = dgvRow.Cells["DiaChi"].Value.ToString();

                //Load Trình độ, Bộ phận, Chức vụ, Tình trạng
                cbxTrinhDo.SelectedValue = dgvRow.Cells["MaTrinhDo"].Value;
                cbxBoPhan.SelectedValue = dgvRow.Cells["MaBP"].Value;
                cbxChucVu.SelectedValue = dgvRow.Cells["MaChucVu"].Value;
                if (Convert.ToBoolean(dgvRow.Cells["DaThoiViec"].Value) == true)
                {
                    rdbDaThoiViec.Checked = true;
                }
                else
                {
                    rdbDangLam.Checked = true;
                }

                //Load Bảo hiểm
                lstBaoHiem = BaoHiemBUL.Load(Convert.ToInt32(lblMaNV.Text));
                if (lstBaoHiem != null)
                {
                    lblClickDeThemBaoHiem.Visible = false;
                    dgvBaoHiem.DataSource = typeof(List<BAOHIEM>);
                    dgvBaoHiem.DataSource = lstBaoHiem;
                    CustomDataGridViewBaoHiem();
                }
                else
                {
                    lstBaoHiem = new List<BAOHIEM>();
                    lblClickDeThemBaoHiem.Visible = true;
                    dgvBaoHiem.DataSource = null;
                }

                
            }
        }

        private void dgvBaoHiem_Click(object sender, EventArgs e)
        {
            if (dgvBaoHiem.SelectedRows.Count > 0)
            {
                BAOHIEM bh = new BAOHIEM();
                DataGridViewRow dgvRow = dgvBaoHiem.SelectedRows[0];
                bh.SoBH = dgvRow.Cells["SoBH"].Value.ToString();
                bh.NgayCap = Convert.ToDateTime(dgvRow.Cells["NgayCap"].Value);
                bh.NoiCap = dgvRow.Cells["NoiCap"].Value.ToString();
                bh.NoiKhamBenh = dgvRow.Cells["NoiKhamBenh"].Value.ToString();
                bh.NgayHetHan = Convert.ToDateTime(dgvRow.Cells["NgayHetHan"].Value);
                bh.MaNV = Convert.ToInt32(dgvRow.Cells["MaNV"].Value);
                frmThongTinBaoHiem frm = new frmThongTinBaoHiem();
                frm.SoBaoHiem = bh.SoBH;
                frm.NgayCap = bh.NgayCap;
                frm.NoiCap = bh.NoiCap;
                frm.NoiKhamBenh = bh.NoiKhamBenh;
                frm.NgayHetHan = bh.NgayHetHan;
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    bh.SoBH = frm.SoBaoHiem;
                    bh.NgayCap = frm.NgayCap;
                    bh.NoiCap = frm.NoiCap;
                    bh.NoiKhamBenh = frm.NoiKhamBenh;
                    bh.NgayHetHan = frm.NgayHetHan;
                    bh.MaNV = Convert.ToInt32(dgvRow.Cells["MaNV"].Value);
                    lstBaoHiem.Add(bh);
                    dgvBaoHiem.DataSource = typeof(List<BAOHIEM>);
                    dgvBaoHiem.DataSource = lstBaoHiem;
                    CustomDataGridViewBaoHiem();
                    BaoHiemBUL.Them(bh);
                }
                else if (res == DialogResult.OK)
                {
                    bh.SoBH = dgvRow.Cells[0].Value.ToString();
                    bh = lstBaoHiem.SingleOrDefault(i => i.SoBH == bh.SoBH);
                    bh.NgayCap = frm.NgayCap;
                    bh.NoiCap = frm.NoiCap;
                    bh.NoiKhamBenh = frm.NoiKhamBenh;
                    bh.NgayHetHan = frm.NgayHetHan;
                    dgvBaoHiem.DataSource = typeof(List<BAOHIEM>);
                    dgvBaoHiem.DataSource = lstBaoHiem;
                    CustomDataGridViewBaoHiem();
                    BaoHiemBUL.CapNhat(bh);
                }
                else if (res == DialogResult.No)
                {
                    bh.SoBH = dgvRow.Cells[0].Value.ToString();
                    bh = lstBaoHiem.SingleOrDefault(i => i.SoBH == bh.SoBH);
                    lstBaoHiem.Remove(bh);
                    dgvBaoHiem.DataSource = typeof(List<BAOHIEM>);
                    dgvBaoHiem.DataSource = lstBaoHiem;
                    CustomDataGridViewBaoHiem();
                    BaoHiemBUL.Xoa(bh.SoBH);
                }
            }
        }

        private void picHinhAnhNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files|*.jpg;*jpeg|PNG Files|*.png|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnhNV.Image = Image.FromFile(dialog.FileName);
            }
            MessageBox.Show(dialog.FileName.ToString());
        }

        private void lblClickDeThemBaoHiem_Click(object sender, EventArgs e)
        {
            BAOHIEM bh = new BAOHIEM();
            frmThongTinBaoHiem frm = new frmThongTinBaoHiem();
            frm.btnBaoHiem_Sua.Enabled = false;
            frm.btnBaoHiem_Xoa.Enabled = false;
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                bh.SoBH = frm.SoBaoHiem;
                bh.NgayCap = frm.NgayCap;
                bh.NoiCap = frm.NoiCap;
                bh.NoiKhamBenh = frm.NoiKhamBenh;
                bh.NgayHetHan = frm.NgayHetHan;
                bh.MaNV = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells["MaNV"].Value);
                lstBaoHiem.Add(bh);
                lblClickDeThemBaoHiem.Visible = false;
                dgvBaoHiem.DataSource = typeof(List<BAOHIEM>);
                dgvBaoHiem.DataSource = lstBaoHiem;
                CustomDataGridViewBaoHiem();
                BaoHiemBUL.Them(bh);
            }
            frm.btnBaoHiem_Sua.Enabled = true;
            frm.btnBaoHiem_Xoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVienDTO NhanVienCanThem = getInfoNhanVien();
            NhanVienCanThem = NhanVienBUL.Them(NhanVienCanThem);
            if (NhanVienCanThem != null)
            {
                lstNhanVien.Add(NhanVienCanThem);
                LoadNhanVien(1);
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(dgvNhanVien.SelectedRows.Count > 0)
            {
                NhanVienDTO NhanVienCanCapNhat = getInfoNhanVien();
                NhanVienCanCapNhat.MaNV = Convert.ToInt32(lblMaNV.Text);
                NhanVienCanCapNhat = NhanVienBUL.CapNhat(NhanVienCanCapNhat);
                if (NhanVienCanCapNhat != null)
                {
                    NhanVienCanCapNhat.TenBP = lstBoPhan.SingleOrDefault(i => i.MaBP == NhanVienCanCapNhat.MaBP).TenBP;
                    NhanVienCanCapNhat.TenChucVu = lstChucVu.SingleOrDefault(i => i.MaChucVu == NhanVienCanCapNhat.MaChucVu).TenChucVu;
                    NhanVienDTO nvFromList = lstNhanVien.SingleOrDefault(i => i.MaNV == NhanVienCanCapNhat.MaNV);
                    CapNhatListNhanVien(nvFromList, NhanVienCanCapNhat);
                    LoadNhanVien(1);
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                NhanVienDTO NhanVienCanXoa = getInfoNhanVien();
                NhanVienCanXoa.MaNV = Convert.ToInt32(lblMaNV.Text);
                NhanVienCanXoa.DaThoiViec = true;
                if (NhanVienBUL.CapNhat(NhanVienCanXoa) != null)
                {
                    NhanVienCanXoa = lstNhanVien.SingleOrDefault(i => i.MaNV == NhanVienCanXoa.MaNV);
                    lstNhanVien.Remove(NhanVienCanXoa);
                    LoadNhanVien(1);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void cbxTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbxTimKiem.Text == "Họ")
            {
                foreach (var item in lstNhanVien)
                {
                    asc.Add(item.HoLot);
                }
                txtTimKiem.AutoCompleteCustomSource = asc;
            }
            else if (cbxTimKiem.Text == "Tên")
            {
                foreach (var item in lstNhanVien)
                {
                    asc.Add(item.Ten);
                }
                txtTimKiem.AutoCompleteCustomSource = asc;
            }
            else if (cbxTimKiem.Text == "CMND")
            {
                foreach (var item in lstNhanVien)
                {
                    asc.Add(item.CMND);
                }
                txtTimKiem.AutoCompleteCustomSource = asc;
            }
            else if (cbxTimKiem.Text == "Điện thoại")
            {
                foreach (var item in lstNhanVien)
                {
                    asc.Add(item.DienThoai);
                }
                txtTimKiem.AutoCompleteCustomSource = asc;
            }
            else if (cbxTimKiem.Text == "Địa chỉ")
            {
                foreach (var item in lstNhanVien)
                {
                    asc.Add(item.DiaChi);
                }
                txtTimKiem.AutoCompleteCustomSource = asc;
            }
            else if (cbxTimKiem.Text == "Giới tính")
            {
                foreach (var item in lstNhanVien)
                {
                    asc.Add(item.DiaChi);
                }
                txtTimKiem.AutoCompleteCustomSource = asc;
            }
            else if (cbxTimKiem.Text == "Ngày sinh")
            {
                foreach (var item in lstNhanVien)
                {
                    asc.Add(item.DiaChi);
                }
                txtTimKiem.AutoCompleteCustomSource = asc;
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                if (cbxTimKiem.Text == "Họ")
                {
                    List<NhanVienDTO> lstTimKiem = lstNhanVien.Where(i => i.HoLot.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())).ToList();
                    dgvNhanVien.DataSource = lstTimKiem;
                    CustomDataGridViewNhanVien();
                }
                else if (cbxTimKiem.Text == "Tên")
                {
                    List<NhanVienDTO> lstTimKiem = lstNhanVien.Where(i => i.Ten.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())).ToList();
                    dgvNhanVien.DataSource = lstTimKiem;
                    CustomDataGridViewNhanVien();
                }
                else if (cbxTimKiem.Text == "CMND")
                {
                    List<NhanVienDTO> lstTimKiem = lstNhanVien.Where(i => i.CMND.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())).ToList();
                    dgvNhanVien.DataSource = lstTimKiem;
                    CustomDataGridViewNhanVien();
                }
                else if (cbxTimKiem.Text == "Giới tính")
                {
                    bool res = false;
                    if (txtTimKiem.Text.Trim().ToLower() == "nam" || txtTimKiem.Text.Trim().ToLower() == "Nam")
                    {
                        res = true;
                    }
                    List<NhanVienDTO> lstTimKiem = lstNhanVien.Where(i => i.GioiTinh == res).ToList();
                    dgvNhanVien.DataSource = lstTimKiem;
                    CustomDataGridViewNhanVien();
                }
                else if (cbxTimKiem.Text == "Địa chỉ")
                {
                    List<NhanVienDTO> lstTimKiem = lstNhanVien.Where(i => i.DiaChi.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())).ToList();
                    dgvNhanVien.DataSource = lstTimKiem;
                    CustomDataGridViewNhanVien();
                }
                else if (cbxTimKiem.Text == "Điện thoại")
                {
                    List<NhanVienDTO> lstTimKiem = lstNhanVien.Where(i => i.DienThoai.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())).ToList();
                    dgvNhanVien.DataSource = lstTimKiem;
                    CustomDataGridViewNhanVien();
                }

            }
            else
            {
                LoadNhanVienIntoGridView();
            }
        }

        private void numbericUDSoTrang_ValueChanged(object sender, EventArgs e)
        {
            LoadNhanVien(Convert.ToInt32(numbericUDSoTrang.Value));
        }

        #region Tools
        private void CustomDataGridViewNhanVien()
        {
            dgvNhanVien.Columns["HoLot"].HeaderText = "Họ";
            dgvNhanVien.Columns["Ten"].HeaderText = "Tên";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvNhanVien.Columns["TenBP"].HeaderText = "Bộ phận";
            dgvNhanVien.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dgvNhanVien.Columns["TenTrinhDo"].HeaderText = "Trình độ";
            dgvNhanVien.Columns["DaThoiViec"].Visible = false;
            dgvNhanVien.Columns["MaNV"].Visible = false;
            dgvNhanVien.Columns["HinhAnh"].Visible = false;
            dgvNhanVien.Columns["MaBP"].Visible = false;
            dgvNhanVien.Columns["MaChucVu"].Visible = false;
            dgvNhanVien.Columns["MaTrinhDo"].Visible = false;
            dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void CustomDataGridViewBaoHiem()
        {
            dgvBaoHiem.Columns["SoBH"].HeaderText = "Số bảo hiểm";
            dgvBaoHiem.Columns["NgayCap"].HeaderText = "Ngày cấp";
            dgvBaoHiem.Columns["NoiCap"].HeaderText = "Nơi cấp";
            dgvBaoHiem.Columns["NoiKhamBenh"].HeaderText = "Nơi khám bệnh";
            dgvBaoHiem.Columns["NgayHetHan"].HeaderText = "Ngày hết hạn";
            dgvBaoHiem.Columns["MaNV"].Visible = false;
            dgvBaoHiem.Columns["NHANVIEN"].Visible = false;
        }

        private void ReloadDataGridView()
        {
            dgvNhanVien.DataSource = typeof(List<NhanVienDTO>);
            dgvNhanVien.DataSource = lstNhanVien;
            CustomDataGridViewNhanVien();
        }

        private void CapNhatListNhanVien(NhanVienDTO nhanVienCanUpdate, NhanVienDTO data)
        {
            nhanVienCanUpdate.HoLot = data.HoLot;
            nhanVienCanUpdate.Ten = data.Ten;
            nhanVienCanUpdate.CMND = data.CMND;
            nhanVienCanUpdate.GioiTinh = data.GioiTinh;
            nhanVienCanUpdate.NgaySinh = data.NgaySinh;
            nhanVienCanUpdate.HinhAnh = data.HinhAnh;
            nhanVienCanUpdate.DiaChi = data.DiaChi;
            nhanVienCanUpdate.DienThoai = data.DienThoai;
            nhanVienCanUpdate.MaTrinhDo = data.MaTrinhDo;
            nhanVienCanUpdate.MaBP = data.MaBP;
            nhanVienCanUpdate.MaChucVu = data.MaChucVu;
            nhanVienCanUpdate.TenTrinhDo = data.TenTrinhDo;
            nhanVienCanUpdate.TenChucVu = data.TenChucVu;
            nhanVienCanUpdate.TenBP = data.TenBP;
            nhanVienCanUpdate.DaThoiViec = data.DaThoiViec;
            
            
        }

        private NhanVienDTO getInfoNhanVien()
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.HoLot = txtHo.Text;
            nv.Ten = txtTen.Text;
            nv.CMND = txtCMND.Text;
            if (rdbNam.Checked == true)
            {
                nv.GioiTinh = true;
            }
            else
            {
                nv.GioiTinh = false;
            }
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.DienThoai = txtDienThoai.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.HinhAnh = MyConvert.ImageToBinary(picHinhAnhNV.Image);
            nv.MaTrinhDo = Convert.ToInt32(cbxTrinhDo.SelectedValue);
            nv.MaBP = Convert.ToInt32(cbxBoPhan.SelectedValue);
            nv.MaChucVu = Convert.ToInt32(cbxChucVu.SelectedValue);
            if (rdbDaThoiViec.Checked == true)
            {
                nv.DaThoiViec = true;
            }
            else
            {
                nv.DaThoiViec = false;
            }
            return nv;
        }

        private void LoadNhanVienIntoGridView()
        {
            dgvNhanVien.DataSource = NhanVienBUL.LoadNhanVien();
            CustomDataGridViewNhanVien();
        }
        
        private void LoadNhanVien(int soTrang)
        {
            numbericUDSoTrang.Value = soTrang;
            int tongSoTrang;
            const int soDongMotTrang = 9;
            if (lstNhanVien.Count % soDongMotTrang != 0)
            {
                tongSoTrang = lstNhanVien.Count / soDongMotTrang + 1;
                numbericUDSoTrang.Maximum = tongSoTrang;
            }
            else
            {
                tongSoTrang = lstNhanVien.Count / soDongMotTrang;
                numbericUDSoTrang.Maximum = tongSoTrang;
            }
            int skipRow = (soTrang - 1) * soDongMotTrang;
            List<NhanVienDTO> lstNhanVienPhanTrang = lstNhanVien.Skip(skipRow).Take(soDongMotTrang).ToList();
            dgvNhanVien.DataSource = lstNhanVienPhanTrang;
            CustomDataGridViewNhanVien();
        }
        #endregion
    }

    
}
