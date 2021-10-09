using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaseDeDatosEnCsharp
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        public Form2()
        {
            InitializeComponent();
            conexion cn = new conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnIngresarC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string insertCliente;
                insertCliente="INSERT INTO CLIENTES (NombreCliente)";
                insertCliente += "VALUES (@nombreCliente)";
                insert1 = new SqlCommand(insertCliente, conn);
                insert1.Parameters.Add(

                    new SqlParameter("@nombreCliente", SqlDbType.VarChar));
                insert1.Parameters["@nombreCliente"].Value = txtnombre.Text;
                insert1.ExecuteNonQuery();
                txtnombre.Clear();
                MessageBox.Show("Registro ingresado...", "Ingresar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }catch
            {
                MessageBox.Show("El registro no fue ingresado..",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();

        }

        private void btnVolverC_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1();
            formu1.Show();
            this.Hide();
        }
    }
}
