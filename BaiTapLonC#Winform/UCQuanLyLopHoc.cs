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

    public partial class UCQuanLyLopHoc : UserControl
    {
        DatabaseDataContext db = new DatabaseDataContext();
        int pageSize = 5;
        int currentPage = 1;
        int totalPage = 1;
        public UCQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UCQuanLyLopHoc_Load(object sender, EventArgs e)
        {
             LoadDataLH(textSearchInput.Text);
            dvg_dslh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadDataLH(string key= "")
        {
            //List<tbl_lophoc> dslh = db.tbl_lophocs.ToList();
            //dvg_dslh.DataSource = dslh;
            //dvg_dslh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                var query =  db.tbl_lophocs.AsQueryable();
                if (!string.IsNullOrWhiteSpace(key)){
                    query = query.Where( lh => 
                    lh.tenlop.Contains(key) || 
                    lh.malop.Contains(key)
                    );
                }
                var total = query.Count();

                totalPage = (int)Math.Ceiling((double)total / pageSize);
                if (currentPage > totalPage)
                {
                    currentPage = totalPage;
                }
                if (currentPage < 1)
                {
                    currentPage = 1;
                }
                var dsLH = query
                    .OrderBy(lh => lh.id)
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .Select(lh => new {
                    lh.id,
                    lh.malop,
                    lh.tenlop,
                    lh.ghichu
                }). ToList();
                dvg_dslh.DataSource = dsLH;

                lbPageClass.Text = currentPage + " / " + totalPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if(textMaLop.Text == "" || textTenLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin lớp học.");
                return;
            }

            if (db.tbl_lophocs.Any(l => l.id == int.Parse(textMaID.Text)))
            {
                MessageBox.Show("Id lớp đã tồn tại. Vui lòng điền lại ID khác.");
                return;
            }
            if(db.tbl_lophocs.Any(l => l.malop == textMaLop.Text))
            {
                MessageBox.Show("Mã lớp đã tồn tại. Vui lòng điền mã khác.");
                return;
            }
            try
            {
                tbl_lophoc tbl_Lophoc = new tbl_lophoc();
                tbl_Lophoc.id = int.Parse(textMaID.Text);
                tbl_Lophoc.malop = textMaLop.Text;
                tbl_Lophoc.tenlop = textTenLop.Text;
                tbl_Lophoc.ghichu = textGhiChu.Text;
                db.tbl_lophocs.InsertOnSubmit(tbl_Lophoc);
                db.SubmitChanges();
                MessageBox.Show("Thêm  lớp thành công!", "Thông báo");

                ClearInput();
                 LoadDataLH(textSearchInput.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void ClearInput()
        {
            textMaID.Text = "";
            textMaLop.Text = "";
            textTenLop.Text = "";
            textGhiChu.Text =" ";
        }

        private void dvg_dslh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvg_dslh.Rows[e.RowIndex];

                textMaID.Text = row.Cells["id"].Value.ToString();
                textMaLop.Text = row.Cells["malop"].Value.ToString();
                textTenLop.Text = row.Cells["tenlop"].Value.ToString();
                if (row.Cells["ghichu"].Value == null)
                {
                    textGhiChu.Text = " ";
                }
                else
                {
                    textGhiChu.Text = row.Cells["ghichu"].Value.ToString();
                }
                    textMaID.Enabled = false; 
            }
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (textMaLop.Text == "" || textTenLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin lớp học.");
                return;
            }
            try {
                var lophoc = db.tbl_lophocs.FirstOrDefault(l => l.id == int.Parse(textMaID.Text));
                lophoc.tenlop = textTenLop.Text;
                lophoc.malop = textMaLop.Text;
                lophoc.ghichu = textGhiChu.Text;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật lớp thành công!", "Thông báo");

                ClearInput();
                 LoadDataLH(textSearchInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(textMaID.Text) || !int.TryParse(textMaID.Text, out id))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa.");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.No)
            {
                return;
            }
            try
            {
                var lophoc = db.tbl_lophocs.FirstOrDefault(l => l.id == id);
                if (lophoc != null)
                {
                    db.tbl_lophocs.DeleteOnSubmit(lophoc);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo");
                    ClearInput();
                     LoadDataLH(textSearchInput.Text);
                }
                else
                {
                    MessageBox.Show("Lớp học không tồn tại.", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRefreshClass_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnGetStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDataLH(textSearchInput.Text);
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataLH(textSearchInput.Text);
            }
        }

        private void btnprev1_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadDataLH(textSearchInput.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                LoadDataLH(textSearchInput.Text);
            }
        }

        private void btnNextLenght_Click(object sender, EventArgs e)
        {
            currentPage = totalPage;
            LoadDataLH(textSearchInput.Text);
        }
    }
}
