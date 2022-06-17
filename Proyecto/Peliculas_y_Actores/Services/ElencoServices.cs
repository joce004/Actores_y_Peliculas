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
/// Servicios para la entidad relacional de actores y películas
/// Los servicios de esta aplicación son los procesos relacionados al consumo y proceso de datos sobre la base de datos del proyecto
///

namespace Services
{
    public class ElencoServices
    {
        public string ConnectionString = "Data Source=DESKTOP-8JHS4HK;Initial Catalog = Peliculas_y_Actores; Integrated Security = True"; //ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString;
        public SqlConnection conn;
        public ElencoServices() { }

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

    



        public void Modificar(string Query)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();


            SqlCommand Modificar= new SqlCommand(Query, conn);
            Modificar.ExecuteNonQuery();

            conn.Close();
        }
    }
}
