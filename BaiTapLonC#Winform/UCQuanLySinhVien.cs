using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonC_Winform
{
    public partial class UCQuanLySinhVien : UserControl
    {
        DatabaseDataContext db = new DatabaseDataContext();
        int pageSize = 5;
        int currentPage = 1;
        int totalPage= 1;
        public UCQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UCQuanLySinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                dateNgaySinh.Format = DateTimePickerFormat.Custom;
                dateNgaySinh.CustomFormat = "dd/MM/yyyy";

                LoadDSLH();
                LoadData();
                DsSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (DsSinhVien.Columns["ngaysinh"] != null)
                {
                    DsSinhVien.Columns["ngaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("MSSV không được để trống.");
                return;
            }
            int mSSV;
            if (!int.TryParse(txtMSSV.Text, out mSSV))
            {
                MessageBox.Show("MSSV phải là một số nguyên.");
                return;
            }
            if (!int.TryParse(txtMSSV.Text.Trim(), out mSSV))
            {
                MessageBox.Show("Mã số sinh viên phải là số nguyên!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (cbGioiTinh.SelectedIndex <= 0 || string.IsNullOrWhiteSpace(cbGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGioiTinh.Focus();
                return;
            }

            if (cbLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học hợp lệ!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLop.Focus();
                return;
            }
            try
            {
                var checkTrungMSSV = db.tbl_sinhviens.FirstOrDefault(sv => sv.id == mSSV);
                if (checkTrungMSSV != null)
                {
                    MessageBox.Show("MSSV đã tồn tại. Vui lòng nhập MSSV khác!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMSSV.Focus();
                    return;
                }
                tbl_sinhvien sinhvien = new tbl_sinhvien();
                sinhvien.id = mSSV;
                sinhvien.hoten = txtHoTen.Text.Trim();
                sinhvien.gioitinh = cbGioiTinh.Text;
                sinhvien.ngaysinh = dateNgaySinh.Value;
                sinhvien.malop = cbLop.SelectedValue.ToString();

                db.tbl_sinhviens.InsertOnSubmit(sinhvien);
                db.SubmitChanges();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");

                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm sinh viên " + ex.Message);
            }

        }
        public void LoadData(string keyword = "")
        {
            try
            {
                var query = db.tbl_sinhviens.AsQueryable();
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query = query.Where(sv =>
                        sv.hoten.Contains(keyword) ||
                        sv.id.ToString().Contains(keyword) ||
                        sv.malop.Contains(keyword)
                    );
                }
                var total = query.Count();
                totalPage = (int)Math.Ceiling((double)total / pageSize);
                if(currentPage > totalPage)
                {
                    currentPage = totalPage;
                }
                if ( currentPage < 1)
                {
                    currentPage = 1;
                }
                var dSSV = query
                    .OrderBy(sv => sv.id)
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .Select(sv => new
                    {
                        sv.id,
                        sv.hoten,
                        sv.gioitinh,
                        sv.ngaysinh,
                        sv.malop
                    })
                    .ToList();

                        DsSinhVien.DataSource = dSSV;

                lblPage.Text = currentPage + " / " + totalPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sinh viên: " + ex.Message);
            }
        }
        public void LoadDSLH()
        {
            try
            {
                List<tbl_lophoc> dsLH = db.tbl_lophocs.ToList();
                cbLop.DataSource = dsLH;
                cbLop.DisplayMember = "tenlop";
                cbLop.ValueMember = "malop";
                cbLop.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách lớp học: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            cbGioiTinh.SelectedIndex = 0;
            dateNgaySinh.Value = DateTime.Now;
            cbLop.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV!", "Nhắc nhở",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV.Focus();
                return;
            }

            int mSSV;
            if (!int.TryParse(txtMSSV.Text.Trim(), out mSSV))
            {
                MessageBox.Show("MSSV phải là số nguyên!", "Nhắc nhở",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Nhắc nhở",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (cbGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Nhắc nhở",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGioiTinh.Focus();
                return;
            }
            if (cbLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Nhắc nhở",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLop.Focus();
                return;
            }

            try
            {
                var sinhvien = db.tbl_sinhviens.FirstOrDefault(sv => sv.id == mSSV);

                if (sinhvien == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }


                sinhvien.hoten = txtHoTen.Text.Trim();
                sinhvien.gioitinh = cbGioiTinh.Text;
                sinhvien.ngaysinh = dateNgaySinh.Value;
                sinhvien.malop = cbLop.SelectedValue.ToString();

                db.SubmitChanges();

                MessageBox.Show("Cập nhật sinh viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void DsSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DsSinhVien.Rows[e.RowIndex];

                txtMSSV.Text = row.Cells["id"].Value.ToString();
                txtHoTen.Text = row.Cells["hoten"].Value.ToString();
                cbGioiTinh.Text = row.Cells["gioitinh"].Value.ToString();

                if (row.Cells["ngaysinh"].Value != null)
                {
                    dateNgaySinh.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
                }

                cbLop.SelectedValue = row.Cells["malop"].Value.ToString();

                txtMSSV.Enabled = false;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mssv;
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtMSSV.Text.Trim(), out mssv))
            {
                MessageBox.Show("MSSV không hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if(result == DialogResult.No)
            {
                return;
            }
            try
            {
              var sinhvien = db.tbl_sinhviens.FirstOrDefault(s => s.id == mssv);
                if (sinhvien == null)
                {
                    MessageBox.Show("Không tim thấy sinh viên",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                db.tbl_sinhviens.DeleteOnSubmit(sinhvien);
                db.SubmitChanges();

                MessageBox.Show("Xóa sinh viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message,
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            currentPage = 1;

            LoadData(inputSearch.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(currentPage > 1)
            {
                currentPage--;
                LoadData(inputSearch.Text.Trim());
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                LoadData(inputSearch.Text.Trim());
            }
        }

        private void prev_1_Click(object sender, EventArgs e)
        {
            currentPage = 1;

            LoadData(inputSearch.Text.Trim());
        }

        private void next_length_Click(object sender, EventArgs e)
        {
  
                currentPage = totalPage;
                LoadData(inputSearch.Text.Trim());
        }
    }
}
