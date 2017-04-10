using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EbaisProyecto.DAL.Interfaces;
using EbaisProyecto.DAL.Clases;
using EbaisProyecto.DATOS;

namespace EbaisProyecto.UI.FolderFarmacia
{
    public partial class EditarFarmacia : UserControl
    {
        public EditarFarmacia()
        {
            InitializeComponent();
        }

        private void EditarFarmacia_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarF_Click(object sender, EventArgs e)
        {
            try
            {


                DATOS.Farmacia farmacia = new DATOS.Farmacia();
               
                farmacia.IdMedicamento = Convert.ToInt32(txtCodigoMedicamento.Text);
                farmacia.Nombre = txt_nom_medica.Text;
                farmacia.Tipo = cbMedicamento.Text;
                farmacia.Cantidad = Convert.ToInt32(numCantidad.Value);
                farmacia.Descripcion = rchtDescripcion.Text;
                                

                IFarmacia farm = new Mfarmacia();
                farm.ActualizarFarmacia(farmacia);

                MessageBox.Show("La información del medicamento se ha actualizado correctamente.");
                ((Form)this.TopLevelControl).Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. " + ex.Message, "ERROR");
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
