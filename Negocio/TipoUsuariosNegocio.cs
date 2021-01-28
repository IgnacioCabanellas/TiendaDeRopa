using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDeRopa.Datos;

namespace Negocio
{
    public class TipoUsuariosNegocio
    {

        public static List<tipos_usuarios> GetAll()
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                return db.tipos_usuarios.ToList();
            }
        }
    }
}
