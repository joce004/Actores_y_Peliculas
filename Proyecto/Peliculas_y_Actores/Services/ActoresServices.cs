using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Aplication.Querys;
using System.Data;
using Domain;


///
/// Servicios para la entidad actores
/// Los servicios de esta aplicación son los procesos relacionados al consumo y proceso de datos sobre la base de datos del proyecto
///

namespace Services
{
    public class ActoresServices
    {
        public string ConnectionString = "Data Source=DESKTOP-8JHS4HK;Initial Catalog = Peliculas_y_Actores; Integrated Security = True"; //ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString;
        public SqlConnection conn;
        public ActoresServices() { }

        public DataTable Get(string Query)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            var DA = new SqlDataAdapter(Query, conn);


            DataTable DT = new DataTable();
            DA.Fill(DT);

            conn.Close();

            return DT;
        }

        public DataTable Filter(string query, string Criterio, string busqueda)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            var Query = String.Format(Querys.SELECT_PELICULA_F, Criterio, busqueda);

            var DA = new SqlDataAdapter(Query, conn);


            DataTable DT = new DataTable();
            DA.Fill(DT);

            conn.Close();

            return DT;
        }

        public void InsertActor(Actor actor, string query)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            var Query = String.Format(query, actor.Nombre, actor.Sexo, actor.Fecha_Nacimiento.ToString("yyyy-MM-dd"), actor.Foto);

            SqlCommand Insert = new SqlCommand(Query, conn);
            Insert.ExecuteNonQuery();

            conn.Close();
        }

        public void UpdateActor(Actor actor, string query, string subject)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            var Query = String.Format(query, actor.Nombre, actor.Sexo, actor.Fecha_Nacimiento.ToString("yyyy-MM-dd"), actor.Foto, subject);

            SqlCommand Insert = new SqlCommand(Query, conn);
            Insert.ExecuteNonQuery();

            conn.Close();
        }


        public void Delete(string subject, string query)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            var Query = String.Format(query, subject);

            SqlCommand Delete = new SqlCommand(Query, conn);
            Delete.ExecuteNonQuery();

            conn.Close();
        }
    }
}
