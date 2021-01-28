using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDeRopa.Datos;

namespace Negocio
{
    public class TiposProductosNegocio
    {
        static public void Insert(tipos_productos tp)
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                db.tipos_productos.Add(tp);
                db.SaveChanges();
            }
        }

        static public List<tipos_productos> GetAll()
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                return db.tipos_productos.ToList();
            }
        }
    }
}
