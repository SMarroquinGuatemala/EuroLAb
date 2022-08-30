using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEuroLab
{
    public class Municipio
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();

        public DataTable GetAll()
        {
            Database namedDB = factory.Create("ProduccionCS");
            string sql = "select MunicipioID, Codigo,Nombre from Municipio";
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            return namedDB.ExecuteDataSet(sqlCommand).Tables[0];
        }

        public DataTable GetAllByDepartamento(int DepartamentoID)
        {
            Database namedDB = factory.Create("ProduccionCS");
            string sql = "select MunicipioID, Codigo,Nombre from Municipio WHERE DepartamentoID=@DepartamentoID";            
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            namedDB.AddInParameter(sqlCommand, "DepartamentoID", DbType.String, DepartamentoID);
            return namedDB.ExecuteDataSet(sqlCommand).Tables[0];
        }


    }
}
