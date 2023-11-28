namespace DoAnC_
{
    partial class ADMIN
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
            menuStrip1 = new MenuStrip();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            tácGiảToolStripMenuItem = new ToolStripMenuItem();
            nhàXuấtBảnToolStripMenuItem = new ToolStripMenuItem();
            sáchToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            traCứuĐơnHàngToolStripMenuItem = new ToolStripMenuItem();
            báoCáoThốngKêToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, danhMụcToolStripMenuItem, tácGiảToolStripMenuItem, nhàXuấtBảnToolStripMenuItem, sáchToolStripMenuItem, phiếuNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, traCứuĐơnHàngToolStripMenuItem, báoCáoThốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1530, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(89, 24);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            danhMụcToolStripMenuItem.Click += danhMụcToolStripMenuItem_Click;
            // 
            // tácGiảToolStripMenuItem
            // 
            tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            tácGiảToolStripMenuItem.Size = new Size(69, 24);
            tácGiảToolStripMenuItem.Text = "Tác giả";
            tácGiảToolStripMenuItem.Click += tácGiảToolStripMenuItem_Click;
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            nhàXuấtBảnToolStripMenuItem.Size = new Size(111, 24);
            nhàXuấtBảnToolStripMenuItem.Text = "Nhà xuất bản";
            nhàXuấtBảnToolStripMenuItem.Click += nhàXuấtBảnToolStripMenuItem_Click;
            // 
            // sáchToolStripMenuItem
            // 
            sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            sáchToolStripMenuItem.Size = new Size(54, 24);
            sáchToolStripMenuItem.Text = "Sách";
            sáchToolStripMenuItem.Click += sáchToolStripMenuItem_Click;
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            phiếuNhậpToolStripMenuItem.Size = new Size(96, 24);
            phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            phiếuNhậpToolStripMenuItem.Click += phiếuNhậpToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(91, 24);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // traCứuĐơnHàngToolStripMenuItem
            // 
            traCứuĐơnHàngToolStripMenuItem.Name = "traCứuĐơnHàngToolStripMenuItem";
            traCứuĐơnHàngToolStripMenuItem.Size = new Size(138, 24);
            traCứuĐơnHàngToolStripMenuItem.Text = "Tra cứu đơn hàng";
            traCứuĐơnHàngToolStripMenuItem.Click += traCứuĐơnHàngToolStripMenuItem_Click;
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            báoCáoThốngKêToolStripMenuItem.Size = new Size(139, 24);
            báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            báoCáoThốngKêToolStripMenuItem.Click += báoCáoThốngKêToolStripMenuItem_Click;
            // 
            // ADMIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 915);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem tácGiảToolStripMenuItem;
        private ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem traCứuĐơnHàngToolStripMenuItem;
        private ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
    }
}