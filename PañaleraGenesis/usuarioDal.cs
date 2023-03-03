using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PañaleraGenesis
{
    internal class usuarioDal
    {
       public static int CrearCuentas(string pUsuaruio, string pContrasena)
        {
           int resultado = 0;
           SqlConnection common = DBConection,
            SqlCommand  = new  = (string.Format("insert into usuarios(nombre,contraseña) values('{0}',PwdEncrypt(´{1}´))", pUsuaruio, pContrasena), conn);
            resultado = SqlCommand.ExecuteNonquery();
            common.Close();
            return resultado;

        }
         
        
    }
}
