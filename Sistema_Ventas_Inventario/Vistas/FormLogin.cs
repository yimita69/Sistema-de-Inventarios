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
using System.Runtime.InteropServices;

namespace Sistema_Ventas_Inventario.Vistas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            // Suscribir eventos si no están en el diseñador
            this.Load += FormLogin_Load;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MetodosUsuario metodosUsuario = new MetodosUsuario();
                Usuario usuario = metodosUsuario.LoginUsuario(tbUsuario.Text.Trim(), tbContrasena.Text.Trim());

                if (usuario.idUsuario == 0)
                {
                    MessageBox.Show("No se puede acceder, revisa que los datos sean correctos.");
                    return;
                }

                if (usuario.idEstado == 1)
                {
                    MessageBox.Show("Esta cuenta está inactiva, contacta al administrador del sistema");
                    return;
                }

                // Guarda información del usuario en la sesión (ajusta según tu implementación)
                SesionUsuario.IdUsuario = usuario.idUsuario;         // opcional
                SesionUsuario.NombreUsuario = usuario.nomUsuario;   // guarda globalmente el nombre
                SesionUsuario.IdPermiso = usuario.idPermiso;          // opcional

                // Abrir MDIPrincipal y pasar datos del usuario
                MDIPrincipal mdiPrincipal = new MDIPrincipal();
                mdiPrincipal.nomUsuario = usuario.nomUsuario; // opcional, por compatibilidad
                mdiPrincipal.SetUsuarioLabel();               // forzar actualización inmediata
                mdiPrincipal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

           
            try
            {
                // color base consistente para el botón (ajusta los valores si quieres otro tono)
                Color botonColor = System.Drawing.Color.FromArgb(0, 122, 204);

                // Mover labels y controles visuales como hijos del pictureBox para que la transparencia funcione
                if (pictureBox1 != null)
                {
                    // mover etiquetas (texto) al PictureBox y hacerlas transparentes
                    foreach (var lbl in this.Controls.OfType<Label>().ToList())
                    {
                        if (this.Controls.Contains(lbl))
                        {
                            this.Controls.Remove(lbl);
                            pictureBox1.Controls.Add(lbl);
                            lbl.BackColor = System.Drawing.Color.Transparent;
                            lbl.BringToFront();
                        }
                    }

                    // mover botones/iconos que usan BackgroundImage/Image al PictureBox
                    var iconControls = new Control[] { button1, button2, btnLogin, tbUsuario, tbContrasena };
                    foreach (var c in iconControls)
                    {
                        if (c == null) continue;
                        if (this.Controls.Contains(c))
                        {
                            this.Controls.Remove(c);
                            pictureBox1.Controls.Add(c);
                        }

                        // Ajustes estéticos para botones con imagen
                        if (c is Button btn)
                        {


                            btn.FlatStyle = FlatStyle.Flat;
                            btn.FlatAppearance.BorderSize = 0;
                            btn.BackColor = Color.Transparent;
                            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                            btn.BringToFront();
                        }

                        // Asegurar que TextBox esté en frente (no transparente, pero encima del PictureBox)
                        if (c is TextBox tb)
                        {
                            tb.BackColor = Color.White; // o el color que prefieras
                            tb.BringToFront();
                        }
                    }
                }

                // Redondear botón y TextBox si usas CreateRoundRectRgn
                btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 18, 18));
                ApplyRoundedToControl(tbUsuario, 10);
                ApplyRoundedToControl(tbContrasena, 10);

                // Aplicar estilo al btnLogin (asegura que quede igual aun si no pasó por el loop anterior)
                btnLogin.FlatStyle = FlatStyle.Flat;
                btnLogin.FlatAppearance.BorderSize = 0;
                btnLogin.UseVisualStyleBackColor = false;
                btnLogin.BackColor = botonColor;
                btnLogin.ForeColor = System.Drawing.Color.White;
                btnLogin.FlatAppearance.MouseOverBackColor = ControlPaint.Light(botonColor);
                btnLogin.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(botonColor);
                btnLogin.Cursor = Cursors.Hand;
                btnLogin.BringToFront();

                // Mantener regiones si se redimensionan
                btnLogin.SizeChanged += (s, ev) => btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 18, 18));
                tbUsuario.SizeChanged += (s, ev) => ApplyRoundedToControl(tbUsuario, 10);
                tbContrasena.SizeChanged += (s, ev) => ApplyRoundedToControl(tbContrasena, 10);
            }
            catch
            {
                // ignorar errores de diseño en tiempo de carga
            }
        }

        private void ApplyRoundedToControl(Control c, int radius)
        {
            if (c == null) return;
            c.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, radius, radius));
        }

        // Método externo para crear esquinas redondeadas
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


    }
}


