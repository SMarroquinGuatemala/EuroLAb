using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEuroLab
{
    public class PrecioClienteProducto
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();


        public void Save(int ClienteID, int ProductoID, decimal Precio)
        {
            try
            {
                Database namedDB = factory.Create("ProduccionCS");

                namedDB.ExecuteNonQuery("uspSavePrecioClienteProducto", ClienteID, ProductoID, Precio);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
