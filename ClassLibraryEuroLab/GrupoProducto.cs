using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEuroLab
{
    public class GrupoProducto
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public DataTable GetAll()
        {
            Database namedDB = factory.Create("ProduccionCS");          
            return namedDB.ExecuteDataSet("uspGrupoProducto").Tables[0];
        }
    }
}
