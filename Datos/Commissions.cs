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

        public List<Entidades.Commissions> GetAll()
        {

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Commissions", Conn);
                List<Entidades.Commissions> CommissionsList = new List<Entidades.Commissions>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.Commissions objCommissions = new Entidades.Commissions();
                        objCommissions.IdCommission = Convert.ToInt32(oReader["IdCommission"]);
                        objCommissions.CommissionDescription = Convert.ToString(oReader["CommissionDescription"]);
                        objCommissions.SpecialityYear = Convert.ToInt32(oReader["SpecialityYear"]);
                        objCommissions.IdPlan = Convert.ToInt32(oReader["IdPlan"]);

                        CommissionsList.Add(objCommissions);
                        objCommissions = null;
                    }
                    return CommissionsList;
                }
            }
            finally
            {
                //objCommissions = null;
                this.Disconnect();

            }
        }

        public Entidades.Commissions GetOne(int id)
        {
            Entidades.Commissions objCommissions = new Entidades.Commissions();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Commissions WHERE @IdCommission = id", Conn);
                comm.Parameters.AddWithValue("@IdCommission", id);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objCommissions.IdCommission = Convert.ToInt32(oReader["IdCommission"]);
                    objCommissions.CommissionDescription = Convert.ToString(oReader["CommissionDescription"]);
                    objCommissions.SpecialityYear = Convert.ToInt32(oReader["SpecialityYear"]);
                    objCommissions.IdPlan = Convert.ToInt32(oReader["IdPlan"]);


                    return objCommissions;

                }
            }
            finally
            {
                objCommissions = null;
            }
        }
    }
}
