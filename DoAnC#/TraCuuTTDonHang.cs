using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_
{
    public partial class TraCuuTTDonHang : Form
    {
        public TraCuuTTDonHang()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getCUSTOMER()
        {
            string query = string.Format("SELECT * FROM CUSTOMER");
            DataTable tb = kn.layDuLieu(query);
            dgvKH.DataSource = tb;
        }
        public void getCTHD(string sdt)
        {
            string query = string.Format("SELECT C.customerName as TenKhachHang, C.addresss as DiaChi, PX.id AS IdPhieuXuat, PX.sumMoney as TongTien, PX.dateOrder as NgayDat FROM CUSTOMER C JOIN PhieuXuat PX ON C.sdt = PX.sdtCustomer WHERE C.sdt = {0}", sdt);
            DataTable tb = kn.layDuLieu(query);
            dgvCTDH.DataSource = tb;
        }
        public void getSPDH(string mahd)
        {
            string query = string.Format("SELECT CT.id AS Id, CT.bookId as MaSach, CT.quantity as SoLuong, CT.price as Gia, PX.userId as MaKhachHang, PX.sumMoney as TongTien, PX.sdtCustomer as SoDienThoai, PX.dateOrder as NgayDat FROM chitietphieuxuat CT JOIN phieuxuat PX ON CT.maphieuxuat = PX.id WHERE PX.id = {0}", mahd);
            DataTable tb = kn.layDuLieu(query);
            dgvSPDH.DataSource = tb;
        }

        private void TraCuuTTDonHang_Load(object sender, EventArgs e)
        {
            getCUSTOMER();
        }

        private void tbKH_TextChanged(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM CUSTOMER where customerName like N'%{0}%'", tbKH.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvKH.DataSource = tb;
        }

        private void tbCTDH_TextChanged(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM Book where bookName like N'%{0}%'", tbCTDH.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvCTDH.DataSource = tb;
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                try
                {
                    getCTHD(dgvKH.Rows[r].Cells["sdt"].Value.ToString());
                }
                catch { }



            }
        }

        private void dgvCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                try
                {
                    getSPDH(dgvCTDH.Rows[r].Cells["IdPhieuXuat"].Value.ToString());
                }
                catch { }



            }
        }
    }
}
