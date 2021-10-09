using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MDB_LF212591_PRACTICA4
{
    public partial class Form1 : Form
    {
        //defino una variable de tipo connection
        private SqlConnection conn1;
        //defino una variable de tipo dataadapter
        private SqlDataAdapter da1;
        //defino una variable de tipo datareader
        private SqlDataReader dr1;
        //define una varibale que contendra la cadena de conexion
        private string scn1;
        //instancio una variable oledbconnection
        OleDbConnection cnn = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            //linea de conexion con el servidorde base de datos sql por oledb
            cnn.ConnectionString =
                @"PROVIDER=SQLOLEDB; Server=DESKTOP-BPB89G7; Database=Practica_4_LF212591; Uid=sa; Pwd=ivania123123";
            //ocultamos el boton modificar
            modificar1.Visible = false;
            //conexion por SQLCLIENT
            Conexion cn1 = new Conexion();
            cn1.conectar();
            scn1 = cn1.cadena;
            conn1 = new SqlConnection(scn1);
            conn1.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            //mostramos los textbox ocultos
            textapel1.Visible = true;
            textedad1.Visible = true;
            textnom1.Visible = true;
            modificar1.Visible = true;
            //variable que tendra la consulta
            string seleccion;
            seleccion = $"Select *From Participantes where Codigo='{textcod1.Text}'";
            da1 = new SqlDataAdapter(seleccion, conn1);
            SqlParameter prm = new SqlParameter("Codigo", SqlDbType.VarChar);
            prm.Value = textcod1.Text;
            da1.SelectCommand.Parameters.Add(prm);
            dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read()) 
            {
                textnom1.Text = dr1["Nombres"].ToString().Trim();
                textapel1.Text = dr1["Apellidos"].ToString().Trim();
                textedad1.Text = dr1["Edad"].ToString().Trim();
            }
            if(dr1!=null)
            {
                MessageBox.Show("Datos encontrados");
                dr1.Close();
            }
        }

        private void modificar1_Click(object sender, EventArgs e)
        {
            string actualizar;
            actualizar = "update Participantes set";
            actualizar += " Nombres='"+textnom1.Text +"', Apellidos='"+textapel1.Text;
            actualizar += "', Edad="+textedad1.Text+"where Codigo='"+textcod1.Text+"'";
            OleDbCommand datos = new OleDbCommand(actualizar, cnn);
            
            cnn.Open();
            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Registro actualizado");
            Reset();
        }

        private void Reset()
        {
            textapel1.Text = "";
            textnom1.Text = "";
            textcod1.Text = "";
            textedad1.Text = "";
            textapel1.Visible =false;
            textnom1.Visible = false;
            textedad1.Visible = false;
            modificar1.Visible = false;
            Form2 formu2 = new Form2();
            formu2.Show();
            this.Hide();
        }
    }
}
