using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Ventas_Inventario.Clases;
using System.Runtime.InteropServices;

namespace Sistema_Ventas_Inventario.Vistas
{
    public partial class FormUsuarios : Form
    {
        MetodosUsuario metodosUsuario;
        DataTable datos;
        int idUsuario = 0;

        public FormUsuarios()
        {
            InitializeComponent();
            metodosUsuario = new MetodosUsuario();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            this.BtnMostrarUsuarios();
            this.MostrarPermisos(cbPermisos);
            this.MostrarPermisos(cbActPermisos);
            this.MostrarEstados(cbEstados);
            this.MostrarEstados(cbActEstados);

            // Aplicar esquinas redondeadas a todos los TextBox del formulario
            ApplyRoundedToTextBoxes(this.Controls, 10);

            // Aplicar estilo a todos los botones (sin fondo/borde y hover azul)
            ApplyStyleToButtons(this.Controls);

            // Aplicar esquinas redondeadas a todos los botones (incluye el botón "volver")
            ApplyRoundedToButtons(this.Controls, 10);

            // Si existe un botón llamado "btnVolver" lo conectamos a su manejador (seguro si lo añadiste en el diseñador)
            var volverBtn = this.Controls.Find("btnVolver", true).FirstOrDefault() as Button;
            if (volverBtn != null)
            {
                volverBtn.Click -= BtnVolver_Click;
                volverBtn.Click += BtnVolver_Click;
            }
        }

        private void BtnMostrarUsuarios()
        {
            MessageBox.Show("Cargando usuarios...");
        }

        private void MostrarPermisos(ComboBox cbPermisos)
        {
            List<Permiso> datos = metodosUsuario.ObtenerPermisos();
            cbPermisos.Items.Add("Seleccione una opción");
            foreach (Permiso dato in datos)
            {
                cbPermisos.Items.Add(dato.permiso);
            }
            cbPermisos.SelectedIndex = 0;
        }

        private void MostrarEstados(ComboBox cbEstados)
        {
            List<Estado> datos = metodosUsuario.ObtenerEstados();
            cbEstados.Items.Add("Seleccione una opción");
            foreach (Estado dato in datos)
            {
                cbEstados.Items.Add((dato.estado + 1).ToString() + " - " + dato.descripcion);

            }
            cbEstados.SelectedIndex = 0;
        }

        public void MostrarUsuarios()
        {
            metodosUsuario  = new MetodosUsuario();
            datos = metodosUsuario.ObtenerUsuarios();
            FormatoTablaUsuarios(datos);
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            //this.datos.Reset();
            this.MostrarUsuarios();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nomUsuario = tbNombre.Text.Trim();
            string usuario = tbUsuario.Text.Trim();
            string contrasena = tbContrasena.Text.Trim();

            if (cbPermisos.SelectedIndex <= 0 || cbEstados.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecciona un permiso y un estado válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPermiso = cbPermisos.SelectedIndex;
            int idEstado = cbEstados.SelectedIndex;

            Usuario nuevoUsuario = new Usuario(nomUsuario, usuario, contrasena, idPermiso, idEstado);

            string resultado = metodosUsuario.AgregarUsuario(nuevoUsuario);
            MessageBox.Show(resultado);

            // Inicializa this.datos si es null
            if (this.datos == null)
                this.datos = new DataTable();

            this.datos.Reset();   // Ahora sí no dará error
            LimpiarCampos();
            this.MostrarUsuarios();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            if (idUsuario == 0)
            {
                MessageBox.Show("Selecciona un usuario antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            
            string nomUsuario = tbActNombre.Text.Trim();
            string usuario = tbActUsuario.Text.Trim();
            string contrasena = tbActContrasena.Text.Trim();
            int idPermiso = cbActPermisos.SelectedIndex;
            int idEstado = cbActEstados.SelectedIndex;

         
            Usuario actualizarUsuario = new Usuario(nomUsuario, usuario, contrasena, idPermiso, idEstado);

           
            string resultado = metodosUsuario.Validarusuario(actualizarUsuario);

            if (resultado.Equals("OK"))
            {
                try
                {
                   
                    resultado = metodosUsuario.ActualizarUsuario(idUsuario, actualizarUsuario);
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                    LimpiarCampos();
                    this.datos.Reset();
                    this.MostrarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(resultado, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
            actualizarUsuario = null;
        }
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosUsuario = new MetodosUsuario();
            datos = metodosUsuario.BuscarUsuario(tbBuscarUsuario.Text.Trim());
            FormatoTablaUsuarios(datos);
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            idUsuario = 0;

            tbNombre.Text = "";
            tbUsuario.Text = "";
            tbContrasena.Text = "";
            tbBuscarUsuario.Text = "";
            cbPermisos.SelectedIndex = 0;
            cbEstados.SelectedIndex = 0;

            tbActNombre.Text = "";
            tbActUsuario.Text = "";
            tbActContrasena.Text = "";
            cbActPermisos.SelectedIndex = 0;
            cbActEstados.SelectedIndex = 0;
        }

        public void FormatoTablaUsuarios(DataTable datos)
        {
            try
            {
                datos.Columns["idUsuario"].ColumnName = "ID";
                datos.Columns["nomUsuario"].ColumnName = "NOMBRE";
                datos.Columns["usuario"].ColumnName = "USUARIO";
                datos.Columns["contrasena"].ColumnName = "CONTRASEÑA";
                datos.Columns["idPermiso"].ColumnName = "PERMISO";
                datos.Columns["idEstado"].ColumnName = "ESTADO";

                DGVUsuarios.DataSource = datos;
                DGVUsuarios.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["NOMBRE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["USUARIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["CONTRASEÑA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["PERMISO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVUsuarios.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //txtTotalUsuarios.Text = "Total de usuarios: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Evita errores al hacer clic en los encabezados
                if (e.RowIndex < 0) return;

                // Obtiene la fila seleccionada
                DataGridViewRow fila = DGVUsuarios.Rows[e.RowIndex];

                // Asigna el ID (para el UPDATE)
                idUsuario = Convert.ToInt32(fila.Cells["ID"].Value);

                // Llena los campos de actualización
                tbActNombre.Text = fila.Cells["NOMBRE"].Value?.ToString() ?? "";
                tbActUsuario.Text = fila.Cells["USUARIO"].Value?.ToString() ?? "";
                tbActContrasena.Text = fila.Cells["CONTRASEÑA"].Value?.ToString() ?? "";

                // Buscar el permiso en el combo según el valor del DataGridView
                string permiso = fila.Cells["PERMISO"].Value?.ToString() ?? "";
                int permisoIndex = cbActPermisos.Items.IndexOf(permiso);
                cbActPermisos.SelectedIndex = permisoIndex >= 0 ? permisoIndex : 0;

                // Buscar el estado en el combo
                string estado = fila.Cells["ESTADO"].Value?.ToString() ?? "";
                int estadoIndex = cbActEstados.Items
                    .Cast<object>()
                    .ToList()
                    .FindIndex(item => item.ToString().Contains(estado));
                cbActEstados.SelectedIndex = estadoIndex >= 0 ? estadoIndex : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar usuario: " + ex.Message);
            }
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // ----------------- Estética: esquinas redondeadas y hover azul -----------------

        // Método externo para crear esquinas redondeadas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Aplica región redondeada a todos los TextBox (recursivo)
        private void ApplyRoundedToTextBoxes(Control.ControlCollection controls, int radius)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox tb)
                {
                    tb.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tb.Width, tb.Height, radius, radius));
                    // Actualizar región si cambia el tamaño
                    tb.SizeChanged -= TextBox_SizeChanged;
                    tb.SizeChanged += TextBox_SizeChanged;
                }
                else if (c.HasChildren)
                {
                    ApplyRoundedToTextBoxes(c.Controls, radius);
                }
            }
        }

        private void TextBox_SizeChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tb.Width, tb.Height, 10, 10));
            }
        }

