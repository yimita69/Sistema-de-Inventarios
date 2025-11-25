using Sistema_Ventas_Inventario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas_Inventario.Clases
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string nomProveedor { get; set; }
        public string numContacto { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }

        public Proveedor(int idProveedor, string nomProveedor)
        {
            this.idProveedor = idProveedor;
            this.nomProveedor = nomProveedor;
        }

        public Proveedor(int idProveedor, string nomProveedor, string numContacto, string direccion, string email)
        {
            this.idProveedor = idProveedor;
            this.nomProveedor = nomProveedor;
            this.numContacto = numContacto;
            this.direccion = direccion;
            this.email = email;
        }

        public Proveedor(string nomProveedor, string numContacto, string direccion, string email)
        {
            this.nomProveedor = nomProveedor;
            this.numContacto = numContacto;
            this.direccion = direccion;
            this.email = email;
        }
    }
}