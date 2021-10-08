using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
namespace AL_Rawateb
{
    public class Myconnection
    {
        static Myconnection MyObject;
        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommand com;
        DataSet ds;
        public Myconnection(String Str)
        {
            //----------------------------------------------------------------------------------------------------------------
            string ss = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\rwateb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //----------------------------------------------------------------------------------------------------------------
            //ss = @"Integrated Security=SSPI;Persist Security Info=False;Data "+
            //      "Source=JEMMIEH;Initial File Name=" + sfile;
            //----------------------------------------------------------------------------------------------------------------
            con = new SqlConnection(ss);
            adp = new SqlDataAdapter();

            ds = new DataSet();
        }
        public static Myconnection GetInstance(String Str)
        {
            if (MyObject == null)
            {
                MyObject = new Myconnection(Str);
            }
            return MyObject;
        }
        public int Commoand(String sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand(sql, con);
            int r = com.ExecuteNonQuery();
            con.Close();
            return r;
        }
        public ArrayList myselect(String sql)
        {
            ArrayList resfinish = new ArrayList();
            com = new SqlCommand(sql, con);
            adp.SelectCommand = com;
            adp.Fill(ds);
            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                ArrayList res = new ArrayList();
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    res.Add(ds.Tables[0].Rows[j][i]);
                }
                resfinish.Add(res);
            }
            return resfinish;
        }
        public DataTable myselect_ds(String sql)
        {
                ArrayList resfinish = new ArrayList();
                DataSet ds1 = new DataSet(); 
                com = new SqlCommand(sql, con);
                adp.SelectCommand = com;
                ds1.Clear();
                adp.Fill(ds1);
                return ds1.Tables[0];
        }
        public string getonevalue(String sql)
        {
            string d="0";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                com = new SqlCommand(sql, con);
                d = com.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception q) { return "no"; }//return q.ToString();
            return d;
        }
        public ArrayList Reader(string sql, int index)
        {
            ArrayList array1 = new ArrayList();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand(sql, con);
            SqlDataReader e = com.ExecuteReader();
            int t = 0;
            while (e.Read())
            {
                t = 1;
                array1.Add(e[index]);
            }
            if (t == 0) { con.Close(); return null; }
            con.Close();
            return array1;
        }
        //public int getmax(string sql)
        //{
        //    string sqlmax = "select max(" + sql + "_id) from " + sql;
        //    string resmax = this.getonevalue(sqlmax);
        //    if (resmax.ToString() == "")
        //    {
        //        resmax = "0";
        //    }
        //    int res = Convert.ToInt32(resmax.ToString()) + 1;
        //    return res;
        //}
    }
}
