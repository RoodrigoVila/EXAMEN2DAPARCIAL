
using WindowsFormsApp1;
using comun;
using AccesoDatosLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using comun;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e) { var dalEstu = new dalEmpleado(); var perComun = dalEstu.SeleccionarEmpleado((int)txtID.Value); txtDNI.Text = perComun.id.ToString(); txtNombres.Text = perComun.nombre; txtApellidos.Text = perComun.apellidos; txtTelefono.Text = perComun.categoria; }

        private void button2_Click(object sender, EventArgs e)
        {
            var perComun = new CEmpleado(); var dalCli = new dalEmpleado(); perComun.id = (int)txtID.Value; perComun.nombre = txtNombres.Text; perComun.apellidos = txtApellidos.Text; perComun.categoria = txtTelefono.Text;

            MessageBox.Show(perComun.ToString()); dalCli.InsertarEmpleado(perComun);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var perComun = new CEmpleado(); var dalEstu = new dalEmpleado(); perComun.id = (int)txtID.Value; perComun.nombre = txtNombres.Text; perComun.apellidos = txtApellidos.Text; perComun.categoria = txtTelefono.Text;

            MessageBox.Show(perComun.ToString()); dalEstu.ActualizarEmpleado(perComun);
        }

        private void button4_Click(object sender, EventArgs e) { var dalEstu = new dalEmpleado(); dalEstu.EliminarEmpleado((int)txtID.Value); }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
