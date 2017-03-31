using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EbaisProyecto.DAL.Clases;
using EbaisProyecto.DATOS;
using EbaisProyecto.DAL.Interfaces;

namespace EbaisProyecto.UI
{
    public partial class VistaPaciente : Form
    {
        public VistaPaciente()
        {
            InitializeComponent();
        }

        private void VistaPaciente_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            IUsuarios usu = new MUsuarios();
            var pass = log.tbUser.Text;
            lbNombreUsuario.Text = pass;
        }
    }
}
