using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EbaisProyecto.DAL;
using EbaisProyecto.DATOS;
using EbaisProyecto.DAL.Interfaces;
using EbaisProyecto.DAL.Clases;
using EbaisProyecto.UI.FolderPaciente;

namespace EbaisProyecto.UI
{
    public partial class Paciente : UserControl
    {
        IUsuarios us = new MUsuarios();


        public Paciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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


                us.InsertarUsuario(usuario);


                MessageBox.Show("Paciente insertado con éxito", "Información");
                LimpiarCampos();
                PopularDGVPacientes();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");
            }
        }

        private void Paciente_Load(object sender, EventArgs e)
        {

            try
            {
                cbSexo.SelectedIndex = 0;
                PopularDGVPacientes();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                MostrarPanelEdicion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");

            }
        }
        private void dgvListaMedicamentosDos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MostrarPanelEdicion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                us.EliminarUsuario(Convert.ToInt32(dgvListaPacientes.SelectedCells[0].Value.ToString()));
                MessageBox.Show("Se ha eliminado correctamente el paciente.", "Información");
                PopularDGVPacientes();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");
            }

        }

        private void MostrarPanelEdicion()
        {
            var editarPaciente = new EditarPaciente();
            editarPaciente.txtCedula.Text = dgvListaPacientes.SelectedCells[0].Value.ToString();
            editarPaciente.txtNombre.Text = dgvListaPacientes.SelectedCells[1].Value.ToString();
            editarPaciente.txtApellidos.Text = dgvListaPacientes.SelectedCells[2].Value.ToString();
            editarPaciente.numTelefono.Value = Convert.ToInt32(dgvListaPacientes.SelectedCells[3].Value);
            editarPaciente.dtpFechaNacimiento.Value = Convert.ToDateTime(dgvListaPacientes.SelectedCells[4].Value);
            editarPaciente.rchDireccion.Text = dgvListaPacientes.SelectedCells[5].Value.ToString();
            editarPaciente.cbSexo.SelectedItem = dgvListaPacientes.SelectedCells[8].Value.ToString();
            FormEdicion ventanaEditarPaciente = new FormEdicion();
            ventanaEditarPaciente.Controls.Add(editarPaciente);
            ventanaEditarPaciente.ShowDialog();
            PopularDGVPacientes();
        }


        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            numTelefono.Value = 0;
            rchDireccion.Clear();
            cbSexo.SelectedIndex = 0;
        }

        private void PopularDGVPacientes()
        {
            var listaPacientes = us.ListarUsuarios();
            listaPacientes = listaPacientes.Where(x => x.TipoUsuario == "Paciente").ToList();
            dgvListaPacientes.DataSource = null;
            dgvListaPacientes.DataSource = listaPacientes;
            dgvListaPacientes.Columns[6].Visible = false;
            dgvListaPacientes.Columns[7].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var verPaciente = new VerPaciente();
            verPaciente.txtCedula.Text = dgvListaPacientes.SelectedCells[0].Value.ToString();
            verPaciente.txtNombre.Text = dgvListaPacientes.SelectedCells[1].Value.ToString();
            verPaciente.txtApellidos.Text = dgvListaPacientes.SelectedCells[2].Value.ToString();
            verPaciente.numTelefono.Value = Convert.ToInt32(dgvListaPacientes.SelectedCells[3].Value);
            verPaciente.txtFecha.Text = dgvListaPacientes.SelectedCells[4].Value.ToString();
            verPaciente.rchDireccion.Text = dgvListaPacientes.SelectedCells[5].Value.ToString();
            verPaciente.txtSexo.Text = dgvListaPacientes.SelectedCells[8].Value.ToString();
            FormEdicion ventanaEditarPaciente = new FormEdicion();
            ventanaEditarPaciente.Controls.Add(verPaciente);
            ventanaEditarPaciente.ShowDialog();
        }
    }
}
