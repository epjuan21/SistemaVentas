using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Conexion
{
    public class Conexion: DataConnection
    {
        public Conexion(): base("PDHN2")
        {

        }

        public ITable<TClientes> TClientes { get { return GetTable<TClientes>(); } }
        public ITable<TReportesClientes> TReportesClientes { get { return GetTable<TReportesClientes>(); } }
    }
}
