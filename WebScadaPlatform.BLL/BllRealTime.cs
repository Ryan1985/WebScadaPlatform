using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScadaPlatform.DAL;

namespace WebScadaPlatform.BLL
{
    public class BllRealTime
    {
        public DataTable GetRealTimeData()
        {
            try
            {
                var sql = @"select * from RealTime";
                var dt = DataBase.GetDataSet(sql);
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }


    }
}
