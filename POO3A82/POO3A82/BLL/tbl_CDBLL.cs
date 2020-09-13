using POO3A82.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A82.BLL
{
    class tbl_CDBLL
    {
        private DALBD daoBanco = new DALBD();

        public DataTable ListarCDs()
        {
            string sql = string.Format($@"select * from TBL_CD");
            return daoBanco.ExecutarConsulta(sql);
        }
    }
}
