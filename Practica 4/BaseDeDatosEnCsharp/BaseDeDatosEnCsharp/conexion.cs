using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatosEnCsharp
{
    class conexion
    {
        public string servidor, usuario, clave, db;
        public string cadena;
        public void conec()
        {
            servidor = "localhost";
            db = "DB_Avanzada";
            usuario = "sa";
            clave = "ivania123123";
            cadena = $"server= {servidor}; uid={usuario};" +
                $"pwd={clave};database={db}";

        }
    }
}
