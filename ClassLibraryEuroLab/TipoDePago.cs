using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEuroLab
{
     public class TipoDePago
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();

        public DataTable GetAll()
        {
            Database namedDB = factory.Create("ProduccionCS");
            string sql = "select  TipoDePagoID, Nombre from TipoDePago";
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            return namedDB.ExecuteDataSet(sqlCommand).Tables[0];
        }
    }
}
