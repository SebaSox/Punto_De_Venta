using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private string codigo = "";
        private string producto = "";
        private string precioXUnidad = "";
        private string cantidad = "";
        private string descuento = "";
        private string precioTotal = "";
        private string subTotal = "";
        private string cliente = "";
        private string total = "";
        private string numFact = "";

        public string Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public string PrecioXUnidad { get => precioXUnidad; set => precioXUnidad = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string SubTotal { get => subTotal; set => subTotal = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Total { get => total; set => total = value; }
        public string NumFact { get => numFact; set => numFact = value; }
    }
}
