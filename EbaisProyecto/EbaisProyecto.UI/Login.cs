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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            ILogin log = new MLogin();
            var listaCedulas = log.ListarUsuarios();
            var listaPass = log.ListarUsuarios();
            listaPass = listaPass.Where(x => x.Password != null).ToList();
            listaCedulas = listaCedulas.Where(x => x.Cedula != 0).ToList();
            Usuarios a = new Usuarios();
            a.Nombre = tbUser.Text;
            bool cedula = false;
            bool pass = false;
            
            foreach (var u in listaCedulas)
            {
                if (u.Cedula == Convert.ToInt32(tbUser.Text) && u.TipoUsuario == "Paciente")
                {
                    cedula = true;
                    VistaPaciente vista = new VistaPaciente();
                    vista.Show();
                    Hide();
                }
                else if (u.Cedula == Convert.ToInt32(tbUser.Text) && u.TipoUsuario == "Doctor")
                {
                    Pass postlogin = new Pass();
                    postlogin.Show();
                    Hide();
                }
                else if (u.Cedula == Convert.ToInt32(tbUser.Text) && u.TipoUsuario == "Administrador")
                {
                    Principal inicio = new Principal();
                    inicio.Show();
                    Hide();
                }
            }
            //foreach (var p in listaPass)
            //{
            //    if (p.Password == mtbPass.Text)
            //    {
            //        pass = true;
            //    }
            //}

            //try
            //{
            //    if (cedula == true && pass == true)
            //    {
            //        Principal inicio = new Principal();
            //        inicio.Show();
            //        Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Número de cédula o contraseña incorrectos");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Se ha producido un error " +ex.Data);
            //}
            
            

            
        }

        public void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
