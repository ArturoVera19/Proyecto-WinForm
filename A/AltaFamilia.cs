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
        public AltaFamilia()
        {
            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {

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
            fila.nombre = textNombre.ToString();
            fila.apellido = textApellido.ToString();
            fila.parentesco = textParentesco.ToString();
            fila.ocupacion = textOcupacion.ToString();
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
