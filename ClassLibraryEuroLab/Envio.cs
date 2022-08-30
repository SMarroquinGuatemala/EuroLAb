using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryEuroLab
{
    public class Envio
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();

        public int EnvioID()
        {
            Database namedDB = factory.Create("ProduccionCS");
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select max(EnvioID) from Envio");
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql.ToString());
            return (int)namedDB.ExecuteScalar(sqlCommand);
        }
            

        public DataTable GetDetalleTemporal()
        {
            Database namedDB = factory.Create("ProduccionCS");
            StringBuilder sql  = new StringBuilder();
            sql.AppendLine("select A.EnvioDetalle,  A.ProductoID,A.Cantidad,b.Nombre, ISNULL(C.Precio, B.Precio) Precio , A.Cantidad * ISNULL(C.Precio, B.Precio) SubTotal ");
            sql.AppendLine(" from EnvioDetalleTemporal a ");
            sql.AppendLine(" INNER JOIN Producto B ON B.ProductoID =A.ProductoID ");
            sql.AppendLine(" LEFT JOIN PrecioClienteProducto C ON C.ProductoID =B.ProductoID AND C.ClienteID=A.ClienteID ");
            sql.AppendLine(" WHERE A.Computadora =HOST_NAME()");
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql.ToString());
            return namedDB.ExecuteDataSet(sqlCommand).Tables[0];
        }

        public DataTable GetAllDetalle(int EnvioID)
        {
            Database namedDB = factory.Create("ProduccionCS");
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select A.EnvioDetalle,  A.ProductoID,A.Cantidad,c.Nombre, ISNULL(d.Precio, c.Precio) Precio , A.Cantidad* ISNULL(d.Precio, c.Precio) SubTotal from EnvioDetalle a");
            sql.AppendLine(" inner join Envio b on b.EnvioID =a.EnvioID");
            sql.AppendLine(" INNER JOIN Producto c ON c.ProductoID =a.ProductoID");
            sql.AppendLine(" LEFT JOIN PrecioClienteProducto d ON d.ProductoID =a.ProductoID AND d.ClienteID=b.ClienteID");
            sql.AppendLine(" WHERE A.EnvioID =@PEnvioID ");
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql.ToString());
            namedDB.AddInParameter(sqlCommand, "PEnvioID", DbType.Int32, EnvioID);
            return namedDB.ExecuteDataSet(sqlCommand).Tables[0];
        }

        public DataTable GetDataReportePorEnvio(int Envio)
        {
            Database namedDB = factory.Create("ProduccionCS");
            StringBuilder sql = new StringBuilder();            
            return namedDB.ExecuteDataSet("uspReporteEnvio", Envio).Tables[0];
        }

        public DataTable GetDataByKey(int EnvioID)
        {
            Database namedDB = factory.Create("ProduccionCS");
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select  EnvioID,Fecha,NumeroDeEnvio,ClienteID,VendedorID, b.DepartamentoID,a.MunicipioID,TipoDePagoID,a.Codigo from Envio a");
            sql.AppendLine(" left join Municipio b on b.MunicipioID=a.MunicipioID  where EnvioID =@PEnvioID");
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql.ToString());
            namedDB.AddInParameter(sqlCommand, "PEnvioID", DbType.Int32, EnvioID);
            return namedDB.ExecuteDataSet(sqlCommand).Tables[0];
        }

        public DataTable GetData(DateTime? dateFirst, DateTime? dateLast, int? ClienteID)
        {
            Database namedDB = factory.Create("ProduccionCS");
            StringBuilder sql = new StringBuilder();
            return namedDB.ExecuteDataSet("uspEnvios", dateFirst, dateLast, ClienteID).Tables[0];
        }

        public void SaveDetailTemporal(int ClienteID, int ProductoID, decimal Cantidad)
        {
            Database namedDB = factory.Create("ProduccionCS");
            string sql = "insert EnvioDetalleTemporal(ClienteID,ProductoID,Cantidad) VALUES (@PClienteID, @PProductoID,@PCantidad)";
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            namedDB.AddInParameter(sqlCommand, "PClienteID", DbType.Int32, ClienteID);
            namedDB.AddInParameter(sqlCommand, "PProductoID", DbType.Int32, ProductoID);
            namedDB.AddInParameter(sqlCommand, "PCantidad", DbType.Int32, Cantidad);
            namedDB.ExecuteNonQuery(sqlCommand);
        }

        public void SaveDetail(int ProductoID, decimal Cantidad, int EnvioID)
        {
            Database namedDB = factory.Create("ProduccionCS");            
            namedDB.ExecuteNonQuery("UPSaveDetalleEnvio", ProductoID, Cantidad, EnvioID);
        }

        public void DeleteDetail(int EnvioDetalle)
        {
            Database namedDB = factory.Create("ProduccionCS");
            string sql = "DELETE FROM EnvioDetalle WHERE EnvioDetalle= @PEnvioDetalle ";
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            namedDB.AddInParameter(sqlCommand, "PEnvioDetalle", DbType.Int32, EnvioDetalle);
            
            namedDB.ExecuteNonQuery(sqlCommand);
        }

        public void DeleteDetailTemporal(int EnvioDetalle, string Computadora)
        {
            Database namedDB = factory.Create("ProduccionCS");
            string sql = "DELETE FROM EnvioDetalleTemporal WHERE EnvioDetalle= @PEnvioDetalle AND Computadora =@PComputadora";
            System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            namedDB.AddInParameter(sqlCommand, "PEnvioDetalle", DbType.Int32, EnvioDetalle);
            namedDB.AddInParameter(sqlCommand, "PComputadora", DbType.String, Computadora);
            namedDB.ExecuteNonQuery(sqlCommand);
        }

        public int Save(DateTime fecha, int ClienteID, int? VendedorID, int? MunicipioID, int? TipoDePagoID, int? EnvioId, string Codigo= null)
        {
            Database db = factory.Create("ProduccionCS");
            return (int)db.ExecuteDataSet("uspSaveEnvio", fecha, ClienteID, VendedorID, MunicipioID, TipoDePagoID, Codigo, EnvioId).Tables[0].Rows[0]["NumeroEnvio"];
            //string sql = "insert EnvioDetalleTemporal(ProductoID,Cantidad) VALUES (@ProductoID,@PCantidad)";
            //System.Data.Common.DbCommand sqlCommand = namedDB.GetSqlStringCommand(sql);
            //namedDB.AddInParameter(sqlCommand, "ProductoID", DbType.String, ProductoID);
            //namedDB.AddInParameter(sqlCommand, "PCantidad", DbType.String, Cantidad);
            //namedDB.ExecuteNonQuery(sqlCommand);
        }


    }
}
