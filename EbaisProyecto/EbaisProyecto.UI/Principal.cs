using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbaisProyecto.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pnlFarmacia.Visible = false;
            pnlPaciente.Visible = false;
            pnlExpediente.Visible = false;
            pnlCita.Visible = false;
            pnlDiagnostico.Visible = false;
            pnlUsuarios.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlPadecimiento.Visible = false;
            pnlInicio.Visible = true;
            
        }

        private void menuItemNuevoExp_Click(object sender, EventArgs e)
        {
            pnlFarmacia.Visible = false;
            pnlPaciente.Visible = false;
            
            pnlCita.Visible = false;
            pnlDiagnostico.Visible = false;
            pnlUsuarios.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlPadecimiento.Visible = false;
            pnlInicio.Visible = false;
            pnlExpediente.Visible = true;
        }

        private void menuItemCita_Click(object sender, EventArgs e)
        {
            pnlFarmacia.Visible = false;
            pnlPaciente.Visible = false;

           
            pnlDiagnostico.Visible = false;
            pnlUsuarios.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlPadecimiento.Visible = false;
            pnlInicio.Visible = false;
            pnlExpediente.Visible = false;
            pnlCita.Visible = true;
        }

        private void menuItemPaciente_Click(object sender, EventArgs e)
        {
            pnlFarmacia.Visible = false;
            


            pnlDiagnostico.Visible = false;
            pnlUsuarios.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlPadecimiento.Visible = false;
            pnlInicio.Visible = false;
            pnlExpediente.Visible = false;
            pnlCita.Visible = false;
            pnlPaciente.Visible = true;
        }

        private void menuItemPreConsulta_Click(object sender, EventArgs e)
        {
            pnlFarmacia.Visible = false;



            pnlDiagnostico.Visible = false;
            pnlUsuarios.Visible = false;
           
            pnlPadecimiento.Visible = false;
            pnlInicio.Visible = false;
            pnlExpediente.Visible = false;
            pnlCita.Visible = false;
            pnlPaciente.Visible = false;
            pnlPreconsulta.Visible = true;
        }

        private void menuItemDiagnostico_Click(object sender, EventArgs e)
        {
            pnlFarmacia.Visible = false;          
            pnlUsuarios.Visible = false;
            pnlPadecimiento.Visible = false;
            pnlInicio.Visible = false;
            pnlExpediente.Visible = false;
            pnlCita.Visible = false;
            pnlPaciente.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlDiagnostico.Visible = true;
        }

        private void menuItemMedicamentos_Click(object sender, EventArgs e)
        {
            
            pnlUsuarios.Visible = false;
            pnlPadecimiento.Visible = false;
            pnlInicio.Visible = false;
            pnlExpediente.Visible = false;
            pnlCita.Visible = false;
            pnlPaciente.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlDiagnostico.Visible = false;
            pnlFarmacia.Visible = true;
        }

        private void menuItemControlPadecimientos_Click(object sender, EventArgs e)
        {
            pnlUsuarios.Visible = false;     
            pnlInicio.Visible = false;
            pnlExpediente.Visible = false;
            pnlCita.Visible = false;
            pnlPaciente.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlDiagnostico.Visible = false;
            pnlFarmacia.Visible = false;
            pnlPadecimiento.Visible = true;
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pnlInicio.Visible = false;
            pnlExpediente.Visible = false;
            pnlCita.Visible = false;
            pnlPaciente.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlDiagnostico.Visible = false;
            pnlFarmacia.Visible = false;
            pnlPadecimiento.Visible = false;
            pnlUsuarios.Visible = true;
        }

        private void menuItemPantallaPrincipal_Click(object sender, EventArgs e)
        {

           
            pnlExpediente.Visible = false;
            pnlCita.Visible = false;
            pnlPaciente.Visible = false;
            pnlPreconsulta.Visible = false;
            pnlDiagnostico.Visible = false;
            pnlFarmacia.Visible = false;
            pnlPadecimiento.Visible = false;
            pnlUsuarios.Visible = false;
            pnlInicio.Visible = true;
        }

        private void padecimiento1_Load(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
  

	

    

}
