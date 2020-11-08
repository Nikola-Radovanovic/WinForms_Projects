using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KlijentiMiddleLayer
{
    public class ClsDataAccess
    {
        private readonly SqlConnection Cn = new SqlConnection();
        private readonly DataSet Ds = new DataSet();
        private readonly SqlDataAdapter Da = new SqlDataAdapter();
        private readonly SqlCommand Cm = new SqlCommand();

        public ClsDataAccess()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Konekcija"].ConnectionString;
            Cn.ConnectionString = connectionString;
        }

        private void OtvoriKonekciju()
        {
            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            Cm.ExecuteNonQuery();
        }

        //SELECT
        public DataTable Dbo_KlijentiRead()
        {
            Cm.Connection = Cn;
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.CommandText = "dbo.KlijentiRead";
            Da.SelectCommand = Cm;

            try
            {
                //OtvoriKonekciju();
                Ds.Tables.Clear();
                Da.Fill(Ds);
                //Cn.Close();

                return Ds.Tables[0];
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message); 
            }
        }

        //CLEAR
        public DataTable Clear()
        {
            try
            {
                Ds.Tables.Clear();
                return Ds.Tables["dbo.Klijenti"];
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        //INSERT
        public int Dbo_KlijentiInsert(string Naziv, string Kontakt, string Grad, string Zemlja)
        {
            int RetVal;

            Cm.Connection = Cn;
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.CommandText = "dbo.KlijentiInsert";
            Da.InsertCommand = Cm;

            try
            {   
                Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4,
                    ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null));
                Cm.Parameters.AddWithValue("@Naziv", Naziv);
                Cm.Parameters.AddWithValue("@Kontakt", Kontakt);
                Cm.Parameters.AddWithValue("@Grad", Grad);
                Cm.Parameters.AddWithValue("@Zemlja", Zemlja);

                OtvoriKonekciju();
                RetVal = (int)Cm.Parameters["@RETURN_VALUE"].Value;
                Cn.Close();

                return RetVal;
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        //UPDATE
        public int Dbo_KlijentiUpdate(int KlijentId, string Naziv, string Kontakt, string Grad, string Zemlja)
        {
            int RetVal;

            Cm.Connection = Cn;
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.CommandText = "dbo.KlijentiUpdate";
            Da.UpdateCommand = Cm;

            try
            {   
                Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4,
                    ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null));
                Cm.Parameters.Add(new SqlParameter("@KlijentId", SqlDbType.Int, 4,
                  ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Original, KlijentId));
                Cm.Parameters.Add(new SqlParameter("@Naziv", SqlDbType.NVarChar, 40,
                    ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, Naziv));
                Cm.Parameters.Add(new SqlParameter("@Kontakt", SqlDbType.NVarChar, 30,
                    ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, Kontakt));
                Cm.Parameters.Add(new SqlParameter("@Grad", SqlDbType.NVarChar, 15,
                    ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, Grad));
                Cm.Parameters.Add(new SqlParameter("@Zemlja", SqlDbType.NVarChar, 15,
                    ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, Zemlja));

                OtvoriKonekciju();
                RetVal = (int)Cm.Parameters["@RETURN_VALUE"].Value;
                Cn.Close();
                
                return RetVal;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        //DELETE
        public int Dbo_KlijentiDelete(int KlijentId)
        {
            int RetVal;

            Cm.Connection = Cn;
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.CommandText = "dbo.KlijentiDelete";
            Da.DeleteCommand = Cm;

            try
            {   
                Cm.Parameters.Clear();

                Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4,
                    ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null));
                Cm.Parameters.Add(new SqlParameter("@KlijentId", SqlDbType.Int, 4,
                    ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Original, KlijentId));

                OtvoriKonekciju();
                RetVal = (int)Cm.Parameters["@RETURN_VALUE"].Value;
                Cn.Close();

                return RetVal;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
    }
}