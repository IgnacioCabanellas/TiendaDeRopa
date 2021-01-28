using TiendaDeRopa.Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductosNegocio
    {

        public static productos GetOne(int id)
        {
            return ProductosDatos.GetOne(id);
        }

        public static void Insert(productos prod)
        {
            ProductosDatos.Insert(prod);
        }

        public static void Modificar(productos prod)
        {
            ProductosDatos.Modificar(prod);
        }

        public static void Eliminar(productos prod)
        {
            ProductosDatos.Eliminar(prod);
        }

        //public static List<productos> GetAll()
        //{
        //    return ProductosDatos.GetAll();
        //}
    }
}
