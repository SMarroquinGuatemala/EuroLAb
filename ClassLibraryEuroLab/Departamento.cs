using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEuroLab
{
    public class Departamento
    {

        DatabaseProviderFactory factory = new DatabaseProviderFactory();

        public DataTable GetDepartamentos()
        {
            Database namedDB = factory.Create("ProduccionCS");
            string sql = "select DepartamentoID,  Codigo,Nombre from Departamento";
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            return namedDB.ExecuteDataSet(sqlCommand).Tables[0];
        }

    }
}
