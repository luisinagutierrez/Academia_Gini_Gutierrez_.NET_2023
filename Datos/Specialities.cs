using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Specialities : Connection
    {
        public int Add(Entidades.Specialities item)
        {
            SqlConnection conn = new Connection.Connect();
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text; //Stored Procedure
                    comm.CommandText = "SpecialitiesAdd";

                    comm.Parameters.AddWithValue("@IdSpeciality", item.IdSpeciality);
                    comm.Parameters.AddWithValue("@SpecialityDescription", item.SpecialityDescription);
                    return comm.ExecuteNonQuery();
                }
            }
        }

        public void Update(Entidades.Specialities item)
        {
            SqlConnection conn = new Connection.Connect();
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text; //Stored Procedure
                    comm.CommandText = "SpecialitiesUpdate";

                    comm.Parameters.AddWithValue("@IdSpeciality", item.IdSpeciality);
                    comm.Parameters.AddWithValue("@SpecialityDescription", item.SpecialityDescription);
                    comm.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            SqlConnection conn = new Connection.Connect();
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                using (comm)
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text; //Stored Procedure
                    comm.CommandText = "SpecialitiesDelete";

                    comm.Parameters.AddWithValue("@IdSpeciality", id);
                    comm.ExecuteNonQuery();
                }
            }
        }
    }
}
