using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using Org.BouncyCastle.Utilities.Collections;

namespace Modelo
{
    class Familia
    {
        public int idFamilia { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string parentesco { get; set; }
        public string ocupacion { get; set; }

        public DataTable llenarFamilia()
        {
            MySqlConnection conexion = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = conexion;

            conexion.Open();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            instruccion.CommandText = "select * from familia";
            Adapter.SelectCommand = instruccion;
            DataSet SetDatos = new DataSet();
            Adapter.Fill(SetDatos);
            DataTable Tabla = new DataTable();
            Tabla = SetDatos.Tables[0];
            conexion.Close();

            return Tabla;
        }


        public void eliminarFamilia(string pId)
        {
            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = cnx;
            cnx.Open();
            instruccion.CommandText = "delete from familia where idfamilia = '" + pId + "'";
            instruccion.ExecuteNonQuery();
            cnx.Close();
            //MessageBox.Show(pId);
        }

        public void AgregarFamilia(Familia pfila)
        {
            string textRecibido = pfila.nombre + "" + pfila.apellido + "" +  pfila.ocupacion + "" + pfila.parentesco;
            //MessageBox.Show(textRecibido);

            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = cnx;
            cnx.Open();
            instruccion.CommandText = "insert into familia (nombre,apellido,parentesco,ocupacion) values ('" + pfila.nombre + "','" + pfila.apellido + "','" + pfila.parentesco + "','" + pfila.ocupacion +"')";

            //insert from familia where idfamilia = '" + pfila + "'";
            instruccion.ExecuteNonQuery();
            cnx.Close();

        }

    }
}


