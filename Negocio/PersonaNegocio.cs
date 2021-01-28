using TiendaDeRopa.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PersonaNegocio
    {
        public static List<personas> GetAll()
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                return db.personas.ToList();
            }
        }

        //public static List<personas> GetPersonasPorId(int id)
        //{
        //    using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
        //    {
        //        return db.personas
        //    }
        //}
    }
}
