using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public void LoadData()
        {
            try
            {
                var dSSV = db.tbl_sinhviens.Select(sv => new
                {
                    sv.id,
                    sv.hoten,
                    sv.gioitinh,
                    sv.ngaysinh,
                    sv.malop
                }).ToList();
                cbGioiTinh.SelectedIndex = 0;
                DsSinhVien.DataSource = dSSV;
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
            cbGioiTinh.SelectedIndex = -1;
            dateNgaySinh.Value = DateTime.Now;
            cbLop.SelectedIndex = 0;
        }
    }
}
