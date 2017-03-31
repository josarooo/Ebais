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
using EbaisProyecto.UI.FolderPadecimiento;

namespace EbaisProyecto.UI
{
    public partial class Padecimiento : UserControl
    {
        IPadecimiento iPade = new MPadecimiento();

        public Padecimiento()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try

            {

                int cod = iPade.UltimoValor() + 1;
                var padecimiento = new DATOS.Padecimiento
                {
                    IdPadecimiento = cod,
                    //Nombre = txtNombreMedicamento.Text,
                    Tipo = cbPadecimento.Text,
                    Descripcion = rchtDescrip.Text
                };

                var pade = iPade.InsertarPadecimiento(padecimiento);
                this.dgvListaPadecimentosUno.DataSource = null;
                List<DATOS.Padecimiento> ListPade = new List<DATOS.Padecimiento> { pade };
                dgvListaPadecimentosUno.DataSource = ListPade;
                ;


                MessageBox.Show("El Padecimiento insertado con éxito", "Información");
                LimpiarCampos();
                PopularDGVPadecimiento();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");
            }
        }

        private void LimpiarCampos()
        {


            cbPadecimento.SelectedIndex = 0;
            rchtDescrip.Clear();
        }

        private void MostrarPanelEdicion()
        {
            var editarPadecimento = new EditarPadecimiento();
            editarPadecimento.txtCodigoPadecimento.Text = dgvListaPadecimentoDos.SelectedCells[0].Value.ToString();
            editarPadecimento.cbPadecimento.SelectedText = dgvListaPadecimentoDos.SelectedCells[1].Value.ToString();
            editarPadecimento.rchtDescripcion.Text = dgvListaPadecimentoDos.SelectedCells[2].Value.ToString();

            FormEdicion ventanaEditarPadecimento = new FormEdicion();
            ventanaEditarPadecimento.Controls.Add(editarPadecimento);
            ventanaEditarPadecimento.ShowDialog();
            PopularDGVPadecimiento();
        }

        private void PopularDGVPadecimiento()
        {
            var listaPadecimiento = iPade.ListarPadecimiento();
            listaPadecimiento = listaPadecimiento.ToList();
            dgvListaPadecimentosUno.DataSource = null;
            this.dgvListaPadecimentoDos.DataSource = listaPadecimiento;

        }

        private void dgvListaPadecimentoDos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                IPadecimiento far = new MPadecimiento();
                var pade = far.BuscarPadecimiento(Convert.ToInt32(txtCodigoB.Text));
                this.dgvListaPadecimentoDos.DataSource = null;
                List<DATOS.Padecimiento> ListaPade = new List<DATOS.Padecimiento> { pade };
                dgvListaPadecimentoDos.DataSource = ListaPade;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el usuario. " + ex.Data);
            }
        }

        private void Padecimiento_Load(object sender, EventArgs e)
        {
            try
            {


                this.cbPadecimento.SelectedIndex = 0;
                PopularDGVPadecimiento();



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

                iPade.EliminarPadecimiento(Convert.ToInt32(dgvListaPadecimentoDos.SelectedCells[0].Value.ToString()));
                MessageBox.Show("Se ha eliminado correctamente el Padecimiento.", "Información");
                PopularDGVPadecimiento();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var verPadecimiento = new VerPadecimiento();
                verPadecimiento.txtId.Text = dgvListaPadecimentoDos.SelectedCells[0].Value.ToString();
                verPadecimiento.txtTipo.Text = dgvListaPadecimentoDos.SelectedCells[1].Value.ToString();
                verPadecimiento.rchDesc.Text = dgvListaPadecimentoDos.SelectedCells[2].Value.ToString();

                FormEdicion ventanaEditarPadecimiento = new FormEdicion();
                ventanaEditarPadecimiento.Controls.Add(verPadecimiento);
                ventanaEditarPadecimiento.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Debe selecionar la fila completa");
            }
           
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                IPadecimiento far = new MPadecimiento();
                var pade = far.BuscarPorTipo(cboPadecimentoDos.Text);
                this.dgvListaPadecimentoDos.DataSource = null;
                //List<DATOS.Padecimiento> ListaPade = new List<DATOS.Padecimiento> { pade };
                dgvListaPadecimentoDos.DataSource = pade;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el usuario. " + ex.Data);
            }
        }
    }
}
