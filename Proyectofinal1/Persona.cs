using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinal1
{
    class Persona:Datos
    {
        string cedula, nombre, telefono, email;
    }

    //public DataTable LlenarGrid(string nom)
    //{
    //    con.Open(); //abrir conexion

    //    string lineaComando = $"select Fecha, Hora, idClinicas, idPacientes, idMedicos, Causa from Proceso inner join Medicos on Medicos.id = Proceso.idMedicos where Medicos.Nombre = '{nom}'"; //comando
    //    comando = new SqlCommand(lineaComando, con); //Establecer el comando
    //    comando.ExecuteNonQuery(); //Ejecutamos el comando

    //    SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
    //    DataTable table = new DataTable();  //Creamos la tabla en Memoria

    //    data.Fill(table); //Llenamos el DataTable
    //    con.Close();

    //    return table;
    //}
}
