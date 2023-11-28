namespace DoAnC_
{
    partial class TraCuuTTDonHang
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
            groupBox1 = new GroupBox();
            dgvKH = new DataGridView();
            label1 = new Label();
            tbKH = new TextBox();
            groupBox2 = new GroupBox();
            dgvCTDH = new DataGridView();
            label2 = new Label();
            tbCTDH = new TextBox();
            groupBox3 = new GroupBox();
            dgvSPDH = new DataGridView();
            label3 = new Label();
            tbSPDH = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTDH).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSPDH).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvKH);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbKH);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // dgvKH
            // 
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new Point(0, 77);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 51;
            dgvKH.Size = new Size(519, 267);
            dgvKH.TabIndex = 3;
            dgvKH.CellClick += dgvKH_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // tbKH
            // 
            tbKH.Location = new Point(372, 26);
            tbKH.Name = "tbKH";
            tbKH.Size = new Size(125, 27);
            tbKH.TabIndex = 1;
            tbKH.TextChanged += tbKH_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCTDH);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbCTDH);
            groupBox2.Location = new Point(543, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 350);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết phiếu xuất";
            // 
            // dgvCTDH
            // 
            dgvCTDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTDH.Location = new Point(6, 77);
            dgvCTDH.Name = "dgvCTDH";
            dgvCTDH.RowHeadersWidth = 51;
            dgvCTDH.Size = new Size(371, 267);
            dgvCTDH.TabIndex = 3;
            dgvCTDH.CellClick += dgvCTDH_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 29);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Tìm kiếm";
            // 
            // tbCTDH
            // 
            tbCTDH.Location = new Point(237, 26);
            tbCTDH.Name = "tbCTDH";
            tbCTDH.Size = new Size(125, 27);
            tbCTDH.TabIndex = 1;
            tbCTDH.TextChanged += tbCTDH_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSPDH);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(tbSPDH);
            groupBox3.Location = new Point(932, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(322, 350);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết phiếu xuất";
            // 
            // dgvSPDH
            // 
            dgvSPDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSPDH.Location = new Point(6, 77);
            dgvSPDH.Name = "dgvSPDH";
            dgvSPDH.RowHeadersWidth = 51;
            dgvSPDH.Size = new Size(310, 267);
            dgvSPDH.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 29);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Tìm kiếm";
            // 
            // tbSPDH
            // 
            tbSPDH.Location = new Point(145, 26);
            tbSPDH.Name = "tbSPDH";
            tbSPDH.Size = new Size(125, 27);
            tbSPDH.TabIndex = 1;
            // 
            // TraCuuTTDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 605);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TraCuuTTDonHang";
            Text = "TraCuuTTDonHang";
            Load += TraCuuTTDonHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTDH).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSPDH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox tbKH;
        private TextBox tbCTDH;
        private TextBox tbSPDH;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvKH;
        private DataGridView dgvCTDH;
        private DataGridView dgvSPDH;
    }
}