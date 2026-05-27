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
        public UCQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UCQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            List<tbl_lophoc> dslh = db.tbl_lophocs.ToList();
            dvg_dslh.DataSource = dslh;
            dvg_dslh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
