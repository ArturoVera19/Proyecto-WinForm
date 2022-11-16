using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace A
{
    public partial class AltaFamilia : Form
    {
        Familia fila = new Familia();
        string nombre = "";
        public AltaFamilia(string pOrigen)
        {
           if (pOrigen == "M")
            {
                nombre = "Probando si funciona";
            }
            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            textNombre.Text = nombre;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            fila.nombre = textNombre.Text;
            fila.apellido = textApellido.Text;
            fila.parentesco = textParentesco.Text;
            fila.ocupacion = textOcupacion.Text;
            fila.AgregarFamilia(fila);


            this.Close();

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textParentesco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOcupacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