        // Aplica esquinas redondeadas a todos los Button (recursivo)
        private void ApplyRoundedToButtons(Control.ControlCollection controls, int radius)
        {
            foreach (Control c in controls)
            {
                if (c is Button btn)
                {
                    btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, radius, radius));
                    btn.SizeChanged -= Button_SizeChanged;
                    btn.SizeChanged += Button_SizeChanged;
                }
                else if (c.HasChildren)
                {
                    ApplyRoundedToButtons(c.Controls, radius);
                }
            }
        }

        private void Button_SizeChanged(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 10, 10));
            }
        }

        // Aplica estilo a todos los botones (recursivo para contenedores)
        private void ApplyStyleToButtons(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is Button btn)
                {
                    StyleButton(btn);
                }
                else if (c.HasChildren)
                {
                    ApplyStyleToButtons(c.Controls);
                }
            }
        }

        // Aplica estilo consistente a un botón/IconButton
        private void StyleButton(Button btn)
        {
            // quitar fondo y bordes
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = SystemColors.ControlText;
            btn.Cursor = Cursors.Hand;

            // usar color de Theme para hover (MouseOver/MouseDown)
            // Theme.Accent debe existir (usa el mismo azul de FormLogin)
            btn.FlatAppearance.MouseOverBackColor = Theme.Accent;
            btn.FlatAppearance.MouseDownBackColor = Theme.Accent;

            // cambiar ForeColor cuando pase el mouse
            btn.MouseEnter -= Btn_MouseEnter; // evitar doble suscripción
            btn.MouseLeave -= Btn_MouseLeave;
            btn.MouseEnter += Btn_MouseEnter;
            btn.MouseLeave += Btn_MouseLeave;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Theme.Accent;
                btn.ForeColor = Color.White;
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = SystemColors.ControlText;
            }
        }

        // Manejador para el botón "volver"
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            // Buscar la instancia existente de MDIPrincipal y mostrarla en lugar de crear una nueva
            var mdi = Application.OpenForms.OfType<MDIPrincipal>().FirstOrDefault();
            if (mdi != null)
            {
                // Asegurarse de que el label muestre el nombre del usuario actual
                mdi.SetUsuarioLabel();
                mdi.Show();
                mdi.BringToFront();
            }
            else
            {
                // Si no existe, crear una nueva instancia (fallback)
                var nuevo = new MDIPrincipal();
                nuevo.Show();
            }

            // Cerrar este formulario de usuarios
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIPrincipal IR = new MDIPrincipal();
            IR.Show();
            this.Hide();
        }
    }
}