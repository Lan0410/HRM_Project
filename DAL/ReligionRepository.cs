using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class ReligionRepository : IReligionRepository
    {
        private IDatabaseHelper _dbHelper;
        public ReligionRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public bool Create(Religion model)
        {
            throw new NotImplementedException();
        }

        public List<Religion> GetData()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_religion_get_data ");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<Religion>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
       
    
}
