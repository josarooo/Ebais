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
using EbaisProyecto.DAL.Interfaces;
using EbaisProyecto.DAL.Clases;

namespace EbaisProyecto.UI.FolderPaciente
{
    public partial class EditarPaciente : UserControl
    {
        public EditarPaciente()
        {
            InitializeComponent();
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuarios
                {
                    Cedula = Convert.ToInt32(txtCedula.Text),
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Telefono = Convert.ToInt32(numTelefono.Value),
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Direccion = rchDireccion.Text,
                    TipoUsuario = "Paciente",
                    Password = null,
                    Sexo = cbSexo.SelectedItem.ToString()
                };

                IUsuario usu = new MUsuario();
                usu.ActualizarUsuario(usuario);
                
                MessageBox.Show("La información del paciente se ha actualizado correctamente.");
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");
            }
        }

       
    }
}
