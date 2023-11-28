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
    public partial class BCTK : Form
    {
        KetNoi kn = new KetNoi();
        public BCTK()
        {
            InitializeComponent();
        }
        public void GetKH()
        {
            string query = string.Format("SELECT C.sdt as SĐT, C.customerName as TenKhachHang, C.addresss as DiaChi, SUM(PX.sumMoney) as TongChiTieu FROM CUSTOMER C LEFT JOIN PhieuXuat PX ON C.sdt = PX.sdtCustomer GROUP BY C.sdt, C.customerName, C.addresss ORDER BY SUM(PX.sumMoney) DESC");
            DataTable tb = kn.layDuLieu(query);
            dgv.DataSource = tb;
        }
        public void GetNV()
        {
            string query = string.Format("SELECT us.fullName as TenNhanVien, us.email as Email,SUM(px.sumMoney) As DoanhThuKiemDuoc FROM PhieuXuat px JOIN USERS us ON px.userId = us.id group by us.fullName,us.email, px.userId ORDER BY SUM(px.sumMoney) DESC");
            DataTable tb = kn.layDuLieu(query);
            dgv.DataSource = tb;
        }
        public void GetBook()
        {
            string query = string.Format("SELECT B.bookName as TenSach, B.priceSale as Gia, CTPX.quantity as SoLuong, CTPX.quantity*B.priceSale As Tong FROM chitietphieuxuat CTPX JOIN BOOK B ON CTPX.bookId = B.id ORDER BY CTPX.quantity*B.priceSale DESC");
            DataTable tb = kn.layDuLieu(query);
            dgv.DataSource = tb;
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BCTK_Load_1(object sender, EventArgs e)
        {
            if (cBox.Text == "Sách bán chạy")
            {
                GetBook();
            }
            else if (cBox.Text == "Nhân viên xuất sắc")
            {
                GetNV();
            }
            else if (cBox.Text == "Khách hàng Vip")
            {
                GetKH();
            }
        }

        private void cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BCTK_Load_1(sender,e);
        }
        //public void getData()
        //{
        //    string lb1 = kn.layBien("SELECT TOP 1 B.bookName FROM chitietphieuxuat CTPX JOIN BOOK B ON CTPX.bookId = B.id ORDER BY CTPX.quantity DESC");
        //    MessageBox.Show(lb1);
        //    label1.Text = lb1;

        //}
    }
}
