using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class ReligionBusiness:IReligionBusiness
    {
        private IReligionRepository _res;
        public ReligionBusiness(IReligionRepository ReligionRes)
        {
            _res = ReligionRes;
        }

        public List<Religion> GetData()
        {
            var allReligion = _res.GetData();
            var lst = allReligion.ToList();
            return lst;
            
        }
        //public List<Religion> GetHiearchyList(List<Religion> lstAll, Religion node)
        //{
        //    var lstChilds = lstAll.Where(ds => ds.parent_item_group_id == node.item_group_id).ToList();
        //    if (lstChilds.Count == 0)
        //        return null;
        //    for (int i = 0; i < lstChilds.Count; i++)
        //    {
        //        var childs = GetHiearchyList(lstAll, lstChilds[i]);
        //        lstChilds[i].type = (childs == null || childs.Count == 0) ? "leaf" : "";
        //        lstChilds[i].children = childs;
        //    }
        //    return lstChilds.OrderBy(s => s.seq_num).ToList();
        //}

        //List<Religion> IReligionBusiness.GetData()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
