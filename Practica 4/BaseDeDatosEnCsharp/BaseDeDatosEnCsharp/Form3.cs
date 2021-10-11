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
    public partial class Form3 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        public Form3()
        {
            InitializeComponent();
            nUDcant.Text = "1";
            conexion cn = new conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }
        private void llenar()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT id_Cliente FROM CLIENTES",conn);
            da.Fill(ds, "CLIENTES");
            cbCliente.DataSource = ds.Tables[0].DefaultView;
            cbCliente.ValueMember = "id_Cliente";


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            llenar();

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero;
            if(!Int32.TryParse(this.cbCliente.Text, out numero))
            {

            }
            else
            {
                try
                {
                    conn.Open();
                    int num1 = int.Parse(cbCliente.Text);
                    string seleccion;
                    seleccion = $"SELECT * FROM CLIENTES WHERE id_Cliente={num1};";
                    da1 = new SqlDataAdapter(seleccion, conn);
                    SqlParameter prm = new SqlParameter("id_Cliente", SqlDbType.Int);
                    prm.Value = num1;
                    da1.SelectCommand.Parameters.Add(prm);
                    dr1 = da1.SelectCommand.ExecuteReader();
                    while (dr1.Read())
                    {
                        lbNombreC.Visible = true;
                        lbNombreC.Text = dr1["NombreCliente"].ToString().Trim();
                    }
                    conn.Close();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
                if(dr1 !=null)
                {
                    dr1.Close();
                }
               
            }
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string insertarPedido;
                insertarPedido = "INSERT INTO PEDIDOS(id_Cliente, id_Libro, CantidadPedido, FechaPedido, Precio)";
                insertarPedido += "VALUES (@id_Cliente, @libro, @CantidadPedido, @FechaPedido, @precio)";
                insert1 = new SqlCommand(insertarPedido, conn);
                insert1.Parameters.Add(new SqlParameter("@id_Cliente", SqlDbType.Int));
                insert1.Parameters["@id_Cliente"].Value = cbCliente.Text;
                insert1.Parameters.Add(new SqlParameter("@libro", SqlDbType.Int));
                insert1.Parameters["@libro"].Value = lbIDlibro.Text;
                insert1.Parameters.Add(new SqlParameter("@CantidadPedido", SqlDbType.Int));
                insert1.Parameters["@CantidadPedido"].Value = nUDcant.Value;
                insert1.Parameters.Add(new SqlParameter("@FechaPedido", SqlDbType.VarChar, 200));
                insert1.Parameters["@FechaPedido"].Value = dtime1.Text;
                insert1.Parameters.Add(new SqlParameter("@precio", SqlDbType.Decimal));
                insert1.Parameters["@precio"].Value = lbPrecioP.Text;

                insert1.ExecuteNonQuery();
                MessageBox.Show("Registro agregado...", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"El registro no fue agregado...{error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            cbCliente.Text = "";
            nUDcant.Value = 1;
            dtime1.Text = "";
            lbNombreC.Text = "";
            lbLibrosP.Text = "";
            lbIDlibro.Text = "";
            lbPrecioP.Text = "";
        }

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1();
            formu1.Show();
            this.Hide();
        }

        private void nUDcant_ValueChanged(object sender, EventArgs e)
        {
            decimal nuevoprecio, precioriginal;
            precioriginal = Convert.ToDecimal(lbPrecioP.Text);
            nuevoprecio = nUDcant.Value * precioriginal;
            lbPrecioP.Text = nuevoprecio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string borrar;
            borrar = $"DELETE FROM PEDIDOS WHERE id_Cliente={cbCliente.Text} AND id_Libro={lbIDlibro.Text} AND CantidadPedido={nUDcant.Value};";
            SqlCommand delete = new SqlCommand(borrar, conn);

            conn.Open();
            delete.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("El registro fue borrado");
            Reset();
        }
        private void Reset ()
        {
            cbCliente.Text = "";
            nUDcant.Text = "1";
            lbNombreC.Text = "";
            lbIDlibro.Text = "";
            lbLibrosP.Text = "";
            lbPrecioP.Text = "";
        }
    }
}
