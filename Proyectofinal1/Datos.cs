using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Proyectofinal1
{
    class Datos
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OFQSFIV;Initial Catalog=proyectofinal1;Integrated Security=True");
        SqlCommand comando;
        protected SqlDataReader dr;
        protected DataSet ds;

        //Insertar Pacientes en la base de datos
        public void Guardar(string ced, string nom, string tel, string email, string direc)
        {
            con.Open();
            string lineaComando = $"insert into Pacientes values('{ced}', '{nom}', '{tel}', '{email}', '{direc}')";
            comando = new SqlCommand(lineaComando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        //Insertar Medicos en la base de datos
        public void GuardarMedicos(string ced,string Exequátur, string nom, string tel, string email, string clinica)
        {
            con.Open();
            string lineaComando = $"insert into Medicos values('{ced}', '{Exequátur}', '{nom}', '{tel}', '{email}', '{clinica}')";
            comando = new SqlCommand(lineaComando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        //Insertar Clinica en la base de datos
        public void GuardarClinica(string nom, string direc)
        {
            con.Open();
            string lineaComando = $"insert into Clinicas values('{nom}', '{direc}')";
            comando = new SqlCommand(lineaComando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        //Insertar Proceso en la base de datos
        public void GuardarProceso(string fecha, string hora, string idclic, string idpac, string idmed, string causa)
        {
            con.Open();
            string lineaComando = $"insert into Proceso values ('{fecha}', '{hora}', {idclic}, {idpac}, {idmed}, '{causa}')";
            comando = new SqlCommand(lineaComando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }


        //LlenarGrid de Pacientes
        public DataTable LlenarGrid()
        {
            con.Open(); //abrir conexion

            string lineaComando = "select * from Pacientes"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }
        //LlenarGrid de Medicos
        public DataTable LlenarGridMedicos()
        {
            con.Open(); //abrir conexion

            string lineaComando = "select * from Medicos"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }

        //LlenarGridClinicas
        public DataTable LlenarGridClinicas()
        {
            con.Open(); //abrir conexion

            string lineaComando = "select * from Clinicas"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }
        //LlenarGrid de Proceso
        public DataTable LlenarGridProceso()
        {
            con.Open(); //abrir conexion

            string lineaComando = "select Proceso.id, Proceso.Fecha, Proceso.Hora, Clinicas.Nombre as 'Nombre Clinica', Pacientes.Nombre as 'Nombre Paciente', Medicos.Nombre as 'Nombre Medico', Proceso.Causa from Proceso inner join Clinicas on Clinicas.id = Proceso.idCLinicas inner join Pacientes on Pacientes.id = Proceso.idPacientes inner join Medicos on Medicos.id = Proceso.idMedicos"; //comando
            //string lineaComando = "select * from Proceso"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }

        //// Llenar datos del combobox en el Form Proceso
        public void SeleccionarCombo(ComboBox cb)
        {
            
            con.Open();
            string cmd = $"select id from Clinicas";
            comando = new SqlCommand(cmd, con);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["id"].ToString());
            }

            dr.Close();
            con.Close();
            
        }
        public void SeleccionarCombo2(ComboBox cb)
        {

            con.Open();
            string cmd = $"select id from Pacientes";
            comando = new SqlCommand(cmd, con);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["id"].ToString());
            }

            dr.Close();
            con.Close();

        }
        public void SeleccionarCombo3(ComboBox cb)
        {

            con.Open();
            string cmd = $"select id from Medicos";
            comando = new SqlCommand(cmd, con);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["id"].ToString());
            }

            dr.Close();
            con.Close();

        }

        //actualizar citas
        public void Actualizar(string fecha, string hora, string idmed, int id)
        {
            con.Open();
            string lineaComando = $" update Proceso set Fecha ='{fecha}', Hora = '{hora}', idMedicos = {idmed} where id = {id}";
            comando = new SqlCommand(lineaComando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        //Buscar pacientes por nombre
        public DataTable LlenarGridBuscarPac(string nom)
        {
            con.Open(); //abrir conexion

            string lineaComando = $" select * from Pacientes where Nombre = '{nom}'"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }
        //Buscar pacientes por correo
        public DataTable LlenarGridBuscarPacCorreo(string email)
        {
            con.Open(); //abrir conexion

            string lineaComando = $" select * from Pacientes where Email = '{email}'"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }

        //Buscar medicos por nombre
        public DataTable LlenarGridBuscarMed(string nom)
        {
            con.Open(); //abrir conexion

            string lineaComando = $" select * from Medicos where Nombre = '{nom}'"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }
        //Buscar medicos por correo
        public DataTable LlenarGridBuscarMedCorreo(string exequatur)
        {
            con.Open(); //abrir conexion

            string lineaComando = $" select * from Medicos where Exequátur = '{exequatur}'"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }

        //Buscar citas por nombre de medico
        public DataTable LlenarGridBuscarCit(string nom)
        {
            con.Open(); //abrir conexion 

            string lineaComando = $"select Fecha, Hora, idClinicas, idPacientes, idMedicos, Causa from Proceso inner join Medicos on Medicos.id = Proceso.idMedicos where Medicos.Nombre = '{nom}'"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }
        //Buscar citas por exequatur de medico
        public DataTable LlenarGridBuscarCitExe(string exequatur)
        {
            con.Open(); //abrir conexion

            string lineaComando = $"select Fecha, Hora, idClinicas, idPacientes, idMedicos, Causa from Proceso inner join Medicos on Medicos.id = Proceso.idMedicos where Medicos.Exequátur = '{exequatur}'"; //comando
            comando = new SqlCommand(lineaComando, con); //Establecer el comando
            comando.ExecuteNonQuery(); //Ejecutamos el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptamos los datos
            DataTable table = new DataTable();  //Creamos la tabla en Memoria

            data.Fill(table); //Llenamos el DataTable
            con.Close();

            return table;
        }


    }
}
