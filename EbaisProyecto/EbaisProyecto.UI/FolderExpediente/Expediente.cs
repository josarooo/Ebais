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
    public partial class Expediente : UserControl
    {
        public Expediente()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPagePadecimientos_Click(object sender, EventArgs e)
        {

        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            IExpediente expe = new MExpediente();
            DATOS.Expediente ex = new DATOS.Expediente();
            try
            {
                if (Convert.ToInt32(txtCedula.Text) != ex.Cedula)
                {
                    MessageBox.Show("Usuario asociado");
                }
                else
                {
                    MessageBox.Show("El usuario ya tiene un expediente asociado");
                    txtCedula.Clear();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido un error " + error.Data);
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
