using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hoangdhph31492_Csharp3_BT1.MODEL.Context;
using hoangdhph31492_Csharp3_BT1.MODEL.DomainClass;

namespace hoangdhph31492_Csharp3_BT1.CONTROLLER
{
    internal class XeMayRepository
    {
        DBContext _Context;
        public XeMayRepository()
        {
            _Context = new DBContext();
        }
        public List<XeMay> GetXeMays(string search)
        {
            if (search == null)
            {
                var data = _Context.XeMays.ToList();
                return data;
            }
            return _Context.XeMays.Where(xm => xm.Ma.StartsWith(search)|| xm.Ten.StartsWith(search)).ToList();
        }
        public LoaiXm GetLoaiXe(Guid id)
        {
            return _Context.LoaiXms.FirstOrDefault(lx => lx.Id == id);
        }
        public bool AddXM(XeMay xm)
        {
            if (xm == null)
            {
                return false;
            }
            else
            {
                xm.Id = Guid.NewGuid();
                _Context.Add(xm);
                _Context.SaveChanges();
                return true;
            }
        }
        public bool UpDaXM(XeMay xm)
        {
            if (xm == null)
            {
                return false;
            }
            else
            {
                
                _Context.Update(xm);
                _Context.SaveChanges();
                return true;
            }
        }
        public bool DelXM(XeMay xm)
        {
            if (xm == null)
            {
                return false;
            }
            else
            {
                
                _Context.Remove(xm);
                _Context.SaveChanges();
                return true;
            }
        }
    }
}
