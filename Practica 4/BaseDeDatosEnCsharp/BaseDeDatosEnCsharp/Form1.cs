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
                "NombreCliente varchar(40)," +
                "CONSTRAINT PK_cliente PRIMARY KEY (id_Cliente));";
            //crear la tabla pedidos
            string tPedidos = "USE DB_Avanzada;" +
                "CREATE TABLE PEDIDOS(" +
                "id_Pedido int IDENTITY(1,1)," +
                "id_Cliente int not null," +
                "id_Libro int not null,"+
                "CantidadPedido int," +
                "FechaPedido varchar(70)," +
                "Precio decimal," +
                 "CONSTRAINT PK_Pedido PRIMARY KEY(id_Pedido)," +
                 "CONSTRAINT FK_Cliente FOREIGN KEY (id_Cliente)" +
                 "REFERENCES CLIENTES (id_Cliente),"+
                 "CONSTRAINT FK_Libro FOREIGN KEY (id_Libro)" +
                 "REFERENCES LIBROS (id_Libro));";
            //crear la tabla libros
            string tLibros = "USE DB_Avanzada;" +
                "CREATE TABLE LIBROS(" +
                "id_Libro int IDENTITY(1,1)," +
                "NombreLibro varchar(70)," +
                "Autor varchar(70)," +
                "Precio float,"+
                 "CONSTRAINT PK_Libro PRIMARY KEY(id_Libro));";
            //agregando los libros a la tabla libros 
            string AddLibros = "USE DB_Avanzada;" +
                "INSERT INTO LIBROS(NombreLibro, Autor, Precio)" +
                "VALUES ('Divina comedia',  'Dante Alighieri', 28.00)," + 
"('Orgullo y prejuicio', 'Jane Austen', 22.50),"+
"('Papá Goriot', 'Honoré de Balzac', 23.50)," +
"('Decamerón', 'Giovanni Boccaccio', 22.75)," +
"('Ficciones', 'Jorge Luis Borges', 20.50)," +
"('Cumbres', 'Borrascosas Emily Brontë', 28.50)," +
"('El extranjero', 'Albert Camus', 22.00)," +
"('Poemas', 'Paul Celan', 20.00)," +
"('Viaje al fin de la noche', 'Louis - Ferdinand Céline', 23.00)," +
"('Don Quijote de la Mancha', 'Miguel de Cervantes', 24.50)," +
"('Los cuentos de Canterbury', 'Geoffrey Chaucer', 22.00)," +
"('Relatos cortos', 'Antón Chéjov', 21.50)," +
"('Nostromo', 'Joseph Conrad', 19.50)," +
"('Grandes Esperanzas', 'Charles Dickens', 18.50)," +
"('Jacques el fatalista', 'Denis Diderot', 22.25)," +
"('Berlin Alexanderplatz', 'Alfred Döblin', 16.50)," +
"('Crimen y castigo', 'Fiódor Dostoievski', 30.00)," +
"('El idiota', 'Fiódor Dostoievski', 26.00)," +
"('Los endemoniados', 'Fiódor Dostoievski', 25.50)," +
"('Los hermanos Karamazov', 'Fiódor Dostoievski', 25.00)," +
"('Middlemarch', 'George Eliot', 22.00)," +
"('El hombre invisible', 'Ralph Ellison', 21.50)," +
"('Medea', 'Eurípides', 15.50)," +
"('El ruido y la furia', 'William Faulkner', 22.75)," +
"('Madame Bovary', 'Gustave Flaubert', 18.45)," +
"('La educación sentimental', 'Gustave Flaubert', 12.00)," +
"('Romancero gitano', 'Federico García Lorca', 15.50)," +
"('Cien años de soledad', 'Gabriel García Márquez', 31.00)," +
"('El amor en los tiempos del cólera', 'Gabriel García Márquez', 28.00)," +
"('Fausto', 'Johann Wolfgang von Goethe', 20.75)," +
"('Almas muertas', 'Nikolai Gogol', 7.50)," +
"('El tambor de hojalata', 'Günter Grass', 10.00)," +
"('Gran Sertón: Veredas', 'João Guimarães Rosa', 12.50)," +
"('Hambre', 'Knut Hamsun', 19.70)," +
"('El viejo y el mar', 'Ernest Hemingway', 14.00)," +
"('Ilíada', 'Homero', 25.50);";
          SqlCommand cmd = new SqlCommand(CrearDB, cnn);
            SqlCommand cmd1 = new SqlCommand(tClientes, cnn);
            SqlCommand cmd2 = new SqlCommand(tPedidos, cnn);
            SqlCommand cmd3 = new SqlCommand(tLibros, cnn);
            SqlCommand cmd4 = new SqlCommand(AddLibros, cnn);

           try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
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

        private void btnlibros_Click(object sender, EventArgs e)
        {
            Form4 formu1 = new Form4();
            formu1.Show();
            this.Hide();
        }
    }
}
