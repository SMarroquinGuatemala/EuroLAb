using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEuroLab
{
    public class Producto
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();

        public DataTable GetAll()
        {
            Database namedDB = factory.Create("ProduccionCS");
            string sql = "select  ProductoID,Codigo,Nombre,Precio from Producto";
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            return namedDB.ExecuteDataSet(sqlCommand).Tables[0];
        }

        public DataTable GetAllByGrupoProducto(int? grupoProducto)
        {
            Database namedDB = factory.Create("ProduccionCS");

            return namedDB.ExecuteDataSet("uspProducto", grupoProducto).Tables[0];
        }

        public DataTable GetAllByID(int ProductoID)
        {
            Database namedDB = factory.Create("ProduccionCS");

            return namedDB.ExecuteDataSet("uspProductoByID", ProductoID).Tables[0];
        }

        public void Save(string Codigo, string Nombre, decimal Precio,string Descripcion, int GrupoProductoID, int? ProductoID)
        {
            try
            {

            
            Database namedDB = factory.Create("ProduccionCS");

                namedDB.ExecuteNonQuery("uspSaveProducto",Codigo, Nombre, Precio, Descripcion, GrupoProductoID , ProductoID);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
