namespace BaiTapLonC_Winform
{
    partial class UCQuanLyLopHoc
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
        private void InitializeComponent()
        {
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnRefreshClass = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textSearchInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dvg_dslh = new System.Windows.Forms.DataGridView();
            this.btnprev1 = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnNextLenght = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbPageClass = new System.Windows.Forms.Label();
            this.btnGetStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textGhiChu = new System.Windows.Forms.TextBox();
            this.textTenLop = new System.Windows.Forms.TextBox();
            this.textMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maLop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_dslh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddClass
            // 
            this.btnAddClass.AllowDrop = true;
            this.btnAddClass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClass.Location = new System.Drawing.Point(18, 441);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(178, 66);
            this.btnAddClass.TabIndex = 39;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateClass.Location = new System.Drawing.Point(222, 441);
            this.btnUpdateClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(178, 66);
            this.btnUpdateClass.TabIndex = 40;
            this.btnUpdateClass.Text = "Sửa";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.BackColor = System.Drawing.Color.Red;
            this.btnDeleteClass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteClass.Location = new System.Drawing.Point(18, 523);
            this.btnDeleteClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(174, 61);
            this.btnDeleteClass.TabIndex = 41;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnRefreshClass
            // 
            this.btnRefreshClass.BackColor = System.Drawing.Color.Silver;
            this.btnRefreshClass.Location = new System.Drawing.Point(226, 523);
            this.btnRefreshClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshClass.Name = "btnRefreshClass";
            this.btnRefreshClass.Size = new System.Drawing.Size(174, 61);
            this.btnRefreshClass.TabIndex = 42;
            this.btnRefreshClass.Text = "Làm mới";
            this.btnRefreshClass.UseVisualStyleBackColor = false;
            this.btnRefreshClass.Click += new System.EventHandler(this.btnRefreshClass_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tìm kiếm (Mã ID/ Mã lớp/ Tên lớp):";
            // 
            // textSearchInput
            // 
            this.textSearchInput.Location = new System.Drawing.Point(433, 68);
            this.textSearchInput.Margin = new System.Windows.Forms.Padding(2);
            this.textSearchInput.Name = "textSearchInput";
            this.textSearchInput.Size = new System.Drawing.Size(585, 22);
            this.textSearchInput.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowDrop = true;
            this.btnSearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(1042, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 33);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dvg_dslh
            // 
            this.dvg_dslh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvg_dslh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_dslh.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvg_dslh.Location = new System.Drawing.Point(434, 104);
            this.dvg_dslh.Name = "dvg_dslh";
            this.dvg_dslh.RowHeadersWidth = 51;
            this.dvg_dslh.RowTemplate.Height = 24;
            this.dvg_dslh.Size = new System.Drawing.Size(737, 480);
            this.dvg_dslh.TabIndex = 46;
            this.dvg_dslh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_dslh_CellClick);
            // 
            // btnprev1
            // 
            this.btnprev1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprev1.Location = new System.Drawing.Point(433, 599);
            this.btnprev1.Name = "btnprev1";
            this.btnprev1.Size = new System.Drawing.Size(81, 61);
            this.btnprev1.TabIndex = 47;
            this.btnprev1.Text = "<<";
            this.btnprev1.UseVisualStyleBackColor = true;
            this.btnprev1.Click += new System.EventHandler(this.btnprev1_Click);
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprev.Location = new System.Drawing.Point(509, 599);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(81, 61);
            this.btnprev.TabIndex = 48;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnNextLenght
            // 
            this.btnNextLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLenght.Location = new System.Drawing.Point(1087, 599);
            this.btnNextLenght.Name = "btnNextLenght";
            this.btnNextLenght.Size = new System.Drawing.Size(81, 61);
            this.btnNextLenght.TabIndex = 50;
            this.btnNextLenght.Text = ">>";
            this.btnNextLenght.UseVisualStyleBackColor = true;
            this.btnNextLenght.Click += new System.EventHandler(this.btnNextLenght_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1009, 599);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 61);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbPageClass
            // 
            this.lbPageClass.AutoSize = true;
            this.lbPageClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageClass.Location = new System.Drawing.Point(709, 619);
            this.lbPageClass.Name = "lbPageClass";
            this.lbPageClass.Size = new System.Drawing.Size(162, 20);
            this.lbPageClass.TabIndex = 51;
            this.lbPageClass.Text = "Trang 1/1 | 3 bản ghi";
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.AllowDrop = true;
            this.btnGetStudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGetStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetStudent.Location = new System.Drawing.Point(18, 599);
            this.btnGetStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetStudent.Name = "btnGetStudent";
            this.btnGetStudent.Size = new System.Drawing.Size(382, 50);
            this.btnGetStudent.TabIndex = 52;
            this.btnGetStudent.Text = "Xem danh sách sinh viên";
            this.btnGetStudent.UseVisualStyleBackColor = false;
            this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textGhiChu);
            this.groupBox1.Controls.Add(this.textTenLop);
            this.groupBox1.Controls.Add(this.textMaLop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textMaID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(386, 389);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // textGhiChu
            // 
            this.textGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textGhiChu.Location = new System.Drawing.Point(10, 315);
            this.textGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.textGhiChu.Name = "textGhiChu";
            this.textGhiChu.Size = new System.Drawing.Size(368, 24);
            this.textGhiChu.TabIndex = 6;
            // 
            // textTenLop
            // 
            this.textTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTenLop.Location = new System.Drawing.Point(11, 238);
            this.textTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.textTenLop.Name = "textTenLop";
            this.textTenLop.Size = new System.Drawing.Size(368, 24);
            this.textTenLop.TabIndex = 6;
            // 
            // textMaLop
            // 
            this.textMaLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMaLop.Location = new System.Drawing.Point(10, 158);
            this.textMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.textMaLop.Name = "textMaLop";
            this.textMaLop.Size = new System.Drawing.Size(368, 24);
            this.textMaLop.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ghi Chú :";
            // 
            // textMaID
            // 
            this.textMaID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMaID.Location = new System.Drawing.Point(10, 80);
            this.textMaID.Margin = new System.Windows.Forms.Padding(2);
            this.textMaID.Name = "textMaID";
            this.textMaID.Size = new System.Drawing.Size(368, 24);
            this.textMaID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lớp :";
            // 
            // maLop
            // 
            this.maLop.AutoSize = true;
            this.maLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLop.Location = new System.Drawing.Point(10, 124);
            this.maLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maLop.Name = "maLop";
            this.maLop.Size = new System.Drawing.Size(66, 18);
            this.maLop.TabIndex = 1;
            this.maLop.Text = "Mã Lớp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ID :";
            // 
            // UCQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lbPageClass);
            this.Controls.Add(this.btnNextLenght);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnprev1);
            this.Controls.Add(this.dvg_dslh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearchInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRefreshClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnGetStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCQuanLyLopHoc";
            this.Size = new System.Drawing.Size(1182, 754);
            this.Load += new System.EventHandler(this.UCQuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_dslh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnRefreshClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSearchInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dvg_dslh;
        private System.Windows.Forms.Button btnprev1;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnNextLenght;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbPageClass;
        private System.Windows.Forms.Button btnGetStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMaLop;
        private System.Windows.Forms.TextBox textMaID;
        private System.Windows.Forms.Label maLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGhiChu;
        private System.Windows.Forms.TextBox textTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
