using FontAwesome.Sharp;
using Sistema_Ventas_Inventario.Vistas;
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

namespace Sistema_Ventas_Inventario
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();

            // Actualizar etiqueta cuando el formulario gane foco o cambie visibilidad
            this.Activated += (s, e) => SetUsuarioLabel();
            this.VisibleChanged += (s, e) => SetUsuarioLabel();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            // mover labels al pictureBox (si lo necesitas)
            if (this.Controls.Contains(label1))
            {
                this.Controls.Remove(label1);
                pictureBox1.Controls.Add(label1);
            }
            if (this.Controls.Contains(label2))
            {
                this.Controls.Remove(label2);
                pictureBox1.Controls.Add(label2);
            }

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;

            // Mostrar el nombre si fue asignado antes de abrir el formulario
            SetUsuarioLabel();
        }

        // propiedad pública (opcional) que se puede asignar desde FormLogin
        public string nomUsuario { get; set; }

        // Método público para actualizar la etiqueta desde otros formularios / sesión global
        public void SetUsuarioLabel()
        {
            try
            {
                // Prioridad: Sesión global (SesiónUsuario) si existe, si no usar la propiedad local
                var nombre = !string.IsNullOrWhiteSpace(SesionUsuario.NombreUsuario)
                    ? SesionUsuario.NombreUsuario
                    : this.nomUsuario;

                if (!string.IsNullOrWhiteSpace(nombre))
                    label2.Text = "Usuario: " + nombre;
                else
                    label2.Text = "Usuario: (no identificado)";
            }
            catch
            {
                // ignorar si label no existe aún
            }
        }

        private void usuariosToolSstripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios IR = new FormUsuarios();
            IR.Show();
            this.Hide();
        }

        private void ventasToolSstripMenuItem_Click(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
=======

        private void productosToolSstripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos IR = new FormProductos();
            IR.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolSstripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores IR = new FormProveedores();
            IR.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cerrarsesionToolSstripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin IR = new FormLogin();
            IR.Show();
            this.Hide();
        }
>>>>>>> Stashed changes
    }
}
