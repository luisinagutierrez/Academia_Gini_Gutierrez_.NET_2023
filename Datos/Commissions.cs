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
        public int Add(int IdPlan, string CommissionDescription, int SpecialityYear)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("INSERT INTO Commissions (CommissionDescription, SpecialityYear, IdPlan) VALUES (@CommissionDescription, @SpecialityYear, @IdPlan)", Conn);
                comm.Parameters.AddWithValue("@CommissionDescription", CommissionDescription);
                comm.Parameters.AddWithValue("@SpecialityYear", SpecialityYear);
                comm.Parameters.AddWithValue("@IdPlan", IdPlan);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar comision", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Update(int IdCommission, string CommissionDescription, int SpecialityYear, int IdPlan)
        {
            try
            {
                this.Connect(); 
                SqlCommand comm = new SqlCommand("UPDATE Commissions SET CommissionDescription = @CommissionDescription, SpecialityYear = @SpecialityYear, IdPlan = @IdPlan WHERE IdCommission = @IdCommission", Conn);
                comm.Parameters.AddWithValue("@IdCommission", IdCommission);
                comm.Parameters.AddWithValue("@CommissionDescription", CommissionDescription);
                comm.Parameters.AddWithValue("@SpecialityYear", SpecialityYear);
                comm.Parameters.AddWithValue("@IdPlan", IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar comision", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Delete(int IdCommission)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("DELETE Commissions WHERE IdCommission = @IdCommission", Conn);

                comm.Parameters.AddWithValue("@IdCommission", IdCommission);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar comision ", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
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
                        objCommissions.IdCommission = (int)(oReader["IdCommission"]);
                        objCommissions.CommissionDescription = (string)(oReader["CommissionDescription"]);
                        objCommissions.SpecialityYear = (int)(oReader["SpecialityYear"]);
                        objCommissions.IdPlan = (int)(oReader["IdPlan"]);

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

        public Entidades.Commissions GetOne(int IdCommission)
        {
            Entidades.Commissions objCommissions = new Entidades.Commissions();
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Commissions WHERE @IdCommission = IdCommission", Conn);
                comm.Parameters.AddWithValue("@IdCommission", IdCommission);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objCommissions.IdCommission = (int)(oReader["IdCommission"]);
                    objCommissions.CommissionDescription = (string)(oReader["CommissionDescription"]);
                    objCommissions.SpecialityYear = (int)(oReader["SpecialityYear"]);
                    objCommissions.IdPlan = (int)(oReader["IdPlan"]);


                    return objCommissions;

                }
            }
            finally
            {
                this.Disconnect();
                objCommissions = null;
            }
        }
    }
}
