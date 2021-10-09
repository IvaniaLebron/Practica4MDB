using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MDB_LF212591_PRACTICA4
{
    class Conexion
    {
        //parametros para la cadena conexion
        public string servidor, usuario, clave, db, cadena;
        //funcion que tendra la cadena de conexion
        public void conectar()
        {
            servidor = "DESKTOP-BPB89G7";
            db = "Practica_4_LF212591";
            usuario = "sa";
            clave = "ivania123123";
            cadena = $"server= {servidor}; uid= {usuario}; pwd= {clave}; database= {db}";
        }
    }
}
