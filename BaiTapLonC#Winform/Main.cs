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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadUserControl(new UCQuanLySinhVien());
            
        }
        private void LoadUserControl(UserControl uc)
        {
            pnQLSV.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnQLSV.Controls.Add(uc);
            
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCQuanLySinhVien());
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCQuanLyLopHoc());
        }
    }
}
