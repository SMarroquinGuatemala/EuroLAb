using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEuroLab
{
    public class Cliente
    {
        
        DatabaseProviderFactory factory = new DatabaseProviderFactory();

        public DataTable GetAll(int? DepartamentoID, int? MunicipioID)
        {
            try
            {           
            Database namedDB = factory.Create("ProduccionCS");            
            return namedDB.ExecuteDataSet("uspCliente", DepartamentoID, MunicipioID).Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetAll()
        {
            try
            {
                Database namedDB = factory.Create("ProduccionCS");
                return namedDB.ExecuteDataSet("uspCliente", null,null).Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetAllByID(int clienteID)
        {
            try
            {          
            Database namedDB = factory.Create("ProduccionCS");
            return namedDB.ExecuteDataSet("uspClienteByID", clienteID).Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(string Nombres, string Apellidos, string NIT, string Telefono, string Direccion, int DepartamentoID, int MunicipioID , int? ClienteID)
        {
            try
            {


                Database namedDB = factory.Create("ProduccionCS");

                namedDB.ExecuteNonQuery("uspSaveCliente", Nombres, Apellidos, NIT, Telefono, Direccion, MunicipioID, ClienteID);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
