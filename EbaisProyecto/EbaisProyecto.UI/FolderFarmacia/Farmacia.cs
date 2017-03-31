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
using EbaisProyecto.UI.FolderFarmacia;

namespace EbaisProyecto.UI
{
    public partial class Farmacia : UserControl
    {
       
        IFarmacia fMedica = new Mfarmacia();
        

        public Farmacia()
        {
            
            InitializeComponent();
        }

        private void tabPageAgregarMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {

        }

        private void tabPageConsultaMedicamentos_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try

            {
                int cod = fMedica.UltimoValor()+1;
               
                var farmacia = new DATOS.Farmacia
                {
                    IdMedicamento = cod,
                    //Nombre = txtNombreMedicamento.Text,
                    Tipo = cbMedicamento.Text,
                    Cantidad = Convert.ToInt32(numCantidad.Value),
                    Descripcion = rchtDescripcion.Text
                };

                var medicamento = fMedica.InsertarFarmacia(farmacia);
                dgvMedicamentosUno.DataSource = null;
                List<DATOS.Farmacia> ListMedi = new List<DATOS.Farmacia> { medicamento };
                dgvMedicamentosUno.DataSource = ListMedi;
                ;


                MessageBox.Show("El medicamento insertado con éxito", "Información");
                LimpiarCampos();
                PopularDGVFarmacia();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");
            }
        }

        private void LimpiarCampos()
        {

            
            cbMedicamento.SelectedIndex = 0;
            numCantidad.Value = 0;
            rchtDescripcion.Clear();
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

        private void MostrarPanelEdicion()
        {
            var editarFarmacia = new EditarFarmacia();
            editarFarmacia.txtCodigoMedicamento.Text = dgvListaMedicamentosDos.SelectedCells[0].Value.ToString();
            editarFarmacia.cbMedicamento.SelectedText = dgvListaMedicamentosDos.SelectedCells[1].Value.ToString();
            editarFarmacia.numCantidad.Value = Convert.ToInt32(dgvListaMedicamentosDos.SelectedCells[2].Value);
            editarFarmacia.rchtDescripcion.Text = dgvListaMedicamentosDos.SelectedCells[3].Value.ToString();

            FormEdicion ventanaEditarFarmacia = new FormEdicion();
            ventanaEditarFarmacia.Controls.Add(editarFarmacia);
            ventanaEditarFarmacia.ShowDialog();
            PopularDGVFarmacia();
        }

        private void dgvListaMedicamentosDos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PopularDGVFarmacia()
        {
            var listaMedicamentos = fMedica.ListarFarmacia();
            listaMedicamentos = listaMedicamentos.ToList();
            dgvListaMedicamentosDos.DataSource = null;
            dgvListaMedicamentosDos.DataSource = listaMedicamentos;
            
        }

        private void Farmacia_Load(object sender, EventArgs e)
        {
            try
            {
                

                cbMedicamento.SelectedIndex = 0;
                PopularDGVFarmacia();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void dgvListaMedicamentosDos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                fMedica.EliminarFarmacia(Convert.ToInt32(dgvListaMedicamentosDos.SelectedCells[0].Value.ToString()));
                MessageBox.Show("Se ha eliminado correctamente el Medicamento.", "Información");
                PopularDGVFarmacia();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            try
            {
                IFarmacia far = new Mfarmacia();
                var farma = far.BuscarMedicamento(Convert.ToInt32(txtCodigoB.Text));
                dgvListaMedicamentosDos.DataSource = null;
                List<DATOS.Farmacia> ListaFarma = new List< DATOS.Farmacia > { farma };
                dgvListaMedicamentosDos.DataSource = ListaFarma;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el usuario. " + ex.Data);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var verFarmacia = new VerFarmacia();
                verFarmacia.txtId.Text = dgvListaMedicamentosDos.SelectedCells[0].Value.ToString();
                verFarmacia.txtTipo.Text = dgvListaMedicamentosDos.SelectedCells[1].Value.ToString();
                verFarmacia.txtCantidad.Text = dgvListaMedicamentosDos.SelectedCells[2].Value.ToString();
                verFarmacia.rchDesc.Text = dgvListaMedicamentosDos.SelectedCells[3].Value.ToString();

                FormEdicion ventanaEditarFarmacia = new FormEdicion();
                ventanaEditarFarmacia.Controls.Add(verFarmacia);
                ventanaEditarFarmacia.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Debe selecionar toda la fila");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                IFarmacia far = new Mfarmacia();
                var farma = far.BuscarPorTipo(cboMedica.Text);
                dgvListaMedicamentosDos.DataSource = null;
                //List<DATOS.Farmacia> ListaFarma = new List<DATOS.Farmacia> { farma };
                dgvListaMedicamentosDos.DataSource = farma;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el usuario. " + ex.Data);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
