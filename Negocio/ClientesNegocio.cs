using TiendaDeRopa.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClientesNegocio
    {

        public static List<usuarios> GetAll()
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                return db.usuarios.ToList();
            }
        }

        
    }
}
