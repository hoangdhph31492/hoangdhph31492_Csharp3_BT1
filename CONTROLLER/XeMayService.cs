using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hoangdhph31492_Csharp3_BT1.CONTROLLER;
using hoangdhph31492_Csharp3_BT1.MODEL.DomainClass;

namespace hoangdhph31492_Csharp3_BT1.CONTROLLER
{
    internal class XeMayService
    {
        XeMayRepository _respo;
        public XeMayService()
        {
            _respo = new XeMayRepository();
        }
        public string GetTenLoai(Guid id)
        {
            
            if (_respo.GetLoaiXe(id)==null)
            {
                return "không bắt đc!";
            }
            return _respo.GetLoaiXe(id).Ten;
        }
        public List<XeMay> GetXeMays(string input)
        {
            return _respo.GetXeMays(input);
        }
        public bool CheckTrung(XeMay xm)
        {
            foreach (var x in _respo.GetXeMays(null))
            {
                if (x.Ma.Equals(xm.Ma))
                {
                    return true;
                }
            }
            return false;
        }
        public void ThemXM(XeMay xm)
        {
            if (CheckTrung(xm))
            {
                MessageBox.Show("Mã xe đã tồn tại~!");
                return;
            }
            if (_respo.AddXM(xm))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        public void SuaXM(XeMay xm)
        {
            if (_respo.UpDaXM(xm))
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
        public void XoaXM(Guid id)
        {
            var obj = _respo.GetXeMays(null).FirstOrDefault(x => x.Id == id);
            if (_respo.DelXM(obj))
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
    }
}
