using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEdad.Clear();
            txtCarrera.Clear();
            lblApellidos.ResetText();
            lblNombre.ResetText();
            lblMatricula.ResetText();
            lblApellidos.ResetText();
            lblEdad.ResetText();
            lblCarrera.ResetText();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string matricula, nombre, apellidos, carrera;
            int edad;

            matricula= txtMatricula.Text;
            nombre= txtNombre.Text;
            apellidos= txtApellidos.Text;
            carrera= txtCarrera.Text;
            edad= int.Parse(txtEdad.Text);

            lblMatricula.Text = matricula;
            lblNombre.Text = nombre;
            lblApellidos.Text = apellidos;
            lblEdad.Text = edad.ToString();
            lblCarrera.Text = carrera;
        }
    }
}
