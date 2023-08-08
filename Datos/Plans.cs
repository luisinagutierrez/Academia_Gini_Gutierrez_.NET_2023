using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Plans:Connection
    {
        public int Add(Entidades.Plans item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Plans (PlanDescription, IdSpeciality) VALUES (@PlanDescription, @IdSpeciality)", Conn);
                comm.Parameters.AddWithValue("@PlanDescription", item.PlanDescription);
                comm.Parameters.AddWithValue("@IdSpeciality", item.IdSpeciality);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar plan ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.Plans item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE Plans SET (PlanDescription, IdSpeciality) = (@PlanDescription, @IdSpeciality) WHERE IdPlan = @Id", Conn);
                comm.Parameters.AddWithValue("@PlanDescription", item.PlanDescription);
                comm.Parameters.AddWithValue("@IdSpeciality", item.IdSpeciality);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar plan ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Delete(int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("DELETE Plans WHERE IdPlan = @Id", Conn);

                comm.Parameters.AddWithValue("@IdPlan", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar plan ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
