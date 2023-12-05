using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appPlanilla_2023.db
{
    internal class Db
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        public Db(string _cn)
        { 
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings[_cn].ConnectionString);
        }

        internal void Sentencia(string _sql)
        {
            cmd = new SqlCommand(_sql, cn);
        }

        internal void Parametros(params object[] parametros)
        {
            cmd.Parameters.Clear();
            for(int i = 0; i < parametros.Length; i++)
            {
                cmd.CommandText += " @" + (i+1) + (i < parametros.Length - 1 ? "," : "");
                cmd.Parameters.AddWithValue("@" + ( i + 1 ), parametros[i]);
            }

        }

        internal DataSet getDataSet()
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        
        internal DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if( dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    dt.Rows[i].ItemArray = System.Array.ConvertAll(dt.Rows[i].ItemArray, x => x.ToString().Trim());
                return dt;
            }
            return null;
        }

        internal DataRow getDataRow()
        {
            DataTable dt = getDataTable();
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        internal int Ejecutar()
        {
            if (cn.State == ConnectionState.Closed) cn.Open();
            return cmd.ExecuteNonQuery();
        }

        internal void getComboBox(ComboBox cbo, string sTexto = null)
        {
            DataTable dt = getDataTable();
            if(sTexto != null)
            {
                DataRow dr = dt.NewRow();
                dr[0] = -1;
                dr[1] = sTexto;
                dt.Rows.InsertAt(dr , 0);
            }


            cbo.DataSource = dt;
            cbo.ValueMember = dt.Columns[0].ColumnName;
            cbo.DisplayMember = dt.Columns[1].ColumnName;
        }


    }
}

