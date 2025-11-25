using Sistema_Ventas_Inventario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas_Inventario.Vistas
{
    public partial class FormProductos : Form
    {
        public byte[] imagenProductoBytes { get; set; }
        MetodosProductos metodosProductos;
        DataTable datos;


        public FormProductos()
        {
            InitializeComponent();
            metodosProductos = new MetodosProductos();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
            this.MostrarProveedores(cbProveedores);
            this.MostrarProveedores(cbActProveedores);

            
        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Filter = "Imágenes|*.jpg;*.png;*.jpeg";

    if (ofd.ShowDialog() == DialogResult.OK)
    {
        Image img = Image.FromFile(ofd.FileName);
        pbImagenProducto1.Image = img;
        pbImagenProducto2.Image = img;

        // Convertir imagen a byte[]
        using (MemoryStream ms = new MemoryStream())
        {
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imagenProductoBytes = ms.ToArray();  // se guarda para enviarla a SQL
        }
    }
}

        public void MostrarProductos()
        {
            metodosProductos = new MetodosProductos();
            datos = metodosProductos.ObtenerProductos();
            FormatoTablaProductos(datos);
        }

        public void FormatoTablaProductos(DataTable datos)
        {
            try
            {
                datos.Columns["idProducto"].ColumnName = "ID";
                datos.Columns["nomProducto"].ColumnName = "PRODUCTO";
                datos.Columns["idProveedor"].ColumnName = "ID PROVEEDOR";
                datos.Columns["nomProveedor"].ColumnName = "PROVEEDOR";
                datos.Columns["descripcion"].ColumnName = "DESCRIPCION";
                datos.Columns["stock"].ColumnName = "STOCK";
                datos.Columns["precio"].ColumnName = "PRECIO";

                DGVProductos.DataSource = datos;
                DGVProductos.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["PRODUCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["ID PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["DESCRIPCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["STOCK"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["PRECIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // --- MÉTODO MODIFICADO: enlaza el ComboBox al listado de Proveedores ---
        private void MostrarProveedores(ComboBox cbProveedores)
        {
            try
            {
                cbProveedores.DataSource = null;
                metodosProductos = new MetodosProductos();

                List<Proveedor> lista = metodosProductos.ObtenerProveedores() ?? new List<Proveedor>();

                if (lista.Count == 0)
                {
                    MessageBox.Show("Aviso: no se obtuvieron proveedores (lista vacía). Comprueba la conexión y el SP ObtenerProveedores.", "Diagnóstico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // placeholder + datos reales
                var listaConPlaceholder = new List<Proveedor> { new Proveedor(0, "Selecciona una opción") };
                listaConPlaceholder.AddRange(lista);

                // establecer Display/Value antes de asignar DataSource evita problemas de refresco
                cbProveedores.DisplayMember = "nomProveedor";
                cbProveedores.ValueMember = "idProveedor";
                cbProveedores.DataSource = listaConPlaceholder;
                cbProveedores.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idProducto = tbIdProducto.Text.Trim();
            string nomProducto = tbNomProducto.Text.Trim();
            string stock = tbStock.Text.Trim();
            string precio = tbPrecio.Text.Trim();
            string descripcion = tbDescripcion.Text.Trim();

            // Usar SelectedValue (ValueMember) en lugar de parsear SelectedItem
            if (cbProveedores.SelectedValue == null || Convert.ToInt32(cbProveedores.SelectedValue) == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
                return;
            }

            string idProveedor = cbProveedores.SelectedValue.ToString();

            Producto nuevoProducto = new Producto(idProducto, nomProducto, stock, precio, descripcion, idProveedor);

            string resultado = metodosProductos.ValidarProducto(nuevoProducto);

            if (resultado.Equals("OK"))
            {
                resultado = metodosProductos.AgregarProducto(nuevoProducto);


            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos?.Reset();
            this.MostrarProductos();
            nuevoProducto = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idProducto = tbActIdProducto.Text.Trim();
            string nomProducto = tbActNomProducto.Text.Trim();
            string stock = tbActStock.Text.Trim();
            string precio = tbActPrecio.Text.Trim();
            string descripcion = tbActDescripcion.Text.Trim();

            if (cbActProveedores.SelectedValue == null || Convert.ToInt32(cbActProveedores.SelectedValue) == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
                return;
            }

            string idProveedor = cbActProveedores.SelectedValue.ToString();

            Producto actualizarProducto = new Producto(idProducto, nomProducto, stock, precio, descripcion, idProveedor);
            string resultado = metodosProductos.ValidarProducto(actualizarProducto);
            if (resultado.Equals("OK"))
            {
                resultado = metodosProductos.ActualizarProducto(actualizarProducto);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos?.Reset();
            this.MostrarProductos();
            actualizarProducto = null;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.datos?.Reset();
            metodosProductos = new MetodosProductos();
            datos = metodosProductos.BuscarProducto(tbBuscarProducto.Text.Trim());
            FormatoTablaProductos(datos);
            LimpiarCampos();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos?.Reset();
            this.MostrarProductos();
        }

        private void LimpiarCampos()
        {
            tbIdProducto.Text = "";
            tbNomProducto.Text = "";
            tbStock.Text = "";
            tbPrecio.Text = "";
            tbDescripcion.Text = "";

            // Si el Combo está enlazado mediante DataSource -> seleccionar la opción 0
            if (cbProveedores.DataSource != null)
                cbProveedores.SelectedIndex = 0;
            else
                cbProveedores.SelectedItem = "Selecciona una opción";
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                tbActIdProducto.Text = DGVProductos.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim();
                tbActNomProducto.Text = DGVProductos.Rows[e.RowIndex].Cells["PRODUCTO"].Value.ToString().Trim();
                tbActStock.Text = DGVProductos.Rows[e.RowIndex].Cells["STOCK"].Value.ToString().Trim();
                tbActPrecio.Text = DGVProductos.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString().Trim();
                tbActDescripcion.Text = DGVProductos.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString().Trim();

                // Seleccionar el proveedor correcto por SelectedValue (ValueMember = idProveedor)
                string idProv = DGVProductos.Rows[e.RowIndex].Cells["ID PROVEEDOR"].Value.ToString().Trim();
                int idProvInt;
                if (int.TryParse(idProv, out idProvInt) && cbActProveedores.DataSource != null)
                {
                    cbActProveedores.SelectedValue = idProvInt;
                }
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario IR = new Inventario();
            IR.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIPrincipal IR = new MDIPrincipal();
            IR.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var mdi = Application.OpenForms.OfType<MDIPrincipal>().FirstOrDefault();
            if (mdi != null)
            {
                mdi.SetUsuarioLabel(); // asegúrate que muestre el usuario actual
                mdi.Show();
            }
            else
            {
                // si no existe, crear uno nuevo (Sesión ya contiene el nombre)
                mdi = new MDIPrincipal();
                mdi.Show();
            }
            this.Close();
        }
    }
}