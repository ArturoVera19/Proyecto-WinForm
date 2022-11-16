using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo;

namespace A
{
    public partial class AdministradorDeFamilia : Form
    {

        Familia familia1 = new Familia();

        public AdministradorDeFamilia()
        {
            InitializeComponent();
        }

        private void btCompletar_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // dgvFamilia.RowHeadersVisible = false;
            //dgvFamilia.AllowUserToAddRows = false;
            dgvFamilia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgvFamilia.DataSource = familia1.llenarFamilia();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaFamilia altafamilia = new AltaFamilia("A");
            altafamilia.ShowDialog();

            dgvFamilia.DataSource = familia1.llenarFamilia();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AltaFamilia ModificarFamilia = new AltaFamilia("M");
            ModificarFamilia.Text = "ModificarFamilia";
            ModificarFamilia.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idFamilia = dgvFamilia.SelectedCells[0].Value.ToString();
            familia1.eliminarFamilia(idFamilia);

            dgvFamilia.DataSource = familia1.llenarFamilia();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvFamilia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
