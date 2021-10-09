using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaseDeDatosEnCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 formu1 = new Form3();
            formu1.Show();
            this.Hide();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form2 formu1 = new Form2();
            formu1.Show();
            this.Hide();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(
              "Server=" + "localhost" + "; " + "database=master; integrated security=yes"
               );
            //crear la base de datos
            string CrearDB = "CREATE DATABASE " + "DB_Avanzada";
            //crear la tabla clientes
            string tClientes = "USE DB_Avanzada;" +
                "CREATE TABLE CLIENTES(" +
                "id_Cliente int IDENTITY(1,1)," +
                "NombreCliente varchar(40)" +
                "CONSTRAINT PK_cliente PRIMARY KEY (id_Cliente));";
            //crear la tabla pedidos
            string tPedidos = "USE DB_Avanzada;" +
                "CREATE TABLE PEDIDOS(" +
                "id_Pedido int IDENTITY(1,1)," +
                "id_Cliente int not null," +
                "CantidadPedido int," +
                "FechaPedido varchar(70)," +
                 "CONSTRAINT PK_Pedido PRIMARY KEY(id_Pedido)," +
                 "CONSTRAINT FK_Cliente FOREIGN KEY (id_Cliente)" +
                 "REFERENCES CLIENTES (id_Cliente));";
            SqlCommand cmd = new SqlCommand(CrearDB, cnn);
            SqlCommand cmd1 = new SqlCommand(tClientes, cnn);
            SqlCommand cmd2 = new SqlCommand(tPedidos, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Base de datos" +
                "\nCreada correctamente...", "Generar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error al crear la Base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
