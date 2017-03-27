using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EbaisProyecto.DATOS;
using EbaisProyecto.DAL.Clases;
using EbaisProyecto.DAL.Interfaces;

namespace EbaisProyecto.UI
{
    public partial class Usuario : UserControl
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                IUsuarios usu = new MUsuarios();
                var usuario = usu.BuscarUsuario(Convert.ToInt32(txtNombreB.Text));
                dgvListaMedicamentosDos.DataSource = null;
                List<DATOS.Usuarios> ListaUsuarios = new List<Usuarios> { usuario };
                dgvListaMedicamentosDos.DataSource = ListaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el usuario. " + ex.Data);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                var user = new Usuarios
                {
                    Cedula = Convert.ToInt32(txtCedula.Text),
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Telefono = Convert.ToInt32(txtNumero.Text),
                    FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text),
                    Direccion = rchDireccion.Text,
                    TipoUsuario = cbTipoUsuario.Text,
                    Password = mtbPass.Text,
                    Sexo = cbSexo.Text
                };
                IUsuarios usu = new MUsuarios();
                if (mtbPass.Text == mtbConfirmarPass.Text)
                {
                    usu.InsertarUsuario(user);
                    MessageBox.Show("Usuario Agregado correctamente", "Usuario Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    mtbPass.Clear();
                    mtbConfirmarPass.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Data);
            }
        }
    }
}
