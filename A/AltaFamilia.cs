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
        string origen = "";
        public AltaFamilia(string pOrigen, string pIdFamilia)
        {
           if (pOrigen == "M")
            {
                origen = pIdFamilia;
                fila.obtenerFamilia(pIdFamilia);
            }
            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            textNombre.Text = fila.nombre;
            textApellido.Text = fila.apellido;
            textParentesco.Text = fila.parentesco;
            textOcupacion.Text = fila.ocupacion;

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
           // fila.AgregarFamilia(fila);

            if (origen == "")
            {
                fila.AgregarFamilia(fila);
            }
            else
            {
                fila.actualizarFamilia(fila,origen);
            }

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
