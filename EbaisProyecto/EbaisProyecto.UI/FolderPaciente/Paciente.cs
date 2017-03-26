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
       
        public Paciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void Paciente_Load(object sender, EventArgs e)
        {

            try
            {
                IUsuario us = new MUsuario();
                var listaPacientes = us.ListarUsuarios();
                dgvListaMedicamentosDos.DataSource = listaPacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //FormEdicion ventanaEditarPaciente = new FormEdicion();
           

            MostrarPanelEdicion();


        }

        


     

        private void dgvListaMedicamentosDos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarPanelEdicion();

        }


        private void MostrarPanelEdicion()
        {
            var editarPaciente = new EditarPaciente();
            editarPaciente.txtCedula.Text = dgvListaMedicamentosDos.SelectedCells[0].Value.ToString();
            editarPaciente.txtNombre.Text = dgvListaMedicamentosDos.SelectedCells[1].Value.ToString();
            editarPaciente.txtApellidos.Text = dgvListaMedicamentosDos.SelectedCells[2].Value.ToString();
            editarPaciente.numTelefono.Value = Convert.ToInt32(dgvListaMedicamentosDos.SelectedCells[3].Value);
            editarPaciente.dtpFechaNacimiento.Value = Convert.ToDateTime(dgvListaMedicamentosDos.SelectedCells[4].Value);           
            editarPaciente.txtCedula.Enabled = false;

            FormEdicion ventanaEditarPaciente = new FormEdicion();
            ventanaEditarPaciente.Controls.Add(editarPaciente);
            ventanaEditarPaciente.ShowDialog();

            


        }
    }
}
