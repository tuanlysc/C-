namespace DoAnC_
{
    partial class BCTK
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
            dgv = new DataGridView();
            cBox = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 73);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(668, 206);
            dgv.TabIndex = 3;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // cBox
            // 
            cBox.FormattingEnabled = true;
            cBox.Items.AddRange(new object[] { "Sách bán chạy", "Nhân viên xuất sắc", "Khách hàng Vip" });
            cBox.Location = new Point(209, 39);
            cBox.Name = "cBox";
            cBox.Size = new Size(151, 28);
            cBox.TabIndex = 4;
            cBox.SelectedIndexChanged += cBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 42);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Sắp xếp theo";
            // 
            // BCTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 468);
            Controls.Add(label2);
            Controls.Add(cBox);
            Controls.Add(dgv);
            Name = "BCTK";
            Text = "BCTK";
            Load += BCTK_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv;
        private ComboBox cBox;
        private Label label2;
    }
}