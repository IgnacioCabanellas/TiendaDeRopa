using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa.Datos
{
    public class ProductosDatos
    {
        
        public static productos GetOne(int id)
        {
            using (DB_NegocioDeRopaEntities DB = new DB_NegocioDeRopaEntities())
            {
                return DB.productos.FirstOrDefault(p => p.idProducto == id);
            }
        }

        public static void Insert(productos prod)
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                var tipo = db.tipos_productos.FirstOrDefault(x => x.idTipoProducto == prod.idTipoProducto);
                prod.tipos_productos = tipo;

                db.productos.Add(prod);

                db.SaveChanges();
            }
        }

        public static void Modificar(productos prod)
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                productos productoEncontrado = db.productos.FirstOrDefault(x => x.idProducto == prod.idProducto);

                productoEncontrado.stock = prod.stock;
                productoEncontrado.precio = prod.precio;
                productoEncontrado.descripcion = prod.descripcion;

                db.SaveChanges();

            }
        }

        public static void Eliminar(productos prod)
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                productos productoEncontrado = db.productos.FirstOrDefault(x => x.idProducto == prod.idProducto);

                db.productos.Remove(productoEncontrado);

                db.SaveChanges();
            }
        }

        //public static List<productos> GetAll()
        //{

        //    //using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
        //    //{
        //    //    List<productos> prods = db.productos.Select(p => new { p.idProducto, p.descripcion, p.stock, p.precio, p.idTipoProducto }).ToList();


        //    //    return prods;
        //    //}

        //    //using (DB_NegocioDeRopaEntities db =  new DB_NegocioDeRopaEntities())
        //    //{
        //    //    return db.productos.ToList();
        //    //}


        //    //using (DB_NegocioDeRopaEntities context = new DB_NegocioDeRopaEntities())
        //    //{
        //    //    return (from p in context.productos
        //    //            select new productos
        //    //            {
        //    //                idProducto = p.idProducto,
        //    //                descripcion = p.descripcion,
        //    //                stock = p.stock,
        //    //                precio = p.precio,
        //    //                idTipoProducto = p.idTipoProducto
        //    //            }).ToList();
        //    //}
        //}
    }
}
