using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace BaseDeDatosEnCsharp
{

    public partial class Form4 : Form
    {

        private SqlConnection conn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private string scn1;
        OleDbConnection cnn = new OleDbConnection();
        public Form4()
        {
            InitializeComponent();
            cnn.ConnectionString =
               @"PROVIDER=SQLOLEDB; Server=DESKTOP-BPB89G7; Database=DB_Avanzada; Uid=sa; Pwd=ivania123123";
            //conexion por SQLCLIENT
            conexion cn1 = new conexion();
            cn1.conec();
            scn1 = cn1.cadena;
            conn1 = new SqlConnection(scn1);
            conn1.Open();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mostramos los textbox ocultos
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            //variable que tendra la consulta
            string seleccion;
            seleccion = $"Select *From LIBROS where id_Libro='{textBox1.Text}'";
            da1 = new SqlDataAdapter(seleccion, conn1);
            SqlParameter prm = new SqlParameter("id_Libro", SqlDbType.Int);
            prm.Value = textBox1.Text;
            da1.SelectCommand.Parameters.Add(prm);
            dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                textBox2.Text = dr1["id_Libro"].ToString().Trim();
                textBox3.Text = dr1["NombreLibro"].ToString().Trim();
                textBox4.Text = dr1["Autor"].ToString().Trim();
                textBox5.Text = dr1["Precio"].ToString().Trim();
            }
            if (dr1 != null)
            {
                MessageBox.Show("Datos encontrados");
                dr1.Close();
            }
        }

        private void btnVolverL_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1();
            formu1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPedirL_Click(object sender, EventArgs e)
        {
            Form3 enviar = new Form3();
            enviar.lbLibrosP.Text = textBox3.Text;
            enviar.lbPrecioP.Text = textBox5.Text;
            enviar.lbIDlibro.Text = textBox2.Text;
            enviar.lbLibrosP.Visible = true;
            enviar.lbPrecioP.Visible = true;
            enviar.lbIDlibro.Visible = true;
            enviar.Show();
            this.Close();
        }
    }
}
