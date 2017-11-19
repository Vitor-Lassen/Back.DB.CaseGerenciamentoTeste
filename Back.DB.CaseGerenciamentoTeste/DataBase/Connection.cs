using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.DataBase
{
    public class Connection
    {
        SqlConnection conSql = new SqlConnection(ConfigurationManager.ConnectionStrings["stringConDB"].ConnectionString);

        SqlTransaction transaction;

        public Dictionary<string,object> execComand(SqlCommand cmd)
        {
            Dictionary<string, object> ret = new Dictionary<string, object>();
            try
            {

                conSql.Open();
           
                transaction = conSql.BeginTransaction("SampleTransaction");
                cmd.Connection = conSql;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();

                foreach(SqlParameter param in cmd.Parameters)
                {
                    if(param.Direction == System.Data.ParameterDirection.Output)
                    {
                        ret.Add(param.ParameterName, param.Value);
                    }
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void commit()
        {
            try
            {
                transaction.Commit();
                conSql.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void rollBack()
        {
            try { 
                transaction.Rollback();
                conSql.Close();
            }
              catch (Exception ex)
            {
                throw ex;
            }
        }
        public string execQueryJson(SqlCommand cmd)
        {
            try
            {
                conSql.Open();
                cmd.Connection = conSql;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conSql.Close();
                return ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public DataSet execQuery(SqlCommand cmd)
        {
            try
            {
                conSql.Open();
                cmd.Connection = conSql;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conSql.Close();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}