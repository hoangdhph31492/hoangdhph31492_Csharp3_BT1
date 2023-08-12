using hoangdhph31492_Csharp3_BT1.CONTROLLER;
using hoangdhph31492_Csharp3_BT1.MODEL.DomainClass;
using System.Text.RegularExpressions;

namespace hoangdhph31492_Csharp3_BT1
{
    public partial class Form1 : Form
    {
        Guid _idWhenClick;
        XeMayRepository _respo = new XeMayRepository();
        XeMayService _service = new XeMayService();
        public Form1()
        {
            InitializeComponent();
            loadcmbx();
            loadGridView(null);
        }
        public void loadcmbx()
        {

            cmbSL.Items.Add("Từ 1 đến 100");
            for (int i = 0; i < 100; i++)
            {
                cmbSL.Items.Add(i + 1);
            }
            cmbSL.SelectedIndex = 0;
        }
        public void loadGridView(string input)
        {
            int stt = 1;
            Type type = typeof(XeMay);
            dtgXe.ColumnCount = type.GetProperties().Length + 1;
            dtgXe.Columns[0].Name = "ID";
            dtgXe.Columns[1].Name = "Stt";
            dtgXe.Columns[2].Name = "Tên xe";
            dtgXe.Columns[3].Name = "Mô tả";
            dtgXe.Columns[4].Name = "Số lượng";
            dtgXe.Columns[5].Name = "Giá nhập";
            dtgXe.Columns[6].Name = "Tên loại xe";
            dtgXe.Rows.Clear();
            foreach (var x in _respo.GetXeMays(input))
            {

                dtgXe.Rows.Add(x.Id, stt++, x.Ten, x.Mt, x.Sl, x.Gia,x.IdLsp!=null? _respo.GetLoaiXe((Guid)x.IdLsp).Ten:"Hangf giả");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XeMay obj = new XeMay();
            obj.Ten = txtTen.Text;
            obj.Mt = txtMT.Text;
            obj.Sl = int.Parse(cmbSL.SelectedItem.ToString());
            obj.Gia = int.Parse(txtGia.Text);
            _service.ThemXM(obj);
            loadGridView(null);
        }

        private void dtgXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if ( rowIndex < 0)
            {
                return;
            }
            else
            {
                _idWhenClick = Guid.Parse(dtgXe.Rows[rowIndex].Cells[0].Value.ToString());
            }
            var obj = _service.GetXeMays(null).FirstOrDefault(x => x.Id == _idWhenClick);
            txtTen.Text = obj.Ten;
            txtGia.Text = obj.Gia.ToString();
            txtMT.Text = obj.Mt;
            cmbSL.SelectedItem = obj.Sl;
        }
        public void CheckGia(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
        }


        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckGia(e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _service.XoaXM(_idWhenClick);
            loadGridView(null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGia.Text = null; txtMT.Text = null;
            txtTen.Text = null; txtTim.Text = null;
            cmbSL.Items[0] = "Từ 1 đến 100";
            cmbSL.SelectedIndex = 0;

        }

        private void cmbSL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSL_Click(object sender, EventArgs e)
        {
            cmbSL.Items[0] = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            loadGridView(txtTim.Text);
            _respo.GetXeMays(txtTim.Text);
        }
    }
}
