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
                List<Usuarios> ListaU = usu.ListarUsuarios();
                foreach (var i in ListaU)
                {
                    if (Convert.ToInt32(txtCedula.Text) != i.Cedula)
                    {
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
                    else 
                    {
                        MessageBox.Show("El usuario ya existe");
                        limpiar();
                        break;
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Data);
            }
        }

        private void txtNombreB_TextChanged(object sender, EventArgs e)
        {
            //IUsuarios usu = new MUsuarios();
            //var usuario = usu.BuscarPorNombre(txtNombreB.Text);
            //List<Usuarios> Lista  = new List<Usuarios> { usuario };
            //var filtro = from Usuarios in Lista where usuario.Nombre.ToUpper().Contains(txtNombreB.Text.ToUpper()) select usuario;
            //this.dgvListaMedicamentosDos.DataSource = filtro.ToList<Usuarios>();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            txtCedula.Clear();
            txtCedula.Focus();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtNumero.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            rchDireccion.Clear();
            mtbPass.Clear();
            mtbConfirmarPass.Clear();
        }
    }
}
