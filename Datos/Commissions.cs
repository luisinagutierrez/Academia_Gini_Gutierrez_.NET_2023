using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Commissions : Connection { 
        public int Add(Entidades.Commissions item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Commissions (CommissionDescription, SpecialityYear, IdPlan) VALUES (@CommissionDescription, @SpecialityYear, @IdPlan)", Conn);
                comm.Parameters.AddWithValue("@CommissionDescription", item.CommissionDescription);
                comm.Parameters.AddWithValue("@SpecialityYear", item.SpecialityYear);
                comm.Parameters.AddWithValue("@IdPlan", item.IdPlan);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar comision", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.Commissions item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE Commissions SET (CommissionDescription, SpecialityYear, IdPlan) = (@CommissionDescription, @SpeacialityYear, @IdPlan) WHERE IdCommission = @Id", Conn);
                comm.Parameters.AddWithValue("@CommissionDescription", item.CommissionDescription);
                comm.Parameters.AddWithValue("@SpecialityYear", item.SpecialityYear);
                comm.Parameters.AddWithValue("@IdPlan", item.IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar especialidad", Ex);
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
                SqlCommand comm = new SqlCommand("DELETE Commissions WHERE IdCommission = @Id", Conn);

                comm.Parameters.AddWithValue("@IdCommission", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar comision ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
