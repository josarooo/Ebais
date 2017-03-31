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

namespace EbaisProyecto.UI.FolderPadecimiento
{
    public partial class EditarPadecimiento : UserControl
    {
        public EditarPadecimiento()
        {
            InitializeComponent();
        }

        private void btnConfirmarF_Click(object sender, EventArgs e)
        {
            try
            {


                DATOS.Padecimiento padecimiento = new DATOS.Padecimiento();

                padecimiento.IdPadecimiento = Convert.ToInt32(txtCodigoPadecimento.Text);
                padecimiento.Tipo = this.cbPadecimento.Text;
                padecimiento.Descripcion = rchtDescripcion.Text;


                IPadecimiento pade = new MPadecimiento();
                pade.ActualizarPadecimiento(padecimiento);

                MessageBox.Show("La información del padecimiento se ha actualizado correctamente.");
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
