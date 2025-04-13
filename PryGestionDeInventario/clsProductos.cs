using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryGestionDeInventario
{
    public class clsProductos
    {
        public List<clsProducto> lstProductos;

        public clsProductos()
        {
            lstProductos = new List<clsProducto>();
        }

        public void agregarProducto(clsProducto nuevo)
        {
            lstProductos.Add(nuevo);
        }

    }
}
