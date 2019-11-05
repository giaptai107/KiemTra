namespace Kiemtra
{
    partial class frmQuanLyDanhBa
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
            this.components = new System.ComponentModel.Container();
            this.dgvNhom = new System.Windows.Forms.DataGridView();
            this.tenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhba = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.btnXoaNhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemLienLac = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLienLac = new System.Windows.Forms.ToolStripButton();
            this.tbTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bdsNhom = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDanhba = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhba)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhba)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhom
            // 
            this.dgvNhom.AllowUserToAddRows = false;
            this.dgvNhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhom.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhom});
            this.dgvNhom.Location = new System.Drawing.Point(8, 28);
            this.dgvNhom.Name = "dgvNhom";
            this.dgvNhom.Size = new System.Drawing.Size(239, 345);
            this.dgvNhom.TabIndex = 0;
            this.dgvNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhom_CellClick);
            this.dgvNhom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhom_CellContentClick);
            // 
            // tenNhom
            // 
            this.tenNhom.DataPropertyName = "TenNhom";
            this.tenNhom.HeaderText = "Tên nhóm";
            this.tenNhom.Name = "tenNhom";
            // 
            // dgvDanhba
            // 
            this.dgvDanhba.AllowUserToAddRows = false;
            this.dgvDanhba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhba.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDanhba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colEmail,
            this.colSdt});
            this.dgvDanhba.Location = new System.Drawing.Point(256, 28);
            this.dgvDanhba.Name = "dgvDanhba";
            this.dgvDanhba.Size = new System.Drawing.Size(514, 172);
            this.dgvDanhba.TabIndex = 0;
            this.dgvDanhba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenGoi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên gọi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colSdt
            // 
            this.colSdt.DataPropertyName = "Sdt";
            this.colSdt.HeaderText = "Số điện thoại";
            this.colSdt.Name = "colSdt";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.btnXoaNhom,
            this.toolStripSeparator1,
            this.btnThemLienLac,
            this.btnXoaLienLac,
            this.tbTimKiem,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = global::Kiemtra.Properties.Resources.iconfinder_sign_add_299068;
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(92, 22);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.BtnThemNhom_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = global::Kiemtra.Properties.Resources.iconfinder_f_cross_256_282471;
            this.btnXoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(82, 22);
            this.btnXoaNhom.Text = "Xóa nhóm";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = global::Kiemtra.Properties.Resources.iconfinder_sign_add_299068;
            this.btnThemLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(97, 22);
            this.btnThemLienLac.Text = "Thêm liên lạc";
            // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Image = global::Kiemtra.Properties.Resources.iconfinder_f_cross_256_282471;
            this.btnXoaLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(87, 22);
            this.btnXoaLienLac.Text = "Xóa liên lạc";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Nhập từ cần tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "[Tên gọi]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại:";
            // 
            // frmQuanLyDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDanhba);
            this.Controls.Add(this.dgvNhom);
            this.Name = "frmQuanLyDanhBa";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhba)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhom;
        private System.Windows.Forms.DataGridView dgvDanhba;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripButton btnXoaNhom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnThemLienLac;
        private System.Windows.Forms.ToolStripButton btnXoaLienLac;
        private System.Windows.Forms.ToolStripTextBox tbTimKiem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bdsNhom;
        private System.Windows.Forms.BindingSource bdsDanhba;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdt;
    }
}

